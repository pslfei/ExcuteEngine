using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using DCSType;
using Newtonsoft.Json.Linq;
using TDServer.Service;

// 独立进程回归；不构造执行引擎、不连接 MySQL、不读取现场配置。
int assertions = 0;
void Check(bool condition, string message)
{
    assertions++;
    if (!condition) throw new InvalidOperationException(message);
}
T Throws<T>(Action action, string message) where T : Exception
{
    try { action(); }
    catch (T ex) { Check(true, message); return ex; }
    throw new InvalidOperationException("未捕获预期异常：" + message);
}
LA Value(float value)
{
    var result = (LA)RuntimeHelpers.GetUninitializedObject(typeof(LA));
    result.buffer = value;
    return result;
}

await using var legacy = await FakeServer.Start();
await using var tsq = await FakeServer.Start();
var oldConfig = ExcuteEngine.configInfo;
var oldClient = InfluxDBHelp.influxDBClient;
var oldCulture = CultureInfo.CurrentCulture;
var oldTimeout = InfluxDBHelp.RequestTimeout;
var rootField = typeof(InfluxDBHelp).GetField("tsqServerRoot", BindingFlags.Static | BindingFlags.NonPublic)!;
var oldRoot = rootField.GetValue(null);
var tryQuery = typeof(InfluxDBHelp).GetMethod("TryExecuteQuery", BindingFlags.Static | BindingFlags.NonPublic)!;
const string sample = "{\"code\":0,\"msg\":\"success\",\"data\":[{\"statement_id\":0,\"series\":[{\"name\":\"test002\",\"columns\":[\"time\",\"last\"],\"values\":[[\"2026-11-05T00:48:09Z\",16]]}]}]}";
void Init(string? address)
{
    ExcuteEngine.configInfo = new ConfigInfo
    {
        TsqServerBaseUrl = address!, InfluxDBUrl = legacy.Url,
        InfluxDBToken = "local-test-token", InfluxDBName = "local-test-db",
        InfluxDBOrg = "local-test-org", InfluxDBQueryApiurl = legacy.Url + "/legacy-query"
    };
    InfluxDBHelp.InitInfluxDB(legacy.Url, "local-test-token");
}
void TsqReply(string body, int status = 200) => tsq.Replies.Enqueue(new Reply { Body = body, Status = status });
CapturedRequest Last() => tsq.Requests.Last();
void WriteOne() => InfluxDBHelp.BatchInsert(new Dictionary<string, double> { ["test002"] = 16 });

