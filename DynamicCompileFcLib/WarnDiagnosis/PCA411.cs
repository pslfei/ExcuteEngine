using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA411")]
    [FCDisplay("PCA411")]
    public partial class PCA411 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵转速大于2000")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵齿轮箱润滑油回油温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵驱动端润滑油回油温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵驱动端径向轴承温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端径向轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端推力轴承内侧温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端推力轴承外侧温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端润滑油回油温度2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端润滑油回油温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵驱动端机封冲洗出口温度")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端机封冲洗出口温度")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵驱动端径向轴承温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端径向轴承温度2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端推力轴承内侧温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽泵前置泵非驱动端推力轴承外侧温度2")]
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

		public PCA411()
		{
			ModelID = 452;
			SysID = 45;
			FcType = enumType.Warn;
			FcName = "PCA411";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""452"",""name"":""PCA411"",""description"":""汽泵前置泵温度"",""founder"":""admin"",""creatTime"":""2025-12-04 17:21:22"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:23:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 16:28:12"",""et"":""2025-11-25 22:51:16"",""duration"":1146184,""number"":3821,""filter"":90,""mode"":3731,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lac10ct101r"",""Description"":""汽泵前置泵齿轮箱润滑油回油温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""52.71"",""TMin"":""47.02"",""TAvg"":""49.25"",""DMax"":""0.60"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.42"",""C99"":""0.52""},{""PointId"":""d1_10lac10ct102r"",""Description"":""汽泵前置泵驱动端润滑油回油温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""47.86"",""TMin"":""40.30"",""TAvg"":""44.05"",""DMax"":""1.63"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.57"",""C99"":""1.93""},{""PointId"":""d1_10lac10ct107r"",""Description"":""汽泵前置泵驱动端径向轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""56.21"",""TMin"":""45.11"",""TAvg"":""50.27"",""DMax"":""4.08"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.13"",""C99"":""1.40""},{""PointId"":""d1_10lac10ct109r"",""Description"":""汽泵前置泵非驱动端径向轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""56.74"",""TMin"":""48.48"",""TAvg"":""51.97"",""DMax"":""2.10"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.69"",""C99"":""0.85""},{""PointId"":""d1_10lac10ct111r"",""Description"":""汽泵前置泵非驱动端推力轴承内侧温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""49.69"",""TMin"":""46.23"",""TAvg"":""47.32"",""DMax"":""0.92"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10lac10ct113r"",""Description"":""汽泵前置泵非驱动端推力轴承外侧温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""49.71"",""TMin"":""46.12"",""TAvg"":""47.27"",""DMax"":""0.84"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.36""},{""PointId"":""d1_10lac10ct104r"",""Description"":""汽泵前置泵非驱动端润滑油回油温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""48.65"",""TMin"":""44.80"",""TAvg"":""46.25"",""DMax"":""0.68"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.28"",""C99"":""0.34""},{""PointId"":""d1_10lac10ct103r"",""Description"":""汽泵前置泵非驱动端润滑油回油温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""46.91"",""TMin"":""39.59"",""TAvg"":""43.34"",""DMax"":""1.70"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""1.03"",""C99"":""1.28""},{""PointId"":""d1_10lac10ct105r"",""Description"":""汽泵前置泵驱动端机封冲洗出口温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""41.27"",""TMin"":""31.12"",""TAvg"":""33.84"",""DMax"":""0.33"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.23"",""C99"":""0.28""},{""PointId"":""d1_10lac10ct106r"",""Description"":""汽泵前置泵非驱动端机封冲洗出口温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""40.66"",""TMin"":""30.77"",""TAvg"":""33.37"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.18""},{""PointId"":""d1_10lac10ct108r"",""Description"":""汽泵前置泵驱动端径向轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""54.53"",""TMin"":""44.51"",""TAvg"":""49.02"",""DMax"":""3.59"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.10"",""C99"":""1.36""},{""PointId"":""d1_10lac10ct110r"",""Description"":""汽泵前置泵非驱动端径向轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""54.88"",""TMin"":""47.83"",""TAvg"":""50.68"",""DMax"":""1.52"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.56"",""C99"":""0.68""},{""PointId"":""d1_10lac10ct112r"",""Description"":""汽泵前置泵非驱动端推力轴承内侧温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""49.45"",""TMin"":""45.99"",""TAvg"":""47.09"",""DMax"":""0.91"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10lac10ct114r"",""Description"":""汽泵前置泵非驱动端推力轴承外侧温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""49.82"",""TMin"":""46.26"",""TAvg"":""47.41"",""DMax"":""0.85"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.31"",""C99"":""0.38""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:23:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[47.019,40.298,45.111,48.481,46.227,46.117,44.799,39.592,31.121,30.766,44.511,47.826,45.991,46.264],""Train_X_max"":[52.712,47.861,56.207,56.742,49.687,49.705,48.645,46.905,41.274,40.664,54.526,54.884,49.446,49.817],""Train_X_std"":[1.625,1.77,3.374,2.391,0.752,0.793,0.76,1.491,1.339,1.264,2.96,1.954,0.753,0.791],""Train_X_mean"":[49.253,44.051,50.265,51.969,47.323,47.271,46.251,43.338,33.843,33.369,49.024,50.683,47.085,47.405],""Train_X_bais_max"":[[0.6,1.625,4.079,2.098,0.916,0.843,0.682,1.703,0.328,0.185,3.587,1.515,0.913,0.847]],""Train_X_bais_min"":[[0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.12,0.46,0.292,0.191,0.086,0.08,0.077,0.272,0.061,0.041,0.289,0.152,0.084,0.083]],""QCUL_95"":1.00464916,""QCUL_99"":1.63760674,""QCUL_95_line"":[0.422,1.574,1.132,0.692,0.317,0.296,0.28,1.034,0.226,0.144,1.099,0.555,0.312,0.306],""QCUL_99_line"":[0.518,1.926,1.397,0.851,0.39,0.364,0.344,1.275,0.278,0.177,1.356,0.683,0.384,0.376],""T2CUL_95"":5.999,""T2CUL_99"":9.227,""T2CUL_95_line"":[0.065,0.071,0.135,0.096,0.03,0.032,0.03,0.06,0.054,0.051,0.119,0.078,0.03,0.032],""T2CUL_99_line"":[0.081,0.088,0.168,0.119,0.037,0.039,0.038,0.074,0.067,0.063,0.147,0.097,0.037,0.039],""Kesi_95"":1.573,""Kesi_99"":1.378,""Kesi_95_line"":[0.033,0.036,0.069,0.049,0.015,0.016,0.016,0.031,0.027,0.026,0.061,0.04,0.015,0.016],""Kesi_99_line"":[0.031,0.034,0.065,0.046,0.014,0.015,0.015,0.029,0.026,0.024,0.057,0.038,0.014,0.015],""COV"":[[1.0,0.927,0.994,0.998,0.982,0.984,0.976,0.946,0.708,0.665,0.991,0.998,0.982,0.984],[0.927,1.0,0.956,0.937,0.899,0.906,0.935,0.944,0.704,0.677,0.957,0.938,0.9,0.903],[0.994,0.956,1.0,0.996,0.963,0.968,0.969,0.957,0.716,0.677,0.999,0.997,0.964,0.967],[0.998,0.937,0.996,1.0,0.975,0.978,0.972,0.948,0.716,0.675,0.993,1.0,0.976,0.978],[0.982,0.899,0.963,0.975,1.0,1.0,0.986,0.924,0.702,0.664,0.958,0.974,1.0,1.0],[0.984,0.906,0.968,0.978,1.0,1.0,0.989,0.931,0.706,0.668,0.963,0.977,1.0,1.0],[0.976,0.935,0.969,0.972,0.986,0.989,1.0,0.968,0.729,0.699,0.969,0.973,0.987,0.987],[0.946,0.944,0.957,0.948,0.924,0.931,0.968,1.0,0.743,0.721,0.962,0.951,0.925,0.928],[0.708,0.704,0.716,0.716,0.702,0.706,0.729,0.743,1.0,0.995,0.727,0.723,0.702,0.703],[0.665,0.677,0.677,0.675,0.664,0.668,0.699,0.721,0.995,1.0,0.689,0.682,0.664,0.665],[0.991,0.957,0.999,0.993,0.958,0.963,0.969,0.962,0.727,0.689,1.0,0.994,0.959,0.962],[0.998,0.938,0.997,1.0,0.974,0.977,0.973,0.951,0.723,0.682,0.994,1.0,0.974,0.977],[0.982,0.9,0.964,0.976,1.0,1.0,0.987,0.925,0.702,0.664,0.959,0.974,1.0,1.0],[0.984,0.903,0.967,0.978,1.0,1.0,0.987,0.928,0.703,0.665,0.962,0.977,1.0,1.0]],""K"":2,""R"":0.975,""featValue"":[12.731,0.922,0.203,0.085,0.052,0.005,0.003,0.002,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.277,0.116,-0.029,-0.286,0.135,-0.183,0.327,-0.094,-0.758,-0.284,0.054,-0.024,0.005,0.024],[0.265,0.041,0.604,0.232,-0.684,0.121,0.046,0.029,-0.15,0.015,-0.015,-0.002,0.0,-0.033],[0.277,0.093,0.198,-0.298,0.035,-0.175,-0.253,0.168,0.314,-0.376,0.216,-0.006,-0.046,0.611],[0.277,0.1,0.044,-0.332,0.082,0.511,-0.088,-0.146,0.243,-0.383,0.035,-0.046,0.067,-0.539],[0.275,0.116,-0.332,0.117,-0.122,0.046,-0.124,0.188,-0.059,0.174,0.304,-0.048,0.768,0.027],[0.276,0.112,-0.293,0.118,-0.107,-0.021,-0.084,0.1,0.03,-0.084,-0.625,-0.607,-0.086,0.09],[0.277,0.067,-0.076,0.429,0.06,-0.284,0.425,-0.534,0.358,-0.185,0.114,0.031,0.044,0.002],[0.271,-0.002,0.354,0.486,0.653,0.211,-0.095,0.257,-0.126,0.051,-0.026,-0.003,-0.017,0.017],[0.219,-0.647,-0.08,-0.126,-0.04,0.069,0.528,0.44,0.179,0.006,0.004,0.003,-0.017,-0.008],[0.21,-0.69,-0.048,0.042,-0.014,-0.071,-0.508,-0.42,-0.185,-0.023,0.001,-0.003,0.015,0.013],[0.277,0.073,0.232,-0.265,0.108,-0.634,-0.125,0.12,0.156,0.337,-0.137,0.047,0.044,-0.435],[0.278,0.089,0.057,-0.325,0.098,0.341,0.166,-0.358,0.053,0.633,-0.09,0.005,-0.044,0.334],[0.275,0.116,-0.327,0.123,-0.122,0.016,-0.126,0.136,-0.05,0.192,0.536,-0.127,-0.613,-0.148],[0.276,0.116,-0.307,0.092,-0.111,0.061,-0.105,0.115,-0.021,-0.074,-0.372,0.779,-0.12,0.045]],""selectVec"":[[0.277,0.116],[0.265,0.041],[0.277,0.093],[0.277,0.1],[0.275,0.116],[0.276,0.112],[0.277,0.067],[0.271,-0.002],[0.219,-0.647],[0.21,-0.69],[0.277,0.073],[0.278,0.089],[0.275,0.116],[0.276,0.116]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3821,""AfterCleanSamNum"":3731,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""汽泵转速大于2000"",""alarmcondition"":""[d1_mehspeed]>2000""},""copy"":false,""principal"":""2"",""precision"":""97.5%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":452,""version"":""v-2025-12-04 17:23:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>2000))
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