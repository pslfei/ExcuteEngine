using DBServer.LogServer;
using DCSType;
using EngineCore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.ComponentModel;

namespace TDServer.Service
{
    /// <summary>
    /// 缓存数据API
    /// </summary>
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private static readonly object mylock = new object();
        private static LoggerService<HomeController> logger = new LoggerService<HomeController>();

        /// <summary>
        /// 获取回写点
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetWarnRValues(string? pointName)
        {
            var dict = ExcuteEngine.GetWarnRValues(pointName);
            return Ok(dict);
        }


        [HttpPost]
        public async Task<IActionResult> InsertDataToInfluxDB([FromBody] List<items> list)
        {
            var ret = InfluxDBHelp.BatchInsertPointValue(list);
            return Ok(ret);
        }

        [HttpPost]
        public async Task<IActionResult> GetLogicFc([FromQuery] string algName)
        {
            var dict = ExcuteEngine.controllerList[0].FunctionInstanceDict.TryGetValue(algName, out var value);
            return Ok(JsonConvert.SerializeObject(value));
        }



        #region 预警诊断平台
        [HttpPost]
        public async Task<IActionResult> GetLogicFcPinValue([FromBody] Dictionary<string, List<string>> fcPins)
        {
            var dict = ExcuteEngine.GetLogicFcPinValue(fcPins);
            return Ok(dict);
        }



        [HttpPost]
        public async Task<IActionResult> GetWarnInstanceRunState([FromBody] List<string> algNames)
        {
            var ret = ExcuteEngine.GetWarnInstanceRunState(algNames);
            return Ok(ret);
        }



        [HttpPost]
        public async Task<IActionResult> SetForceValueToPoint([FromBody] ForcePointInfo forcePointInfo)
        {
            bool result = ExcuteEngine.SetForceValueToPoint(forcePointInfo);
            return Ok(result ? "OK" : "fail");
        }

        [HttpPost]
        public async Task<IActionResult> SetValueToPin([FromBody] ForcePointInfo forcePointInfo)
        {

            bool result = ExcuteEngine.SetForceValueToPoint(forcePointInfo);
            return Ok(result ? "OK" : "fail");
        }


        [HttpGet]
        public async Task<IActionResult> SetWarnPointAck([FromQuery] string pointName)
        {
            bool result = ExcuteEngine.SetWarnPointAck(pointName);
            return Ok(result ? "OK" : "fail");
        }


        [HttpGet]
        public async Task<IActionResult> SetWarnPointAck2([FromQuery] string pointName, int alarmType)
        {
            bool result = ExcuteEngine.SetWarnPointAck2(pointName, alarmType);
            return Ok(result ? "OK" : "fail");
        }


