using DBServer.LogServer;
using EngineCore;
using EngineCore.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Emit;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace TDServer.Service
{
    public class FcInfo
    {
        /// <summary>
        /// 功能码名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 功能码代码
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 功能码类型
        /// </summary>
        public FcType Type { get; set; }
    }

    public enum FcType
    {
        /// <summary>
        /// 故障诊断
        /// </summary>
        FaultDiagnosis,

        /// <summary>
        /// 预警诊断
        /// </summary>
        WarnDiagnosis
    }

    public class EInfo
    {
        public string InstantName { get; set; }
        public bool CurValue { get; set; }
    }

    public class WarnDiagnosisInfo
    {
        public int SysID { get; set; }
        public string ModelInfo { get; set; }
    }

    public class ForcePointInfo
    {
        /// <summary>
        /// 点名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 是否强制
        /// </summary>
        public byte IsForce { get; set; } = 0;

    }


    public class DynamicCompileFC
    {
        private static LoggerService<DynamicCompileFC> logger = new LoggerService<DynamicCompileFC>();
        public class InstantObject
        {
            public string name;
            public string[] inputInfo;
            public int interval;
            public string modelId;
            public string model_state;
            public string id;
            public int visible;
            public int status;
            public int isStore;
            public string[] outPointInfo;
            public string[] biasPointInfo;
            public string[] faultVariablePointInfo;
            public bool?[] type;
            public string Model_Status;
            public string version;
        }

        private class ModelInfo
        {
            public string id { get; set; }
            //public para para { get; set; }

            public string version { get; set; }

            public string name { get; set; }

            public string algorithm { get; set; }

            public List<PointInfoItem> pointInfo { get; set; }

            public alarmmodelset alarmmodelset { get; set; }
        }
        private class para
        {
            public List<List<object>> weight { get; set; }

            public double limit { get; set; }
        }

        private class PointInfoItem
        {
            public bool? type { get; set; }

            public double? TMax { get; set; }

            public double? TMin { get; set; }

            public double? C95 { get; set; }

            public string PointId { get; set; }

            public string Description { get; set; }
        }

        private class alarmmodelset
        {
            public string alarmname { get; set; }

            public string alarmcondition { get; set; }
        }

        public static (bool Success, string ErrorMessage) BatchCompiler(int? metaFcMasterID)
        {
            return BatchCompilerInternal(warnContext =>
                metaFcMasterID == null
                    ? warnContext.MetaFcmasters.Where(x => x.Type == "AIModel").ToList()
                    : warnContext.MetaFcmasters.Where(x => x.Id == metaFcMasterID && x.Type == "AIModel").ToList()
            );
        }

        public static (bool Success, string ErrorMessage) BatchCompiler(string? modelName)
        {
            return BatchCompilerInternal(warnContext =>
                modelName == null
                    ? warnContext.MetaFcmasters.Where(x => x.Type == "AIModel").ToList()
                    : warnContext.MetaFcmasters.Where(x => x.FunctionName == modelName && x.Type == "AIModel").ToList()
            );
        }

        private static (bool Success, string ErrorMessage) BatchCompilerInternal(Func<WarnContext, List<MetaFcmaster>> getMetaFcmasters)
        {
            using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
            {
                try
                {
                    var metaFcmasters = getMetaFcmasters(warnContext);

                    if (metaFcmasters.Count == 0)
                    {
                        return (false, "未找到符合条件的模型数据");
                    }

                    // 添加错误收集器和成功计数器
                    var errorList = new List<string>();
                    int successCount = 0;
                    int totalCount = metaFcmasters.Count;

                    foreach (var fcmaster in metaFcmasters)
                    {
                        var warnDiagnosisInfo = new WarnDiagnosisInfo
                        {
                            SysID = fcmaster.PrjSystemId.Value,
                            ModelInfo = fcmaster.ModelInfo
                        };

                        // 修改1：ModelInfo 为空时记录错误并继续
                        if (string.IsNullOrEmpty(warnDiagnosisInfo.ModelInfo))
                        {
                            string error = $"模型 {fcmaster.FunctionName} 的 ModelInfo 为空";
                            logger.ErrorLog(error);
                            errorList.Add(error);
                            continue;
                        }

                        logger.InfoLog("ModelInfo：" + warnDiagnosisInfo.ModelInfo);
                        var fcInfo = DynamicCompileFC.CreateFcInfo(warnDiagnosisInfo);

                        // 修改2：创建功能码失败时记录错误并继续
                        if (fcInfo == null)
                        {
                            string error = $"模型 {fcmaster.FunctionName} 创建功能码信息失败";
                            logger.ErrorLog(error);
                            errorList.Add(error);
                            continue;
                        }

                        var (success, errorMessage) = DynamicCompileFC.Compiler(fcInfo);
                        if (success)
                        {
                            logger.InfoLog($"{fcInfo.Name}动态编译成功！");
                            successCount++;
                        }
                        else
                        {
                            // 修改3：编译失败时记录错误并继续，不再立即返回
                            string detailedError = $"模型 {fcInfo.Name} 动态编译失败！错误信息: {errorMessage}";
                            logger.ErrorLog(detailedError);
                            errorList.Add(detailedError);
                        }
                    }

                    // 修改4：循环结束后统一处理返回结果
                    if (errorList.Count == 0)
                    {
                        // 全部成功
                        return (true, string.Empty);
                    }
                    else
                    {
                        // 有失败的情况，返回详细错误信息
                        var errorSummary = new StringBuilder();
                        errorSummary.AppendLine($"批量编译完成：成功 {successCount} 个，失败 {errorList.Count} 个（共 {totalCount} 个）");
                        errorSummary.AppendLine("失败详情：");
                        for (int i = 0; i < errorList.Count; i++)
                        {
                            errorSummary.AppendLine($"{i + 1}. {errorList[i]}");
                        }

                        string finalError = errorSummary.ToString();
                        logger.ErrorLog(finalError);
                        return (false, finalError);
                    }
                }
                catch (Exception ex)
                {
                    string errorMessage = $"批量编译过程中发生异常: {ex.Message}";
                    logger.ErrorLog("BatchCreate：" + ex.Message);
                    return (false, errorMessage);
                }
            }
        }





        public static FcInfo CreateFcInfo(WarnDiagnosisInfo warnDiagnosisInfo)
        {
            try
            {
                string dir = AppDomain.CurrentDomain.BaseDirectory + "WarnDiagnosisLib";
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }

                ModelInfo modelInfo = JsonConvert.DeserializeObject<ModelInfo>(warnDiagnosisInfo.ModelInfo);

                string jsonModelInfo = warnDiagnosisInfo.ModelInfo;
                int sysID = warnDiagnosisInfo.SysID;
                string modelid = modelInfo.id;
                string version = modelInfo.version;
                string strSetOutputValue = "";
                string strFCCode = "";
                string Test_Data = "";
                string Target_Data = "";
                string strDiagnosisData = "";
                string algorithmName = modelInfo.algorithm;
                string alarmcondition = "";
                string alarmName = "";
                string fcName = modelInfo.name;
                string fstr = "";
                string istr = "";
                int outPinCount = 0;
                string delayOutputValue = "";
                string strIN = "";
                string strOUT_B = "";
                string strOUT_W = "";

                MatchCollection matchCollection = null;
                //获取报警条件点
                if (modelInfo.alarmmodelset != null)
                {
                    alarmcondition = modelInfo.alarmmodelset.alarmcondition;

                    if (!string.IsNullOrEmpty(alarmcondition))
                    {
                        alarmcondition = alarmcondition.Replace("\\n", "").Replace("\t", "");
                        alarmName = modelInfo.alarmmodelset.alarmname;
                        if (!string.IsNullOrEmpty(alarmcondition))
                        {
                            Regex r = new Regex(@"\[(.*?)\]");
                            matchCollection = r.Matches(alarmcondition);
                        }
                    }
                }

                string InputPins = "";
                string delayRunStr = $"\n\t\t\tfor (int i = 0; i < arrOUT_B.Length; i++)" +
                        $"\n\t\t\t{{" +
                        $"\n\t\t\t\tif (!arrIN[i].Runable || arrIN[i].AlarmType != 0 || arrIN[i].HasConstraint)" +
                        $"\n\t\t\t\t{{" +
                        $"\n\t\t\t\t\tarrOUT_W[i].buffer = false;" +
                        $"\n\t\t\t\t\tOldTempOUT_W[i] = false;" +
                        $"\n\t\t\t\t\tStartTime[i] = -1;" +
                        $"\n\t\t\t\t\tcontinue;" +
                        $"\n\t\t\t\t}}" +
                        $"\n\t\t\t\tif (arrOUT_B[i] > arrIN[i].WarnUpLimit)" +
                        $"\n\t\t\t\t{{" +
                        $"\n\t\t\t\t\tTempOUT_W[i] = true;" +
                        $"\n\t\t\t\t\tarrIN[i].LimitAlarmType = 1;" +
                        $"\n\t\t\t\t}}" +
                        $"\n\t\t\t\telse if (arrOUT_B[i] < arrIN[i].WarnLowLimit)" +
                        $"\n\t\t\t\t{{" +
                        $"\n\t\t\t\t\tTempOUT_W[i] = true;" +
                        $"\n\t\t\t\t\tarrIN[i].LimitAlarmType = 4;" +
                        $"\n\t\t\t\t}}" +
                        $"\n\t\t\t\telse" +
                        $"\n\t\t\t\t{{" +
                        $"\n\t\t\t\t\tTempOUT_W[i] = false;" +
                        $"\n\t\t\t\t}}" +
                        $"\n\t\t\t\tif (TempOUT_W[i])" +
                        $"\n\t\t\t\t{{" +
                        $"\n\t\t\t\t\tif (!OldTempOUT_W[i] && TempOUT_W[i])" +
                        $"\n\t\t\t\t\t{{" +
                        $"\n\t\t\t\t\t\tStartTime[i] = DateTimeOffset.Now.ToUnixTimeMilliseconds();" +
                        $"\n\t\t\t\t\t}}" +
                        $"\n\t\t\t\t\tif (StartTime[i] >= 0 && DateTimeOffset.Now.ToUnixTimeMilliseconds() >= StartTime[i] + arrIN[i].DelayTime * 1000)" +
                        $"\n\t\t\t\t\t{{" +
                        $"\n\t\t\t\t\t\tarrIN[i].SetModelAlarmStartTime(DateTimeOffset.FromUnixTimeMilliseconds(StartTime[i]).LocalDateTime);" +
                        $"\n\t\t\t\t\t\tarrOUT_W[i].buffer = true;" +
                        $"\n\t\t\t\t\t\tUnAck = true;" +
                        $"\n\t\t\t\t\t\tarrIN[i].active = true;" +
                        $"\n\t\t\t\t\t\tarrIN[i].unAck = true;" +
                        $"\n\t\t\t\t\t\tStartTime[i] = -1;" +
                        $"\n\t\t\t\t\t}}" +
                        $"\n\t\t\t\t}}" +
                        $"\n\t\t\t\telse" +
                        $"\n\t\t\t\t{{" +
                        $"\n\t\t\t\t\tarrIN[i].active = false;" +
                        $"\n\t\t\t\t\tarrOUT_W[i].buffer = false;" +
                        $"\n\t\t\t\t\tStartTime[i] = -1;" +
                        $"\n\t\t\t\t}}" +
                        $"\n\t\t\t\tOldTempOUT_W[i] = TempOUT_W[i];" +
                        $"\n\t\t\t}}";

                if (algorithmName == "PCA")
                {
                    outPinCount = modelInfo.pointInfo.Count;
                    for (int i = 0; i < modelInfo.pointInfo.Count; i++)
                    {
                        Test_Data += "\"" + $" + IN{i + 1}.buffer.ToString(System.Globalization.CultureInfo.InvariantCulture) + " + "\"" + ",";
                    }

                    for (int i = 0; i < modelInfo.pointInfo.Count; i++)
                    {

                        strSetOutputValue += $"OUT_R{i + 1}[0] = reconData[0][{i}];\n	        ";
                        strSetOutputValue += $"OUT_B{i + 1}[0] = errorData[0][{i}];\n	        ";
                        strSetOutputValue += $"OUT_F{i + 1}[0] = paraState[0][{i}];\n	        ";
                        strIN += $"IN{i + 1},";
                        strOUT_B += $"OUT_B{i + 1},";
                        strOUT_W += $"OUT_W{i + 1},";
                        //strHighLimit += $"IN{i + 1}.WarnHighLimit,";
                        //strLowLimit += $"IN{i + 1}.WarnLowLimit,";
                        //strDelayTime += $"IN{i + 1}.DelayTime,";


                        InputPins += "	    [PinType(PinTypes.Output)]\n";
                        InputPins += $"	    [PinDisplay(\"重构输出{i + 1}\")]\n";
                        InputPins += $"	    public LA OUT_R{i + 1} = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                        InputPins += "	    [PinType(PinTypes.Output)]\n";
                        InputPins += $"	    [PinDisplay(\"残差输出{i + 1}\")]\n";
                        InputPins += $"	    public LA OUT_B{i + 1} = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                        InputPins += "	    [PinType(PinTypes.Output)]\n";
                        InputPins += $"	    [PinDisplay(\"故障输出{i + 1}\")]\n";
                        InputPins += $"	    public LD OUT_F{i + 1} = new LD(QualityTypes.Good, false, false, false, 0, false);\n\n";

                        InputPins += "	    [PinType(PinTypes.Output)]\n";
                        InputPins += $"	    [PinDisplay(\"故障输出{i + 1}\")]\n";
                        InputPins += $"	    public LD OUT_W{i + 1} = new LD(QualityTypes.Good, false, false, false, 0, false);\n\n";
                    }

                    strDiagnosisData += $"string jsonResult = {algorithmName}.Diagnosis(ModelInfo, InputInfo, 1, 1);\n";
                    strDiagnosisData += $"\t\t\tif (string.IsNullOrEmpty(jsonResult)) {{ throw new InvalidOperationException(\"PCA诊断失败，模型：{fcName}\"); }}\n";
                    strDiagnosisData += $"\t\t\tPCA.Output_Info diagnosisResult = PCA.GetOutputInfo(jsonResult);\n";

                    strSetOutputValue += "OUT_ste[0] = index[0];\n";
                    delayOutputValue += $"\t\t\tLAExWarn[] arrIN = new LAExWarn[{modelInfo.pointInfo.Count}] {{{strIN.TrimEnd(',')}}};\n";
                    delayOutputValue += $"\t\t\tfloat[] arrOUT_B = new float[{modelInfo.pointInfo.Count}] {{{strOUT_B.TrimEnd(',')}}};\n";


                    delayOutputValue += $"\t\t\tLD[] arrOUT_W = new LD[{modelInfo.pointInfo.Count}] {{ {strOUT_W.TrimEnd(',')} }};\n\t\t\t";

                    //delayOutputValue += delayRunStr;
                }
                else if (algorithmName == "ANN")
                {
                    int index = 0;
                    for (int i = 0; i < modelInfo.pointInfo.Count; i++)
                    {
                        bool? type = modelInfo.pointInfo[i].type;
                        string data = "\"" + $" + IN{i + 1} + " + "\"";
                        if (type != null && type == true)
                        {
                            index = i + 1;
                            //strSetOutputValue += $"OUT_R{index}[0] = reconData[0][0];\n	        ";
                            //strSetOutputValue += $"OUT_B{index}[0] = errorData[0][0];\n	        ";
                            //strSetOutputValue += $"OUT_F{index}[0] = paraState[0][0];\n	        ";
                            strSetOutputValue += $"OUT_R1[0] = reconData[0][0];\n	        ";
                            strSetOutputValue += $"OUT_B1[0] = errorData[0][0];\n	        ";
                            strSetOutputValue += $"OUT_F1[0] = paraState[0][0];\n	        ";
                            strIN += $"IN{i + 1},";
                            strOUT_B += $"OUT_B1,";
                            strOUT_W += $"OUT_W1,";

                            //strOUT_B += $"OUT_B{index},";
                            //strOUT_W += $"OUT_W{index},";


                            //strHighLimit += $"IN{index}.WarnHighLimit,";
                            //strLowLimit += $"IN{index}.WarnLowLimit,";
                            //strDelayTime += $"IN{index}.DelayTime,";


                            outPinCount++;
                            Target_Data += data + ",";


                            //InputPins += "	    [PinType(PinTypes.Output)]\n";
                            //InputPins += $"	    [PinDisplay(\"重构输出{index}\")]\n";
                            //InputPins += $"	    public LA OUT_R{index} = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                            //InputPins += "	    [PinType(PinTypes.Output)]\n";
                            //InputPins += $"	    [PinDisplay(\"残差输出{index}\")]\n";
                            //InputPins += $"	    public LA OUT_B{index} = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                            //InputPins += "	    [PinType(PinTypes.Output)]\n";
                            //InputPins += $"	    [PinDisplay(\"故障输出{index}\")]\n";
                            //InputPins += $"	    public LD OUT_F{index} = new LD(QualityTypes.Good, false, false, false, 0, false);\n\n";

                            //InputPins += "	    [PinType(PinTypes.Output)]\n";
                            //InputPins += $"	    [PinDisplay(\"故障输出{index}\")]\n";
                            //InputPins += $"	    public LD OUT_W{index} = new LD(QualityTypes.Good, false, false, false, 0, false);\n\n";

                            InputPins += "	    [PinType(PinTypes.Output)]\n";
                            InputPins += $"	    [PinDisplay(\"重构输出{index}\")]\n";
                            InputPins += $"	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                            InputPins += "	    [PinType(PinTypes.Output)]\n";
                            InputPins += $"	    [PinDisplay(\"残差输出{index}\")]\n";
                            InputPins += $"	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                            InputPins += "	    [PinType(PinTypes.Output)]\n";
                            InputPins += $"	    [PinDisplay(\"故障输出{index}\")]\n";
                            InputPins += $"	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);\n\n";

                            InputPins += "	    [PinType(PinTypes.Output)]\n";
                            InputPins += $"	    [PinDisplay(\"故障输出{index}\")]\n";
                            InputPins += $"	    public LD OUT_W1 = new LD(QualityTypes.Good, false, false, false, 0, false);\n\n";
                        }
                        else
                        {
                            Test_Data += data + ",";
                        }
                    }

                    strDiagnosisData += $"string jsonResult = {algorithmName}.Diagnosis(ModelInfo, InputInfo);\n";
                    strDiagnosisData += $"\t\t\tif (string.IsNullOrEmpty(jsonResult)) {{ return; }}\n";

                    strSetOutputValue += "OUT_ste[0] = index[0];\n";

                    delayOutputValue += $"\t\t\tLAExWarn[] arrIN = new LAExWarn[{outPinCount}] {{{strIN.TrimEnd(',')}}};\n";
                    delayOutputValue += $"\t\t\tfloat[] arrOUT_B = new float[{outPinCount}] {{{strOUT_B.TrimEnd(',')}}};\n";
                    delayOutputValue += $"\t\t\tLD[] arrOUT_W = new LD[{outPinCount}] {{ {strOUT_W.TrimEnd(',')} }};\n\t\t\t";


                    //delayOutputValue += delayRunStr;
                }

                Test_Data = Test_Data.TrimEnd(',');
                Target_Data = Target_Data.TrimEnd(',');

                if (algorithmName == "PCA")
                {
                    strDiagnosisData += $"	        float[][] reconData = diagnosisResult.reconData;\n";
                    strDiagnosisData += $"	        float[][] errorData = diagnosisResult.errorData;\n";
                    strDiagnosisData += $"	        float[][] paraState = diagnosisResult.paraState;\n";
                    strDiagnosisData += $"	        float[] index = diagnosisResult.Index;\n";
                }
                else
                {
                    strDiagnosisData += $"	        float[][] reconData = {algorithmName}.OutputInfo.reconData;\n";
                    strDiagnosisData += $"	        float[][] errorData = {algorithmName}.OutputInfo.errorData;\n";
                    strDiagnosisData += $"	        float[][] paraState = {algorithmName}.OutputInfo.paraState;\n";
                    strDiagnosisData += $"	        float[] index = {algorithmName}.OutputInfo.Index;\n";
                }

                strFCCode += "using System;\n";
                strFCCode += "using System.Reflection;\n";
                strFCCode += "using POWERSISAI;\n";
                strFCCode += "using DCSCommon;\n";
                strFCCode += "using DCSType;\n";
                strFCCode += "using TDServer.Service;\n";
                strFCCode += "using System.Runtime.InteropServices;\n\n";
                strFCCode += "namespace FunctionCode\n";
                strFCCode += "{\n";
                strFCCode += "    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]\n";
                strFCCode += $"    [FCName(\"{fcName}\")]\n";
                strFCCode += $"    [FCDisplay(\"{modelInfo.name}\")]\n";
                strFCCode += $"    public partial class {fcName} : WarnFunction\n";
                strFCCode += "    {\n";

                //生成报警条件对应的管脚及运行代码
                string strCondition = "";
                if (matchCollection != null && matchCollection.Count > 0)
                {
                    for (int i = 0; i < matchCollection.Count; i++)
                    {
                        strFCCode += "	    [PinType(PinTypes.Input)]\n";
                        strFCCode += $"	    [PinDisplay(\"{alarmName}\")]\n";
                        strFCCode += $"	    public LA Condition{i + 1} = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                        alarmcondition = alarmcondition.Replace(matchCollection[i].ToString(), $"Condition{i + 1}");
                    }

                    if (!string.IsNullOrEmpty(alarmcondition))
                    {
                        alarmcondition = alarmcondition.Replace("and", "&").Replace("or", "|");
                        alarmcondition = $"({alarmcondition})";
                        //strCondition = $"if (!{alarmcondition}) return;\n\n";

                        //
                        strCondition += $"if (!{alarmcondition})\n";
                        strCondition += "\t\t\t{\n";
                        strCondition += "\t\t\t\tfor (int i = 0; i < arrIN.Length; i++)\n";
                        strCondition += "\t\t\t\t{\n";
                        strCondition += "\t\t\t\t\tStartTime[i] = -1;\n";
                        strCondition += "\t\t\t\t\tarrIN[i].active = false;\n";
                        strCondition += "\t\t\t\t\tarrOUT_W[i].buffer = false;\n";
                        strCondition += "\t\t\t\t\tOldTempOUT_W[i] = false;\n";
                        strCondition += "\t\t\t\t}\n";
                        strCondition += "\t\t\t\treturn;\n";
                        strCondition += "\t\t\t}\n\n";
                    }
                }

                //生成输入管脚
                for (int i = 0; i < modelInfo.pointInfo.Count; i++)
                {
                    strFCCode += "	    [PinType(PinTypes.Input)]\n";
                    strFCCode += $"	    [PinDisplay(\"{modelInfo.pointInfo[i].Description}\")]\n";
                    strFCCode += $"	    public LAExWarn IN{i + 1} = new LAExWarn(QualityTypes.Good,false,\"\",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";
                }

                //生成输出管脚
                if (outPinCount > 0)
                {
                    strFCCode += InputPins;
                    for (int i = 0; i < outPinCount; i++)
                    {
                        fstr += "false,";
                        istr += "-1,";
                    }

                    strFCCode += "	    [PinType(PinTypes.Output)]\n";
                    strFCCode += "	    [PinDisplay(\"\")]\n";
                    strFCCode += "	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);\n\n";

                    strFCCode += "	    [PinType(PinTypes.Constant)]\n";
                    strFCCode += $"	    [PinDisplay(\"\")]\n";
                    strFCCode += $"	    public bool[] TempOUT_W = new bool[{outPinCount}] {{{fstr.TrimEnd(',')}}};\n\n";

                    strFCCode += "	    [PinType(PinTypes.Constant)]\n";
                    strFCCode += $"	    [PinDisplay(\"\")]\n";
                    strFCCode += $"	    public bool[] OldTempOUT_W = new bool[{outPinCount}] {{{fstr.TrimEnd(',')}}};\n\n";

                    //strFCCode += "	    [PinType(PinTypes.Constant)]\n";
                    //strFCCode += $"	    [PinDisplay(\"\")]\n";
                    //strFCCode += $"	    public int DelayTime = 10;\n\n";

                    strFCCode += "	    [PinType(PinTypes.Constant)]\n";
                    strFCCode += $"	    [PinDisplay(\"\")]\n";
                    strFCCode += $"	    public long[] StartTime = new long[{outPinCount}] {{{istr.TrimEnd(',')}}};\n\n";
                }

                strFCCode += $"\t\tpublic {fcName}()\n" +
                                $"\t\t{{\n" +
                                $"\t\t\tModelID = {modelid};\n" +
                                $"\t\t\tSysID = {sysID};\n" +
                                $"\t\t\tFcType = enumType.Warn;\n" +
                                $"\t\t\tFcName = \"{fcName}\";\n" +
                                $"\t\t\tFcCode = \"{algorithmName}\";\n" +
                                $"\t\t}}\n\n";

                strFCCode += "	    protected override void Run(ICommand cmd)\n";
                strFCCode += "	    {\n";

                strFCCode += "	        string ModelInfo = @\"" + jsonModelInfo.Replace("\"", "\"\"") + "\";\n";
                strFCCode += "	        string InputInfo = @\"{\"\"Model_id\"\":" + modelid + ",\"\"version\"\":\"\"" + version + "\"\",\"\"Test_Data\"\":[[" + Test_Data + "]],\\\"Target_Data\\\":[[" + Target_Data + "]]}\";\n";
                strFCCode += $"	        {strDiagnosisData}\n";
                strFCCode += $"	        {strSetOutputValue}\n";
                strFCCode += $"{delayOutputValue}\n";


                strFCCode += $"	        {strCondition}";
                strFCCode += $"{delayRunStr}";

                strFCCode += $"\n\t\t\tWarnActive = false;\n";

                strFCCode += $"\t\t\tfor (int i = 0; i < arrOUT_W.Length; i++)" +
                    $"\n\t\t\t{{" +
                    $"\n\t\t\t\tWarnActive |= arrOUT_W[i].buffer;" +
                    $"\n\t\t\t}}\n" +
                    $"\n\t\t\tif (!WarnActive && !UnAck)" +
                    $"\n\t\t\t{{" +
                    $"\n\t\t\t\tWarnState = 1;" +
                    $"\n\t\t\t}}" +
                    $"\n\t\t\telse if (!WarnActive && UnAck) " +
                    $"\n\t\t\t{{" +
                    $"\n\t\t\t\tWarnState = 2; " +
                    $"\n\t\t\t}}" +
                    $"\n\t\t\telse if (WarnActive && !UnAck) " +
                    $"\n\t\t\t{{" +
                    $"\n\t\t\t\tWarnState = 4; " +
                    $"\n\t\t\t}}" +
                    $"\n\t\t\telse if (WarnActive && UnAck) " +
                    $"\n\t\t\t{{" +
                    $"\n\t\t\t\tWarnState = 8; " +
                    $"\n\t\t\t}}\n";

                strFCCode += "	    }\n";
                strFCCode += "    }\n";
                strFCCode += "}";


                return new FcInfo() { Name = fcName, Code = strFCCode, Type = FcType.WarnDiagnosis };
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message);
                return null;
            }
        }


        public static (bool Success, string ErrorMessage) Compiler(FcInfo fcInfo)
        {
            try
            {
                string strCSFilePath = "";
                string strCsDir = Path.GetDirectoryName("./");
                string strTempDir = "";
                if (fcInfo.Type == FcType.FaultDiagnosis)
                {
                    strTempDir = Path.Combine(strCsDir, "DynamicCompileFcLib", "FaultDiagnosis");
                }
                else if (fcInfo.Type == FcType.WarnDiagnosis)
                {
                    strTempDir = Path.Combine(strCsDir, "DynamicCompileFcLib", "WarnDiagnosis");
                }

                if (!Directory.Exists(strTempDir))
                    Directory.CreateDirectory(strTempDir);
                //string strOutput = Path.GetRandomFileName();//随机文件名
                string fcName = fcInfo.Name;


                string path = strTempDir + "\\" + fcName + ".cs";
                var fi = new FileInfo(path);
                // 创建写入文件
                using (StreamWriter sw = fi.CreateText())
                {
                    sw.Write(fcInfo.Code);
                }

                string strCompiledFile = Path.Combine(strTempDir, fcName + ".dll");
                string strPdbFile = Path.Combine(strTempDir, fcName + ".pdb");

                StringBuilder asmInfo = new StringBuilder();

                //生成版本信息
                asmInfo.AppendLine("using System.Reflection;");
                asmInfo.AppendLine($"[assembly: AssemblyTitle(\"{fcName}\")]");
                asmInfo.AppendLine("[assembly: AssemblyVersion(\"1.0.0.0\")]");
                asmInfo.AppendLine("[assembly: AssemblyFileVersion(\"1.0.0.0\")]");
                // Product Info
                asmInfo.AppendLine($"[assembly: AssemblyProduct(\"{fcName}\")]");
                asmInfo.AppendLine("[assembly: AssemblyInformationalVersion(\"1.0.0.0\")]");

                var VerInfoSyntaxTree = CSharpSyntaxTree.ParseText(asmInfo.ToString(), CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp8));

                //string strCode = File.ReadAllText(strCSFilePath);
                //LanguageVersion 需要一致
                var parsedSyntaxTree = CSharpSyntaxTree.ParseText(fcInfo.Code, CSharpParseOptions.Default.WithLanguageVersion(LanguageVersion.CSharp8), strCSFilePath, Encoding.UTF8);//调试源码path需指定encoding
                CSharpCompilationOptions defaultCompilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithOptimizationLevel(OptimizationLevel.Release).WithPlatform(Platform.AnyCpu);
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    //生成调试信息
                    defaultCompilationOptions = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary).WithOptimizationLevel(OptimizationLevel.Debug).WithPlatform(Platform.AnyCpu);

                }

                var assemblyPath = Path.GetDirectoryName(typeof(object).Assembly.Location);
                //dll引用,动态库需要就引入，不需要的可以省略
                IEnumerable<MetadataReference> DefaultReferences =
                    new[]
                    {
                    MetadataReference.CreateFromFile(typeof(object).Assembly.Location),//mscorlib.dll
                    MetadataReference.CreateFromFile(typeof(Uri).Assembly.Location),//System.dll
                    MetadataReference.CreateFromFile(typeof(Enumerable).Assembly.Location),//System.Core.dll
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Collections.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Data.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Linq.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Xml.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.IO.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "Microsoft.CSharp.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Runtime.Serialization.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Dynamic.Runtime.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(assemblyPath, "System.Reflection.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DCSCommon.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DCSType.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TDServer.Service.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "POWERSISAI.dll")),
                    MetadataReference.CreateFromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FunctionCode.dll"))
                    };

                var compilation = CSharpCompilation.Create(fcName, new SyntaxTree[] { VerInfoSyntaxTree, parsedSyntaxTree }, DefaultReferences, defaultCompilationOptions);
                var dllms = new MemoryStream();

                MemoryStream pdbms = null;//pdb文件
                EmitOptions emitOptions = null;
                if (System.Diagnostics.Debugger.IsAttached)
                {
                    pdbms = new MemoryStream();
                    emitOptions = new EmitOptions(debugInformationFormat: DebugInformationFormat.PortablePdb, pdbFilePath: strPdbFile);
                }
                var EmitRet = compilation.Emit(dllms, pdbStream: pdbms, options: emitOptions);

                if (EmitRet.Success)
                {
                    //输出类库
                    using (var file = new FileStream(strCompiledFile, FileMode.Create))
                    {
                        dllms.Seek(0, SeekOrigin.Begin);
                        dllms.WriteTo(file);
                        file.Close();
                    }

                    ////输出pdb文件
                    //if (pdbms != null)
                    //{
                    //    using (var filePdb = new System.IO.FileStream(strPdbFile, System.IO.FileMode.Create))
                    //    {
                    //        pdbms.Seek(0, System.IO.SeekOrigin.Begin);
                    //        pdbms.WriteTo(filePdb);
                    //        filePdb.Close();
                    //    }
                    //}
                    return (true, string.Empty);
                }
                else
                {
                    string error = "编译失败";
                    if (EmitRet.Diagnostics != null)
                    {
                        var errorMessages = new StringBuilder();
                        for (int i = 0; i < EmitRet.Diagnostics.Length; i++)
                        {
                            errorMessages.AppendLine(EmitRet.Diagnostics[i].ToString());
                        }
                        error = errorMessages.ToString();
                        logger.ErrorLog(error);
                    }
                    return (false, error);
                }
            }
            catch (Exception ex)
            {
                string errorMessage = $"编译过程中发生异常: {ex.Message}";
                logger.ErrorLog(errorMessage);
                return (false, errorMessage);
            }
        }


        //public static bool Compiler(CodeDomProvider codeDomProvider, string source, string[] referencedAssemblies, string output)
        //{
        //    try
        //    {
        //        var compilerOptions = $"/target:library /platform:x86 /optimize+";
        //        var compilerParameters = new CompilerParameters(referencedAssemblies)
        //        {
        //            GenerateExecutable = true,
        //            GenerateInMemory = false,
        //            CompilerOptions = compilerOptions,
        //            TreatWarningsAsErrors = false,
        //            IncludeDebugInformation = false,
        //            OutputAssembly = output,
        //        };
        //        var compilerResults = codeDomProvider.CompileAssemblyFromSource(compilerParameters, source);

        //        if (compilerResults.Errors.Count > 0)
        //        {
        //            foreach (CompilerError compilerError in compilerResults.Errors)
        //            {
        //                //throw new Exception(string.Format("{0}\nLine: {1}", compilerError.ErrorText, compilerError.Line));
        //            }
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.Message);
        //    }
        //}
    }

    /// <summary>
    /// 使用示例：展示如何使用改造后的BatchCompiler函数
    /// </summary>
    public static class BatchCompilerUsageExample
    {
        public static void ExampleUsage()
        {
            // 按模型ID编译的示例
            var (success1, errorMessage1) = DynamicCompileFC.BatchCompiler(123);
            if (success1)
            {
                Console.WriteLine("按模型ID批量编译成功！");
            }
            else
            {
                Console.WriteLine($"按模型ID批量编译失败：{errorMessage1}");
            }

            // 按模型名称编译的示例
            var (success2, errorMessage2) = DynamicCompileFC.BatchCompiler("MyModel");
            if (success2)
            {
                Console.WriteLine("按模型名称批量编译成功！");
            }
            else
            {
                Console.WriteLine($"按模型名称批量编译失败：{errorMessage2}");
            }

            // 编译所有模型的示例
            var (success3, errorMessage3) = DynamicCompileFC.BatchCompiler((int?)null);
            if (success3)
            {
                Console.WriteLine("编译所有模型成功！");
            }
            else
            {
                Console.WriteLine($"编译所有模型失败：{errorMessage3}");
            }
        }
    }
}
