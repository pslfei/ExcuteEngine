using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA158")]
    [FCDisplay("PCA158")]
    public partial class PCA158 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F减速机推力轴承油温1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F减速机推力轴承油温2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F减速机推力轴承油温3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F液压油站油箱油温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F减速机推力轴承油温4")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F润滑油站油箱油温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F润滑油站供油管路油温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机绕组温度（A相）1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机绕组温度（B相）1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机绕组温度（C相）1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机绕组温度（A相）2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机绕组温度（B相）2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机绕组温度（C相）2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机前轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机后轴承温度1")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机前轴承温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机F主电机后轴承温度2")]
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

		public PCA158()
		{
			ModelID = 170;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA158";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""170"",""name"":""PCA158"",""description"":""磨煤机F本体温度"",""founder"":""admin"",""creatTime"":""2023-11-08 10:10:01"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:49:34"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-05 19:23:44"",""et"":""2025-11-17 19:57:20"",""duration"":1038816,""number"":3463,""filter"":90,""mode"":3373,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc61ct101r"",""Description"":""磨煤机F减速机推力轴承油温1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.40"",""lowerBound"":""-0.40"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""46.52"",""TMin"":""40.32"",""TAvg"":""42.64"",""DMax"":""0.53"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.33"",""C99"":""0.40""},{""PointId"":""d1_10hfc61ct102r"",""Description"":""磨煤机F减速机推力轴承油温2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""47.11"",""TMin"":""41.29"",""TAvg"":""43.50"",""DMax"":""0.54"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.39""},{""PointId"":""d1_10hfc61ct103r"",""Description"":""磨煤机F减速机推力轴承油温3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""46.86"",""TMin"":""41.32"",""TAvg"":""43.44"",""DMax"":""0.46"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.31""},{""PointId"":""d1_10hfc62ct101r"",""Description"":""磨煤机F液压油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.46"",""lowerBound"":""-0.46"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""37.40"",""TMin"":""32.46"",""TAvg"":""34.25"",""DMax"":""0.55"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.37"",""C99"":""0.46""},{""PointId"":""d1_10hfc61ct104r"",""Description"":""磨煤机F减速机推力轴承油温4"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.40"",""lowerBound"":""-0.40"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""46.77"",""TMin"":""40.53"",""TAvg"":""42.86"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.40""},{""PointId"":""d1_10hfc61ct105r"",""Description"":""磨煤机F润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.84"",""lowerBound"":""-0.84"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""39.22"",""TMin"":""34.15"",""TAvg"":""35.91"",""DMax"":""1.12"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.68"",""C99"":""0.84""},{""PointId"":""d1_10hfc61ct106r"",""Description"":""磨煤机F润滑油站供油管路油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""31.07"",""TMin"":""25.10"",""TAvg"":""27.78"",""DMax"":""0.52"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfc60ct101r"",""Description"":""磨煤机F主电机绕组温度（A相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""64.13"",""TMin"":""54.49"",""TAvg"":""58.27"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.08""},{""PointId"":""d1_10hfc60ct103r"",""Description"":""磨煤机F主电机绕组温度（B相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""67.27"",""TMin"":""58.21"",""TAvg"":""61.95"",""DMax"":""0.20"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hfc60ct105r"",""Description"":""磨煤机F主电机绕组温度（C相）1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.06"",""lowerBound"":""-0.06"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""63.64"",""TMin"":""54.66"",""TAvg"":""58.23"",""DMax"":""0.13"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.05"",""C99"":""0.06""},{""PointId"":""d1_10hfc60ct102r"",""Description"":""磨煤机F主电机绕组温度（A相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.06"",""lowerBound"":""-0.06"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""65.19"",""TMin"":""55.66"",""TAvg"":""59.43"",""DMax"":""0.08"",""DMin"":""0.00"",""DAvg"":""0.01"",""C95"":""0.05"",""C99"":""0.06""},{""PointId"":""d1_10hfc60ct104r"",""Description"":""磨煤机F主电机绕组温度（B相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.07"",""lowerBound"":""-0.07"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""67.21"",""TMin"":""57.35"",""TAvg"":""61.19"",""DMax"":""0.13"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.06"",""C99"":""0.07""},{""PointId"":""d1_10hfc60ct106r"",""Description"":""磨煤机F主电机绕组温度（C相）2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.07"",""lowerBound"":""-0.07"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""65.22"",""TMin"":""55.75"",""TAvg"":""59.51"",""DMax"":""0.07"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.06"",""C99"":""0.07""},{""PointId"":""d1_10hfc60ct107r"",""Description"":""磨煤机F主电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""39.83"",""TMin"":""35.52"",""TAvg"":""37.03"",""DMax"":""0.27"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hfc60ct109r"",""Description"":""磨煤机F主电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.57"",""lowerBound"":""-0.57"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""46.01"",""TMin"":""42.63"",""TAvg"":""43.69"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.57""},{""PointId"":""d1_10hfc60ct108r"",""Description"":""磨煤机F主电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.22"",""lowerBound"":""-0.22"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""39.57"",""TMin"":""35.27"",""TAvg"":""36.79"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hfc60ct110r"",""Description"":""磨煤机F主电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.57"",""lowerBound"":""-0.57"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""46.04"",""TMin"":""42.66"",""TAvg"":""43.72"",""DMax"":""0.78"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.57""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:49:34"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[40.323,41.289,41.315,32.459,40.527,34.147,25.1,54.49,58.214,54.656,55.664,57.348,55.749,35.519,42.628,35.27,42.661],""Train_X_max"":[46.518,47.113,46.861,37.4,46.774,39.219,31.074,64.134,67.272,63.635,65.192,67.207,65.221,39.825,46.009,39.574,46.042],""Train_X_std"":[1.101,1.088,1.003,0.713,1.123,1.028,1.181,1.783,1.749,1.689,1.785,1.827,1.78,0.629,0.643,0.63,0.644],""Train_X_mean"":[42.643,43.504,43.435,34.25,42.855,35.91,27.779,58.268,61.949,58.227,59.432,61.192,59.512,37.031,43.694,36.789,43.724],""Train_X_bais_max"":[[0.531,0.542,0.459,0.548,0.465,1.121,0.519,0.14,0.198,0.126,0.076,0.131,0.068,0.271,0.774,0.275,0.776]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.094,0.087,0.072,0.105,0.091,0.191,0.085,0.019,0.037,0.012,0.014,0.016,0.016,0.052,0.132,0.052,0.131]],""QCUL_95"":1.00300682,""QCUL_99"":1.76438475,""QCUL_95_line"":[0.329,0.313,0.255,0.372,0.323,0.682,0.302,0.069,0.132,0.045,0.05,0.056,0.056,0.181,0.463,0.181,0.461],""QCUL_99_line"":[0.403,0.385,0.313,0.456,0.397,0.838,0.37,0.084,0.161,0.055,0.061,0.069,0.069,0.222,0.568,0.222,0.566],""T2CUL_95"":9.51,""T2CUL_99"":13.315,""T2CUL_95_line"":[0.058,0.058,0.053,0.038,0.06,0.055,0.063,0.095,0.093,0.09,0.095,0.097,0.095,0.033,0.034,0.033,0.034],""T2CUL_99_line"":[0.069,0.068,0.063,0.045,0.071,0.065,0.074,0.112,0.11,0.106,0.112,0.115,0.112,0.04,0.04,0.04,0.04],""Kesi_95"":1.593,""Kesi_99"":1.381,""Kesi_95_line"":[0.024,0.024,0.022,0.015,0.024,0.022,0.026,0.039,0.038,0.037,0.039,0.04,0.039,0.014,0.014,0.014,0.014],""Kesi_99_line"":[0.022,0.022,0.02,0.014,0.023,0.021,0.024,0.036,0.035,0.034,0.036,0.037,0.036,0.013,0.013,0.013,0.013],""COV"":[[1.0,0.997,0.996,0.564,0.997,0.876,0.454,0.728,0.742,0.734,0.73,0.728,0.727,0.534,0.777,0.533,0.777],[0.997,1.0,0.996,0.525,0.997,0.86,0.435,0.712,0.727,0.718,0.715,0.713,0.711,0.494,0.756,0.493,0.756],[0.996,0.996,1.0,0.55,0.995,0.88,0.46,0.697,0.713,0.704,0.7,0.697,0.696,0.524,0.784,0.523,0.784],[0.564,0.525,0.55,1.0,0.535,0.738,0.702,0.545,0.547,0.561,0.541,0.534,0.544,0.975,0.824,0.975,0.825],[0.997,0.997,0.995,0.535,1.0,0.866,0.438,0.706,0.721,0.713,0.709,0.707,0.705,0.508,0.768,0.507,0.769],[0.876,0.86,0.88,0.738,0.866,1.0,0.638,0.631,0.649,0.644,0.632,0.627,0.631,0.753,0.942,0.752,0.942],[0.454,0.435,0.46,0.702,0.438,0.638,1.0,0.321,0.332,0.334,0.317,0.315,0.316,0.673,0.689,0.672,0.69],[0.728,0.712,0.697,0.545,0.706,0.631,0.321,1.0,0.999,1.0,1.0,1.0,1.0,0.452,0.615,0.452,0.616],[0.742,0.727,0.713,0.547,0.721,0.649,0.332,0.999,1.0,1.0,1.0,1.0,1.0,0.456,0.634,0.455,0.634],[0.734,0.718,0.704,0.561,0.713,0.644,0.334,1.0,1.0,1.0,1.0,1.0,1.0,0.47,0.631,0.469,0.631],[0.73,0.715,0.7,0.541,0.709,0.632,0.317,1.0,1.0,1.0,1.0,1.0,1.0,0.449,0.616,0.448,0.616],[0.728,0.713,0.697,0.534,0.707,0.627,0.315,1.0,1.0,1.0,1.0,1.0,1.0,0.441,0.612,0.44,0.612],[0.727,0.711,0.696,0.544,0.705,0.631,0.316,1.0,1.0,1.0,1.0,1.0,1.0,0.452,0.615,0.451,0.616],[0.534,0.494,0.524,0.975,0.508,0.753,0.673,0.452,0.456,0.47,0.449,0.441,0.452,1.0,0.834,1.0,0.835],[0.777,0.756,0.784,0.824,0.768,0.942,0.689,0.615,0.634,0.631,0.616,0.612,0.615,0.834,1.0,0.834,1.0],[0.533,0.493,0.523,0.975,0.507,0.752,0.672,0.452,0.455,0.469,0.448,0.44,0.451,1.0,0.834,1.0,0.834],[0.777,0.756,0.784,0.825,0.769,0.942,0.69,0.616,0.634,0.631,0.616,0.612,0.616,0.835,1.0,0.834,1.0]],""K"":4,""R"":0.982,""featValue"":[12.268,2.645,1.351,0.432,0.235,0.048,0.017,0.004,0.002,0.002,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.258,0.035,0.352,-0.052,0.212,0.013,-0.049,0.025,-0.357,-0.79,0.064,-0.023,0.017,0.008,0.021,0.009,0.018],[0.253,0.048,0.384,-0.032,0.201,0.072,0.016,-0.18,-0.606,0.581,0.013,-0.024,0.001,-0.021,-0.004,-0.009,-0.01],[0.254,0.019,0.383,-0.036,0.156,0.09,0.052,-0.624,0.602,0.002,-0.008,0.019,-0.007,0.001,-0.005,-0.003,-0.011],[0.223,-0.299,-0.282,-0.157,0.325,0.183,0.78,0.096,0.005,-0.015,-0.015,0.001,-0.007,0.023,0.006,-0.001,-0.007],[0.253,0.037,0.383,-0.051,0.176,0.13,-0.127,0.746,0.362,0.169,-0.064,0.028,-0.013,0.012,-0.018,-0.001,-0.001],[0.258,-0.166,0.19,-0.014,-0.325,-0.833,0.251,0.064,0.029,0.035,-0.003,0.009,0.003,-0.001,0.006,0.007,0.001],[0.168,-0.328,-0.079,0.901,0.191,-0.019,-0.096,0.0,0.005,0.0,0.002,0.006,-0.003,0.004,-0.005,-0.001,0.0],[0.25,0.263,-0.187,0.034,0.001,-0.026,-0.027,0.029,0.066,0.043,0.472,-0.589,0.075,0.126,0.386,-0.029,-0.287],[0.253,0.257,-0.168,0.045,-0.043,-0.004,-0.016,-0.034,-0.026,-0.039,-0.831,-0.338,0.107,-0.1,0.067,0.034,-0.046],[0.253,0.252,-0.187,0.029,-0.008,-0.016,-0.003,0.011,0.034,0.008,0.264,-0.149,0.117,-0.52,-0.567,-0.032,0.369],[0.25,0.265,-0.181,0.029,-0.012,-0.02,-0.03,-0.02,-0.004,0.027,0.016,0.152,-0.198,0.574,0.114,0.045,0.651],[0.25,0.269,-0.18,0.039,-0.017,-0.001,-0.01,0.002,-0.004,0.008,0.067,0.619,0.187,-0.36,0.433,0.276,-0.125],[0.25,0.264,-0.187,0.024,-0.011,-0.031,-0.032,-0.014,-0.026,-0.022,-0.006,0.296,-0.285,0.269,-0.44,-0.293,-0.555],[0.21,-0.358,-0.238,-0.273,0.184,-0.104,-0.383,-0.05,0.004,0.022,-0.021,-0.074,-0.632,-0.261,0.124,0.114,0.017],[0.255,-0.225,0.037,-0.01,-0.522,0.333,-0.01,-0.006,-0.044,-0.018,0.051,-0.068,0.007,0.162,-0.227,0.63,-0.125],[0.21,-0.358,-0.239,-0.274,0.184,-0.102,-0.386,-0.053,0.007,0.04,-0.005,0.081,0.643,0.236,-0.11,-0.103,-0.014],[0.255,-0.225,0.036,-0.009,-0.519,0.328,-0.006,0.0,-0.039,-0.028,0.003,0.064,-0.015,-0.147,0.227,-0.642,0.12]],""selectVec"":[[0.258,0.035,0.352,-0.052],[0.253,0.048,0.384,-0.032],[0.254,0.019,0.383,-0.036],[0.223,-0.299,-0.282,-0.157],[0.253,0.037,0.383,-0.051],[0.258,-0.166,0.19,-0.014],[0.168,-0.328,-0.079,0.901],[0.25,0.263,-0.187,0.034],[0.253,0.257,-0.168,0.045],[0.253,0.252,-0.187,0.029],[0.25,0.265,-0.181,0.029],[0.25,0.269,-0.18,0.039],[0.25,0.264,-0.187,0.024],[0.21,-0.358,-0.238,-0.273],[0.255,-0.225,0.037,-0.01],[0.21,-0.358,-0.239,-0.274],[0.255,-0.225,0.036,-0.009]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3463,""AfterCleanSamNum"":3373,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机F运行"",""alarmcondition"":""[d1_10hfe60aj001xq01]>10""},""copy"":false,""principal"":""4"",""precision"":""98.2%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":170,""version"":""v-2025-12-09 10:49:34"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "]],\"Target_Data\":[[]]}";
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