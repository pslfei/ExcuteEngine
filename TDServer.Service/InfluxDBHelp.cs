using DBServer.LogServer;
using DCSType;
using InfluxDB.Client;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Writes;
using Newtonsoft.Json;
using RestSharp;

namespace TDServer.Service
{
    public partial class InfluxDBHelp
    {
        private static LoggerService<InfluxDBHelp> logger = new LoggerService<InfluxDBHelp>();
        public static InfluxDBClient influxDBClient = null!;

        /// <summary>按启动配置固定访问方式；HTTP 模式不创建直连数据库客户端。</summary>
        public static void InitInfluxDB(string url, string token)
        {
            Uri? root = GetTsqServerRoot(ExcuteEngine.configInfo?.TsqServerBaseUrl);
            if (root != null)
            {
                tsqServerRoot = root;
                logger.InfoLog("时序数据读写使用 TSQSERVER：" + root);
                return;
            }
            influxDBClient = new InfluxDBClient(url, token);
            tsqServerRoot = null;
            logger.InfoLog("时序数据读写沿用原 InfluxDB 访问方式。");
        }

        public static double? GetQjrhValue(DateTime? dateTime)
        {
            try
            {
                string sql = $"select last(qsr) as qsr from turbincalculator_1 where ts <= '{dateTime?.ToUTCString()}' and ts >= '{dateTime?.AddMinutes(-10).ToUTCString()}'";
                List<DataItem> data = ExecuteQuery(sql);
                return ReadFirstNumber(data)?.To2d();
            }
            catch (Exception ex)
            {
                logger.ErrorLog("获取汽机热耗失败：" + ex.Message);
                return null;
            }
        }

