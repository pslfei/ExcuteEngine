using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA279")]
    [FCDisplay("PCA279")]
    public partial class PCA279 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("总燃料量大于5")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机出口母管压力1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机出口母管压力2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A密封风进口压力")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B密封风进口压力")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C密封风进口压力")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D密封风进口压力")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E密封风进口压力")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F密封风进口压力")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机出口与热一次风母管差压")]
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

		public PCA279()
		{
			ModelID = 302;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA279";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""302"",""name"":""PCA279"",""description"":""磨煤机密封风压力"",""founder"":""admin"",""creatTime"":""2024-02-28 17:28:41"",""Modifier"":""admin"",""modifiedTime"":""2024-04-01 16:09:47"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-01-28 14:48:20"",""et"":""2024-02-28 06:20:12"",""duration"":2647912,""number"":8827,""filter"":0,""mode"":8827,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HFW20CP111"",""Description"":""密封风机出口母管压力1"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""16.55"",""TMin"":""12.64"",""TAvg"":""14.73"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""dcs_HFW20CP112"",""Description"":""密封风机出口母管压力2"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.09"",""lowerBound"":""-0.09"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""16.53"",""TMin"":""12.68"",""TAvg"":""14.74"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.09""},{""PointId"":""dcs_HFW41CP101"",""Description"":""磨煤机A密封风进口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.06"",""lowerBound"":""-0.06"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""15.65"",""TMin"":""11.87"",""TAvg"":""13.98"",""DMax"":""0.09"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.05"",""C99"":""0.06""},{""PointId"":""dcs_HFW42CP101"",""Description"":""磨煤机B密封风进口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""15.21"",""TMin"":""11.38"",""TAvg"":""13.45"",""DMax"":""0.69"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""dcs_HFW43CP101"",""Description"":""磨煤机C密封风进口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.04"",""lowerBound"":""-0.04"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""15.84"",""TMin"":""11.45"",""TAvg"":""13.82"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.04"",""C99"":""0.04""},{""PointId"":""dcs_HFW44CP101"",""Description"":""磨煤机D密封风进口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.02"",""lowerBound"":""-0.02"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""15.81"",""TMin"":""11.15"",""TAvg"":""13.71"",""DMax"":""0.06"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.02"",""C99"":""0.02""},{""PointId"":""dcs_HFW45CP101"",""Description"":""磨煤机E密封风进口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.07"",""lowerBound"":""-0.07"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""15.50"",""TMin"":""11.82"",""TAvg"":""13.87"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.06"",""C99"":""0.07""},{""PointId"":""dcs_HFW46CP101"",""Description"":""磨煤机F密封风进口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""15.64"",""TMin"":""11.88"",""TAvg"":""13.97"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""dcs_HFE60DP101"",""Description"":""密封风机出口与热一次风母管差压"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""7.70"",""TMin"":""5.39"",""TAvg"":""6.49"",""DMax"":""0.02"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-04-01 16:09:47"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[12.64,12.682,11.873,11.38,11.448,11.148,11.815,11.881,5.39],""Train_X_max"":[16.55,16.53,15.651,15.211,15.838,15.806,15.5,15.637,7.702],""Train_X_std"":[0.636,0.633,0.581,0.575,0.685,0.578,0.587,0.632,0.254],""Train_X_mean"":[14.73,14.736,13.976,13.446,13.819,13.708,13.865,13.974,6.493],""Train_X_bais_max"":[[0.275,0.239,0.089,0.687,0.145,0.062,0.15,0.207,0.023]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.027,0.022,0.014,0.029,0.01,0.004,0.017,0.04,0.002]],""QCUL_95"":0.06290751,""QCUL_99"":0.0990798548,""QCUL_95_line"":[0.093,0.076,0.051,0.128,0.036,0.016,0.06,0.142,0.006],""QCUL_99_line"":[0.114,0.094,0.062,0.16,0.044,0.019,0.074,0.174,0.008],""T2CUL_95"":9.496,""T2CUL_99"":13.291,""T2CUL_95_line"":[0.021,0.021,0.019,0.019,0.022,0.019,0.019,0.021,0.008],""T2CUL_99_line"":[0.025,0.025,0.023,0.022,0.027,0.022,0.023,0.025,0.01],""Kesi_95"":1.608,""Kesi_99"":1.441,""Kesi_95_line"":[0.009,0.009,0.008,0.008,0.009,0.008,0.008,0.009,0.003],""Kesi_99_line"":[0.008,0.008,0.007,0.007,0.009,0.007,0.007,0.008,0.003],""COV"":[[1.0,1.0,0.989,0.982,0.795,0.775,0.991,0.989,0.472],[1.0,1.0,0.99,0.984,0.794,0.767,0.993,0.99,0.452],[0.989,0.99,1.0,0.997,0.851,0.791,0.998,0.994,0.425],[0.982,0.984,0.997,1.0,0.849,0.781,0.995,0.989,0.406],[0.795,0.794,0.851,0.849,1.0,0.585,0.83,0.832,0.373],[0.775,0.767,0.791,0.781,0.585,1.0,0.778,0.776,0.504],[0.991,0.993,0.998,0.995,0.83,0.778,1.0,0.996,0.409],[0.989,0.99,0.994,0.989,0.832,0.776,0.996,1.0,0.418],[0.472,0.452,0.425,0.406,0.373,0.504,0.409,0.418,1.0]],""K"":4,""R"":0.998,""featValue"":[7.535,0.823,0.387,0.234,0.012,0.008,0.002,0.0,0.0],""featVec"":[[-0.36,0.039,0.029,-0.292,-0.32,0.423,0.29,-0.062,-0.643],[-0.359,0.065,0.029,-0.304,-0.242,0.392,0.054,0.004,0.747],[-0.363,0.101,-0.001,-0.051,0.172,0.008,-0.444,0.783,-0.124],[-0.361,0.123,-0.004,-0.047,0.782,-0.042,0.481,-0.079,0.038],[-0.311,0.132,-0.633,0.667,-0.15,0.117,0.034,-0.063,0.023],[-0.299,-0.238,0.725,0.563,-0.08,0.055,0.025,-0.036,0.021],[-0.361,0.12,0.02,-0.144,0.145,-0.096,-0.652,-0.608,-0.095],[-0.36,0.109,0.006,-0.139,-0.378,-0.797,0.238,0.042,0.039],[-0.183,-0.932,-0.269,-0.129,0.065,-0.062,-0.026,-0.001,0.007]],""selectVec"":[[-0.36,0.039,0.029,-0.292],[-0.359,0.065,0.029,-0.304],[-0.363,0.101,-0.001,-0.051],[-0.361,0.123,-0.004,-0.047],[-0.311,0.132,-0.633,0.667],[-0.299,-0.238,0.725,0.563],[-0.361,0.12,0.02,-0.144],[-0.36,0.109,0.006,-0.139],[-0.183,-0.932,-0.269,-0.129]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8827,""AfterCleanSamNum"":8827,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""总燃料量大于5"",""alarmcondition"":""[dcs_TFFREAL]>5""},""copy"":false,""principal"":""4"",""precision"":""99.8%"",""rate"":""0.975"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":302,""version"":""v-2024-04-01 16:09:47"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>5))
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