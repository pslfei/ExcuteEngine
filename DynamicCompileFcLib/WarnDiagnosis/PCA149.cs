using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA149")]
    [FCDisplay("PCA149")]
    public partial class PCA149 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D压力")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D进出口差压")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D密封风与一次风差压1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D密封风与一次风差压2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D密封风与一次风差压3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D入口混合一次风压力1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D入口混合一次风压力2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D分离器出口压力")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D入口密封风压力")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D入口一次风压力")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出2")]
	    public LA OUT_R2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出2")]
	    public LA OUT_B2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出2")]
	    public LD OUT_F2 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出2")]
	    public LD OUT_W2 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出3")]
	    public LA OUT_R3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出3")]
	    public LA OUT_B3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出3")]
	    public LD OUT_F3 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出3")]
	    public LD OUT_W3 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出4")]
	    public LA OUT_R4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出4")]
	    public LA OUT_B4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出4")]
	    public LD OUT_F4 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出4")]
	    public LD OUT_W4 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出5")]
	    public LA OUT_R5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出5")]
	    public LA OUT_B5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出5")]
	    public LD OUT_F5 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出5")]
	    public LD OUT_W5 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出6")]
	    public LA OUT_R6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出6")]
	    public LA OUT_B6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出6")]
	    public LD OUT_F6 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出6")]
	    public LD OUT_W6 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出7")]
	    public LA OUT_R7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出7")]
	    public LA OUT_B7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出7")]
	    public LD OUT_F7 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出7")]
	    public LD OUT_W7 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出8")]
	    public LA OUT_R8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出8")]
	    public LA OUT_B8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出8")]
	    public LD OUT_F8 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出8")]
	    public LD OUT_W8 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出9")]
	    public LA OUT_R9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出9")]
	    public LA OUT_B9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出9")]
	    public LD OUT_F9 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出9")]
	    public LD OUT_W9 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[9] {false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[9] {false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[9] {-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA149()
		{
			ModelID = 161;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA149";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""161"",""name"":""PCA149"",""description"":""磨煤机D压力"",""founder"":""admin"",""creatTime"":""2023-11-01 09:51:23"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 17:00:10"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 14:58:56"",""et"":""2025-11-26 01:05:10"",""duration"":1159574,""number"":3866,""filter"":899,""mode"":2967,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":809},{""st"":""2025-11-26 21:10:16"",""et"":""2025-12-02 05:07:12"",""duration"":460616,""number"":1536,""filter"":432,""mode"":1104,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":342}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc40cp101d"",""Description"":""磨煤机D进出口差压"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""5.85"",""TMin"":""3.62"",""TAvg"":""4.68"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfe40cp101d"",""Description"":""磨煤机D密封风与一次风差压1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.04"",""lowerBound"":""-0.04"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""3.55"",""TMin"":""2.48"",""TAvg"":""2.89"",""DMax"":""0.04"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.03"",""C99"":""0.03""},{""PointId"":""d1_10hfe40cp102d"",""Description"":""磨煤机D密封风与一次风差压2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.03"",""lowerBound"":""-0.03"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""3.60"",""TMin"":""2.53"",""TAvg"":""2.94"",""DMax"":""0.03"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.02"",""C99"":""0.03""},{""PointId"":""d1_10hfe40cp103d"",""Description"":""磨煤机D密封风与一次风差压3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.06"",""lowerBound"":""-0.06"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""3.57"",""TMin"":""2.49"",""TAvg"":""2.90"",""DMax"":""0.07"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.04"",""C99"":""0.05""},{""PointId"":""d1_10hfe40cp101"",""Description"":""磨煤机D入口混合一次风压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""10.19"",""TMin"":""5.34"",""TAvg"":""7.53"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.08""},{""PointId"":""d1_10hfe40cp102"",""Description"":""磨煤机D入口混合一次风压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""10.49"",""TMin"":""5.62"",""TAvg"":""7.81"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.08""},{""PointId"":""d1_10hfc40cp101"",""Description"":""磨煤机D分离器出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.43"",""lowerBound"":""-0.43"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""4.83"",""TMin"":""1.73"",""TAvg"":""3.09"",""DMax"":""0.53"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.41""},{""PointId"":""d1_10hfw40cp101"",""Description"":""磨煤机D入口密封风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""13.33"",""TMin"":""8.37"",""TAvg"":""10.66"",""DMax"":""0.44"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_dmillip"",""Description"":""磨煤机D入口一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.09"",""lowerBound"":""-0.09"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""10.34"",""TMin"":""5.48"",""TAvg"":""7.67"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.06"",""C99"":""0.08""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 17:00:10"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[3.616,2.478,2.531,2.486,5.343,5.619,1.726,8.365,5.482],""Train_X_max"":[5.847,3.547,3.597,3.572,10.191,10.494,4.83,13.328,10.337],""Train_X_std"":[0.431,0.124,0.126,0.121,1.031,1.025,0.633,1.055,1.028],""Train_X_mean"":[4.675,2.889,2.936,2.897,7.529,7.805,3.085,10.664,7.667],""Train_X_bais_max"":[[0.473,0.042,0.026,0.065,0.239,0.257,0.526,0.442,0.262]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.085,0.007,0.007,0.013,0.016,0.017,0.096,0.02,0.015]],""QCUL_95"":0.426504552,""QCUL_99"":0.740321934,""QCUL_95_line"":[0.298,0.025,0.023,0.044,0.065,0.068,0.335,0.082,0.064],""QCUL_99_line"":[0.365,0.03,0.028,0.053,0.081,0.084,0.41,0.102,0.079],""T2CUL_95"":5.999,""T2CUL_99"":9.225,""T2CUL_95_line"":[0.016,0.005,0.005,0.005,0.039,0.039,0.024,0.04,0.039],""T2CUL_99_line"":[0.02,0.006,0.006,0.006,0.049,0.048,0.03,0.05,0.048],""Kesi_95"":1.573,""Kesi_99"":1.37,""Kesi_95_line"":[0.008,0.002,0.002,0.002,0.02,0.02,0.012,0.021,0.02],""Kesi_99_line"":[0.008,0.002,0.002,0.002,0.019,0.019,0.012,0.019,0.019],""COV"":[[1.0,0.061,0.092,0.085,0.964,0.964,0.902,0.956,0.964],[0.061,1.0,0.999,0.98,0.062,0.068,0.048,0.186,0.065],[0.092,0.999,1.0,0.982,0.09,0.095,0.072,0.213,0.093],[0.085,0.98,0.982,1.0,0.089,0.092,0.076,0.211,0.091],[0.964,0.062,0.09,0.089,1.0,1.0,0.983,0.992,1.0],[0.964,0.068,0.095,0.092,1.0,1.0,0.983,0.992,1.0],[0.902,0.048,0.072,0.076,0.983,0.983,1.0,0.975,0.983],[0.956,0.186,0.213,0.211,0.992,0.992,0.975,1.0,0.992],[0.964,0.065,0.093,0.091,1.0,1.0,0.983,0.992,1.0]],""K"":2,""R"":0.986,""featValue"":[5.945,2.927,0.101,0.025,0.002,0.001,0.001,0.0,0.0],""featVec"":[[0.394,0.067,0.791,0.075,0.376,-0.07,0.249,-0.005,-0.004],[0.074,-0.573,-0.003,-0.429,0.091,0.651,0.22,-0.005,-0.029],[0.085,-0.57,0.05,-0.377,-0.059,-0.704,-0.132,0.006,0.079],[0.085,-0.567,-0.05,0.814,-0.057,0.026,0.022,-0.003,-0.048],[0.407,0.07,-0.045,0.013,-0.388,0.075,0.105,0.45,0.676],[0.407,0.067,-0.036,-0.068,-0.398,-0.028,0.062,0.361,-0.728],[0.399,0.077,-0.601,0.009,0.549,-0.178,0.375,-0.007,-0.006],[0.41,-0.003,-0.054,-0.011,0.282,0.19,-0.844,0.019,0.009],[0.407,0.068,-0.041,-0.027,-0.391,0.027,0.059,-0.817,0.052]],""selectVec"":[[0.394,0.067],[0.074,-0.573],[0.085,-0.57],[0.085,-0.567],[0.407,0.07],[0.407,0.067],[0.399,0.077],[0.41,-0.003],[0.407,0.068]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5401,""AfterCleanSamNum"":4147,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机D压力"",""alarmcondition"":""[d1_10hfe40aj001xq01]>20""},""copy"":false,""principal"":""2"",""precision"":""98.6%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":161,""version"":""v-2025-12-03 17:00:10"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[]]}";
	        string jsonResult = PCA.Diagnosis(ModelInfo, InputInfo, 1, 1);
			if (string.IsNullOrEmpty(jsonResult)) { return; }
	        float[][] reconData = PCA.OutputInfo.reconData;
	        float[][] errorData = PCA.OutputInfo.errorData;
	        float[][] paraState = PCA.OutputInfo.paraState;
	        float[] index = PCA.OutputInfo.Index;

	        OUT_R1[0] = reconData[0][0];
	        OUT_B1[0] = errorData[0][0];
	        OUT_F1[0] = paraState[0][0];
	        OUT_R2[0] = reconData[0][1];
	        OUT_B2[0] = errorData[0][1];
	        OUT_F2[0] = paraState[0][1];
	        OUT_R3[0] = reconData[0][2];
	        OUT_B3[0] = errorData[0][2];
	        OUT_F3[0] = paraState[0][2];
	        OUT_R4[0] = reconData[0][3];
	        OUT_B4[0] = errorData[0][3];
	        OUT_F4[0] = paraState[0][3];
	        OUT_R5[0] = reconData[0][4];
	        OUT_B5[0] = errorData[0][4];
	        OUT_F5[0] = paraState[0][4];
	        OUT_R6[0] = reconData[0][5];
	        OUT_B6[0] = errorData[0][5];
	        OUT_F6[0] = paraState[0][5];
	        OUT_R7[0] = reconData[0][6];
	        OUT_B7[0] = errorData[0][6];
	        OUT_F7[0] = paraState[0][6];
	        OUT_R8[0] = reconData[0][7];
	        OUT_B8[0] = errorData[0][7];
	        OUT_F8[0] = paraState[0][7];
	        OUT_R9[0] = reconData[0][8];
	        OUT_B9[0] = errorData[0][8];
	        OUT_F9[0] = paraState[0][8];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[9] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9};
			float[] arrOUT_B = new float[9] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9};
			LD[] arrOUT_W = new LD[9] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9 };
			
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