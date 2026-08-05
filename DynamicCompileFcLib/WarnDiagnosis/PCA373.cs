using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA373")]
    [FCDisplay("PCA373")]
    public partial class PCA373 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高加抽汽温度大于200")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一段抽汽逆止阀后管顶壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一段抽汽逆止阀后管底壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一段抽汽电动闸阀后管顶壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一段抽汽电动闸阀后管底壁温")]
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

		public PCA373()
		{
			ModelID = 408;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "PCA373";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""408"",""name"":""PCA373"",""description"":""1号高加抽汽壁温"",""founder"":""admin"",""creatTime"":""2025-03-04 10:48:10"",""Modifier"":""admin"",""modifiedTime"":""2025-03-04 10:51:07"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-02-08 22:27:45"",""et"":""2025-02-12 03:42:00"",""duration"":278055,""number"":927,""filter"":90,""mode"":837,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-02-14 00:14:00"",""et"":""2025-03-04 01:02:30"",""duration"":1558110,""number"":5194,""filter"":90,""mode"":5104,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ10CT611"",""Description"":""一段抽汽逆止阀后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""1.57"",""lowerBound"":""-1.57"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""411.22"",""TMin"":""363.40"",""TAvg"":""400.87"",""DMax"":""1.03"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.29"",""C99"":""1.57""},{""PointId"":""dcs_LBQ10CT612"",""Description"":""一段抽汽逆止阀后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""1.31"",""lowerBound"":""-1.31"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""413.81"",""TMin"":""367.04"",""TAvg"":""403.87"",""DMax"":""1.31"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.07"",""C99"":""1.31""},{""PointId"":""dcs_LBQ10CT613"",""Description"":""一段抽汽电动闸阀后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""1.27"",""lowerBound"":""-1.27"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""414.75"",""TMin"":""366.28"",""TAvg"":""404.17"",""DMax"":""1.07"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.04"",""C99"":""1.27""},{""PointId"":""dcs_LBQ10CT614"",""Description"":""一段抽汽电动闸阀后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""1.63"",""lowerBound"":""-1.63"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""415.47"",""TMin"":""370.26"",""TAvg"":""405.90"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.34"",""C99"":""1.63""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-04 10:51:07"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[363.4,367.043,366.279,370.256],""Train_X_max"":[411.222,413.805,414.752,415.466],""Train_X_std"":[3.726,3.563,3.716,3.438],""Train_X_mean"":[400.87,403.866,404.173,405.904],""Train_X_bais_max"":[[1.033,1.311,1.066,2.114]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.394,0.32,0.315,0.398]],""QCUL_95"":0.1937253,""QCUL_99"":0.342166573,""QCUL_95_line"":[1.285,1.072,1.042,1.336],""QCUL_99_line"":[1.567,1.31,1.272,1.633],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.094,0.09,0.094,0.087],""T2CUL_99_line"":[0.124,0.118,0.123,0.114],""Kesi_95"":1.566,""Kesi_99"":1.352,""Kesi_95_line"":[0.06,0.057,0.06,0.055],""Kesi_99_line"":[0.056,0.053,0.056,0.051],""COV"":[[1.0,0.976,0.999,0.968],[0.976,1.0,0.981,0.993],[0.999,0.981,1.0,0.973],[0.968,0.993,0.973,1.0]],""K"":1,""R"":0.986,""featValue"":[3.945,0.048,0.007,0.001],""featVec"":[[0.5,0.546,0.104,-0.665],[0.501,-0.402,-0.763,-0.073],[0.501,0.442,0.025,0.744],[0.499,-0.588,0.637,-0.008]],""selectVec"":[[0.5],[0.501],[0.501],[0.499]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6120,""AfterCleanSamNum"":6030,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""1号高加抽汽温度大于200"",""alarmcondition"":""[dcs_LBQ10CT601]>200""},""copy"":false,""principal"":""1"",""precision"":""98.6%"",""rate"":""0.85"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":408,""version"":""v-2025-03-04 10:51:07"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[]]}";
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