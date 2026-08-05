using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA163")]
    [FCDisplay("PCA163")]
    public partial class PCA163 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A液压润滑油站控制油压力1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A液压润滑油站润滑油压力1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A液压润滑油站控制油压力2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A液压润滑油站润滑油压力2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A液压润滑油站控制油压力3")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A液压润滑油站润滑油压力3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[6] {false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[6] {false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[6] {-1,-1,-1,-1,-1,-1};

		public PCA163()
		{
			ModelID = 175;
			SysID = 29;
			FcType = enumType.Warn;
			FcName = "PCA163";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""175"",""name"":""PCA163"",""description"":""引风机A油压力"",""founder"":""admin"",""creatTime"":""2023-11-09 16:03:25"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 14:34:51"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-08 10:33:26"",""et"":""2025-11-12 01:35:32"",""duration"":313326,""number"":1045,""filter"":90,""mode"":955,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-19 12:52:10"",""et"":""2025-11-26 02:34:26"",""duration"":567736,""number"":1893,""filter"":90,""mode"":1803,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 05:21:14"",""et"":""2025-12-07 10:50:14"",""duration"":883740,""number"":2946,""filter"":90,""mode"":2856,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hnc41cp101"",""Description"":""引风机A液压润滑油站控制油压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""4.76"",""TMin"":""4.69"",""TAvg"":""4.74"",""DMax"":""0.02"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""},{""PointId"":""d1_10hnc41cp104"",""Description"":""引风机A液压润滑油站润滑油压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""0.26"",""TMin"":""0.26"",""TAvg"":""0.26"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""},{""PointId"":""d1_10hnc41cp102"",""Description"":""引风机A液压润滑油站控制油压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""4.75"",""TMin"":""4.68"",""TAvg"":""4.73"",""DMax"":""0.01"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""},{""PointId"":""d1_10hnc41cp105"",""Description"":""引风机A液压润滑油站润滑油压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""0.26"",""TMin"":""0.26"",""TAvg"":""0.26"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""},{""PointId"":""d1_10hnc41cp901"",""Description"":""引风机A液压润滑油站控制油压力3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""4.75"",""TMin"":""4.66"",""TAvg"":""4.72"",""DMax"":""0.01"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.01""},{""PointId"":""d1_10hnc41cp902"",""Description"":""引风机A液压润滑油站润滑油压力3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""0.27"",""TMin"":""0.27"",""TAvg"":""0.27"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""未下装"",""version"":""v-test"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[4.692,0.257,4.682,0.255,4.662,0.269],""Train_X_max"":[4.758,0.262,4.754,0.259,4.751,0.272],""Train_X_std"":[0.007,0.001,0.007,0.001,0.008,0.0],""Train_X_mean"":[4.735,0.26,4.731,0.257,4.724,0.27],""Train_X_bais_max"":[[0.018,0.001,0.009,0.001,0.01,0.0]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.002,0.0,0.001,0.0,0.001,0.0]],""QCUL_95"":1.14697671,""QCUL_99"":1.78399289,""QCUL_95_line"":[0.007,0.001,0.003,0.001,0.004,0.0],""QCUL_99_line"":[0.008,0.001,0.004,0.001,0.005,0.0],""T2CUL_95"":9.5,""T2CUL_99"":13.299,""T2CUL_95_line"":[0.0,0.0,0.0,0.0,0.0,0.0],""T2CUL_99_line"":[0.0,0.0,0.0,0.0,0.0,0.0],""Kesi_95"":1.615,""Kesi_99"":1.468,""Kesi_95_line"":[0.0,0.0,0.0,0.0,0.0,0.0],""Kesi_99_line"":[0.0,0.0,0.0,0.0,0.0,0.0],""COV"":[[1.0,0.033,0.79,0.062,0.791,0.044],[0.033,1.0,0.046,0.816,0.029,0.403],[0.79,0.046,1.0,0.072,0.771,0.027],[0.062,0.816,0.072,1.0,0.058,0.369],[0.791,0.029,0.771,0.058,1.0,0.06],[0.044,0.403,0.027,0.369,0.06,1.0]],""K"":4,""R"":0.936,""featValue"":[2.608,2.05,0.729,0.228,0.203,0.182],""featVec"":[[-0.559,-0.156,-0.001,-0.016,-0.814,0.021],[-0.158,0.618,-0.287,0.025,0.008,0.715],[-0.555,-0.151,-0.045,0.713,0.396,-0.039],[-0.175,0.603,-0.344,-0.062,-0.012,-0.695],[-0.555,-0.154,0.035,-0.696,0.425,0.044],[-0.125,0.43,0.892,0.047,0.0,-0.042]],""selectVec"":[[-0.559,-0.156,-0.001,-0.016],[-0.158,0.618,-0.287,0.025],[-0.555,-0.151,-0.045,0.713],[-0.175,0.603,-0.344,-0.062],[-0.555,-0.154,0.035,-0.696],[-0.125,0.43,0.892,0.047]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5884,""AfterCleanSamNum"":5794,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""引风机A运行"",""alarmcondition"":""[d1_10hnc40an001xq01]>40""},""copy"":false,""principal"":""4"",""precision"":""93.6%"",""rate"":""0.9"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":175,""version"":""v-test"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[6] {IN1,IN2,IN3,IN4,IN5,IN6};
			float[] arrOUT_B = new float[6] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6};
			LD[] arrOUT_W = new LD[6] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6 };
			
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