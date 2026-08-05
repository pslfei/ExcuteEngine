using DBServer.LogServer;
using DCSType;
using InfluxDB.Client;
using InfluxDB.Client.Api.Domain;
using InfluxDB.Client.Writes;
using Newtonsoft.Json;
using PerformanceCalc;
using RestSharp;
using System.Text;

namespace TDServer.Service
{
    public class InfluxDBHelp
    {
        private static LoggerService<InfluxDBHelp> logger = new LoggerService<InfluxDBHelp>();
        public static InfluxDBClient influxDBClient = null;
        public static void InitInfluxDB(string url, string token)
        {
            influxDBClient = new InfluxDBClient(url, token);
        }

        public static double? GetQjrhValue(DateTime? dateTime)
        {
            try
            {
                string strsql = $"select last(qsr) as qsr from turbincalculator_1 where ts <= '{dateTime?.ToUTCString()}' and ts >= '{dateTime?.AddMinutes(-10).ToUTCString()}'";
                using (HttpClient httpClient = new HttpClient())
                {
                    InfluxQuery influxQuery = new InfluxQuery()
                    {
                        sql = strsql
                    };

                    var json = JsonConvert.SerializeObject(influxQuery);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(ExcuteEngine.configInfo.InfluxDBQueryApiurl, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content.ReadAsStringAsync().Result;
                        var responseMsg = JsonConvert.DeserializeObject<Response2<List<DataItem>>>(responseContent);

                        if (responseMsg.Data[0].series != null)
                        {
                            return Convert.ToDouble(responseMsg.Data[0].series[0].values[0][1]).To2d();
                        }
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static double QueryAsync(string dbName, string command, out string msg)
        {
            double r = -1;
            msg = string.Empty;
            try
            {

                using RestClient client = new(ExcuteEngine.configInfo.InfluxDBUrl + "/query");
                RestRequest restRequest = new()
                {
                    Method = Method.Get
                };

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
            msg = string.Empty;
            string t = time.AddHours(-8).ToString("yyyy-MM-dd HH:mm:ss");
            string sql = $"select last(pvalue) from {pointName} where time<='{t}'";
            // select * from TCS03_30RCAOG-B018_01 where time >= '2025-10-20 05:00:00' AND time <= '2025-10-20 06:00:00' tz('Asia/Shanghai')
            string sql1 = "select * from TCS03_30RCAOG-B018_01 where time >= '2025-10-20 05:00:00' AND time <= '2025-10-20 06:00:00'";
            return QueryAsync(ExcuteEngine.configInfo.InfluxDBName, sql, out msg);
        }


        /// <summary>
        /// 获取当日发电量
        /// </summary>
        /// <returns></returns>
        public static double GetEletodaysum()
        {
            string strsql = $"SELECT sum(pvalue)/7200  FROM (select first(pvalue) as pvalue from   dcs_ammka01ag001ce01  " +
                $" where time>='{DateTime.Today.ToUTCString()}' and  time<'{DateTime.Now.ToUTCString()}' group by time(5s) fill(previous))";

            using (HttpClient httpClient = new HttpClient())
            {
                InfluxQuery influxQuery = new InfluxQuery()
                {
                    sql = strsql
                };

                var json = JsonConvert.SerializeObject(influxQuery);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = httpClient.PostAsync(ExcuteEngine.configInfo.InfluxDBQueryApiurl, content).Result;
                if (response.IsSuccessStatusCode)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    var responseMsg = JsonConvert.DeserializeObject<Response2<List<DataItem>>>(responseContent);

                    if (responseMsg.Data[0].series != null)
                    {
                        return Convert.ToDouble(responseMsg.Data[0].series[0].values[0][1]).To2d();
                    }
                    else
                    {
                        return 0;
                    }
                }
                else
                {
                    return 0;
                }
            }
        }

        //public static void BatchInsert(Dictionary<string, double> dict)
        //{
        //    return;
        //    using (var writeApi = influxDBClient.GetWriteApi())
        //    {
        //        var points = dict.Select(item =>
        //                PointData.Measurement(item.Key)
        //                  .Field("pvalue", item.Value)
        //                  .Timestamp(DateTime.Now, WritePrecision.S)).ToList();

        //        writeApi.WritePoints(points, ExcuteEngine.configInfo.InfluxDBName, "ifnk");
        //    }
        //}

        public static void BatchInsert(Dictionary<string, double> values)
        {
            //return;
            var writeApi = influxDBClient.GetWriteApiAsync();
            List<PointData> pointDatas = new();

            foreach (var field in values)
            {

                var point = PointData.Measurement(field.Key).Timestamp(DateTime.Now, WritePrecision.S).Field("pvalue", field.Value);
                pointDatas.Add(point);

            }

            //var rs = Newtonsoft.Json.JsonConvert.SerializeObject(ps);

            var result = writeApi.WritePointsAsyncWithIRestResponse(pointDatas, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg).GetAwaiter().GetResult();
            var failed = (from item in result where !item.IsSuccessful select item).ToList();

            return;
        }

        /// <summary>
        /// 插入性能计算二次点
        /// </summary>
        /// <param name="secondaryCalculationPinList"></param>
        public static void BatchInsert(Dictionary<string, Dictionary<string, object>> secondaryCalculationPinList)
        {
            //return;
            if (secondaryCalculationPinList.Count > 0)
            {

                var writeApi = influxDBClient.GetWriteApiAsync();
                //if (!ExcuteEngine.oldPowerUnitStop && ExcuteEngine.powerUnitStop)//停机
                {
                    //List<string> ps = [];
                    List<PointData> pointDatas = new();
                    foreach (var item in secondaryCalculationPinList.Values)
                    {
                        foreach (var field in item)
                        {

                            var point = PointData.Measurement(field.Key).Timestamp(DateTime.Now, WritePrecision.S).Field("pvalue", ((LA)field.Value).buffer);
                            pointDatas.Add(point);

                        }

                    }

                    //var rs = Newtonsoft.Json.JsonConvert.SerializeObject(ps);

                    var result = writeApi.WritePointsAsyncWithIRestResponse(pointDatas, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg).GetAwaiter().GetResult();
                    var failed = (from item in result where !item.IsSuccessful select item).ToList();
                    return;
                    //if (failed.Count > 0)
                    //{
                    //    response.Message = failed[0].ErrorMessage;
                    //    response.Code = 500;
                    //}


                    //writeApi.WritePoints(pointDatas, "iotsharp-bucket", "iotsharp");
                    // 将数据点写入到InfluxDB
                    //writeApi.WritePointsWithIRestResponse(pointDatas, ExcuteEngine.configInfo.InfluxDBName, "ifnk");
                }


                if (!ExcuteEngine.powerUnitStop)
                {
                    float glxl = 0f;
                    float qjrh = 0f;
                    List<PointData> pointDatas = new List<PointData>();
                    foreach (var item in secondaryCalculationPinList)
                    {
                        if (item.Key == "boilerCalculator_1")
                        {
                            float e = ((LA)item.Value["e"]).buffer;
                            glxl = e;
                            if (e < 0.91)
                            {
                                logger.ErrorLog($"锅炉性能计算的锅炉效率值为【{e}】，小于0.91不存储。");
                                continue;
                            }
                        }

                        if (item.Key == "turbinCalculator_1")
                        {
                            float qsr = ((LA)item.Value["qsr"]).buffer;
                            qjrh = qsr;
                            if (qsr < 6800)
                            {
                                logger.ErrorLog($"汽机性能计算的汽机热耗值为【{qsr}】，小于6800不存储。");
                                continue;
                            }
                        }

                        var point = PointData.Measurement(item.Key.ToTableName()).Timestamp(DateTime.Now, WritePrecision.S);
                        foreach (var field in item.Value)
                        {
                            point = point.Field(field.Key, ((LA)field.Value).buffer);
                        }

                        pointDatas.Add(point);
                        // 将数据点写入到InfluxDB
                        //writeApi.WritePoints(pointDatas, ExcuteEngine.configInfo.InfluxDBName, "ifnk");
                    }
                    if (ICCompareService.standard != null)
                    {
                        if (ICCompareService.standard.qjrh.HasValue && ICCompareService.standard.glxl.HasValue)
                        {
                            double qjrhhc = PCalc.ComputeQsr(glxl, qjrh, ICCompareService.standard.qjrh.Value).To2d();//实际锅炉效率，实际汽机热耗，标杆锅炉效率
                            double glxlhc = PCalc.ComputeEb(glxl, ICCompareService.standard.glxl.Value, qjrh).To2d();//实际锅炉效率，标杆锅炉效率，实际汽机热耗
                            double zhhc = (qjrhhc + glxlhc).To2d();
                            Dictionary<string, double> zhhcdic = new();
                            zhhcdic.Add("zhhc", zhhc);
                            BatchInsert(zhhcdic);
                        }
                    }
                }
            }
        }


        /// <summary>
        /// 插入预警重构值
        /// </summary>
        /// <param name="warnRValues"></param>
        public static void BatchInsert(List<WarnRValue> warnRValues)
        {
            try
            {
                //// 这样序列化出来的 JSON 结构和 Dictionary 完全一样
                //var list = warnRValues.Select(warn => new
                //{
                //    warn.WarnRTableName,
                //    RValue = warn.RValue?.buffer
                //});
                //logger.InfoLog($"插入预警重构值：{JsonConvert.SerializeObject(list)}");
                //return;

                if (warnRValues.Count > 0)
                {
                    using (var writeApi = influxDBClient.GetWriteApi())
                    {
                        var points = warnRValues.Select(x =>
                                PointData.Measurement(x.WarnRTableName)
                                  .Field("pvalue", x.RValue?.buffer)
                                  .Timestamp(DateTime.Now, WritePrecision.S)).ToList();
                        //logger.InfoLog($"插入预警重构值：{JsonConvert.SerializeObject(points)}");
                        writeApi.WritePoints(points, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg);

                    }
                }


                //using (var writeApi = influxDBClient.GetWriteApi())
                //{
                //    var points = new List<PointData>();

                //    foreach (var x in warnRValues)
                //    {
                //        string tableName = x.WarnRTableName;

                //        // 判定条件：如果是特定表名，打印日志并跳过 (continue)
                //        if (tableName == "d1_10had40ct_r")
                //        {
                //            logger.InfoLog($"拦截写入：检测到表名 {tableName}，执行跳过逻辑。内容: {x.RValue?.buffer}");
                //            continue;
                //        }

                //        // 正常转换逻辑
                //        var key = "pvalue";
                //        var value = x.RValue?.buffer;

                //        var point = PointData.Measurement(tableName)
                //                      .Field(key, value)
                //                      .Timestamp(DateTime.Now, WritePrecision.S);

                //        points.Add(point);
                //    }

                //    if (points.Count > 0)
                //    {
                //        writeApi.WritePoints(points, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg);
                //    }
                //}
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"插入预警重构值失败：{ex.Message}");
                throw;
            }
        }


        public static bool BatchInsertPointValue(List<items> items)
        {
            try
            {
                if (items.Count > 0)
                {
                    using (var writeApi = influxDBClient.GetWriteApi())
                    {
                        var points = items.Select(x =>
                                PointData.Measurement(x.item)
                                  .Field("pvalue", x.value)
                                  .Timestamp(DateTime.Now, WritePrecision.S)).ToList();
                        writeApi.WritePoints(points, ExcuteEngine.configInfo.InfluxDBName, ExcuteEngine.configInfo.InfluxDBOrg);

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
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
