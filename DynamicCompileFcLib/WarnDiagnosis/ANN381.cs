using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN381")]
    [FCDisplay("ANN381")]
    public partial class ANN381 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A入口混合一次风风量1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A入口混合一次风压力1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机磨煤机A电动机电流")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A分离器电机频率反馈")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A瞬时煤量反馈")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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

		public ANN381()
		{
			ModelID = 421;
			SysID = 2;
			FcType = enumType.Warn;
			FcName = "ANN381";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""421"",""name"":""ANN381"",""description"":""磨煤机A电流"",""founder"":""admin"",""creatTime"":""2025-09-28 17:56:33"",""Modifier"":""admin"",""modifiedTime"":""2025-10-11 11:01:33"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-09-03 17:20:16"",""et"":""2025-09-19 21:03:56"",""duration"":1395820,""number"":4653,""filter"":90,""mode"":4563,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfe10cf101"",""Description"":""磨煤机A入口混合一次风风量1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":false,""TMax"":""257.38"",""TMin"":""-0.06"",""TAvg"":""176.54"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10hfe10cp101"",""Description"":""磨煤机A入口混合一次风压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":false,""TMax"":""11.18"",""TMin"":""-0.49"",""TAvg"":""8.05"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10hfe10aj001xq01"",""Description"":""#1机磨煤机A电动机电流"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""4.89"",""lowerBound"":""-4.89"",""LAY_TABLE_INDEX"":3,""type"":true,""TMax"":""36.71"",""TMin"":""10.05"",""TAvg"":""24.99"",""DMax"":""6.92"",""DMin"":""-3.93"",""DAvg"":""0.18"",""C95"":""4.66"",""C99"":""4.66""},{""PointId"":""d1_10hfc10at001xq01"",""Description"":""磨煤机A分离器电机频率反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":false,""TMax"":""43.95"",""TMin"":""24.98"",""TAvg"":""36.91"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10hfb10gh001xq03"",""Description"":""给煤机A瞬时煤量反馈"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":false,""TMax"":""103.82"",""TMin"":""-0.08"",""TAvg"":""71.65"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-10-11 11:01:33"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[257.3834,11.176507,43.95327,103.817551],""data_min_"":[-0.05828395,-0.4919266,24.984663,-0.07809234],""data_range_"":[257.441681,11.6684332,18.9686069,103.895645],""min_"":[0.0002263967,0.0421587527,-1.31715858,0.0007516421],""scale_"":[0.00388437486,0.08570131,0.0527186841,0.009625043]},""mms2"":{""data_max_"":[36.70854],""data_min_"":[10.0547752],""data_range_"":[26.6537647],""min_"":[-0.377236575],""scale_"":[0.03751815]},""train_max"":[257.3834,11.176507,36.70854,43.95327,103.817551],""train_min"":[-0.05828395,-0.4919266,10.0547752,24.984663,-0.07809234],""train_ave"":[176.537628,8.05145,24.992157,36.9129677,71.65183],""pre_max"":[6.915629],""pre_min"":[-3.9269762],""pre_ave"":[0.177828953],""pre_s"":[4.66211176],""pre_s_ave"":4.66211176,""limit"":0.176055282,""weight"":[[[-0.861573338508606,-1.1514949798583984,1.1300650835037231,-1.5775885581970215,0.20803232491016388],[1.28794527053833,0.95910543203353882,-0.28569018840789795,1.3672245740890503,-0.22157040238380432],[-0.50594961643218994,-0.34397542476654053,-1.9798091650009155,-0.008292175829410553,-0.042885251343250275],[1.5814577341079712,1.4213573932647705,0.21055994927883148,0.45299544930458069,-0.66410547494888306]],[-1.0771636962890625,-0.7560049295425415,-0.19054773449897766,-0.33837437629699707,0.47783607244491577],[[0.96959555149078369],[0.85453128814697266],[-0.71513831615448],[1.038943886756897],[-0.6068950891494751]],[-0.29595166444778442]],""BeforeCleanSamNum"":4653,""AfterCleanSamNum"":2450,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机运行"",""alarmcondition"":""[d1_10hfe10aj001xq01]>10""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":421,""version"":""v-2025-10-11 11:01:33"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN4 + "," + IN5 + "]],\"Target_Data\":[[" + IN3 + "]]}";
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
			
	        if (!(Condition1>10))
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