using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA166")]
    [FCDisplay("PCA166")]
    public partial class PCA166 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B非驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B中轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B驱动端轴承温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机驱动端轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机非驱动端轴承温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机定子U相绕组温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机定子V相绕组温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机定子W相绕组温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B非驱动端轴承温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B中轴承温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B驱动端轴承温度3")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B出口温度")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机驱动端轴承温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机非驱动端轴承温度2")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机定子U相绕组温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机定子V相绕组温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B电机定子W相绕组温度2")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B非驱动端轴承温度3")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B中轴承温度3")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B驱动端轴承温度1")]
	    public LAExWarn IN20 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机B联合油站油箱油温")]
	    public LAExWarn IN21 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出21")]
	    public LA OUT_R21 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出21")]
	    public LA OUT_B21 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出21")]
	    public LD OUT_F21 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出21")]
	    public LD OUT_W21 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[21] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[21] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[21] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA166()
		{
			ModelID = 178;
			SysID = 31;
			FcType = enumType.Warn;
			FcName = "PCA166";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""178"",""name"":""PCA166"",""description"":""一次风机B本体温度"",""founder"":""admin"",""creatTime"":""2023-11-14 09:28:42"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 17:30:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-26 03:19:04"",""duration"":1154218,""number"":3848,""filter"":90,""mode"":3758,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 21:54:54"",""et"":""2025-12-04 21:05:40"",""duration"":688246,""number"":2295,""filter"":90,""mode"":2205,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hlb40ct101r"",""Description"":""一次风机B非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""53.01"",""TMin"":""46.30"",""TAvg"":""48.92"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.17"",""C99"":""0.20""},{""PointId"":""d1_10hlb40ct104r"",""Description"":""一次风机B中轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""54.72"",""TMin"":""47.76"",""TAvg"":""50.25"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.15""},{""PointId"":""d1_10hlb40ct108r"",""Description"":""一次风机B驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.18"",""lowerBound"":""-0.18"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""47.02"",""TMin"":""39.30"",""TAvg"":""42.21"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.18""},{""PointId"":""d1_10hlb40ct110r"",""Description"":""一次风机B电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.61"",""lowerBound"":""-1.61"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""40.08"",""TMin"":""15.14"",""TAvg"":""24.69"",""DMax"":""2.68"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.31"",""C99"":""1.61""},{""PointId"":""d1_10hlb40ct112r"",""Description"":""一次风机B电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.43"",""lowerBound"":""-1.43"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""32.21"",""TMin"":""11.47"",""TAvg"":""20.29"",""DMax"":""1.48"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.17"",""C99"":""1.43""},{""PointId"":""d1_10hlb40ct114r"",""Description"":""一次风机B电机定子U相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.81"",""lowerBound"":""-0.81"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""58.56"",""TMin"":""22.05"",""TAvg"":""36.61"",""DMax"":""0.90"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.66"",""C99"":""0.81""},{""PointId"":""d1_10hlb40ct116r"",""Description"":""一次风机B电机定子V相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.91"",""lowerBound"":""-0.91"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""59.94"",""TMin"":""22.66"",""TAvg"":""37.46"",""DMax"":""0.88"",""DMin"":""0.00"",""DAvg"":""0.22"",""C95"":""0.75"",""C99"":""0.91""},{""PointId"":""d1_10hlb40ct118r"",""Description"":""一次风机B电机定子W相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.83"",""lowerBound"":""-0.83"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""58.23"",""TMin"":""21.90"",""TAvg"":""36.39"",""DMax"":""0.92"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.68"",""C99"":""0.83""},{""PointId"":""d1_10hlb40ct102r"",""Description"":""一次风机B非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""53.07"",""TMin"":""46.30"",""TAvg"":""48.96"",""DMax"":""0.23"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hlb40ct105r"",""Description"":""一次风机B中轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""54.71"",""TMin"":""47.72"",""TAvg"":""50.24"",""DMax"":""0.17"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.12"",""C99"":""0.15""},{""PointId"":""d1_10hlb40ct109r"",""Description"":""一次风机B驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""47.32"",""TMin"":""39.61"",""TAvg"":""42.51"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hla40ct101r"",""Description"":""一次风机B出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""5.36"",""lowerBound"":""-5.36"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""33.15"",""TMin"":""3.50"",""TAvg"":""14.95"",""DMax"":""4.53"",""DMin"":""0.00"",""DAvg"":""1.27"",""C95"":""4.38"",""C99"":""5.36""},{""PointId"":""d1_10hlb40ct111r"",""Description"":""一次风机B电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.63"",""lowerBound"":""-1.63"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""40.36"",""TMin"":""15.22"",""TAvg"":""25.01"",""DMax"":""2.64"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.32"",""C99"":""1.63""},{""PointId"":""d1_10hlb40ct113r"",""Description"":""一次风机B电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.32"",""lowerBound"":""-1.32"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""32.28"",""TMin"":""11.29"",""TAvg"":""20.31"",""DMax"":""1.37"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.08"",""C99"":""1.32""},{""PointId"":""d1_10hlb40ct115r"",""Description"":""一次风机B电机定子U相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.81"",""lowerBound"":""-0.81"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""58.58"",""TMin"":""21.92"",""TAvg"":""36.53"",""DMax"":""0.87"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.66"",""C99"":""0.81""},{""PointId"":""d1_10hlb40ct117r"",""Description"":""一次风机B电机定子V相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.89"",""lowerBound"":""-0.89"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""59.14"",""TMin"":""22.51"",""TAvg"":""37.08"",""DMax"":""0.94"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.73"",""C99"":""0.89""},{""PointId"":""d1_10hlb40ct119r"",""Description"":""一次风机B电机定子W相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.86"",""lowerBound"":""-0.86"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""59.94"",""TMin"":""22.84"",""TAvg"":""37.58"",""DMax"":""0.84"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.70"",""C99"":""0.86""},{""PointId"":""d1_10hlb40ct103r"",""Description"":""一次风机B非驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""55.42"",""TMin"":""48.90"",""TAvg"":""51.36"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.19"",""C99"":""0.23""},{""PointId"":""d1_10hlb40ct106r"",""Description"":""一次风机B中轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""54.76"",""TMin"":""47.69"",""TAvg"":""50.24"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hlb40ct107r"",""Description"":""一次风机B驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.20"",""lowerBound"":""-0.20"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""46.44"",""TMin"":""38.60"",""TAvg"":""41.57"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10hlb41ct101r"",""Description"":""一次风机B联合油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":21,""type"":null,""TMax"":""47.03"",""TMin"":""40.14"",""TAvg"":""42.59"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.37""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 17:30:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[46.298,47.762,39.297,15.135,11.466,22.046,22.663,21.898,46.298,47.715,39.611,3.503,15.221,11.291,21.915,22.51,22.838,48.901,47.688,38.602,40.136],""Train_X_max"":[53.012,54.718,47.018,40.076,32.211,58.561,59.939,58.229,53.071,54.709,47.324,33.147,40.356,32.283,58.579,59.144,59.935,55.422,54.761,46.439,47.034],""Train_X_std"":[1.016,0.866,1.308,5.126,4.622,8.003,8.176,7.952,1.039,0.878,1.32,6.014,5.153,4.67,8.038,8.03,8.155,0.906,0.887,1.328,1.028],""Train_X_mean"":[48.915,50.249,42.212,24.689,20.289,36.608,37.463,36.394,48.957,50.244,42.514,14.947,25.007,20.314,36.531,37.076,37.581,51.357,50.235,41.573,42.585],""Train_X_bais_max"":[[0.238,0.182,0.239,2.68,1.484,0.903,0.883,0.922,0.234,0.166,0.25,4.528,2.635,1.371,0.867,0.936,0.843,0.245,0.191,0.261,0.673]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.048,0.036,0.042,0.37,0.342,0.189,0.215,0.196,0.047,0.035,0.047,1.273,0.375,0.316,0.189,0.209,0.201,0.055,0.038,0.047,0.083]],""QCUL_95"":0.455920041,""QCUL_99"":0.8038391,""QCUL_95_line"":[0.167,0.125,0.147,1.312,1.168,0.658,0.745,0.68,0.164,0.12,0.164,4.377,1.324,1.078,0.658,0.729,0.699,0.191,0.131,0.163,0.299],""QCUL_99_line"":[0.204,0.153,0.18,1.61,1.429,0.807,0.913,0.833,0.201,0.147,0.201,5.358,1.625,1.319,0.807,0.893,0.857,0.234,0.16,0.199,0.368],""T2CUL_95"":7.823,""T2CUL_99"":11.36,""T2CUL_95_line"":[0.037,0.031,0.047,0.184,0.166,0.288,0.294,0.286,0.037,0.032,0.047,0.216,0.185,0.168,0.289,0.289,0.293,0.033,0.032,0.048,0.037],""T2CUL_99_line"":[0.044,0.038,0.057,0.222,0.2,0.347,0.354,0.345,0.045,0.038,0.057,0.261,0.223,0.202,0.348,0.348,0.353,0.039,0.038,0.058,0.045],""Kesi_95"":1.577,""Kesi_99"":1.358,""Kesi_95_line"":[0.016,0.014,0.021,0.083,0.075,0.129,0.132,0.128,0.017,0.014,0.021,0.097,0.083,0.075,0.13,0.13,0.132,0.015,0.014,0.021,0.017],""Kesi_99_line"":[0.015,0.013,0.02,0.077,0.069,0.12,0.122,0.119,0.016,0.013,0.02,0.09,0.077,0.07,0.12,0.12,0.122,0.014,0.013,0.02,0.015],""COV"":[[1.0,0.936,0.994,0.781,0.815,0.675,0.669,0.678,1.0,0.935,0.993,0.882,0.778,0.816,0.673,0.676,0.668,0.991,0.934,0.994,0.99],[0.936,1.0,0.909,0.717,0.716,0.727,0.726,0.729,0.932,1.0,0.907,0.767,0.719,0.72,0.726,0.728,0.724,0.965,1.0,0.91,0.944],[0.994,0.909,1.0,0.78,0.821,0.653,0.646,0.656,0.995,0.909,1.0,0.905,0.776,0.82,0.65,0.654,0.645,0.977,0.907,1.0,0.986],[0.781,0.717,0.78,1.0,0.99,0.931,0.926,0.932,0.784,0.725,0.786,0.879,1.0,0.992,0.93,0.931,0.926,0.743,0.725,0.774,0.745],[0.815,0.716,0.821,0.99,1.0,0.883,0.876,0.885,0.819,0.722,0.826,0.911,0.988,1.0,0.881,0.883,0.876,0.768,0.722,0.815,0.776],[0.675,0.727,0.653,0.931,0.883,1.0,1.0,1.0,0.676,0.738,0.659,0.768,0.936,0.89,1.0,1.0,1.0,0.666,0.738,0.648,0.649],[0.669,0.726,0.646,0.926,0.876,1.0,1.0,1.0,0.67,0.736,0.652,0.76,0.931,0.883,1.0,1.0,1.0,0.661,0.736,0.641,0.643],[0.678,0.729,0.656,0.932,0.885,1.0,1.0,1.0,0.679,0.739,0.662,0.771,0.938,0.891,1.0,1.0,1.0,0.669,0.74,0.651,0.652],[1.0,0.932,0.995,0.784,0.819,0.676,0.67,0.679,1.0,0.932,0.994,0.887,0.781,0.819,0.674,0.677,0.669,0.99,0.931,0.994,0.989],[0.935,1.0,0.909,0.725,0.722,0.738,0.736,0.739,0.932,1.0,0.906,0.771,0.727,0.727,0.736,0.738,0.734,0.964,1.0,0.909,0.942],[0.993,0.907,1.0,0.786,0.826,0.659,0.652,0.662,0.994,0.906,1.0,0.91,0.782,0.826,0.656,0.66,0.65,0.975,0.905,1.0,0.984],[0.882,0.767,0.905,0.879,0.911,0.768,0.76,0.771,0.887,0.771,0.91,1.0,0.874,0.912,0.765,0.768,0.759,0.831,0.77,0.902,0.845],[0.778,0.719,0.776,1.0,0.988,0.936,0.931,0.938,0.781,0.727,0.782,0.874,1.0,0.99,0.935,0.936,0.932,0.741,0.727,0.77,0.743],[0.816,0.72,0.82,0.992,1.0,0.89,0.883,0.891,0.819,0.727,0.826,0.912,0.99,1.0,0.888,0.889,0.883,0.77,0.727,0.815,0.776],[0.673,0.726,0.65,0.93,0.881,1.0,1.0,1.0,0.674,0.736,0.656,0.765,0.935,0.888,1.0,1.0,1.0,0.664,0.737,0.645,0.647],[0.676,0.728,0.654,0.931,0.883,1.0,1.0,1.0,0.677,0.738,0.66,0.768,0.936,0.889,1.0,1.0,1.0,0.667,0.739,0.649,0.65],[0.668,0.724,0.645,0.926,0.876,1.0,1.0,1.0,0.669,0.734,0.65,0.759,0.932,0.883,1.0,1.0,1.0,0.66,0.735,0.639,0.642],[0.991,0.965,0.977,0.743,0.768,0.666,0.661,0.669,0.99,0.964,0.975,0.831,0.741,0.77,0.664,0.667,0.66,1.0,0.963,0.977,0.99],[0.934,1.0,0.907,0.725,0.722,0.738,0.736,0.74,0.931,1.0,0.905,0.77,0.727,0.727,0.737,0.739,0.735,0.963,1.0,0.907,0.941],[0.994,0.91,1.0,0.774,0.815,0.648,0.641,0.651,0.994,0.909,1.0,0.902,0.77,0.815,0.645,0.649,0.639,0.977,0.907,1.0,0.986],[0.99,0.944,0.986,0.745,0.776,0.649,0.643,0.652,0.989,0.942,0.984,0.845,0.743,0.776,0.647,0.65,0.642,0.99,0.941,0.986,1.0]],""K"":3,""R"":0.993,""featValue"":[17.603,2.539,0.715,0.103,0.021,0.012,0.005,0.003,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.222,0.225,-0.048,0.063,0.141,-0.45,0.027,-0.046,-0.456,0.142,0.093,-0.235,0.052,0.548,-0.215,-0.041,0.16,0.0,-0.023,-0.006,-0.004],[-0.217,0.177,0.351,0.023,-0.347,0.094,0.008,-0.008,-0.07,0.367,-0.181,-0.505,-0.371,-0.27,-0.036,-0.097,-0.08,0.094,-0.064,-0.016,-0.004],[-0.22,0.232,-0.133,-0.06,0.125,0.15,-0.324,0.22,0.078,0.207,0.04,-0.035,0.183,0.166,0.09,0.237,-0.707,-0.086,-0.032,0.008,-0.017],[-0.223,-0.174,-0.233,0.265,-0.116,0.152,-0.223,-0.464,-0.065,0.136,-0.006,0.388,-0.482,0.226,0.063,-0.127,-0.101,0.08,0.02,-0.001,0.001],[-0.223,-0.12,-0.337,0.239,-0.276,-0.045,0.266,0.363,0.039,-0.091,0.091,0.077,-0.132,-0.151,-0.599,0.117,-0.105,-0.17,0.089,0.037,0.001],[-0.213,-0.269,0.139,-0.074,0.119,-0.031,-0.001,0.056,0.022,0.132,-0.102,0.0,-0.026,0.036,0.071,0.251,0.094,-0.092,0.375,-0.229,0.728],[-0.212,-0.272,0.154,-0.08,0.138,-0.03,-0.017,0.061,-0.001,-0.118,0.084,0.06,-0.002,-0.033,-0.127,-0.142,-0.085,0.029,-0.702,-0.507,0.084],[-0.214,-0.267,0.136,-0.08,0.113,-0.027,0.006,0.061,0.025,0.13,-0.133,0.048,-0.098,0.042,0.124,0.244,0.184,-0.462,-0.346,0.585,-0.085],[-0.222,0.223,-0.06,0.047,0.149,-0.45,0.017,-0.053,-0.361,-0.145,-0.154,0.28,-0.043,-0.575,0.239,0.045,-0.149,-0.012,0.026,0.005,0.003],[-0.218,0.169,0.35,0.011,-0.33,0.096,0.006,0.008,-0.091,-0.446,0.569,0.054,-0.1,0.113,0.223,0.27,0.029,-0.04,0.041,0.013,0.005],[-0.22,0.227,-0.142,-0.079,0.138,0.15,-0.329,0.21,0.082,0.373,0.424,0.168,0.058,-0.263,-0.04,-0.183,0.467,0.015,0.014,-0.009,0.008],[-0.219,0.037,-0.343,-0.81,-0.229,0.001,0.218,-0.271,0.036,-0.017,0.007,-0.022,0.003,0.005,-0.018,-0.008,-0.014,0.007,0.003,0.0,-0.001],[-0.223,-0.179,-0.217,0.267,-0.101,0.148,-0.23,-0.446,-0.076,-0.143,0.011,-0.395,0.491,-0.229,-0.044,0.134,0.105,-0.091,-0.032,-0.003,0.001],[-0.224,-0.123,-0.323,0.215,-0.253,-0.056,0.275,0.345,0.084,0.074,-0.076,-0.09,0.138,0.146,0.61,-0.148,0.105,0.202,-0.095,-0.041,-0.004],[-0.213,-0.271,0.143,-0.074,0.12,-0.03,-0.002,0.051,0.021,0.129,-0.102,0.044,-0.014,0.013,0.008,0.368,0.127,0.124,0.297,-0.352,-0.654],[-0.213,-0.269,0.14,-0.074,0.151,-0.028,-0.039,0.068,0.0,-0.178,0.126,-0.152,0.002,0.0,0.069,-0.661,-0.201,-0.348,0.361,0.043,-0.147],[-0.212,-0.274,0.152,-0.07,0.144,-0.034,-0.027,0.05,-0.004,-0.072,0.094,0.009,0.104,-0.047,-0.17,-0.038,-0.122,0.728,0.027,0.467,0.074],[-0.219,0.239,0.088,0.157,0.105,-0.405,0.102,-0.267,0.774,-0.021,0.038,-0.034,-0.014,0.031,-0.038,-0.002,0.0,-0.002,-0.004,0.001,0.0],[-0.218,0.168,0.353,0.018,-0.356,0.107,0.022,-0.014,-0.025,0.075,-0.36,0.459,0.476,0.13,-0.161,-0.194,0.05,-0.051,0.031,0.006,-0.001],[-0.219,0.237,-0.13,-0.067,0.123,0.176,-0.347,0.228,0.084,-0.531,-0.463,-0.123,-0.229,0.12,-0.054,-0.019,0.245,0.079,0.007,-0.004,0.011],[-0.218,0.248,0.014,0.135,0.47,0.52,0.596,-0.141,-0.086,-0.004,-0.001,-0.001,-0.003,-0.009,-0.001,-0.004,-0.004,0.001,0.003,0.001,0.0]],""selectVec"":[[-0.222,0.225,-0.048],[-0.217,0.177,0.351],[-0.22,0.232,-0.133],[-0.223,-0.174,-0.233],[-0.223,-0.12,-0.337],[-0.213,-0.269,0.139],[-0.212,-0.272,0.154],[-0.214,-0.267,0.136],[-0.222,0.223,-0.06],[-0.218,0.169,0.35],[-0.22,0.227,-0.142],[-0.219,0.037,-0.343],[-0.223,-0.179,-0.217],[-0.224,-0.123,-0.323],[-0.213,-0.271,0.143],[-0.213,-0.269,0.14],[-0.212,-0.274,0.152],[-0.219,0.239,0.088],[-0.218,0.168,0.353],[-0.219,0.237,-0.13],[-0.218,0.248,0.014]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6142,""AfterCleanSamNum"":6052,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""一次风机B运行"",""alarmcondition"":""[d1_10hlb40an001xq01]>20""},""copy"":false,""principal"":""3"",""precision"":""99.3%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":178,""version"":""v-2025-12-08 17:30:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "," + IN21 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R21[0] = reconData[0][20];
	        OUT_B21[0] = errorData[0][20];
	        OUT_F21[0] = paraState[0][20];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[21] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18,IN19,IN20,IN21};
			float[] arrOUT_B = new float[21] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18,OUT_B19,OUT_B20,OUT_B21};
			LD[] arrOUT_W = new LD[21] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18,OUT_W19,OUT_W20,OUT_W21 };
			
	        if (!(Condition1>20))
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