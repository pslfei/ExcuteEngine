using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA360")]
    [FCDisplay("PCA360")]
    public partial class PCA360 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口烟气温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口烟气温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口烟气温度3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A出口烟温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器B出口烟气温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器B出口烟气温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器B出口烟气温度3")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B出口烟温")]
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

		public PCA360()
		{
			ModelID = 388;
			SysID = 93;
			FcType = enumType.Warn;
			FcName = "PCA360";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""388"",""name"":""PCA360"",""description"":""风烟系统烟温"",""founder"":""admin"",""creatTime"":""2024-04-10 09:56:28"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 10:51:08"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 10:35:44"",""et"":""2025-11-12 01:35:32"",""duration"":658788,""number"":2196,""filter"":90,""mode"":2106,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 17:27:06"",""et"":""2025-12-04 03:59:06"",""duration"":642720,""number"":2143,""filter"":90,""mode"":2053,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hna10ct107k"",""Description"":""空预器A出口烟气温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.68"",""lowerBound"":""-2.68"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""132.26"",""TMin"":""63.26"",""TAvg"":""88.81"",""DMax"":""5.33"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.19"",""C99"":""2.68""},{""PointId"":""d1_10hna10ct108k"",""Description"":""空预器A出口烟气温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.85"",""lowerBound"":""-1.85"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""135.28"",""TMin"":""64.21"",""TAvg"":""90.57"",""DMax"":""6.19"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.50"",""C99"":""1.85""},{""PointId"":""d1_10hna10ct109k"",""Description"":""空预器A出口烟气温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.18"",""lowerBound"":""-3.18"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""144.16"",""TMin"":""70.18"",""TAvg"":""98.20"",""DMax"":""7.39"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.60"",""C99"":""3.18""},{""PointId"":""d1_10hna40ct101r"",""Description"":""引风机A出口烟温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.16"",""lowerBound"":""-2.16"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""125.18"",""TMin"":""71.85"",""TAvg"":""91.33"",""DMax"":""3.15"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.74"",""C99"":""2.16""},{""PointId"":""d1_10hna20ct107k"",""Description"":""空预器B出口烟气温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.76"",""lowerBound"":""-3.76"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""142.09"",""TMin"":""67.46"",""TAvg"":""96.09"",""DMax"":""3.86"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.08"",""C99"":""3.76""},{""PointId"":""d1_10hna20ct108k"",""Description"":""空预器B出口烟气温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.90"",""lowerBound"":""-1.90"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""135.38"",""TMin"":""62.89"",""TAvg"":""90.49"",""DMax"":""6.46"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.54"",""C99"":""1.90""},{""PointId"":""d1_10hna20ct109k"",""Description"":""空预器B出口烟气温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.19"",""lowerBound"":""-3.19"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""130.23"",""TMin"":""62.85"",""TAvg"":""88.43"",""DMax"":""7.43"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.60"",""C99"":""3.19""},{""PointId"":""d1_10hna50ct101r"",""Description"":""引风机B出口烟温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.03"",""lowerBound"":""-2.03"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""119.12"",""TMin"":""70.84"",""TAvg"":""90.49"",""DMax"":""3.08"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.64"",""C99"":""2.03""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 10:51:08"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[63.257,64.21,70.183,71.849,67.464,62.893,62.85,70.842],""Train_X_max"":[132.26,135.278,144.161,125.177,142.09,135.38,130.228,119.121],""Train_X_std"":[15.73,16.244,17.335,11.27,17.526,16.85,15.927,10.956],""Train_X_mean"":[88.81,90.57,98.2,91.332,96.088,90.485,88.429,90.486],""Train_X_bais_max"":[[5.325,6.189,7.388,3.147,3.86,6.463,7.433,3.076]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.002,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.633,0.384,0.738,0.428,0.916,0.391,0.725,0.404]],""QCUL_95"":0.0607293248,""QCUL_99"":0.09366364,""QCUL_95_line"":[2.191,1.501,2.596,1.741,3.076,1.538,2.598,1.642],""QCUL_99_line"":[2.684,1.854,3.183,2.157,3.759,1.901,3.19,2.034],""T2CUL_95"":5.999,""T2CUL_99"":9.225,""T2CUL_95_line"":[0.591,0.61,0.651,0.423,0.659,0.633,0.598,0.412],""T2CUL_99_line"":[0.733,0.757,0.808,0.525,0.817,0.785,0.742,0.511],""Kesi_95"":1.585,""Kesi_99"":1.414,""Kesi_95_line"":[0.304,0.314,0.335,0.218,0.339,0.326,0.308,0.212],""Kesi_99_line"":[0.287,0.296,0.316,0.206,0.32,0.307,0.291,0.2],""COV"":[[1.0,0.999,0.994,0.881,0.993,0.997,0.997,0.874],[0.999,1.0,0.997,0.889,0.996,0.998,0.996,0.884],[0.994,0.997,1.0,0.91,0.998,0.995,0.988,0.907],[0.881,0.889,0.91,1.0,0.898,0.878,0.863,0.993],[0.993,0.996,0.998,0.898,1.0,0.997,0.991,0.898],[0.997,0.998,0.995,0.878,0.997,1.0,0.998,0.876],[0.997,0.996,0.988,0.863,0.991,0.998,1.0,0.859],[0.874,0.884,0.907,0.993,0.898,0.876,0.859,1.0]],""K"":2,""R"":0.997,""featValue"":[7.642,0.337,0.011,0.008,0.003,0.001,0.0,0.0],""featVec"":[[-0.358,0.222,0.437,-0.025,0.355,-0.344,-0.597,-0.175],[-0.359,0.191,0.141,-0.185,0.383,0.662,0.33,-0.294],[-0.361,0.1,-0.194,-0.55,0.181,-0.337,0.276,0.545],[-0.338,-0.609,0.468,-0.267,-0.468,0.065,0.022,-0.03],[-0.36,0.14,-0.553,-0.173,-0.366,-0.178,-0.073,-0.586],[-0.358,0.225,-0.175,0.217,-0.321,0.458,-0.437,0.49],[-0.356,0.279,0.251,0.588,-0.207,-0.286,0.511,0.028],[-0.337,-0.621,-0.365,0.412,0.442,-0.039,-0.034,0.022]],""selectVec"":[[-0.358,0.222],[-0.359,0.191],[-0.361,0.1],[-0.338,-0.609],[-0.36,0.14],[-0.358,0.225],[-0.356,0.279],[-0.337,-0.621]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":4338,""AfterCleanSamNum"":4248,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""引风机A运行"",""alarmcondition"":""[d1_10hnc40an001xq01]>50""},""copy"":false,""principal"":""2"",""precision"":""99.7%"",""rate"":""0.96"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":388,""version"":""v-2025-12-04 10:51:08"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>50))
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