using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ANN198")]
    [FCDisplay("ANN198")]
    public partial class ANN198 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A磨煤机电流")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A转速")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A瞬时输送流量")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("给煤机A电流")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口风粉混合物温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后磨煤机A一次风量")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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

		public ANN198()
		{
			ModelID = 219;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "ANN198";
			FcCode = "ANN";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""219"",""name"":""ANN198"",""description"":""磨煤机A电流"",""founder"":""admin"",""creatTime"":""2023-12-29 11:22:48"",""Modifier"":""admin"",""modifiedTime"":""2024-01-03 14:13:13"",""algorithm"":""ANN"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2023-11-14 22:55:52"",""et"":""2023-12-26 12:52:16"",""duration"":3592584,""number"":11976,""filter"":1913,""mode"":10063,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""dcs_HFC10AJ001CE"",""Description"":""A磨煤机电流"",""Unit"":""A"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.23"",""lowerBound"":""-2.23"",""LAY_TABLE_INDEX"":1,""type"":true,""TMax"":""52.74"",""TMin"":""20.81"",""TAvg"":""43.69"",""DMax"":""7.98"",""DMin"":""-4.92"",""DAvg"":""-0.06"",""C95"":""3.14"",""C99"":""3.14""},{""PointId"":""dcs_HFY11AI003"",""Description"":""给煤机A转速"",""Unit"":""rpm"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""1175.58"",""TMin"":""206.13"",""TAvg"":""934.95"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HFY11AI001"",""Description"":""给煤机A瞬时输送流量"",""Unit"":""t/h"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""91.69"",""TMin"":""15.38"",""TAvg"":""72.16"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HFY11AI002"",""Description"":""给煤机A电流"",""Unit"":""A"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""4.61"",""TMin"":""2.25"",""TAvg"":""4.30"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_HFC10CT315"",""Description"":""磨煤机A出口风粉混合物温度1"",""Unit"":""℃"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""87.18"",""TMin"":""63.02"",""TAvg"":""79.12"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null},{""PointId"":""dcs_MAPAFL"",""Description"":""选择后磨煤机A一次风量"",""Unit"":""t/h"",""Upper"":null,""Lower"":null,""dead"":false,""limit"":false,""Lock"":false,""upperBound"":null,""lowerBound"":null,""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""150.93"",""TMin"":""55.06"",""TAvg"":""131.00"",""DMax"":null,""DMin"":null,""DAvg"":null,""C95"":null,""C99"":null}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-01-03 14:13:13"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""samrange_temp"":null,""para"":{""filename"":{""class_name"":""Sequential"",""config"":{""name"":""sequential"",""layers"":[{""class_name"":""Dense"",""config"":{""name"":""dense"",""trainable"":true,""batch_input_shape"":[null,5],""dtype"":""float32"",""units"":5,""activation"":""sigmoid"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}},{""class_name"":""Dense"",""config"":{""name"":""dense_1"",""trainable"":true,""batch_input_shape"":null,""dtype"":""float32"",""units"":1,""activation"":""linear"",""use_bias"":true,""kernel_initializer"":{""class_name"":""GlorotUniform"",""config"":{""seed"":null,""dtype"":""float32""}},""bias_initializer"":{""class_name"":""Zeros"",""config"":{""dtype"":""float32""}},""kernel_regularizer"":null,""bias_regularizer"":null,""activity_regularizer"":null,""kernel_constraint"":null,""bias_constraint"":null}}]},""keras_version"":""2.2.4-tf"",""backend"":""tensorflow""},""mms1"":{""data_max_"":[1175.58154,91.6870346,4.607681,87.18,150.934036],""data_min_"":[206.129913,15.37818,2.24573612,63.015,55.0584373],""data_range_"":[969.4516,76.30885,2.361945,24.165,95.8756],""min_"":[-0.21262528,-0.2015255,-0.9507995,-2.607697,-0.574269533],""scale_"":[0.001031511,0.013104639,0.4233799,0.0413821638,0.0104301823]},""mms2"":{""data_max_"":[52.74118],""data_min_"":[20.8099823],""data_range_"":[31.9311981],""min_"":[-0.651713133],""scale_"":[0.0313173346]},""train_max"":[52.74118,1175.58154,91.6870346,4.607681,87.18,150.934036],""train_min"":[20.8099823,206.129913,15.37818,2.24573612,63.015,55.0584373],""train_ave"":[43.685955,934.9491,72.15677,4.30022573,79.1233139,130.9991],""pre_max"":[7.977394],""pre_min"":[-4.92008924],""pre_ave"":[-0.0565621],""pre_s"":[3.141965],""pre_s_ave"":3.141965,""limit"":0.09854135,""weight"":[[[1.3270130157470703,-0.81279522180557251,1.6276067495346069,2.0004258155822754,-0.32570594549179077],[-0.34862637519836426,0.61906230449676514,0.06986575573682785,0.11501315236091614,0.61487090587615967],[-0.72105246782302856,0.78909564018249512,0.45679113268852234,0.56901758909225464,-0.36565095186233521],[-0.51355737447738647,-0.50617581605911255,-0.28421574831008911,0.18097862601280212,-0.23878422379493713],[-0.89128082990646362,1.1339824199676514,-0.5496220588684082,-0.0672626942396164,-3.9857096672058105]],[0.37966263294219971,-0.48302173614501953,0.4001133143901825,0.49631556868553162,0.6990620493888855],[[1.4543460607528687],[-1.1083132028579712],[0.3180796205997467],[0.66959375143051147],[-2.1526868343353271]],[0.1666606217622757]],""BeforeCleanSamNum"":11976,""AfterCleanSamNum"":10063,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机A运行"",""alarmcondition"":""[dcs_HFC10AJ001CE]>20""},""copy"":false,""principal"":null,""precision"":null,""rate"":""0.85"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":219,""version"":""v-2024-01-03 14:13:13"",""Test_Data"":[[" + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "]],\"Target_Data\":[[" + IN1 + "]]}";
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
			
	        if (!(Condition1>20))
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