using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA199")]
    [FCDisplay("PCA199")]
    public partial class PCA199 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器出口集箱出口温度(B-1)")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器出口集箱出口温度")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器出口集箱出口温度")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("末级过热器出口集箱出口平均温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器入口集箱入口温度")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器入口集箱入口温度")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器出口集箱出口温度(A-1)")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器出口集箱出口温度(A-2)")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器出口集箱出口温度(B-2)")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器出口集箱出口温度(A-3)")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器出口集箱出口温度(B-3)")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器入口集箱入口温度(A-1)")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器入口集箱入口温度(B-1)")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧末级过热器入口集箱入口温度(A-2)")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧末级过热器入口集箱入口温度(B-2)")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧一级再热器入口集箱入口温度(A-1)")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧一级再热器入口集箱入口温度(B-1)")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧一级再热器入口集箱入口温度(A-2)")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧一级再热器入口集箱入口温度(B-2)")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("A侧一级再热器入口集箱入口温度(A-3)")]
	    public LAExWarn IN20 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("B侧一级再热器入口集箱入口温度(B-3)")]
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

		public PCA199()
		{
			ModelID = 220;
			SysID = 25;
			FcType = enumType.Warn;
			FcName = "PCA199";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""220"",""name"":""PCA199"",""description"":""锅炉蒸汽温度—高过后"",""founder"":""admin"",""creatTime"":""2024-01-03 14:30:49"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:39:48"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 18:42:06"",""et"":""2025-11-26 05:32:58"",""duration"":1162252,""number"":3875,""filter"":1404,""mode"":2471,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1314},{""st"":""2025-11-26 20:25:38"",""et"":""2025-12-04 09:11:32"",""duration"":650754,""number"":2170,""filter"":757,""mode"":1413,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":667}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lba72ct101k"",""Description"":""B侧末级过热器出口集箱出口温度(B-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.98"",""lowerBound"":""-0.98"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""615.44"",""TMin"":""565.33"",""TAvg"":""597.14"",""DMax"":""4.66"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.79"",""C99"":""0.98""},{""PointId"":""d1_tfshor"",""Description"":""A侧末级过热器出口集箱出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.65"",""lowerBound"":""-0.65"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""613.95"",""TMin"":""554.30"",""TAvg"":""597.14"",""DMax"":""3.39"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.52"",""C99"":""0.65""},{""PointId"":""d1_tfshol"",""Description"":""B侧末级过热器出口集箱出口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.74"",""lowerBound"":""-0.74"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""615.22"",""TMin"":""565.62"",""TAvg"":""597.14"",""DMax"":""4.01"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.58"",""C99"":""0.74""},{""PointId"":""d1_tfsho"",""Description"":""末级过热器出口集箱出口平均温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.56"",""lowerBound"":""-0.56"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""611.57"",""TMin"":""559.82"",""TAvg"":""597.14"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.45"",""C99"":""0.56""},{""PointId"":""d1_t2sor"",""Description"":""A侧末级过热器入口集箱入口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""537.59"",""TMin"":""479.41"",""TAvg"":""513.50"",""DMax"":""1.52"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.21"",""C99"":""0.27""},{""PointId"":""d1_t2sol"",""Description"":""B侧末级过热器入口集箱入口温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.28"",""lowerBound"":""-0.28"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""540.62"",""TMin"":""469.53"",""TAvg"":""515.75"",""DMax"":""1.20"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.23"",""C99"":""0.28""},{""PointId"":""d1_10lba71ct101k"",""Description"":""A侧末级过热器出口集箱出口温度(A-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.22"",""lowerBound"":""-1.22"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""614.86"",""TMin"":""554.77"",""TAvg"":""597.93"",""DMax"":""3.14"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.99"",""C99"":""1.22""},{""PointId"":""d1_10lba71ct102k"",""Description"":""A侧末级过热器出口集箱出口温度(A-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.19"",""lowerBound"":""-1.19"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""615.28"",""TMin"":""554.27"",""TAvg"":""597.14"",""DMax"":""6.69"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.95"",""C99"":""1.19""},{""PointId"":""d1_10lba72ct102k"",""Description"":""B侧末级过热器出口集箱出口温度(B-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.95"",""lowerBound"":""-0.95"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""615.33"",""TMin"":""566.01"",""TAvg"":""597.11"",""DMax"":""4.79"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.76"",""C99"":""0.95""},{""PointId"":""d1_10lba71ct103k"",""Description"":""A侧末级过热器出口集箱出口温度(A-3)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.83"",""lowerBound"":""-0.83"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""613.41"",""TMin"":""553.66"",""TAvg"":""596.75"",""DMax"":""2.01"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.68"",""C99"":""0.83""},{""PointId"":""d1_10lba72ct103k"",""Description"":""B侧末级过热器出口集箱出口温度(B-3)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.91"",""lowerBound"":""-0.91"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""614.86"",""TMin"":""565.42"",""TAvg"":""597.21"",""DMax"":""3.69"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.74"",""C99"":""0.91""},{""PointId"":""d1_10hah20ct105k"",""Description"":""A侧末级过热器入口集箱入口温度(A-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.87"",""lowerBound"":""-0.87"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""537.82"",""TMin"":""480.49"",""TAvg"":""513.92"",""DMax"":""1.76"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.70"",""C99"":""0.87""},{""PointId"":""d1_10hah20ct107k"",""Description"":""B侧末级过热器入口集箱入口温度(B-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.83"",""lowerBound"":""-0.83"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""540.48"",""TMin"":""470.93"",""TAvg"":""516.02"",""DMax"":""1.97"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.68"",""C99"":""0.83""},{""PointId"":""d1_10hah20ct106k"",""Description"":""A侧末级过热器入口集箱入口温度(A-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.94"",""lowerBound"":""-0.94"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""537.57"",""TMin"":""478.91"",""TAvg"":""513.08"",""DMax"":""2.68"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.76"",""C99"":""0.94""},{""PointId"":""d1_10hah20ct108k"",""Description"":""B侧末级过热器入口集箱入口温度(B-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.95"",""lowerBound"":""-0.95"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""540.84"",""TMin"":""465.67"",""TAvg"":""515.48"",""DMax"":""2.44"",""DMin"":""0.00"",""DAvg"":""0.21"",""C95"":""0.77"",""C99"":""0.95""},{""PointId"":""d1_10lbc80ct101k"",""Description"":""A侧一级再热器入口集箱入口温度(A-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.49"",""lowerBound"":""-0.49"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""366.71"",""TMin"":""326.42"",""TAvg"":""351.07"",""DMax"":""0.83"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.40"",""C99"":""0.49""},{""PointId"":""d1_10lbc81ct101k"",""Description"":""B侧一级再热器入口集箱入口温度(B-1)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.57"",""lowerBound"":""-0.57"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""366.45"",""TMin"":""326.35"",""TAvg"":""350.98"",""DMax"":""0.89"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.57""},{""PointId"":""d1_10lbc80ct102k"",""Description"":""A侧一级再热器入口集箱入口温度(A-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.64"",""lowerBound"":""-0.64"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""366.10"",""TMin"":""325.65"",""TAvg"":""350.28"",""DMax"":""1.04"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.52"",""C99"":""0.64""},{""PointId"":""d1_10lbc81ct102k"",""Description"":""B侧一级再热器入口集箱入口温度(B-2)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.70"",""lowerBound"":""-0.70"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""365.54"",""TMin"":""325.08"",""TAvg"":""349.70"",""DMax"":""0.93"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.57"",""C99"":""0.70""},{""PointId"":""d1_10lbc80ct103k"",""Description"":""A侧一级再热器入口集箱入口温度(A-3)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.60"",""lowerBound"":""-0.60"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""367.80"",""TMin"":""327.27"",""TAvg"":""351.78"",""DMax"":""1.38"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10lbc81ct103k"",""Description"":""B侧一级再热器入口集箱入口温度(B-3)"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.59"",""lowerBound"":""-0.59"",""LAY_TABLE_INDEX"":21,""type"":null,""TMax"":""367.23"",""TMin"":""326.73"",""TAvg"":""351.21"",""DMax"":""1.39"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.48"",""C99"":""0.59""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:39:48"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[565.327,554.298,565.616,559.816,479.412,469.529,554.772,554.266,566.01,553.662,565.419,480.493,470.929,478.908,465.674,326.42,326.352,325.646,325.084,327.272,326.731],""Train_X_max"":[615.437,613.95,615.221,611.566,537.589,540.624,614.858,615.276,615.325,613.408,614.863,537.817,540.477,537.568,540.835,366.713,366.45,366.095,365.536,367.802,367.229],""Train_X_std"":[5.3,5.211,5.273,4.967,8.003,8.878,5.235,5.229,5.299,5.192,5.264,7.872,8.779,8.143,8.993,6.464,6.457,6.57,6.583,6.492,6.491],""Train_X_mean"":[597.14,597.136,597.14,597.137,513.497,515.754,597.928,597.144,597.106,596.747,597.207,513.917,516.021,513.078,515.483,351.07,350.983,350.281,349.704,351.776,351.208],""Train_X_bais_max"":[[4.658,3.39,4.009,3.005,1.522,1.197,3.138,6.688,4.791,2.014,3.691,1.762,1.969,2.683,2.44,0.831,0.891,1.044,0.928,1.381,1.389]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.161,0.133,0.107,0.092,0.044,0.047,0.258,0.18,0.17,0.186,0.176,0.194,0.186,0.205,0.206,0.115,0.131,0.152,0.166,0.131,0.13]],""QCUL_95"":0.0946925953,""QCUL_99"":0.152027816,""QCUL_95_line"":[0.787,0.522,0.584,0.45,0.212,0.226,0.99,0.95,0.761,0.675,0.735,0.704,0.677,0.763,0.773,0.403,0.46,0.521,0.572,0.486,0.481],""QCUL_99_line"":[0.984,0.645,0.735,0.563,0.265,0.282,1.222,1.194,0.948,0.83,0.912,0.866,0.832,0.939,0.952,0.494,0.565,0.637,0.701,0.598,0.592],""T2CUL_95"":11.096,""T2CUL_99"":15.128,""T2CUL_95_line"":[0.281,0.276,0.279,0.263,0.424,0.47,0.277,0.277,0.28,0.275,0.279,0.417,0.465,0.431,0.476,0.342,0.342,0.348,0.348,0.344,0.344],""T2CUL_99_line"":[0.328,0.322,0.326,0.307,0.495,0.549,0.324,0.323,0.328,0.321,0.325,0.487,0.543,0.503,0.556,0.4,0.399,0.406,0.407,0.401,0.401],""Kesi_95"":1.605,""Kesi_99"":1.407,""Kesi_95_line"":[0.107,0.105,0.106,0.1,0.161,0.179,0.105,0.105,0.107,0.105,0.106,0.158,0.177,0.164,0.181,0.13,0.13,0.132,0.133,0.131,0.131],""Kesi_99_line"":[0.1,0.098,0.099,0.094,0.151,0.167,0.099,0.099,0.1,0.098,0.099,0.148,0.165,0.154,0.17,0.122,0.122,0.124,0.124,0.122,0.122],""COV"":[[1.0,0.777,0.995,0.939,0.067,0.126,0.779,0.784,0.999,0.778,0.994,0.072,0.135,0.063,0.117,0.554,0.551,0.545,0.548,0.546,0.547],[0.777,1.0,0.785,0.944,0.103,0.061,0.995,0.996,0.78,0.998,0.782,0.111,0.068,0.096,0.054,0.546,0.543,0.539,0.541,0.539,0.54],[0.995,0.785,1.0,0.946,0.069,0.127,0.784,0.783,0.995,0.785,0.999,0.074,0.135,0.065,0.119,0.561,0.558,0.552,0.554,0.554,0.555],[0.939,0.944,0.946,1.0,0.09,0.099,0.941,0.941,0.94,0.943,0.943,0.096,0.107,0.084,0.091,0.585,0.582,0.577,0.579,0.578,0.579],[0.067,0.103,0.069,0.09,1.0,0.735,0.097,0.101,0.066,0.115,0.076,1.0,0.731,0.999,0.738,0.171,0.172,0.166,0.166,0.175,0.176],[0.126,0.061,0.127,0.099,0.735,1.0,0.044,0.061,0.132,0.06,0.126,0.739,1.0,0.731,0.999,0.159,0.159,0.164,0.166,0.162,0.163],[0.779,0.995,0.784,0.941,0.097,0.044,1.0,0.992,0.779,0.995,0.782,0.104,0.051,0.089,0.036,0.528,0.525,0.519,0.521,0.52,0.521],[0.784,0.996,0.783,0.941,0.101,0.061,0.992,1.0,0.786,0.994,0.78,0.109,0.069,0.094,0.054,0.547,0.544,0.54,0.543,0.539,0.54],[0.999,0.78,0.995,0.94,0.066,0.132,0.779,0.786,1.0,0.779,0.994,0.07,0.14,0.062,0.124,0.569,0.566,0.561,0.564,0.561,0.562],[0.778,0.998,0.785,0.943,0.115,0.06,0.995,0.994,0.779,1.0,0.784,0.122,0.066,0.109,0.053,0.534,0.532,0.526,0.528,0.528,0.529],[0.994,0.782,0.999,0.943,0.076,0.126,0.782,0.78,0.994,0.784,1.0,0.08,0.134,0.072,0.118,0.562,0.559,0.552,0.555,0.556,0.557],[0.072,0.111,0.074,0.096,1.0,0.739,0.104,0.109,0.07,0.122,0.08,1.0,0.736,0.998,0.741,0.173,0.173,0.167,0.168,0.176,0.177],[0.135,0.068,0.135,0.107,0.731,1.0,0.051,0.069,0.14,0.066,0.134,0.736,1.0,0.727,0.998,0.159,0.159,0.165,0.166,0.162,0.163],[0.063,0.096,0.065,0.084,0.999,0.731,0.089,0.094,0.062,0.109,0.072,0.998,0.727,1.0,0.735,0.17,0.17,0.164,0.165,0.174,0.175],[0.117,0.054,0.119,0.091,0.738,0.999,0.036,0.054,0.124,0.053,0.118,0.741,0.998,0.735,1.0,0.159,0.159,0.164,0.166,0.162,0.163],[0.554,0.546,0.561,0.585,0.171,0.159,0.528,0.547,0.569,0.534,0.562,0.173,0.159,0.17,0.159,1.0,1.0,0.999,0.999,0.999,0.999],[0.551,0.543,0.558,0.582,0.172,0.159,0.525,0.544,0.566,0.532,0.559,0.173,0.159,0.17,0.159,1.0,1.0,0.999,0.999,0.999,0.999],[0.545,0.539,0.552,0.577,0.166,0.164,0.519,0.54,0.561,0.526,0.552,0.167,0.165,0.164,0.164,0.999,0.999,1.0,1.0,0.999,0.999],[0.548,0.541,0.554,0.579,0.166,0.166,0.521,0.543,0.564,0.528,0.555,0.168,0.166,0.165,0.166,0.999,0.999,1.0,1.0,0.999,0.999],[0.546,0.539,0.554,0.578,0.175,0.162,0.52,0.539,0.561,0.528,0.556,0.176,0.162,0.174,0.162,0.999,0.999,0.999,0.999,1.0,1.0],[0.547,0.54,0.555,0.579,0.176,0.163,0.521,0.54,0.562,0.529,0.557,0.177,0.163,0.175,0.163,0.999,0.999,0.999,0.999,1.0,1.0]],""K"":5,""R"":0.998,""featValue"":[11.433,5.064,2.818,1.014,0.64,0.017,0.008,0.004,0.003,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.257,0.077,0.189,0.274,0.235,-0.388,-0.236,-0.225,0.159,-0.321,0.256,0.034,-0.061,0.516,-0.16,-0.076,-0.044,-0.082,0.0,0.001,0.001],[0.255,0.086,0.197,-0.267,-0.233,0.101,0.298,0.285,-0.014,-0.192,0.23,0.177,-0.074,0.265,0.486,-0.066,-0.331,0.187,0.018,-0.014,0.003],[0.258,0.077,0.186,0.269,0.23,0.305,0.021,0.263,-0.013,-0.217,-0.182,0.196,-0.124,-0.342,-0.368,-0.005,-0.453,-0.11,-0.005,0.001,0.012],[0.272,0.087,0.203,0.003,0.0,0.197,0.148,0.281,-0.061,-0.203,0.082,0.086,-0.088,-0.023,-0.112,0.02,0.808,-0.06,0.001,0.006,-0.003],[0.073,-0.396,0.064,-0.267,0.31,-0.016,-0.013,0.032,0.024,0.054,0.017,0.011,0.073,-0.073,0.016,-0.592,0.025,-0.094,0.533,0.07,0.034],[0.073,-0.395,0.076,0.259,-0.315,0.005,-0.025,0.003,0.026,0.06,0.007,-0.052,-0.125,-0.062,0.032,-0.532,0.023,-0.03,-0.579,-0.14,-0.001],[0.252,0.092,0.208,-0.273,-0.212,0.089,-0.757,0.04,-0.379,0.191,0.009,0.025,0.011,-0.01,-0.022,0.023,-0.029,0.003,0.0,-0.002,0.001],[0.255,0.086,0.196,-0.261,-0.231,-0.535,0.207,-0.115,0.112,0.091,-0.575,0.182,-0.113,-0.085,-0.141,0.0,0.025,-0.002,0.012,-0.001,-0.003],[0.259,0.076,0.179,0.279,0.222,-0.393,0.114,0.019,-0.176,0.336,0.35,-0.059,0.12,-0.468,0.286,0.09,0.011,0.077,-0.012,0.005,-0.004],[0.254,0.084,0.206,-0.276,-0.211,0.238,0.176,-0.378,0.303,0.02,0.291,-0.429,0.215,-0.158,-0.261,0.032,-0.09,-0.157,-0.028,0.012,0.0],[0.258,0.075,0.185,0.265,0.245,0.369,0.04,-0.193,0.056,0.312,-0.467,-0.21,0.121,0.308,0.304,-0.021,0.055,0.141,0.014,-0.011,-0.007],[0.075,-0.396,0.067,-0.267,0.3,-0.053,-0.131,0.303,0.377,0.079,-0.016,0.146,0.398,0.06,-0.029,0.313,0.006,0.066,-0.35,-0.041,-0.038],[0.075,-0.393,0.08,0.263,-0.317,-0.025,-0.139,0.211,0.333,0.115,0.025,-0.232,-0.385,0.0,0.034,0.335,-0.013,0.046,0.385,0.09,0.001],[0.072,-0.396,0.061,-0.267,0.319,0.039,0.157,-0.299,-0.407,-0.129,0.001,-0.156,-0.473,0.014,0.012,0.281,-0.03,0.027,-0.184,-0.028,0.006],[0.072,-0.397,0.071,0.255,-0.311,0.046,0.142,-0.245,-0.36,-0.18,-0.035,0.282,0.508,0.06,-0.063,0.196,-0.01,-0.014,0.195,0.05,0.0],[0.249,-0.01,-0.321,-0.006,-0.003,-0.027,-0.146,-0.084,0.071,-0.362,-0.095,-0.147,0.065,-0.215,0.061,-0.089,0.047,0.525,-0.084,0.541,-0.005],[0.248,-0.01,-0.323,-0.008,-0.003,-0.033,-0.175,-0.073,0.107,-0.391,-0.159,-0.113,0.069,-0.228,0.378,0.073,0.037,-0.28,0.087,-0.55,0.003],[0.247,-0.011,-0.326,0.001,-0.022,-0.099,0.116,0.275,-0.2,0.104,-0.066,-0.235,0.071,0.201,0.028,0.022,-0.08,-0.589,-0.102,0.415,-0.199],[0.248,-0.011,-0.324,0.002,-0.022,-0.103,0.152,0.27,-0.223,0.144,0.035,-0.289,0.099,0.21,-0.4,-0.042,-0.057,0.369,0.083,-0.404,0.213],[0.248,-0.012,-0.325,-0.007,-0.003,0.134,0.004,-0.194,0.145,0.252,0.129,0.403,-0.145,0.02,0.03,0.05,0.03,-0.15,-0.044,0.125,0.669],[0.248,-0.013,-0.324,-0.007,-0.003,0.136,0.023,-0.197,0.107,0.25,0.161,0.372,-0.159,0.017,-0.108,-0.014,0.022,0.124,0.06,-0.126,-0.681]],""selectVec"":[[0.257,0.077,0.189,0.274,0.235],[0.255,0.086,0.197,-0.267,-0.233],[0.258,0.077,0.186,0.269,0.23],[0.272,0.087,0.203,0.003,0.0],[0.073,-0.396,0.064,-0.267,0.31],[0.073,-0.395,0.076,0.259,-0.315],[0.252,0.092,0.208,-0.273,-0.212],[0.255,0.086,0.196,-0.261,-0.231],[0.259,0.076,0.179,0.279,0.222],[0.254,0.084,0.206,-0.276,-0.211],[0.258,0.075,0.185,0.265,0.245],[0.075,-0.396,0.067,-0.267,0.3],[0.075,-0.393,0.08,0.263,-0.317],[0.072,-0.396,0.061,-0.267,0.319],[0.072,-0.397,0.071,0.255,-0.311],[0.249,-0.01,-0.321,-0.006,-0.003],[0.248,-0.01,-0.323,-0.008,-0.003],[0.247,-0.011,-0.326,0.001,-0.022],[0.248,-0.011,-0.324,0.002,-0.022],[0.248,-0.012,-0.325,-0.007,-0.003],[0.248,-0.013,-0.324,-0.007,-0.003]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6044,""AfterCleanSamNum"":3960,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""5"",""precision"":""99.8%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":220,""version"":""v-2025-12-04 17:39:48"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "," + IN21 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>350))
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