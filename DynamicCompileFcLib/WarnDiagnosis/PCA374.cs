using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA374")]
    [FCDisplay("PCA374")]
    public partial class PCA374 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高加抽汽温度大于200")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("二段抽汽逆止阀后管顶壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("二段抽汽逆止阀后管底壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("二段抽汽电动闸阀后管顶壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("二段抽汽电动闸阀后管底壁温")]
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

		public PCA374()
		{
			ModelID = 409;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "PCA374";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""409"",""name"":""PCA374"",""description"":""2号高加抽汽壁温"",""founder"":""admin"",""creatTime"":""2025-03-04 11:07:54"",""Modifier"":""admin"",""modifiedTime"":""2025-03-04 11:14:39"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2025-02-10 14:07:30"",""et"":""2025-03-02 19:07:15"",""duration"":1745985,""number"":5820,""filter"":90,""mode"":5730,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ20CT611"",""Description"":""二段抽汽逆止阀后管顶壁温"",""Unit"":""℃"",""Upper"":""800"",""Lower"":""50"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""341.64"",""TMin"":""305.75"",""TAvg"":""333.49"",""DMax"":""1.55"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.11"",""C99"":""1.36""},{""PointId"":""dcs_LBQ20CT612"",""Description"":""二段抽汽逆止阀后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.30"",""lowerBound"":""-1.30"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""339.33"",""TMin"":""303.73"",""TAvg"":""332.88"",""DMax"":""1.52"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.37"",""C99"":""1.67""},{""PointId"":""dcs_LBQ20CT613"",""Description"":""二段抽汽电动闸阀后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.84"",""lowerBound"":""-1.84"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""339.76"",""TMin"":""303.01"",""TAvg"":""332.05"",""DMax"":""1.61"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.62"",""C99"":""1.99""},{""PointId"":""dcs_LBQ20CT614"",""Description"":""二段抽汽电动闸阀后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.81"",""lowerBound"":""-1.81"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""352.57"",""TMin"":""315.21"",""TAvg"":""344.44"",""DMax"":""1.54"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.27"",""C99"":""1.56""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-04 11:14:39"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[305.75,303.731,303.014,315.205],""Train_X_max"":[341.635,339.333,339.756,352.567],""Train_X_std"":[3.075,3.002,3.256,3.134],""Train_X_mean"":[333.49,332.883,332.054,344.443],""Train_X_bais_max"":[[1.551,1.52,1.611,1.539]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.337,0.412,0.471,0.366]],""QCUL_95"":0.2902579,""QCUL_99"":0.463484,""QCUL_95_line"":[1.112,1.371,1.624,1.274],""QCUL_99_line"":[1.357,1.674,1.988,1.561],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.08,0.078,0.084,0.081],""T2CUL_99_line"":[0.105,0.102,0.111,0.107],""Kesi_95"":1.572,""Kesi_99"":1.378,""Kesi_95_line"":[0.051,0.05,0.054,0.052],""Kesi_99_line"":[0.048,0.047,0.05,0.049],""COV"":[[1.0,0.961,0.967,0.99],[0.961,1.0,0.969,0.968],[0.967,0.969,1.0,0.95],[0.99,0.968,0.95,1.0]],""K"":1,""R"":0.976,""featValue"":[3.903,0.058,0.035,0.004],""featVec"":[[-0.502,0.391,0.408,-0.655],[-0.499,-0.337,-0.746,-0.283],[-0.498,-0.634,0.5,0.315],[-0.501,0.576,-0.163,0.626]],""selectVec"":[[-0.502],[-0.499],[-0.498],[-0.501]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5820,""AfterCleanSamNum"":5730,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""2号高加抽汽温度大于200"",""alarmcondition"":""[dcs_LBQ20CT601]>200""},""copy"":true,""principal"":""1"",""precision"":""97.6%"",""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":409,""version"":""v-2025-03-04 11:14:39"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>200))
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