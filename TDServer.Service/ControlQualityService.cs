using EngineCore;
using EngineCore.Models;
using EngineCore.Models.energyanalysis;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Globalization;
using System.Net.Http.Headers;
using System.Text;

namespace TDServer.Service
{
    public class ControlQualityService
    {
        private static DateTime _lastExecutionTime = DateTime.MinValue;
        private static readonly object _lock = new object();
        public static List<ControlInfoData> GetAllControlLastData(string unitName)
        {
            using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
            {
                var controlCfgs = warnContext.controlcfg
                    .Where(cfg => cfg.UnitName == unitName)
                    .ToList();

                var controlInfoCfgs = warnContext.controlinfocfg
                    .Where(cfg => cfg.UnitName == unitName)
                    .ToList();

                var controlInfoDataList = controlCfgs
                    .GroupJoin(
                        controlInfoCfgs,
                        cfg => cfg.PointName,
                        infoCfg => infoCfg.Name,
                        (cfg, infoCfgs) => new { cfg, infoCfgs })
                    .SelectMany(
                        x => x.infoCfgs.DefaultIfEmpty(),
                        (x, infoCfg) => new { x.cfg, infoCfg })
                    .Where(x => x.infoCfg == null ||
                                (double.TryParse(x.infoCfg.Score, out double score) &&
                                 score > 0.0))
                    .GroupBy(x => x.cfg.PointName)
                    .Select(g => g
                        .OrderByDescending(ci => ci.infoCfg?.StartTime)
                        .First())
                    .Select(item => new ControlInfoData
                    {
                        Id = item.cfg.Id,
                        Name = item.cfg.Name,
                        PointName = item.cfg.PointName,
                        StartTime = string.IsNullOrEmpty(item.infoCfg?.StartTime) ? "-" : item.infoCfg.StartTime,
                        EndTime = item.infoCfg?.EndTime ?? "-",
                        MaxDeviation = item.infoCfg?.MaxDeviation?.To2d().ToString() ?? "-",
                        Time = item.infoCfg?.Time.ToString() ?? "-",
                        DecayRate = item.infoCfg?.DecayRate?.To2d().ToString() ?? "-",
                        Residual = item.infoCfg?.Residual?.To2d().ToString() ?? "-",
                        UpperCount = item.infoCfg?.UpperCount.ToString() ?? "-",
                        LowerCount = item.infoCfg?.LowerCount.ToString() ?? "-",
                        Qos = item.infoCfg == null ? "-" : (item.infoCfg.Qos == "True" ? "正常" : "异常"),
                        Performance = item.infoCfg == null ? "-" :
                                      (item.infoCfg.Performance == "True" ? "正常" : item.cfg.Faultcodedes),
                        Score = item.infoCfg?.Score?.ToDouble().To2d().ToString() ?? "-",
                        decayratescore = item.infoCfg?.decayratescore?.ToDouble().To2d().ToString() ?? "-",
                        resscore = item.infoCfg?.resscore?.ToDouble().To2d().ToString() ?? "-",
                        SetPoint = item.cfg.SetPoint,
                        Upper = item.cfg.Upper.ToString(),
                        Lower = item.cfg.Lower.ToString(),
                        Firsttime = item.cfg.Firsttime,
                        Secondtime = item.cfg.Secondtime,
                        ControlEndtime = item.cfg.Endtime,
                        Pointevaluate = item.cfg.Pointevaluate,
                        kpiscore = item.infoCfg?.kpiscore?.ToDouble().To2d().ToString() ?? "-",
                        timescore = item.infoCfg?.timescore?.ToDouble().To2d().ToString() ?? "-",
                        Deviceevaluate = item.cfg.Deviceevaluate,
                        faultcodedes = item.cfg.Faultcodedes,
                        level = item.cfg.Level
                    })
                    .OrderByDescending(x => x.StartTime)
                    .ToList();

                // 添加特殊项
                controlInfoDataList.Add(new ControlInfoData
                {
                    Id = 100,
                    Name = "AGC",
                    StartTime = "-",
                    EndTime = "-",
                    MaxDeviation = "-",
                    Time = "-",
                    DecayRate = "-",
                    Residual = "-",
                    UpperCount = "-",
                    LowerCount = "-",
                    Qos = "-",
                    Performance = "-",
                    Score = "-"
                });

                controlInfoDataList.Add(new ControlInfoData
                {
                    Id = 101,
                    Name = "AGC月度指标",
                    StartTime = "-",
                    EndTime = "-",
                    MaxDeviation = "-",
                    Time = "-",
                    DecayRate = "-",
                    Residual = "-",
                    UpperCount = "-",
                    LowerCount = "-",
                    Qos = "-",
                    Performance = "-",
                    Score = "-"
                });

                return controlInfoDataList;
            }
        }

