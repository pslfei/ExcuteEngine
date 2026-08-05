using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA135")]
    [FCDisplay("PCA135")]
    public partial class PCA135 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("循环水泵C运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C非驱动端轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机定子U相温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机定子V相温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机定子W相温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机驱动端轴承温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机非驱动端轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机定子U相温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机定子V相温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机定子W相温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机驱动端轴承温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C电机非驱动端轴承温度2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C驱动端轴承温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵C非驱动端轴承温度2")]
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

		public PCA135()
		{
			ModelID = 144;
			SysID = 20;
			FcType = enumType.Warn;
			FcName = "PCA135";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""144"",""name"":""PCA135"",""description"":""循环水泵C电机温度"",""founder"":""admin"",""creatTime"":""2023-10-27 11:42:15"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:12:49"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-09-12 18:42:06"",""et"":""2025-10-26 04:48:20"",""duration"":3751574,""number"":12506,""filter"":7770,""mode"":4736,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":6245}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pac30ct111r"",""Description"":""#1机组循环水泵C驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""43.72"",""TMin"":""22.69"",""TAvg"":""33.08"",""DMax"":""1.65"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.31""},{""PointId"":""d1_10pac30ct113r"",""Description"":""#1机组循环水泵C非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.18"",""lowerBound"":""-0.18"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""58.02"",""TMin"":""24.99"",""TAvg"":""47.47"",""DMax"":""0.63"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.18""},{""PointId"":""d1_10pac30ct101r"",""Description"":""#1机组循环水泵C电机定子U相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""106.88"",""TMin"":""53.34"",""TAvg"":""89.70"",""DMax"":""2.41"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10pac30ct103r"",""Description"":""#1机组循环水泵C电机定子V相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.30"",""lowerBound"":""-0.30"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""104.82"",""TMin"":""52.87"",""TAvg"":""87.79"",""DMax"":""1.64"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.24"",""C99"":""0.30""},{""PointId"":""d1_10pac30ct105r"",""Description"":""#1机组循环水泵C电机定子W相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""103.31"",""TMin"":""52.90"",""TAvg"":""86.57"",""DMax"":""1.39"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10pac30ct107r"",""Description"":""#1机组循环水泵C电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.40"",""lowerBound"":""-0.40"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""58.68"",""TMin"":""30.31"",""TAvg"":""47.91"",""DMax"":""2.35"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.33"",""C99"":""0.40""},{""PointId"":""d1_10pac30ct109r"",""Description"":""#1机组循环水泵C电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.25"",""lowerBound"":""-1.25"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""52.69"",""TMin"":""32.68"",""TAvg"":""41.93"",""DMax"":""7.46"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""1.01"",""C99"":""1.25""},{""PointId"":""d1_10pac30ct102r"",""Description"":""#1机组循环水泵C电机定子U相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""106.40"",""TMin"":""53.71"",""TAvg"":""89.27"",""DMax"":""1.88"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10pac30ct104r"",""Description"":""#1机组循环水泵C电机定子V相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""105.25"",""TMin"":""52.86"",""TAvg"":""88.31"",""DMax"":""2.24"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10pac30ct106r"",""Description"":""#1机组循环水泵C电机定子W相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.21"",""lowerBound"":""-0.21"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""100.51"",""TMin"":""51.99"",""TAvg"":""83.91"",""DMax"":""0.51"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.17"",""C99"":""0.21""},{""PointId"":""d1_10pac30ct108r"",""Description"":""#1机组循环水泵C电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.43"",""lowerBound"":""-0.43"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""58.11"",""TMin"":""29.97"",""TAvg"":""47.36"",""DMax"":""2.72"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.35"",""C99"":""0.43""},{""PointId"":""d1_10pac30ct110r"",""Description"":""#1机组循环水泵C电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.18"",""lowerBound"":""-1.18"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""52.25"",""TMin"":""32.38"",""TAvg"":""41.50"",""DMax"":""7.37"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""0.96"",""C99"":""1.18""},{""PointId"":""d1_10pac30ct112r"",""Description"":""#1机组循环水泵C驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""43.92"",""TMin"":""23.11"",""TAvg"":""33.35"",""DMax"":""1.13"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10pac30ct114r"",""Description"":""#1机组循环水泵C非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.41"",""lowerBound"":""-0.41"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""58.10"",""TMin"":""24.96"",""TAvg"":""47.13"",""DMax"":""1.56"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.33"",""C99"":""0.41""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:12:49"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[22.685,24.987,53.341,52.874,52.899,30.305,32.677,53.706,52.855,51.994,29.968,32.381,23.106,24.955],""Train_X_max"":[43.722,58.022,106.881,104.824,103.312,58.675,52.687,106.395,105.247,100.508,58.114,52.25,43.919,58.098],""Train_X_std"":[4.28,4.44,6.52,6.426,6.288,3.991,3.937,6.483,6.405,6.239,3.997,3.96,4.209,4.549],""Train_X_mean"":[33.081,47.472,89.696,87.794,86.566,47.908,41.934,89.274,88.306,83.907,47.357,41.5,33.353,47.126],""Train_X_bais_max"":[[1.645,0.63,2.405,1.644,1.392,2.346,7.462,1.878,2.244,0.509,2.716,7.374,1.134,1.558]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.071,0.039,0.084,0.062,0.05,0.086,0.27,0.071,0.069,0.048,0.092,0.252,0.043,0.095]],""QCUL_95"":0.08179554,""QCUL_99"":0.144399658,""QCUL_95_line"":[0.255,0.145,0.306,0.243,0.192,0.325,1.012,0.262,0.261,0.171,0.347,0.958,0.158,0.331],""QCUL_99_line"":[0.314,0.178,0.376,0.3,0.237,0.401,1.247,0.322,0.321,0.21,0.428,1.182,0.195,0.406],""T2CUL_95"":9.503,""T2CUL_99"":13.304,""T2CUL_95_line"":[0.192,0.199,0.292,0.288,0.282,0.179,0.176,0.29,0.287,0.279,0.179,0.177,0.189,0.204],""T2CUL_99_line"":[0.227,0.235,0.346,0.341,0.333,0.212,0.209,0.344,0.339,0.331,0.212,0.21,0.223,0.241],""Kesi_95"":1.615,""Kesi_99"":1.419,""Kesi_95_line"":[0.079,0.082,0.12,0.119,0.116,0.074,0.073,0.12,0.118,0.115,0.074,0.073,0.078,0.084],""Kesi_99_line"":[0.074,0.077,0.113,0.111,0.109,0.069,0.068,0.112,0.111,0.108,0.069,0.069,0.073,0.079],""COV"":[[1.0,0.926,0.826,0.83,0.833,0.904,0.922,0.827,0.829,0.834,0.906,0.924,0.999,0.944],[0.926,1.0,0.832,0.837,0.838,0.882,0.915,0.833,0.835,0.839,0.877,0.914,0.936,0.998],[0.826,0.832,1.0,1.0,1.0,0.957,0.965,1.0,1.0,1.0,0.955,0.965,0.824,0.841],[0.83,0.837,1.0,1.0,1.0,0.959,0.967,1.0,1.0,1.0,0.957,0.967,0.828,0.845],[0.833,0.838,1.0,1.0,1.0,0.96,0.968,1.0,1.0,1.0,0.958,0.968,0.831,0.846],[0.904,0.882,0.957,0.959,0.96,1.0,0.981,0.957,0.958,0.96,1.0,0.983,0.9,0.897],[0.922,0.915,0.965,0.967,0.968,0.981,1.0,0.965,0.966,0.969,0.98,1.0,0.922,0.924],[0.827,0.833,1.0,1.0,1.0,0.957,0.965,1.0,1.0,1.0,0.955,0.965,0.825,0.842],[0.829,0.835,1.0,1.0,1.0,0.958,0.966,1.0,1.0,1.0,0.956,0.966,0.827,0.844],[0.834,0.839,1.0,1.0,1.0,0.96,0.969,1.0,1.0,1.0,0.958,0.969,0.832,0.847],[0.906,0.877,0.955,0.957,0.958,1.0,0.98,0.955,0.956,0.958,1.0,0.981,0.901,0.893],[0.924,0.914,0.965,0.967,0.968,0.983,1.0,0.965,0.966,0.969,0.981,1.0,0.924,0.923],[0.999,0.936,0.824,0.828,0.831,0.9,0.922,0.825,0.827,0.832,0.901,0.924,1.0,0.952],[0.944,0.998,0.841,0.845,0.846,0.897,0.924,0.842,0.844,0.847,0.893,0.923,0.952,1.0]],""K"":4,""R"":0.998,""featValue"":[13.056,0.718,0.139,0.067,0.022,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.256,0.403,0.396,0.353,0.142,-0.209,0.191,-0.488,0.274,0.27,0.021,-0.029,0.044,-0.009],[0.255,0.383,-0.576,-0.147,0.017,0.548,-0.067,-0.354,0.06,-0.012,-0.026,-0.003,-0.01,0.001],[0.27,-0.255,-0.083,0.143,0.107,-0.182,-0.437,-0.255,-0.25,-0.076,0.153,-0.117,0.228,0.614],[0.27,-0.245,-0.078,0.131,0.094,0.057,-0.002,0.196,0.403,0.143,-0.297,0.099,-0.636,0.329],[0.271,-0.241,-0.067,0.143,0.061,0.173,0.433,0.226,0.334,-0.241,0.023,-0.464,0.43,0.034],[0.272,-0.027,0.275,-0.543,0.206,0.138,-0.183,0.178,-0.069,0.565,-0.126,-0.249,0.156,-0.051],[0.275,0.014,0.058,-0.084,-0.656,-0.004,-0.163,0.155,0.322,0.126,0.515,0.209,0.066,0.007],[0.27,-0.253,-0.081,0.142,0.096,-0.125,-0.317,-0.143,-0.039,-0.113,0.206,-0.356,-0.319,-0.637],[0.27,-0.248,-0.079,0.136,0.102,-0.041,-0.162,-0.004,0.094,-0.004,-0.381,0.605,0.424,-0.321],[0.271,-0.238,-0.067,0.15,0.043,0.15,0.523,-0.003,-0.542,0.293,0.303,0.238,-0.129,-0.02],[0.272,-0.025,0.32,-0.53,0.221,-0.028,0.164,-0.175,0.046,-0.57,0.148,0.246,-0.152,0.048],[0.275,0.014,0.085,-0.081,-0.62,-0.137,0.14,-0.161,-0.306,-0.129,-0.551,-0.209,-0.07,-0.002],[0.256,0.418,0.311,0.355,0.074,0.312,-0.244,0.478,-0.273,-0.26,-0.021,0.026,-0.043,0.008],[0.257,0.385,-0.437,-0.135,0.154,-0.644,0.121,0.345,-0.053,0.009,0.034,0.003,0.011,-0.002]],""selectVec"":[[0.256,0.403,0.396,0.353],[0.255,0.383,-0.576,-0.147],[0.27,-0.255,-0.083,0.143],[0.27,-0.245,-0.078,0.131],[0.271,-0.241,-0.067,0.143],[0.272,-0.027,0.275,-0.543],[0.275,0.014,0.058,-0.084],[0.27,-0.253,-0.081,0.142],[0.27,-0.248,-0.079,0.136],[0.271,-0.238,-0.067,0.15],[0.272,-0.025,0.32,-0.53],[0.275,0.014,0.085,-0.081],[0.256,0.418,0.311,0.355],[0.257,0.385,-0.437,-0.135]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":12506,""AfterCleanSamNum"":4736,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""循环水泵C运行"",""alarmcondition"":""[d1_10pac30aa001xq11]>20""},""copy"":false,""principal"":""4"",""precision"":""99.8%"",""rate"":""0.998"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":144,""version"":""v-2025-12-04 17:12:49"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "]],\"Target_Data\":[[]]}";
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