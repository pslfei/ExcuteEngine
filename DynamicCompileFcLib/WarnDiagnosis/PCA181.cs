using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA181")]
    [FCDisplay("PCA181")]
    public partial class PCA181 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A非驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A中轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A驱动端轴承温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A非驱动端轴承温度2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A中轴承温度2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A驱动端轴承温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A非驱动端轴承温度3")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A中轴承温度3")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A驱动端轴承温度3")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A联合油站油箱油温")]
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

		public PCA181()
		{
			ModelID = 200;
			SysID = 30;
			FcType = enumType.Warn;
			FcName = "PCA181";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""200"",""name"":""PCA181"",""description"":""送风机A轴承温度"",""founder"":""admin"",""creatTime"":""2023-11-22 15:06:13"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 15:57:47"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-26 01:05:10"",""duration"":1146184,""number"":3821,""filter"":91,""mode"":3730,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 04:36:36"",""et"":""2025-12-07 13:48:46"",""duration"":897130,""number"":2991,""filter"":90,""mode"":2901,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hlb10ct101r"",""Description"":""送风机A非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""62.44"",""TMin"":""44.97"",""TAvg"":""54.85"",""DMax"":""1.63"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.56"",""C99"":""0.69""},{""PointId"":""d1_10hlb10ct104r"",""Description"":""送风机A中轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.07"",""lowerBound"":""-1.07"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""55.17"",""TMin"":""41.09"",""TAvg"":""47.36"",""DMax"":""1.95"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""0.87"",""C99"":""1.07""},{""PointId"":""d1_10hlb10ct107r"",""Description"":""送风机A驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.64"",""lowerBound"":""-0.64"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""56.32"",""TMin"":""43.67"",""TAvg"":""49.76"",""DMax"":""1.03"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.52"",""C99"":""0.64""},{""PointId"":""d1_10hlb10ct102r"",""Description"":""送风机A非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.51"",""lowerBound"":""-0.51"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""62.13"",""TMin"":""45.78"",""TAvg"":""54.88"",""DMax"":""1.21"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.42"",""C99"":""0.51""},{""PointId"":""d1_10hlb10ct105r"",""Description"":""送风机A中轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.77"",""lowerBound"":""-0.77"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""54.54"",""TMin"":""40.19"",""TAvg"":""46.75"",""DMax"":""1.76"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.63"",""C99"":""0.77""},{""PointId"":""d1_10hlb10ct108r"",""Description"":""送风机A驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.66"",""lowerBound"":""-0.66"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""56.03"",""TMin"":""43.03"",""TAvg"":""49.19"",""DMax"":""1.12"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.54"",""C99"":""0.66""},{""PointId"":""d1_10hlb10ct103r"",""Description"":""送风机A非驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.67"",""lowerBound"":""-0.67"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""62.49"",""TMin"":""45.32"",""TAvg"":""55.06"",""DMax"":""1.56"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.54"",""C99"":""0.67""},{""PointId"":""d1_10hlb10ct106r"",""Description"":""送风机A中轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.82"",""lowerBound"":""-0.82"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""54.86"",""TMin"":""40.45"",""TAvg"":""46.96"",""DMax"":""1.82"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.66"",""C99"":""0.82""},{""PointId"":""d1_10hlb10ct109r"",""Description"":""送风机A驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.68"",""lowerBound"":""-0.68"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""56.56"",""TMin"":""43.84"",""TAvg"":""49.84"",""DMax"":""1.10"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.55"",""C99"":""0.68""},{""PointId"":""d1_10hlb11ct101r"",""Description"":""送风机A联合油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.74"",""lowerBound"":""-2.74"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""35.29"",""TMin"":""16.59"",""TAvg"":""23.97"",""DMax"":""7.11"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.22"",""C99"":""2.74""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 15:57:47"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[44.968,41.086,43.672,45.783,40.185,43.028,45.318,40.445,43.835,16.592],""Train_X_max"":[62.436,55.166,56.32,62.129,54.541,56.031,62.488,54.856,56.56,35.291],""Train_X_std"":[4.06,3.078,2.758,3.811,3.005,2.827,4.033,3.021,2.74,3.528],""Train_X_mean"":[54.846,47.364,49.762,54.88,46.748,49.19,55.059,46.963,49.839,23.968],""Train_X_bais_max"":[[1.628,1.945,1.028,1.207,1.764,1.115,1.559,1.818,1.098,7.111]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.153,0.252,0.147,0.112,0.169,0.15,0.147,0.178,0.157,0.586]],""QCUL_95"":0.341357142,""QCUL_99"":0.6066016,""QCUL_95_line"":[0.561,0.87,0.519,0.417,0.626,0.538,0.543,0.662,0.553,2.22],""QCUL_99_line"":[0.69,1.065,0.636,0.514,0.77,0.66,0.669,0.815,0.679,2.737],""T2CUL_95"":5.996,""T2CUL_99"":9.219,""T2CUL_95_line"":[0.121,0.092,0.082,0.114,0.09,0.084,0.12,0.09,0.082,0.105],""T2CUL_99_line"":[0.15,0.114,0.102,0.141,0.111,0.105,0.149,0.112,0.101,0.131],""Kesi_95"":1.573,""Kesi_99"":1.362,""Kesi_95_line"":[0.062,0.047,0.042,0.058,0.046,0.043,0.062,0.046,0.042,0.054],""Kesi_99_line"":[0.058,0.044,0.039,0.054,0.043,0.04,0.057,0.043,0.039,0.05],""COV"":[[1.0,0.934,0.958,1.0,0.927,0.959,1.0,0.929,0.954,0.864],[0.934,1.0,0.991,0.939,0.995,0.992,0.934,0.996,0.992,0.939],[0.958,0.991,1.0,0.963,0.992,1.0,0.959,0.992,1.0,0.931],[1.0,0.939,0.963,1.0,0.932,0.964,1.0,0.934,0.959,0.868],[0.927,0.995,0.992,0.932,1.0,0.992,0.928,0.999,0.993,0.946],[0.959,0.992,1.0,0.964,0.992,1.0,0.96,0.992,0.999,0.929],[1.0,0.934,0.959,1.0,0.928,0.96,1.0,0.93,0.955,0.865],[0.929,0.996,0.992,0.934,0.999,0.992,0.93,1.0,0.993,0.943],[0.954,0.992,1.0,0.959,0.993,0.999,0.955,0.993,1.0,0.934],[0.864,0.939,0.931,0.868,0.946,0.929,0.865,0.943,0.934,1.0]],""K"":2,""R"":0.99,""featValue"":[9.633,0.267,0.083,0.01,0.006,0.001,0.001,0.0,0.0,0.0],""featVec"":[[-0.313,0.456,0.168,-0.142,0.02,0.044,0.099,-0.206,-0.366,0.676],[-0.319,-0.195,-0.234,-0.567,-0.684,0.079,0.033,-0.012,-0.023,-0.083],[-0.321,-0.055,-0.18,0.418,-0.136,-0.04,0.193,0.756,-0.209,0.116],[-0.314,0.433,0.136,-0.056,-0.025,-0.098,-0.052,0.183,0.804,0.023],[-0.319,-0.247,-0.211,-0.201,0.524,0.677,-0.019,0.065,0.111,0.053],[-0.321,-0.043,-0.199,0.338,-0.094,-0.052,-0.827,-0.205,-0.063,0.032],[-0.313,0.453,0.166,-0.075,0.129,0.062,0.006,0.013,-0.37,-0.712],[-0.319,-0.235,-0.232,-0.268,0.44,-0.715,0.092,-0.051,-0.033,-0.001],[-0.321,-0.082,-0.178,0.496,-0.128,0.061,0.506,-0.551,0.148,-0.106],[-0.303,-0.484,0.818,0.046,-0.042,-0.019,-0.031,0.005,0.001,0.002]],""selectVec"":[[-0.313,0.456],[-0.319,-0.195],[-0.321,-0.055],[-0.314,0.433],[-0.319,-0.247],[-0.321,-0.043],[-0.313,0.453],[-0.319,-0.235],[-0.321,-0.082],[-0.303,-0.484]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6812,""AfterCleanSamNum"":6721,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""送风机A运行"",""alarmcondition"":""[d1_10hlb10an001xq01]>30""},""copy"":false,""principal"":""2"",""precision"":""99%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":200,""version"":""v-2025-12-08 15:57:47"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "]],\"Target_Data\":[[]]}";
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