using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA413")]
    [FCDisplay("PCA413")]
    public partial class PCA413 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧二级过热器入口集箱入口温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧二级过热器入口集箱入口温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧二级过热器出口集箱出口温度温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧二级过热器出口集箱出口温度温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧二级过热器入口集箱入口温(A-1)")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧二级过热器入口集箱入口温(B-1)")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧二级过热器出口集箱出口温度(A-1)")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧二级过热器出口集箱出口温度(B-1)")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧二级过热器入口集箱入口温(A-2)")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧二级过热器入口集箱入口温(B-2)")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧二级过热器出口集箱出口温度(A-2)")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧二级过热器出口集箱出口温度(B-2)")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出12")]
	    public LA OUT_R12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出12")]
	    public LA OUT_B12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出12")]
	    public LD OUT_F12 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出12")]
	    public LD OUT_W12 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[12] {false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[12] {false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[12] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA413()
		{
			ModelID = 454;
			SysID = 25;
			FcType = enumType.Warn;
			FcName = "PCA413";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""454"",""name"":""PCA413"",""description"":""二过出入口温度"",""founder"":""admin"",""creatTime"":""2025-12-04 17:45:00"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:46:04"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-26 01:49:48"",""duration"":1148862,""number"":3830,""filter"":1363,""mode"":2467,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1273},{""st"":""2025-11-26 19:41:00"",""et"":""2025-12-03 13:06:26"",""duration"":581126,""number"":1938,""filter"":737,""mode"":1201,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":647}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_t1sor"",""Description"":""A侧二级过热器入口集箱入口温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""535.61"",""TMin"":""397.41"",""TAvg"":""480.72"",""DMax"":""4.14"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.55"",""C99"":""0.69""},{""PointId"":""d1_t1sol"",""Description"":""B侧二级过热器入口集箱入口温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""522.84"",""TMin"":""393.78"",""TAvg"":""475.80"",""DMax"":""5.72"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.61"",""C99"":""0.78""},{""PointId"":""d1_t2sir"",""Description"":""A侧二级过热器出口集箱出口温度温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""563.13"",""TMin"":""488.69"",""TAvg"":""534.47"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.43"",""C99"":""0.54""},{""PointId"":""d1_t2sil"",""Description"":""B侧二级过热器出口集箱出口温度温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""567.86"",""TMin"":""491.42"",""TAvg"":""536.14"",""DMax"":""3.26"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.47"",""C99"":""0.60""},{""PointId"":""d1_10hah10ct105k"",""Description"":""A侧二级过热器入口集箱入口温(A-1)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""537.26"",""TMin"":""398.67"",""TAvg"":""481.98"",""DMax"":""2.42"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10hah10ct107k"",""Description"":""B侧二级过热器入口集箱入口温(B-1)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""523.54"",""TMin"":""394.62"",""TAvg"":""476.35"",""DMax"":""3.67"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.53"",""C99"":""0.66""},{""PointId"":""d1_10hah20ct101k"",""Description"":""A侧二级过热器出口集箱出口温度(A-1)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""563.87"",""TMin"":""489.42"",""TAvg"":""535.07"",""DMax"":""1.83"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.45"",""C99"":""0.56""},{""PointId"":""d1_10hah20ct103k"",""Description"":""B侧二级过热器出口集箱出口温度(B-1)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""568.84"",""TMin"":""491.91"",""TAvg"":""536.87"",""DMax"":""2.16"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10hah10ct106k"",""Description"":""A侧二级过热器入口集箱入口温(A-2)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""534.40"",""TMin"":""396.14"",""TAvg"":""479.46"",""DMax"":""1.71"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.43"",""C99"":""0.53""},{""PointId"":""d1_10hah10ct108k"",""Description"":""B侧二级过热器入口集箱入口温(B-2)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""522.09"",""TMin"":""392.91"",""TAvg"":""475.27"",""DMax"":""2.03"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.46"",""C99"":""0.56""},{""PointId"":""d1_10hah20ct102k"",""Description"":""A侧二级过热器出口集箱出口温度(A-2)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""562.41"",""TMin"":""487.90"",""TAvg"":""533.87"",""DMax"":""1.73"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.43"",""C99"":""0.53""},{""PointId"":""d1_10hah20ct104k"",""Description"":""B侧二级过热器出口集箱出口温度(B-2)"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""566.88"",""TMin"":""490.59"",""TAvg"":""535.40"",""DMax"":""1.80"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.43"",""C99"":""0.52""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:46:04"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[397.406,393.78,488.691,491.416,398.666,394.62,489.423,491.909,396.138,392.906,487.898,490.585],""Train_X_max"":[535.607,522.841,563.125,567.858,537.264,523.536,563.872,568.835,534.399,522.087,562.408,566.882],""Train_X_std"":[13.934,14.636,9.077,9.423,13.918,14.58,9.109,9.47,13.915,14.623,9.079,9.418],""Train_X_mean"":[480.718,475.797,534.465,536.139,481.976,476.346,535.067,536.871,479.463,475.268,533.866,535.401],""Train_X_bais_max"":[[4.136,5.724,3.553,3.262,2.422,3.674,1.834,2.156,1.713,2.033,1.733,1.802]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.086,0.094,0.063,0.071,0.123,0.128,0.123,0.128,0.115,0.119,0.118,0.118]],""QCUL_95"":0.008532211,""QCUL_99"":0.0125691248,""QCUL_95_line"":[0.545,0.612,0.428,0.473,0.486,0.534,0.453,0.486,0.43,0.456,0.433,0.425],""QCUL_99_line"":[0.691,0.776,0.544,0.6,0.601,0.662,0.558,0.599,0.53,0.563,0.532,0.523],""T2CUL_95"":9.507,""T2CUL_99"":13.311,""T2CUL_95_line"":[0.702,0.738,0.457,0.475,0.701,0.735,0.459,0.477,0.701,0.737,0.458,0.475],""T2CUL_99_line"":[0.831,0.873,0.541,0.562,0.83,0.869,0.543,0.565,0.83,0.872,0.541,0.562],""Kesi_95"":1.62,""Kesi_99"":1.469,""Kesi_95_line"":[0.29,0.304,0.189,0.196,0.29,0.303,0.189,0.197,0.289,0.304,0.189,0.196],""Kesi_99_line"":[0.276,0.29,0.18,0.187,0.276,0.289,0.18,0.188,0.276,0.29,0.18,0.187],""COV"":[[1.0,0.689,0.318,0.297,1.0,0.687,0.317,0.299,1.0,0.688,0.32,0.297],[0.689,1.0,0.137,0.111,0.689,1.0,0.138,0.115,0.689,1.0,0.139,0.11],[0.318,0.137,1.0,0.701,0.32,0.139,1.0,0.701,0.319,0.138,1.0,0.7],[0.297,0.111,0.701,1.0,0.298,0.112,0.702,1.0,0.297,0.112,0.701,1.0],[1.0,0.689,0.32,0.298,1.0,0.688,0.319,0.3,1.0,0.688,0.321,0.298],[0.687,1.0,0.139,0.112,0.688,1.0,0.14,0.116,0.687,1.0,0.141,0.111],[0.317,0.138,1.0,0.702,0.319,0.14,1.0,0.703,0.318,0.138,1.0,0.702],[0.299,0.115,0.701,1.0,0.3,0.116,0.703,1.0,0.299,0.116,0.702,1.0],[1.0,0.689,0.319,0.297,1.0,0.687,0.318,0.299,1.0,0.688,0.321,0.297],[0.688,1.0,0.138,0.112,0.688,1.0,0.138,0.116,0.688,1.0,0.139,0.112],[0.32,0.139,1.0,0.701,0.321,0.141,1.0,0.702,0.321,0.139,1.0,0.702],[0.297,0.11,0.7,1.0,0.298,0.111,0.702,1.0,0.297,0.112,0.702,1.0]],""K"":4,""R"":1.0,""featValue"":[6.416,3.832,0.894,0.857,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.312,0.241,-0.052,-0.419,0.014,-0.067,0.543,-0.458,-0.366,0.122,-0.004,0.09],[0.253,0.347,0.033,0.383,0.085,-0.1,0.586,0.397,0.369,-0.008,-0.052,-0.102],[0.296,-0.271,0.415,0.013,-0.528,0.146,0.083,0.419,-0.408,0.12,0.052,0.01],[0.289,-0.286,-0.397,0.1,-0.572,0.151,0.072,-0.331,0.406,-0.193,-0.026,-0.008],[0.312,0.241,-0.052,-0.418,0.036,0.281,-0.279,0.264,0.288,0.198,-0.383,0.412],[0.254,0.346,0.034,0.386,-0.008,0.307,-0.308,-0.277,-0.193,0.266,-0.26,-0.474],[0.296,-0.272,0.414,0.015,0.384,0.352,0.016,-0.233,0.313,0.137,0.472,0.041],[0.29,-0.285,-0.397,0.103,0.438,0.308,0.056,0.215,-0.366,-0.428,-0.117,0.005],[0.312,0.241,-0.052,-0.419,-0.049,-0.211,-0.266,0.193,0.077,-0.32,0.389,-0.502],[0.253,0.347,0.031,0.385,-0.08,-0.21,-0.278,-0.12,-0.174,-0.255,0.313,0.575],[0.297,-0.271,0.414,0.013,0.144,-0.5,-0.098,-0.187,0.095,-0.258,-0.523,-0.049],[0.289,-0.286,-0.398,0.099,0.133,-0.458,-0.128,0.117,-0.041,0.622,0.142,0.0]],""selectVec"":[[0.312,0.241,-0.052,-0.419],[0.253,0.347,0.033,0.383],[0.296,-0.271,0.415,0.013],[0.289,-0.286,-0.397,0.1],[0.312,0.241,-0.052,-0.418],[0.254,0.346,0.034,0.386],[0.296,-0.272,0.414,0.015],[0.29,-0.285,-0.397,0.103],[0.312,0.241,-0.052,-0.419],[0.253,0.347,0.031,0.385],[0.297,-0.271,0.414,0.013],[0.289,-0.286,-0.398,0.099]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5767,""AfterCleanSamNum"":3744,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""4"",""precision"":""100%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":454,""version"":""v-2025-12-04 17:46:04"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R12[0] = reconData[0][11];
	        OUT_B12[0] = errorData[0][11];
	        OUT_F12[0] = paraState[0][11];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[12] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12};
			float[] arrOUT_B = new float[12] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12};
			LD[] arrOUT_W = new LD[12] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12 };
			
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