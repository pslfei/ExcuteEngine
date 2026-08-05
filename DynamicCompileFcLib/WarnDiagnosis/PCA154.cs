using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA154")]
    [FCDisplay("PCA154")]
    public partial class PCA154 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B减速机推力轴承油温1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B减速机推力轴承油温2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B减速机推力轴承油温3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B液压油站油箱油温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B减速机推力轴承油温4")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B润滑油站油箱油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B润滑油站供油管路油温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机绕组温度（A相）1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机绕组温度（B相）1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机绕组温度（C相）1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机绕组温度（B相）2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机绕组温度（C相）2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机前轴承温度1")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机后轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机前轴承温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B主电机后轴承温度2")]
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

		public PCA154()
		{
			ModelID = 166;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA154";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""166"",""name"":""PCA154"",""description"":""磨煤机B本体温度"",""founder"":""admin"",""creatTime"":""2023-11-07 14:09:50"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:21:12"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 16:28:12"",""et"":""2025-11-26 02:34:26"",""duration"":1159574,""number"":3866,""filter"":1857,""mode"":2009,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1766},{""st"":""2025-11-27 18:00:00"",""et"":""2025-12-07 21:15:06"",""duration"":875706,""number"":2920,""filter"":1410,""mode"":1510,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":1320}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc21ct101r"",""Description"":""磨煤机B减速机推力轴承油温1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""46.17"",""TMin"":""30.55"",""TAvg"":""42.18"",""DMax"":""0.72"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.39"",""C99"":""0.47""},{""PointId"":""d1_10hfc21ct102r"",""Description"":""磨煤机B减速机推力轴承油温2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.48"",""lowerBound"":""-0.48"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""46.49"",""TMin"":""30.11"",""TAvg"":""42.18"",""DMax"":""2.18"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.39"",""C99"":""0.48""},{""PointId"":""d1_10hfc21ct103r"",""Description"":""磨煤机B减速机推力轴承油温3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""45.18"",""TMin"":""29.75"",""TAvg"":""41.44"",""DMax"":""1.06"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hfc22ct101r"",""Description"":""磨煤机B液压油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""45.72"",""TMin"":""32.88"",""TAvg"":""38.57"",""DMax"":""0.58"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hfc21ct104r"",""Description"":""磨煤机B减速机推力轴承油温4"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""44.57"",""TMin"":""30.10"",""TAvg"":""40.76"",""DMax"":""0.82"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.29"",""C99"":""0.35""},{""PointId"":""d1_10hfc21ct105r"",""Description"":""磨煤机B润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.92"",""lowerBound"":""-0.92"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""39.92"",""TMin"":""31.23"",""TAvg"":""36.85"",""DMax"":""2.68"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.75"",""C99"":""0.92""},{""PointId"":""d1_10hfc21ct106r"",""Description"":""磨煤机B润滑油站供油管路油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.06"",""lowerBound"":""-1.06"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""34.47"",""TMin"":""26.39"",""TAvg"":""30.40"",""DMax"":""1.43"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.86"",""C99"":""1.06""},{""PointId"":""d1_10hfc20ct101r"",""Description"":""磨煤机B主电机绕组温度（A相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""63.49"",""TMin"":""33.12"",""TAvg"":""58.37"",""DMax"":""0.86"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.56"",""C99"":""0.69""},{""PointId"":""d1_10hfc20ct103r"",""Description"":""磨煤机B主电机绕组温度（B相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.66"",""lowerBound"":""-0.66"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""63.72"",""TMin"":""33.06"",""TAvg"":""58.61"",""DMax"":""0.82"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.54"",""C99"":""0.66""},{""PointId"":""d1_10hfc20ct105r"",""Description"":""磨煤机B主电机绕组温度（C相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.57"",""lowerBound"":""-0.57"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""63.69"",""TMin"":""32.72"",""TAvg"":""58.49"",""DMax"":""0.87"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.47"",""C99"":""0.57""},{""PointId"":""d1_10hfc20ct104r"",""Description"":""磨煤机B主电机绕组温度（B相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.56"",""lowerBound"":""-0.56"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""65.71"",""TMin"":""33.15"",""TAvg"":""60.36"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.56""},{""PointId"":""d1_10hfc20ct106r"",""Description"":""磨煤机B主电机绕组温度（C相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.53"",""lowerBound"":""-0.53"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""65.21"",""TMin"":""32.78"",""TAvg"":""59.89"",""DMax"":""1.29"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.43"",""C99"":""0.53""},{""PointId"":""d1_10hfc20ct107r"",""Description"":""磨煤机B主电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.46"",""lowerBound"":""-0.46"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""45.57"",""TMin"":""32.01"",""TAvg"":""38.08"",""DMax"":""0.96"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.38"",""C99"":""0.46""},{""PointId"":""d1_10hfc20ct109r"",""Description"":""磨煤机B主电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.24"",""lowerBound"":""-2.24"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""52.48"",""TMin"":""31.96"",""TAvg"":""47.54"",""DMax"":""2.91"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.83"",""C99"":""2.24""},{""PointId"":""d1_10hfc20ct108r"",""Description"":""磨煤机B主电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""45.40"",""TMin"":""31.78"",""TAvg"":""37.90"",""DMax"":""0.94"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.38"",""C99"":""0.47""},{""PointId"":""d1_10hfc20ct110r"",""Description"":""磨煤机B主电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.24"",""lowerBound"":""-2.24"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""52.48"",""TMin"":""31.93"",""TAvg"":""47.55"",""DMax"":""2.88"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.83"",""C99"":""2.24""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:21:12"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[30.551,30.114,29.747,32.88,30.102,31.232,26.392,33.12,33.059,32.716,33.145,32.775,32.007,31.962,31.781,31.928],""Train_X_max"":[46.17,46.485,45.175,45.72,44.568,39.921,34.466,63.49,63.717,63.694,65.713,65.205,45.573,52.483,45.403,52.483],""Train_X_std"":[2.106,2.078,2.007,1.492,1.965,1.395,1.373,4.324,4.32,4.41,4.677,4.609,1.969,3.644,1.978,3.647],""Train_X_mean"":[42.179,42.184,41.435,38.566,40.755,36.85,30.399,58.368,58.613,58.488,60.364,59.888,38.077,47.54,37.897,47.547],""Train_X_bais_max"":[[0.72,2.178,1.059,0.583,0.816,2.682,1.433,0.86,0.821,0.865,0.571,1.29,0.962,2.906,0.944,2.876]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.108,0.102,0.083,0.048,0.08,0.205,0.242,0.16,0.153,0.132,0.127,0.119,0.105,0.514,0.105,0.514]],""QCUL_95"":0.62759614,""QCUL_99"":1.06668043,""QCUL_95_line"":[0.386,0.385,0.308,0.175,0.288,0.748,0.861,0.559,0.541,0.468,0.458,0.428,0.378,1.826,0.378,1.826],""QCUL_99_line"":[0.474,0.475,0.38,0.215,0.353,0.92,1.056,0.685,0.663,0.574,0.563,0.526,0.464,2.24,0.465,2.24],""T2CUL_95"":11.098,""T2CUL_99"":15.133,""T2CUL_95_line"":[0.117,0.116,0.112,0.083,0.109,0.078,0.076,0.24,0.24,0.245,0.26,0.256,0.109,0.203,0.11,0.203],""T2CUL_99_line"":[0.137,0.135,0.13,0.097,0.128,0.091,0.089,0.281,0.28,0.286,0.304,0.299,0.128,0.237,0.128,0.237],""Kesi_95"":1.609,""Kesi_99"":1.413,""Kesi_95_line"":[0.045,0.044,0.042,0.032,0.042,0.03,0.029,0.092,0.091,0.093,0.099,0.098,0.042,0.077,0.042,0.077],""Kesi_99_line"":[0.042,0.041,0.04,0.03,0.039,0.028,0.027,0.086,0.086,0.087,0.093,0.091,0.039,0.072,0.039,0.072],""COV"":[[1.0,0.999,0.999,0.291,0.998,0.951,0.478,0.851,0.847,0.841,0.837,0.839,0.636,0.715,0.638,0.716],[0.999,1.0,0.999,0.291,0.998,0.951,0.49,0.85,0.846,0.839,0.835,0.837,0.642,0.707,0.644,0.708],[0.999,0.999,1.0,0.303,0.999,0.955,0.485,0.855,0.851,0.845,0.841,0.843,0.644,0.718,0.646,0.718],[0.291,0.291,0.303,1.0,0.313,0.369,0.397,0.268,0.271,0.27,0.259,0.256,0.113,0.11,0.111,0.11],[0.998,0.998,0.999,0.313,1.0,0.96,0.503,0.844,0.839,0.833,0.828,0.83,0.651,0.708,0.653,0.708],[0.951,0.951,0.955,0.369,0.96,1.0,0.573,0.806,0.802,0.794,0.788,0.791,0.709,0.673,0.711,0.674],[0.478,0.49,0.485,0.397,0.503,0.573,1.0,0.21,0.207,0.191,0.176,0.183,0.551,-0.035,0.55,-0.034],[0.851,0.85,0.855,0.268,0.844,0.806,0.21,1.0,1.0,1.0,0.999,1.0,0.602,0.898,0.604,0.898],[0.847,0.846,0.851,0.271,0.839,0.802,0.207,1.0,1.0,1.0,0.999,1.0,0.601,0.899,0.603,0.899],[0.841,0.839,0.845,0.27,0.833,0.794,0.191,1.0,1.0,1.0,1.0,1.0,0.592,0.905,0.594,0.905],[0.837,0.835,0.841,0.259,0.828,0.788,0.176,0.999,0.999,1.0,1.0,1.0,0.578,0.91,0.581,0.91],[0.839,0.837,0.843,0.256,0.83,0.791,0.183,1.0,1.0,1.0,1.0,1.0,0.589,0.909,0.591,0.909],[0.636,0.642,0.644,0.113,0.651,0.709,0.551,0.602,0.601,0.592,0.578,0.589,1.0,0.525,1.0,0.525],[0.715,0.707,0.718,0.11,0.708,0.673,-0.035,0.898,0.899,0.905,0.91,0.909,0.525,1.0,0.527,1.0],[0.638,0.644,0.646,0.111,0.653,0.711,0.55,0.604,0.603,0.594,0.581,0.591,1.0,0.527,1.0,0.528],[0.716,0.708,0.718,0.11,0.708,0.674,-0.034,0.898,0.899,0.905,0.91,0.909,0.525,1.0,0.528,1.0]],""K"":5,""R"":0.988,""featValue"":[11.776,1.983,1.118,0.684,0.248,0.144,0.048,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.275,-0.114,-0.09,-0.31,-0.129,-0.104,-0.202,0.822,0.213,0.067,0.05,0.042,-0.093,-0.001,-0.007,-0.001],[-0.275,-0.122,-0.086,-0.308,-0.103,-0.116,-0.218,-0.223,-0.596,0.554,0.118,-0.057,-0.077,-0.014,-0.001,-0.004],[-0.276,-0.118,-0.091,-0.29,-0.129,-0.1,-0.167,-0.136,-0.279,-0.717,-0.373,-0.056,0.093,-0.018,0.003,0.002],[-0.088,-0.235,-0.689,0.599,-0.289,-0.102,-0.09,0.011,-0.015,0.007,0.004,-0.007,-0.004,0.008,-0.002,0.0],[-0.275,-0.135,-0.091,-0.286,-0.158,-0.072,-0.165,-0.489,0.675,0.056,0.213,0.079,0.089,0.031,0.006,0.003],[-0.269,-0.199,-0.063,-0.15,-0.22,0.082,0.897,0.022,-0.033,0.033,0.001,0.001,0.009,0.001,0.001,0.0],[-0.113,-0.61,-0.041,0.02,0.488,0.604,-0.104,0.01,-0.002,-0.006,-0.005,0.0,-0.001,-0.003,-0.001,0.0],[-0.28,0.155,-0.044,0.085,0.273,-0.114,0.046,-0.056,0.216,0.176,-0.457,-0.618,-0.355,0.027,0.015,-0.008],[-0.28,0.158,-0.045,0.095,0.275,-0.113,0.048,-0.077,-0.022,-0.034,-0.121,0.704,-0.503,0.152,-0.023,-0.006],[-0.279,0.17,-0.048,0.1,0.263,-0.098,0.033,0.035,0.029,0.136,-0.166,0.186,0.476,-0.7,-0.036,0.027],[-0.278,0.182,-0.05,0.088,0.263,-0.078,0.049,0.011,-0.117,-0.339,0.739,-0.269,-0.176,-0.154,0.02,0.0],[-0.278,0.176,-0.041,0.091,0.266,-0.086,0.029,0.073,-0.051,0.055,0.024,-0.005,0.576,0.677,0.027,-0.014],[-0.211,-0.266,0.481,0.314,-0.138,-0.184,-0.055,0.011,-0.005,0.003,-0.002,0.022,-0.001,-0.027,0.705,0.002],[-0.251,0.309,0.082,0.107,-0.286,0.481,-0.098,0.002,-0.012,0.011,-0.02,0.006,-0.011,-0.022,0.001,-0.707],[-0.211,-0.265,0.482,0.311,-0.137,-0.183,-0.052,0.001,-0.004,-0.011,0.022,-0.031,0.004,0.026,-0.707,-0.003],[-0.251,0.308,0.082,0.107,-0.285,0.481,-0.098,0.002,-0.017,0.013,-0.019,-0.003,-0.027,0.02,-0.002,0.707]],""selectVec"":[[-0.275,-0.114,-0.09,-0.31,-0.129],[-0.275,-0.122,-0.086,-0.308,-0.103],[-0.276,-0.118,-0.091,-0.29,-0.129],[-0.088,-0.235,-0.689,0.599,-0.289],[-0.275,-0.135,-0.091,-0.286,-0.158],[-0.269,-0.199,-0.063,-0.15,-0.22],[-0.113,-0.61,-0.041,0.02,0.488],[-0.28,0.155,-0.044,0.085,0.273],[-0.28,0.158,-0.045,0.095,0.275],[-0.279,0.17,-0.048,0.1,0.263],[-0.278,0.182,-0.05,0.088,0.263],[-0.278,0.176,-0.041,0.091,0.266],[-0.211,-0.266,0.481,0.314,-0.138],[-0.251,0.309,0.082,0.107,-0.286],[-0.211,-0.265,0.482,0.311,-0.137],[-0.251,0.308,0.082,0.107,-0.285]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6785,""AfterCleanSamNum"":3591,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机B运行"",""alarmcondition"":""[d1_10hfe20aj001xq01]>10""},""copy"":false,""principal"":""5"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":166,""version"":""v-2025-12-09 10:21:12"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "]],\"Target_Data\":[[]]}";
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