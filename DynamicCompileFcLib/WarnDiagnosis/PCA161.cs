using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA161")]
    [FCDisplay("PCA161")]
    public partial class PCA161 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A前轴承温度2")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A中轴承温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A后轴承温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A前轴承温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A中轴承温度3")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A后轴承温度3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机前轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机后轴承温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机U相绕组温度1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机V相绕组温度1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机W相绕组温度1")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A前轴承温度1")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A中轴承温度1")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A后轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机前轴承温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机后轴承温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机U相绕组温度2")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机V相绕组温度2")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机A电机W相绕组温度2")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出19")]
	    public LA OUT_R19 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出19")]
	    public LA OUT_B19 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出19")]
	    public LD OUT_F19 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出19")]
	    public LD OUT_W19 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[19] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[19] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[19] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA161()
		{
			ModelID = 173;
			SysID = 29;
			FcType = enumType.Warn;
			FcName = "PCA161";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""173"",""name"":""PCA161"",""description"":""引风机A本体温度"",""founder"":""admin"",""creatTime"":""2023-11-09 15:01:42"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 14:49:14"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-25 20:37:22"",""duration"":1130116,""number"":3768,""filter"":108,""mode"":3660,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-27 20:13:54"",""et"":""2025-12-04 18:07:08"",""duration"":597194,""number"":1991,""filter"":97,""mode"":1894,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":7}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hnc40ct112r"",""Description"":""引风机A前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.61"",""lowerBound"":""-0.61"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""55.86"",""TMin"":""48.62"",""TAvg"":""51.62"",""DMax"":""0.10"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.09""},{""PointId"":""d1_10hnc40ct115r"",""Description"":""引风机A中轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.33"",""lowerBound"":""-0.33"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""53.78"",""TMin"":""47.03"",""TAvg"":""49.92"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.14""},{""PointId"":""d1_10hnc40ct118r"",""Description"":""引风机A后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.36"",""lowerBound"":""-0.36"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""52.04"",""TMin"":""44.09"",""TAvg"":""48.16"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.10"",""C99"":""0.12""},{""PointId"":""d1_10hnc40ct113r"",""Description"":""引风机A前轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""55.53"",""TMin"":""48.07"",""TAvg"":""51.17"",""DMax"":""0.16"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10hnc40ct116r"",""Description"":""引风机A中轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""52.42"",""TMin"":""45.03"",""TAvg"":""48.28"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.31""},{""PointId"":""d1_10hnc40ct119r"",""Description"":""引风机A后轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.50"",""lowerBound"":""-0.50"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""52.14"",""TMin"":""44.61"",""TAvg"":""48.75"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.18""},{""PointId"":""d1_10hnc40ct101r"",""Description"":""引风机A电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""52.85"",""TMin"":""46.80"",""TAvg"":""48.97"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hnc40ct103r"",""Description"":""引风机A电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.28"",""lowerBound"":""-0.28"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""48.24"",""TMin"":""41.71"",""TAvg"":""44.03"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.23""},{""PointId"":""d1_10hnc40ct105r"",""Description"":""引风机A电机U相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.98"",""lowerBound"":""-0.98"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""76.98"",""TMin"":""36.58"",""TAvg"":""49.89"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10hnc40ct107r"",""Description"":""引风机A电机V相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.00"",""lowerBound"":""-1.00"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""77.30"",""TMin"":""36.61"",""TAvg"":""50.02"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.18""},{""PointId"":""d1_10hnc40ct109r"",""Description"":""引风机A电机W相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.92"",""lowerBound"":""-0.92"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""79.50"",""TMin"":""37.80"",""TAvg"":""51.45"",""DMax"":""0.81"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.45""},{""PointId"":""d1_10hnc40ct111r"",""Description"":""引风机A前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""56.39"",""TMin"":""49.18"",""TAvg"":""52.16"",""DMax"":""0.12"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.10"",""C99"":""0.12""},{""PointId"":""d1_10hnc40ct114r"",""Description"":""引风机A中轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""53.64"",""TMin"":""46.78"",""TAvg"":""49.70"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.18""},{""PointId"":""d1_10hnc40ct117r"",""Description"":""引风机A后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""50.98"",""TMin"":""42.96"",""TAvg"":""47.03"",""DMax"":""0.11"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_10hnc40ct102r"",""Description"":""引风机A电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""58.79"",""TMin"":""53.54"",""TAvg"":""55.50"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.29"",""C99"":""0.35""},{""PointId"":""d1_10hnc40ct104r"",""Description"":""引风机A电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.29"",""lowerBound"":""-0.29"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""55.07"",""TMin"":""49.08"",""TAvg"":""51.30"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.22""},{""PointId"":""d1_10hnc40ct106r"",""Description"":""引风机A电机U相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.96"",""lowerBound"":""-0.96"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""74.28"",""TMin"":""34.38"",""TAvg"":""47.55"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.26""},{""PointId"":""d1_10hnc40ct108r"",""Description"":""引风机A电机V相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.99"",""lowerBound"":""-0.99"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""79.69"",""TMin"":""38.70"",""TAvg"":""52.24"",""DMax"":""0.27"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.28""},{""PointId"":""d1_10hnc40ct110r"",""Description"":""引风机A电机W相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.92"",""lowerBound"":""-0.92"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""77.49"",""TMin"":""36.95"",""TAvg"":""50.33"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 14:49:14"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[48.621,47.032,44.087,48.068,45.032,44.613,46.797,41.707,36.575,36.613,37.801,49.179,46.778,42.957,53.535,49.082,34.379,38.702,36.953],""Train_X_max"":[55.864,53.782,52.042,55.527,52.419,52.143,52.853,48.244,76.984,77.304,79.5,56.392,53.637,50.984,58.787,55.07,74.28,79.693,77.492],""Train_X_std"":[1.337,1.219,1.463,1.397,1.356,1.479,0.857,0.899,8.162,8.235,8.494,1.316,1.251,1.468,0.81,0.873,8.109,8.26,8.232],""Train_X_mean"":[51.616,49.915,48.159,51.174,48.275,48.745,48.972,44.03,49.893,50.017,51.454,52.158,49.699,47.031,55.497,51.298,47.552,52.244,50.333],""Train_X_bais_max"":[[0.1,0.142,0.144,0.159,0.282,0.208,0.236,0.244,0.672,0.291,0.81,0.117,0.207,0.108,0.348,0.192,0.214,0.266,0.243]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.022,0.033,0.028,0.045,0.074,0.041,0.054,0.053,0.094,0.038,0.097,0.027,0.042,0.024,0.082,0.053,0.064,0.069,0.035]],""QCUL_95"":0.14881283,""QCUL_99"":0.2647214,""QCUL_95_line"":[0.077,0.115,0.097,0.152,0.255,0.146,0.183,0.185,0.36,0.142,0.362,0.095,0.145,0.082,0.289,0.182,0.212,0.23,0.128],""QCUL_99_line"":[0.094,0.141,0.118,0.186,0.312,0.18,0.224,0.227,0.444,0.175,0.445,0.117,0.178,0.101,0.354,0.223,0.26,0.281,0.157],""T2CUL_95"":9.501,""T2CUL_99"":13.299,""T2CUL_95_line"":[0.055,0.05,0.06,0.057,0.056,0.061,0.035,0.037,0.335,0.338,0.348,0.054,0.051,0.06,0.033,0.036,0.332,0.339,0.338],""T2CUL_99_line"":[0.065,0.059,0.071,0.068,0.066,0.072,0.042,0.044,0.396,0.4,0.412,0.064,0.061,0.071,0.039,0.042,0.393,0.401,0.399],""Kesi_95"":1.587,""Kesi_99"":1.363,""Kesi_95_line"":[0.022,0.02,0.025,0.023,0.023,0.025,0.014,0.015,0.137,0.138,0.142,0.022,0.021,0.025,0.014,0.015,0.136,0.138,0.138],""Kesi_99_line"":[0.021,0.019,0.023,0.022,0.021,0.023,0.013,0.014,0.127,0.128,0.132,0.02,0.019,0.023,0.013,0.014,0.126,0.128,0.128],""COV"":[[1.0,0.99,0.871,0.997,0.977,0.845,0.932,0.901,0.824,0.824,0.812,0.999,0.989,0.87,0.956,0.928,0.826,0.824,0.821],[0.99,1.0,0.923,0.993,0.994,0.896,0.945,0.928,0.761,0.762,0.747,0.985,1.0,0.923,0.961,0.951,0.764,0.762,0.759],[0.871,0.923,1.0,0.894,0.94,0.993,0.83,0.837,0.506,0.507,0.485,0.854,0.924,1.0,0.844,0.863,0.509,0.506,0.501],[0.997,0.993,0.894,1.0,0.988,0.872,0.929,0.903,0.812,0.813,0.799,0.994,0.993,0.893,0.953,0.932,0.814,0.812,0.81],[0.977,0.994,0.94,0.988,1.0,0.919,0.931,0.921,0.75,0.752,0.736,0.969,0.995,0.941,0.947,0.946,0.753,0.751,0.748],[0.845,0.896,0.993,0.872,0.919,1.0,0.776,0.777,0.489,0.489,0.466,0.826,0.898,0.992,0.801,0.812,0.492,0.489,0.484],[0.932,0.945,0.83,0.929,0.931,0.776,1.0,0.985,0.749,0.749,0.738,0.931,0.944,0.833,0.992,0.985,0.75,0.749,0.746],[0.901,0.928,0.837,0.903,0.921,0.777,0.985,1.0,0.684,0.686,0.674,0.898,0.928,0.842,0.961,0.995,0.687,0.685,0.683],[0.824,0.761,0.506,0.812,0.75,0.489,0.749,0.684,1.0,1.0,0.999,0.836,0.763,0.505,0.789,0.721,1.0,1.0,1.0],[0.824,0.762,0.507,0.813,0.752,0.489,0.749,0.686,1.0,1.0,1.0,0.836,0.764,0.506,0.789,0.723,1.0,1.0,1.0],[0.812,0.747,0.485,0.799,0.736,0.466,0.738,0.674,0.999,1.0,1.0,0.825,0.749,0.484,0.776,0.71,1.0,1.0,1.0],[0.999,0.985,0.854,0.994,0.969,0.826,0.931,0.898,0.836,0.836,0.825,1.0,0.984,0.853,0.954,0.925,0.837,0.836,0.833],[0.989,1.0,0.924,0.993,0.995,0.898,0.944,0.928,0.763,0.764,0.749,0.984,1.0,0.923,0.96,0.952,0.765,0.763,0.76],[0.87,0.923,1.0,0.893,0.941,0.992,0.833,0.842,0.505,0.506,0.484,0.853,0.923,1.0,0.845,0.866,0.508,0.505,0.5],[0.956,0.961,0.844,0.953,0.947,0.801,0.992,0.961,0.789,0.789,0.776,0.954,0.96,0.845,1.0,0.974,0.79,0.789,0.786],[0.928,0.951,0.863,0.932,0.946,0.812,0.985,0.995,0.721,0.723,0.71,0.925,0.952,0.866,0.974,1.0,0.724,0.722,0.72],[0.826,0.764,0.509,0.814,0.753,0.492,0.75,0.687,1.0,1.0,1.0,0.837,0.765,0.508,0.79,0.724,1.0,1.0,1.0],[0.824,0.762,0.506,0.812,0.751,0.489,0.749,0.685,1.0,1.0,1.0,0.836,0.763,0.505,0.789,0.722,1.0,1.0,1.0],[0.821,0.759,0.501,0.81,0.748,0.484,0.746,0.683,1.0,1.0,1.0,0.833,0.76,0.5,0.786,0.72,1.0,1.0,1.0]],""K"":4,""R"":0.997,""featValue"":[16.022,2.43,0.415,0.089,0.034,0.005,0.004,0.003,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.247,0.042,0.069,0.45,0.011,0.227,0.125,-0.078,-0.051,0.038,-0.415,-0.163,-0.025,0.05,0.635,-0.203,0.083,-0.012,-0.005],[0.245,0.116,0.038,0.24,-0.084,-0.066,-0.279,0.441,0.106,-0.145,-0.163,-0.323,-0.535,-0.127,-0.325,0.043,0.1,-0.018,0.015],[0.213,0.319,0.237,-0.228,0.05,0.12,0.25,0.2,0.251,-0.049,0.091,-0.169,0.116,0.118,0.217,0.668,-0.046,-0.004,0.018],[0.247,0.062,0.109,0.283,-0.078,-0.171,0.176,-0.587,0.109,-0.336,0.296,0.23,-0.357,-0.12,-0.026,0.134,-0.075,0.025,0.012],[0.244,0.13,0.098,-0.035,-0.224,-0.674,-0.228,-0.265,0.088,0.288,-0.181,-0.253,0.289,0.118,-0.025,0.004,0.022,-0.008,-0.002],[0.206,0.318,0.4,-0.309,0.15,0.174,-0.12,-0.18,-0.601,0.065,-0.243,0.149,-0.145,0.013,-0.17,-0.033,-0.066,0.005,-0.012],[0.237,0.081,-0.431,-0.035,0.376,-0.31,0.358,0.13,-0.424,0.032,0.291,-0.28,-0.097,0.039,0.074,-0.083,-0.018,-0.004,0.002],[0.23,0.13,-0.503,-0.17,-0.395,-0.035,0.265,0.101,-0.001,-0.154,-0.441,0.412,0.005,0.091,-0.103,0.061,-0.003,0.008,-0.003],[0.217,-0.315,0.08,-0.106,0.05,0.062,-0.057,-0.015,0.012,-0.559,-0.077,-0.254,0.213,0.33,-0.109,-0.148,-0.374,0.121,-0.316],[0.217,-0.315,0.078,-0.118,-0.021,-0.015,0.034,0.032,-0.048,0.128,0.056,0.104,-0.035,-0.157,0.045,0.115,0.542,0.364,-0.575],[0.214,-0.328,0.064,-0.094,-0.044,0.001,0.131,0.093,0.103,0.433,-0.059,0.048,-0.179,-0.321,0.047,0.003,-0.628,0.257,0.068],[0.247,0.024,0.049,0.509,-0.009,0.272,0.241,0.016,-0.058,0.268,0.094,0.014,0.397,0.091,-0.54,0.047,0.015,-0.014,-0.01],[0.245,0.115,0.042,0.206,-0.123,-0.116,-0.421,0.391,-0.198,-0.103,0.364,0.432,0.224,-0.012,0.284,-0.02,-0.152,0.036,-0.009],[0.213,0.32,0.222,-0.257,0.009,0.021,0.254,0.134,0.396,-0.027,0.175,0.054,0.062,-0.128,-0.037,-0.655,0.11,-0.008,-0.006],[0.242,0.059,-0.287,-0.01,0.694,0.059,-0.344,-0.145,0.36,0.048,-0.185,0.226,0.07,-0.045,-0.053,0.067,0.01,0.001,-0.002],[0.236,0.118,-0.384,-0.207,-0.335,0.47,-0.326,-0.286,-0.008,0.117,0.297,-0.323,0.001,-0.096,0.057,-0.03,0.002,-0.005,0.0],[0.217,-0.313,0.08,-0.113,-0.011,0.05,-0.038,0.02,0.064,0.155,0.136,0.119,-0.242,0.649,0.013,-0.062,0.218,0.139,0.469],[0.217,-0.315,0.078,-0.114,0.016,-0.014,0.022,0.003,-0.129,-0.312,-0.089,-0.092,0.313,-0.485,-0.022,0.062,0.244,-0.009,0.553],[0.217,-0.318,0.074,-0.109,-0.022,0.0,0.026,0.034,0.011,0.112,0.039,0.086,-0.079,-0.008,0.034,0.026,0.008,-0.874,-0.196]],""selectVec"":[[0.247,0.042,0.069,0.45],[0.245,0.116,0.038,0.24],[0.213,0.319,0.237,-0.228],[0.247,0.062,0.109,0.283],[0.244,0.13,0.098,-0.035],[0.206,0.318,0.4,-0.309],[0.237,0.081,-0.431,-0.035],[0.23,0.13,-0.503,-0.17],[0.217,-0.315,0.08,-0.106],[0.217,-0.315,0.078,-0.118],[0.214,-0.328,0.064,-0.094],[0.247,0.024,0.049,0.509],[0.245,0.115,0.042,0.206],[0.213,0.32,0.222,-0.257],[0.242,0.059,-0.287,-0.01],[0.236,0.118,-0.384,-0.207],[0.217,-0.313,0.08,-0.113],[0.217,-0.315,0.078,-0.114],[0.217,-0.318,0.074,-0.109]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5759,""AfterCleanSamNum"":5651,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""引风机A运行"",""alarmcondition"":""[d1_10hnc40an001xq01]>40""},""copy"":false,""principal"":""4"",""precision"":""99.7%"",""rate"":""0.993"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":173,""version"":""v-2025-12-08 14:49:14"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R19[0] = reconData[0][18];
	        OUT_B19[0] = errorData[0][18];
	        OUT_F19[0] = paraState[0][18];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[19] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18,IN19};
			float[] arrOUT_B = new float[19] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18,OUT_B19};
			LD[] arrOUT_W = new LD[19] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18,OUT_W19 };
			
	        if (!(Condition1>40))
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