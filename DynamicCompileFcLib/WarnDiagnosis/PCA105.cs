using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA105")]
    [FCDisplay("PCA105")]
    public partial class PCA105 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽机转速大于500")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承回油温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承左前上部温度#1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承右前上部温度#1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承左前下部温度#1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承右前下部温度#1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承左前上部温度#2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承右前上部温度#2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承左前下部温度#2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承右前下部温度#2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承左前上部温度#3")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承右前上部温度#3")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承左前下部温度#3")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1轴承右前下部温度#3")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出13")]
	    public LA OUT_R13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出13")]
	    public LA OUT_B13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出13")]
	    public LD OUT_F13 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出13")]
	    public LD OUT_W13 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[13] {false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[13] {false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[13] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA105()
		{
			ModelID = 113;
			SysID = 13;
			FcType = enumType.Warn;
			FcName = "PCA105";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""113"",""name"":""PCA105"",""description"":""#1轴承温度"",""founder"":""admin"",""creatTime"":""2023-10-25 11:14:48"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 16:14:10"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 15:43:34"",""et"":""2025-11-26 03:19:04"",""duration"":1164930,""number"":3884,""filter"":90,""mode"":3794,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10mav71ct101a"",""Description"":""#1轴承回油温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.12"",""lowerBound"":""-1.12"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""57.19"",""TMin"":""52.24"",""TAvg"":""53.87"",""DMax"":""1.72"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.92"",""C99"":""1.12""},{""PointId"":""d1_10mad11ct111a"",""Description"":""#1轴承左前上部温度#1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""57.46"",""TMin"":""52.99"",""TAvg"":""54.36"",""DMax"":""0.60"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10mad11ct112a"",""Description"":""#1轴承右前上部温度#1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""59.67"",""TMin"":""56.39"",""TAvg"":""57.64"",""DMax"":""0.88"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10mad11ct113a"",""Description"":""#1轴承左前下部温度#1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.91"",""lowerBound"":""-0.91"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""80.40"",""TMin"":""75.69"",""TAvg"":""78.13"",""DMax"":""1.49"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.75"",""C99"":""0.91""},{""PointId"":""d1_10mad11ct114a"",""Description"":""#1轴承右前下部温度#1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""59.40"",""TMin"":""54.81"",""TAvg"":""57.66"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.26""},{""PointId"":""d1_10mad11ct111b"",""Description"":""#1轴承左前上部温度#2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.33"",""lowerBound"":""-0.33"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""57.45"",""TMin"":""53.00"",""TAvg"":""54.39"",""DMax"":""0.44"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.27"",""C99"":""0.33""},{""PointId"":""d1_10mad11ct112b"",""Description"":""#1轴承右前上部温度#2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""59.86"",""TMin"":""57.00"",""TAvg"":""57.88"",""DMax"":""0.49"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.20"",""C99"":""0.24""},{""PointId"":""d1_10mad11ct113b"",""Description"":""#1轴承左前下部温度#2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.77"",""lowerBound"":""-0.77"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""80.32"",""TMin"":""75.93"",""TAvg"":""78.35"",""DMax"":""0.89"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.63"",""C99"":""0.77""},{""PointId"":""d1_10mad11ct114b"",""Description"":""#1轴承右前下部温度#2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.33"",""lowerBound"":""-0.33"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""58.95"",""TMin"":""54.85"",""TAvg"":""57.77"",""DMax"":""0.65"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.27"",""C99"":""0.33""},{""PointId"":""d1_10mad11ct111c"",""Description"":""#1轴承左前上部温度#3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.34"",""lowerBound"":""-0.34"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""57.80"",""TMin"":""53.33"",""TAvg"":""54.65"",""DMax"":""0.62"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.27"",""C99"":""0.34""},{""PointId"":""d1_10mad11ct112c"",""Description"":""#1轴承右前上部温度#3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""60.48"",""TMin"":""57.52"",""TAvg"":""58.45"",""DMax"":""0.49"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10mad11ct113c"",""Description"":""#1轴承左前下部温度#3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.86"",""lowerBound"":""-0.86"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""80.36"",""TMin"":""75.95"",""TAvg"":""78.38"",""DMax"":""0.94"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.70"",""C99"":""0.86""},{""PointId"":""d1_10mad11ct114c"",""Description"":""#1轴承右前下部温度#3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""59.13"",""TMin"":""55.10"",""TAvg"":""57.93"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.21"",""C99"":""0.26""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 16:14:10"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[52.243,52.989,56.387,75.694,54.807,52.998,56.998,75.927,54.849,53.326,57.52,75.947,55.102],""Train_X_max"":[57.189,57.462,59.667,80.403,59.395,57.448,59.862,80.319,58.951,57.797,60.481,80.356,59.13],""Train_X_std"":[1.015,0.773,0.577,1.01,0.404,0.74,0.527,0.987,0.373,0.753,0.535,0.982,0.361],""Train_X_mean"":[53.866,54.355,57.639,78.125,57.66,54.392,57.884,78.354,57.773,54.648,58.445,78.382,57.927],""Train_X_bais_max"":[[1.721,0.6,0.882,1.492,0.465,0.441,0.489,0.887,0.646,0.619,0.491,0.937,0.57]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.26,0.085,0.077,0.213,0.055,0.08,0.055,0.182,0.076,0.077,0.073,0.201,0.053]],""QCUL_95"":1.600148,""QCUL_99"":2.546923,""QCUL_95_line"":[0.916,0.303,0.297,0.745,0.209,0.272,0.197,0.631,0.268,0.273,0.251,0.699,0.211],""QCUL_99_line"":[1.124,0.372,0.366,0.913,0.258,0.332,0.242,0.773,0.328,0.335,0.307,0.856,0.261],""T2CUL_95"":5.999,""T2CUL_99"":9.226,""T2CUL_95_line"":[0.04,0.031,0.023,0.04,0.016,0.029,0.021,0.039,0.015,0.03,0.021,0.039,0.014],""T2CUL_99_line"":[0.05,0.038,0.028,0.05,0.02,0.037,0.026,0.049,0.018,0.037,0.026,0.048,0.018],""Kesi_95"":1.576,""Kesi_99"":1.377,""Kesi_95_line"":[0.021,0.016,0.012,0.021,0.008,0.015,0.011,0.02,0.008,0.015,0.011,0.02,0.007],""Kesi_99_line"":[0.019,0.015,0.011,0.019,0.008,0.014,0.01,0.019,0.007,0.014,0.01,0.019,0.007],""COV"":[[1.0,0.857,0.824,-0.861,-0.631,0.89,0.888,-0.885,-0.73,0.898,0.888,-0.874,-0.702],[0.857,1.0,0.975,-0.751,-0.372,0.985,0.971,-0.812,-0.554,0.981,0.964,-0.802,-0.523],[0.824,0.975,1.0,-0.658,-0.274,0.94,0.972,-0.734,-0.49,0.938,0.967,-0.72,-0.448],[-0.861,-0.751,-0.658,1.0,0.803,-0.821,-0.767,0.991,0.815,-0.82,-0.753,0.991,0.824],[-0.631,-0.372,-0.274,0.803,1.0,-0.473,-0.421,0.755,0.934,-0.487,-0.423,0.751,0.941],[0.89,0.985,0.94,-0.821,-0.473,1.0,0.977,-0.86,-0.602,0.996,0.967,-0.852,-0.58],[0.888,0.971,0.972,-0.767,-0.421,0.977,1.0,-0.813,-0.565,0.975,0.992,-0.803,-0.537],[-0.885,-0.812,-0.734,0.991,0.755,-0.86,-0.813,1.0,0.817,-0.86,-0.8,0.998,0.816],[-0.73,-0.554,-0.49,0.815,0.934,-0.602,-0.565,0.817,1.0,-0.619,-0.574,0.805,0.979],[0.898,0.981,0.938,-0.82,-0.487,0.996,0.975,-0.86,-0.619,1.0,0.977,-0.846,-0.58],[0.888,0.964,0.967,-0.753,-0.423,0.967,0.992,-0.8,-0.574,0.977,1.0,-0.782,-0.522],[-0.874,-0.802,-0.72,0.991,0.751,-0.852,-0.803,0.998,0.805,-0.846,-0.782,1.0,0.818],[-0.702,-0.523,-0.448,0.824,0.941,-0.58,-0.537,0.816,0.979,-0.58,-0.522,0.818,1.0]],""K"":2,""R"":0.954,""featValue"":[10.435,1.969,0.3,0.133,0.091,0.045,0.029,0.001,0.001,0.0,0.0,0.0,0.0],""featVec"":[[0.292,-0.026,-0.029,-0.821,-0.42,-0.246,-0.042,0.019,0.021,-0.008,0.007,-0.001,0.002],[0.284,-0.262,-0.071,0.282,-0.066,-0.42,0.055,0.069,0.423,-0.4,-0.346,0.342,0.049],[0.269,-0.326,-0.246,0.208,-0.324,0.304,0.011,0.461,0.276,0.26,0.372,-0.149,0.066],[-0.288,-0.176,-0.483,0.013,-0.105,-0.139,-0.037,0.067,-0.062,0.061,-0.519,-0.553,-0.181],[-0.215,-0.495,0.137,0.204,-0.535,-0.065,0.098,-0.425,-0.365,0.025,0.119,0.144,0.006],[0.294,-0.2,0.032,0.101,0.274,-0.397,-0.246,0.064,-0.352,-0.325,0.411,-0.399,-0.083],[0.288,-0.245,-0.118,-0.065,0.134,0.402,-0.419,0.138,-0.424,-0.011,-0.329,0.369,-0.203],[-0.296,-0.122,-0.395,-0.123,0.164,-0.112,-0.262,0.026,-0.066,-0.002,0.124,0.201,0.746],[-0.248,-0.383,0.432,-0.136,0.149,0.012,-0.54,-0.103,0.461,0.161,-0.018,-0.122,-0.094],[0.295,-0.193,-0.013,0.014,0.341,-0.341,0.238,-0.137,-0.073,0.738,-0.097,0.078,0.033],[0.286,-0.247,-0.184,-0.153,0.241,0.429,0.244,-0.567,0.197,-0.238,-0.008,-0.242,0.151],[-0.294,-0.129,-0.442,-0.166,0.208,-0.087,0.106,-0.064,0.153,-0.048,0.385,0.344,-0.562],[-0.242,-0.415,0.307,-0.251,0.242,0.086,0.511,0.468,-0.14,-0.179,-0.09,-0.009,0.084]],""selectVec"":[[0.292,-0.026],[0.284,-0.262],[0.269,-0.326],[-0.288,-0.176],[-0.215,-0.495],[0.294,-0.2],[0.288,-0.245],[-0.296,-0.122],[-0.248,-0.383],[0.295,-0.193],[0.286,-0.247],[-0.294,-0.129],[-0.242,-0.415]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3884,""AfterCleanSamNum"":3794,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""汽机转速大于500"",""alarmcondition"":""[d1_10cjj01yq03ai]>500""},""copy"":false,""principal"":""2"",""precision"":""95.4%"",""rate"":""0.95"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":113,""version"":""v-2025-12-04 16:14:10"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R13[0] = reconData[0][12];
	        OUT_B13[0] = errorData[0][12];
	        OUT_F13[0] = paraState[0][12];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[13] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13};
			float[] arrOUT_B = new float[13] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13};
			LD[] arrOUT_W = new LD[13] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13 };
			
	        if (!(Condition1>500))
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