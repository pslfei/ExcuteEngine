using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA384Copy")]
    [FCDisplay("PCA384Copy")]
    public partial class PCA384Copy : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭市循环冷却水泵B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置导体温度反馈3")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置轴承温度反馈3")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置导体温度反馈2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置轴承温度反馈2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置导体温度反馈1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机永磁调速装置轴承温度反馈1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机定子U相温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机定子V相温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机定子W相温度1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机驱动端轴承温度")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B驱动端轴承温度1")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B非驱动端轴承温度1")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机定子U相温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机定子V相温度2")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机定子W相温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B电机非驱动端轴承温度")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B驱动端轴承温度2")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("闭式循环冷却水泵B非驱动端轴承温度2")]
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

		public PCA384Copy()
		{
			ModelID = 425;
			SysID = 11;
			FcType = enumType.Warn;
			FcName = "PCA384Copy";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""425"",""name"":""PCA384Copy"",""description"":""闭式循环冷却水泵B温度"",""founder"":""admin"",""creatTime"":""2025-10-24 09:47:47"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:51:27"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":"""",""trainTime"":[{""st"":""2025-11-04 14:18:54"",""et"":""2025-11-12 00:50:54"",""duration"":642720,""number"":2143,""filter"":97,""mode"":2046,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":7},{""st"":""2025-11-12 22:25:16"",""et"":""2025-11-26 03:19:04"",""duration"":1140828,""number"":3803,""filter"":98,""mode"":3705,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pgb60gf002xq03"",""Description"":""闭式循环冷却水泵B电机永磁调速装置导体温度反馈3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.28"",""lowerBound"":""-1.28"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""67.83"",""TMin"":""26.29"",""TAvg"":""43.08"",""DMax"":""5.93"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.02"",""C99"":""2.48""},{""PointId"":""d1_10pgb60gf002xq06"",""Description"":""闭式循环冷却水泵B电机永磁调速装置轴承温度反馈3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.89"",""lowerBound"":""-0.89"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""43.13"",""TMin"":""22.49"",""TAvg"":""31.38"",""DMax"":""3.70"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.63"",""C99"":""0.78""},{""PointId"":""d1_10pgb60gf002xq02"",""Description"":""闭式循环冷却水泵B电机永磁调速装置导体温度反馈2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.37"",""lowerBound"":""-1.37"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""68.92"",""TMin"":""25.62"",""TAvg"":""42.74"",""DMax"":""5.48"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.95"",""C99"":""2.38""},{""PointId"":""d1_10pgb60gf002xq05"",""Description"":""闭式循环冷却水泵B电机永磁调速装置轴承温度反馈2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.89"",""lowerBound"":""-0.89"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""44.45"",""TMin"":""23.09"",""TAvg"":""32.03"",""DMax"":""4.03"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.64"",""C99"":""0.79""},{""PointId"":""d1_10pgb60gf002xq01"",""Description"":""闭式循环冷却水泵B电机永磁调速装置导体温度反馈1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.36"",""lowerBound"":""-1.36"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""67.27"",""TMin"":""25.77"",""TAvg"":""42.17"",""DMax"":""5.75"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.92"",""C99"":""2.35""},{""PointId"":""d1_10pgb60gf002xq04"",""Description"":""闭式循环冷却水泵B电机永磁调速装置轴承温度反馈1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.91"",""lowerBound"":""-0.91"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""44.39"",""TMin"":""23.02"",""TAvg"":""32.06"",""DMax"":""3.84"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.63"",""C99"":""0.77""},{""PointId"":""d1_10pgb60ct120r"",""Description"":""闭式循环冷却水泵B电机定子U相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.24"",""lowerBound"":""-0.24"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""62.46"",""TMin"":""43.69"",""TAvg"":""54.25"",""DMax"":""1.27"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10pgb60ct122r"",""Description"":""闭式循环冷却水泵B电机定子V相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""62.91"",""TMin"":""44.00"",""TAvg"":""54.63"",""DMax"":""1.18"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.29"",""C99"":""0.35""},{""PointId"":""d1_10pgb60ct124r"",""Description"":""闭式循环冷却水泵B电机定子W相温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""61.87"",""TMin"":""43.18"",""TAvg"":""53.70"",""DMax"":""1.24"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10pgb60ct126r"",""Description"":""闭式循环冷却水泵B电机驱动端轴承温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.17"",""lowerBound"":""-1.17"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""40.43"",""TMin"":""24.10"",""TAvg"":""33.30"",""DMax"":""3.38"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.18"",""C99"":""1.46""},{""PointId"":""d1_10pgb60ct128r"",""Description"":""闭式循环冷却水泵B驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.80"",""lowerBound"":""-0.80"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""28.57"",""TMin"":""16.95"",""TAvg"":""22.54"",""DMax"":""1.35"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.62"",""C99"":""0.76""},{""PointId"":""d1_10pgb60ct130r"",""Description"":""闭式循环冷却水泵B非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.45"",""lowerBound"":""-0.45"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""32.44"",""TMin"":""22.90"",""TAvg"":""27.31"",""DMax"":""0.51"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10pgb60ct121r"",""Description"":""闭式循环冷却水泵B电机定子U相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""63.11"",""TMin"":""44.38"",""TAvg"":""54.91"",""DMax"":""1.14"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10pgb60ct123r"",""Description"":""闭式循环冷却水泵B电机定子V相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.19"",""lowerBound"":""-0.19"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""61.74"",""TMin"":""42.99"",""TAvg"":""53.54"",""DMax"":""1.10"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10pgb60ct125r"",""Description"":""闭式循环冷却水泵B电机定子W相温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.21"",""lowerBound"":""-0.21"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""62.42"",""TMin"":""43.70"",""TAvg"":""54.23"",""DMax"":""1.30"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10pgb60ct127r"",""Description"":""闭式循环冷却水泵B电机非驱动端轴承温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.07"",""lowerBound"":""-1.07"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""30.76"",""TMin"":""18.32"",""TAvg"":""25.66"",""DMax"":""0.90"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.66"",""C99"":""0.81""},{""PointId"":""d1_10pgb60ct129r"",""Description"":""闭式循环冷却水泵B驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.79"",""lowerBound"":""-0.79"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""30.13"",""TMin"":""18.06"",""TAvg"":""23.85"",""DMax"":""1.72"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.55"",""C99"":""0.67""},{""PointId"":""d1_10pgb60ct131r"",""Description"":""闭式循环冷却水泵B非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.50"",""lowerBound"":""-0.50"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""32.46"",""TMin"":""23.03"",""TAvg"":""27.34"",""DMax"":""0.55"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:51:27"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[26.287,22.493,25.623,23.089,25.767,23.02,43.688,44.002,43.178,24.103,16.947,22.898,44.375,42.992,43.702,18.315,18.059,23.026],""Train_X_max"":[67.829,43.132,68.915,44.447,67.269,44.388,62.456,62.914,61.866,40.426,28.569,32.437,63.113,61.741,62.417,30.764,30.132,32.463],""Train_X_std"":[11.666,4.334,12.424,4.472,11.966,4.53,4.239,4.289,4.235,2.747,2.181,1.705,4.23,4.239,4.251,2.701,2.218,1.739],""Train_X_mean"":[43.075,31.375,42.739,32.034,42.174,32.062,54.245,54.633,53.699,33.3,22.535,27.306,54.913,53.541,54.233,25.661,23.849,27.335],""Train_X_bais_max"":[[5.929,3.697,5.482,4.033,5.749,3.837,1.268,1.18,1.235,3.38,1.353,0.506,1.141,1.1,1.295,0.904,1.716,0.554]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.589,0.169,0.566,0.167,0.558,0.163,0.085,0.081,0.068,0.318,0.181,0.043,0.089,0.071,0.072,0.194,0.16,0.045]],""QCUL_95"":0.2051184,""QCUL_99"":0.326231033,""QCUL_95_line"":[2.024,0.634,1.945,0.64,1.916,0.625,0.302,0.288,0.249,1.182,0.618,0.154,0.315,0.257,0.26,0.663,0.549,0.16],""QCUL_99_line"":[2.478,0.781,2.381,0.789,2.345,0.771,0.371,0.353,0.306,1.455,0.756,0.188,0.387,0.316,0.319,0.811,0.672,0.196],""T2CUL_95"":7.823,""T2CUL_99"":11.361,""T2CUL_95_line"":[0.427,0.159,0.455,0.164,0.438,0.166,0.155,0.157,0.155,0.1,0.08,0.062,0.155,0.155,0.156,0.099,0.081,0.064],""T2CUL_99_line"":[0.514,0.191,0.548,0.197,0.528,0.2,0.187,0.189,0.187,0.121,0.096,0.075,0.187,0.187,0.187,0.119,0.098,0.077],""Kesi_95"":1.59,""Kesi_99"":1.4,""Kesi_95_line"":[0.192,0.071,0.205,0.074,0.197,0.075,0.07,0.071,0.07,0.045,0.036,0.028,0.07,0.07,0.07,0.045,0.037,0.029],""Kesi_99_line"":[0.181,0.067,0.192,0.069,0.185,0.07,0.066,0.066,0.066,0.043,0.034,0.026,0.065,0.066,0.066,0.042,0.034,0.027],""COV"":[[1.0,0.953,1.0,0.959,1.0,0.961,-0.466,-0.48,-0.477,0.607,0.465,0.415,-0.464,-0.474,-0.483,-0.058,0.572,0.4],[0.953,1.0,0.946,1.0,0.947,1.0,-0.205,-0.22,-0.216,0.792,0.686,0.604,-0.202,-0.214,-0.223,0.219,0.77,0.592],[1.0,0.946,1.0,0.953,1.0,0.955,-0.49,-0.503,-0.5,0.586,0.442,0.392,-0.487,-0.497,-0.506,-0.085,0.551,0.377],[0.959,1.0,0.953,1.0,0.954,1.0,-0.229,-0.244,-0.24,0.778,0.668,0.587,-0.226,-0.237,-0.247,0.195,0.754,0.574],[1.0,0.947,1.0,0.954,1.0,0.956,-0.487,-0.5,-0.497,0.588,0.444,0.394,-0.484,-0.495,-0.503,-0.082,0.553,0.38],[0.961,1.0,0.955,1.0,0.956,1.0,-0.235,-0.249,-0.246,0.775,0.663,0.583,-0.232,-0.243,-0.253,0.189,0.751,0.57],[-0.466,-0.205,-0.49,-0.229,-0.487,-0.235,1.0,1.0,1.0,0.402,0.554,0.549,1.0,1.0,1.0,0.904,0.447,0.564],[-0.48,-0.22,-0.503,-0.244,-0.5,-0.249,1.0,1.0,1.0,0.388,0.542,0.538,1.0,1.0,1.0,0.898,0.434,0.553],[-0.477,-0.216,-0.5,-0.24,-0.497,-0.246,1.0,1.0,1.0,0.391,0.545,0.541,1.0,1.0,1.0,0.9,0.437,0.555],[0.607,0.792,0.586,0.778,0.588,0.775,0.402,0.388,0.391,1.0,0.954,0.896,0.405,0.394,0.385,0.741,0.971,0.896],[0.465,0.686,0.442,0.668,0.444,0.663,0.554,0.542,0.545,0.954,1.0,0.949,0.557,0.547,0.539,0.84,0.992,0.949],[0.415,0.604,0.392,0.587,0.394,0.583,0.549,0.538,0.541,0.896,0.949,1.0,0.552,0.543,0.536,0.804,0.937,0.999],[-0.464,-0.202,-0.487,-0.226,-0.484,-0.232,1.0,1.0,1.0,0.405,0.557,0.552,1.0,1.0,1.0,0.906,0.45,0.566],[-0.474,-0.214,-0.497,-0.237,-0.495,-0.243,1.0,1.0,1.0,0.394,0.547,0.543,1.0,1.0,1.0,0.901,0.44,0.557],[-0.483,-0.223,-0.506,-0.247,-0.503,-0.253,1.0,1.0,1.0,0.385,0.539,0.536,1.0,1.0,1.0,0.897,0.431,0.55],[-0.058,0.219,-0.085,0.195,-0.082,0.189,0.904,0.898,0.9,0.741,0.84,0.804,0.906,0.901,0.897,1.0,0.77,0.815],[0.572,0.77,0.551,0.754,0.553,0.751,0.447,0.434,0.437,0.971,0.992,0.937,0.45,0.44,0.431,0.77,1.0,0.935],[0.4,0.592,0.377,0.574,0.38,0.57,0.564,0.553,0.555,0.896,0.949,0.999,0.566,0.557,0.55,0.815,0.935,1.0]],""K"":3,""R"":0.996,""featValue"":[9.357,8.348,0.222,0.039,0.015,0.013,0.009,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.056,0.34,-0.019,-0.126,-0.463,-0.031,0.09,0.008,0.167,-0.595,-0.074,-0.442,-0.202,-0.097,0.081,0.037,-0.031,0.006],[0.14,0.31,-0.217,0.165,0.207,0.313,-0.049,0.053,-0.005,0.138,-0.111,-0.423,0.502,0.025,0.005,-0.223,-0.389,0.005],[0.047,0.342,-0.017,-0.098,-0.43,-0.04,-0.009,0.04,-0.069,0.656,0.403,-0.121,-0.249,-0.018,-0.05,-0.064,-0.033,-0.012],[0.133,0.314,-0.216,0.15,0.195,0.331,-0.071,0.022,-0.03,-0.009,0.09,-0.068,0.008,0.023,-0.096,0.439,0.668,0.001],[0.048,0.342,-0.018,-0.106,-0.441,-0.03,0.031,-0.032,-0.004,0.015,-0.353,0.562,0.458,0.126,-0.036,0.032,0.064,0.007],[0.131,0.315,-0.213,0.137,0.186,0.327,-0.07,0.004,-0.005,-0.161,0.006,0.481,-0.522,-0.056,0.093,-0.217,-0.289,-0.006],[0.258,-0.212,-0.105,-0.007,-0.159,0.108,-0.118,0.042,0.024,-0.264,0.466,0.057,0.099,0.661,-0.273,-0.084,-0.072,0.037],[0.255,-0.216,-0.1,0.003,-0.152,0.096,-0.126,-0.01,-0.032,0.02,-0.079,0.029,-0.021,-0.311,-0.403,0.466,-0.339,-0.479],[0.255,-0.215,-0.102,0.013,-0.135,0.089,-0.092,0.038,0.021,0.147,-0.339,-0.123,-0.148,0.251,0.359,-0.3,0.277,-0.555],[0.283,0.161,-0.183,-0.757,0.356,-0.305,-0.255,-0.013,0.05,0.003,-0.009,-0.005,0.006,0.002,0.004,0.002,0.002,0.0],[0.309,0.108,-0.011,0.427,0.099,-0.482,-0.012,0.155,0.656,0.078,0.039,0.068,0.013,-0.014,0.001,0.041,-0.002,-0.001],[0.301,0.092,0.608,-0.013,0.064,0.202,-0.091,-0.671,0.155,0.034,0.034,-0.023,0.01,0.008,0.019,-0.014,0.002,-0.003],[0.258,-0.211,-0.103,-0.007,-0.168,0.107,-0.129,0.044,-0.028,-0.135,0.44,0.15,0.311,-0.517,0.436,-0.125,0.109,0.051],[0.256,-0.214,-0.103,0.009,-0.14,0.089,-0.102,0.006,0.032,0.063,-0.288,-0.065,-0.113,-0.263,-0.511,-0.413,0.242,0.419],[0.254,-0.217,-0.1,0.012,-0.138,0.09,-0.107,0.012,-0.031,0.173,-0.257,-0.065,-0.141,0.191,0.392,0.447,-0.214,0.531],[0.316,-0.079,-0.182,-0.125,0.087,0.018,0.901,-0.142,-0.02,0.051,0.044,0.028,0.002,-0.006,-0.006,0.008,0.0,-0.003],[0.294,0.148,-0.017,0.342,0.037,-0.492,-0.072,-0.169,-0.69,-0.126,-0.018,-0.052,-0.021,0.013,0.0,-0.036,0.009,-0.001],[0.303,0.086,0.6,-0.081,0.091,0.129,0.106,0.682,-0.169,-0.032,-0.037,0.021,-0.01,-0.008,-0.02,0.012,-0.001,0.003]],""selectVec"":[[0.056,0.34,-0.019],[0.14,0.31,-0.217],[0.047,0.342,-0.017],[0.133,0.314,-0.216],[0.048,0.342,-0.018],[0.131,0.315,-0.213],[0.258,-0.212,-0.105],[0.255,-0.216,-0.1],[0.255,-0.215,-0.102],[0.283,0.161,-0.183],[0.309,0.108,-0.011],[0.301,0.092,0.608],[0.258,-0.211,-0.103],[0.256,-0.214,-0.103],[0.254,-0.217,-0.1],[0.316,-0.079,-0.182],[0.294,0.148,-0.017],[0.303,0.086,0.6]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5946,""AfterCleanSamNum"":5843,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""闭市循环冷却水泵B运行"",""alarmcondition"":""[d1_10pgb60ap002xq01]>6""},""copy"":true,""principal"":""3"",""precision"":""99.6%"",""rate"":""0.992"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":425,""version"":""v-2025-12-04 15:51:27"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "]],\"Target_Data\":[[]]}";
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