using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN160")]
    [FCDisplay("ANN160")]
    public partial class ANN160 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A电流")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A电流")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A瞬时输送流量")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A转速")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A给煤量")]
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

		public ANN160()
		{
			ModelID = 172;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "ANN160";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""172"",""name"":""ANN160"",""description"":""给煤机A电流"",""founder"":""admin"",""creatTime"":""2023-11-09 14:41:58"",""Modifier"":""admin"",""modifiedTime"":""2024-03-22 10:15:11"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2024-02-22 20:10:58"",""et"":""2024-03-08 21:29:00"",""duration"":1300682,""number"":4336,""filter"":0,""mode"":4336,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2024-03-12 23:21:56"",""et"":""2024-03-20 21:22:20"",""duration"":684024,""number"":2281,""filter"":0,""mode"":2281,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HFY11AI002"",""Description"":""给煤机A电流"",""Unit"":""A"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":true,""TMax"":""4.33"",""TMin"":""4.21"",""TAvg"":""4.27"",""DMax"":""0.04"",""DMin"":""-0.03"",""DAvg"":""0.00"",""C95"":""0.02"",""C99"":""0.02""},{""PointId"":""dcs_HFY11AI001"",""Description"":""给煤机A瞬时输送流量"",""Unit"":""t/h"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""87.24"",""TMin"":""40.22"",""TAvg"":""66.83"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HFY11AI003"",""Description"":""给煤机A转速"",""Unit"":""rpm"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""1164.93"",""TMin"":""521.30"",""TAvg"":""867.94"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_MALLTFF"",""Description"":""给煤机A给煤量"",""Unit"":""%"",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""87.24"",""TMin"":""40.27"",""TAvg"":""66.83"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-03-22 10:15:11"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense"",""trainable"":true,""batch_input_shape"":[null,3],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_1"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[87.24498,1164.9314,87.2365341],""data_min_"":[40.22067,521.29834,40.26886],""data_range_"":[47.02431,643.633057,46.9676743],""min_"":[-0.8553165,-0.809931,-0.857373953],""scale_"":[0.0212655962,0.00155368028,0.02129124]},""mms2"":{""data_max_"":[4.32938957],""data_min_"":[4.208839],""data_range_"":[0.1205506],""min_"":[-34.9134636],""scale_"":[8.295272]},""train_max"":[4.32938957,87.24498,1164.9314,87.2365341],""train_min"":[4.208839,40.22067,521.29834,40.26886],""train_ave"":[4.27042675,66.83003,867.940369,66.82761],""pre_max"":[0.0379351526],""pre_min"":[-0.0314221047],""pre_ave"":[0.000372057752],""pre_s"":[0.0217815042],""pre_s_ave"":0.0217815042,""limit"":0.180920571,""weight"":[[[0.63128763437271118,-1.2999604940414429,2.2979106903076172,-1.1983203887939453,-0.19420008361339569],[-1.4115233421325684,-4.2517247200012207,1.9637652635574341,1.6063270568847656,1.2667391300201416],[0.575553834438324,-1.9360991716384888,3.7056984901428223,-0.062173910439014435,-0.48996326327323914]],[-0.97253769636154175,1.1462005376815796,-3.3033173084259033,0.79589533805847168,0.77017253637313843],[[1.1384960412979126],[2.2426152229309082],[1.5763881206512451],[-0.79236817359924316],[-0.422902911901474]],[-0.21308055520057678]],""BeforeCleanSamNum"":6616,""AfterCleanSamNum"":6616,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""给煤机A电流"",""alarmcondition"":""[dcs_HFY11AI002]>2""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":172,""version"":""v-2024-03-22 10:15:11"",""Test_Data"":[[" + IN2 + "," + IN3 + "," + IN4 + "]],\"Target_Data\":[[" + IN1 + "]]}";
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