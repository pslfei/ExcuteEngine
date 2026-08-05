using DBServer.LogServer;
using DCSCommon;
using DCSType;
using EngineCore;
using EngineCore.Models;
using InfluxDB.Client;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Concurrent;
using System.Data;
using System.Reflection;
using System.Text;
using static TDServer.Service.HealthHelp;

namespace TDServer.Service
{
    public class ExcuteEngine
    {
        public enum totalenum
        {
            all,
            day,
            week,
            month
        }
        public enum hdltotalenum
        {
            month,
            quarter,
            year,
            lastmonth,
            lastquarter,
            lastyear
        }
        public enum CommDataType
        {
            LA = 0,
            LD = 1,
            LP = 2
        }

        public enum SourceType
        {
            /// <summary>
            /// 原始系统点
            /// </summary>
            DCS = 0,
            /// <summary>
            /// 页面输入点
            /// </summary>
            PageInput = 1,
            /// <summary>
            /// 外部系统点
            /// </summary>
            ExternalSystems = 2,
            /// <summary>
            /// 回写DCS点
            /// </summary>
            WriteBack = 3
        }

        public static float dwfrlCoefficient = 4.184f;
        private static int FaultDiagnosisAlarmDurThreshold = 10;
        private static int WarnAlarmDurThreshold = 10;
        public static string turbinJson = "";

        private static LoggerService<ExcuteEngine> logger = new LoggerService<ExcuteEngine>();

        
        public static ConcurrentDictionary<string, object> RTDDict_Rule;
        public static ConcurrentDictionary<string, List<object>> RTDDict;
        public static Dictionary<string, string> WarnRTableDict;//预警点重构表
        public static int cycle = 3000;


        public static int HealthControllerID = 10000;
        public static int AlarmControllerID = 20000;
        public static List<CfgVarsystem> pointsList;
        public static List<Controller> controllerList;
        public static AlarmHelp.AlarmConfigData? alarmConfig;

        public static long cycleCount = 0;
        public static bool hasRun = false;
        static bool hasUpdatedVarPoint = true;

        public static List<Assembly> assemblyList;
        public static List<Type> fcTypeList;
        public static Dictionary<string, List<string>> secondCalcPinNameList;
        public static Dictionary<string, Function> fcTypeDict = new Dictionary<string, Function>();

        public static Dictionary<string, List<CldWarnpoint>> modelWarnPoint;

        //public static List<LAExWarn> ruleWarnPoint;
        public static Dictionary<string, string> WriteBackPointDict = new Dictionary<string, string>();


        public static HttpClient client;
        public static ConfigInfo configInfo;

        public static double pcr;
        public static double tpy;

        public static double eletodaysum2 = 0;
        public static double dgs;

        public static List<double> tgsList = new List<double>();
        public static Dictionary<string, double> targetValueDict = new();

        public static InfluxDBClient influxDBClient = null;
        public static Dictionary<string, double> pageInputDict = new Dictionary<string, double>();

        public static List<string> ruleWarnPoints;
        public static List<CldWarnpoint> cldWarnpointList;
        public static List<string> CommPoints;

        public static OptimizingFunction optimizingFunction;

        public static Dictionary<string, List<WarnRValue>> warnRValueDict;

        public static List<WarnAlarm> warnAlarmList = new List<WarnAlarm>();

        public static List<FaultDiagnosis> faultDiagnosisList = new List<FaultDiagnosis>();

        public static List<parawarns> parawarnsList = new List<parawarns>();

        public static List<CfgVarsystem> CfgVarsystemList = new List<CfgVarsystem>();

        public static Dictionary<string, Dictionary<string, object>> WriteBackDcsPointDict = new Dictionary<string, Dictionary<string, object>>();

        // 定义一个静态对象作为锁
        private static readonly object _lock = new object();

        public static bool powerUnitStop = false;
        public static bool oldPowerUnitStop = false;


        private static Queue<double> qnetarQueue = new Queue<double>();
        private static DateTime lastCacheDate = DateTime.MinValue;

        public static object GetFirstRunableWarn(string pointName)
        {
            if (!RTDDict.TryGetValue(pointName, out List<object> warnList))
            {
                return null;
            }
            lock (warnList)
            {
                if (warnList.Count > 1)
                {
                    return warnList.OfType<LAExWarn>().FirstOrDefault(w => w.Runable);
                }
                else if (warnList.Count == 1)
                {
                    return warnList[0];
                }
                return null;
            }
        }

        public static void ReinitializeSheet(int sheetid)
        {
            try
            {
                hasRun = false;

                for (int i = 0; i < controllerList.Count; i++)
                {
                    if (controllerList[i].ID != HealthControllerID)
                    {
                        controllerList[i].ReinitializeSheetIncremental(sheetid);
                    }
                }

                hasRun = true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"ReinitializeSheet：初始化sheetid【{sheetid}】失败！" + ex);
                hasRun = true;
            }
        }


