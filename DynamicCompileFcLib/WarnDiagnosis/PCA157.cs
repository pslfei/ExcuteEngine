using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA157")]
    [FCDisplay("PCA157")]
    public partial class PCA157 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E减速机推力轴承油温1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E减速机推力轴承油温2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E减速机推力轴承油温3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E液压油站油箱油温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E减速机推力轴承油温4")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E润滑油站油箱油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E润滑油站供油管路油温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机绕组温度（A相）1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机绕组温度（B相）1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机绕组温度（C相）1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机绕组温度（A相）2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机绕组温度（B相）2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机绕组温度（C相）2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机前轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机后轴承温度1")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机前轴承温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E主电机后轴承温度2")]
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

		public PCA157()
		{
			ModelID = 169;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA157";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""169"",""name"":""PCA157"",""description"":""磨煤机E本体温度"",""founder"":""admin"",""creatTime"":""2023-11-08 10:04:15"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:44:56"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 14:58:56"",""et"":""2025-11-26 04:48:20"",""duration"":1172964,""number"":3910,""filter"":90,""mode"":3820,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 00:08:48"",""et"":""2025-12-05 20:53:56"",""duration"":765908,""number"":2554,""filter"":90,""mode"":2464,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc51ct101r"",""Description"":""磨煤机E减速机推力轴承油温1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""45.89"",""TMin"":""38.74"",""TAvg"":""41.35"",""DMax"":""0.32"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hfc51ct102r"",""Description"":""磨煤机E减速机推力轴承油温2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""46.57"",""TMin"":""39.56"",""TAvg"":""42.20"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10hfc51ct103r"",""Description"":""磨煤机E减速机推力轴承油温3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.14"",""lowerBound"":""-0.14"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""46.03"",""TMin"":""39.17"",""TAvg"":""41.71"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.14""},{""PointId"":""d1_10hfc52ct101r"",""Description"":""磨煤机E液压油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.86"",""lowerBound"":""-0.86"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""41.34"",""TMin"":""32.27"",""TAvg"":""35.05"",""DMax"":""1.27"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.70"",""C99"":""0.86""},{""PointId"":""d1_10hfc51ct104r"",""Description"":""磨煤机E减速机推力轴承油温4"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""45.86"",""TMin"":""38.49"",""TAvg"":""41.21"",""DMax"":""0.33"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hfc51ct105r"",""Description"":""磨煤机E润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.90"",""lowerBound"":""-0.90"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""40.18"",""TMin"":""31.02"",""TAvg"":""33.52"",""DMax"":""1.10"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.73"",""C99"":""0.90""},{""PointId"":""d1_10hfc51ct106r"",""Description"":""磨煤机E润滑油站供油管路油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.04"",""lowerBound"":""-1.04"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""33.91"",""TMin"":""24.70"",""TAvg"":""28.00"",""DMax"":""1.36"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.85"",""C99"":""1.04""},{""PointId"":""d1_10hfc50ct101r"",""Description"":""磨煤机E主电机绕组温度（A相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""65.22"",""TMin"":""53.59"",""TAvg"":""57.51"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hfc50ct103r"",""Description"":""磨煤机E主电机绕组温度（B相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""64.61"",""TMin"":""53.79"",""TAvg"":""57.54"",""DMax"":""0.13"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_10hfc50ct105r"",""Description"":""磨煤机E主电机绕组温度（C相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""65.81"",""TMin"":""54.24"",""TAvg"":""58.17"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hfc50ct102r"",""Description"":""磨煤机E主电机绕组温度（A相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""66.59"",""TMin"":""55.31"",""TAvg"":""59.14"",""DMax"":""0.12"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.09"",""C99"":""0.10""},{""PointId"":""d1_10hfc50ct104r"",""Description"":""磨煤机E主电机绕组温度（B相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.09"",""lowerBound"":""-0.09"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""65.64"",""TMin"":""54.86"",""TAvg"":""58.59"",""DMax"":""0.09"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.09""},{""PointId"":""d1_10hfc50ct106r"",""Description"":""磨煤机E主电机绕组温度（C相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.74"",""lowerBound"":""-0.74"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""67.07"",""TMin"":""57.78"",""TAvg"":""61.04"",""DMax"":""0.81"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.60"",""C99"":""0.74""},{""PointId"":""d1_10hfc50ct107r"",""Description"":""磨煤机E主电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""42.70"",""TMin"":""34.98"",""TAvg"":""37.27"",""DMax"":""0.89"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.38"",""C99"":""0.47""},{""PointId"":""d1_10hfc50ct109r"",""Description"":""磨煤机E主电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.60"",""lowerBound"":""-0.60"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""50.02"",""TMin"":""43.35"",""TAvg"":""45.23"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10hfc50ct108r"",""Description"":""磨煤机E主电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.46"",""lowerBound"":""-0.46"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""42.65"",""TMin"":""34.96"",""TAvg"":""37.23"",""DMax"":""0.87"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.37"",""C99"":""0.46""},{""PointId"":""d1_10hfc50ct110r"",""Description"":""磨煤机E主电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.60"",""lowerBound"":""-0.60"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""50.09"",""TMin"":""43.42"",""TAvg"":""45.30"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.49"",""C99"":""0.60""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:44:56"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[38.738,39.559,39.17,32.269,38.485,31.016,24.702,53.587,53.791,54.239,55.306,54.86,57.779,34.975,43.35,34.955,43.418],""Train_X_max"":[45.887,46.565,46.033,41.344,45.855,40.179,33.907,65.215,64.605,65.806,66.591,65.642,67.069,42.703,50.024,42.654,50.092],""Train_X_std"":[1.02,1.015,0.98,1.021,1.103,1.057,1.271,2.181,2.013,2.166,2.12,2.017,1.634,0.927,0.908,0.927,0.907],""Train_X_mean"":[41.347,42.198,41.705,35.046,41.207,33.523,28.001,57.511,57.54,58.167,59.144,58.586,61.041,37.268,45.231,37.233,45.298],""Train_X_bais_max"":[[0.317,0.257,0.185,1.27,0.326,1.099,1.359,0.181,0.134,0.19,0.115,0.089,0.808,0.893,0.771,0.871,0.774]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.036,0.04,0.032,0.199,0.052,0.21,0.242,0.047,0.024,0.048,0.025,0.022,0.176,0.105,0.14,0.103,0.14]],""QCUL_95"":1.06936634,""QCUL_99"":1.83441246,""QCUL_95_line"":[0.128,0.141,0.111,0.702,0.18,0.732,0.846,0.16,0.083,0.162,0.085,0.074,0.601,0.382,0.487,0.373,0.488],""QCUL_99_line"":[0.158,0.173,0.136,0.862,0.221,0.897,1.036,0.195,0.102,0.199,0.104,0.091,0.736,0.469,0.596,0.459,0.598],""T2CUL_95"":9.499,""T2CUL_99"":13.297,""T2CUL_95_line"":[0.039,0.039,0.038,0.039,0.043,0.041,0.049,0.084,0.078,0.084,0.082,0.078,0.063,0.036,0.035,0.036,0.035],""T2CUL_99_line"":[0.047,0.046,0.045,0.047,0.05,0.048,0.058,0.1,0.092,0.099,0.097,0.092,0.075,0.042,0.041,0.042,0.041],""Kesi_95"":1.597,""Kesi_99"":1.396,""Kesi_95_line"":[0.016,0.016,0.016,0.016,0.017,0.017,0.02,0.035,0.032,0.034,0.034,0.032,0.026,0.015,0.014,0.015,0.014],""Kesi_99_line"":[0.015,0.015,0.015,0.015,0.016,0.016,0.019,0.032,0.03,0.032,0.031,0.03,0.024,0.014,0.013,0.014,0.013],""COV"":[[1.0,0.998,0.999,0.656,0.998,0.754,0.585,0.804,0.813,0.803,0.807,0.814,0.833,0.629,0.72,0.63,0.721],[0.998,1.0,0.998,0.618,0.998,0.719,0.555,0.805,0.812,0.804,0.807,0.813,0.83,0.59,0.693,0.591,0.694],[0.999,0.998,1.0,0.644,0.998,0.749,0.578,0.795,0.803,0.794,0.797,0.804,0.826,0.619,0.718,0.621,0.719],[0.656,0.618,0.644,1.0,0.645,0.907,0.777,0.53,0.566,0.539,0.539,0.561,0.61,0.977,0.829,0.976,0.828],[0.998,0.998,0.998,0.645,1.0,0.74,0.56,0.822,0.83,0.821,0.824,0.83,0.846,0.616,0.711,0.618,0.712],[0.754,0.719,0.749,0.907,0.74,1.0,0.762,0.592,0.624,0.598,0.601,0.622,0.687,0.922,0.913,0.923,0.913],[0.585,0.555,0.578,0.777,0.56,0.762,1.0,0.385,0.416,0.391,0.396,0.413,0.495,0.753,0.679,0.753,0.68],[0.804,0.805,0.795,0.53,0.822,0.592,0.385,1.0,0.999,1.0,1.0,0.999,0.974,0.501,0.602,0.503,0.603],[0.813,0.812,0.803,0.566,0.83,0.624,0.416,0.999,1.0,0.999,0.999,1.0,0.982,0.541,0.638,0.542,0.638],[0.803,0.804,0.794,0.539,0.821,0.598,0.391,1.0,0.999,1.0,1.0,0.999,0.975,0.51,0.608,0.512,0.608],[0.807,0.807,0.797,0.539,0.824,0.601,0.396,1.0,0.999,1.0,1.0,1.0,0.978,0.512,0.615,0.514,0.615],[0.814,0.813,0.804,0.561,0.83,0.622,0.413,0.999,1.0,0.999,1.0,1.0,0.982,0.537,0.637,0.539,0.637],[0.833,0.83,0.826,0.61,0.846,0.687,0.495,0.974,0.982,0.975,0.978,0.982,1.0,0.609,0.741,0.611,0.741],[0.629,0.59,0.619,0.977,0.616,0.922,0.753,0.501,0.541,0.51,0.512,0.537,0.609,1.0,0.898,1.0,0.897],[0.72,0.693,0.718,0.829,0.711,0.913,0.679,0.602,0.638,0.608,0.615,0.637,0.741,0.898,1.0,0.9,1.0],[0.63,0.591,0.621,0.976,0.618,0.923,0.753,0.503,0.542,0.512,0.514,0.539,0.611,1.0,0.9,1.0,0.9],[0.721,0.694,0.719,0.828,0.712,0.913,0.68,0.603,0.638,0.608,0.615,0.637,0.741,0.897,1.0,0.9,1.0]],""K"":4,""R"":0.98,""featValue"":[12.903,2.556,0.812,0.396,0.243,0.075,0.01,0.005,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.257,-0.08,-0.4,0.051,-0.077,-0.031,0.038,0.012,-0.162,-0.471,0.71,-0.056,-0.004,0.022,-0.008,-0.011,0.002],[0.252,-0.107,-0.422,0.063,-0.062,-0.097,0.018,-0.043,0.691,-0.302,-0.396,0.043,0.007,-0.011,0.005,0.01,0.004],[0.255,-0.08,-0.418,0.072,-0.055,-0.023,0.065,-0.007,-0.686,-0.019,-0.517,0.052,-0.005,-0.011,0.002,0.002,0.005],[0.227,0.312,0.111,-0.192,-0.485,-0.105,-0.734,-0.099,-0.04,-0.06,-0.036,-0.028,0.004,-0.014,-0.001,0.007,-0.001],[0.257,-0.1,-0.379,0.066,-0.1,-0.058,-0.054,0.032,0.141,0.824,0.242,-0.036,-0.001,0.01,-0.001,-0.006,-0.009],[0.243,0.26,-0.007,0.071,-0.019,0.919,0.061,-0.129,0.057,0.011,-0.011,-0.005,0.004,0.004,-0.001,-0.001,0.001],[0.188,0.301,-0.15,-0.774,0.49,-0.057,0.035,0.09,0.008,0.023,0.002,0.006,-0.004,0.001,0.0,0.0,0.0],[0.246,-0.27,0.196,-0.082,-0.029,0.052,0.015,0.226,-0.004,-0.014,0.003,-0.111,0.206,-0.647,0.444,0.302,0.067],[0.251,-0.243,0.206,-0.072,-0.018,0.026,-0.014,0.068,0.002,0.004,0.07,0.856,-0.245,-0.059,-0.123,-0.091,-0.025],[0.247,-0.264,0.204,-0.085,-0.036,0.043,-0.004,0.224,-0.001,-0.018,-0.032,-0.011,0.473,0.657,0.302,-0.137,0.009],[0.247,-0.262,0.2,-0.076,-0.009,0.03,0.017,0.133,0.0,-0.014,-0.039,-0.272,0.234,-0.126,-0.811,-0.033,0.017],[0.251,-0.245,0.203,-0.068,-0.011,0.023,0.021,0.109,0.005,-0.019,-0.055,-0.403,-0.773,0.175,0.12,-0.065,-0.08],[0.26,-0.178,0.188,0.008,0.225,-0.137,0.021,-0.881,-0.029,0.029,0.034,-0.055,0.093,0.001,0.072,0.022,0.011],[0.225,0.345,0.16,0.018,-0.276,-0.194,0.442,0.002,0.019,0.022,-0.004,-0.049,0.042,-0.201,0.09,-0.639,0.186],[0.241,0.235,0.098,0.396,0.387,-0.118,-0.177,0.162,0.001,-0.005,0.004,0.018,-0.074,0.09,-0.035,0.153,0.679],[0.225,0.344,0.16,0.023,-0.269,-0.192,0.436,0.004,0.012,0.023,0.01,0.06,-0.021,0.201,-0.088,0.647,-0.185],[0.241,0.235,0.096,0.396,0.388,-0.117,-0.172,0.16,-0.002,-0.019,-0.003,-0.014,0.077,-0.097,0.033,-0.16,-0.677]],""selectVec"":[[0.257,-0.08,-0.4,0.051],[0.252,-0.107,-0.422,0.063],[0.255,-0.08,-0.418,0.072],[0.227,0.312,0.111,-0.192],[0.257,-0.1,-0.379,0.066],[0.243,0.26,-0.007,0.071],[0.188,0.301,-0.15,-0.774],[0.246,-0.27,0.196,-0.082],[0.251,-0.243,0.206,-0.072],[0.247,-0.264,0.204,-0.085],[0.247,-0.262,0.2,-0.076],[0.251,-0.245,0.203,-0.068],[0.26,-0.178,0.188,0.008],[0.225,0.345,0.16,0.018],[0.241,0.235,0.098,0.396],[0.225,0.344,0.16,0.023],[0.241,0.235,0.096,0.396]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6464,""AfterCleanSamNum"":6374,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机E运行"",""alarmcondition"":""[d1_10hfe50aj001xq01]>10""},""copy"":false,""principal"":""4"",""precision"":""98%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":169,""version"":""v-2025-12-09 10:44:56"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "]],\"Target_Data\":[[]]}";
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