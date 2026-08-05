using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA134")]
    [FCDisplay("PCA134")]
    public partial class PCA134 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("循泵出口们开度大于20")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机定子U相温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机定子V相温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机定子W相温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机驱动端轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机非驱动端轴承温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B驱动端轴承温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B非驱动端轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机定子U相温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机定子V相温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机定子W相温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机驱动端轴承温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B电机非驱动端轴承温度2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B驱动端轴承温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1机组循环水泵B非驱动端轴承温度2")]
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

		public PCA134()
		{
			ModelID = 143;
			SysID = 20;
			FcType = enumType.Warn;
			FcName = "PCA134";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""143"",""name"":""PCA134"",""description"":""循环水泵B电机温度"",""founder"":""admin"",""creatTime"":""2023-10-27 10:14:37"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:09:19"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-26 15:13:12"",""et"":""2025-12-04 16:34:14"",""duration"":696062,""number"":2321,""filter"":90,""mode"":2231,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-06 16:09:20"",""et"":""2025-11-12 03:04:48"",""duration"":471328,""number"":1572,""filter"":91,""mode"":1481,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pac20ct101r"",""Description"":""#1机组循环水泵B电机定子U相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""83.44"",""TMin"":""71.68"",""TAvg"":""76.38"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_10pac20ct103r"",""Description"":""#1机组循环水泵B电机定子V相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""83.53"",""TMin"":""71.81"",""TAvg"":""76.48"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.13""},{""PointId"":""d1_10pac20ct105r"",""Description"":""#1机组循环水泵B电机定子W相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.14"",""lowerBound"":""-0.14"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""78.03"",""TMin"":""66.21"",""TAvg"":""71.01"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.14""},{""PointId"":""d1_10pac20ct107r"",""Description"":""#1机组循环水泵B电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.48"",""lowerBound"":""-2.48"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""57.84"",""TMin"":""40.07"",""TAvg"":""46.75"",""DMax"":""18.91"",""DMin"":""0.00"",""DAvg"":""0.33"",""C95"":""1.96"",""C99"":""2.48""},{""PointId"":""d1_10pac20ct109r"",""Description"":""#1机组循环水泵B电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""46.16"",""TMin"":""32.54"",""TAvg"":""36.48"",""DMax"":""1.67"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10pac20ct111r"",""Description"":""#1机组循环水泵B驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""36.82"",""TMin"":""28.35"",""TAvg"":""32.35"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_10pac20ct113r"",""Description"":""#1机组循环水泵B非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.12"",""lowerBound"":""-0.12"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""43.86"",""TMin"":""38.12"",""TAvg"":""40.65"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.10"",""C99"":""0.12""},{""PointId"":""d1_10pac20ct102r"",""Description"":""#1机组循环水泵B电机定子U相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.11"",""lowerBound"":""-0.11"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""78.26"",""TMin"":""66.51"",""TAvg"":""71.29"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""d1_10pac20ct104r"",""Description"":""#1机组循环水泵B电机定子V相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.07"",""lowerBound"":""-0.07"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""83.88"",""TMin"":""72.13"",""TAvg"":""76.85"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.06"",""C99"":""0.07""},{""PointId"":""d1_10pac20ct106r"",""Description"":""#1机组循环水泵B电机定子W相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.05"",""lowerBound"":""-0.05"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""83.94"",""TMin"":""72.21"",""TAvg"":""76.93"",""DMax"":""0.27"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.04"",""C99"":""0.05""},{""PointId"":""d1_10pac20ct108r"",""Description"":""#1机组循环水泵B电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.24"",""lowerBound"":""-2.24"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""58.21"",""TMin"":""0.00"",""TAvg"":""47.01"",""DMax"":""17.10"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.77"",""C99"":""2.24""},{""PointId"":""d1_10pac20ct110r"",""Description"":""#1机组循环水泵B电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""45.23"",""TMin"":""31.47"",""TAvg"":""35.50"",""DMax"":""1.87"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.21"",""C99"":""0.27""},{""PointId"":""d1_10pac20ct112r"",""Description"":""#1机组循环水泵B驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""35.97"",""TMin"":""27.38"",""TAvg"":""31.49"",""DMax"":""0.20"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.06"",""C99"":""0.08""},{""PointId"":""d1_10pac20ct114r"",""Description"":""#1机组循环水泵B非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.14"",""lowerBound"":""-0.14"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""43.49"",""TMin"":""37.87"",""TAvg"":""40.41"",""DMax"":""0.30"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.14""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:09:19"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[71.684,71.809,66.214,40.068,32.539,28.353,38.119,66.513,72.132,72.205,0.0,31.469,27.377,37.87],""Train_X_max"":[83.435,83.527,78.032,57.835,46.156,36.815,43.862,78.26,83.875,83.94,58.21,45.233,35.971,43.494],""Train_X_std"":[2.54,2.541,2.526,4.545,2.738,1.792,1.217,2.511,2.533,2.529,4.928,2.749,1.822,1.2],""Train_X_mean"":[76.383,76.482,71.01,46.745,36.48,32.349,40.646,71.285,76.853,76.926,47.007,35.499,31.492,40.413],""Train_X_bais_max"":[[0.347,0.248,0.193,18.908,1.667,0.153,0.207,0.206,0.24,0.265,17.098,1.865,0.196,0.296]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.023,0.03,0.033,0.331,0.038,0.023,0.027,0.024,0.014,0.009,0.299,0.039,0.018,0.031]],""QCUL_95"":0.225581974,""QCUL_99"":0.39908272,""QCUL_95_line"":[0.084,0.106,0.117,1.962,0.193,0.08,0.097,0.088,0.055,0.041,1.774,0.211,0.062,0.112],""QCUL_99_line"":[0.103,0.131,0.144,2.477,0.243,0.098,0.12,0.108,0.067,0.051,2.24,0.265,0.076,0.138],""T2CUL_95"":11.097,""T2CUL_99"":15.13,""T2CUL_95_line"":[0.137,0.137,0.137,0.246,0.148,0.097,0.066,0.136,0.137,0.137,0.266,0.149,0.098,0.065],""T2CUL_99_line"":[0.16,0.16,0.159,0.287,0.173,0.113,0.077,0.158,0.16,0.16,0.311,0.173,0.115,0.076],""Kesi_95"":1.621,""Kesi_99"":1.418,""Kesi_95_line"":[0.052,0.052,0.052,0.094,0.057,0.037,0.025,0.052,0.052,0.052,0.102,0.057,0.038,0.025],""Kesi_99_line"":[0.049,0.049,0.049,0.088,0.053,0.035,0.024,0.048,0.049,0.049,0.095,0.053,0.035,0.023],""COV"":[[1.0,1.0,0.999,0.48,0.843,0.685,0.572,1.0,1.0,1.0,0.445,0.85,0.691,0.595],[1.0,1.0,0.999,0.477,0.843,0.682,0.57,0.999,1.0,1.0,0.442,0.849,0.688,0.593],[0.999,0.999,1.0,0.466,0.835,0.699,0.577,1.0,1.0,1.0,0.432,0.842,0.706,0.601],[0.48,0.477,0.466,1.0,0.753,0.154,0.144,0.466,0.473,0.471,0.935,0.747,0.15,0.155],[0.843,0.843,0.835,0.753,1.0,0.527,0.476,0.835,0.84,0.838,0.7,1.0,0.524,0.489],[0.685,0.682,0.699,0.154,0.527,1.0,0.894,0.699,0.686,0.686,0.141,0.534,0.999,0.913],[0.572,0.57,0.577,0.144,0.476,0.894,1.0,0.577,0.571,0.569,0.145,0.472,0.872,0.997],[1.0,0.999,1.0,0.466,0.835,0.699,0.577,1.0,1.0,1.0,0.431,0.842,0.707,0.601],[1.0,1.0,1.0,0.473,0.84,0.686,0.571,1.0,1.0,1.0,0.439,0.847,0.693,0.595],[1.0,1.0,1.0,0.471,0.838,0.686,0.569,1.0,1.0,1.0,0.436,0.845,0.693,0.593],[0.445,0.442,0.432,0.935,0.7,0.141,0.145,0.431,0.439,0.436,1.0,0.694,0.136,0.153],[0.85,0.849,0.842,0.747,1.0,0.534,0.472,0.842,0.847,0.845,0.694,1.0,0.533,0.487],[0.691,0.688,0.706,0.15,0.524,0.999,0.872,0.707,0.693,0.693,0.136,0.533,1.0,0.894],[0.595,0.593,0.601,0.155,0.489,0.913,0.997,0.601,0.595,0.593,0.153,0.487,0.894,1.0]],""K"":5,""R"":0.996,""featValue"":[10.073,2.411,1.071,0.214,0.174,0.059,0.002,0.001,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.305,-0.039,0.233,0.074,0.112,0.025,-0.035,-0.329,-0.079,0.001,-0.131,0.657,-0.427,-0.292],[-0.304,-0.039,0.237,0.064,0.122,0.017,-0.155,-0.366,-0.386,0.188,-0.497,-0.461,0.135,0.1],[-0.305,-0.026,0.237,0.102,0.07,0.014,0.073,0.523,0.337,0.04,-0.201,-0.271,-0.053,-0.569],[-0.174,-0.446,-0.403,0.193,-0.014,0.755,-0.017,0.011,-0.006,0.002,0.005,-0.005,0.001,0.003],[-0.28,-0.228,-0.099,-0.54,-0.241,-0.111,-0.051,-0.271,0.358,-0.511,-0.132,-0.12,-0.004,0.015],[-0.25,0.347,-0.182,0.228,-0.435,-0.016,-0.257,-0.238,0.457,0.45,0.062,-0.019,0.001,0.066],[-0.224,0.364,-0.35,-0.213,0.437,0.021,-0.608,0.236,-0.117,-0.122,0.027,0.051,-0.027,0.004],[-0.305,-0.026,0.237,0.102,0.067,0.015,0.096,0.359,0.207,-0.055,-0.257,0.317,0.168,0.675],[-0.304,-0.035,0.238,0.076,0.107,0.017,-0.035,-0.168,-0.03,-0.096,0.497,0.125,0.702,-0.193],[-0.304,-0.035,0.242,0.081,0.1,0.013,0.034,-0.009,-0.033,-0.075,0.583,-0.362,-0.524,0.28],[-0.164,-0.437,-0.437,0.408,0.166,-0.63,0.003,-0.005,0.0,-0.001,-0.001,0.0,0.0,0.0],[-0.282,-0.225,-0.085,-0.515,-0.284,-0.123,0.081,0.28,-0.355,0.508,0.131,0.122,0.005,-0.016],[-0.25,0.343,-0.155,0.277,-0.509,-0.019,0.162,0.166,-0.449,-0.444,-0.053,0.009,-0.006,-0.069],[-0.231,0.362,-0.334,-0.15,0.369,0.046,0.697,-0.183,0.085,0.11,-0.029,-0.047,0.029,-0.003]],""selectVec"":[[-0.305,-0.039,0.233,0.074,0.112],[-0.304,-0.039,0.237,0.064,0.122],[-0.305,-0.026,0.237,0.102,0.07],[-0.174,-0.446,-0.403,0.193,-0.014],[-0.28,-0.228,-0.099,-0.54,-0.241],[-0.25,0.347,-0.182,0.228,-0.435],[-0.224,0.364,-0.35,-0.213,0.437],[-0.305,-0.026,0.237,0.102,0.067],[-0.304,-0.035,0.238,0.076,0.107],[-0.304,-0.035,0.242,0.081,0.1],[-0.164,-0.437,-0.437,0.408,0.166],[-0.282,-0.225,-0.085,-0.515,-0.284],[-0.25,0.343,-0.155,0.277,-0.509],[-0.231,0.362,-0.334,-0.15,0.369]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3892,""AfterCleanSamNum"":3801,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""循泵出口们开度大于20"",""alarmcondition"":""[d1_10pac20aa001xq11]>20""},""copy"":false,""principal"":""5"",""precision"":""99.6%"",""rate"":""0.99"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":143,""version"":""v-2025-12-04 17:09:19"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "]],\"Target_Data\":[[]]}";
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