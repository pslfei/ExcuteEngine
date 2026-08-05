using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN160Copy3")]
    [FCDisplay("ANN160Copy3")]
    public partial class ANN160Copy3 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机D电流")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机D电流")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机D瞬时输送流量")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机D转速")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机D给煤量")]
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

		public ANN160Copy3()
		{
			ModelID = 339;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "ANN160Copy3";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""339"",""name"":""ANN160Copy3"",""description"":""给煤机D电流"",""founder"":""admin"",""creatTime"":""2024-03-22 10:41:00"",""Modifier"":""admin"",""modifiedTime"":""2024-03-22 10:45:35"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2024-02-23 22:05:34"",""et"":""2024-03-22 07:55:08"",""duration"":2368174,""number"":7894,""filter"":4755,""mode"":3139,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HFY14AI002"",""Description"":""给煤机D电流"",""Unit"":""A"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":1,""type"":true,""TMax"":""5.12"",""TMin"":""2.02"",""TAvg"":""4.23"",""DMax"":""1.89"",""DMin"":""-1.81"",""DAvg"":""0.00"",""C95"":""0.39"",""C99"":""0.39""},{""PointId"":""dcs_HFY14AI001"",""Description"":""给煤机D瞬时输送流量"",""Unit"":""t/h"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""87.38"",""TMin"":""-0.13"",""TAvg"":""63.16"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HFY14AI003"",""Description"":""给煤机D转速"",""Unit"":""rpm"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""1036.84"",""TMin"":""-0.62"",""TAvg"":""749.34"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_MDLLTFF"",""Description"":""给煤机D给煤量"",""Unit"":""%"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""87.37"",""TMin"":""2.64"",""TAvg"":""63.43"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-03-22 10:45:35"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential_1"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense_2"",""trainable"":true,""batch_input_shape"":[null,3],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_3"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[87.37877,1036.84131,87.37491],""data_min_"":[-0.130745247,-0.61881423,2.63968134],""data_range_"":[87.5095139,1037.46008,84.73523],""min_"":[0.001494069,0.0005964704,-0.0311521124],""scale_"":[0.0114273289,0.0009638925,0.0118014673]},""mms2"":{""data_max_"":[5.121666],""data_min_"":[2.02291417],""data_range_"":[3.09875178],""min_"":[-0.6528158],""scale_"":[0.322710574]},""train_max"":[5.121666,87.37877,1036.84131,87.37491],""train_min"":[2.02291417,-0.130745247,-0.61881423,2.63968134],""train_ave"":[4.2346077,63.16122,749.3413,63.4255028],""pre_max"":[1.88973224],""pre_min"":[-1.81406689],""pre_ave"":[-0.00426793657],""pre_s"":[0.385908425],""pre_s_ave"":0.385908425,""limit"":0.124605268,""weight"":[[[0.47279730439186096,-0.98651134967803955,0.89131253957748413,3.8840444087982178,-0.31286850571632385],[0.20839783549308777,0.86070936918258667,-0.17058186233043671,1.3734076023101807,-0.58879756927490234],[-0.33276042342185974,1.2396965026855469,-0.27516138553619385,1.266448974609375,0.22921717166900635]],[-0.022996243089437485,-0.07708171010017395,-0.044551271945238113,0.28349295258522034,-0.21755482256412506],[[0.49012431502342224],[-0.91596800088882446],[0.356448769569397],[0.9303581714630127],[-0.089815936982631683]],[-0.03706003725528717]],""BeforeCleanSamNum"":7894,""AfterCleanSamNum"":3139,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""给煤机D电流"",""alarmcondition"":""[dcs_HFY14AI002]>2""},""copy"":true,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":339,""version"":""v-2024-03-22 10:45:35"",""Test_Data"":[[" + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[" + IN1 + "]]}";
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