using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN369")]
    [FCDisplay("ANN369")]
    public partial class ANN369 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A出口压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A入口电动调节动叶阀位反馈")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A出口温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机一次风机A电动机电流")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A联合油站油箱油温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A联合油站冷油器出口油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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

		public ANN369()
		{
			ModelID = 397;
			SysID = 31;
			FcType = enumType.Warn;
			FcName = "ANN369";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""397"",""name"":""ANN369"",""description"":""一次风机A电流"",""founder"":""admin"",""creatTime"":""2024-05-10 17:36:23"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:40:00"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-07 21:10:02"",""et"":""2025-11-26 03:19:04"",""duration"":1577342,""number"":5258,""filter"":90,""mode"":5168,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hla30cp101"",""Description"":""一次风机A出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""13.77"",""TMin"":""7.84"",""TAvg"":""10.77"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hlb30aa101xq11"",""Description"":""一次风机A入口电动调节动叶阀位反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""61.03"",""TMin"":""28.79"",""TAvg"":""44.50"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hla30ct101r"",""Description"":""一次风机A出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""31.25"",""TMin"":""4.36"",""TAvg"":""17.92"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hlb30an001xq01"",""Description"":""#1机一次风机A电动机电流"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""6.12"",""lowerBound"":""-6.12"",""LAY_TABLE_INDEX"":4,""type"":true,""TMax"":""156.71"",""TMin"":""73.75"",""TAvg"":""106.23"",""DMax"":""8.08"",""DMin"":""-6.62"",""DAvg"":""0.09"",""C95"":""6.12"",""C99"":""6.12""},{""PointId"":""d1_10hlb31ct101r"",""Description"":""一次风机A联合油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""46.28"",""TMin"":""39.27"",""TAvg"":""42.19"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hlb31ct102r"",""Description"":""一次风机A联合油站冷油器出口油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""39.51"",""TMin"":""31.25"",""TAvg"":""34.19"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:40:00"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[13.765027,61.0282669,31.2504749,46.28015,39.5098038],""data_min_"":[7.838307,28.7893257,4.36426544,39.27214,31.2451344],""data_range_"":[5.92672,32.23894,26.88621,7.00801,8.26467],""min_"":[-1.32253706,-0.8929985,-0.162323564,-5.60389328,-3.78056645],""scale_"":[0.1687274,0.03101839,0.03719379,0.142693862,0.120996967]},""mms2"":{""data_max_"":[156.711487],""data_min_"":[73.7545242],""data_range_"":[82.95696],""min_"":[-0.8890697],""scale_"":[0.0120544424]},""train_max"":[13.765027,61.0282669,31.2504749,156.711487,46.28015,39.5098038],""train_min"":[7.838307,28.7893257,4.36426544,73.7545242,39.27214,31.2451344],""train_ave"":[10.7651834,44.5030365,17.9223614,106.233177,42.18764,34.1877136],""pre_max"":[8.082954],""pre_min"":[-6.615977],""pre_ave"":[0.08618719],""pre_s"":[6.120647],""pre_s_ave"":6.120647,""limit"":0.0738468,""weight"":[[[0.12737967073917389,1.1184015274047852,-0.31591728329658508,-0.80988007783889771,0.48102918267250061],[0.69983208179473877,1.956812858581543,0.018419193103909492,0.16038770973682404,1.7036511898040772],[-1.0920984745025635,-0.12129585444927216,0.61555147171020508,-0.19743539392948151,-0.421368271112442],[-0.71310430765151978,-0.16187302768230438,-0.074264705181121826,0.26569780707359314,-0.402881920337677],[0.37587574124336243,-0.12993296980857849,-0.0790780633687973,-0.44188201427459717,0.38529106974601746]],[-0.22626568377017975,-1.9301894903182983,0.58293265104293823,-0.29096761345863342,-1.6474487781524658],[[-0.83700990676879883],[1.0179107189178467],[-0.8750838041305542],[0.75180965662002563],[1.3192667961120606]],[0.24845269322395325]],""BeforeCleanSamNum"":5258,""AfterCleanSamNum"":5168,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""一次风机A运行"",""alarmcondition"":""[d1_10hlb30an001xq01]>20""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":397,""version"":""v-2025-12-03 14:40:00"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN5 + "," + IN6 + "]],\"Target_Data\":[[" + IN4 + "]]}";
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
			
	        if (!(Condition1>20))
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