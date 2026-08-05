using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA136")]
    [FCDisplay("PCA136")]
    public partial class PCA136 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("循泵出口门开度大于20")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D驱动端轴承温度2")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D非驱动端轴承温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机定子U相温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机定子V相温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机定子W相温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机驱动端轴承温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机非驱动端轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D驱动端轴承温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D非驱动端轴承温度1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机定子U相温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机定子V相温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机定子W相温度2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机驱动端轴承温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵D电机非驱动端轴承温度2")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出14")]
	    public LA OUT_R14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出14")]
	    public LA OUT_B14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出14")]
	    public LD OUT_F14 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出14")]
	    public LD OUT_W14 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[14] {false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[14] {false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[14] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA136()
		{
			ModelID = 145;
			SysID = 20;
			FcType = enumType.Warn;
			FcName = "PCA136";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""145"",""name"":""PCA136"",""description"":""循环水泵D电机温度"",""founder"":""admin"",""creatTime"":""2023-10-27 14:19:55"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:16:22"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-09-04 12:05:00"",""et"":""2025-10-06 08:43:00"",""duration"":2752680,""number"":9176,""filter"":3732,""mode"":5444,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":3260}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pac40ct112r"",""Description"":""#1机组循环水泵D驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.55"",""lowerBound"":""-1.55"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""52.00"",""TMin"":""25.51"",""TAvg"":""42.42"",""DMax"":""4.28"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.26"",""C99"":""1.55""},{""PointId"":""d1_10pac40ct114r"",""Description"":""#1机组循环水泵D非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.15"",""lowerBound"":""-1.15"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""58.84"",""TMin"":""25.10"",""TAvg"":""48.85"",""DMax"":""3.06"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.93"",""C99"":""1.15""},{""PointId"":""d1_10pac40ct101r"",""Description"":""#1机组循环水泵D电机定子U相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""97.18"",""TMin"":""29.41"",""TAvg"":""81.00"",""DMax"":""1.82"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10pac40ct103r"",""Description"":""#1机组循环水泵D电机定子V相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""99.66"",""TMin"":""29.78"",""TAvg"":""83.51"",""DMax"":""0.56"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10pac40ct105r"",""Description"":""#1机组循环水泵D电机定子W相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""100.13"",""TMin"":""30.61"",""TAvg"":""84.20"",""DMax"":""1.46"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.10"",""C99"":""0.13""},{""PointId"":""d1_10pac40ct107r"",""Description"":""#1机组循环水泵D电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""57.99"",""TMin"":""22.97"",""TAvg"":""48.10"",""DMax"":""0.40"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10pac40ct109r"",""Description"":""#1机组循环水泵D电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.59"",""lowerBound"":""-0.59"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""51.02"",""TMin"":""21.95"",""TAvg"":""38.38"",""DMax"":""1.76"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.48"",""C99"":""0.59""},{""PointId"":""d1_10pac40ct111r"",""Description"":""#1机组循环水泵D驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.56"",""lowerBound"":""-1.56"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""52.46"",""TMin"":""25.98"",""TAvg"":""42.89"",""DMax"":""4.21"",""DMin"":""0.00"",""DAvg"":""0.33"",""C95"":""1.27"",""C99"":""1.56""},{""PointId"":""d1_10pac40ct113r"",""Description"":""#1机组循环水泵D非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.84"",""lowerBound"":""-0.84"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""58.43"",""TMin"":""25.35"",""TAvg"":""48.28"",""DMax"":""2.37"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.68"",""C99"":""0.84""},{""PointId"":""d1_10pac40ct102r"",""Description"":""#1机组循环水泵D电机定子U相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.06"",""lowerBound"":""-0.06"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""99.02"",""TMin"":""29.95"",""TAvg"":""83.08"",""DMax"":""0.48"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.05"",""C99"":""0.06""},{""PointId"":""d1_10pac40ct104r"",""Description"":""#1机组循环水泵D电机定子V相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""100.41"",""TMin"":""30.37"",""TAvg"":""84.32"",""DMax"":""0.68"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10pac40ct106r"",""Description"":""#1机组循环水泵D电机定子W相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""98.89"",""TMin"":""29.65"",""TAvg"":""82.70"",""DMax"":""0.94"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.13""},{""PointId"":""d1_10pac40ct108r"",""Description"":""#1机组循环水泵D电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""58.68"",""TMin"":""23.48"",""TAvg"":""47.88"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10pac40ct110r"",""Description"":""#1机组循环水泵D电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""50.03"",""TMin"":""21.54"",""TAvg"":""37.54"",""DMax"":""1.17"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.38"",""C99"":""0.47""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:16:22"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[25.507,25.101,29.411,29.777,30.606,22.971,21.948,25.977,25.345,29.946,30.369,29.654,23.477,21.543],""Train_X_max"":[52.002,58.844,97.178,99.658,100.134,57.986,51.024,52.458,58.426,99.015,100.414,98.889,58.683,50.032],""Train_X_std"":[3.647,3.367,7.357,7.385,7.321,5.156,4.303,3.618,3.453,7.303,7.38,7.364,5.306,4.334],""Train_X_mean"":[42.415,48.853,81.001,83.513,84.203,48.096,38.377,42.893,48.278,83.078,84.315,82.704,47.884,37.542],""Train_X_bais_max"":[[4.276,3.057,1.817,0.563,1.464,0.403,1.764,4.206,2.367,0.477,0.68,0.937,0.251,1.167]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.323,0.242,0.041,0.036,0.021,0.036,0.121,0.326,0.173,0.012,0.033,0.029,0.034,0.101]],""QCUL_95"":0.202054784,""QCUL_99"":0.35587433,""QCUL_95_line"":[1.256,0.933,0.179,0.138,0.103,0.129,0.48,1.265,0.676,0.051,0.137,0.107,0.128,0.384],""QCUL_99_line"":[1.551,1.152,0.222,0.171,0.128,0.158,0.594,1.562,0.835,0.064,0.17,0.132,0.157,0.473],""T2CUL_95"":9.501,""T2CUL_99"":13.3,""T2CUL_95_line"":[0.152,0.141,0.307,0.309,0.306,0.215,0.18,0.151,0.144,0.305,0.308,0.308,0.222,0.181],""T2CUL_99_line"":[0.18,0.166,0.364,0.365,0.362,0.255,0.213,0.179,0.171,0.361,0.365,0.364,0.262,0.214],""Kesi_95"":1.617,""Kesi_99"":1.425,""Kesi_95_line"":[0.063,0.058,0.127,0.127,0.126,0.089,0.074,0.062,0.06,0.126,0.127,0.127,0.091,0.075],""Kesi_99_line"":[0.059,0.054,0.119,0.119,0.118,0.083,0.07,0.059,0.056,0.118,0.119,0.119,0.086,0.07],""COV"":[[1.0,0.953,0.929,0.927,0.926,0.776,0.921,1.0,0.963,0.927,0.926,0.928,0.742,0.924],[0.953,1.0,0.866,0.867,0.864,0.675,0.849,0.955,0.999,0.865,0.866,0.868,0.639,0.85],[0.929,0.866,1.0,1.0,1.0,0.859,0.943,0.924,0.872,1.0,1.0,1.0,0.827,0.946],[0.927,0.867,1.0,1.0,1.0,0.861,0.942,0.922,0.873,1.0,1.0,1.0,0.83,0.944],[0.926,0.864,1.0,1.0,1.0,0.861,0.941,0.922,0.871,1.0,1.0,1.0,0.83,0.944],[0.776,0.675,0.859,0.861,0.861,1.0,0.862,0.77,0.688,0.861,0.862,0.859,0.998,0.861],[0.921,0.849,0.943,0.942,0.941,0.862,1.0,0.918,0.858,0.942,0.941,0.942,0.835,1.0],[1.0,0.955,0.924,0.922,0.922,0.77,0.918,1.0,0.965,0.922,0.922,0.924,0.736,0.92],[0.963,0.999,0.872,0.873,0.871,0.688,0.858,0.965,1.0,0.871,0.872,0.874,0.653,0.859],[0.927,0.865,1.0,1.0,1.0,0.861,0.942,0.922,0.871,1.0,1.0,1.0,0.83,0.945],[0.926,0.866,1.0,1.0,1.0,0.862,0.941,0.922,0.872,1.0,1.0,1.0,0.83,0.944],[0.928,0.868,1.0,1.0,1.0,0.859,0.942,0.924,0.874,1.0,1.0,1.0,0.827,0.945],[0.742,0.639,0.827,0.83,0.83,0.998,0.835,0.736,0.653,0.83,0.83,0.827,1.0,0.834],[0.924,0.85,0.946,0.944,0.944,0.861,1.0,0.92,0.859,0.945,0.944,0.945,0.834,1.0]],""K"":4,""R"":0.996,""featValue"":[12.739,0.774,0.283,0.152,0.054,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.27,0.241,0.194,-0.035,-0.563,-0.151,-0.161,0.163,0.651,-0.067,-0.091,-0.022,0.003,0.018],[0.255,0.42,0.271,0.208,0.449,-0.603,-0.212,0.081,-0.155,0.021,-0.024,0.022,-0.011,0.001],[0.277,-0.038,-0.28,0.085,-0.015,0.056,-0.459,-0.52,0.088,0.381,0.258,-0.047,-0.201,-0.301],[0.277,-0.041,-0.276,0.109,0.024,-0.014,0.203,0.054,0.005,0.183,-0.549,0.316,0.417,-0.424],[0.277,-0.044,-0.281,0.107,0.001,-0.058,0.14,0.269,-0.015,-0.488,0.585,-0.058,0.159,-0.356],[0.247,-0.487,0.351,0.174,0.014,0.223,-0.33,0.54,-0.133,0.278,0.053,0.001,0.001,-0.021],[0.271,-0.056,0.058,-0.633,0.181,-0.144,0.399,0.081,0.119,0.43,0.184,-0.255,0.036,-0.009],[0.269,0.253,0.205,-0.033,-0.571,0.04,0.165,-0.129,-0.662,0.078,0.064,0.014,-0.006,-0.015],[0.257,0.406,0.286,0.183,0.316,0.682,0.206,-0.104,0.18,-0.033,0.049,-0.011,0.011,-0.003],[0.277,-0.043,-0.28,0.101,0.003,-0.025,0.054,-0.023,0.049,0.128,0.241,0.493,0.169,0.694],[0.277,-0.043,-0.278,0.112,0.025,-0.014,0.249,0.199,-0.021,-0.075,-0.256,0.002,-0.81,0.045],[0.277,-0.036,-0.277,0.102,0.016,0.06,-0.143,-0.04,-0.098,-0.134,-0.275,-0.718,0.269,0.344],[0.239,-0.533,0.413,0.192,0.019,-0.208,0.284,-0.498,0.116,-0.253,-0.046,-0.001,0.0,0.019],[0.271,-0.052,0.043,-0.624,0.14,0.148,-0.393,-0.082,-0.125,-0.454,-0.191,0.265,-0.038,0.009]],""selectVec"":[[0.27,0.241,0.194,-0.035],[0.255,0.42,0.271,0.208],[0.277,-0.038,-0.28,0.085],[0.277,-0.041,-0.276,0.109],[0.277,-0.044,-0.281,0.107],[0.247,-0.487,0.351,0.174],[0.271,-0.056,0.058,-0.633],[0.269,0.253,0.205,-0.033],[0.257,0.406,0.286,0.183],[0.277,-0.043,-0.28,0.101],[0.277,-0.043,-0.278,0.112],[0.277,-0.036,-0.277,0.102],[0.239,-0.533,0.413,0.192],[0.271,-0.052,0.043,-0.624]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":9176,""AfterCleanSamNum"":5444,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""循泵出口门开度大于20"",""alarmcondition"":""[d1_10pac40aa001xq11]>20""},""copy"":false,""principal"":""4"",""precision"":""99.6%"",""rate"":""0.988"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":145,""version"":""v-2025-12-04 17:16:22"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R14[0] = reconData[0][13];
	        OUT_B14[0] = errorData[0][13];
	        OUT_F14[0] = paraState[0][13];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[14] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14};
			float[] arrOUT_B = new float[14] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14};
			LD[] arrOUT_W = new LD[14] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14 };
			
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