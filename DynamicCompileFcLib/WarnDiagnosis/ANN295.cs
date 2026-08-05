using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN295")]
    [FCDisplay("ANN295")]
    public partial class ANN295 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵转速大于3000")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽动给水泵入口流量1（计算后）")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽动给水泵入口温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽动给水泵入口压力1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽动给水泵转速（三选后）")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽动给水泵出口温度")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽动给水泵出口压力")]
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

		public ANN295()
		{
			ModelID = 321;
			SysID = 7;
			FcType = enumType.Warn;
			FcName = "ANN295";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""321"",""name"":""ANN295"",""description"":""汽泵A入口流量"",""founder"":""admin"",""creatTime"":""2024-03-07 17:00:19"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:16:41"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-07 21:10:02"",""et"":""2025-11-22 20:27:56"",""duration"":1293474,""number"":4312,""filter"":1155,""mode"":3157,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1065}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lab20cf101_cal"",""Description"":""汽动给水泵入口流量1（计算后）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""131.29"",""lowerBound"":""-131.29"",""LAY_TABLE_INDEX"":1,""type"":true,""TMax"":""3202.10"",""TMin"":""1121.59"",""TAvg"":""1997.76"",""DMax"":""212.84"",""DMin"":""-120.85"",""DAvg"":""5.75"",""C95"":""131.29"",""C99"":""131.29""},{""PointId"":""d1_10lab20ct101k"",""Description"":""汽动给水泵入口温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""187.42"",""TMin"":""137.02"",""TAvg"":""173.19"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lab20cp101"",""Description"":""汽动给水泵入口压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""3.22"",""TMin"":""1.43"",""TAvg"":""2.54"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_mehspeed"",""Description"":""汽动给水泵转速（三选后）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""5021.66"",""TMin"":""3000.09"",""TAvg"":""4052.97"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lab30ct101k"",""Description"":""汽动给水泵出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""192.18"",""TMin"":""139.16"",""TAvg"":""177.24"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lab30cp101"",""Description"":""汽动给水泵出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""35.70"",""TMin"":""15.97"",""TAvg"":""27.45"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:16:41"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[187.424667,3.21735859,5021.65674,192.181442,35.7033424],""data_min_"":[137.017456,1.4307096,3000.08936,139.159576,15.9672594],""data_range_"":[50.40721,1.786649,2021.56726,53.02186,19.7360821],""min_"":[-2.71821165,-0.8007782,-1.48404133,-2.62457,-0.8090389],""scale_"":[0.0198384319,0.559707046,0.0004946657,0.0188601464,0.0506686158]},""mms2"":{""data_max_"":[3202.09473],""data_min_"":[1121.589],""data_range_"":[2080.50562],""min_"":[-0.5390944],""scale_"":[0.000480652379]},""train_max"":[3202.09473,187.424667,3.21735859,5021.65674,192.181442,35.7033424],""train_min"":[1121.589,137.017456,1.4307096,3000.08936,139.159576,15.9672594],""train_ave"":[1997.75708,173.190262,2.53595281,4052.9646,177.244888,27.451704],""pre_max"":[212.83696],""pre_min"":[-120.847206],""pre_ave"":[5.74834871],""pre_s"":[131.29187],""pre_s_ave"":131.29187,""limit"":0.0636477843,""weight"":[[[-0.81019216775894165,0.677330732345581,-0.087308779358863831,0.21182018518447876,0.60917913913726807],[0.81868678331375122,-0.46178644895553589,-0.2093646377325058,1.1122814416885376,-0.097611747682094574],[-2.2387256622314453,1.9491560459136963,-0.43857169151306152,2.6410613059997559,0.88293832540512085],[0.64841365814208984,-0.89596337080001831,0.31922060251235962,0.058393906801939011,-0.776580274105072],[1.4275240898132324,-0.83576101064682007,1.7349517345428467,0.084515213966369629,-1.6224995851516724]],[0.14953619241714478,-0.2327340841293335,0.2395852655172348,-1.9083499908447266,-0.15562093257904053],[[-1.3957204818725586],[1.7474386692047119],[-1.1220755577087402],[1.4109383821487427],[1.0509222745895386]],[0.057955268770456314]],""BeforeCleanSamNum"":4312,""AfterCleanSamNum"":3157,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""汽泵转速大于3000"",""alarmcondition"":""[d1_mehspeed]>3000""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":321,""version"":""v-2025-12-04 15:16:41"",""Test_Data"":[[" + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "]],\"Target_Data\":[[" + IN1 + "]]}";
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

			LAExWarn[] arrIN = new LAExWarn[1] {IN1};
			float[] arrOUT_B = new float[1] {OUT_B1};
			LD[] arrOUT_W = new LD[1] { OUT_W1 };
			
	        if (!(Condition1>3000))
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