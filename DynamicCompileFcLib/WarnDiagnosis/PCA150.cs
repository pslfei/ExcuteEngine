using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA150")]
    [FCDisplay("PCA150")]
    public partial class PCA150 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E进出口差压")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E密封风与一次风差压1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E密封风与一次风差压2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E密封风与一次风差压3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E分离器出口压力")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E入口混合一次风压力1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E入口混合一次风压力2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E入口一次风压力")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E入口密封风压力")]
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

		public PCA150()
		{
			ModelID = 162;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA150";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""162"",""name"":""PCA150"",""description"":""磨煤机E压力"",""founder"":""admin"",""creatTime"":""2023-11-01 10:15:10"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 16:57:27"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 18:58:26"",""et"":""2025-11-19 15:50:42"",""duration"":1371136,""number"":4571,""filter"":416,""mode"":4155,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":326}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc50cp101d"",""Description"":""磨煤机E进出口差压"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.05"",""lowerBound"":""-0.05"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""5.91"",""TMin"":""2.96"",""TAvg"":""4.39"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.09""},{""PointId"":""d1_10hfe50cp101d"",""Description"":""磨煤机E密封风与一次风差压1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.03"",""lowerBound"":""-0.03"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""3.48"",""TMin"":""2.54"",""TAvg"":""2.96"",""DMax"":""0.04"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.03"",""C99"":""0.03""},{""PointId"":""d1_10hfe50cp102d"",""Description"":""磨煤机E密封风与一次风差压2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""3.54"",""TMin"":""2.60"",""TAvg"":""3.01"",""DMax"":""0.03"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""},{""PointId"":""d1_10hfe50cp103d"",""Description"":""磨煤机E密封风与一次风差压3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.04"",""lowerBound"":""-0.04"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""3.50"",""TMin"":""2.58"",""TAvg"":""3.01"",""DMax"":""0.06"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.03"",""C99"":""0.04""},{""PointId"":""d1_10hfc50cp101"",""Description"":""磨煤机E分离器出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.09"",""lowerBound"":""-0.09"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""4.68"",""TMin"":""1.47"",""TAvg"":""3.10"",""DMax"":""0.59"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hfe50cp101"",""Description"":""磨煤机E入口混合一次风压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""10.36"",""TMin"":""4.67"",""TAvg"":""7.57"",""DMax"":""1.86"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hfe50cp102"",""Description"":""磨煤机E入口混合一次风压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""10.37"",""TMin"":""4.66"",""TAvg"":""7.56"",""DMax"":""1.85"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_emillip"",""Description"":""磨煤机E入口一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""10.37"",""TMin"":""4.66"",""TAvg"":""7.57"",""DMax"":""1.00"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.10"",""C99"":""0.12""},{""PointId"":""d1_10hfw50cp101"",""Description"":""磨煤机E入口密封风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""13.21"",""TMin"":""7.63"",""TAvg"":""10.57"",""DMax"":""0.85"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.10"",""C99"":""0.12""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 16:57:27"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[2.959,2.544,2.6,2.576,1.471,4.666,4.659,4.663,7.628],""Train_X_max"":[5.908,3.48,3.537,3.503,4.684,10.359,10.366,10.366,13.214],""Train_X_std"":[0.575,0.061,0.059,0.061,0.608,1.148,1.146,1.147,1.162],""Train_X_mean"":[4.386,2.961,3.012,3.005,3.098,7.571,7.56,7.57,10.574],""Train_X_bais_max"":[[0.466,0.036,0.026,0.056,0.586,1.858,1.854,1.0,0.848]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.018,0.008,0.003,0.01,0.038,0.022,0.024,0.02,0.022]],""QCUL_95"":0.303119063,""QCUL_99"":0.537885368,""QCUL_95_line"":[0.069,0.027,0.011,0.034,0.132,0.155,0.157,0.098,0.1],""QCUL_99_line"":[0.085,0.033,0.014,0.042,0.162,0.197,0.2,0.123,0.124],""T2CUL_95"":7.827,""T2CUL_99"":11.367,""T2CUL_95_line"":[0.025,0.003,0.003,0.003,0.026,0.05,0.05,0.05,0.05],""T2CUL_99_line"":[0.03,0.003,0.003,0.003,0.032,0.06,0.06,0.06,0.061],""Kesi_95"":1.584,""Kesi_99"":1.372,""Kesi_95_line"":[0.011,0.001,0.001,0.001,0.012,0.022,0.022,0.022,0.023],""Kesi_99_line"":[0.01,0.001,0.001,0.001,0.011,0.021,0.021,0.021,0.021],""COV"":[[1.0,0.027,0.029,-0.103,0.784,0.937,0.939,0.944,0.942],[0.027,1.0,0.989,0.912,0.069,0.049,0.049,0.056,0.104],[0.029,0.989,1.0,0.949,0.06,0.04,0.039,0.048,0.098],[-0.103,0.912,0.949,1.0,-0.111,-0.13,-0.131,-0.121,-0.071],[0.784,0.069,0.06,-0.111,1.0,0.941,0.939,0.941,0.94],[0.937,0.049,0.04,-0.13,0.941,1.0,1.0,0.996,0.995],[0.939,0.049,0.039,-0.131,0.939,1.0,1.0,0.996,0.995],[0.944,0.056,0.048,-0.121,0.941,0.996,0.996,1.0,0.999],[0.942,0.104,0.098,-0.071,0.94,0.995,0.995,0.999,1.0]],""K"":3,""R"":0.99,""featValue"":[5.787,2.904,0.221,0.073,0.011,0.005,0.002,0.0,0.0],""featVec"":[[-0.392,-0.01,0.704,-0.006,-0.387,0.045,-0.445,-0.035,0.003],[-0.026,0.577,-0.094,-0.586,-0.071,0.554,-0.011,-0.04,-0.006],[-0.023,0.585,-0.033,-0.159,-0.026,-0.785,-0.105,0.061,0.02],[0.047,0.569,0.146,0.754,0.116,0.249,0.087,0.013,-0.017],[-0.392,0.004,-0.688,0.241,-0.377,0.058,-0.409,-0.032,-0.011],[-0.415,-0.009,-0.012,-0.032,0.559,0.032,-0.133,0.033,0.703],[-0.415,-0.009,-0.002,-0.052,0.553,-0.004,-0.122,-0.002,-0.71],[-0.415,-0.004,0.011,-0.014,-0.214,0.006,0.513,0.72,-0.013],[-0.415,0.025,0.012,0.006,-0.157,-0.094,0.565,-0.688,0.024]],""selectVec"":[[-0.392,-0.01,0.704],[-0.026,0.577,-0.094],[-0.023,0.585,-0.033],[0.047,0.569,0.146],[-0.392,0.004,-0.688],[-0.415,-0.009,-0.012],[-0.415,-0.009,-0.002],[-0.415,-0.004,0.011],[-0.415,0.025,0.012]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":4571,""AfterCleanSamNum"":4155,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机E运行"",""alarmcondition"":""[d1_10hfe50aj001xq01]>20""},""copy"":false,""principal"":""3"",""precision"":""99%"",""rate"":""0.97"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":162,""version"":""v-2025-12-03 16:57:27"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>20))
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