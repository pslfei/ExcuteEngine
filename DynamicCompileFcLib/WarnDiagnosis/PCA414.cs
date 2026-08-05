using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA414")]
    [FCDisplay("PCA414")]
    public partial class PCA414 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("风机运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A电机绕组温度（A相）")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A风机前轴承温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A电机前轴承温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A电机绕组温度（B相）")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A风机后轴承温度")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A电机后轴承温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("密封风机A电机绕组温度（C相）")]
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

		public PCA414()
		{
			ModelID = 455;
			SysID = 31;
			FcType = enumType.Warn;
			FcName = "PCA414";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""455"",""name"":""PCA414"",""description"":""密封风机A温度"",""founder"":""admin"",""creatTime"":""2025-12-08 16:54:04"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 16:57:41"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:57:28"",""et"":""2025-11-26 00:20:32"",""duration"":1146184,""number"":3821,""filter"":90,""mode"":3731,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 22:39:32"",""et"":""2025-12-04 05:28:22"",""duration"":629330,""number"":2098,""filter"":90,""mode"":2008,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfw71ct105r"",""Description"":""密封风机A电机绕组温度（A相）"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""80.83"",""TMin"":""26.62"",""TAvg"":""60.91"",""DMax"":""1.14"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.70"",""C99"":""0.86""},{""PointId"":""d1_10hfw71ct101r"",""Description"":""密封风机A风机前轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""48.19"",""TMin"":""31.35"",""TAvg"":""40.55"",""DMax"":""0.48"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.35"",""C99"":""0.43""},{""PointId"":""d1_10hfw71ct103r"",""Description"":""密封风机A电机前轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""44.75"",""TMin"":""11.74"",""TAvg"":""31.44"",""DMax"":""2.70"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.46"",""C99"":""1.79""},{""PointId"":""d1_10hfw71ct106r"",""Description"":""密封风机A电机绕组温度（B相）"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""81.61"",""TMin"":""26.63"",""TAvg"":""61.47"",""DMax"":""1.54"",""DMin"":""0.00"",""DAvg"":""0.23"",""C95"":""0.85"",""C99"":""1.04""},{""PointId"":""d1_10hfw71ct102r"",""Description"":""密封风机A风机后轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""48.96"",""TMin"":""33.26"",""TAvg"":""41.90"",""DMax"":""1.19"",""DMin"":""0.00"",""DAvg"":""0.22"",""C95"":""0.77"",""C99"":""0.94""},{""PointId"":""d1_10hfw71ct104r"",""Description"":""密封风机A电机后轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""34.04"",""TMin"":""5.27"",""TAvg"":""21.45"",""DMax"":""1.88"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.80"",""C99"":""2.20""},{""PointId"":""d1_10hfw71ct107r"",""Description"":""密封风机A电机绕组温度（C相）"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""80.78"",""TMin"":""26.67"",""TAvg"":""60.91"",""DMax"":""1.12"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.69"",""C99"":""0.84""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 16:57:41"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[26.615,31.345,11.738,26.632,33.257,5.274,26.673],""Train_X_max"":[80.833,48.187,44.752,81.605,48.956,34.04,80.781],""Train_X_std"":[11.699,3.517,6.78,11.904,3.25,5.973,11.684],""Train_X_mean"":[60.905,40.547,31.443,61.469,41.897,21.452,60.91],""Train_X_bais_max"":[[1.144,0.477,2.698,1.538,1.193,1.878,1.124]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.197,0.103,0.384,0.234,0.221,0.534,0.193]],""QCUL_95"":0.08812824,""QCUL_99"":0.148549974,""QCUL_95_line"":[0.701,0.353,1.455,0.848,0.766,1.798,0.687],""QCUL_99_line"":[0.86,0.432,1.793,1.043,0.938,2.198,0.843],""T2CUL_95"":5.997,""T2CUL_99"":9.221,""T2CUL_95_line"":[0.375,0.113,0.217,0.382,0.104,0.192,0.375],""T2CUL_99_line"":[0.465,0.14,0.27,0.473,0.129,0.238,0.465],""Kesi_95"":1.573,""Kesi_99"":1.375,""Kesi_95_line"":[0.192,0.058,0.111,0.196,0.053,0.098,0.192],""Kesi_99_line"":[0.18,0.054,0.104,0.183,0.05,0.092,0.179],""COV"":[[1.0,0.677,0.921,1.0,0.619,0.829,1.0],[0.677,1.0,0.901,0.669,0.993,0.963,0.677],[0.921,0.901,1.0,0.917,0.861,0.974,0.922],[1.0,0.669,0.917,1.0,0.611,0.824,1.0],[0.619,0.993,0.861,0.611,1.0,0.932,0.619],[0.829,0.963,0.974,0.824,0.932,1.0,0.829],[1.0,0.677,0.922,1.0,0.619,0.829,1.0]],""K"":2,""R"":0.996,""featValue"":[6.079,0.893,0.019,0.007,0.002,0.0,0.0],""featVec"":[[0.377,-0.388,0.148,0.086,0.043,0.486,-0.663],[0.365,0.461,0.045,-0.065,0.805,0.013,0.001],[0.404,0.012,-0.275,-0.836,-0.241,-0.06,-0.006],[0.376,-0.399,0.16,0.159,0.075,-0.798,-0.078],[0.349,0.53,0.589,0.123,-0.485,-0.004,0.001],[0.395,0.214,-0.712,0.491,-0.222,0.013,0.0],[0.377,-0.388,0.145,0.086,0.044,0.349,0.745]],""selectVec"":[[0.377,-0.388],[0.365,0.461],[0.404,0.012],[0.376,-0.399],[0.349,0.53],[0.395,0.214],[0.377,-0.388]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5919,""AfterCleanSamNum"":5829,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""风机运行"",""alarmcondition"":""[d1_10hfw71an001xq01]>5""},""copy"":false,""principal"":""2"",""precision"":""99.6%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":455,""version"":""v-2025-12-08 16:57:41"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>5))
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