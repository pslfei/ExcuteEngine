using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA371")]
    [FCDisplay("PCA371")]
    public partial class PCA371 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("带100MW负荷")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("间冷塔热出水温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("间冷塔热出水温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("间冷塔热出水温度3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("充水箱液位1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("充水箱液位2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("充水箱液位3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[6] {false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[6] {false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[6] {-1,-1,-1,-1,-1,-1};

		public PCA371()
		{
			ModelID = 406;
			SysID = 12;
			FcType = enumType.Warn;
			FcName = "PCA371";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""406"",""name"":""PCA371"",""description"":""间冷循环充水箱液位"",""founder"":""admin"",""creatTime"":""2025-02-27 17:21:35"",""Modifier"":""admin"",""modifiedTime"":""2025-05-07 16:41:30"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-02-09 03:47:48"",""et"":""2025-02-27 10:11:52"",""duration"":1578244,""number"":5261,""filter"":90,""mode"":5171,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_PAD00CT304"",""Description"":""间冷塔热出水温度1"",""Unit"":""mm"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""32.84"",""TMin"":""8.60"",""TAvg"":""19.19"",""DMax"":""0.22"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""dcs_PAD00CT305"",""Description"":""间冷塔热出水温度2"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""32.84"",""TMin"":""8.52"",""TAvg"":""19.18"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""dcs_PAD00CT306"",""Description"":""间冷塔热出水温度3"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""32.99"",""TMin"":""8.73"",""TAvg"":""19.37"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""dcs_PAS00CL101"",""Description"":""充水箱液位1"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""3.98"",""lowerBound"":""-3.98"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""7089.48"",""TMin"":""4428.81"",""TAvg"":""6138.80"",""DMax"":""4.21"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.25"",""C99"":""3.98""},{""PointId"":""dcs_PAS00CL102"",""Description"":""充水箱液位2"",""Unit"":""MPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""4.91"",""lowerBound"":""-4.91"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""7097.39"",""TMin"":""4432.49"",""TAvg"":""6143.72"",""DMax"":""4.71"",""DMin"":""0.00"",""DAvg"":""1.14"",""C95"":""4.00"",""C99"":""4.91""},{""PointId"":""dcs_PAS00CL103"",""Description"":""充水箱液位3"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""6.23"",""lowerBound"":""-6.23"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""7085.88"",""TMin"":""4423.34"",""TAvg"":""6135.40"",""DMax"":""6.54"",""DMin"":""0.00"",""DAvg"":""1.47"",""C95"":""5.09"",""C99"":""6.23""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-05-07 16:41:30"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[8.6,8.517,8.725,4428.805,4432.493,4423.336],""Train_X_max"":[32.843,32.843,32.989,7089.477,7097.394,7085.877],""Train_X_std"":[4.745,4.762,4.746,712.585,713.042,712.552],""Train_X_mean"":[19.194,19.175,19.365,6138.803,6143.719,6135.398],""Train_X_bais_max"":[[0.22,0.181,0.242,4.207,4.71,6.544]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.002,0.0,0.001]],""Train_X_bais_mean"":[[0.022,0.025,0.026,0.96,1.141,1.471]],""QCUL_95"":0.0004362325,""QCUL_99"":0.0006884402,""QCUL_95_line"":[0.078,0.091,0.092,3.251,4.001,5.09],""QCUL_99_line"":[0.096,0.112,0.114,3.975,4.906,6.234],""T2CUL_95"":5.997,""T2CUL_99"":9.222,""T2CUL_95_line"":[0.162,0.162,0.162,24.268,24.283,24.266],""T2CUL_99_line"":[0.2,0.201,0.2,30.093,30.112,30.092],""Kesi_95"":1.583,""Kesi_99"":1.41,""Kesi_95_line"":[0.083,0.083,0.083,12.466,12.474,12.466],""Kesi_99_line"":[0.078,0.079,0.078,11.768,11.776,11.768],""COV"":[[1.0,1.0,1.0,0.687,0.687,0.687],[1.0,1.0,1.0,0.687,0.686,0.687],[1.0,1.0,1.0,0.687,0.687,0.687],[0.687,0.687,0.687,1.0,1.0,1.0],[0.687,0.686,0.687,1.0,1.0,1.0],[0.687,0.687,0.687,1.0,1.0,1.0]],""K"":2,""R"":1.0,""featValue"":[5.061,0.94,0.0,0.0,0.0,0.0],""featVec"":[[0.408,0.408,0.049,-0.815,0.003,-0.001],[0.408,0.409,0.681,0.45,-0.004,-0.003],[0.408,0.408,-0.73,0.365,0.001,0.005],[0.408,-0.408,0.004,-0.002,-0.268,0.771],[0.408,-0.409,-0.005,-0.001,-0.534,-0.618],[0.408,-0.408,0.001,0.003,0.802,-0.153]],""selectVec"":[[0.408,0.408],[0.408,0.409],[0.408,0.408],[0.408,-0.408],[0.408,-0.409],[0.408,-0.408]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5261,""AfterCleanSamNum"":5171,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""带100MW负荷"",""alarmcondition"":""[dcs_AMMKA01AG001CE01] > 100.0""},""copy"":false,""principal"":""2"",""precision"":""100%"",""rate"":""0.85"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":406,""version"":""v-2025-05-07 16:41:30"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[6] {IN1,IN2,IN3,IN4,IN5,IN6};
			float[] arrOUT_B = new float[6] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6};
			LD[] arrOUT_W = new LD[6] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6 };
			
	        if (!(Condition1 > 100.0))
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