using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA420")]
    [FCDisplay("PCA420")]
    public partial class PCA420 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁57号屏2号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁57号屏3号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁57号屏4号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁57号屏5号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁57号屏6号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁58号屏1号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁58号屏2号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁58号屏3号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁58号屏4号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁58号屏5号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁58号屏6号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁59号屏1号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁59号屏2号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁59号屏3号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁59号屏4号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁59号屏5号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁59号屏6号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁60号屏1号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁60号屏2号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁60号屏3号管壁温")]
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

		public PCA420()
		{
			ModelID = 461;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA420";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""461"",""name"":""PCA420"",""description"":""中温分隔屏过热器水冷壁21-41-60"",""founder"":""admin"",""creatTime"":""2025-12-09 10:11:07"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:13:26"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 16:18:46"",""et"":""2025-12-05 15:41:30"",""duration"":2244164,""number"":7481,""filter"":2521,""mode"":4960,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2431}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah21ct141k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""565.00"",""TMin"":""475.63"",""TAvg"":""531.48"",""DMax"":""4.33"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.78"",""C99"":""3.40""},{""PointId"":""d1_10hah21ct142k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""563.73"",""TMin"":""473.53"",""TAvg"":""530.23"",""DMax"":""5.40"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.75"",""C99"":""3.37""},{""PointId"":""d1_10hah21ct143k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""570.58"",""TMin"":""481.93"",""TAvg"":""536.32"",""DMax"":""3.88"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.76"",""C99"":""2.15""},{""PointId"":""d1_10hah21ct144k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""572.25"",""TMin"":""483.92"",""TAvg"":""538.33"",""DMax"":""3.77"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.89"",""C99"":""3.54""},{""PointId"":""d1_10hah21ct145k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""571.12"",""TMin"":""483.95"",""TAvg"":""537.54"",""DMax"":""5.26"",""DMin"":""0.00"",""DAvg"":""1.10"",""C95"":""3.74"",""C99"":""4.58""},{""PointId"":""d1_10hah21ct146k"",""Description"":""中温（分隔屏）过热器水冷壁58号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""568.73"",""TMin"":""481.73"",""TAvg"":""533.63"",""DMax"":""5.25"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.14"",""C99"":""3.85""},{""PointId"":""d1_10hah21ct147k"",""Description"":""中温（分隔屏）过热器水冷壁58号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""569.25"",""TMin"":""481.25"",""TAvg"":""534.91"",""DMax"":""2.55"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.48"",""C99"":""3.04""},{""PointId"":""d1_10hah21ct148k"",""Description"":""中温（分隔屏）过热器水冷壁58号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""567.20"",""TMin"":""478.40"",""TAvg"":""533.13"",""DMax"":""2.03"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.12"",""C99"":""2.59""},{""PointId"":""d1_10hah21ct149k"",""Description"":""中温（分隔屏）过热器水冷壁58号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""572.87"",""TMin"":""485.37"",""TAvg"":""538.28"",""DMax"":""2.20"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.37"",""C99"":""1.68""},{""PointId"":""d1_10hah21ct150k"",""Description"":""中温（分隔屏）过热器水冷壁58号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""572.73"",""TMin"":""485.43"",""TAvg"":""538.24"",""DMax"":""2.95"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.90"",""C99"":""2.33""},{""PointId"":""d1_10hah21ct151k"",""Description"":""中温（分隔屏）过热器水冷壁58号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""576.07"",""TMin"":""489.77"",""TAvg"":""541.89"",""DMax"":""4.53"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.11"",""C99"":""3.80""},{""PointId"":""d1_10hah21ct152k"",""Description"":""中温（分隔屏）过热器水冷壁59号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""566.72"",""TMin"":""479.85"",""TAvg"":""532.14"",""DMax"":""3.69"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.93"",""C99"":""3.59""},{""PointId"":""d1_10hah21ct153k"",""Description"":""中温（分隔屏）过热器水冷壁59号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""566.83"",""TMin"":""479.43"",""TAvg"":""533.26"",""DMax"":""2.36"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.13"",""C99"":""2.60""},{""PointId"":""d1_10hah21ct154k"",""Description"":""中温（分隔屏）过热器水冷壁59号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""567.98"",""TMin"":""479.97"",""TAvg"":""534.78"",""DMax"":""2.46"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.01"",""C99"":""2.45""},{""PointId"":""d1_10hah21ct155k"",""Description"":""中温（分隔屏）过热器水冷壁59号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""574.00"",""TMin"":""488.20"",""TAvg"":""539.78"",""DMax"":""2.60"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.98"",""C99"":""2.42""},{""PointId"":""d1_10hah21ct156k"",""Description"":""中温（分隔屏）过热器水冷壁59号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""577.23"",""TMin"":""491.50"",""TAvg"":""543.29"",""DMax"":""4.42"",""DMin"":""0.00"",""DAvg"":""1.03"",""C95"":""3.49"",""C99"":""4.27""},{""PointId"":""d1_10hah21ct157k"",""Description"":""中温（分隔屏）过热器水冷壁59号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""577.97"",""TMin"":""493.23"",""TAvg"":""544.37"",""DMax"":""6.21"",""DMin"":""0.00"",""DAvg"":""1.35"",""C95"":""4.59"",""C99"":""5.61""},{""PointId"":""d1_10hah21ct158k"",""Description"":""中温（分隔屏）过热器水冷壁60号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""565.62"",""TMin"":""480.04"",""TAvg"":""532.21"",""DMax"":""2.96"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.37"",""C99"":""2.90""},{""PointId"":""d1_10hah21ct159k"",""Description"":""中温（分隔屏）过热器水冷壁60号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""566.28"",""TMin"":""479.20"",""TAvg"":""533.31"",""DMax"":""3.61"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.29"",""C99"":""2.80""},{""PointId"":""d1_10hah21ct160k"",""Description"":""中温（分隔屏）过热器水冷壁60号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""565.05"",""TMin"":""477.39"",""TAvg"":""532.28"",""DMax"":""3.42"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.61"",""C99"":""3.20""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:13:26"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[475.633,473.533,481.933,483.917,483.95,481.733,481.25,478.4,485.367,485.433,489.767,479.85,479.433,479.967,488.2,491.5,493.233,480.043,479.2,477.386],""Train_X_max"":[565.0,563.733,570.583,572.25,571.117,568.733,569.25,567.2,572.867,572.733,576.067,566.717,566.833,567.983,574.0,577.233,577.967,565.617,566.283,565.05],""Train_X_std"":[9.38,9.451,9.231,9.105,8.974,9.194,9.256,9.334,9.115,9.084,8.951,9.158,9.196,9.348,9.005,8.995,8.86,8.952,9.095,9.29],""Train_X_mean"":[531.476,530.225,536.322,538.327,537.542,533.631,534.912,533.13,538.276,538.238,541.892,532.141,533.26,534.777,539.782,543.285,544.366,532.212,533.31,532.284],""Train_X_bais_max"":[[4.334,5.397,3.88,3.774,5.258,5.251,2.554,2.029,2.196,2.945,4.526,3.686,2.356,2.456,2.604,4.421,6.213,2.964,3.605,3.423]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.817,0.801,0.497,0.851,1.103,0.903,0.738,0.627,0.399,0.554,0.904,0.856,0.63,0.586,0.577,1.029,1.348,0.686,0.655,0.763]],""QCUL_95"":0.7407447,""QCUL_99"":1.31887043,""QCUL_95_line"":[2.783,2.75,1.755,2.894,3.741,3.14,2.483,2.12,1.373,1.902,3.107,2.929,2.125,2.005,1.979,3.494,4.586,2.366,2.285,2.612],""QCUL_99_line"":[3.404,3.366,2.153,3.541,4.575,3.847,3.035,2.592,1.681,2.329,3.804,3.585,2.598,2.454,2.423,4.274,5.61,2.898,2.801,3.197],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.261,0.263,0.257,0.253,0.25,0.256,0.258,0.26,0.254,0.253,0.249,0.255,0.256,0.26,0.251,0.25,0.247,0.249,0.253,0.259],""T2CUL_99_line"":[0.343,0.346,0.338,0.333,0.328,0.336,0.339,0.342,0.334,0.332,0.328,0.335,0.336,0.342,0.33,0.329,0.324,0.328,0.333,0.34],""Kesi_95"":1.554,""Kesi_99"":1.307,""Kesi_95_line"":[0.166,0.167,0.163,0.161,0.159,0.163,0.164,0.165,0.161,0.161,0.158,0.162,0.163,0.165,0.159,0.159,0.157,0.158,0.161,0.164],""Kesi_99_line"":[0.152,0.153,0.15,0.148,0.146,0.149,0.15,0.152,0.148,0.147,0.145,0.149,0.149,0.152,0.146,0.146,0.144,0.145,0.148,0.151],""COV"":[[1.0,0.999,0.992,0.981,0.972,0.995,0.997,0.998,0.989,0.986,0.975,0.996,0.996,0.998,0.983,0.97,0.958,0.994,0.995,0.995],[0.999,1.0,0.995,0.984,0.976,0.991,0.995,0.997,0.99,0.987,0.976,0.993,0.994,0.997,0.985,0.973,0.96,0.993,0.995,0.997],[0.992,0.995,1.0,0.997,0.992,0.986,0.99,0.993,0.997,0.996,0.991,0.987,0.991,0.993,0.995,0.989,0.981,0.991,0.991,0.993],[0.981,0.984,0.997,1.0,0.999,0.975,0.98,0.984,0.995,0.997,0.996,0.975,0.982,0.983,0.996,0.995,0.991,0.981,0.983,0.983],[0.972,0.976,0.992,0.999,1.0,0.966,0.972,0.976,0.991,0.994,0.997,0.966,0.975,0.976,0.993,0.996,0.994,0.975,0.976,0.976],[0.995,0.991,0.986,0.975,0.966,1.0,0.998,0.996,0.99,0.984,0.975,0.999,0.996,0.995,0.983,0.97,0.959,0.994,0.991,0.989],[0.997,0.995,0.99,0.98,0.972,0.998,1.0,0.999,0.992,0.989,0.98,0.998,0.999,0.998,0.987,0.975,0.964,0.994,0.994,0.992],[0.998,0.997,0.993,0.984,0.976,0.996,0.999,1.0,0.994,0.991,0.982,0.997,0.998,0.999,0.989,0.978,0.967,0.994,0.995,0.994],[0.989,0.99,0.997,0.995,0.991,0.99,0.992,0.994,1.0,0.999,0.995,0.989,0.993,0.993,0.999,0.994,0.987,0.991,0.99,0.989],[0.986,0.987,0.996,0.997,0.994,0.984,0.989,0.991,0.999,1.0,0.998,0.984,0.989,0.99,0.999,0.996,0.991,0.987,0.988,0.987],[0.975,0.976,0.991,0.996,0.997,0.975,0.98,0.982,0.995,0.998,1.0,0.974,0.982,0.981,0.997,0.998,0.996,0.979,0.98,0.977],[0.996,0.993,0.987,0.975,0.966,0.999,0.998,0.997,0.989,0.984,0.974,1.0,0.998,0.997,0.984,0.971,0.959,0.997,0.995,0.993],[0.996,0.994,0.991,0.982,0.975,0.996,0.999,0.998,0.993,0.989,0.982,0.998,1.0,0.999,0.989,0.979,0.969,0.997,0.998,0.995],[0.998,0.997,0.993,0.983,0.976,0.995,0.998,0.999,0.993,0.99,0.981,0.997,0.999,1.0,0.989,0.979,0.967,0.997,0.998,0.998],[0.983,0.985,0.995,0.996,0.993,0.983,0.987,0.989,0.999,0.999,0.997,0.984,0.989,0.989,1.0,0.998,0.993,0.989,0.989,0.988],[0.97,0.973,0.989,0.995,0.996,0.97,0.975,0.978,0.994,0.996,0.998,0.971,0.979,0.979,0.998,1.0,0.998,0.978,0.98,0.977],[0.958,0.96,0.981,0.991,0.994,0.959,0.964,0.967,0.987,0.991,0.996,0.959,0.969,0.967,0.993,0.998,1.0,0.969,0.97,0.966],[0.994,0.993,0.991,0.981,0.975,0.994,0.994,0.994,0.991,0.987,0.979,0.997,0.997,0.997,0.989,0.978,0.969,1.0,0.998,0.997],[0.995,0.995,0.991,0.983,0.976,0.991,0.994,0.995,0.99,0.988,0.98,0.995,0.998,0.998,0.989,0.98,0.97,0.998,1.0,0.999],[0.995,0.997,0.993,0.983,0.976,0.989,0.992,0.994,0.989,0.987,0.977,0.993,0.995,0.998,0.988,0.977,0.966,0.997,0.999,1.0]],""K"":1,""R"":0.988,""featValue"":[19.771,0.17,0.027,0.02,0.007,0.004,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,-0.233,0.215,-0.162,0.038,0.143,-0.046,0.293,-0.462,0.097,0.238,0.217,-0.009,-0.425,0.063,-0.019,-0.439,-0.062,0.062,-0.032],[-0.224,-0.19,0.412,-0.084,-0.055,0.017,-0.093,0.357,0.215,0.02,0.016,-0.103,0.231,-0.012,0.036,0.12,0.402,0.373,-0.102,-0.399],[-0.224,0.047,0.355,-0.124,0.202,-0.286,-0.112,-0.242,-0.03,-0.158,0.032,0.151,0.41,-0.016,-0.387,-0.069,0.187,-0.307,0.246,0.224],[-0.223,0.236,0.332,-0.133,0.145,0.021,0.029,-0.066,-0.092,0.372,-0.049,-0.165,-0.286,0.15,-0.074,-0.434,0.016,0.114,-0.443,0.236],[-0.222,0.334,0.274,-0.084,0.224,0.449,-0.147,-0.145,0.262,-0.029,-0.051,0.109,-0.235,0.121,0.304,0.329,-0.088,-0.186,0.246,-0.069],[-0.223,-0.234,-0.345,-0.267,0.424,-0.057,-0.127,0.382,0.001,0.06,-0.198,-0.246,0.07,0.386,0.021,0.004,-0.12,0.032,0.227,0.188],[-0.224,-0.196,-0.187,-0.236,-0.192,0.226,0.007,-0.147,0.004,-0.006,-0.446,0.392,-0.002,0.167,-0.326,-0.05,-0.075,-0.162,-0.262,-0.349],[-0.224,-0.16,0.002,-0.25,-0.335,-0.031,0.275,0.071,0.009,-0.201,-0.26,0.103,-0.256,-0.208,0.28,0.005,0.358,-0.004,0.123,0.468],[-0.225,0.085,-0.101,-0.187,-0.003,-0.29,-0.315,-0.284,-0.124,-0.271,-0.189,-0.489,-0.054,-0.327,0.137,0.178,-0.122,-0.039,-0.241,-0.186],[-0.224,0.154,-0.036,-0.186,-0.156,-0.2,0.54,-0.131,-0.067,0.24,0.13,-0.237,-0.135,0.069,-0.138,0.005,-0.06,0.022,0.439,-0.377],[-0.223,0.286,-0.161,-0.152,-0.074,0.295,0.298,-0.073,-0.083,-0.318,0.246,-0.022,0.456,0.136,0.011,0.117,-0.15,0.321,-0.238,0.203],[-0.223,-0.252,-0.254,-0.039,0.246,-0.097,0.202,-0.101,0.349,0.237,0.432,0.078,0.011,-0.148,0.139,0.146,0.152,-0.344,-0.353,0.0],[-0.224,-0.164,-0.189,0.075,-0.261,0.267,-0.381,-0.259,0.201,0.303,0.162,-0.131,-0.049,-0.19,-0.329,0.045,-0.001,0.303,0.231,0.244],[-0.224,-0.169,0.023,0.085,-0.301,-0.016,-0.227,0.009,0.035,-0.404,0.426,-0.067,-0.189,0.392,0.134,-0.403,-0.044,-0.186,0.047,-0.114],[-0.224,0.167,-0.122,0.082,-0.067,-0.433,-0.173,-0.13,0.103,0.227,-0.088,0.457,0.19,0.048,0.438,-0.157,-0.167,0.302,0.085,-0.043],[-0.223,0.322,-0.16,0.176,-0.103,-0.216,-0.178,0.29,-0.332,0.033,0.153,0.202,-0.276,0.17,-0.244,0.449,0.242,-0.031,-0.121,0.046],[-0.221,0.433,-0.245,0.211,-0.019,0.14,-0.002,0.41,0.237,-0.049,-0.128,-0.074,0.126,-0.381,-0.096,-0.386,0.055,-0.239,0.063,-0.089],[-0.224,-0.156,-0.096,0.372,0.515,0.066,0.168,-0.205,-0.141,-0.323,-0.036,0.139,-0.267,-0.139,-0.089,-0.145,0.154,0.356,0.079,-0.132],[-0.224,-0.145,0.013,0.467,-0.104,0.217,0.053,-0.149,-0.41,0.264,-0.19,-0.223,0.318,0.142,0.286,0.037,0.191,-0.25,0.02,0.001],[-0.224,-0.156,0.266,0.437,-0.12,-0.208,0.229,0.13,0.329,-0.095,-0.197,-0.09,-0.053,0.063,-0.168,0.228,-0.489,-0.017,-0.113,0.182]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.223],[-0.222],[-0.223],[-0.224],[-0.224],[-0.225],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.223],[-0.221],[-0.224],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7481,""AfterCleanSamNum"":4960,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":461,""version"":""v-2025-12-09 10:13:26"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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