using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA288")]
    [FCDisplay("PCA288")]
    public partial class PCA288 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于100")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器A(高背压)热井液位1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器B(低背压)热井液位1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器A(高背压)热井液位3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器B(低背压)热井液位3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器A(高背压)热井液位2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器B(低背压)热井液位2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器A(高背压)热井液位（选择后）")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器热井液位")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝汽器B(低背压)热井液位（选择后）")]
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

		public PCA288()
		{
			ModelID = 313;
			SysID = 8;
			FcType = enumType.Warn;
			FcName = "PCA288";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""313"",""name"":""PCA288"",""description"":""凝汽器液位"",""founder"":""admin"",""creatTime"":""2024-03-06 10:49:09"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:22:38"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-18 01:54:24"",""et"":""2025-12-03 01:12:18"",""duration"":1293474,""number"":4312,""filter"":90,""mode"":4222,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10mag10cl101"",""Description"":""凝汽器A(高背压)热井液位1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""16.52"",""lowerBound"":""-16.52"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""999.30"",""TMin"":""370.26"",""TAvg"":""669.36"",""DMax"":""53.45"",""DMin"":""0.00"",""DAvg"":""3.49"",""C95"":""13.39"",""C99"":""16.52""},{""PointId"":""d1_10mag20cl101"",""Description"":""凝汽器B(低背压)热井液位1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""7.32"",""lowerBound"":""-7.32"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""999.94"",""TMin"":""518.50"",""TAvg"":""752.19"",""DMax"":""11.66"",""DMin"":""0.00"",""DAvg"":""1.54"",""C95"":""5.93"",""C99"":""7.32""},{""PointId"":""d1_10mag10cl103"",""Description"":""凝汽器A(高背压)热井液位3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""46.55"",""lowerBound"":""-46.55"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""1000.00"",""TMin"":""413.14"",""TAvg"":""685.50"",""DMax"":""173.00"",""DMin"":""0.00"",""DAvg"":""9.57"",""C95"":""37.66"",""C99"":""46.55""},{""PointId"":""d1_10mag20cl103"",""Description"":""凝汽器B(低背压)热井液位3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""7.49"",""lowerBound"":""-7.49"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""999.28"",""TMin"":""529.51"",""TAvg"":""761.70"",""DMax"":""11.27"",""DMin"":""0.00"",""DAvg"":""1.60"",""C95"":""6.07"",""C99"":""7.49""},{""PointId"":""d1_10mag10cl102"",""Description"":""凝汽器A(高背压)热井液位2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""15.81"",""lowerBound"":""-15.81"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""999.79"",""TMin"":""377.67"",""TAvg"":""674.60"",""DMax"":""56.00"",""DMin"":""0.00"",""DAvg"":""3.28"",""C95"":""12.80"",""C99"":""15.81""},{""PointId"":""d1_10mag20cl102"",""Description"":""凝汽器B(低背压)热井液位2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""14.18"",""lowerBound"":""-14.18"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""1000.00"",""TMin"":""514.05"",""TAvg"":""750.46"",""DMax"":""27.83"",""DMin"":""0.00"",""DAvg"":""2.88"",""C95"":""11.47"",""C99"":""14.18""},{""PointId"":""d1_nqqa_yw"",""Description"":""凝汽器A(高背压)热井液位（选择后）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""12.89"",""lowerBound"":""-12.89"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""999.97"",""TMin"":""376.67"",""TAvg"":""673.74"",""DMax"":""52.97"",""DMin"":""0.00"",""DAvg"":""2.56"",""C95"":""10.41"",""C99"":""12.89""},{""PointId"":""d1_nqq_yw"",""Description"":""凝汽器热井液位"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""6.84"",""lowerBound"":""-6.84"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""999.90"",""TMin"":""467.98"",""TAvg"":""713.70"",""DMax"":""25.75"",""DMin"":""0.00"",""DAvg"":""1.37"",""C95"":""5.53"",""C99"":""6.84""},{""PointId"":""d1_nqqb_yw"",""Description"":""凝汽器B(低背压)热井液位（选择后）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.55"",""lowerBound"":""-3.55"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""999.87"",""TMin"":""517.30"",""TAvg"":""753.66"",""DMax"":""8.34"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.88"",""C99"":""3.55""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:22:38"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[370.257,518.504,413.141,529.509,377.672,514.048,376.671,467.98,517.297],""Train_X_max"":[999.296,999.936,1000.0,999.284,999.792,1000.0,999.965,999.896,999.866],""Train_X_std"":[97.62,88.565,93.436,88.039,96.766,89.024,96.524,86.252,88.88],""Train_X_mean"":[669.358,752.19,685.501,761.703,674.603,750.462,673.735,713.696,753.655],""Train_X_bais_max"":[[53.449,11.659,172.999,11.273,55.999,27.826,52.974,25.745,8.34]],""Train_X_bais_min"":[[0.002,0.001,0.003,0.0,0.0,0.0,0.001,0.0,0.0]],""Train_X_bais_mean"":[[3.494,1.543,9.565,1.596,3.279,2.88,2.56,1.373,0.765]],""QCUL_95"":0.1225324,""QCUL_99"":0.217009991,""QCUL_95_line"":[13.391,5.928,37.661,6.071,12.795,11.465,10.406,5.529,2.879],""QCUL_99_line"":[16.522,7.315,46.548,7.487,15.806,14.18,12.887,6.844,3.548],""T2CUL_95"":5.999,""T2CUL_99"":9.225,""T2CUL_95_line"":[3.68,3.338,3.522,3.318,3.647,3.356,3.638,3.251,3.35],""T2CUL_99_line"":[4.563,4.14,4.368,4.115,4.523,4.161,4.512,4.032,4.155],""Kesi_95"":1.579,""Kesi_99"":1.378,""Kesi_95_line"":[1.888,1.713,1.807,1.703,1.871,1.722,1.867,1.668,1.719],""Kesi_99_line"":[1.764,1.6,1.688,1.591,1.748,1.609,1.744,1.558,1.606],""COV"":[[1.0,0.711,0.979,0.711,1.0,0.723,1.0,0.928,0.716],[0.711,1.0,0.712,1.0,0.729,0.997,0.726,0.922,1.0],[0.979,0.712,1.0,0.711,0.979,0.726,0.981,0.918,0.716],[0.711,1.0,0.711,1.0,0.728,0.997,0.726,0.921,1.0],[1.0,0.729,0.979,0.728,1.0,0.74,1.0,0.937,0.733],[0.723,0.997,0.726,0.997,0.74,1.0,0.738,0.927,0.999],[1.0,0.726,0.981,0.726,1.0,0.738,1.0,0.936,0.731],[0.928,0.922,0.918,0.921,0.937,0.927,0.936,1.0,0.924],[0.716,1.0,0.716,1.0,0.733,0.999,0.731,0.924,1.0]],""K"":2,""R"":0.996,""featValue"":[7.877,1.09,0.031,0.003,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.329,-0.366,-0.288,-0.055,-0.362,-0.313,0.137,-0.651,0.001],[-0.33,0.36,-0.007,0.416,-0.186,-0.042,-0.737,-0.099,0.004],[-0.327,-0.352,0.872,0.077,-0.014,-0.045,0.015,0.003,0.0],[-0.33,0.361,-0.01,0.42,-0.261,0.39,0.603,0.017,-0.003],[-0.332,-0.344,-0.281,0.01,-0.315,-0.191,-0.021,0.746,-0.001],[-0.332,0.343,0.094,-0.799,-0.249,0.233,-0.087,0.008,0.0],[-0.332,-0.348,-0.227,0.003,0.433,0.552,-0.146,-0.073,0.446],[-0.356,-0.012,-0.129,-0.021,0.471,0.003,0.022,-0.014,-0.796],[-0.331,0.354,-0.005,-0.044,0.443,-0.592,0.213,0.057,0.409]],""selectVec"":[[-0.329,-0.366],[-0.33,0.36],[-0.327,-0.352],[-0.33,0.361],[-0.332,-0.344],[-0.332,0.343],[-0.332,-0.348],[-0.356,-0.012],[-0.331,0.354]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":4312,""AfterCleanSamNum"":4222,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于100"",""alarmcondition"":""[d1_mw]>100""},""copy"":false,""principal"":""2"",""precision"":""99.6%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":313,""version"":""v-2025-12-04 15:22:38"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>100))
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