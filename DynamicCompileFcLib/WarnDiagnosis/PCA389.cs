using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA389")]
    [FCDisplay("PCA389")]
    public partial class PCA389 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("循环水泵A电流")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机定子U相温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机定子V相温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机定子W相温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机驱动端轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机非驱动端轴承温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A驱动端轴承温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A非驱动端轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机定子U相温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机定子V相温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机定子W相温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机驱动端轴承温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A电机非驱动端轴承温度2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A驱动端轴承温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵A非驱动端轴承温度2")]
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

		public PCA389()
		{
			ModelID = 429;
			SysID = 20;
			FcType = enumType.Warn;
			FcName = "PCA389";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""429"",""name"":""PCA389"",""description"":""循泵A温度"",""founder"":""admin"",""creatTime"":""2025-10-27 16:00:41"",""Modifier"":""admin"",""modifiedTime"":""2025-10-27 16:02:55"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-08-19 20:35:52"",""et"":""2025-09-01 22:43:12"",""duration"":1130840,""number"":3770,""filter"":90,""mode"":3680,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pac10ct101r"",""Description"":""#1机组循环水泵A电机定子U相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""113.44"",""TMin"":""89.90"",""TAvg"":""100.40"",""DMax"":""1.35"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.92"",""C99"":""1.13""},{""PointId"":""d1_10pac10ct103r"",""Description"":""#1机组循环水泵A电机定子V相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""113.12"",""TMin"":""89.60"",""TAvg"":""100.11"",""DMax"":""1.32"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.91"",""C99"":""1.12""},{""PointId"":""d1_10pac10ct105r"",""Description"":""#1机组循环水泵A电机定子W相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""112.42"",""TMin"":""88.85"",""TAvg"":""99.36"",""DMax"":""1.29"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""0.88"",""C99"":""1.07""},{""PointId"":""d1_10pac10ct107r"",""Description"":""#1机组循环水泵A电机驱动端轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""60.27"",""TMin"":""45.57"",""TAvg"":""51.51"",""DMax"":""1.30"",""DMin"":""0.00"",""DAvg"":""0.33"",""C95"":""1.15"",""C99"":""1.41""},{""PointId"":""d1_10pac10ct109r"",""Description"":""#1机组循环水泵A电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""54.41"",""TMin"":""39.41"",""TAvg"":""45.62"",""DMax"":""1.45"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.38"",""C99"":""1.69""},{""PointId"":""d1_10pac10ct111r"",""Description"":""#1机组循环水泵A驱动端轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""47.64"",""TMin"":""31.39"",""TAvg"":""37.94"",""DMax"":""0.78"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.70"",""C99"":""0.85""},{""PointId"":""d1_10pac10ct113r"",""Description"":""#1机组循环水泵A非驱动端轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""60.34"",""TMin"":""47.28"",""TAvg"":""52.92"",""DMax"":""1.21"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.62"",""C99"":""0.76""},{""PointId"":""d1_10pac10ct102r"",""Description"":""#1机组循环水泵A电机定子U相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""112.41"",""TMin"":""88.78"",""TAvg"":""99.32"",""DMax"":""1.32"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.92"",""C99"":""1.12""},{""PointId"":""d1_10pac10ct104r"",""Description"":""#1机组循环水泵A电机定子V相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""110.84"",""TMin"":""87.59"",""TAvg"":""97.95"",""DMax"":""1.11"",""DMin"":""0.00"",""DAvg"":""0.22"",""C95"":""0.78"",""C99"":""0.96""},{""PointId"":""d1_10pac10ct106r"",""Description"":""#1机组循环水泵A电机定子W相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""111.81"",""TMin"":""88.36"",""TAvg"":""98.80"",""DMax"":""1.28"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.86"",""C99"":""1.06""},{""PointId"":""d1_10pac10ct108r"",""Description"":""#1机组循环水泵A电机驱动端轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""59.39"",""TMin"":""44.70"",""TAvg"":""50.65"",""DMax"":""1.26"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.21"",""C99"":""1.48""},{""PointId"":""d1_10pac10ct110r"",""Description"":""#1机组循环水泵A电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""53.86"",""TMin"":""38.89"",""TAvg"":""45.10"",""DMax"":""1.40"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.32"",""C99"":""1.62""},{""PointId"":""d1_10pac10ct112r"",""Description"":""#1机组循环水泵A驱动端轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""48.24"",""TMin"":""32.00"",""TAvg"":""38.49"",""DMax"":""0.79"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.81"",""C99"":""0.99""},{""PointId"":""d1_10pac10ct114r"",""Description"":""#1机组循环水泵A非驱动端轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""61.45"",""TMin"":""47.71"",""TAvg"":""53.73"",""DMax"":""0.98"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.84"",""C99"":""1.03""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-10-27 16:02:55"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[89.896,89.597,88.847,45.566,39.408,31.385,47.279,88.782,87.586,88.36,44.704,38.889,31.995,47.708],""Train_X_max"":[113.436,113.118,112.422,60.265,54.41,47.644,60.341,112.412,110.843,111.805,59.388,53.864,48.243,61.453],""Train_X_std"":[5.928,5.915,5.892,3.291,3.256,3.221,2.754,5.94,5.751,5.868,3.301,3.254,3.212,2.797],""Train_X_mean"":[100.396,100.113,99.357,51.507,45.624,37.937,52.923,99.316,97.952,98.803,50.646,45.096,38.491,53.732],""Train_X_bais_max"":[[1.35,1.322,1.294,1.297,1.454,0.784,1.214,1.324,1.109,1.279,1.258,1.402,0.789,0.983]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.26,0.257,0.246,0.334,0.396,0.203,0.175,0.258,0.219,0.242,0.353,0.383,0.236,0.24]],""QCUL_95"":0.3910101,""QCUL_99"":0.65435,""QCUL_95_line"":[0.923,0.909,0.875,1.154,1.377,0.696,0.621,0.916,0.783,0.86,1.21,1.324,0.806,0.841],""QCUL_99_line"":[1.133,1.115,1.074,1.413,1.688,0.852,0.762,1.124,0.961,1.056,1.481,1.621,0.986,1.03],""T2CUL_95"":6.0,""T2CUL_99"":9.227,""T2CUL_95_line"":[0.239,0.239,0.238,0.133,0.131,0.13,0.111,0.24,0.232,0.237,0.133,0.131,0.13,0.113],""T2CUL_99_line"":[0.297,0.296,0.295,0.165,0.163,0.161,0.138,0.297,0.288,0.294,0.165,0.163,0.161,0.14],""Kesi_95"":1.571,""Kesi_99"":1.37,""Kesi_95_line"":[0.122,0.122,0.122,0.068,0.067,0.067,0.057,0.123,0.119,0.121,0.068,0.067,0.066,0.058],""Kesi_99_line"":[0.114,0.114,0.114,0.064,0.063,0.062,0.053,0.115,0.111,0.113,0.064,0.063,0.062,0.054],""COV"":[[1.0,1.0,1.0,0.952,0.929,0.828,0.573,1.0,1.0,1.0,0.95,0.93,0.828,0.637],[1.0,1.0,1.0,0.953,0.93,0.829,0.575,1.0,1.0,1.0,0.951,0.931,0.829,0.638],[1.0,1.0,1.0,0.954,0.932,0.832,0.579,1.0,1.0,1.0,0.952,0.933,0.832,0.642],[0.952,0.953,0.954,1.0,0.985,0.933,0.752,0.952,0.956,0.955,1.0,0.986,0.931,0.795],[0.929,0.93,0.932,0.985,1.0,0.949,0.781,0.93,0.935,0.933,0.984,1.0,0.951,0.819],[0.828,0.829,0.832,0.933,0.949,1.0,0.923,0.828,0.837,0.833,0.934,0.95,1.0,0.946],[0.573,0.575,0.579,0.752,0.781,0.923,1.0,0.574,0.585,0.581,0.754,0.782,0.92,0.995],[1.0,1.0,1.0,0.952,0.93,0.828,0.574,1.0,1.0,1.0,0.95,0.93,0.828,0.638],[1.0,1.0,1.0,0.956,0.935,0.837,0.585,1.0,1.0,1.0,0.955,0.936,0.837,0.647],[1.0,1.0,1.0,0.955,0.933,0.833,0.581,1.0,1.0,1.0,0.953,0.934,0.833,0.644],[0.95,0.951,0.952,1.0,0.984,0.934,0.754,0.95,0.955,0.953,1.0,0.986,0.931,0.797],[0.93,0.931,0.933,0.986,1.0,0.95,0.782,0.93,0.936,0.934,0.986,1.0,0.952,0.819],[0.828,0.829,0.832,0.931,0.951,1.0,0.92,0.828,0.837,0.833,0.931,0.952,1.0,0.943],[0.637,0.638,0.642,0.795,0.819,0.946,0.995,0.638,0.647,0.644,0.797,0.819,0.943,1.0]],""K"":2,""R"":0.991,""featValue"":[12.538,1.336,0.084,0.031,0.014,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.271,-0.239,-0.195,-0.02,0.047,-0.006,0.143,0.203,0.128,0.063,0.396,0.15,0.384,-0.648],[-0.271,-0.237,-0.193,-0.016,0.047,-0.012,0.114,0.124,0.06,0.053,0.151,-0.85,-0.03,0.222],[-0.272,-0.233,-0.187,-0.027,0.042,0.024,-0.019,-0.034,0.074,-0.14,-0.476,0.177,0.64,0.375],[-0.28,-0.018,0.298,0.518,-0.175,-0.163,-0.102,0.423,-0.266,-0.494,0.002,0.007,-0.051,-0.012],[-0.279,0.034,0.477,-0.291,0.377,-0.126,-0.014,0.359,-0.228,0.48,-0.199,0.027,0.0,-0.006],[-0.268,0.262,-0.019,-0.253,-0.537,0.02,0.635,-0.077,-0.298,0.016,-0.086,0.029,-0.016,-0.006],[-0.219,0.543,-0.221,0.175,0.286,0.683,-0.016,0.169,-0.007,-0.02,-0.011,-0.009,0.001,0.004],[-0.271,-0.238,-0.194,-0.022,0.045,0.007,0.095,0.146,0.088,0.095,0.42,0.467,-0.357,0.51],[-0.272,-0.227,-0.166,-0.05,0.034,0.135,-0.387,-0.446,-0.669,0.026,0.055,0.005,-0.095,-0.126],[-0.272,-0.231,-0.184,-0.024,0.035,0.022,0.045,0.008,0.303,-0.096,-0.563,0.05,-0.548,-0.336],[-0.28,-0.014,0.301,0.543,-0.247,0.092,-0.022,-0.37,0.279,0.498,0.005,-0.005,0.054,0.012],[-0.279,0.035,0.47,-0.248,0.309,0.071,0.142,-0.433,0.236,-0.48,0.205,-0.025,0.002,0.008],[-0.268,0.26,0.013,-0.409,-0.462,-0.034,-0.609,0.131,0.285,-0.022,0.088,-0.034,0.019,0.01],[-0.232,0.486,-0.337,0.156,0.276,-0.675,-0.007,-0.195,0.017,0.025,0.014,0.011,-0.002,-0.006]],""selectVec"":[[-0.271,-0.239],[-0.271,-0.237],[-0.272,-0.233],[-0.28,-0.018],[-0.279,0.034],[-0.268,0.262],[-0.219,0.543],[-0.271,-0.238],[-0.272,-0.227],[-0.272,-0.231],[-0.28,-0.014],[-0.279,0.035],[-0.268,0.26],[-0.232,0.486]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3770,""AfterCleanSamNum"":3680,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""循环水泵A电流"",""alarmcondition"":""[d1_10pac10ap001xq01]>10""},""copy"":false,""principal"":""2"",""precision"":""99.1%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":429,""version"":""v-2025-10-27 16:02:55"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>10))
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