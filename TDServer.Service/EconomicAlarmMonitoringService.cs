using DBServer.LogServer;
using DCSType;
using EngineCore;
using EngineCore.Models;
using Newtonsoft.Json;
using PerformanceCalc;
using StackExchange.Redis;
using System.Collections.Concurrent;
using System.Text;
using static TDServer.Service.ExcuteEngine;

namespace TDServer.Service
{
    public class EconomicAlarmMonitoringService
    {
        public static readonly object economiccfgListLock = new();
        public static readonly object economichistorycfgLock = new();
        private static Dictionary<string, double> targetValueDict = new();
        private static readonly HttpClient lsqrHttpClient = new();
        private static LoggerService<EconomicAlarmMonitoringService> logger = new LoggerService<EconomicAlarmMonitoringService>();
        public static List<economiccfg> economiccfgList = new List<economiccfg>();

        public static bool IsSteadyState = false;

        public static async Task Start()
        {
            if (!ExcuteEngine.configInfo.enableEconomicAlarmMonitoring) return;
            logger.InfoLog("能效预警功能已开启！");

            Task.Run(async () =>
            {
                try
                {
                    // 1. 初始化连接（StackExchange.Redis 底层自带断线重连，初始化一次即可）
                    var _redisConnection = await ConnectionMultiplexer.ConnectAsync(ExcuteEngine.configInfo.economicConfig.redisConnectionString);
                    var _redisDb = _redisConnection.GetDatabase(ExcuteEngine.configInfo.economicConfig.redisDatabase);
                    logger.InfoLog("Redis初始化成功！");
                    while (true)
                    {
                        try
                        {
                            //logger.InfoLog($"开始读取Redis 点{ExcuteEngine.configInfo.economicConfig.StablePoint}");
                            var redisValue = await _redisDb.StringGetAsync(ExcuteEngine.configInfo.economicConfig.redisStablePoint);
                            if (!redisValue.IsNullOrEmpty)
                            {
                                if (double.TryParse(redisValue.ToString(), out double num))
                                {
                                    IsSteadyState = num != 0;
                                }
                                logger.InfoLog($"Redis {ExcuteEngine.configInfo.economicConfig.redisStablePoint} Value：{redisValue.ToString()}！");
                            }
                            else
                            {
                                logger.InfoLog($"Redis {ExcuteEngine.configInfo.economicConfig.redisStablePoint} Value为空！");
                            }
                        }
                        catch (Exception ex)
                        {
                            // 3. 优化：记录循环内部的异常（如网络波动导致读取超时）
                            logger.ErrorLog($"读取 Redis 异常: {ex.Message}");
                        }

                        await Task.Delay(ExcuteEngine.configInfo.RunCycle);
                    }
                }
                catch (Exception ex)
                {
                    logger.ErrorLog($"Redis 后台任务致命错误: {ex.Message}");
                    return;
                }
            });

            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                economiccfgList = warnContext.economiccfgs.ToList().Select(item =>
                {
                    item.alarmLevel = "/";
                    item.realTimeValue = "/";
                    item.NormalLimit = "/";
                    item.BadLimit = "/";
                    item.MoreBadLimit = "/";
                    return item;
                }).ToList();

                foreach (var item in economiccfgList)
                {
                    if (!ExcuteEngine.CommPoints.Contains(item.pointName))
                    {
                        ExcuteEngine.CommPoints.Add(item.pointName);
                    }
                }
            }


            await Task.Run(async () =>
            {
                while (true)
                {
                    try
                    {
                        await ProcessEconomicAlarmsAsync();
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog($"能效预警主循环发生未捕获异常: {ex.Message}");
                    }
                    finally
                    {
                        // 使用 await Task.Delay 释放线程池资源，不要用 Thread.Sleep
                        await Task.Delay(10000);
                    }
                }
            });
        }


        private static string GetLsqrApiUrlForLog()
        {
            return ExcuteEngine.configInfo?.economicConfig?.lsqrResultApiUrl?.Trim() ?? string.Empty;
        }

