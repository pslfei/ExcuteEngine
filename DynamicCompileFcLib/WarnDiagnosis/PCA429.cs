using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA429")]
    [FCDisplay("PCA429")]
    public partial class PCA429 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁86号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁87号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁87号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁87号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁87号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁87号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁87号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁88号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁88号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁88号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁88号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁88号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁88号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁89号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁89号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁89号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁89号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁89号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁89号屏6号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁90号屏1号管壁温")]
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

		public PCA429()
		{
			ModelID = 470;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA429";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""470"",""name"":""PCA429"",""description"":""中温分隔屏过热器水冷壁23-21-40"",""founder"":""admin"",""creatTime"":""2025-12-09 10:35:28"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:37:03"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 17:03:24"",""et"":""2025-12-07 12:19:30"",""duration"":2402166,""number"":8008,""filter"":2617,""mode"":5391,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2527}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah23ct121k"",""Description"":""中温（分隔屏）过热器水冷壁86号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""568.91"",""TMin"":""490.38"",""TAvg"":""533.98"",""DMax"":""5.13"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.14"",""C99"":""3.84""},{""PointId"":""d1_10hah23ct122k"",""Description"":""中温（分隔屏）过热器水冷壁87号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""560.03"",""TMin"":""481.61"",""TAvg"":""526.34"",""DMax"":""5.37"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.89"",""C99"":""3.54""},{""PointId"":""d1_10hah23ct123k"",""Description"":""中温（分隔屏）过热器水冷壁87号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""561.50"",""TMin"":""480.87"",""TAvg"":""526.96"",""DMax"":""3.51"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.29"",""C99"":""2.81""},{""PointId"":""d1_10hah23ct124k"",""Description"":""中温（分隔屏）过热器水冷壁87号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""561.08"",""TMin"":""479.68"",""TAvg"":""525.91"",""DMax"":""4.09"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.32"",""C99"":""2.85""},{""PointId"":""d1_10hah23ct125k"",""Description"":""中温（分隔屏）过热器水冷壁87号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""568.27"",""TMin"":""488.66"",""TAvg"":""532.79"",""DMax"":""2.73"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.70"",""C99"":""2.09""},{""PointId"":""d1_10hah23ct126k"",""Description"":""中温（分隔屏）过热器水冷壁87号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""569.27"",""TMin"":""490.17"",""TAvg"":""533.80"",""DMax"":""4.22"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""2.96"",""C99"":""3.62""},{""PointId"":""d1_10hah23ct127k"",""Description"":""中温（分隔屏）过热器水冷壁87号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""569.08"",""TMin"":""491.62"",""TAvg"":""534.21"",""DMax"":""5.65"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.18"",""C99"":""3.89""},{""PointId"":""d1_10hah23ct128k"",""Description"":""中温（分隔屏）过热器水冷壁88号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""562.91"",""TMin"":""484.98"",""TAvg"":""528.33"",""DMax"":""4.74"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.64"",""C99"":""3.24""},{""PointId"":""d1_10hah23ct129k"",""Description"":""中温（分隔屏）过热器水冷壁88号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""565.27"",""TMin"":""486.16"",""TAvg"":""529.86"",""DMax"":""2.69"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.12"",""C99"":""2.59""},{""PointId"":""d1_10hah23ct130k"",""Description"":""中温（分隔屏）过热器水冷壁88号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""563.94"",""TMin"":""483.15"",""TAvg"":""528.03"",""DMax"":""2.81"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.77"",""C99"":""2.17""},{""PointId"":""d1_10hah23ct131k"",""Description"":""中温（分隔屏）过热器水冷壁88号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""568.23"",""TMin"":""488.12"",""TAvg"":""532.20"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""0.96"",""C99"":""1.18""},{""PointId"":""d1_10hah23ct132k"",""Description"":""中温（分隔屏）过热器水冷壁88号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""569.24"",""TMin"":""488.69"",""TAvg"":""532.80"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.99"",""C99"":""2.44""},{""PointId"":""d1_10hah23ct133k"",""Description"":""中温（分隔屏）过热器水冷壁88号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""571.63"",""TMin"":""491.54"",""TAvg"":""536.02"",""DMax"":""4.95"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.33"",""C99"":""4.08""},{""PointId"":""d1_10hah23ct134k"",""Description"":""中温（分隔屏）过热器水冷壁89号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""561.25"",""TMin"":""483.33"",""TAvg"":""526.50"",""DMax"":""5.76"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.24"",""C99"":""3.97""},{""PointId"":""d1_10hah23ct135k"",""Description"":""中温（分隔屏）过热器水冷壁89号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""561.35"",""TMin"":""482.36"",""TAvg"":""526.10"",""DMax"":""3.68"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.21"",""C99"":""2.70""},{""PointId"":""d1_10hah23ct136k"",""Description"":""中温（分隔屏）过热器水冷壁89号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""564.18"",""TMin"":""483.17"",""TAvg"":""527.83"",""DMax"":""3.49"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.31"",""C99"":""2.82""},{""PointId"":""d1_10hah23ct137k"",""Description"":""中温（分隔屏）过热器水冷壁89号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""569.29"",""TMin"":""487.47"",""TAvg"":""532.75"",""DMax"":""2.85"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.64"",""C99"":""2.01""},{""PointId"":""d1_10hah23ct138k"",""Description"":""中温（分隔屏）过热器水冷壁89号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.93"",""TMin"":""491.09"",""TAvg"":""536.07"",""DMax"":""3.65"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.23"",""C99"":""2.74""},{""PointId"":""d1_10hah23ct139k"",""Description"":""中温（分隔屏）过热器水冷壁89号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""574.31"",""TMin"":""492.43"",""TAvg"":""537.87"",""DMax"":""6.38"",""DMin"":""0.00"",""DAvg"":""1.01"",""C95"":""3.48"",""C99"":""4.26""},{""PointId"":""d1_10hah23ct140k"",""Description"":""中温（分隔屏）过热器水冷壁90号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""561.35"",""TMin"":""483.49"",""TAvg"":""526.84"",""DMax"":""6.13"",""DMin"":""0.00"",""DAvg"":""0.97"",""C95"":""3.35"",""C99"":""4.11""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:37:03"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[490.376,481.606,480.874,479.68,488.662,490.17,491.62,484.975,486.155,483.152,488.115,488.685,491.538,483.325,482.36,483.17,487.468,491.085,492.43,483.488],""Train_X_max"":[568.905,560.025,561.5,561.075,568.269,569.265,569.082,562.906,565.267,563.94,568.228,569.236,571.63,561.253,561.35,564.183,569.287,572.933,574.305,561.35],""Train_X_std"":[9.776,10.139,10.249,10.258,10.094,9.924,9.751,10.323,10.386,10.414,10.251,10.223,10.04,10.409,10.455,10.584,10.404,10.371,10.272,10.433],""Train_X_mean"":[533.98,526.344,526.963,525.908,532.793,533.804,534.212,528.334,529.861,528.032,532.203,532.797,536.015,526.501,526.097,527.832,532.747,536.07,537.868,526.842],""Train_X_bais_max"":[[5.132,5.368,3.512,4.09,2.729,4.224,5.65,4.738,2.688,2.812,1.995,3.168,4.954,5.761,3.677,3.492,2.854,3.654,6.377,6.134]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.911,0.826,0.66,0.653,0.496,0.869,0.922,0.757,0.623,0.513,0.274,0.581,0.988,0.934,0.644,0.676,0.47,0.645,1.009,0.966]],""QCUL_95"":0.539536059,""QCUL_99"":0.9545645,""QCUL_95_line"":[3.138,2.891,2.293,2.322,1.704,2.955,3.18,2.641,2.119,1.771,0.963,1.991,3.334,3.239,2.206,2.308,1.641,2.234,3.482,3.351],""QCUL_99_line"":[3.842,3.544,2.809,2.85,2.086,3.615,3.894,3.238,2.593,2.169,1.18,2.437,4.076,3.968,2.7,2.824,2.011,2.737,4.264,4.105],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.261,0.271,0.274,0.274,0.27,0.265,0.26,0.276,0.277,0.278,0.274,0.273,0.268,0.278,0.279,0.283,0.278,0.277,0.274,0.279],""T2CUL_99_line"":[0.343,0.356,0.36,0.36,0.354,0.348,0.342,0.362,0.365,0.365,0.36,0.359,0.352,0.365,0.367,0.371,0.365,0.364,0.361,0.366],""Kesi_95"":1.556,""Kesi_99"":1.316,""Kesi_95_line"":[0.166,0.172,0.174,0.174,0.171,0.169,0.166,0.175,0.176,0.177,0.174,0.174,0.171,0.177,0.178,0.18,0.177,0.176,0.175,0.177],""Kesi_99_line"":[0.153,0.158,0.16,0.16,0.158,0.155,0.152,0.161,0.162,0.163,0.16,0.16,0.157,0.163,0.163,0.165,0.163,0.162,0.161,0.163],""COV"":[[1.0,0.981,0.986,0.988,0.997,1.0,0.999,0.981,0.984,0.987,0.994,0.996,0.997,0.976,0.982,0.983,0.993,0.994,0.994,0.975],[0.981,1.0,0.998,0.995,0.99,0.981,0.979,0.999,0.997,0.996,0.991,0.986,0.978,0.998,0.997,0.996,0.989,0.985,0.977,0.997],[0.986,0.998,1.0,0.999,0.994,0.986,0.984,0.997,0.999,0.999,0.995,0.989,0.982,0.995,0.998,0.998,0.991,0.988,0.98,0.995],[0.988,0.995,0.999,1.0,0.995,0.988,0.987,0.994,0.997,0.999,0.996,0.99,0.983,0.992,0.996,0.998,0.992,0.989,0.981,0.992],[0.997,0.99,0.994,0.995,1.0,0.998,0.996,0.99,0.992,0.995,0.999,0.998,0.995,0.986,0.992,0.993,0.997,0.996,0.993,0.986],[1.0,0.981,0.986,0.988,0.998,1.0,0.999,0.981,0.985,0.988,0.996,0.997,0.998,0.977,0.984,0.985,0.995,0.996,0.996,0.976],[0.999,0.979,0.984,0.987,0.996,0.999,1.0,0.98,0.983,0.987,0.995,0.996,0.998,0.974,0.982,0.983,0.993,0.995,0.995,0.974],[0.981,0.999,0.997,0.994,0.99,0.981,0.98,1.0,0.998,0.997,0.993,0.989,0.981,1.0,0.999,0.996,0.992,0.988,0.981,0.999],[0.984,0.997,0.999,0.997,0.992,0.985,0.983,0.998,1.0,0.999,0.996,0.991,0.983,0.998,1.0,0.999,0.994,0.991,0.983,0.997],[0.987,0.996,0.999,0.999,0.995,0.988,0.987,0.997,0.999,1.0,0.997,0.993,0.985,0.996,0.999,1.0,0.995,0.992,0.984,0.995],[0.994,0.991,0.995,0.996,0.999,0.996,0.995,0.993,0.996,0.997,1.0,0.999,0.995,0.991,0.995,0.996,0.999,0.998,0.994,0.99],[0.996,0.986,0.989,0.99,0.998,0.997,0.996,0.989,0.991,0.993,0.999,1.0,0.997,0.986,0.991,0.991,0.999,1.0,0.998,0.985],[0.997,0.978,0.982,0.983,0.995,0.998,0.998,0.981,0.983,0.985,0.995,0.997,1.0,0.976,0.983,0.982,0.995,0.996,0.998,0.975],[0.976,0.998,0.995,0.992,0.986,0.977,0.974,1.0,0.998,0.996,0.991,0.986,0.976,1.0,0.998,0.996,0.99,0.986,0.977,1.0],[0.982,0.997,0.998,0.996,0.992,0.984,0.982,0.999,1.0,0.999,0.995,0.991,0.983,0.998,1.0,0.999,0.994,0.991,0.983,0.998],[0.983,0.996,0.998,0.998,0.993,0.985,0.983,0.996,0.999,1.0,0.996,0.991,0.982,0.996,0.999,1.0,0.994,0.991,0.982,0.996],[0.993,0.989,0.991,0.992,0.997,0.995,0.993,0.992,0.994,0.995,0.999,0.999,0.995,0.99,0.994,0.994,1.0,0.999,0.996,0.99],[0.994,0.985,0.988,0.989,0.996,0.996,0.995,0.988,0.991,0.992,0.998,1.0,0.996,0.986,0.991,0.991,0.999,1.0,0.998,0.986],[0.994,0.977,0.98,0.981,0.993,0.996,0.995,0.981,0.983,0.984,0.994,0.998,0.998,0.977,0.983,0.982,0.996,0.998,1.0,0.977],[0.975,0.997,0.995,0.992,0.986,0.976,0.974,0.999,0.997,0.995,0.99,0.985,0.975,1.0,0.998,0.996,0.99,0.986,0.977,1.0]],""K"":1,""R"":0.992,""featValue"":[19.836,0.125,0.024,0.01,0.003,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.223,-0.286,0.295,0.289,0.113,0.105,0.163,0.117,-0.014,-0.321,-0.633,0.009,-0.315,-0.104,-0.066,-0.101,-0.002,-0.065,0.031,-0.021],[0.223,0.253,0.107,0.464,0.246,-0.122,0.154,-0.29,-0.045,0.13,0.014,-0.222,0.305,0.165,-0.061,0.096,0.289,-0.136,0.415,0.007],[0.224,0.18,0.31,0.021,-0.139,-0.054,-0.019,0.21,-0.095,0.04,0.109,-0.611,-0.063,0.017,0.091,0.001,-0.449,0.377,0.024,-0.049],[0.224,0.122,0.419,-0.252,0.097,0.135,-0.032,-0.325,-0.047,0.115,-0.035,0.007,0.074,0.368,-0.126,-0.248,0.021,-0.197,-0.532,0.074],[0.224,-0.121,0.208,0.02,0.441,-0.059,-0.297,0.2,-0.034,-0.107,0.333,0.02,-0.108,-0.234,-0.042,0.516,0.104,-0.115,-0.19,0.217],[0.223,-0.287,0.188,0.093,0.114,-0.042,-0.097,0.359,-0.172,0.176,0.265,0.416,0.079,0.303,0.155,-0.302,0.001,0.121,0.207,-0.311],[0.223,-0.311,0.194,0.108,-0.369,0.4,0.194,-0.179,0.233,-0.106,0.28,0.031,0.367,-0.347,0.184,-0.006,0.025,-0.008,-0.022,0.066],[0.224,0.232,-0.139,0.352,-0.091,-0.286,-0.014,-0.166,-0.19,-0.102,0.073,0.348,-0.067,-0.188,-0.011,-0.248,-0.043,0.389,-0.235,0.389],[0.224,0.189,0.005,-0.102,-0.389,-0.278,0.199,0.167,-0.003,-0.514,0.169,0.049,-0.008,0.169,-0.27,0.17,0.243,-0.096,-0.087,-0.327],[0.224,0.136,0.151,-0.264,-0.139,-0.131,0.0,-0.241,-0.155,0.171,0.103,0.188,-0.329,-0.355,-0.103,-0.074,-0.273,-0.395,0.402,-0.038],[0.224,-0.058,-0.015,-0.213,-0.003,-0.166,-0.089,-0.212,0.536,-0.12,0.022,-0.008,-0.341,0.299,0.418,0.013,0.157,0.164,0.215,0.198],[0.224,-0.17,-0.152,-0.108,0.114,-0.306,0.529,0.151,0.183,0.495,-0.008,-0.129,-0.089,-0.229,-0.043,-0.045,0.189,0.04,-0.265,-0.097],[0.223,-0.319,-0.118,0.172,-0.385,-0.144,-0.43,-0.087,0.157,0.33,-0.214,0.013,0.077,0.164,-0.386,0.259,-0.117,0.019,-0.025,0.006],[0.223,0.296,-0.226,0.214,0.061,0.065,0.025,0.002,0.133,0.041,-0.16,0.209,0.066,0.041,0.452,0.276,-0.386,-0.24,-0.254,-0.333],[0.224,0.2,-0.087,-0.125,-0.234,-0.007,-0.236,0.474,-0.091,0.081,-0.231,-0.123,0.214,-0.084,0.256,-0.203,0.277,-0.327,0.036,0.352],[0.224,0.183,0.053,-0.414,0.045,0.24,0.052,-0.05,-0.201,0.103,-0.33,0.241,0.18,-0.09,-0.016,0.346,0.174,0.489,0.155,-0.07],[0.224,-0.087,-0.245,-0.174,0.301,-0.145,-0.375,-0.193,0.096,-0.26,-0.063,-0.207,0.262,-0.311,-0.06,-0.352,0.009,0.069,-0.018,-0.374],[0.224,-0.16,-0.298,-0.21,0.225,0.013,0.308,0.118,0.023,-0.211,0.016,0.04,0.281,0.248,-0.227,0.001,-0.456,-0.09,0.161,0.39],[0.223,-0.295,-0.4,-0.001,-0.085,0.203,0.03,-0.23,-0.588,-0.029,0.108,-0.256,-0.266,0.162,0.212,0.074,0.145,-0.057,-0.066,-0.03],[0.223,0.3,-0.253,0.136,0.075,0.587,-0.064,0.177,0.271,0.091,0.182,-0.013,-0.319,0.012,-0.359,-0.172,0.092,0.055,0.046,-0.049]],""selectVec"":[[0.223],[0.223],[0.224],[0.224],[0.224],[0.223],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8008,""AfterCleanSamNum"":5391,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.2%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":470,""version"":""v-2025-12-09 10:37:03"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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