        public static async Task<List<object>> GetControlInfoDataAsync(ControlQueryModel queryModel)
        {
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
            {
                if (queryModel.PointName == "AGC")
                {
                    //List<Agccontrolinfocfg> agccontrolinfocfgs = warnContext.agccontrolinfocfg.ToList();
                    var agccontrolinfocfgs = warnContext.agccontrolinfocfg.Where(agc => agc.Unit == queryModel.UnitName && DateTime.Parse(agc.StartTime) >= DateTime.Parse(queryModel.StartTime) && DateTime.Parse(agc.StartTime) <= DateTime.Parse(queryModel.EndTime)).ToList();
                    var agcControlinfoDataList = (from agccontrolinfo in agccontrolinfocfgs
                                                  where agccontrolinfo.Unit == queryModel.UnitName
                                                  select new AgcControlInfoData
                                                  {
                                                      Id = agccontrolinfo.Id,
                                                      startTime = agccontrolinfo.StartTime,
                                                      endTime = agccontrolinfo.EndTime,
                                                      Qualified = agccontrolinfo.Qualified,


                                                      LoadValue = agccontrolinfo.LoadValue?.To2d().ToString(),
                                                      AgcValue = agccontrolinfo.AgcValue?.To2d().ToString(),
                                                      LoadValueSteady = agccontrolinfo.LoadValueSteady?.To2d().ToString(),
                                                      Time = agccontrolinfo.Time,
                                                      ControlRate = agccontrolinfo.ControlRate?.To2d().ToString(),
                                                      ControlRateSp = agccontrolinfo.ControlRateSp?.To2d().ToString(),
                                                      ResponseTime = agccontrolinfo.ResponseTime?.To2d().ToString(),
                                                      ResponseTimeStandard = agccontrolinfo.ResponseTimeStandard?.To2d().ToString()

                                                  }).OrderByDescending(x => x.startTime).ToList();

                    return agcControlinfoDataList.Cast<object>().ToList();
                }
                else if (queryModel.PointName == "AGC月度指标")
                {
                    List<Agcmonthinfocfg> agcmonthinfocfgs = warnContext.agcmonthinfocfg.ToList();
                    var agcmonthinfo = agcmonthinfocfgs.Where(agcmonthinfo => agcmonthinfo.Unit == queryModel.UnitName).OrderByDescending(agcmonthinfo => DateTime.Parse(agcmonthinfo.Time)).FirstOrDefault();
                    List<AgcMonthInfoData> agcmonthinfoDataList = new List<AgcMonthInfoData>();
                    if (agcmonthinfo != null)
                    {
                        agcmonthinfoDataList.Add(new AgcMonthInfoData()
                        {
                            Id = agcmonthinfo.Id,
                            Time = agcmonthinfo.Time,
                            Availability = (Convert.ToDouble(agcmonthinfo.Availability) * 100).To2d().ToString() + "%",
                            AvailabilityStandard = (Convert.ToDouble(agcmonthinfo.AvailabilityStandard) * 100).To2d().ToString() + "%",
                            MonthlyControlrate = Convert.ToDouble(agcmonthinfo.MonthlyControlrate).To2d().ToString(),
                            MonthlyControlrateStandard = Convert.ToDouble(agcmonthinfo.MonthlyControlrateStandard).To2d().ToString(),
                            Qualified = agcmonthinfo.Qualified,
                            MonthlyQualified = (Convert.ToDouble(agcmonthinfo.MonthlyQualified) * 100).To2d().ToString() + "%",
                            MonthlyQualifiedStandard = (Convert.ToDouble(agcmonthinfo.MonthlyQualifiedStandard) * 100).To2d().ToString() + "%"
                        });
                    }

                    return agcmonthinfoDataList.Cast<object>().ToList();
                }
                else if (queryModel.PointName == "DEH")
                {
                    List<Dehcontrolinfocfg> dehcontrolinfocfgs = warnContext.dehcontrolinfocfg.ToList();

                    var dehcontrolinfocfgList = (from dehcontrolinfo in dehcontrolinfocfgs
                                                 where dehcontrolinfo.Unit == queryModel.UnitName
                                                 && DateTime.Parse(dehcontrolinfo.StartTime) >= DateTime.Parse(queryModel.StartTime) && DateTime.Parse(dehcontrolinfo.StartTime) <= DateTime.Parse(queryModel.EndTime)
                                                 select new DehcontrolinfoData
                                                 {
                                                     Id = dehcontrolinfo.Id,
                                                     startTime = dehcontrolinfo.StartTime,
                                                     endTime = dehcontrolinfo.EndTime,
                                                     time = dehcontrolinfo.Time,
                                                     LoadValue = dehcontrolinfo.LoadValue?.To2d().ToString(),
                                                     Loadchange = dehcontrolinfo.Loadchange?.To2d().ToString(),
                                                     ResponseValue = dehcontrolinfo.ResponseValue?.To2d().ToString(),
                                                     ResponseDeviation = dehcontrolinfo.ResponseDeviation?.To2d().ToString(),
                                                     ResponseQualified = dehcontrolinfo.ResponseQualified?.To2d().ToString(),
                                                     EleQualified = dehcontrolinfo.EleQualified?.To2d().ToString(),
                                                     DehQualified = dehcontrolinfo.DehQualified?.To2d().ToString(),
                                                     Ele = dehcontrolinfo.Ele?.To2d().ToString(),
                                                     Elesum = dehcontrolinfo.Elesum?.To2d().ToString()

                                                 }).OrderByDescending(x => x.startTime).ToList();

                    return dehcontrolinfocfgList.Cast<object>().ToList();
                }
                else
                {

                    List<Controlcfg> controlcfgs = warnContext.controlcfg.Where(fd => fd.PointName.ToLower() == queryModel.PointName.ToLower() && fd.UnitName == queryModel.UnitName).ToList();
                    string codedes = "异常";
                    if (controlcfgs.Count > 0)
                        codedes = controlcfgs[0].Faultcodedes;
                    List<Controlinfocfg> controlinfocfgs = warnContext.controlinfocfg
                        .Where(fd => fd.UnitName == queryModel.UnitName && fd.Name == queryModel.PointName)
                        .AsEnumerable() // 将查询转换为在内存中执行
                        .Where(fd => DateTime.Parse(fd.StartTime) >= DateTime.Parse(queryModel.StartTime) &&
                                    DateTime.Parse(fd.EndTime) <= DateTime.Parse(queryModel.EndTime))
                        .ToList();
                    var controlinfoDataList = (from controlinfocfg in controlinfocfgs

                                               select new ControlInfoData
                                               {
                                                   Id = controlinfocfg.Id,
                                                   PointName = controlinfocfg.Name,
                                                   StartTime = controlinfocfg.StartTime,
                                                   EndTime = controlinfocfg.EndTime, // Assuming EndTime is not nullable
                                                   MaxDeviation = Convert.ToDouble(controlinfocfg.MaxDeviation).To2d().ToString(),
                                                   Time = controlinfocfg.Time.ToString(),
                                                   DecayRate = Convert.ToDouble(controlinfocfg.DecayRate).To2d().ToString(),
                                                   Residual = Convert.ToDouble(controlinfocfg.Residual).To2d().ToString(),
                                                   UpperCount = controlinfocfg.UpperCount.ToString(),
                                                   LowerCount = controlinfocfg.LowerCount.ToString(),
                                                   Qos = controlinfocfg.Qos == "True" ? "正常" : "异常",
                                                   Performance = controlinfocfg.Performance == "True" ? "正常" : codedes,
                                                   Score = string.IsNullOrEmpty(controlinfocfg.Score) ? "-" : Convert.ToDouble(controlinfocfg.Score).To2d().ToString(),
                                                   decayratescore = string.IsNullOrEmpty(controlinfocfg.decayratescore) ? "-" : Convert.ToDouble(controlinfocfg.decayratescore).To2d().ToString(),
                                                   resscore = string.IsNullOrEmpty(controlinfocfg.resscore) ? "-" : Convert.ToDouble(controlinfocfg.resscore).To2d().ToString(),
                                                   timescore = string.IsNullOrEmpty(controlinfocfg.timescore) ? "-" : Convert.ToDouble(controlinfocfg.timescore).To2d().ToString(),
                                                   kpiscore = string.IsNullOrEmpty(controlinfocfg.kpiscore) ? "-" : Convert.ToDouble(controlinfocfg.kpiscore).To2d().ToString()
                                                   
                                               }).OrderByDescending(x => x.StartTime).ToList();

                    return controlinfoDataList.Cast<object>().ToList();
                }
            }
        }
        public static async Task<List<object>> GetControlInfoDataautoAsync(ControlQueryModel queryModel)
        {
            List<object> data = new List<object>();
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
            {
                if (queryModel.PointName != "AGC" && queryModel.PointName != "AGC月度指标" && queryModel.PointName != "DEH")
                {
                    List<Controlcfg> controlcfg = warnContext.controlcfg.Where(x => x.UnitName == queryModel.UnitName && x.PointName == queryModel.PointName).ToList();
                    double autoper = 0d;
                    if (controlcfg.Count == 1 && controlcfg[0].auto != "")
                    {
                        string inputstarttime = queryModel.StartTime;
                        string inputendtime = queryModel.EndTime;
                        DateTime dt = DateTime.ParseExact(inputstarttime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        DateTime dt1 = DateTime.ParseExact(inputendtime, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture);
                        string outputstarttime = dt.ToString("yyyy-MM-dd HH:mm:ss");
                        string outputendtime = dt1.ToString("yyyy-MM-dd HH:mm:ss");
                        string auto = controlcfg[0].auto;

                        // 检查 auto 是否以 '!' 开头
                        bool isInverted = auto.StartsWith("!");

                        // 如果是，去除 '!' 前缀
                        if (isInverted)
                        {
                            auto = auto.Substring(1);
                        }

                        string url = "http://10.116.17.13:5336/api/Point/OriginQuery";
                        if (queryModel.UnitName == "2DCS")
                        {
                            url = "http://10.116.17.12:5336/api/Point/OriginQuery";
                        }

                        gethisdata getdata = new gethisdata
                        {
                            sql = string.Format("select mean(pvalue) from {0} WHERE time >= '{2}' and time<= '{1}';", auto.ToLower(), outputendtime, outputstarttime)
                        };
                        var stringPayload = JsonConvert.SerializeObject(getdata);
                        var client = new HttpClient();
                        var request = new HttpRequestMessage
                        {
                            Method = HttpMethod.Post,
                            RequestUri = new Uri(url),
                            Content = new StringContent(stringPayload)
                            {
                                Headers = { ContentType = new MediaTypeHeaderValue("application/json") }
                            }
                        };

                        using (var response = await client.SendAsync(request))
                        {
                            response.EnsureSuccessStatusCode();
                            var resultJson = await response.Content.ReadAsStringAsync();
                            if (string.IsNullOrWhiteSpace(resultJson)) return null;

                            Root1 newhis = JsonConvert.DeserializeObject<Root1>(resultJson);
                            if (newhis.code == 500) return null;

                            autoper = Convert.ToDouble(newhis.data[0].series[0].values[0][1]);

                            // 如果 auto 以 '!' 开头，取 1 - autoper
                            if (isInverted)
                            {
                                autoper = 1 - autoper;
                            }
                        }
                    }
                    DateTime today = DateTime.Today;
                    DateTime firstDayOfThisMonth = new DateTime(today.Year, today.Month, 1);
                    DateTime firstDayOfLastMonth = firstDayOfThisMonth.AddMonths(-1);
                    DateTime firstDayOfMonthBeforeLast = firstDayOfThisMonth.AddMonths(-2);
                    List<Controlinfocfg> controlinfocfgs = warnContext.controlinfocfg.Where(x => x.UnitName == queryModel.UnitName && x.Name == queryModel.PointName).ToList();
                    var averageDecayRateScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfThisMonth &&
                        DateTime.Parse(c.StartTime) <= DateTime.Now)
                        .Select(c => double.TryParse(c.decayratescore, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var lastmonthaverageDecayRateScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfLastMonth &&
                        DateTime.Parse(c.StartTime) <= firstDayOfThisMonth)
                        .Select(c => double.TryParse(c.decayratescore, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var lastlastmonthaverageDecayRateScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfMonthBeforeLast &&
                        DateTime.Parse(c.StartTime) <= firstDayOfLastMonth)
                        .Select(c => double.TryParse(c.decayratescore, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var averageabsScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfThisMonth &&
                        DateTime.Parse(c.StartTime) <= DateTime.Now)
                        .Select(c => double.TryParse(c.Score, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var lastmonthaverageabsScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfLastMonth &&
                        DateTime.Parse(c.StartTime) <= firstDayOfThisMonth)
                        .Select(c => double.TryParse(c.Score, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var lastlastmonthaverageabsScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfMonthBeforeLast &&
                        DateTime.Parse(c.StartTime) <= firstDayOfLastMonth)
                        .Select(c => double.TryParse(c.Score, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var averageresScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfThisMonth &&
                        DateTime.Parse(c.StartTime) <= DateTime.Now)
                        .Select(c => double.TryParse(c.resscore, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var lastmonthaverageresScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfLastMonth &&
                        DateTime.Parse(c.StartTime) <= firstDayOfThisMonth)
                        .Select(c => double.TryParse(c.resscore, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    var lastlastmonthaverageresScore = controlinfocfgs.Where(c =>
                        DateTime.Parse(c.StartTime) >= firstDayOfMonthBeforeLast &&
                        DateTime.Parse(c.StartTime) <= firstDayOfLastMonth)
                        .Select(c => double.TryParse(c.resscore, out double score) ? score : (double?)null)
                        .Where(score => score.HasValue)
                        .Average();
                    data.Add(autoper == 0 ? "-" : autoper.ToString());
                    data.Add(averageDecayRateScore == null ? "-" : averageDecayRateScore.ToString());
                    data.Add(lastmonthaverageDecayRateScore == null ? "-" : lastmonthaverageDecayRateScore.ToString());
                    data.Add(lastlastmonthaverageDecayRateScore == null ? "-" : lastlastmonthaverageDecayRateScore.ToString());
                    data.Add(averageabsScore == null ? "-" : averageabsScore.ToString());
                    data.Add(lastmonthaverageabsScore == null ? "-" : lastmonthaverageabsScore.ToString());
                    data.Add(lastlastmonthaverageabsScore == null ? "-" : lastlastmonthaverageabsScore.ToString());
                    data.Add(averageresScore == null ? "-" : averageresScore.ToString());
                    data.Add(lastmonthaverageresScore == null ? "-" : lastmonthaverageresScore.ToString());
                    data.Add(lastlastmonthaverageresScore == null ? "-" : lastlastmonthaverageresScore.ToString());
                    return data;
                }
            }
            return null;
        }

        public static ControlCurve GetControlAlarmCurve(int id)
        {

            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
            {
                Controlinfocfg controlinfocfg = warnContext.controlinfocfg.FirstOrDefault(x => x.Id == id);
                Controlcfg controlcfg = warnContext.controlcfg.FirstOrDefault(x => x.PointName == controlinfocfg.Name && x.UnitName == controlinfocfg.UnitName);

                if (controlcfg == null) return null;

                string pn = controlcfg.PointName;
                string? limitPn = controlcfg.LimitPoint;
                DateTime startTime = Convert.ToDateTime(controlinfocfg.StartTime);
                DateTime endtime = Convert.ToDateTime(controlinfocfg.EndTime);

                double upper = Convert.ToDouble(controlcfg.Upper).To2d();
                double lower = Convert.ToDouble(controlcfg.Lower).To2d();
                double setpoint = Convert.ToDouble(controlcfg.SetPoint).To2d();


                var GetSql = (List<string> tableNames) =>
                {
                    string sql = "";
                    foreach (var item in tableNames)
                    {
                        if (string.IsNullOrEmpty(item))
                        {
                            continue;
                        }
                        if (item.Contains("."))
                        {
                            string fromAlgName = item.Split('.')[0];
                            string fromPinName = item.Split('.')[1];
                            sql += $@"select first({fromPinName}) as pvalue from {fromAlgName.ToTableName()} where time >= '{startTime.ToUTCString()}' and time <= '{endtime.ToUTCString()}' group by time(1s) fill(previous);";
                        }
                        else
                        {
                            sql += $@"select first(pvalue) as pvalue from {item.ToTableName()} where time >= '{startTime.ToUTCString()}' and time <= '{endtime.ToUTCString()}' group by time(1s) fill(previous);";
                        }
                    }

                    return sql;
                };


                ControlCurve controlCurve = new ControlCurve();
                using (HttpClient httpClient = new HttpClient())
                {
                    try
                    {
                        InfluxQuery influxQuery = new InfluxQuery()
                        {
                            sql = GetSql(new List<string>() { $"{pn}", $"{limitPn}" })
                        };

                        influxQuery.sql += $"select last(pvalue) as pvalue from {limitPn} where time >= '{endtime.AddMonths(-1).ToUTCString()}' and time <= '{endtime.ToUTCString()}';";

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
                                    List<string> tsList0 = item.series[0].values.Select(x => Convert.ToDateTime(x[0]).ToLocalTime().ToFormatString()).ToList();
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

                            List<double> upperValueList = pvalueList[0].Select(p => setpoint + upper).ToList();
                            List<double> lowerValueList = pvalueList[0].Select(p => setpoint - upper).ToList();



                            controlCurve.title = "控制品质历史曲线";


                            if (!string.IsNullOrEmpty(limitPn))
                            {
                                controlCurve.curveData = new List<CurveData>
                                {
                                    new CurveData() { tag = $"{controlcfg.PointName}({controlcfg.Name})", tslist = tsList[0], pvalueList = pvalueList[0].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() },
                                    new CurveData() { tag = $"{controlcfg.LimitPoint}", tslist = tsList[1] == null ? tsList[0] : tsList[1], pvalueList = pvalueList[1] == null ? Enumerable.Repeat(Convert.ToDouble(pvalueList[2][0]).To2d(), tsList[0].Count).ToList() : pvalueList[1].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() }
                                };


                                //controlCurve.curveData = new List<CurveData>
                                //{
                                //    new CurveData()
                                //    {
                                //        tag = $"{controlcfg.PointName}({controlcfg.Name})",
                                //        tslist = tsList[0],
                                //        pvalueList = pvalueList[0]?.Select(p => Convert.ToDouble(p).ToXd(4)).ToList() ?? new List<double>()
                                //    }
                                //};

                                //// 检查 pvalueList[1] 是否为空
                                //if (pvalueList[1] != null)
                                //{
                                //    controlCurve.curveData.Add(new CurveData()
                                //    {
                                //        tag = $"{controlcfg.LimitPoint}",
                                //        tslist = tsList[1],
                                //        pvalueList = pvalueList[1].Select(p => Convert.ToDouble(p).ToXd(4)).ToList()
                                //    });
                                //}
                                //else
                                //{
                                //    // 如果 pvalueList[1] 为空，可以选择不添加该 CurveData 对象，或者添加一个空列表
                                //    controlCurve.curveData.Add(new CurveData()
                                //    {
                                //        tag = $"{controlcfg.LimitPoint}",
                                //        tslist = tsList[0],
                                //        pvalueList = Enumerable.Repeat(0.0, tsList[0].Count).ToList()
                                //    });
                                //}

                            }
                            else
                            {
                                controlCurve.curveData = new List<CurveData>
                                {
                                    new CurveData() { tag = $"{controlcfg.PointName}({controlcfg.Name})", tslist = tsList[0], pvalueList = pvalueList[0].Select(p => Convert.ToDouble(p).ToXd(4)).ToList() },
                                    new CurveData() { tag = "upper(上限)", tslist = tsList[0], pvalueList = upperValueList },
                                    new CurveData() { tag = "lower(下限)", tslist = tsList[0], pvalueList = lowerValueList }
                                };
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        throw;
                    }
                }
                return controlCurve;
            }

        }
        public static bool DeleteControl(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
                {
                    Controlcfg controlcfg = warnContext.controlcfg.FirstOrDefault(x => x.Id == id);
                    if (controlcfg != null)
                    {
                        List<Controlinfocfg> controlinfocfgs = warnContext.controlinfocfg.Where(x => x.Name == controlcfg.PointName).ToList();
                        if (controlinfocfgs.Count > 0)
                        {
                            warnContext.controlinfocfg.RemoveRange(controlinfocfgs);
                        }
                        warnContext.controlcfg.Remove(controlcfg);
                        warnContext.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool DeleteControlInfo(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
                {
                    Controlinfocfg controlinfocfg = warnContext.controlinfocfg.FirstOrDefault(x => x.Id == id);
                    if (controlinfocfg != null)
                    {
                        warnContext.controlinfocfg.RemoveRange(controlinfocfg);
                        warnContext.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static bool UpdateControl(ControlInfoData controlInfoData)
        {
            try
            {
                if (controlInfoData != null)
                {
                    using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
                    {
                        Controlcfg? controlcfg = warnContext.controlcfg.FirstOrDefault(x => x.Id == controlInfoData.Id);
                        if (controlcfg != null)
                        {
                            controlcfg.SetPoint = controlInfoData.SetPoint;
                            controlcfg.PointName = controlInfoData.PointName;
                            controlcfg.Upper = double.Parse(controlInfoData.Upper);
                            controlcfg.Lower = double.Parse(controlInfoData.Lower);
                            controlcfg.NewPoint = "true";
                            controlcfg.Firsttime = controlInfoData.Firsttime;
                            controlcfg.Secondtime = controlInfoData.Secondtime;
                            controlcfg.Endtime = controlInfoData.ControlEndtime;
                            controlcfg.Pointevaluate = controlInfoData.Pointevaluate;
                            controlcfg.Deviceevaluate = controlInfoData.Deviceevaluate;
                            warnContext.controlcfg.Update(controlcfg);
                            warnContext.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static bool DeleteDehControlInfo(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
                {
                    Dehcontrolinfocfg dehcontrolinfocfg = warnContext.dehcontrolinfocfg.FirstOrDefault(x => x.Id == id);
                    if (dehcontrolinfocfg != null)
                    {
                        warnContext.dehcontrolinfocfg.RemoveRange(dehcontrolinfocfg);
                        warnContext.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool DeleteAgcControlInfo(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
                {
                    Agccontrolinfocfg agccontrolinfocfg = warnContext.agccontrolinfocfg.FirstOrDefault(x => x.Id == id);
                    if (agccontrolinfocfg != null)
                    {
                        warnContext.agccontrolinfocfg.RemoveRange(agccontrolinfocfg);
                        warnContext.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static bool clickdatasave(click id)
        {
            lock (_lock)
            {
                if ((DateTime.Now - _lastExecutionTime).TotalSeconds < 10)
                {
                    // 如果距离上次执行不足10秒，拒绝执行
                    return false;
                }
                try
                {
                    using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlEnergyanalySis))
                    {
                        clicktime click = new();
                        click.number = id.part;
                        click.Clicktime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        warnContext.clicktimecfg.AddRange(click);
                        warnContext.SaveChanges();
                    }

                    _lastExecutionTime = DateTime.Now;
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public static async Task<List<Controlweigh>> getweigh(controlweighunit unit)
        {
            using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
            {
                var weigh = await warnContext.controlweighcfg
                    .Where(c => c.unit.ToLower() == unit.Unit.ToLower())
                    .ToListAsync();
                return weigh;
            }
        }
        public static async Task<bool> setweigh(Controlweigh data)
        {
            try
            {
                if (data != null)
                {
                    using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConnWay))
                    {
                        Controlweigh? controlcfg = warnContext.controlweighcfg.FirstOrDefault(x => x.unit == data.unit);
                        if (controlcfg != null)
                        {
                            controlcfg.absweigh = data.absweigh;
                            controlcfg.timeweigh = data.timeweigh;
                            controlcfg.runweigh = data.runweigh;
                            controlcfg.kpiweigh = data.kpiweigh;
                            controlcfg.performanceweigh = data.performanceweigh;
                            controlcfg.decayrateweigh = data.decayrateweigh;
                            controlcfg.resweigh = data.resweigh;
                            warnContext.controlweighcfg.Update(controlcfg);
                            warnContext.SaveChanges();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
    public class gethisdata
    {
        public string sql { get; set; }
    }
}
