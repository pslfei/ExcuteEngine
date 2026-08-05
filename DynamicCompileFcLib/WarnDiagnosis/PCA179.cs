using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA179")]
    [FCDisplay("PCA179")]
    public partial class PCA179 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A入口温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A入口温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A入口温度3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A入口温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A出口温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A出口温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器A出口温度")]
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

		public PCA179()
		{
			ModelID = 198;
			SysID = 47;
			FcType = enumType.Warn;
			FcName = "PCA179";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""198"",""name"":""PCA179"",""description"":""PCA179"",""founder"":""admin"",""creatTime"":""2023-11-22 14:56:02"",""Modifier"":""admin"",""modifiedTime"":""2025-01-16 11:48:21"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-04-25 02:44:32"",""et"":""2024-05-15 07:45:28"",""duration"":1746056,""number"":5821,""filter"":0,""mode"":5821,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-12-16 10:53:48"",""et"":""2025-01-16 11:38:28"",""duration"":2681080,""number"":8937,""filter"":90,""mode"":8847,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HSA20CT601"",""Description"":""反应器A入口温度1"",""Unit"":""℃"",""Upper"":""600"",""Lower"":""20"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""6.26"",""lowerBound"":""-6.26"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""391.87"",""TMin"":""328.88"",""TAvg"":""364.05"",""DMax"":""7.07"",""DMin"":""0.00"",""DAvg"":""1.40"",""C95"":""4.70"",""C99"":""5.75""},{""PointId"":""dcs_HSA20CT602"",""Description"":""反应器A入口温度2"",""Unit"":""℃"",""Upper"":""600"",""Lower"":""10"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""6.89"",""lowerBound"":""-6.89"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""392.77"",""TMin"":""336.91"",""TAvg"":""368.12"",""DMax"":""9.33"",""DMin"":""0.00"",""DAvg"":""1.64"",""C95"":""5.91"",""C99"":""7.25""},{""PointId"":""dcs_HSA20CT603"",""Description"":""反应器A入口温度3"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""14.64"",""lowerBound"":""-14.64"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""417.08"",""TMin"":""345.07"",""TAvg"":""382.96"",""DMax"":""4.86"",""DMin"":""0.00"",""DAvg"":""1.06"",""C95"":""3.67"",""C99"":""4.50""},{""PointId"":""dcs_HSA20CT101"",""Description"":""反应器A入口温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""19.22"",""lowerBound"":""-19.22"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""391.24"",""TMin"":""323.04"",""TAvg"":""362.25"",""DMax"":""17.67"",""DMin"":""0.00"",""DAvg"":""2.81"",""C95"":""10.02"",""C99"":""12.30""},{""PointId"":""dcs_HSA30CT601"",""Description"":""反应器A出口温度1"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""5.97"",""lowerBound"":""-5.97"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""435.28"",""TMin"":""374.41"",""TAvg"":""407.39"",""DMax"":""4.71"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.92"",""C99"":""3.58""},{""PointId"":""dcs_HSA30CT602"",""Description"":""反应器A出口温度2"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""9.15"",""lowerBound"":""-9.15"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""426.13"",""TMin"":""361.07"",""TAvg"":""399.33"",""DMax"":""3.82"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.39"",""C99"":""2.92""},{""PointId"":""dcs_HSA30CT101"",""Description"":""反应器A出口温度"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""368.86"",""TMin"":""318.08"",""TAvg"":""343.58"",""DMax"":""16.37"",""DMin"":""0.00"",""DAvg"":""2.68"",""C95"":""9.51"",""C99"":""11.67""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-01-16 11:48:21"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[328.878,336.91,345.067,323.037,374.407,361.074,318.081],""Train_X_max"":[391.873,392.767,417.079,391.235,435.277,426.134,368.862],""Train_X_std"":[13.083,10.073,10.904,13.003,8.576,9.574,10.537],""Train_X_mean"":[364.046,368.121,382.96,362.254,407.388,399.331,343.583],""Train_X_bais_max"":[[7.072,9.325,4.856,17.668,4.707,3.815,16.374]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.395,1.644,1.055,2.813,0.827,0.682,2.677]],""QCUL_95"":0.894949555,""QCUL_99"":1.5289079,""QCUL_95_line"":[4.701,5.905,3.672,10.023,2.917,2.386,9.506],""QCUL_99_line"":[5.747,7.253,4.5,12.304,3.579,2.924,11.667],""T2CUL_95"":7.818,""T2CUL_99"":11.351,""T2CUL_95_line"":[0.302,0.233,0.252,0.3,0.198,0.221,0.243],""T2CUL_99_line"":[0.364,0.28,0.303,0.362,0.239,0.266,0.293],""Kesi_95"":1.583,""Kesi_99"":1.379,""Kesi_95_line"":[0.136,0.105,0.113,0.135,0.089,0.099,0.109],""Kesi_99_line"":[0.127,0.098,0.106,0.126,0.083,0.093,0.102],""COV"":[[1.0,0.911,0.225,0.952,0.137,-0.007,0.905],[0.911,1.0,0.472,0.829,0.312,0.167,0.872],[0.225,0.472,1.0,0.17,0.615,0.583,0.19],[0.952,0.829,0.17,1.0,0.191,0.073,0.791],[0.137,0.312,0.615,0.191,1.0,0.97,0.085],[-0.007,0.167,0.583,0.073,0.97,1.0,-0.078],[0.905,0.872,0.19,0.791,0.085,-0.078,1.0]],""K"":3,""R"":0.958,""featValue"":[3.876,2.302,0.531,0.197,0.063,0.017,0.014],""featVec"":[[-0.473,-0.219,0.089,0.179,-0.081,-0.267,0.781],[-0.489,-0.066,-0.181,-0.133,0.822,0.098,-0.145],[-0.252,0.416,-0.801,0.233,-0.259,-0.008,-0.028],[-0.453,-0.179,0.313,0.611,-0.215,0.119,-0.481],[-0.225,0.565,0.322,-0.194,-0.004,-0.67,-0.2],[-0.154,0.604,0.339,-0.029,-0.003,0.652,0.266],[-0.441,-0.244,-0.04,-0.696,-0.452,0.175,-0.159]],""selectVec"":[[-0.473,-0.219,0.089],[-0.489,-0.066,-0.181],[-0.252,0.416,-0.801],[-0.453,-0.179,0.313],[-0.225,0.565,0.322],[-0.154,0.604,0.339],[-0.441,-0.244,-0.04]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":14758,""AfterCleanSamNum"":14661,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[dcs_AMMKA01AG001CE01]>350""},""copy"":false,""principal"":""3"",""precision"":""95.8%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":198,""version"":""v-2025-01-16 11:48:21"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>350))
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