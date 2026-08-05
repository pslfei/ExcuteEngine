using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA289")]
    [FCDisplay("PCA289")]
    public partial class PCA289 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝泵出口母管压力大于1.2")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵出口母管压力1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵出口母管压力2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("除氧器入口凝结水压力")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵出口母管压力")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[4] {false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[4] {false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[4] {-1,-1,-1,-1};

		public PCA289()
		{
			ModelID = 314;
			SysID = 8;
			FcType = enumType.Warn;
			FcName = "PCA289";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""314"",""name"":""PCA289"",""description"":""凝结水压力"",""founder"":""admin"",""creatTime"":""2024-03-06 14:23:35"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:27:23"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-11 05:30:26"",""et"":""2025-11-24 09:39:36"",""duration"":1138150,""number"":3794,""filter"":90,""mode"":3704,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lca22cp101"",""Description"":""凝结水泵出口母管压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""3.21"",""TMin"":""1.58"",""TAvg"":""2.45"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.15""},{""PointId"":""d1_10lca22cp102"",""Description"":""凝结水泵出口母管压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""3.21"",""TMin"":""1.58"",""TAvg"":""2.45"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.15""},{""PointId"":""d1_10lca90cp101"",""Description"":""除氧器入口凝结水压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.29"",""lowerBound"":""-0.29"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""1.35"",""TMin"":""0.38"",""TAvg"":""0.84"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.29""},{""PointId"":""d1_10lca22cp101_avg"",""Description"":""凝结水泵出口母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""3.23"",""TMin"":""1.58"",""TAvg"":""2.45"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:27:23"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[1.577,1.577,0.379,1.579],""Train_X_max"":[3.209,3.21,1.348,3.227],""Train_X_std"":[0.513,0.513,0.305,0.513],""Train_X_mean"":[2.445,2.446,0.837,2.445],""Train_X_bais_max"":[[0.152,0.152,0.281,0.153]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.037,0.037,0.069,0.037]],""QCUL_95"":0.37062934,""QCUL_99"":0.6514845,""QCUL_95_line"":[0.126,0.126,0.233,0.126],""QCUL_99_line"":[0.154,0.154,0.285,0.155],""T2CUL_95"":3.845,""T2CUL_99"":6.644,""T2CUL_95_line"":[0.017,0.017,0.01,0.017],""T2CUL_99_line"":[0.022,0.022,0.013,0.022],""Kesi_95"":1.579,""Kesi_99"":1.392,""Kesi_95_line"":[0.011,0.011,0.006,0.011],""Kesi_99_line"":[0.01,0.01,0.006,0.01],""COV"":[[1.0,1.0,0.934,1.0],[1.0,1.0,0.934,1.0],[0.934,0.934,1.0,0.934],[1.0,1.0,0.934,1.0]],""K"":1,""R"":0.975,""featValue"":[3.902,0.099,0.0,0.0],""featVec"":[[0.504,-0.281,0.408,-0.707],[0.504,-0.281,0.408,0.707],[0.487,0.873,0.0,0.0],[0.504,-0.281,-0.816,0.0]],""selectVec"":[[0.504],[0.504],[0.487],[0.504]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3794,""AfterCleanSamNum"":3704,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""凝泵出口母管压力大于1.2"",""alarmcondition"":""[d1_10lca22cp101]>1.2""},""copy"":false,""principal"":""1"",""precision"":""97.5%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":314,""version"":""v-2025-12-04 15:27:23"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[4] {IN1,IN2,IN3,IN4};
			float[] arrOUT_B = new float[4] {OUT_B1,OUT_B2,OUT_B3,OUT_B4};
			LD[] arrOUT_W = new LD[4] { OUT_W1,OUT_W2,OUT_W3,OUT_W4 };
			
	        if (!(Condition1>1.2))
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