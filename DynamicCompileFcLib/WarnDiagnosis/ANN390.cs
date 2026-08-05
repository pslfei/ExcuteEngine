using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN390")]
    [FCDisplay("ANN390")]
    public partial class ANN390 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于400")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("分离器出口过热度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组给水流量")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("总风量")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("主汽压力")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("主汽温度（机侧）")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机发电机有功功率")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("校正后总燃料量")]
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

		public ANN390()
		{
			ModelID = 430;
			SysID = 24;
			FcType = enumType.Warn;
			FcName = "ANN390";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""430"",""name"":""ANN390"",""description"":""过热度"",""founder"":""admin"",""creatTime"":""2025-11-04 10:43:57"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:34:31"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-22 20:27:56"",""et"":""2025-12-04 15:08:36"",""duration"":1017640,""number"":3393,""filter"":1764,""mode"":1629,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":48,""conditionnumber"":1626},{""st"":""2025-11-09 23:00:28"",""et"":""2025-11-17 05:49:18"",""duration"":629330,""number"":2098,""filter"":712,""mode"":1386,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":52,""conditionnumber"":570}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_sep_shr"",""Description"":""分离器出口过热度"",""Unit"":"""",""Upper"":""55"",""Lower"":""15"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""14.81"",""lowerBound"":""-14.81"",""LAY_TABLE_INDEX"":1,""type"":true,""TMax"":""54.68"",""TMin"":""15.07"",""TAvg"":""32.20"",""DMax"":""22.95"",""DMin"":""-20.75"",""DAvg"":""-0.42"",""C95"":""15.41"",""C99"":""15.41""},{""PointId"":""d1_10cxd21xq01ao"",""Description"":""#1机组给水流量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":false,""TMax"":""2501.58"",""TMin"":""832.35"",""TAvg"":""1735.51"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_taf"",""Description"":""总风量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":false,""TMax"":""3932.73"",""TMin"":""1790.42"",""TAvg"":""2995.04"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_selpress"",""Description"":""主汽压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":false,""TMax"":""29.52"",""TMin"":""14.39"",""TAvg"":""23.94"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_mst"",""Description"":""主汽温度（机侧）"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":false,""TMax"":""606.60"",""TMin"":""568.58"",""TAvg"":""594.80"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_10mka01xq51"",""Description"":""#1机发电机有功功率"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":false,""TMax"":""1005.11"",""TMin"":""390.21"",""TAvg"":""726.55"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""d1_tff"",""Description"":""校正后总燃料量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":7,""type"":false,""TMax"":""432.36"",""TMin"":""136.76"",""TAvg"":""293.03"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:34:31"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[2501.5835,3932.73315,29.5228214,606.598145,1005.10651,432.356171],""data_min_"":[832.349365,1790.42,14.3897028,568.5829,390.214539,136.7575],""data_range_"":[1669.23413,2142.31323,15.1331177,38.01524,614.891968,295.598663],""min_"":[-0.498641461,-0.83574146,-0.950875,-14.95671,-0.634606659,-0.462645859],""scale_"":[0.000599077146,0.000466785161,0.0660802349,0.02630524,0.00162630191,0.00338296522]},""mms2"":{""data_max_"":[54.6802139],""data_min_"":[15.0739355],""data_range_"":[39.6062775],""min_"":[-0.380594581],""scale_"":[0.0252485219]},""train_max"":[54.6802139,2501.5835,3932.73315,29.5228214,606.598145,1005.10651,432.356171],""train_min"":[15.0739355,832.349365,1790.42,14.3897028,568.5829,390.214539,136.7575],""train_ave"":[32.196682,1735.50525,2995.04126,23.93851,594.798035,726.547,293.028839],""pre_max"":[22.9521923],""pre_min"":[-20.7522545],""pre_ave"":[-0.422984183],""pre_s"":[15.4133291],""pre_s_ave"":15.4133291,""limit"":0.3904804,""weight"":[[[-0.24759423732757568,-0.37710288166999817,0.58493906259536743,-1.1005362272262573,-1.5463865995407105],[-3.252687931060791,0.1754780113697052,0.23627674579620361,0.3586374819278717,-0.94321775436401367],[1.2695928812026978,-0.55689328908920288,-0.18263773620128632,0.22426861524581909,1.1509108543395996],[0.55582594871521,0.0014964933507144451,-0.72256100177764893,-0.37859499454498291,-0.044903639703989029],[-0.54027360677719116,-1.2990820407867432,-1.5199322700500488,0.79364418983459473,0.87328940629959106],[-1.7807043790817261,-0.031720828264951706,0.84605211019515991,0.051589887589216232,-0.43908727169036865]],[0.36560928821563721,-0.14868739247322083,0.17193883657455444,-0.12358629703521729,0.039646849036216736],[[1.0732125043869019],[-0.76838719844818115],[-0.86337721347808838],[0.81526947021484375],[0.95752155780792236]],[-0.045349005609750748]],""BeforeCleanSamNum"":5490,""AfterCleanSamNum"":3059,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于400"",""alarmcondition"":""[d1_mw]>400""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":430,""version"":""v-2025-12-04 17:34:31"",""Test_Data"":[[" + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[" + IN1 + "]]}";
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
			
	        if (!(Condition1>400))
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