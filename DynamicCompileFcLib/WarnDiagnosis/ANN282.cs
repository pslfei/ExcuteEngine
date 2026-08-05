using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN282")]
    [FCDisplay("ANN282")]
    public partial class ANN282 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("高加进汽温度大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高加进汽压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高加进汽温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高压加热器正常疏水温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高压加热器正常疏水温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后的1号高压加热器水位")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高压加热器事故疏水管道薄膜气动调节阀位置反馈")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高压加热器正常疏水管道薄膜气动角式调节阀设定（限速后）")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出7")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出7")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出7")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出7")]
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

		public ANN282()
		{
			ModelID = 306;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "ANN282";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""306"",""name"":""ANN282"",""description"":""1号高加液位"",""founder"":""admin"",""creatTime"":""2024-03-04 15:45:07"",""Modifier"":""admin"",""modifiedTime"":""2025-03-20 18:08:14"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-04-26 06:15:45"",""et"":""2024-08-31 07:39:30"",""duration"":10977825,""number"":36593,""filter"":32879,""mode"":3714,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-11-30 06:58:30"",""et"":""2025-01-21 20:50:50"",""duration"":4542740,""number"":15143,""filter"":15042,""mode"":101,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":4},{""st"":""2025-03-01 10:23:55"",""et"":""2025-03-12 06:24:29"",""duration"":936034,""number"":3121,""filter"":3093,""mode"":28,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ10CP102"",""Description"":""1号高加进汽压力"",""Unit"":""MPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""8.60"",""TMin"":""3.31"",""TAvg"":""5.10"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LBQ10CT602"",""Description"":""1号高加进汽温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""414.72"",""TMin"":""379.37"",""TAvg"":""404.49"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH10CT601"",""Description"":""1号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""278.39"",""TMin"":""223.46"",""TAvg"":""244.06"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH10AA101ZZ"",""Description"":""1号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""88.90"",""TMin"":""35.52"",""TAvg"":""77.10"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH00AA101ZZ"",""Description"":""0号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""79.53"",""TMin"":""45.59"",""TAvg"":""65.26"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH00CT601"",""Description"":""0号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""305.94"",""TMin"":""246.41"",""TAvg"":""270.25"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HPH1LVL_SEL"",""Description"":""选择后的1号高压加热器水位"",""Unit"":""mm"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""14.42"",""lowerBound"":""-14.42"",""LAY_TABLE_INDEX"":7,""type"":true,""TMax"":""73.93"",""TMin"":""-47.59"",""TAvg"":""52.63"",""DMax"":""52.23"",""DMin"":""-47.21"",""DAvg"":""-0.16"",""C95"":""10.96"",""C99"":""10.96""},{""PointId"":""dcs_LCH11AA101ZZ"",""Description"":""1号高压加热器事故疏水管道薄膜气动调节阀位置反馈"",""Unit"":""%"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""52.65"",""TMin"":""-0.83"",""TAvg"":""0.14"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH10AA101_SP"",""Description"":""1号高压加热器正常疏水管道薄膜气动角式调节阀设定（限速后）"",""Unit"":"""",""Upper"":""70"",""Lower"":""-50"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":"""",""lowerBound"":"""",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""60.00"",""TMin"":""-38.00"",""TAvg"":""49.85"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-20 18:08:14"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense"",""trainable"":true,""batch_input_shape"":[null,8],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_1"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[8.60233,414.722717,278.39,88.9007339,79.534935,305.944458,52.65402,60.0],""data_min_"":[3.31461525,379.369781,223.457138,35.5223656,45.5927773,246.40889,-0.8338017,-38.0],""data_range_"":[5.287715,35.35294,54.93286,53.37837,33.9421577,59.53557,53.4878235,98.0],""min_"":[-0.6268521,-10.7309256,-4.067823,-0.6654824,-1.3432492,-4.13885164,0.0155886272,0.3877551],""scale_"":[0.18911761,0.02828619,0.01820404,0.0187341813,0.0294618867,0.016796682,0.0186958443,0.0102040814]},""mms2"":{""data_max_"":[73.926],""data_min_"":[-47.58746],""data_range_"":[121.513458],""min_"":[0.391622961],""scale_"":[0.008229541]},""train_max"":[8.60233,414.722717,278.39,88.9007339,79.534935,305.944458,73.926,52.65402,60.0],""train_min"":[3.31461525,379.369781,223.457138,35.5223656,45.5927773,246.40889,-47.58746,-0.8338017,-38.0],""train_ave"":[5.09604,404.49292,244.060242,77.09607,65.2646255,270.253571,52.6295052,0.135831431,49.85427],""pre_max"":[52.2338371],""pre_min"":[-47.2079773],""pre_ave"":[-0.1640566],""pre_s"":[10.960166],""pre_s_ave"":10.960166,""limit"":0.09028802,""weight"":[[[-0.20273475348949432,-0.49806946516036987,-0.90030080080032349,-0.60420733690261841,0.20907293260097504],[0.673430860042572,-0.12191561609506607,0.54760080575942993,0.56817859411239624,0.097903378307819366],[-0.794945478439331,0.72374939918518066,0.31273218989372253,0.5405731201171875,0.036456659436225891],[0.97762322425842285,-0.45413383841514587,0.26101893186569214,-0.30697888135910034,0.38939356803894043],[-1.0945127010345459,0.59673392772674561,-0.33516547083854675,0.054629664868116379,0.099724330008029938],[-0.66870337724685669,-0.35726621747016907,-0.32673263549804688,-0.41243365406990051,-0.35557839274406433],[3.1961395740509033,1.0724841356277466,0.38126349449157715,1.1547342538833618,4.4592061042785645],[1.7982882261276245,-1.537927508354187,-0.19262918829917908,-0.8658071756362915,0.73675912618637085]],[0.27513071894645691,-0.18294323980808258,-0.19214467704296112,0.087436214089393616,0.086801335215568542],[[0.4592801034450531],[-1.0704307556152344],[-0.24552780389785767],[-0.5591118335723877],[1.0057554244995117]],[0.13233911991119385]],""BeforeCleanSamNum"":54856,""AfterCleanSamNum"":3815,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""高加进汽温度大于350"",""alarmcondition"":""[dcs_LBQ10CT602]>350""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":306,""version"":""v-2025-03-20 18:08:14"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[" + IN7 + "]]}";
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

			LAExWarn[] arrIN = new LAExWarn[1] {IN7};
			float[] arrOUT_B = new float[1] {OUT_B1};
			LD[] arrOUT_W = new LD[1] { OUT_W1 };
			
	        if (!(Condition1>350))
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