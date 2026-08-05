using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA195")]
    [FCDisplay("PCA195")]
    public partial class PCA195 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("给水流量大于200湿态")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给水流量大于200湿态")]
	    public LA Condition2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("贮水箱液位1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("贮水箱液位2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("贮水箱液位3")]
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

		public PCA195()
		{
			ModelID = 215;
			SysID = 25;
			FcType = enumType.Warn;
			FcName = "PCA195";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""215"",""name"":""PCA195"",""description"":""储水罐液位"",""founder"":""admin"",""creatTime"":""2023-12-07 09:36:41"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 15:21:15"",""algorithm"":""PCA"",""sampling"":""30"",""monitor"":null,""trainTime"":[{""st"":""2025-10-28 19:27:04"",""et"":""2025-10-30 03:41:52"",""duration"":116088,""number"":3870,""filter"":954,""mode"":2916,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_storlvl1"",""Description"":""贮水箱液位1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""9.83"",""TMin"":""-0.99"",""TAvg"":""8.21"",""DMax"":""0.02"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""},{""PointId"":""d1_storlvl2"",""Description"":""贮水箱液位2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""9.84"",""TMin"":""-0.96"",""TAvg"":""8.22"",""DMax"":""0.02"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""},{""PointId"":""d1_storlvl3"",""Description"":""贮水箱液位3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""9.81"",""TMin"":""-1.00"",""TAvg"":""8.20"",""DMax"":""0.01"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 15:21:15"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[-0.992,-0.96,-1.001],""Train_X_max"":[9.825,9.837,9.812],""Train_X_std"":[1.911,1.907,1.911],""Train_X_mean"":[8.207,8.219,8.196],""Train_X_bais_max"":[[0.017,0.02,0.008]],""Train_X_bais_min"":[[0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.002,0.002,0.002]],""QCUL_95"":1.51785E-05,""QCUL_99"":2.44255E-05,""QCUL_95_line"":[0.006,0.008,0.006],""QCUL_99_line"":[0.008,0.009,0.007],""T2CUL_95"":3.886,""T2CUL_99"":6.744,""T2CUL_95_line"":[0.219,0.218,0.219],""T2CUL_99_line"":[0.288,0.287,0.288],""Kesi_95"":1.564,""Kesi_99"":1.373,""Kesi_95_line"":[0.139,0.138,0.139],""Kesi_99_line"":[0.13,0.13,0.13],""COV"":[[1.003,1.003,1.003],[1.003,1.003,1.003],[1.003,1.003,1.003]],""K"":1,""R"":1.0,""featValue"":[3.01,0.0,0.0],""featVec"":[[0.577,-0.468,-0.669],[0.577,0.813,-0.07],[0.577,-0.346,0.74]],""selectVec"":[[0.577],[0.577],[0.577]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":387,""AfterCleanSamNum"":297,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""给水流量大于200湿态"",""alarmcondition"":""[d1_fwflow]>200 and [d1_mw]<350""},""copy"":false,""principal"":""1"",""precision"":""100%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":215,""version"":""v-2025-12-08 15:21:15"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>200 & Condition2<350))
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