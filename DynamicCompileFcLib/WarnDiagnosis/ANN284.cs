using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN284")]
    [FCDisplay("ANN284")]
    public partial class ANN284 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("进汽温度大于220")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高加进汽压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高加进汽温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高压加热器正常疏水温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高压加热器正常疏水温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高压加热器事故疏水管道薄膜气动调节阀位置反馈")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后的3号高压加热器水位")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("3号高压加热器正常疏水管道薄膜气动角式调节阀设定")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出8")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出8")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出8")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出8")]
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

		public ANN284()
		{
			ModelID = 308;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "ANN284";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""308"",""name"":""ANN284"",""description"":""3号高加液位"",""founder"":""admin"",""creatTime"":""2024-03-04 16:01:05"",""Modifier"":""admin"",""modifiedTime"":""2025-03-21 15:30:41"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-04-25 06:43:06"",""et"":""2024-06-01 01:30:02"",""duration"":3178016,""number"":10594,""filter"":5471,""mode"":5123,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":6,""conditionnumber"":0},{""st"":""2024-03-13 15:46:08"",""et"":""2024-04-09 03:14:20"",""duration"":2287692,""number"":7626,""filter"":589,""mode"":7037,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":162,""conditionnumber"":0},{""st"":""2024-06-18 12:07:30"",""et"":""2024-08-30 15:40:00"",""duration"":6319950,""number"":21067,""filter"":21046,""mode"":21,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":6,""conditionnumber"":0},{""st"":""2024-10-02 14:45:36"",""et"":""2024-11-15 21:12:24"",""duration"":3824808,""number"":12750,""filter"":12536,""mode"":214,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":4,""limitnumber"":24,""conditionnumber"":0},{""st"":""2024-11-30 20:28:35"",""et"":""2025-01-24 00:24:10"",""duration"":4679735,""number"":15600,""filter"":14863,""mode"":737,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":5,""limitnumber"":41,""conditionnumber"":0},{""st"":""2025-02-08 17:04:44"",""et"":""2025-03-11 02:05:24"",""duration"":2624440,""number"":8749,""filter"":8405,""mode"":344,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":6,""limitnumber"":15,""conditionnumber"":6}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ31CP101"",""Description"":""3号高加进汽压力"",""Unit"":""MPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":false,""TMax"":""2.69"",""TMin"":""0.98"",""TAvg"":""1.82"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_LBQ31CT601"",""Description"":""3号高加进汽温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":false,""TMax"":""330.16"",""TMin"":""263.76"",""TAvg"":""303.18"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_LCH30AA101ZZ"",""Description"":""3号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":false,""TMax"":""97.91"",""TMin"":""52.70"",""TAvg"":""76.13"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_LCH30CT601"",""Description"":""3号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":false,""TMax"":""197.18"",""TMin"":""151.97"",""TAvg"":""176.11"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_LCH20AA101ZZ"",""Description"":""2号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":false,""TMax"":""80.67"",""TMin"":""39.38"",""TAvg"":""65.55"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_LCH20CT601"",""Description"":""2号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":false,""TMax"":""238.04"",""TMin"":""183.30"",""TAvg"":""209.68"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_LCH31AA101ZZ"",""Description"":""3号高压加热器事故疏水管道薄膜气动调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":7,""type"":false,""TMax"":""65.18"",""TMin"":""-1.98"",""TAvg"":""-0.62"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":""0"",""C99"":null},{""PointId"":""dcs_HPH3LVL_SEL"",""Description"":""选择后的3号高压加热器水位"",""Unit"":""mm"",""Upper"":""60"",""Lower"":""-50"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":true,""TMax"":""59.01"",""TMin"":""-49.99"",""TAvg"":""9.94"",""DMax"":""66.73"",""DMin"":""-58.42"",""DAvg"":""0.09"",""C95"":""22.68"",""C99"":""22.68""},{""PointId"":""dcs_LCH30AA101SP"",""Description"":""3号高压加热器正常疏水管道薄膜气动角式调节阀设定"",""Unit"":"""",""Upper"":""90"",""Lower"":""-100"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":"""",""lowerBound"":"""",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""85.45"",""TMin"":""-98.46"",""TAvg"":""8.82"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-21 15:30:41"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential_1"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense_2"",""trainable"":true,""batch_input_shape"":[null,8],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_3"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[2.685115,330.157562,97.91182,197.184,80.66864,238.04483,65.1781845,85.44718],""data_min_"":[0.9838883,263.755554,52.699028,151.96666,39.3785667,183.3,-1.98425257,-98.46385],""data_range_"":[1.70122671,66.40201,45.21279,45.21734,41.2900734,54.74483,67.16244,183.911026],""min_"":[-0.5783405,-3.972102,-1.16557789,-3.360805,-0.95370543,-3.34826136,0.0295440834,0.53538847],""scale_"":[0.5878111,0.015059785,0.0221176352,0.02211541,0.0242188964,0.0182665642,0.0148892747,0.005437412]},""mms2"":{""data_max_"":[59.0075035],""data_min_"":[-49.99406],""data_range_"":[109.001564],""min_"":[0.458654523],""scale_"":[0.00917418]},""train_max"":[2.685115,330.157562,97.91182,197.184,80.66864,238.04483,65.1781845,59.0075035,85.44718],""train_min"":[0.9838883,263.755554,52.699028,151.96666,39.3785667,183.3,-1.98425257,-49.99406,-98.46385],""train_ave"":[1.81770313,303.181366,76.12687,176.107864,65.5546646,209.675751,-0.6225291,9.944318,8.820716],""pre_max"":[66.73255],""pre_min"":[-58.4219],""pre_ave"":[0.08718889],""pre_s"":[22.6784267],""pre_s_ave"":22.6784267,""limit"":0.2080698,""weight"":[[[-0.9785459041595459,0.28491103649139404,1.3656405210494995,0.30089643597602844,-0.79289388656616211],[-0.80824649333953857,0.22388006746768951,-1.3468822240829468,0.7077491283416748,0.28827723860740662],[-0.90193301439285278,1.0902228355407715,-0.4368206262588501,-0.63755118846893311,-0.69130200147628784],[-2.2327375411987305,0.094684973359107971,-0.13928794860839844,0.72392874956130981,0.69306576251983643],[-1.3934092521667481,0.34748312830924988,-0.63150620460510254,-0.46343854069709778,0.258523166179657],[0.509778618812561,-1.1206566095352173,-0.42721408605575562,0.98900938034057617,1.4381518363952637],[-1.5775989294052124,25.683151245117188,-0.31887182593345642,1.2898353338241577,3.3820817470550537],[2.2846925258636475,-0.030519662424921989,3.0549604892730713,-1.1781789064407349,-0.95979797840118408]],[0.56250596046447754,0.094290867447853088,-1.6240588426589966,-0.04166068509221077,0.21979427337646484],[[-1.0270990133285523],[1.4049948453903198],[1.682551383972168],[-0.78114050626754761],[-1.0618730783462524]],[0.33328774571418762]],""BeforeCleanSamNum"":76382,""AfterCleanSamNum"":13380,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""进汽温度大于220"",""alarmcondition"":""[dcs_LBQ31CT601]>220""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":308,""version"":""v-2025-03-21 15:30:41"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN9 + "]],\"Target_Data\":[[" + IN8 + "]]}";
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

			LAExWarn[] arrIN = new LAExWarn[1] {IN8};
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