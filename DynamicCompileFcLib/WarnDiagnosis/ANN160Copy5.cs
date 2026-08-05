using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN160Copy5")]
    [FCDisplay("ANN160Copy5")]
    public partial class ANN160Copy5 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机F电流")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机F电流")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机F瞬时输送流量")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机F转速")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机F给煤量")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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

		public ANN160Copy5()
		{
			ModelID = 341;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "ANN160Copy5";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""341"",""name"":""ANN160Copy5"",""description"":""给煤机F电流"",""founder"":""admin"",""creatTime"":""2024-03-22 10:54:42"",""Modifier"":""admin"",""modifiedTime"":""2024-03-22 10:59:55"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2024-02-24 00:15:07"",""et"":""2024-03-09 03:14:28"",""duration"":1220361,""number"":4068,""filter"":716,""mode"":3352,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HFY16AI002"",""Description"":""给煤机F电流"",""Unit"":""A"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":1,""type"":true,""TMax"":""4.82"",""TMin"":""2.01"",""TAvg"":""4.36"",""DMax"":""1.81"",""DMin"":""-0.74"",""DAvg"":""0.00"",""C95"":""0.22"",""C99"":""0.22""},{""PointId"":""dcs_HFY16AI001"",""Description"":""给煤机F瞬时输送流量"",""Unit"":""t/h"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""83.63"",""TMin"":""-0.12"",""TAvg"":""67.13"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HFY16AI003"",""Description"":""给煤机F转速"",""Unit"":""rpm"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""939.74"",""TMin"":""0.27"",""TAvg"":""777.49"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_MFLLTFF"",""Description"":""给煤机F给煤量"",""Unit"":""%"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""83.70"",""TMin"":""10.83"",""TAvg"":""67.19"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-03-22 10:59:55"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense"",""trainable"":true,""batch_input_shape"":[null,3],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_1"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[83.6348343,939.74,83.70181],""data_min_"":[-0.12116988,0.2717142,10.83106],""data_range_"":[83.7560043,939.468262,72.87075],""min_"":[0.00144670077,-0.000289221265,-0.148633853],""scale_"":[0.0119394427,0.00106443185,0.0137229273]},""mms2"":{""data_max_"":[4.8152504],""data_min_"":[2.01266813],""data_range_"":[2.80258226],""min_"":[-0.7181477],""scale_"":[0.3568138]},""train_max"":[4.8152504,83.6348343,939.74,83.70181],""train_min"":[2.01266813,-0.12116988,0.2717142,10.83106],""train_ave"":[4.361722,67.12869,777.4906,67.19316],""pre_max"":[1.80591726],""pre_min"":[-0.7446313],""pre_ave"":[0.004514152],""pre_s"":[0.216908485],""pre_s_ave"":0.216908485,""limit"":0.07754663,""weight"":[[[-3.2944881916046143,0.1381770670413971,1.7680720090866089,0.81798434257507324,0.33001172542572021],[-3.1215424537658691,0.74967736005783081,0.47991856932640076,-0.505638062953949,-0.28882119059562683],[-7.21294641494751,-0.6052057147026062,2.2237086296081543,-0.36003875732421875,0.50214910507202148]],[0.89159005880355835,0.15675154328346252,-0.64149230718612671,0.14884433150291443,0.23154248297214508],[[-2.3821656703948975],[0.84382671117782593],[-0.69468206167221069],[0.524717390537262],[0.82183706760406494]],[0.17405733466148377]],""BeforeCleanSamNum"":4068,""AfterCleanSamNum"":3352,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""给煤机F电流"",""alarmcondition"":""[dcs_HFY16AI002]>2""},""copy"":true,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":341,""version"":""v-2024-03-22 10:59:55"",""Test_Data"":[[" + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[" + IN1 + "]]}";
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
			
	        if (!(Condition1>2))
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