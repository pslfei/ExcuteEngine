using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA151")]
    [FCDisplay("PCA151")]
    public partial class PCA151 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F进出口差压")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F密封风与一次风差压1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F密封风与一次风差压2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F密封风与一次风差压3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F分离器出口压力")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F入口混合一次风压力1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F入口混合一次风压力2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F入口密封风压力")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F入口一次风压力")]
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

		public PCA151()
		{
			ModelID = 163;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA151";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""163"",""name"":""PCA151"",""description"":""磨煤机F压力"",""founder"":""admin"",""creatTime"":""2023-11-01 10:24:48"",""Modifier"":""admin"",""modifiedTime"":""2024-07-17 15:10:19"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-05 20:04:14"",""et"":""2025-11-17 16:58:48"",""duration"":1025674,""number"":3419,""filter"":493,""mode"":2926,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":403}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc60cp101d"",""Description"":""磨煤机F进出口差压"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.07"",""lowerBound"":""-0.07"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""7.37"",""TMin"":""3.31"",""TAvg"":""4.77"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.05"",""C99"":""0.07""},{""PointId"":""d1_10hfe60cp101d"",""Description"":""磨煤机F密封风与一次风差压1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.02"",""lowerBound"":""-0.02"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""3.42"",""TMin"":""2.70"",""TAvg"":""3.02"",""DMax"":""0.04"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.02"",""C99"":""0.02""},{""PointId"":""d1_10hfe60cp102d"",""Description"":""磨煤机F密封风与一次风差压2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.01"",""lowerBound"":""-0.01"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""3.43"",""TMin"":""2.68"",""TAvg"":""3.00"",""DMax"":""0.02"",""DMin"":""0.00"",""DAvg"":""0.00"",""C95"":""0.01"",""C99"":""0.01""},{""PointId"":""d1_10hfe60cp103d"",""Description"":""磨煤机F密封风与一次风差压3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.02"",""lowerBound"":""-0.02"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""3.23"",""TMin"":""2.50"",""TAvg"":""2.83"",""DMax"":""0.03"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.02"",""C99"":""0.02""},{""PointId"":""d1_10hfc60cp101"",""Description"":""磨煤机F分离器出口压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""4.61"",""TMin"":""1.22"",""TAvg"":""2.93"",""DMax"":""0.73"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.09"",""C99"":""0.12""},{""PointId"":""d1_10hfe60cp101"",""Description"":""磨煤机F入口混合一次风压力1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""11.06"",""TMin"":""4.46"",""TAvg"":""7.62"",""DMax"":""2.03"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10hfe60cp102"",""Description"":""磨煤机F入口混合一次风压力2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""10.77"",""TMin"":""4.12"",""TAvg"":""7.30"",""DMax"":""2.02"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10hfw60cp101"",""Description"":""磨煤机F入口密封风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""13.96"",""TMin"":""7.28"",""TAvg"":""10.51"",""DMax"":""1.07"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.13"",""C99"":""0.17""},{""PointId"":""d1_fmillip"",""Description"":""磨煤机F入口一次风压力"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.14"",""lowerBound"":""-0.14"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""10.92"",""TMin"":""4.29"",""TAvg"":""7.47"",""DMax"":""1.15"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.11"",""C99"":""0.14""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2024-07-17 15:10:19"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[3.308,2.699,2.684,2.496,1.224,4.46,4.115,7.282,4.289],""Train_X_max"":[7.368,3.422,3.431,3.227,4.607,11.062,10.77,13.958,10.92],""Train_X_std"":[0.516,0.06,0.059,0.062,0.594,1.045,1.045,1.033,1.047],""Train_X_mean"":[4.769,3.016,3.002,2.832,2.934,7.618,7.303,10.51,7.469],""Train_X_bais_max"":[[0.347,0.035,0.022,0.033,0.732,2.032,2.022,1.069,1.147]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.013,0.006,0.003,0.005,0.021,0.023,0.022,0.029,0.015]],""QCUL_95"":0.141911909,""QCUL_99"":0.217430174,""QCUL_95_line"":[0.053,0.019,0.012,0.018,0.093,0.187,0.185,0.132,0.109],""QCUL_99_line"":[0.065,0.024,0.014,0.022,0.116,0.239,0.236,0.165,0.139],""T2CUL_95"":7.832,""T2CUL_99"":11.377,""T2CUL_95_line"":[0.027,0.003,0.003,0.003,0.031,0.054,0.054,0.053,0.054],""T2CUL_99_line"":[0.032,0.004,0.004,0.004,0.037,0.065,0.065,0.064,0.065],""Kesi_95"":1.601,""Kesi_99"":1.442,""Kesi_95_line"":[0.012,0.001,0.001,0.001,0.014,0.024,0.024,0.024,0.024],""Kesi_99_line"":[0.011,0.001,0.001,0.001,0.013,0.023,0.023,0.023,0.023],""COV"":[[1.0,0.026,-0.074,-0.268,0.778,0.917,0.917,0.93,0.933],[0.026,1.0,0.975,0.895,0.101,0.064,0.065,0.122,0.068],[-0.074,0.975,1.0,0.958,-0.048,-0.071,-0.071,-0.008,-0.065],[-0.268,0.895,0.958,1.0,-0.296,-0.311,-0.312,-0.248,-0.304],[0.778,0.101,-0.048,-0.296,1.0,0.951,0.952,0.951,0.952],[0.917,0.064,-0.071,-0.311,0.951,1.0,1.0,0.99,0.992],[0.917,0.065,-0.071,-0.312,0.952,1.0,1.0,0.99,0.992],[0.93,0.122,-0.008,-0.248,0.951,0.99,0.99,1.0,0.998],[0.933,0.068,-0.065,-0.304,0.952,0.992,0.992,0.998,1.0]],""K"":3,""R"":0.994,""featValue"":[5.872,2.842,0.236,0.024,0.019,0.008,0.001,0.0,0.0],""featVec"":[[-0.383,-0.035,-0.753,0.045,0.263,-0.067,0.44,0.124,0.009],[0.004,-0.588,0.154,0.65,0.332,-0.298,-0.097,0.026,-0.01],[0.059,-0.586,-0.009,-0.082,-0.123,0.772,0.187,0.003,0.002],[0.156,-0.543,-0.171,-0.571,-0.238,-0.51,-0.061,-0.065,0.013],[-0.391,-0.054,0.613,-0.305,0.255,-0.124,0.528,0.125,0.013],[-0.41,-0.043,0.04,0.191,-0.539,-0.071,0.029,-0.049,-0.702],[-0.41,-0.043,0.043,0.203,-0.529,-0.059,-0.025,0.034,0.709],[-0.408,-0.08,-0.016,-0.23,0.208,0.129,-0.627,0.563,-0.058],[-0.411,-0.047,-0.014,-0.139,0.266,0.097,-0.29,-0.802,0.035]],""selectVec"":[[-0.383,-0.035,-0.753],[0.004,-0.588,0.154],[0.059,-0.586,-0.009],[0.156,-0.543,-0.171],[-0.391,-0.054,0.613],[-0.41,-0.043,0.04],[-0.41,-0.043,0.043],[-0.408,-0.08,-0.016],[-0.411,-0.047,-0.014]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3419,""AfterCleanSamNum"":2926,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机F运行"",""alarmcondition"":""[d1_10hfe60aj001xq01]>20""},""copy"":false,""principal"":""3"",""precision"":""99.4%"",""rate"":""0.97"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":163,""version"":""v-2024-07-17 15:10:19"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "]],\"Target_Data\":[[]]}";
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