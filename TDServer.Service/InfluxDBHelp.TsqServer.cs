using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Writes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Text;

namespace TDServer.Service
{
    public partial class InfluxDBHelp
    {
        private static readonly HttpClient httpClient = new HttpClient(new HttpClientHandler { AllowAutoRedirect = false })
        {
            Timeout = Timeout.InfiniteTimeSpan
        };
        private static Uri? tsqServerRoot;
        private const int MaxWriteBytes = 1024 * 1024;
        private const int MaxWriteLines = 10000;

        /// <summary>单次 TSQSERVER 调用的时限，包含响应正文读取；不触发自动重试。</summary>
        public static TimeSpan RequestTimeout { get; set; } = TimeSpan.FromSeconds(30);

        /// <summary>按初始化时的配置固定访问模式，不在每次读写时重新读取文件。</summary>
        private static Uri? GetTsqServerRoot(string? address)
        {
            if (string.IsNullOrWhiteSpace(address)) return null;
            Uri? root;
            if (!Uri.TryCreate(address.Trim().TrimEnd('/') + "/", UriKind.Absolute, out root)
                || (root.Scheme != Uri.UriSchemeHttp && root.Scheme != Uri.UriSchemeHttps)
                || root.AbsolutePath != "/" || !string.IsNullOrEmpty(root.Query)
                || !string.IsNullOrEmpty(root.Fragment) || !string.IsNullOrEmpty(root.UserInfo))
            {
                throw new InvalidOperationException("TsqServerBaseUrl 必须为 HTTP/HTTPS 根地址，不能带接口路径、查询参数或身份信息。");
            }
            return root;
        }

        /// <summary>统一返回旧 DataItem 结构；旧模式仍使用原 JSON 查询代理。</summary>
        public static List<DataItem> ExecuteQuery(string sql)
        {
            if (string.IsNullOrWhiteSpace(sql)) throw new ArgumentException("查询 SQL 不能为空。", nameof(sql));
            if (tsqServerRoot == null)
            {
                return ExecuteLegacyQueryAsync(sql).GetAwaiter().GetResult();
            }

            JObject response = SendTextAsync("Query", sql).GetAwaiter().GetResult();
            JArray? data = response.GetValue("data", StringComparison.OrdinalIgnoreCase) as JArray;
            if (data == null) throw new InvalidOperationException("TSQSERVER 查询响应缺少 data 数组。");
            for (int i = 0; i < data.Count; i++)
            {
                JObject? item = data[i] as JObject;
                if (item == null) throw new InvalidOperationException($"第 {i + 1} 条查询结果不是对象。");
                JToken? error = item.GetValue("error", StringComparison.OrdinalIgnoreCase);
                if (error != null) throw new InvalidOperationException($"第 {i + 1} 条查询失败：{error}");
            }
            return data.ToObject<List<DataItem>>()
                ?? throw new InvalidOperationException("TSQSERVER 查询结果无法转换为 DataItem 列表。");
        }

        /// <summary>仅把 HTTP 非成功状态交回原业务分支，其他错误继续抛出，避免伪装为空数据。</summary>
        internal static bool TryExecuteQuery(string sql, out List<DataItem> data, out string error)
        {
            try
            {
                data = ExecuteQuery(sql);
                error = string.Empty;
                return true;
            }
            catch (HttpRequestException ex) when (ex.StatusCode.HasValue)
            {
                data = new List<DataItem>();
                error = ex.Message;
                logger.ErrorLog(error);
                return false;
            }
        }

        /// <summary>保留旧代理的 JSON 请求、原超时及 DataItem 返回契约。</summary>
        private static async Task<List<DataItem>> ExecuteLegacyQueryAsync(string sql)
        {
            using (HttpClient client = new HttpClient())
            using (StringContent content = new StringContent(
                JsonConvert.SerializeObject(new InfluxQuery { sql = sql }), Encoding.UTF8, "application/json"))
            using (HttpResponseMessage response = await client.PostAsync(
                ExcuteEngine.configInfo.InfluxDBQueryApiurl, content).ConfigureAwait(false))
            {
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                Response2<List<DataItem>>? result = JsonConvert.DeserializeObject<Response2<List<DataItem>>>(body);
                return result?.Data ?? throw new InvalidOperationException("原时序查询接口缺少查询结果。");
            }
        }

        /// <summary>保留无数据与零值的区别，按固定小数格式读取第一个结果值。</summary>
        private static double? ReadFirstNumber(List<DataItem> results)
        {
            SeriesItem? series = results.FirstOrDefault()?.series?.FirstOrDefault();
            List<string>? row = series?.values?.FirstOrDefault();
            if (row == null || row.Count < 2 || string.IsNullOrWhiteSpace(row[1])) return null;
            double number;
            if (!double.TryParse(row[1], NumberStyles.Float, CultureInfo.InvariantCulture, out number)
                || !double.IsFinite(number))
            {
                throw new InvalidOperationException("查询返回的第一个值不是有效数值。");
            }
            return number;
        }

