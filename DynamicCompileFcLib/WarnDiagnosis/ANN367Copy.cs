using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN367Copy")]
    [FCDisplay("ANN367Copy")]
    public partial class ANN367Copy : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B入口烟气压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器B出口烟气温度选择后")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B出口烟温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B出口烟气压力")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机引风机B电动机电流")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B液压润滑油站油箱油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B入口电动调节动叶阀位反馈")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出5")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出5")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出5")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出5")]
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

		public ANN367Copy()
		{
			ModelID = 396;
			SysID = 29;
			FcType = enumType.Warn;
			FcName = "ANN367Copy";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""396"",""name"":""ANN367Copy"",""description"":""引风机B电流"",""founder"":""admin"",""creatTime"":""2024-05-10 17:29:28"",""Modifier"":""admin"",""modifiedTime"":""2025-12-01 09:56:33"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2025-11-02 19:10:10"",""et"":""2025-11-11 19:38:28"",""duration"":779298,""number"":2598,""filter"":90,""mode"":2508,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 19:29:16"",""et"":""2025-11-30 21:07:58"",""duration"":265122,""number"":884,""filter"":90,""mode"":794,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hna50cp102"",""Description"":""引风机B入口烟气压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""-0.92"",""TMin"":""-4.21"",""TAvg"":""-2.09"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hna20ct_sel3"",""Description"":""空预器B出口烟气温度选择后"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""141.49"",""TMin"":""62.90"",""TAvg"":""97.84"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hna50ct101r"",""Description"":""引风机B出口烟温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""119.12"",""TMin"":""70.84"",""TAvg"":""93.94"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hna50cp103"",""Description"":""引风机B出口烟气压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""2.07"",""TMin"":""0.12"",""TAvg"":""0.80"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hnc50an001xq01"",""Description"":""#1机引风机B电动机电流"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""8.08"",""lowerBound"":""-8.08"",""LAY_TABLE_INDEX"":5,""type"":true,""TMax"":""416.49"",""TMin"":""161.53"",""TAvg"":""228.22"",""DMax"":""12.48"",""DMin"":""-9.57"",""DAvg"":""0.42"",""C95"":""8.08"",""C99"":""8.08""},{""PointId"":""d1_10hnc51ct101r"",""Description"":""引风机B液压润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""44.23"",""TMin"":""37.35"",""TAvg"":""40.78"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hnc50aa101xq11"",""Description"":""引风机B入口电动调节动叶阀位反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""80.44"",""TMin"":""28.97"",""TAvg"":""51.13"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-01 09:56:33"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[-0.91898185,141.486664,119.121223,2.071533,44.23094,80.43525],""data_min_"":[-4.205452,62.8967934,70.84171,0.122941986,37.3521271,28.9668121],""data_range_"":[3.28647017,78.58987,48.27951,1.948591,6.878813,51.4684372],""min_"":[1.27962577,-0.8003168,-1.4673245,-0.06309276,-5.430025,-0.562807262],""scale_"":[0.304277837,0.0127242869,0.02071272,0.513191342,0.145373926,0.0194293838]},""mms2"":{""data_max_"":[416.485565],""data_min_"":[161.528183],""data_range_"":[254.9574],""min_"":[-0.6335497],""scale_"":[0.003922224]},""train_max"":[-0.91898185,141.486664,119.121223,2.071533,416.485565,44.23094,80.43525],""train_min"":[-4.205452,62.8967934,70.84171,0.122941986,161.528183,37.3521271,28.9668121],""train_ave"":[-2.093544,97.838,93.94359,0.8023214,228.219467,40.775898,51.1281128],""pre_max"":[12.4764376],""pre_min"":[-9.574891],""pre_ave"":[0.424661815],""pre_s"":[8.076646],""pre_s_ave"":8.076646,""limit"":0.03207009,""weight"":[[[0.27318874001502991,0.78131198883056641,2.4947817325592041,-1.6796927452087402,0.19828617572784424],[-0.013021435588598251,0.68853724002838135,-0.041973918676376343,-0.01700947992503643,0.041529435664415359],[0.085454195737838745,-0.21933208405971527,0.40929272770881653,0.11585872620344162,-0.714067280292511],[-0.88963830471038818,-1.0612471103668213,-0.14836443960666657,0.24895209074020386,0.15763244032859802],[-0.72101771831512451,0.63591110706329346,0.41153949499130249,0.50546592473983765,-0.26322063803672791],[-1.3186590671539307,-0.61280125379562378,-1.3863247632980347,0.13519643247127533,-0.7584722638130188]],[-0.24126902222633362,0.23474961519241333,0.93088608980178833,-0.29560384154319763,-0.24950900673866272],[[0.19989874958992004],[-0.28607547283172607],[-0.76633679866790771],[1.2667644023895264],[0.14520668983459473]],[0.640961229801178]],""BeforeCleanSamNum"":3482,""AfterCleanSamNum"":3392,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""引风机B运行"",""alarmcondition"":""[d1_10hnc50an001xq01]>100""},""copy"":true,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":396,""version"":""v-2025-12-01 09:56:33"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[" + IN5 + "]]}";
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

			LAExWarn[] arrIN = new LAExWarn[1] {IN5};
			float[] arrOUT_B = new float[1] {OUT_B1};
			LD[] arrOUT_W = new LD[1] { OUT_W1 };
			
	        if (!(Condition1>100))
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