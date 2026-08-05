
using DBServer.LogServer;
using DCSCommon;
using DCSType;
using EngineCore;
using EngineCore.Models;
using Newtonsoft.Json;

using System.Reflection;
using System.Text.RegularExpressions;
using static TDServer.Service.AlarmHelp;
using static TDServer.Service.ExcuteEngine;
using static TDServer.Service.HealthHelp;

namespace TDServer.Service
{
    public class Controller
    {
        #region 属性和字段

        public int ID;
        public List<CldFcblock> CldFcblockList;
        public Dictionary<string, Function> FunctionInstanceDict;
        public Dictionary<string, List<string>> AckDict;
        public Dictionary<string, FaultInfo> FaultInfoList;
        public Dictionary<string, LA> HealthScoreDict;
        public Dictionary<string, AlarmWarnInfo> AlarmWarnInfoDict;
        public Dictionary<string, Dictionary<string, List<string>>> UsedPointsByFc;
        public Dictionary<string, Dictionary<string, object>> secondCalcPinValueList;
        public List<DSystem> dSystemList;
        Dictionary<string, List<CalculatedLA>> calculatedLAList;

        private readonly HttpClient client = new HttpClient();
        private string mysqlconn = string.Empty;
        private static readonly LoggerService<Controller> logger = new LoggerService<Controller>();

        //public Dictionary<string,List<string>> warnPointByAlgName = new Dictionary<string, List<string>>();

        #endregion

        #region 内部类

        public class FaultInfo
        {
            /// <summary>
            /// 故障时间
            /// </summary>
            public string Time { get; set; } = "";

            /// <summary>
            /// 故障状态
            /// </summary>
            public int Status { get; set; } = 0;

            /// <summary>
            /// 故障编码
            /// </summary>
            public int Code { get; set; } = -1;

            /// <summary>
            /// 故障描述
            /// </summary>
            public string Desc { get; set; } = "";

            /// <summary>
            /// 故障实例名称
            /// </summary>
            public string Source { get; set; } = "";

            /// <summary>
            /// 故障回写点名
            /// </summary>
            public string PointName { get; set; } = "";
        }

        public class AlarmWarnInfo
        {
            public string PointName { get; set; } = "";

            public string InstanceName { get; set; } = "";

            public int AlarmType { get; set; } = 1;

            public int LimitAlarmType { get; set; } = 20;
        }

        #endregion

        #region 构造函数

        public Controller(int controllerID, string conn)
        {
            InitializeFields(controllerID, conn);
            InitializeController();
        }

        private void InitializeFields(int controllerID, string conn)
        {
            client.Timeout = new TimeSpan(0, 0, 0, 5);
            AckDict = new Dictionary<string, List<string>>();
            UsedPointsByFc = new Dictionary<string, Dictionary<string, List<string>>>();
            HealthScoreDict = new Dictionary<string, LA>();
            AlarmWarnInfoDict = new Dictionary<string, AlarmWarnInfo>(StringComparer.OrdinalIgnoreCase);
            FaultInfoList = new Dictionary<string, FaultInfo>();
            CldFcblockList = new List<CldFcblock>();
            FunctionInstanceDict = new Dictionary<string, Function>(StringComparer.OrdinalIgnoreCase);
            secondCalcPinValueList = new Dictionary<string, Dictionary<string, object>>();
            dSystemList = new List<DSystem>();
            calculatedLAList = new Dictionary<string, List<CalculatedLA>>();
            ID = controllerID;
            // 需要在构造函数中初始化，避免编译器警告
            mysqlconn = conn;
        }

        private void InitializeController()
        {
            if (ID == HealthControllerID)
            {
                dSystemList = dSystems;
                InstanceHealthFunctionBlock();
            }
            else if (ID == AlarmControllerID)
            {
                InstanceAlarmFunctionBlock();
            }
            else
            {
                InstanceFunctionBlock();
            }
        }

        #endregion

        #region 主要运行方法

        public void Run()
        {
            try
            {
                if (ID == HealthControllerID)
                {
                    // 执行健康功能实例
                    foreach (var healthFunctionInstance in FunctionInstanceDict)
                    {
                        healthFunctionInstance.Value.Implement(null);
                    }

                    // 计算系统健康度得分
                    for (int i = 0; i < dSystemList.Count; i++)
                    {
                        DSystem dSystem = dSystemList[i];
                        CalculateDeviceHealthScores(dSystem);
                        CalculateSystemScore(dSystem);
                    }
                    //InsertHealthData();
                }
                else
                {
                    // 在执行功能块之前，先更新所有计算LA的值
                    UpdateAllCalculatedLAValues();

                    // 执行功能块实例
                    foreach (var functionBlockInstance in FunctionInstanceDict)
                    {
                        if (functionBlockInstance.Key.Contains("ANN390"))
                        {

                        }
                        string algName = functionBlockInstance.Key;
                        ExecuteSingleFunctionBlock(functionBlockInstance, algName);
                    }
                    // 处理数据插入
                    //InsertWarnData();
                    InsertFaultData();
                    InsertAlarmWarnData();

                    //InfluxDBHelp.BatchInsert(secondCalcPinValueList);

                    //UpdateSecondCalcCacheValues();
                    Task.Run(() =>
                    {
                        List<WarnRValue> warnRValues = warnRValueDict.Values.SelectMany(list => list).ToList();
                        InfluxDBHelp.BatchInsert(warnRValues);
                    });

                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog("Controller.Run" + ex.Message);
            }
        }

        /// <summary>
        /// 更新所有计算LA对象的值
        /// </summary>
        private void UpdateAllCalculatedLAValues()
        {
            foreach (var algItem in calculatedLAList)
            {
                foreach (var calculatedLA in algItem.Value)
                {
                    calculatedLA.UpdateCalculatedValue();
                }
            }
        }

        /// <summary>
        /// 计算设备健康度分数
        /// </summary>
        private void CalculateDeviceHealthScores(DSystem dSystem)
        {
            if (dSystem.Devices.Count <= 0) return;

            foreach (var dDevice in dSystem.Devices)
            {
                var healthIndicatorList = dDevice.HealthIndicators;
                if (healthIndicatorList.Count > 0)
                {
                    double sumIndicatorWeight = healthIndicatorList.Sum(x => x.weight);
                    float deviceScore = (float)healthIndicatorList.Sum(dHealthIndicator =>
                        (dHealthIndicator.Score.buffer * dHealthIndicator.weight) / sumIndicatorWeight);
                    dDevice.Score = deviceScore;
                }
            }
        }

        /// <summary>
        /// 计算系统分数
        /// </summary>
        private void CalculateSystemScore(DSystem dSystem)
        {
            var devices = dSystem.Devices.Where(x => x.Score != -1);

            if (!devices.Any())
            {
                dSystem.Score = -1;
                return;
            }

            double sumDeviceWeight = devices.Sum(x => x.weight);
            float systemScore = (float)devices.Sum(dDevice =>
                (dDevice.Score * dDevice.weight) / sumDeviceWeight);
            dSystem.Score = systemScore;
        }

        /// <summary>
        /// 执行单个功能块
        /// </summary>
        private void ExecuteSingleFunctionBlock(KeyValuePair<string, Function> functionBlockInstance, string algName)
        {
            try
            {
                functionBlockInstance.Value.Implement(null);

                if (functionBlockInstance.Value.FcType == Function.enumType.ICO)
                {
                    optimizingFunction = (OptimizingFunction)functionBlockInstance.Value;
                }

                ProcessWarnPointsForFunction(functionBlockInstance, algName);
            }
            catch (Exception ex)
            {
                // 处理异常但不抛出，保证其他功能块继续执行
            }
        }

        /// <summary>
        /// 处理功能块的预警点
        /// </summary>
        private void ProcessWarnPointsForFunction(KeyValuePair<string, Function> functionBlockInstance, string algName)
        {
            if (!modelWarnPoint.ContainsKey(algName)) return;

            if (functionBlockInstance.Value.Runable)
            {
                ProcessRunnableWarnPoints(functionBlockInstance, algName);
            }
            else
            {
                ProcessStoppedWarnPoints(algName);
            }
        }

        /// <summary>
        /// 处理可运行的预警点
        /// </summary>
        private void ProcessRunnableWarnPoints(KeyValuePair<string, Function> functionBlockInstance, string algName)
        {
            //预警块的测点中只要有一个报警未确认，预警块的UnAck就等于true
            bool unack = false;
            foreach (var item in modelWarnPoint[algName])
            {
                object syspoint = GetFirstRunableWarn(item.PointName);
                if (syspoint != null)
                {
                    LAExWarn lAExWarn = (LAExWarn)syspoint;
                    //lAExWarn.Run();
                    unack |= lAExWarn.UnAck;
                }
            }

            ((WarnFunction)functionBlockInstance.Value).UnAck = unack;
        }

        /// <summary>
        /// 处理停止的预警点
        /// </summary>
        private void ProcessStoppedWarnPoints(string algName)
        {
            //当预警块停止运算，对应的测点也停止运算
            foreach (var item in modelWarnPoint[algName])
            {
                object syspoint = GetFirstRunableWarn(item.PointName);
                if (syspoint != null)
                {
                    ((LAExWarn)syspoint).Runable = false;
                }
            }
        }

        #endregion


        //public void UpdateSecondCalcCacheValues()
        //{
        //    Task.Run(() =>
        //    {
        //        try
        //        {
        //            var itemsList = new List<object>();
        //            foreach (var item in secondCalcPinValueList)
        //            {
        //                foreach (var field in item.Value)
        //                {
        //                    itemsList.Add(new
        //                    {
        //                        pointName = item.Key,
        //                        field = field.Key,
        //                        value = ((LA)field.Value).buffer.ToString()
        //                    });
        //                }
        //            }

        //            string jsonArray = JsonConvert.SerializeObject(itemsList);
        //            using (HttpClient httpClient = new HttpClient())
        //            {
        //                var content = new StringContent(jsonArray, Encoding.UTF8, "application/json");
        //                var response = httpClient.PostAsync(configInfo.UpdatePCalcValuesapiurl, content).Result;
        //                if (!response.IsSuccessStatusCode)
        //                {
        //                    logger.ErrorLog("Controller.UpdateSecondCalcCacheValues" + response.ReasonPhrase + "-" + response.RequestMessage.ToString());
        //                }
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            logger.ErrorLog("Controller.UpdateSecondCalcCacheValues" + ex.Message);
        //        }
        //    });
        //}


        //public Dictionary<string, string> GetSecondCalcPointValues(string[] pointNames)
        //{
        //    Dictionary<string, string> dict = new Dictionary<string, string>();
        //    for (int i = 0; i < pointNames.Length; i++)
        //    {
        //        string pn = pointNames[i];
        //        foreach (var blockOutputList in secondCalcPinValueList)
        //        {
        //            foreach (var pin in blockOutputList.Value)
        //            {
        //                if (pn == blockOutputList.Key + "." + pin.Key)
        //                {
        //                    if (pin.Value is LA)
        //                    {
        //                        LA lA = (LA)pin.Value;
        //                        dict.Add(pn, lA.buffer.ToString());
        //                    }
        //                    else if (pin.Value is LD)
        //                    {
        //                        LD lD = (LD)pin.Value;
        //                        dict.Add(pn, lD.buffer.ToString());
        //                    }
        //                }
        //                else
        //                {
        //                    logger.ErrorLog($"外部请求点{pn}不存在！");
        //                }
        //            }
        //        }
        //    }
        //    return new Dictionary<string, string>();
        //}



        #region 辅助方法 - 功能块对比

        /// <summary>
        /// 对比两个功能块是否有变化（只对比输入PointName、输出PointName、规格数值）
        /// </summary>
        /// <param name="oldBlock">旧功能块</param>
        /// <param name="newBlock">新功能块</param>
        /// <returns>true=有变化，需要重新初始化；false=无变化，保持不变</returns>
        private bool HasFunctionBlockChanged(CldFcblock oldBlock, CldFcblock newBlock)
        {
            try
            {
                // 1. 对比输入管脚的 PointName
                if (!CompareInputPins(oldBlock.CldFcinputs, newBlock.CldFcinputs))
                {
                    logger.InfoLog($"功能块 {oldBlock.AlgName} 的输入管脚有变化");
                    return true;
                }

                // 2. 对比输出管脚的 PointName
                if (!CompareOutputPins(oldBlock.CldFcoutputs, newBlock.CldFcoutputs))
                {
                    logger.InfoLog($"功能块 {oldBlock.AlgName} 的输出管脚有变化");
                    return true;
                }

                // 3. 对比规格数的值
                if (!CompareParameters(oldBlock.CldFcparameters, newBlock.CldFcparameters))
                {
                    logger.InfoLog($"功能块 {oldBlock.AlgName} 的规格数有变化");
                    return true;
                }

                // 所有检查都通过，没有变化
                return false;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"对比功能块 {oldBlock.AlgName} 时出错: {ex.Message}");
                // 出错时默认认为有变化，需要重新初始化
                return true;
            }
        }

