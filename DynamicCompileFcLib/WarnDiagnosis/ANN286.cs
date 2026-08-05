using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN286")]
    [FCDisplay("ANN286")]
    public partial class ANN286 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("进汽温度大于220")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("5号低加进汽压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("5号低加进汽温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("5号低加正常疏水气动调节阀反馈")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("5号低压加热器正常疏水出口温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("5号低压加热器水位1(计算后）")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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

		public ANN286()
		{
			ModelID = 310;
			SysID = 4;
			FcType = enumType.Warn;
			FcName = "ANN286";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""310"",""name"":""ANN286"",""description"":""5号低加液位"",""founder"":""admin"",""creatTime"":""2024-03-04 16:33:58"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 14:47:59"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 11:20:22"",""et"":""2025-11-12 02:20:10"",""duration"":658788,""number"":2196,""filter"":90,""mode"":2106,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 18:56:22"",""et"":""2025-12-04 04:43:44"",""duration"":640042,""number"":2134,""filter"":90,""mode"":2044,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lbs20cp102"",""Description"":""5号低加进汽压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""0.58"",""TMin"":""0.12"",""TAvg"":""0.31"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lbs20ct104k"",""Description"":""5号低加进汽温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""312.18"",""TMin"":""245.88"",""TAvg"":""291.98"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lcj50aa101xq11"",""Description"":""5号低加正常疏水气动调节阀反馈"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""66.59"",""TMin"":""28.98"",""TAvg"":""47.50"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lcj50ct101r"",""Description"":""5号低压加热器正常疏水出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""144.02"",""TMin"":""98.37"",""TAvg"":""120.84"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10lcc50cl101_cal"",""Description"":""5号低压加热器水位1(计算后）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""7.23"",""lowerBound"":""-7.23"",""LAY_TABLE_INDEX"":5,""type"":true,""TMax"":""17.46"",""TMin"":""-22.89"",""TAvg"":""2.15"",""DMax"":""16.30"",""DMin"":""-16.75"",""DAvg"":""0.15"",""C95"":""7.20"",""C99"":""7.20""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 14:47:59"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":null,""mms1"":{""data_max_"":[0.5803405,312.184448,66.59016,144.01506],""data_min_"":[0.118943147,245.878052,28.9821472,98.37088],""data_range_"":[0.46139735,66.3064,37.6080132,45.64418],""min_"":[-0.257789,-3.70821,-0.7706376,-2.155168],""scale_"":[2.16732931,0.0150815006,0.0265900772,0.021908598]},""mms2"":{""data_max_"":[17.4606342],""data_min_"":[-22.8859653],""data_range_"":[40.3466],""min_"":[0.567234039],""scale_"":[0.0247852374]},""train_max"":[0.5803405,312.184448,66.59016,144.01506,17.4606342],""train_min"":[0.118943147,245.878052,28.9821472,98.37088,-22.8859653],""train_ave"":[0.3057631,291.983063,47.5019341,120.837807,2.14985824],""pre_max"":[16.2970276],""pre_min"":[-16.7546711],""pre_ave"":[0.154494643],""pre_s"":[7.20250368],""pre_s_ave"":7.20250368,""limit"":0.178884968,""weight"":[[[-0.69439250230789185,-2.1871330738067627,-0.67934828996658325,0.33961594104766846,0.95925843715667725],[-0.37357577681541443,0.061352413147687912,0.44398561120033264,0.42240360379219055,-0.46359387040138245],[2.2460715770721436,-1.6092830896377564,1.3113998174667358,-1.5218982696533203,-2.0599310398101807],[-0.70935314893722534,0.11620106548070908,-0.68016934394836426,0.59889036417007446,0.21862924098968506]],[0.14256128668785095,-0.79281318187713623,0.30167645215988159,-0.3393990695476532,0.0897960364818573],[[0.62450540065765381],[0.24474245309829712],[0.76652985811233521],[-0.53348129987716675],[-0.93787109851837158]],[0.245485320687294]],""BeforeCleanSamNum"":4329,""AfterCleanSamNum"":4239,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""进汽温度大于220"",""alarmcondition"":""[d1_10lbs20ct104k]>220""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":310,""version"":""v-2025-12-04 14:47:59"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[" + IN5 + "]]}";
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
			
	        if (!(Condition1>220))
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