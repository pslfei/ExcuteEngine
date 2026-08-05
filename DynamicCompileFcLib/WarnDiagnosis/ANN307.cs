using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN307")]
    [FCDisplay("ANN307")]
    public partial class ANN307 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式水系统运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水供水母管压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵进口母管压力")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵出口母管压力")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式水升压泵出口母管压力")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置执行器开度反馈")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置执行器开度反馈")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵出口母管温度")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出3")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出3")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出3")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出3")]
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

		public ANN307()
		{
			ModelID = 333;
			SysID = 11;
			FcType = enumType.Warn;
			FcName = "ANN307";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""333"",""name"":""ANN307"",""description"":""闭式水系统母管压力"",""founder"":""admin"",""creatTime"":""2024-03-21 17:05:03"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:43:47"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 11:20:22"",""et"":""2025-11-12 03:49:26"",""duration"":664144,""number"":2214,""filter"":90,""mode"":2124,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 17:27:06"",""et"":""2025-12-02 14:47:26"",""duration"":508820,""number"":1697,""filter"":90,""mode"":1607,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pgb10cp101"",""Description"":""闭式循环冷却水供水母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""0.76"",""TMin"":""0.54"",""TAvg"":""0.69"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10pgb60cp101"",""Description"":""闭式循环冷却水泵进口母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""0.28"",""TMin"":""0.21"",""TAvg"":""0.27"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10pgb60cp102"",""Description"":""闭式循环冷却水泵出口母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.00"",""lowerBound"":""0.00"",""LAY_TABLE_INDEX"":3,""type"":true,""TMax"":""0.86"",""TMin"":""0.66"",""TAvg"":""0.80"",""DMax"":""0.00"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.00"",""C99"":""0.00""},{""PointId"":""d1_10pgb88cp101"",""Description"":""闭式水升压泵出口母管压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""0.86"",""TMin"":""0.66"",""TAvg"":""0.77"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10pgb60aa101xq01"",""Description"":""闭式循环冷却水泵A电机永磁调速装置执行器开度反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""0.32"",""TMin"":""0.28"",""TAvg"":""0.30"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10pgb60aa102xq01"",""Description"":""闭式循环冷却水泵B电机永磁调速装置执行器开度反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""76.41"",""TMin"":""62.91"",""TAvg"":""70.41"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10pgb60ct101r"",""Description"":""闭式循环冷却水泵出口母管温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""38.85"",""TMin"":""31.39"",""TAvg"":""34.48"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:43:47"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[0.7626311,0.279919118,0.860729039,0.3219185,76.41207,38.8466759],""data_min_"":[0.5437251,0.2086649,0.6552962,0.278381348,62.9060822,31.39467],""data_range_"":[0.218906,0.07125422,0.205432847,0.04353715,13.5059881,7.452006],""min_"":[-2.483829,-2.92845678,-3.18983173,-6.39411068,-4.657644,-4.21291542],""scale_"":[4.568171,14.0342569,4.86777067,22.96889,0.07404123,0.13419205]},""mms2"":{""data_max_"":[0.8585506],""data_min_"":[0.664998055],""data_range_"":[0.193552554],""min_"":[-3.43574929],""scale_"":[5.1665554]},""train_max"":[0.7626311,0.279919118,0.8585506,0.860729039,0.3219185,76.41207,38.8466759],""train_min"":[0.5437251,0.2086649,0.664998055,0.6552962,0.278381348,62.9060822,31.39467],""train_ave"":[0.694510937,0.26999858,0.796494544,0.771468937,0.298206627,70.41266,34.47517],""pre_max"":[0.00298586837],""pre_min"":[-0.00348157086],""pre_ave"":[-0.000134908711],""pre_s"":[0.002040622],""pre_s_ave"":0.002040622,""limit"":0.0107483584,""weight"":[[[-0.17353489995002747,1.0584332942962647,0.84135866165161133,-1.5246512889862061,0.79417073726654053],[-0.40409481525421143,-0.027194011956453323,0.67927265167236328,0.11156181246042252,0.29809275269508362],[-0.42309433221817017,-0.37029677629470825,0.57863909006118774,0.51778388023376465,0.073381543159484863],[0.37711679935455322,0.58244568109512329,0.65240508317947388,0.14765514433383942,-0.15022379159927368],[-0.20294676721096039,0.689579963684082,-1.0914326906204224,-0.43579798936843872,0.18190070986747742],[-0.18828378617763519,-0.37134292721748352,0.23311875760555267,-0.34981435537338257,-0.37152808904647827]],[0.13326220214366913,-0.24635747075080872,-0.45085826516151428,-0.087770864367485046,-0.35657128691673279],[[-0.62714028358459473],[0.522702693939209],[0.33476546406745911],[-1.1479614973068237],[0.97238808870315552]],[0.065580509603023529]],""BeforeCleanSamNum"":3910,""AfterCleanSamNum"":3820,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""闭式水系统运行"",""alarmcondition"":""[d1_10pgb60cp102]>0.3""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":333,""version"":""v-2025-12-04 15:43:47"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[" + IN3 + "]]}";
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

			LAExWarn[] arrIN = new LAExWarn[1] {IN3};
			float[] arrOUT_B = new float[1] {OUT_B1};
			LD[] arrOUT_W = new LD[1] { OUT_W1 };
			
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