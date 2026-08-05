using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA182")]
    [FCDisplay("PCA182")]
    public partial class PCA182 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B非驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B中轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B驱动端轴承温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B非驱动端轴承温度2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B中轴承温度2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B驱动端轴承温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B非驱动端轴承温度3")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B中轴承温度3")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B驱动端轴承温度3")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B联合油站油箱油温")]
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

		public PCA182()
		{
			ModelID = 201;
			SysID = 30;
			FcType = enumType.Warn;
			FcName = "PCA182";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""201"",""name"":""PCA182"",""description"":""送风机B轴承温度"",""founder"":""admin"",""creatTime"":""2023-11-22 15:19:54"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 16:02:26"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 15:43:34"",""et"":""2025-11-26 02:34:26"",""duration"":1162252,""number"":3875,""filter"":90,""mode"":3785,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 20:25:38"",""et"":""2025-12-06 11:01:58"",""duration"":830180,""number"":2768,""filter"":90,""mode"":2678,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hlb20ct101r"",""Description"":""送风机B非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.49"",""lowerBound"":""-0.49"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""56.63"",""TMin"":""33.95"",""TAvg"":""47.49"",""DMax"":""0.43"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.40"",""C99"":""0.49""},{""PointId"":""d1_10hlb20ct104r"",""Description"":""送风机B中轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.67"",""lowerBound"":""-0.67"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""52.43"",""TMin"":""34.84"",""TAvg"":""44.43"",""DMax"":""0.88"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.54"",""C99"":""0.67""},{""PointId"":""d1_10hlb20ct107r"",""Description"":""送风机B驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.81"",""lowerBound"":""-0.81"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""53.32"",""TMin"":""35.15"",""TAvg"":""44.91"",""DMax"":""0.96"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.66"",""C99"":""0.81""},{""PointId"":""d1_10hlb20ct102r"",""Description"":""送风机B非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.55"",""lowerBound"":""-0.55"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""56.67"",""TMin"":""35.54"",""TAvg"":""48.18"",""DMax"":""0.49"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.45"",""C99"":""0.55""},{""PointId"":""d1_10hlb20ct105r"",""Description"":""送风机B中轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.52"",""lowerBound"":""-2.52"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""53.44"",""TMin"":""35.38"",""TAvg"":""44.64"",""DMax"":""2.38"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.06"",""C99"":""2.52""},{""PointId"":""d1_10hlb20ct108r"",""Description"":""送风机B驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.70"",""lowerBound"":""-0.70"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""52.80"",""TMin"":""34.69"",""TAvg"":""44.54"",""DMax"":""0.89"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.57"",""C99"":""0.70""},{""PointId"":""d1_10hlb20ct103r"",""Description"":""送风机B非驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.70"",""lowerBound"":""-0.70"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""56.49"",""TMin"":""33.74"",""TAvg"":""47.53"",""DMax"":""0.68"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.57"",""C99"":""0.70""},{""PointId"":""d1_10hlb20ct106r"",""Description"":""送风机B中轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.36"",""lowerBound"":""-1.36"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""53.56"",""TMin"":""34.92"",""TAvg"":""45.29"",""DMax"":""1.40"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.11"",""C99"":""1.36""},{""PointId"":""d1_10hlb20ct109r"",""Description"":""送风机B驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""53.38"",""TMin"":""35.09"",""TAvg"":""44.98"",""DMax"":""0.89"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.56"",""C99"":""0.69""},{""PointId"":""d1_10hlb21ct101r"",""Description"":""送风机B联合油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.52"",""lowerBound"":""-0.52"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""35.69"",""TMin"":""17.62"",""TAvg"":""24.86"",""DMax"":""0.60"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.43"",""C99"":""0.52""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 16:02:26"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[33.953,34.841,35.151,35.535,35.377,34.693,33.737,34.915,35.09,17.616],""Train_X_max"":[56.63,52.431,53.318,56.668,53.44,52.802,56.488,53.555,53.383,35.69],""Train_X_std"":[4.737,3.533,3.756,4.361,3.73,3.824,4.747,3.499,3.838,3.093],""Train_X_mean"":[47.49,44.432,44.91,48.182,44.642,44.536,47.526,45.286,44.98,24.859],""Train_X_bais_max"":[[0.431,0.875,0.96,0.488,2.382,0.888,0.681,1.395,0.887,0.597]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.116,0.154,0.187,0.135,0.612,0.16,0.172,0.32,0.155,0.125]],""QCUL_95"":0.233122155,""QCUL_99"":0.399521351,""QCUL_95_line"":[0.401,0.543,0.662,0.449,2.058,0.567,0.57,1.112,0.562,0.426],""QCUL_99_line"":[0.492,0.666,0.812,0.549,2.516,0.695,0.696,1.362,0.691,0.521],""T2CUL_95"":7.822,""T2CUL_99"":11.359,""T2CUL_95_line"":[0.164,0.122,0.13,0.151,0.129,0.132,0.164,0.121,0.133,0.107],""T2CUL_99_line"":[0.197,0.147,0.156,0.182,0.155,0.159,0.198,0.146,0.16,0.129],""Kesi_95"":1.587,""Kesi_99"":1.391,""Kesi_95_line"":[0.074,0.055,0.058,0.068,0.058,0.06,0.074,0.054,0.06,0.048],""Kesi_99_line"":[0.069,0.051,0.055,0.064,0.054,0.056,0.069,0.051,0.056,0.045],""COV"":[[1.0,0.907,0.915,1.0,0.93,0.937,1.0,0.871,0.927,0.778],[0.907,1.0,0.991,0.909,0.973,0.989,0.907,0.99,0.992,0.909],[0.915,0.991,1.0,0.918,0.956,0.997,0.916,0.985,0.997,0.881],[1.0,0.909,0.918,1.0,0.93,0.94,1.0,0.875,0.929,0.782],[0.93,0.973,0.956,0.93,1.0,0.971,0.926,0.931,0.972,0.886],[0.937,0.989,0.997,0.94,0.971,1.0,0.938,0.975,0.999,0.873],[1.0,0.907,0.916,1.0,0.926,0.938,1.0,0.874,0.928,0.777],[0.871,0.99,0.985,0.875,0.931,0.975,0.874,1.0,0.978,0.896],[0.927,0.992,0.997,0.929,0.972,0.999,0.928,0.978,1.0,0.879],[0.778,0.909,0.881,0.782,0.886,0.873,0.777,0.896,0.879,1.0]],""K"":3,""R"":0.993,""featValue"":[9.374,0.411,0.143,0.054,0.016,0.001,0.001,0.0,0.0,0.0],""featVec"":[[0.313,0.437,0.17,-0.098,0.062,-0.239,0.596,-0.502,0.068,0.003],[0.323,-0.199,-0.155,0.078,0.401,-0.123,0.056,0.025,-0.804,0.021],[0.323,-0.13,-0.307,-0.134,-0.414,-0.721,-0.081,0.222,0.116,0.083],[0.313,0.426,0.168,-0.139,0.038,-0.032,-0.68,-0.148,-0.064,-0.427],[0.32,-0.035,0.119,0.844,0.216,-0.097,-0.08,0.065,0.316,0.056],[0.325,-0.045,-0.237,0.063,-0.39,0.404,-0.217,-0.435,-0.078,0.524],[0.313,0.437,0.152,-0.169,0.041,0.241,0.1,0.671,-0.007,0.374],[0.316,-0.283,-0.325,-0.389,0.559,0.144,-0.034,-0.059,0.475,-0.008],[0.324,-0.088,-0.251,0.11,-0.356,0.393,0.328,0.172,-0.015,-0.627],[0.292,-0.538,0.75,-0.197,-0.151,0.029,0.014,-0.009,0.007,0.0]],""selectVec"":[[0.313,0.437,0.17],[0.323,-0.199,-0.155],[0.323,-0.13,-0.307],[0.313,0.426,0.168],[0.32,-0.035,0.119],[0.325,-0.045,-0.237],[0.313,0.437,0.152],[0.316,-0.283,-0.325],[0.324,-0.088,-0.251],[0.292,-0.538,0.75]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6642,""AfterCleanSamNum"":6552,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""送风机B运行"",""alarmcondition"":""[d1_10hlb20an001xq01]>20""},""copy"":false,""principal"":""3"",""precision"":""99.3%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":201,""version"":""v-2025-12-08 16:02:26"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "]],\"Target_Data\":[[]]}";
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