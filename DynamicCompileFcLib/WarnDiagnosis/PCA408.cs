using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA408")]
    [FCDisplay("PCA408")]
    public partial class PCA408 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽轮机转速大于500")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#6轴承左前下部温度#1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#6轴承左前下部温度#2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#6轴承左前下部温度#3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#7轴承左前下部温度#1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#7轴承左前下部温度#2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#7轴承左前下部温度#3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#8轴承左前下部温度#1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#8轴承左前下部温度#2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#8轴承左前下部温度#3")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出9")]
	    public LA OUT_R9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出9")]
	    public LA OUT_B9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出9")]
	    public LD OUT_F9 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出9")]
	    public LD OUT_W9 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[9] {false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[9] {false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[9] {-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA408()
		{
			ModelID = 449;
			SysID = 13;
			FcType = enumType.Warn;
			FcName = "PCA408";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""449"",""name"":""PCA408"",""description"":""#678轴承温度"",""founder"":""admin"",""creatTime"":""2025-12-04 16:30:18"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 16:31:09"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 19:26:44"",""et"":""2025-11-26 03:19:04"",""duration"":1151540,""number"":3839,""filter"":90,""mode"":3749,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10mkd11ct113a"",""Description"":""#6轴承左前下部温度#1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""81.69"",""TMin"":""77.95"",""TAvg"":""80.17"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.10"",""C99"":""0.13""},{""PointId"":""d1_10mkd11ct113b"",""Description"":""#6轴承左前下部温度#2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""81.50"",""TMin"":""77.76"",""TAvg"":""80.02"",""DMax"":""0.43"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.23""},{""PointId"":""d1_10mkd11ct113c"",""Description"":""#6轴承左前下部温度#3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.18"",""lowerBound"":""-0.18"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""82.10"",""TMin"":""78.36"",""TAvg"":""80.63"",""DMax"":""0.36"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.18""},{""PointId"":""d1_10mkd12ct113a"",""Description"":""#7轴承左前下部温度#1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.21"",""lowerBound"":""-0.21"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""89.20"",""TMin"":""85.95"",""TAvg"":""87.79"",""DMax"":""0.22"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.17"",""C99"":""0.21""},{""PointId"":""d1_10mkd12ct113b"",""Description"":""#7轴承左前下部温度#2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""89.86"",""TMin"":""86.59"",""TAvg"":""88.45"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""d1_10mkd12ct113c"",""Description"":""#7轴承左前下部温度#3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""89.92"",""TMin"":""86.62"",""TAvg"":""88.53"",""DMax"":""0.59"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10mkd21ct113a"",""Description"":""#8轴承左前下部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""85.12"",""TMin"":""81.49"",""TAvg"":""83.86"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.09""},{""PointId"":""d1_10mkd21ct113b"",""Description"":""#8轴承左前下部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""85.66"",""TMin"":""81.85"",""TAvg"":""84.26"",""DMax"":""0.50"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10mkd21ct113c"",""Description"":""#8轴承左前下部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""86.42"",""TMin"":""82.48"",""TAvg"":""84.95"",""DMax"":""0.32"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.14""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 16:31:09"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[77.946,77.764,78.36,85.945,86.588,86.623,81.488,81.849,82.477],""Train_X_max"":[81.693,81.496,82.099,89.199,89.862,89.921,85.117,85.661,86.419],""Train_X_std"":[0.286,0.247,0.249,0.229,0.217,0.212,0.405,0.43,0.461],""Train_X_mean"":[80.168,80.015,80.629,87.793,88.448,88.531,83.857,84.261,84.946],""Train_X_bais_max"":[[0.351,0.425,0.361,0.219,0.18,0.591,0.251,0.495,0.315]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.027,0.054,0.042,0.049,0.026,0.043,0.019,0.037,0.031]],""QCUL_95"":1.11081338,""QCUL_99"":1.87614322,""QCUL_95_line"":[0.103,0.186,0.15,0.168,0.091,0.163,0.076,0.14,0.113],""QCUL_99_line"":[0.126,0.228,0.184,0.206,0.112,0.201,0.094,0.172,0.139],""T2CUL_95"":7.828,""T2CUL_99"":11.37,""T2CUL_95_line"":[0.013,0.011,0.011,0.01,0.01,0.01,0.019,0.02,0.021],""T2CUL_99_line"":[0.016,0.014,0.014,0.013,0.012,0.012,0.022,0.024,0.025],""Kesi_95"":1.589,""Kesi_99"":1.4,""Kesi_95_line"":[0.006,0.005,0.005,0.005,0.004,0.004,0.008,0.009,0.009],""Kesi_99_line"":[0.006,0.005,0.005,0.004,0.004,0.004,0.008,0.008,0.009],""COV"":[[1.0,0.858,0.938,0.895,0.665,0.715,0.183,0.041,0.034],[0.858,1.0,0.928,0.769,0.864,0.774,0.217,0.226,0.158],[0.938,0.928,1.0,0.874,0.79,0.85,0.303,0.221,0.221],[0.895,0.769,0.874,1.0,0.807,0.893,0.413,0.272,0.283],[0.665,0.864,0.79,0.807,1.0,0.917,0.436,0.478,0.415],[0.715,0.774,0.85,0.893,0.917,1.0,0.539,0.494,0.508],[0.183,0.217,0.303,0.413,0.436,0.539,1.0,0.954,0.97],[0.041,0.226,0.221,0.272,0.478,0.494,0.954,1.0,0.981],[0.034,0.158,0.221,0.283,0.415,0.508,0.97,0.981,1.0]],""K"":3,""R"":0.961,""featValue"":[5.777,2.511,0.367,0.252,0.09,0.002,0.002,0.001,0.001],""featVec"":[[0.334,0.319,-0.467,-0.228,-0.218,-0.367,0.334,-0.467,-0.061],[0.357,0.241,0.339,-0.538,-0.127,0.616,-0.011,-0.077,-0.092],[0.375,0.228,-0.138,-0.292,0.544,-0.299,-0.26,0.483,0.128],[0.377,0.16,-0.354,0.483,-0.348,0.349,0.096,0.427,0.201],[0.38,0.05,0.607,0.223,-0.34,-0.473,-0.025,0.139,-0.274],[0.396,0.016,0.148,0.487,0.514,0.161,-0.078,-0.526,0.101],[0.259,-0.475,-0.336,-0.067,-0.187,0.041,-0.635,-0.122,-0.369],[0.237,-0.511,0.13,-0.212,-0.181,-0.128,0.057,-0.078,0.75],[0.23,-0.522,-0.057,-0.062,0.269,0.083,0.632,0.205,-0.384]],""selectVec"":[[0.334,0.319,-0.467],[0.357,0.241,0.339],[0.375,0.228,-0.138],[0.377,0.16,-0.354],[0.38,0.05,0.607],[0.396,0.016,0.148],[0.259,-0.475,-0.336],[0.237,-0.511,0.13],[0.23,-0.522,-0.057]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3839,""AfterCleanSamNum"":3749,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""汽轮机转速大于500"",""alarmcondition"":""[d1_10cjj01yq03ai]>500""},""copy"":false,""principal"":""3"",""precision"":""96.1%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":449,""version"":""v-2025-12-04 16:31:09"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R9[0] = reconData[0][8];
	        OUT_B9[0] = errorData[0][8];
	        OUT_F9[0] = paraState[0][8];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[9] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9};
			float[] arrOUT_B = new float[9] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9};
			LD[] arrOUT_W = new LD[9] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9 };
			
	        if (!(Condition1>500))
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