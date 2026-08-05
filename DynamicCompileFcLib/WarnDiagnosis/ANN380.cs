using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN380")]
    [FCDisplay("ANN380")]
    public partial class ANN380 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B入口混合一次风风量1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B入口混合一次风压力1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机磨煤机B电动机电流")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B分离器电机频率反馈")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机B瞬时煤量反馈")]
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

		public ANN380()
		{
			ModelID = 419;
			SysID = 2;
			FcType = enumType.Warn;
			FcName = "ANN380";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""419"",""name"":""ANN380"",""description"":""磨煤机B电流"",""founder"":""admin"",""creatTime"":""2025-09-26 15:12:28"",""Modifier"":""admin"",""modifiedTime"":""2025-10-11 10:54:56"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-09-14 18:59:20"",""et"":""2025-09-19 08:00:48"",""duration"":392488,""number"":1309,""filter"":283,""mode"":1026,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":193},{""st"":""2025-09-14 17:27:12"",""et"":""2025-09-19 07:14:44"",""duration"":395252,""number"":1318,""filter"":305,""mode"":1013,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":215}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfe20cf101"",""Description"":""磨煤机B入口混合一次风风量1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":false,""TMax"":""236.13"",""TMin"":""17.70"",""TAvg"":""171.40"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10hfe20cp101"",""Description"":""磨煤机B入口混合一次风压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":false,""TMax"":""11.03"",""TMin"":""0.34"",""TAvg"":""8.32"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10hfe20aj001xq01"",""Description"":""#1机磨煤机B电动机电流"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""2.96"",""lowerBound"":""-2.96"",""LAY_TABLE_INDEX"":3,""type"":true,""TMax"":""30.87"",""TMin"":""10.10"",""TAvg"":""23.55"",""DMax"":""3.58"",""DMin"":""-5.01"",""DAvg"":""-0.05"",""C95"":""2.70"",""C99"":""2.70""},{""PointId"":""d1_10hfc20at001xq01"",""Description"":""磨煤机B分离器电机频率反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":false,""TMax"":""41.02"",""TMin"":""26.41"",""TAvg"":""34.10"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10hfb20gh001xq03"",""Description"":""给煤机B瞬时煤量反馈"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":false,""TMax"":""102.93"",""TMin"":""5.01"",""TAvg"":""71.70"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-10-11 10:54:56"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[236.133423,11.0322943,41.01774,102.929665],""data_min_"":[17.6966038,0.3363203,26.406023,5.01373243],""data_range_"":[218.436813,10.6959734,14.6117172,97.91593],""min_"":[-0.08101475,-0.0314436369,-1.80718136,-0.0512044579],""scale_"":[0.00457798271,0.09349313,0.0684382245,0.0102128424]},""mms2"":{""data_max_"":[30.8715878],""data_min_"":[10.10036],""data_range_"":[20.7712288],""min_"":[-0.486266881],""scale_"":[0.0481435172]},""train_max"":[236.133423,11.0322943,30.8715878,41.01774,102.929665],""train_min"":[17.6966038,0.3363203,10.10036,26.406023,5.01373243],""train_ave"":[171.401352,8.324499,23.5480232,34.0971031,71.70214],""pre_max"":[3.58433914],""pre_min"":[-5.00596476],""pre_ave"":[-0.0515220352],""pre_s"":[2.69940972],""pre_s_ave"":2.69940972,""limit"":0.13017194,""weight"":[[[-0.26441070437431335,1.5499781370162964,0.94063645601272583,-1.435707688331604,-1.8926621675491333],[-0.98212802410125732,-0.888581395149231,-0.95166176557540894,1.8435995578765869,0.34116950631141663],[-0.058161400258541107,-0.59998869895935059,0.0556466244161129,-1.0133200883865356,0.583881676197052],[-0.98482412099838257,-0.73418533802032471,-1.4916031360626221,1.9171887636184692,1.495991587638855]],[-0.085000559687614441,0.077261768281459808,0.24794112145900726,-0.1132800281047821,-0.0845806822180748],[[-0.53061026334762573],[-0.62903714179992676],[-0.91532701253890991],[0.75595587491989136],[0.75278788805007935]],[0.323822945356369]],""BeforeCleanSamNum"":1327,""AfterCleanSamNum"":1022,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机运行"",""alarmcondition"":""[d1_10hfe20aj001xq01]>10""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":419,""version"":""v-2025-10-11 10:54:56"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN4 + "," + IN5 + "]],\"Target_Data\":[[" + IN3 + "]]}";
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