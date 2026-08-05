using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA109")]
    [FCDisplay("PCA109")]
    public partial class PCA109 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("机组负荷大于350MW")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1扇区冷水母管温度A")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2扇区冷水母管温度A")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#3扇区冷水母管温度A")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#4扇区冷水母管温度A")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1扇区冷水母管温度C")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2扇区冷水母管温度C")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#3扇区冷水母管温度C")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#4扇区冷水母管温度C")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#1扇区冷水母管温度B")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2扇区冷水母管温度B")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#3扇区冷水母管温度B")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#4扇区冷水母管温度B")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5扇区冷水母管温度A")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#6扇区冷水母管温度A")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#7扇区冷水母管温度A")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#8扇区冷水母管温度A")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5扇区冷水母管温度B")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#6扇区冷水母管温度B")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#7扇区冷水母管温度B")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#8扇区冷水母管温度B")]
	    public LAExWarn IN20 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#5扇区冷水母管温度C")]
	    public LAExWarn IN21 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#6扇区冷水母管温度C")]
	    public LAExWarn IN22 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#7扇区冷水母管温度C")]
	    public LAExWarn IN23 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#8扇区冷水母管温度C")]
	    public LAExWarn IN24 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#9扇区冷水母管温度A")]
	    public LAExWarn IN25 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#10扇区冷水母管温度A")]
	    public LAExWarn IN26 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#9扇区冷水母管温度B")]
	    public LAExWarn IN27 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#10扇区冷水母管温度B")]
	    public LAExWarn IN28 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#9扇区冷水母管温度C")]
	    public LAExWarn IN29 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#10扇区冷水母管温度C")]
	    public LAExWarn IN30 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#11扇区冷水母管温度A")]
	    public LAExWarn IN31 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#12扇区冷水母管温度A")]
	    public LAExWarn IN32 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#13扇区冷水母管温度A")]
	    public LAExWarn IN33 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#14扇区冷水母管温度A")]
	    public LAExWarn IN34 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#11扇区冷水母管温度C")]
	    public LAExWarn IN35 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#12扇区冷水母管温度C")]
	    public LAExWarn IN36 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#13扇区冷水母管温度C")]
	    public LAExWarn IN37 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#14扇区冷水母管温度C")]
	    public LAExWarn IN38 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#11扇区冷水母管温度B")]
	    public LAExWarn IN39 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#12扇区冷水母管温度B")]
	    public LAExWarn IN40 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#13扇区冷水母管温度B")]
	    public LAExWarn IN41 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#14扇区冷水母管温度B")]
	    public LAExWarn IN42 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("循环水冷水母管温度")]
	    public LAExWarn IN43 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("重构输出22")]
	    public LA OUT_R22 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出22")]
	    public LA OUT_B22 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出22")]
	    public LD OUT_F22 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出22")]
	    public LD OUT_W22 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出23")]
	    public LA OUT_R23 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出23")]
	    public LA OUT_B23 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出23")]
	    public LD OUT_F23 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出23")]
	    public LD OUT_W23 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出24")]
	    public LA OUT_R24 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出24")]
	    public LA OUT_B24 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出24")]
	    public LD OUT_F24 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出24")]
	    public LD OUT_W24 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出25")]
	    public LA OUT_R25 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出25")]
	    public LA OUT_B25 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出25")]
	    public LD OUT_F25 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出25")]
	    public LD OUT_W25 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出26")]
	    public LA OUT_R26 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出26")]
	    public LA OUT_B26 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出26")]
	    public LD OUT_F26 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出26")]
	    public LD OUT_W26 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出27")]
	    public LA OUT_R27 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出27")]
	    public LA OUT_B27 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出27")]
	    public LD OUT_F27 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出27")]
	    public LD OUT_W27 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出28")]
	    public LA OUT_R28 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出28")]
	    public LA OUT_B28 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出28")]
	    public LD OUT_F28 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出28")]
	    public LD OUT_W28 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出29")]
	    public LA OUT_R29 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出29")]
	    public LA OUT_B29 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出29")]
	    public LD OUT_F29 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出29")]
	    public LD OUT_W29 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出30")]
	    public LA OUT_R30 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出30")]
	    public LA OUT_B30 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出30")]
	    public LD OUT_F30 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出30")]
	    public LD OUT_W30 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出31")]
	    public LA OUT_R31 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出31")]
	    public LA OUT_B31 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出31")]
	    public LD OUT_F31 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出31")]
	    public LD OUT_W31 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出32")]
	    public LA OUT_R32 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出32")]
	    public LA OUT_B32 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出32")]
	    public LD OUT_F32 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出32")]
	    public LD OUT_W32 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出33")]
	    public LA OUT_R33 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出33")]
	    public LA OUT_B33 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出33")]
	    public LD OUT_F33 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出33")]
	    public LD OUT_W33 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出34")]
	    public LA OUT_R34 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出34")]
	    public LA OUT_B34 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出34")]
	    public LD OUT_F34 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出34")]
	    public LD OUT_W34 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出35")]
	    public LA OUT_R35 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出35")]
	    public LA OUT_B35 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出35")]
	    public LD OUT_F35 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出35")]
	    public LD OUT_W35 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出36")]
	    public LA OUT_R36 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出36")]
	    public LA OUT_B36 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出36")]
	    public LD OUT_F36 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出36")]
	    public LD OUT_W36 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出37")]
	    public LA OUT_R37 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出37")]
	    public LA OUT_B37 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出37")]
	    public LD OUT_F37 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出37")]
	    public LD OUT_W37 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出38")]
	    public LA OUT_R38 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出38")]
	    public LA OUT_B38 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出38")]
	    public LD OUT_F38 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出38")]
	    public LD OUT_W38 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出39")]
	    public LA OUT_R39 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出39")]
	    public LA OUT_B39 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出39")]
	    public LD OUT_F39 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出39")]
	    public LD OUT_W39 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出40")]
	    public LA OUT_R40 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出40")]
	    public LA OUT_B40 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出40")]
	    public LD OUT_F40 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出40")]
	    public LD OUT_W40 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出41")]
	    public LA OUT_R41 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出41")]
	    public LA OUT_B41 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出41")]
	    public LD OUT_F41 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出41")]
	    public LD OUT_W41 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出42")]
	    public LA OUT_R42 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出42")]
	    public LA OUT_B42 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出42")]
	    public LD OUT_F42 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出42")]
	    public LD OUT_W42 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("重构输出43")]
	    public LA OUT_R43 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("残差输出43")]
	    public LA OUT_B43 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出43")]
	    public LD OUT_F43 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("故障输出43")]
	    public LD OUT_W43 = new LD(QualityTypes.Good, false, false, false, 0, false);

	    [PinType(PinTypes.Output)]
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[43] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[43] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[43] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA109()
		{
			ModelID = 117;
			SysID = 12;
			FcType = enumType.Warn;
			FcName = "PCA109";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""117"",""name"":""PCA109"",""description"":""辅机循环水温度"",""founder"":""admin"",""creatTime"":""2023-10-25 14:57:33"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 16:01:25"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:57:28"",""et"":""2025-11-26 04:48:20"",""duration"":1162252,""number"":3875,""filter"":1395,""mode"":2480,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1305},{""st"":""2025-11-26 18:11:44"",""et"":""2025-11-30 06:59:56"",""duration"":305292,""number"":1018,""filter"":429,""mode"":589,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":339}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10pae21ct101r"",""Description"":""#1扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""40.45"",""TMin"":""28.77"",""TAvg"":""33.27"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10pae22ct101r"",""Description"":""#2扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.28"",""lowerBound"":""-0.28"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""36.86"",""TMin"":""28.95"",""TAvg"":""32.57"",""DMax"":""0.45"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.28""},{""PointId"":""d1_10pae23ct101r"",""Description"":""#3扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""38.25"",""TMin"":""26.60"",""TAvg"":""33.38"",""DMax"":""0.82"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10pae24ct101r"",""Description"":""#4扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""36.55"",""TMin"":""29.09"",""TAvg"":""32.48"",""DMax"":""0.64"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10pae21ct103r"",""Description"":""#1扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""37.83"",""TMin"":""28.31"",""TAvg"":""30.95"",""DMax"":""0.32"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.26""},{""PointId"":""d1_10pae22ct103r"",""Description"":""#2扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""35.71"",""TMin"":""28.58"",""TAvg"":""31.33"",""DMax"":""0.30"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.19"",""C99"":""0.23""},{""PointId"":""d1_10pae23ct103r"",""Description"":""#3扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""35.38"",""TMin"":""26.31"",""TAvg"":""31.15"",""DMax"":""0.32"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.26""},{""PointId"":""d1_10pae24ct103r"",""Description"":""#4扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""36.49"",""TMin"":""28.72"",""TAvg"":""31.68"",""DMax"":""0.54"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10pae21ct102r"",""Description"":""#1扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.10"",""lowerBound"":""-0.10"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""39.07"",""TMin"":""28.87"",""TAvg"":""32.08"",""DMax"":""0.24"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.08"",""C99"":""0.10""},{""PointId"":""d1_10pae22ct102r"",""Description"":""#2扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""36.28"",""TMin"":""28.78"",""TAvg"":""32.04"",""DMax"":""0.28"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.10"",""C99"":""0.13""},{""PointId"":""d1_10pae23ct102r"",""Description"":""#3扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.17"",""lowerBound"":""-0.17"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""35.97"",""TMin"":""26.26"",""TAvg"":""32.10"",""DMax"":""0.33"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10pae24ct102r"",""Description"":""#4扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.36"",""lowerBound"":""-0.36"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""36.14"",""TMin"":""28.94"",""TAvg"":""32.11"",""DMax"":""0.46"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.29"",""C99"":""0.36""},{""PointId"":""d1_10pae25ct101r"",""Description"":""#5扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.13"",""lowerBound"":""-0.13"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""38.55"",""TMin"":""28.33"",""TAvg"":""32.32"",""DMax"":""0.19"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.11"",""C99"":""0.13""},{""PointId"":""d1_10pae26ct101r"",""Description"":""#6扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""36.46"",""TMin"":""28.06"",""TAvg"":""32.16"",""DMax"":""0.80"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10pae27ct101r"",""Description"":""#7扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.41"",""lowerBound"":""-0.41"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""36.34"",""TMin"":""28.49"",""TAvg"":""32.26"",""DMax"":""0.74"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.33"",""C99"":""0.41""},{""PointId"":""d1_10pae28ct101r"",""Description"":""#8扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""36.26"",""TMin"":""28.54"",""TAvg"":""32.15"",""DMax"":""0.74"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10pae25ct102r"",""Description"":""#5扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.08"",""lowerBound"":""-0.08"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""38.30"",""TMin"":""28.26"",""TAvg"":""32.09"",""DMax"":""0.15"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.06"",""C99"":""0.08""},{""PointId"":""d1_10pae26ct102r"",""Description"":""#6扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.43"",""lowerBound"":""-0.43"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""36.38"",""TMin"":""28.09"",""TAvg"":""32.09"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.35"",""C99"":""0.43""},{""PointId"":""d1_10pae27ct102r"",""Description"":""#7扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.40"",""lowerBound"":""-0.40"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""36.24"",""TMin"":""28.36"",""TAvg"":""32.09"",""DMax"":""0.66"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.33"",""C99"":""0.40""},{""PointId"":""d1_10pae28ct102r"",""Description"":""#8扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""36.28"",""TMin"":""28.55"",""TAvg"":""32.10"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10pae25ct103r"",""Description"":""#5扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.15"",""lowerBound"":""-0.15"",""LAY_TABLE_INDEX"":21,""type"":null,""TMax"":""38.13"",""TMin"":""28.14"",""TAvg"":""31.84"",""DMax"":""0.25"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.13"",""C99"":""0.15""},{""PointId"":""d1_10pae26ct103r"",""Description"":""#6扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.44"",""lowerBound"":""-0.44"",""LAY_TABLE_INDEX"":22,""type"":null,""TMax"":""36.20"",""TMin"":""27.85"",""TAvg"":""31.68"",""DMax"":""0.76"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10pae27ct103r"",""Description"":""#7扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.42"",""lowerBound"":""-0.42"",""LAY_TABLE_INDEX"":23,""type"":null,""TMax"":""35.99"",""TMin"":""27.98"",""TAvg"":""31.57"",""DMax"":""0.75"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.35"",""C99"":""0.42""},{""PointId"":""d1_10pae28ct103r"",""Description"":""#8扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.48"",""lowerBound"":""-0.48"",""LAY_TABLE_INDEX"":24,""type"":null,""TMax"":""35.77"",""TMin"":""28.23"",""TAvg"":""31.58"",""DMax"":""0.75"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.39"",""C99"":""0.48""},{""PointId"":""d1_10pae29ct101r"",""Description"":""#9扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.58"",""lowerBound"":""-0.58"",""LAY_TABLE_INDEX"":25,""type"":null,""TMax"":""36.62"",""TMin"":""28.67"",""TAvg"":""32.72"",""DMax"":""0.98"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.47"",""C99"":""0.58""},{""PointId"":""d1_10pae30ct101r"",""Description"":""#10扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.45"",""lowerBound"":""-0.45"",""LAY_TABLE_INDEX"":26,""type"":null,""TMax"":""36.41"",""TMin"":""28.84"",""TAvg"":""32.46"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.37"",""C99"":""0.45""},{""PointId"":""d1_10pae29ct102r"",""Description"":""#9扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.48"",""lowerBound"":""-0.48"",""LAY_TABLE_INDEX"":27,""type"":null,""TMax"":""36.09"",""TMin"":""28.52"",""TAvg"":""32.10"",""DMax"":""0.65"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.39"",""C99"":""0.48""},{""PointId"":""d1_10pae30ct102r"",""Description"":""#10扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.47"",""lowerBound"":""-0.47"",""LAY_TABLE_INDEX"":28,""type"":null,""TMax"":""36.25"",""TMin"":""28.70"",""TAvg"":""32.09"",""DMax"":""0.81"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.38"",""C99"":""0.47""},{""PointId"":""d1_10pae29ct103r"",""Description"":""#9扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.59"",""lowerBound"":""-0.59"",""LAY_TABLE_INDEX"":29,""type"":null,""TMax"":""35.90"",""TMin"":""28.29"",""TAvg"":""31.40"",""DMax"":""0.80"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.48"",""C99"":""0.59""},{""PointId"":""d1_10pae30ct103r"",""Description"":""#10扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.48"",""lowerBound"":""-0.48"",""LAY_TABLE_INDEX"":30,""type"":null,""TMax"":""35.44"",""TMin"":""28.67"",""TAvg"":""31.40"",""DMax"":""0.81"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.39"",""C99"":""0.48""},{""PointId"":""d1_10pae31ct101r"",""Description"":""#11扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.52"",""lowerBound"":""-0.52"",""LAY_TABLE_INDEX"":31,""type"":null,""TMax"":""37.57"",""TMin"":""28.67"",""TAvg"":""33.29"",""DMax"":""0.73"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.42"",""C99"":""0.52""},{""PointId"":""d1_10pae32ct101r"",""Description"":""#12扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.19"",""lowerBound"":""-0.19"",""LAY_TABLE_INDEX"":32,""type"":null,""TMax"":""36.48"",""TMin"":""28.67"",""TAvg"":""32.25"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.15"",""C99"":""0.19""},{""PointId"":""d1_10pae33ct101r"",""Description"":""#13扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.50"",""lowerBound"":""-0.50"",""LAY_TABLE_INDEX"":33,""type"":null,""TMax"":""36.94"",""TMin"":""29.18"",""TAvg"":""32.73"",""DMax"":""0.63"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.41"",""C99"":""0.50""},{""PointId"":""d1_10pae34ct101r"",""Description"":""#14扇区冷水母管温度A"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.42"",""lowerBound"":""-0.42"",""LAY_TABLE_INDEX"":34,""type"":null,""TMax"":""36.97"",""TMin"":""22.33"",""TAvg"":""32.57"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.42""},{""PointId"":""d1_10pae31ct103r"",""Description"":""#11扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.40"",""lowerBound"":""-0.40"",""LAY_TABLE_INDEX"":35,""type"":null,""TMax"":""36.34"",""TMin"":""28.35"",""TAvg"":""31.11"",""DMax"":""0.63"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.40""},{""PointId"":""d1_10pae32ct103r"",""Description"":""#12扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":36,""type"":null,""TMax"":""55.66"",""TMin"":""29.32"",""TAvg"":""34.06"",""DMax"":""0.51"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10pae33ct103r"",""Description"":""#13扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.53"",""lowerBound"":""-0.53"",""LAY_TABLE_INDEX"":37,""type"":null,""TMax"":""36.43"",""TMin"":""28.59"",""TAvg"":""31.41"",""DMax"":""0.85"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.43"",""C99"":""0.53""},{""PointId"":""d1_10pae34ct103r"",""Description"":""#14扇区冷水母管温度C"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":38,""type"":null,""TMax"":""36.34"",""TMin"":""23.15"",""TAvg"":""31.55"",""DMax"":""0.44"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10pae31ct102r"",""Description"":""#11扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.42"",""lowerBound"":""-0.42"",""LAY_TABLE_INDEX"":39,""type"":null,""TMax"":""36.51"",""TMin"":""28.42"",""TAvg"":""32.09"",""DMax"":""0.62"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.42""},{""PointId"":""d1_10pae32ct102r"",""Description"":""#12扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.23"",""lowerBound"":""-0.23"",""LAY_TABLE_INDEX"":40,""type"":null,""TMax"":""36.33"",""TMin"":""28.58"",""TAvg"":""31.82"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.23""},{""PointId"":""d1_10pae33ct102r"",""Description"":""#13扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.42"",""lowerBound"":""-0.42"",""LAY_TABLE_INDEX"":41,""type"":null,""TMax"":""36.66"",""TMin"":""28.90"",""TAvg"":""32.12"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.34"",""C99"":""0.42""},{""PointId"":""d1_10pae34ct102r"",""Description"":""#14扇区冷水母管温度B"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.09"",""lowerBound"":""-0.09"",""LAY_TABLE_INDEX"":42,""type"":null,""TMax"":""36.29"",""TMin"":""22.54"",""TAvg"":""31.97"",""DMax"":""0.14"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.09""},{""PointId"":""d1_10pae20ct104r"",""Description"":""循环水冷水母管温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":43,""type"":null,""TMax"":""35.47"",""TMin"":""28.43"",""TAvg"":""31.02"",""DMax"":""0.80"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.22"",""C99"":""0.27""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 16:01:25"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[28.77,28.951,26.595,29.093,28.305,28.576,26.305,28.715,28.865,28.782,26.263,28.944,28.333,28.064,28.488,28.543,28.26,28.094,28.36,28.545,28.135,27.848,27.982,28.233,28.667,28.843,28.52,28.701,28.285,28.673,28.666,28.668,29.177,22.326,28.353,29.316,28.593,23.15,28.424,28.584,28.897,22.536,28.425],""Train_X_max"":[40.452,36.858,38.252,36.548,37.833,35.707,35.379,36.49,39.065,36.277,35.973,36.142,38.546,36.462,36.337,36.255,38.297,36.377,36.242,36.275,38.132,36.201,35.987,35.767,36.622,36.41,36.094,36.249,35.897,35.438,37.565,36.482,36.938,36.967,36.343,55.659,36.432,36.344,36.506,36.332,36.662,36.289,35.473],""Train_X_std"":[1.333,1.166,1.24,1.093,1.003,0.956,1.001,1.041,1.088,1.061,1.07,1.065,1.203,1.098,1.096,1.088,1.177,1.076,1.08,1.077,1.162,1.041,1.04,1.042,1.145,1.122,1.081,1.084,1.051,0.988,1.316,0.973,1.109,1.619,0.96,2.985,1.065,1.263,1.088,0.906,1.067,1.436,0.946],""Train_X_mean"":[33.271,32.571,33.376,32.477,30.947,31.326,31.15,31.679,32.078,32.038,32.096,32.11,32.315,32.162,32.263,32.152,32.093,32.092,32.094,32.096,31.839,31.682,31.569,31.575,32.719,32.459,32.095,32.087,31.397,31.404,33.286,32.245,32.732,32.567,31.108,34.06,31.414,31.548,32.085,31.823,32.118,31.968,31.019],""Train_X_bais_max"":[[0.466,0.453,0.82,0.64,0.324,0.296,0.315,0.535,0.24,0.277,0.33,0.46,0.188,0.795,0.743,0.735,0.148,0.768,0.66,0.671,0.252,0.758,0.748,0.746,0.976,0.774,0.647,0.809,0.796,0.811,0.73,0.292,0.628,0.572,0.626,0.51,0.849,0.444,0.621,0.351,0.668,0.139,0.797]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.087,0.066,0.09,0.085,0.059,0.054,0.059,0.09,0.021,0.028,0.038,0.081,0.031,0.099,0.092,0.099,0.017,0.097,0.09,0.099,0.035,0.1,0.096,0.109,0.132,0.102,0.109,0.105,0.136,0.109,0.122,0.043,0.116,0.095,0.092,0.09,0.123,0.084,0.095,0.053,0.095,0.02,0.056]],""QCUL_95"":0.891552866,""QCUL_99"":1.18447816,""QCUL_95_line"":[0.307,0.23,0.32,0.299,0.212,0.191,0.209,0.318,0.08,0.103,0.136,0.29,0.109,0.355,0.332,0.357,0.063,0.351,0.325,0.355,0.125,0.361,0.345,0.388,0.469,0.365,0.392,0.381,0.479,0.387,0.424,0.153,0.408,0.344,0.324,0.315,0.432,0.303,0.339,0.184,0.338,0.072,0.217],""QCUL_99_line"":[0.377,0.282,0.392,0.367,0.26,0.234,0.256,0.39,0.098,0.127,0.166,0.356,0.133,0.436,0.407,0.439,0.077,0.431,0.4,0.436,0.153,0.444,0.423,0.477,0.575,0.448,0.481,0.468,0.587,0.475,0.519,0.188,0.5,0.423,0.397,0.386,0.53,0.372,0.416,0.226,0.415,0.088,0.268],""T2CUL_95"":19.778,""T2CUL_99"":24.874,""T2CUL_95_line"":[0.106,0.092,0.098,0.087,0.08,0.076,0.079,0.083,0.086,0.084,0.085,0.084,0.095,0.087,0.087,0.086,0.093,0.085,0.086,0.085,0.092,0.083,0.083,0.083,0.091,0.089,0.086,0.086,0.083,0.078,0.104,0.077,0.088,0.128,0.076,0.237,0.085,0.1,0.086,0.072,0.085,0.114,0.075],""T2CUL_99_line"":[0.119,0.104,0.11,0.097,0.089,0.085,0.089,0.093,0.097,0.094,0.095,0.095,0.107,0.098,0.098,0.097,0.105,0.096,0.096,0.096,0.103,0.093,0.093,0.093,0.102,0.1,0.096,0.096,0.094,0.088,0.117,0.087,0.099,0.144,0.085,0.266,0.095,0.112,0.097,0.081,0.095,0.128,0.084],""Kesi_95"":1.697,""Kesi_99"":1.576,""Kesi_95_line"":[0.031,0.027,0.029,0.025,0.023,0.022,0.023,0.024,0.025,0.025,0.025,0.025,0.028,0.026,0.025,0.025,0.027,0.025,0.025,0.025,0.027,0.024,0.024,0.024,0.027,0.026,0.025,0.025,0.024,0.023,0.031,0.023,0.026,0.038,0.022,0.069,0.025,0.029,0.025,0.021,0.025,0.033,0.022],""Kesi_99_line"":[0.03,0.026,0.028,0.024,0.022,0.021,0.022,0.023,0.024,0.024,0.024,0.024,0.027,0.025,0.025,0.024,0.026,0.024,0.024,0.024,0.026,0.023,0.023,0.023,0.026,0.025,0.024,0.024,0.024,0.022,0.029,0.022,0.025,0.036,0.022,0.067,0.024,0.028,0.024,0.02,0.024,0.032,0.021],""COV"":[[1.0,0.895,0.916,0.9,0.766,0.803,0.761,0.84,0.944,0.871,0.874,0.875,0.809,0.878,0.874,0.873,0.793,0.87,0.864,0.864,0.761,0.841,0.83,0.821,0.898,0.889,0.859,0.869,0.787,0.791,0.918,0.852,0.898,0.669,0.664,0.508,0.795,0.537,0.867,0.809,0.867,0.63,0.8],[0.895,1.0,0.945,0.949,0.733,0.945,0.869,0.919,0.87,0.991,0.946,0.939,0.85,0.955,0.95,0.948,0.838,0.949,0.944,0.941,0.813,0.932,0.921,0.911,0.953,0.958,0.94,0.944,0.891,0.888,0.959,0.918,0.943,0.691,0.78,0.569,0.886,0.586,0.94,0.886,0.932,0.663,0.893],[0.916,0.945,1.0,0.931,0.655,0.859,0.834,0.864,0.842,0.923,0.953,0.903,0.805,0.92,0.917,0.913,0.788,0.912,0.907,0.903,0.753,0.881,0.87,0.858,0.941,0.928,0.898,0.908,0.822,0.832,0.953,0.879,0.924,0.691,0.701,0.607,0.813,0.56,0.905,0.838,0.89,0.653,0.824],[0.9,0.949,0.931,1.0,0.799,0.924,0.891,0.977,0.906,0.952,0.95,0.993,0.857,0.961,0.956,0.952,0.849,0.959,0.953,0.95,0.828,0.946,0.937,0.93,0.951,0.956,0.946,0.949,0.907,0.915,0.936,0.93,0.97,0.687,0.829,0.594,0.923,0.623,0.945,0.914,0.963,0.675,0.926],[0.766,0.733,0.655,0.799,1.0,0.814,0.863,0.859,0.934,0.776,0.797,0.831,0.763,0.804,0.801,0.804,0.771,0.813,0.811,0.814,0.783,0.835,0.836,0.841,0.748,0.793,0.812,0.811,0.848,0.856,0.696,0.799,0.792,0.503,0.865,0.4,0.874,0.568,0.804,0.83,0.837,0.537,0.892],[0.803,0.945,0.859,0.924,0.814,1.0,0.922,0.935,0.859,0.978,0.929,0.934,0.836,0.938,0.934,0.933,0.836,0.942,0.939,0.937,0.83,0.946,0.943,0.94,0.909,0.93,0.937,0.936,0.933,0.942,0.869,0.899,0.915,0.61,0.895,0.601,0.925,0.611,0.929,0.909,0.932,0.621,0.95],[0.761,0.869,0.834,0.891,0.863,0.922,1.0,0.936,0.861,0.902,0.96,0.916,0.807,0.917,0.914,0.915,0.81,0.923,0.921,0.921,0.812,0.937,0.935,0.935,0.869,0.908,0.918,0.919,0.936,0.94,0.83,0.891,0.878,0.591,0.915,0.522,0.933,0.61,0.911,0.906,0.914,0.609,0.956],[0.84,0.919,0.864,0.977,0.859,0.935,0.936,1.0,0.903,0.939,0.942,0.991,0.85,0.953,0.948,0.947,0.848,0.956,0.95,0.949,0.84,0.959,0.952,0.948,0.917,0.943,0.946,0.945,0.941,0.94,0.892,0.932,0.945,0.657,0.889,0.554,0.96,0.635,0.941,0.932,0.964,0.66,0.963],[0.944,0.87,0.842,0.906,0.934,0.859,0.861,0.903,1.0,0.878,0.891,0.909,0.838,0.897,0.893,0.895,0.833,0.897,0.893,0.894,0.821,0.892,0.887,0.884,0.88,0.898,0.89,0.896,0.869,0.875,0.866,0.881,0.902,0.629,0.81,0.484,0.887,0.587,0.892,0.872,0.908,0.624,0.898],[0.871,0.991,0.923,0.952,0.776,0.978,0.902,0.939,0.878,1.0,0.953,0.95,0.857,0.961,0.957,0.956,0.85,0.96,0.956,0.953,0.832,0.951,0.943,0.936,0.949,0.961,0.952,0.955,0.921,0.923,0.937,0.924,0.946,0.669,0.837,0.589,0.915,0.605,0.95,0.908,0.946,0.656,0.928],[0.874,0.946,0.953,0.95,0.797,0.929,0.96,0.942,0.891,0.953,1.0,0.951,0.843,0.96,0.957,0.956,0.836,0.959,0.956,0.954,0.82,0.951,0.945,0.938,0.944,0.959,0.95,0.955,0.921,0.926,0.931,0.926,0.94,0.671,0.848,0.581,0.916,0.612,0.95,0.913,0.943,0.66,0.932],[0.875,0.939,0.903,0.993,0.831,0.934,0.916,0.991,0.909,0.95,0.951,1.0,0.856,0.963,0.958,0.956,0.85,0.963,0.957,0.956,0.836,0.957,0.95,0.945,0.941,0.957,0.952,0.955,0.93,0.934,0.922,0.937,0.964,0.678,0.864,0.58,0.947,0.634,0.951,0.928,0.97,0.673,0.946],[0.809,0.85,0.805,0.857,0.763,0.836,0.807,0.85,0.838,0.857,0.843,0.856,1.0,0.863,0.86,0.859,0.999,0.863,0.86,0.859,0.992,0.859,0.855,0.85,0.849,0.853,0.857,0.85,0.834,0.831,0.823,0.83,0.851,0.598,0.761,0.468,0.832,0.556,0.843,0.821,0.855,0.593,0.868],[0.878,0.955,0.92,0.961,0.804,0.938,0.917,0.953,0.897,0.961,0.96,0.963,0.863,1.0,0.982,0.978,0.857,0.999,0.981,0.977,0.84,0.993,0.971,0.963,0.965,0.978,0.973,0.974,0.945,0.947,0.947,0.939,0.958,0.682,0.867,0.588,0.935,0.626,0.968,0.927,0.961,0.672,0.95],[0.874,0.95,0.917,0.956,0.801,0.934,0.914,0.948,0.893,0.957,0.957,0.958,0.86,0.982,1.0,0.98,0.853,0.981,0.999,0.979,0.837,0.975,0.99,0.965,0.965,0.976,0.974,0.973,0.947,0.947,0.945,0.94,0.957,0.681,0.867,0.59,0.936,0.627,0.967,0.928,0.961,0.672,0.948],[0.873,0.948,0.913,0.952,0.804,0.933,0.915,0.947,0.895,0.956,0.956,0.956,0.859,0.978,0.98,1.0,0.853,0.978,0.979,0.999,0.837,0.972,0.971,0.986,0.971,0.978,0.981,0.976,0.955,0.951,0.946,0.942,0.956,0.68,0.874,0.587,0.937,0.628,0.97,0.931,0.962,0.672,0.95],[0.793,0.838,0.788,0.849,0.771,0.836,0.81,0.848,0.833,0.85,0.836,0.85,0.999,0.857,0.853,0.853,1.0,0.858,0.855,0.853,0.996,0.857,0.854,0.85,0.839,0.845,0.852,0.844,0.835,0.834,0.806,0.822,0.843,0.584,0.772,0.465,0.832,0.556,0.837,0.819,0.85,0.583,0.873],[0.87,0.949,0.912,0.959,0.813,0.942,0.923,0.956,0.897,0.96,0.959,0.963,0.863,0.999,0.981,0.978,0.858,1.0,0.982,0.978,0.843,0.996,0.975,0.967,0.962,0.976,0.973,0.974,0.95,0.954,0.939,0.939,0.955,0.674,0.88,0.589,0.94,0.629,0.968,0.93,0.962,0.668,0.956],[0.864,0.944,0.907,0.953,0.811,0.939,0.921,0.95,0.893,0.956,0.956,0.957,0.86,0.981,0.999,0.979,0.855,0.982,1.0,0.979,0.841,0.978,0.995,0.97,0.961,0.974,0.974,0.973,0.953,0.954,0.936,0.939,0.954,0.672,0.88,0.588,0.942,0.629,0.967,0.931,0.962,0.667,0.955],[0.864,0.941,0.903,0.95,0.814,0.937,0.921,0.949,0.894,0.953,0.954,0.956,0.859,0.977,0.979,0.999,0.853,0.978,0.979,1.0,0.84,0.974,0.974,0.992,0.966,0.976,0.981,0.976,0.961,0.958,0.937,0.942,0.953,0.672,0.886,0.588,0.943,0.63,0.97,0.935,0.962,0.668,0.957],[0.761,0.813,0.753,0.828,0.783,0.83,0.812,0.84,0.821,0.832,0.82,0.836,0.992,0.84,0.837,0.837,0.996,0.843,0.841,0.84,1.0,0.849,0.847,0.844,0.815,0.825,0.839,0.829,0.832,0.832,0.775,0.807,0.821,0.556,0.786,0.448,0.831,0.549,0.822,0.812,0.837,0.563,0.873],[0.841,0.932,0.881,0.946,0.835,0.946,0.937,0.959,0.892,0.951,0.951,0.957,0.859,0.993,0.975,0.972,0.857,0.996,0.978,0.974,0.849,1.0,0.979,0.972,0.945,0.966,0.97,0.969,0.96,0.964,0.914,0.933,0.943,0.651,0.906,0.575,0.951,0.629,0.962,0.934,0.959,0.654,0.97],[0.83,0.921,0.87,0.937,0.836,0.943,0.935,0.952,0.887,0.943,0.945,0.95,0.855,0.971,0.99,0.971,0.854,0.975,0.995,0.974,0.847,0.979,1.0,0.976,0.942,0.961,0.969,0.967,0.963,0.966,0.905,0.93,0.939,0.641,0.912,0.572,0.951,0.627,0.959,0.934,0.957,0.647,0.969],[0.821,0.911,0.858,0.93,0.841,0.94,0.935,0.948,0.884,0.936,0.938,0.945,0.85,0.963,0.965,0.986,0.85,0.967,0.97,0.992,0.844,0.972,0.976,1.0,0.938,0.957,0.973,0.965,0.973,0.97,0.896,0.931,0.932,0.634,0.92,0.58,0.954,0.63,0.957,0.938,0.954,0.644,0.973],[0.898,0.953,0.941,0.951,0.748,0.909,0.869,0.917,0.88,0.949,0.944,0.941,0.849,0.965,0.965,0.971,0.839,0.962,0.961,0.966,0.815,0.945,0.942,0.938,1.0,0.974,0.983,0.965,0.93,0.919,0.961,0.926,0.961,0.686,0.82,0.599,0.895,0.606,0.959,0.904,0.946,0.667,0.908],[0.889,0.958,0.928,0.956,0.793,0.93,0.908,0.943,0.898,0.961,0.959,0.957,0.853,0.978,0.976,0.978,0.845,0.976,0.974,0.976,0.825,0.966,0.961,0.957,0.974,1.0,0.977,0.997,0.943,0.961,0.961,0.944,0.961,0.69,0.858,0.588,0.931,0.621,0.975,0.928,0.962,0.675,0.939],[0.859,0.94,0.898,0.946,0.812,0.937,0.918,0.946,0.89,0.952,0.95,0.952,0.857,0.973,0.974,0.981,0.852,0.973,0.974,0.981,0.839,0.97,0.969,0.973,0.983,0.977,1.0,0.978,0.982,0.96,0.935,0.94,0.953,0.67,0.887,0.587,0.943,0.63,0.969,0.934,0.962,0.666,0.956],[0.869,0.944,0.908,0.949,0.811,0.936,0.919,0.945,0.896,0.955,0.955,0.955,0.85,0.974,0.973,0.976,0.844,0.974,0.973,0.976,0.829,0.969,0.967,0.965,0.965,0.997,0.978,1.0,0.955,0.977,0.944,0.942,0.955,0.674,0.885,0.591,0.941,0.628,0.976,0.934,0.962,0.668,0.95],[0.787,0.891,0.822,0.907,0.848,0.933,0.936,0.941,0.869,0.921,0.921,0.93,0.834,0.945,0.947,0.955,0.835,0.95,0.953,0.961,0.832,0.96,0.963,0.973,0.93,0.943,0.982,0.955,1.0,0.969,0.873,0.921,0.911,0.628,0.927,0.559,0.959,0.633,0.946,0.933,0.944,0.641,0.97],[0.791,0.888,0.832,0.915,0.856,0.942,0.94,0.94,0.875,0.923,0.926,0.934,0.831,0.947,0.947,0.951,0.834,0.954,0.954,0.958,0.832,0.964,0.966,0.97,0.919,0.961,0.96,0.977,0.969,1.0,0.867,0.917,0.919,0.61,0.946,0.59,0.952,0.634,0.95,0.935,0.946,0.63,0.975],[0.918,0.959,0.953,0.936,0.696,0.869,0.83,0.892,0.866,0.937,0.931,0.922,0.823,0.947,0.945,0.946,0.806,0.939,0.936,0.937,0.775,0.914,0.905,0.896,0.961,0.961,0.935,0.944,0.873,0.867,1.0,0.918,0.943,0.716,0.764,0.562,0.864,0.58,0.963,0.874,0.923,0.676,0.858],[0.852,0.918,0.879,0.93,0.799,0.899,0.891,0.932,0.881,0.924,0.926,0.937,0.83,0.939,0.94,0.942,0.822,0.939,0.939,0.942,0.807,0.933,0.93,0.931,0.926,0.944,0.94,0.942,0.921,0.917,0.918,1.0,0.945,0.671,0.84,0.591,0.932,0.618,0.939,0.99,0.952,0.662,0.925],[0.898,0.943,0.924,0.97,0.792,0.915,0.878,0.945,0.902,0.946,0.94,0.964,0.851,0.958,0.957,0.956,0.843,0.955,0.954,0.953,0.821,0.943,0.939,0.932,0.961,0.961,0.953,0.955,0.911,0.919,0.943,0.945,1.0,0.692,0.834,0.599,0.946,0.629,0.953,0.928,0.99,0.68,0.924],[0.669,0.691,0.691,0.687,0.503,0.61,0.591,0.657,0.629,0.669,0.671,0.678,0.598,0.682,0.681,0.68,0.584,0.674,0.672,0.672,0.556,0.651,0.641,0.634,0.686,0.69,0.67,0.674,0.628,0.61,0.716,0.671,0.692,1.0,0.509,0.441,0.633,0.93,0.672,0.629,0.678,0.99,0.653],[0.664,0.78,0.701,0.829,0.865,0.895,0.915,0.889,0.81,0.837,0.848,0.864,0.761,0.867,0.867,0.874,0.772,0.88,0.88,0.886,0.786,0.906,0.912,0.92,0.82,0.858,0.887,0.885,0.927,0.946,0.764,0.84,0.834,0.509,1.0,0.549,0.917,0.605,0.907,0.884,0.88,0.555,0.947],[0.508,0.569,0.607,0.594,0.4,0.601,0.522,0.554,0.484,0.589,0.581,0.58,0.468,0.588,0.59,0.587,0.465,0.589,0.588,0.588,0.448,0.575,0.572,0.58,0.599,0.588,0.587,0.591,0.559,0.59,0.562,0.591,0.599,0.441,0.549,1.0,0.542,0.453,0.59,0.605,0.583,0.455,0.567],[0.795,0.886,0.813,0.923,0.874,0.925,0.933,0.96,0.887,0.915,0.916,0.947,0.832,0.935,0.936,0.937,0.832,0.94,0.942,0.943,0.831,0.951,0.951,0.954,0.895,0.931,0.943,0.941,0.959,0.952,0.864,0.932,0.946,0.633,0.917,0.542,1.0,0.637,0.936,0.943,0.982,0.645,0.969],[0.537,0.586,0.56,0.623,0.568,0.611,0.61,0.635,0.587,0.605,0.612,0.634,0.556,0.626,0.627,0.628,0.556,0.629,0.629,0.63,0.549,0.629,0.627,0.63,0.606,0.621,0.63,0.628,0.633,0.634,0.58,0.618,0.629,0.93,0.605,0.453,0.637,1.0,0.623,0.623,0.642,0.973,0.685],[0.867,0.94,0.905,0.945,0.804,0.929,0.911,0.941,0.892,0.95,0.95,0.951,0.843,0.968,0.967,0.97,0.837,0.968,0.967,0.97,0.822,0.962,0.959,0.957,0.959,0.975,0.969,0.976,0.946,0.95,0.963,0.939,0.953,0.672,0.907,0.59,0.936,0.623,1.0,0.928,0.959,0.665,0.942],[0.809,0.886,0.838,0.914,0.83,0.909,0.906,0.932,0.872,0.908,0.913,0.928,0.821,0.927,0.928,0.931,0.819,0.93,0.931,0.935,0.812,0.934,0.934,0.938,0.904,0.928,0.934,0.934,0.933,0.935,0.874,0.99,0.928,0.629,0.884,0.605,0.943,0.623,0.928,1.0,0.947,0.638,0.945],[0.867,0.932,0.89,0.963,0.837,0.932,0.914,0.964,0.908,0.946,0.943,0.97,0.855,0.961,0.961,0.962,0.85,0.962,0.962,0.962,0.837,0.959,0.957,0.954,0.946,0.962,0.962,0.962,0.944,0.946,0.923,0.952,0.99,0.678,0.88,0.583,0.982,0.642,0.959,0.947,1.0,0.676,0.956],[0.63,0.663,0.653,0.675,0.537,0.621,0.609,0.66,0.624,0.656,0.66,0.673,0.593,0.672,0.672,0.672,0.583,0.668,0.667,0.668,0.563,0.654,0.647,0.644,0.667,0.675,0.666,0.668,0.641,0.63,0.676,0.662,0.68,0.99,0.555,0.455,0.645,0.973,0.665,0.638,0.676,1.0,0.677],[0.8,0.893,0.824,0.926,0.892,0.95,0.956,0.963,0.898,0.928,0.932,0.946,0.868,0.95,0.948,0.95,0.873,0.956,0.955,0.957,0.873,0.97,0.969,0.973,0.908,0.939,0.956,0.95,0.97,0.975,0.858,0.925,0.924,0.653,0.947,0.567,0.969,0.685,0.942,0.945,0.956,0.677,1.0]],""K"":11,""R"":0.989,""featValue"":[37.425,1.584,0.944,0.813,0.581,0.414,0.213,0.206,0.143,0.13,0.104,0.084,0.073,0.063,0.056,0.052,0.051,0.019,0.012,0.009,0.006,0.005,0.004,0.004,0.003,0.002,0.002,0.002,0.001,0.001,0.001,0.001,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.145,-0.027,0.243,-0.271,-0.108,-0.421,-0.109,-0.174,0.012,0.065,-0.012,0.0,-0.004,-0.001,-0.071,0.03,-0.088,0.503,-0.264,0.171,0.046,0.081,0.14,0.145,-0.071,0.04,-0.122,0.064,-0.095,0.029,-0.145,-0.076,-0.115,0.273,-0.101,-0.186,0.0,0.003,-0.01,-0.011,0.001,0.01,-0.009],[0.156,-0.003,0.2,-0.084,-0.034,0.084,0.25,0.018,0.119,0.36,-0.051,-0.007,-0.014,0.046,0.099,-0.073,0.116,-0.222,-0.14,-0.195,0.423,0.086,0.312,-0.03,-0.028,0.144,-0.215,0.086,-0.163,-0.061,-0.189,-0.183,-0.104,-0.284,0.133,0.06,0.002,-0.022,0.008,0.017,-0.007,-0.031,-0.007],[0.15,-0.042,0.345,-0.096,-0.013,-0.018,0.214,-0.086,-0.289,-0.151,0.116,0.074,-0.082,-0.012,-0.174,0.093,-0.192,0.067,0.408,-0.339,-0.094,0.214,0.012,-0.247,-0.054,0.081,-0.187,0.116,-0.168,-0.089,0.253,0.085,0.126,0.043,-0.026,0.03,0.007,-0.008,0.002,-0.013,0.006,0.005,-0.002],[0.159,0.001,0.104,-0.042,-0.027,-0.088,0.172,0.195,0.224,-0.268,0.022,-0.019,0.288,-0.013,-0.171,0.055,-0.037,-0.007,0.096,-0.215,0.033,-0.122,0.012,0.441,0.273,0.024,-0.29,-0.226,0.375,-0.069,-0.091,0.061,0.023,-0.033,-0.07,0.045,0.046,0.024,0.008,-0.009,-0.013,0.003,-0.004],[0.138,0.11,-0.375,-0.038,-0.127,-0.513,0.022,-0.159,0.006,0.081,-0.075,0.007,-0.005,0.011,0.075,-0.007,0.085,-0.456,0.264,-0.132,-0.061,-0.074,-0.104,-0.093,0.056,0.087,-0.122,0.048,-0.074,0.004,-0.134,-0.07,-0.12,0.256,-0.11,-0.155,0.009,0.023,-0.01,-0.014,-0.005,0.01,0.005],[0.156,0.062,-0.028,0.088,0.05,0.072,0.393,-0.043,0.211,0.447,-0.035,0.022,-0.027,0.019,-0.132,0.069,-0.116,0.187,0.14,0.224,-0.46,-0.081,-0.312,0.079,0.006,0.025,-0.091,0.068,-0.081,0.022,-0.151,-0.107,0.073,-0.158,0.064,0.027,-0.008,0.004,0.005,-0.006,-0.004,-0.002,-0.005],[0.153,0.079,-0.158,0.106,-0.077,0.027,0.381,-0.079,-0.47,-0.165,0.048,0.109,-0.079,0.03,0.131,-0.04,0.105,-0.059,-0.306,0.268,0.057,-0.194,-0.025,0.307,0.041,0.108,-0.178,0.048,-0.156,-0.119,0.273,0.094,0.034,0.025,0.007,0.022,0.008,0.01,0.001,0.002,0.0,-0.002,-0.001],[0.159,0.036,-0.064,0.022,-0.06,-0.06,0.21,0.237,0.178,-0.254,-0.037,-0.029,0.334,0.031,0.045,-0.033,0.188,0.042,-0.237,-0.001,-0.116,0.119,-0.094,-0.317,-0.425,0.158,-0.057,0.341,0.221,0.164,0.071,0.064,-0.045,0.01,0.047,-0.012,-0.041,-0.015,-0.001,0.004,-0.001,0.008,0.013],[0.151,0.041,-0.056,-0.17,-0.127,-0.491,-0.061,-0.174,0.006,0.078,-0.038,-0.004,-0.007,0.012,0.016,0.002,0.016,0.045,-0.019,0.037,0.034,0.016,0.005,-0.034,0.0,-0.111,0.225,-0.088,0.17,-0.023,0.258,0.154,0.224,-0.5,0.196,0.327,-0.017,-0.024,0.02,0.017,0.004,-0.017,0.005],[0.159,0.022,0.11,-0.018,-0.002,0.081,0.299,-0.003,0.154,0.394,-0.035,0.0,-0.024,0.039,0.009,-0.028,0.032,-0.068,-0.012,0.003,0.154,0.011,0.109,-0.044,0.015,-0.146,0.308,-0.14,0.253,0.046,0.344,0.298,0.008,0.428,-0.195,-0.078,-0.003,0.017,-0.012,-0.011,0.01,0.032,0.013],[0.159,0.02,0.085,0.003,-0.057,0.012,0.301,-0.076,-0.404,-0.162,0.086,0.082,-0.086,0.019,0.014,0.013,-0.002,0.014,0.058,0.04,0.033,0.021,0.022,-0.136,0.01,-0.179,0.346,-0.128,0.324,0.202,-0.514,-0.161,-0.14,-0.069,0.01,-0.04,-0.021,0.0,-0.001,0.002,-0.007,-0.001,0.002],[0.16,0.016,0.026,-0.004,-0.047,-0.072,0.169,0.212,0.208,-0.263,0.023,-0.023,0.314,0.004,-0.072,0.007,0.091,0.014,0.165,0.269,0.115,0.024,0.082,-0.098,0.182,-0.164,0.333,-0.127,-0.572,-0.096,0.013,-0.108,0.019,0.015,0.015,-0.023,-0.01,0.002,-0.006,-0.001,0.008,-0.009,-0.005],[0.145,0.058,-0.097,-0.383,0.355,0.085,-0.036,0.03,-0.031,-0.017,0.034,-0.003,0.005,0.0,0.021,-0.02,0.036,-0.029,0.097,-0.034,0.023,-0.054,-0.035,0.212,-0.086,-0.161,0.182,0.422,0.013,-0.216,-0.101,0.095,-0.019,-0.004,-0.039,0.008,0.487,-0.204,-0.007,0.14,0.076,-0.014,-0.018],[0.161,0.02,0.066,0.005,-0.038,0.077,-0.015,-0.074,0.05,-0.101,-0.192,-0.223,-0.012,-0.119,0.305,0.015,-0.249,-0.05,0.114,0.001,0.025,0.009,-0.02,0.166,-0.079,-0.071,0.013,-0.012,-0.005,0.204,0.099,0.008,0.004,0.037,0.504,-0.296,0.155,0.006,-0.022,-0.455,0.015,-0.049,-0.05],[0.161,0.019,0.065,0.016,-0.038,0.089,-0.075,-0.081,0.03,-0.101,-0.249,-0.136,-0.197,0.018,-0.212,0.127,0.272,-0.066,0.073,-0.037,0.008,0.015,-0.037,0.231,-0.25,0.013,0.062,-0.063,-0.11,0.296,0.096,-0.141,-0.051,-0.072,-0.233,0.146,0.063,0.079,-0.04,-0.006,-0.05,0.36,-0.435],[0.161,0.021,0.055,0.022,-0.044,0.091,-0.135,-0.092,-0.004,-0.032,-0.115,0.148,0.079,0.27,-0.095,-0.309,-0.13,-0.159,-0.034,0.07,-0.128,0.207,-0.016,0.092,-0.228,0.137,0.079,-0.228,0.019,-0.32,-0.076,-0.015,0.0,0.025,0.063,-0.002,0.017,-0.09,0.008,-0.091,0.047,0.464,0.347],[0.144,0.069,-0.133,-0.37,0.372,0.087,-0.028,0.018,-0.029,-0.02,0.037,-0.001,-0.001,-0.007,-0.004,-0.007,0.002,-0.018,0.0,-0.076,0.001,-0.026,-0.019,0.11,-0.034,-0.072,0.06,0.106,-0.001,-0.089,0.013,-0.066,-0.003,0.009,0.003,0.012,-0.692,0.275,-0.002,-0.226,-0.104,0.013,0.014],[0.161,0.028,0.042,0.021,-0.032,0.076,-0.011,-0.078,0.052,-0.102,-0.195,-0.225,-0.012,-0.126,0.297,0.026,-0.277,-0.015,0.09,0.033,0.017,-0.005,-0.008,0.072,-0.031,-0.007,-0.005,0.01,0.001,0.041,0.03,-0.002,-0.038,0.017,0.05,-0.037,-0.24,-0.02,0.026,0.757,-0.046,0.086,0.094],[0.161,0.028,0.036,0.03,-0.035,0.094,-0.068,-0.086,0.033,-0.098,-0.254,-0.136,-0.202,0.016,-0.229,0.138,0.266,-0.015,0.029,-0.018,-0.002,0.006,-0.026,0.101,-0.096,-0.004,0.016,-0.032,-0.046,0.106,0.028,-0.037,-0.027,0.0,-0.097,0.051,-0.023,-0.091,0.048,-0.041,0.069,-0.486,0.607],[0.161,0.029,0.029,0.039,-0.037,0.091,-0.136,-0.094,-0.001,-0.03,-0.12,0.155,0.083,0.278,-0.103,-0.321,-0.132,-0.089,0.032,0.085,-0.054,0.097,-0.01,0.035,-0.115,0.055,0.02,-0.094,0.049,-0.123,0.001,-0.001,-0.03,0.029,-0.002,-0.016,-0.039,0.022,-0.007,0.103,-0.055,-0.602,-0.475],[0.142,0.088,-0.197,-0.355,0.385,0.096,-0.013,0.012,-0.036,-0.018,0.032,-0.013,-0.007,-0.003,0.005,-0.002,0.01,0.028,-0.044,0.181,-0.021,0.082,0.052,-0.294,0.104,0.238,-0.246,-0.487,-0.003,0.301,0.076,-0.004,0.017,-0.009,0.031,-0.01,0.198,-0.067,0.008,0.08,0.027,0.002,0.007],[0.161,0.049,-0.03,0.05,-0.032,0.09,0.004,-0.079,0.052,-0.095,-0.216,-0.234,-0.015,-0.127,0.326,0.025,-0.277,0.06,-0.078,0.065,-0.023,-0.012,0.049,-0.219,0.108,0.078,-0.022,0.032,0.028,-0.233,-0.119,0.006,0.031,-0.05,-0.522,0.325,0.076,0.024,-0.003,-0.308,0.032,-0.036,-0.037],[0.16,0.056,-0.047,0.065,-0.03,0.107,-0.057,-0.096,0.04,-0.092,-0.262,-0.146,-0.21,0.008,-0.267,0.155,0.255,0.077,-0.074,0.093,0.002,-0.027,0.081,-0.302,0.311,-0.008,-0.087,0.106,0.154,-0.383,-0.117,0.182,0.068,0.066,0.307,-0.177,-0.045,0.019,-0.009,0.044,-0.019,0.129,-0.169],[0.16,0.058,-0.07,0.09,-0.018,0.095,-0.124,-0.097,0.002,-0.02,-0.149,0.178,0.087,0.287,-0.126,-0.348,-0.153,0.148,0.054,-0.056,0.17,-0.28,0.026,-0.128,0.308,-0.164,-0.113,0.317,-0.037,0.417,0.056,0.029,0.023,-0.057,-0.06,0.027,0.016,0.065,-0.001,-0.021,0.008,0.145,0.134],[0.158,0.0,0.172,-0.024,-0.026,0.077,-0.174,-0.102,0.047,-0.001,0.074,0.285,0.116,-0.039,-0.047,0.414,-0.156,-0.366,-0.277,0.099,-0.101,0.196,-0.068,0.03,0.27,0.087,0.102,0.174,0.014,0.15,0.034,-0.036,0.05,-0.022,-0.029,-0.016,-0.013,-0.033,-0.41,0.015,0.009,-0.018,0.02],[0.161,0.012,0.099,0.009,-0.064,0.064,-0.104,-0.074,-0.016,0.044,0.134,0.009,0.063,-0.378,-0.029,-0.226,0.126,-0.11,-0.127,-0.021,-0.054,0.109,-0.19,-0.021,-0.044,-0.386,-0.239,-0.084,-0.17,0.086,-0.228,0.321,-0.043,0.211,0.152,0.384,-0.019,0.017,-0.006,0.004,0.001,0.0,-0.02],[0.161,0.029,0.025,0.043,-0.034,0.1,-0.16,-0.084,0.019,0.039,0.02,0.332,0.14,-0.003,0.135,0.335,0.04,-0.023,-0.006,0.001,0.003,0.007,-0.004,0.003,0.009,0.013,0.016,0.014,-0.004,0.016,-0.011,0.009,0.021,0.022,-0.001,-0.01,0.033,0.067,0.807,-0.015,-0.024,0.021,-0.037],[0.161,0.025,0.046,0.046,-0.053,0.066,-0.115,-0.089,-0.009,0.049,0.173,0.012,0.067,-0.426,-0.071,-0.237,0.124,-0.051,0.058,0.169,0.017,0.054,-0.028,-0.078,-0.011,-0.245,-0.151,0.017,0.196,-0.131,0.261,-0.346,-0.009,-0.25,-0.235,-0.394,0.03,0.005,0.017,-0.003,0.016,0.018,0.029],[0.158,0.058,-0.126,0.117,-0.037,0.116,-0.139,-0.068,-0.005,0.077,-0.026,0.371,0.159,0.03,0.296,0.26,0.214,0.317,0.279,-0.067,0.098,-0.189,0.089,-0.032,-0.238,-0.082,-0.119,-0.161,0.014,-0.133,-0.021,0.038,-0.058,-0.001,0.025,0.028,-0.024,-0.031,-0.406,-0.002,0.012,-0.001,0.019],[0.158,0.069,-0.12,0.146,-0.005,0.061,-0.073,-0.118,0.007,0.04,0.15,0.039,0.069,-0.478,-0.192,-0.191,-0.012,0.122,0.072,-0.116,0.02,-0.154,0.185,0.086,0.016,0.582,0.325,0.066,-0.022,0.063,-0.069,0.074,0.048,0.052,0.086,0.056,-0.014,-0.018,-0.011,-0.005,-0.013,-0.018,-0.007],[0.154,-0.035,0.267,-0.09,-0.099,0.059,-0.152,-0.021,-0.025,0.046,0.271,-0.242,0.024,0.211,0.189,-0.053,0.205,0.02,-0.03,-0.108,0.026,-0.206,-0.443,-0.052,0.091,0.218,0.1,-0.09,-0.117,-0.008,-0.072,0.315,-0.101,-0.213,-0.139,-0.273,-0.037,0.02,-0.014,-0.01,-0.003,0.002,-0.007],[0.157,0.009,0.043,0.044,-0.034,-0.057,-0.194,0.442,-0.342,0.238,-0.131,-0.136,0.123,0.0,-0.019,0.031,0.005,-0.061,0.001,0.03,0.03,-0.06,0.041,0.02,-0.103,-0.009,-0.038,-0.009,-0.013,0.057,-0.173,-0.032,0.654,0.082,-0.067,-0.1,-0.005,0.033,-0.022,0.027,-0.011,-0.014,0.001],[0.159,-0.006,0.106,-0.02,-0.033,-0.074,-0.064,0.258,0.176,-0.102,0.177,0.131,-0.37,-0.03,-0.112,0.058,-0.252,-0.168,-0.068,0.09,-0.016,-0.498,0.103,-0.135,-0.217,-0.069,-0.055,-0.053,-0.016,-0.016,0.006,0.018,-0.064,-0.003,0.007,0.005,-0.141,-0.41,0.045,-0.06,0.01,0.017,-0.062],[0.116,-0.552,0.004,-0.1,-0.06,0.035,-0.023,0.016,-0.027,0.013,-0.018,-0.007,0.003,0.033,0.173,-0.107,0.192,-0.042,0.012,-0.025,-0.44,-0.074,0.345,0.017,0.121,-0.026,0.017,0.029,-0.012,0.044,0.036,0.007,-0.035,-0.01,-0.006,0.013,0.053,-0.039,-0.007,-0.008,-0.486,-0.004,0.054],[0.146,0.114,-0.299,0.253,0.021,0.042,-0.033,-0.145,0.046,0.007,0.432,-0.306,0.027,0.219,-0.12,0.158,-0.135,-0.005,-0.028,-0.02,-0.073,0.203,0.393,0.091,-0.134,-0.171,-0.078,0.016,-0.074,0.075,-0.09,0.25,0.022,-0.145,-0.101,-0.142,-0.019,0.02,0.008,-0.003,0.012,0.0,0.002],[0.098,-0.095,0.288,0.519,0.689,-0.338,-0.016,-0.079,0.017,-0.044,-0.042,0.018,-0.017,0.02,0.11,-0.05,0.105,-0.037,-0.033,0.013,0.01,-0.011,-0.005,-0.006,0.01,0.003,0.0,-0.002,0.005,-0.007,-0.006,0.0,0.003,0.003,0.001,-0.002,0.001,-0.002,0.001,-0.001,-0.001,0.001,-0.001],[0.157,0.052,-0.151,0.088,-0.069,-0.027,-0.026,0.284,0.126,-0.052,0.086,0.175,-0.39,0.026,0.251,-0.154,0.136,0.185,0.101,-0.033,0.052,0.488,-0.101,0.154,0.242,0.062,0.004,0.083,0.025,0.084,-0.013,0.008,0.088,0.014,-0.048,-0.012,-0.139,-0.329,0.02,-0.045,0.006,0.019,-0.055],[0.11,-0.539,-0.283,0.075,0.04,0.007,0.044,-0.055,0.021,0.012,0.02,-0.003,-0.001,-0.038,-0.203,0.122,-0.219,0.047,0.005,0.074,0.476,0.096,-0.355,-0.031,-0.126,0.024,-0.027,-0.016,0.015,-0.053,-0.038,0.027,0.028,0.001,-0.013,-0.009,0.043,-0.025,-0.009,-0.023,-0.318,0.002,0.031],[0.16,0.023,0.053,0.048,-0.057,0.057,-0.127,-0.077,0.006,0.038,0.401,-0.305,0.029,0.244,0.063,0.035,0.091,0.026,0.071,0.076,0.061,-0.077,-0.079,-0.033,0.078,0.057,-0.01,0.075,0.166,-0.06,0.141,-0.481,0.04,0.319,0.209,0.367,0.044,-0.029,0.004,0.007,-0.012,0.001,0.009],[0.156,0.04,-0.053,0.116,0.008,-0.074,-0.178,0.429,-0.339,0.246,-0.127,-0.124,0.126,-0.032,-0.138,0.098,-0.123,0.056,0.043,0.016,-0.051,0.092,0.0,0.009,0.11,0.011,0.02,0.015,0.019,-0.044,0.164,0.043,-0.621,-0.08,0.061,0.1,-0.002,-0.026,0.022,-0.032,0.01,0.013,0.001],[0.16,0.017,-0.002,0.025,-0.048,-0.054,-0.048,0.268,0.152,-0.076,0.136,0.155,-0.382,-0.005,0.051,-0.038,-0.08,-0.002,-0.025,0.02,-0.015,-0.001,0.012,-0.026,-0.064,0.029,0.029,-0.006,0.003,-0.06,-0.003,0.001,-0.038,-0.013,0.048,0.016,0.271,0.74,-0.063,0.099,-0.015,-0.034,0.119],[0.115,-0.556,-0.106,-0.034,-0.02,0.023,0.004,-0.011,-0.008,0.011,-0.002,-0.004,0.003,0.007,0.024,-0.016,0.031,-0.015,0.016,0.003,-0.073,-0.022,0.063,0.02,0.025,0.015,-0.005,0.01,0.01,0.024,-0.001,-0.01,-0.002,0.004,0.016,0.008,-0.104,0.067,0.018,0.024,0.792,0.005,-0.081],[0.159,0.033,-0.197,0.073,0.025,0.01,0.049,-0.003,-0.001,0.003,-0.048,0.012,-0.005,-0.009,-0.019,0.006,-0.082,0.155,-0.452,-0.628,-0.149,-0.051,-0.133,-0.063,0.05,-0.18,0.153,-0.198,-0.158,-0.09,0.094,-0.269,0.05,0.037,0.034,-0.099,0.089,-0.071,-0.01,0.068,0.011,-0.025,-0.042]],""selectVec"":[[0.145,-0.027,0.243,-0.271,-0.108,-0.421,-0.109,-0.174,0.012,0.065,-0.012],[0.156,-0.003,0.2,-0.084,-0.034,0.084,0.25,0.018,0.119,0.36,-0.051],[0.15,-0.042,0.345,-0.096,-0.013,-0.018,0.214,-0.086,-0.289,-0.151,0.116],[0.159,0.001,0.104,-0.042,-0.027,-0.088,0.172,0.195,0.224,-0.268,0.022],[0.138,0.11,-0.375,-0.038,-0.127,-0.513,0.022,-0.159,0.006,0.081,-0.075],[0.156,0.062,-0.028,0.088,0.05,0.072,0.393,-0.043,0.211,0.447,-0.035],[0.153,0.079,-0.158,0.106,-0.077,0.027,0.381,-0.079,-0.47,-0.165,0.048],[0.159,0.036,-0.064,0.022,-0.06,-0.06,0.21,0.237,0.178,-0.254,-0.037],[0.151,0.041,-0.056,-0.17,-0.127,-0.491,-0.061,-0.174,0.006,0.078,-0.038],[0.159,0.022,0.11,-0.018,-0.002,0.081,0.299,-0.003,0.154,0.394,-0.035],[0.159,0.02,0.085,0.003,-0.057,0.012,0.301,-0.076,-0.404,-0.162,0.086],[0.16,0.016,0.026,-0.004,-0.047,-0.072,0.169,0.212,0.208,-0.263,0.023],[0.145,0.058,-0.097,-0.383,0.355,0.085,-0.036,0.03,-0.031,-0.017,0.034],[0.161,0.02,0.066,0.005,-0.038,0.077,-0.015,-0.074,0.05,-0.101,-0.192],[0.161,0.019,0.065,0.016,-0.038,0.089,-0.075,-0.081,0.03,-0.101,-0.249],[0.161,0.021,0.055,0.022,-0.044,0.091,-0.135,-0.092,-0.004,-0.032,-0.115],[0.144,0.069,-0.133,-0.37,0.372,0.087,-0.028,0.018,-0.029,-0.02,0.037],[0.161,0.028,0.042,0.021,-0.032,0.076,-0.011,-0.078,0.052,-0.102,-0.195],[0.161,0.028,0.036,0.03,-0.035,0.094,-0.068,-0.086,0.033,-0.098,-0.254],[0.161,0.029,0.029,0.039,-0.037,0.091,-0.136,-0.094,-0.001,-0.03,-0.12],[0.142,0.088,-0.197,-0.355,0.385,0.096,-0.013,0.012,-0.036,-0.018,0.032],[0.161,0.049,-0.03,0.05,-0.032,0.09,0.004,-0.079,0.052,-0.095,-0.216],[0.16,0.056,-0.047,0.065,-0.03,0.107,-0.057,-0.096,0.04,-0.092,-0.262],[0.16,0.058,-0.07,0.09,-0.018,0.095,-0.124,-0.097,0.002,-0.02,-0.149],[0.158,0.0,0.172,-0.024,-0.026,0.077,-0.174,-0.102,0.047,-0.001,0.074],[0.161,0.012,0.099,0.009,-0.064,0.064,-0.104,-0.074,-0.016,0.044,0.134],[0.161,0.029,0.025,0.043,-0.034,0.1,-0.16,-0.084,0.019,0.039,0.02],[0.161,0.025,0.046,0.046,-0.053,0.066,-0.115,-0.089,-0.009,0.049,0.173],[0.158,0.058,-0.126,0.117,-0.037,0.116,-0.139,-0.068,-0.005,0.077,-0.026],[0.158,0.069,-0.12,0.146,-0.005,0.061,-0.073,-0.118,0.007,0.04,0.15],[0.154,-0.035,0.267,-0.09,-0.099,0.059,-0.152,-0.021,-0.025,0.046,0.271],[0.157,0.009,0.043,0.044,-0.034,-0.057,-0.194,0.442,-0.342,0.238,-0.131],[0.159,-0.006,0.106,-0.02,-0.033,-0.074,-0.064,0.258,0.176,-0.102,0.177],[0.116,-0.552,0.004,-0.1,-0.06,0.035,-0.023,0.016,-0.027,0.013,-0.018],[0.146,0.114,-0.299,0.253,0.021,0.042,-0.033,-0.145,0.046,0.007,0.432],[0.098,-0.095,0.288,0.519,0.689,-0.338,-0.016,-0.079,0.017,-0.044,-0.042],[0.157,0.052,-0.151,0.088,-0.069,-0.027,-0.026,0.284,0.126,-0.052,0.086],[0.11,-0.539,-0.283,0.075,0.04,0.007,0.044,-0.055,0.021,0.012,0.02],[0.16,0.023,0.053,0.048,-0.057,0.057,-0.127,-0.077,0.006,0.038,0.401],[0.156,0.04,-0.053,0.116,0.008,-0.074,-0.178,0.429,-0.339,0.246,-0.127],[0.16,0.017,-0.002,0.025,-0.048,-0.054,-0.048,0.268,0.152,-0.076,0.136],[0.115,-0.556,-0.106,-0.034,-0.02,0.023,0.004,-0.011,-0.008,0.011,-0.002],[0.159,0.033,-0.197,0.073,0.025,0.01,0.049,-0.003,-0.001,0.003,-0.048]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":4893,""AfterCleanSamNum"":3142,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""机组负荷大于350MW"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""11"",""precision"":""98.9%"",""rate"":""0.988"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":117,""version"":""v-2025-12-04 16:01:25"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "," + IN21 + "," + IN22 + "," + IN23 + "," + IN24 + "," + IN25 + "," + IN26 + "," + IN27 + "," + IN28 + "," + IN29 + "," + IN30 + "," + IN31 + "," + IN32 + "," + IN33 + "," + IN34 + "," + IN35 + "," + IN36 + "," + IN37 + "," + IN38 + "," + IN39 + "," + IN40 + "," + IN41 + "," + IN42 + "," + IN43 + "]],\"Target_Data\":[[]]}";
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
	        OUT_R22[0] = reconData[0][21];
	        OUT_B22[0] = errorData[0][21];
	        OUT_F22[0] = paraState[0][21];
	        OUT_R23[0] = reconData[0][22];
	        OUT_B23[0] = errorData[0][22];
	        OUT_F23[0] = paraState[0][22];
	        OUT_R24[0] = reconData[0][23];
	        OUT_B24[0] = errorData[0][23];
	        OUT_F24[0] = paraState[0][23];
	        OUT_R25[0] = reconData[0][24];
	        OUT_B25[0] = errorData[0][24];
	        OUT_F25[0] = paraState[0][24];
	        OUT_R26[0] = reconData[0][25];
	        OUT_B26[0] = errorData[0][25];
	        OUT_F26[0] = paraState[0][25];
	        OUT_R27[0] = reconData[0][26];
	        OUT_B27[0] = errorData[0][26];
	        OUT_F27[0] = paraState[0][26];
	        OUT_R28[0] = reconData[0][27];
	        OUT_B28[0] = errorData[0][27];
	        OUT_F28[0] = paraState[0][27];
	        OUT_R29[0] = reconData[0][28];
	        OUT_B29[0] = errorData[0][28];
	        OUT_F29[0] = paraState[0][28];
	        OUT_R30[0] = reconData[0][29];
	        OUT_B30[0] = errorData[0][29];
	        OUT_F30[0] = paraState[0][29];
	        OUT_R31[0] = reconData[0][30];
	        OUT_B31[0] = errorData[0][30];
	        OUT_F31[0] = paraState[0][30];
	        OUT_R32[0] = reconData[0][31];
	        OUT_B32[0] = errorData[0][31];
	        OUT_F32[0] = paraState[0][31];
	        OUT_R33[0] = reconData[0][32];
	        OUT_B33[0] = errorData[0][32];
	        OUT_F33[0] = paraState[0][32];
	        OUT_R34[0] = reconData[0][33];
	        OUT_B34[0] = errorData[0][33];
	        OUT_F34[0] = paraState[0][33];
	        OUT_R35[0] = reconData[0][34];
	        OUT_B35[0] = errorData[0][34];
	        OUT_F35[0] = paraState[0][34];
	        OUT_R36[0] = reconData[0][35];
	        OUT_B36[0] = errorData[0][35];
	        OUT_F36[0] = paraState[0][35];
	        OUT_R37[0] = reconData[0][36];
	        OUT_B37[0] = errorData[0][36];
	        OUT_F37[0] = paraState[0][36];
	        OUT_R38[0] = reconData[0][37];
	        OUT_B38[0] = errorData[0][37];
	        OUT_F38[0] = paraState[0][37];
	        OUT_R39[0] = reconData[0][38];
	        OUT_B39[0] = errorData[0][38];
	        OUT_F39[0] = paraState[0][38];
	        OUT_R40[0] = reconData[0][39];
	        OUT_B40[0] = errorData[0][39];
	        OUT_F40[0] = paraState[0][39];
	        OUT_R41[0] = reconData[0][40];
	        OUT_B41[0] = errorData[0][40];
	        OUT_F41[0] = paraState[0][40];
	        OUT_R42[0] = reconData[0][41];
	        OUT_B42[0] = errorData[0][41];
	        OUT_F42[0] = paraState[0][41];
	        OUT_R43[0] = reconData[0][42];
	        OUT_B43[0] = errorData[0][42];
	        OUT_F43[0] = paraState[0][42];
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[43] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18,IN19,IN20,IN21,IN22,IN23,IN24,IN25,IN26,IN27,IN28,IN29,IN30,IN31,IN32,IN33,IN34,IN35,IN36,IN37,IN38,IN39,IN40,IN41,IN42,IN43};
			float[] arrOUT_B = new float[43] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18,OUT_B19,OUT_B20,OUT_B21,OUT_B22,OUT_B23,OUT_B24,OUT_B25,OUT_B26,OUT_B27,OUT_B28,OUT_B29,OUT_B30,OUT_B31,OUT_B32,OUT_B33,OUT_B34,OUT_B35,OUT_B36,OUT_B37,OUT_B38,OUT_B39,OUT_B40,OUT_B41,OUT_B42,OUT_B43};
			LD[] arrOUT_W = new LD[43] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18,OUT_W19,OUT_W20,OUT_W21,OUT_W22,OUT_W23,OUT_W24,OUT_W25,OUT_W26,OUT_W27,OUT_W28,OUT_W29,OUT_W30,OUT_W31,OUT_W32,OUT_W33,OUT_W34,OUT_W35,OUT_W36,OUT_W37,OUT_W38,OUT_W39,OUT_W40,OUT_W41,OUT_W42,OUT_W43 };
			
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