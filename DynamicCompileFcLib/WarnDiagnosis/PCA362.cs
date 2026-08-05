using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA362")]
    [FCDisplay("PCA362")]
    public partial class PCA362 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A电机绕组温度3")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A电机绕组温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A电机轴承温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A电机绕组温度2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A电机轴承温度2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A永磁调速器导体温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热媒水循环泵A永磁调速器轴承温度1")]
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

		public PCA362()
		{
			ModelID = 390;
			SysID = 34;
			FcType = enumType.Warn;
			FcName = "PCA362";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""390"",""name"":""PCA362"",""description"":""热媒水循环泵A温度"",""founder"":""admin"",""creatTime"":""2024-04-10 11:14:10"",""Modifier"":""admin"",""modifiedTime"":""2024-05-08 18:40:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-03-26 08:57:52"",""et"":""2024-04-14 18:33:28"",""duration"":1676136,""number"":5588,""filter"":715,""mode"":4873,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LCK11CT303"",""Description"":""热媒水循环泵A电机绕组温度3"",""Unit"":""℃"",""Upper"":""111"",""Lower"":""15"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""1.38"",""lowerBound"":""-1.38"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""80.10"",""TMin"":""31.65"",""TAvg"":""68.68"",""DMax"":""2.03"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.57""},{""PointId"":""dcs_LCK11CT301"",""Description"":""热媒水循环泵A电机绕组温度1"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.24"",""lowerBound"":""-2.24"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""81.18"",""TMin"":""32.33"",""TAvg"":""69.67"",""DMax"":""3.42"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.47"",""C99"":""0.57""},{""PointId"":""dcs_LCK11CT304"",""Description"":""热媒水循环泵A电机轴承温度1"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.77"",""lowerBound"":""-1.77"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""54.20"",""TMin"":""28.27"",""TAvg"":""44.67"",""DMax"":""5.80"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.11"",""C99"":""1.37""},{""PointId"":""dcs_LCK11CT302"",""Description"":""热媒水循环泵A电机绕组温度2"",""Unit"":""℃"",""Upper"":""111"",""Lower"":""15"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""2.01"",""lowerBound"":""-2.01"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""80.17"",""TMin"":""31.13"",""TAvg"":""68.75"",""DMax"":""2.31"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.48"",""C99"":""0.59""},{""PointId"":""dcs_LCK11CT305"",""Description"":""热媒水循环泵A电机轴承温度2"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.34"",""lowerBound"":""-2.34"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""46.77"",""TMin"":""26.04"",""TAvg"":""38.03"",""DMax"":""7.12"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.72"",""C99"":""2.10""},{""PointId"":""dcs_LCK11AI003"",""Description"":""热媒水循环泵A永磁调速器导体温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.58"",""lowerBound"":""-0.58"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""105.77"",""TMin"":""47.12"",""TAvg"":""76.96"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.56""},{""PointId"":""dcs_LCK11AI006"",""Description"":""热媒水循环泵A永磁调速器轴承温度1"",""Unit"":""°C"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.29"",""lowerBound"":""-3.29"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""63.75"",""TMin"":""28.99"",""TAvg"":""47.42"",""DMax"":""10.54"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.23"",""C99"":""2.74""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-05-08 18:40:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[31.65,32.333,28.267,31.131,26.04,47.115,28.992],""Train_X_max"":[80.1,81.18,54.2,80.167,46.767,105.77,63.746],""Train_X_std"":[4.625,4.624,4.882,4.628,4.898,7.785,8.461],""Train_X_mean"":[68.678,69.673,44.671,68.752,38.033,76.959,47.418],""Train_X_bais_max"":[[2.028,3.422,5.796,2.309,7.123,2.106,10.539]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.133,0.127,0.318,0.135,0.493,0.131,0.638]],""QCUL_95"":0.133624658,""QCUL_99"":0.236453578,""QCUL_95_line"":[0.464,0.466,1.114,0.48,1.716,0.456,2.232],""QCUL_99_line"":[0.569,0.573,1.366,0.59,2.103,0.559,2.736],""T2CUL_95"":7.825,""T2CUL_99"":11.364,""T2CUL_95_line"":[0.185,0.185,0.196,0.185,0.196,0.312,0.339],""T2CUL_99_line"":[0.223,0.223,0.236,0.223,0.237,0.376,0.409],""Kesi_95"":1.599,""Kesi_99"":1.403,""Kesi_95_line"":[0.084,0.084,0.088,0.084,0.089,0.141,0.153],""Kesi_99_line"":[0.078,0.078,0.083,0.079,0.083,0.132,0.144],""COV"":[[1.0,1.0,0.961,1.0,0.929,0.569,0.752],[1.0,1.0,0.959,1.0,0.927,0.574,0.747],[0.961,0.959,1.0,0.959,0.993,0.545,0.876],[1.0,1.0,0.959,1.0,0.926,0.573,0.746],[0.929,0.927,0.993,0.926,1.0,0.548,0.896],[0.569,0.574,0.545,0.573,0.548,1.0,0.299],[0.752,0.747,0.876,0.746,0.896,0.299,1.0]],""K"":3,""R"":0.995,""featValue"":[5.902,0.75,0.313,0.035,0.002,0.0,0.0],""featVec"":[[-0.403,-0.017,0.355,-0.186,0.079,-0.464,-0.675],[-0.403,-0.026,0.358,-0.183,0.094,0.814,-0.068],[-0.408,0.106,-0.06,0.403,-0.81,0.011,-0.004],[-0.403,-0.026,0.363,-0.196,0.067,-0.35,0.735],[-0.403,0.118,-0.22,0.671,0.569,-0.013,0.013],[-0.253,-0.875,-0.396,-0.115,-0.015,-0.003,-0.004],[-0.347,0.455,-0.636,-0.517,0.024,0.004,0.003]],""selectVec"":[[-0.403,-0.017,0.355],[-0.403,-0.026,0.358],[-0.408,0.106,-0.06],[-0.403,-0.026,0.363],[-0.403,0.118,-0.22],[-0.253,-0.875,-0.396],[-0.347,0.455,-0.636]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5588,""AfterCleanSamNum"":4873,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""热媒水循环泵A运行"",""alarmcondition"":""[dcs_LCK11AI009]>150""},""copy"":false,""principal"":""3"",""precision"":""99.5%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":390,""version"":""v-2024-05-08 18:40:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>150))
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