using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA177")]
    [FCDisplay("PCA177")]
    public partial class PCA177 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空气预热器A出口热一次风压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A出口压力")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("炉右冷一次风压力")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后热一次风母管压力")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空气预热器B出口热一次风压力")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B出口压力")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("炉左冷一次风压力")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热一次风母管压力1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热一次风母管压力2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热一次风母管压力3")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出10")]
	    public LA OUT_R10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出10")]
	    public LA OUT_B10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出10")]
	    public LD OUT_F10 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出10")]
	    public LD OUT_W10 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[10] {false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[10] {false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[10] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA177()
		{
			ModelID = 196;
			SysID = 31;
			FcType = enumType.Warn;
			FcName = "PCA177";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""196"",""name"":""PCA177"",""description"":""一次风机压力"",""founder"":""admin"",""creatTime"":""2023-11-22 10:37:00"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 09:58:03"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 16:28:12"",""et"":""2025-11-26 02:34:26"",""duration"":1159574,""number"":3866,""filter"":1368,""mode"":2498,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1278},{""st"":""2025-11-26 23:24:10"",""et"":""2025-12-07 10:05:36"",""duration"":902486,""number"":3009,""filter"":924,""mode"":2085,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":834}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hla30cp103"",""Description"":""空气预热器A出口热一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""11.55"",""TMin"":""7.47"",""TAvg"":""9.62"",""DMax"":""0.53"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10hla30cp101"",""Description"":""一次风机A出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""13.77"",""TMin"":""8.54"",""TAvg"":""11.45"",""DMax"":""0.43"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10hla30cp102"",""Description"":""炉右冷一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.33"",""lowerBound"":""-0.33"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""13.80"",""TMin"":""8.41"",""TAvg"":""11.43"",""DMax"":""0.71"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.27"",""C99"":""0.33""},{""PointId"":""d1_paprs"",""Description"":""选择后热一次风母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""12.50"",""TMin"":""8.20"",""TAvg"":""10.61"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10hla40cp103"",""Description"":""空气预热器B出口热一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""12.51"",""TMin"":""8.23"",""TAvg"":""10.61"",""DMax"":""0.31"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10hla40cp101"",""Description"":""一次风机B出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.30"",""lowerBound"":""-0.30"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""13.79"",""TMin"":""8.55"",""TAvg"":""11.47"",""DMax"":""0.40"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.30""},{""PointId"":""d1_10hla40cp102"",""Description"":""炉左冷一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""13.68"",""TMin"":""8.31"",""TAvg"":""11.33"",""DMax"":""0.52"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.31""},{""PointId"":""d1_10hla80cp101"",""Description"":""热一次风母管压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""12.43"",""TMin"":""8.10"",""TAvg"":""10.53"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10hla80cp102"",""Description"":""热一次风母管压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""12.55"",""TMin"":""8.24"",""TAvg"":""10.65"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10hla80cp103"",""Description"":""热一次风母管压力3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""12.51"",""TMin"":""8.20"",""TAvg"":""10.61"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 09:58:03"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[7.466,8.537,8.414,8.202,8.234,8.548,8.312,8.1,8.24,8.202],""Train_X_max"":[11.546,13.765,13.797,12.5,12.51,13.791,13.679,12.426,12.552,12.505],""Train_X_std"":[0.752,1.032,1.052,0.804,0.78,1.031,1.048,0.808,0.807,0.804],""Train_X_mean"":[9.619,11.447,11.434,10.608,10.608,11.467,11.325,10.529,10.652,10.608],""Train_X_bais_max"":[[0.531,0.427,0.712,0.275,0.308,0.402,0.523,0.285,0.286,0.281]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.074,0.074,0.076,0.038,0.056,0.071,0.072,0.039,0.038,0.039]],""QCUL_95"":0.22327134,""QCUL_99"":0.3801738,""QCUL_95_line"":[0.258,0.254,0.271,0.136,0.194,0.245,0.256,0.138,0.135,0.138],""QCUL_99_line"":[0.316,0.311,0.333,0.166,0.238,0.3,0.314,0.17,0.165,0.17],""T2CUL_95"":3.844,""T2CUL_99"":6.642,""T2CUL_95_line"":[0.022,0.03,0.03,0.023,0.022,0.03,0.03,0.023,0.023,0.023],""T2CUL_99_line"":[0.028,0.039,0.04,0.03,0.029,0.039,0.04,0.031,0.031,0.03],""Kesi_95"":1.561,""Kesi_99"":1.337,""Kesi_95_line"":[0.014,0.019,0.019,0.015,0.014,0.019,0.019,0.015,0.015,0.015],""Kesi_99_line"":[0.013,0.017,0.018,0.014,0.013,0.017,0.018,0.014,0.014,0.014],""COV"":[[1.0,0.984,0.985,0.99,0.99,0.985,0.986,0.99,0.99,0.989],[0.984,1.0,0.999,0.99,0.985,1.0,0.999,0.99,0.99,0.99],[0.985,0.999,1.0,0.989,0.984,0.999,1.0,0.989,0.989,0.989],[0.99,0.99,0.989,1.0,0.999,0.99,0.989,1.0,1.0,1.0],[0.99,0.985,0.984,0.999,1.0,0.985,0.985,0.999,0.999,0.999],[0.985,1.0,0.999,0.99,0.985,1.0,0.999,0.99,0.99,0.99],[0.986,0.999,1.0,0.989,0.985,0.999,1.0,0.989,0.99,0.989],[0.99,0.99,0.989,1.0,0.999,0.99,0.989,1.0,1.0,1.0],[0.99,0.99,0.989,1.0,0.999,0.99,0.99,1.0,1.0,1.0],[0.989,0.99,0.989,1.0,0.999,0.99,0.989,1.0,1.0,1.0]],""K"":1,""R"":0.993,""featValue"":[9.931,0.05,0.017,0.003,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.315,-0.139,-0.929,-0.094,0.089,-0.023,0.015,-0.014,0.003,-0.006],[0.316,0.375,0.098,-0.495,-0.105,-0.393,-0.323,0.035,0.042,-0.482],[0.316,0.4,0.006,0.556,0.142,-0.37,-0.298,0.05,0.036,0.425],[0.317,-0.251,0.171,-0.011,0.026,-0.289,0.27,-0.801,-0.084,0.043],[0.316,-0.383,0.058,0.232,-0.799,0.026,-0.179,0.157,0.001,-0.033],[0.316,0.365,0.066,-0.448,-0.24,0.349,0.248,0.013,-0.019,0.565],[0.316,0.386,0.007,0.416,0.007,0.433,0.346,-0.061,-0.052,-0.514],[0.317,-0.248,0.166,-0.066,0.36,0.529,-0.606,-0.153,0.082,0.009],[0.317,-0.248,0.174,-0.058,0.279,-0.124,0.176,0.428,-0.705,0.002],[0.317,-0.256,0.178,-0.032,0.238,-0.138,0.35,0.347,0.695,-0.01]],""selectVec"":[[0.315],[0.316],[0.316],[0.317],[0.316],[0.316],[0.316],[0.317],[0.317],[0.317]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6874,""AfterCleanSamNum"":4650,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.3%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":196,""version"":""v-2025-12-09 09:58:03"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R10[0] = reconData[0][9];
	        OUT_B10[0] = errorData[0][9];
	        OUT_F10[0] = paraState[0][9];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[10] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10};
			float[] arrOUT_B = new float[10] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10};
			LD[] arrOUT_W = new LD[10] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10 };
			
	        if (!(Condition1>350))
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