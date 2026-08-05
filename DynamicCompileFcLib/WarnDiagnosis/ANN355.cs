using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN355")]
    [FCDisplay("ANN355")]
    public partial class ANN355 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A主电机运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A热二次风出口A温度三选后")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A入口烟气压力")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口烟气压力")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口热二次风主风道风量选择三选后")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A出口烟气含氧量")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A主电机电流信号")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("空预器A入口二次风温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		public ANN355()
		{
			ModelID = 383;
			SysID = 33;
			FcType = enumType.Warn;
			FcName = "ANN355";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""383"",""name"":""ANN355"",""description"":""空预器A主电机电流"",""founder"":""admin"",""creatTime"":""2024-04-09 17:26:45"",""Modifier"":""admin"",""modifiedTime"":""2024-04-09 17:34:22"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-03-13 08:55:36"",""et"":""2024-04-03 04:45:00"",""duration"":1799364,""number"":5998,""filter"":8,""mode"":5990,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hla10ct_sel"",""Description"":""空预器A热二次风出口A温度三选后"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hna10cp102"",""Description"":""空预器A入口烟气压力"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hna10cp103"",""Description"":""空预器A出口烟气压力"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hla10cf_sel"",""Description"":""空预器A出口热二次风主风道风量选择三选后"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hna10cq105"",""Description"":""空预器A出口烟气含氧量"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hld10gh001xq01"",""Description"":""空预器A主电机电流信号"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""d1_10hla10ct102r"",""Description"":""空预器A入口二次风温度1"",""Unit"":"""",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":0,""type"":null,""TMax"":null,""TMin"":null,""TAvg"":null,""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-04-09 17:34:22"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense"",""trainable"":true,""batch_input_shape"":[null,11],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_1"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[1350.20166,356.282,356.544434,227.3725,-0.651177049,2.576077,-1.32222235,168.485718,20.1715984,10.0740414,0.745188],""data_min_"":[469.053375,278.5191,284.592316,166.478333,-1.894778,0.467370927,-4.55504656,115.649994,0.230459452,3.89306521,0.7277934],""data_range_"":[881.1483,77.7629,71.95211,60.89417,1.243601,2.108706,3.232824,52.8357277,19.94114,6.180976,0.0173946],""min_"":[-0.532320559,-3.581645,-3.955302,-2.733896,1.52362216,-0.221638724,1.4089992,-2.1888597,-0.0115569858,-0.6298464,-41.84019],""scale_"":[0.00113488268,0.0128596025,0.0138981333,0.0164219327,0.8041165,0.474224448,0.309327066,0.018926587,0.05014759,0.16178675,57.4891052]},""mms2"":{""data_max_"":[11.9200163],""data_min_"":[7.56802],""data_range_"":[4.351996],""min_"":[-1.73897684],""scale_"":[0.229779616]},""train_max"":[1350.20166,356.282,356.544434,227.3725,-0.651177049,2.576077,-1.32222235,168.485718,20.1715984,10.0740414,11.9200163,0.745188],""train_min"":[469.053375,278.5191,284.592316,166.478333,-1.894778,0.467370927,-4.55504656,115.649994,0.230459452,3.89306521,7.56802,0.7277934],""train_ave"":[980.6582,338.8862,336.7841,202.0152,-1.25119722,1.56218421,-2.96907878,153.254059,3.28386831,6.40373135,7.83806849,0.743919432],""pre_max"":[1.85090721],""pre_min"":[-3.29657435],""pre_ave"":[0.01587952],""pre_s"":[0.446706623],""pre_s_ave"":0.446706623,""limit"":0.103226125,""weight"":[[[-0.43693771958351135,-0.663235604763031,-0.40788498520851135,0.24826100468635559,0.603233277797699],[0.47103744745254517,1.4012049436569214,0.64087039232254028,-0.2593829333782196,-0.64669603109359741],[0.17250289022922516,1.2593953609466553,0.44299325346946716,0.40028154850006104,-0.31243652105331421],[-0.042197376489639282,-1.7986609935760498,-0.090522691607475281,0.0311568733304739,-0.19832193851470947],[-0.21657900512218475,-2.2433836460113525,-0.63491719961166382,-1.5125436782836914,-0.49949097633361816],[-0.082840092480182648,-0.36120098829269409,-0.77259546518325806,0.5668373703956604,-0.74068927764892578],[-0.79449397325515747,-1.9452270269393921,-0.73561286926269531,-0.86921560764312744,0.068044409155845642],[-0.29697525501251221,0.77556902170181274,0.15710419416427612,-0.25617840886116028,0.1675754189491272],[0.0036966400220990181,0.49359133839607239,-0.61544477939605713,-0.20854121446609497,0.044380974024534225],[-0.18925862014293671,0.62240833044052124,-0.6112481951713562,-0.611551821231842,0.035220637917518616],[0.33282357454299927,-1.5312776565551758,-0.77497255802154541,-0.25074279308319092,0.16162151098251343]],[-0.18721608817577362,-0.61259567737579346,-0.26502150297164917,-0.33199566602706909,0.08943784236907959],[[-0.52713590860366821],[0.91923850774765015],[0.52375900745391846],[-0.1699206531047821],[0.3678010106086731]],[0.027960466220974922]],""BeforeCleanSamNum"":5998,""AfterCleanSamNum"":5990,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""空预器A主电机运行"",""alarmcondition"":""[dcs_HLY56AI001]>6""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":383,""version"":""v-2024-04-09 17:34:22"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "]],\"Target_Data\":[[]]}";
	        string jsonResult = ANN.Diagnosis(ModelInfo, InputInfo);
			if (string.IsNullOrEmpty(jsonResult)) { return; }
	        float[][] reconData = ANN.OutputInfo.reconData;
	        float[][] errorData = ANN.OutputInfo.errorData;
	        float[][] paraState = ANN.OutputInfo.paraState;
	        float[] index = ANN.OutputInfo.Index;

	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[0] {};
			float[] arrOUT_B = new float[0] {};
			LD[] arrOUT_W = new LD[0] {  };
			
	        if (!(Condition1>6))
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