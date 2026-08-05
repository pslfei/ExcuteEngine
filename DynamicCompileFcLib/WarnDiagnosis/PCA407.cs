using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA407")]
    [FCDisplay("PCA407")]
    public partial class PCA407 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽机转速大于500")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承回油温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承左前下部温度#1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承左后下部温度#1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承左前下部温度#2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承左后下部温度#2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承左前下部温度#3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5轴承左后下部温度#3")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[7] {false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[7] {false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[7] {-1,-1,-1,-1,-1,-1,-1};

		public PCA407()
		{
			ModelID = 448;
			SysID = 13;
			FcType = enumType.Warn;
			FcName = "PCA407";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""448"",""name"":""PCA407"",""description"":""#5轴承温度"",""founder"":""admin"",""creatTime"":""2025-12-04 16:28:25"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 16:29:18"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-26 04:48:20"",""duration"":1159574,""number"":3866,""filter"":90,""mode"":3776,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10mav71ct109a"",""Description"":""#5轴承回油温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""64.44"",""TMin"":""60.79"",""TAvg"":""62.99"",""DMax"":""0.03"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.02""},{""PointId"":""d1_10mad15ct113a"",""Description"":""#5轴承左前下部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""96.58"",""TMin"":""92.88"",""TAvg"":""95.04"",""DMax"":""0.58"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10mad15ct117a"",""Description"":""#5轴承左后下部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""98.63"",""TMin"":""95.90"",""TAvg"":""97.02"",""DMax"":""0.61"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10mad15ct113b"",""Description"":""#5轴承左前下部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""96.48"",""TMin"":""93.10"",""TAvg"":""95.35"",""DMax"":""0.59"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10mad15ct117b"",""Description"":""#5轴承左后下部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""98.86"",""TMin"":""96.26"",""TAvg"":""97.47"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10mad15ct113c"",""Description"":""#5轴承左前下部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""96.50"",""TMin"":""93.23"",""TAvg"":""95.42"",""DMax"":""0.55"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.15""},{""PointId"":""d1_10mad15ct117c"",""Description"":""#5轴承左后下部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""98.57"",""TMin"":""96.27"",""TAvg"":""97.45"",""DMax"":""0.53"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.14""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 16:29:18"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[60.791,92.883,95.9,93.104,96.257,93.228,96.271],""Train_X_max"":[64.436,96.584,98.63,96.482,98.864,96.501,98.565],""Train_X_std"":[0.214,0.398,0.299,0.406,0.222,0.398,0.246],""Train_X_mean"":[62.986,95.037,97.021,95.349,97.472,95.417,97.446],""Train_X_bais_max"":[[0.034,0.582,0.613,0.589,0.567,0.549,0.531]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.003,0.045,0.046,0.035,0.036,0.028,0.026]],""QCUL_95"":0.755756557,""QCUL_99"":1.25352776,""QCUL_95_line"":[0.012,0.19,0.193,0.153,0.153,0.123,0.115],""QCUL_99_line"":[0.015,0.236,0.239,0.19,0.189,0.153,0.144],""T2CUL_95"":7.828,""T2CUL_99"":11.369,""T2CUL_95_line"":[0.01,0.018,0.014,0.018,0.01,0.018,0.011],""T2CUL_99_line"":[0.012,0.022,0.016,0.022,0.012,0.022,0.013],""Kesi_95"":1.591,""Kesi_99"":1.412,""Kesi_95_line"":[0.004,0.008,0.006,0.008,0.005,0.008,0.005],""Kesi_99_line"":[0.004,0.008,0.006,0.008,0.004,0.008,0.005],""COV"":[[1.0,-0.108,0.204,-0.158,0.134,-0.147,0.188],[-0.108,1.0,0.131,0.93,0.091,0.953,0.088],[0.204,0.131,1.0,-0.146,0.879,-0.064,0.932],[-0.158,0.93,-0.146,1.0,-0.035,0.977,-0.11],[0.134,0.091,0.879,-0.035,1.0,-0.009,0.932],[-0.147,0.953,-0.064,0.977,-0.009,1.0,-0.01],[0.188,0.088,0.932,-0.11,0.932,-0.01,1.0]],""K"":3,""R"":0.966,""featValue"":[2.98,2.856,0.926,0.167,0.071,0.001,0.001],""featVec"":[[0.186,-0.055,-0.979,-0.052,0.014,0.014,-0.014],[-0.414,-0.397,-0.068,0.431,0.208,0.649,0.126],[0.343,-0.452,0.057,0.586,0.258,-0.5,-0.118],[-0.491,-0.3,-0.07,-0.325,0.227,-0.465,0.539],[0.316,-0.464,0.131,-0.592,0.425,0.243,-0.279],[-0.469,-0.337,-0.065,-0.083,-0.435,-0.192,-0.655],[0.339,-0.465,0.08,-0.072,-0.685,0.127,0.415]],""selectVec"":[[0.186,-0.055,-0.979],[-0.414,-0.397,-0.068],[0.343,-0.452,0.057],[-0.491,-0.3,-0.07],[0.316,-0.464,0.131],[-0.469,-0.337,-0.065],[0.339,-0.465,0.08]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3866,""AfterCleanSamNum"":3776,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""汽机转速大于500"",""alarmcondition"":""[d1_10cjj01yq03ai]>500""},""copy"":false,""principal"":""3"",""precision"":""96.6%"",""rate"":""0.85"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":448,""version"":""v-2025-12-04 16:29:18"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[7] {IN1,IN2,IN3,IN4,IN5,IN6,IN7};
			float[] arrOUT_B = new float[7] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7};
			LD[] arrOUT_W = new LD[7] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7 };
			
	        if (!(Condition1>500))
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