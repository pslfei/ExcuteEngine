using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA152")]
    [FCDisplay("PCA152")]
    public partial class PCA152 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机绕组温度（A相）1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机绕组温度（B相）1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机绕组温度（C相）1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机绕组温度（A相）2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机绕组温度（B相）2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机绕组温度（C相）2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机前轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机后轴承温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机前轴承温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A主电机后轴承温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A减速机推力轴承油温1")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A减速机推力轴承油温2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A减速机推力轴承油温3")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A液压油站油箱油温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A减速机推力轴承油温4")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A润滑油站油箱油温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A润滑油站供油管路油温")]
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

		public PCA152()
		{
			ModelID = 164;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA152";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""164"",""name"":""PCA152"",""description"":""磨煤机A本体温度"",""founder"":""admin"",""creatTime"":""2023-11-01 10:40:22"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:14:16"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-25 22:06:38"",""duration"":1135472,""number"":3785,""filter"":2401,""mode"":1384,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2311},{""st"":""2025-11-27 18:44:38"",""et"":""2025-12-06 10:17:20"",""duration"":747162,""number"":2491,""filter"":1679,""mode"":812,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":1589},{""st"":""2025-10-29 03:07:44"",""et"":""2025-11-05 04:02:24"",""duration"":608080,""number"":2027,""filter"":1133,""mode"":894,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":0,""conditionnumber"":1043}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc10ct101r"",""Description"":""磨煤机A主电机绕组温度（A相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.52"",""lowerBound"":""-1.52"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""59.53"",""TMin"":""30.77"",""TAvg"":""53.44"",""DMax"":""0.78"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.56"",""C99"":""0.69""},{""PointId"":""d1_10hfc10ct103r"",""Description"":""磨煤机A主电机绕组温度（B相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.51"",""lowerBound"":""-1.51"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""60.86"",""TMin"":""31.46"",""TAvg"":""54.88"",""DMax"":""1.74"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.62"",""C99"":""0.76""},{""PointId"":""d1_10hfc10ct105r"",""Description"":""磨煤机A主电机绕组温度（C相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.63"",""lowerBound"":""-1.63"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""60.01"",""TMin"":""31.03"",""TAvg"":""54.01"",""DMax"":""1.00"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.52"",""C99"":""0.64""},{""PointId"":""d1_10hfc10ct102r"",""Description"":""磨煤机A主电机绕组温度（A相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.58"",""lowerBound"":""-1.58"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""61.07"",""TMin"":""30.94"",""TAvg"":""54.76"",""DMax"":""0.82"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.57"",""C99"":""0.70""},{""PointId"":""d1_10hfc10ct104r"",""Description"":""磨煤机A主电机绕组温度（B相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.31"",""lowerBound"":""-1.31"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""58.42"",""TMin"":""31.27"",""TAvg"":""52.51"",""DMax"":""0.65"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.47"",""C99"":""0.58""},{""PointId"":""d1_10hfc10ct106r"",""Description"":""磨煤机A主电机绕组温度（C相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.74"",""lowerBound"":""-1.74"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""61.26"",""TMin"":""31.28"",""TAvg"":""55.05"",""DMax"":""0.85"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.58"",""C99"":""0.71""},{""PointId"":""d1_10hfc10ct107r"",""Description"":""磨煤机A主电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""55.26"",""TMin"":""29.99"",""TAvg"":""38.48"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""d1_10hfc10ct109r"",""Description"":""磨煤机A主电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.58"",""lowerBound"":""-2.58"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""49.34"",""TMin"":""30.12"",""TAvg"":""43.64"",""DMax"":""1.19"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.53"",""C99"":""0.65""},{""PointId"":""d1_10hfc10ct108r"",""Description"":""磨煤机A主电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""55.20"",""TMin"":""29.97"",""TAvg"":""38.43"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_10hfc10ct110r"",""Description"":""磨煤机A主电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.58"",""lowerBound"":""-2.58"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""49.34"",""TMin"":""30.15"",""TAvg"":""43.64"",""DMax"":""1.18"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.53"",""C99"":""0.65""},{""PointId"":""d1_10hfc11ct101r"",""Description"":""磨煤机A减速机推力轴承油温1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.54"",""lowerBound"":""-0.54"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""43.08"",""TMin"":""28.30"",""TAvg"":""39.37"",""DMax"":""0.68"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10hfc11ct102r"",""Description"":""磨煤机A减速机推力轴承油温2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.65"",""lowerBound"":""-0.65"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""42.85"",""TMin"":""28.26"",""TAvg"":""39.14"",""DMax"":""1.33"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10hfc11ct103r"",""Description"":""磨煤机A减速机推力轴承油温3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""44.01"",""TMin"":""28.58"",""TAvg"":""40.33"",""DMax"":""0.79"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hfc12ct101r"",""Description"":""磨煤机A液压油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.66"",""lowerBound"":""-0.66"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""40.90"",""TMin"":""30.39"",""TAvg"":""34.22"",""DMax"":""1.63"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.68"",""C99"":""0.83""},{""PointId"":""d1_10hfc11ct104r"",""Description"":""磨煤机A减速机推力轴承油温4"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.66"",""lowerBound"":""-0.66"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""43.66"",""TMin"":""28.28"",""TAvg"":""39.93"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.29""},{""PointId"":""d1_10hfc11ct105r"",""Description"":""磨煤机A润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.85"",""lowerBound"":""-0.85"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""38.14"",""TMin"":""28.97"",""TAvg"":""35.24"",""DMax"":""1.84"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.69"",""C99"":""0.85""},{""PointId"":""d1_10hfc11ct106r"",""Description"":""磨煤机A润滑油站供油管路油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.55"",""lowerBound"":""-0.55"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""35.15"",""TMin"":""26.63"",""TAvg"":""30.05"",""DMax"":""1.15"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.69"",""C99"":""0.85""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:14:16"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[30.769,31.462,31.026,30.943,31.271,31.275,29.993,30.123,29.97,30.145,28.297,28.264,28.584,30.393,28.28,28.973,26.625],""Train_X_max"":[59.526,60.858,60.006,61.069,58.421,61.259,55.264,49.339,55.199,49.344,43.077,42.852,44.005,40.904,43.655,38.139,35.15],""Train_X_std"":[4.847,4.937,4.825,5.138,4.591,5.058,3.079,3.94,3.071,3.935,2.303,2.319,2.394,1.442,2.405,1.398,1.161],""Train_X_mean"":[53.435,54.881,54.006,54.758,52.512,55.048,38.479,43.637,38.43,43.639,39.373,39.143,40.326,34.219,39.934,35.243,30.053],""Train_X_bais_max"":[[0.775,1.744,0.995,0.822,0.651,0.848,0.141,1.186,0.143,1.184,0.683,1.333,0.786,1.625,0.467,1.84,1.152]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.164,0.174,0.15,0.167,0.138,0.165,0.026,0.15,0.024,0.151,0.074,0.086,0.083,0.191,0.065,0.196,0.201]],""QCUL_95"":0.4266799,""QCUL_99"":0.733444333,""QCUL_95_line"":[0.561,0.617,0.524,0.573,0.473,0.576,0.089,0.526,0.084,0.532,0.261,0.319,0.307,0.677,0.234,0.689,0.692],""QCUL_99_line"":[0.687,0.757,0.643,0.702,0.579,0.706,0.108,0.645,0.102,0.653,0.32,0.393,0.378,0.83,0.287,0.845,0.848],""T2CUL_95"":11.101,""T2CUL_99"":15.138,""T2CUL_95_line"":[0.284,0.289,0.282,0.301,0.269,0.296,0.18,0.231,0.18,0.23,0.135,0.136,0.14,0.084,0.141,0.082,0.068],""T2CUL_99_line"":[0.331,0.337,0.33,0.351,0.314,0.346,0.21,0.269,0.21,0.269,0.157,0.158,0.164,0.099,0.164,0.096,0.079],""Kesi_95"":1.607,""Kesi_99"":1.406,""Kesi_95_line"":[0.108,0.11,0.107,0.114,0.102,0.113,0.069,0.088,0.068,0.088,0.051,0.052,0.053,0.032,0.054,0.031,0.026],""Kesi_99_line"":[0.101,0.103,0.101,0.107,0.096,0.105,0.064,0.082,0.064,0.082,0.048,0.048,0.05,0.03,0.05,0.029,0.024],""COV"":[[1.0,0.999,1.0,1.0,1.0,1.0,0.598,0.892,0.597,0.892,0.926,0.924,0.928,0.167,0.931,0.819,0.197],[0.999,1.0,0.999,1.0,0.999,0.999,0.603,0.905,0.602,0.905,0.917,0.915,0.92,0.147,0.924,0.807,0.179],[1.0,0.999,1.0,1.0,1.0,1.0,0.596,0.888,0.595,0.888,0.925,0.923,0.927,0.174,0.93,0.821,0.201],[1.0,1.0,1.0,1.0,1.0,1.0,0.595,0.897,0.594,0.897,0.922,0.92,0.925,0.149,0.928,0.81,0.18],[1.0,0.999,1.0,1.0,1.0,1.0,0.603,0.894,0.602,0.894,0.929,0.927,0.93,0.179,0.933,0.826,0.208],[1.0,0.999,1.0,1.0,1.0,1.0,0.596,0.889,0.595,0.889,0.924,0.922,0.926,0.162,0.929,0.815,0.19],[0.598,0.603,0.596,0.595,0.603,0.596,1.0,0.617,1.0,0.617,0.541,0.545,0.533,0.234,0.541,0.556,0.213],[0.892,0.905,0.888,0.897,0.894,0.889,0.617,1.0,0.616,1.0,0.79,0.8,0.807,-0.044,0.813,0.666,0.031],[0.597,0.602,0.595,0.594,0.602,0.595,1.0,0.616,1.0,0.616,0.54,0.544,0.532,0.235,0.54,0.556,0.214],[0.892,0.905,0.888,0.897,0.894,0.889,0.617,1.0,0.616,1.0,0.79,0.799,0.807,-0.044,0.813,0.667,0.032],[0.926,0.917,0.925,0.922,0.929,0.924,0.541,0.79,0.54,0.79,1.0,0.999,0.998,0.306,0.998,0.914,0.391],[0.924,0.915,0.923,0.92,0.927,0.922,0.545,0.8,0.544,0.799,0.999,1.0,0.998,0.293,0.998,0.91,0.382],[0.928,0.92,0.927,0.925,0.93,0.926,0.533,0.807,0.532,0.807,0.998,0.998,1.0,0.255,1.0,0.893,0.35],[0.167,0.147,0.174,0.149,0.179,0.162,0.234,-0.044,0.235,-0.044,0.306,0.293,0.255,1.0,0.259,0.607,0.868],[0.931,0.924,0.93,0.928,0.933,0.929,0.541,0.813,0.54,0.813,0.998,0.998,1.0,0.259,1.0,0.898,0.358],[0.819,0.807,0.821,0.81,0.826,0.815,0.556,0.666,0.556,0.667,0.914,0.91,0.893,0.607,0.898,1.0,0.639],[0.197,0.179,0.201,0.18,0.208,0.19,0.213,0.031,0.214,0.032,0.391,0.382,0.35,0.868,0.358,0.639,1.0]],""K"":5,""R"":0.992,""featValue"":[12.921,2.16,1.244,0.296,0.253,0.099,0.029,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.273,-0.077,-0.063,0.166,0.196,-0.128,-0.025,0.102,0.113,0.308,-0.025,0.223,0.389,-0.715,0.029,-0.015,0.028],[-0.272,-0.093,-0.053,0.192,0.16,-0.131,-0.012,-0.341,-0.063,-0.558,-0.012,0.596,-0.173,0.029,0.128,0.017,-0.004],[-0.273,-0.073,-0.066,0.176,0.21,-0.122,-0.014,-0.056,-0.097,-0.18,0.061,-0.588,-0.528,-0.342,-0.189,-0.003,0.017],[-0.272,-0.09,-0.064,0.167,0.186,-0.127,-0.016,0.032,-0.005,0.094,-0.024,0.049,0.249,0.397,-0.775,-0.021,-0.02],[-0.274,-0.069,-0.059,0.17,0.177,-0.104,0.002,0.314,0.103,0.521,-0.063,0.191,-0.466,0.329,0.313,0.023,-0.02],[-0.272,-0.08,-0.065,0.167,0.216,-0.128,-0.034,-0.029,-0.101,-0.156,0.043,-0.429,0.508,0.314,0.496,-0.002,-0.001],[-0.187,0.026,0.66,-0.15,0.073,-0.033,-0.001,-0.003,0.0,0.004,0.002,-0.01,0.016,-0.006,-0.02,0.706,0.04],[-0.249,-0.216,0.062,0.246,-0.543,0.147,0.093,0.009,0.012,-0.003,0.016,-0.037,0.019,-0.037,0.005,0.039,-0.705],[-0.186,0.027,0.66,-0.15,0.074,-0.031,0.0,-0.004,0.0,-0.001,0.001,0.007,-0.018,0.007,0.016,-0.705,-0.041],[-0.249,-0.216,0.063,0.246,-0.543,0.149,0.092,0.014,0.018,0.002,0.019,-0.021,0.009,0.022,-0.001,-0.041,0.705],[-0.268,0.075,-0.15,-0.336,0.004,0.08,0.121,0.269,0.655,-0.263,0.443,-0.008,0.005,0.025,-0.014,0.0,-0.004],[-0.268,0.067,-0.144,-0.35,-0.038,0.107,0.148,0.575,-0.558,-0.224,-0.199,0.095,0.023,-0.062,-0.019,0.0,0.003],[-0.267,0.042,-0.158,-0.365,-0.033,0.068,0.2,-0.496,-0.349,0.365,0.469,0.037,-0.016,0.017,0.018,0.0,0.0],[-0.072,0.626,0.05,0.401,0.174,0.504,0.393,-0.034,0.009,-0.001,-0.023,0.0,0.022,0.001,-0.007,0.001,0.0],[-0.268,0.044,-0.149,-0.347,-0.05,0.041,0.145,-0.343,0.299,0.063,-0.73,-0.119,-0.007,0.016,0.018,0.0,0.002],[-0.247,0.284,-0.066,-0.036,-0.079,0.338,-0.854,-0.045,-0.024,0.028,0.006,0.009,-0.013,0.005,-0.004,0.0,-0.002],[-0.086,0.617,-0.028,0.059,-0.37,-0.686,-0.009,0.017,-0.014,0.0,0.019,-0.007,0.002,0.003,0.0,-0.001,0.001]],""selectVec"":[[-0.273,-0.077,-0.063,0.166,0.196],[-0.272,-0.093,-0.053,0.192,0.16],[-0.273,-0.073,-0.066,0.176,0.21],[-0.272,-0.09,-0.064,0.167,0.186],[-0.274,-0.069,-0.059,0.17,0.177],[-0.272,-0.08,-0.065,0.167,0.216],[-0.187,0.026,0.66,-0.15,0.073],[-0.249,-0.216,0.062,0.246,-0.543],[-0.186,0.027,0.66,-0.15,0.074],[-0.249,-0.216,0.063,0.246,-0.543],[-0.268,0.075,-0.15,-0.336,0.004],[-0.268,0.067,-0.144,-0.35,-0.038],[-0.267,0.042,-0.158,-0.365,-0.033],[-0.072,0.626,0.05,0.401,0.174],[-0.268,0.044,-0.149,-0.347,-0.05],[-0.247,0.284,-0.066,-0.036,-0.079],[-0.086,0.617,-0.028,0.059,-0.37]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8302,""AfterCleanSamNum"":3241,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机A运行"",""alarmcondition"":""[d1_10hfe10aj001xq01]>10""},""copy"":false,""principal"":""5"",""precision"":""99.2%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":164,""version"":""v-2025-12-09 10:14:16"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "]],\"Target_Data\":[[]]}";
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