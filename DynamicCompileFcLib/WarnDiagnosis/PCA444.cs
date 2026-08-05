using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA444")]
    [FCDisplay("PCA444")]
    public partial class PCA444 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁136号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁136号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁136号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁136号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁137号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁137号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁137号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁137号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁137号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁137号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁138号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁138号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁138号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁138号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁138号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁138号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁139号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁139号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁139号屏3号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁139号屏4号管壁温")]
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

		public PCA444()
		{
			ModelID = 485;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA444";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""485"",""name"":""PCA444"",""description"":""中温分隔屏过热器水冷壁26-21-40"",""founder"":""admin"",""creatTime"":""2025-12-10 17:08:36"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:10:12"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 12:23:52"",""et"":""2025-12-07 07:51:42"",""duration"":2316470,""number"":7722,""filter"":2586,""mode"":5136,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2496}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah26ct121k"",""Description"":""中温（分隔屏）过热器水冷壁136号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""566.69"",""TMin"":""488.20"",""TAvg"":""532.36"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.57"",""C99"":""3.15""},{""PointId"":""d1_10hah26ct122k"",""Description"":""中温（分隔屏）过热器水冷壁136号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""573.41"",""TMin"":""494.97"",""TAvg"":""538.51"",""DMax"":""2.87"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.85"",""C99"":""2.27""},{""PointId"":""d1_10hah26ct123k"",""Description"":""中温（分隔屏）过热器水冷壁136号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""574.32"",""TMin"":""496.57"",""TAvg"":""539.22"",""DMax"":""5.21"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.85"",""C99"":""3.50""},{""PointId"":""d1_10hah26ct124k"",""Description"":""中温（分隔屏）过热器水冷壁136号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""573.50"",""TMin"":""497.24"",""TAvg"":""539.37"",""DMax"":""6.01"",""DMin"":""0.00"",""DAvg"":""1.21"",""C95"":""4.17"",""C99"":""5.10""},{""PointId"":""d1_10hah26ct125k"",""Description"":""中温（分隔屏）过热器水冷壁137号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""566.54"",""TMin"":""488.05"",""TAvg"":""532.72"",""DMax"":""4.75"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.68"",""C99"":""3.29""},{""PointId"":""d1_10hah26ct126k"",""Description"":""中温（分隔屏）过热器水冷壁137号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""567.30"",""TMin"":""489.31"",""TAvg"":""533.52"",""DMax"":""2.38"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.74"",""C99"":""2.13""},{""PointId"":""d1_10hah26ct127k"",""Description"":""中温（分隔屏）过热器水冷壁137号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""568.91"",""TMin"":""489.94"",""TAvg"":""534.69"",""DMax"":""2.64"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.95"",""C99"":""2.38""},{""PointId"":""d1_10hah26ct128k"",""Description"":""中温（分隔屏）过热器水冷壁137号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""573.12"",""TMin"":""493.20"",""TAvg"":""538.50"",""DMax"":""2.22"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.70"",""C99"":""2.08""},{""PointId"":""d1_10hah26ct129k"",""Description"":""中温（分隔屏）过热器水冷壁137号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""573.61"",""TMin"":""493.94"",""TAvg"":""538.63"",""DMax"":""3.48"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.14"",""C99"":""2.62""},{""PointId"":""d1_10hah26ct130k"",""Description"":""中温（分隔屏）过热器水冷壁137号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""573.46"",""TMin"":""495.32"",""TAvg"":""539.07"",""DMax"":""4.04"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""2.97"",""C99"":""3.63""},{""PointId"":""d1_10hah26ct131k"",""Description"":""中温（分隔屏）过热器水冷壁138号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""565.64"",""TMin"":""487.52"",""TAvg"":""532.55"",""DMax"":""4.96"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.67"",""C99"":""3.27""},{""PointId"":""d1_10hah26ct132k"",""Description"":""中温（分隔屏）过热器水冷壁138号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""567.83"",""TMin"":""489.34"",""TAvg"":""534.80"",""DMax"":""2.60"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.97"",""C99"":""2.41""},{""PointId"":""d1_10hah26ct133k"",""Description"":""中温（分隔屏）过热器水冷壁138号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""566.65"",""TMin"":""486.83"",""TAvg"":""532.82"",""DMax"":""2.59"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.46"",""C99"":""3.01""},{""PointId"":""d1_10hah26ct134k"",""Description"":""中温（分隔屏）过热器水冷壁138号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""573.76"",""TMin"":""493.66"",""TAvg"":""539.79"",""DMax"":""2.17"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.58"",""C99"":""1.94""},{""PointId"":""d1_10hah26ct135k"",""Description"":""中温（分隔屏）过热器水冷壁138号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""573.53"",""TMin"":""493.96"",""TAvg"":""539.75"",""DMax"":""3.60"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.64"",""C99"":""3.23""},{""PointId"":""d1_10hah26ct136k"",""Description"":""中温（分隔屏）过热器水冷壁138号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""572.64"",""TMin"":""494.72"",""TAvg"":""539.84"",""DMax"":""4.42"",""DMin"":""0.00"",""DAvg"":""1.16"",""C95"":""3.93"",""C99"":""4.81""},{""PointId"":""d1_10hah26ct137k"",""Description"":""中温（分隔屏）过热器水冷壁139号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""565.74"",""TMin"":""488.62"",""TAvg"":""533.39"",""DMax"":""5.18"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.21"",""C99"":""3.93""},{""PointId"":""d1_10hah26ct138k"",""Description"":""中温（分隔屏）过热器水冷壁139号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""566.38"",""TMin"":""487.28"",""TAvg"":""533.62"",""DMax"":""4.41"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.08"",""C99"":""3.77""},{""PointId"":""d1_10hah26ct139k"",""Description"":""中温（分隔屏）过热器水冷壁139号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""564.94"",""TMin"":""485.03"",""TAvg"":""531.99"",""DMax"":""4.95"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.38"",""C99"":""4.14""},{""PointId"":""d1_10hah26ct140k"",""Description"":""中温（分隔屏）过热器水冷壁139号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""571.20"",""TMin"":""491.26"",""TAvg"":""537.67"",""DMax"":""2.85"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.60"",""C99"":""1.96""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:10:12"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[488.198,494.969,496.568,497.243,488.05,489.307,489.942,493.2,493.94,495.317,487.52,489.34,486.833,493.66,493.96,494.72,488.617,487.283,485.025,491.26],""Train_X_max"":[566.69,573.407,574.318,573.5,566.539,567.297,568.911,573.117,573.614,573.456,565.638,567.833,566.65,573.762,573.525,572.638,565.738,566.383,564.94,571.2],""Train_X_std"":[10.054,9.972,9.925,9.894,9.897,9.892,9.983,9.918,9.949,9.94,9.817,9.873,9.974,9.875,9.857,9.803,9.702,9.823,9.903,9.786],""Train_X_mean"":[532.359,538.506,539.223,539.368,532.724,533.515,534.687,538.5,538.628,539.067,532.547,534.797,532.823,539.788,539.749,539.841,533.385,533.616,531.993,537.667],""Train_X_bais_max"":[[3.551,2.866,5.206,6.007,4.75,2.377,2.638,2.221,3.484,4.04,4.956,2.598,2.59,2.169,3.604,4.424,5.181,4.408,4.952,2.85]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.746,0.535,0.821,1.208,0.775,0.509,0.565,0.495,0.619,0.865,0.764,0.569,0.721,0.455,0.768,1.161,0.93,0.901,0.976,0.456]],""QCUL_95"":0.6299438,""QCUL_99"":1.12836289,""QCUL_95_line"":[2.571,1.853,2.852,4.168,2.683,1.742,1.945,1.702,2.137,2.968,2.665,1.965,2.459,1.58,2.641,3.932,3.208,3.079,3.376,1.596],""QCUL_99_line"":[3.148,2.27,3.495,5.104,3.287,2.133,2.382,2.084,2.617,3.633,3.267,2.406,3.008,1.936,3.234,4.808,3.929,3.769,4.136,1.956],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.275,0.273,0.272,0.271,0.271,0.271,0.273,0.271,0.272,0.272,0.269,0.27,0.273,0.27,0.27,0.268,0.265,0.269,0.271,0.268],""T2CUL_99_line"":[0.362,0.359,0.357,0.356,0.356,0.356,0.359,0.357,0.358,0.357,0.353,0.355,0.359,0.355,0.354,0.353,0.349,0.353,0.356,0.352],""Kesi_95"":1.557,""Kesi_99"":1.32,""Kesi_95_line"":[0.175,0.174,0.173,0.172,0.172,0.172,0.174,0.173,0.173,0.173,0.171,0.172,0.174,0.172,0.172,0.171,0.169,0.171,0.172,0.17],""Kesi_99_line"":[0.161,0.16,0.159,0.159,0.159,0.159,0.16,0.159,0.159,0.159,0.157,0.158,0.16,0.158,0.158,0.157,0.156,0.157,0.159,0.157],""COV"":[[1.0,0.992,0.985,0.975,0.996,0.998,1.0,0.99,0.988,0.983,0.995,0.998,0.999,0.991,0.984,0.975,0.993,0.995,0.996,0.992],[0.992,1.0,0.998,0.994,0.989,0.994,0.994,0.999,0.999,0.997,0.988,0.991,0.99,0.999,0.997,0.993,0.984,0.985,0.984,0.995],[0.985,0.998,1.0,0.998,0.983,0.989,0.988,0.998,0.999,0.999,0.981,0.985,0.983,0.997,0.999,0.997,0.976,0.977,0.975,0.992],[0.975,0.994,0.998,1.0,0.973,0.98,0.979,0.994,0.996,0.998,0.971,0.976,0.972,0.993,0.997,0.998,0.966,0.966,0.963,0.985],[0.996,0.989,0.983,0.973,1.0,0.998,0.996,0.989,0.987,0.982,0.999,0.998,0.996,0.989,0.982,0.974,0.998,0.996,0.994,0.992],[0.998,0.994,0.989,0.98,0.998,1.0,0.999,0.993,0.992,0.988,0.997,0.999,0.998,0.993,0.988,0.981,0.995,0.996,0.995,0.995],[1.0,0.994,0.988,0.979,0.996,0.999,1.0,0.993,0.991,0.986,0.995,0.999,0.999,0.993,0.988,0.979,0.994,0.996,0.996,0.995],[0.99,0.999,0.998,0.994,0.989,0.993,0.993,1.0,0.999,0.998,0.989,0.992,0.99,1.0,0.998,0.995,0.985,0.986,0.985,0.997],[0.988,0.999,0.999,0.996,0.987,0.992,0.991,0.999,1.0,0.999,0.986,0.989,0.988,0.999,0.999,0.996,0.982,0.983,0.981,0.995],[0.983,0.997,0.999,0.998,0.982,0.988,0.986,0.998,0.999,1.0,0.981,0.985,0.982,0.997,0.999,0.998,0.976,0.977,0.975,0.992],[0.995,0.988,0.981,0.971,0.999,0.997,0.995,0.989,0.986,0.981,1.0,0.998,0.997,0.989,0.983,0.974,0.999,0.998,0.995,0.994],[0.998,0.991,0.985,0.976,0.998,0.999,0.999,0.992,0.989,0.985,0.998,1.0,0.999,0.993,0.987,0.979,0.997,0.999,0.997,0.996],[0.999,0.99,0.983,0.972,0.996,0.998,0.999,0.99,0.988,0.982,0.997,0.999,1.0,0.991,0.984,0.974,0.996,0.998,0.998,0.995],[0.991,0.999,0.997,0.993,0.989,0.993,0.993,1.0,0.999,0.997,0.989,0.993,0.991,1.0,0.999,0.994,0.986,0.987,0.986,0.998],[0.984,0.997,0.999,0.997,0.982,0.988,0.988,0.998,0.999,0.999,0.983,0.987,0.984,0.999,1.0,0.998,0.979,0.98,0.978,0.994],[0.975,0.993,0.997,0.998,0.974,0.981,0.979,0.995,0.996,0.998,0.974,0.979,0.974,0.994,0.998,1.0,0.97,0.971,0.968,0.988],[0.993,0.984,0.976,0.966,0.998,0.995,0.994,0.985,0.982,0.976,0.999,0.997,0.996,0.986,0.979,0.97,1.0,0.999,0.997,0.993],[0.995,0.985,0.977,0.966,0.996,0.996,0.996,0.986,0.983,0.977,0.998,0.999,0.998,0.987,0.98,0.971,0.999,1.0,0.999,0.994],[0.996,0.984,0.975,0.963,0.994,0.995,0.996,0.985,0.981,0.975,0.995,0.997,0.998,0.986,0.978,0.968,0.997,0.999,1.0,0.993],[0.992,0.995,0.992,0.985,0.992,0.995,0.995,0.997,0.995,0.992,0.994,0.996,0.995,0.998,0.994,0.988,0.993,0.994,0.993,1.0]],""K"":1,""R"":0.99,""featValue"":[19.814,0.151,0.016,0.012,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.171,0.484,0.149,0.032,0.044,0.194,0.272,0.061,0.195,-0.207,0.35,0.217,-0.009,0.416,0.164,0.274,-0.037,-0.105,-0.09],[-0.224,-0.133,0.253,0.009,-0.32,-0.432,0.078,0.154,-0.019,0.1,0.035,0.136,0.151,-0.317,-0.243,-0.098,-0.522,0.023,-0.073,0.221],[-0.223,-0.257,0.184,-0.063,-0.087,0.0,-0.299,-0.019,-0.317,-0.368,-0.022,-0.127,0.348,-0.192,0.045,-0.098,0.179,-0.002,0.44,-0.317],[-0.222,-0.383,0.084,-0.168,0.247,-0.124,-0.209,0.38,0.009,-0.158,0.434,0.024,-0.098,0.22,-0.11,0.133,0.226,-0.062,-0.369,0.107],[-0.224,0.201,0.067,-0.528,-0.14,0.05,-0.008,0.122,-0.14,0.222,-0.069,-0.346,-0.048,0.171,0.228,-0.519,0.046,0.124,-0.098,0.128],[-0.224,0.121,0.214,-0.204,0.26,-0.073,-0.299,-0.299,-0.027,0.356,0.043,-0.065,-0.135,0.024,-0.072,0.426,-0.204,0.393,0.068,-0.238],[-0.224,0.133,0.346,0.114,0.16,-0.043,-0.062,-0.087,-0.12,-0.125,-0.327,-0.101,-0.506,0.062,-0.256,-0.032,0.05,-0.469,0.154,0.201],[-0.224,-0.139,-0.016,0.058,-0.204,-0.418,0.09,-0.325,0.502,-0.262,-0.202,-0.136,-0.127,0.132,0.125,-0.086,0.154,0.117,-0.215,-0.277],[-0.224,-0.187,0.024,-0.023,-0.242,0.425,-0.154,-0.23,0.237,-0.032,-0.177,-0.042,0.202,-0.015,-0.094,0.219,0.156,0.172,-0.016,0.597],[-0.223,-0.269,-0.021,-0.11,0.041,0.456,-0.042,0.106,0.432,0.087,0.045,0.259,-0.163,0.051,0.05,-0.232,-0.367,-0.191,0.212,-0.278],[-0.224,0.215,-0.184,-0.402,-0.169,0.122,0.325,0.024,0.065,-0.015,0.095,-0.136,0.03,-0.395,-0.233,0.341,0.166,-0.328,-0.109,-0.229],[-0.224,0.172,0.001,-0.013,0.278,-0.021,0.13,-0.423,-0.03,-0.263,0.453,0.152,-0.037,-0.259,0.419,-0.124,-0.1,-0.063,0.015,0.272],[-0.224,0.205,0.15,0.259,-0.074,0.304,0.312,-0.006,-0.158,-0.214,0.2,0.101,-0.091,0.125,-0.431,-0.219,0.066,0.448,-0.102,-0.17],[-0.224,-0.12,-0.094,0.186,-0.278,-0.143,0.271,-0.116,-0.097,0.347,0.357,-0.103,0.04,0.452,0.042,0.138,0.096,-0.19,0.405,0.053],[-0.224,-0.236,-0.156,0.145,0.089,0.188,0.123,-0.186,-0.429,-0.02,-0.254,-0.137,0.182,0.185,0.141,0.101,-0.35,-0.19,-0.462,-0.137],[-0.222,-0.347,-0.299,0.029,0.453,-0.123,0.37,0.124,-0.044,0.199,-0.268,-0.032,-0.083,-0.272,-0.05,-0.1,0.182,0.265,0.21,0.113],[-0.223,0.273,-0.371,-0.24,-0.043,-0.159,-0.024,0.211,-0.093,-0.372,-0.234,0.387,-0.003,0.332,0.046,0.215,-0.168,0.122,0.209,0.105],[-0.223,0.272,-0.231,0.118,0.249,-0.128,-0.3,-0.156,0.137,0.238,-0.015,0.186,0.452,0.071,-0.335,-0.31,0.16,-0.226,-0.104,-0.033],[-0.223,0.29,-0.111,0.403,0.121,0.047,-0.115,0.4,0.253,-0.114,0.076,-0.564,0.089,-0.07,0.134,0.114,-0.218,0.047,0.077,0.036],[-0.224,0.015,-0.328,0.278,-0.366,0.028,-0.383,0.064,-0.221,0.198,0.036,0.192,-0.418,-0.297,0.178,-0.033,0.177,0.048,-0.138,-0.065]],""selectVec"":[[-0.224],[-0.224],[-0.223],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.222],[-0.223],[-0.223],[-0.223],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7722,""AfterCleanSamNum"":5136,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":485,""version"":""v-2025-12-10 17:10:12"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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