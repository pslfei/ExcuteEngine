using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA269")]
    [FCDisplay("PCA269")]
    public partial class PCA269 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵电机绕组温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵电机绕组温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵电机绕组温度3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵电机轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵电机轴承温度2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵永磁调速器导体温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水增压泵永磁调速器轴承温度1")]
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

		public PCA269()
		{
			ModelID = 291;
			SysID = 34;
			FcType = enumType.Warn;
			FcName = "PCA269";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""291"",""name"":""PCA269"",""description"":""凝结水增压泵永磁调速器温度"",""founder"":""admin"",""creatTime"":""2024-02-27 16:10:15"",""Modifier"":""admin"",""modifiedTime"":""2025-03-12 15:15:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-03-09 17:02:18"",""et"":""2025-03-09 22:47:48"",""duration"":20730,""number"":70,""filter"":63,""mode"":7,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-03-10 16:38:51"",""et"":""2025-03-10 21:49:48"",""duration"":18657,""number"":63,""filter"":56,""mode"":7,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LCA30CT301"",""Description"":""凝结水增压泵电机绕组温度1"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.89"",""lowerBound"":""-3.89"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""80.72"",""TMin"":""38.80"",""TAvg"":""61.41"",""DMax"":""0.07"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""dcs_LCA30CT302"",""Description"":""凝结水增压泵电机绕组温度2"",""Unit"":""℃"",""Upper"":""150"",""Lower"":""15"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""2.68"",""lowerBound"":""-2.68"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""79.72"",""TMin"":""39.20"",""TAvg"":""60.85"",""DMax"":""0.17"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.20"",""C99"":""0.25""},{""PointId"":""dcs_LCA30CT303"",""Description"":""凝结水增压泵电机绕组温度3"",""Unit"":""℃"",""Upper"":""150"",""Lower"":""15"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""3.28"",""lowerBound"":""-3.28"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""80.65"",""TMin"":""38.95"",""TAvg"":""61.46"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""dcs_LCA30CT304"",""Description"":""凝结水增压泵电机轴承温度1"",""Unit"":""℃"",""Upper"":""65"",""Lower"":""20"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""5.79"",""lowerBound"":""-5.79"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""64.75"",""TMin"":""39.05"",""TAvg"":""51.70"",""DMax"":""0.74"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.70"",""C99"":""0.86""},{""PointId"":""dcs_LCA30CT305"",""Description"":""凝结水增压泵电机轴承温度2"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.09"",""lowerBound"":""-3.09"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""55.81"",""TMin"":""36.83"",""TAvg"":""46.85"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""dcs_LCA30AI003"",""Description"":""凝结水增压泵永磁调速器导体温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""50.46"",""TMin"":""27.01"",""TAvg"":""42.95"",""DMax"":""0.81"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.81"",""C99"":""0.99""},{""PointId"":""dcs_LCA30AI006"",""Description"":""凝结水增压泵永磁调速器轴承温度1"",""Unit"":""°C"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.72"",""lowerBound"":""-0.72"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""54.36"",""TMin"":""37.21"",""TAvg"":""47.52"",""DMax"":""1.33"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""1.36"",""C99"":""1.67""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-12 15:15:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[38.8,39.2,38.95,39.05,36.833,27.012,37.212],""Train_X_max"":[80.72,79.72,80.65,64.75,55.814,50.459,54.361],""Train_X_std"":[16.066,15.476,15.991,9.505,7.163,10.439,7.072],""Train_X_mean"":[61.41,60.851,61.458,51.696,46.846,42.947,47.52],""Train_X_bais_max"":[[0.072,0.171,0.141,0.74,0.246,0.812,1.332]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.001,0.0,0.001,0.002]],""Train_X_bais_mean"":[[0.025,0.05,0.036,0.18,0.065,0.214,0.364]],""QCUL_95"":0.027312208,""QCUL_99"":0.0480593964,""QCUL_95_line"":[0.092,0.198,0.133,0.696,0.252,0.806,1.358],""QCUL_99_line"":[0.114,0.245,0.164,0.859,0.311,0.993,1.672],""T2CUL_95"":7.879,""T2CUL_99"":13.329,""T2CUL_95_line"":[10.084,9.713,10.037,5.966,4.496,6.552,4.439],""T2CUL_99_line"":[13.115,12.633,13.054,7.759,5.848,8.522,5.773],""Kesi_95"":1.418,""Kesi_99"":1.206,""Kesi_95_line"":[4.279,4.121,4.259,2.531,1.908,2.78,1.883],""Kesi_99_line"":[3.945,3.8,3.926,2.334,1.759,2.563,1.737],""COV"":[[1.053,1.053,1.053,1.045,1.052,0.977,1.044],[1.053,1.053,1.053,1.047,1.053,0.972,1.042],[1.053,1.053,1.053,1.045,1.052,0.977,1.044],[1.045,1.047,1.045,1.053,1.047,0.927,1.023],[1.052,1.053,1.052,1.047,1.053,0.971,1.041],[0.977,0.972,0.977,0.927,0.971,1.053,1.007],[1.044,1.042,1.044,1.023,1.041,1.007,1.053]],""K"":2,""R"":0.999,""featValue"":[7.206,0.155,0.007,0.0,0.0,0.0,0.0],""featVec"":[[0.382,0.119,0.003,-0.318,0.004,-0.261,-0.819],[0.382,0.155,0.045,-0.449,-0.076,0.778,0.127],[0.382,0.118,0.003,-0.462,0.121,-0.555,0.551],[0.377,0.412,0.331,0.467,-0.589,-0.087,0.081],[0.381,0.159,0.153,0.44,0.776,0.102,0.002],[0.361,-0.855,0.348,0.073,-0.112,0.001,0.017],[0.381,-0.15,-0.863,0.26,-0.137,0.023,0.044]],""selectVec"":[[0.382,0.119],[0.382,0.155],[0.382,0.118],[0.377,0.412],[0.381,0.159],[0.361,-0.855],[0.381,-0.15]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":132,""AfterCleanSamNum"":20,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""凝结水增压泵运行"",""alarmcondition"":""[dcs_LCK20CP132]>0.3""},""copy"":false,""principal"":""2"",""precision"":""99.9%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":291,""version"":""v-2025-03-12 15:15:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>0.3))
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