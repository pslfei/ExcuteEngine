using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA156")]
    [FCDisplay("PCA156")]
    public partial class PCA156 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D减速机推力轴承油温1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D减速机推力轴承油温2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D减速机推力轴承油温3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D液压油站油箱油温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D减速机推力轴承油温4")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D润滑油站油箱油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D润滑油站供油管路油温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机绕组温度（A相）1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机绕组温度（B相）1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机绕组温度（C相）1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机绕组温度（A相）2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机绕组温度（B相）2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机绕组温度（C相）2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机前轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机后轴承温度1")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机前轴承温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D主电机后轴承温度2")]
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

		public PCA156()
		{
			ModelID = 168;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA156";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""168"",""name"":""PCA156"",""description"":""磨煤机D本体温度"",""founder"":""admin"",""creatTime"":""2023-11-08 09:53:47"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:32:46"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 15:43:34"",""et"":""2025-11-26 05:32:58"",""duration"":1172964,""number"":3910,""filter"":90,""mode"":3820,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-29 07:11:40"",""et"":""2025-12-06 02:06:22"",""duration"":586482,""number"":1955,""filter"":90,""mode"":1865,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc41ct101r"",""Description"":""磨煤机D减速机推力轴承油温1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""46.83"",""TMin"":""38.88"",""TAvg"":""41.92"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hfc41ct102r"",""Description"":""磨煤机D减速机推力轴承油温2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""46.12"",""TMin"":""38.29"",""TAvg"":""41.15"",""DMax"":""0.22"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.22"",""C99"":""0.27""},{""PointId"":""d1_10hfc41ct103r"",""Description"":""磨煤机D减速机推力轴承油温3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""47.34"",""TMin"":""39.10"",""TAvg"":""42.30"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hfc42ct101r"",""Description"":""磨煤机D液压油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.70"",""lowerBound"":""-0.70"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""40.79"",""TMin"":""31.73"",""TAvg"":""34.84"",""DMax"":""0.78"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.57"",""C99"":""0.70""},{""PointId"":""d1_10hfc41ct104r"",""Description"":""磨煤机D减速机推力轴承油温4"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.19"",""lowerBound"":""-0.19"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""47.09"",""TMin"":""38.77"",""TAvg"":""42.08"",""DMax"":""0.27"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.19""},{""PointId"":""d1_10hfc41ct105r"",""Description"":""磨煤机D润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.78"",""lowerBound"":""-0.78"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""41.08"",""TMin"":""32.82"",""TAvg"":""35.56"",""DMax"":""0.96"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.64"",""C99"":""0.78""},{""PointId"":""d1_10hfc41ct106r"",""Description"":""磨煤机D润滑油站供油管路油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.90"",""lowerBound"":""-0.90"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""34.05"",""TMin"":""25.35"",""TAvg"":""28.54"",""DMax"":""0.99"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.74"",""C99"":""0.90""},{""PointId"":""d1_10hfc40ct101r"",""Description"":""磨煤机D主电机绕组温度（A相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.17"",""lowerBound"":""-1.17"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""64.59"",""TMin"":""54.81"",""TAvg"":""58.62"",""DMax"":""1.09"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""0.96"",""C99"":""1.17""},{""PointId"":""d1_10hfc40ct103r"",""Description"":""磨煤机D主电机绕组温度（B相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""66.88"",""TMin"":""56.53"",""TAvg"":""60.23"",""DMax"":""0.44"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hfc40ct105r"",""Description"":""磨煤机D主电机绕组温度（C相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""66.18"",""TMin"":""55.91"",""TAvg"":""59.56"",""DMax"":""0.41"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfc40ct102r"",""Description"":""磨煤机D主电机绕组温度（A相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""62.01"",""TMin"":""52.28"",""TAvg"":""55.57"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.19"",""C99"":""0.23""},{""PointId"":""d1_10hfc40ct104r"",""Description"":""磨煤机D主电机绕组温度（B相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""66.53"",""TMin"":""56.33"",""TAvg"":""59.96"",""DMax"":""0.39"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfc40ct106r"",""Description"":""磨煤机D主电机绕组温度（C相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""66.25"",""TMin"":""56.13"",""TAvg"":""59.68"",""DMax"":""0.41"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfc40ct107r"",""Description"":""磨煤机D主电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.41"",""lowerBound"":""-0.41"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""50.20"",""TMin"":""41.88"",""TAvg"":""44.60"",""DMax"":""0.49"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.41""},{""PointId"":""d1_10hfc40ct109r"",""Description"":""磨煤机D主电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""51.48"",""TMin"":""44.49"",""TAvg"":""46.61"",""DMax"":""0.36"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.28"",""C99"":""0.35""},{""PointId"":""d1_10hfc40ct108r"",""Description"":""磨煤机D主电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.41"",""lowerBound"":""-0.41"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""50.10"",""TMin"":""41.77"",""TAvg"":""44.49"",""DMax"":""0.49"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.41""},{""PointId"":""d1_10hfc40ct110r"",""Description"":""磨煤机D主电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""51.62"",""TMin"":""44.64"",""TAvg"":""46.75"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.29"",""C99"":""0.35""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:32:46"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[38.881,38.285,39.101,31.726,38.767,32.819,25.346,54.812,56.527,55.913,52.278,56.333,56.125,41.878,44.488,41.767,44.644],""Train_X_max"":[46.826,46.117,47.335,40.793,47.089,41.081,34.054,64.588,66.879,66.179,62.006,66.532,66.25,50.202,51.479,50.095,51.62],""Train_X_std"":[1.195,1.17,1.263,0.997,1.309,1.065,1.207,1.526,1.65,1.641,1.423,1.613,1.616,0.94,1.037,0.941,1.036],""Train_X_mean"":[41.919,41.152,42.301,34.839,42.082,35.563,28.537,58.622,60.23,59.559,55.572,59.959,59.681,44.598,46.608,44.488,46.751],""Train_X_bais_max"":[[0.241,0.223,0.254,0.78,0.274,0.957,0.99,1.085,0.439,0.413,0.209,0.39,0.41,0.488,0.364,0.487,0.354]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.05,0.064,0.045,0.164,0.044,0.186,0.213,0.285,0.09,0.088,0.056,0.088,0.089,0.097,0.083,0.098,0.083]],""QCUL_95"":0.751840234,""QCUL_99"":1.17703235,""QCUL_95_line"":[0.175,0.221,0.161,0.568,0.158,0.639,0.738,0.957,0.307,0.301,0.19,0.3,0.303,0.336,0.284,0.338,0.286],""QCUL_99_line"":[0.215,0.27,0.198,0.695,0.194,0.783,0.904,1.169,0.375,0.369,0.233,0.367,0.37,0.412,0.347,0.414,0.35],""T2CUL_95"":9.5,""T2CUL_99"":13.299,""T2CUL_95_line"":[0.048,0.047,0.051,0.04,0.053,0.043,0.049,0.062,0.067,0.067,0.058,0.065,0.066,0.038,0.042,0.038,0.042],""T2CUL_99_line"":[0.057,0.056,0.061,0.048,0.063,0.051,0.058,0.073,0.079,0.079,0.068,0.077,0.078,0.045,0.05,0.045,0.05],""Kesi_95"":1.607,""Kesi_99"":1.436,""Kesi_95_line"":[0.02,0.02,0.021,0.017,0.022,0.018,0.02,0.025,0.028,0.027,0.024,0.027,0.027,0.016,0.017,0.016,0.017],""Kesi_99_line"":[0.019,0.018,0.02,0.016,0.021,0.017,0.019,0.024,0.026,0.026,0.022,0.025,0.025,0.015,0.016,0.015,0.016],""COV"":[[1.0,0.999,0.998,0.611,0.998,0.845,0.502,0.819,0.885,0.888,0.87,0.876,0.886,0.584,0.485,0.584,0.486],[0.999,1.0,0.996,0.627,0.996,0.852,0.518,0.816,0.884,0.887,0.872,0.875,0.885,0.599,0.493,0.598,0.493],[0.998,0.996,1.0,0.597,0.999,0.844,0.492,0.823,0.885,0.887,0.868,0.876,0.885,0.572,0.485,0.572,0.486],[0.611,0.627,0.597,1.0,0.583,0.861,0.776,0.646,0.652,0.653,0.747,0.67,0.661,0.961,0.807,0.961,0.806],[0.998,0.996,0.999,0.583,1.0,0.832,0.485,0.816,0.881,0.883,0.861,0.871,0.881,0.557,0.465,0.556,0.465],[0.845,0.852,0.844,0.861,0.832,1.0,0.682,0.828,0.833,0.831,0.88,0.841,0.837,0.866,0.804,0.865,0.805],[0.502,0.518,0.492,0.776,0.485,0.682,1.0,0.345,0.38,0.384,0.456,0.388,0.384,0.713,0.532,0.713,0.532],[0.819,0.816,0.823,0.646,0.816,0.828,0.345,1.0,0.958,0.957,0.955,0.96,0.957,0.643,0.617,0.643,0.616],[0.885,0.884,0.885,0.652,0.881,0.833,0.38,0.958,1.0,1.0,0.99,0.999,0.999,0.66,0.621,0.66,0.62],[0.888,0.887,0.887,0.653,0.883,0.831,0.384,0.957,1.0,1.0,0.99,0.999,1.0,0.657,0.611,0.656,0.611],[0.87,0.872,0.868,0.747,0.861,0.88,0.456,0.955,0.99,0.99,1.0,0.993,0.992,0.754,0.702,0.754,0.701],[0.876,0.875,0.876,0.67,0.871,0.841,0.388,0.96,0.999,0.999,0.993,1.0,0.999,0.681,0.646,0.68,0.645],[0.886,0.885,0.885,0.661,0.881,0.837,0.384,0.957,0.999,1.0,0.992,0.999,1.0,0.669,0.628,0.668,0.628],[0.584,0.599,0.572,0.961,0.557,0.866,0.713,0.643,0.66,0.657,0.754,0.681,0.669,1.0,0.919,1.0,0.918],[0.485,0.493,0.485,0.807,0.465,0.804,0.532,0.617,0.621,0.611,0.702,0.646,0.628,0.919,1.0,0.919,1.0],[0.584,0.598,0.572,0.961,0.556,0.865,0.713,0.643,0.66,0.656,0.754,0.68,0.668,1.0,0.919,1.0,0.918],[0.486,0.493,0.486,0.806,0.465,0.805,0.532,0.616,0.62,0.611,0.701,0.645,0.628,0.918,1.0,0.918,1.0]],""K"":4,""R"":0.984,""featValue"":[13.173,2.326,0.926,0.303,0.136,0.092,0.026,0.015,0.003,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.249,-0.221,-0.241,-0.234,0.114,0.056,0.114,-0.002,-0.24,0.033,-0.074,-0.589,0.562,-0.115,0.089,-0.013,0.007],[0.25,-0.209,-0.251,-0.217,0.139,0.063,0.077,-0.059,-0.669,-0.013,-0.16,0.358,-0.373,0.06,0.084,-0.004,0.009],[0.248,-0.227,-0.231,-0.261,0.052,-0.002,0.11,0.145,0.529,0.595,-0.234,0.186,-0.075,0.018,-0.024,0.008,-0.015],[0.23,0.303,-0.139,0.327,0.502,-0.125,-0.067,0.665,-0.046,-0.059,-0.018,0.047,0.062,0.013,-0.045,0.0,-0.003],[0.245,-0.239,-0.24,-0.25,0.061,0.031,0.129,0.054,0.356,-0.616,0.437,0.025,-0.152,0.039,-0.124,0.009,-0.001],[0.263,0.092,-0.113,-0.158,-0.069,-0.608,-0.68,-0.213,0.013,-0.009,0.02,0.008,0.033,-0.005,0.002,0.0,0.001],[0.166,0.284,-0.624,0.361,-0.592,0.115,0.084,-0.016,-0.012,0.009,0.001,-0.009,-0.006,-0.012,0.007,0.0,0.0],[0.251,-0.144,0.243,0.252,-0.141,-0.649,0.589,-0.054,-0.049,0.003,0.001,0.005,0.0,0.007,0.004,-0.001,0.002],[0.26,-0.169,0.18,0.165,-0.09,0.172,-0.125,-0.052,-0.004,-0.177,-0.411,0.064,0.08,-0.231,-0.724,0.021,-0.026],[0.26,-0.173,0.169,0.185,-0.078,0.179,-0.139,-0.013,-0.04,0.086,0.117,-0.018,0.151,0.856,-0.049,0.011,-0.024],[0.268,-0.084,0.165,0.189,0.002,0.126,-0.136,0.024,0.019,0.145,0.069,-0.594,-0.645,-0.136,0.096,0.0,0.006],[0.262,-0.148,0.196,0.164,-0.095,0.164,-0.125,0.022,0.197,-0.329,-0.385,0.189,0.127,-0.13,0.653,-0.023,0.038],[0.261,-0.162,0.179,0.159,-0.068,0.181,-0.119,0.018,-0.131,0.302,0.622,0.303,0.223,-0.397,0.034,-0.009,0.008],[0.232,0.344,0.004,0.038,0.299,0.116,0.134,-0.441,0.101,0.021,0.008,0.033,0.016,0.012,-0.014,-0.7,-0.097],[0.213,0.351,0.253,-0.379,-0.251,0.063,0.078,0.208,-0.066,-0.023,-0.001,-0.007,-0.004,-0.002,0.023,0.097,-0.701],[0.232,0.344,0.005,0.038,0.301,0.116,0.134,-0.44,0.09,0.023,0.009,0.029,0.03,-0.001,0.023,0.7,0.099],[0.213,0.351,0.253,-0.382,-0.252,0.064,0.077,0.214,-0.053,-0.003,0.0,-0.009,-0.004,0.034,-0.05,-0.096,0.697]],""selectVec"":[[0.249,-0.221,-0.241,-0.234],[0.25,-0.209,-0.251,-0.217],[0.248,-0.227,-0.231,-0.261],[0.23,0.303,-0.139,0.327],[0.245,-0.239,-0.24,-0.25],[0.263,0.092,-0.113,-0.158],[0.166,0.284,-0.624,0.361],[0.251,-0.144,0.243,0.252],[0.26,-0.169,0.18,0.165],[0.26,-0.173,0.169,0.185],[0.268,-0.084,0.165,0.189],[0.262,-0.148,0.196,0.164],[0.261,-0.162,0.179,0.159],[0.232,0.344,0.004,0.038],[0.213,0.351,0.253,-0.379],[0.232,0.344,0.005,0.038],[0.213,0.351,0.253,-0.382]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5865,""AfterCleanSamNum"":5775,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机D运行"",""alarmcondition"":""[d1_10hfe40aj001xq01]>10""},""copy"":false,""principal"":""4"",""precision"":""98.4%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":168,""version"":""v-2025-12-09 10:32:46"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "]],\"Target_Data\":[[]]}";
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