using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA184")]
    [FCDisplay("PCA184")]
    public partial class PCA184 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机非驱动端轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机定子U相绕组温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机定子V相绕组温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机定子W相绕组温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机驱动端轴承温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机非驱动端轴承温度2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机定子U相绕组温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机定子V相绕组温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B电机定子W相绕组温度2")]
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

		public PCA184()
		{
			ModelID = 203;
			SysID = 30;
			FcType = enumType.Warn;
			FcName = "PCA184";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""203"",""name"":""PCA184"",""description"":""送风机B电机温度"",""founder"":""admin"",""creatTime"":""2023-11-22 15:33:39"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 15:55:34"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:57:28"",""et"":""2025-11-25 22:06:38"",""duration"":1138150,""number"":3794,""filter"":90,""mode"":3704,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 20:58:32"",""et"":""2025-12-07 18:16:34"",""duration"":854282,""number"":2848,""filter"":90,""mode"":2758,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hlb20ct110r"",""Description"":""送风机B电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.40"",""lowerBound"":""-1.40"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""41.17"",""TMin"":""12.24"",""TAvg"":""22.28"",""DMax"":""3.88"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""1.13"",""C99"":""1.40""},{""PointId"":""d1_10hlb20ct112r"",""Description"":""送风机B电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.05"",""lowerBound"":""-1.05"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""38.43"",""TMin"":""8.78"",""TAvg"":""18.83"",""DMax"":""2.91"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.85"",""C99"":""1.05""},{""PointId"":""d1_10hlb20ct114r"",""Description"":""送风机B电机定子U相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.85"",""lowerBound"":""-0.85"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""82.05"",""TMin"":""24.00"",""TAvg"":""37.71"",""DMax"":""1.96"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.69"",""C99"":""0.85""},{""PointId"":""d1_10hlb20ct116r"",""Description"":""送风机B电机定子V相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""82.19"",""TMin"":""21.61"",""TAvg"":""35.54"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.29"",""C99"":""0.35""},{""PointId"":""d1_10hlb20ct118r"",""Description"":""送风机B电机定子W相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""84.58"",""TMin"":""22.71"",""TAvg"":""36.81"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.15""},{""PointId"":""d1_10hlb20ct111r"",""Description"":""送风机B电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.04"",""lowerBound"":""-1.04"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""40.79"",""TMin"":""11.80"",""TAvg"":""21.94"",""DMax"":""2.46"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.84"",""C99"":""1.04""},{""PointId"":""d1_10hlb20ct113r"",""Description"":""送风机B电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.06"",""lowerBound"":""-1.06"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""39.09"",""TMin"":""9.21"",""TAvg"":""19.21"",""DMax"":""2.77"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.86"",""C99"":""1.06""},{""PointId"":""d1_10hlb20ct115r"",""Description"":""送风机B电机定子U相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""83.22"",""TMin"":""21.98"",""TAvg"":""35.99"",""DMax"":""0.45"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hlb20ct117r"",""Description"":""送风机B电机定子V相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""84.19"",""TMin"":""21.68"",""TAvg"":""35.80"",""DMax"":""0.91"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.35"",""C99"":""0.44""},{""PointId"":""d1_10hlb20ct119r"",""Description"":""送风机B电机定子W相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""84.69"",""TMin"":""22.47"",""TAvg"":""36.58"",""DMax"":""0.63"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.22"",""C99"":""0.27""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 15:55:34"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[12.243,8.784,24.0,21.608,22.71,11.802,9.205,21.978,21.682,22.474],""Train_X_max"":[41.17,38.429,82.048,82.193,84.583,40.786,39.088,83.22,84.188,84.694],""Train_X_std"":[5.846,5.873,10.876,11.343,11.595,5.893,5.918,11.467,11.688,11.654],""Train_X_mean"":[22.283,18.833,37.707,35.535,36.811,21.938,19.208,35.985,35.804,36.581],""Train_X_bais_max"":[[3.877,2.911,1.964,0.668,0.24,2.457,2.774,0.447,0.905,0.626]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.273,0.2,0.164,0.076,0.033,0.197,0.203,0.04,0.085,0.049]],""QCUL_95"":0.0567686558,""QCUL_99"":0.10066247,""QCUL_95_line"":[1.127,0.847,0.687,0.286,0.122,0.836,0.857,0.161,0.351,0.215],""QCUL_99_line"":[1.398,1.052,0.853,0.352,0.15,1.038,1.064,0.199,0.435,0.267],""T2CUL_95"":5.996,""T2CUL_99"":9.22,""T2CUL_95_line"":[0.177,0.178,0.329,0.343,0.351,0.178,0.179,0.347,0.354,0.353],""T2CUL_99_line"":[0.219,0.22,0.408,0.426,0.435,0.221,0.222,0.43,0.438,0.437],""Kesi_95"":1.582,""Kesi_99"":1.385,""Kesi_95_line"":[0.091,0.091,0.169,0.176,0.18,0.092,0.092,0.178,0.182,0.181],""Kesi_99_line"":[0.085,0.085,0.158,0.165,0.169,0.086,0.086,0.167,0.17,0.169],""COV"":[[1.0,0.99,0.891,0.878,0.875,0.999,0.99,0.876,0.871,0.872],[0.99,1.0,0.862,0.85,0.845,0.991,1.0,0.847,0.842,0.842],[0.891,0.862,1.0,0.999,0.999,0.901,0.863,0.999,0.999,0.999],[0.878,0.85,0.999,1.0,1.0,0.889,0.85,1.0,1.0,1.0],[0.875,0.845,0.999,1.0,1.0,0.885,0.846,1.0,1.0,1.0],[0.999,0.991,0.901,0.889,0.885,1.0,0.991,0.887,0.882,0.883],[0.99,1.0,0.863,0.85,0.846,0.991,1.0,0.848,0.842,0.843],[0.876,0.847,0.999,1.0,1.0,0.887,0.848,1.0,1.0,1.0],[0.871,0.842,0.999,1.0,1.0,0.882,0.842,1.0,1.0,1.0],[0.872,0.842,0.999,1.0,1.0,0.883,0.843,1.0,1.0,1.0]],""K"":2,""R"":0.998,""featValue"":[9.348,0.637,0.015,0.001,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.312,0.361,-0.607,-0.094,0.592,0.095,0.178,0.033,0.019,-0.042],[0.306,0.434,0.464,0.062,-0.088,0.69,0.121,0.011,-0.012,-0.012],[0.322,-0.217,-0.048,-0.838,-0.263,0.048,0.121,0.151,0.089,0.166],[0.321,-0.248,0.051,0.227,-0.12,-0.168,0.535,0.339,-0.093,-0.573],[0.32,-0.259,0.011,-0.077,0.112,0.089,-0.373,-0.348,-0.701,-0.229],[0.315,0.336,-0.436,0.238,-0.689,-0.129,-0.212,-0.038,-0.025,0.051],[0.306,0.432,0.464,-0.129,0.174,-0.665,-0.119,-0.012,0.01,0.013],[0.32,-0.254,0.033,0.117,0.02,-0.016,0.136,-0.719,0.529,-0.046],[0.32,-0.267,0.053,0.339,0.097,-0.061,0.229,0.132,-0.22,0.76],[0.32,-0.265,0.031,0.159,0.173,0.118,-0.619,0.451,0.404,-0.088]],""selectVec"":[[0.312,0.361],[0.306,0.434],[0.322,-0.217],[0.321,-0.248],[0.32,-0.259],[0.315,0.336],[0.306,0.432],[0.32,-0.254],[0.32,-0.267],[0.32,-0.265]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6641,""AfterCleanSamNum"":6551,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""送风机B运行"",""alarmcondition"":""[d1_10hlb20an001xq01]>40""},""copy"":false,""principal"":""2"",""precision"":""99.8%"",""rate"":""0.995"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":203,""version"":""v-2025-12-08 15:55:34"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>40))
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