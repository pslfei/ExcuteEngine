using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA196")]
    [FCDisplay("PCA196")]
    public partial class PCA196 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("分离器出口平衡集箱温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("分离器出口蒸汽温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("分离器出口平衡集箱温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("分离器出口平衡集箱温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("分离器出口平衡集箱温度2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧一级过热器出口集箱出口温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧一级过热器出口集箱出口温度")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧一级过热器出口集箱出口温度(A-1)")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧一级过热器出口集箱出口温度(B-1)")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧一级过热器出口集箱出口温度(A-2)")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧一级过热器出口集箱出口温度(B-2)")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出10")]
	    public LA OUT_R10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出10")]
	    public LA OUT_B10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出10")]
	    public LD OUT_F10 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出10")]
	    public LD OUT_W10 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出11")]
	    public LA OUT_R11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出11")]
	    public LA OUT_B11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出11")]
	    public LD OUT_F11 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出11")]
	    public LD OUT_W11 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[11] {false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[11] {false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[11] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA196()
		{
			ModelID = 216;
			SysID = 25;
			FcType = enumType.Warn;
			FcName = "PCA196";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""216"",""name"":""PCA196"",""description"":""锅炉蒸汽温度1"",""founder"":""admin"",""creatTime"":""2023-12-07 09:44:40"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:43:53"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 14:14:18"",""et"":""2025-11-26 01:05:10"",""duration"":1162252,""number"":3875,""filter"":1363,""mode"":2512,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1273},{""st"":""2025-11-26 18:11:44"",""et"":""2025-12-03 16:04:58"",""duration"":597194,""number"":1991,""filter"":756,""mode"":1235,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":666}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10had40ct"",""Description"":""分离器出口平衡集箱温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.86"",""lowerBound"":""-1.86"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""451.77"",""TMin"":""361.13"",""TAvg"":""414.74"",""DMax"":""4.01"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.51"",""C99"":""1.86""},{""PointId"":""d1_midtemp"",""Description"":""分离器出口蒸汽温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.77"",""lowerBound"":""-1.77"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""452.48"",""TMin"":""360.76"",""TAvg"":""414.75"",""DMax"":""3.88"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.43"",""C99"":""1.77""},{""PointId"":""d1_10had40ct101k"",""Description"":""分离器出口平衡集箱温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""6.10"",""lowerBound"":""-6.10"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""455.62"",""TMin"":""360.97"",""TAvg"":""413.26"",""DMax"":""13.68"",""DMin"":""0.00"",""DAvg"":""1.30"",""C95"":""4.95"",""C99"":""6.10""},{""PointId"":""d1_10had40ct103k"",""Description"":""分离器出口平衡集箱温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.48"",""lowerBound"":""-3.48"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""451.80"",""TMin"":""361.09"",""TAvg"":""415.46"",""DMax"":""7.54"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.81"",""C99"":""3.48""},{""PointId"":""d1_10had40ct102k"",""Description"":""分离器出口平衡集箱温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""6.37"",""lowerBound"":""-6.37"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""444.67"",""TMin"":""360.19"",""TAvg"":""414.34"",""DMax"":""15.18"",""DMin"":""0.00"",""DAvg"":""1.30"",""C95"":""5.16"",""C99"":""6.37""},{""PointId"":""d1_t1sir"",""Description"":""A侧一级过热器出口集箱出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.03"",""lowerBound"":""-1.03"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""554.28"",""TMin"":""415.70"",""TAvg"":""490.66"",""DMax"":""6.83"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.82"",""C99"":""1.03""},{""PointId"":""d1_t1sil"",""Description"":""B侧一级过热器出口集箱出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.01"",""lowerBound"":""-1.01"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""545.94"",""TMin"":""416.01"",""TAvg"":""491.92"",""DMax"":""7.04"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.80"",""C99"":""1.01""},{""PointId"":""d1_10hah10ct101k"",""Description"":""A侧一级过热器出口集箱出口温度(A-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.77"",""lowerBound"":""-0.77"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""554.93"",""TMin"":""411.11"",""TAvg"":""492.10"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.62"",""C99"":""0.77""},{""PointId"":""d1_10hah10ct103k"",""Description"":""B侧一级过热器出口集箱出口温度(B-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.89"",""lowerBound"":""-0.89"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""547.27"",""TMin"":""408.97"",""TAvg"":""492.86"",""DMax"":""3.43"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.72"",""C99"":""0.89""},{""PointId"":""d1_10hah10ct102k"",""Description"":""A侧一级过热器出口集箱出口温度(A-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""551.77"",""TMin"":""410.31"",""TAvg"":""489.25"",""DMax"":""3.44"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.56"",""C99"":""0.69""},{""PointId"":""d1_10hah10ct104k"",""Description"":""B侧一级过热器出口集箱出口温度(B-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.76"",""lowerBound"":""-0.76"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""544.93"",""TMin"":""409.63"",""TAvg"":""490.99"",""DMax"":""4.36"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.61"",""C99"":""0.76""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:43:53"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[361.131,360.758,360.969,361.089,360.191,415.703,416.009,411.11,408.972,410.31,409.631],""Train_X_max"":[451.773,452.479,455.617,451.802,444.674,554.276,545.94,554.932,547.266,551.765,544.932],""Train_X_std"":[18.53,18.527,21.028,18.024,18.026,15.918,14.456,15.966,14.57,15.895,14.372],""Train_X_mean"":[414.739,414.748,413.257,415.456,414.339,490.664,491.92,492.097,492.861,489.245,490.992],""Train_X_bais_max"":[[4.008,3.883,13.681,7.541,15.18,6.832,7.043,3.071,3.427,3.437,4.364]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.385,0.372,1.303,0.708,1.303,0.144,0.141,0.145,0.172,0.137,0.148]],""QCUL_95"":0.08180412,""QCUL_99"":0.140890211,""QCUL_95_line"":[1.507,1.433,4.949,2.814,5.155,0.819,0.801,0.616,0.715,0.555,0.614],""QCUL_99_line"":[1.863,1.768,6.102,3.48,6.373,1.033,1.009,0.765,0.887,0.687,0.762],""T2CUL_95"":7.828,""T2CUL_99"":11.369,""T2CUL_95_line"":[0.839,0.839,0.952,0.816,0.816,0.721,0.654,0.723,0.66,0.72,0.651],""T2CUL_99_line"":[1.011,1.011,1.147,0.983,0.983,0.868,0.789,0.871,0.795,0.867,0.784],""Kesi_95"":1.578,""Kesi_99"":1.365,""Kesi_95_line"":[0.377,0.377,0.427,0.366,0.366,0.324,0.294,0.325,0.296,0.323,0.292],""Kesi_99_line"":[0.35,0.35,0.398,0.341,0.341,0.301,0.273,0.302,0.275,0.301,0.272],""COV"":[[1.0,1.0,0.989,0.998,0.992,0.236,-0.09,0.229,-0.098,0.242,-0.081],[1.0,1.0,0.99,0.998,0.992,0.236,-0.09,0.229,-0.098,0.242,-0.082],[0.989,0.99,1.0,0.986,0.975,0.255,-0.131,0.248,-0.139,0.261,-0.123],[0.998,0.998,0.986,1.0,0.988,0.227,-0.083,0.22,-0.091,0.233,-0.074],[0.992,0.992,0.975,0.988,1.0,0.248,-0.063,0.24,-0.071,0.253,-0.054],[0.236,0.236,0.255,0.227,0.248,1.0,0.768,1.0,0.764,1.0,0.768],[-0.09,-0.09,-0.131,-0.083,-0.063,0.768,1.0,0.771,1.0,0.764,1.0],[0.229,0.229,0.248,0.22,0.24,1.0,0.771,1.0,0.769,1.0,0.773],[-0.098,-0.098,-0.139,-0.091,-0.071,0.764,1.0,0.769,1.0,0.762,1.0],[0.242,0.242,0.261,0.233,0.253,1.0,0.764,1.0,0.762,1.0,0.766],[-0.081,-0.082,-0.123,-0.074,-0.054,0.768,1.0,0.773,1.0,0.766,1.0]],""K"":3,""R"":0.998,""featValue"":[5.633,4.82,0.523,0.018,0.005,0.002,0.001,0.0,0.0,0.0,0.0],""featVec"":[[0.28,-0.338,-0.105,-0.021,0.221,-0.517,0.023,-0.026,0.683,0.105,0.033],[0.28,-0.338,-0.105,-0.022,0.212,-0.477,0.027,-0.03,-0.714,-0.096,-0.042],[0.276,-0.342,0.042,-0.543,-0.708,0.092,-0.009,0.022,0.008,-0.003,0.003],[0.279,-0.337,-0.141,-0.246,0.539,0.658,-0.064,0.007,0.016,-0.005,0.004],[0.285,-0.329,-0.137,0.795,-0.316,0.239,0.023,0.043,0.008,-0.001,0.002],[0.362,0.192,0.404,0.054,0.034,-0.025,-0.538,0.048,-0.094,0.516,0.312],[0.268,0.327,-0.387,-0.02,-0.058,-0.052,-0.608,0.045,0.079,-0.468,-0.262],[0.361,0.195,0.4,0.017,0.069,0.001,0.312,0.362,0.06,-0.556,0.354],[0.266,0.33,-0.386,-0.068,-0.017,-0.005,0.344,0.565,-0.051,0.426,-0.213],[0.363,0.189,0.404,0.035,0.034,0.044,0.227,-0.413,0.033,0.038,-0.663],[0.27,0.325,-0.391,-0.039,-0.06,0.034,0.261,-0.609,-0.028,0.045,0.469]],""selectVec"":[[0.28,-0.338,-0.105],[0.28,-0.338,-0.105],[0.276,-0.342,0.042],[0.279,-0.337,-0.141],[0.285,-0.329,-0.137],[0.362,0.192,0.404],[0.268,0.327,-0.387],[0.361,0.195,0.4],[0.266,0.33,-0.386],[0.363,0.189,0.404],[0.27,0.325,-0.391]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5866,""AfterCleanSamNum"":3820,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""3"",""precision"":""99.8%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":216,""version"":""v-2025-12-04 17:43:53"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R10[0] = reconData[0][9];
	        OUT_B10[0] = errorData[0][9];
	        OUT_F10[0] = paraState[0][9];
	        OUT_R11[0] = reconData[0][10];
	        OUT_B11[0] = errorData[0][10];
	        OUT_F11[0] = paraState[0][10];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[11] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11};
			float[] arrOUT_B = new float[11] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11};
			LD[] arrOUT_W = new LD[11] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11 };
			
	        if (!(Condition1>350))
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