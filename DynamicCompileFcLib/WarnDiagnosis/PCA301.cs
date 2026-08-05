using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA301")]
    [FCDisplay("PCA301")]
    public partial class PCA301 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("燃料量大于10")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁A出口温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁B出口温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁阀A出口蒸汽温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁阀B出口蒸汽温度2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁阀A出口蒸汽温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁阀B出口蒸汽温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁阀A前气动疏水阀后温度")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低旁阀B前气动疏水阀后温度")]
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

		public PCA301()
		{
			ModelID = 327;
			SysID = 92;
			FcType = enumType.Warn;
			FcName = "PCA301";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""327"",""name"":""PCA301"",""description"":""低旁温度"",""founder"":""admin"",""creatTime"":""2024-03-21 11:32:47"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:27:18"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-14 06:24:30"",""et"":""2025-12-03 09:23:16"",""duration"":1652326,""number"":5508,""filter"":90,""mode"":5418,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_lpt1"",""Description"":""低旁A出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.02"",""lowerBound"":""-0.02"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""50.74"",""TMin"":""44.03"",""TAvg"":""47.82"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_lpt2"",""Description"":""低旁B出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.03"",""lowerBound"":""-0.03"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""52.52"",""TMin"":""37.50"",""TAvg"":""42.22"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.60"",""C99"":""0.73""},{""PointId"":""d1_10map11ct102k"",""Description"":""低旁阀A出口蒸汽温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""49.14"",""TMin"":""41.19"",""TAvg"":""44.95"",""DMax"":""1.62"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""1.26"",""C99"":""1.54""},{""PointId"":""d1_10map12ct102k"",""Description"":""低旁阀B出口蒸汽温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.30"",""lowerBound"":""-0.30"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""52.96"",""TMin"":""37.84"",""TAvg"":""42.58"",""DMax"":""1.42"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.68"",""C99"":""0.83""},{""PointId"":""d1_10map11ct101k"",""Description"":""低旁阀A出口蒸汽温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.02"",""lowerBound"":""-0.02"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""54.01"",""TMin"":""46.72"",""TAvg"":""50.69"",""DMax"":""1.27"",""DMin"":""0.00"",""DAvg"":""0.28"",""C95"":""0.99"",""C99"":""1.21""},{""PointId"":""d1_10map12ct101k"",""Description"":""低旁阀B出口蒸汽温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.29"",""lowerBound"":""-0.29"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""52.07"",""TMin"":""37.15"",""TAvg"":""41.86"",""DMax"":""0.83"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.61"",""C99"":""0.75""},{""PointId"":""d1_10lbb25ct101k"",""Description"":""低旁阀A前气动疏水阀后温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.06"",""lowerBound"":""-0.06"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""456.40"",""TMin"":""47.94"",""TAvg"":""221.17"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.60"",""C99"":""3.18""},{""PointId"":""d1_10lbb26ct101k"",""Description"":""低旁阀B前气动疏水阀后温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""87.20"",""TMin"":""34.39"",""TAvg"":""44.13"",""DMax"":""0.11"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""未下装"",""version"":""v-test"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[44.033,37.497,41.185,37.835,46.716,37.15,47.937,34.385],""Train_X_max"":[50.742,52.516,49.141,52.957,54.011,52.066,456.397,87.197],""Train_X_std"":[1.39,3.104,1.476,3.195,1.597,3.016,84.843,5.012],""Train_X_mean"":[47.819,42.219,44.952,42.581,50.686,41.856,221.169,44.133],""Train_X_bais_max"":[[0.184,0.765,1.624,1.424,1.274,0.833,3.314,0.105]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0]],""Train_X_bais_mean"":[[0.039,0.172,0.361,0.189,0.284,0.175,0.746,0.024]],""QCUL_95"":0.612709939,""QCUL_99"":1.07841063,""QCUL_95_line"":[0.135,0.599,1.257,0.677,0.99,0.609,2.595,0.082],""QCUL_99_line"":[0.165,0.734,1.54,0.831,1.213,0.746,3.18,0.101],""T2CUL_95"":9.501,""T2CUL_99"":13.3,""T2CUL_95_line"":[0.058,0.13,0.062,0.134,0.067,0.126,3.553,0.21],""T2CUL_99_line"":[0.069,0.154,0.073,0.158,0.079,0.149,4.204,0.248],""Kesi_95"":1.618,""Kesi_99"":1.426,""Kesi_95_line"":[0.024,0.054,0.025,0.055,0.028,0.052,1.466,0.087],""Kesi_99_line"":[0.023,0.05,0.024,0.052,0.026,0.049,1.377,0.081],""COV"":[[1.0,0.506,0.897,0.501,0.913,0.511,0.393,0.117],[0.506,1.0,0.724,1.0,0.212,1.0,0.192,0.386],[0.897,0.724,1.0,0.72,0.637,0.728,0.331,0.227],[0.501,1.0,0.72,1.0,0.207,0.998,0.187,0.385],[0.913,0.212,0.637,0.207,1.0,0.217,0.379,-0.006],[0.511,1.0,0.728,0.998,0.217,1.0,0.197,0.386],[0.393,0.192,0.331,0.187,0.379,0.197,1.0,0.04],[0.117,0.386,0.227,0.385,-0.006,0.386,0.04,1.0]],""K"":4,""R"":0.979,""featValue"":[4.57,1.733,0.798,0.736,0.163,0.002,0.0,0.0],""featVec"":[[-0.381,-0.409,0.104,-0.22,0.086,-0.003,-0.729,-0.299],[-0.422,0.296,0.104,0.163,-0.174,-0.006,-0.31,0.755],[-0.429,-0.159,0.137,-0.092,0.767,-0.008,0.387,0.159],[-0.421,0.3,0.107,0.163,-0.18,-0.699,0.158,-0.385],[-0.268,-0.565,0.055,-0.298,-0.559,0.001,0.419,0.172],[-0.424,0.292,0.1,0.162,-0.167,0.715,0.153,-0.37],[-0.18,-0.332,-0.695,0.611,0.028,-0.006,0.0,0.0],[-0.178,0.339,-0.672,-0.634,0.015,-0.002,0.0,0.0]],""selectVec"":[[-0.381,-0.409,0.104,-0.22],[-0.422,0.296,0.104,0.163],[-0.429,-0.159,0.137,-0.092],[-0.421,0.3,0.107,0.163],[-0.268,-0.565,0.055,-0.298],[-0.424,0.292,0.1,0.162],[-0.18,-0.332,-0.695,0.611],[-0.178,0.339,-0.672,-0.634]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5508,""AfterCleanSamNum"":5418,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""燃料量大于10"",""alarmcondition"":""[d1_mw]>10""},""copy"":false,""principal"":""4"",""precision"":""97.9%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":327,""version"":""v-test"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>10))
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