        private static bool TryGetLsqrApiUri(out Uri? requestUri, out string errorMessage)
        {
            requestUri = null;
            string apiUrl = GetLsqrApiUrlForLog();
            if (string.IsNullOrWhiteSpace(apiUrl))
            {
                errorMessage = "能效预警配置项 economicConfig.lsqrResultApiUrl 为空。";
                return false;
            }

            if (!Uri.TryCreate(apiUrl, UriKind.Absolute, out requestUri) ||
                (requestUri.Scheme != Uri.UriSchemeHttp && requestUri.Scheme != Uri.UriSchemeHttps))
            {
                errorMessage = $"能效预警配置项 economicConfig.lsqrResultApiUrl 非法，当前值：{apiUrl}";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        private static async Task<Response<double>> RequestLsqrResultAsync(string requestJson)
        {
            Response<double> response = new();
            if (!TryGetLsqrApiUri(out Uri? requestUri, out string errorMessage))
            {
                response.Code = 500;
                response.Msg = errorMessage;
                return response;
            }

            using var content = new StringContent(requestJson, Encoding.UTF8, "application/json");
            using var httpResponse = await lsqrHttpClient.PostAsync(requestUri, content);
            string apiResult = await httpResponse.Content.ReadAsStringAsync();

            if (!httpResponse.IsSuccessStatusCode)
            {
                response.Code = (int)httpResponse.StatusCode;
                response.Msg = $"LSQR接口 HTTP 状态异常：{(int)httpResponse.StatusCode}，URL：{requestUri}，响应：{apiResult}";
                return response;
            }

            var apiResponse = JsonConvert.DeserializeAnonymousType(apiResult, new { code = 0, data = new List<double>(), message = "" });
            if (apiResponse == null)
            {
                response.Code = 500;
                response.Msg = $"LSQR接口返回内容反序列化失败，URL：{requestUri}，响应：{apiResult}";
                return response;
            }

            response.Code = apiResponse.code;
            response.Data = apiResponse.data?.FirstOrDefault() ?? 0;
            response.Msg = apiResponse.message;
            return response;
        }

        private static async Task ProcessEconomicAlarmsAsync()
        {
            Dictionary<string, double> targetValueDict = new();
            List<economichistorycfg> addeconomiccfgList = new();
            List<economichistorycfg> updateeconomichistorycfgList = new();
            // 1. 获取当前需要处理的配置副本（极小化锁的范围）
            List<economiccfg> currentConfigs;
            lock (economiccfgListLock)
            {
                currentConfigs = economiccfgList.ToList();
            }
            if (currentConfigs.Count == 0) return;
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                // 2. 性能优化核心：只查询当前还没结束的报警记录，千万不要 ToList() 整张表！
                var activeHistoryList = warnContext.economichistorycfgs
                    .Where(x => x.endTime == null)
                    .ToList();
                foreach (var item in currentConfigs)
                {
                    // 3. 避免重复 Split 解析，缓存起来
                    var xValues = item.designXValue.Split(';').Select(Convert.ToDouble).ToList();
                    var yValues = item.designYValue.Split(';').Select(Convert.ToDouble).ToList();
                    double loadValue = ExcuteEngine.GetRealTimeValue(item.loadPoint);
                    LSQRModel model = new() { X = xValues, Y = yValues, Tx = new List<double> { loadValue } };
                    string requestJson = JsonConvert.SerializeObject(model);
                    try
                    {


                        Response<double> response = null;
                        try
                        {
                            response = await RequestLsqrResultAsync(requestJson);
                        }
                        catch (Exception ex)
                        {
                            logger.ErrorLog($"能效预警 LSQR接口异常,请求数据:{requestJson}，点名:{item.pointName}，接口地址:{GetLsqrApiUrlForLog()}：{ex.Message}");
                            continue;
                        }

                        if (response?.Code != 200)
                        {
                            logger.ErrorLog($"能效预警 LSQR接口调用失败,请求数据:{requestJson}，点名:{item.pointName}，接口地址:{GetLsqrApiUrlForLog()}，返回码:{response?.Code}，信息:{response?.Msg}");
                            continue;
                        }

                        double realTimeValue = ExcuteEngine.GetRealTimeValue(item.pointName);
                        double biasValue = realTimeValue; // 计算偏差值
                        string level = "正常";
                        Dictionary<string, string> alarmDict = new()
                        {
                            { "一般", item.alarmLConfig },
                            { "严重", item.alarmMConfig },
                            { "非常严重", item.alarmHConfig }
                        };
                        object syspoint = ExcuteEngine.GetFirstRunableWarn(item.loadPoint);
                        if (syspoint == null) continue;

                        // 4. 修复死锁风险：使用 await 替代 .Result
                        var res = await ComputeAlarmValue(((LA)syspoint).buffer, xValues, alarmDict);

                        item.realTimeValue = realTimeValue.ToXd(4).ToString();
                        if (res?.Data != null && res.Data.ContainsKey("一般") && res.Data.ContainsKey("严重") && res.Data.ContainsKey("非常严重"))
                        {
                            item.NormalLimit = res.Data["一般"].ToXd(4).ToString();
                            item.BadLimit = res.Data["严重"].ToXd(4).ToString();
                            item.MoreBadLimit = res.Data["非常严重"].ToXd(4).ToString();
                        }
                        if (IsSteadyState)
                        {
                            if (string.IsNullOrEmpty(item.alarmLConfig) || string.IsNullOrEmpty(item.alarmMConfig) || string.IsNullOrEmpty(item.alarmHConfig))
                                continue;
                            // 5. 抽离复杂的报警等级计算逻辑
                            level = DetermineAlarmLevel(item, biasValue, res.Data);
                            targetValueDict[(item.pointName.Replace(".", "_") + "_Normal").ToLower()] = res.Data["一般"];
                            targetValueDict[(item.pointName.Replace(".", "_") + "_Bad").ToLower()] = res.Data["严重"];
                            targetValueDict[(item.pointName.Replace(".", "_") + "_MoreBad").ToLower()] = res.Data["非常严重"];
                            // 处理报警状态变更
                            if (item.alarmLevel != level)
                            {
                                DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

                                // 结束旧的报警
                                if (item.alarmLevel != "/")
                                {
                                    var activeAlarm = activeHistoryList.LastOrDefault(x => x.pointName.Equals(item.pointName, StringComparison.OrdinalIgnoreCase));
                                    if (activeAlarm != null)
                                    {
                                        activeAlarm.endTime = now;
                                        activeAlarm.duration = Math.Floor((now - activeAlarm.startTime).TotalSeconds).ToString();
                                        updateeconomichistorycfgList.Add(activeAlarm);
                                    }
                                }
                                // 开启新的报警
                                if (level != "正常")
                                {
                                    var newAlarm = new economichistorycfg
                                    {
                                        pointName = item.pointName,
                                        startTime = now,
                                        endTime = null,
                                        level = level
                                    };
                                    addeconomiccfgList.Add(newAlarm);
                                    item.startTime = now;
                                }
                            }
                            item.alarmLevel = level;
                        }
                        else
                        {
                            item.alarmLevel = "/";
                            item.startTime = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog($"处理预警点 {item.pointName} 发生异常: {ex.Message}");
                    }
                } // end foreach
                  // 6. 统一保存数据库
                lock (economichistorycfgLock)
                {
                    if (IsSteadyState)
                    {
                        if (addeconomiccfgList.Count > 0)
                        {
                            warnContext.economichistorycfgs.AddRange(addeconomiccfgList);
                        }
                        if (updateeconomichistorycfgList.Count > 0)
                        {
                            warnContext.economichistorycfgs.UpdateRange(updateeconomichistorycfgList);
                        }
                        if (addeconomiccfgList.Count > 0 || updateeconomichistorycfgList.Count > 0)
                        {
                            warnContext.SaveChanges();
                        }
                        if (targetValueDict.Count > 0)
                        {
                            InfluxDBHelp.BatchInsert(targetValueDict);
                        }
                    }
                    else
                    {
                        // 非稳态，结束所有正在报警的记录
                        DateTime now = DateTime.Now;
                        var alarmsToClose = warnContext.economichistorycfgs.Where(x => x.endTime == null).ToList();

                        if (alarmsToClose.Count > 0)
                        {
                            foreach (var alarm in alarmsToClose)
                            {
                                alarm.endTime = now;
                                alarm.duration = Math.Floor((now - alarm.startTime).TotalSeconds).ToString();
                            }
                            warnContext.economichistorycfgs.UpdateRange(alarmsToClose);
                            warnContext.SaveChanges();
                        }
                    }
                }
            }
        }
        // 抽取出的报警等级判断逻辑，保持数学逻辑与原代码完全一致，但提升了可读性
        private static string DetermineAlarmLevel(economiccfg item, double biasValue, ConcurrentDictionary<string, double> resData)
        {
            string level = "正常";
            if (resData == null || resData.Count == 0) return level;
            if (item.computeRule)
            {
                // 升序排
                var sortedD = resData.OrderBy(x => x.Value).ToList();
                var values = sortedD.Select(x => x.Value).ToList();
                if (biasValue >= values[^1]) // 大于等于最大值
                {
                    level = "非常严重";
                    logger.InfoLog($"能效报警点：{item.pointName} {biasValue.ToXd(4)} >= {values[^1].ToXd(4)} 预警级别：{level} 预警类型：高报");
                }
                else
                {
                    for (int k = 0; k < values.Count - 1; k++)
                    {
                        if (biasValue >= values[k] && biasValue < values[k + 1])
                        {
                            level = sortedD[k].Key;
                            logger.InfoLog($"能效报警点：{item.pointName} {biasValue.ToXd(4)} >= {values[k].ToXd(4)} && {biasValue.ToXd(4)} < {values[k + 1].ToXd(4)} 预警级别：{level} 预警类型：高报");
                            break;
                        }
                    }
                }
            }
            else
            {
                // 降序排
                var sortedD = resData.OrderByDescending(x => x.Value).ToList();
                var values = sortedD.Select(x => x.Value).ToList();
                if (Math.Abs(biasValue) <= values[^1]) // 绝对值小于等于最小值
                {
                    level = "非常严重";
                    logger.InfoLog($"能效报警点：{item.pointName} {biasValue.ToXd(4)} <= {values[^1].ToXd(4)} 预警级别：{level} 预警类型：低报");
                }
                else
                {
                    for (int k = 0; k < values.Count - 1; k++)
                    {
                        if (biasValue < values[k] && biasValue >= values[k + 1])
                        {
                            level = sortedD[k].Key;
                            logger.InfoLog($"能效报警点：{item.pointName} {biasValue.ToXd(4)} < {values[k].ToXd(4)} && {biasValue.ToXd(4)} >= {values[k + 1].ToXd(4)} 预警级别：{level} 预警类型：低报");
                            break;
                        }
                    }
                }
            }
            return level;
        }


        // {"一般": 1.0, "严重": 2.0, "非常严重": ""}
        private static async Task<Response<ConcurrentDictionary<string, double>>> ComputeAlarmValue(double load, List<double> X, Dictionary<string, string> configs)
        {
            Response<ConcurrentDictionary<string, double>> response = new()
            {
                Data = new()
            };

            try
            {
                List<Task<Response<bool>>> workers = new();
                foreach (var cf in configs)
                {
                    var config = cf;
                    workers.Add(Task.Run(async () =>
                    {
                        Response<bool> r = new();

                        try
                        {
                            LSQRModel model = new()
                            {
                                X = X,
                                Y = (from x in config.Value.Split(";") select Convert.ToDouble(x)).ToList(),
                                Tx = new List<double> { load }
                            };

                            string requestJson = JsonConvert.SerializeObject(model);
                            Response<double> or = await RequestLsqrResultAsync(requestJson);
                            if (or.Code == 200)
                            {
                                response.Data[config.Key] = or.Data;
                            }
                            else
                            {
                                r.Message = $"LSQR接口调用失败，等级:{config.Key}，接口地址:{GetLsqrApiUrlForLog()}，返回码:{or.Code}，信息:{or.Msg}";
                                r.Code = 500;
                            }
                        }
                        catch (Exception ex)
                        {
                            r.Message = $"LSQR接口异常，等级:{config.Key}，接口地址:{GetLsqrApiUrlForLog()}：{ex.Message}";
                            r.Code = 500;
                        }

                        return r;
                    }));
                }

                var f = from x in await Task.WhenAll(workers) where !string.IsNullOrEmpty(x.Message) select x;
                if (f.Any())
                {
                    foreach (var failed in f)
                    {

                        response.Message = failed.Message;
                        response.Code = 500;
                        return response;

                    }
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;
                response.Code = 500;
            }

            return response;

        }

        public static bool AddEconomicCfg(economiccfg addeconomiccfg, out string errmsg)
        {
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                if (addeconomiccfg != null)
                {
                    lock (economiccfgListLock)
                    {
                        CfgVarsystem varsys = ExcuteEngine.CfgVarsystemList.FirstOrDefault(x => x.Name.ToLower() == addeconomiccfg.pointName.ToLower());
                        if (varsys == null)
                        {
                            errmsg = $"{addeconomiccfg.pointName}在系统点表中不存在，添加失败。";
                            return false;
                        }
                        else
                        {

                            economiccfg economiccfg = economiccfgList.FirstOrDefault(x => x.pointName == addeconomiccfg.pointName);
                            if (economiccfg != null)
                            {
                                errmsg = "当前预警配置已存在，添加失败。";
                                return false;
                            }
                            else
                            {

                                int len1 = addeconomiccfg.alarmLConfig.Split(';').Length;
                                int len2 = addeconomiccfg.alarmMConfig.Split(';').Length;
                                int len3 = addeconomiccfg.alarmHConfig.Split(';').Length;
                                int len4 = addeconomiccfg.designYValue.Split(';').Length;
                                int len5 = addeconomiccfg.designXValue.Split(';').Length;


                                if (len1 > 0 && len1 == len2 && len2 == len3 && len3 == len4 && len4 == len5)
                                {
                                    string str = JsonConvert.SerializeObject(addeconomiccfg);
                                    addeconomiccfg.subName = varsys?.Description;
                                    if (addeconomiccfg.unitDescription == "1号机组")
                                    {
                                        addeconomiccfg.unitName = "1DCS";
                                        addeconomiccfg.loadPoint = "dcs_AMMKA01AG001CE01";
                                    }
                                    else if (addeconomiccfg.unitDescription == "2号机组")
                                    {
                                        addeconomiccfg.unitName = "2DCS";
                                        addeconomiccfg.loadPoint = "dcs_AMMKA01AG001CE01";
                                    }

                                    addeconomiccfg.alarmLevel = "/";
                                    addeconomiccfg.NormalLimit = "/";
                                    addeconomiccfg.BadLimit = "/";
                                    addeconomiccfg.MoreBadLimit = "/";
                                    addeconomiccfg.realTimeValue = "/";

                                    warnContext.economiccfgs.Add(addeconomiccfg);
                                    warnContext.SaveChanges();
                                    economiccfgList.Add(addeconomiccfg);

                                    errmsg = "";
                                    return true;
                                }
                                else
                                {
                                    errmsg = "请确保各参数的长度一致，添加失败。";
                                    return false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    errmsg = "预警配置不能为空，添加失败。";
                    return false;
                }

            }
        }

        public static bool UpdateEconomicCfg(economiccfg economiccfg, out string errmsg)
        {

            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                lock (economiccfgListLock)
                {
                    economiccfg updateeconomiccfg = economiccfgList.FirstOrDefault(x => x.Id == economiccfg.Id);
                    if (updateeconomiccfg != null)
                    {

                        int len1 = economiccfg.alarmLConfig.Split(';').Length;
                        int len2 = economiccfg.alarmMConfig.Split(';').Length;
                        int len3 = economiccfg.alarmHConfig.Split(';').Length;
                        int len4 = economiccfg.designYValue.Split(';').Length;
                        int len5 = economiccfg.designXValue.Split(';').Length;


                        if (len1 > 0 && len1 == len2 && len2 == len3 && len3 == len4 && len4 == len5)
                        {

                            updateeconomiccfg.designXValue = economiccfg.designXValue;
                            updateeconomiccfg.designYValue = economiccfg.designYValue;
                            updateeconomiccfg.alarmLConfig = economiccfg.alarmLConfig;
                            updateeconomiccfg.alarmMConfig = economiccfg.alarmMConfig;
                            updateeconomiccfg.alarmHConfig = economiccfg.alarmHConfig;
                            updateeconomiccfg.computeRule = economiccfg.computeRule;

                            warnContext.economiccfgs.Update(updateeconomiccfg);
                            warnContext.SaveChanges();

                            errmsg = "";
                            return true;
                        }
                        else
                        {
                            errmsg = "请确保各参数的长度一致，更新失败。";
                            return false;
                        }
                    }
                    else
                    {
                        errmsg = "当前预警配置不存在，更新失败。";
                        return false;
                    }
                }
            }
        }

        public static bool DeleteEconomicCfg(int id)
        {
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                lock (economiccfgListLock)
                {
                    economiccfg economiccfg = economiccfgList.FirstOrDefault(x => x.Id == id);
                    if (economiccfg != null)
                    {
                        warnContext.economiccfgs.Remove(economiccfg);
                        warnContext.SaveChanges();


                        var historycfg = warnContext.economichistorycfgs?.Where(x => x.pointName == economiccfg.pointName);
                        if (historycfg == null) return false;



                        economiccfgList.Remove(economiccfg);

                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static List<economiccfg> GetAllEconomicCfg()
        {
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                try
                {
                    return economiccfgList;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static List<economichistorycfgdto> GetEconomicAlarm(string bt, string et, string pointname)
        {

            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                DateTime beginTime = DateTime.Parse(bt); // 确保字符串可以正确解析为DateTime
                DateTime endTime = DateTime.Parse(et);


                var query = warnContext.economichistorycfgs
                            .Where(x => x.startTime > beginTime && x.startTime < endTime && x.pointName == pointname)// && Convert.ToInt32(x.duration??"0") > 15
                            .Select(x => new economichistorycfgdto
                            {
                                Id = x.Id,
                                pointName = x.pointName,
                                startTime = x.startTime.ToString("yyyy-MM-dd HH:mm:ss"),
                                endTime = x.endTime.HasValue ? x.endTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : null,
                                duration = x.duration,
                                level = x.level
                            });

                return query.OrderByDescending(x => x.Id).ToList();
            }
        }

        public static EconomicCurve GetEconomicAlarmCurve(int id)
        {
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                //List<List<PointValue>> pointValueList = new List<List<PointValue>>();
                var historycfg = warnContext.economichistorycfgs?.FirstOrDefault(x => x.Id == id);
                if (historycfg == null) return null;

                string pn = historycfg.pointName;
                DateTime startTime = historycfg.startTime.AddMinutes(-10);
                DateTime? endtime = DateTime.MinValue;

                if (historycfg.endTime == null)
                {
                    endtime = DateTime.Now;
                }
                else
                {
                    endtime = historycfg.endTime?.AddMinutes(10);
                    if (endtime > DateTime.Now)
                    {
                        endtime = DateTime.Now;
                    }
                }

                var GetSql = (List<string> tableNames) =>
                {
                    string sql = "";
                    foreach (var item in tableNames)
                    {
                        if (item.Contains("."))
                        {
                            string fromAlgName = pn.Split('.')[0];
                            string fromPinName = pn.Split('.')[1];
                            sql += $@"select first({fromPinName}) as pvalue from {fromAlgName.ToTableName()} where time >= '{startTime.ToUTCString()}' and time <= '{endtime?.ToUTCString()}' group by time(10s) fill(previous);";
                        }
                        else
                        {
                            sql += $@"select first(pvalue) as pvalue from {item.ToTableName()} where time >= '{startTime.ToUTCString()}' and time <= '{endtime?.ToUTCString()}' group by time(10s) fill(previous);";
                        }
                    }

                    return sql;
                };


                EconomicCurve economicCurve = new EconomicCurve();
                using (HttpClient httpClient = new HttpClient())
                {
                    try
                    {
                        InfluxQuery influxQuery = new InfluxQuery()
                        {
                            sql = GetSql(new List<string>() { $"{historycfg.pointName}", $"{historycfg.pointName.Replace(".", "_").ToLower()}_normal", $"{historycfg.pointName.Replace(".", "_").ToLower()}_bad", $"{historycfg.pointName.Replace(".", "_").ToLower()}_morebad" })
                        };

                        var json = JsonConvert.SerializeObject(influxQuery);
                        var content = new StringContent(json, Encoding.UTF8, "application/json");
                        var response = httpClient.PostAsync(ExcuteEngine.configInfo.InfluxDBQueryApiurl, content).Result;
                        if (response.IsSuccessStatusCode)
                        {
                            var responseContent = response.Content.ReadAsStringAsync().Result;
                            var responseMsg = JsonConvert.DeserializeObject<Response2<List<DataItem>>>(responseContent);


                            List<List<string>> tsList = new List<List<string>>();
                            List<string[]> pvalueList = new List<string[]>();
                            foreach (var item in responseMsg.Data)
                            {
                                if (item.series != null)
                                {
                                    List<string> tsList0 = item.series[0].values.Select(x => Convert.ToDateTime(x[0]).ToLocalTime().ToString("yyyy-MM-dd HH:mm:ss")).ToList();
                                    string[] pvalueList0 = item.series[0].values.Select(x => x[1]).ToArray();
                                    ExcuteEngine.FillNulls(pvalueList0);

                                    tsList.Add(tsList0);
                                    pvalueList.Add(pvalueList0);
                                }
                                else
                                {
                                    tsList.Add(null);
                                    pvalueList.Add(null);
                                }
                            }

                            economiccfg economiccfg = warnContext.economiccfgs.FirstOrDefault(x => x.pointName == historycfg.pointName);

                            economicCurve.title = economiccfg?.subName;
                            economicCurve.curveData = new List<CurveData>
                            {
                                new CurveData() { tag = "实时值", tslist = tsList[0], pvalueList = pvalueList[0].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() },
                                new CurveData() { tag = "一般报警值", tslist = tsList[1], pvalueList = pvalueList[1].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() },
                                new CurveData() { tag = "严重报警值", tslist = tsList[2], pvalueList = pvalueList[2].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() },
                                new CurveData() { tag = "非常严重报警值", tslist = tsList[3], pvalueList = pvalueList[3].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() }
                            };

                            return economicCurve;
                        }
                        else
                        {
                            return economicCurve;
                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
            }
        }
        public static bool DeleteEconomicAlarm(int id)
        {
            lock (economichistorycfgLock)
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    economichistorycfg historycfg = warnContext.economichistorycfgs.FirstOrDefault(x => x.Id == id);
                    if (historycfg != null)
                    {
                        warnContext.economichistorycfgs.Remove(historycfg);
                        warnContext.SaveChanges();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        public static List<Hdl> GetHdlList(int data)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                List<Hdl> hdllist = new();
                if (data == (int)hdltotalenum.month)
                {
                    // 获取今天的日期
                    DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    DateTime startOfMonth1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-1);
                    hdllist = warnContext.Hdldata.Where(wa => wa.Time.Value >= startOfMonth1 && wa.Time.Value < startOfMonth.AddDays(1)).ToList();
                }
                else if (data == (int)hdltotalenum.quarter)
                {
                    DateTime currentDate = DateTime.Now;
                    Tuple<DateTime, DateTime> lastQuarterRange = GetLastQuarterRange(currentDate);
                    // 过滤出 BeginTime 为本周的数据
                    hdllist = warnContext.Hdldata.Where(wa => wa.Time.Value >= lastQuarterRange.Item1.AddMonths(-3) && wa.Time.Value < lastQuarterRange.Item2).ToList();

                }
                else if (data == (int)hdltotalenum.year)
                {
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;
                    DateTime startDate = new DateTime(currentYear - 1, 1, 1);
                    DateTime endDate = new DateTime(currentYear, 1, 1);
                    // 获取本月的第一天
                    hdllist = warnContext.Hdldata.Where(wa => wa.Time.Value >= startDate && wa.Time.Value < endDate).ToList();

                }
                else
                {
                    return null;
                }
                return hdllist;
            }
        }
        public static List<Rmrz> GetRmrzList(int data)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                List<Rmrz> rmrzlist = new();
                if (data == (int)hdltotalenum.month)
                {
                    // 获取今天的日期
                    DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    DateTime startOfMonth1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-2);
                    rmrzlist = warnContext.rmrz.Where(wa => wa.Time >= startOfMonth1 && wa.Time < startOfMonth.AddDays(1)).ToList();

                }
                else if (data == (int)hdltotalenum.quarter)
                {
                    DateTime currentDate = DateTime.Now;
                    Tuple<DateTime, DateTime> lastQuarterRange = GetLastQuarterRange(currentDate);
                    // 过滤出 BeginTime 为本周的数据
                    rmrzlist = warnContext.rmrz.Where(wa => wa.Time >= lastQuarterRange.Item1.AddMonths(-3) && wa.Time < lastQuarterRange.Item2).ToList();

                }
                else if (data == (int)hdltotalenum.year)
                {
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;
                    DateTime startDate = new DateTime(currentYear - 1, 1, 1);
                    DateTime endDate = new DateTime(currentYear, 1, 1);
                    // 获取本月的第一天
                    rmrzlist = warnContext.rmrz.Where(wa => wa.Time >= startDate && wa.Time < endDate).ToList();

                }
                else
                {
                    return null;
                }
                return rmrzlist;
            }
        }
        public static List<weighteddata> GetZkList(int data)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                List<weighteddata> rmrzlist = new();
                if (data == (int)hdltotalenum.month)
                {
                    // 获取今天的日期
                    DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    DateTime startOfMonth1 = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1).AddMonths(-2);
                    rmrzlist = warnContext.weighteddatum.Where(wa => wa.Time >= startOfMonth1 && wa.Time < startOfMonth.AddDays(1)).ToList();

                }
                else if (data == (int)hdltotalenum.quarter)
                {
                    DateTime currentDate = DateTime.Now;
                    Tuple<DateTime, DateTime> lastQuarterRange = GetLastQuarterRange(currentDate);
                    // 过滤出 BeginTime 为本周的数据
                    rmrzlist = warnContext.weighteddatum.Where(wa => wa.Time >= lastQuarterRange.Item1.AddMonths(-3) && wa.Time < lastQuarterRange.Item2).ToList();

                }
                else if (data == (int)hdltotalenum.year)
                {
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;
                    DateTime startDate = new DateTime(currentYear - 1, 1, 1);
                    DateTime endDate = new DateTime(currentYear, 1, 1);
                    // 获取本月的第一天
                    rmrzlist = warnContext.weighteddatum.Where(wa => wa.Time >= startDate && wa.Time < endDate).ToList();

                }
                else
                {
                    return null;
                }
                return rmrzlist;
            }
        }
        static Tuple<DateTime, DateTime> GetLastQuarterRange(DateTime currentDate)
        {
            int currentQuarter = (currentDate.Month - 1) / 3 + 1;
            int lastQuarter = currentQuarter - 1;
            if (lastQuarter == 0)
            {
                lastQuarter = 4;
            }

            int startMonth = (lastQuarter - 1) * 3 + 1;
            int endMonth = startMonth + 2;
            int endYear = currentDate.Year;
            if (lastQuarter == 4)
            {
                endYear--;
            }

            DateTime startDate = new DateTime(endYear, startMonth, 1);
            DateTime endDate = new();
            if (endMonth == 12)
            {
                endDate = new DateTime(endYear + 1, 1, 1);
            }
            else
            {
                endDate = new DateTime(endYear, endMonth + 1, 1);
            }

            return Tuple.Create(startDate, endDate);
        }
    }

    public class LSQRModel
    {

        [JsonProperty("x")]
        public List<double>? X { get; set; }

        [JsonProperty("y")]
        public List<double>? Y { get; set; }

        [JsonProperty("preX")]
        public List<double>? Tx { get; set; }
    }
}
