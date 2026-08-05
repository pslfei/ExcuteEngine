using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA409")]
    [FCDisplay("PCA409")]
    public partial class PCA409 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于400")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽封供汽阀前汽封蒸汽温度#1(20)")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽封供汽阀前汽封蒸汽温度#2(20)")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽封蒸汽集管中温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽封蒸汽集管前温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("高压轴封漏汽管温度")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("门杆漏汽母管温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("U型密封环漏汽温度")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中压缸U型密封环漏汽温度")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出1")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出1")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出1")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出1")]
	    public LD OUT_W1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出2")]
	    public LA OUT_R2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出2")]
	    public LA OUT_B2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出2")]
	    public LD OUT_F2 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出2")]
	    public LD OUT_W2 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出3")]
	    public LA OUT_R3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出3")]
	    public LA OUT_B3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出3")]
	    public LD OUT_F3 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出3")]
	    public LD OUT_W3 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出4")]
	    public LA OUT_R4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出4")]
	    public LA OUT_B4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出4")]
	    public LD OUT_F4 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出4")]
	    public LD OUT_W4 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出5")]
	    public LA OUT_R5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出5")]
	    public LA OUT_B5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出5")]
	    public LD OUT_F5 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出5")]
	    public LD OUT_W5 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出6")]
	    public LA OUT_R6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出6")]
	    public LA OUT_B6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出6")]
	    public LD OUT_F6 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出6")]
	    public LD OUT_W6 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出7")]
	    public LA OUT_R7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出7")]
	    public LA OUT_B7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出7")]
	    public LD OUT_F7 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出7")]
	    public LD OUT_W7 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出8")]
	    public LA OUT_R8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出8")]
	    public LA OUT_B8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出8")]
	    public LD OUT_F8 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出8")]
	    public LD OUT_W8 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[8] {false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[8] {false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[8] {-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA409()
		{
			ModelID = 450;
			SysID = 17;
			FcType = enumType.Warn;
			FcName = "PCA409";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""450"",""name"":""PCA409"",""description"":""轴封系统温度"",""founder"":""admin"",""creatTime"":""2025-12-04 16:34:50"",""Modifier"":null,""modifiedTime"":"""",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:12:50"",""et"":""2025-11-26 05:32:58"",""duration"":1167608,""number"":3893,""filter"":1609,""mode"":2284,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1519},{""st"":""2025-11-26 17:27:06"",""et"":""2025-12-04 09:56:10"",""duration"":664144,""number"":2214,""filter"":960,""mode"":1254,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":870}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lbg30ct101aom"",""Description"":""汽封供汽阀前汽封蒸汽温度#1(20)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.30"",""lowerBound"":""-0.30"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""318.16"",""TMin"":""298.02"",""TAvg"":""307.31"",""DMax"":""0.56"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.24"",""C99"":""0.30""},{""PointId"":""d1_10lbg30ct102aom"",""Description"":""汽封供汽阀前汽封蒸汽温度#2(20)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""320.27"",""TMin"":""300.15"",""TAvg"":""309.41"",""DMax"":""0.52"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10maw20ct103a"",""Description"":""汽封蒸汽集管中温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""12.21"",""lowerBound"":""-12.21"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""330.98"",""TMin"":""285.09"",""TAvg"":""308.04"",""DMax"":""17.82"",""DMin"":""0.00"",""DAvg"":""2.83"",""C95"":""9.95"",""C99"":""12.21""},{""PointId"":""d1_10maw20ct101a"",""Description"":""汽封蒸汽集管前温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""5.88"",""lowerBound"":""-5.88"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""352.23"",""TMin"":""288.14"",""TAvg"":""320.80"",""DMax"":""6.50"",""DMin"":""0.00"",""DAvg"":""1.39"",""C95"":""4.80"",""C99"":""5.88""},{""PointId"":""d1_10maw60ct101a"",""Description"":""高压轴封漏汽管温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""11.72"",""lowerBound"":""-11.72"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""418.68"",""TMin"":""339.05"",""TAvg"":""389.01"",""DMax"":""19.55"",""DMin"":""0.00"",""DAvg"":""2.66"",""C95"":""9.54"",""C99"":""11.72""},{""PointId"":""d1_10mam50ct101a"",""Description"":""门杆漏汽母管温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""1.36"",""lowerBound"":""-1.36"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""468.02"",""TMin"":""438.81"",""TAvg"":""459.08"",""DMax"":""1.45"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.11"",""C99"":""1.36""},{""PointId"":""d1_10mam20ct101a"",""Description"":""U型密封环漏汽温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""2.56"",""lowerBound"":""-2.56"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""51.88"",""TMin"":""32.12"",""TAvg"":""40.86"",""DMax"":""3.06"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.09"",""C99"":""2.56""},{""PointId"":""d1_10mam40ct101a"",""Description"":""中压缸U型密封环漏汽温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""52.42"",""TMin"":""27.47"",""TAvg"":""40.54"",""DMax"":""6.97"",""DMin"":""0.00"",""DAvg"":""1.33"",""C95"":""4.63"",""C99"":""5.67""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""未下装"",""version"":""v-test"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[298.016,300.154,285.088,288.141,339.047,438.814,32.121,27.47],""Train_X_max"":[318.155,320.272,330.977,352.232,418.682,468.017,51.884,52.416],""Train_X_std"":[3.617,3.685,13.123,15.771,12.899,3.777,3.247,4.847],""Train_X_mean"":[307.305,309.405,308.04,320.798,389.011,459.076,40.859,40.539],""Train_X_bais_max"":[[0.556,0.519,17.816,6.504,19.55,1.447,3.058,6.97]],""Train_X_bais_min"":[[0.0,0.0,0.002,0.0,0.0,0.0,0.0,0.002]],""Train_X_bais_mean"":[[0.069,0.075,2.825,1.388,2.66,0.324,0.603,1.329]],""QCUL_95"":1.08102465,""QCUL_99"":1.74830329,""QCUL_95_line"":[0.242,0.261,9.953,4.796,9.542,1.114,2.092,4.63],""QCUL_99_line"":[0.297,0.32,12.208,5.875,11.718,1.364,2.563,5.674],""T2CUL_95"":11.098,""T2CUL_99"":15.133,""T2CUL_95_line"":[0.201,0.205,0.73,0.878,0.718,0.21,0.181,0.27],""T2CUL_99_line"":[0.235,0.239,0.853,1.025,0.838,0.245,0.211,0.315],""Kesi_95"":1.616,""Kesi_99"":1.446,""Kesi_95_line"":[0.077,0.078,0.279,0.335,0.274,0.08,0.069,0.103],""Kesi_99_line"":[0.073,0.074,0.264,0.317,0.259,0.076,0.065,0.097],""COV"":[[1.0,0.999,0.031,-0.002,-0.022,-0.118,-0.104,-0.061],[0.999,1.0,0.024,-0.003,-0.029,-0.114,-0.091,-0.045],[0.031,0.024,1.0,0.705,0.863,0.102,-0.213,-0.616],[-0.002,-0.003,0.705,1.0,0.627,0.399,-0.111,-0.486],[-0.022,-0.029,0.863,0.627,1.0,0.105,-0.25,-0.636],[-0.118,-0.114,0.102,0.399,0.105,1.0,0.212,-0.063],[-0.104,-0.091,-0.213,-0.111,-0.25,0.212,1.0,0.607],[-0.061,-0.045,-0.616,-0.486,-0.636,-0.063,0.607,1.0]],""K"":5,""R"":0.956,""featValue"":[3.173,2.068,1.328,0.764,0.319,0.228,0.122,0.001],""featVec"":[[-0.033,-0.674,-0.207,-0.012,0.033,0.006,-0.013,0.708],[-0.028,-0.672,-0.216,-0.008,0.022,0.016,-0.019,-0.707],[-0.506,0.028,-0.074,0.362,0.068,0.176,0.755,-0.003],[-0.446,0.094,-0.328,-0.024,-0.781,-0.17,-0.214,0.006],[-0.5,0.058,-0.012,0.325,0.378,0.354,-0.611,0.001],[-0.116,0.22,-0.611,-0.651,0.298,0.213,0.09,0.001],[0.251,0.171,-0.595,0.51,0.23,-0.489,-0.047,0.002],[0.465,0.057,-0.267,0.282,-0.316,0.728,0.006,0.012]],""selectVec"":[[-0.033,-0.674,-0.207,-0.012,0.033],[-0.028,-0.672,-0.216,-0.008,0.022],[-0.506,0.028,-0.074,0.362,0.068],[-0.446,0.094,-0.328,-0.024,-0.781],[-0.5,0.058,-0.012,0.325,0.378],[-0.116,0.22,-0.611,-0.651,0.298],[0.251,0.171,-0.595,0.51,0.23],[0.465,0.057,-0.267,0.282,-0.316]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6107,""AfterCleanSamNum"":3584,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于400"",""alarmcondition"":""[d1_mw]>400""},""copy"":false,""principal"":""5"",""precision"":""95.6%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":null}";
	        string InputInfo = @"{""Model_id"":450,""version"":""v-test"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "]],\"Target_Data\":[[]]}";
	        string jsonResult = PCA.Diagnosis(ModelInfo, InputInfo, 1, 1);
			if (string.IsNullOrEmpty(jsonResult)) { return; }
	        float[][] reconData = PCA.OutputInfo.reconData;
	        float[][] errorData = PCA.OutputInfo.errorData;
	        float[][] paraState = PCA.OutputInfo.paraState;
	        float[] index = PCA.OutputInfo.Index;

	        OUT_R1[0] = reconData[0][0];
	        OUT_B1[0] = errorData[0][0];
	        OUT_F1[0] = paraState[0][0];
	        OUT_R2[0] = reconData[0][1];
	        OUT_B2[0] = errorData[0][1];
	        OUT_F2[0] = paraState[0][1];
	        OUT_R3[0] = reconData[0][2];
	        OUT_B3[0] = errorData[0][2];
	        OUT_F3[0] = paraState[0][2];
	        OUT_R4[0] = reconData[0][3];
	        OUT_B4[0] = errorData[0][3];
	        OUT_F4[0] = paraState[0][3];
	        OUT_R5[0] = reconData[0][4];
	        OUT_B5[0] = errorData[0][4];
	        OUT_F5[0] = paraState[0][4];
	        OUT_R6[0] = reconData[0][5];
	        OUT_B6[0] = errorData[0][5];
	        OUT_F6[0] = paraState[0][5];
	        OUT_R7[0] = reconData[0][6];
	        OUT_B7[0] = errorData[0][6];
	        OUT_F7[0] = paraState[0][6];
	        OUT_R8[0] = reconData[0][7];
	        OUT_B8[0] = errorData[0][7];
	        OUT_F8[0] = paraState[0][7];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[8] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8};
			float[] arrOUT_B = new float[8] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8};
			LD[] arrOUT_W = new LD[8] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8 };
			
	        if (!(Condition1>400))
			{
				for (int i = 0; i < arrIN.Length; i++)
				{
					StartTime[i] = 0;
					arrIN[i].active = false;
					arrOUT_W[i].buffer = false;
				}
				return;
			}


			for (int i = 0; i < arrOUT_B.Length; i++)
			{
				if (!arrIN[i].Runable || arrIN[i].AlarmType != 0 || arrIN[i].HasConstraint)
				{
					arrOUT_W[i].buffer = false;
					OldTempOUT_W[i] = false;
					StartTime[i] = -1;
					continue;
				}
				if (arrOUT_B[i] > arrIN[i].WarnUpLimit)
				{
					TempOUT_W[i] = true;
					arrIN[i].LimitAlarmType = 1;
				}
				else if (arrOUT_B[i] < arrIN[i].WarnLowLimit)
				{
					TempOUT_W[i] = true;
					arrIN[i].LimitAlarmType = 4;
				}
				else
				{
					TempOUT_W[i] = false;
				}
				if (TempOUT_W[i])
				{
					if (!OldTempOUT_W[i] && TempOUT_W[i])
					{
						StartTime[i] = ExcuteEngine.cycle * ExcuteEngine.cycleCount;
					}
					if (StartTime[i] >= 0 && ExcuteEngine.cycle * ExcuteEngine.cycleCount >= StartTime[i] + arrIN[i].DelayTime * 1000)
					{
						StartTime[i] = -1;
						arrOUT_W[i].buffer = true;
						UnAck = true;
						arrIN[i].active = true;
						arrIN[i].unAck = true;
					}
				}
				else
				{
					arrIN[i].active = false;
					arrOUT_W[i].buffer = false;
					StartTime[i] = -1;
				}
				OldTempOUT_W[i] = TempOUT_W[i];
			}
			WarnActive = false;
			for (int i = 0; i < arrOUT_W.Length; i++)
			{
				WarnActive |= arrOUT_W[i].buffer;
			}

			if (!WarnActive && !UnAck)
			{
				WarnState = 1;
			}
			else if (!WarnActive && UnAck) 
			{
				WarnState = 2; 
			}
			else if (WarnActive && !UnAck) 
			{
				WarnState = 4; 
			}
			else if (WarnActive && UnAck) 
			{
				WarnState = 8; 
			}
	    }
    }
}