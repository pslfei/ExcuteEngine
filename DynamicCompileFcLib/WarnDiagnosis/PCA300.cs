using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA300")]
    [FCDisplay("PCA300")]
    public partial class PCA300 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("11")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("高旁出口温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("高旁阀出口蒸汽温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("高旁阀出口蒸汽温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[3] {false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[3] {false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[3] {-1,-1,-1};

		public PCA300()
		{
			ModelID = 326;
			SysID = 92;
			FcType = enumType.Warn;
			FcName = "PCA300";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""326"",""name"":""PCA300"",""description"":""高旁温度"",""founder"":""admin"",""creatTime"":""2024-03-21 10:50:33"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:27:12"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 19:26:44"",""et"":""2025-11-26 01:05:10"",""duration"":1143506,""number"":3812,""filter"":90,""mode"":3722,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_hpt"",""Description"":""高旁出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""365.12"",""TMin"":""326.19"",""TAvg"":""348.42"",""DMax"":""0.42"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.07"",""C99"":""0.08""},{""PointId"":""d1_10lbf21ct101k"",""Description"":""高旁阀出口蒸汽温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.71"",""lowerBound"":""-0.71"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""364.55"",""TMin"":""326.29"",""TAvg"":""347.92"",""DMax"":""1.58"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.58"",""C99"":""0.71""},{""PointId"":""d1_10lbf21ct102k"",""Description"":""高旁阀出口蒸汽温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.73"",""lowerBound"":""-0.73"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""366.29"",""TMin"":""326.11"",""TAvg"":""348.92"",""DMax"":""1.61"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.59"",""C99"":""0.73""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:27:12"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[326.189,326.285,326.114],""Train_X_max"":[365.121,364.553,366.293],""Train_X_std"":[6.132,6.132,6.141],""Train_X_mean"":[348.418,347.92,348.917],""Train_X_bais_max"":[[0.415,1.579,1.613]],""Train_X_bais_min"":[[0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.013,0.154,0.157]],""QCUL_95"":0.009491467,""QCUL_99"":0.016706638,""QCUL_95_line"":[0.066,0.577,0.59],""QCUL_99_line"":[0.082,0.71,0.727],""T2CUL_95"":3.845,""T2CUL_99"":6.643,""T2CUL_95_line"":[0.197,0.197,0.197],""T2CUL_99_line"":[0.259,0.259,0.259],""Kesi_95"":1.577,""Kesi_99"":1.388,""Kesi_95_line"":[0.126,0.126,0.126],""Kesi_99_line"":[0.118,0.118,0.119],""COV"":[[1.0,1.0,1.0],[1.0,1.0,0.998],[1.0,0.998,1.0]],""K"":1,""R"":0.999,""featValue"":[2.998,0.003,0.0],""featVec"":[[0.578,-0.017,0.816],[0.577,-0.698,-0.423],[0.577,0.716,-0.393]],""selectVec"":[[0.578],[0.577],[0.577]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3812,""AfterCleanSamNum"":3722,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""11"",""alarmcondition"":""[d1_10lbf21aa101xq11]<10""},""copy"":false,""principal"":""1"",""precision"":""99.9%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":326,""version"":""v-2025-12-04 17:27:12"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[3] {IN1,IN2,IN3};
			float[] arrOUT_B = new float[3] {OUT_B1,OUT_B2,OUT_B3};
			LD[] arrOUT_W = new LD[3] { OUT_W1,OUT_W2,OUT_W3 };
			
	        if (!(Condition1<10))
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