using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA376")]
    [FCDisplay("PCA376")]
    public partial class PCA376 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("4号高加抽汽温度大于200")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("四段抽汽逆止阀1后管顶壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("四段抽汽逆止阀1后管底壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("四段抽汽逆止阀2后管顶壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("四段抽汽逆止阀2后管底壁温")]
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

		public PCA376()
		{
			ModelID = 411;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "PCA376";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""411"",""name"":""PCA376"",""description"":""4号高加抽汽壁温"",""founder"":""admin"",""creatTime"":""2025-03-04 17:23:03"",""Modifier"":""admin"",""modifiedTime"":""2025-03-04 17:30:12"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2025-02-09 07:30:30"",""et"":""2025-03-04 05:54:45"",""duration"":1981455,""number"":6605,""filter"":90,""mode"":6515,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBS40CT611"",""Description"":""四段抽汽逆止阀1后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""6.56"",""lowerBound"":""-6.56"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""366.13"",""TMin"":""335.67"",""TAvg"":""359.10"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""dcs_LBS40CT612"",""Description"":""四段抽汽逆止阀1后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.76"",""lowerBound"":""-1.76"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""380.43"",""TMin"":""348.26"",""TAvg"":""369.07"",""DMax"":""2.43"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.74"",""C99"":""0.92""},{""PointId"":""dcs_LBS40CT613"",""Description"":""四段抽汽逆止阀2后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.04"",""lowerBound"":""-1.04"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""373.97"",""TMin"":""343.65"",""TAvg"":""364.75"",""DMax"":""1.89"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.58"",""C99"":""0.72""},{""PointId"":""dcs_LBS40CT614"",""Description"":""四段抽汽逆止阀2后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""5.41"",""lowerBound"":""-5.41"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""382.93"",""TMin"":""351.28"",""TAvg"":""370.62"",""DMax"":""0.73"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.47"",""C99"":""0.58""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-04 17:30:12"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[335.674,348.255,343.65,351.275],""Train_X_max"":[366.128,380.425,373.971,382.929],""Train_X_std"":[3.644,4.427,4.173,5.058],""Train_X_mean"":[359.102,369.073,364.751,370.618],""Train_X_bais_max"":[[0.192,2.428,1.888,0.725]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.036,0.178,0.144,0.133]],""QCUL_95"":0.0278136339,""QCUL_99"":0.04763685,""QCUL_95_line"":[0.127,0.743,0.584,0.471],""QCUL_99_line"":[0.156,0.922,0.724,0.577],""T2CUL_95"":5.996,""T2CUL_99"":9.22,""T2CUL_95_line"":[0.111,0.134,0.127,0.153],""T2CUL_99_line"":[0.137,0.167,0.157,0.19],""Kesi_95"":1.576,""Kesi_99"":1.383,""Kesi_95_line"":[0.057,0.069,0.065,0.079],""Kesi_99_line"":[0.053,0.064,0.061,0.074],""COV"":[[1.0,0.789,0.82,0.643],[0.789,1.0,0.993,0.973],[0.82,0.993,1.0,0.963],[0.643,0.973,0.963,1.0]],""K"":2,""R"":0.998,""featValue"":[3.604,0.388,0.007,0.002],""featVec"":[[-0.448,-0.847,0.022,0.287],[-0.523,0.165,-0.792,-0.267],[-0.525,0.081,0.574,-0.623],[-0.5,0.499,0.206,0.676]],""selectVec"":[[-0.448,-0.847],[-0.523,0.165],[-0.525,0.081],[-0.5,0.499]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6605,""AfterCleanSamNum"":6515,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""4号高加抽汽温度大于200"",""alarmcondition"":""[dcs_LBS40CT601]>200""},""copy"":true,""principal"":""2"",""precision"":""99.8%"",""rate"":""0.9493"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":411,""version"":""v-2025-03-04 17:30:12"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[]]}";
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