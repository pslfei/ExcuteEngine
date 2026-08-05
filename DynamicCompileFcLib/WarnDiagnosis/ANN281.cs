using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN281")]
    [FCDisplay("ANN281")]
    public partial class ANN281 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("抽汽温度大于400")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高加进汽压力")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高加进汽温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高压加热器正常疏水温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高压加热器事故疏水管道薄膜气动调节阀位置反馈")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后的0号高压加热器水位")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("0号高压加热器正常疏水管道薄膜气动角式调节阀设定")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出6")]
	    public LA OUT_R1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出6")]
	    public LA OUT_B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出6")]
	    public LD OUT_F1 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出6")]
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

		public ANN281()
		{
			ModelID = 305;
			SysID = 5;
			FcType = enumType.Warn;
			FcName = "ANN281";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""305"",""name"":""ANN281"",""description"":""0号高加液位"",""founder"":""admin"",""creatTime"":""2024-03-04 15:22:46"",""Modifier"":""admin"",""modifiedTime"":""2025-03-20 17:39:39"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-02-20 16:58:15"",""et"":""2025-03-12 02:29:00"",""duration"":1675845,""number"":5587,""filter"":5566,""mode"":21,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-10-02 05:19:04"",""et"":""2024-10-31 21:58:49"",""duration"":2565585,""number"":8552,""filter"":8527,""mode"":25,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-02-02 01:31:27"",""et"":""2024-03-05 15:03:51"",""duration"":2813544,""number"":9379,""filter"":9328,""mode"":51,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":8,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_LBQ00CP102"",""Description"":""0号高加进汽压力"",""Unit"":""MPa"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":1,""type"":false,""TMax"":""9.87"",""TMin"":""4.42"",""TAvg"":""6.69"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LBQ00CT602"",""Description"":""0号高加进汽温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""472.48"",""TMin"":""440.78"",""TAvg"":""460.42"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH00CT601"",""Description"":""0号高压加热器正常疏水温度"",""Unit"":""℃"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""305.30"",""TMin"":""246.41"",""TAvg"":""274.54"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH00AA101ZZ"",""Description"":""0号高压加热器正常疏水管道薄膜气动角式调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""83.54"",""TMin"":""47.43"",""TAvg"":""71.83"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_LCH01AA101ZZ"",""Description"":""0号高压加热器事故疏水管道薄膜气动调节阀位置反馈"",""Unit"":""%"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""2.02"",""TMin"":""0.43"",""TAvg"":""0.68"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HPH0LVL_SEL"",""Description"":""选择后的0号高压加热器水位"",""Unit"":""mm"",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""9.61"",""lowerBound"":""-9.61"",""LAY_TABLE_INDEX"":6,""type"":true,""TMax"":""64.68"",""TMin"":""-31.70"",""TAvg"":""8.74"",""DMax"":""12.37"",""DMin"":""-27.75"",""DAvg"":""-0.36"",""C95"":""17.46"",""C99"":""17.46""},{""PointId"":""dcs_LCH00AA101SP"",""Description"":""0号高压加热器正常疏水管道薄膜气动角式调节阀设定"",""Unit"":"""",""Upper"":""100"",""Lower"":""-30"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":"""",""lowerBound"":"""",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""60.00"",""TMin"":""-29.83"",""TAvg"":""9.04"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-03-20 17:39:39"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense"",""trainable"":true,""batch_input_shape"":[null,6],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_1"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[9.87192,472.477783,305.3,83.5393753,2.021305,60.0],""data_min_"":[4.41879,440.780762,246.40889,47.4298172,0.429522038,-29.832],""data_range_"":[5.45313,31.69702,58.89111,36.10956,1.59178293,89.832],""min_"":[-0.8103218,-13.9060631,-4.184144,-1.31349754,-0.269837052,0.332086563],""scale_"":[0.183380917,0.03154871,0.0169804916,0.0276934989,0.62822634,0.011131891]},""mms2"":{""data_max_"":[64.68295],""data_min_"":[-31.6978874],""data_range_"":[96.38084],""min_"":[0.328881621],""scale_"":[0.0103755062]},""train_max"":[9.87192,472.477783,305.3,83.5393753,2.021305,64.68295,60.0],""train_min"":[4.41879,440.780762,246.40889,47.4298172,0.429522038,-31.6978874,-29.832],""train_ave"":[6.688186,460.415344,274.53714,71.8312149,0.6832429,8.742033,9.040637],""pre_max"":[12.3711357],""pre_min"":[-27.7541122],""pre_ave"":[-0.3561788],""pre_s"":[17.45706],""pre_s_ave"":17.45706,""limit"":0.181464821,""weight"":[[[0.67067044973373413,0.58253759145736694,0.4263496994972229,-0.171017587184906,-0.54017931222915649],[0.6159098744392395,0.8944438099861145,-0.34638190269470215,0.41161143779754639,-0.64655482769012451],[-0.82864665985107422,-0.61899173259735107,0.39595025777816772,0.22570349276065826,-0.11906427145004273],[0.1426759660243988,-0.89177745580673218,-0.96810579299926758,0.319993793964386,0.44187939167022705],[-0.42729121446609497,-0.433030366897583,0.24783344566822052,0.40596505999565125,0.0020530270412564278],[0.76669377088546753,0.34001976251602173,0.70082253217697144,-1.3058948516845703,-0.723557710647583]],[-0.029046215116977692,0.065226063132286072,0.092279635369777679,-0.017220554873347282,0.08335065096616745],[[0.49500244855880737],[0.59914910793304443],[0.80662083625793457],[-0.985019326210022],[-0.51238179206848145]],[0.081265382468700409]],""BeforeCleanSamNum"":23517,""AfterCleanSamNum"":83,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""抽汽温度大于400"",""alarmcondition"":""[dcs_LBQ00CT602]>400""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":305,""version"":""v-2025-03-20 17:39:39"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN7 + "]],\"Target_Data\":[[" + IN6 + "]]}";
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

			LAExWarn[] arrIN = new LAExWarn[1] {IN6};
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