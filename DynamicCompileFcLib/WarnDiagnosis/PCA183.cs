using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA183")]
    [FCDisplay("PCA183")]
    public partial class PCA183 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机非驱动端轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机定子U相绕组温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机定子V相绕组温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机定子W相绕组温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机驱动端轴承温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机非驱动端轴承温度2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机定子U相绕组温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机定子V相绕组温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A电机定子W相绕组温度2")]
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

		public PCA183()
		{
			ModelID = 202;
			SysID = 30;
			FcType = enumType.Warn;
			FcName = "PCA183";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""202"",""name"":""PCA183"",""description"":""送风机A电机温度"",""founder"":""admin"",""creatTime"":""2023-11-22 15:24:43"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 15:52:59"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:57:28"",""et"":""2025-11-24 19:19:50"",""duration"":1041742,""number"":3473,""filter"":90,""mode"":3383,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 03:07:20"",""et"":""2025-12-07 07:51:42"",""duration"":881062,""number"":2937,""filter"":90,""mode"":2847,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hlb10ct110r"",""Description"":""送风机A电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.23"",""lowerBound"":""-1.23"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""40.02"",""TMin"":""11.65"",""TAvg"":""21.59"",""DMax"":""1.67"",""DMin"":""0.00"",""DAvg"":""0.28"",""C95"":""1.00"",""C99"":""1.23""},{""PointId"":""d1_10hlb10ct112r"",""Description"":""送风机A电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.18"",""lowerBound"":""-1.18"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""34.01"",""TMin"":""7.08"",""TAvg"":""17.01"",""DMax"":""1.59"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""0.96"",""C99"":""1.18""},{""PointId"":""d1_10hlb10ct114r"",""Description"":""送风机A电机定子U相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.30"",""lowerBound"":""-0.30"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""84.48"",""TMin"":""21.70"",""TAvg"":""36.24"",""DMax"":""0.37"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.30""},{""PointId"":""d1_10hlb10ct116r"",""Description"":""送风机A电机定子V相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""88.68"",""TMin"":""23.51"",""TAvg"":""38.38"",""DMax"":""0.62"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10hlb10ct118r"",""Description"":""送风机A电机定子W相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""86.76"",""TMin"":""22.07"",""TAvg"":""36.81"",""DMax"":""0.54"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10hlb10ct111r"",""Description"":""送风机A电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.31"",""lowerBound"":""-1.31"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""39.53"",""TMin"":""11.72"",""TAvg"":""21.52"",""DMax"":""1.75"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.07"",""C99"":""1.31""},{""PointId"":""d1_10hlb10ct113r"",""Description"":""送风机A电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.92"",""lowerBound"":""-0.92"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""35.08"",""TMin"":""7.73"",""TAvg"":""17.65"",""DMax"":""1.23"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.75"",""C99"":""0.92""},{""PointId"":""d1_10hlb10ct115r"",""Description"":""送风机A电机定子U相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""86.07"",""TMin"":""22.16"",""TAvg"":""36.82"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hlb10ct117r"",""Description"":""送风机A电机定子V相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""86.80"",""TMin"":""22.75"",""TAvg"":""37.44"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hlb10ct119r"",""Description"":""送风机A电机定子W相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""86.21"",""TMin"":""21.86"",""TAvg"":""36.56"",""DMax"":""0.62"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.37""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 15:52:59"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[11.648,7.078,21.696,23.513,22.065,11.718,7.725,22.161,22.747,21.856],""Train_X_max"":[40.024,34.009,84.481,88.676,86.763,39.534,35.082,86.067,86.795,86.21],""Train_X_std"":[5.9,5.551,11.886,12.327,12.258,5.802,5.651,12.098,12.135,12.198],""Train_X_mean"":[21.588,17.008,36.24,38.377,36.809,21.517,17.65,36.824,37.443,36.555],""Train_X_bais_max"":[[1.67,1.591,0.373,0.616,0.536,1.754,1.233,0.237,0.353,0.622]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.28,0.266,0.07,0.067,0.066,0.296,0.209,0.036,0.03,0.077]],""QCUL_95"":0.0565192141,""QCUL_99"":0.0994954258,""QCUL_95_line"":[1.003,0.957,0.247,0.254,0.252,1.065,0.749,0.129,0.126,0.299],""QCUL_99_line"":[1.231,1.176,0.303,0.314,0.31,1.308,0.919,0.158,0.157,0.37],""T2CUL_95"":5.996,""T2CUL_99"":9.22,""T2CUL_95_line"":[0.182,0.171,0.366,0.38,0.378,0.179,0.174,0.373,0.374,0.376],""T2CUL_99_line"":[0.225,0.212,0.454,0.471,0.468,0.222,0.216,0.462,0.464,0.466],""Kesi_95"":1.591,""Kesi_99"":1.408,""Kesi_95_line"":[0.094,0.088,0.189,0.196,0.195,0.092,0.09,0.192,0.193,0.194],""Kesi_99_line"":[0.088,0.083,0.177,0.184,0.183,0.087,0.084,0.181,0.181,0.182],""COV"":[[1.0,0.987,0.888,0.884,0.882,1.0,0.991,0.885,0.885,0.882],[0.987,1.0,0.836,0.829,0.828,0.987,1.0,0.831,0.831,0.829],[0.888,0.836,1.0,1.0,1.0,0.883,0.853,1.0,1.0,1.0],[0.884,0.829,1.0,1.0,1.0,0.878,0.847,1.0,1.0,1.0],[0.882,0.828,1.0,1.0,1.0,0.876,0.846,1.0,1.0,1.0],[1.0,0.987,0.883,0.878,0.876,1.0,0.991,0.879,0.88,0.876],[0.991,1.0,0.853,0.847,0.846,0.991,1.0,0.849,0.849,0.847],[0.885,0.831,1.0,1.0,1.0,0.879,0.849,1.0,1.0,1.0],[0.885,0.831,1.0,1.0,1.0,0.88,0.849,1.0,1.0,1.0],[0.882,0.829,1.0,1.0,1.0,0.876,0.847,1.0,1.0,1.0]],""K"":2,""R"":0.998,""featValue"":[9.326,0.661,0.015,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.314,-0.334,-0.509,-0.056,-0.619,0.038,-0.335,-0.171,-0.002,-0.006],[-0.303,-0.458,0.518,-0.246,0.06,0.584,-0.1,0.101,0.069,0.009],[-0.321,0.24,0.056,-0.106,-0.36,0.146,0.73,-0.098,-0.313,-0.181],[-0.32,0.254,-0.034,0.582,0.275,0.335,-0.258,-0.406,-0.228,-0.148],[-0.32,0.258,0.054,-0.35,0.112,-0.181,-0.268,0.105,-0.532,0.543],[-0.313,-0.348,-0.551,-0.058,0.582,-0.006,0.325,0.17,0.004,0.008],[-0.307,-0.422,0.396,0.356,-0.032,-0.645,0.089,-0.109,-0.076,-0.009],[-0.321,0.25,0.031,0.0,-0.011,-0.011,0.155,-0.28,0.694,0.5],[-0.321,0.249,-0.001,0.342,-0.167,0.018,-0.102,0.802,0.168,-0.087],[-0.32,0.256,0.063,-0.466,0.164,-0.272,-0.24,-0.113,0.216,-0.627]],""selectVec"":[[-0.314,-0.334],[-0.303,-0.458],[-0.321,0.24],[-0.32,0.254],[-0.32,0.258],[-0.313,-0.348],[-0.307,-0.422],[-0.321,0.25],[-0.321,0.249],[-0.32,0.256]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6410,""AfterCleanSamNum"":6320,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""送风机A运行"",""alarmcondition"":""[d1_10hlb10an001xq01]>30""},""copy"":false,""principal"":""2"",""precision"":""99.8%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":202,""version"":""v-2025-12-08 15:52:59"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>30))
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