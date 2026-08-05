using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA180")]
    [FCDisplay("PCA180")]
    public partial class PCA180 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B入口温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B入口温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B入口温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B入口温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B出口温度")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B出口温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("反应器B出口温度2")]
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

		public PCA180()
		{
			ModelID = 199;
			SysID = 47;
			FcType = enumType.Warn;
			FcName = "PCA180";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""199"",""name"":""PCA180"",""description"":""PCA180"",""founder"":""admin"",""creatTime"":""2023-11-22 15:00:49"",""Modifier"":""admin"",""modifiedTime"":""2023-11-22 15:03:46"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-04-25 04:13:48"",""et"":""2024-05-15 09:59:22"",""duration"":1748734,""number"":5830,""filter"":0,""mode"":5830,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HSA50CT101"",""Description"":""反应器B入口温度"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""385.19"",""TMin"":""331.52"",""TAvg"":""360.81"",""DMax"":""6.18"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.88"",""C99"":""4.76""},{""PointId"":""dcs_HSA50CT601"",""Description"":""反应器B入口温度1"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""412.34"",""TMin"":""343.12"",""TAvg"":""385.70"",""DMax"":""4.14"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.63"",""C99"":""3.22""},{""PointId"":""dcs_HSA50CT602"",""Description"":""反应器B入口温度2"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""396.78"",""TMin"":""338.83"",""TAvg"":""365.38"",""DMax"":""7.09"",""DMin"":""0.00"",""DAvg"":""1.33"",""C95"":""4.71"",""C99"":""5.78""},{""PointId"":""dcs_HSA50CT603"",""Description"":""反应器B入口温度3"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""388.29"",""TMin"":""338.09"",""TAvg"":""364.70"",""DMax"":""4.28"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.70"",""C99"":""3.30""},{""PointId"":""dcs_HSA60CT101"",""Description"":""反应器B出口温度"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""369.12"",""TMin"":""321.33"",""TAvg"":""341.64"",""DMax"":""8.57"",""DMin"":""0.00"",""DAvg"":""1.46"",""C95"":""5.10"",""C99"":""6.25""},{""PointId"":""dcs_HSA60CT601"",""Description"":""反应器B出口温度1"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""432.22"",""TMin"":""374.87"",""TAvg"":""403.96"",""DMax"":""10.45"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.05"",""C99"":""2.50""},{""PointId"":""dcs_HSA60CT602"",""Description"":""反应器B出口温度2"",""Unit"":""℃"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""427.37"",""TMin"":""367.02"",""TAvg"":""400.74"",""DMax"":""12.58"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.85"",""C99"":""2.27""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2023-11-22 15:03:46"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[331.515,343.119,338.829,338.087,321.328,374.867,367.019],""Train_X_max"":[385.185,412.335,396.778,388.29,369.122,432.216,427.365],""Train_X_std"":[9.715,10.162,10.344,10.359,11.352,7.824,8.48],""Train_X_mean"":[360.812,385.696,365.382,364.703,341.636,403.962,400.738],""Train_X_bais_max"":[[6.181,4.142,7.092,4.28,8.567,10.454,12.576]],""Train_X_bais_min"":[[0.0,0.0,0.001,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.076,0.75,1.332,0.797,1.464,0.595,0.507]],""QCUL_95"":0.297394633,""QCUL_99"":0.4606185,""QCUL_95_line"":[3.876,2.627,4.714,2.701,5.102,2.045,1.845],""QCUL_99_line"":[4.761,3.22,5.784,3.303,6.253,2.504,2.268],""T2CUL_95"":7.823,""T2CUL_99"":11.361,""T2CUL_95_line"":[0.356,0.372,0.379,0.379,0.416,0.287,0.311],""T2CUL_99_line"":[0.429,0.449,0.457,0.457,0.501,0.345,0.374],""Kesi_95"":1.598,""Kesi_99"":1.432,""Kesi_95_line"":[0.161,0.168,0.171,0.172,0.188,0.13,0.14],""Kesi_99_line"":[0.152,0.159,0.162,0.162,0.178,0.123,0.133],""COV"":[[1.0,0.136,0.944,0.984,0.888,0.378,0.136],[0.136,1.0,0.194,0.079,-0.135,0.757,0.833],[0.944,0.194,1.0,0.964,0.906,0.499,0.257],[0.984,0.079,0.964,1.0,0.928,0.374,0.113],[0.888,-0.135,0.906,0.928,1.0,0.277,0.019],[0.378,0.757,0.499,0.374,0.277,1.0,0.95],[0.136,0.833,0.257,0.113,0.019,0.95,1.0]],""K"":3,""R"":0.984,""featValue"":[4.177,2.428,0.287,0.053,0.036,0.015,0.005],""featVec"":[[-0.454,-0.191,0.31,-0.556,-0.252,-0.377,-0.383],[-0.178,0.546,0.687,0.364,-0.2,0.152,-0.052],[-0.473,-0.126,0.044,0.38,0.725,-0.284,-0.088],[-0.457,-0.216,0.154,-0.255,0.045,0.445,0.675],[-0.417,-0.295,-0.344,0.532,-0.566,0.071,-0.107],[-0.327,0.452,-0.409,-0.245,0.167,0.506,-0.421],[-0.221,0.558,-0.347,-0.079,-0.143,-0.543,0.446]],""selectVec"":[[-0.454,-0.191,0.31],[-0.178,0.546,0.687],[-0.473,-0.126,0.044],[-0.457,-0.216,0.154],[-0.417,-0.295,-0.344],[-0.327,0.452,-0.409],[-0.221,0.558,-0.347]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5830,""AfterCleanSamNum"":5830,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[dcs_AMMKA01AG001CE01]>350""},""copy"":false,""principal"":""3"",""precision"":""98.4%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":199,""version"":""v-2023-11-22 15:03:46"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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