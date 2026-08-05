using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN283")]
    [FCDisplay("ANN283")]
    public partial class ANN283 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于200")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高加进汽压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高加进汽温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("1号高压加热器正常疏水温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高压加热器正常疏水温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高压加热器事故疏水管道薄膜气动调节阀位置反馈")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后的2号高压加热器水位")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("2号高压加热器正常疏水管道薄膜气动角式调节阀设定")]
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

		public ANN283()
		{
			ModelID = 307;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "ANN283";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""307"",""name"":""ANN283"",""description"":""2号高加液位"",""founder"":""admin"",""creatTime"":""2024-03-04 15:54:34"",""Modifier"":""admin"",""modifiedTime"":""2025-03-21 16:00:39"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-01-21 13:59:00"",""et"":""2024-03-08 04:44:20"",""duration"":4027520,""number"":13426,""filter"":12960,""mode"":466,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-03-13 10:45:54"",""et"":""2024-04-08 01:55:10"",""duration"":2214556,""number"":7382,""filter"":2423,""mode"":4959,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":72,""conditionnumber"":0},{""st"":""2024-04-26 14:36:58"",""et"":""2024-08-29 11:17:24"",""duration"":10788026,""number"":35961,""filter"":32261,""mode"":3700,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":6,""conditionnumber"":0},{""st"":""2024-10-02 16:55:10"",""et"":""2024-11-15 21:12:24"",""duration"":3817034,""number"":12724,""filter"":12680,""mode"":44,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":4,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-02-08 20:07:08"",""et"":""2025-03-11 19:19:40"",""duration"":2675552,""number"":8919,""filter"":8851,""mode"":68,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":5,""limitnumber"":1,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ20CP102"",""Description"":""2号高加进汽压力"",""Unit"":""MPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""5.87"",""TMin"":""1.64"",""TAvg"":""3.92"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LBQ20CT602"",""Description"":""2号高加进汽温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""367.35"",""TMin"":""310.34"",""TAvg"":""349.76"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH10AA101ZZ"",""Description"":""1号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""88.91"",""TMin"":""0.27"",""TAvg"":""77.59"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH10CT601"",""Description"":""1号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""278.39"",""TMin"":""53.60"",""TAvg"":""251.94"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH20AA101ZZ"",""Description"":""2号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""80.37"",""TMin"":""39.38"",""TAvg"":""65.19"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH20CT601"",""Description"":""2号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""232.85"",""TMin"":""173.33"",""TAvg"":""209.56"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH21AA101ZZ"",""Description"":""2号高压加热器事故疏水管道薄膜气动调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""19.98"",""TMin"":""-0.99"",""TAvg"":""-0.18"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HPH2LVL_SEL"",""Description"":""选择后的2号高压加热器水位"",""Unit"":""mm"",""Upper"":""100"",""Lower"":""-100"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""15.92"",""lowerBound"":""-15.92"",""LAY_TABLE_INDEX"":8,""type"":true,""TMax"":""78.69"",""TMin"":""-93.60"",""TAvg"":""30.23"",""DMax"":""66.74"",""DMin"":""-43.68"",""DAvg"":""-0.21"",""C95"":""15.77"",""C99"":""15.77""},{""PointId"":""dcs_LCH20AA101SP"",""Description"":""2号高压加热器正常疏水管道薄膜气动角式调节阀设定"",""Unit"":"""",""Upper"":""100"",""Lower"":""-100"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":"""",""lowerBound"":"""",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""60.00"",""TMin"":""-96.67"",""TAvg"":""27.75"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-21 16:00:39"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential_1"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense_2"",""trainable"":true,""batch_input_shape"":[null,8],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_3"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[5.867395,367.353333,88.90769,278.39,80.36683,232.846436,19.981411,60.0],""data_min_"":[1.642905,310.342438,0.2714549,53.6,39.3785667,173.325,-0.9913,-96.6666641],""data_range_"":[4.22449,57.01089,88.63624,224.79,40.9882622,59.52144,20.9727116,156.666656],""min_"":[-0.3889002,-5.44356441,-0.00306257256,-0.238444775,-0.9607279,-2.91197586,0.04726618,0.617021263],""scale_"":[0.236714959,0.0175405089,0.0112820677,0.00444859639,0.0243972279,0.0168006681,0.0476810075,0.006382979]},""mms2"":{""data_max_"":[78.6859],""data_min_"":[-93.60118],""data_range_"":[172.287079],""min_"":[0.543286145],""scale_"":[0.005804266]},""train_max"":[5.867395,367.353333,88.90769,278.39,80.36683,232.846436,19.981411,78.6859,60.0],""train_min"":[1.642905,310.342438,0.2714549,53.6,39.3785667,173.325,-0.9913,-93.60118,-96.6666641],""train_ave"":[3.92113113,349.756,77.59025,251.93924,65.18892,209.558609,-0.18481341,30.2303963,27.74708],""pre_max"":[66.73784],""pre_min"":[-43.68371],""pre_ave"":[-0.212753356],""pre_s"":[15.7746181],""pre_s_ave"":15.7746181,""limit"":0.091635,""weight"":[[[-0.035753477364778519,-1.9541904926300049,-3.6987841129302979,0.86718451976776123,-0.38058063387870789],[0.33376771211624146,0.23216661810874939,-0.55475819110870361,-0.61619424819946289,-0.79970079660415649],[0.22422091662883759,-0.489410400390625,0.55660015344619751,-0.18360403180122376,-0.015717774629592896],[0.36896535754203796,-0.046695880591869354,-0.22199846804141998,-0.59610229730606079,0.15693569183349609],[-0.38956668972969055,-0.43516424298286438,-0.83122348785400391,-0.25214406847953796,-0.067203454673290253],[-1.2095983028411865,0.85445350408554077,-0.023640455678105354,-1.2731451988220215,0.93294060230255127],[0.31032627820968628,-0.60341662168502808,-1.9465211629867554,-0.62357097864151,-1.1024453639984131],[1.6006820201873779,0.290446400642395,-0.47841066122055054,1.5675508975982666,-1.5406506061553955]],[-0.0713777169585228,0.1839447021484375,-0.059032171964645386,-0.39641055464744568,-0.10598025470972061],[[0.93422138690948486],[-0.87318354845047],[-0.82876372337341309],[1.2065461874008179],[-0.87222617864608765]],[0.18334117531776428]],""BeforeCleanSamNum"":78410,""AfterCleanSamNum"":9751,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于200"",""alarmcondition"":""[dcs_AMMKA01AG001CE01]>200""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":307,""version"":""v-2025-03-21 16:00:39"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN9 + "]],\"Target_Data\":[[" + IN8 + "]]}";
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
			
	        if (!(Condition1>200))
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