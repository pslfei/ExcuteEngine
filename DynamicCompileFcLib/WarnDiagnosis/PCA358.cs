using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA358")]
    [FCDisplay("PCA358")]
    public partial class PCA358 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A入口压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机A出口压力")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("二次风暖风器A入口二次风压")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("二次风暖风器A出口二次风压")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A进出口二次风差压1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A进出口二次风差压2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口热二次风母管压力")]
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

		public PCA358()
		{
			ModelID = 386;
			SysID = 93;
			FcType = enumType.Warn;
			FcName = "PCA358";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""386"",""name"":""PCA358"",""description"":""A侧风压力"",""founder"":""admin"",""creatTime"":""2024-04-09 18:03:45"",""Modifier"":""admin"",""modifiedTime"":""2025-01-07 17:27:52"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-03-10 14:53:52"",""et"":""2024-04-10 09:16:04"",""duration"":2658132,""number"":8861,""filter"":539,""mode"":8322,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-12-31 15:58:30"",""et"":""2025-01-07 16:41:39"",""duration"":607389,""number"":2025,""filter"":90,""mode"":1935,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HLA21CP111"",""Description"":""送风机A入口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.07"",""lowerBound"":""-0.07"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""0.05"",""TMin"":""-0.63"",""TAvg"":""-0.30"",""DMax"":""0.08"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.05"",""C99"":""0.07""},{""PointId"":""dcs_HLA21CP112"",""Description"":""送风机A出口压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""4.94"",""TMin"":""0.10"",""TAvg"":""2.92"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.08""},{""PointId"":""dcs_HLA21CP113"",""Description"":""二次风暖风器A入口二次风压"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""4.90"",""TMin"":""-0.26"",""TAvg"":""2.87"",""DMax"":""0.16"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""dcs_HLA21CP114"",""Description"":""二次风暖风器A出口二次风压"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""4.47"",""TMin"":""-0.20"",""TAvg"":""2.59"",""DMax"":""0.17"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""dcs_HLA21DP101"",""Description"":""空预器A进出口二次风差压1"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""3.47"",""TMin"":""-0.02"",""TAvg"":""1.70"",""DMax"":""0.10"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.05"",""C99"":""0.06""},{""PointId"":""dcs_HLA21DP102"",""Description"":""空预器A进出口二次风差压2"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""2.99"",""TMin"":""-0.01"",""TAvg"":""1.48"",""DMax"":""0.06"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.05"",""C99"":""0.06""},{""PointId"":""dcs_HLA10CP103"",""Description"":""空预器A出口热二次风母管压力"",""Unit"":""KPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""1.32"",""TMin"":""-0.13"",""TAvg"":""0.59"",""DMax"":""0.16"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.10"",""C99"":""0.12""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-01-07 17:27:52"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[-0.626,0.1,-0.256,-0.203,-0.015,-0.012,-0.126],""Train_X_max"":[0.047,4.944,4.899,4.472,3.474,2.994,1.323],""Train_X_std"":[0.162,1.238,1.238,1.107,0.696,0.592,0.386],""Train_X_mean"":[-0.299,2.916,2.87,2.594,1.695,1.48,0.588],""Train_X_bais_max"":[[0.079,0.467,0.157,0.173,0.095,0.064,0.155]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.015,0.018,0.024,0.023,0.015,0.015,0.028]],""QCUL_95"":0.0915184,""QCUL_99"":0.1623696,""QCUL_95_line"":[0.053,0.065,0.085,0.083,0.05,0.051,0.097],""QCUL_99_line"":[0.065,0.08,0.105,0.102,0.061,0.063,0.119],""T2CUL_95"":5.994,""T2CUL_99"":9.216,""T2CUL_95_line"":[0.004,0.03,0.03,0.027,0.017,0.014,0.009],""T2CUL_99_line"":[0.005,0.037,0.037,0.033,0.021,0.018,0.012],""Kesi_95"":1.577,""Kesi_99"":1.373,""Kesi_95_line"":[0.002,0.015,0.015,0.014,0.009,0.007,0.005],""Kesi_99_line"":[0.002,0.014,0.014,0.013,0.008,0.007,0.004],""COV"":[[1.0,-0.949,-0.946,-0.939,-0.783,-0.789,-0.973],[-0.949,1.0,1.0,1.0,0.933,0.936,0.917],[-0.946,1.0,1.0,1.0,0.936,0.938,0.914],[-0.939,1.0,1.0,1.0,0.943,0.945,0.906],[-0.783,0.933,0.936,0.943,1.0,0.999,0.718],[-0.789,0.936,0.938,0.945,0.999,1.0,0.723],[-0.973,0.917,0.914,0.906,0.718,0.723,1.0]],""K"":2,""R"":0.996,""featValue"":[6.49,0.484,0.023,0.002,0.001,0.0,0.0],""featVec"":[[-0.372,-0.43,0.792,0.197,-0.081,0.052,0.039],[0.392,0.015,0.048,0.315,-0.153,0.844,-0.095],[0.392,0.006,0.046,0.482,-0.051,-0.293,0.723],[0.392,-0.025,0.119,0.411,-0.103,-0.437,-0.679],[0.368,-0.499,0.021,-0.175,0.764,0.039,-0.011],[0.369,-0.487,-0.027,-0.5,-0.605,-0.077,0.065],[0.358,0.573,0.594,-0.424,0.09,-0.031,0.04]],""selectVec"":[[-0.372,-0.43],[0.392,0.015],[0.392,0.006],[0.392,-0.025],[0.368,-0.499],[0.369,-0.487],[0.358,0.573]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":10886,""AfterCleanSamNum"":10347,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""送风机A运行"",""alarmcondition"":""[dcs_HLB21AN001CE]>60""},""copy"":false,""principal"":""2"",""precision"":""99.6%"",""rate"":""0.995"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":386,""version"":""v-2025-01-07 17:27:52"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>60))
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