        public static void ReinitializeSheets(List<int> sheetids)
        {
            try
            {
                hasRun = false;

                for (int i = 0; i < controllerList.Count; i++)
                {
                    if (controllerList[i].ID != HealthControllerID)
                    {
                        controllerList[i].ReinitializeSheets(sheetids);
                    }
                }

                hasRun = true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"ReinitializeSheet：初始化sheetids【{JsonConvert.SerializeObject(sheetids)}】失败！" + ex);
                hasRun = true;
            }
        }


        public static void ReinitializeSheetsIncremental(List<int> sheetids)
        {
            try
            {
                hasRun = false;

                for (int i = 0; i < controllerList.Count; i++)
                {
                    if (controllerList[i].ID != HealthControllerID)
                    {
                        controllerList[i].ReinitializeSheetsIncremental(sheetids);
                    }
                }

                hasRun = true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"ReinitializeSheetsIncremental：初始化sheetids【{JsonConvert.SerializeObject(sheetids)}】失败！" + ex);
                hasRun = true;
            }
        }


        public ExcuteEngine(ConfigInfo config)
        {
            Console.WriteLine("正在初始化数据库和计算引擎...");
            logger.InfoLog("正在初始化数据库和计算引擎...");
            configInfo = config;
            InfluxDBHelp.InitInfluxDB(config.InfluxDBUrl, config.InfluxDBToken);
            Initial();
            Start();
        }

        public static (bool Success, string ErrorMessage) Compiler22()
        {
            return (false, string.Empty);
        }

        public static void Initial()
        {
            engineStartTime = DateTime.Now;
            cycle = configInfo.RunCycle;
            client = new HttpClient();
            client.Timeout = new TimeSpan(0, 0, 0, 5);

            modelWarnPoint = new Dictionary<string, List<CldWarnpoint>>();
            //ruleWarnPoint = new List<LAExWarn>();

            fcTypeDict = new Dictionary<string, Function>();
            controllerList = new List<Controller>();
            //WarnTableDict = new Dictionary<string, string>();
            WarnRTableDict = new Dictionary<string, string>();

            CommPoints = new List<string>();
            //RTDDict = new Dictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            RTDDict_Rule = new ConcurrentDictionary<string, object>(StringComparer.OrdinalIgnoreCase);
            RTDDict = new ConcurrentDictionary<string, List<object>>(StringComparer.OrdinalIgnoreCase);

            // 从配置文件初始化pageInputDict
            if (configInfo.pageInputDefaultValues != null)
            {
                pageInputDict = new Dictionary<string, double>(configInfo.pageInputDefaultValues);
            }

            //LoadWriteBackPoints();
            InitSystemPoint();

            LoadDll();

            InitController();

            hasRun = true;
            Console.WriteLine("数据库初始化成功。");
            logger.InfoLog("数据库初始化成功。");
        }

        public static void Start()
        {
            StartFunctionCodeRunTask();
            StartUpdateWarnPointUpLowLimitTask();
            StartAlarmAcknowledgmentTask();

            //StartVarSystemPointUpdateTask();
            StartWriteBackDcsTask();
            StartWarnPointWriteBackTask();
            StartGetBoilerDataTask();
            //StartGetChAndFqDataTask();

            EconomicAlarmMonitoringService.Start();

            ICCompareService.Start();

            DeviceRunCfgService.Start();

            Console.WriteLine("计算引擎已运行。");
            logger.InfoLog("计算引擎已运行。");
        }

        /// <summary>
        /// 功能码Run
        /// </summary>
        private static void StartFunctionCodeRunTask()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        TimeSpan ts = new TimeSpan();
                        if (hasRun && hasUpdatedVarPoint)
                        {
                            UpateVarSystemPointAsync(configInfo.GetLastValuesapiurl);
                            DateTime dt1 = DateTime.Now;

                            SetPowerUnitState();
                            AnalyticalExpression.SetWarnConstraintAndAlarm(cldWarnpointList);

                            for (int i = 0; i < controllerList.Count; i++)
                            {
                                controllerList[i].Run();
                            }
                            cycleCount++;

                            ProcessWarnAlarmData();

                            oldPowerUnitStop = powerUnitStop;
                            ts = DateTime.Now - dt1;
                        }

                        int sleepTime = cycle - (int)ts.TotalMilliseconds;
                        Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
                        logger.InfoLog("执行周期：" + ts.TotalMilliseconds + "");
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog("功能码运行任务异常: " + ex.Message);
                    }
                }
            });
        }

        private static void ProcessWarnAlarmData()
        {
            List<WarnAlarm> addMysqlWarnAlarmList = new List<WarnAlarm>();
            List<WarnAlarm> updateMysqlWarnAlarmList = new List<WarnAlarm>();

            var warnpointSnapshot = cldWarnpointList;
            foreach (var item in warnpointSnapshot)
            {
                ProcessSingleWarnPoint(item, addMysqlWarnAlarmList, updateMysqlWarnAlarmList);
            }

            AddOrUpdateWarnAlarm(addMysqlWarnAlarmList, updateMysqlWarnAlarmList);
        }

        private static void ProcessSingleWarnPoint(CldWarnpoint item, List<WarnAlarm> addList, List<WarnAlarm> updateList)
        {
            object modelOrRuleWarn = GetWarnPointInstance(item);
            if (modelOrRuleWarn is null) return;

            // 模型点使用旧逻辑（不支持多级报警）
            if (item.ModelOrrule == 0 && modelOrRuleWarn is LAExWarn modelWarn)
            {
                if (modelWarn.IsAlarmSuspended || modelWarn.NeedRecord != 1) return;

                if (modelWarn.Active)
                    AddModelAlarm(item, modelWarn, addList);
                else
                    UpdateModelAlarm(item, modelWarn, updateList);
                modelWarn.NeedRecord = 0;

                logger.InfoLog($"ProcessSingleWarnPoint {modelWarn.PointName} NeedRecord 设置为0；");
                return;
            }
            // 规则点支持多级报警
            else if (item.ModelOrrule == 1)
            {
                ProcessRuleWarnLevels(item, modelOrRuleWarn, addList, updateList);
            }
        }


        /// <summary>
        /// 处理规则预警点的多级报警（统一LAExWarn和LDExWarn的处理逻辑）
        /// </summary>
        private static void ProcessRuleWarnLevels(CldWarnpoint item, object warnPoint, List<WarnAlarm> addList, List<WarnAlarm> updateList)
        {
            // 定义处理委托
            Action<dynamic> processLevels = (dynamic warn) =>
            {
                if (warn.IsAlarmSuspended || warn.NeedRecord != 1) return;

                foreach (var levelInfo in warn.AlarmLevels.Values)
                {
                    if (!levelInfo.NeedRecord) continue;

                    if (levelInfo.Active)
                    {
                        AddRuleAlarm(item, warn, levelInfo, addList);
                    }
                    else
                    {
                        UpdateRuleAlarm(item, warn, levelInfo, updateList);
                        levelInfo.AlarmStartTime = null;
                        levelInfo.AlarmEndTime = null;
                    }

                    levelInfo.NeedRecord = false;
                }

                warn.NeedRecord = 0;
            };

            // 根据类型调用
            switch (warnPoint)
            {
                case LAExWarn laExWarn:
                    processLevels(laExWarn);
                    break;
                case LDExWarn ldExWarn:
                    processLevels(ldExWarn);
                    break;
            }
        }

        /// <summary>
        /// 创建并添加报警记录（统一LAExWarn和LDExWarn）
        /// </summary>
        private static void AddRuleAlarm(CldWarnpoint item, dynamic warn, dynamic levelInfo, List<WarnAlarm> addList)
        {
            WarnAlarm warnAlarm = new WarnAlarm()
            {
                PointName = item.PointName,
                SysID = warn.SysID,
                ModelID = warn.ModelID,
                BeginTime = levelInfo.AlarmStartTime ?? DateTime.Now,
                Level = warn.AlarmLevel ?? 1,
                AlarmType = warn.AlarmType,
                LimitAlarmType = levelInfo.LimitAlarmType,
                UnAck = 1
            };

            addList.Add(warnAlarm);

            string levelName = GetAlarmLevelName(levelInfo.LimitAlarmType);
            logger.InfoLog($"预警点:{item.PointName} 触发{levelName}报警");
        }

        /// <summary>
        /// 查找并更新报警记录（统一LAExWarn和LDExWarn）
        /// </summary>
        private static void UpdateRuleAlarm(CldWarnpoint item, dynamic warn, dynamic levelInfo, List<WarnAlarm> updateList)
        {
            string tablePointName = (item.PointName ?? "").ToTableName();

            WarnAlarm warnAlarm = warnAlarmList.LastOrDefault(x =>
                x.PointName == tablePointName &&
                x.AlarmType == warn.AlarmType &&
                x.LimitAlarmType == levelInfo.LimitAlarmType &&
                x.EndTime == DateTime.MinValue);

            if (warnAlarm == null) return;

            warnAlarm.EndTime = levelInfo.AlarmEndTime;
            warnAlarm.Duration = Math.Ceiling((levelInfo.AlarmEndTime - levelInfo.AlarmStartTime).TotalSeconds);

            if (warn is LAExWarn)
            {
                LAExWarn laExWarn = warn as LAExWarn;
                if (laExWarn.WarnUpUpMaxLimit is not null && levelInfo.LimitAlarmType == 2)
                {
                    warnAlarm.UpUpLimitDuration = laExWarn.UpUpLimitDurTime;
                    warnAlarm.ExceedLimitMaximum = laExWarn.ExceedUpUpLimitList.Count > 0
                        ? laExWarn.ExceedUpUpLimitList.Max()
                        : null;
                }
            }

            updateList.Add(warnAlarm);

            string levelName = GetAlarmLevelName(levelInfo.LimitAlarmType);
            logger.InfoLog($"预警点:{item.PointName} {levelName}报警恢复，持续时间:{warnAlarm.Duration:F1}秒");
        }


        private static object GetWarnPointInstance(CldWarnpoint item)
        {
            string warnPointName = item.PointName ?? "";
            object obj = null;

            if (item.ModelOrrule == 1)
            {
                if (RTDDict_Rule.TryGetValue(warnPointName, out var ruleObj))
                {
                    obj = ruleObj;
                    if (ruleObj is LAExWarn)
                    {
                        (ruleObj as LAExWarn)?.RuleWarnRun(cycle, cycleCount);
                    }
                    else if (ruleObj is LDExWarn)
                    {
                        (ruleObj as LDExWarn)?.RuleWarnRun(cycle, cycleCount);
                    }
                }
            }
            else if (item.ModelOrrule == 0)
            {
                if (RTDDict.TryGetValue(warnPointName, out var warnList))
                {
                    List<LAExWarn> snapshot;
                    lock (warnList)
                    {
                        snapshot = warnList.OfType<LAExWarn>().ToList();
                    }
                    snapshot.ForEach(x => x.Run());
                    obj = snapshot.FirstOrDefault(x => x.Runable || x.NeedRecord == 1);
                }
            }

            return obj;
        }

        private static void AddModelAlarm(CldWarnpoint item, LAExWarn lAExWarn, List<WarnAlarm> addList)
        {
            WarnAlarm warnAlarm = new WarnAlarm()
            {
                PointName = item.PointName,
                SysID = lAExWarn.SysID,
                ModelID = lAExWarn.ModelID,
                BeginTime = lAExWarn.WarnAlarmStartTime,
                Level = lAExWarn.AlarmLevel ?? 1,
                AlarmType = lAExWarn.AlarmType,
                LimitAlarmType = lAExWarn.LimitAlarmType,
                UnAck = 1
            };

            addList.Add(warnAlarm);

            logger.InfoLog("预警点:" + item.PointName + "触发预警。");
        }


        private static void UpdateModelAlarm(CldWarnpoint item, LAExWarn lAExWarn, List<WarnAlarm> updateList)
        {
            string warnPointName = item.PointName ?? "";
            WarnAlarm warnAlarm = warnAlarmList.LastOrDefault(x => x.PointName == warnPointName.ToTableName() && x.EndTime == DateTime.MinValue && x.AlarmType == lAExWarn.AlarmType && x.LimitAlarmType == lAExWarn.LimitAlarmType);

            if (warnAlarm == null) return;

            warnAlarm.EndTime = DateTime.Now;
            //warnAlarm.UpUpLimitDuration = lAExWarn.UpUpLimitDurTime;
            //warnAlarm.ExceedLimitMaximum = lAExWarn.ExceedUpUpLimitList.Count > 0
            //    ? lAExWarn.ExceedUpUpLimitList.Max()
            //    : null;
            warnAlarm.Duration = Math.Ceiling((warnAlarm.EndTime - warnAlarm.BeginTime).TotalSeconds);
            updateList.Add(warnAlarm);
        }


        private static void AddWarnAlarmWithLevel(CldWarnpoint item, LAExWarn lAExWarn,
            LAExWarn.AlarmLevelInfo levelInfo, List<WarnAlarm> addList)
        {
            WarnAlarm warnAlarm = new WarnAlarm()
            {
                PointName = item.PointName,
                SysID = lAExWarn.SysID,
                ModelID = lAExWarn.ModelID,
                BeginTime = levelInfo.AlarmStartTime ?? DateTime.Now,
                Level = lAExWarn.AlarmLevel ?? 1,
                AlarmType = lAExWarn.AlarmType,
                LimitAlarmType = levelInfo.LimitAlarmType,
                UnAck = 1
            };

            addList.Add(warnAlarm);

            string levelName = GetAlarmLevelName(levelInfo.LimitAlarmType);
            logger.InfoLog($"预警点:{item.PointName} 触发{levelName}报警");
        }

        // 为 LDExWarn 添加报警记录
        private static void AddWarnAlarmWithLevel(CldWarnpoint item, LDExWarn lDExWarn,
            LDExWarn.AlarmLevelInfo levelInfo, List<WarnAlarm> addList)
        {
            WarnAlarm warnAlarm = new WarnAlarm()
            {
                PointName = item.PointName,
                SysID = lDExWarn.SysID,
                ModelID = lDExWarn.ModelID,
                BeginTime = levelInfo.AlarmStartTime ?? DateTime.Now,
                Level = lDExWarn.AlarmLevel ?? 1,
                AlarmType = lDExWarn.AlarmType,
                LimitAlarmType = levelInfo.LimitAlarmType,
                UnAck = 1
            };

            addList.Add(warnAlarm);

            string levelName = GetAlarmLevelName(levelInfo.LimitAlarmType);
            logger.InfoLog($"预警点:{item.PointName} 触发{levelName}报警");
        }

        private static string GetAlarmLevelName(int alarmType2)
        {
            return alarmType2 switch
            {
                1 => "高1",
                2 => "高2",
                3 => "高3",
                4 => "低1",
                5 => "低2",
                6 => "低3",
                _ => "未知"
            };
        }

        /// <summary>
        /// 更新系统点及规则预警点的值
        /// </summary>
        private static void StartVarSystemPointUpdateTask()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        DateTime dt = DateTime.Now;
                        if (hasRun)
                        {
                            UpateVarSystemPointAsync(configInfo.GetLastValuesapiurl);
                            //CalculateTemperatureCorrection();
                            hasUpdatedVarPoint = true;
                        }

                        TimeSpan ts = DateTime.Now - dt;
                        int sleepTime = cycle - (int)ts.TotalMilliseconds;
                        Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
                    }
                    catch (Exception ex)
                    {
                        logger.InfoLog("系统点更新任务异常: " + ex.Message);
                    }
                }
            });
        }

        //private static void CalculateTemperatureCorrection()
        //{
        //    //原排烟温度(dcs_hna10ct305 + dcs_hna20ct305) / 2
        //    //一二次风温修正排烟温度数值   0.7 * (0.2 * C + 0.8 * D - 25)
        //    //一次暖风器出口一次风温度(dcs_hlc11ct302 + dcs_hlc11ct303 + dcs_hlc11ct304 + dcs_hlc12ct302 + dcs_hlc12ct303 + dcs_hlc12ct304) / 6
        //    //二次暖风器出口二次风温度(dcs_hlc21ct302 + dcs_hlc21ct303 + dcs_hlc21ct304 + dcs_hlc22ct302 + dcs_hlc22ct303 + dcs_hlc22ct304) / 6
        //    //修正后排烟温度 A-B
        //    List<double> list = GetPointsValue(configInfo.pvapiurl, new List<string>()
        //    {
        //        "dcs_yhjcydl24", "dcs_erhjcydl24", "dcs_hna10ct305", "dcs_hna20ct305", "dcs_hlc11ct302",
        //        "dcs_hlc11ct303", "dcs_hlc11ct304", "dcs_hlc12ct302", "dcs_hlc12ct303", "dcs_hlc12ct304",
        //        "dcs_hla21ct304", "dcs_hla21ct305", "dcs_hla21ct306", "dcs_hla22ct304", "dcs_hla22ct305", "dcs_hla22ct306"
        //    });

        //    if (list != null)
        //    {
        //        pcr = eletodaysum2 > 0 ? list[0] * 0.1 / eletodaysum2 : 0;
        //        double oldtpy = (list[2] + list[3]) / 2;
        //        double c = (list[4] + list[5] + list[6] + list[7] + list[8] + list[9]) / 6;
        //        double d = (list[10] + list[11] + list[12] + list[13] + list[14] + list[15]) / 6;
        //        tpy = oldtpy - (0.7 * (0.2 * c + 0.8 * d - 25));
        //    }
        //}


        /// <summary>
        /// 报警确认
        /// </summary>
        private static void StartAlarmAcknowledgmentTask()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;

                    if (hasRun)
                    {
                        for (int i = 0; i < controllerList.Count; i++)
                        {
                            if (controllerList[i].ID != HealthControllerID)
                            {
                                controllerList[i].Ack();
                            }
                        }
                    }

                    TimeSpan ts = DateTime.Now - dt;
                    int sleepTime = cycle - (int)ts.TotalMilliseconds;
                    Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
                }
            });
        }


        /// <summary>
        /// 回写dcs
        /// </summary>
        private static void StartWriteBackDcsTask()
        {
            if (!configInfo.enableWriteBackDcs) return;

            logger.InfoLog("启用组态逻辑回写功能！");

            Task.Run(async () =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;

                    try
                    {
                        if (hasRun)
                        {
                            var attributeItems = new List<AttributeItem>();
                            var dict = WriteBackDcsPointDict.SelectMany(outerDict => outerDict.Value).ToDictionary(innerKvP => innerKvP.Key, innerKvP => innerKvP.Value);

                            foreach (var keyValuePair in dict)
                            {
                                object value = keyValuePair.Value switch
                                {
                                    LA laObj => laObj.buffer,
                                    LD ldObj => ldObj.buffer ? 1 : 0,
                                    _ => null
                                };

                                if (value == null) continue;

                                // 实时写入处理
                                if (RTDDict.TryGetValue(keyValuePair.Key, out var writeBackDcsPoints) && writeBackDcsPoints != null)
                                {
                                    lock (writeBackDcsPoints)
                                    {
                                        foreach (var point in writeBackDcsPoints)
                                        {
                                            if (point is IValueSetter setterPoint)
                                            {
                                                setterPoint.SetValue(value);
                                            }
                                        }
                                    }
                                }

                                // 添加到AttributeItem列表
                                attributeItems.Add(new AttributeItem
                                {
                                    Code = keyValuePair.Key,
                                    Value = value.ToString()
                                });
                            }

                            logger.InfoLog($"attributeItems：{JsonConvert.SerializeObject(attributeItems)}");
                            try
                            {

                                // 每50个一组进行批量写入
                                var batchSize = 50;
                                for (int i = 0; i < attributeItems.Count; i += batchSize)
                                {
                                    var batchAttributes = attributeItems
                                        .Skip(i)
                                        .Take(batchSize)
                                        .ToList();

                                    logger.InfoLog($"正在回写数据，Data:{JsonConvert.SerializeObject(batchAttributes)}");
                                    // 调用批量写入方法
                                    int result = await TpriClient.BatchWriteValuesAsync(batchAttributes, DateTime.UtcNow);

                                    // 处理结果
                                    if (result == 200)
                                    {
                                        Console.WriteLine("数据回写成功！");
                                        logger.InfoLog("数据回写成功！");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"数据回写失败Code:{result}");
                                        logger.InfoLog($"数据回写失败Code:{result}");
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"数据回写时发生异常：{ex.Message}");
                                logger.ErrorLog($"数据回写异常：{ex.Message}");
                            }

                        }

                        TimeSpan ts = DateTime.Now - dt;

                        int sleepTime = cycle - (int)ts.TotalMilliseconds;
                        Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog($"数据回写异常：{ex.Message}");
                    }
                }
            });
        }

        /// <summary>
        /// 预警点值回写：将cld_warnpoint中配置了回写的点，把PointName的值送给WriteBackPointName
        /// </summary>
        private static void StartWarnPointWriteBackTask()
        {
            if (!configInfo.enableWriteBackDcs) return;

            logger.InfoLog("启用预警点表回写功能！");
            Task.Run(async () =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;
                    try
                    {
                        if (hasRun)
                        {
                            var warnpointSnapshot = cldWarnpointList;
                            var writeBackItems = warnpointSnapshot
                                .Where(w => w.IsWriteBack.HasValue && w.IsWriteBack.Value == 1
                                         && !string.IsNullOrEmpty(w.WriteBackPointName)
                                         && !string.IsNullOrEmpty(w.PointName))
                                .ToList();

                            if (writeBackItems.Count > 0)
                            {
                                var attributeItems = new List<AttributeItem>();

                                foreach (var item in writeBackItems)
                                {
                                    try
                                    {
                                        object pointObj = GetFirstRunableWarn(item.PointName);
                                        if (pointObj == null) continue;

                                        object value = pointObj switch
                                        {
                                            LAExWarn laObj => laObj.Active ? 1 : 0,
                                            LDExWarn ldObj => ldObj.Active ? 1 : 0,
                                            _ => null
                                        };

                                        if (value == null) continue;

                                        attributeItems.Add(new AttributeItem
                                        {
                                            Code = item.WriteBackPointName,
                                            Value = value.ToString()
                                        });
                                    }
                                    catch (Exception ex)
                                    {
                                        logger.ErrorLog($"预警点回写-获取点值异常 PointName:{item.PointName}, Error:{ex.Message}");
                                    }
                                }

                                if (attributeItems.Count > 0)
                                {
                                    try
                                    {
                                        var batchSize = 50;
                                        for (int i = 0; i < attributeItems.Count; i += batchSize)
                                        {
                                            var batchAttributes = attributeItems.Skip(i).Take(batchSize).ToList();

                                            logger.InfoLog($"预警点回写数据，Data:{JsonConvert.SerializeObject(batchAttributes)}");

                                            int result = await TpriClient.BatchWriteValuesAsync(batchAttributes, DateTime.UtcNow);

                                            if (result == 200)
                                            {
                                                logger.InfoLog($"预警点回写成功，共{batchAttributes.Count}条");
                                            }
                                            else
                                            {
                                                logger.InfoLog($"预警点回写失败Code:{result}");
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        logger.ErrorLog($"预警点回写批量发送异常：{ex.Message}");
                                    }
                                }
                            }
                        }

                        TimeSpan ts = DateTime.Now - dt;
                        int sleepTime = cycle - (int)ts.TotalMilliseconds;
                        Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog($"预警点回写任务异常：{ex.Message}");
                    }
                }
            });
        }

        /// <summary>
        /// 前端手动调整预警点的上下限值后，后端实时更新
        /// </summary>
        private static void StartUpdateWarnPointUpLowLimitTask()
        {
            Task.Run(() =>
            {
                while (true)
                {
                    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                    {
                        try
                        {
                            var cldWarnpoints = warnContext.CldWarnpoints.Select(w => new { w.PointName, w.UpLimit, w.LowLimit, w.TimeDurationThreshold, w.ModelOrrule });
                            foreach (var item in cldWarnpoints)
                            {
                                object warnPoint = GetWarnPointForLimitSync(item);
                                if (warnPoint is not null)
                                {
                                    UpdateWarnPointLimits(warnPoint, item);
                                }
                            }

                            Thread.Sleep(1000);
                        }
                        catch (Exception ex)
                        {
                            logger.ErrorLog("UpdateWarnPointUpLowLimit：" + ex.Message);
                        }
                    }
                }
            });
        }

        private static object GetWarnPointForLimitSync(dynamic item)
        {
            object warnPoint = null;
            string pointName = item.PointName;

            if (item.ModelOrrule == 0)
            {
                if (RTDDict.TryGetValue(pointName, out var warnList))
                {
                    lock (warnList)
                    {
                        foreach (object obj in warnList)
                        {
                            if (obj is LAExWarn warn && warn.Runable)
                            {
                                warnPoint = warn;
                                break;
                            }
                        }
                    }
                }
            }
            else if (item.ModelOrrule == 1 && RTDDict_Rule.ContainsKey(pointName))
            {
                object obj = RTDDict_Rule[pointName];
                return RTDDict_Rule[pointName];
            }

            return warnPoint;
        }

        private static void UpdateWarnPointLimits(dynamic warnPoint, dynamic item)
        {
            if (!string.IsNullOrEmpty(item.UpLimit))
            {
                warnPoint.WarnUpLimit = Convert.ToSingle(item.UpLimit);
            }
            if (!string.IsNullOrEmpty(item.LowLimit))
            {
                warnPoint.WarnLowLimit = Convert.ToSingle(item.LowLimit);
            }
            warnPoint.DelayTime = item.TimeDurationThreshold ?? 0;
        }

        /// <summary>
        /// 获取锅炉效率计算相关数据
        /// </summary>
        private static void StartGetBoilerDataTask()
        {
            if (!configInfo.enableGetBoilerData) return;

            Task.Run(() =>
            {
                while (true)
                {
                    DateTime dt = DateTime.Now;
                    if (hasRun)
                    {
                        GetUnitOther(configInfo.boilerdataapiurl);
                    }
                    TimeSpan ts = DateTime.Now - dt;
                    int sleepTime = 5000 - (int)ts.TotalMilliseconds;
                    Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
                }
            });
        }

        ///// <summary>
        ///// 获取吹会流量和辅汽流量
        ///// </summary>
        //private static void StartGetChAndFqDataTask()
        //{
        //    //if (!configInfo.enableGetChAndFqData) return;
        //    Task.Run(() =>
        //    {
        //        while (true)
        //        {
        //            try
        //            {
        //                DateTime dt = DateTime.Now;

        //                if (hasRun)
        //                {
        //                    GetChAndFq();
        //                }

        //                TimeSpan ts = DateTime.Now - dt;
        //                int sleepTime = 3000 - (int)ts.TotalMilliseconds;
        //                Thread.Sleep(sleepTime > 0 ? sleepTime : 0);
        //            }
        //            catch (Exception ex)
        //            {
        //                logger.ErrorLog("获取吹会流量和辅汽流量任务异常: " + ex.Message);
        //            }
        //        }
        //    });
        //}

        //public static List<double> GetPointsValue(string pvapiurl, List<string> points)
        //{
        //    try
        //    {
        //        HttpClient client = new HttpClient();
        //        points = points.Select(point => point.Replace($"{configInfo.sysUnit}_", "").ToUpper()).ToList();

        //        var json = JsonConvert.SerializeObject(points);
        //        var content = new StringContent(json, Encoding.UTF8, "application/json");
        //        var response = client.PostAsync(pvapiurl, content).Result;
        //        if (response.IsSuccessStatusCode)
        //        {
        //            var responseContent = response.Content.ReadAsStringAsync().Result;
        //            Dictionary<string, string> dictPointValue = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseContent);


        //            // 将字符串值转换为 double
        //            Dictionary<string, double> dictDoubleValues = dictPointValue.ToDictionary(kvp => kvp.Key, kvp => double.Parse(kvp.Value));
        //            return dictDoubleValues.Values.ToList();

        //        }

        //        return null;
        //    }
        //    catch (Exception ex)
        //    {

        //        logger.ErrorLog(ex.Message);
        //        return null;
        //    }
        //}


        /// <summary>
        /// 将新的接口返回格式转换为LastValue格式
        /// </summary>
        /// <param name="newResponseData">新的接口返回数据 Dictionary<string, string></param>
        /// <returns>转换后的LastValue列表</returns>
        private static List<LastValue> ConvertToLastValueList(Dictionary<string, string> newResponseData)  //dongguan
        {
            var lastValueList = new List<LastValue>();
            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            foreach (var kvp in newResponseData)
            {
                if (double.TryParse(kvp.Value, out double value))
                {
                    lastValueList.Add(new LastValue
                    {
                        tag = kvp.Key,
                        value = value,
                        dateTime = now
                    });
                }
                else
                {
                    // 如果解析失败，记录日志并设置为null
                    logger.ErrorLog($"无法解析点值: {kvp.Key} = {kvp.Value}");
                    lastValueList.Add(new LastValue
                    {
                        tag = kvp.Key,
                        value = null,
                        dateTime = now
                    });
                }
            }

            return lastValueList;
        }


        private static DateTime engineStartTime = DateTime.MinValue;

        public static void UpateVarSystemPointAsync(string url)
        {
            Task.Run(() =>
            {

                try
                {
                    //var newCommPoints = CommPoints.Distinct(StringComparer.OrdinalIgnoreCase).Select(point => point).ToList();
                    // var newCommPoints = from x in CommPoints.Distinct(StringComparer.Ordinal).Select(point => point)
                    //                     select x.Replace(configInfo.OldDcsPrefix, configInfo.NewDcsPrefix).Replace(configInfo.OldDcsSimplePrefix, configInfo.NewDcsSimplePrefix)
                    //     .Replace(configInfo.OldTcsPrefix, configInfo.NewTcsPrefix).Replace(configInfo.OldTcsSimplePrefix, configInfo.NewTcsSimplePrefix);

                    // 添加机组负荷点
                    var json = JsonConvert.SerializeObject(CommPoints);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = client.PostAsync(url, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content.ReadAsStringAsync().Result;
                        List<LastValue> lastValueList = null;

                        // 尝试解析多种不同的响应格式
                        try
                        {
                            // 首先尝试解析为 Response2<List<LastValue>> 格式
                            var responseMsg = JsonConvert.DeserializeObject<Response2<List<LastValue>>>(responseContent);
                            if (responseMsg?.Data != null)
                            {
                                lastValueList = responseMsg.Data;
                            }
                            else
                            {
                                // 再尝试解析为 Response2<Dictionary<string, string>> 格式
                                var responseMsg2 = JsonConvert.DeserializeObject<Response2<Dictionary<string, string>>>(responseContent);
                                if (responseMsg2?.Data != null)
                                {
                                    lastValueList = ConvertToLastValueList(responseMsg2.Data);
                                }
                                else
                                {
                                    // 最后兼容直接返回 Dictionary<string, string> 的格式
                                    var newResponseData = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseContent);
                                    if (newResponseData != null)
                                    {
                                        lastValueList = ConvertToLastValueList(newResponseData);
                                    }
                                }
                            }
                        }
                        catch
                        {
                            //临时解决，最终要统一为var responseMsg = JsonConvert.DeserializeObject<Response2<List<LastValue>>>(responseContent);
                            try
                            {
                                var responseMsg2 = JsonConvert.DeserializeObject<Response2<Dictionary<string, string>>>(responseContent);
                                if (responseMsg2?.Data != null)
                                {
                                    lastValueList = ConvertToLastValueList(responseMsg2.Data);
                                }
                                else
                                {
                                    var newResponseData = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseContent);
                                    if (newResponseData != null)
                                    {
                                        lastValueList = ConvertToLastValueList(newResponseData);
                                    }
                                }
                            }
                            catch (Exception parseEx)
                            {
                                logger.ErrorLog($"无法解析响应格式: {parseEx.Message}");
                                return;
                            }
                        }

                        // 处理解析后的数据
                        if (lastValueList != null)
                        {
                            foreach (var item in lastValueList)
                            {
                                //if (item.tag == "dcs_amfp_10" || item.tag == "dcs_dcstofgdao04")
                                //{
                                //    Random random = new Random();
                                //    // 生成 [minValue, maxValue) 范围的随机整数
                                //    int min = 100;
                                //    int max = 1000;
                                //    int randomNumber = random.Next(min, max); // 包含 min，不包含 max
                                //    item.value += randomNumber;
                                //}

                                double? pv = item.value;
                                if (item.tag == "dcs_20HAH51CT751".ToLower()) // 600
                                {
                                    //    if (engineStartTime != DateTime.MinValue && pv.HasValue)
                                    //    {
                                    //        // 计算已运行的分钟数
                                    //        double elapsedMinutes = (DateTime.Now - engineStartTime).TotalMinutes;
                                    //        // 根据运行时间调整值
                                    //        if (elapsedMinutes >= 0.25 && elapsedMinutes < 0.5)
                                    //        {
                                    //            pv = pv.Value + 100;
                                    //        }
                                    //        else if (elapsedMinutes >= 0.5 && elapsedMinutes < 0.75)
                                    //        {
                                    //            pv = pv.Value + 200;
                                    //        }
                                    //        else if (elapsedMinutes >= 0.75 && elapsedMinutes < 1)
                                    //        {
                                    //            pv = pv.Value + 300;
                                    //        }
                                    //        else if (elapsedMinutes >= 1 && elapsedMinutes < 1.25)
                                    //        {
                                    //            pv = pv.Value + 200;
                                    //        }
                                    //        else if (elapsedMinutes >= 1.25 && elapsedMinutes < 1.5)
                                    //        {
                                    //            pv = pv.Value + 100;
                                    //        }
                                    //        else if (elapsedMinutes >= 1.5 && elapsedMinutes < 1.75)
                                    //        {
                                    //            pv = pv.Value;
                                    //        }
                                    //        else if (elapsedMinutes >= 1.75 && elapsedMinutes < 2)
                                    //        {
                                    //            pv = pv.Value - 100;
                                    //        }
                                    //        else if (elapsedMinutes >= 2 && elapsedMinutes < 2.25)
                                    //        {
                                    //            pv = pv.Value - 200;
                                    //        }
                                    //        else if (elapsedMinutes >= 2.25 && elapsedMinutes < 2.5)
                                    //        {
                                    //            pv = pv.Value - 300;
                                    //        }
                                    //        else if (elapsedMinutes >= 2.5 && elapsedMinutes < 2.75)
                                    //        {
                                    //            pv = pv.Value - 200;
                                    //        }
                                    //        else if (elapsedMinutes >= 2.75 && elapsedMinutes < 3)
                                    //        {
                                    //            pv = pv.Value - 100;
                                    //        }
                                    //        else if (elapsedMinutes >= 3)
                                    //        {
                                    //            pv = pv.Value;
                                    //        }
                                    //    }
                                }
                                else if (item.tag == "DCS03_30MAG10CL_3SO")
                                {

                                }

                                if (pv != null)
                                {
                                    if (RTDDict_Rule.TryGetValue(item.tag, out var sysPointRule) && sysPointRule is IValueSetter setterRule)
                                    {
                                        setterRule.SetValue(pv);
                                    }

                                    if (RTDDict.TryGetValue(item.tag, out var sysPoints))
                                    {
                                        lock (sysPoints)
                                        {
                                            foreach (var point in sysPoints)
                                            {
                                                if (point is IValueSetter setterPoint)
                                                {
                                                    setterPoint.SetValue(pv);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.ErrorLog(ex.Message);
                }
            });
        }


        public static float dch = 0;//吹会流量
        public static float dfq = 0;//辅汽流量

        //public static void GetChAndFq()
        //{
        //    string p1 = "dcs_HCB10AA002ZO";
        //    string p2 = "dcs_hcb10aa101zz";
        //    string p3 = "dcs_J0LBG30AA001ZO_42";

        //    string zchPointName = "dcs_hcb10cf101c";
        //    string ychPointName = "dcs_hcb20cf101c";
        //    string fqPointName = "dcs_jocnyqcf103c";
        //    dch = 0;
        //    dfq = 0;

        //    AddCommPoints(new List<string> { p1, p2, p3, zchPointName, ychPointName, fqPointName });

        //    object p1Obj = GetFirstRunableWarn(p1);
        //    object p2Obj = GetFirstRunableWarn(p2);

        //    if (p1Obj != null && p2Obj != null)
        //    {
        //        if (((LD)p1Obj).buffer == true && ((LA)p2Obj).buffer > 1.0)
        //        {
        //            object zchPointNameObj = GetFirstRunableWarn(zchPointName);
        //            object ychPointNameObj = GetFirstRunableWarn(ychPointName);

        //            if (zchPointNameObj != null && ychPointNameObj != null)
        //            {
        //                dch = ((LA)zchPointNameObj).buffer + ((LA)ychPointNameObj).buffer;
        //            }
        //        }
        //    }

        //    object p3Obj = GetFirstRunableWarn(p3);
        //    object fqPointNameObj = GetFirstRunableWarn(fqPointName);

        //    if (p3Obj != null && fqPointNameObj != null)
        //    {
        //        if (((LD)p3Obj).buffer == true)
        //        {
        //            dfq = ((LA)fqPointNameObj).buffer;
        //        }
        //    }
        //}

        public static void AddCommPoints(List<string> pns)
        {
            for (int i = 0; i < pns.Count; i++)
            {
                if (!CommPoints.Contains(pns[i]))
                {
                    CommPoints.Add(pns[i]);
                }
            }
        }
        /// <summary>
        /// 获取锅炉效率计算相关数据
        /// </summary>
        /// <param name="boilerdataapiurl"></param>
        public static void GetUnitOther(string url)
        {
            try
            {
                eletodaysum2 = InfluxDBHelp.GetEletodaysum();

                var httpRequestMessage = client.GetAsync(configInfo.pageinputapiurl).Result;
                if (httpRequestMessage.IsSuccessStatusCode)
                {
                    var responseContent = httpRequestMessage.Content.ReadAsStringAsync().Result;
                    List<PageInput> pageInputs = JsonConvert.DeserializeObject<List<PageInput>>(responseContent);
                    if (pageInputs?.Count > 0)
                    {
                        string dt = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                        //pageInputDict = new Dictionary<string, double>();
                        foreach (var item in pageInputs)
                        {
                            if (item.code == "dcs02_other1001")//燃煤热值
                            {
                                if (DateTime.Now.Date != lastCacheDate.Date)
                                {
                                    if (qnetarQueue.Count >= 7)
                                    {
                                        qnetarQueue.Dequeue();
                                    }
                                    qnetarQueue.Enqueue(item.Value * 238.89);
                                    lastCacheDate = DateTime.Now.Date;
                                }

                                pageInputDict["pageinput_qnetar"] = qnetarQueue.Average();
                            }
                            else if (item.code == "other1002")//挥发分
                            {
                                pageInputDict["pageinput_vad"] = item.Value;
                            }
                            else if (item.code == "other1003")//灰分
                            {
                                pageInputDict["pageinput_aad"] = item.Value;
                            }
                            else if (item.code == "other1005")//水分
                            {
                                pageInputDict["pageinput_mar"] = item.Value;
                            }
                        }

                        foreach (var item in pageInputDict)
                        {
                            object sysPoint = GetFirstRunableWarn(item.Key);
                            if (sysPoint != null)
                            {
                                if (sysPoint is LA)
                                {
                                    ((LA)sysPoint).buffer = (float)item.Value;
                                }
                            }
                        }

                        InfluxDBHelp.BatchInsert(pageInputDict);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message);
            }
        }

        public static double GetRealTimeValue(string pn)
        {
            if (pn.Contains("."))
            {
                string fromAlgName = pn.Split('.')[0];
                string fromPinName = pn.Split('.')[1];

                for (int i = 0; i < controllerList.Count; i++)
                {
                    if (controllerList[i].FunctionInstanceDict.ContainsKey(fromAlgName))
                    {
                        Function function = controllerList[i].FunctionInstanceDict[fromAlgName];

                        FieldInfo pinvalue = function.GetType().GetField(fromPinName);
                        if (pinvalue != null)
                        {
                            object OutValue = pinvalue.GetValue(function);
                            if (OutValue is LA)
                            {
                                return ((LA)OutValue).buffer;
                            }
                            else if (OutValue is LD)
                            {
                                return ((LD)OutValue).buffer ? 1 : 0;
                            }
                        }
                    }
                }
            }
            else
            {
                object obj = GetFirstRunableWarn(pn);
                if (obj != null)
                {
                    if (obj is LA)
                    {
                        return ((LA)obj).buffer;
                    }
                    else if (obj is LD)
                    {
                        return ((LD)obj).buffer ? 1 : 0;
                    }
                }
            }

            return -9999;
        }

        internal static List<WarnAlarm> LoadOpenWarnAlarms(WarnContext warnContext)
        {
            return warnContext.WarnAlarms
                .AsNoTracking()
                .Where(x => x.EndTime == DateTime.MinValue)
                .OrderBy(x => x.Id)
                .ToList();
        }

        private static void AddOrUpdateWarnAlarm(List<WarnAlarm> addMysqlWarnAlarmList, List<WarnAlarm> updateMysqlWarnAlarmList)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                if (addMysqlWarnAlarmList.Count > 0 || updateMysqlWarnAlarmList.Count > 0)
                {
                    if (addMysqlWarnAlarmList.Count > 0)
                    {
                        warnContext.WarnAlarms.AddRange(addMysqlWarnAlarmList);
                    }

                    if (updateMysqlWarnAlarmList.Count > 0)
                    {
                        warnContext.WarnAlarms.UpdateRange(updateMysqlWarnAlarmList);
                    }

                    warnContext.SaveChanges();
                    warnAlarmList = LoadOpenWarnAlarms(warnContext);
                }
            }
        }
        public static List<Xunyou> GetxunyoudataTotalChart(xunyoudataRequest request)
        {
            using var warnContext = new WarnContext(configInfo.mysqlConn);

            // 获取专家数据
            DateTime start = DateTime.Parse(request.Starttime);
            DateTime end = DateTime.Parse(request.Endtime);
            var expertICList = warnContext.CldIndexconditionscompare
                .Where(c => c.Sj >= start && c.Sj <= end && c.comparetime.HasValue)
                .ToList();

            // 全部标准数据拉到内存
            var standardICList = warnContext.CldIndexconditions.ToList();

            // 转成时间戳字典，便于快速查找
            var standardICDict = standardICList
                .GroupBy(x => ((DateTimeOffset)x.Sj.Value).ToUnixTimeSeconds())
                .ToDictionary(g => g.Key, g => g.First());

            var xunyoulist = new List<Xunyou>();
            foreach (var expert in expertICList)
            {
                var ts = ((DateTimeOffset)expert.comparetime.Value).ToUnixTimeSeconds();
                var matched = standardICDict.TryGetValue(ts, out var standard) ? standard : null;

                xunyoulist.Add(new Xunyou
                {
                    steadydata = expert,
                    standarddata = matched
                });
            }

            return xunyoulist;
        }
        public static string Getxunyoudataadvice(adviseRequest request)
        {
            if (!DateTime.TryParse(request.Steadytime, out DateTime targetTime))
            {
                // 处理解析失败的情况，例如返回 null 或抛出异常
                return null;
            }

            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                var result = warnContext.XunYoudata
                    .Where(x => x.steadytime.HasValue && x.steadytime.Value == targetTime && x.unit == "2DCS")
                    .OrderByDescending(x => x.standardtime)
                    .FirstOrDefault();

                return result?.json;
            }
        }

        public static bool SetEnableFC(EInfo eInfo)
        {
            //模型实例的启停，根据模型实例名称找到blockid，再根据blockid在warnpoint表找到相关记录，再根据warnstatus更新RTDDict
            foreach (var controller in controllerList)
            {
                if (controller.FunctionInstanceDict.TryGetValue(eInfo.InstantName, out Function function))
                {
                    function.Runable = eInfo.CurValue;
                    if (modelWarnPoint.TryGetValue(eInfo.InstantName, out var warnPoints) && warnPoints.Count > 0)
                    {
                        foreach (var cldWarnpoint in warnPoints)
                        {
                            object obj = GetFirstRunableWarn(cldWarnpoint.PointName);
                            if (obj != null)
                            {
                                ((LAExWarn)obj).Runable = eInfo.CurValue;
                            }
                        }
                    }
                }
                return true;
            }
            return false;
        }

        public static void ReInitial()
        {
            Stop();
            Initial();
            Run();
        }

        public static Function CreateFcInstance(string fcName)
        {
            object curInstance = null;
            try
            {
                foreach (var assembly in assemblyList)
                {
                    curInstance = assembly.CreateInstance($"FunctionCode.{fcName}", false);
                    if (curInstance != null)
                    {
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"FunctionCode.{fcName}" + ex.Message);
            }
            return curInstance != null ? (Function)curInstance : null;
        }

        private static readonly Dictionary<string, DateTime> dllLastModifiedTimes = new Dictionary<string, DateTime>();
        private static readonly HashSet<string> loadedDllPaths = new HashSet<string>();

        public static void LoadDll()
        {
            if (assemblyList == null)
                assemblyList = new List<Assembly>();
            if (fcTypeList == null)
                fcTypeList = new List<Type>();
            if (secondCalcPinNameList == null)
                secondCalcPinNameList = new Dictionary<string, List<string>>();

            List<string> dllList = GetDllList();
            bool hasNewOrUpdatedDll = false;

            // 支持并行加载DLL以提高效率
            Parallel.ForEach(dllList, dllPath =>
            {
                DateTime lastWriteTime = File.GetLastWriteTime(dllPath);
                bool needToLoad = false;

                lock (_lock) // 使用已有的_lock对象进行线程同步
                {
                    // 检查DLL是否是新的或已更新
                    if (!dllLastModifiedTimes.TryGetValue(dllPath, out DateTime savedTime) ||
                        lastWriteTime > savedTime ||
                        !loadedDllPaths.Contains(dllPath))
                    {
                        needToLoad = true;
                        dllLastModifiedTimes[dllPath] = lastWriteTime;
                        loadedDllPaths.Add(dllPath);
                        hasNewOrUpdatedDll = true;
                    }
                }

                if (needToLoad)
                {
                    LoadSingleDll(dllPath);
                }
            });

            // 只在有新DLL或更新时重新加载类型
            if (hasNewOrUpdatedDll)
            {
                LoadedFcTypes();
            }

            logger.InfoLog("DLL动态加载完成！");
        }

        public static int GetSheetIdByModelName(string name)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                PrjSheet prjSheet = warnContext.PrjSheets.FirstOrDefault(x => x.SheetName.Contains(name));
                return prjSheet?.Id ?? 0;
            }
        }

        /// <summary>
        /// Reloads a specific DLL by its path.
        /// </summary>
        /// <param name="dllPath">The path of the DLL to reload.</param>
        public static bool ReloadModel(string modelName)
        {
            try
            {
                if (string.IsNullOrEmpty(modelName)) return false;

                string dllName = modelName + ".dll";
                string dllPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DynamicCompileFcLib", "WarnDiagnosis", dllName);
                if (!File.Exists(dllPath))
                {
                    logger.InfoLog($"ReloadModel {modelName}:{dllPath}不存在！");
                    return false;
                }

                int sheetid = GetSheetIdByModelName(modelName);
                logger.InfoLog($"ReloadModel {modelName}:Excute GetSheetIdByModelName OK 返回 {sheetid}");
                if (sheetid != 0)
                {
                    var existingAssembly = assemblyList.FirstOrDefault(a => a.ManifestModule.ScopeName == dllName);
                    if (existingAssembly != null)
                    {
                        assemblyList.Remove(existingAssembly);
                        fcTypeList.RemoveAll(t => t.Assembly == existingAssembly);
                        fcTypeDict.Remove(modelName);
                    }
                    LoadSingleDll(dllPath);
                    logger.InfoLog($"ReloadModel {modelName}:Excute LoadSingleDll OK");
                    foreach (Type type in fcTypeList)
                    {
                        if (!fcTypeDict.ContainsKey(type.Name))
                        {
                            Function functionInstance = CreateFcInstance(type.Name);
                            if (functionInstance != null)
                            {
                                fcTypeDict.Add(type.Name, functionInstance);
                                break;
                            }
                        }
                    }

                    logger.InfoLog($"ReloadModel {modelName}:Excute CreateFcInstance OK");
  
                    ReinitializeSheet(sheetid);

                    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                    {
                        cldWarnpointList = warnContext.CldWarnpoints.ToList();
                    }
                    logger.InfoLog($"ReloadModel {modelName}:Excute ReinitializeSheet OK");
                }
                else
                {
                    //模型实例被删除，删除缓存中的模型实例及dll
                    hasRun = false;
                    foreach (var controller in controllerList)
                    {
                        var functionToRemove = controller.FunctionInstanceDict.Values.FirstOrDefault(x => x.Name == modelName);
                        if (functionToRemove != null)
                        {
                            var keyToRemove = controller.FunctionInstanceDict.FirstOrDefault(x => x.Value == functionToRemove).Key;
                            controller.FunctionInstanceDict.Remove(keyToRemove);
                            File.Delete(dllPath);
                            break;
                        }
                    }
                    hasRun = true;
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"ReloadModel {modelName}:" + ex.Message);
                hasRun = true;
                return false;
            }
        }

        /// <summary>
        /// Gets the list of DLLs to load.
        /// </summary>
        /// <returns>A list of DLL paths.</returns>
        private static List<string> GetDllList()
        {
            List<string> dllList = new List<string>();
            dllList.Add(AppDomain.CurrentDomain.BaseDirectory + "FunctionCode.dll");

            string fdDir = AppDomain.CurrentDomain.BaseDirectory + "DynamicCompileFcLib";
            if (Directory.Exists(fdDir))
            {
                string[] fdDlls = Directory.GetFiles(fdDir, "*.dll", SearchOption.AllDirectories);
                if (fdDlls.Length > 0)
                {
                    dllList.AddRange(fdDlls);
                }
            }

            return dllList;
        }

        /// <summary>
        /// Loads a single DLL and adds its types to the global lists.
        /// </summary>
        /// <param name="dllPath">The path of the DLL to load.</param>
        private static void LoadSingleDll(string dllPath)
        {
            try
            {
                // 使用内存映射优化文件读取
                using (var fileStream = new FileStream(dllPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (var memoryStream = new MemoryStream((int)fileStream.Length))
                {
                    fileStream.CopyTo(memoryStream);
                    byte[] fileData = memoryStream.ToArray();

                    Assembly assembly = Assembly.Load(fileData);

                    lock (_lock) // 使用线程同步保护集合
                    {
                        assemblyList.Add(assembly);

                        // 添加导出的类型到全局列表
                        Type[] types = assembly.GetExportedTypes();
                        fcTypeList.AddRange(types);
                    }

                    // 加载引用的程序集
                    AssemblyName[] referencedAssemblies = assembly.GetReferencedAssemblies();
                    LoadAssembly(referencedAssemblies);
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"加载DLL '{dllPath}' 失败: {ex.Message}");
            }
        }

        /// <summary>
        /// Processes the loaded types to populate secondCalcPinNameList and fcTypeDict.
        /// </summary>
        private static void LoadedFcTypes()
        {
            foreach (Type type in fcTypeList)
            {
                if (fcTypeDict.ContainsKey(type.Name))
                {
                    continue;
                }

                Function functionInstance = CreateFcInstance(type.Name);
                if (functionInstance == null)
                {
                    continue;
                }

                fcTypeDict.Add(type.Name, functionInstance);

                if (functionInstance.FcType == Function.enumType.SC || functionInstance.FcType == Function.enumType.ICO)
                {
                    if (!secondCalcPinNameList.ContainsKey(type.Name))
                    {
                        secondCalcPinNameList.Add(type.Name, new List<string>());

                        foreach (FieldInfo fileInfo in type.GetFields())
                        {
                            IList<CustomAttributeData> customAttributeDataList = fileInfo.GetCustomAttributesData();
                            if (customAttributeDataList.Count > 0)
                            {
                                IList<CustomAttributeTypedArgument> customAttributeTypedArgumentList = customAttributeDataList[0].ConstructorArguments;
                                if (customAttributeTypedArgumentList.Count > 0)
                                {
                                    int pinType = (int)customAttributeTypedArgumentList[0].Value;
                                    if (pinType == 1) // Output
                                    {
                                        if (fileInfo.Name != "_ENO")
                                        {
                                            secondCalcPinNameList[type.Name].Add(fileInfo.Name);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Loads referenced assemblies recursively.
        /// </summary>
        /// <param name="arr">The list of assembly names to load.</param>
        private static void LoadAssembly(AssemblyName[] arr)
        {
            Assembly[] loadedAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            List<string> names = loadedAssemblies.Select(a => a.FullName).ToList();

            foreach (AssemblyName aname in arr)
            {
                if (!names.Contains(aname.FullName))
                {
                    try
                    {
                        Assembly loadedAssembly = Assembly.Load(aname);
                        assemblyList.Add(loadedAssembly);

                        // Recursively load referenced assemblies
                        AssemblyName[] referencedAssemblies = loadedAssembly.GetReferencedAssemblies();
                        LoadAssembly(referencedAssemblies);
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog(ex.Message);
                    }
                }
            }
        }

        public static Dictionary<string, List<CldWarnpoint>> modelwarnpointbyNameDict = new Dictionary<string, List<CldWarnpoint>>();
        private static void InitSystemPoint()
        {
            warnRValueDict = new Dictionary<string, List<WarnRValue>>();
            ruleWarnPoints = new List<string>();
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                faultDiagnosisList = warnContext.FaultDiagnosis.ToList();
                cldWarnpointList = warnContext.CldWarnpoints.ToList();
                warnAlarmList = LoadOpenWarnAlarms(warnContext);
                parawarnsList = warnContext.ParaWarns.ToList();
                CfgVarsystemList = warnContext.CfgVarsystems.ToList();
                List<CfgVarsystem> invalidCfgVarsystems = CfgVarsystemList.Where(x => string.IsNullOrWhiteSpace(x.Name)).ToList();
                if (invalidCfgVarsystems.Count > 0)
                {
                    logger.ErrorLog($"cfg_varsystem存在{invalidCfgVarsystems.Count}条Name为空的无效记录，ID：{string.Join(",", invalidCfgVarsystems.Select(x => x.Id))}，启动时已跳过。");
                    CfgVarsystemList = CfgVarsystemList.Where(x => !string.IsNullOrWhiteSpace(x.Name)).ToList();
                }

                List<string> pnList = CfgVarsystemList.Select(x => x.Name!).ToList();

                List<CldFcblock> cldFcblocks = warnContext.CldFcblocks.ToList();
                List<CldFcinput> CldFcinputList = warnContext.CldFcinputs.ToList();
                List<MetaFcmaster> CldFcmasterList = warnContext.MetaFcmasters.ToList();

                warnRValueDict = (from block in cldFcblocks
                                  join input in CldFcinputList on block.Id equals input.CldFcblockId
                                  join metafcmaster in CldFcmasterList on block.FunctionName equals metafcmaster.FunctionName
                                  join warnPoint in cldWarnpointList on new { BlockId = block.Id, input.PointName } equals new { BlockId = warnPoint.CldFcblockId, warnPoint.PointName }
                                  where input.PinName.StartsWith("IN") && warnPoint.ModelOrrule == 0
                                  select new WarnRValue
                                  {
                                      AlgorithmName = block.AlgName,
                                      WarnRTableName = input.PointName.ToTableName() + "_r",
                                      OutPinName = block.FunctionName.StartsWith("ANN") ? "OUT_R1" : $"OUT_R{input.PinName.Substring(2)}"
                                  }).GroupBy(x => x.AlgorithmName).ToDictionary(s => s.Key, s => s.ToList());


                InitializeModelWarnPoints(pnList, cldFcblocks, warnContext);
                InitializeRuleWarnPoints(pnList);
                InitializeRemainingSystemPoints();
                pointsList = CfgVarsystemList;
            }

            //#region 创建能效预警点目标值表
            //string[] economiccfgArray = economiccfgList.Select(x => x.pointName.ToTableName() + "_design").ToArray();
            //TDengineHelp.CreateTablesByArray(economiccfgArray);
            //#endregion
        }


        /// <summary>
        /// 初始化模型预警点
        /// </summary>
        /// <param name="pnList"></param>
        /// <param name="cldFcblocks"></param>
        /// <param name="warnContext"></param>
        public static void InitializeModelWarnPoints(List<string> pnList, List<CldFcblock> cldFcblocks, WarnContext warnContext)
        {
            if (cldWarnpointList.Count == 0) return;
            List<MetaFcmaster> metaFcmasters = warnContext.MetaFcmasters.ToList();

            Dictionary<int, List<CldWarnpoint>> warnpointbyIdDict = cldWarnpointList.GroupBy(x => x.CldFcblockId).ToDictionary(s => s.Key, s => s.ToList());
            var varBlocks = warnpointbyIdDict.Keys.Join(cldFcblocks, x => x, y => y.Id, (x, y) => new { blcokid = x, fcname = y.FunctionName, algname = y.AlgName }).
                                                   Join(metaFcmasters, x => x.fcname, y => y.FunctionName, (x, y) => new { blcokid = x.blcokid, algname = x.algname, sysid = y.PrjSystemId, modelid = y.Id }).ToList();

            foreach (var item in warnpointbyIdDict)
            {
                var block = varBlocks.Find(x => x.blcokid == item.Key);
                if (block == null) continue;
                modelWarnPoint.Add(block.algname, item.Value);

                for (int i = 0; i < item.Value.Count; i++)
                {
                    CldWarnpoint cldWarnpoint = item.Value[i];
                    string modelWarnPointName = cldWarnpoint.PointName;
                    if (!pnList.Contains(modelWarnPointName))
                    {
                        logger.ErrorLog($"{modelWarnPointName}在点表中不存在！");
                        continue;
                    }

                    string warnRTbName = modelWarnPointName.ToTableName() + "_r";
                    if (!WarnRTableDict.ContainsKey(warnRTbName))
                    {
                        WarnRTableDict.Add(warnRTbName, $"CREATE TABLE {warnRTbName} (ts TIMESTAMP, pvalue FLOAT)");
                    }

                    string unit = cldWarnpoint.Unit ?? "";
                    int delayTime = cldWarnpoint.TimeDurationThreshold ?? 0;
                    int alarmLevel = cldWarnpoint.AlarmLevel ?? 0;
                    float? upLimit = cldWarnpoint.UpLimit.ToFloatOrNull();
                    float? lowLimit = cldWarnpoint.LowLimit.ToFloatOrNull();

                    int alarmType = cldWarnpoint.ModelOrrule ?? 0;
                    LAExWarn lAExWarn = new LAExWarn(QualityTypes.Good, cldWarnpoint.WarnStatus > 0, unit, upLimit, lowLimit, delayTime, alarmType, block.sysid ?? 0, block.modelid, alarmLevel, false, false, false, false, false, 0, 0, 0.0f, 0, 0.0f);
                    lAExWarn.WarnConstraint = string.IsNullOrEmpty(cldWarnpoint.WarnConstraint) || cldWarnpoint.WarnConstraint == "1=1" ? "" : cldWarnpoint.WarnConstraint;
                    lAExWarn.LimitAlarmCondition = string.IsNullOrEmpty(cldWarnpoint.LimitAlarmCondition) || cldWarnpoint.LimitAlarmCondition == "1=1" ? "" : cldWarnpoint.LimitAlarmCondition;
                    lAExWarn.IsAlarmSuspended = cldWarnpoint.IsAlarmSuspended == 1;
                    lAExWarn.DelayTimeLimitAlarm = cldWarnpoint.DelayTimeLimitAlarm ?? 0;
                    lAExWarn.FcBlockID = cldWarnpoint.CldFcblockId;
                    lAExWarn.PointName = cldWarnpoint.PointName;

                    RTDDict.AddOrUpdate(modelWarnPointName,
                        _ => new List<object> { lAExWarn },
                        (_, existingList) => { lock (existingList) { existingList.Add(lAExWarn); } return existingList; });
                }
            }
            logger.InfoLog("模型预警点初始化完成！");
        }


        /// <summary>
        /// 初始化规则预警点
        /// </summary>
        /// <param name="pnList"></param>
        public static void InitializeRuleWarnPoints(List<string> pnList)
        {
            if (cldWarnpointList.Count == 0) return;
            #region 初始化规则报警点
            foreach (var cldWarnpoint in cldWarnpointList)
            {
                if (cldWarnpoint.ModelOrrule == 1)
                {
                    string ruleWarnPointName = cldWarnpoint.PointName;
                    if (ruleWarnPointName == "d1_10pgb40cl101")
                    {

                    }
                    if (!pnList.Contains(ruleWarnPointName))
                    {
                        logger.ErrorLog($"{ruleWarnPointName}在点表中不存在！");
                        continue;
                    }

                    // 调用方法
                    var result = GetValidRulePointLimits(cldWarnpoint);

                    // 判断是否成功
                    if (!result.Success)
                    {
                        logger.InfoLog($"{ruleWarnPointName}规则预警点限值不正确，无法进行规则预警点初始化！");
                        continue;
                    }

                    float? up1Limit = result.Up1;
                    float? low1Limit = result.Low1;

                    float? up2Limit = result.Up2;
                    float? low2Limit = result.Low2;

                    float? up3Limit = result.Up3;
                    float? low3Limit = result.Low3;

                    int alarmType = cldWarnpoint.ModelOrrule ?? 1;

                    if (!RTDDict_Rule.ContainsKey(ruleWarnPointName))
                    {

                        CfgVarsystem cfgVarsystem = CfgVarsystemList.FirstOrDefault(x => x.Name == ruleWarnPointName);
                        if (cfgVarsystem.DataType == "LA")
                        {
                            LAExWarn lAExWarn = new LAExWarn(QualityTypes.Good, cldWarnpoint.WarnStatus > 0, cldWarnpoint.Unit, up1Limit, low1Limit, up2Limit, low2Limit, up3Limit, low3Limit, cldWarnpoint.TimeDurationThreshold ?? 0, alarmType, -1, -1, cldWarnpoint.AlarmLevel ?? 0, false, false, false, false, false, 0, 0, 0.0f, 0, 0.0f);
                            lAExWarn.WarnConstraint = string.IsNullOrEmpty(cldWarnpoint.WarnConstraint) || cldWarnpoint.WarnConstraint == "1=1" ? "" : cldWarnpoint.WarnConstraint;
                            lAExWarn.IsAlarmSuspended = cldWarnpoint.IsAlarmSuspended == 1;
                            lAExWarn.PointName = ruleWarnPointName;
                            lAExWarn.WarnUpUpMaxLimit = cldWarnpoint.UpUpMaxLimit.ToFloatOrNull();
                            lAExWarn.DelayTimeLimitAlarm = cldWarnpoint.DelayTimeLimitAlarm ?? 0;
                            RTDDict_Rule.TryAdd(ruleWarnPointName, lAExWarn);
                        }
                        else if (cfgVarsystem.DataType == "LD")
                        {
                            LDExWarn lDExWarn = new LDExWarn(QualityTypes.Good, cldWarnpoint.WarnStatus > 0, cldWarnpoint.Unit, up1Limit, low1Limit, cldWarnpoint.TimeDurationThreshold ?? 0, alarmType, false, cldWarnpoint.AlarmLevel ?? 0, false, 0, false, false);
                            lDExWarn.WarnConstraint = string.IsNullOrEmpty(cldWarnpoint.WarnConstraint) || cldWarnpoint.WarnConstraint == "1=1" ? "" : cldWarnpoint.WarnConstraint;
                            lDExWarn.IsAlarmSuspended = cldWarnpoint.IsAlarmSuspended == 1;
                            lDExWarn.PointName = ruleWarnPointName;
                            RTDDict_Rule.TryAdd(ruleWarnPointName, lDExWarn);
                        }
                    }

                    AddCommPoints(new List<string>() { ruleWarnPointName });
                }
            }

            logger.InfoLog("规则预警点初始化完成！");
            #endregion
        }

        /// <summary>
        /// 校验并获取规则点限制值
        /// </summary>
        /// <param name="cldWarnpoint">规则点对象</param>
        /// <returns>返回元组：(是否成功, 高1, 低1, 高2, 低2, 高3, 低3)</returns>
        public static (bool Success, float? Up1, float? Low1, float? Up2, float? Low2, float? Up3, float? Low3)
            GetValidRulePointLimits(CldWarnpoint cldWarnpoint)
        {
            // 定义失败时的返回值模板 (便于代码复用)
            var failResult = (Success: false, Up1: (float?)null, Low1: (float?)null,
                              Up2: (float?)null, Low2: (float?)null,
                              Up3: (float?)null, Low3: (float?)null);

            float? up1Limit = cldWarnpoint.UpLimit.ToFloatOrNull();
            float? low1Limit =cldWarnpoint.LowLimit.ToFloatOrNull();
            float? up2Limit = cldWarnpoint.UpUpLimit.ToFloatOrNull();
            float? low2Limit =cldWarnpoint.LowLowLimit.ToFloatOrNull();
            float? up3Limit = cldWarnpoint.Up3Limit.ToFloatOrNull();
            float? low3Limit =cldWarnpoint.Low3Limit.ToFloatOrNull();

            string pointName = cldWarnpoint.PointName;

            // 2. 全局基础校验：至少设置一个高1或低1
            if (!up1Limit.HasValue && !low1Limit.HasValue)
            {
                logger.InfoLog($"{pointName}配置无效：必须至少设置高1或低1报警限值");
                return failResult;
            }

            // 3. 高报警校验 (Up1 < Up2 < Up3)
            if (up3Limit.HasValue)
            {
                if (!up2Limit.HasValue || !up1Limit.HasValue)
                {
                    logger.InfoLog($"{pointName}已设置高3({up3Limit})，必须同时设置高2和高1");
                    return failResult;
                }
                if (up1Limit >= up2Limit || up2Limit >= up3Limit)
                {
                    logger.InfoLog($"{pointName}高限逻辑错误：需满足 高1({up1Limit}) < 高2({up2Limit}) < 高3({up3Limit})");
                    return failResult;
                }
            }
            else if (up2Limit.HasValue)
            {
                if (!up1Limit.HasValue)
                {
                    logger.InfoLog($"{pointName}已设置高2({up2Limit})，必须同时设置高1");
                    return failResult;
                }
                if (up1Limit >= up2Limit)
                {
                    logger.InfoLog($"{pointName}高限逻辑错误：需满足 高1({up1Limit}) < 高2({up2Limit})");
                    return failResult;
                }
            }

            // 4. 低报警校验 (Low3 < Low2 < Low1)
            if (low3Limit.HasValue)
            {
                if (!low2Limit.HasValue || !low1Limit.HasValue)
                {
                    logger.InfoLog($"{pointName}已设置低3({low3Limit})，必须同时设置低2和低1");
                    return failResult;
                }
                if (low3Limit >= low2Limit || low2Limit >= low1Limit)
                {
                    logger.InfoLog($"{pointName}低限逻辑错误：需满足 低3({low3Limit}) < 低2({low2Limit}) < 低1({low1Limit})");
                    return failResult;
                }
            }
            else if (low2Limit.HasValue)
            {
                if (!low1Limit.HasValue)
                {
                    logger.InfoLog($"{pointName}已设置低2({low2Limit})，必须同时设置低1");
                    return failResult;
                }
                if (low2Limit >= low1Limit)
                {
                    logger.InfoLog($"{pointName}低限逻辑错误：需满足 低2({low2Limit}) < 低1({low1Limit})");
                    return failResult;
                }
            }

            // 5. 交叉校验 (低1 < 高1)
            if (up1Limit.HasValue && low1Limit.HasValue && low1Limit >= up1Limit)
            {
                logger.InfoLog($"{pointName}逻辑错误：低1({low1Limit}) 不能 >= 高1({up1Limit})");
                return failResult;
            }

            // 6. 校验通过，返回成功状态和所有值
            return (true, up1Limit, low1Limit, up2Limit, low2Limit, up3Limit, low3Limit);
        }


        /// <summary>
        /// 初始化其他系统点
        /// </summary>
        private static void InitializeRemainingSystemPoints()
        {
            string SysPointName;
            string DataType;
            float laDefaultValue = 0.0f;
            bool ldDefaultValue = false;
            float MaxValue = 0.0f;
            float MinValue = 0.0f;
            float ForceValue = 0.0f;
            int alarmPriority;
            int satusChecking;

            foreach (CfgVarsystem var in CfgVarsystemList)
            {
                SysPointName = var.Name;
                DataType = var.DataType;
                ldDefaultValue = false;
                MaxValue = 0.0f;
                MinValue = 0.0f;
                ForceValue = 0.0f;

                if (string.IsNullOrWhiteSpace(SysPointName))
                {
                    logger.ErrorLog($"系统点配置无效：CfgVarsystem.Id={var.Id} 的 Name 为空，已跳过初始化。");
                    continue;
                }

                if (string.IsNullOrWhiteSpace(DataType))
                {
                    logger.ErrorLog($"系统点{SysPointName}配置无效：DataType为空，已跳过初始化。");
                    continue;
                }

                if (RTDDict.ContainsKey(SysPointName))
                {
                    continue;
                }

                string defaultValue = var.DefaultValue;
                if (!string.IsNullOrEmpty(defaultValue))
                {
                    if (DataType == "LA")
                    {
                        laDefaultValue = float.Parse(defaultValue);
                    }
                    else if (DataType == "LD")
                    {
                        if (defaultValue == "1")
                            defaultValue = "true";
                        else
                            defaultValue = "false";
                        ldDefaultValue = bool.Parse(defaultValue);
                    }
                }

                if (!string.IsNullOrEmpty(var.MaximunScale))
                    MaxValue = float.Parse(var.MaximunScale);

                if (!string.IsNullOrEmpty(var.MinimumScale))
                    MinValue = float.Parse(var.MinimumScale);

                if (!string.IsNullOrEmpty(var.ForceValue))
                    ForceValue = float.Parse(var.ForceValue);


                switch (DataType)
                {
                    case "LA":

                        RTDDict.TryAdd(SysPointName, new List<object>() { new LAExWarn(QualityTypes.Good, false, var.Unit, 0, 0, 0, 0, 0, 0, 0, false, false, false, false, false, MaxValue, MinValue, 0.0f, 0, laDefaultValue) });
                        break;
                    case "LD":
                        alarmPriority = var.AlarmPriority ?? 0;
                        satusChecking = var.StatusChecking ?? 0;

                        RTDDict.TryAdd(SysPointName, new List<object>() { new LDEx(QualityTypes.Good, false, false, false, 0, ldDefaultValue, alarmPriority, satusChecking) });
                        break;
                    case "LP":
                        RTDDict.TryAdd(SysPointName, new List<object>() { new LP32() });
                        break;
                }
            }

            logger.InfoLog("剩余系统点初始化完成！");
        }



        /// <summary>
        /// warnStateValue=-1:未找到对应的模型，warnStateValue=0:条件不满足未运行，1：未报警，2：未报警未确认，4：报警已确认，8：报警未确认
        /// </summary>
        /// <param name="algList"></param>
        /// <returns></returns>
        public static Dictionary<string, int> GetWarnInstanceAlarmState(List<string> algList)
        {
            Dictionary<string, int> dirt = new();
            for (int i = 0; i < controllerList.Count; i++)
            {
                if (controllerList[i].ID == HealthControllerID) continue;

                Dictionary<string, Function> fcInstanceDict = controllerList[i].FunctionInstanceDict;

                for (int j = 0; j < algList.Count; j++)
                {
                    int warnStateValue = -1;
                    string algName = algList[j];
                    if (fcInstanceDict.ContainsKey(algName))
                    {
                        if (fcInstanceDict[algName].FcType == Function.enumType.Warn)
                        {
                            warnStateValue = ((WarnFunction)fcInstanceDict[algName]).WarnState;
                            dirt.Add(algName, warnStateValue);
                        }
                    }
                }
            }
            return dirt;
        }

        public static Dictionary<string, object[]> GetWarnPointAlarmList(int sysID, int modelID)
        {
            var alarmEntries = new Dictionary<string, object[]>();

            foreach (var warnPoint in cldWarnpointList)
            {
                var pointName = warnPoint.PointName;
                object rtdObject = GetFirstRunableWarn(pointName);

                // 安全类型转换并检查空值
                if (!(rtdObject is LAExWarn exWarn))
                    continue;

                // 提前过滤不符合警报状态的条件
                if (exWarn.WarnState <= 2 || exWarn.IsAlarmSuspended)
                    continue;

                // 合并系统ID和模型ID的过滤条件
                bool isSysMatch = sysID == -1 || exWarn.SysID == sysID;
                bool isModelMatch = modelID == -1 || exWarn.ModelID == modelID;

                if (isSysMatch && isModelMatch)
                {
                    alarmEntries.TryAdd(pointName, new object[]
                    {
                        exWarn.WarnState,
                        exWarn.SysID,
                        exWarn.WarnAlarmStartTime,
                        exWarn.AlarmLevel ?? 1
                    });
                }
            }

            return alarmEntries;
        }

        public static List<object[]> GetWarnPointAlarmList2(int SysID, int ModelID)
        {
            var list = new List<object[]>();

            var warnpointSnapshot = cldWarnpointList;
            foreach (var point in warnpointSnapshot)
            {
                string pointName = point.PointName ?? "";
                object obj = null;

                // 根据 ModelOrrule 决定从哪个字典获取数据
                if (point.ModelOrrule == 1)
                {
                    // 规则点：从 RTDDict_Rule 获取
                    RTDDict_Rule.TryGetValue(pointName, out obj);
                }
                else if (point.ModelOrrule == 0)
                {
                    // 模型点：从 RTDDict 获取
                    obj = GetFirstRunableWarn(pointName);
                }

                // 使用接口统一处理
                if (obj != null && obj is IWarnModel warnItem)
                {
                    // 过滤：WarnState <= 2 或者已暂停的报警
                    if (warnItem.WarnState <= 2 || warnItem.IsAlarmSuspended)
                    {
                        continue;
                    }

                    // 校验 SysID 和 ModelID
                    bool sysMatch = (SysID == -1 || warnItem.SysID == SysID);
                    bool modelMatch = (ModelID == -1 || warnItem.ModelID == ModelID);

                    if (sysMatch && modelMatch)
                    {
                        var alarmData = new object[]
                        {
                            pointName,
                            warnItem.WarnState,
                            warnItem.SysID,
                            warnItem.WarnAlarmStartTime,
                            warnItem.AlarmLevel ?? 1,
                            warnItem.AlarmType,
                            warnItem.LimitAlarmType
                        };
                        list.Add(alarmData);
                    }
                }
            }

            // 按 AlarmLevel 升序，再按 AlarmType 降序排序
            return list.OrderBy(a => (int)a[4])
                       .ThenByDescending(a => (int)a[5])
                       .ToList();
        }

        public static Dictionary<string, byte> GetWarnPointStatusList(int SysID, int ModelID)
        {
            Dictionary<string, byte> dirt = new Dictionary<string, byte>();
            var warnpointSnapshot = cldWarnpointList;
            for (int i = 0; i < warnpointSnapshot.Count; i++)
            {
                string pointName = warnpointSnapshot[i].PointName;

                object obj = GetFirstRunableWarn(pointName);
                if (obj != null && obj is LAExWarn lAExWarn && lAExWarn.WarnState > 0 && !dirt.ContainsKey(pointName))
                {
                    bool isSysMatch = SysID == -1 || lAExWarn.SysID == SysID;
                    bool isModelMatch = ModelID == -1 || lAExWarn.ModelID == ModelID;

                    if (isSysMatch && isModelMatch)
                    {
                        dirt.Add(pointName, lAExWarn.WarnState);
                    }
                }
            }

            dirt.OrderBy(p => p.Value).ToDictionary(p => p.Key, o => o.Value);
            return dirt;
        }

        public static List<object[]> GetWarnPointStatusList2(int SysID, int ModelID)
        {
            var list = new List<object[]>();

            var warnpointSnapshot = cldWarnpointList;
            foreach (var point in warnpointSnapshot)
            {
                string pointName = point.PointName ?? "";
                object obj = null;

                if (pointName == "d1_10lab20cp101")
                {

                }
                if (point.ModelOrrule == 1)
                {
                    RTDDict_Rule.TryGetValue(pointName, out obj);
                }
                else if (point.ModelOrrule == 0)
                {
                    obj = GetFirstRunableWarn(pointName);
                }

                if (obj is IWarnModel warnItem)
                {
                    if (warnItem.WarnState > 0)
                    {
                        // 校验 SysID 和 ModelID
                        bool sysMatch = (SysID == -1 || warnItem.SysID == SysID);
                        bool modelMatch = (ModelID == -1 || warnItem.ModelID == ModelID);

                        if (sysMatch && modelMatch)
                        {
                            list.Add(new object[] { pointName, warnItem.AlarmType, warnItem.WarnState });
                        }
                    }
                }
            }

            // 4. 排序返回
            return list.OrderByDescending(item => Convert.ToInt32(item[2])).ToList();
        }


        public static List<Controller.FaultInfo> GetFaultList()
        {
            List<Controller.FaultInfo> tmpList = new List<Controller.FaultInfo>();
            for (int i = 0; i < controllerList.Count; i++)
            {
                List<Controller.FaultInfo> list = controllerList[i].FaultInfoList.Values.ToList().FindAll(x => x.Status == 1);
                tmpList.AddRange(list);
            }
            return tmpList;
        }

        public static Dictionary<string, Dictionary<string, object?>> GetLogicFcPinValue(Dictionary<string, List<string>> fcPins)
        {
            Dictionary<string, Dictionary<string, object?>> fcValues = new();
            foreach (var item in fcPins)
            {
                string algName = item.Key;
                Dictionary<string, object?> pinValues = new();
                for (int j = 0; j < controllerList.Count; j++)
                {
                    if (controllerList[j].FunctionInstanceDict.ContainsKey(algName))
                    {
                        Function function = controllerList[j].FunctionInstanceDict[algName];
                        for (int m = 0; m < item.Value.Count; m++)
                        {
                            string pinName = item.Value[m];
                            object objValue = null;
                            FieldInfo? fieldInfo = function.GetType().GetField(pinName);
                            if (fieldInfo != null)
                            {
                                object? obj = fieldInfo.GetValue(function);
                                if (obj is LA)
                                {
                                    objValue = ((LA)obj).buffer;
                                }
                                else if (obj is LD)
                                {
                                    objValue = ((LD)obj).buffer;
                                }
                                else if (obj is LP32)
                                {
                                    objValue = ((LP32)obj).buffer;
                                }
                                else
                                {
                                    objValue = obj;
                                }
                            }
                            pinValues.Add(pinName, objValue);
                        }
                    }
                }
                fcValues.Add(algName, pinValues);
            }

            return fcValues;
        }

        public static object? GetPointValue(string pointName)
        {
            if (string.IsNullOrEmpty(pointName))
            {
                return null;
            }

            if (!CommPoints.Contains(pointName))
            {
                CommPoints.Add(pointName);
            }

            object sysPoint = GetFirstRunableWarn(pointName);
            if (sysPoint != null)
            {
                if (sysPoint is LAExWarn)
                {
                    return (LAExWarn)sysPoint;
                }
                else if (sysPoint is LDEx)
                {
                    return (LDEx)sysPoint;
                }
                else if (sysPoint is LP32)
                {
                    return (LP32)sysPoint;
                }
            }
            return null;
        }


        public static object? GetWarnRulePointValue(string pointName)
        {
            if (string.IsNullOrEmpty(pointName))
            {
                return null;
            }

            if (!CommPoints.Contains(pointName))
            {
                CommPoints.Add(pointName);
            }



            if (!RTDDict_Rule.TryGetValue(pointName, out object warnRulePoint))
            {
                return null;
            }

            if (warnRulePoint != null)
            {
                if (warnRulePoint is LAExWarn)
                {
                    return (LAExWarn)warnRulePoint;
                }
                else if (warnRulePoint is LDEx)
                {
                    return (LDEx)warnRulePoint;
                }
                else if (warnRulePoint is LP32)
                {
                    return (LP32)warnRulePoint;
                }
            }
            return null;
        }

        public static bool SetWarnPointAck(string pointName)
        {
            object obj = GetFirstRunableWarn(pointName);
            if (obj != null)
            {
                if (obj != null && obj is LAExWarn)
                {
                    ((LAExWarn)obj).UnAck = false;
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        public static bool SetWarnPointAck2(string pointName, int alarmType)
        {
            if (alarmType != 0 && alarmType != 1)
                return false;

            if (alarmType == 0)
            {
                object syspoint = GetFirstRunableWarn(pointName);
                if (syspoint == null || syspoint is not LAExWarn warn)
                    return false;
                warn.UnAck = false;

            }
            else if (alarmType == 1)
            {
                if (RTDDict_Rule.TryGetValue(pointName, out var obj))
                {
                    if (obj is LAExWarn lAExWarn)
                    {
                        lAExWarn.Ack();
                    }
                    else if (obj is LDExWarn lDExWarn)
                    {
                        lDExWarn.Ack();
                    }
                }
                else
                {
                    return false;
                }
            }

            return true;
        }

        public static bool SetWarnFcAck(string algName)
        {
            return true;

            //for (int i = 0; i < controllerList.Count; i++)
            //{
            //    if (controllerList[i].warnPointDict.ContainsKey(algName))
            //    {
            //        foreach (var item in controllerList[i].warnPointDict[algName])
            //        {
            //            if (RTDDict.ContainsKey(item.Key))
            //            {
            //                if (RTDDict[item.Key] is LAExWarn)
            //                {
            //                    ((LAExWarn)RTDDict[item.Key]).unAck = false;
            //                }
            //            }
            //        }
            //    }
            //}
            //return true;
        }

        public static Dictionary<string, List<string>>? GetReference(string pointName)
        {
            for (int i = 0; i < controllerList.Count; i++)
            {
                if (controllerList[i].UsedPointsByFc.ContainsKey(pointName))
                {
                    return controllerList[i].UsedPointsByFc[pointName];
                }
            }

            return null;
        }

        /// <summary>
        /// 获取预警块的运行状态，返回字典中的value值：0表示未下装，1表示下装成功未运行，2表示已下装且运行,-1表示不是预警块
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, int> GetWarnInstanceRunState(List<string> algNames)
        {
            Dictionary<string, int> dirt = new Dictionary<string, int>();
            for (int i = 0; i < controllerList.Count; i++)
            {
                for (int k = 0; k < algNames.Count; k++)
                {
                    string algName = algNames[k];
                    if (controllerList[i].FunctionInstanceDict.ContainsKey(algName))
                    {
                        Function function = controllerList[i].FunctionInstanceDict[algName];
                        if (function.FcType == Function.enumType.Warn)
                        {
                            if (function.Runable)
                            {
                                dirt.Add(algName, 2);
                            }
                            else
                            {
                                dirt.Add(algName, 1);
                            }
                        }
                        else
                        {
                            dirt.Add(algName, -1);
                        }
                    }
                    else
                    {
                        if (!dirt.ContainsKey(algName))
                        {
                            dirt.Add(algName, 0);
                        }

                    }
                }
            }
            return dirt;
        }

        public static List<DSystem> dSystems;

        private static void InitController()
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                List<PrjController> prjControllerList = warnContext.PrjControllers.ToList();

                foreach (PrjController prjController in prjControllerList)
                {
                    Controller controller = new Controller(prjController.Id, configInfo.mysqlConn);
                    controllerList.Add(controller);
                }

                #region 动态初始化健康度控制器
                if (configInfo.enableHealth)
                {
                    dSystems = GetHealthInfo("健康度导入表.xlsx");
                    if (dSystems != null && dSystems.Count > 0)
                    {
                        Controller controllerHealth = new Controller(HealthControllerID, configInfo.mysqlConn);
                        controllerList.Add(controllerHealth);

                        using (WarnContext warnContext2 = new WarnContext(configInfo.mysqlEnergyanalySis))
                        {
                            List<Healthy> sysHealthyList = warnContext2.healthy.Where(x => x.Unit == "1DCS").ToList();
                            List<Devicehealthy> deviceHealthyList = warnContext2.devicehealthy.Where(x => x.Unit == "1DCS").ToList();

                            foreach (var item in dSystems)
                            {
                                foreach (var ddevice in item.Devices)
                                {
                                    ddevice.weight = (double)sysHealthyList.FirstOrDefault(x => x.Device == ddevice.ID.ToString())?.Weight;
                                    foreach (var dHealthIndicator in ddevice.HealthIndicators)
                                    {
                                        dHealthIndicator.weight = (double)deviceHealthyList.FirstOrDefault(x => x.Point == dHealthIndicator.IndicatorID.ToString())?.Weight;
                                    }
                                }
                            }
                        }
                    }
                }

                #endregion

                #region 动态初始化报警控制器
                alarmConfig = AlarmHelp.GetAlarmInfo("alarm.xlsx");
                if (alarmConfig != null && alarmConfig.HasData)
                {
                    Controller controllerAlarm = new Controller(AlarmControllerID, configInfo.mysqlConn);
                    controllerList.Add(controllerAlarm);
                }
                #endregion
            }
        }

        public static void Run()
        {
            hasRun = true;
        }

        public static void Stop()
        {
            hasRun = false;
        }

        /// <summary>
        /// 加载回写点
        /// </summary>
        public static bool LoadWriteBackPoints()
        {

            WriteBackPointDict.Clear();
            string? path = AppContext.BaseDirectory + "/DataCfg.csv";
            if (path == null || !System.IO.File.Exists(path))
                return false;

            bool res = false;
            System.IO.FileStream fs = new FileStream(path, FileMode.Open);
            System.IO.StreamReader sr = new StreamReader(fs, Encoding.UTF8);


            string[] strs = null;
            string linestring = "";
            string temstr1 = "";


            try
            {
                linestring = sr.ReadLine(); //mycount++;
                while (linestring != null)
                {
                    linestring = linestring.Trim();
                    if (linestring == "" || linestring.StartsWith("\\\\") || linestring.StartsWith("//"))
                    {
                        linestring = sr.ReadLine();
                        continue;
                    }
                    strs = linestring.Split(',');
                    if (strs != null && strs.Length > 1)
                    {
                        if (!WriteBackPointDict.ContainsKey(strs[0]))
                        {
                            WriteBackPointDict.Add(strs[0], strs[1]);
                        }
                    }
                    linestring = sr.ReadLine();
                }
                res = true;
            }
            catch (Exception ex)
            {


            }
            finally
            {
                try
                {
                    sr.Close();
                    fs.Close();
                }
                catch { }
                sr = null;
                fs = null;
            }
            strs = null;
            return res;
        }

        public static bool SetForceValueToPoint([FromBody] ForcePointInfo forcePointInfo)
        {
            if (forcePointInfo == null || string.IsNullOrEmpty(forcePointInfo.Name))
            {
                logger.ErrorLog("forcePointInfo 或 forcePointInfo.Name 为空！");
                return false;
            }

            if (!forcePointInfo.Name.Contains("."))
            {
                return HandleSystemPoint(forcePointInfo);
            }
            else
            {
                return HandleAlgorithmPoint(forcePointInfo);
            }
        }

        private static bool HandleSystemPoint(ForcePointInfo forcePointInfo)
        {
            object sysPoint = GetFirstRunableWarn(forcePointInfo.Name);
            if (sysPoint == null)
            {
                logger.ErrorLog($"{forcePointInfo.Name}在点表中不存在！");
                return false;
            }

            if (forcePointInfo.IsForce != 0 && forcePointInfo.IsForce != 1)
                return false;

            bool isForce = forcePointInfo.IsForce == 1;

            if (sysPoint is LA la)
            {
                la.IsForced = forcePointInfo.IsForce;
                if (isForce) la.ForceValue = Convert.ToSingle(forcePointInfo.Value);
                return true;
            }
            else if (sysPoint is LD ld)
            {
                ld.IsForced = forcePointInfo.IsForce;
                if (isForce)
                {
                    if (float.TryParse(forcePointInfo.Value, out float fv))
                        ld.ForceValue = fv > 0;
                    else if (bool.TryParse(forcePointInfo.Value, out bool bv))
                        ld.ForceValue = bv;
                }
                return true;
            }

            return false;
        }

        private static bool HandleAlgorithmPoint(ForcePointInfo forcePointInfo)
        {
            string[] parts = forcePointInfo.Name.Split('.');
            string algName = parts[0];
            string pinName = parts[1];

            foreach (var controller in controllerList)
            {
                if (!controller.FunctionInstanceDict.TryGetValue(algName, out Function function))
                    continue;

                FieldInfo fieldInfo = function.GetType().GetField(pinName);
                if (fieldInfo == null)
                    continue;

                object obj = fieldInfo.GetValue(function);
                if (obj is LA la)
                {
                    la.Value = Convert.ToSingle(forcePointInfo.Value);
                    return true;
                }
                else if (obj is LD ld)
                {
                    if (float.TryParse(forcePointInfo.Value, out float fv))
                        ld.Value = fv > 0;
                    else if (bool.TryParse(forcePointInfo.Value, out bool bv))
                        ld.Value = bv;
                    return true;
                }
                else
                {
                    if (fieldInfo.FieldType.Name == "Int32")
                        fieldInfo.SetValue(function, Convert.ToInt32(forcePointInfo.Value));
                    else if (fieldInfo.FieldType.Name == "Single")
                        fieldInfo.SetValue(function, Convert.ToSingle(forcePointInfo.Value));
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// 设置功能码规格数
        /// </summary>
        /// <param name="algName"></param>
        /// <param name="pinName"></param>
        /// <param name="pinValue"></param>
        /// <returns></returns>
        public static bool SetFunctionConstantCacheValue(string algName, string pinName, string pinValue)
        {

            foreach (var controller in ExcuteEngine.controllerList)
            {
                if (controller.FunctionInstanceDict.TryGetValue(algName, out Function funciton))
                {
                    FieldInfo fileInfo = funciton.GetType().GetField(pinName);
                    if (fileInfo != null)
                    {
                        bool boolValue;
                        int intValue;
                        float floatValue;
                        object? obj = fileInfo.GetValue(funciton);

                        if (obj is LA)
                        {
                            if (float.TryParse(pinValue, out floatValue))
                            {
                                ((LA)obj).Value = floatValue;
                                return true;
                            }
                        }
                        if (obj is LD)
                        {
                            if (bool.TryParse(pinValue, out boolValue))
                            {
                                ((LD)obj).Value = boolValue;
                                return true;
                            }
                        }
                        else
                        {
                            if (int.TryParse(pinValue, out intValue))
                            {
                                fileInfo.SetValue(funciton, intValue);
                                return true;
                            }
                            else if (float.TryParse(pinValue, out floatValue))
                            {
                                fileInfo.SetValue(funciton, floatValue);
                                return true;
                            }
                        }
                        break;
                    }
                }
            }
            return false;
        }

        #region 健康度得分加权
        public static List<Healthy> GetDeviceHealthWeight(int sysId)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                List<Healthy> sysHealthyList = warnContext.healthy.Where(x => x.Unit == configInfo.healthUnit).ToList();
                List<Healthy> healthies = sysHealthyList.Where(x => x.System == sysId.ToString()).ToList();
                return healthies;
            }
        }

        public static List<Devicehealthy> GetIndicatorHealthWeight(int devId)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                List<Devicehealthy> deviceHealthyList = warnContext.devicehealthy.Where(x => x.Unit == configInfo.healthUnit).ToList();
                List<Devicehealthy> devicehealthies = deviceHealthyList.Where(x => x.System == devId.ToString()).ToList();
                return devicehealthies;
            }
        }

        public static bool SetDeviceHealthWeightToDb(List<Healthy> healthies)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
                {
                    warnContext.healthy.UpdateRange(healthies);
                    warnContext.SaveChanges();
                }

                //SetHealthWeightToCache();
                foreach (var healthy in healthies)
                {
                    DDevice? dDevice = dSystems.FirstOrDefault(x => x.ID.ToString() == healthy.System)?.Devices?.FirstOrDefault(x => x.ID.ToString() == healthy.Device);
                    var device = dSystems.SelectMany(x => x.Devices).ToList().FirstOrDefault(x => x.ID.ToString() == healthy.Device);
                    if (dDevice != null)
                    {
                        dDevice.weight = (double)healthy.Weight;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool SetIndicatorHealthWeightToDb(List<Devicehealthy> devicehealthies)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
                {
                    warnContext.devicehealthy.UpdateRange(devicehealthies);
                    warnContext.SaveChanges();
                }


                foreach (var item in devicehealthies)
                {
                    var device = dSystems.SelectMany(x => x.Devices).ToList().FirstOrDefault(x => x.ID.ToString() == item.System);
                    if (device != null)
                    {
                        var dHealthIndicator = device.HealthIndicators.FirstOrDefault(x => x.IndicatorID.ToString() == item.Point);
                        if (dHealthIndicator != null)
                        {
                            dHealthIndicator.weight = (double)item.Weight;
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public static List<HealthSystemScore> GetHealthScore()
        {
            try
            {
                List<HealthSystemScore> healthSystemScoreList = new List<HealthSystemScore>();
                for (int m = 0; m < controllerList.Count; m++)
                {
                    Controller controller = controllerList[m];
                    if (controller.ID != HealthControllerID) continue;

                    if (controller.dSystemList.Count > 0)
                    {
                        healthSystemScoreList = controller.dSystemList.Select((x) => new HealthSystemScore { ID = x.ID, Name = x.Name, Score = x.Score }).ToList();
                        for (int i = 0; i < controller.dSystemList.Count; i++)
                        {
                            DSystem dSystem = controller.dSystemList[i];
                            if (dSystem.Devices.Count > 0)
                            {
                                List<HealthDeviceScore> healthDeviceScoreList = dSystem.Devices.Select((x) => new HealthDeviceScore { ID = x.ID, Name = x.Name, Score = x.Score }).ToList();

                                for (int j = 0; j < dSystem.Devices.Count; j++)
                                {
                                    if (dSystem.Devices[j].HealthIndicators.Count > 0)
                                    {
                                        DDevice dDevice = dSystem.Devices[j];
                                        for (int k = 0; k < dDevice.HealthIndicators.Count; k++)
                                        {
                                            DHealthIndicator healthIndicator = dDevice.HealthIndicators[k];
                                            healthIndicator.PointScoreList = new List<PointScore>();
                                            for (int n = 0; n < healthIndicator.UsePoint.Count; n++)
                                            {
                                                HealthFunction healthFunction = (HealthFunction)healthIndicator.InstanceFc;
                                                try
                                                {
                                                    LA outScore = (LA)healthFunction.outList2[n];
                                                    if (outScore.buffer < 100)
                                                    {
                                                        healthIndicator.PointScoreList.Add(new PointScore()
                                                        {
                                                            PN = healthIndicator.UsePoint[n].ToTableName(),
                                                            Score = outScore.buffer,
                                                            Desc = CfgVarsystemList.FirstOrDefault(x => x.Name.ToLower() == healthIndicator.UsePoint[n].ToLower())?.Description
                                                        });
                                                    }
                                                }
                                                catch (Exception ex)
                                                {
                                                    logger.ErrorLog($"GetHealthScore：{ex.Message}");
                                                }
                                            }
                                        }


                                        List<HealthIndicatorScore> healthIndicatorScoreList = dDevice.HealthIndicators.Select((x) => new HealthIndicatorScore { ID = x.IndicatorID, Name = x.IndicatorName, Score = x.Score, InstanceName = x.InstanceName, AlarmValue1 = x.AlarmValue1, AlarmValue2 = x.AlarmValue2, TripValue1 = x.TripValue1, TripValue2 = x.TripValue2, PointScores = x.PointScoreList }).ToList();
                                        healthDeviceScoreList[j].HealthIndicatorScores.AddRange(healthIndicatorScoreList);
                                        healthSystemScoreList[i].HealthDeviceScores.Add(healthDeviceScoreList[j]);
                                    }
                                }
                            }
                        }
                    }

                }

                return healthSystemScoreList;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion


        private static readonly object warnPointLock = new object();

        public static bool ImportWarnPoints(List<CldWarnpoint> warnPoints)
        {
            lock (warnPointLock)
            {
                foreach (var cldWarnpoint in warnPoints)
                {
                    AddWarnPointToCache(cldWarnpoint);
                }
            }

            return true;
        }

        private static object _ruleLock = new object();
        public static void AddWarnPointToCache(CldWarnpoint cldWarnpoint)
        {
            string warnPointName = cldWarnpoint.PointName ?? "";
            var existingIndex = cldWarnpointList.FindIndex(x => x.Id == cldWarnpoint.Id);
            if (existingIndex >= 0)
            {
                // 已存在：整体替换为新对象
                var newList = new List<CldWarnpoint>(cldWarnpointList);
                newList[existingIndex] = cldWarnpoint;
                cldWarnpointList = newList;
            }
            else
            {
                // 不存在：追加
                var newList = new List<CldWarnpoint>(cldWarnpointList) { cldWarnpoint };
                cldWarnpointList = newList;
            }

            // 提前计算公共变量
            bool isEnabled = cldWarnpoint.WarnStatus > 0;
            string unit = cldWarnpoint.Unit ?? "";
            int delayTime = cldWarnpoint.TimeDurationThreshold ?? 0;
            int modelOrRule = cldWarnpoint.ModelOrrule ?? 0;
            int alarmLevel = cldWarnpoint.AlarmLevel ?? 0;
            bool isAlarmSuspended = cldWarnpoint.IsAlarmSuspended == 1;
            string warnConstraint = string.IsNullOrEmpty(cldWarnpoint.WarnConstraint) || cldWarnpoint.WarnConstraint == "1=1" ? "" : cldWarnpoint.WarnConstraint;

            // 解析限值
            float? up1Limit = cldWarnpoint.UpLimit.ToFloatOrNull();
            float? low1Limit = cldWarnpoint.LowLimit.ToFloatOrNull();
            float? up2Limit = cldWarnpoint.UpUpLimit.ToFloatOrNull();
            float? low2Limit = cldWarnpoint.LowLowLimit.ToFloatOrNull();
            float? up3Limit = cldWarnpoint.Up3Limit.ToFloatOrNull();
            float? low3Limit = cldWarnpoint.Low3Limit.ToFloatOrNull();

            if (modelOrRule == 0 && !RTDDict.ContainsKey(warnPointName))
            {
                var lAExWarn = new LAExWarn(QualityTypes.Good, isEnabled, unit, up1Limit, low1Limit, up2Limit, low2Limit, up3Limit, low3Limit, delayTime, modelOrRule, -1, -1, alarmLevel, false, false, false, false, false, 0, 0, 0.0f, 0, 0.0f)
                {
                    WarnConstraint = warnConstraint
                };
                RTDDict.TryAdd(warnPointName, new List<object>(1) { lAExWarn });
            }
            else if (modelOrRule == 1) // 去掉 !ContainsKey 判断，允许进入逻辑进行更新
            {
                CfgVarsystem cfgVarsystem = CfgVarsystemList.FirstOrDefault(x => x.Name == warnPointName);

                // 只有找到配置才处理
                if (cfgVarsystem != null)
                {
                    // 【关键点】：涉及字典的读写操作，必须加锁
                    lock (_ruleLock)
                    {
                        if (cfgVarsystem.DataType == "LA")
                        {
                            if (RTDDict_Rule.TryGetValue(warnPointName, out var baseWarn) && baseWarn is LAExWarn existingLA)
                            {
                                // === 更新现有对象 (Update) ===
                                existingLA.WarnLowLimit = low1Limit;
                                existingLA.WarnUpLimit = up1Limit;
                                existingLA.LowLowLimit = low2Limit;
                                existingLA.WarnUpUpLimit = up2Limit;
                                existingLA.Low3Limit = low3Limit;
                                existingLA.Up3Limit = up3Limit;
                                existingLA.DelayTime = delayTime;
                                existingLA.AlarmLevel = alarmLevel;

                                // 更新扩展属性
                                existingLA.WarnConstraint = warnConstraint;
                                existingLA.IsAlarmSuspended = isAlarmSuspended;
                                existingLA.WarnUpUpMaxLimit = cldWarnpoint.UpUpMaxLimit.ToFloatOrNull();
                                existingLA.DelayTimeLimitAlarm = cldWarnpoint.DelayTimeLimitAlarm ?? 0;

                                existingLA.InitializeAlarmLevels();
                            }
                            else
                            {
                                // === 不存在，或者类型不匹配，则新建 (Create & Add) ===
                                var lAExWarn = new LAExWarn(QualityTypes.Good, isEnabled, unit, up1Limit, low1Limit, up2Limit, low2Limit, up3Limit, low3Limit, delayTime, modelOrRule, -1, -1, alarmLevel, false, false, false, false, false, 0, 0, 0.0f, 0, 0.0f)
                                {
                                    WarnConstraint = warnConstraint,
                                    IsAlarmSuspended = isAlarmSuspended,
                                    WarnUpUpMaxLimit = cldWarnpoint.UpUpMaxLimit.ToFloatOrNull(),
                                    DelayTimeLimitAlarm = cldWarnpoint.DelayTimeLimitAlarm ?? 0
                                };

                                // 使用索引器赋值，如果 Key 已存在但类型不对（极少情况），会直接覆盖
                                RTDDict_Rule[warnPointName] = lAExWarn;
                            }
                        }
                        else if (cfgVarsystem.DataType == "LD")
                        {
                            // 尝试获取现有对象
                            if (RTDDict_Rule.TryGetValue(warnPointName, out var baseWarn) && baseWarn is LDExWarn existingLD)
                            {
                                // === 更新现有对象 (Update) ===
                                existingLD.Unit = unit;
                                existingLD.WarnUpLimit = up1Limit;   // LD 可能只用到部分限值，根据类定义赋值
                                existingLD.WarnLowLimit = low1Limit;
                                existingLD.DelayTime = delayTime;
                                existingLD.AlarmLevel = alarmLevel;

                                // 更新扩展属性
                                existingLD.WarnConstraint = warnConstraint;
                                existingLD.IsAlarmSuspended = isAlarmSuspended;

                                existingLD.InitializeAlarmLevels();
                            }
                            else
                            {
                                // === 不存在，或者类型不匹配，则新建 (Create & Add) ===
                                var lDExWarn = new LDExWarn(QualityTypes.Good, isEnabled, unit, up1Limit, low1Limit, delayTime, modelOrRule, false, alarmLevel, false, 0, false, false)
                                {
                                    WarnConstraint = warnConstraint,
                                    IsAlarmSuspended = isAlarmSuspended
                                };

                                RTDDict_Rule[warnPointName] = lDExWarn;
                            }
                        }
                    } // End lock
                }
            }

            if (!CommPoints.Contains(warnPointName))
            {
                CommPoints.Add(warnPointName);
            }
        }

        /// <summary>
        /// 更新预警点
        /// </summary>
        /// <param name="warnPointUpdateInfo"></param>
        /// <returns></returns>
        public static bool UpdateWarnPoint(WarnPointUpdateInfo warnPointUpdateInfo)
        {
            CldWarnpoint cldWarnpoint = warnPointUpdateInfo.cldWarnpoint;
            lock (warnPointLock)
            {
                if (warnPointUpdateInfo.DbAction == 2)
                {
                    var newList = new List<CldWarnpoint>(cldWarnpointList);
                    newList.RemoveAll(x => x.Id == cldWarnpoint.Id);
                    cldWarnpointList = newList;
                    return true;
                }
                else if (warnPointUpdateInfo.DbAction == 0)
                {
                    if (cldWarnpointList.FirstOrDefault(x => x.Id == cldWarnpoint.Id) == null)
                    {
                        AddWarnPointToCache(cldWarnpoint);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (warnPointUpdateInfo.DbAction == 1)
                {
                    string pointName = cldWarnpoint.PointName ?? "";

                    //// 同步更新 cldWarnpointList 中对应记录的 IsWriteBack 和 WriteBackPointName
                    //var existingWarnpoint = cldWarnpointList.FirstOrDefault(x => x.Id == cldWarnpoint.Id);
                    //if (existingWarnpoint != null)
                    //{
                    //    existingWarnpoint.IsWriteBack = cldWarnpoint.IsWriteBack;
                    //    existingWarnpoint.WriteBackPointName = cldWarnpoint.WriteBackPointName;
                    //}

                    var existingIndex = cldWarnpointList.FindIndex(x => x.Id == cldWarnpoint.Id);
                    if (existingIndex >= 0)
                    {
                        // 已存在：整体替换为新对象
                        var newList = new List<CldWarnpoint>(cldWarnpointList);
                        newList[existingIndex] = cldWarnpoint;
                        cldWarnpointList = newList;
                    }

                    //WarnStatus为启动或停止
                    if (cldWarnpoint.WarnStatus > 0)
                    {
                        if (cldWarnpoint.ModelOrrule == 0)
                        {
                            // 模型预警点处理（保持不变）
                            if (RTDDict.TryGetValue(pointName, out List<object> warnList) && warnList != null)
                            {
                                lock (warnList)
                                {
                                    foreach (var item in warnList.OfType<LAExWarn>())
                                    {
                                        if (item.FcBlockID == cldWarnpoint.CldFcblockId)
                                        {
                                            UpdateWarnProperties(item, cldWarnpoint);
                                        }
                                        else
                                        {
                                            item.Runable = false;
                                        }
                                    }
                                }
                            }
                        }
                        else if (cldWarnpoint.ModelOrrule == 1 && RTDDict_Rule.TryGetValue(pointName, out var ruleItem))
                        {
                            return ruleItem switch
                            {
                                LAExWarn laExWarn => UpdateWarnProperties(laExWarn, cldWarnpoint),
                                LDExWarn ldExWarn => UpdateWarnProperties(ldExWarn, cldWarnpoint),
                                _ => false
                            };
                        }
                    }
                    else
                    {
                        if (cldWarnpoint.ModelOrrule == 0)
                        {
                            if (GetFirstRunableWarn(pointName) is LAExWarn modelWarn)
                            {
                                return UpdateWarnProperties(modelWarn, cldWarnpoint);
                            }
                        }
                        else if (cldWarnpoint.ModelOrrule == 1 && RTDDict_Rule.TryGetValue(pointName, out var ruleItem))
                        {
                            return ruleItem switch
                            {
                                LAExWarn laExWarn => UpdateWarnProperties(laExWarn, cldWarnpoint),
                                LDExWarn ldExWarn => UpdateWarnProperties(ldExWarn, cldWarnpoint),
                                _ => false
                            };
                        }
                    }
                    return false;
                }
                return false;
            }
        }


        /// <summary>
        /// 更新 LAExWarn 类型预警点的属性
        /// </summary>
        private static bool UpdateWarnProperties(LAExWarn laExWarn, CldWarnpoint cldWarnpoint)
        {
            laExWarn.Runable = cldWarnpoint.WarnStatus > 0;


            laExWarn.WarnUpLimit = cldWarnpoint.UpLimit.ToFloatOrNull();
            laExWarn.WarnLowLimit = cldWarnpoint.LowLimit.ToFloatOrNull();
            laExWarn.WarnUpUpLimit = cldWarnpoint.UpUpLimit.ToFloatOrNull();
            laExWarn.LowLowLimit = cldWarnpoint.LowLowLimit.ToFloatOrNull();
            laExWarn.Up3Limit = cldWarnpoint.Up3Limit.ToFloatOrNull();
            laExWarn.Low3Limit = cldWarnpoint.Low3Limit.ToFloatOrNull();

            laExWarn.WarnConstraint = cldWarnpoint.WarnConstraint ?? "";
            laExWarn.WarnUpUpMaxLimit = cldWarnpoint.UpUpMaxLimit.ToFloatOrNull();
            laExWarn.LimitAlarmCondition = cldWarnpoint.LimitAlarmCondition ?? "";
            laExWarn.DelayTimeLimitAlarm = cldWarnpoint.DelayTimeLimitAlarm ?? 0;
            laExWarn.AlarmLevel = cldWarnpoint.AlarmLevel ?? 0;
            laExWarn.DelayTime = cldWarnpoint.TimeDurationThreshold ?? 0;

            // 重新初始化报警级别（因为限值可能变化）
            laExWarn.InitializeAlarmLevels();
            return true;
        }


        /// <summary>
        /// 更新 LDExWarn 类型预警点的属性
        /// </summary>
        private static bool UpdateWarnProperties(LDExWarn ldExWarn, CldWarnpoint cldWarnpoint)
        {
            ldExWarn.Runable = cldWarnpoint.WarnStatus > 0;

            // LD 类型只支持高1和低1，不支持多级报警
            ldExWarn.WarnUpLimit = cldWarnpoint.UpLimit.ToFloatOrNull();
            ldExWarn.WarnLowLimit = cldWarnpoint.LowLimit.ToFloatOrNull();
            ldExWarn.WarnConstraint = cldWarnpoint.WarnConstraint ?? "";
            ldExWarn.LimitAlarmCondition = cldWarnpoint.LimitAlarmCondition ?? "";
            ldExWarn.DelayTimeLimitAlarm = cldWarnpoint.DelayTimeLimitAlarm ?? 0;
            ldExWarn.AlarmLevel = cldWarnpoint.AlarmLevel ?? 0;
            ldExWarn.DelayTime = cldWarnpoint.TimeDurationThreshold ?? 0;

            // 重新初始化报警级别（因为限值可能变化）
            ldExWarn.InitializeAlarmLevels();

            return true;
        }

        public static Dictionary<string, string> GetICPoints()
        {
            var dict = new Dictionary<string, string>()
            {
                { "glxl", "ICOptimizing_1.glxl"},                          //锅炉效率
                { "qjrh" , "ICOptimizing_1.qjrh"},                       //汽机热耗
                { "glxlhc", "ICOptimizing_1.glxlhc"},                   //锅炉效率耗差
                { "qjrhhc" , "ICOptimizing_1.qjrhhc"},                   //汽机热耗耗差
                { "fh", "dcs_ammka01ag001ce01"},                                  //机组负荷
                { "hjwd" , "dcs_pan00ct301"},                           //环境温度
                { "dwfrl", "PageInput_Qnetar"},                             //低位发热量
                { "yl" , "dcs_o2"},                                    //氧量
                { "zfl", "dcs_tfa"},                               //总风量
                { "acpywd" , "dcs_hna10ct303"},                         //A侧排烟温度
                { "bcpywd", "dcs_hna20ct303"},                          //B侧排烟温度
                { "kyqackyqhyl" , "dcs_hna10cq111"},                    //空预器A出口烟气含氧量
                { "Kyqbckyqhyl", "dcs_hna20cq111"},                     //空预器B出口烟气含氧量
                { "fhhtl" , "PageInput_Cfhc"},                              //飞灰含碳量
                { "lzhtl", "PageInput_Clzc"},                               //炉渣含碳量
                { "zzqyl" , "dcs_msp"},                          //主蒸汽压力
                { "zrzqyl", "dcs_rhpres"},                       //再热蒸汽压力
                { "zzqwd" , "dcs_mst"},                     //主蒸汽温度
                { "Zrzqwd", "dcs_rhte"},                       //再热蒸汽温度
                { "nqqby" , ""},                          //凝汽器背压
                { "zgsll", "dcs_fw_flow"},                       //主给水流量
                { "Lzczrqjwsll", ""},                         //#1炉左侧再热器减温水流量
                { "Lyczrqjwsll", ""},                         //#1炉右侧再热器减温水流量
                { "grd", "dcs_shdeg"},                         //过热度
                { "rll", "dcs_tffreal"},                                           //燃料量
                { "sfwd", "dcs_hla21ct305"},                         //送风温度
                { "pywd", ""},                         //排烟温度
                { "hf", "PageInput_Aad"},                         //灰分
                { "fxs", "PageInput_Mad"},                         //分析水
                { "qsf", "PageInput_Mar"},                         //全水分
                { "hff", "PageInput_Vad"}                         //挥发分
            };

            return dict;
        }


        #region 预警、故障统计

        public static List<List<object>> GetWarnAlarmTotalChart(int? alarmtype)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                // 1. 计算时间范围
                //alarmtype  规则 1    模拟 0   空为全部
                DateTime today = DateTime.Today;
                DateTime startOfWeek = GetWeekFirstDayMon(DateTime.Now);
                DateTime endOfWeek = GetWeekLastDaySun(DateTime.Now);
                DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddTicks(-1);

                // 2. 一次性查询本月数据（添加 AsNoTracking，移除无用的 PrjSystems 查询）
                var warnAlarms = warnContext.WarnAlarms.AsNoTracking()
                                .Where(x => (!alarmtype.HasValue || x.AlarmType.Equals(alarmtype)) // 这里的括号至关重要
                                            && x.Duration > WarnAlarmDurThreshold
                                            && x.EndTime > DateTime.MinValue
                                            && x.BeginTime >= startOfMonth
                                            && x.BeginTime <= endOfMonth)
                .ToList();


                // 3. 预先计算 parawarnsList 的 PointName -> Major 映射
                var pointToMajorDict = parawarnsList.Where(p => !string.IsNullOrEmpty(p.Major)).ToDictionary(p => p.PointName, p => p.Major);

                // 4. 预先计算并缓存 distinctMajors（只计算一次）
                var distinctMajors = parawarnsList
                    .Where(p => !string.IsNullOrEmpty(p.Major))
                    .Select(p => p.Major)
                    .Distinct()
                    .ToList();

                if (!distinctMajors.Contains("锅炉")) distinctMajors.Add("锅炉");
                if (!distinctMajors.Contains("汽机")) distinctMajors.Add("汽机");

                distinctMajors = distinctMajors
                    .OrderBy(m => m == "锅炉" ? 0 : m == "汽机" ? 1 : 2)
                    .ThenBy(m => m)
                    .ToList();

                // 5. 初始化三个统计字典（只创建一次）
                var dayDict = distinctMajors.ToDictionary(m => m, m => 0);
                var weekDict = distinctMajors.ToDictionary(m => m, m => 0);
                var monthDict = distinctMajors.ToDictionary(m => m, m => 0);

                // 6. 一次遍历，同时计算日/周/月统计
                foreach (var alarm in warnAlarms)
                {
                    if (!pointToMajorDict.TryGetValue(alarm.PointName, out var major)) continue;
                    if (!monthDict.ContainsKey(major)) continue;

                    // 本月（所有数据都属于本月）
                    monthDict[major]++;

                    // 本周
                    if (alarm.BeginTime >= startOfWeek && alarm.BeginTime <= endOfWeek)
                    {
                        weekDict[major]++;
                    }

                    // 本日
                    if (alarm.BeginTime >= today && alarm.BeginTime < today.AddDays(1))
                    {
                        dayDict[major]++;
                    }
                }

                // 7. 构建返回结果
                List<List<object>> list = new List<List<object>>()
                {
                    new List<object>()
                    {
                        new ChartRow() { name = "报警数量统计表", spanCol = 4, spanRow = 1 }
                    },
                    new List<object>()
                    {
                        new ChartRow() { name = "", spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = "本日", spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = "本周", spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = "本月", spanCol = 1, spanRow = 1 }
                    }
                };

                foreach (var major in distinctMajors)
                {
                    list.Add(new List<object>()
                    {
                        new ChartRow() { name = major, spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = dayDict[major], spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = weekDict[major], spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = monthDict[major], spanCol = 1, spanRow = 1 }
                    });
                }

                return list;
            }
        }

        public static List<List<object>> GetFaultDiagnosisTotalChart()
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                // 1. 计算时间范围
                DateTime today = DateTime.Today;
                DateTime startOfWeek = GetWeekFirstDayMon(DateTime.Now);
                DateTime endOfWeek = GetWeekLastDaySun(DateTime.Now);
                DateTime startOfMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endOfMonth = startOfMonth.AddMonths(1).AddTicks(-1);

                // 2. 一次性查询本月数据（添加 AsNoTracking）
                var faultDiagnosisList = warnContext.FaultDiagnosis.AsNoTracking()
                    .Where(x => x.EndTime > DateTime.MinValue
                             && x.BeginTime >= startOfMonth
                             && x.BeginTime <= endOfMonth
                             && EF.Functions.DateDiffSecond(x.BeginTime, x.EndTime) > FaultDiagnosisAlarmDurThreshold)
                    .ToList();

                // 3. 只查询需要的字段（Code 和 Major）
                var troubleshootingDict = warnContext.Troubleshooting.AsNoTracking()
                    .ToDictionary(t => t.Code, t => t.Major);

                // 4. 预先计算并缓存 distinctMajors（只计算一次）
                var distinctMajors = parawarnsList
                    .Where(p => !string.IsNullOrEmpty(p.Major))
                    .Select(p => p.Major)
                    .Distinct()
                    .ToList();

                if (!distinctMajors.Contains("锅炉")) distinctMajors.Add("锅炉");
                if (!distinctMajors.Contains("汽机")) distinctMajors.Add("汽机");

                distinctMajors = distinctMajors
                    .OrderBy(m => m == "锅炉" ? 0 : m == "汽机" ? 1 : 2)
                    .ThenBy(m => m)
                    .ToList();

                // 5. 初始化三个统计字典（只创建一次）
                var dayDict = distinctMajors.ToDictionary(m => m, m => 0);
                var weekDict = distinctMajors.ToDictionary(m => m, m => 0);
                var monthDict = distinctMajors.ToDictionary(m => m, m => 0);

                // 6. 一次遍历，同时计算日/周/月统计
                foreach (var fault in faultDiagnosisList)
                {
                    if (!troubleshootingDict.TryGetValue(fault.FaultCode, out var major)) continue;
                    if (!monthDict.ContainsKey(major)) continue;

                    // 本月（所有数据都属于本月）
                    monthDict[major]++;

                    // 本周
                    if (fault.BeginTime >= startOfWeek && fault.BeginTime <= endOfWeek)
                    {
                        weekDict[major]++;
                    }

                    // 本日
                    if (fault.BeginTime >= today && fault.BeginTime < today.AddDays(1))
                    {
                        dayDict[major]++;
                    }
                }

                // 7. 构建返回结果
                List<List<object>> list = new List<List<object>>()
                {
                    new List<object>()
                    {
                        new ChartRow() { name = "故障诊断统计表", spanCol = 4, spanRow = 1 }
                    },
                    new List<object>()
                    {
                        new ChartRow() { name = "", spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = "本日", spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = "本周", spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = "本月", spanCol = 1, spanRow = 1 }
                    }
                };

                foreach (var major in distinctMajors)
                {
                    list.Add(new List<object>()
                    {
                        new ChartRow() { name = major, spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = dayDict[major], spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = weekDict[major], spanCol = 1, spanRow = 1 },
                        new ChartRow() { name = monthDict[major], spanCol = 1, spanRow = 1 }
                    });
                }

                return list;
            }
        }

        public static double? GetLAValue(string pointName)
        {
            object syspoint = GetFirstRunableWarn(pointName);
            if (syspoint != null)
            {
                return ((LA)syspoint).buffer;
            }
            else
            {
                return 0;
            }
        }


        public static List<WarnAlarmData> GetWarnAlarmList(WarnAlarmRequest request)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                // 1. AsNoTracking：纯读取场景，禁用 EF 变更追踪，减少内存开销
                var query = warnContext.WarnAlarms.AsNoTracking()
                    .Where(x => x.Duration > WarnAlarmDurThreshold
                             && x.EndTime > DateTime.MinValue
                             && x.AlarmType != null);

                // 2. 日期过滤（数据库层面）
                if (request.TimeDelta == (int)totalenum.day)
                {
                    DateTime today = DateTime.Today;
                    DateTime tomorrow = today.AddDays(1);
                    query = query.Where(wa => wa.BeginTime >= today && wa.BeginTime < tomorrow);
                }
                else if (request.TimeDelta == (int)totalenum.week)
                {
                    DateTime startOfWeek = GetWeekFirstDayMon(DateTime.Now);
                    DateTime endOfWeek = GetWeekLastDaySun(DateTime.Now);
                    query = query.Where(wa => wa.BeginTime >= startOfWeek && wa.BeginTime <= endOfWeek);
                }
                else if (request.TimeDelta == (int)totalenum.month)
                {
                    DateTime startOfMonth = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    DateTime endOfMonth = startOfMonth.AddMonths(1).AddDays(-1);
                    query = query.Where(wa => wa.BeginTime >= startOfMonth && wa.BeginTime <= endOfMonth);
                }

                // 3. 名称搜索（数据库层面）
                if (!string.IsNullOrEmpty(request.SearceName))
                {
                    string searchTerm = request.SearceName.Trim();
                    query = query.Where(x => x.PointName.Contains(searchTerm));
                }

                // 3.5 描述模糊搜索 - OrdinalIgnoreCase 替代 ToLower()，零字符串分配
                if (!string.IsNullOrEmpty(request.SearchDescription))
                {
                    string descSearchTerm = request.SearchDescription.Trim();
                    var matchedPointNames = parawarnsList
                        .Where(p => !string.IsNullOrEmpty(p.Description)
                                 && p.Description.Contains(descSearchTerm, StringComparison.OrdinalIgnoreCase))
                        .Select(p => p.PointName)
                        .ToList();

                    if (matchedPointNames.Count == 0)
                    {
                        return new List<WarnAlarmData>();
                    }

                    // 将 List 转为 HashSet 加速 EF 翻译后的内存端比对
                    var matchedPointNameSet = new HashSet<string>(matchedPointNames);
                    query = query.Where(x => matchedPointNameSet.Contains(x.PointName));
                }

                // 4. 排序下推到数据库，然后执行查询
                var filteredWarnAlarms = query
                    .OrderByDescending(x => x.BeginTime)
                    .ToList();

                if (filteredWarnAlarms.Count == 0)
                {
                    return new List<WarnAlarmData>();
                }

                // 5. 预构建 parawarnsList 字典（忽略大小写），O(1) 查找替代 O(N) Join
                var parawarnsDict = new Dictionary<string, parawarns>(StringComparer.OrdinalIgnoreCase);
                foreach (var pw in parawarnsList)
                {
                    if (!string.IsNullOrEmpty(pw.PointName))
                        parawarnsDict.TryAdd(pw.PointName, pw);
                }

                // 6. CldWarnpoints 只投影需要的 3 个字段，构建复合 Key Lookup
                var pointNames = filteredWarnAlarms.Select(x => x.PointName).Distinct().ToList();
                var warnpointsLookup = warnContext.CldWarnpoints.AsNoTracking()
                    .Where(wp => pointNames.Contains(wp.PointName))
                    .Select(wp => new { wp.PointName, wp.ModelOrrule, wp.IsAlarmSuspended })
                    .AsEnumerable()
                    .ToLookup(wp => (wp.PointName, wp.ModelOrrule));

                // 7. 字典查找替代 LINQ 双 Join，保持 DB 端排序顺序
                var result = new List<WarnAlarmData>(filteredWarnAlarms.Count);
                foreach (var wa in filteredWarnAlarms)
                {
                    if (!parawarnsDict.TryGetValue(wa.PointName, out var pw))
                        continue;

                    foreach (var wp in warnpointsLookup[(wa.PointName, wa.AlarmType)])
                    {
                        result.Add(new WarnAlarmData
                        {
                            Id = wa.Id,
                            PointName = wa.PointName,
                            SysName = pw.SysName,
                            Description = pw.Description,
                            BeginTime = wa.BeginTime,
                            EndTime = wa.EndTime,
                            Duration = Math.Floor(wa.Duration),
                            UpUpLimitDuration = Math.Floor((double)(wa.UpUpLimitDuration ?? 0)),
                            ExceedLimitMaximum = wa.ExceedLimitMaximum,
                            AlarmType = (int)wa.AlarmType,
                            IsAlarmSuspended = wp.IsAlarmSuspended ?? 0,
                            Level = wa.Level
                        });
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// 得到本周第一天(以星期一为第一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekFirstDayMon(DateTime datetime)
        {
            //星期一为第一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);

            //因为是以星期一为第一天，所以要判断weeknow等于0时，要向前推6天。
            weeknow = (weeknow == 0 ? (7 - 1) : (weeknow - 1));
            int daydiff = (-1) * weeknow;

            //本周第一天
            string FirstDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(FirstDay);
        }
        /// <summary>
        /// 得到本周最后一天(以星期天为最后一天)
        /// </summary>
        /// <param name="datetime"></param>
        /// <returns></returns>
        public static DateTime GetWeekLastDaySun(DateTime datetime)
        {
            //星期天为最后一天
            int weeknow = Convert.ToInt32(datetime.DayOfWeek);
            weeknow = (weeknow == 0 ? 7 : weeknow);
            int daydiff = (7 - weeknow);

            //本周最后一天
            string LastDay = datetime.AddDays(daydiff).ToString("yyyy-MM-dd");
            return Convert.ToDateTime(LastDay);
        }

        public static List<FaultDiagnosisData> GetFaultDiagnosisAlarmList(WarnAlarmRequest request)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                // 计算时间范围
                DateTime? startTime = null;
                DateTime? endTime = null;

                if (request.TimeDelta == (int)totalenum.day)
                {
                    startTime = DateTime.Today;
                    endTime = DateTime.Today.AddDays(1);
                }
                else if (request.TimeDelta == (int)totalenum.week)
                {
                    startTime = GetWeekFirstDayMon(DateTime.Now);
                    endTime = GetWeekLastDaySun(DateTime.Now);
                }
                else if (request.TimeDelta == (int)totalenum.month)
                {
                    startTime = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
                    endTime = startTime.Value.AddMonths(1).AddDays(-1);
                }

                // 构建数据库查询
                var faultQuery = warnContext.FaultDiagnosis.AsNoTracking().Where(x => x.EndTime > DateTime.MinValue);
                if (startTime.HasValue && endTime.HasValue)
                {
                    faultQuery = faultQuery.Where(x => x.BeginTime >= startTime.Value && x.BeginTime <= endTime.Value);
                }

                var query = from wa in faultQuery
                            join pw in warnContext.Troubleshooting.AsNoTracking() on wa.FaultCode equals pw.Code
                            select new
                            {
                                wa.Id,
                                pw.Code,
                                pw.TroubleName,
                                wa.BeginTime,
                                wa.EndTime
                            };

                // 名称搜索过滤（在数据库端执行）
                string searchName = request.SearceName?.Trim().ToLower();
                if (!string.IsNullOrEmpty(searchName))
                {
                    query = query.Where(x => x.TroubleName.ToLower().Contains(searchName));
                }

                var filteredQuery = query
                    .Where(x => EF.Functions.DateDiffSecond(x.BeginTime, x.EndTime) > FaultDiagnosisAlarmDurThreshold)
                    .OrderByDescending(x => x.BeginTime);

                var result = filteredQuery.AsEnumerable().Select(x => new FaultDiagnosisData
                {
                    Id = x.Id,
                    FaultCode = (int)x.Code,
                    FaultName = x.TroubleName,
                    BeginTime = x.BeginTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    EndTime = x.EndTime.ToString("yyyy-MM-dd HH:mm:ss"),
                    Duration = Math.Floor((x.EndTime - x.BeginTime).TotalSeconds)
                }).ToList();

                return result;
            }
        }

        public static bool DeleteWarnAlarm(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    WarnAlarm warnAlarm = warnContext.WarnAlarms.FirstOrDefault(x => x.Id == id);
                    if (warnAlarm != null)
                    {
                        warnContext.WarnAlarms.Remove(warnAlarm);
                        warnContext.SaveChanges();
                        return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteFaultDiagnosis(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    FaultDiagnosis faultDiagnosis = warnContext.FaultDiagnosis.FirstOrDefault(x => x.Id == id);
                    if (faultDiagnosis != null)
                    {
                        warnContext.FaultDiagnosis.Remove(faultDiagnosis);
                        warnContext.SaveChanges();

                        return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        #region Pointshow CRUD操作

        /// <summary>
        /// 添加Pointshow记录
        /// </summary>
        public static bool AddPointshow(Pointshow pointshow)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    warnContext.Pointshows.Add(pointshow);
                    warnContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 批量添加Pointshow记录
        /// </summary>
        public static bool AddPointshows(List<Pointshow> pointshows)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    warnContext.Pointshows.AddRange(pointshows);
                    warnContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 删除Pointshow记录
        /// </summary>
        public static bool DeletePointshow(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    Pointshow pointshow = warnContext.Pointshows.FirstOrDefault(x => x.Id == id);
                    if (pointshow != null)
                    {
                        warnContext.Pointshows.Remove(pointshow);
                        warnContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 更新Pointshow记录
        /// </summary>
        public static bool UpdatePointshow(Pointshow pointshow)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    Pointshow existingPointshow = warnContext.Pointshows.FirstOrDefault(x => x.Id == pointshow.Id);
                    if (existingPointshow != null)
                    {
                        existingPointshow.pointname = pointshow.pointname;
                        warnContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 批量更新Pointshow记录
        /// </summary>
        public static bool UpdatePointshows(List<Pointshow> pointshows)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    warnContext.Pointshows.UpdateRange(pointshows);
                    warnContext.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// 根据ID查询Pointshow记录
        /// </summary>
        public static Pointshow GetPointshowById(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    return warnContext.Pointshows.FirstOrDefault(x => x.Id == id);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        /// <summary>
        /// 查询所有Pointshow记录
        /// </summary>
        public static List<Pointshow> GetAllPointshows()
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    return warnContext.Pointshows.ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Pointshow>();
            }
        }

        /// <summary>
        /// 根据pointname查询Pointshow记录
        /// </summary>
        public static List<Pointshow> GetPointshowsByPointname(string pointname)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    return warnContext.Pointshows.Where(x => x.pointname == pointname).ToList();
                }
            }
            catch (Exception ex)
            {
                return new List<Pointshow>();
            }
        }

        #endregion

        #endregion

        public static void FillNulls(string[] data)
        {
            if (data.Length == 0)
            {
                return;
            }
            // 找到第一个非 null 的值
            string firstNonNull = data.FirstOrDefault(x => x != null);

            // 如果第一个元素是 null，且找到第一个非 null 的值，将第一个元素替换为该值
            if (data[0] == null && firstNonNull != null)
            {
                data[0] = firstNonNull;
            }

            // 遍历数组，将 null 替换为前一个非 null 的值
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i] == null && data[i - 1] != null)
                {
                    data[i] = data[i - 1];
                }
            }
        }

        public static void SetPowerUnitState()
        {
            object syspoint = GetFirstRunableWarn("dcs_ammka01ag001ce01");
            if (syspoint != null)
            {
                float pw = ((LA)syspoint).buffer;
                if (pw < 100)
                {
                    powerUnitStop = true;
                }
                else
                {
                    powerUnitStop = false;
                }
            }
            else
            {
                powerUnitStop = true;
            }
        }


        /// <summary>
        /// 报警挂起
        /// </summary>
        /// <param name="pointName"></param>
        /// <param name="modelorRule"></param>
        /// <param name="status"></param>
        public static void SetAlarmSuspended(string pointName, int modelorRule, int status)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                try
                {
                    var cldWarnpoint = cldWarnpointList.FirstOrDefault(x => x.PointName == pointName && x.ModelOrrule == modelorRule);
                    if (cldWarnpoint != null)
                    {
                        cldWarnpoint.IsAlarmSuspended = status;
                        warnContext.CldWarnpoints.Update(cldWarnpoint);
                        warnContext.SaveChanges();

                        object syspoint = GetFirstRunableWarn(pointName);
                        if (cldWarnpoint.ModelOrrule == 0 && syspoint != null && syspoint is LAExWarn modelWarn)
                        {
                            modelWarn.IsAlarmSuspended = status == 1;
                        }
                        else if (cldWarnpoint.ModelOrrule == 1 && RTDDict_Rule.TryGetValue(pointName, out var ruleItem) && ruleItem is LAExWarn ruleWarn)
                        {
                            //ruleWarn.IsAlarmSuspended = status == 1;
                            switch (ruleItem)
                            {
                                case LAExWarn laExWarn:
                                    laExWarn.IsAlarmSuspended = status == 1;
                                    break;
                                case LDExWarn ldExWarn:
                                    ldExWarn.IsAlarmSuspended = status == 1;
                                    break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }
        }

        /// <summary>
        /// 查询所有挂起的报警点
        /// </summary>
        /// <param name="alarmType">报警类型：0-模型，1-规则，null-全部</param>
        public static List<SuspendedAlarmPointData> GetSuspendedAlarmPoints(int? alarmType)
        {
            var snapshot = cldWarnpointList;
            if (snapshot == null)
                return new List<SuspendedAlarmPointData>();

            var query = snapshot.Where(x => x.IsAlarmSuspended == 1);

            if (alarmType.HasValue)
                query = query.Where(x => x.ModelOrrule == alarmType.Value);

            return query.Select(x => new SuspendedAlarmPointData
            {
                PointName = x.PointName,
                Description = x.Description,
                AlarmType = x.ModelOrrule
            }).ToList();
        }


        private static readonly object rtdDictLock = new object();

        public static bool AddPointToVarsystem(string names, string types, string descs)
        {
            bool result = false;
            try
            {
                string[] namesArr = names.Split(',');
                string[] typesArr = types.Split(",");
                string[] descArr = descs.Split(",");

                if (namesArr.Length == typesArr.Length && typesArr.Length == descArr.Length && namesArr.Length > 0)
                {
                    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                    {
                        List<CfgVarsystem> CfgVarsystemList = warnContext.CfgVarsystems.ToList();

                        List<CfgVarsystem> list = new List<CfgVarsystem>();
                        for (int i = 0; i < namesArr.Length; i++)
                        {
                            CfgVarsystem cfgVarsystem = CfgVarsystemList.FirstOrDefault(x => x.Name.ToLower() == namesArr[i].ToLower());
                            if (cfgVarsystem == null)
                            {
                                list.Add(new CfgVarsystem()
                                {
                                    Name = namesArr[i],
                                    Description = descArr[i],
                                    DataType = typesArr[i],
                                    Prj_Controller_ID = 1,
                                    Source = (int)SourceType.DCS
                                });
                            }
                        }

                        warnContext.CfgVarsystems.AddRange(list);
                        warnContext.SaveChanges();
                    }

                    result = true;
                }
            }
            catch (Exception ex)
            {
                // 处理异常，例如记录日志
            }

            return result;
        }

        /// <summary>
        /// 批量添加点表到变量系统（优化版本，避免多次连接数据库）
        /// </summary>
        /// <param name="points">点表数据列表</param>
        /// <returns>添加结果</returns>
        public static BatchAddResult AddPointToVarsystems(List<PointData> points)
        {
            var result = new BatchAddResult();

            if (points == null || points.Count == 0)
            {
                result.Success = false;
                result.Message = "点表数据为空";
                return result;
            }

            try
            {
                // 只连接一次数据库
                using (var warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    // 获取现有的点表列表（只查询一次）
                    var existingPoints = warnContext.CfgVarsystems
                        .Where(x => points.Select(p => p.PointName.ToLower()).Contains(x.Name.ToLower()))
                        .Select(x => x.Name.ToLower())
                        .ToList();

                    // 过滤出需要新增的点表
                    var newPoints = points.Where(p => !existingPoints.Contains(p.PointName.ToLower())).ToList();
                    var skippedPoints = points.Where(p => existingPoints.Contains(p.PointName.ToLower())).ToList();

                    if (newPoints.Count > 0)
                    {
                        // 批量创建新的点表记录
                        var cfgVarsystemList = newPoints.Select(p => new CfgVarsystem
                        {
                            Name = p.PointName,
                            Description = p.Description,
                            DataType = p.DataType,
                            Prj_Controller_ID = 1,
                            Source = (int)SourceType.DCS
                        }).ToList();

                        // 批量添加到数据库
                        warnContext.CfgVarsystems.AddRange(cfgVarsystemList);
                        warnContext.SaveChanges();

                        result.Success = true;
                        result.Message = $"批量添加成功，新增：{newPoints.Count}个，跳过重复：{skippedPoints.Count}个";
                        result.AddedCount = newPoints.Count;
                        result.SkippedCount = skippedPoints.Count;
                        result.AddedPoints = newPoints;
                        result.SkippedPoints = skippedPoints;
                    }
                    else
                    {
                        result.Success = true;
                        result.Message = $"所有点表已存在，跳过：{skippedPoints.Count}个";
                        result.AddedCount = 0;
                        result.SkippedCount = skippedPoints.Count;
                        result.SkippedPoints = skippedPoints;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = $"批量添加失败：{ex.Message}";
                logger.ErrorLog($"批量添加点表失败：{ex.Message}");
            }

            return result;
        }

        public static object GetWarnRValues(string? pointName)
        {
            // 1. 获取所有数据并打平
            var query = warnRValueDict.Values.SelectMany(list => list);

            // 2. 如果 pointName 不为空，执行筛选逻辑
            if (!string.IsNullOrEmpty(pointName))
            {
                // 将 int 转换为 string 进行比较，假设 WarnRTableName 存储的是编号的字符串形式
                string filterName = pointName;
                query = query.Where(warn => warn.WarnRTableName == filterName);
            }

            // 3. 投影出需要的匿名对象
            var list = query.Select(warn => new
            {
                warn.WarnRTableName,
                RValue = warn.RValue?.buffer
            }).ToList(); // 建议加上 ToList() 确保立即执行并返回列表

            return list;
        }

        /// <summary>
        /// 点表数据模型
        /// </summary>
        public class PointData
        {
            public string PointName { get; set; } = string.Empty;
            public string Description { get; set; } = string.Empty;
            public string DataType { get; set; } = string.Empty;
        }

        /// <summary>
        /// 批量添加结果
        /// </summary>
        public class BatchAddResult
        {
            public bool Success { get; set; }
            public string Message { get; set; } = string.Empty;
            public int AddedCount { get; set; }
            public int SkippedCount { get; set; }
            public List<PointData> AddedPoints { get; set; } = new List<PointData>();
            public List<PointData> SkippedPoints { get; set; } = new List<PointData>();
        }
    }


    public class content
    {
        public string conditon { get; set; }
        public List<List<string>> text { get; set; }

        public int device { get; set; }

    }
    public class Pointmsg
    {
        public string description { get; set; }
        public string dcspoint { get; set; }
        public bool issteady { get; set; }
        public string comparepoint { get; set; }
        public bool issql { get; set; } = false;
    }
}
