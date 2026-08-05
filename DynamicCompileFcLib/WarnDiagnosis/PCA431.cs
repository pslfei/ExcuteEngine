using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA431")]
    [FCDisplay("PCA431")]
    public partial class PCA431 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁93号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁93号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁93号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁94号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁94号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁94号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁94号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁94号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁94号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁95号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁95号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁95号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁95号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁95号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁95号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁96号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁96号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁96号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁96号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁96号屏5号管壁温")]
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

		public PCA431()
		{
			ModelID = 472;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA431";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""472"",""name"":""PCA431"",""description"":""中温分隔屏过热器水冷壁23-61-80"",""founder"":""admin"",""creatTime"":""2025-12-09 10:40:17"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:42:40"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 10:50:14"",""duration"":2402166,""number"":8008,""filter"":2599,""mode"":5409,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2509}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah23ct161k"",""Description"":""中温（分隔屏）过热器水冷壁93号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""569.21"",""TMin"":""484.94"",""TAvg"":""531.44"",""DMax"":""8.19"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""2.25"",""C99"":""2.78""},{""PointId"":""d1_10hah23ct162k"",""Description"":""中温（分隔屏）过热器水冷壁93号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""570.39"",""TMin"":""485.76"",""TAvg"":""532.07"",""DMax"":""7.29"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.37"",""C99"":""2.93""},{""PointId"":""d1_10hah23ct163k"",""Description"":""中温（分隔屏）过热器水冷壁93号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""570.94"",""TMin"":""486.47"",""TAvg"":""532.68"",""DMax"":""5.60"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.52"",""C99"":""3.10""},{""PointId"":""d1_10hah23ct164k"",""Description"":""中温（分隔屏）过热器水冷壁94号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""564.12"",""TMin"":""482.51"",""TAvg"":""527.70"",""DMax"":""5.76"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.98"",""C99"":""3.65""},{""PointId"":""d1_10hah23ct165k"",""Description"":""中温（分隔屏）过热器水冷壁94号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""566.48"",""TMin"":""484.10"",""TAvg"":""529.59"",""DMax"":""4.87"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.56"",""C99"":""3.14""},{""PointId"":""d1_10hah23ct166k"",""Description"":""中温（分隔屏）过热器水冷壁94号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""565.73"",""TMin"":""482.49"",""TAvg"":""528.24"",""DMax"":""6.10"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.76"",""C99"":""3.38""},{""PointId"":""d1_10hah23ct167k"",""Description"":""中温（分隔屏）过热器水冷壁94号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""572.53"",""TMin"":""486.77"",""TAvg"":""534.18"",""DMax"":""4.26"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.34"",""C99"":""1.65""},{""PointId"":""d1_10hah23ct168k"",""Description"":""中温（分隔屏）过热器水冷壁94号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""573.51"",""TMin"":""487.86"",""TAvg"":""535.08"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.77"",""C99"":""2.17""},{""PointId"":""d1_10hah23ct169k"",""Description"":""中温（分隔屏）过热器水冷壁94号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""575.76"",""TMin"":""489.67"",""TAvg"":""537.45"",""DMax"":""4.57"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.76"",""C99"":""3.37""},{""PointId"":""d1_10hah23ct170k"",""Description"":""中温（分隔屏）过热器水冷壁95号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""567.60"",""TMin"":""485.09"",""TAvg"":""530.85"",""DMax"":""4.71"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.61"",""C99"":""3.20""},{""PointId"":""d1_10hah23ct171k"",""Description"":""中温（分隔屏）过热器水冷壁95号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""567.59"",""TMin"":""484.22"",""TAvg"":""530.29"",""DMax"":""2.56"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.02"",""C99"":""2.47""},{""PointId"":""d1_10hah23ct172k"",""Description"":""中温（分隔屏）过热器水冷壁95号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""569.19"",""TMin"":""484.29"",""TAvg"":""531.16"",""DMax"":""2.89"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.92"",""C99"":""2.35""},{""PointId"":""d1_10hah23ct173k"",""Description"":""中温（分隔屏）过热器水冷壁95号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""576.83"",""TMin"":""489.75"",""TAvg"":""538.51"",""DMax"":""2.45"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.76"",""C99"":""2.16""},{""PointId"":""d1_10hah23ct174k"",""Description"":""中温（分隔屏）过热器水冷壁95号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""576.35"",""TMin"":""489.81"",""TAvg"":""537.90"",""DMax"":""3.66"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.39"",""C99"":""2.93""},{""PointId"":""d1_10hah23ct175k"",""Description"":""中温（分隔屏）过热器水冷壁95号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""577.90"",""TMin"":""490.83"",""TAvg"":""539.79"",""DMax"":""5.69"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.69"",""C99"":""4.52""},{""PointId"":""d1_10hah23ct176k"",""Description"":""中温（分隔屏）过热器水冷壁96号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""567.65"",""TMin"":""484.93"",""TAvg"":""530.69"",""DMax"":""7.71"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.86"",""C99"":""3.51""},{""PointId"":""d1_10hah23ct177k"",""Description"":""中温（分隔屏）过热器水冷壁96号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""569.09"",""TMin"":""485.75"",""TAvg"":""531.56"",""DMax"":""6.43"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.46"",""C99"":""3.02""},{""PointId"":""d1_10hah23ct178k"",""Description"":""中温（分隔屏）过热器水冷壁96号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""567.83"",""TMin"":""483.92"",""TAvg"":""529.86"",""DMax"":""4.97"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.70"",""C99"":""3.31""},{""PointId"":""d1_10hah23ct179k"",""Description"":""中温（分隔屏）过热器水冷壁96号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""573.61"",""TMin"":""487.78"",""TAvg"":""535.72"",""DMax"":""7.26"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.54"",""C99"":""3.12""},{""PointId"":""d1_10hah23ct180k"",""Description"":""中温（分隔屏）过热器水冷壁96号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""577.57"",""TMin"":""490.79"",""TAvg"":""538.73"",""DMax"":""9.26"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.26"",""C99"":""4.01""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:42:40"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[484.939,485.763,486.469,482.506,484.097,482.492,486.77,487.859,489.668,485.092,484.215,484.292,489.752,489.807,490.827,484.928,485.75,483.916,487.777,490.785],""Train_X_max"":[569.212,570.389,570.935,564.115,566.478,565.73,572.525,573.51,575.757,567.598,567.594,569.189,576.828,576.351,577.9,567.652,569.094,567.832,573.609,577.574],""Train_X_std"":[10.623,10.602,10.503,10.65,10.782,10.788,10.789,10.689,10.617,10.723,10.797,10.893,10.718,10.636,10.58,10.524,10.541,10.562,10.403,10.393],""Train_X_mean"":[531.437,532.071,532.681,527.697,529.587,528.238,534.183,535.082,537.452,530.854,530.285,531.156,538.506,537.903,539.792,530.688,531.557,529.86,535.715,538.731],""Train_X_bais_max"":[[8.188,7.286,5.595,5.761,4.874,6.097,4.26,3.165,4.574,4.709,2.563,2.889,2.448,3.663,5.685,7.705,6.433,4.965,7.255,9.255]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.57,0.623,0.688,0.864,0.741,0.785,0.369,0.502,0.802,0.747,0.591,0.556,0.503,0.694,1.076,0.775,0.673,0.765,0.691,0.901]],""QCUL_95"":0.4322246,""QCUL_99"":0.6899886,""QCUL_95_line"":[2.252,2.373,2.518,2.981,2.56,2.759,1.344,1.769,2.755,2.607,2.016,1.92,1.763,2.393,3.69,2.856,2.456,2.695,2.538,3.263],""QCUL_99_line"":[2.784,2.927,3.097,3.651,3.136,3.383,1.652,2.17,3.373,3.195,2.467,2.352,2.162,2.93,4.517,3.514,3.021,3.306,3.122,4.01],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.283,0.283,0.28,0.284,0.288,0.288,0.288,0.285,0.283,0.286,0.288,0.291,0.286,0.284,0.282,0.281,0.281,0.282,0.278,0.277],""T2CUL_99_line"":[0.372,0.372,0.368,0.373,0.378,0.378,0.378,0.375,0.372,0.376,0.379,0.382,0.376,0.373,0.371,0.369,0.37,0.37,0.365,0.364],""Kesi_95"":1.569,""Kesi_99"":1.356,""Kesi_95_line"":[0.181,0.181,0.179,0.181,0.184,0.184,0.184,0.182,0.181,0.183,0.184,0.186,0.183,0.181,0.18,0.179,0.18,0.18,0.177,0.177],""Kesi_99_line"":[0.168,0.168,0.166,0.169,0.171,0.171,0.171,0.169,0.168,0.17,0.171,0.173,0.17,0.169,0.168,0.167,0.167,0.167,0.165,0.165],""COV"":[[1.0,0.999,0.998,0.992,0.995,0.996,0.998,0.997,0.994,0.991,0.994,0.996,0.995,0.992,0.987,0.986,0.988,0.989,0.988,0.985],[0.999,1.0,1.0,0.99,0.993,0.994,0.998,0.998,0.996,0.988,0.993,0.994,0.995,0.994,0.99,0.984,0.987,0.988,0.988,0.986],[0.998,1.0,1.0,0.988,0.991,0.992,0.997,0.998,0.998,0.987,0.991,0.992,0.996,0.995,0.992,0.983,0.986,0.986,0.989,0.988],[0.992,0.99,0.988,1.0,0.999,0.997,0.994,0.99,0.984,0.999,0.998,0.997,0.989,0.985,0.977,0.995,0.994,0.993,0.985,0.979],[0.995,0.993,0.991,0.999,1.0,0.999,0.996,0.992,0.987,0.997,0.999,0.999,0.991,0.987,0.979,0.992,0.994,0.994,0.986,0.981],[0.996,0.994,0.992,0.997,0.999,1.0,0.995,0.992,0.986,0.995,0.998,0.999,0.99,0.986,0.978,0.99,0.993,0.994,0.986,0.98],[0.998,0.998,0.997,0.994,0.996,0.995,1.0,0.999,0.996,0.994,0.996,0.997,0.998,0.996,0.992,0.991,0.992,0.991,0.993,0.99],[0.997,0.998,0.998,0.99,0.992,0.992,0.999,1.0,0.999,0.991,0.993,0.994,0.999,0.998,0.995,0.988,0.99,0.989,0.994,0.993],[0.994,0.996,0.998,0.984,0.987,0.986,0.996,0.999,1.0,0.986,0.989,0.989,0.998,0.999,0.998,0.984,0.986,0.985,0.993,0.993],[0.991,0.988,0.987,0.999,0.997,0.995,0.994,0.991,0.986,1.0,0.999,0.997,0.991,0.988,0.981,0.998,0.997,0.995,0.99,0.985],[0.994,0.993,0.991,0.998,0.999,0.998,0.996,0.993,0.989,0.999,1.0,0.999,0.993,0.99,0.983,0.996,0.997,0.997,0.991,0.986],[0.996,0.994,0.992,0.997,0.999,0.999,0.997,0.994,0.989,0.997,0.999,1.0,0.994,0.99,0.983,0.995,0.996,0.997,0.991,0.986],[0.995,0.995,0.996,0.989,0.991,0.99,0.998,0.999,0.998,0.991,0.993,0.994,1.0,0.999,0.997,0.991,0.992,0.991,0.997,0.996],[0.992,0.994,0.995,0.985,0.987,0.986,0.996,0.998,0.999,0.988,0.99,0.99,0.999,1.0,0.998,0.989,0.99,0.989,0.997,0.997],[0.987,0.99,0.992,0.977,0.979,0.978,0.992,0.995,0.998,0.981,0.983,0.983,0.997,0.998,1.0,0.982,0.984,0.981,0.994,0.996],[0.986,0.984,0.983,0.995,0.992,0.99,0.991,0.988,0.984,0.998,0.996,0.995,0.991,0.989,0.982,1.0,0.999,0.997,0.994,0.99],[0.988,0.987,0.986,0.994,0.994,0.993,0.992,0.99,0.986,0.997,0.997,0.996,0.992,0.99,0.984,0.999,1.0,0.999,0.996,0.992],[0.989,0.988,0.986,0.993,0.994,0.994,0.991,0.989,0.985,0.995,0.997,0.997,0.991,0.989,0.981,0.997,0.999,1.0,0.995,0.99],[0.988,0.988,0.989,0.985,0.986,0.986,0.993,0.994,0.993,0.99,0.991,0.991,0.997,0.997,0.994,0.994,0.996,0.995,1.0,0.999],[0.985,0.986,0.988,0.979,0.981,0.98,0.99,0.993,0.993,0.985,0.986,0.986,0.996,0.997,0.996,0.99,0.992,0.99,0.999,1.0]],""K"":1,""R"":0.992,""featValue"":[19.851,0.083,0.05,0.01,0.003,0.003,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,-0.005,0.327,0.18,0.394,0.217,0.238,-0.054,-0.418,0.154,-0.37,-0.123,-0.115,0.128,-0.113,0.148,0.172,0.217,-0.239,0.015],[0.224,-0.088,0.332,0.221,0.273,-0.148,-0.197,0.235,-0.117,0.197,0.034,0.005,-0.108,-0.21,0.21,-0.319,-0.15,-0.457,0.302,0.124],[0.224,-0.163,0.307,0.121,0.217,-0.464,0.11,0.105,0.139,-0.258,0.441,0.101,0.116,0.217,-0.226,0.146,-0.123,0.235,-0.026,-0.188],[0.223,0.315,0.071,-0.366,0.245,-0.072,-0.074,-0.4,0.26,0.012,0.041,0.147,-0.457,0.035,0.019,0.153,0.115,0.07,0.281,0.243],[0.224,0.257,0.17,-0.065,-0.303,-0.096,-0.048,-0.325,-0.224,0.18,0.233,0.11,0.162,0.053,-0.194,-0.015,0.3,-0.468,-0.271,-0.209],[0.223,0.256,0.214,0.245,-0.196,0.098,0.139,-0.224,0.456,0.304,-0.068,-0.231,0.193,-0.035,0.118,-0.32,-0.195,0.301,0.017,-0.138],[0.224,-0.038,0.153,-0.135,0.021,0.437,-0.151,-0.047,-0.026,-0.33,-0.045,-0.033,0.484,-0.172,-0.343,0.046,0.047,0.0,0.434,0.064],[0.224,-0.162,0.141,-0.076,-0.043,0.051,-0.462,-0.071,0.101,-0.222,-0.282,0.466,-0.002,-0.157,0.185,-0.081,-0.153,0.133,-0.456,-0.067],[0.223,-0.297,0.119,-0.162,-0.216,-0.303,0.21,-0.082,0.054,-0.124,-0.18,-0.284,0.217,-0.136,0.492,0.293,0.263,-0.063,0.019,0.186],[0.224,0.254,-0.093,-0.427,0.133,-0.011,-0.013,0.194,-0.022,-0.113,-0.102,-0.448,-0.036,-0.007,-0.017,0.126,-0.484,-0.215,-0.201,-0.276],[0.224,0.216,0.006,-0.052,-0.377,-0.093,-0.064,0.123,-0.455,-0.234,0.167,-0.128,-0.132,0.113,0.033,-0.329,-0.087,0.329,-0.007,0.412],[0.224,0.19,0.046,0.206,-0.248,0.195,0.058,0.443,0.251,-0.26,-0.192,0.116,-0.237,0.405,0.096,0.086,0.262,-0.188,0.128,-0.177],[0.224,-0.179,-0.035,-0.093,-0.014,0.486,0.21,0.101,0.054,0.26,0.442,0.2,0.067,0.157,0.223,0.219,-0.245,-0.084,-0.167,0.298],[0.224,-0.267,-0.061,-0.083,-0.176,0.07,-0.398,0.227,-0.009,0.376,0.196,-0.237,-0.262,-0.21,-0.115,0.172,0.256,0.292,0.079,-0.273],[0.223,-0.417,-0.081,-0.238,-0.232,-0.088,0.448,-0.011,0.055,0.093,-0.253,0.19,-0.231,-0.063,-0.406,-0.287,-0.137,-0.094,0.079,-0.02],[0.223,0.194,-0.343,-0.245,0.352,-0.119,0.111,0.343,0.091,0.143,0.004,0.164,0.335,-0.068,0.052,-0.322,0.394,0.124,-0.123,0.039],[0.224,0.16,-0.311,0.145,-0.094,-0.198,0.007,-0.055,-0.327,0.223,-0.193,0.357,0.182,0.048,0.146,0.317,-0.279,0.13,0.371,-0.212],[0.223,0.189,-0.263,0.455,-0.027,-0.081,0.068,0.062,0.167,-0.106,0.003,-0.039,-0.096,-0.493,-0.294,0.28,-0.027,-0.104,-0.221,0.323],[0.224,-0.145,-0.336,0.193,0.175,0.207,0.169,-0.333,-0.143,-0.364,0.255,-0.08,-0.197,-0.146,0.277,-0.233,0.089,-0.021,0.043,-0.374],[0.223,-0.271,-0.365,0.176,0.117,-0.091,-0.358,-0.233,0.115,0.071,-0.132,-0.253,0.115,0.542,-0.143,-0.083,-0.02,-0.138,-0.042,0.23]],""selectVec"":[[0.224],[0.224],[0.224],[0.223],[0.224],[0.223],[0.224],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.223],[0.224],[0.223],[0.224],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8008,""AfterCleanSamNum"":5402,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.2%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":472,""version"":""v-2025-12-09 10:42:40"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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