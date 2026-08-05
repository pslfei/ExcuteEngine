using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN366")]
    [FCDisplay("ANN366")]
    public partial class ANN366 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B出口压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B出口温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("送风机B入口电动调节动叶阀位反馈")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机送风机B电动机电流")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("总二次风量")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出4")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出4")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出4")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出4")]
	    public LD OUT_W1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[1] {false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[1] {false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[1] {-1};

		public ANN366()
		{
			ModelID = 394;
			SysID = 30;
			FcType = enumType.Warn;
			FcName = "ANN366";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""394"",""name"":""ANN366"",""description"":""送风机B电流"",""founder"":""admin"",""creatTime"":""2024-05-10 17:09:56"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:30:28"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-07 15:57:36"",""et"":""2025-11-20 08:12:38"",""duration"":1095302,""number"":3652,""filter"":90,""mode"":3562,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hla20cp101"",""Description"":""送风机B出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""3.94"",""TMin"":""0.00"",""TAvg"":""1.43"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hla20ct101r"",""Description"":""送风机B出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""21.69"",""TMin"":""-4.06"",""TAvg"":""9.85"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hlb20aa101xq11"",""Description"":""送风机B入口电动调节动叶阀位反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""97.51"",""TMin"":""29.02"",""TAvg"":""61.00"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hlb20an001xq01"",""Description"":""#1机送风机B电动机电流"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.20"",""lowerBound"":""-3.20"",""LAY_TABLE_INDEX"":4,""type"":true,""TMax"":""154.28"",""TMin"":""45.75"",""TAvg"":""68.17"",""DMax"":""4.52"",""DMin"":""-5.26"",""DAvg"":""-0.23"",""C95"":""3.20"",""C99"":""3.20""},{""PointId"":""d1_10saf"",""Description"":""总二次风量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""3150.91"",""TMin"":""1039.13"",""TAvg"":""2115.87"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:30:28"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[3.93617225,21.6898613,97.5063858,3150.912],""data_min_"":[0.0,-4.05684233,29.02434,1039.128],""data_range_"":[3.93617225,25.7467041,68.48205,2111.784],""min_"":[0.0,0.157567441,-0.423824072,-0.492061675],""scale_"":[0.254053921,0.0388399251,0.0146023678,0.0004735333]},""mms2"":{""data_max_"":[154.2756],""data_min_"":[45.7469254],""data_range_"":[108.528671],""min_"":[-0.42151925],""scale_"":[0.009214154]},""train_max"":[3.93617225,21.6898613,97.5063858,154.2756,3150.912],""train_min"":[0.0,-4.05684233,29.02434,45.7469254,1039.128],""train_ave"":[1.43178785,9.852378,61.00232,68.16528,2115.87231],""pre_max"":[4.51973724],""pre_min"":[-5.25609159],""pre_ave"":[-0.231834069],""pre_s"":[3.20205617],""pre_s_ave"":3.20205617,""limit"":0.0301922038,""weight"":[[[-0.31813091039657593,-0.35094016790390015,0.65215009450912476,-0.54906243085861206,-2.8426249027252197],[-0.47069233655929565,-0.78037369251251221,0.016318326815962791,0.31145867705345154,0.086144149303436279],[0.73275476694107056,-0.72986084222793579,-0.25083175301551819,0.29950246214866638,-1.9280601739883423],[-0.04218156635761261,0.19322992861270905,-0.14091725647449493,0.30181148648262024,-0.55309021472930908]],[0.20923946797847748,-0.010771948844194412,-0.0047679203562438488,-0.10753453522920609,4.9867587089538574],[[0.63425672054290771],[0.17621637880802155],[0.44966301321983337],[1.34425687789917],[-1.737284779548645]],[0.41005429625511169]],""BeforeCleanSamNum"":3652,""AfterCleanSamNum"":3562,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""送风机B运行"",""alarmcondition"":""[d1_10hlb20an001xq01]>40""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":394,""version"":""v-2025-12-03 14:30:28"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN5 + "]],\"Target_Data\":[[" + IN4 + "]]}";
	        string jsonResult = ANN.Diagnosis(ModelInfo, InputInfo);
			if (string.IsNullOrEmpty(jsonResult)) { return; }
	        float[][] reconData = ANN.OutputInfo.reconData;
	        float[][] errorData = ANN.OutputInfo.errorData;
	        float[][] paraState = ANN.OutputInfo.paraState;
	        float[] index = ANN.OutputInfo.Index;

	        OUT_R1[0] = reconData[0][0];
	        OUT_B1[0] = errorData[0][0];
	        OUT_F1[0] = paraState[0][0];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[1] {IN4};
			float[] arrOUT_B = new float[1] {OUT_B1};
			LD[] arrOUT_W = new LD[1] { OUT_W1 };
			
	        if (!(Condition1>40))
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