using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA155")]
    [FCDisplay("PCA155")]
    public partial class PCA155 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C减速机推力轴承油温1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C减速机推力轴承油温2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C减速机推力轴承油温3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C液压油站油箱油温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C减速机推力轴承油温4")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C润滑油站油箱油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C润滑油站供油管路油温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机绕组温度（A相）1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机绕组温度（B相）1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机绕组温度（C相）1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机绕组温度（A相）2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机绕组温度（B相）2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机绕组温度（C相）2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机前轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机后轴承温度1")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机前轴承温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C主电机后轴承温度2")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出17")]
	    public LA OUT_R17 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出17")]
	    public LA OUT_B17 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出17")]
	    public LD OUT_F17 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出17")]
	    public LD OUT_W17 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[17] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[17] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[17] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA155()
		{
			ModelID = 167;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA155";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""167"",""name"":""PCA155"",""description"":""磨煤机C本体温度"",""founder"":""admin"",""creatTime"":""2023-11-08 09:46:45"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:26:42"",""algorithm"":""PCA"",""sampling"":""100"",""monitor"":null,""trainTime"":[{""st"":""2025-11-17 20:41:58"",""et"":""2025-11-26 05:32:58"",""duration"":723060,""number"":7231,""filter"":297,""mode"":6934,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc31ct101r"",""Description"":""磨煤机C减速机推力轴承油温1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.43"",""lowerBound"":""-0.43"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""44.88"",""TMin"":""37.80"",""TAvg"":""40.02"",""DMax"":""0.40"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.43""},{""PointId"":""d1_10hfc31ct102r"",""Description"":""磨煤机C减速机推力轴承油温2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.42"",""lowerBound"":""-0.42"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""45.02"",""TMin"":""38.22"",""TAvg"":""40.39"",""DMax"":""0.31"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.35"",""C99"":""0.42""},{""PointId"":""d1_10hfc31ct103r"",""Description"":""磨煤机C减速机推力轴承油温3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.48"",""lowerBound"":""-0.48"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""45.00"",""TMin"":""38.00"",""TAvg"":""40.26"",""DMax"":""0.37"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.40"",""C99"":""0.48""},{""PointId"":""d1_10hfc32ct101r"",""Description"":""磨煤机C液压油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.48"",""lowerBound"":""-0.48"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""41.40"",""TMin"":""32.82"",""TAvg"":""35.20"",""DMax"":""0.81"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.39"",""C99"":""0.48""},{""PointId"":""d1_10hfc31ct104r"",""Description"":""磨煤机C减速机推力轴承油温4"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""44.27"",""TMin"":""37.24"",""TAvg"":""39.46"",""DMax"":""0.36"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfc31ct105r"",""Description"":""磨煤机C润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.30"",""lowerBound"":""-0.30"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""41.12"",""TMin"":""34.01"",""TAvg"":""36.08"",""DMax"":""0.38"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.30""},{""PointId"":""d1_10hfc31ct106r"",""Description"":""磨煤机C润滑油站供油管路油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.13"",""lowerBound"":""-1.13"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""36.28"",""TMin"":""27.77"",""TAvg"":""30.46"",""DMax"":""0.97"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""0.92"",""C99"":""1.13""},{""PointId"":""d1_10hfc30ct101r"",""Description"":""磨煤机C主电机绕组温度（A相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""64.96"",""TMin"":""54.25"",""TAvg"":""57.62"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.26""},{""PointId"":""d1_10hfc30ct103r"",""Description"":""磨煤机C主电机绕组温度（B相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""67.59"",""TMin"":""56.67"",""TAvg"":""60.12"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.22"",""C99"":""0.27""},{""PointId"":""d1_10hfc30ct105r"",""Description"":""磨煤机C主电机绕组温度（C相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.29"",""lowerBound"":""-0.29"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""66.87"",""TMin"":""55.74"",""TAvg"":""59.29"",""DMax"":""0.31"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.29""},{""PointId"":""d1_10hfc30ct102r"",""Description"":""磨煤机C主电机绕组温度（A相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.25"",""lowerBound"":""-0.25"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""65.45"",""TMin"":""54.41"",""TAvg"":""57.91"",""DMax"":""0.22"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.25""},{""PointId"":""d1_10hfc30ct104r"",""Description"":""磨煤机C主电机绕组温度（B相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.29"",""lowerBound"":""-0.29"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""66.46"",""TMin"":""55.13"",""TAvg"":""58.78"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.24"",""C99"":""0.29""},{""PointId"":""d1_10hfc30ct106r"",""Description"":""磨煤机C主电机绕组温度（C相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.28"",""lowerBound"":""-0.28"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""67.09"",""TMin"":""55.76"",""TAvg"":""59.41"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.28""},{""PointId"":""d1_10hfc30ct107r"",""Description"":""磨煤机C主电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""43.34"",""TMin"":""36.02"",""TAvg"":""38.10"",""DMax"":""0.92"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.38"",""C99"":""0.47""},{""PointId"":""d1_10hfc30ct109r"",""Description"":""磨煤机C主电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""51.62"",""TMin"":""44.54"",""TAvg"":""46.60"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10hfc30ct108r"",""Description"":""磨煤机C主电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""43.19"",""TMin"":""35.87"",""TAvg"":""37.95"",""DMax"":""0.92"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.39"",""C99"":""0.47""},{""PointId"":""d1_10hfc30ct110r"",""Description"":""磨煤机C主电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""51.54"",""TMin"":""44.46"",""TAvg"":""46.51"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.26"",""C99"":""0.32""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:26:42"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[37.795,38.22,37.998,32.818,37.239,34.006,27.767,54.245,56.672,55.742,54.411,55.134,55.762,36.016,44.543,35.868,44.456],""Train_X_max"":[44.876,45.018,44.995,41.395,44.265,41.124,36.277,64.963,67.59,66.867,65.448,66.459,67.092,43.336,51.619,43.189,51.538],""Train_X_std"":[1.012,0.969,1.018,1.111,0.992,0.956,1.166,1.85,1.942,1.956,1.938,2.006,2.026,0.977,1.011,0.977,1.012],""Train_X_mean"":[40.02,40.385,40.263,35.201,39.461,36.082,30.459,57.616,60.123,59.287,57.905,58.776,59.41,38.1,46.595,37.95,46.507],""Train_X_bais_max"":[[0.396,0.309,0.372,0.813,0.361,0.377,0.966,0.235,0.263,0.305,0.223,0.249,0.263,0.917,0.293,0.918,0.292]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.103,0.102,0.114,0.103,0.089,0.069,0.269,0.06,0.063,0.067,0.06,0.07,0.066,0.102,0.078,0.103,0.078]],""QCUL_95"":0.6688552,""QCUL_99"":1.03675413,""QCUL_95_line"":[0.355,0.345,0.395,0.386,0.304,0.247,0.924,0.208,0.217,0.233,0.208,0.237,0.225,0.383,0.263,0.385,0.264],""QCUL_99_line"":[0.434,0.421,0.484,0.476,0.373,0.303,1.131,0.255,0.265,0.286,0.254,0.29,0.275,0.472,0.322,0.474,0.323],""T2CUL_95"":7.836,""T2CUL_99"":11.385,""T2CUL_95_line"":[0.059,0.056,0.059,0.065,0.058,0.056,0.068,0.107,0.113,0.114,0.113,0.117,0.118,0.057,0.059,0.057,0.059],""T2CUL_99_line"":[0.071,0.068,0.071,0.078,0.069,0.067,0.082,0.13,0.136,0.137,0.136,0.14,0.142,0.068,0.071,0.068,0.071],""Kesi_95"":1.597,""Kesi_99"":1.432,""Kesi_95_line"":[0.027,0.025,0.027,0.029,0.026,0.025,0.031,0.049,0.051,0.051,0.051,0.053,0.053,0.026,0.027,0.026,0.027],""Kesi_99_line"":[0.025,0.024,0.025,0.028,0.025,0.024,0.029,0.046,0.048,0.049,0.048,0.05,0.05,0.024,0.025,0.024,0.025],""COV"":[[1.0,0.997,0.999,0.873,0.997,0.937,0.818,0.896,0.882,0.882,0.886,0.879,0.877,0.851,0.899,0.851,0.899],[0.997,1.0,0.998,0.887,0.999,0.953,0.832,0.876,0.861,0.861,0.865,0.857,0.855,0.875,0.91,0.875,0.91],[0.999,0.998,1.0,0.865,0.997,0.935,0.813,0.892,0.879,0.878,0.881,0.875,0.873,0.848,0.9,0.848,0.9],[0.873,0.887,0.865,1.0,0.896,0.971,0.939,0.673,0.648,0.65,0.659,0.646,0.638,0.967,0.845,0.967,0.844],[0.997,0.999,0.997,0.896,1.0,0.958,0.837,0.871,0.856,0.855,0.859,0.851,0.849,0.882,0.919,0.882,0.918],[0.937,0.953,0.935,0.971,0.958,1.0,0.919,0.734,0.71,0.711,0.718,0.706,0.7,0.97,0.921,0.97,0.921],[0.818,0.832,0.813,0.939,0.837,0.919,1.0,0.588,0.562,0.563,0.571,0.56,0.554,0.915,0.832,0.915,0.832],[0.896,0.876,0.892,0.673,0.871,0.734,0.588,1.0,1.0,0.999,1.0,0.999,0.999,0.612,0.703,0.611,0.703],[0.882,0.861,0.879,0.648,0.856,0.71,0.562,1.0,1.0,1.0,1.0,1.0,1.0,0.585,0.684,0.584,0.684],[0.882,0.861,0.878,0.65,0.855,0.711,0.563,0.999,1.0,1.0,1.0,1.0,1.0,0.587,0.681,0.586,0.681],[0.886,0.865,0.881,0.659,0.859,0.718,0.571,1.0,1.0,1.0,1.0,1.0,1.0,0.594,0.684,0.593,0.684],[0.879,0.857,0.875,0.646,0.851,0.706,0.56,0.999,1.0,1.0,1.0,1.0,1.0,0.581,0.676,0.58,0.676],[0.877,0.855,0.873,0.638,0.849,0.7,0.554,0.999,1.0,1.0,1.0,1.0,1.0,0.573,0.675,0.573,0.675],[0.851,0.875,0.848,0.967,0.882,0.97,0.915,0.612,0.585,0.587,0.594,0.581,0.573,1.0,0.876,1.0,0.875],[0.899,0.91,0.9,0.845,0.919,0.921,0.832,0.703,0.684,0.681,0.684,0.676,0.675,0.876,1.0,0.875,1.0],[0.851,0.875,0.848,0.967,0.882,0.97,0.915,0.611,0.584,0.586,0.593,0.58,0.573,1.0,0.875,1.0,0.875],[0.899,0.91,0.9,0.844,0.918,0.921,0.832,0.703,0.684,0.681,0.684,0.676,0.675,0.875,1.0,0.875,1.0]],""K"":3,""R"":0.986,""featValue"":[14.299,2.142,0.323,0.117,0.09,0.025,0.007,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.262,-0.002,0.081,-0.079,-0.395,0.01,0.263,-0.413,0.557,-0.055,-0.45,0.085,-0.017,0.0,-0.008,0.018,-0.001],[0.262,0.03,0.077,-0.143,-0.375,-0.069,-0.099,0.771,0.335,0.116,0.137,-0.093,0.024,-0.01,-0.003,-0.007,-0.004],[0.261,-0.001,0.107,-0.096,-0.441,-0.084,0.183,0.074,-0.755,-0.018,-0.315,0.018,-0.03,-0.005,0.009,-0.004,0.015],[0.237,0.249,-0.387,0.017,0.133,0.759,0.339,0.143,-0.036,0.02,-0.015,-0.001,0.004,-0.011,-0.031,-0.001,0.002],[0.262,0.04,0.089,-0.139,-0.32,0.066,0.066,-0.381,-0.053,-0.055,0.799,-0.025,0.01,-0.003,0.011,-0.007,-0.012],[0.25,0.21,-0.078,-0.137,-0.069,0.24,-0.858,-0.181,-0.048,-0.008,-0.174,0.01,0.053,0.031,-0.012,0.0,0.001],[0.221,0.298,-0.293,0.819,-0.139,-0.285,-0.043,-0.019,0.01,0.009,0.051,0.006,0.0,0.004,0.016,0.0,-0.001],[0.241,-0.282,-0.062,0.032,0.123,-0.019,-0.08,0.061,0.009,-0.242,0.035,0.309,-0.52,-0.606,-0.197,-0.001,-0.003],[0.237,-0.303,-0.051,0.032,0.121,-0.031,-0.006,0.087,-0.011,-0.097,0.055,0.716,0.367,0.397,-0.088,-0.003,0.007],[0.237,-0.302,-0.065,0.021,0.118,-0.011,-0.01,-0.109,-0.019,0.796,-0.005,0.037,-0.036,-0.144,0.406,0.008,-0.01],[0.238,-0.297,-0.079,0.032,0.118,0.001,-0.03,0.021,0.017,-0.255,-0.009,-0.288,-0.518,0.579,0.284,0.009,0.003],[0.236,-0.306,-0.07,0.043,0.123,-0.018,0.001,0.012,0.001,-0.412,-0.042,-0.345,0.55,-0.329,0.356,-0.003,-0.014],[0.235,-0.311,-0.051,0.05,0.113,-0.045,0.005,-0.076,-0.018,0.209,-0.026,-0.413,0.136,0.096,-0.761,-0.011,0.017],[0.231,0.31,-0.202,-0.321,0.263,-0.355,0.1,-0.027,0.01,-0.002,-0.017,-0.001,-0.008,0.005,0.009,-0.707,-0.02],[0.239,0.186,0.556,0.141,0.264,0.076,0.038,0.022,0.009,0.003,-0.007,-0.009,-0.002,-0.008,0.023,-0.019,0.707],[0.23,0.31,-0.203,-0.323,0.264,-0.356,0.096,-0.012,-0.005,-0.006,0.002,-0.004,0.005,0.0,-0.009,0.706,0.02],[0.239,0.186,0.558,0.143,0.264,0.076,0.042,0.027,-0.01,0.004,-0.027,-0.007,-0.006,0.012,-0.008,0.021,-0.706]],""selectVec"":[[0.262,-0.002,0.081],[0.262,0.03,0.077],[0.261,-0.001,0.107],[0.237,0.249,-0.387],[0.262,0.04,0.089],[0.25,0.21,-0.078],[0.221,0.298,-0.293],[0.241,-0.282,-0.062],[0.237,-0.303,-0.051],[0.237,-0.302,-0.065],[0.238,-0.297,-0.079],[0.236,-0.306,-0.07],[0.235,-0.311,-0.051],[0.231,0.31,-0.202],[0.239,0.186,0.556],[0.23,0.31,-0.203],[0.239,0.186,0.558]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":2411,""AfterCleanSamNum"":2321,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机C运行"",""alarmcondition"":""[d1_10hfe30aj001xq01]>10""},""copy"":false,""principal"":""3"",""precision"":""98.6%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":167,""version"":""v-2025-12-09 10:26:42"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R17[0] = reconData[0][16];
	        OUT_B17[0] = errorData[0][16];
	        OUT_F17[0] = paraState[0][16];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[17] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17};
			float[] arrOUT_B = new float[17] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17};
			LD[] arrOUT_W = new LD[17] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17 };
			
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