try
{
    // 配置缺失、空值及地址校验；初始化不做网络探活。
    Check(new ConfigInfo().TsqServerBaseUrl == "", "缺失配置默认旧模式");
    foreach (string? empty in new string?[] { null, "", " \t\r\n" })
    {
        Init(empty);
        Check(rootField.GetValue(null) == null && InfluxDBHelp.influxDBClient != null, "空配置创建旧客户端");
        InfluxDBHelp.influxDBClient!.Dispose();
        InfluxDBHelp.influxDBClient = null!;
    }
    Check(legacy.Requests.IsEmpty && tsq.Requests.IsEmpty, "初始化不能发送网络请求");
    foreach (string invalid in new[] { "not-a-url", "ftp://localhost", tsq.Url + "/api/Query",
        tsq.Url + "?x=1", tsq.Url + "#fragment", "http://user:pass@localhost" })
        Throws<InvalidOperationException>(() => Init(invalid), "拒绝无效非空地址");
    Init("https://localhost:5336/");
    Check(rootField.GetValue(null) is Uri https && https.Scheme == "https", "支持 HTTPS 根地址");
    Init("  " + tsq.Url + "/  ");
    Check(InfluxDBHelp.influxDBClient == null, "HTTP 模式不创建 InfluxDB 客户端");
    ExcuteEngine.configInfo.TsqServerBaseUrl = "";

    // 用户样例、大小写及现有 DTO 契约。
    TsqReply(sample);
    var data = InfluxDBHelp.ExecuteQuery("select last(pvalue) from test002");
    Check(data[0].series[0].values[0][1] == "16", "样例数值转换为原 string 值");
    Check(Last().Path == "/api/ExcuteEngine/Query" && Last().Method == "POST", "查询路径和方法");
    Check(Last().Body == "select last(pvalue) from test002" && Last().ContentType.StartsWith("text/plain"), "发送裸 SQL");
    Check(Last().Authorization == "" && legacy.Requests.IsEmpty, "HTTP 模式不发送旧 Token 或访问旧端点");
    Check(rootField.GetValue(null) != null, "初始化后的模式不跟随配置对象改动");
    TsqReply("{\"CODE\":0,\"DATA\":[{\"statement_id\":0},{\"statement_id\":1,\"series\":[{\"values\":[[\"t\",null]]}]}]}");
    data = InfluxDBHelp.ExecuteQuery("select a;select b;");
    Check(data.Count == 2 && data[0].series == null && data[1].statement_id == 1, "保留多语句顺序和无 series");
    Check(data[1].series[0].values[0][1] == null, "保留 null 值");
    Check(InfluxDBHelp.ExecuteQuery("select empty").Count == 0, "空 data 为合法无数据");
    TsqReply("{\"code\":0,\"data\":[{\"statement_id\":0},{\"error\":\"bad sql\"}]}");
    Check(Throws<InvalidOperationException>(() => InfluxDBHelp.ExecuteQuery("a;b"), "逐语句错误").Message.Contains("第 2 条"), "错误包含语句位置");
    foreach (string malformed in new[] { "not-json", "{\"data\":[]}", "{\"code\":\"0\",\"data\":[]}",
        "{\"code\":1,\"msg\":\"denied\"}", "{\"code\":0}", "{\"code\":0,\"data\":{}}", "{\"code\":0,\"data\":[null]}" })
    {
        TsqReply(malformed);
        Throws<InvalidOperationException>(() => InfluxDBHelp.ExecuteQuery("select malformed"), "拒绝错误响应");
    }
    int requestsBeforeEmpty = tsq.Requests.Count;
    Throws<ArgumentException>(() => InfluxDBHelp.ExecuteQuery(" \t"), "拒绝空 SQL");
    Check(tsq.Requests.Count == requestsBeforeEmpty, "空 SQL 不发请求");

    // 标量查询原返回约定。
    TsqReply(sample);
    Check(InfluxDBHelp.QueryAsync("ignored-db", "select value", out string msg) == 16 && msg == "", "QueryAsync 返回首值");
    Check(!Last().Query.Contains("db="), "HTTP 模式数据库由 TSQSERVER 决定");
    Check(InfluxDBHelp.QueryAsync("", "select empty", out msg) == -1 && msg != "", "无数值返回 -1 和原因");
    TsqReply(sample);
    Check(InfluxDBHelp.GetQjrhValue(DateTime.Today) == 16 && Last().Body.Contains("where ts <="), "汽机热耗保留 ts SQL");
    Check(InfluxDBHelp.GetQjrhValue(DateTime.Today) == null, "汽机热耗无数据返回 null");
    TsqReply(sample);
    Check(InfluxDBHelp.GetEletodaysum() == 16 && Last().Body.Contains("sum(pvalue)/7200")
        && Last().Body.Contains("group by time(5s)"), "当日发电量保留公式");
    Check(InfluxDBHelp.GetEletodaysum() == 0, "发电量无数据返回零");
    TsqReply("{\"code\":5,\"msg\":\"backend error\"}");
    Throws<InvalidOperationException>(() => InfluxDBHelp.GetEletodaysum(), "业务失败不能伪装成发电量零");
    TsqReply(sample);
    DateTime inputTime = new DateTime(2026, 11, 5, 8, 30, 0);
    Check(InfluxDBHelp.GetValueByTime(inputTime, "test002", out msg) == 16
        && Last().Body.Contains("2026-11-05 00:30:00"), "保留 GetValueByTime 原时间转换");
    TsqReply("{\"code\":0,\"data\":[{\"series\":[{\"values\":[[\"t\",\"NaN\"]]}]}]}");
    Check(InfluxDBHelp.QueryAsync("", "select badvalue", out msg) == -1 && msg != "", "非法数值不当成零");

    // 所有公开写入入口，复用 SDK 转义及固定小数格式。
    CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("fr-FR");
    WriteOne();
    var write = Last();
    Check(write.Method == "POST" && write.Path == "/api/ExcuteEngine/Write", "写入路由");
    Check(write.Body.StartsWith("test002 pvalue=16 ") && write.ContentType.StartsWith("text/plain"), "写入行协议而非 JSON");
    long timestamp = long.Parse(write.Body.Trim().Split(' ').Last(), CultureInfo.InvariantCulture);
    Check(Math.Abs(timestamp - DateTimeOffset.UtcNow.ToUnixTimeSeconds()) < 3, "秒级 Unix 时间戳");
    InfluxDBHelp.BatchInsert(new Dictionary<string, double> { ["点 名,abc"] = 1.25 });
    Check(Last().Body.StartsWith("点\\ 名\\,abc pvalue=1.25 "), "SDK 转义及固定小数点");
    InfluxDBHelp.BatchInsert(new Dictionary<string, Dictionary<string, object>>
    {
        ["outer-not-measurement"] = new() { ["inner-measurement"] = Value(2.5f) }
    });
    Check(Last().Body.StartsWith("inner-measurement pvalue=2.5 "), "二次点使用内层键和 LA.buffer");
    InfluxDBHelp.BatchInsert(new List<WarnRValue> { new() { WarnRTableName = "reconstruction", RValue = Value(3.5f) } });
    Check(Last().Body.StartsWith("reconstruction pvalue=3.5 "), "重构值映射");
    Check(InfluxDBHelp.BatchInsertPointValue(new List<items> { new() { item = "api-point", value = 4.5f } })
        && Last().Body.StartsWith("api-point pvalue=4.5 "), "API 点写入及 bool 成功");
    int beforeInvalid = tsq.Requests.Count;
    foreach (string name in new[] { "", " ", "#comment", "bad\nline", "bad\rline", "bad\0line" })
        Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(new Dictionary<string, double> { [name] = 1 }), "非法 measurement");
    foreach (double number in new[] { double.NaN, double.PositiveInfinity, double.NegativeInfinity })
        Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(new Dictionary<string, double> { ["bad"] = number }), "非法浮点值");
    Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(new List<WarnRValue>
        { new() { WarnRTableName = "missing", RValue = null! } }), "空重构值不能写零");
    Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(new Dictionary<string, Dictionary<string, object>>
        { ["outer"] = new() { ["inner"] = "not-la" } }), "拒绝非 LA 输入");
    Check(!InfluxDBHelp.BatchInsertPointValue(new List<items> { new() { item = "bad", value = float.NaN } }), "非法 API 值返回 false");
    InfluxDBHelp.BatchInsert(new Dictionary<string, double>());
    InfluxDBHelp.BatchInsert(new Dictionary<string, Dictionary<string, object>>());
    InfluxDBHelp.BatchInsert(new List<WarnRValue>());
    Check(InfluxDBHelp.BatchInsertPointValue(new List<items>()), "空 API 批次成功且无需请求");
    Check(tsq.Requests.Count == beforeInvalid, "无效及空批次均不发送");

    // 行数边界、预校验、拆包时间戳及部分失败不重试。
    var many = Enumerable.Range(0, 10001).ToDictionary(i => "point" + i, i => (double)i);
    int beforeMany = tsq.Requests.Count;
    InfluxDBHelp.BatchInsert(many);
    var batches = tsq.Requests.Skip(beforeMany).ToArray();
    Check(batches.Length == 2 && batches[0].Body.Count(c => c == '\n') == 10000
        && batches[1].Body.Count(c => c == '\n') == 1, "10001 行拆分为两批");
    Check(batches.SelectMany(x => x.Body.Split('\n', StringSplitOptions.RemoveEmptyEntries))
        .Select(x => x.Split(' ').Last()).Distinct().Count() == 1, "拆批不重新生成时间戳");
    int beforeExactLines = tsq.Requests.Count;
    InfluxDBHelp.BatchInsert(many.Take(10000).ToDictionary(x => x.Key, x => x.Value));
    Check(tsq.Requests.Count == beforeExactLines + 1 && Last().Body.Count(c => c == '\n') == 10000, "正好 10000 行不额外拆包");
    int suffixBytes = Encoding.UTF8.GetByteCount(" pvalue=1 " + DateTimeOffset.UtcNow.ToUnixTimeSeconds() + "\n");
    string exactName = new string('a', 1024 * 1024 - suffixBytes);
    InfluxDBHelp.BatchInsert(new Dictionary<string, double> { [exactName] = 1 });
    Check(Encoding.UTF8.GetByteCount(Last().Body) == 1024 * 1024, "正好 1 MiB 可发送");
    int beforeExactOverflow = tsq.Requests.Count;
    Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(new Dictionary<string, double>
        { [exactName + "a"] = 1 }), "超过 1 MiB 一个字节即拒绝");
    Check(tsq.Requests.Count == beforeExactOverflow, "字节越界不发请求");
    var unicode = new Dictionary<string, double>();
    for (int i = 0; i < 400; i++) unicode[new string('测', 1000) + i] = i;
    int beforeBytes = tsq.Requests.Count;
    InfluxDBHelp.BatchInsert(unicode);
    batches = tsq.Requests.Skip(beforeBytes).ToArray();
    Check(batches.Length == 2 && batches.All(x => Encoding.UTF8.GetByteCount(x.Body) <= 1024 * 1024), "按 UTF-8 字节而非字符拆批");
    int beforeOversize = tsq.Requests.Count;
    var oversize = new Dictionary<string, double> { ["valid-before-invalid"] = 1, [new string('测', 350000)] = 2 };
    Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(oversize), "单行超过 1 MiB");
    var lateInvalid = new Dictionary<string, double>(many) { ["bad-at-end"] = double.NaN };
    Throws<ArgumentException>(() => InfluxDBHelp.BatchInsert(lateInvalid), "发送前校验完整批次");
    Check(tsq.Requests.Count == beforeOversize, "晚出现非法行也不能先发送前批");
    TsqReply("{\"code\":0}");
    TsqReply("{\"code\":12,\"msg\":\"second batch failed\"}");
    int beforePartial = tsq.Requests.Count;
    Throws<InvalidOperationException>(() => InfluxDBHelp.BatchInsert(many), "后批业务失败");
    Check(tsq.Requests.Count == beforePartial + 2, "部分失败不重发前批或失败批");

    // HTTP 状态、超时和连接失败；保留原业务返回约定。
    TsqReply("{\"code\":99,\"msg\":\"unavailable\"}", 503);
    var httpError = Throws<HttpRequestException>(() => InfluxDBHelp.ExecuteQuery("select failure"), "HTTP 非成功");
    Check(httpError.Message.Contains("503") && httpError.Message.Contains("local-test-trace")
        && httpError.Message.Contains("unavailable"), "错误保留状态、跟踪标识和服务端消息");
    tsq.Replies.Enqueue(new Reply { Status = 307, Body = "{\"code\":0}", Location = tsq.Url + "/redirected-write" });
    int beforeRedirect = tsq.Requests.Count;
    Throws<HttpRequestException>(WriteOne, "重定向不能重发写入或伪装成功");
    Check(tsq.Requests.Count == beforeRedirect + 1 && Last().Path == "/api/ExcuteEngine/Write", "禁止自动重定向写请求");
    TsqReply("{}", 503);
    Check(InfluxDBHelp.GetEletodaysum() == 0, "发电量保留非成功 HTTP 回零约定");
    TsqReply("{}", 503);
    Check(!InfluxDBHelp.BatchInsertPointValue(new List<items> { new() { item = "api", value = 1 } }), "写失败返回 false");
    TsqReply("{}", 503);
    Check(InfluxDBHelp.GetQjrhValue(DateTime.Today) == null, "热耗失败返回 null");
    TsqReply("{}", 503);
    object?[] tryArgs = { "select failure", null, null };
    Check(!(bool)tryQuery.Invoke(null, tryArgs)! && ((string)tryArgs[2]!).Contains("503"), "业务适配保留 HTTP 非成功信息");
    TsqReply("{}", 503);
    Check(!ICCompareService.CreateExpertICByDt("2026-11-05 08:30:00", out string expertError)
        && expertError.Contains("503"), "专家库旁路查询失败返回 false 和原因且不访问数据库");
    TsqReply("{\"code\":0,\"data\":[{\"statement_id\":0}]}");
    Check(!ICCompareService.CreateExpertICByDt("2026-11-05 08:30:00", out expertError)
        && expertError.Contains("不完整"), "专家库无 series 保留失败分支");
    TsqReply("{\"code\":8,\"msg\":\"sql failed\"}");
    Throws<InvalidOperationException>(() => ICCompareService.CreateExpertICByDt("2026-11-05 08:30:00", out _), "专家库业务错误不伪装为空数据");
    InfluxDBHelp.RequestTimeout = TimeSpan.FromMilliseconds(100);
    foreach (var reply in new[] { new Reply { DelayHeadersMs = 800 }, new Reply { DelayBodyMs = 800 } })
    {
        tsq.Replies.Enqueue(reply);
        int beforeTimeout = tsq.Requests.Count;
        Throws<TimeoutException>(WriteOne, "发送及正文读取均有时限");
        Check(tsq.Requests.Count == beforeTimeout + 1, "超时只发送一次");
    }
    InfluxDBHelp.RequestTimeout = oldTimeout;
    Check(legacy.Requests.IsEmpty, "HTTP 所有失败路径均未回退旧接口");
    await Task.WhenAll(Enumerable.Range(0, 16).Select(_ => Task.Run(() => InfluxDBHelp.ExecuteQuery("select concurrent"))));
    Check(tsq.Requests.TakeLast(16).All(x => x.Body == "select concurrent"), "并发查询共用客户端不串请求");
    string closedUrl;
    await using (var closed = await FakeServer.Start()) closedUrl = closed.Url;
    Init(closedUrl);
    Throws<HttpRequestException>(WriteOne, "连接失败明确报告且不回退");
    Check(legacy.Requests.IsEmpty, "连接失败不访问旧接口");

    // 旧查询代理、直连 GET 和 SDK 写入在本机验证真实网络协议。
    CultureInfo.CurrentCulture = oldCulture;
    Init("");
    legacy.Replies.Enqueue(new Reply { Body = sample });
    Check(InfluxDBHelp.ExecuteQuery("select legacy")[0].series[0].values[0][1] == "16", "旧列表查询保持返回格式");
    var oldRequest = legacy.Requests.Last();
    Check(oldRequest.Path == "/legacy-query" && oldRequest.ContentType.StartsWith("application/json")
        && JObject.Parse(oldRequest.Body)["sql"]!.Value<string>() == "select legacy", "旧代理发送 JSON SQL");
    legacy.Replies.Enqueue(new Reply { Body = "{\"results\":[{\"series\":[{\"values\":[[\"t\",17]]}]}]}" });
    Check(InfluxDBHelp.QueryAsync("old-db", "select oldvalue", out msg) == 17 && msg == "", "旧直连查询数值");
    oldRequest = legacy.Requests.Last();
    Check(oldRequest.Method == "GET" && oldRequest.Path == "/query"
        && oldRequest.Query.Contains("db=old-db") && oldRequest.Query.Contains("q=")
        && oldRequest.Authorization == "Token local-test-token", "旧 GET 保留数据库与 Token");
    legacy.DefaultReply = new Reply { Status = 204, Body = "" };
    int oldWriteStart = legacy.Requests.Count;
    WriteOne();
    InfluxDBHelp.BatchInsert(new Dictionary<string, Dictionary<string, object>>
        { ["outer"] = new() { ["old-inner"] = Value(2.5f) } });
    InfluxDBHelp.BatchInsert(new List<WarnRValue> { new() { WarnRTableName = "old-r", RValue = Value(3.5f) } });
    Check(InfluxDBHelp.BatchInsertPointValue(new List<items> { new() { item = "old-api", value = 4.5f } }), "旧 API 写返回 true");
    var oldWrites = legacy.Requests.Skip(oldWriteStart).ToArray();
    Check(oldWrites.Length == 4 && oldWrites.All(x => x.Path == "/api/v2/write" && x.Query.Contains("precision=s")
        && x.Query.Contains("bucket=local-test-db") && x.Query.Contains("org=local-test-org")
        && x.Authorization == "Token local-test-token"), "四个旧写入入口保持 SDK 路由、精度、库、组织及 Token");
    Check(oldWrites[1].Body.StartsWith("old-inner pvalue=2.5 ") && oldWrites[2].Body.Contains("old-r pvalue=3.5 "), "旧二次点和重构值映射");
    legacy.DefaultReply = new Reply();
    legacy.Replies.Enqueue(new Reply { Status = 503 });
    Check(InfluxDBHelp.GetEletodaysum() == 0, "旧模式发电量 HTTP 非成功仍回零");
    legacy.Replies.Enqueue(new Reply { Body = "{\"data\":[{\"statement_id\":0}]}" });
    Check(InfluxDBHelp.GetQjrhValue(DateTime.Today) == null, "旧代理无 series 仍为 null");
    Console.WriteLine($"InfluxDBRoutingRegression：通过 {assertions} 项断言；仅使用本地模拟接口。");
}
finally
{
    if (InfluxDBHelp.influxDBClient != oldClient) InfluxDBHelp.influxDBClient?.Dispose();
    InfluxDBHelp.influxDBClient = oldClient;
    rootField.SetValue(null, oldRoot);
    ExcuteEngine.configInfo = oldConfig;
    InfluxDBHelp.RequestTimeout = oldTimeout;
    CultureInfo.CurrentCulture = oldCulture;
}
