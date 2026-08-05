using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA162")]
    [FCDisplay("PCA162")]
    public partial class PCA162 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B前轴承温度2")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B中轴承温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B后轴承温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B前轴承温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B中轴承温度3")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B后轴承温度3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机前轴承温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机后轴承温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机U相绕组温度1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机V相绕组温度1")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机W相绕组温度1")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B前轴承温度1")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B中轴承温度1")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B后轴承温度1")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机前轴承温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机后轴承温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机U相绕组温度2")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机V相绕组温度2")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B电机W相绕组温度2")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("引风机B液压润滑油站油箱油温")]
	    public LAExWarn IN20 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出20")]
	    public LA OUT_R20 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出20")]
	    public LA OUT_B20 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出20")]
	    public LD OUT_F20 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出20")]
	    public LD OUT_W20 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[20] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[20] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[20] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA162()
		{
			ModelID = 174;
			SysID = 29;
			FcType = enumType.Warn;
			FcName = "PCA162";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""174"",""name"":""PCA162"",""description"":""引风机B本体温度"",""founder"":""admin"",""creatTime"":""2023-11-09 15:27:45"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 14:54:20"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-08 11:18:04"",""et"":""2025-11-12 03:49:26"",""duration"":318682,""number"":1063,""filter"":92,""mode"":971,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-12 16:28:12"",""et"":""2025-11-25 22:51:16"",""duration"":1146184,""number"":3821,""filter"":90,""mode"":3731,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 21:54:54"",""et"":""2025-12-04 22:34:56"",""duration"":693602,""number"":2313,""filter"":90,""mode"":2223,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":3,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hnc50ct112r"",""Description"":""引风机B前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""54.64"",""TMin"":""46.43"",""TAvg"":""50.31"",""DMax"":""0.42"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hnc50ct115r"",""Description"":""引风机B中轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""52.96"",""TMin"":""44.06"",""TAvg"":""48.61"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.17"",""C99"":""0.20""},{""PointId"":""d1_10hnc50ct118r"",""Description"":""引风机B后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.21"",""lowerBound"":""-0.21"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""52.26"",""TMin"":""43.26"",""TAvg"":""48.04"",""DMax"":""0.38"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.17"",""C99"":""0.21""},{""PointId"":""d1_10hnc50ct113r"",""Description"":""引风机B前轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""51.52"",""TMin"":""42.35"",""TAvg"":""46.88"",""DMax"":""0.43"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10hnc50ct116r"",""Description"":""引风机B中轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.76"",""lowerBound"":""-0.76"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""49.34"",""TMin"":""38.59"",""TAvg"":""44.49"",""DMax"":""0.88"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.62"",""C99"":""0.76""},{""PointId"":""d1_10hnc50ct119r"",""Description"":""引风机B后轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""51.33"",""TMin"":""41.33"",""TAvg"":""46.70"",""DMax"":""0.48"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hnc50ct101r"",""Description"":""引风机B电机前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""64.04"",""TMin"":""53.56"",""TAvg"":""57.47"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hnc50ct103r"",""Description"":""引风机B电机后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""55.77"",""TMin"":""49.97"",""TAvg"":""52.59"",""DMax"":""0.42"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.28"",""C99"":""0.35""},{""PointId"":""d1_10hnc50ct105r"",""Description"":""引风机B电机U相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""76.77"",""TMin"":""36.59"",""TAvg"":""50.08"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10hnc50ct107r"",""Description"":""引风机B电机V相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""79.31"",""TMin"":""38.55"",""TAvg"":""52.22"",""DMax"":""0.39"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.22"",""C99"":""0.27""},{""PointId"":""d1_10hnc50ct109r"",""Description"":""引风机B电机W相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""75.05"",""TMin"":""35.84"",""TAvg"":""49.06"",""DMax"":""0.31"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10hnc50ct111r"",""Description"":""引风机B前轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.41"",""lowerBound"":""-0.41"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""54.74"",""TMin"":""46.40"",""TAvg"":""50.35"",""DMax"":""0.44"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.41""},{""PointId"":""d1_10hnc50ct114r"",""Description"":""引风机B中轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""52.55"",""TMin"":""43.46"",""TAvg"":""48.11"",""DMax"":""0.22"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.23""},{""PointId"":""d1_10hnc50ct117r"",""Description"":""引风机B后轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.21"",""lowerBound"":""-0.21"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""52.31"",""TMin"":""43.78"",""TAvg"":""48.27"",""DMax"":""0.37"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.17"",""C99"":""0.21""},{""PointId"":""d1_10hnc50ct102r"",""Description"":""引风机B电机前轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.14"",""lowerBound"":""-0.14"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""59.34"",""TMin"":""47.79"",""TAvg"":""52.24"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.14""},{""PointId"":""d1_10hnc50ct104r"",""Description"":""引风机B电机后轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.25"",""lowerBound"":""-0.25"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""50.98"",""TMin"":""44.70"",""TAvg"":""47.41"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.25""},{""PointId"":""d1_10hnc50ct106r"",""Description"":""引风机B电机U相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.32"",""lowerBound"":""-0.32"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""76.59"",""TMin"":""36.78"",""TAvg"":""50.22"",""DMax"":""0.40"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10hnc50ct108r"",""Description"":""引风机B电机V相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""79.03"",""TMin"":""38.85"",""TAvg"":""52.41"",""DMax"":""0.38"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10hnc50ct110r"",""Description"":""引风机B电机W相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.56"",""lowerBound"":""-0.56"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""74.23"",""TMin"":""34.79"",""TAvg"":""48.05"",""DMax"":""0.60"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.56""},{""PointId"":""d1_10hnc51ct101r"",""Description"":""引风机B液压润滑油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.61"",""lowerBound"":""-0.61"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""44.96"",""TMin"":""36.66"",""TAvg"":""40.08"",""DMax"":""0.83"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.50"",""C99"":""0.61""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 14:54:20"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[46.434,44.06,43.262,42.351,38.588,41.327,53.557,49.972,36.587,38.551,35.835,46.401,43.46,43.783,47.788,44.699,36.777,38.85,34.787,36.661],""Train_X_max"":[54.638,52.964,52.259,51.516,49.337,51.329,64.035,55.767,76.774,79.309,75.054,54.741,52.545,52.309,59.339,50.976,76.588,79.034,74.234,44.964],""Train_X_std"":[1.538,1.582,1.656,1.766,1.839,1.861,2.259,1.071,8.078,8.16,7.878,1.584,1.644,1.557,2.518,1.094,7.958,8.037,7.981,1.313],""Train_X_mean"":[50.309,48.606,48.039,46.879,44.494,46.701,57.471,52.588,50.082,52.221,49.063,50.35,48.11,48.267,52.244,47.409,50.216,52.41,48.049,40.078],""Train_X_bais_max"":[[0.416,0.194,0.375,0.43,0.881,0.475,0.187,0.42,0.294,0.391,0.306,0.435,0.223,0.366,0.151,0.351,0.402,0.381,0.601,0.828]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.089,0.048,0.05,0.103,0.176,0.09,0.038,0.082,0.073,0.065,0.076,0.099,0.053,0.049,0.033,0.06,0.074,0.072,0.131,0.145]],""QCUL_95"":0.2163482,""QCUL_99"":0.351357043,""QCUL_95_line"":[0.304,0.166,0.174,0.356,0.616,0.312,0.132,0.283,0.25,0.223,0.261,0.335,0.184,0.172,0.116,0.206,0.258,0.253,0.459,0.497],""QCUL_99_line"":[0.372,0.203,0.214,0.437,0.755,0.381,0.162,0.346,0.306,0.273,0.32,0.409,0.226,0.211,0.142,0.252,0.317,0.31,0.562,0.608],""T2CUL_95"":11.085,""T2CUL_99"":15.11,""T2CUL_95_line"":[0.061,0.062,0.065,0.07,0.073,0.073,0.089,0.042,0.319,0.322,0.311,0.063,0.065,0.062,0.099,0.043,0.314,0.317,0.315,0.052],""T2CUL_99_line"":[0.071,0.073,0.076,0.081,0.085,0.086,0.104,0.049,0.373,0.376,0.363,0.073,0.076,0.072,0.116,0.05,0.367,0.371,0.368,0.061],""Kesi_95"":1.609,""Kesi_99"":1.424,""Kesi_95_line"":[0.023,0.024,0.025,0.027,0.028,0.028,0.034,0.016,0.122,0.123,0.119,0.024,0.025,0.023,0.038,0.016,0.12,0.121,0.12,0.02],""Kesi_99_line"":[0.022,0.022,0.023,0.025,0.026,0.026,0.032,0.015,0.114,0.116,0.112,0.022,0.023,0.022,0.036,0.015,0.113,0.114,0.113,0.019],""COV"":[[1.0,0.996,0.943,0.985,0.976,0.921,0.912,0.941,0.851,0.847,0.855,1.0,0.997,0.945,0.906,0.934,0.854,0.85,0.854,0.91],[0.996,1.0,0.933,0.98,0.985,0.909,0.911,0.936,0.857,0.854,0.861,0.996,1.0,0.935,0.905,0.93,0.86,0.856,0.86,0.91],[0.943,0.933,1.0,0.974,0.948,0.995,0.888,0.945,0.665,0.659,0.671,0.943,0.934,1.0,0.886,0.938,0.67,0.663,0.669,0.925],[0.985,0.98,0.974,1.0,0.986,0.967,0.923,0.959,0.79,0.785,0.795,0.984,0.98,0.975,0.92,0.953,0.794,0.789,0.794,0.941],[0.976,0.985,0.948,0.986,1.0,0.936,0.922,0.94,0.801,0.797,0.806,0.975,0.983,0.95,0.92,0.935,0.805,0.799,0.805,0.93],[0.921,0.909,0.995,0.967,0.936,1.0,0.876,0.929,0.64,0.634,0.647,0.921,0.911,0.993,0.874,0.919,0.646,0.638,0.644,0.91],[0.912,0.911,0.888,0.923,0.922,0.876,1.0,0.922,0.766,0.763,0.77,0.908,0.908,0.89,0.999,0.922,0.77,0.766,0.767,0.904],[0.941,0.936,0.945,0.959,0.94,0.929,0.922,1.0,0.745,0.741,0.75,0.938,0.933,0.947,0.92,0.998,0.75,0.744,0.748,0.964],[0.851,0.857,0.665,0.79,0.801,0.64,0.766,0.745,1.0,1.0,1.0,0.852,0.858,0.666,0.755,0.733,1.0,1.0,1.0,0.691],[0.847,0.854,0.659,0.785,0.797,0.634,0.763,0.741,1.0,1.0,1.0,0.848,0.854,0.66,0.752,0.729,1.0,1.0,1.0,0.686],[0.855,0.861,0.671,0.795,0.806,0.647,0.77,0.75,1.0,1.0,1.0,0.856,0.862,0.672,0.759,0.738,1.0,1.0,1.0,0.696],[1.0,0.996,0.943,0.984,0.975,0.921,0.908,0.938,0.852,0.848,0.856,1.0,0.997,0.944,0.903,0.93,0.855,0.851,0.855,0.904],[0.997,1.0,0.934,0.98,0.983,0.911,0.908,0.933,0.858,0.854,0.862,0.997,1.0,0.936,0.902,0.926,0.861,0.857,0.861,0.904],[0.945,0.935,1.0,0.975,0.95,0.993,0.89,0.947,0.666,0.66,0.672,0.944,0.936,1.0,0.887,0.94,0.671,0.664,0.67,0.928],[0.906,0.905,0.886,0.92,0.92,0.874,0.999,0.92,0.755,0.752,0.759,0.903,0.902,0.887,1.0,0.92,0.76,0.755,0.757,0.905],[0.934,0.93,0.938,0.953,0.935,0.919,0.922,0.998,0.733,0.729,0.738,0.93,0.926,0.94,0.92,1.0,0.738,0.732,0.737,0.975],[0.854,0.86,0.67,0.794,0.805,0.646,0.77,0.75,1.0,1.0,1.0,0.855,0.861,0.671,0.76,0.738,1.0,1.0,1.0,0.695],[0.85,0.856,0.663,0.789,0.799,0.638,0.766,0.744,1.0,1.0,1.0,0.851,0.857,0.664,0.755,0.732,1.0,1.0,1.0,0.69],[0.854,0.86,0.669,0.794,0.805,0.644,0.767,0.748,1.0,1.0,1.0,0.855,0.861,0.67,0.757,0.737,1.0,1.0,1.0,0.696],[0.91,0.91,0.925,0.941,0.93,0.91,0.904,0.964,0.691,0.686,0.696,0.904,0.904,0.928,0.905,0.975,0.695,0.69,0.696,1.0]],""K"":5,""R"":0.996,""featValue"":[17.493,1.913,0.288,0.158,0.076,0.043,0.021,0.008,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.237,0.041,0.179,0.066,-0.203,-0.259,0.279,0.239,-0.213,0.144,0.061,0.09,0.193,0.146,0.24,-0.658,-0.16,-0.034,0.085,0.023],[0.236,0.029,0.162,0.065,-0.375,-0.139,-0.024,-0.23,0.309,-0.203,-0.153,0.089,-0.004,0.647,-0.222,0.173,-0.18,-0.015,-0.011,0.006],[0.221,0.252,0.218,0.086,0.289,0.003,0.147,-0.353,-0.156,0.002,-0.028,0.151,-0.234,0.071,0.645,0.269,-0.063,0.05,-0.014,0.004],[0.234,0.126,0.135,0.048,0.013,0.174,-0.095,0.698,-0.013,-0.359,-0.011,0.124,-0.483,0.011,-0.019,0.065,0.014,0.01,-0.007,0.002],[0.233,0.099,0.098,0.12,-0.378,0.359,-0.651,-0.125,-0.369,0.169,0.087,0.056,0.137,-0.072,0.044,-0.008,0.017,-0.001,0.002,0.001],[0.217,0.267,0.228,0.143,0.486,0.258,-0.123,0.167,0.373,0.089,-0.047,-0.257,0.478,0.113,-0.037,-0.065,0.009,-0.012,-0.016,0.005],[0.224,0.101,-0.527,0.381,0.023,-0.055,0.062,-0.024,0.132,-0.139,0.641,0.206,0.107,0.02,0.005,0.053,0.049,0.001,-0.014,0.009],[0.227,0.161,-0.158,-0.414,0.17,-0.38,-0.35,0.055,0.233,0.508,0.052,0.202,-0.253,0.035,-0.065,-0.044,-0.005,0.001,0.012,0.002],[0.212,-0.331,0.002,-0.03,0.089,0.049,0.006,-0.035,0.004,-0.024,-0.068,0.108,0.043,-0.004,-0.03,-0.05,0.132,0.597,-0.068,0.657],[0.212,-0.336,-0.004,-0.029,0.086,0.034,0.017,-0.038,-0.088,0.044,0.04,-0.142,-0.096,0.226,0.043,-0.129,0.422,-0.095,-0.669,-0.294],[0.213,-0.326,0.005,-0.03,0.099,0.053,-0.007,-0.014,0.03,-0.01,0.025,0.025,0.016,-0.248,-0.033,0.077,-0.668,-0.408,-0.322,0.219],[0.236,0.038,0.197,0.082,-0.18,-0.278,0.288,0.26,-0.201,0.308,0.013,-0.031,0.258,-0.183,-0.177,0.586,0.142,0.029,-0.068,-0.022],[0.236,0.027,0.186,0.088,-0.34,-0.157,-0.019,-0.173,0.493,-0.122,0.024,-0.316,-0.165,-0.524,0.159,-0.134,0.164,0.023,-0.003,-0.013],[0.222,0.251,0.212,0.073,0.248,-0.007,0.16,-0.355,-0.268,-0.101,0.042,0.087,-0.208,-0.176,-0.63,-0.232,0.061,-0.051,0.031,-0.005],[0.223,0.111,-0.549,0.379,-0.003,-0.022,0.035,0.016,-0.095,0.134,-0.639,-0.191,-0.112,-0.028,-0.01,-0.049,-0.049,-0.002,0.012,-0.008],[0.226,0.17,-0.207,-0.47,0.057,-0.297,-0.151,-0.017,-0.262,-0.555,-0.061,-0.226,0.315,-0.046,0.078,0.048,0.014,0.001,-0.016,-0.001],[0.213,-0.326,-0.001,-0.026,0.107,0.047,-0.002,-0.016,-0.061,0.043,0.145,-0.252,-0.085,0.007,-0.06,0.037,-0.361,0.493,0.264,-0.537],[0.212,-0.333,-0.006,-0.027,0.094,0.034,0.008,-0.024,-0.099,0.071,0.136,-0.344,-0.147,0.202,0.032,0.071,0.252,-0.442,0.542,0.245],[0.213,-0.327,0.008,-0.037,0.081,0.068,-0.006,-0.033,0.149,-0.139,-0.294,0.618,0.251,-0.199,0.04,-0.011,0.216,-0.147,0.257,-0.291],[0.22,0.202,-0.218,-0.49,-0.246,0.58,0.439,-0.041,0.101,0.142,0.029,-0.003,-0.003,0.0,-0.004,0.0,0.001,0.001,0.001,0.0]],""selectVec"":[[0.237,0.041,0.179,0.066,-0.203],[0.236,0.029,0.162,0.065,-0.375],[0.221,0.252,0.218,0.086,0.289],[0.234,0.126,0.135,0.048,0.013],[0.233,0.099,0.098,0.12,-0.378],[0.217,0.267,0.228,0.143,0.486],[0.224,0.101,-0.527,0.381,0.023],[0.227,0.161,-0.158,-0.414,0.17],[0.212,-0.331,0.002,-0.03,0.089],[0.212,-0.336,-0.004,-0.029,0.086],[0.213,-0.326,0.005,-0.03,0.099],[0.236,0.038,0.197,0.082,-0.18],[0.236,0.027,0.186,0.088,-0.34],[0.222,0.251,0.212,0.073,0.248],[0.223,0.111,-0.549,0.379,-0.003],[0.226,0.17,-0.207,-0.47,0.057],[0.213,-0.326,-0.001,-0.026,0.107],[0.212,-0.333,-0.006,-0.027,0.094],[0.213,-0.327,0.008,-0.037,0.081],[0.22,0.202,-0.218,-0.49,-0.246]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7195,""AfterCleanSamNum"":7103,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""引风机B运行"",""alarmcondition"":""[d1_10hnc50an001xq01]>60""},""copy"":false,""principal"":""5"",""precision"":""99.6%"",""rate"":""0.995"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":174,""version"":""v-2025-12-08 14:54:20"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R20[0] = reconData[0][19];
	        OUT_B20[0] = errorData[0][19];
	        OUT_F20[0] = paraState[0][19];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[20] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18,IN19,IN20};
			float[] arrOUT_B = new float[20] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18,OUT_B19,OUT_B20};
			LD[] arrOUT_W = new LD[20] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18,OUT_W19,OUT_W20 };
			
	        if (!(Condition1>60))
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