using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA165")]
    [FCDisplay("PCA165")]
    public partial class PCA165 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A非驱动端轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A中轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A驱动端轴承温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机驱动端轴承温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机非驱动端轴承温度1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机定子U相绕组温度1")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机定子V相绕组温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机定子W相绕组温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A非驱动端轴承温度2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A中轴承温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A驱动端轴承温度3")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A出口温度")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机驱动端轴承温度2")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机非驱动端轴承温度2")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机定子U相绕组温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机定子V相绕组温度2")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A电机定子W相绕组温度2")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A非驱动端轴承温度3")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A中轴承温度3")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A驱动端轴承温度1")]
	    public LAExWarn IN20 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("一次风机A联合油站油箱油温")]
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

		public PCA165()
		{
			ModelID = 177;
			SysID = 31;
			FcType = enumType.Warn;
			FcName = "PCA165";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""177"",""name"":""PCA165"",""description"":""一次风机A本体温度"",""founder"":""admin"",""creatTime"":""2023-11-14 09:21:52"",""Modifier"":""admin"",""modifiedTime"":""2025-12-08 17:26:53"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 15:43:34"",""et"":""2025-11-26 04:48:20"",""duration"":1170286,""number"":3901,""filter"":96,""mode"":3805,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-26 17:27:06"",""et"":""2025-12-04 11:25:26"",""duration"":669500,""number"":2232,""filter"":92,""mode"":2140,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hlb30ct101r"",""Description"":""一次风机A非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.14"",""lowerBound"":""-0.14"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""54.77"",""TMin"":""48.28"",""TAvg"":""50.69"",""DMax"":""0.20"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.14""},{""PointId"":""d1_10hlb30ct104r"",""Description"":""一次风机A中轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.16"",""lowerBound"":""-0.16"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""53.82"",""TMin"":""46.93"",""TAvg"":""49.43"",""DMax"":""0.21"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.16""},{""PointId"":""d1_10hlb30ct108r"",""Description"":""一次风机A驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""46.10"",""TMin"":""38.60"",""TAvg"":""41.53"",""DMax"":""0.22"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10hlb30ct110r"",""Description"":""一次风机A电机驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.11"",""lowerBound"":""-2.11"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""43.22"",""TMin"":""17.98"",""TAvg"":""26.82"",""DMax"":""4.02"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.71"",""C99"":""2.11""},{""PointId"":""d1_10hlb30ct112r"",""Description"":""一次风机A电机非驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.67"",""lowerBound"":""-1.67"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""35.25"",""TMin"":""10.94"",""TAvg"":""19.83"",""DMax"":""3.80"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.34"",""C99"":""1.67""},{""PointId"":""d1_10hlb30ct114r"",""Description"":""一次风机A电机定子U相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.77"",""lowerBound"":""-0.77"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""58.41"",""TMin"":""24.15"",""TAvg"":""36.87"",""DMax"":""1.23"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.63"",""C99"":""0.77""},{""PointId"":""d1_10hlb30ct116r"",""Description"":""一次风机A电机定子V相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.84"",""lowerBound"":""-0.84"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""55.91"",""TMin"":""22.99"",""TAvg"":""35.30"",""DMax"":""1.47"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.68"",""C99"":""0.84""},{""PointId"":""d1_10hlb30ct118r"",""Description"":""一次风机A电机定子W相绕组温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.67"",""lowerBound"":""-0.67"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""59.82"",""TMin"":""25.47"",""TAvg"":""38.25"",""DMax"":""1.02"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.55"",""C99"":""0.67""},{""PointId"":""d1_10hlb30ct102r"",""Description"":""一次风机A非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""51.81"",""TMin"":""45.25"",""TAvg"":""47.76"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.15""},{""PointId"":""d1_10hlb30ct105r"",""Description"":""一次风机A中轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""53.82"",""TMin"":""46.98"",""TAvg"":""49.45"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10hlb30ct109r"",""Description"":""一次风机A驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.19"",""lowerBound"":""-0.19"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""45.71"",""TMin"":""38.16"",""TAvg"":""41.09"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10hla30ct101r"",""Description"":""一次风机A出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""4.87"",""lowerBound"":""-4.87"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""33.23"",""TMin"":""4.25"",""TAvg"":""15.61"",""DMax"":""5.94"",""DMin"":""0.00"",""DAvg"":""1.14"",""C95"":""3.98"",""C99"":""4.87""},{""PointId"":""d1_10hlb30ct111r"",""Description"":""一次风机A电机驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.38"",""lowerBound"":""-2.38"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""44.36"",""TMin"":""18.34"",""TAvg"":""27.35"",""DMax"":""4.54"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.93"",""C99"":""2.38""},{""PointId"":""d1_10hlb30ct113r"",""Description"":""一次风机A电机非驱动端轴承温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.44"",""lowerBound"":""-1.44"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""34.04"",""TMin"":""10.26"",""TAvg"":""19.17"",""DMax"":""3.16"",""DMin"":""0.00"",""DAvg"":""0.28"",""C95"":""1.16"",""C99"":""1.44""},{""PointId"":""d1_10hlb30ct115r"",""Description"":""一次风机A电机定子U相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.76"",""lowerBound"":""-0.76"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""58.25"",""TMin"":""24.16"",""TAvg"":""36.83"",""DMax"":""1.24"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.62"",""C99"":""0.76""},{""PointId"":""d1_10hlb30ct117r"",""Description"":""一次风机A电机定子V相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.72"",""lowerBound"":""-0.72"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""58.21"",""TMin"":""24.55"",""TAvg"":""37.08"",""DMax"":""1.16"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.58"",""C99"":""0.72""},{""PointId"":""d1_10hlb30ct119r"",""Description"":""一次风机A电机定子W相绕组温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.69"",""lowerBound"":""-0.69"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""59.21"",""TMin"":""25.19"",""TAvg"":""37.85"",""DMax"":""1.02"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.56"",""C99"":""0.69""},{""PointId"":""d1_10hlb30ct103r"",""Description"":""一次风机A非驱动端轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""51.16"",""TMin"":""44.51"",""TAvg"":""47.07"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.13""},{""PointId"":""d1_10hlb30ct106r"",""Description"":""一次风机A中轴承温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""52.56"",""TMin"":""45.62"",""TAvg"":""48.16"",""DMax"":""0.18"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.12"",""C99"":""0.15""},{""PointId"":""d1_10hlb30ct107r"",""Description"":""一次风机A驱动端轴承温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.18"",""lowerBound"":""-0.18"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""46.34"",""TMin"":""38.86"",""TAvg"":""41.81"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.18""},{""PointId"":""d1_10hlb31ct101r"",""Description"":""一次风机A联合油站油箱油温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.52"",""lowerBound"":""-0.52"",""LAY_TABLE_INDEX"":21,""type"":null,""TMax"":""46.28"",""TMin"":""39.27"",""TAvg"":""42.02"",""DMax"":""0.86"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.43"",""C99"":""0.52""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-08 17:26:53"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[48.284,46.931,38.599,17.979,10.937,24.153,22.985,25.47,45.254,46.979,38.161,4.247,18.339,10.256,24.163,24.548,25.189,44.511,45.617,38.856,39.272],""Train_X_max"":[54.765,53.817,46.098,43.223,35.247,58.406,55.914,59.819,51.805,53.82,45.713,33.23,44.358,34.041,58.25,58.205,59.214,51.16,52.56,46.335,46.28],""Train_X_std"":[1.003,0.914,1.301,5.06,4.945,7.509,7.181,7.548,1.069,0.907,1.322,5.961,5.135,4.924,7.471,7.388,7.474,1.114,0.949,1.312,1.098],""Train_X_mean"":[50.686,49.431,41.526,26.822,19.829,36.874,35.295,38.25,47.76,49.454,41.088,15.608,27.345,19.169,36.828,37.082,37.851,47.074,48.157,41.813,42.02],""Train_X_bais_max"":[[0.198,0.208,0.223,4.018,3.798,1.232,1.468,1.02,0.179,0.239,0.262,5.938,4.535,3.164,1.235,1.155,1.023,0.146,0.176,0.248,0.86]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.032,0.036,0.039,0.461,0.315,0.175,0.191,0.152,0.034,0.038,0.043,1.143,0.52,0.278,0.172,0.162,0.156,0.031,0.034,0.042,0.121]],""QCUL_95"":0.4545553,""QCUL_99"":0.7663609,""QCUL_95_line"":[0.114,0.129,0.137,1.71,1.342,0.626,0.683,0.547,0.119,0.135,0.151,3.976,1.934,1.16,0.618,0.582,0.562,0.109,0.122,0.147,0.427],""QCUL_99_line"":[0.14,0.158,0.168,2.105,1.667,0.769,0.838,0.672,0.145,0.166,0.185,4.872,2.381,1.439,0.759,0.715,0.69,0.134,0.15,0.18,0.524],""T2CUL_95"":7.823,""T2CUL_99"":11.36,""T2CUL_95_line"":[0.036,0.033,0.047,0.182,0.178,0.27,0.258,0.272,0.038,0.033,0.048,0.215,0.185,0.177,0.269,0.266,0.269,0.04,0.034,0.047,0.04],""T2CUL_99_line"":[0.044,0.04,0.056,0.219,0.215,0.326,0.311,0.327,0.046,0.039,0.057,0.259,0.223,0.214,0.324,0.32,0.324,0.048,0.041,0.057,0.048],""Kesi_95"":1.58,""Kesi_99"":1.372,""Kesi_95_line"":[0.016,0.015,0.021,0.082,0.08,0.121,0.116,0.122,0.017,0.015,0.021,0.096,0.083,0.08,0.121,0.12,0.121,0.018,0.015,0.021,0.018],""Kesi_99_line"":[0.015,0.014,0.02,0.076,0.075,0.113,0.108,0.114,0.016,0.014,0.02,0.09,0.077,0.074,0.113,0.111,0.113,0.017,0.014,0.02,0.017],""COV"":[[1.0,0.969,0.987,0.79,0.836,0.668,0.688,0.663,0.996,0.967,0.988,0.878,0.786,0.839,0.67,0.674,0.667,0.994,0.979,0.985,0.988],[0.969,1.0,0.927,0.768,0.795,0.732,0.744,0.728,0.952,1.0,0.929,0.816,0.765,0.796,0.734,0.735,0.731,0.947,0.999,0.923,0.942],[0.987,0.927,1.0,0.818,0.871,0.661,0.684,0.655,0.996,0.925,1.0,0.925,0.813,0.875,0.663,0.667,0.659,0.997,0.944,1.0,0.981],[0.79,0.768,0.818,1.0,0.98,0.919,0.93,0.917,0.819,0.771,0.817,0.892,1.0,0.98,0.92,0.923,0.919,0.826,0.785,0.819,0.765],[0.836,0.795,0.871,0.98,1.0,0.878,0.893,0.875,0.866,0.796,0.869,0.93,0.978,1.0,0.88,0.883,0.878,0.873,0.814,0.872,0.816],[0.668,0.732,0.661,0.919,0.878,1.0,0.999,1.0,0.682,0.738,0.662,0.771,0.918,0.875,1.0,1.0,1.0,0.686,0.732,0.659,0.623],[0.688,0.744,0.684,0.93,0.893,0.999,1.0,0.999,0.703,0.749,0.684,0.792,0.929,0.891,1.0,1.0,0.999,0.707,0.746,0.683,0.644],[0.663,0.728,0.655,0.917,0.875,1.0,0.999,1.0,0.677,0.734,0.656,0.765,0.916,0.872,1.0,1.0,1.0,0.681,0.728,0.654,0.619],[0.996,0.952,0.996,0.819,0.866,0.682,0.703,0.677,1.0,0.951,0.996,0.91,0.814,0.869,0.685,0.688,0.681,1.0,0.966,0.995,0.985],[0.967,1.0,0.925,0.771,0.796,0.738,0.749,0.734,0.951,1.0,0.927,0.816,0.768,0.797,0.739,0.741,0.736,0.946,0.999,0.921,0.94],[0.988,0.929,1.0,0.817,0.869,0.662,0.684,0.656,0.996,0.927,1.0,0.925,0.812,0.874,0.664,0.668,0.66,0.997,0.946,1.0,0.982],[0.878,0.816,0.925,0.892,0.93,0.771,0.792,0.765,0.91,0.816,0.925,1.0,0.885,0.936,0.773,0.777,0.769,0.918,0.839,0.928,0.856],[0.786,0.765,0.813,1.0,0.978,0.918,0.929,0.916,0.814,0.768,0.812,0.885,1.0,0.977,0.919,0.922,0.918,0.821,0.781,0.814,0.76],[0.839,0.796,0.875,0.98,1.0,0.875,0.891,0.872,0.869,0.797,0.874,0.936,0.977,1.0,0.877,0.88,0.875,0.876,0.815,0.877,0.819],[0.67,0.734,0.663,0.92,0.88,1.0,1.0,1.0,0.685,0.739,0.664,0.773,0.919,0.877,1.0,1.0,1.0,0.688,0.734,0.662,0.626],[0.674,0.735,0.667,0.923,0.883,1.0,1.0,1.0,0.688,0.741,0.668,0.777,0.922,0.88,1.0,1.0,1.0,0.692,0.736,0.666,0.63],[0.667,0.731,0.659,0.919,0.878,1.0,0.999,1.0,0.681,0.736,0.66,0.769,0.918,0.875,1.0,1.0,1.0,0.684,0.731,0.658,0.622],[0.994,0.947,0.997,0.826,0.873,0.686,0.707,0.681,1.0,0.946,0.997,0.918,0.821,0.876,0.688,0.692,0.684,1.0,0.962,0.996,0.983],[0.979,0.999,0.944,0.785,0.814,0.732,0.746,0.728,0.966,0.999,0.946,0.839,0.781,0.815,0.734,0.736,0.731,0.962,1.0,0.94,0.954],[0.985,0.923,1.0,0.819,0.872,0.659,0.683,0.654,0.995,0.921,1.0,0.928,0.814,0.877,0.662,0.666,0.658,0.996,0.94,1.0,0.98],[0.988,0.942,0.981,0.765,0.816,0.623,0.644,0.619,0.985,0.94,0.982,0.856,0.76,0.819,0.626,0.63,0.622,0.983,0.954,0.98,1.0]],""K"":3,""R"":0.993,""featValue"":[17.9,2.408,0.538,0.095,0.027,0.024,0.007,0.003,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.22,0.229,-0.089,0.076,-0.005,-0.041,-0.274,-0.318,0.823,-0.054,-0.053,0.028,0.058,-0.052,0.101,0.075,0.044,-0.023,0.005,0.003,-0.001],[0.219,0.161,-0.379,0.043,0.214,0.2,0.198,0.048,0.04,0.029,0.093,0.052,0.008,0.653,-0.385,-0.126,0.217,-0.043,0.004,0.009,0.004],[0.221,0.224,0.112,-0.064,-0.055,-0.089,-0.185,0.404,-0.057,-0.069,0.232,-0.133,0.115,-0.259,-0.19,0.295,0.618,0.103,0.029,-0.014,-0.005],[0.224,-0.147,0.261,0.333,0.363,-0.264,0.101,-0.03,-0.033,-0.501,0.207,0.441,-0.21,-0.005,-0.009,0.046,-0.019,-0.033,-0.006,-0.008,-0.003],[0.227,-0.077,0.321,0.174,-0.194,0.554,0.065,-0.022,0.037,0.328,-0.003,0.271,-0.171,0.009,-0.146,0.406,-0.134,0.21,-0.021,0.02,0.007],[0.209,-0.293,-0.136,-0.081,-0.089,-0.05,-0.056,0.021,-0.036,-0.051,-0.065,-0.107,0.018,0.019,-0.065,0.356,-0.065,-0.602,-0.324,0.456,0.024],[0.212,-0.278,-0.104,-0.096,-0.088,-0.049,-0.055,0.017,-0.016,-0.363,-0.083,-0.278,0.209,0.232,0.058,0.218,-0.191,0.549,-0.273,-0.138,-0.22],[0.208,-0.297,-0.139,-0.058,-0.096,-0.056,-0.08,0.012,0.026,0.253,0.072,0.2,-0.105,-0.156,-0.024,-0.277,0.159,-0.106,-0.513,-0.547,0.074],[0.223,0.214,0.014,0.005,0.025,-0.035,-0.367,-0.414,-0.302,0.037,0.358,-0.172,0.059,-0.158,-0.427,-0.128,-0.345,0.006,0.001,0.009,-0.006],[0.219,0.155,-0.383,0.04,0.23,0.202,0.224,0.084,-0.026,-0.019,0.178,-0.338,-0.523,-0.297,0.314,0.07,-0.115,0.06,-0.018,-0.002,0.0],[0.221,0.224,0.104,-0.072,-0.051,-0.089,-0.137,0.483,0.082,-0.111,-0.524,0.011,-0.261,-0.059,-0.312,-0.23,-0.325,-0.024,-0.003,-0.01,-0.003],[0.221,0.053,0.335,-0.772,0.214,-0.054,0.375,-0.202,0.084,0.036,0.012,0.017,-0.011,-0.022,-0.023,0.0,0.014,0.001,-0.001,0.002,0.0],[0.223,-0.15,0.261,0.375,0.406,-0.269,0.144,0.019,0.043,0.472,-0.18,-0.404,0.194,0.017,-0.001,-0.029,0.012,0.031,0.007,0.009,0.001],[0.227,-0.072,0.329,0.134,-0.166,0.496,0.064,-0.031,-0.003,-0.349,0.004,-0.298,0.17,-0.015,0.153,-0.443,0.149,-0.237,0.025,-0.019,-0.008],[0.209,-0.291,-0.132,-0.08,-0.091,-0.051,-0.058,0.017,-0.018,-0.011,-0.023,-0.057,-0.002,0.048,-0.017,0.221,-0.09,-0.285,0.681,-0.465,-0.091],[0.21,-0.289,-0.124,-0.072,-0.094,-0.056,-0.073,0.015,0.01,-0.005,0.014,0.029,0.005,-0.017,0.029,-0.155,0.029,0.283,0.215,0.259,0.783],[0.209,-0.294,-0.134,-0.061,-0.098,-0.058,-0.082,0.014,0.022,0.183,0.059,0.187,-0.095,-0.12,0.026,-0.346,0.145,0.188,0.212,0.433,-0.568],[0.223,0.209,0.04,-0.017,0.022,-0.043,-0.315,-0.339,-0.414,0.032,-0.44,0.072,-0.225,0.221,0.342,0.073,0.307,0.011,-0.006,-0.013,0.008],[0.221,0.167,-0.316,0.035,0.2,0.178,0.163,0.022,-0.174,-0.03,-0.246,0.351,0.595,-0.365,0.091,0.034,-0.105,-0.004,0.013,-0.007,-0.004],[0.22,0.223,0.128,-0.08,-0.064,-0.093,-0.184,0.369,-0.024,0.199,0.387,0.137,0.172,0.328,0.497,-0.057,-0.299,-0.094,-0.024,0.022,0.008],[0.214,0.256,-0.037,0.209,-0.625,-0.38,0.529,-0.157,-0.056,0.004,0.009,-0.01,-0.005,-0.003,-0.012,-0.005,-0.002,0.003,-0.001,0.0,0.0]],""selectVec"":[[0.22,0.229,-0.089],[0.219,0.161,-0.379],[0.221,0.224,0.112],[0.224,-0.147,0.261],[0.227,-0.077,0.321],[0.209,-0.293,-0.136],[0.212,-0.278,-0.104],[0.208,-0.297,-0.139],[0.223,0.214,0.014],[0.219,0.155,-0.383],[0.221,0.224,0.104],[0.221,0.053,0.335],[0.223,-0.15,0.261],[0.227,-0.072,0.329],[0.209,-0.291,-0.132],[0.21,-0.289,-0.124],[0.209,-0.294,-0.134],[0.223,0.209,0.04],[0.221,0.167,-0.316],[0.22,0.223,0.128],[0.214,0.256,-0.037]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6133,""AfterCleanSamNum"":6037,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""一次风机A运行"",""alarmcondition"":""[d1_10hlb30an001xq01]>20""},""copy"":false,""principal"":""3"",""precision"":""99.3%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":177,""version"":""v-2025-12-08 17:26:53"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "," + IN21 + "]],\"Target_Data\":[[]]}";
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