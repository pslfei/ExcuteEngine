using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA278")]
    [FCDisplay("PCA278")]
    public partial class PCA278 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组锅炉房仪用压缩空气母管压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组汽机房房仪用压缩空气母管压力")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1锅炉压缩空气母管出口压力")]
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

		public PCA278()
		{
			ModelID = 300;
			SysID = 23;
			FcType = enumType.Warn;
			FcName = "PCA278";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""300"",""name"":""PCA278"",""description"":""PCA278"",""founder"":""admin"",""creatTime"":""2024-02-28 15:17:48"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:29:42"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-14 11:36:56"",""et"":""2025-12-04 07:42:16"",""duration"":1713920,""number"":5714,""filter"":90,""mode"":5624,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10qfb20cp101"",""Description"":""#1机组锅炉房仪用压缩空气母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""0.74"",""TMin"":""0.66"",""TAvg"":""0.72"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""},{""PointId"":""d1_10qfb02cp101"",""Description"":""#1机组汽机房房仪用压缩空气母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""0.74"",""TMin"":""0.66"",""TAvg"":""0.72"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""},{""PointId"":""d1_10hjq00cp101"",""Description"":""#1锅炉压缩空气母管出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""0.25"",""TMin"":""0.22"",""TAvg"":""0.24"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""未下装"",""version"":""v-test"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[0.655,0.657,0.224],""Train_X_max"":[0.741,0.742,0.248],""Train_X_std"":[0.011,0.011,0.003],""Train_X_mean"":[0.722,0.724,0.237],""Train_X_bais_max"":[[0.0,0.0,0.0]],""Train_X_bais_min"":[[0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.0,0.0,0.0]],""QCUL_95"":3.61084E-05,""QCUL_99"":6.34686E-05,""QCUL_95_line"":[0.0,0.0,0.0],""QCUL_99_line"":[0.0,0.0,0.0],""T2CUL_95"":5.997,""T2CUL_99"":9.221,""T2CUL_95_line"":[0.0,0.0,0.0],""T2CUL_99_line"":[0.0,0.0,0.0],""Kesi_95"":1.593,""Kesi_99"":1.412,""Kesi_95_line"":[0.0,0.0,0.0],""Kesi_99_line"":[0.0,0.0,0.0],""COV"":[[1.0,1.0,0.783],[1.0,1.0,0.784],[0.783,0.784,1.0]],""K"":2,""R"":1.0,""featValue"":[2.716,0.285,0.0],""featVec"":[[-0.594,-0.384,-0.707],[-0.594,-0.383,0.707],[-0.543,0.84,0.0]],""selectVec"":[[-0.594,-0.384],[-0.594,-0.383],[-0.543,0.84]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5714,""AfterCleanSamNum"":5624,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""全工况运行"",""alarmcondition"":null},""copy"":false,""principal"":""2"",""precision"":""100%"",""rate"":""0.99"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":300,""version"":""v-test"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "]],\"Target_Data\":[[]]}";
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