        /// <summary>
        /// 对比输入管脚列表
        /// </summary>
        private bool CompareInputPins(List<CldFcinput> oldInputs, List<CldFcinput> newInputs)
        {
            // 处理空值情况
            if (oldInputs == null && newInputs == null) return true;
            if (oldInputs == null || newInputs == null) return false;

            // 数量不同
            if (oldInputs.Count != newInputs.Count) return false;

            // 按 PinName 排序后逐个对比
            var oldSorted = oldInputs.OrderBy(x => x.PinName).ToList();
            var newSorted = newInputs.OrderBy(x => x.PinName).ToList();

            for (int i = 0; i < oldSorted.Count; i++)
            {
                // 对比 PinName 和 PointName
                if (oldSorted[i].PinName != newSorted[i].PinName ||
                    oldSorted[i].PointName != newSorted[i].PointName)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 对比输出管脚列表
        /// </summary>
        private bool CompareOutputPins(List<CldFcoutput> oldOutputs, List<CldFcoutput> newOutputs)
        {
            // 处理空值情况
            if (oldOutputs == null && newOutputs == null) return true;
            if (oldOutputs == null || newOutputs == null) return false;

            // 数量不同
            if (oldOutputs.Count != newOutputs.Count) return false;

            // 按 PinName 排序后逐个对比
            var oldSorted = oldOutputs.OrderBy(x => x.PinName).ToList();
            var newSorted = newOutputs.OrderBy(x => x.PinName).ToList();

            for (int i = 0; i < oldSorted.Count; i++)
            {
                // 对比 PinName 和 PointName
                if (oldSorted[i].PinName != newSorted[i].PinName ||
                    oldSorted[i].PointName != newSorted[i].PointName)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 对比规格数列表
        /// </summary>
        private bool CompareParameters(List<CldFcparameter> oldParams, List<CldFcparameter> newParams)
        {
            // 处理空值情况
            if (oldParams == null && newParams == null) return true;
            if (oldParams == null || newParams == null) return false;

            // 数量不同
            if (oldParams.Count != newParams.Count) return false;

            // 按 Name 排序后逐个对比
            var oldSorted = oldParams.OrderBy(x => x.Name).ToList();
            var newSorted = newParams.OrderBy(x => x.Name).ToList();

            for (int i = 0; i < oldSorted.Count; i++)
            {
                // 对比 Name 和 Pvalue
                if (oldSorted[i].Name != newSorted[i].Name ||
                    oldSorted[i].Pvalue != newSorted[i].Pvalue)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// 获取变化的输入管脚列表
        /// </summary>
        /// <returns>返回(PinName, 旧PointName, 新PointName)的列表</returns>
        private List<InputPinChange> GetChangedInputPins(
            List<CldFcinput> oldInputs, List<CldFcinput> newInputs)
        {

            //var changedPins = new List<(string PinName, string OldPointName, string NewPointName)>();

            var changedPins = new List<InputPinChange>();
            if (oldInputs == null || newInputs == null) return changedPins;

            // 建立PinName索引，同时保存完整的CldFcinput对象
            var oldDict = oldInputs.ToDictionary(x => x.PinName, x => x);
            var newDict = newInputs.ToDictionary(x => x.PinName, x => x);

            // 查找所有PinName
            var allPinNames = oldDict.Keys.Union(newDict.Keys).ToList();

            foreach (var pinName in allPinNames)
            {
                var oldInput = oldDict.ContainsKey(pinName) ? oldDict[pinName] : null;
                var newInput = newDict.ContainsKey(pinName) ? newDict[pinName] : null;

                string oldPointName = oldInput?.PointName ?? "";
                string newPointName = newInput?.PointName ?? "";
                string oldInitialValue = oldInput?.InitialValue ?? "";
                string newInitialValue = newInput?.InitialValue ?? "";

                var change = new InputPinChange
                {
                    PinName = pinName,
                    OldPointName = oldPointName,
                    NewPointName = newPointName,
                    OldInitialValue = oldInput?.InitialValue ?? "",
                    NewInitialValue = newInput?.InitialValue ?? ""
                };

                if (change.HasAnyChange)
                {
                    changedPins.Add(change);
                }
            }

            return changedPins;
        }

        /// <summary>
        /// 获取变化的输出管脚列表
        /// </summary>
        /// <returns>返回(PinName, 旧PointName, 新PointName)的列表</returns>
        private List<(string PinName, string OldPointName, string NewPointName)> GetChangedOutputPins(
            List<CldFcoutput> oldOutputs, List<CldFcoutput> newOutputs)
        {
            var changedPins = new List<(string PinName, string OldPointName, string NewPointName)>();

            if (oldOutputs == null || newOutputs == null) return changedPins;

            // 建立PinName索引
            var oldDict = oldOutputs.ToDictionary(x => x.PinName, x => x.PointName ?? "");
            var newDict = newOutputs.ToDictionary(x => x.PinName, x => x.PointName ?? "");

            // 查找所有PinName
            var allPinNames = oldDict.Keys.Union(newDict.Keys).ToList();

            foreach (var pinName in allPinNames)
            {
                string oldPointName = oldDict.ContainsKey(pinName) ? oldDict[pinName] : "";
                string newPointName = newDict.ContainsKey(pinName) ? newDict[pinName] : "";

                if (oldPointName != newPointName)
                {
                    changedPins.Add((pinName, oldPointName, newPointName));
                }
            }

            return changedPins;
        }

        /// <summary>
        /// 获取变化的规格数列表
        /// </summary>
        /// <returns>返回(Name, 旧Pvalue, 新Pvalue)的列表</returns>
        private List<(string Name, string OldPvalue, string NewPvalue)> GetChangedParameters(
            List<CldFcparameter> oldParams, List<CldFcparameter> newParams)
        {
            var changedParams = new List<(string Name, string OldPvalue, string NewPvalue)>();

            if (oldParams == null || newParams == null) return changedParams;

            // 建立Name索引
            var oldDict = oldParams.ToDictionary(x => x.Name, x => x.Pvalue ?? "");
            var newDict = newParams.ToDictionary(x => x.Name, x => x.Pvalue ?? "");

            // 查找所有Name
            var allNames = oldDict.Keys.Union(newDict.Keys).ToList();

            foreach (var name in allNames)
            {
                string oldPvalue = oldDict.ContainsKey(name) ? oldDict[name] : "";
                string newPvalue = newDict.ContainsKey(name) ? newDict[name] : "";

                if (oldPvalue != newPvalue)
                {
                    changedParams.Add((name, oldPvalue, newPvalue));
                }
            }

            return changedParams;
        }

        /// <summary>
        /// 更新单个输入管脚的PointName连接
        /// </summary>
        private void UpdateSingleInputPin(string algName, string pinName, string newPointName, string newInitialValue = null)
        {
            try
            {
                if (!FunctionInstanceDict.ContainsKey(algName))
                {
                    logger.ErrorLog($"更新输入管脚失败: 功能块 {algName} 不存在");
                    return;
                }

                Function functionInstance = FunctionInstanceDict[algName];
                FieldInfo fieldInfo = functionInstance.GetType().GetField(pinName);

                if (fieldInfo == null)
                {
                    logger.ErrorLog($"更新输入管脚失败: 管脚 {algName}.{pinName} 不存在");
                    return;
                }

                // 清理旧连接
                object oldValue = fieldInfo.GetValue(functionInstance);
                if (oldValue != null)
                {
                    SetPointDisconnected(oldValue);
                }

                // 如果新PointName为空，使用InitialValue设置默认值
                if (string.IsNullOrEmpty(newPointName))
                {
                    if (!string.IsNullOrEmpty(newInitialValue))
                    {
                        // 创建临时CldFcinput对象
                        var inputTmp = new CldFcinput
                        {
                            PinName = pinName,
                            InitialValue = newInitialValue
                        };

                        var cldFcblockTmp = CldFcblockList.FirstOrDefault(x => x.AlgName == algName);
                        if (cldFcblockTmp != null)
                        {
                            SetDefaultInputValue(cldFcblockTmp, inputTmp, fieldInfo, functionInstance);
                            logger.InfoLog($"已更新输入管脚的InitialValue: {algName}.{pinName} = {newInitialValue}");
                        }
                    }
                    else
                    {
                        // 设置为类型默认值
                        string fcName = functionInstance.GetType().Name;
                        Function function = ExcuteEngine.fcTypeDict[fcName];
                        FieldInfo defaultfieldInfo = function.GetType().GetField(pinName);
                        object defaultValue = defaultfieldInfo.GetValue(function);
                        fieldInfo.SetValue(functionInstance, defaultValue);
                        logger.InfoLog($"输入管脚 {algName}.{pinName} 的PointName为空，设置为默认值");
                    }
                    return;
                }

                // 处理新连接（PointName不为空的情况）
                var cldFcblock = CldFcblockList.FirstOrDefault(x => x.AlgName == algName);
                if (cldFcblock == null)
                {
                    logger.ErrorLog($"更新输入管脚失败: CldFcblock {algName} 不存在");
                    return;
                }

                var tempInput = new CldFcinput
                {
                    PinName = pinName,
                    PointName = newPointName
                };

                ProcessSingleInputPin(cldFcblock, functionInstance, tempInput);
                logger.InfoLog($"已更新输入管脚: {algName}.{pinName} -> {newPointName}");
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"更新输入管脚 {algName}.{pinName} 时出错: {ex.Message}");
            }
        }



        /// <summary>
        /// 更新单个输出管脚的PointName连接
        /// </summary>
        private void UpdateSingleOutputPin(string algName, string pinName, string newPointName)
        {
            try
            {
                if (!FunctionInstanceDict.ContainsKey(algName))
                {
                    logger.ErrorLog($"更新输出管脚失败: 功能块 {algName} 不存在");
                    return;
                }

                Function functionInstance = FunctionInstanceDict[algName];

                // 清理旧的回写点记录
                if (WriteBackDcsPointDict.ContainsKey(algName))
                {
                    var oldOutputDict = WriteBackDcsPointDict[algName];
                    // 找到并移除该管脚对应的旧PointName
                    var keysToRemove = oldOutputDict.Keys.ToList();
                    foreach (var key in keysToRemove)
                    {
                        WriteBackDcsPointDict[algName].Remove(key);
                    }
                }

                // 如果新PointName为空，直接返回
                if (string.IsNullOrEmpty(newPointName))
                {
                    logger.InfoLog($"输出管脚 {algName}.{pinName} 的PointName为空，已清理旧连接");
                    return;
                }

                // 检查新PointName是否存在
                if (!RTDDict.ContainsKey(newPointName))
                {
                    logger.ErrorLog($"更新输出管脚失败: 点名 {newPointName} 不存在");
                    return;
                }

                // 创建临时CldFcoutput对象
                var tempOutput = new CldFcoutput
                {
                    PinName = pinName,
                    PointName = newPointName
                };

                // 复用现有的输出管脚处理逻辑
                ProcessWriteBackDcsPoint(algName, tempOutput, functionInstance);

                logger.InfoLog($"已更新输出管脚: {algName}.{pinName} -> {newPointName}");
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"更新输出管脚 {algName}.{pinName} 时出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 更新单个规格数的值
        /// </summary>
        private void UpdateSingleParameter(string algName, string paramName, string newPvalue)
        {
            try
            {
                if (!FunctionInstanceDict.ContainsKey(algName))
                {
                    logger.ErrorLog($"更新规格数失败: 功能块 {algName} 不存在");
                    return;
                }

                Function functionInstance = FunctionInstanceDict[algName];
                FieldInfo fieldInfo = functionInstance.GetType().GetField(paramName);

                if (fieldInfo == null)
                {
                    logger.ErrorLog($"更新规格数失败: 字段 {algName}.{paramName} 不存在");
                    return;
                }

                if (string.IsNullOrEmpty(newPvalue))
                {
                    logger.InfoLog($"规格数 {algName}.{paramName} 的值为空，跳过更新");
                    return;
                }

                // 根据字段类型设置新值
                switch (fieldInfo.FieldType.Name)
                {
                    case "Int32":
                        if (int.TryParse(newPvalue, out int intValue))
                        {
                            fieldInfo.SetValue(functionInstance, intValue);
                            logger.InfoLog($"已更新规格数(Int32): {algName}.{paramName} = {newPvalue}");
                        }
                        else
                        {
                            logger.ErrorLog($"规格数值格式错误(Int32): {algName}.{paramName} = {newPvalue}");
                        }
                        break;

                    case "Single":
                        if (float.TryParse(newPvalue, out float floatValue))
                        {
                            fieldInfo.SetValue(functionInstance, floatValue);
                            logger.InfoLog($"已更新规格数(Single): {algName}.{paramName} = {newPvalue}");
                        }
                        else
                        {
                            logger.ErrorLog($"规格数值格式错误(Single): {algName}.{paramName} = {newPvalue}");
                        }
                        break;

                    case "String":
                        fieldInfo.SetValue(functionInstance, newPvalue);
                        logger.InfoLog($"已更新规格数(String): {algName}.{paramName} = {newPvalue}");
                        break;

                    default:
                        logger.ErrorLog($"不支持的规格数类型: {fieldInfo.FieldType.Name}");
                        break;
                }

                // 特殊处理FaultOut类型的FaultCode
                if (functionInstance.FcType == Function.enumType.FaultOut && paramName == "FaultCode")
                {
                    if (FaultInfoList.ContainsKey(algName))
                    {
                        FaultInfoList[algName].Code = Convert.ToInt32(newPvalue);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"更新规格数 {algName}.{paramName} 时出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 设置点的Connected属性为false（断开连接）
        /// </summary>
        private void SetPointDisconnected(object pointDetail)
        {
            switch (pointDetail)
            {
                case LA la:
                    la.Connected = false;
                    break;
                case LD ld:
                    ld.Connected = false;
                    break;
                case LP32 lp32:
                    lp32.Connected = false;
                    break;
            }
        }

        #endregion


        #region 功能块实例化相关方法

        public void InstanceFunctionBlock()
        {
            try
            {
                //加载功能块实例数据
                using (WarnContext warnContext = new WarnContext(mysqlconn))
                {
                    // 预加载相关数据以提高性能
                    var cldFcblockList = warnContext.CldFcblocks.ToList();
                    var cldFcinputList = warnContext.CldFcinputs.ToList();
                    var cldFcoutputList = warnContext.CldFcoutputs.ToList();
                    var cldFcparameterList = warnContext.CldFcparameters.ToList();

                    CldFcblockList = warnContext.CldFcblocks
                        .Where(x => x.PrjControllerId == ID)
                        .ToList();
                }

                AckDict.Clear();
                secondCalcPinValueList = new Dictionary<string, Dictionary<string, object>>();

                //创建功能实例
                for (int i = CldFcblockList.Count - 1; i >= 0; i--)
                {
                    if (CldFcblockList[i].FunctionName.Contains("ANN390"))
                    {

                    }
                    if (!CreateSingleFunctionInstance(CldFcblockList[i]))
                    {
                        string fcName = CldFcblockList[i].FunctionName;
                        CldFcblockList.RemoveAt(i);
                    }
                }

                InitializeBlocks(CldFcblockList);

                logger.InfoLog("其他算法块初始化完成！");

                logger.InfoLog($"WriteBackDcsPointDict：{JsonConvert.SerializeObject(ExcuteEngine.WriteBackDcsPointDict)}");
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message);
            }
        }

        /// <summary>
        /// 创建单个功能实例
        /// </summary>
        /// <returns>创建成功返回true，失败返回false</returns>
        private bool CreateSingleFunctionInstance(CldFcblock cldFcblock)
        {
            string fcName = cldFcblock.FunctionName;
            if (!fcTypeDict.ContainsKey(fcName))
            {
                logger.InfoLog($"功能块类型未注册，将移除: FunctionName={fcName}, AlgName={cldFcblock.AlgName}");
                return false;
            }

            string algName = cldFcblock.AlgName;
            Function functionInstance = CreateFcInstance(cldFcblock.FunctionName);
            if (functionInstance == null)
            {
                logger.InfoLog($"功能实例创建失败，将移除: FunctionName={fcName}, AlgName={algName}");
                return false;
            }

            functionInstance.InstanceName = algName;
            functionInstance.SheetId = cldFcblock.PrjSheetId;

            if (functionInstance.FcType == Function.enumType.Warn)
            {
                functionInstance.Runable = cldFcblock.InstantStatus == 1;
            }

            FunctionInstanceDict.Add(algName, functionInstance);
            return true;
        }


        #endregion

        #region 健康功能块实例化相关方法

        public void InstanceHealthFunctionBlock()
        {
            foreach (var dSystem in dSystemList)
            {
                if (dSystem.Devices.Count > 0)
                {
                    int systemID = dSystem.ID;
                    foreach (var dDevice in dSystem.Devices)
                    {
                        if (dDevice.HealthIndicators.Count > 0)
                        {
                            ProcessDeviceHealthIndicators(dDevice, systemID);
                        }
                    }
                }
            }
            logger.InfoLog("健康度算法块初始化完成！");

        }

        /// <summary>
        /// 处理设备健康指标
        /// </summary>
        private void ProcessDeviceHealthIndicators(DDevice dDevice, int systemID)
        {
            foreach (var dHealthIndicator in dDevice.HealthIndicators)
            {
                try
                {
                    int deviceID = dHealthIndicator.DeviceID;
                    int indicatorID = dHealthIndicator.IndicatorID;

                    // 解析聚合模式
                    if (!ParseAggregationPattern(dHealthIndicator, out int selNum))
                    {
                        return;
                    }


                    // 根据健康指标类型创建相应的健康功能
                    CreateHealthFunction(dHealthIndicator, systemID, deviceID, indicatorID, selNum);
                }
                catch (Exception ex)
                {
                    logger.ErrorLog($"处理健康指标{dHealthIndicator.IndicatorID}时出错: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// 解析聚合模式
        /// </summary>
        private bool ParseAggregationPattern(DHealthIndicator dHealthIndicator, out int selNum)
        {
            int inputNum = 0;
            selNum = 0;

            string[] arr = dHealthIndicator.AggregationPattren.Split("取");

            if (!int.TryParse(arr[0], out inputNum))
            {
                logger.ErrorLog($"健康度聚合模式：【{dHealthIndicator.AggregationPattren}】格式不正确。");
                return false;
            }

            if (!int.TryParse(arr[1], out selNum))
            {
                logger.ErrorLog($"健康度聚合模式：【{dHealthIndicator.AggregationPattren}】格式不正确。");
                return false;
            }

            if (inputNum != dHealthIndicator.UsePoint.Count)
            {
                logger.ErrorLog($"健康度聚合模式：【{dHealthIndicator.AggregationPattren}】与使用点名的个数不对呀。");
                return false;
            }

            return true;
        }

        /// <summary>
        /// 获取使能点
        /// </summary>
        private LD GetEnablePoint(DHealthIndicator dHealthIndicator, int indicatorID)
        {
            string strEnablePoint = dHealthIndicator.EnablePoint;
            if (string.IsNullOrEmpty(strEnablePoint))
            {
                return null;
            }

            if (!RTDDict.ContainsKey(strEnablePoint))
            {
                logger.ErrorLog($"健康度指标编号：【{indicatorID}】的使用点名【{strEnablePoint}】不存在。");
                return null;
            }

            AddCommPoints(new List<string> { strEnablePoint });
            object pointDetails = RTDDict[strEnablePoint];

            if (pointDetails is LD enablePointObj)
            {
                return enablePointObj;
            }
            else
            {
                logger.ErrorLog($"健康度指标编号：【{indicatorID}】的使用点名【{strEnablePoint}】类型错误。");
                return null;
            }
        }

        /// <summary>
        /// 解析设备运行条件
        /// </summary>
        private MatchCollection ParseDeviceRunCondition(DHealthIndicator dHealthIndicator)
        {
            if (string.IsNullOrEmpty(dHealthIndicator.DeviceRunCondition))
            {
                return null;
            }

            string alarmcondition = dHealthIndicator.DeviceRunCondition.Replace("\\n", "").Replace("\t", "");
            if (string.IsNullOrEmpty(alarmcondition))
            {
                return null;
            }

            Regex r = new Regex(@"(?<=\[)(.+?)(?=\])");
            return r.Matches(alarmcondition);
        }

        /// <summary>
        /// 创建健康功能
        /// </summary>
        private void CreateHealthFunction(DHealthIndicator dHealthIndicator, int systemID, int deviceID, int indicatorID, int selNum)
        {

            // 解析设备运行条件
            MatchCollection matchCollection = ParseDeviceRunCondition(dHealthIndicator);
            // 获取使能点
            LD enablePointObj = GetEnablePoint(dHealthIndicator, indicatorID);

            bool isSingleValue = dHealthIndicator.NormalValue1 != null && dHealthIndicator.AlarmValue1 != null &&
                               dHealthIndicator.TripValue1 != null && dHealthIndicator.NormalValue2 == null &&
                               dHealthIndicator.AlarmValue2 == null && dHealthIndicator.TripValue2 == null;

            bool isIntervalValue = dHealthIndicator.NormalValue1 != null && dHealthIndicator.AlarmValue1 != null &&
                                 dHealthIndicator.TripValue1 != null && dHealthIndicator.NormalValue2 != null &&
                                 dHealthIndicator.AlarmValue2 != null && dHealthIndicator.TripValue2 != null;

            if (isSingleValue)
            {
                if (dHealthIndicator.UsePoint.Count == 1)
                {
                    CreateNormalHealthFunction(dHealthIndicator, systemID, deviceID, indicatorID, enablePointObj, matchCollection);
                }
                else
                {
                    CreateMultiSelectHealthFunction(dHealthIndicator, systemID, deviceID, indicatorID, selNum, enablePointObj, matchCollection);
                }
            }
            else if (isIntervalValue)
            {
                CreateIntervalHealthFunction(dHealthIndicator, systemID, deviceID, indicatorID, selNum, enablePointObj, matchCollection);
            }
        }

        /// <summary>
        /// 创建普通健康度功能
        /// </summary>
        private void CreateNormalHealthFunction(DHealthIndicator dHealthIndicator, int systemID, int deviceID, int indicatorID,
            LD enablePointObj, MatchCollection matchCollection)
        {
            if (!fcTypeDict.ContainsKey("Health"))
            {
                return;
            }

            HealthFunction health = (HealthFunction)CreateFcInstance("Health");
            string pn = dHealthIndicator.UsePoint[0];
            SetHealthPointToInputPin(health, "IN", pn, indicatorID);

            SetHealthFunctionCommonProperties(health, enablePointObj, matchCollection, dHealthIndicator, systemID, deviceID);

            string algName = $"health{dHealthIndicator.IndicatorID}";
            health.InstanceName = algName;
            FunctionInstanceDict.Add(algName, health);

            SetHealthIndicatorOutput(dHealthIndicator, health, algName);
        }

        /// <summary>
        /// 创建多选健康度功能
        /// </summary>
        private void CreateMultiSelectHealthFunction(DHealthIndicator dHealthIndicator, int systemID, int deviceID, int indicatorID,
            int selNum, LD enablePointObj, MatchCollection matchCollection)
        {
            if (!fcTypeDict.ContainsKey("Health16SEL"))
            {
                return;
            }

            HealthFunction health16SEL = (HealthFunction)CreateFcInstance("Health16SEL");

            for (int m = 0; m < dHealthIndicator.UsePoint.Count; m++)
            {
                string pn = dHealthIndicator.UsePoint[m];
                SetHealthPointToInputPin(health16SEL, $"IN{m + 1}", pn, indicatorID);
            }

            SetHealthFunctionCommonProperties(health16SEL, enablePointObj, matchCollection, dHealthIndicator, systemID, deviceID);
            health16SEL.SelNum = selNum;

            string algName = $"health16sel{dHealthIndicator.IndicatorID}";
            health16SEL.InstanceName = algName;
            FunctionInstanceDict.Add(algName, health16SEL);

            SetHealthIndicatorOutput(dHealthIndicator, health16SEL, algName);
        }

        /// <summary>
        /// 创建区间健康度功能
        /// </summary>
        private void CreateIntervalHealthFunction(DHealthIndicator dHealthIndicator, int systemID, int deviceID, int indicatorID,
            int selNum, LD enablePointObj, MatchCollection matchCollection)
        {
            if (!fcTypeDict.ContainsKey("HealthInterval"))
            {
                return;
            }

            HealthFunction healthInterval = (HealthFunction)CreateFcInstance("HealthInterval");

            for (int m = 0; m < dHealthIndicator.UsePoint.Count; m++)
            {
                string pn = dHealthIndicator.UsePoint[m];
                SetHealthPointToInputPin(healthInterval, $"IN{m + 1}", pn, indicatorID);
            }

            SetHealthFunctionCommonProperties(healthInterval, enablePointObj, matchCollection, dHealthIndicator, systemID, deviceID);

            healthInterval.NormalValue2 = (float)dHealthIndicator.NormalValue2;
            healthInterval.AlarmValue2 = (float)dHealthIndicator.AlarmValue2;
            healthInterval.TripValue2 = (float)dHealthIndicator.TripValue2;
            healthInterval.SelNum = selNum;

            string algName = $"healthinterval{indicatorID}";
            healthInterval.InstanceName = algName;
            FunctionInstanceDict.Add(algName, healthInterval);

            SetHealthIndicatorOutput(dHealthIndicator, healthInterval, algName);
        }

        /// <summary>
        /// 设置健康功能通用属性
        /// </summary>
        private void SetHealthFunctionCommonProperties(HealthFunction healthFunction, LD enablePointObj,
            MatchCollection matchCollection, DHealthIndicator dHealthIndicator, int systemID, int deviceID)
        {
            if (enablePointObj != null)
            {
                FieldInfo health_EN = healthFunction.GetType().GetField("EN");
                health_EN?.SetValue(healthFunction, enablePointObj);
            }

            if (matchCollection != null && matchCollection.Count > 0)
            {
                for (int m = 0; m < matchCollection.Count; m++)
                {
                    SetHealthPointToInputPin(healthFunction, $"Condition{m + 1}", matchCollection[m].ToString(), dHealthIndicator.IndicatorID);
                }
            }

            healthFunction.Description = dHealthIndicator.IndicatorName;
            healthFunction.NormalValue1 = dHealthIndicator.NormalValue1;
            healthFunction.AlarmValue1 = dHealthIndicator.AlarmValue1;
            healthFunction.TripValue1 = dHealthIndicator.TripValue1;
            healthFunction.SystemID = systemID;
            healthFunction.DeviceID = deviceID;
            healthFunction.DeviceRunCondition = dHealthIndicator.DeviceRunCondition;
        }

        /// <summary>
        /// 设置健康指标输出
        /// </summary>
        private void SetHealthIndicatorOutput(DHealthIndicator dHealthIndicator, HealthFunction healthFunction, string algName)
        {
            FieldInfo health_OUT = healthFunction.GetType().GetField("OUT");
            if (health_OUT != null)
            {
                object OutValue = health_OUT.GetValue(healthFunction);
                dHealthIndicator.Score = (LA)OutValue;
                HealthScoreDict.Add(algName, (LA)OutValue);
            }

            dHealthIndicator.InstanceName = algName;
            dHealthIndicator.InstanceFc = healthFunction;
        }

        #endregion

        #region 报警功能块实例化相关方法

        public void InstanceAlarmFunctionBlock()
        {
            AlarmConfigData? config = alarmConfig;
            if (config == null || !config.HasData)
            {
                logger.InfoLog("报警控制器未找到有效配置，跳过初始化。");
                return;
            }

            int devCreatedCount = 0;
            int fluctuationCreatedCount = 0;
            HashSet<string> fluctuationPointNameSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            foreach (DevAlarmConfig devAlarmConfig in config.DevAlarmConfigs)
            {
                if (CreateDevAlarmFunction(devAlarmConfig))
                {
                    devCreatedCount++;
                }
            }

            foreach (AnalogFluctuationAlarmConfig fluctuationAlarmConfig in config.AnalogFluctuationAlarmConfigs)
            {
                if (!fluctuationPointNameSet.Add(fluctuationAlarmConfig.PointName))
                {
                    logger.ErrorLog($"波动报警点名重复，已跳过：{fluctuationAlarmConfig.PointName}，实例名：{fluctuationAlarmConfig.InstanceName}");
                    continue;
                }

                if (CreateAnalogFluctuationAlarmFunction(fluctuationAlarmConfig))
                {
                    fluctuationCreatedCount++;
                }
            }

            logger.InfoLog($"报警算法块初始化完成！偏差报警={devCreatedCount}，波动报警={fluctuationCreatedCount}");
        }

        private bool CreateDevAlarmFunction(DevAlarmConfig devAlarmConfig)
        {
            if (!fcTypeDict.ContainsKey("DevAlarm"))
            {
                logger.ErrorLog("未注册功能块类型：DevAlarm");
                return false;
            }

            if (FunctionInstanceDict.ContainsKey(devAlarmConfig.InstanceName))
            {
                logger.ErrorLog($"报警功能实例已存在：{devAlarmConfig.InstanceName}");
                return false;
            }

            Function? devAlarm = CreateFcInstance("DevAlarm");
            if (devAlarm == null)
            {
                logger.ErrorLog($"创建 DevAlarm 实例失败：{devAlarmConfig.InstanceName}");
                return false;
            }

            if (!BindAlarmPointToInputPin(devAlarm, "IN1", devAlarmConfig.In1PointName, devAlarmConfig.InstanceName) ||
                !BindAlarmPointToInputPin(devAlarm, "IN2", devAlarmConfig.In2PointName, devAlarmConfig.InstanceName))
            {
                return false;
            }

            devAlarm.InstanceName = devAlarmConfig.InstanceName;
            if (!SetAlarmFunctionFieldValue(devAlarm, "FaultCode", devAlarmConfig.FaultCode) ||
                !SetAlarmFunctionFieldValue(devAlarm, "AlarmThreshold", devAlarmConfig.AlarmThreshold) ||
                !SetAlarmFunctionFieldValue(devAlarm, "DelayTime", devAlarmConfig.DelayTime) ||
                !SetAlarmFunctionFieldValue(devAlarm, "Condition", devAlarmConfig.Condition))
            {
                return false;
            }

            FunctionInstanceDict.Add(devAlarmConfig.InstanceName, devAlarm);
            FaultInfoList[devAlarmConfig.InstanceName] = new FaultInfo
            {
                Code = devAlarmConfig.FaultCode,
                Desc = $"偏差报警:{devAlarmConfig.In1PointName}-{devAlarmConfig.In2PointName}",
                Source = devAlarmConfig.InstanceName
            };

            return true;
        }

        private bool CreateAnalogFluctuationAlarmFunction(AnalogFluctuationAlarmConfig fluctuationAlarmConfig)
        {
            if (!fcTypeDict.ContainsKey("AnalogFluctuationAlarm"))
            {
                logger.ErrorLog("未注册功能块类型：AnalogFluctuationAlarm");
                return false;
            }

            if (FunctionInstanceDict.ContainsKey(fluctuationAlarmConfig.InstanceName))
            {
                logger.ErrorLog($"报警功能实例已存在：{fluctuationAlarmConfig.InstanceName}");
                return false;
            }

            Function? analogFluctuationAlarm = CreateFcInstance("AnalogFluctuationAlarm");
            if (analogFluctuationAlarm == null)
            {
                logger.ErrorLog($"创建 AnalogFluctuationAlarm 实例失败：{fluctuationAlarmConfig.InstanceName}");
                return false;
            }

            if (!BindAlarmPointToInputPin(analogFluctuationAlarm, "IN", fluctuationAlarmConfig.PointName, fluctuationAlarmConfig.InstanceName))
            {
                return false;
            }

            analogFluctuationAlarm.InstanceName = fluctuationAlarmConfig.InstanceName;
            if (!SetAlarmFunctionFieldValue(analogFluctuationAlarm, "SampleTime", fluctuationAlarmConfig.SampleTime) ||
                !SetAlarmFunctionFieldValue(analogFluctuationAlarm, "AlarmThreshold", fluctuationAlarmConfig.AlarmThreshold) ||
                !SetAlarmFunctionFieldValue(analogFluctuationAlarm, "DelayTime", fluctuationAlarmConfig.DelayTime) ||
                !SetAlarmFunctionFieldValue(analogFluctuationAlarm, "Condition", fluctuationAlarmConfig.Condition))
            {
                return false;
            }

            FunctionInstanceDict.Add(fluctuationAlarmConfig.InstanceName, analogFluctuationAlarm);
            AlarmWarnInfoDict[fluctuationAlarmConfig.InstanceName] = new AlarmWarnInfo
            {
                PointName = fluctuationAlarmConfig.PointName,
                InstanceName = fluctuationAlarmConfig.InstanceName
            };

            return true;
        }

        private bool BindAlarmPointToInputPin(Function function, string inputPinName, string pointName, string instanceName)
        {
            if (!RTDDict.ContainsKey(pointName))
            {
                logger.ErrorLog($"报警实例【{instanceName}】使用点名【{pointName}】不存在。");
                return false;
            }

            object? sysPoint = GetFirstRunableWarn(pointName);
            if (sysPoint is not LA laPoint)
            {
                logger.ErrorLog($"报警实例【{instanceName}】使用点名【{pointName}】不是 LA 类型。");
                return false;
            }

            FieldInfo? inputField = function.GetType().GetField(inputPinName);
            if (inputField == null)
            {
                logger.ErrorLog($"报警实例【{instanceName}】不存在输入管脚【{inputPinName}】。");
                return false;
            }

            AddCommPoints(new List<string> { pointName });
            laPoint.Connected = true;
            inputField.SetValue(function, laPoint);
            RecordUsedPoint(pointName, instanceName, inputPinName);
            return true;
        }

        private bool SetAlarmFunctionFieldValue(Function function, string fieldName, object value)
        {
            FieldInfo? fieldInfo = function.GetType().GetField(fieldName);
            if (fieldInfo == null)
            {
                logger.ErrorLog($"报警实例【{function.InstanceName}】不存在字段【{fieldName}】。");
                return false;
            }

            fieldInfo.SetValue(function, value);
            return true;
        }

        #endregion

        #region 辅助方法

        public void SetHealthPointToInputPin(Function function, string inputPinName, string pointName, int indicatorID)
        {
            if (!RTDDict.ContainsKey(pointName))
            {
                logger.ErrorLog($"健康度指标编号：【{indicatorID}】的使用点名【{pointName}】不存在。");
                return;
            }

            AddCommPoints(new List<string> { pointName });
            object sysPoint = GetFirstRunableWarn(pointName);

            if (!(sysPoint is LA))
            {
                logger.ErrorLog($"健康度指标编号：【{indicatorID}】的使用点名【{pointName}】类型错误。");
                return;
            }

            FieldInfo health_IN = function.GetType().GetField(inputPinName);
            if (health_IN != null)
            {
                ((LA)sysPoint).Connected = true;
                health_IN.SetValue(function, (LA)sysPoint);
            }
        }

        #endregion

        #region 确认处理方法

        public void Ack()
        {
            foreach (var item in AckDict)
            {
                ProcessAcknowledgment(item);
            }
        }

        /// <summary>
        /// 处理单个确认
        /// </summary>
        private void ProcessAcknowledgment(KeyValuePair<string, List<string>> ackItem)
        {
            string algName = ackItem.Key;
            if (!FunctionInstanceDict.ContainsKey(algName))
            {
                return;
            }

            Function function = FunctionInstanceDict[algName];
            FieldInfo needAckField = function.GetType().GetField("NeedAck");

            if (needAckField == null)
            {
                return;
            }

            bool needAck = (bool)needAckField.GetValue(function);
            if (!needAck)
            {
                return;
            }

            foreach (string pointName in ackItem.Value)
            {
                if (RTDDict.ContainsKey(pointName))
                {
                    object syspoint = GetFirstRunableWarn(pointName);
                    if (syspoint is LAExWarn lAExWarn)
                    {
                        lAExWarn.UnAck = false;
                    }
                }
            }


            needAckField.SetValue(function, false);
        }

        #endregion

        #region 健康数据插入方法

        public void InsertHealthData()
        {
            List<string> sqllist = new List<string>();
            foreach (var item in HealthScoreDict)
            {
                string algName = item.Key;
                float score = HealthScoreDict[algName].buffer;
                sqllist.Add($" {algName} values('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}','{score}') ");
            }

            //TDengineHelp.Insert(sqllist);
        }

        #endregion

        #region 故障数据处理方法

        public void InsertFaultData()
        {
            var (addFaultDiagnosisList, updateFaultDiagnosisList) = ProcessFaultInfoList();

            if (addFaultDiagnosisList.Count == 0 && updateFaultDiagnosisList.Count == 0)
            {
                return;
            }

            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                if (addFaultDiagnosisList.Count > 0)
                {
                    warnContext.FaultDiagnosis.AddRange(addFaultDiagnosisList);
                }

                if (updateFaultDiagnosisList.Count > 0)
                {
                    warnContext.FaultDiagnosis.UpdateRange(updateFaultDiagnosisList);
                }

                warnContext.SaveChanges();
                faultDiagnosisList = warnContext.FaultDiagnosis.ToList();
            }
        }

        /// <summary>
        /// 处理故障信息列表
        /// </summary>
        private (List<FaultDiagnosis> addList, List<FaultDiagnosis> updateList) ProcessFaultInfoList()
        {
            List<FaultDiagnosis> addFaultDiagnosisList = new List<FaultDiagnosis>();
            List<FaultDiagnosis> updateFaultDiagnosisList = new List<FaultDiagnosis>();

            foreach (var item in FaultInfoList)
            {
                try
                {
                    ProcessSingleFaultInfo(item, addFaultDiagnosisList, updateFaultDiagnosisList);
                }
                catch (Exception ex)
                {
                    logger.ErrorLog($"处理故障信息时出错 {item.Key}: {ex.Message}");
                }
            }

            return (addFaultDiagnosisList, updateFaultDiagnosisList);
        }

        /// <summary>
        /// 处理单个故障信息
        /// </summary>
        private void ProcessSingleFaultInfo(KeyValuePair<string, FaultInfo> faultItem,
            List<FaultDiagnosis> addList, List<FaultDiagnosis> updateList)
        {
            string algName = faultItem.Key;
            if (!FunctionInstanceDict.ContainsKey(algName))
            {
                return;
            }

            Function function = FunctionInstanceDict[algName];
            var (outValue, needOutValue, faultCodeValue) = GetFunctionOutputValues(function);
            string sourceName = string.IsNullOrWhiteSpace(function.InstanceName) ? algName : function.InstanceName;


            if (FaultInfoList[algName].Status == 0 && outValue == 1)
            {
                FaultInfoList[algName].Time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            FaultInfoList[algName].Status = outValue;

            if (needOutValue)
            {
                ProcessFaultOutput(sourceName, outValue, faultCodeValue, addList, updateList);

                //重置NeedOut标志
                FieldInfo needOutPin = function.GetType().GetField("NeedOut");
                needOutPin?.SetValue(function, false);
            }
        }

        /// <summary>
        /// 获取功能输出值
        /// </summary>
        private (int outValue, bool needOutValue, int faultCodeValue) GetFunctionOutputValues(Function function)
        {
            FieldInfo needOutPin = function.GetType().GetField("NeedOut");
            FieldInfo outPin = function.GetType().GetField("OUT");
            FieldInfo faultCodePin = function.GetType().GetField("FaultCode");

            object obj = outPin?.GetValue(function);
            int outValue = obj != null && ((LD)obj).buffer ? 1 : 0;

            bool needOutValue = needOutPin != null && (bool)needOutPin.GetValue(function);
            int faultCodeValue = faultCodePin != null ? (int)faultCodePin.GetValue(function) : 0;

            return (outValue, needOutValue, faultCodeValue);
        }

        /// <summary>
        /// 处理故障输出
        /// </summary>
        private void ProcessFaultOutput(string sourceName, int outValue, int faultCodeValue,
            List<FaultDiagnosis> addList, List<FaultDiagnosis> updateList)
        {
            if (outValue == 1)
            {
                // 添加新故障
                addList.Add(new FaultDiagnosis()
                {
                    FaultCode = faultCodeValue,
                    BeginTime = DateTime.Now,
                    Source = sourceName
                });
            }
            else
            {
                // 更新故障结束时间
                FaultDiagnosis faultDiagnosis = faultDiagnosisList.LastOrDefault(x => x.FaultCode == faultCodeValue && x.Source == sourceName);
                if (faultDiagnosis != null)
                {
                    faultDiagnosis.EndTime = DateTime.Now;
                    updateList.Add(faultDiagnosis);
                }
            }
        }

        public void InsertAlarmWarnData()
        {
            if (AlarmWarnInfoDict.Count == 0)
            {
                return;
            }

            var (addWarnAlarmList, updateWarnAlarmList) = ProcessAlarmWarnInfoList();
            if (addWarnAlarmList.Count == 0 && updateWarnAlarmList.Count == 0)
            {
                return;
            }

            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    if (addWarnAlarmList.Count > 0)
                    {
                        warnContext.WarnAlarms.AddRange(addWarnAlarmList);
                    }

                    if (updateWarnAlarmList.Count > 0)
                    {
                        warnContext.WarnAlarms.UpdateRange(updateWarnAlarmList);
                    }

                    warnContext.SaveChanges();
                    warnAlarmList = warnContext.WarnAlarms.ToList();
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"InsertAlarmWarnData: {ex.Message}");
            }
        }

        private (List<WarnAlarm> addList, List<WarnAlarm> updateList) ProcessAlarmWarnInfoList()
        {
            List<WarnAlarm> addWarnAlarmList = new List<WarnAlarm>();
            List<WarnAlarm> updateWarnAlarmList = new List<WarnAlarm>();

            foreach (var item in AlarmWarnInfoDict)
            {
                try
                {
                    ProcessSingleAlarmWarnInfo(item, addWarnAlarmList, updateWarnAlarmList);
                }
                catch (Exception ex)
                {
                    logger.ErrorLog($"处理报警预警信息时出错 {item.Key}: {ex.Message}");
                }
            }

            return (addWarnAlarmList, updateWarnAlarmList);
        }

        private void ProcessSingleAlarmWarnInfo(KeyValuePair<string, AlarmWarnInfo> alarmWarnItem,
            List<WarnAlarm> addList, List<WarnAlarm> updateList)
        {
            string algName = alarmWarnItem.Key;
            if (!FunctionInstanceDict.TryGetValue(algName, out Function? function))
            {
                return;
            }

            if (!GetFunctionNeedOut(function))
            {
                return;
            }

            AlarmWarnInfo alarmWarnInfo = alarmWarnItem.Value;
            if (GetFunctionOutValue(function))
            {
                addList.Add(new WarnAlarm
                {
                    PointName = alarmWarnInfo.PointName,
                    SysID = -1,
                    ModelID = -1,
                    BeginTime = DateTime.Now,
                    Level = 1,
                    AlarmType = alarmWarnInfo.AlarmType,
                    LimitAlarmType = alarmWarnInfo.LimitAlarmType,
                    UnAck = 1
                });
            }
            else
            {
                WarnAlarm? warnAlarm = FindOpenAlarmWarn(alarmWarnInfo);
                if (warnAlarm != null)
                {
                    warnAlarm.EndTime = DateTime.Now;
                    warnAlarm.Duration = Math.Ceiling((warnAlarm.EndTime - warnAlarm.BeginTime).TotalSeconds);
                    updateList.Add(warnAlarm);
                }
            }

            SetFunctionNeedOut(function, false);
        }

        private WarnAlarm? FindOpenAlarmWarn(AlarmWarnInfo alarmWarnInfo)
        {
            string pointName = alarmWarnInfo.PointName ?? string.Empty;
            string tablePointName = pointName.ToTableName();

            return warnAlarmList.LastOrDefault(x =>
                (string.Equals(x.PointName, pointName, StringComparison.OrdinalIgnoreCase) ||
                 string.Equals(x.PointName, tablePointName, StringComparison.OrdinalIgnoreCase)) &&
                x.EndTime == DateTime.MinValue &&
                x.AlarmType == alarmWarnInfo.AlarmType &&
                x.LimitAlarmType == alarmWarnInfo.LimitAlarmType);
        }

        private bool GetFunctionNeedOut(Function function)
        {
            FieldInfo? needOutField = function.GetType().GetField("NeedOut");
            return needOutField != null && needOutField.GetValue(function) is bool needOutValue && needOutValue;
        }

        private void SetFunctionNeedOut(Function function, bool value)
        {
            FieldInfo? needOutField = function.GetType().GetField("NeedOut");
            needOutField?.SetValue(function, value);
        }

        private bool GetFunctionOutValue(Function function)
        {
            FieldInfo? outField = function.GetType().GetField("OUT");
            return outField?.GetValue(function) is LD outPin && outPin.buffer;
        }

        #endregion

        #region 重新初始化相关方法
        /// <summary>
        /// 完全清理一个功能块实例的所有相关数据
        /// </summary>
        /// <param name="algName">算法名称</param>
        private void RemoveFunctionBlockInstance(string algName)
        {
            try
            {
                bool hasRemoved = false;

                // 1. 移除功能实例
                if (FunctionInstanceDict.ContainsKey(algName))
                {
                    FunctionInstanceDict.Remove(algName);
                    hasRemoved = true;
                }

                // 2. 移除确认字典
                if (AckDict.ContainsKey(algName))
                {
                    AckDict.Remove(algName);
                }

                // 3. 移除故障信息
                if (FaultInfoList.ContainsKey(algName))
                {
                    FaultInfoList.Remove(algName);
                }

                //// 4. 移除性能计算输出
                //if (secondCalcPinValueList.ContainsKey(algName))
                //{
                //    secondCalcPinValueList.Remove(algName);
                //}

                // 5. 移除回写点
                if (WriteBackDcsPointDict.ContainsKey(algName))
                {
                    WriteBackDcsPointDict.Remove(algName);
                }

                // 6. 移除计算LA
                if (calculatedLAList.ContainsKey(algName))
                {
                    calculatedLAList.Remove(algName);
                }

                // 7. 移除使用点记录
                var keysToRemove = UsedPointsByFc
                    .Where(kvp => kvp.Value.ContainsKey(algName))
                    .Select(kvp => kvp.Key)
                    .ToList();

                foreach (var key in keysToRemove)
                {
                    UsedPointsByFc[key].Remove(algName);
                    // 如果该点名没有其他算法使用，则移除整个键
                    if (UsedPointsByFc[key].Count == 0)
                    {
                        UsedPointsByFc.Remove(key);
                    }
                }

                if (hasRemoved)
                {
                    logger.InfoLog($"已清理功能块实例: {algName}");
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"清理功能块实例 {algName} 时出错: {ex.Message}");
            }
        }

        public void ReinitializeSheets(List<int> sheetids)
        {
            foreach (var sheetid in sheetids)
            {
                ReinitializeSheetIncremental(sheetid);
            }
        }

        /// <summary>
        /// 批量增量重新初始化工作表（只处理变化的功能块）
        /// </summary>
        /// <param name="sheetids">工作表ID列表</param>
        public void ReinitializeSheetsIncremental(List<int> sheetids)
        {
            logger.InfoLog($"开始批量增量重新初始化，共 {sheetids.Count} 个工作表");
            foreach (var sheetid in sheetids)
            {
                ReinitializeSheetIncremental(sheetid);
            }
            logger.InfoLog($"批量增量重新初始化完成");
        }

        //public void ReinitializeSheet(int sheetid)
        //{
        //    try
        //    {
        //        using (WarnContext warnContext = new WarnContext(mysqlconn))
        //        {
        //            // 预加载相关数据
        //            var cldFcinputList = warnContext.CldFcinputs.Where(x => x.PrjSheetId == sheetid).ToList();
        //            var cldFcoutputList = warnContext.CldFcoutputs.Where(x => x.PrjSheetId == sheetid).ToList();
        //            var cldFcparameterList = warnContext.CldFcparameters.Where(x => x.PrjSheetId == sheetid).ToList();

        //            List<CldFcblock> cldFcblockListTemp = warnContext.CldFcblocks.Where(x => x.PrjSheetId == sheetid).ToList();

        //            CldFcblockList.RemoveAll(x => x.PrjSheetId == sheetid);
        //            CldFcblockList.AddRange(cldFcblockListTemp);

        //            foreach (var fcBlock in cldFcblockListTemp)
        //            {
        //                ProcessSingleFunctionBlockForSheet(fcBlock, sheetid);
        //            }

        //            InitializeBlocks(cldFcblockListTemp);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.ErrorLog($"重新初始化工作表 {sheetid} 时出错: {ex.Message}");
        //    }
        //}

        /// <summary>
        /// 增量重新初始化工作表（只处理变化的功能块）
        /// </summary>
        /// <param name="sheetid">工作表ID</param>
        public void ReinitializeSheetIncremental(int sheetid)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(mysqlconn))
                {
                    // ========== 步骤1：加载数据库数据 ==========
                    var cldFcinputList = warnContext.CldFcinputs.Where(x => x.PrjSheetId == sheetid).ToList();
                    var cldFcoutputList = warnContext.CldFcoutputs.Where(x => x.PrjSheetId == sheetid).ToList();
                    var cldFcparameterList = warnContext.CldFcparameters.Where(x => x.PrjSheetId == sheetid).ToList();

                    List<CldFcblock> cldFcblockListTemp = warnContext.CldFcblocks.Where(x => x.PrjSheetId == sheetid).ToList();

                    // 手动填充导航属性
                    foreach (var fcblock in cldFcblockListTemp)
                    {
                        fcblock.CldFcinputs = cldFcinputList.Where(x => x.CldFcblockId == fcblock.Id).ToList();
                        fcblock.CldFcoutputs = cldFcoutputList.Where(x => x.CldFcblockId == fcblock.Id).ToList();
                        fcblock.CldFcparameters = cldFcparameterList.Where(x => x.CldFcblockId == fcblock.Id).ToList();
                    }

                    // ========== 步骤2：获取旧数据并建立索引 ==========
                    var oldFcblockList = CldFcblockList.Where(x => x.PrjSheetId == sheetid).ToList();

                    // 建立 AlgName 索引，便于查找
                    var oldFcblockDict = oldFcblockList.ToDictionary(x => x.AlgName, x => x);
                    var newFcblockDict = cldFcblockListTemp.ToDictionary(x => x.AlgName, x => x);

                    // ========== 步骤3：识别新增、删除、可能修改的功能块 ==========
                    // 新增的功能块：在新数据中存在，但在旧数据中不存在
                    var addedBlocks = cldFcblockListTemp
                        .Where(x => !oldFcblockDict.ContainsKey(x.AlgName))
                        .ToList();

                    // 删除的功能块：在旧数据中存在，但在新数据中不存在
                    var removedBlocks = oldFcblockList
                        .Where(x => !newFcblockDict.ContainsKey(x.AlgName))
                        .ToList();

                    // 可能修改的功能块：在新旧数据中都存在
                    var possiblyModifiedBlocks = cldFcblockListTemp
                        .Where(x => oldFcblockDict.ContainsKey(x.AlgName))
                        .ToList();

                    logger.InfoLog($"Sheet {sheetid} 分析结果: 新增={addedBlocks.Count}, 删除={removedBlocks.Count}, 可能修改={possiblyModifiedBlocks.Count}");

                    // ========== 步骤4：处理删除的功能块 ==========
                    foreach (var removedBlock in removedBlocks)
                    {
                        // 清理实例
                        RemoveFunctionBlockInstance(removedBlock.AlgName);

                        // 从 CldFcblockList 中移除
                        CldFcblockList.Remove(removedBlock);

                        logger.InfoLog($"删除功能块: {removedBlock.AlgName}");
                    }

                    // ========== 步骤5：处理新增的功能块 ==========
                    List<CldFcblock> blocksToInitialize = new List<CldFcblock>();

                    foreach (var addedBlock in addedBlocks)
                    {
                        // 创建功能实例
                        CreateFunctionInstanceForIncremental(addedBlock, sheetid);

                        // 添加到 CldFcblockList
                        CldFcblockList.Add(addedBlock);

                        // 加入待初始化列表
                        blocksToInitialize.Add(addedBlock);

                        logger.InfoLog($"新增功能块: {addedBlock.AlgName}");
                    }

                    // ========== 步骤6：处理可能修改的功能块（精细化更新）==========
                    int totalChangedInputs = 0;
                    int totalChangedOutputs = 0;
                    int totalChangedParams = 0;

                    foreach (var newBlock in possiblyModifiedBlocks)
                    {
                        var oldBlock = oldFcblockDict[newBlock.AlgName];
                        string algName = newBlock.AlgName;

                        if (algName.StartsWith("PCA") || algName.StartsWith("ANN"))
                        {
                            if (addedBlocks.Any(x => x.AlgName.Contains(algName)))
                                continue;

                            logger.InfoLog($"重新创建模型实例: {algName}！");

                            // 销毁旧实例及其关联数据
                            RemoveFunctionBlockInstance(algName);

                            // 从 CldFcblockList 中移除旧数据
                            int index = CldFcblockList.IndexOf(oldBlock);
                            if (index >= 0)
                            {
                                CldFcblockList.RemoveAt(index);
                            }

                            // 用新DLL创建新实例
                            CreateFunctionInstanceForIncremental(newBlock, sheetid);

                            // 添加新数据到 CldFcblockList
                            CldFcblockList.Add(newBlock);

                            // 加入待初始化列表，在步骤7中统一初始化管脚连接
                            blocksToInitialize.Add(newBlock);
                            logger.InfoLog($"模型实例 {algName} 创建完成！");
                            continue;
                        }

                        // 6.1 识别变化的输入管脚
                        var changedInputs = GetChangedInputPins(oldBlock.CldFcinputs, newBlock.CldFcinputs);

                        // 6.2 识别变化的输出管脚
                        var changedOutputs = GetChangedOutputPins(oldBlock.CldFcoutputs, newBlock.CldFcoutputs);

                        // 6.3 识别变化的规格数
                        var changedParams = GetChangedParameters(oldBlock.CldFcparameters, newBlock.CldFcparameters);

                        // 判断是否有任何变化
                        bool hasAnyChange = changedInputs.Count > 0 || changedOutputs.Count > 0 || changedParams.Count > 0;

                        if (hasAnyChange)
                        {
                            logger.InfoLog($"功能块 {algName} 有变化: 输入={changedInputs.Count}, 输出={changedOutputs.Count}, 规格数={changedParams.Count}");

                            // 6.4 更新变化的输入管脚
                            foreach (var change in changedInputs)
                            {
                                if (change.IsPointNameChanged)
                                {
                                    logger.InfoLog($"{algName} 输入管脚 {change.PinName}：PointName '{change.OldPointName}' -> '{change.NewPointName}'");

                                }
                                else if (change.IsInitialValueChanged)
                                {
                                    logger.InfoLog($"{algName} 输入管脚 {change.PinName}：InitialValue '{change.OldInitialValue}' -> '{change.NewInitialValue}'");
                                }

                                UpdateSingleInputPin(algName, change.PinName, change.NewPointName, change.NewInitialValue);
                                totalChangedInputs++;
                            }

                            // 6.5 更新变化的输出管脚
                            foreach (var (pinName, oldPointName, newPointName) in changedOutputs)
                            {
                                logger.InfoLog($"{algName} 输出管脚 {pinName}：PointName '{oldPointName}' -> '{newPointName}'");
                                UpdateSingleOutputPin(algName, pinName, newPointName);
                                totalChangedOutputs++;
                            }

                            // 6.6 更新变化的规格数
                            foreach (var (name, oldPvalue, newPvalue) in changedParams)
                            {
                                logger.InfoLog($"{algName} 规格数 {name}：'{oldPvalue}' -> '{newPvalue}'");
                                UpdateSingleParameter(algName, name, newPvalue);
                                totalChangedParams++;
                            }

                            // 6.7 更新 CldFcblockList 中的数据（保持与数据库一致）
                            int index = CldFcblockList.IndexOf(oldBlock);
                            if (index >= 0)
                            {
                                CldFcblockList[index] = newBlock;
                            }

                            logger.InfoLog($"功能块 {algName} 精细化更新完成");
                        }
                        else
                        {
                            // 无变化，保持不变
                            logger.InfoLog($"功能块无变化，保持不变: {algName}");
                        }
                    }

                    // ========== 步骤7：批量初始化新增的功能块 ==========
                    if (blocksToInitialize.Count > 0)
                    {
                        InitializeBlocks(blocksToInitialize);
                        logger.InfoLog($"Sheet {sheetid} 新增功能块初始化完成: {blocksToInitialize.Count} 个");
                    }

                    // ========== 汇总统计 ==========
                    int totalModifiedBlocks = totalChangedInputs > 0 || totalChangedOutputs > 0 || totalChangedParams > 0
                        ? possiblyModifiedBlocks.Count(b =>
                            GetChangedInputPins(oldFcblockDict[b.AlgName].CldFcinputs, b.CldFcinputs).Count > 0 ||
                            GetChangedOutputPins(oldFcblockDict[b.AlgName].CldFcoutputs, b.CldFcoutputs).Count > 0 ||
                            GetChangedParameters(oldFcblockDict[b.AlgName].CldFcparameters, b.CldFcparameters).Count > 0)
                        : 0;

                    logger.InfoLog($"========== Sheet {sheetid} 增量重新初始化完成 ==========");
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"增量重新初始化工作表 {sheetid} 时出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 为增量更新创建功能实例（不包含删除逻辑）
        /// </summary>
        private void CreateFunctionInstanceForIncremental(CldFcblock cldFcblock, int sheetid)
        {
            // 跳过未注册的功能类型
            if (!fcTypeDict.ContainsKey(cldFcblock.FunctionName))
            {
                logger.ErrorLog($"功能类型 {cldFcblock.FunctionName} 未注册");
                return;
            }

            string algName = cldFcblock.AlgName;

            // 如果实例已存在则跳过（理论上不应该发生，因为调用前已清理）
            if (FunctionInstanceDict.ContainsKey(algName))
            {
                logger.ErrorLog($"功能实例 {algName} 已存在，跳过创建");
                return;
            }

            // 创建功能实例
            Function functionInstance = CreateFcInstance(cldFcblock.FunctionName);
            if (functionInstance == null)
            {
                logger.ErrorLog($"创建功能实例 {algName} 失败");
                return;
            }

            functionInstance.InstanceName = algName;
            functionInstance.SheetId = sheetid;

            // 特殊处理警告类型功能块
            if (functionInstance.FcType == Function.enumType.Warn)
            {
                functionInstance.Runable = cldFcblock.InstantStatus == 1;
            }

            // 添加到实例字典
            FunctionInstanceDict.Add(algName, functionInstance);
        }


        /// <summary>
        /// 处理单个功能块
        /// </summary>
        private void ProcessSingleFunctionBlockForSheet(CldFcblock fcBlock, int sheetid)
        {
            // 跳过未注册的功能类型
            if (!fcTypeDict.ContainsKey(fcBlock.FunctionName))
                return;

            string algName = fcBlock.AlgName;

            //// 如果是重新初始化预警模型，要先删除
            //if (!string.IsNullOrEmpty(fcBlock.InstantInfo) && FunctionInstanceDict.ContainsKey(algName))
            //{
            //    FunctionInstanceDict.Remove(algName);
            //}

            FunctionInstanceDict.Remove(algName);//下装时，移除已经实例化内容，重新实例化，防止输入管脚的连接点删除后之前的信息还存在


            // 如果实例已存在则跳过
            if (FunctionInstanceDict.ContainsKey(algName))
                return;

            // 创建功能实例
            Function functionInstance = CreateFcInstance(fcBlock.FunctionName);
            if (functionInstance == null)
                return;

            functionInstance.InstanceName = algName;
            functionInstance.SheetId = sheetid;

            // 特殊处理警告类型功能块
            if (functionInstance.FcType == Function.enumType.Warn)
            {
                functionInstance.Runable = fcBlock.InstantStatus == 1;
            }

            // 添加到实例字典
            FunctionInstanceDict.Add(algName, functionInstance);
        }

        #endregion

        #region 块初始化相关方法

        public void InitializeBlocks(List<CldFcblock> cldFcblocks)
        {
            foreach (var cldFcblock in cldFcblocks)
            {
                InitializeSingleBlock(cldFcblock);
            }
        }

        /// <summary>
        /// 初始化单个块
        /// </summary>
        private void InitializeSingleBlock(CldFcblock cldFcblock)
        {
            string algName = cldFcblock.AlgName;
            try
            {
                if (!FunctionInstanceDict.ContainsKey(algName))
                {
                    return;
                }

                Function curFunctionInstance = FunctionInstanceDict[algName];

                // 处理预警块测点对应的输出重构值
                ProcessWarnRValues(algName, curFunctionInstance);

                //// 设置性能计算输出关系
                //SetupPerformanceCalculationOutputs(cldFcblock, algName, curFunctionInstance);

                // 处理规格数管脚
                SetParameterDefaultValues(cldFcblock, algName, curFunctionInstance);

                // 处理输出管脚
                List<string> ackPointList = ProcessOutputPins(cldFcblock, algName, curFunctionInstance);

                // 处理确认字典
                if (curFunctionInstance.FcType == Function.enumType.Ack)
                {
                    AckDict.Add(algName, ackPointList);
                }

                // 处理输入管脚
                ProcessInputPins(cldFcblock, curFunctionInstance);
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"初始化块 {algName} 时出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 处理预警块测点对应的输出重构值
        /// </summary>
        private void ProcessWarnRValues(string algName, Function curFunctionInstance)
        {
            if (warnRValueDict.TryGetValue(algName, out var warnRValues))
            {
                foreach (var warnRValue in warnRValues)
                {
                    var fieldInfo = curFunctionInstance.GetType().GetField(warnRValue.OutPinName);
                    if (fieldInfo == null) continue;
                    var fieldValue = fieldInfo.GetValue(curFunctionInstance);

                    if (fieldValue is LA laValue)
                    {
                        warnRValue.RValue = laValue;
                    }
                }
            }
        }

        ///// <summary>
        ///// 设置性能计算输出PinName与Pin对象的关系
        ///// </summary>
        //private void SetupPerformanceCalculationOutputs(CldFcblock cldFcblock, string algName, Function curFunctionInstance)
        //{
        //    if (curFunctionInstance.FcType != Function.enumType.SC && curFunctionInstance.FcType != Function.enumType.ICO)
        //    {
        //        return;
        //    }

        //    foreach (var item in secondCalcPinNameList)
        //    {
        //        if (item.Key == cldFcblock.FunctionName)
        //        {
        //            secondCalcPinValueList.Add(algName, new Dictionary<string, object>());

        //            foreach (string pinName in item.Value)
        //            {
        //                FieldInfo curFcBlockOutputInfo = curFunctionInstance.GetType().GetField(pinName);
        //                if (curFcBlockOutputInfo != null)
        //                {
        //                    object obj = curFcBlockOutputInfo.GetValue(curFunctionInstance);
        //                    if (obj is LA || obj is LD)
        //                    {
        //                        secondCalcPinValueList[algName].Add(configInfo.Prefix + "_" + curFcBlockOutputInfo.Name.ToUpper(), obj);
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 设置规格数默认值
        /// </summary>
        private void SetParameterDefaultValues(CldFcblock cldFcblock, string algName, Function curFunctionInstance)
        {
            foreach (var cldFcparameter in cldFcblock.CldFcparameters)
            {
                if (string.IsNullOrEmpty(cldFcparameter.Pvalue))
                    continue;

                FieldInfo fieldInfo = curFunctionInstance.GetType().GetField(cldFcparameter.Name);
                if (fieldInfo == null)
                    continue;

                switch (fieldInfo.FieldType.Name)
                {
                    case "Int32":
                        fieldInfo.SetValue(curFunctionInstance, Convert.ToInt32(cldFcparameter.Pvalue));
                        break;
                    case "Single":
                        fieldInfo.SetValue(curFunctionInstance, Convert.ToSingle(cldFcparameter.Pvalue));
                        break;
                }

                if (curFunctionInstance.FcType == Function.enumType.FaultOut && cldFcparameter.Name == "FaultCode" && !FaultInfoList.ContainsKey(algName))
                {
                    FaultInfoList.Add(algName, new FaultInfo
                    {
                        Code = Convert.ToInt32(cldFcparameter.Pvalue),
                        Desc = cldFcblock.Description ?? "",
                        Source = cldFcblock.AlgName
                    });
                }
            }
        }


        /// <summary>
        /// 处理输出管脚
        /// </summary>
        private List<string> ProcessOutputPins(CldFcblock cldFcblock, string algName, Function curFunctionInstance)
        {
            WriteBackDcsPointDict.Remove(algName);

            List<string> ackPointList = new List<string>();

            foreach (var cldFcoutput in cldFcblock.CldFcoutputs)
            {
                string pointName = cldFcoutput.PointName;

                if (string.IsNullOrEmpty(pointName) || pointName.Contains("."))
                    continue;

                if (!RTDDict.ContainsKey(pointName))
                    continue;

                if (!ackPointList.Contains(pointName))
                {
                    ackPointList.Add(pointName);
                }

                ProcessFaultOutPointName(cldFcblock, algName, curFunctionInstance, pointName);
                ProcessWriteBackDcsPoint(algName, cldFcoutput, curFunctionInstance);

            }

            return ackPointList;
        }

        /// <summary>
        /// 处理故障输出点名
        /// </summary>
        private void ProcessFaultOutPointName(CldFcblock cldFcblock, string algName, Function curFunctionInstance, string pointName)
        {
            if (curFunctionInstance.FcType != Function.enumType.FaultOut)
                return;

            if (FaultInfoList.ContainsKey(algName))
            {
                FaultInfoList[algName].PointName = pointName;
            }
            else
            {
                FaultInfoList.Add(algName, new FaultInfo
                {
                    Desc = cldFcblock.Description,
                    Source = cldFcblock.AlgName,
                    PointName = pointName
                });
            }
        }







        private void ProcessWriteBackDcsPoint(string algName, CldFcoutput cldFcoutput, Function curFunctionInstance)
        {
            string pointName = cldFcoutput.PointName;
            if (!RTDDict.TryGetValue(pointName, out var sysPoints) || sysPoints == null)
            {
                return;
            }

            FieldInfo fieldInfo = curFunctionInstance.GetType().GetField(cldFcoutput.PinName);
            if (fieldInfo == null)
            {
                return;
            }

            object obj = fieldInfo.GetValue(curFunctionInstance);
            object valueToSet = null; // 用于存储最终要设置的值

            if (obj is LA laObj)
            {
                valueToSet = laObj.buffer;
            }
            else if (obj is LD ldObj)
            {
                valueToSet = ldObj.buffer ? 1 : 0;
            }
            else
            {
                // 如果obj不是LA也不是LD，则不处理
                return;
            }

            // 检查回写点是否已被其他算法使用
            bool writeBacked = false;
            foreach (var item in WriteBackDcsPointDict)
            {
                // 确保字典项的Value不是null，或者可以尝试使用TryGetValue
                if (item.Value != null && item.Value.ContainsKey(pointName))
                {
                    logger.InfoLog($"{algName}.{cldFcoutput.PinName}输出管脚的回写点{pointName}已经在{item.Key}中使用，回写点不能被多个输出赋值！");
                    writeBacked = true;
                    break;
                }
            }

            if (!writeBacked)
            {
                //将当前算法的回写点添加到字典
                ExcuteEngine.WriteBackDcsPointDict.TryAdd(algName, new Dictionary<string, object>());
                ExcuteEngine.WriteBackDcsPointDict[algName][pointName] = obj;//存储原始的LA或LD对象
            }
        }


        /// <summary>
        /// 处理输入管脚
        /// </summary>
        private void ProcessInputPins(CldFcblock cldFcblock, Function curFunctionInstance)
        {
            foreach (var cldFcinput in cldFcblock.CldFcinputs)
            {
                ProcessSingleInputPin(cldFcblock, curFunctionInstance, cldFcinput);
            }
        }

        /// <summary>
        /// 处理单个输入管脚
        /// </summary>
        private void ProcessSingleInputPin(CldFcblock cldFcblock, Function curFunctionInstance, CldFcinput cldFcinput)
        {
            if (cldFcinput == null) return;
            string pinName = cldFcinput.PinName?.Trim();
            if (string.IsNullOrEmpty(pinName)) return;

            try
            {
                FieldInfo curFcBlockInputInfo = curFunctionInstance.GetType().GetField(pinName);
                if (curFcBlockInputInfo == null) return;

                if (!string.IsNullOrEmpty(cldFcinput.PointName))
                {
                    ProcessPointConnection(cldFcblock, curFunctionInstance, cldFcinput, curFcBlockInputInfo);
                }
                else
                {
                    SetDefaultInputValue(cldFcblock, cldFcinput, curFcBlockInputInfo, curFunctionInstance);
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"处理输入管脚 {pinName} 时出错: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// 处理点连接
        /// </summary>
        private void ProcessPointConnection(CldFcblock cldFcblock, Function curFunctionInstance,
            CldFcinput cldFcinput, FieldInfo curFcBlockInputInfo)
        {
            string pointName = cldFcinput.PointName.Trim();

            // 根据点名类型分别处理
            if (pointName.Contains("."))
            {
                ProcessInternalConnection(pointName, curFcBlockInputInfo, curFunctionInstance);
            }
            else if (IsCalculationFunction(pointName))
            {
                string functionType = GetCalculationFunctionType(pointName);
                ProcessCalculationFunction(cldFcblock, pointName, curFcBlockInputInfo, curFunctionInstance, functionType);
            }
            else if (pointName.Contains(","))
            {
                ProcessMultiplePointsConnection(cldFcblock, pointName, curFcBlockInputInfo, curFunctionInstance);
            }
            else
            {
                ProcessExternalPointConnection(cldFcblock, pointName, curFcBlockInputInfo, curFunctionInstance);
            }
        }

        /// <summary>
        /// 判断是否为计算函数
        /// </summary>
        private bool IsCalculationFunction(string pointName)
        {
            return (pointName.StartsWith("sum(") || pointName.StartsWith("avg(")) && pointName.EndsWith(")");
        }

        /// <summary>
        /// 获取计算函数类型
        /// </summary>
        private string GetCalculationFunctionType(string pointName)
        {
            if (pointName.StartsWith("sum(")) return "sum";
            if (pointName.StartsWith("avg(")) return "avg";
            return "";
        }

        /// <summary>
        /// 处理多个点的连接（逗号分隔）
        /// </summary>
        private void ProcessMultiplePointsConnection(CldFcblock cldFcblock, string pointName,
            FieldInfo curFcBlockInputInfo, Function curFunctionInstance)
        {
            try
            {
                string[] pointNames = SplitAndValidatePointNames(pointName);
                if (pointNames.Length == 0) return;

                if (!curFcBlockInputInfo.FieldType.IsArray)
                {
                    logger.ErrorLog($"字段 {curFcBlockInputInfo.Name} 不是数组类型，无法处理多个点名");
                    return;
                }

                var array = (LA[])curFcBlockInputInfo.GetValue(curFunctionInstance);
                if (array == null) return;

                ProcessMultiplePointsToArray(cldFcblock, pointNames, array, curFcBlockInputInfo, curFunctionInstance);
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"处理多个点连接时出错 {pointName}: {ex.Message}");
            }
        }

        /// <summary>
        /// 分割并验证点名
        /// </summary>
        private string[] SplitAndValidatePointNames(string pointName)
        {
            return pointName.Split(',')
                .Select(p => p.Trim())
                .Where(p => !string.IsNullOrEmpty(p))
                .ToArray();
        }

        /// <summary>
        /// 处理多个点到数组的赋值
        /// </summary>
        private void ProcessMultiplePointsToArray(CldFcblock cldFcblock, string[] pointNames, LA[] array,
            FieldInfo curFcBlockInputInfo, Function curFunctionInstance)
        {
            for (int i = 0; i < pointNames.Length && i < array.Length; i++)
            {
                string pn = pointNames[i];

                if (IsCalculationFunction(pn))
                {
                    string functionType = GetCalculationFunctionType(pn);
                    ProcessCalculationFunction(cldFcblock, pn, curFcBlockInputInfo, curFunctionInstance, functionType);
                }
                else
                {
                    ProcessSinglePointToArray(cldFcblock, pn, array, i, curFcBlockInputInfo);
                }
            }
        }

        /// <summary>
        /// 处理单个点到数组的赋值
        /// </summary>
        private void ProcessSinglePointToArray(CldFcblock cldFcblock, string pointName, LA[] array, int index,
            FieldInfo curFcBlockInputInfo)
        {
            if (!RTDDict.ContainsKey(pointName))
            {
                logger.ErrorLog($"点名 {pointName} 在RTDDict中不存在！");
                return;
            }

            AddCommPoints(new List<string> { pointName });
            object pointDetail = GetPointDetail(cldFcblock, pointName);

            if (pointDetail is LA laPoint)
            {
                SetPointConnected(pointDetail);
                array[index] = laPoint;
                RecordUsedPoint(pointName, cldFcblock.AlgName, curFcBlockInputInfo.Name);
            }
            else
            {
                logger.ErrorLog($"点名 {pointName} 不是LA类型，无法进行赋值");
            }
        }

        /// <summary>
        /// 记录使用的点
        /// </summary>
        private void RecordUsedPoint(string pointName, string algName, string pinName)
        {
            UsedPointsByFc.TryAdd(pointName, new Dictionary<string, List<string>>());
            if (!UsedPointsByFc[pointName].TryAdd(algName, new List<string> { pinName }))
            {
                UsedPointsByFc[pointName][algName].Add(pinName);
            }
        }

        /// <summary>
        /// 处理计算函数（sum, avg）
        /// </summary>
        private void ProcessCalculationFunction(CldFcblock cldFcblock, string functionExpression,
            FieldInfo curFcBlockInputInfo, Function curFunctionInstance, string functionType)
        {
            try
            {
                // 解析计算函数表达式
                var calculationInfo = ParseCalculationExpression(functionExpression);
                if (!calculationInfo.IsValid)
                {
                    logger.ErrorLog($"计算函数 {functionExpression} 解析失败: {calculationInfo.ErrorMessage}");
                    return;
                }

                // 获取有效的计算点
                List<object> validPoints = GetValidCalculationPoints(cldFcblock, calculationInfo.PointNames,
                    functionExpression, curFcBlockInputInfo.Name);

                if (validPoints.Count == 0)
                {
                    logger.ErrorLog($"计算函数 {functionExpression} 中没有找到有效的LA类型点");
                    return;
                }

                // 创建并设置计算结果
                CalculatedLA calculatedValue = CreateCalculatedLA(validPoints, functionType);
                SetCalculatedValueToField(calculatedValue, curFcBlockInputInfo, curFunctionInstance);

                // 注册计算LA到更新列表
                RegisterCalculatedLA(cldFcblock.AlgName, calculatedValue);
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"处理计算函数 {functionExpression} 时出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 计算表达式信息
        /// </summary>
        private class CalculationExpressionInfo
        {
            public bool IsValid { get; set; }
            public string[] PointNames { get; set; } = Array.Empty<string>();
            public string ErrorMessage { get; set; } = "";
        }

        /// <summary>
        /// 解析计算函数表达式
        /// </summary>
        private CalculationExpressionInfo ParseCalculationExpression(string functionExpression)
        {
            try
            {
                // 提取括号内的点名列表
                int startIndex = functionExpression.IndexOf('(') + 1;
                int endIndex = functionExpression.LastIndexOf(')');

                if (startIndex <= 0 || endIndex <= startIndex)
                {
                    return new CalculationExpressionInfo
                    {
                        IsValid = false,
                        ErrorMessage = "括号格式错误"
                    };
                }

                string pointNamesPart = functionExpression.Substring(startIndex, endIndex - startIndex);
                string[] pointNames = pointNamesPart.Split('+')
                    .Select(p => p.Trim())
                    .Where(p => !string.IsNullOrEmpty(p))
                    .ToArray();

                if (pointNames.Length == 0)
                {
                    return new CalculationExpressionInfo
                    {
                        IsValid = false,
                        ErrorMessage = "没有找到有效的点名"
                    };
                }

                return new CalculationExpressionInfo
                {
                    IsValid = true,
                    PointNames = pointNames
                };
            }
            catch (Exception ex)
            {
                return new CalculationExpressionInfo
                {
                    IsValid = false,
                    ErrorMessage = ex.Message
                };
            }
        }

        /// <summary>
        /// 获取有效的计算点
        /// </summary>
        private List<object> GetValidCalculationPoints(CldFcblock cldFcblock, string[] pointNames,
            string functionExpression, string pinName)
        {
            List<object> validPoints = new List<object>();

            foreach (string pointName in pointNames)
            {
                if (!RTDDict.ContainsKey(pointName))
                {
                    logger.ErrorLog($"点名 {pointName} 在RTDDict中不存在，函数: {functionExpression}");
                    continue;
                }

                AddCommPoints(new List<string> { pointName });
                object pointDetail = GetPointDetail(cldFcblock, pointName);

                if (pointDetail is LA)
                {
                    SetPointConnected(pointDetail);
                    validPoints.Add(pointDetail);
                    RecordUsedPoint(pointName, cldFcblock.AlgName, pinName);
                }
                else
                {
                    logger.ErrorLog($"点名 {pointName} 不是LA类型，无法进行计算，函数: {functionExpression}");
                }
            }

            return validPoints;
        }

        /// <summary>
        /// 设置计算值到字段
        /// </summary>
        private void SetCalculatedValueToField(CalculatedLA calculatedValue, FieldInfo fieldInfo, Function functionInstance)
        {
            if (fieldInfo.FieldType.IsArray)
            {
                // 对于数组类型，将计算结果赋值给数组的第一个元素
                var array = fieldInfo.GetValue(functionInstance) as Array;
                if (array != null && array.Length > 0)
                {
                    array.SetValue(calculatedValue, 0);
                }
            }
            else
            {
                fieldInfo.SetValue(functionInstance, calculatedValue);
            }
        }

        /// <summary>
        /// 注册计算LA到更新列表
        /// </summary>
        private void RegisterCalculatedLA(string algName, CalculatedLA calculatedValue)
        {
            if (!calculatedLAList.ContainsKey(algName))
            {
                calculatedLAList[algName] = new List<CalculatedLA>();
            }
            calculatedLAList[algName].Add(calculatedValue);
        }

        /// <summary>
        /// 创建计算后的LA对象
        /// </summary>
        private CalculatedLA CreateCalculatedLA(List<object> points, string functionType)
        {
            CalculatedLA calculatedLA = new CalculatedLA(points, functionType);
            calculatedLA.Connected = true;
            // 执行初始计算
            calculatedLA.UpdateCalculatedValue();
            return calculatedLA;
        }

        /// <summary>
        /// 处理内部连接
        /// </summary>
        private void ProcessInternalConnection(string pointName, FieldInfo curFcBlockInputInfo, Function curFunctionInstance)
        {
            string[] parts = pointName.Split('.');
            string fromAlgName = parts[0];
            string fromPinName = parts[1];

            if (!FunctionInstanceDict.ContainsKey(fromAlgName))
            {
                logger.ErrorLog($"{fromAlgName}在cld_fcblock表中不存在！");
                return;
            }

            Function fromFcBlockInstance = FunctionInstanceDict[fromAlgName];
            FieldInfo fromFcBlockFieldInfo = fromFcBlockInstance.GetType().GetField(fromPinName);

            if (fromFcBlockFieldInfo == null)
            {
                logger.ErrorLog($"{fromAlgName}块的{fromPinName}管脚不存在！");
                return;
            }

            object pointValue = fromFcBlockFieldInfo.GetValue(fromFcBlockInstance);
            SetPointConnected(pointValue);
            curFcBlockInputInfo.SetValue(curFunctionInstance, pointValue);
        }

        /// <summary>
        /// 处理外部点连接
        /// </summary>
        private void ProcessExternalPointConnection(CldFcblock cldFcblock, string pointName,
            FieldInfo curFcBlockInputInfo, Function curFunctionInstance)
        {
            if (!RTDDict.ContainsKey(pointName))
            {
                logger.ErrorLog($"{pointName}在VarSystem表中不存在！");
                return;
            }

            AddCommPoints(new List<string> { pointName });

            object pointDetail = GetPointDetail(cldFcblock, pointName);
            SetPointConnected(pointDetail);

            // 检查字段类型，如果是数组则需要特殊处理
            if (curFcBlockInputInfo.FieldType.IsArray)
            {
                // 对于数组类型，将单个点赋值给数组的第一个元素
                var array = curFcBlockInputInfo.GetValue(curFunctionInstance) as Array;
                if (array != null && array.Length > 0)
                {
                    array.SetValue(pointDetail, 0);
                }
            }
            else
            {
                curFcBlockInputInfo.SetValue(curFunctionInstance, pointDetail);
            }


            UsedPointsByFc.TryAdd(pointName, new Dictionary<string, List<string>>());
            if (!UsedPointsByFc[pointName].TryAdd(cldFcblock.AlgName, new List<string> { curFcBlockInputInfo.Name }))
            {
                UsedPointsByFc[pointName][cldFcblock.AlgName].Add(curFcBlockInputInfo.Name);
            }
        }

        /// <summary>
        /// 获取点详情
        /// </summary>
        private object GetPointDetail(CldFcblock cldFcblock, string pointName)
        {
            if (!string.IsNullOrEmpty(cldFcblock.InstantInfo) &&
                RTDDict.TryGetValue(pointName, out var warnPointList) &&
                warnPointList.Count > 1)
            {
                return warnPointList.FirstOrDefault(x => ((LAExWarn)x).FcBlockID == cldFcblock.Id);
            }
            else
            {
                List<object> list = RTDDict[pointName];
                return list[0];
            }
        }

        /// <summary>
        /// 设置点的Connected属性为true
        /// </summary>
        private void SetPointConnected(object pointDetail)
        {
            switch (pointDetail)
            {
                case LA la:
                    la.Connected = true;
                    break;
                case LD ld:
                    ld.Connected = true;
                    break;
                case LP32 lp32:
                    lp32.Connected = true;
                    break;
            }
        }


        /// <summary>
        /// 设置默认输入值
        /// </summary>
        private void SetDefaultInputValue(CldFcblock cldFcblock, CldFcinput cldFcinput, FieldInfo curFcBlockInputInfo, Function curFunctionInstance)
        {
            if (string.IsNullOrEmpty(cldFcinput.InitialValue))
                return;

            object obj = curFcBlockInputInfo.GetValue(curFunctionInstance);

            switch (obj)
            {
                case LA:
                    curFcBlockInputInfo.SetValue(curFunctionInstance,
                        new LA(QualityTypes.Good, false, false, false, false, false,
                               float.MaxValue, float.MinValue, 0.0f, 0, Convert.ToSingle(cldFcinput.InitialValue)));
                    break;
                case LD:
                    SetLDDefaultValue(cldFcblock, cldFcinput, curFcBlockInputInfo, curFunctionInstance);
                    break;
            }
        }

        /// <summary>
        /// 设置LD默认值
        /// </summary>
        private void SetLDDefaultValue(CldFcblock cldFcblock, CldFcinput cldFcinput, FieldInfo curFcBlockInputInfo, Function curFunctionInstance)
        {
            if (float.TryParse(cldFcinput.InitialValue, out float fv))
            {
                curFcBlockInputInfo.SetValue(curFunctionInstance,
                    new LD(QualityTypes.Good, false, false, false, 0, fv > 0));
            }
            else if (bool.TryParse(cldFcinput.InitialValue, out bool bv))
            {
                curFcBlockInputInfo.SetValue(curFunctionInstance,
                    new LD(QualityTypes.Good, false, false, false, 0, bv));
            }
            else
            {
                logger.ErrorLog($"LD输入管脚的初始值错误：{cldFcblock.AlgName}.{cldFcinput.PinName}={cldFcinput.InitialValue}");
            }
        }

        #endregion
    }
}
