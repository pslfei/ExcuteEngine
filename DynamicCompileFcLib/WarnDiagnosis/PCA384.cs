using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA384")]
    [FCDisplay("PCA384")]
    public partial class PCA384 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭市循环冷却水泵A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机定子U相温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机定子V相温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机定子W相温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A驱动端轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A非驱动端轴承温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机驱动端轴承温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机定子U相温度2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机定子V相温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机定子W相温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A驱动端轴承温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A非驱动端轴承温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机非驱动端轴承温度")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置导体温度反馈1")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置轴承温度反馈1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置导体温度反馈2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置轴承温度反馈2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置导体温度反馈3")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵A电机永磁调速装置轴承温度反馈3")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出18")]
	    public LA OUT_R18 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出18")]
	    public LA OUT_B18 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出18")]
	    public LD OUT_F18 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出18")]
	    public LD OUT_W18 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[18] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[18] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[18] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA384()
		{
			ModelID = 424;
			SysID = 11;
			FcType = enumType.Warn;
			FcName = "PCA384";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""424"",""name"":""PCA384"",""description"":""闭式循环冷却水泵A温度"",""founder"":""admin"",""creatTime"":""2025-10-22 14:55:16"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:49:06"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 19:26:44"",""et"":""2025-12-04 15:04:58"",""duration"":1885094,""number"":6284,""filter"":5793,""mode"":491,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":5147},{""st"":""2025-10-06 20:45:20"",""et"":""2025-10-23 04:19:20"",""duration"":1409640,""number"":4699,""filter"":90,""mode"":4609,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-10-25 00:05:08"",""et"":""2025-10-29 14:38:44"",""duration"":398016,""number"":1327,""filter"":90,""mode"":1237,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pgb60ct108r"",""Description"":""闭式循环冷却水泵A电机定子U相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""57.94"",""TMin"":""21.22"",""TAvg"":""49.55"",""DMax"":""1.25"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10pgb60ct110r"",""Description"":""闭式循环冷却水泵A电机定子V相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""59.61"",""TMin"":""20.97"",""TAvg"":""50.88"",""DMax"":""1.93"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.24""},{""PointId"":""d1_10pgb60ct112r"",""Description"":""闭式循环冷却水泵A电机定子W相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""58.89"",""TMin"":""21.36"",""TAvg"":""50.68"",""DMax"":""1.84"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10pgb60ct116r"",""Description"":""闭式循环冷却水泵A驱动端轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""30.47"",""TMin"":""18.77"",""TAvg"":""24.03"",""DMax"":""9.31"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.90"",""C99"":""1.12""},{""PointId"":""d1_10pgb60ct118r"",""Description"":""闭式循环冷却水泵A非驱动端轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""34.89"",""TMin"":""21.48"",""TAvg"":""28.52"",""DMax"":""2.89"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.38"",""C99"":""0.48""},{""PointId"":""d1_10pgb60ct114r"",""Description"":""闭式循环冷却水泵A电机驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""45.42"",""TMin"":""18.87"",""TAvg"":""36.01"",""DMax"":""5.90"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.11"",""C99"":""1.37""},{""PointId"":""d1_10pgb60ct109r"",""Description"":""闭式循环冷却水泵A电机定子U相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""59.97"",""TMin"":""21.04"",""TAvg"":""51.57"",""DMax"":""2.28"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.19"",""C99"":""0.23""},{""PointId"":""d1_10pgb60ct111r"",""Description"":""闭式循环冷却水泵A电机定子V相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""57.58"",""TMin"":""21.45"",""TAvg"":""49.04"",""DMax"":""0.51"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.17"",""C99"":""0.21""},{""PointId"":""d1_10pgb60ct113r"",""Description"":""闭式循环冷却水泵A电机定子W相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""57.07"",""TMin"":""21.24"",""TAvg"":""48.84"",""DMax"":""0.94"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.15""},{""PointId"":""d1_10pgb60ct117r"",""Description"":""闭式循环冷却水泵A驱动端轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""31.42"",""TMin"":""19.72"",""TAvg"":""24.98"",""DMax"":""8.31"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.87"",""C99"":""1.08""},{""PointId"":""d1_10pgb60ct119r"",""Description"":""闭式循环冷却水泵A非驱动端轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""34.19"",""TMin"":""21.10"",""TAvg"":""28.35"",""DMax"":""2.90"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.33"",""C99"":""0.41""},{""PointId"":""d1_10pgb60ct115r"",""Description"":""闭式循环冷却水泵A电机非驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""45.72"",""TMin"":""19.06"",""TAvg"":""26.72"",""DMax"":""0.96"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.09"",""C99"":""0.11""},{""PointId"":""d1_10pgb60gf001xq01"",""Description"":""闭式循环冷却水泵A电机永磁调速装置导体温度反馈1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""62.69"",""TMin"":""28.87"",""TAvg"":""50.06"",""DMax"":""8.83"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.36"",""C99"":""1.69""},{""PointId"":""d1_10pgb60gf001xq04"",""Description"":""闭式循环冷却水泵A电机永磁调速装置轴承温度反馈1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""65.68"",""TMin"":""20.82"",""TAvg"":""43.04"",""DMax"":""3.34"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.75"",""C99"":""0.93""},{""PointId"":""d1_10pgb60gf001xq02"",""Description"":""闭式循环冷却水泵A电机永磁调速装置导体温度反馈2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""62.81"",""TMin"":""27.55"",""TAvg"":""49.45"",""DMax"":""9.22"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.99"",""C99"":""1.22""},{""PointId"":""d1_10pgb60gf001xq05"",""Description"":""闭式循环冷却水泵A电机永磁调速装置轴承温度反馈2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""65.66"",""TMin"":""20.99"",""TAvg"":""43.06"",""DMax"":""2.93"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.72"",""C99"":""0.88""},{""PointId"":""d1_10pgb60gf001xq03"",""Description"":""闭式循环冷却水泵A电机永磁调速装置导体温度反馈3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""63.14"",""TMin"":""26.38"",""TAvg"":""49.21"",""DMax"":""11.11"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""1.13"",""C99"":""1.40""},{""PointId"":""d1_10pgb60gf001xq06"",""Description"":""闭式循环冷却水泵A电机永磁调速装置轴承温度反馈3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""64.87"",""TMin"":""21.08"",""TAvg"":""42.65"",""DMax"":""2.26"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.71"",""C99"":""0.87""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:49:06"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[21.215,20.974,21.356,18.767,21.48,18.872,21.036,21.447,21.244,19.718,21.104,19.061,28.871,20.823,27.552,20.988,26.38,21.084],""Train_X_max"":[57.936,59.608,58.885,30.47,34.886,45.415,59.966,57.578,57.072,31.422,34.193,45.723,62.691,65.681,62.814,65.655,63.135,64.869],""Train_X_std"":[2.81,2.74,2.765,2.226,2.226,4.014,2.794,2.758,2.738,2.226,2.299,2.649,5.428,14.738,6.279,14.546,6.691,14.253],""Train_X_mean"":[49.547,50.883,50.678,24.03,28.52,36.014,51.566,49.041,48.835,24.982,28.352,26.722,50.063,43.041,49.453,43.062,49.214,42.646],""Train_X_bais_max"":[[1.251,1.931,1.835,9.306,2.888,5.898,2.284,0.511,0.938,8.313,2.904,0.956,8.83,3.339,9.22,2.929,11.106,2.262]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.039,0.047,0.039,0.205,0.089,0.288,0.04,0.044,0.033,0.201,0.083,0.022,0.319,0.198,0.262,0.188,0.264,0.187]],""QCUL_95"":0.2873296,""QCUL_99"":0.50842917,""QCUL_95_line"":[0.153,0.193,0.164,0.899,0.383,1.112,0.187,0.167,0.12,0.871,0.33,0.092,1.357,0.752,0.993,0.716,1.127,0.706],""QCUL_99_line"":[0.188,0.239,0.204,1.119,0.477,1.372,0.233,0.206,0.148,1.082,0.408,0.114,1.685,0.928,1.224,0.883,1.4,0.87],""T2CUL_95"":11.086,""T2CUL_99"":15.112,""T2CUL_95_line"":[0.117,0.114,0.115,0.092,0.092,0.167,0.116,0.115,0.114,0.092,0.095,0.11,0.225,0.612,0.261,0.604,0.278,0.592],""T2CUL_99_line"":[0.136,0.133,0.134,0.108,0.108,0.195,0.135,0.134,0.133,0.108,0.111,0.128,0.263,0.715,0.304,0.705,0.324,0.691],""Kesi_95"":1.601,""Kesi_99"":1.382,""Kesi_95_line"":[0.044,0.043,0.044,0.035,0.035,0.063,0.044,0.044,0.043,0.035,0.036,0.042,0.086,0.233,0.099,0.23,0.106,0.225],""Kesi_99_line"":[0.041,0.04,0.041,0.033,0.033,0.059,0.041,0.04,0.04,0.033,0.034,0.039,0.08,0.216,0.092,0.213,0.098,0.209],""COV"":[[1.0,0.998,1.0,0.895,0.809,0.902,0.999,0.999,1.0,0.888,0.828,0.881,0.662,0.669,0.656,0.672,0.626,0.674],[0.998,1.0,0.999,0.875,0.816,0.873,0.999,0.999,0.999,0.867,0.832,0.867,0.628,0.62,0.619,0.623,0.588,0.625],[1.0,0.999,1.0,0.891,0.808,0.892,1.0,1.0,1.0,0.884,0.827,0.876,0.657,0.651,0.65,0.654,0.621,0.657],[0.895,0.875,0.891,1.0,0.769,0.891,0.885,0.89,0.895,0.999,0.802,0.9,0.859,0.707,0.858,0.712,0.838,0.713],[0.809,0.816,0.808,0.769,1.0,0.661,0.806,0.816,0.814,0.756,0.996,0.749,0.446,0.416,0.431,0.418,0.399,0.421],[0.902,0.873,0.892,0.891,0.661,1.0,0.89,0.887,0.893,0.896,0.695,0.842,0.783,0.908,0.795,0.911,0.775,0.912],[0.999,0.999,1.0,0.885,0.806,0.89,1.0,1.0,1.0,0.878,0.824,0.871,0.648,0.647,0.641,0.65,0.612,0.653],[0.999,0.999,1.0,0.89,0.816,0.887,1.0,1.0,1.0,0.882,0.833,0.879,0.65,0.643,0.642,0.646,0.612,0.649],[1.0,0.999,1.0,0.895,0.814,0.893,1.0,1.0,1.0,0.888,0.832,0.88,0.658,0.652,0.651,0.656,0.622,0.658],[0.888,0.867,0.884,0.999,0.756,0.896,0.878,0.882,0.888,1.0,0.79,0.897,0.87,0.718,0.871,0.723,0.852,0.725],[0.828,0.832,0.827,0.802,0.996,0.695,0.824,0.833,0.832,0.79,1.0,0.777,0.489,0.454,0.476,0.457,0.445,0.459],[0.881,0.867,0.876,0.9,0.749,0.842,0.871,0.879,0.88,0.897,0.777,1.0,0.765,0.664,0.759,0.667,0.737,0.669],[0.662,0.628,0.657,0.859,0.446,0.783,0.648,0.65,0.658,0.87,0.489,0.765,1.0,0.716,0.995,0.721,0.993,0.721],[0.669,0.62,0.651,0.707,0.416,0.908,0.647,0.643,0.652,0.718,0.454,0.664,0.716,1.0,0.746,1.0,0.735,1.0],[0.656,0.619,0.65,0.858,0.431,0.795,0.641,0.642,0.651,0.871,0.476,0.759,0.995,0.746,1.0,0.751,0.999,0.751],[0.672,0.623,0.654,0.712,0.418,0.911,0.65,0.646,0.656,0.723,0.457,0.667,0.721,1.0,0.751,1.0,0.74,1.0],[0.626,0.588,0.621,0.838,0.399,0.775,0.612,0.612,0.622,0.852,0.445,0.737,0.993,0.735,0.999,0.74,1.0,0.74],[0.674,0.625,0.657,0.713,0.421,0.912,0.653,0.649,0.658,0.725,0.459,0.669,0.721,1.0,0.751,1.0,0.74,1.0]],""K"":5,""R"":0.995,""featValue"":[14.236,2.155,0.93,0.452,0.141,0.067,0.012,0.005,0.003,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.253,-0.169,-0.079,-0.212,0.044,0.055,-0.095,-0.027,0.003,-0.03,0.191,-0.204,-0.324,0.658,-0.082,0.164,0.4,-0.176],[0.248,-0.208,-0.066,-0.244,0.057,0.095,-0.057,-0.024,0.013,-0.099,-0.066,0.031,0.609,-0.174,0.448,0.28,0.331,-0.1],[0.252,-0.179,-0.065,-0.232,0.066,0.07,-0.064,0.102,-0.043,0.072,-0.218,0.301,-0.198,-0.46,-0.56,-0.037,0.295,-0.157],[0.255,0.002,0.21,0.084,0.116,-0.608,-0.13,-0.173,-0.013,0.216,0.516,0.364,0.085,-0.021,-0.003,-0.02,0.023,0.01],[0.206,-0.34,0.047,0.559,0.083,0.224,-0.032,0.044,0.679,0.059,0.005,0.046,-0.023,-0.006,0.003,-0.001,-0.003,-0.001],[0.255,0.097,-0.204,-0.026,0.081,-0.062,0.928,-0.032,0.058,0.038,0.069,0.013,0.0,0.005,-0.01,0.0,0.01,0.001],[0.251,-0.184,-0.074,-0.243,0.071,0.083,-0.048,0.11,-0.04,-0.007,-0.3,0.536,0.021,0.396,0.123,-0.164,-0.448,0.184],[0.251,-0.189,-0.063,-0.222,0.039,0.061,-0.084,-0.078,0.044,-0.097,0.263,-0.471,0.38,-0.023,-0.396,-0.311,-0.343,0.103],[0.252,-0.18,-0.063,-0.217,0.05,0.032,-0.075,-0.01,-0.024,0.139,0.143,-0.249,-0.545,-0.391,0.455,0.067,-0.242,0.147],[0.255,0.02,0.211,0.083,0.127,-0.59,-0.018,0.088,0.07,-0.252,-0.574,-0.33,-0.047,0.03,0.002,0.031,-0.016,-0.01],[0.214,-0.313,0.056,0.544,0.07,0.156,0.054,-0.002,-0.721,-0.063,0.0,-0.043,0.017,0.006,-0.003,-0.002,-0.002,0.002],[0.244,-0.051,0.131,0.013,-0.956,-0.048,0.048,0.013,0.014,-0.001,-0.015,0.021,0.0,-0.001,0.002,0.0,0.001,0.0],[0.219,0.283,0.381,-0.037,0.071,0.307,-0.007,-0.766,0.022,-0.08,-0.158,0.045,-0.065,-0.009,-0.019,0.007,-0.017,0.0],[0.213,0.311,-0.381,0.145,-0.022,0.006,-0.171,-0.014,-0.004,0.001,-0.024,-0.004,0.033,0.004,-0.155,0.3,0.151,0.724],[0.219,0.306,0.345,-0.022,0.077,0.191,-0.014,0.355,-0.057,0.7,-0.112,-0.182,0.143,0.086,0.013,-0.04,0.038,-0.007],[0.214,0.311,-0.375,0.143,-0.02,0.003,-0.165,-0.007,-0.01,0.028,0.006,0.009,0.032,-0.015,-0.085,0.409,-0.419,-0.563],[0.213,0.325,0.36,-0.025,0.081,0.207,0.007,0.464,0.024,-0.579,0.304,0.119,-0.072,-0.071,0.018,0.032,-0.018,0.012],[0.214,0.309,-0.374,0.142,-0.019,0.0,-0.164,-0.021,-0.003,-0.06,-0.031,0.004,-0.031,-0.024,0.26,-0.71,0.256,-0.164]],""selectVec"":[[0.253,-0.169,-0.079,-0.212,0.044],[0.248,-0.208,-0.066,-0.244,0.057],[0.252,-0.179,-0.065,-0.232,0.066],[0.255,0.002,0.21,0.084,0.116],[0.206,-0.34,0.047,0.559,0.083],[0.255,0.097,-0.204,-0.026,0.081],[0.251,-0.184,-0.074,-0.243,0.071],[0.251,-0.189,-0.063,-0.222,0.039],[0.252,-0.18,-0.063,-0.217,0.05],[0.255,0.02,0.211,0.083,0.127],[0.214,-0.313,0.056,0.544,0.07],[0.244,-0.051,0.131,0.013,-0.956],[0.219,0.283,0.381,-0.037,0.071],[0.213,0.311,-0.381,0.145,-0.022],[0.219,0.306,0.345,-0.022,0.077],[0.214,0.311,-0.375,0.143,-0.02],[0.213,0.325,0.36,-0.025,0.081],[0.214,0.309,-0.374,0.142,-0.019]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":12309,""AfterCleanSamNum"":6427,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""闭市循环冷却水泵A运行"",""alarmcondition"":""[d1_10pgb60ap001xq01]>6""},""copy"":false,""principal"":""5"",""precision"":""99.5%"",""rate"":""0.992"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":424,""version"":""v-2025-12-04 15:49:06"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R18[0] = reconData[0][17];
	        OUT_B18[0] = errorData[0][17];
	        OUT_F18[0] = paraState[0][17];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[18] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18};
			float[] arrOUT_B = new float[18] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18};
			LD[] arrOUT_W = new LD[18] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18 };
			
	        if (!(Condition1>6))
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