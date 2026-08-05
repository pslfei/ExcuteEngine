using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA395")]
    [FCDisplay("PCA395")]
    public partial class PCA395 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁7号屏5号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁7号屏6号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁8号屏1号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁8号屏2号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁8号屏3号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁8号屏4号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁8号屏5号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁8号屏6号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁9号屏1号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁9号屏2号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁9号屏3号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁9号屏4号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁9号屏5号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁9号屏6号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁10号屏1号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁10号屏2号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁10号屏3号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁10号屏4号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁10号屏5号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁10号屏6号管壁温")]
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

		public PCA395()
		{
			ModelID = 435;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA395";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""435"",""name"":""PCA395"",""description"":""中温分隔屏过热器水冷壁41-60"",""founder"":""admin"",""creatTime"":""2025-12-03 14:36:57"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:39:17"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 17:29:10"",""et"":""2025-12-03 10:07:54"",""duration"":2565524,""number"":8552,""filter"":2600,""mode"":5952,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2510}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah17ct141k"",""Description"":""中温（分隔屏）过热器水冷壁7号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""565.18"",""TMin"":""465.62"",""TAvg"":""525.09"",""DMax"":""6.24"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.37"",""C99"":""2.92""},{""PointId"":""d1_10hah17ct142k"",""Description"":""中温（分隔屏）过热器水冷壁7号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""568.58"",""TMin"":""469.62"",""TAvg"":""529.02"",""DMax"":""5.11"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.42"",""C99"":""4.19""},{""PointId"":""d1_10hah17ct143k"",""Description"":""中温（分隔屏）过热器水冷壁8号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""563.46"",""TMin"":""465.98"",""TAvg"":""523.66"",""DMax"":""7.87"",""DMin"":""0.00"",""DAvg"":""1.13"",""C95"":""3.92"",""C99"":""4.80""},{""PointId"":""d1_10hah17ct144k"",""Description"":""中温（分隔屏）过热器水冷壁8号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""566.44"",""TMin"":""467.13"",""TAvg"":""526.34"",""DMax"":""3.90"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.61"",""C99"":""3.20""},{""PointId"":""d1_10hah17ct145k"",""Description"":""中温（分隔屏）过热器水冷壁8号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""563.78"",""TMin"":""463.86"",""TAvg"":""523.86"",""DMax"":""4.74"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.05"",""C99"":""3.73""},{""PointId"":""d1_10hah17ct146k"",""Description"":""中温（分隔屏）过热器水冷壁8号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""568.98"",""TMin"":""467.73"",""TAvg"":""528.02"",""DMax"":""4.15"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.49"",""C99"":""1.83""},{""PointId"":""d1_10hah17ct147k"",""Description"":""中温（分隔屏）过热器水冷壁8号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""569.94"",""TMin"":""469.55"",""TAvg"":""529.35"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.22"",""C99"":""2.72""},{""PointId"":""d1_10hah17ct148k"",""Description"":""中温（分隔屏）过热器水冷壁8号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""569.53"",""TMin"":""470.45"",""TAvg"":""529.34"",""DMax"":""3.23"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.67"",""C99"":""3.27""},{""PointId"":""d1_10hah17ct149k"",""Description"":""中温（分隔屏）过热器水冷壁9号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""568.00"",""TMin"":""471.68"",""TAvg"":""527.75"",""DMax"":""3.22"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.66"",""C99"":""3.25""},{""PointId"":""d1_10hah17ct150k"",""Description"":""中温（分隔屏）过热器水冷壁9号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""567.82"",""TMin"":""469.52"",""TAvg"":""527.62"",""DMax"":""4.31"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.45"",""C99"":""3.00""},{""PointId"":""d1_10hah17ct151k"",""Description"":""中温（分隔屏）过热器水冷壁9号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""567.08"",""TMin"":""466.25"",""TAvg"":""525.67"",""DMax"":""3.77"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.88"",""C99"":""3.52""},{""PointId"":""d1_10hah17ct152k"",""Description"":""中温（分隔屏）过热器水冷壁9号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""571.90"",""TMin"":""471.68"",""TAvg"":""529.57"",""DMax"":""2.08"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.04"",""C99"":""2.49""},{""PointId"":""d1_10hah17ct153k"",""Description"":""中温（分隔屏）过热器水冷壁9号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""574.16"",""TMin"":""474.17"",""TAvg"":""532.30"",""DMax"":""2.61"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.99"",""C99"":""2.43""},{""PointId"":""d1_10hah17ct154k"",""Description"":""中温（分隔屏）过热器水冷壁9号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""573.68"",""TMin"":""475.56"",""TAvg"":""532.73"",""DMax"":""3.03"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.27"",""C99"":""2.78""},{""PointId"":""d1_10hah17ct155k"",""Description"":""中温（分隔屏）过热器水冷壁10号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""571.96"",""TMin"":""474.73"",""TAvg"":""529.81"",""DMax"":""5.07"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.85"",""C99"":""3.50""},{""PointId"":""d1_10hah17ct156k"",""Description"":""中温（分隔屏）过热器水冷壁10号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""571.82"",""TMin"":""473.70"",""TAvg"":""529.34"",""DMax"":""5.88"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.72"",""C99"":""3.34""},{""PointId"":""d1_10hah17ct157k"",""Description"":""中温（分隔屏）过热器水冷壁10号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""571.05"",""TMin"":""471.03"",""TAvg"":""528.29"",""DMax"":""3.87"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.39"",""C99"":""4.15""},{""PointId"":""d1_10hah17ct158k"",""Description"":""中温（分隔屏）过热器水冷壁10号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""577.78"",""TMin"":""478.48"",""TAvg"":""534.06"",""DMax"":""5.38"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.06"",""C99"":""3.75""},{""PointId"":""d1_10hah17ct159k"",""Description"":""中温（分隔屏）过热器水冷壁10号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""581.32"",""TMin"":""481.45"",""TAvg"":""537.32"",""DMax"":""7.08"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.67"",""C99"":""4.50""},{""PointId"":""d1_10hah17ct160k"",""Description"":""中温（分隔屏）过热器水冷壁10号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""581.08"",""TMin"":""482.25"",""TAvg"":""538.13"",""DMax"":""8.37"",""DMin"":""0.00"",""DAvg"":""1.28"",""C95"":""4.44"",""C99"":""5.44""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:39:17"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[465.617,469.62,465.98,467.133,463.86,467.733,469.55,470.45,471.68,469.517,466.25,471.68,474.167,475.56,474.733,473.7,471.033,478.483,481.45,482.25],""Train_X_max"":[565.18,568.58,563.46,566.44,563.78,568.98,569.94,569.533,568.0,567.82,567.08,571.9,574.16,573.683,571.96,571.82,571.05,577.783,581.32,581.083],""Train_X_std"":[10.845,10.97,10.813,10.843,10.802,10.977,11.018,10.993,10.756,10.842,10.922,11.059,11.121,11.055,10.992,10.93,11.036,11.175,11.349,11.312],""Train_X_mean"":[525.091,529.024,523.664,526.335,523.861,528.024,529.347,529.343,527.746,527.619,525.668,529.568,532.304,532.734,529.805,529.335,528.288,534.058,537.317,538.13],""Train_X_bais_max"":[[6.244,5.108,7.874,3.896,4.743,4.152,3.074,3.231,3.223,4.307,3.767,2.078,2.605,3.029,5.068,5.88,3.867,5.379,7.083,8.372]],""Train_X_bais_min"":[[0.0,0.001,0.001,0.0,0.001,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.665,1.002,1.134,0.75,0.891,0.418,0.638,0.771,0.786,0.705,0.85,0.611,0.581,0.657,0.823,0.783,1.017,0.876,1.038,1.284]],""QCUL_95"":0.4767584,""QCUL_99"":0.7300624,""QCUL_95_line"":[2.374,3.424,3.921,2.609,3.046,1.493,2.216,2.665,2.657,2.448,2.881,2.037,1.987,2.27,2.853,2.722,3.394,3.061,3.668,4.443],""QCUL_99_line"":[2.915,4.19,4.803,3.197,3.728,1.833,2.715,3.265,3.25,2.999,3.524,2.488,2.432,2.781,3.495,3.335,4.146,3.752,4.5,5.442],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.276,0.279,0.275,0.276,0.274,0.279,0.28,0.279,0.273,0.276,0.278,0.281,0.283,0.281,0.279,0.278,0.28,0.284,0.288,0.287],""T2CUL_99_line"":[0.362,0.366,0.361,0.362,0.361,0.367,0.368,0.367,0.359,0.362,0.365,0.369,0.371,0.369,0.367,0.365,0.369,0.373,0.379,0.378],""Kesi_95"":1.577,""Kesi_99"":1.37,""Kesi_95_line"":[0.177,0.179,0.176,0.176,0.176,0.179,0.179,0.179,0.175,0.176,0.178,0.18,0.181,0.18,0.179,0.178,0.18,0.182,0.185,0.184],""Kesi_99_line"":[0.165,0.166,0.164,0.165,0.164,0.167,0.167,0.167,0.163,0.165,0.166,0.168,0.169,0.168,0.167,0.166,0.167,0.17,0.172,0.172],""COV"":[[1.0,0.997,0.993,0.995,0.994,0.999,0.998,0.996,0.992,0.992,0.992,0.994,0.995,0.994,0.989,0.987,0.986,0.988,0.985,0.983],[0.997,1.0,0.99,0.991,0.985,0.995,0.999,0.998,0.988,0.985,0.982,0.988,0.991,0.994,0.985,0.982,0.977,0.985,0.985,0.987],[0.993,0.99,1.0,0.997,0.989,0.992,0.989,0.988,0.997,0.991,0.986,0.983,0.983,0.984,0.993,0.985,0.979,0.976,0.972,0.972],[0.995,0.991,0.997,1.0,0.996,0.996,0.994,0.992,0.998,0.997,0.994,0.99,0.989,0.989,0.994,0.992,0.989,0.984,0.98,0.977],[0.994,0.985,0.989,0.996,1.0,0.996,0.99,0.987,0.993,0.997,0.999,0.994,0.991,0.987,0.989,0.991,0.994,0.984,0.979,0.972],[0.999,0.995,0.992,0.996,0.996,1.0,0.998,0.997,0.994,0.995,0.995,0.997,0.997,0.996,0.992,0.991,0.991,0.991,0.989,0.986],[0.998,0.999,0.989,0.994,0.99,0.998,1.0,0.999,0.991,0.99,0.989,0.994,0.996,0.997,0.988,0.988,0.985,0.991,0.991,0.99],[0.996,0.998,0.988,0.992,0.987,0.997,0.999,1.0,0.99,0.988,0.986,0.992,0.995,0.998,0.987,0.987,0.982,0.99,0.991,0.992],[0.992,0.988,0.997,0.998,0.993,0.994,0.991,0.99,1.0,0.997,0.993,0.99,0.989,0.99,0.998,0.994,0.99,0.986,0.982,0.98],[0.992,0.985,0.991,0.997,0.997,0.995,0.99,0.988,0.997,1.0,0.998,0.994,0.992,0.99,0.996,0.997,0.996,0.988,0.984,0.979],[0.992,0.982,0.986,0.994,0.999,0.995,0.989,0.986,0.993,0.998,1.0,0.996,0.993,0.988,0.992,0.994,0.998,0.989,0.984,0.975],[0.994,0.988,0.983,0.99,0.994,0.997,0.994,0.992,0.99,0.994,0.996,1.0,0.999,0.996,0.992,0.994,0.996,0.997,0.994,0.988],[0.995,0.991,0.983,0.989,0.991,0.997,0.996,0.995,0.989,0.992,0.993,0.999,1.0,0.998,0.99,0.993,0.993,0.998,0.996,0.993],[0.994,0.994,0.984,0.989,0.987,0.996,0.997,0.998,0.99,0.99,0.988,0.996,0.998,1.0,0.99,0.991,0.988,0.996,0.996,0.996],[0.989,0.985,0.993,0.994,0.989,0.992,0.988,0.987,0.998,0.996,0.992,0.992,0.99,0.99,1.0,0.996,0.992,0.99,0.987,0.983],[0.987,0.982,0.985,0.992,0.991,0.991,0.988,0.987,0.994,0.997,0.994,0.994,0.993,0.991,0.996,1.0,0.997,0.994,0.992,0.986],[0.986,0.977,0.979,0.989,0.994,0.991,0.985,0.982,0.99,0.996,0.998,0.996,0.993,0.988,0.992,0.997,1.0,0.993,0.988,0.979],[0.988,0.985,0.976,0.984,0.984,0.991,0.991,0.99,0.986,0.988,0.989,0.997,0.998,0.996,0.99,0.994,0.993,1.0,0.999,0.995],[0.985,0.985,0.972,0.98,0.979,0.989,0.991,0.991,0.982,0.984,0.984,0.994,0.996,0.996,0.987,0.992,0.988,0.999,1.0,0.998],[0.983,0.987,0.972,0.977,0.972,0.986,0.99,0.992,0.98,0.979,0.975,0.988,0.993,0.996,0.983,0.986,0.979,0.995,0.998,1.0]],""K"":1,""R"":0.991,""featValue"":[19.822,0.081,0.059,0.027,0.007,0.003,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,-0.062,0.25,-0.237,-0.269,-0.281,-0.264,0.024,0.331,0.205,0.027,-0.095,0.294,0.254,-0.287,0.236,-0.011,0.186,0.281,-0.203],[0.223,0.083,0.439,-0.067,0.027,-0.342,-0.365,0.265,-0.184,-0.035,-0.132,0.092,0.164,-0.119,0.332,-0.165,0.046,-0.214,-0.342,0.142],[0.223,-0.328,0.295,0.32,-0.287,0.054,0.17,-0.005,-0.078,-0.315,0.293,0.306,-0.165,0.293,0.121,0.127,-0.165,-0.239,0.162,-0.012],[0.224,-0.265,0.124,0.081,0.31,-0.094,0.084,-0.128,0.211,-0.433,0.249,-0.374,0.117,-0.314,0.087,0.073,-0.051,0.381,-0.15,-0.019],[0.223,-0.281,-0.079,-0.345,0.139,0.057,0.212,0.262,-0.022,0.349,0.303,0.177,-0.029,-0.263,0.113,0.25,0.312,-0.064,0.157,0.305],[0.224,-0.041,0.119,-0.201,-0.087,0.113,0.284,-0.386,0.309,0.337,0.086,-0.249,-0.083,0.144,0.151,-0.288,-0.045,-0.319,-0.345,-0.097],[0.224,0.088,0.254,-0.138,0.146,-0.171,0.133,-0.225,-0.091,-0.115,-0.153,0.073,-0.234,-0.211,-0.418,-0.427,-0.034,-0.053,0.415,0.239],[0.224,0.144,0.29,-0.06,0.334,0.128,0.214,0.203,-0.089,0.151,-0.288,0.102,-0.406,0.245,0.034,0.221,-0.101,0.373,-0.139,-0.243],[0.224,-0.234,0.029,0.336,-0.048,0.159,0.295,0.136,-0.36,0.247,-0.235,-0.126,0.505,-0.108,-0.307,-0.063,-0.081,-0.023,-0.101,-0.074],[0.224,-0.225,-0.153,0.043,0.309,0.151,-0.384,-0.561,-0.068,0.07,-0.114,0.441,0.158,0.138,0.009,0.048,0.11,0.094,-0.088,0.032],[0.224,-0.214,-0.233,-0.259,-0.008,0.134,0.026,0.187,0.092,-0.437,-0.445,-0.11,0.004,0.096,0.063,-0.051,0.37,-0.264,0.112,-0.29],[0.224,0.075,-0.16,-0.229,-0.344,0.086,0.015,-0.179,-0.086,-0.107,-0.346,-0.128,-0.026,-0.12,0.15,0.378,-0.44,0.039,-0.024,0.421],[0.224,0.172,-0.063,-0.19,-0.213,0.128,-0.224,-0.1,-0.391,-0.046,0.325,-0.012,-0.203,-0.36,-0.219,0.113,-0.008,-0.08,-0.146,-0.488],[0.224,0.22,0.077,-0.011,-0.031,0.586,-0.268,0.158,-0.103,-0.053,0.235,-0.279,0.078,0.285,0.049,-0.263,0.112,0.186,0.145,0.283],[0.224,-0.13,-0.113,0.457,-0.371,-0.027,-0.197,0.076,0.272,0.202,-0.18,-0.007,-0.407,-0.25,-0.013,-0.118,0.273,0.224,-0.085,0.082],[0.224,-0.031,-0.295,0.253,0.34,-0.321,-0.205,0.024,-0.187,0.179,0.072,-0.44,-0.221,0.222,0.037,0.14,-0.132,-0.308,0.199,0.018],[0.223,-0.095,-0.423,-0.141,0.05,-0.073,-0.045,0.364,0.196,-0.031,0.141,0.29,0.02,0.059,-0.094,-0.384,-0.514,0.105,-0.136,-0.05],[0.224,0.273,-0.231,0.026,-0.188,-0.325,0.302,-0.167,-0.247,0.023,0.065,0.074,0.171,0.091,0.446,-0.191,0.18,0.333,0.223,-0.159],[0.223,0.385,-0.16,0.092,0.001,-0.184,0.202,0.018,0.097,-0.224,0.132,0.098,0.059,0.234,-0.41,0.212,0.304,-0.088,-0.401,0.272],[0.222,0.467,0.034,0.276,0.188,0.22,0.017,0.037,0.403,0.031,-0.033,0.172,0.205,-0.315,0.158,0.154,-0.124,-0.272,0.266,-0.159]],""selectVec"":[[0.224],[0.223],[0.223],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.224],[0.223],[0.222]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8552,""AfterCleanSamNum"":5952,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.1%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":435,""version"":""v-2025-12-03 14:39:17"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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