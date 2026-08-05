using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA305")]
    [FCDisplay("PCA305")]
    public partial class PCA305 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于100")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子水流量")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子冷却水流量1计算后")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子冷却水流量2计算后")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子冷却水流量3计算后")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子冷却水流量1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子冷却水流量2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("发电机定子冷却水流量3")]
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

		public PCA305()
		{
			ModelID = 331;
			SysID = 18;
			FcType = enumType.Warn;
			FcName = "PCA305";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""331"",""name"":""PCA305"",""description"":""发电机定子冷却水流量"",""founder"":""admin"",""creatTime"":""2024-03-21 15:25:43"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 16:55:06"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 19:26:44"",""et"":""2025-11-26 03:19:04"",""duration"":1151540,""number"":3839,""filter"":90,""mode"":3749,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10mkf11ap_sel"",""Description"":""发电机定子水流量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""125.88"",""TMin"":""123.21"",""TAvg"":""124.45"",""DMax"":""0.56"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.33"",""C99"":""0.41""},{""PointId"":""d1_10mkf41cf101a_js"",""Description"":""发电机定子冷却水流量1计算后"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""106.23"",""TMin"":""104.85"",""TAvg"":""105.83"",""DMax"":""0.45"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.13""},{""PointId"":""d1_10mkf41cf101b_js"",""Description"":""发电机定子冷却水流量2计算后"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""106.20"",""TMin"":""105.23"",""TAvg"":""105.69"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.14""},{""PointId"":""d1_10mkf41cf102_js"",""Description"":""发电机定子冷却水流量3计算后"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""106.02"",""TMin"":""105.05"",""TAvg"":""105.52"",""DMax"":""0.23"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.09"",""C99"":""0.10""},{""PointId"":""d1_10mkf41cf101a"",""Description"":""发电机定子冷却水流量1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""126.52"",""TMin"":""122.26"",""TAvg"":""124.80"",""DMax"":""0.17"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.08""},{""PointId"":""d1_10mkf41cf101b"",""Description"":""发电机定子冷却水流量2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.05"",""lowerBound"":""-0.05"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""126.31"",""TMin"":""122.11"",""TAvg"":""124.48"",""DMax"":""0.88"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.36""},{""PointId"":""d1_10mkf41cf102"",""Description"":""发电机定子冷却水流量3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.25"",""lowerBound"":""-0.25"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""125.57"",""TMin"":""122.60"",""TAvg"":""124.08"",""DMax"":""0.84"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.38"",""C99"":""0.46""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 16:55:06"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[123.213,104.845,105.228,105.05,122.262,122.112,122.602],""Train_X_max"":[125.881,106.228,106.196,106.015,126.518,126.314,125.568],""Train_X_std"":[0.52,0.159,0.214,0.218,0.475,0.593,0.551],""Train_X_mean"":[124.446,105.827,105.688,105.518,124.8,124.477,124.078],""Train_X_bais_max"":[[0.557,0.454,0.186,0.227,0.167,0.876,0.836]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.095,0.03,0.032,0.024,0.019,0.084,0.108]],""QCUL_95"":0.726269066,""QCUL_99"":1.1338855,""QCUL_95_line"":[0.333,0.106,0.112,0.085,0.067,0.296,0.375],""QCUL_99_line"":[0.408,0.129,0.137,0.104,0.082,0.364,0.459],""T2CUL_95"":7.828,""T2CUL_99"":11.37,""T2CUL_95_line"":[0.024,0.007,0.01,0.01,0.022,0.027,0.025],""T2CUL_99_line"":[0.029,0.009,0.012,0.012,0.026,0.033,0.03],""Kesi_95"":1.595,""Kesi_99"":1.424,""Kesi_95_line"":[0.011,0.003,0.004,0.004,0.01,0.012,0.011],""Kesi_99_line"":[0.01,0.003,0.004,0.004,0.009,0.012,0.011],""COV"":[[1.0,0.873,0.912,0.919,0.769,0.877,0.957],[0.873,1.0,0.913,0.929,0.784,0.789,0.874],[0.912,0.913,1.0,0.982,0.736,0.856,0.921],[0.919,0.929,0.982,1.0,0.746,0.847,0.937],[0.769,0.784,0.736,0.746,1.0,0.641,0.712],[0.877,0.789,0.856,0.847,0.641,1.0,0.858],[0.957,0.874,0.921,0.937,0.712,0.858,1.0]],""K"":3,""R"":0.962,""featValue"":[6.114,0.409,0.212,0.133,0.082,0.036,0.015],""featVec"":[[-0.391,-0.083,-0.214,-0.497,-0.203,-0.706,-0.084],[-0.382,0.143,0.449,0.387,-0.689,-0.026,0.086],[-0.392,-0.124,0.297,0.158,0.558,-0.202,0.605],[-0.395,-0.096,0.34,0.062,0.357,0.071,-0.764],[-0.331,0.867,-0.314,0.008,0.16,0.124,0.009],[-0.363,-0.394,-0.67,0.495,-0.048,0.12,-0.032],[-0.388,-0.204,0.024,-0.573,-0.135,0.652,0.187]],""selectVec"":[[-0.391,-0.083,-0.214],[-0.382,0.143,0.449],[-0.392,-0.124,0.297],[-0.395,-0.096,0.34],[-0.331,0.867,-0.314],[-0.363,-0.394,-0.67],[-0.388,-0.204,0.024]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3839,""AfterCleanSamNum"":3749,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于100"",""alarmcondition"":""[d1_mw]>100""},""copy"":false,""principal"":""3"",""precision"":""96.2%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":331,""version"":""v-2025-12-04 16:55:06"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>100))
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