        /// <summary>冻结并校验整个批次，复用 SDK 行协议序列化，所有分包使用同一秒级采样时间。</summary>
        private static void WriteTsqPoints(IEnumerable<KeyValuePair<string, double>> values)
        {
            DateTime timestamp = DateTime.Now;
            List<string> lines = new List<string>();
            foreach (KeyValuePair<string, double> point in values)
            {
                if (string.IsNullOrWhiteSpace(point.Key) || point.Key.StartsWith("#", StringComparison.Ordinal)
                    || point.Key.Any(char.IsControl))
                {
                    throw new ArgumentException("Measurement 不能为空、以 # 开头或包含控制字符。");
                }
                if (!double.IsFinite(point.Value)) throw new ArgumentException($"测点 {point.Key} 的值不是有限数值。");
                string line = PointData.Measurement(point.Key).Field("pvalue", point.Value)
                    .Timestamp(timestamp, WritePrecision.S).ToLineProtocol();
                if (Encoding.UTF8.GetByteCount(line) + 1 > MaxWriteBytes)
                    throw new ArgumentException("单行写入数据超过 TSQSERVER 的 1 MiB 限制。");
                lines.Add(line);
            }

            StringBuilder batch = new StringBuilder();
            int bytes = 0;
            int count = 0;
            foreach (string line in lines)
            {
                int lineBytes = Encoding.UTF8.GetByteCount(line) + 1;
                if (count > 0 && (count == MaxWriteLines || bytes + lineBytes > MaxWriteBytes))
                {
                    SendWriteBatch(batch.ToString());
                    batch.Clear();
                    bytes = 0;
                    count = 0;
                }
                batch.Append(line).Append('\n');
                bytes += lineBytes;
                count++;
            }
            if (count > 0) SendWriteBatch(batch.ToString());
        }

        /// <summary>发送已经固定时间戳的写入正文；不重试，也不回退到原数据库。</summary>
        private static void SendWriteBatch(string text)
        {
            SendTextAsync("Write", text).GetAwaiter().GetResult();
        }

        /// <summary>发送裸文本并校验 HTTP 和业务状态，单次时限同时覆盖发送及读取。</summary>
        private static async Task<JObject> SendTextAsync(string action, string text)
        {
            if (string.IsNullOrWhiteSpace(text)) throw new ArgumentException("查询或写入内容不能为空。");
            Uri root = tsqServerRoot ?? throw new InvalidOperationException("TSQSERVER 尚未初始化。");
            using (CancellationTokenSource timeout = new CancellationTokenSource(RequestTimeout))
            using (StringContent content = new StringContent(text, Encoding.UTF8, "text/plain"))
            {
                try
                {
                    using (HttpRequestMessage request = new HttpRequestMessage(
                        HttpMethod.Post, new Uri(root, "api/ExcuteEngine/" + action)))
                    {
                        request.Content = content;
                        using (HttpResponseMessage response = await httpClient.SendAsync(request,
                            HttpCompletionOption.ResponseHeadersRead, timeout.Token).ConfigureAwait(false))
                        {
                            string body = await response.Content.ReadAsStringAsync(timeout.Token).ConfigureAwait(false);
                            string trace = response.Headers.TryGetValues("X-Request-Id", out var ids)
                                ? string.Join(",", ids) : "无";
                            JObject? json = null;
                            try { json = JObject.Parse(body); }
                            catch (JsonException) { /* 非 JSON 响应交由统一协议错误报告，不输出整个正文。 */ }
                            JToken? code = json?.GetValue("code", StringComparison.OrdinalIgnoreCase);
                            string message = json?.GetValue("msg", StringComparison.OrdinalIgnoreCase)?.ToString()
                                ?? "响应不是有效的业务 JSON。";
                            string error = $"TSQSERVER {action} 失败，HTTP {(int)response.StatusCode}，跟踪标识 {trace}：{message}";
                            if (!response.IsSuccessStatusCode)
                                throw new HttpRequestException(error, null, response.StatusCode);
                            if (code?.Type != JTokenType.Integer || code.Value<long>() != 0)
                                throw new InvalidOperationException(error + "（要求 code 为整数 0）");
                            return json!;
                        }
                    }
                }
                catch (OperationCanceledException ex)
                {
                    throw new TimeoutException($"TSQSERVER {action} 请求超时；写入结果可能不确定，本次未自动重试。", ex);
                }
                catch (HttpRequestException ex) when (!ex.StatusCode.HasValue)
                {
                    throw new HttpRequestException($"TSQSERVER {action} 连接或响应读取失败；写入结果可能不确定，本次未自动重试。", ex);
                }
            }
        }
    }
}