        public static double QueryAsync(string dbName, string command, out string msg)
        {
            double r = -1;
            msg = string.Empty;
            try
            {
                if (tsqServerRoot != null)
                {
                    return ReadFirstNumber(ExecuteQuery(command))
                        ?? throw new InvalidOperationException("查询没有返回有效数值。");
                }
                using RestClient client = new(ExcuteEngine.configInfo.InfluxDBUrl + "/query");
                RestRequest restRequest = new() { Method = Method.Get };
                restRequest.AddHeader("Authorization", "Token " + ExcuteEngine.configInfo.InfluxDBToken);
                restRequest.AddParameter("db", dbName);
                restRequest.AddParameter("q", string.Join(';', command));
                var rr = client.ExecuteAsync(restRequest).Result;
                var results = JsonConvert.DeserializeObject<InfluxDBResponseModel>(rr.Content ?? string.Empty);
                r = Convert.ToDouble(results?.Results[0].Series[0].Values[0][1]);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
            return r;
        }

        public static double GetValueByTime(DateTime time, string pointName, out string msg)
        {
            string t = time.AddHours(-8).ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"select last(pvalue) from {pointName} where time<='{t}'";
            return QueryAsync(ExcuteEngine.configInfo.InfluxDBName, sql, out msg);
        }

        /// <summary>获取当日发电量，保留原累计公式及 HTTP 非成功时返回零的约定。</summary>
        public static double GetEletodaysum()
        {
            string sql = $"SELECT sum(pvalue)/7200  FROM (select first(pvalue) as pvalue from   dcs_ammka01ag001ce01  " +
                $" where time>='{DateTime.Today.ToUTCString()}' and  time<'{DateTime.Now.ToUTCString()}' group by time(5s) fill(previous))";
            List<DataItem> data;
            string error;
            if (!TryExecuteQuery(sql, out data, out error)) return 0;
            return ReadFirstNumber(data)?.To2d() ?? 0;
        }

        public static void BatchInsert(Dictionary<string, double> values)
        {
            if (tsqServerRoot != null)
            {
                WriteTsqPoints(values);
                return;
            }
            var writeApi = influxDBClient.GetWriteApiAsync();
            List<PointData> pointDatas = new();
            foreach (var field in values)
            {
                pointDatas.Add(PointData.Measurement(field.Key).Timestamp(DateTime.Now, WritePrecision.S)
                    .Field("pvalue", field.Value));
            }
            var result = writeApi.WritePointsAsyncWithIRestResponse(pointDatas,
                ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg).GetAwaiter().GetResult();
            var failed = (from item in result where !item.IsSuccessful select item).ToList();
        }

        /// <summary>插入性能计算二次点，保持当前有效分支的内层测点名和 pvalue 映射。</summary>
        public static void BatchInsert(Dictionary<string, Dictionary<string, object>> secondaryCalculationPinList)
        {
            if (tsqServerRoot != null)
            {
                List<KeyValuePair<string, double>> values = new List<KeyValuePair<string, double>>();
                foreach (var group in secondaryCalculationPinList.Values)
                {
                    foreach (var field in group)
                    {
                        LA? value = field.Value as LA;
                        if (ReferenceEquals(value, null)) throw new ArgumentException($"测点 {field.Key} 的值不是 LA，不能写入。");
                        values.Add(new KeyValuePair<string, double>(field.Key, value.buffer));
                    }
                }
                WriteTsqPoints(values);
                return;
            }
            if (secondaryCalculationPinList.Count == 0) return;
            var writeApi = influxDBClient.GetWriteApiAsync();
            List<PointData> pointDatas = new();
            foreach (var group in secondaryCalculationPinList.Values)
            {
                foreach (var field in group)
                {
                    pointDatas.Add(PointData.Measurement(field.Key).Timestamp(DateTime.Now, WritePrecision.S)
                        .Field("pvalue", ((LA)field.Value).buffer));
                }
            }
            var result = writeApi.WritePointsAsyncWithIRestResponse(pointDatas,
                ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg).GetAwaiter().GetResult();
            var failed = (from item in result where !item.IsSuccessful select item).ToList();
        }

        /// <summary>插入预警重构值；HTTP 分支拒绝空重构值，避免将缺失数据写成零。</summary>
        public static void BatchInsert(List<WarnRValue> warnRValues)
        {
            try
            {
                if (tsqServerRoot != null)
                {
                    List<KeyValuePair<string, double>> values = new List<KeyValuePair<string, double>>();
                    foreach (WarnRValue item in warnRValues)
                    {
                        if (item == null || ReferenceEquals(item.RValue, null))
                            throw new ArgumentException("重构值包含空对象，不能写入。");
                        values.Add(new KeyValuePair<string, double>(item.WarnRTableName, item.RValue.buffer));
                    }
                    WriteTsqPoints(values);
                    return;
                }
                if (warnRValues.Count > 0)
                {
                    using (var writeApi = influxDBClient.GetWriteApi())
                    {
                        var points = warnRValues.Select(x => PointData.Measurement(x.WarnRTableName)
                            .Field("pvalue", x.RValue?.buffer).Timestamp(DateTime.Now, WritePrecision.S)).ToList();
                        writeApi.WritePoints(points, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog("插入预警重构值失败：" + ex.Message);
                throw;
            }
        }

        public static bool BatchInsertPointValue(List<items> items)
        {
            try
            {
                if (tsqServerRoot != null)
                {
                    List<KeyValuePair<string, double>> values = new List<KeyValuePair<string, double>>();
                    foreach (items item in items)
                        values.Add(new KeyValuePair<string, double>(item.item, item.value));
                    WriteTsqPoints(values);
                    return true;
                }
                if (items.Count > 0)
                {
                    using (var writeApi = influxDBClient.GetWriteApi())
                    {
                        var points = items.Select(x => PointData.Measurement(x.item)
                            .Field("pvalue", x.value).Timestamp(DateTime.Now, WritePrecision.S)).ToList();
                        writeApi.WritePoints(points, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog("批量写入点值失败：" + ex.Message);
                return false;
            }
        }
    }

    public class InfluxQuery
    {
        public string sql { get; set; }
    }


    //如果好用，请收藏地址，帮忙分享。
    public class SeriesItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> columns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> values { get; set; }
    }

    public class DataItem
    {
        /// <summary>
        /// 
        /// </summary>
        public List<SeriesItem> series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int statement_id { get; set; }
    }

    public class LastValue
    {
        /// <summary>
        /// 
        /// </summary>
        public double? value { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string tag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string dateTime { get; set; }
    }

    public class Response2<T>
    {
        /// <summary>
        /// 
        /// </summary>
        public int Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// 成功
        /// </summary>
        public string Msg { get; set; }
    }
}
