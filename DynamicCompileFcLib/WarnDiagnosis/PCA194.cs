using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA194")]
    [FCDisplay("PCA194")]
    public partial class PCA194 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级再热器入口温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级再热器入口温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级再热器入口温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级再热器入口温度2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧热再热蒸汽温度(A-1)")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧热再热蒸汽温度(B-1)")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧热再热蒸汽温度(A-2)")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧热再热蒸汽温度(B-2)")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧热再热蒸汽温度(A-3)")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧热再热蒸汽温度(B-3)")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热再热蒸汽温度3（左侧）")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热再热蒸汽温度3（右侧）")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热再热蒸汽温度1（左侧）")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热再热蒸汽温度1（右侧）")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热再热蒸汽温度2（左侧）")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("热再热蒸汽温度2（右侧）")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出15")]
	    public LA OUT_R15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出15")]
	    public LA OUT_B15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出15")]
	    public LD OUT_F15 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出15")]
	    public LD OUT_W15 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出16")]
	    public LA OUT_R16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出16")]
	    public LA OUT_B16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出16")]
	    public LD OUT_F16 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出16")]
	    public LD OUT_W16 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[16] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[16] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[16] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA194()
		{
			ModelID = 214;
			SysID = 25;
			FcType = enumType.Warn;
			FcName = "PCA194";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""214"",""name"":""PCA194"",""description"":""再热蒸汽压力"",""founder"":""admin"",""creatTime"":""2023-12-07 09:16:04"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 15:42:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 19:26:44"",""et"":""2025-11-26 03:19:04"",""duration"":1151540,""number"":3839,""filter"":1377,""mode"":2462,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1287},{""st"":""2025-11-26 21:54:54"",""et"":""2025-12-07 11:34:52"",""duration"":913198,""number"":3044,""filter"":937,""mode"":2107,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":847}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10haj23ct105k"",""Description"":""A侧末级再热器入口温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""15.03"",""lowerBound"":""-15.03"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""503.10"",""TMin"":""280.30"",""TAvg"":""467.07"",""DMax"":""13.24"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.70"",""C99"":""2.12""},{""PointId"":""d1_10haj23ct107k"",""Description"":""B侧末级再热器入口温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""14.81"",""lowerBound"":""-14.81"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""493.59"",""TMin"":""245.43"",""TAvg"":""456.82"",""DMax"":""7.63"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""0.98"",""C99"":""1.21""},{""PointId"":""d1_10haj23ct106k"",""Description"":""A侧末级再热器入口温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""13.06"",""lowerBound"":""-13.06"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""504.84"",""TMin"":""294.72"",""TAvg"":""468.66"",""DMax"":""12.94"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.58"",""C99"":""1.97""},{""PointId"":""d1_10haj23ct108k"",""Description"":""B侧末级再热器入口温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""13.98"",""lowerBound"":""-13.98"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""494.26"",""TMin"":""248.80"",""TAvg"":""457.83"",""DMax"":""6.77"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.89"",""C99"":""1.11""},{""PointId"":""d1_10lbb80ct101k"",""Description"":""A侧热再热蒸汽温度(A-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.97"",""lowerBound"":""-2.97"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""622.83"",""TMin"":""559.79"",""TAvg"":""602.19"",""DMax"":""4.43"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.83"",""C99"":""2.26""},{""PointId"":""d1_10lbb81ct101k"",""Description"":""B侧热再热蒸汽温度(B-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""5.41"",""lowerBound"":""-5.41"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""624.54"",""TMin"":""545.62"",""TAvg"":""597.09"",""DMax"":""9.57"",""DMin"":""0.00"",""DAvg"":""1.12"",""C95"":""4.18"",""C99"":""5.14""},{""PointId"":""d1_10lbb80ct102k"",""Description"":""A侧热再热蒸汽温度(A-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.11"",""lowerBound"":""-3.11"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""623.47"",""TMin"":""560.38"",""TAvg"":""602.56"",""DMax"":""4.87"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.87"",""C99"":""2.31""},{""PointId"":""d1_10lbb81ct102k"",""Description"":""B侧热再热蒸汽温度(B-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""9.18"",""lowerBound"":""-9.18"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""620.69"",""TMin"":""554.91"",""TAvg"":""596.96"",""DMax"":""12.10"",""DMin"":""0.00"",""DAvg"":""1.81"",""C95"":""6.56"",""C99"":""8.06""},{""PointId"":""d1_10lbb80ct103k"",""Description"":""A侧热再热蒸汽温度(A-3)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.74"",""lowerBound"":""-2.74"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""624.07"",""TMin"":""560.96"",""TAvg"":""603.03"",""DMax"":""4.34"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.75"",""C99"":""2.16""},{""PointId"":""d1_10lbb81ct103k"",""Description"":""B侧热再热蒸汽温度(B-3)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""4.78"",""lowerBound"":""-4.78"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""626.82"",""TMin"":""548.07"",""TAvg"":""599.14"",""DMax"":""8.57"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.60"",""C99"":""4.42""},{""PointId"":""d1_10lbb21ct103k"",""Description"":""热再热蒸汽温度3（左侧）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.36"",""lowerBound"":""-2.36"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""621.20"",""TMin"":""563.38"",""TAvg"":""600.88"",""DMax"":""4.84"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.80"",""C99"":""2.22""},{""PointId"":""d1_10lbb22ct103k"",""Description"":""热再热蒸汽温度3（右侧）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.92"",""lowerBound"":""-2.92"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""621.24"",""TMin"":""548.45"",""TAvg"":""595.59"",""DMax"":""2.64"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.65"",""C99"":""0.80""},{""PointId"":""d1_10lbb21ct101k"",""Description"":""热再热蒸汽温度1（左侧）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.43"",""lowerBound"":""-2.43"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""620.02"",""TMin"":""562.15"",""TAvg"":""599.72"",""DMax"":""4.60"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.85"",""C99"":""2.28""},{""PointId"":""d1_10lbb22ct101k"",""Description"":""热再热蒸汽温度1（右侧）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.95"",""lowerBound"":""-2.95"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""621.46"",""TMin"":""548.49"",""TAvg"":""595.77"",""DMax"":""2.48"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.66"",""C99"":""0.81""},{""PointId"":""d1_10lbb21ct102k"",""Description"":""热再热蒸汽温度2（左侧）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.38"",""lowerBound"":""-2.38"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""618.80"",""TMin"":""560.85"",""TAvg"":""598.57"",""DMax"":""4.52"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.81"",""C99"":""2.23""},{""PointId"":""d1_10lbb22ct102k"",""Description"":""热再热蒸汽温度2（右侧）"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.00"",""lowerBound"":""-3.00"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""622.42"",""TMin"":""549.46"",""TAvg"":""596.91"",""DMax"":""1.34"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.73"",""C99"":""0.90""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 15:42:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[280.298,245.429,294.718,248.802,559.786,545.623,560.382,554.912,560.963,548.072,563.379,548.451,562.147,548.487,560.848,549.459],""Train_X_max"":[503.096,493.585,504.837,494.261,622.829,624.542,623.468,620.694,624.067,626.818,621.203,621.237,620.02,621.464,618.798,622.42],""Train_X_std"":[15.342,13.466,14.354,13.282,10.239,13.664,10.265,12.666,10.203,13.642,9.853,13.16,9.834,13.165,9.782,13.129],""Train_X_mean"":[467.065,456.819,468.664,457.834,602.189,597.093,602.556,596.957,603.029,599.143,600.884,595.589,599.718,595.765,598.565,596.909],""Train_X_bais_max"":[[13.244,7.634,12.938,6.774,4.429,9.572,4.868,12.095,4.34,8.572,4.843,2.639,4.602,2.48,4.521,1.341]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.377,0.245,0.344,0.213,0.481,1.121,0.492,1.808,0.476,0.98,0.482,0.175,0.487,0.177,0.481,0.211]],""QCUL_95"":0.309125125,""QCUL_99"":0.551970065,""QCUL_95_line"":[1.699,0.979,1.579,0.892,1.832,4.176,1.87,6.56,1.754,3.595,1.799,0.652,1.85,0.658,1.807,0.731],""QCUL_99_line"":[2.117,1.211,1.969,1.107,2.26,5.142,2.306,8.063,2.159,4.422,2.215,0.802,2.281,0.81,2.226,0.896],""T2CUL_95"":9.504,""T2CUL_99"":13.304,""T2CUL_95_line"":[0.695,0.61,0.65,0.602,0.464,0.619,0.465,0.574,0.462,0.618,0.446,0.596,0.445,0.596,0.443,0.595],""T2CUL_99_line"":[0.822,0.722,0.769,0.712,0.549,0.732,0.55,0.679,0.547,0.731,0.528,0.705,0.527,0.706,0.524,0.704],""Kesi_95"":1.594,""Kesi_99"":1.375,""Kesi_95_line"":[0.285,0.25,0.266,0.246,0.19,0.253,0.19,0.235,0.189,0.253,0.183,0.244,0.182,0.244,0.181,0.244],""Kesi_99_line"":[0.264,0.232,0.247,0.229,0.176,0.235,0.177,0.218,0.176,0.235,0.17,0.227,0.169,0.227,0.169,0.226],""COV"":[[1.0,0.734,0.995,0.735,0.314,0.277,0.308,0.299,0.323,0.283,0.327,0.292,0.33,0.294,0.33,0.294],[0.734,1.0,0.757,0.999,0.429,0.505,0.425,0.489,0.436,0.51,0.441,0.507,0.444,0.509,0.443,0.508],[0.995,0.757,1.0,0.76,0.352,0.317,0.347,0.339,0.361,0.324,0.366,0.333,0.369,0.335,0.369,0.334],[0.735,0.999,0.76,1.0,0.442,0.527,0.438,0.51,0.449,0.532,0.455,0.529,0.458,0.531,0.457,0.53],[0.314,0.429,0.352,0.442,1.0,0.832,1.0,0.809,0.999,0.831,0.99,0.835,0.989,0.833,0.99,0.833],[0.277,0.505,0.317,0.527,0.832,1.0,0.83,0.952,0.833,0.999,0.847,0.993,0.846,0.993,0.846,0.993],[0.308,0.425,0.347,0.438,1.0,0.83,1.0,0.806,0.999,0.828,0.99,0.832,0.989,0.831,0.989,0.831],[0.299,0.489,0.339,0.51,0.809,0.952,0.806,1.0,0.812,0.958,0.854,0.98,0.854,0.98,0.853,0.98],[0.323,0.436,0.361,0.449,0.999,0.833,0.999,0.812,1.0,0.833,0.99,0.836,0.991,0.835,0.991,0.835],[0.283,0.51,0.324,0.532,0.831,0.999,0.828,0.958,0.833,1.0,0.848,0.995,0.848,0.995,0.847,0.995],[0.327,0.441,0.366,0.455,0.99,0.847,0.99,0.854,0.99,0.848,1.0,0.861,1.0,0.86,1.0,0.86],[0.292,0.507,0.333,0.529,0.835,0.993,0.832,0.98,0.836,0.995,0.861,1.0,0.861,1.0,0.86,1.0],[0.33,0.444,0.369,0.458,0.989,0.846,0.989,0.854,0.991,0.848,1.0,0.861,1.0,0.861,1.0,0.86],[0.294,0.509,0.335,0.531,0.833,0.993,0.831,0.98,0.835,0.995,0.86,1.0,0.861,1.0,0.86,1.0],[0.33,0.443,0.369,0.457,0.99,0.846,0.989,0.853,0.991,0.847,1.0,0.86,1.0,0.86,1.0,0.86],[0.294,0.508,0.334,0.53,0.833,0.993,0.831,0.98,0.835,0.995,0.86,1.0,0.86,1.0,0.86,1.0]],""K"":4,""R"":0.994,""featValue"":[11.949,2.584,0.972,0.405,0.074,0.01,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.129,-0.516,0.183,-0.449,-0.053,-0.012,0.64,-0.028,-0.059,-0.246,0.066,-0.002,-0.003,-0.019,-0.007,0.004],[-0.176,-0.439,-0.16,0.511,0.048,0.0,0.275,0.036,-0.008,0.608,-0.177,0.078,0.011,0.038,0.027,-0.011],[-0.14,-0.507,0.174,-0.414,-0.032,0.009,-0.663,0.038,0.056,0.267,-0.066,0.0,0.002,0.018,0.008,-0.005],[-0.181,-0.433,-0.173,0.485,0.035,-0.005,-0.258,-0.034,0.007,-0.635,0.182,-0.079,-0.011,-0.039,-0.028,0.012],[-0.271,0.103,0.295,0.105,-0.199,-0.342,-0.006,0.313,0.056,-0.188,-0.576,0.171,-0.297,-0.238,0.135,0.013],[-0.273,0.083,-0.274,-0.083,-0.409,0.109,-0.026,0.262,-0.479,-0.042,-0.093,-0.064,-0.052,0.542,-0.217,-0.036],[-0.271,0.106,0.298,0.111,-0.202,-0.352,0.024,0.278,0.013,0.205,0.628,-0.354,-0.008,-0.098,0.022,0.007],[-0.271,0.076,-0.252,-0.174,0.679,-0.488,-0.023,-0.053,-0.343,0.007,-0.042,-0.068,-0.023,0.014,0.005,-0.007],[-0.272,0.097,0.294,0.1,-0.172,-0.301,-0.018,-0.644,0.116,-0.015,-0.055,0.196,0.304,0.329,-0.166,-0.025],[-0.274,0.079,-0.276,-0.089,-0.344,0.134,-0.035,-0.418,-0.333,0.08,0.009,-0.067,0.018,-0.582,0.244,0.042],[-0.276,0.098,0.253,0.055,0.211,0.336,-0.018,0.236,-0.207,-0.003,0.102,0.421,0.324,-0.305,-0.452,0.039],[-0.276,0.079,-0.265,-0.118,-0.011,0.022,0.012,0.227,0.281,-0.05,0.198,0.454,0.29,0.165,0.584,-0.047],[-0.276,0.096,0.253,0.054,0.217,0.372,0.0,-0.2,-0.036,0.034,0.161,0.092,-0.59,0.228,0.204,0.38],[-0.276,0.078,-0.266,-0.119,0.003,0.063,0.037,-0.084,0.421,0.04,0.107,0.073,-0.417,-0.091,-0.361,-0.559],[-0.276,0.096,0.254,0.054,0.21,0.377,0.029,0.01,0.035,-0.055,-0.259,-0.526,0.266,0.082,0.255,-0.412],[-0.276,0.078,-0.266,-0.12,0.002,0.052,0.055,0.067,0.466,-0.004,-0.182,-0.329,0.183,-0.045,-0.252,0.604]],""selectVec"":[[-0.129,-0.516,0.183,-0.449],[-0.176,-0.439,-0.16,0.511],[-0.14,-0.507,0.174,-0.414],[-0.181,-0.433,-0.173,0.485],[-0.271,0.103,0.295,0.105],[-0.273,0.083,-0.274,-0.083],[-0.271,0.106,0.298,0.111],[-0.271,0.076,-0.252,-0.174],[-0.272,0.097,0.294,0.1],[-0.274,0.079,-0.276,-0.089],[-0.276,0.098,0.253,0.055],[-0.276,0.079,-0.265,-0.118],[-0.276,0.096,0.253,0.054],[-0.276,0.078,-0.266,-0.119],[-0.276,0.096,0.254,0.054],[-0.276,0.078,-0.266,-0.12]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6883,""AfterCleanSamNum"":4632,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""4"",""precision"":""99.4%"",""rate"":""0.985"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":214,""version"":""v-2025-12-08 15:42:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R15[0] = reconData[0][14];
	        OUT_B15[0] = errorData[0][14];
	        OUT_F15[0] = paraState[0][14];
	        OUT_R16[0] = reconData[0][15];
	        OUT_B16[0] = errorData[0][15];
	        OUT_F16[0] = paraState[0][15];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[16] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16};
			float[] arrOUT_B = new float[16] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16};
			LD[] arrOUT_W = new LD[16] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16 };
			
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