        [HttpGet]
        public async Task<IActionResult> SetWarnFcAck([FromQuery] string algName)
        {
            bool result = ExcuteEngine.SetWarnFcAck(algName);
            return Ok(result ? "OK" : "fail");
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWarnPoint([FromBody] WarnPointUpdateInfo warnPointUpdateInfo)
        {
            bool result = ExcuteEngine.UpdateWarnPoint(warnPointUpdateInfo);
            return Ok(result ? "OK" : "fail");
        }

        [HttpPost]
        public async Task<IActionResult> ImportWarnPoints([FromBody] List<CldWarnpoint> warnPoints)
        {
            bool result = ExcuteEngine.ImportWarnPoints(warnPoints);
            return Ok(result ? "OK" : "fail");
        }


        [HttpGet]
        public async Task<IActionResult> SetFunctionConstantCacheValue(string algName, string pinName, string pinValue)
        {
            try
            {
                if (ExcuteEngine.SetFunctionConstantCacheValue(algName, pinName, pinValue))
                {
                    return Ok("OK");
                }
                else
                {
                    return BadRequest("fail");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("fail" + ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> SetAlarmSuspended([FromQuery] string pointName, int modelorRule, int status)
        {
            ExcuteEngine.SetAlarmSuspended(pointName, modelorRule, status);
            return Ok("OK");
        }

        [HttpGet]
        public IActionResult GetSuspendedAlarmPoints([FromQuery] int? alarmType)
        {
            var result = ExcuteEngine.GetSuspendedAlarmPoints(alarmType);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> ReinitializeSheets([FromBody] List<int> sheetids)
        {
            try
            {
                ExcuteEngine.ReinitializeSheets(sheetids);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                return BadRequest("fail" + ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> ReinitializeSheetsIncremental([FromBody] List<int> sheetids)
        {
            try
            {
                ExcuteEngine.ReinitializeSheetsIncremental(sheetids);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                return BadRequest("fail" + ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReinitializeSheet(int sheetid)
        {
            try
            {
                ExcuteEngine.ReinitializeSheet(sheetid);
                return Ok("OK");
            }
            catch (Exception ex)
            {
                return BadRequest("fail" + ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReloadModel(string modelName)
        {
            try
            {
                logger.InfoLog($"Excute ReloadModel {modelName}!");
                if (ExcuteEngine.ReloadModel(modelName))
                {
                    return Ok("OK");
                }
                else
                {
                    logger.InfoLog("Excute ReloadModel Error!");
                    return BadRequest("fail");
                }
            }
            catch (Exception ex)
            {
                return BadRequest("fail" + ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> ReLoad()
        {
            try
            {
                logger.InfoLog("开始下装！");
                ExcuteEngine.ReInitial();
                logger.InfoLog("下装成功！");
                return Ok("OK");
            }
            catch (Exception ex)
            {
                logger.ErrorLog("下装失败！" + ex.Message);
                return BadRequest("fail" + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> DynamicCompileWarnDiagnosisFC([FromBody] WarnDiagnosisInfo warnDiagnosisInfo)
        {
            if (string.IsNullOrEmpty(warnDiagnosisInfo.ModelInfo))
            {
                return BadRequest("fail");
            }

            //warnDiagnosisInfo.ModelInfo = "{\"id\":\"417\",\"name\":\"PCA379\",\"description\":\"六段低加抽汽壁温2\",\"founder\":\"admin\",\"creatTime\":\"2025-09-09 15:05:23\",\"Modifier\":null,\"modifiedTime\":\"\",\"algorithm\":\"PCA\",\"sampling\":\"300\",\"monitor\":null,\"trainTime\":[{\"st\":\"2025-08-20 21:52:18\",\"et\":\"2025-08-23 17:54:33\",\"duration\":244935,\"number\":817,\"filter\":90,\"mode\":727,\"id\":null,\"load\":null,\"temp\":null,\"LAY_TABLE_INDEX\":1,\"limitnumber\":0,\"conditionnumber\":0}],\"model_state\":\"\",\"pointInfo\":[{\"PointId\":\"DCS06_06LBS60BT604\",\"Description\":\"六级抽汽管道管底温度\",\"Unit\":\"\",\"Upper\":\"\",\"Lower\":\"\",\"dead\":false,\"limit\":null,\"Lock\":false,\"upperBound\":\"2.67\",\"lowerBound\":\"-2.67\",\"LAY_TABLE_INDEX\":1,\"type\":null,\"TMax\":\"222.38\",\"TMin\":\"203.19\",\"TAvg\":\"214.43\",\"DMax\":\"0.99\",\"DMin\":\"0.00\",\"DAvg\":\"0.17\",\"C95\":\"0.59\",\"C99\":\"0.72\"},{\"PointId\":\"DCS06_06LBS60BT603\",\"Description\":\"六级抽汽管道管顶温度\",\"Unit\":\"\",\"Upper\":\"\",\"Lower\":\"\",\"dead\":false,\"limit\":null,\"Lock\":false,\"upperBound\":\"2.16\",\"lowerBound\":\"-2.16\",\"LAY_TABLE_INDEX\":2,\"type\":null,\"TMax\":\"224.12\",\"TMin\":\"204.39\",\"TAvg\":\"215.80\",\"DMax\":\"0.80\",\"DMin\":\"0.00\",\"DAvg\":\"0.11\",\"C95\":\"0.39\",\"C99\":\"0.48\"},{\"PointId\":\"DCS06_06LBS60BT602\",\"Description\":\"六级抽汽温度2\",\"Unit\":\"\",\"Upper\":\"\",\"Lower\":\"\",\"dead\":false,\"limit\":null,\"Lock\":false,\"upperBound\":\"4.40\",\"lowerBound\":\"-4.40\",\"LAY_TABLE_INDEX\":3,\"type\":null,\"TMax\":\"169.10\",\"TMin\":\"152.61\",\"TAvg\":\"161.63\",\"DMax\":\"2.57\",\"DMin\":\"0.00\",\"DAvg\":\"0.33\",\"C95\":\"1.18\",\"C99\":\"1.45\"},{\"PointId\":\"DCS06_06LBS60BT601\",\"Description\":\"六级抽汽温度1\",\"Unit\":\"\",\"Upper\":\"200\",\"Lower\":\"80\",\"dead\":false,\"limit\":true,\"Lock\":false,\"upperBound\":\"0\",\"lowerBound\":\"0\",\"LAY_TABLE_INDEX\":4,\"type\":null,\"TMax\":\"113.75\",\"TMin\":\"94.10\",\"TAvg\":\"106.44\",\"DMax\":\"1.38\",\"DMin\":\"0.00\",\"DAvg\":\"0.18\",\"C95\":\"0.63\",\"C99\":\"0.78\"}],\"outPointInfo\":null,\"biasPointInfo\":null,\"faultVariablePointInfo\":null,\"btmState\":\"未下装\",\"version\":\"v-test\",\"smote\":null,\"online\":1,\"unit\":null,\"versionNumber\":0,\"Envelopes\":null,\"samrangenew\":null,\"para\":{\"Model_info\":{\"Train_X_min\":[203.19,204.388,152.612,94.104],\"Train_X_max\":[222.378,224.119,169.099,113.751],\"Train_X_std\":[3.682,3.769,2.893,2.741],\"Train_X_mean\":[214.429,215.798,161.625,106.441],\"Train_X_bais_max\":[[0.989,0.802,2.573,1.377]],\"Train_X_bais_min\":[[0.0,0.0,0.0,0.0]],\"Train_X_bais_mean\":[[0.166,0.111,0.332,0.178]],\"QCUL_95\":0.1263824,\"QCUL_99\":0.222977936,\"QCUL_95_line\":[0.585,0.388,1.181,0.632],\"QCUL_99_line\":[0.718,0.475,1.45,0.776],\"T2CUL_95\":6.033,\"T2CUL_99\":9.295,\"T2CUL_95_line\":[0.335,0.343,0.264,0.25],\"T2CUL_99_line\":[0.416,0.426,0.327,0.31],\"Kesi_95\":1.584,\"Kesi_99\":1.395,\"Kesi_95_line\":[0.172,0.176,0.135,0.128],\"Kesi_99_line\":[0.161,0.165,0.127,0.12],\"COV\":[[1.001,1.0,0.873,0.607],[1.0,1.001,0.879,0.609],[0.873,0.879,1.001,0.876],[0.607,0.609,0.876,1.001]],\"K\":2,\"R\":0.991,\"featValue\":[3.436,0.535,0.033,0.001],\"featVec\":[[0.511,0.436,0.292,0.681],[0.512,0.432,0.153,-0.727],[0.528,-0.196,-0.822,0.082],[0.445,-0.764,0.464,-0.043]],\"selectVec\":[[0.511,0.436],[0.512,0.432],[0.528,-0.196],[0.445,-0.764]]},\"Model_type\":\"PCA\",\"BeforeCleanSamNum\":817,\"AfterCleanSamNum\":727,\"CleanOrNot\":true},\"alarmmodelset\":{\"alarmname\":\"6号低加抽汽壁温大于150\",\"alarmcondition\":\"[DCS06_06LBS60BT602]>150\"},\"copy\":false,\"principal\":\"2\",\"precision\":\"99.1%\",\"rate\":\"0.95\",\"iter\":null,\"layer\":null,\"component\":null,\"count\":null,\"version1\":null}";

            logger.InfoLog("ModelInfo：" + warnDiagnosisInfo.ModelInfo);

            FcInfo fcInfo = DynamicCompileFC.CreateFcInfo(warnDiagnosisInfo);
            if (fcInfo != null)
            {


                (bool result, string error) = DynamicCompileFC.Compiler(fcInfo);
                //bool result = DynamicCompileFC.Compiler(fcInfo);
                if (result)
                {
                    logger.InfoLog($"{fcInfo.Name}动态编译成功！");
                    return Ok("动态编译成功");
                }
                else
                {
                    logger.InfoLog($"{fcInfo.Name}动态编译失败,{error}！");
                    return BadRequest($"{fcInfo.Name}动态编译失败,{error}！");
                }
            }
            else
            {
                return BadRequest("fail");
            }
        }


        [HttpPost]
        public async Task<IActionResult> DynamicCompileFaultDiagnosisFC([FromBody] FcInfo fcInfo)
        {
            //bool result = DynamicCompileFC.Compiler(fcInfo);
            (bool result, string error) = DynamicCompileFC.Compiler(fcInfo);
            if (result)
            {
                logger.InfoLog($"{fcInfo.Name}动态编译成功！");
                return Ok($"动态编译成功");
            }
            else
            {
                logger.InfoLog($"{fcInfo.Name}编译失败,{error}！");
                return BadRequest($"{fcInfo.Name}编译失败,{error}！");
            }
        }


        [HttpPost]
        public async Task<IActionResult> BatchDynamicCompileWarnDiagnosisFCByModelId(int? modelId)
        {
            (bool result, string error) = DynamicCompileFC.BatchCompiler(modelId);


            if (result)
            {
                logger.InfoLog($"动态编译成功！");
                return Ok($"动态编译成功");
            }
            else
            {
                logger.InfoLog($"动态编译失败,{error}！");
                return BadRequest($"动态编译失败,{error}！");
            }
        }

        [HttpPost]
        public async Task<IActionResult> BatchDynamicCompileWarnDiagnosisFCByModelName(string? modelName)
        {
            (bool result, string error) = DynamicCompileFC.BatchCompiler(modelName);
            if (result)
            {
                logger.InfoLog($"动态编译成功！");
                return Ok($"动态编译成功");
            }
            else
            {
                logger.InfoLog($"动态编译失败,{error}！");
                return BadRequest($"动态编译失败,{error}！");
            }
        }

        /// <summary>
        /// 模型启停
        /// </summary>
        /// <param name="eInfo"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> EnableFC([FromBody] EInfo eInfo)
        {
            bool result = ExcuteEngine.SetEnableFC(eInfo);
            return Ok(result ? "OK" : "fail");
        }

        [HttpPost]
        public async Task<IActionResult> GetWarnInstanceAlarmState([FromBody] List<string> algNames)
        {
            var ret = ExcuteEngine.GetWarnInstanceAlarmState(algNames);
            return Ok(ret);
        }

        [HttpGet]
        public async Task<IActionResult> GetWarnPointAlarmList2([FromQuery] int SysID = -1, int ModelID = -1)
        {
            var ret = ExcuteEngine.GetWarnPointAlarmList2(SysID, ModelID);
            return Ok(ret);
        }

        [HttpGet]
        public async Task<IActionResult> GetWarnPointAlarmList([FromQuery] int SysID = -1, int ModelID = -1)
        {
            var ret = ExcuteEngine.GetWarnPointAlarmList(SysID, ModelID);
            return Ok(ret);
        }

        [HttpGet]
        public async Task<IActionResult> GetWarnPointStatusList([FromQuery] int SysID = -1, int ModelID = -1)
        {
            var ret = ExcuteEngine.GetWarnPointStatusList(SysID, ModelID);
            return Ok(ret);
        }

        [HttpGet]
        public async Task<IActionResult> GetWarnPointStatusList2([FromQuery] int SysID = -1, int ModelID = -1)
        {
            var ret = ExcuteEngine.GetWarnPointStatusList2(SysID, ModelID);
            return Ok(ret);
        }

        #endregion

        #region 能效预警接口

        [HttpPost]
        public async Task<IActionResult> Gethdldata([FromBody] HdlRequest request)
        {
            try
            {
                var result = EconomicAlarmMonitoringService.GetHdlList(request.TimeDelta.Value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Getrmrzdata([FromBody] HdlRequest request)
        {
            try
            {
                var result = EconomicAlarmMonitoringService.GetRmrzList(request.TimeDelta.Value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> GetZkdata([FromBody] HdlRequest request)
        {
            try
            {
                var result = EconomicAlarmMonitoringService.GetZkList(request.TimeDelta.Value);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddEconomicCfg([FromBody] economiccfg economiccfg)
        {
            try
            {
                string errmsg = "";
                var ret = EconomicAlarmMonitoringService.AddEconomicCfg(economiccfg, out errmsg);
                if (ret)
                {
                    return Ok("保存成功！");
                }
                else
                {
                    return BadRequest(errmsg);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateEconomicCfg([FromBody] economiccfg economiccfg)
        {
            try
            {
                string errmsg = "";
                var ret = EconomicAlarmMonitoringService.UpdateEconomicCfg(economiccfg, out errmsg);
                if (ret)
                {
                    return Ok("保存成功！");
                }
                else
                {
                    return BadRequest(errmsg);
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteEconomicCfg(int id)
        {
            try
            {
                var ret = EconomicAlarmMonitoringService.DeleteEconomicCfg(id);
                return Ok("删除成功！");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetAllEconomicCfg()
        {
            try
            {
                var ret = EconomicAlarmMonitoringService.GetAllEconomicCfg();
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetEconomicAlarm(string bt, string et, string pointname)
        {
            try
            {
                var ret = EconomicAlarmMonitoringService.GetEconomicAlarm(bt, et, pointname);
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// 删除能效报警
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteEconomicAlarm(int id)
        {
            try
            {
                var ret = EconomicAlarmMonitoringService.DeleteEconomicAlarm(id);
                return Ok("删除成功！");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// 获取能效报警曲线
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEconomicAlarmCurve(int id)
        {
            try
            {
                var ret = EconomicAlarmMonitoringService.GetEconomicAlarmCurve(id);
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }



        #endregion

        #region 获取点名或点值
        [HttpGet]
        public async Task<IActionResult> GetPoints()
        {
            var ret = ExcuteEngine.pointsList;
            return Ok(ret);
        }

        [HttpPost]
        public async Task<IActionResult> GetPointsByNames([FromBody] List<string> pointsname)
        {
            var ret = ExcuteEngine.pointsList.Where(x => pointsname.Contains(x.Name.Replace('-', '_').ToLower()))
                .ToList();
            return Ok(ret);
        }

        [HttpGet]
        public async Task<IActionResult> GetReference([FromQuery] string pointName)
        {
            var dict = ExcuteEngine.GetReference(pointName);
            return Ok(dict);
        }

        [HttpGet]
        public async Task<IActionResult> GetPointValue([FromQuery] string pointName)
        {
            var dict = ExcuteEngine.GetPointValue(pointName);
            return Ok(dict);
        }


        [HttpGet]
        public async Task<IActionResult> GetWarnRulePointValue([FromQuery] string pointName)
        {
            var dict = ExcuteEngine.GetWarnRulePointValue(pointName);
            return Ok(dict);
        }


        [HttpGet]
        public async Task<IActionResult> GetRealTimeValue(string pn)
        {
            var ret = ExcuteEngine.GetRealTimeValue(pn);
            return Ok(ret);
        }

        [HttpPost]
        public async Task<Dictionary<string, string[]>?> GetRealTimeValues(string[] pointnames)
        {
            if (ExcuteEngine.RTDDict == null)
                return null;

            Dictionary<string, string[]?> pointsvalue = new Dictionary<string, string[]?>();

            try
            {
                foreach (string pname in pointnames)
                {
                    string svalue = "";
                    string stime = "";

                    bool finded = false;
                    foreach (var item in ExcuteEngine.RTDDict)
                    {
                        string key = item.Key.ToTableName();
                        if (key == pname)
                        {
                            finded = true;
                            object obj = item.Value;
                            lock (mylock)
                            {
                                if (obj is LAExWarn)
                                {
                                    LAExWarn lAEx = (LAExWarn)obj;
                                    svalue = lAEx.buffer.ToString();
                                    stime = lAEx.DataReceiveTime;
                                }
                                else if (obj is LDEx)
                                {
                                    LDEx lDEx = (LDEx)obj;
                                    svalue = lDEx.buffer.ToString();
                                    stime = lDEx.DataReceiveTime;
                                }
                                else if (obj is LP32)
                                {
                                    LP32 lP32 = (LP32)obj;
                                    svalue = lP32.buffer.ToString();
                                    stime = lP32.DataReceiveTime;
                                }
                            }
                            break;
                        }
                    }

                    if (finded)
                    {
                        pointsvalue.Add(pname, new string[] { svalue, stime });
                    }
                    else
                    {
                        pointsvalue.Add(pname, null);
                    }
                }
            }
            catch (Exception ex)
            {

            }

            return pointsvalue;
        }



        [HttpPost("/point/addValues")]
        public async Task<Dictionary<string, object>> HandleAddValues(Dictionary<string, double> values)
        {


            Dictionary<string, object> response = new()
            {
                ["code"] = 200,
                ["message"] = string.Empty
            };
            try
            {
                InfluxDBHelp.BatchInsert(values);
            }
            catch (Exception ex)
            {

                response["message"] = ex.Message;
                response["code"] = 500;
            }
            return response;
        }

        [HttpPost]
        public async Task<Dictionary<string, string>?> GetPoints(string[] pointsname)
        {
            var sysPointDict = ExcuteEngine.RTDDict;
            if (sysPointDict == null)
                return null;

            var pointsValue = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

            /* ---------- 局部函数：根据类型提取值 ---------- */
            string GetValue(object? obj, string suffix)
            {
                if (obj == null)
                    return suffix switch
                    {
                        ".AV" or ".av" or ".A2" or ".a2" or ".1W" or ".1w" or
                        ".BV" or ".bv" or ".TV" or ".tv" => "0",
                        _ => string.Empty
                    };

                lock (mylock)
                {
                    return suffix.ToUpper() switch
                    {
                        ".AV" or ".A2" when obj is LAExWarn la
                            => la.buffer.ToString("0.##"),

                        ".1W" when obj is LDEx ld
                            => (ld.buffer ? 1 : 0).ToString("0"),

                        ".EU" when obj is LAExWarn la
                            => la.Unit,

                        ".BV" when obj is LAExWarn la
                            => la.MinValue.ToString("0"),

                        ".TV" when obj is LAExWarn la
                            => la.MaxValue.ToString("0"),

                        _ => obj switch
                        {
                            LAExWarn la => la.buffer.ToString(),
                            LDEx ld => ld.buffer.ToString(),
                            LP32 lp => lp.buffer.ToString(),
                            _ => string.Empty
                        }
                    };
                }
            }

            /* ---------- 主循环 ---------- */
            foreach (var pname in pointsname)
            {
                if (pointsValue.ContainsKey(pname))
                    continue;

                // 统一处理后缀
                var (baseName, suffix) = SplitSuffix(pname);

                var sysPoint = ExcuteEngine.GetFirstRunableWarn(baseName);
                pointsValue[pname] = GetValue(sysPoint, suffix);
            }

            return pointsValue;

            /* ---------- 局部函数：分离点名与后缀 ---------- */
            (string BaseName, string Suffix) SplitSuffix(string fullName)
            {
                var dotIndex = fullName.LastIndexOf('.');
                return dotIndex >= 0
                    ? (fullName.Substring(0, dotIndex), fullName.Substring(dotIndex))
                    : (fullName, string.Empty);
            }
        }

        #endregion

        #region 健康度
        [HttpPost]
        public async Task<IActionResult> GetDeviceHealthWeight(int sysId)
        {
            var result = ExcuteEngine.GetDeviceHealthWeight(sysId);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> GetIndicatorHealthWeight(int devId)
        {
            var result = ExcuteEngine.GetIndicatorHealthWeight(devId);
            return Ok(result);
        }

        [HttpPost]

        public async Task<IActionResult> SetDeviceHealthWeightToDb(List<Healthy> healthies)
        {
            bool result = ExcuteEngine.SetDeviceHealthWeightToDb(healthies);
            return Ok(result ? "OK" : "fail");
        }

        [HttpPost]

        public async Task<IActionResult> SetIndicatorHealthWeightToDb(List<Devicehealthy> devicehealthies)
        {
            bool result = ExcuteEngine.SetIndicatorHealthWeightToDb(devicehealthies);
            return Ok(result ? "OK" : "fail");
        }

        /// <summary>
        /// 获取健康度得分
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetHealthScore()
        {
            var dict = ExcuteEngine.GetHealthScore();
            return Ok(dict);
        }

        [HttpPost]
        public async Task<IActionResult> GetHealthScore2()
        {
            var dict = ExcuteEngine.GetHealthScore();
            return Ok(new ApiResponse<object>(200, "", dict));
        }
        #endregion

        #region 预警统计
        /// <summary>
        /// 获取模型和规则测点的报警统计表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetWarnAlarmTotalChart(int? alarmType)
        {
            var result = ExcuteEngine.GetWarnAlarmTotalChart(alarmType);
            return Ok(result);
        }


        /// <summary>
        /// 获取模型测点和规则测点的报警信息
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetWarnAlarmList([FromBody] WarnAlarmRequest request)
        {

            try
            {
                var result = ExcuteEngine.GetWarnAlarmList(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        /// <summary>
        /// 删除预警报警记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteWarnAlarm(int id)
        {

            try
            {
                var result = ExcuteEngine.DeleteWarnAlarm(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region 故障诊断

        [HttpGet]
        public async Task<IActionResult> GetFaultList()
        {
            var ret = ExcuteEngine.GetFaultList();
            return Ok(ret);
        }

        /// <summary>
        /// 故障诊断统计表
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetFaultDiagnosisAlarmTotalChart()
        {
            var result = ExcuteEngine.GetFaultDiagnosisTotalChart();
            return Ok(result);
        }


        /// <summary>
        /// 故障诊断报警列表
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetFaultDiagnosisAlarmList([FromBody] WarnAlarmRequest request)
        {

            try
            {
                var result = ExcuteEngine.GetFaultDiagnosisAlarmList(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 删除故障记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteFaultDiagnosis(int id)
        {

            try
            {
                var result = ExcuteEngine.DeleteFaultDiagnosis(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region 寻优指导

        [HttpGet]
        public async Task<IActionResult> GetAllWarnPointOperationGuide()
        {
            try
            {
                var ret = ICCompareService.GetAll();
                return Ok(ret);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpPost]
        public async Task<IActionResult> AddOrUpdateWarnPointOperationGuide([FromBody] warnpointoperationguide request)
        {
            try
            {
                var result = ICCompareService.AddOrUpdate(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> DeleteWarnPointOperationGuide(int id)
        {
            try
            {
                var result = ICCompareService.Delete(id);
                return Ok("删除成功！");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetOperationGuide(string pn, int type)
        {
            try
            {
                var result = ICCompareService.GetOperationGuide(pn, type);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetICCompareResult()
        {
            var result = ICCompareService.GetICCompareResult();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetICPoints()
        {
            var result = ExcuteEngine.GetICPoints();
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> ManualCompare()
        {
            ICCompareService.ManualCompare();
            return Ok(true);
        }

        /// <summary>
        /// 添加专家库
        /// </summary>
        /// <param name="dateTime"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AddExpertIC2(string dateTime)
        {
            try
            {
                string errstr;
                var result = ICCompareService.CreateExpertICByDt(dateTime, out errstr);
                if (!string.IsNullOrEmpty(errstr.Trim()))
                {
                    return BadRequest(errstr.Trim());
                }
                else
                {
                    return Ok(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        /// <summary>
        /// 更行专家库
        /// </summary>
        /// <param name="cldIndexcondition"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdateExpertIC([FromBody] CldIndexcondition cldIndexcondition)
        {
            var result = ICCompareService.UpdateExpertIC(cldIndexcondition);
            return Ok(result);
        }
        /// <summary>
        /// 删除专家库
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> DeleteExpertIC(int id)
        {
            var result = ICCompareService.DeleteExpertIC(id);
            return Ok(result);
        }

        /// <summary>
        /// 寻优清单
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Getxunyoudata([FromBody] xunyoudataRequest request)
        {
            var result = ExcuteEngine.GetxunyoudataTotalChart(request);
            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Getxunyoudatachart([FromBody] adviseRequest request)
        {
            var result = ExcuteEngine.Getxunyoudataadvice(request);
            return Ok(result);
        }

        /// <summary>
        /// 添加或更新敏感因子
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddOrUpdateSensitiveFactors([FromBody] Sensitivefactorstandard request)
        {
            try
            {
                var result = ICCompareService.AddOrUpdateSensitiveFactors(request);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetSensitivefactorstandards()
        {
            try
            {
                var result = ICCompareService.Getsensitivefactorstandards();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new { Message = "An error occurred while processing your request.", Details = ex.Message });
            }
        }

        /// <summary>
        /// 获取除标杆库外的其他分组
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetICGroup()
        {
            try
            {
                var result = ICCompareService.GetICGroup();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region 品质评估
        [HttpGet]
        public async Task<IActionResult> GetAllControlLastData(string unitName)
        {
            try
            {
                var result = ControlQualityService.GetAllControlLastData(unitName);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> GetControlInfoData([FromBody] ControlQueryModel model)
        {
            try
            {
                var result = ControlQualityService.GetControlInfoDataAsync(model).Result;
                var result1 = ControlQualityService.GetControlInfoDataautoAsync(model).Result;
                if (result1 != null)
                    result.AddRange(result1);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetControlAlarmCurve(int id)
        {
            try
            {
                var result = ControlQualityService.GetControlAlarmCurve(id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteControl(int id)
        {
            try
            {
                var result = ControlQualityService.DeleteControl(id);
                return Ok("删除成功！");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        public async Task<IActionResult> DeleteControlInfo(int id)
        {
            try
            {
                var result = ControlQualityService.DeleteControlInfo(id);
                return Ok("删除成功！");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> UpdateControl([FromBody] ControlInfoData controlInfoData)
        {
            try
            {
                var result = ControlQualityService.UpdateControl(controlInfoData);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult clickDatasave([FromBody] click model)
        {
            try
            {
                bool result = ControlQualityService.clickdatasave(model);
                if (!result)
                {
                    return Ok("请求过于频繁，请稍后再试。");
                }
                return Ok("保存成功");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Getcontrolweigh([FromBody] controlweighunit unit)
        {
            try
            {
                var result = ControlQualityService.getweigh(unit).Result;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Setcontrolweigh([FromBody] Controlweigh unit)
        {
            try
            {
                var result = ControlQualityService.setweigh(unit).Result;
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        #endregion

        #region 系统点表导入

        /// <summary>
        /// Excel导入点表数据
        /// </summary>
        /// <param name="file">Excel文件</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ImportPointsFromExcel(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("请选择要上传的Excel文件");
                }

                // 检查文件扩展名
                string extension = Path.GetExtension(file.FileName).ToLower();
                if (extension != ".xlsx" && extension != ".xls")
                {
                    return BadRequest("只支持.xlsx和.xls格式的Excel文件");
                }

                // 设置EPPlus许可证上下文
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;


                var result = new List<ExcelImportResult>();
                var successCount = 0;
                var errorCount = 0;

                using (var stream = file.OpenReadStream())
                using (var package = new ExcelPackage(stream))
                {
                    var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                    {
                        return BadRequest("Excel文件中没有找到工作表");
                    }

                    // 获取数据范围 - 修复行数计算问题
                    int originalRowCount = worksheet.Dimension?.Rows ?? 0;
                    int rowCount = GetActualRowCount(worksheet);
                    int colCount = worksheet.Dimension?.Columns ?? 0;

                    // 添加调试信息
                    Console.WriteLine($"Excel文件信息: 原始行数={originalRowCount}, 实际数据行数={rowCount}, 列数={colCount}");

                    if (rowCount < 2 || colCount < 3)
                    {
                        return BadRequest($"Excel文件格式不正确，至少需要3列数据（PointName、Desc、DataType）。检测到行数：{rowCount}，列数：{colCount}");
                    }

                    // 验证表头
                    var headerRow = worksheet.Cells[1, 1, 1, 3];
                    var expectedHeaders = new[] { "PointName", "Desc", "DataType" };
                    for (int i = 0; i < 3; i++)
                    {
                        var headerValue = headerRow[1, i + 1].Value?.ToString()?.Trim();
                        if (string.IsNullOrEmpty(headerValue) || !expectedHeaders[i].Equals(headerValue, StringComparison.OrdinalIgnoreCase))
                        {
                            return BadRequest($"Excel文件表头格式不正确，第{i + 1}列应为：{expectedHeaders[i]}");
                        }
                    }

                    // 先收集所有有效的数据
                    var validPoints = new List<ExcuteEngine.PointData>();
                    var invalidRows = new List<ExcelImportResult>();

                    for (int row = 2; row <= rowCount + 1; row++)
                    {
                        var pointName = worksheet.Cells[row, 1].Value?.ToString()?.Trim();
                        var description = worksheet.Cells[row, 2].Value?.ToString()?.Trim();
                        var dataType = worksheet.Cells[row, 3].Value?.ToString()?.Trim();

                        var importResult = new ExcelImportResult
                        {
                            RowNumber = row,
                            PointName = pointName,
                            Description = description,
                            DataType = dataType
                        };

                        // 数据验证
                        if (string.IsNullOrEmpty(pointName))
                        {
                            importResult.IsSuccess = false;
                            importResult.ErrorMessage = "点名不能为空";
                            invalidRows.Add(importResult);
                            errorCount++;
                        }
                        //else if (string.IsNullOrEmpty(description))
                        //{
                        //    importResult.IsSuccess = false;
                        //    importResult.ErrorMessage = "描述不能为空";
                        //    invalidRows.Add(importResult);
                        //    errorCount++;
                        //}
                        else if (string.IsNullOrEmpty(dataType))
                        {
                            importResult.IsSuccess = false;
                            importResult.ErrorMessage = "数据类型不能为空";
                            invalidRows.Add(importResult);
                            errorCount++;
                        }
                        else if (!IsValidDataType(dataType))
                        {
                            importResult.IsSuccess = false;
                            importResult.ErrorMessage = $"不支持的数据类型：{dataType}，支持的类型：LA、LD、LP";
                            invalidRows.Add(importResult);
                            errorCount++;
                        }
                        else
                        {
                            // 数据验证通过，收集到有效数据列表
                            validPoints.Add(new ExcuteEngine.PointData
                            {
                                PointName = pointName,
                                Description = description,
                                DataType = dataType
                            });
                        }
                    }

                    // 批量添加有效数据到系统
                    if (validPoints.Count > 0)
                    {
                        try
                        {
                            var batchResult = ExcuteEngine.AddPointToVarsystems(validPoints);
                            if (batchResult.Success)
                            {
                                //// 更新成功导入的记录
                                //foreach (var point in batchResult.AddedPoints)
                                //{
                                //    var importResult = new ExcelImportResult
                                //    {
                                //        RowNumber = 0, // 行号在批量导入中无法确定
                                //        PointName = point.PointName,
                                //        Description = point.Description,
                                //        DataType = point.DataType,
                                //        IsSuccess = true,
                                //        SuccessMessage = "批量添加成功"
                                //    };
                                //    result.Add(importResult);
                                //    successCount++;
                                //}

                                // 更新跳过的记录
                                foreach (var point in batchResult.SkippedPoints)
                                {
                                    var importResult = new ExcelImportResult
                                    {
                                        RowNumber = 0, // 行号在批量导入中无法确定
                                        PointName = point.PointName,
                                        Description = point.Description,
                                        DataType = point.DataType,
                                        IsSuccess = true,
                                        SuccessMessage = "点表已存在，跳过"
                                    };
                                    result.Add(importResult);
                                    successCount++;
                                }
                            }
                            else
                            {
                                // 批量添加失败，将所有有效数据标记为失败
                                foreach (var point in validPoints)
                                {
                                    //var importResult = new ExcelImportResult
                                    //{
                                    //    RowNumber = 0,
                                    //    PointName = point.PointName,
                                    //    Description = point.Description,
                                    //    DataType = point.DataType,
                                    //    IsSuccess = false,
                                    //    ErrorMessage = batchResult.Message
                                    //};
                                    //result.Add(importResult);
                                    errorCount++;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // 批量添加异常，将所有有效数据标记为失败
                            foreach (var point in validPoints)
                            {
                                //var importResult = new ExcelImportResult
                                //{
                                //    RowNumber = 0,
                                //    PointName = point.PointName,
                                //    Description = point.Description,
                                //    DataType = point.DataType,
                                //    IsSuccess = false,
                                //    ErrorMessage = $"系统错误：{ex.Message}"
                                //};
                                //result.Add(importResult);
                                errorCount++;
                            }
                        }
                    }

                    // 添加无效行记录
                    result.AddRange(invalidRows);
                }

                return Ok(new
                {
                    Success = true,
                    Message = $"导入完成，成功：{successCount}条，失败：{errorCount}条",
                    TotalRows = result.Count,
                    SuccessCount = successCount,
                    ErrorCount = errorCount,
                    Details = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"导入失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 下载Excel模板
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DownloadExcelTemplate()
        {
            try
            {
                // 设置EPPlus许可证上下文
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("点表模板");

                    // 设置表头
                    worksheet.Cells[1, 1].Value = "PointName";
                    worksheet.Cells[1, 2].Value = "Desc";
                    worksheet.Cells[1, 3].Value = "DataType";

                    // 设置表头样式
                    using (var range = worksheet.Cells[1, 1, 1, 3])
                    {
                        range.Style.Font.Bold = true;
                        range.Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                        range.Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                    }

                    // 添加示例数据
                    worksheet.Cells[2, 1].Value = "DCS01_10HTR89AA106-XB02";
                    worksheet.Cells[2, 2].Value = "1号干燥塔烟气进口电动挡板门开位反馈";
                    worksheet.Cells[2, 3].Value = "LD";

                    worksheet.Cells[3, 1].Value = "DCS01_10HTR89AA105-XB03";
                    worksheet.Cells[3, 2].Value = "1号干燥塔仓泵落料气动阀关位反馈";
                    worksheet.Cells[3, 3].Value = "LD";

                    worksheet.Cells[4, 1].Value = "DCS01_10HTR89AP001-XB02";
                    worksheet.Cells[4, 2].Value = "1号干燥塔雾化器电机运行反馈";
                    worksheet.Cells[4, 3].Value = "LD";

                    // 设置列宽
                    worksheet.Column(1).Width = 35;
                    worksheet.Column(2).Width = 50;
                    worksheet.Column(3).Width = 15;

                    // 设置数据验证（数据类型列）
                    var dataValidation = worksheet.DataValidations.AddListValidation("C2:C1000");
                    dataValidation.Formula.Values.Add("LA");
                    dataValidation.Formula.Values.Add("LD");
                    dataValidation.Formula.Values.Add("LP");
                    dataValidation.ShowErrorMessage = true;
                    dataValidation.ErrorTitle = "数据类型错误";
                    dataValidation.Error = "请选择LA、LD或LP";

                    // 设置边框
                    using (var range = worksheet.Cells[1, 1, 4, 3])
                    {
                        range.Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thin);
                        range.Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        range.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                    }

                    // 转换为字节数组
                    var content = package.GetAsByteArray();
                    var fileName = $"点表导入模板_{DateTime.Now:yyyyMMdd}.xlsx";

                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"模板下载失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 批量导入点表数据
        /// </summary>
        /// <param name="request">批量导入请求</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> BatchImportPoints([FromBody] BatchImportRequest request)
        {
            try
            {
                if (request?.Points == null || request.Points.Count == 0)
                {
                    return BadRequest("请提供要导入的点表数据");
                }

                var result = new List<BatchImportResult>();
                var successCount = 0;
                var errorCount = 0;
                var validPoints = new List<ExcuteEngine.PointData>();

                // 先收集所有有效的数据
                foreach (var point in request.Points)
                {
                    // 数据验证
                    if (string.IsNullOrEmpty(point.PointName))
                    {
                        var importResult = new BatchImportResult
                        {
                            PointName = point.PointName,
                            Description = point.Description,
                            DataType = point.DataType,
                            IsSuccess = false,
                            ErrorMessage = "点名不能为空"
                        };
                        result.Add(importResult);
                        errorCount++;
                    }
                    else if (string.IsNullOrEmpty(point.Description))
                    {
                        var importResult = new BatchImportResult
                        {
                            PointName = point.PointName,
                            Description = point.Description,
                            DataType = point.DataType,
                            IsSuccess = false,
                            ErrorMessage = "描述不能为空"
                        };
                        result.Add(importResult);
                        errorCount++;
                    }
                    else if (string.IsNullOrEmpty(point.DataType))
                    {
                        var importResult = new BatchImportResult
                        {
                            PointName = point.PointName,
                            Description = point.Description,
                            DataType = point.DataType,
                            IsSuccess = false,
                            ErrorMessage = "数据类型不能为空"
                        };
                        result.Add(importResult);
                        errorCount++;
                    }
                    else if (!IsValidDataType(point.DataType))
                    {
                        var importResult = new BatchImportResult
                        {
                            PointName = point.PointName,
                            Description = point.Description,
                            DataType = point.DataType,
                            IsSuccess = false,
                            ErrorMessage = $"不支持的数据类型：{point.DataType}，支持的类型：LA、LD、LP"
                        };
                        result.Add(importResult);
                        errorCount++;
                    }
                    else
                    {
                        // 数据验证通过，收集到有效数据列表
                        validPoints.Add(new ExcuteEngine.PointData
                        {
                            PointName = point.PointName,
                            Description = point.Description,
                            DataType = point.DataType
                        });
                    }
                }

                // 批量添加有效数据到系统
                if (validPoints.Count > 0)
                {
                    try
                    {
                        var batchResult = ExcuteEngine.AddPointToVarsystems(validPoints);
                        if (batchResult.Success)
                        {
                            // 更新成功导入的记录
                            foreach (var addedPoint in batchResult.AddedPoints)
                            {
                                var importResult = new BatchImportResult
                                {
                                    PointName = addedPoint.PointName,
                                    Description = addedPoint.Description,
                                    DataType = addedPoint.DataType,
                                    IsSuccess = true,
                                    SuccessMessage = "批量添加成功"
                                };
                                result.Add(importResult);
                                successCount++;
                            }

                            // 更新跳过的记录
                            foreach (var skippedPoint in batchResult.SkippedPoints)
                            {
                                var importResult = new BatchImportResult
                                {
                                    PointName = skippedPoint.PointName,
                                    Description = skippedPoint.Description,
                                    DataType = skippedPoint.DataType,
                                    IsSuccess = true,
                                    SuccessMessage = "点表已存在，跳过"
                                };
                                result.Add(importResult);
                                successCount++;
                            }
                        }
                        else
                        {
                            // 批量添加失败，将所有有效数据标记为失败
                            foreach (var validPoint in validPoints)
                            {
                                var importResult = new BatchImportResult
                                {
                                    PointName = validPoint.PointName,
                                    Description = validPoint.Description,
                                    DataType = validPoint.DataType,
                                    IsSuccess = false,
                                    ErrorMessage = batchResult.Message
                                };
                                result.Add(importResult);
                                errorCount++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // 批量添加异常，将所有有效数据标记为失败
                        foreach (var validPoint in validPoints)
                        {
                            var importResult = new BatchImportResult
                            {
                                PointName = validPoint.PointName,
                                Description = validPoint.Description,
                                DataType = validPoint.DataType,
                                IsSuccess = false,
                                ErrorMessage = $"系统错误：{ex.Message}"
                            };
                            result.Add(importResult);
                            errorCount++;
                        }
                    }
                }

                return Ok(new
                {
                    Success = true,
                    Message = $"批量导入完成，成功：{successCount}条，失败：{errorCount}条",
                    TotalPoints = result.Count,
                    SuccessCount = successCount,
                    ErrorCount = errorCount,
                    Details = result
                });
            }
            catch (Exception ex)
            {
                return BadRequest($"批量导入失败：{ex.Message}");
            }
        }

        /// <summary>
        /// 批量导入请求
        /// </summary>
        public class BatchImportRequest
        {
            /// <summary>
            /// 点表数据列表
            /// </summary>
            public List<PointData> Points { get; set; } = new List<PointData>();
        }

        /// <summary>
        /// 点表数据
        /// </summary>
        public class PointData
        {
            /// <summary>
            /// 点名
            /// </summary>
            public string PointName { get; set; } = string.Empty;

            /// <summary>
            /// 描述
            /// </summary>
            public string Description { get; set; } = string.Empty;

            /// <summary>
            /// 数据类型
            /// </summary>
            public string DataType { get; set; } = string.Empty;
        }

        /// <summary>
        /// 批量导入结果
        /// </summary>
        public class BatchImportResult
        {
            /// <summary>
            /// 点名
            /// </summary>
            public string PointName { get; set; } = string.Empty;

            /// <summary>
            /// 描述
            /// </summary>
            public string Description { get; set; } = string.Empty;

            /// <summary>
            /// 数据类型
            /// </summary>
            public string DataType { get; set; } = string.Empty;

            /// <summary>
            /// 是否成功
            /// </summary>
            public bool IsSuccess { get; set; }

            /// <summary>
            /// 成功消息
            /// </summary>
            public string SuccessMessage { get; set; } = string.Empty;

            /// <summary>
            /// 错误消息
            /// </summary>
            public string ErrorMessage { get; set; } = string.Empty;
        }

        /// <summary>
        /// 获取Excel工作表的实际行数（排除空行）
        /// </summary>
        /// <param name="worksheet">工作表</param>
        /// <returns>实际数据行数</returns>
        private int GetActualRowCount(ExcelWorksheet worksheet)
        {
            if (worksheet?.Dimension == null)
                return 0;

            int maxRow = worksheet.Dimension.End.Row;
            int actualRowCount = 0;

            // 从第2行开始检查（跳过表头）
            for (int row = 2; row <= maxRow; row++)
            {
                // 检查该行是否有数据（至少第一列有值）
                var pointName = worksheet.Cells[row, 1].Value?.ToString()?.Trim();
                if (!string.IsNullOrEmpty(pointName))
                {
                    actualRowCount = row;
                }
                else
                {
                    // 如果连续遇到5个空行，认为数据结束（避免误判）
                    int emptyRowCount = 0;
                    for (int checkRow = row; checkRow <= Math.Min(row + 4, maxRow); checkRow++)
                    {
                        var checkValue = worksheet.Cells[checkRow, 1].Value?.ToString()?.Trim();
                        if (string.IsNullOrEmpty(checkValue))
                        {
                            emptyRowCount++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (emptyRowCount >= 5)
                    {
                        break; // 数据结束
                    }
                }
            }

            // 如果找到数据行，返回实际行数；否则返回0
            return actualRowCount > 0 ? actualRowCount - 1 : 0;
        }

        /// <summary>
        /// 验证数据类型是否有效
        /// </summary>
        /// <param name="dataType">数据类型</param>
        /// <returns>是否有效</returns>
        private bool IsValidDataType(string dataType)
        {
            if (string.IsNullOrEmpty(dataType))
                return false;

            var validTypes = new[] { "LA", "LD", "LP" };
            return validTypes.Contains(dataType.ToUpper());
        }

        /// <summary>
        /// Excel导入结果
        /// </summary>
        public class ExcelImportResult
        {
            /// <summary>
            /// 行号
            /// </summary>
            public int RowNumber { get; set; }

            /// <summary>
            /// 点名
            /// </summary>
            public string PointName { get; set; } = string.Empty;

            /// <summary>
            /// 描述
            /// </summary>
            public string Description { get; set; } = string.Empty;

            /// <summary>
            /// 数据类型
            /// </summary>
            public string DataType { get; set; } = string.Empty;

            /// <summary>
            /// 是否成功
            /// </summary>
            public bool IsSuccess { get; set; }

            /// <summary>
            /// 成功消息
            /// </summary>
            public string SuccessMessage { get; set; } = string.Empty;

            /// <summary>
            /// 错误消息
            /// </summary>
            public string ErrorMessage { get; set; } = string.Empty;
        }
        #endregion

        #region 设备运行配置接口

        /// <summary>
        /// 获取最新的定时任务结果
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetRunStatus()
        {
            try
            {
                var result = DeviceRunCfgService.GetRunStatus();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 获取定时工作时间配置
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetTimeCfg()
        {
            try
            {
                var result = DeviceRunCfgService.GetTimeCfg();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 更新时间配置
        /// </summary>
        /// <param name="request">时间配置请求</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdateTimeCfg([FromBody] TimeConfigRequest request)
        {
            try
            {
                var result = DeviceRunCfgService.UpdateTimeCfg(request);
                if (result.Status == "success")
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new TimeConfigResponse
                {
                    Status = "error",
                    Message = $"Server error: {ex.Message}"
                });
            }
        }

        /// <summary>
        /// 更新flash状态
        /// </summary>
        /// <param name="request">flash更新请求</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdateFlash([FromBody] FlashUpdateRequest request)
        {
            try
            {
                var result = DeviceRunCfgService.UpdateFlash(request);
                if (result.Status == "success")
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(result);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new TimeConfigResponse
                {
                    Status = "error",
                    Message = $"Server error: {ex.Message}"
                });
            }
        }

        /// <summary>
        /// 重置所有设备的flash状态（交班时调用）
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ResetAllFlash()
        {
            try
            {
                var result = DeviceRunCfgService.ResetAllFlash();
                return Ok(result ? "OK" : "fail");
            }
            catch (Exception ex)
            {
                return BadRequest("fail" + ex.Message);
            }
        }

        #endregion

        #region 日志管理

        /// <summary>
        /// 获取日志文件内容
        /// </summary>
        /// <param name="logType">日志类型：error-错误日志, info-正常日志</param>
        /// <param name="lines">读取行数，默认100行</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetLogs([FromQuery][DefaultValue(LogType.Info)] LogType logType = LogType.Info, [FromQuery] int lines = 100)
        {
            try
            {
                // 根据日志类型确定日志文件路径
                string logFilePath;
                string logTypeName;

                switch (logType)
                {
                    case LogType.Error:
                        logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Log", "Error", "Error.log");
                        logTypeName = "错误日志";
                        break;
                    case LogType.Info:
                        logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Log", "Info", "Info.log");
                        logTypeName = "正常日志";
                        break;
                    default:
                        return BadRequest("不支持的日志类型");
                }

                // 检查文件是否存在
                if (!System.IO.File.Exists(logFilePath))
                {
                    return Ok(new
                    {
                        Success = true,
                        Message = $"{logTypeName}文件不存在",
                        LogType = logType.ToString(),
                        FilePath = logFilePath,
                        TotalLines = 0,
                        Lines = new List<string>()
                    });
                }

                // 读取文件的最后N行
                var logLines = new List<string>();

                try
                {
                    // 读取所有行
                    var allLines = System.IO.File.ReadAllLines(logFilePath);

                    // 获取最后N行
                    int startIndex = Math.Max(0, allLines.Length - lines);
                    logLines = allLines.Skip(startIndex).ToList();

                    return Ok(new
                    {
                        Success = true,
                        Message = $"成功读取{logTypeName}",
                        LogType = logType.ToString(),
                        FilePath = logFilePath,
                        TotalLines = allLines.Length,
                        RequestedLines = lines,
                        ReturnedLines = logLines.Count,
                        Lines = logLines
                    });
                }
                catch (IOException ioEx)
                {
                    logger.ErrorLog($"读取日志文件失败：{ioEx.Message}");
                    return BadRequest($"读取日志文件失败：{ioEx.Message}");
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"获取日志时发生错误：{ex.Message}");
                return BadRequest($"获取日志失败：{ex.Message}");
            }
        }

        #endregion

        #region Pointshow接口

        /// <summary>
        /// 添加Pointshow记录（简化版 - 只需传pointname）
        /// </summary>
        /// <param name="pointname">点名</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> AddPointshowSimple(string pointname)
        {
            try
            {
                var pointshow = new Pointshow { pointname = pointname };
                var result = ExcuteEngine.AddPointshow(pointshow);
                if (result)
                {
                    return Ok("添加成功！");
                }
                else
                {
                    return BadRequest("添加失败！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 添加Pointshow记录（完整版 - 传入完整对象）
        /// </summary>
        /// <param name="pointshow">Pointshow对象</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddPointshow([FromBody] Pointshow pointshow)
        {
            try
            {
                var result = ExcuteEngine.AddPointshow(pointshow);
                if (result)
                {
                    return Ok("添加成功！");
                }
                else
                {
                    return BadRequest("添加失败！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 批量添加Pointshow记录
        /// </summary>
        /// <param name="pointshows">Pointshow列表</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> AddPointshows([FromBody] List<Pointshow> pointshows)
        {
            try
            {
                var result = ExcuteEngine.AddPointshows(pointshows);
                if (result)
                {
                    return Ok($"批量添加成功，共{pointshows.Count}条记录！");
                }
                else
                {
                    return BadRequest("批量添加失败！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 删除Pointshow记录
        /// </summary>
        /// <param name="id">记录ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> DeletePointshow(int id)
        {
            try
            {
                var result = ExcuteEngine.DeletePointshow(id);
                if (result)
                {
                    return Ok("删除成功！");
                }
                else
                {
                    return BadRequest("删除失败，记录不存在！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 更新Pointshow记录（简化版 - 通过参数传递）
        /// </summary>
        /// <param name="id">记录ID</param>
        /// <param name="pointname">新的点名</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> UpdatePointshowSimple(int id, string pointname)
        {
            try
            {
                var pointshow = new Pointshow { Id = id, pointname = pointname };
                var result = ExcuteEngine.UpdatePointshow(pointshow);
                if (result)
                {
                    return Ok("更新成功！");
                }
                else
                {
                    return BadRequest("更新失败，记录不存在！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 更新Pointshow记录（完整版 - 传入完整对象）
        /// </summary>
        /// <param name="pointshow">Pointshow对象</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdatePointshow([FromBody] Pointshow pointshow)
        {
            try
            {
                var result = ExcuteEngine.UpdatePointshow(pointshow);
                if (result)
                {
                    return Ok("更新成功！");
                }
                else
                {
                    return BadRequest("更新失败，记录不存在！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 批量更新Pointshow记录
        /// </summary>
        /// <param name="pointshows">Pointshow列表</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> UpdatePointshows([FromBody] List<Pointshow> pointshows)
        {
            try
            {
                var result = ExcuteEngine.UpdatePointshows(pointshows);
                if (result)
                {
                    return Ok($"批量更新成功，共{pointshows.Count}条记录！");
                }
                else
                {
                    return BadRequest("批量更新失败！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 根据ID查询Pointshow记录
        /// </summary>
        /// <param name="id">记录ID</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPointshowById(int id)
        {
            try
            {
                var result = ExcuteEngine.GetPointshowById(id);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest("记录不存在！");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 查询所有Pointshow记录
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPointshows()
        {
            try
            {
                var result = ExcuteEngine.GetAllPointshows();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /// <summary>
        /// 根据pointname查询Pointshow记录
        /// </summary>
        /// <param name="pointname">点名</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetPointshowsByPointname(string pointname)
        {
            try
            {
                var result = ExcuteEngine.GetPointshowsByPointname(pointname);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }

    /// <summary>
    /// 日志类型枚举
    /// </summary>
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
    public enum LogType
    {
        /// <summary>
        /// 正常日志
        /// </summary>
        Info = 0,

        /// <summary>
        /// 错误日志
        /// </summary>
        Error = 1
    }

    public class ApiResponse<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public T data { get; set; }

        public ApiResponse(int code, string msg, T data)
        {
            this.code = code;
            this.msg = msg;
            this.data = data;
        }
    }
}
