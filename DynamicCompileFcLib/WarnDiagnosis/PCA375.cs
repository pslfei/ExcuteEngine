using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA375")]
    [FCDisplay("PCA375")]
    public partial class PCA375 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高加抽汽温度大于200")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("三段抽汽逆止阀后管顶壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("三段抽汽逆止阀后管底壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("三段抽汽电动闸阀后管顶壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("三段抽汽电动闸阀后管底壁温")]
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

		public PCA375()
		{
			ModelID = 410;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "PCA375";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""410"",""name"":""PCA375"",""description"":""3号高加抽汽壁温"",""founder"":""admin"",""creatTime"":""2025-03-04 17:15:13"",""Modifier"":""admin"",""modifiedTime"":""2025-03-04 17:17:25"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2025-02-11 00:33:45"",""et"":""2025-03-03 20:10:15"",""duration"":1798590,""number"":5996,""filter"":90,""mode"":5906,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ30CT611"",""Description"":""三段抽汽逆止阀后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.60"",""lowerBound"":""-1.60"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""513.40"",""TMin"":""477.64"",""TAvg"":""505.88"",""DMax"":""1.38"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.31"",""C99"":""1.60""},{""PointId"":""dcs_LBQ30CT612"",""Description"":""三段抽汽逆止阀后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.28"",""lowerBound"":""-3.28"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""513.05"",""TMin"":""478.48"",""TAvg"":""504.55"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.69"",""C99"":""3.28""},{""PointId"":""dcs_LBQ30CT613"",""Description"":""三段抽汽电动闸阀后管顶壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.51"",""lowerBound"":""-3.51"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""507.23"",""TMin"":""470.97"",""TAvg"":""499.55"",""DMax"":""2.02"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""2.88"",""C99"":""3.51""},{""PointId"":""dcs_LBQ30CT614"",""Description"":""三段抽汽电动闸阀后管底壁温"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.77"",""lowerBound"":""-1.77"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""512.79"",""TMin"":""478.87"",""TAvg"":""505.23"",""DMax"":""1.36"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.46"",""C99"":""1.77""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-04 17:17:25"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[477.642,478.475,470.971,478.87],""Train_X_max"":[513.4,513.05,507.231,512.793],""Train_X_std"":[4.055,4.1,4.064,3.993],""Train_X_mean"":[505.875,504.554,499.554,505.229],""Train_X_bais_max"":[[1.375,2.106,2.023,1.355]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.405,0.848,0.91,0.455]],""QCUL_95"":0.5320695,""QCUL_99"":0.9371997,""QCUL_95_line"":[1.309,2.692,2.883,1.457],""QCUL_99_line"":[1.595,3.275,3.506,1.774],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.103,0.105,0.104,0.102],""T2CUL_99_line"":[0.136,0.137,0.136,0.134],""Kesi_95"":1.577,""Kesi_99"":1.386,""Kesi_95_line"":[0.066,0.067,0.066,0.065],""Kesi_99_line"":[0.062,0.063,0.062,0.061],""COV"":[[1.0,0.942,0.989,0.971],[0.942,1.0,0.887,0.994],[0.989,0.887,1.0,0.93],[0.971,0.994,0.93,1.0]],""K"":1,""R"":0.964,""featValue"":[3.857,0.141,0.002,0.001],""featVec"":[[0.506,0.29,-0.768,0.266],[0.496,-0.61,-0.115,-0.608],[0.493,0.657,0.455,-0.343],[0.505,-0.335,0.437,0.665]],""selectVec"":[[0.506],[0.496],[0.493],[0.505]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5996,""AfterCleanSamNum"":5906,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""3号高加抽汽温度大于200"",""alarmcondition"":""[dcs_LBQ30CT601]>200""},""copy"":true,""principal"":""1"",""precision"":""96.4%"",""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":410,""version"":""v-2025-03-04 17:17:25"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[]]}";
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