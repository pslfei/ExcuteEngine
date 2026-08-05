using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA399")]
    [FCDisplay("PCA399")]
    public partial class PCA399 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁20号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁21号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁21号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁21号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁21号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁21号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁21号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁22号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁22号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁22号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁22号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁22号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁22号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁23号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁23号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁23号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁23号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁23号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁23号屏6号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁24号屏1号管壁温")]
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

		public PCA399()
		{
			ModelID = 440;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA399";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""440"",""name"":""PCA399"",""description"":""中温分隔屏过热器水冷壁18-21-40"",""founder"":""admin"",""creatTime"":""2025-12-03 15:00:04"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 15:02:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 15:15:16"",""et"":""2025-12-03 09:23:16"",""duration"":2570880,""number"":8570,""filter"":2592,""mode"":5978,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2502}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah18ct121k"",""Description"":""中温（分隔屏）过热器水冷壁20号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""595.98"",""TMin"":""497.22"",""TAvg"":""549.81"",""DMax"":""4.74"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.22"",""C99"":""3.94""},{""PointId"":""d1_10hah18ct122k"",""Description"":""中温（分隔屏）过热器水冷壁21号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""586.88"",""TMin"":""492.95"",""TAvg"":""541.39"",""DMax"":""4.33"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.35"",""C99"":""4.09""},{""PointId"":""d1_10hah18ct123k"",""Description"":""中温（分隔屏）过热器水冷壁21号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""586.13"",""TMin"":""490.50"",""TAvg"":""540.40"",""DMax"":""3.32"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.20"",""C99"":""3.91""},{""PointId"":""d1_10hah18ct124k"",""Description"":""中温（分隔屏）过热器水冷壁21号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""586.30"",""TMin"":""488.85"",""TAvg"":""540.13"",""DMax"":""4.28"",""DMin"":""0.00"",""DAvg"":""1.11"",""C95"":""3.74"",""C99"":""4.57""},{""PointId"":""d1_10hah18ct125k"",""Description"":""中温（分隔屏）过热器水冷壁21号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""594.77"",""TMin"":""496.48"",""TAvg"":""548.58"",""DMax"":""4.07"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.51"",""C99"":""3.08""},{""PointId"":""d1_10hah18ct126k"",""Description"":""中温（分隔屏）过热器水冷壁21号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""597.67"",""TMin"":""497.52"",""TAvg"":""550.95"",""DMax"":""5.18"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.52"",""C99"":""4.31""},{""PointId"":""d1_10hah18ct127k"",""Description"":""中温（分隔屏）过热器水冷壁21号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""602.22"",""TMin"":""502.73"",""TAvg"":""556.11"",""DMax"":""8.02"",""DMin"":""0.00"",""DAvg"":""1.96"",""C95"":""6.63"",""C99"":""8.11""},{""PointId"":""d1_10hah18ct128k"",""Description"":""中温（分隔屏）过热器水冷壁22号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""584.57"",""TMin"":""492.10"",""TAvg"":""540.64"",""DMax"":""6.07"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.12"",""C99"":""3.82""},{""PointId"":""d1_10hah18ct129k"",""Description"":""中温（分隔屏）过热器水冷壁22号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""583.40"",""TMin"":""489.18"",""TAvg"":""539.29"",""DMax"":""4.04"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.33"",""C99"":""4.07""},{""PointId"":""d1_10hah18ct130k"",""Description"":""中温（分隔屏）过热器水冷壁22号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""583.47"",""TMin"":""487.07"",""TAvg"":""538.63"",""DMax"":""4.64"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.55"",""C99"":""4.34""},{""PointId"":""d1_10hah18ct131k"",""Description"":""中温（分隔屏）过热器水冷壁22号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""590.90"",""TMin"":""493.33"",""TAvg"":""545.66"",""DMax"":""1.94"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.44"",""C99"":""1.76""},{""PointId"":""d1_10hah18ct132k"",""Description"":""中温（分隔屏）过热器水冷壁22号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""593.53"",""TMin"":""495.27"",""TAvg"":""548.47"",""DMax"":""3.26"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.54"",""C99"":""3.12""},{""PointId"":""d1_10hah18ct133k"",""Description"":""中温（分隔屏）过热器水冷壁22号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""596.83"",""TMin"":""498.40"",""TAvg"":""552.04"",""DMax"":""7.12"",""DMin"":""0.00"",""DAvg"":""1.60"",""C95"":""5.42"",""C99"":""6.62""},{""PointId"":""d1_10hah18ct134k"",""Description"":""中温（分隔屏）过热器水冷壁23号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""582.00"",""TMin"":""490.78"",""TAvg"":""539.43"",""DMax"":""4.85"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.13"",""C99"":""3.84""},{""PointId"":""d1_10hah18ct135k"",""Description"":""中温（分隔屏）过热器水冷壁23号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""582.48"",""TMin"":""489.40"",""TAvg"":""539.28"",""DMax"":""5.12"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.53"",""C99"":""4.32""},{""PointId"":""d1_10hah18ct136k"",""Description"":""中温（分隔屏）过热器水冷壁23号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""584.07"",""TMin"":""488.76"",""TAvg"":""540.19"",""DMax"":""5.61"",""DMin"":""0.00"",""DAvg"":""0.97"",""C95"":""3.34"",""C99"":""4.10""},{""PointId"":""d1_10hah18ct137k"",""Description"":""中温（分隔屏）过热器水冷壁23号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""590.98"",""TMin"":""494.28"",""TAvg"":""546.59"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.78"",""C99"":""2.19""},{""PointId"":""d1_10hah18ct138k"",""Description"":""中温（分隔屏）过热器水冷壁23号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""592.33"",""TMin"":""495.25"",""TAvg"":""548.14"",""DMax"":""3.47"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.68"",""C99"":""3.28""},{""PointId"":""d1_10hah18ct139k"",""Description"":""中温（分隔屏）过热器水冷壁23号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""591.78"",""TMin"":""496.07"",""TAvg"":""548.66"",""DMax"":""6.12"",""DMin"":""0.00"",""DAvg"":""1.29"",""C95"":""4.39"",""C99"":""5.37""},{""PointId"":""d1_10hah18ct140k"",""Description"":""中温（分隔屏）过热器水冷壁24号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""584.70"",""TMin"":""494.45"",""TAvg"":""541.96"",""DMax"":""3.87"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.76"",""C99"":""3.38""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 15:02:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[497.217,492.95,490.5,488.85,496.483,497.517,502.733,492.1,489.183,487.067,493.333,495.267,498.4,490.783,489.4,488.76,494.283,495.25,496.067,494.45],""Train_X_max"":[595.983,586.883,586.133,586.3,594.767,597.667,602.217,584.567,583.4,583.467,590.9,593.533,596.833,582.0,582.48,584.067,590.98,592.333,591.783,584.7],""Train_X_std"":[11.859,11.387,11.433,11.579,11.763,11.95,12.088,11.251,11.292,11.394,11.574,11.683,11.83,11.111,11.204,11.24,11.544,11.585,11.548,11.067],""Train_X_mean"":[549.811,541.387,540.402,540.128,548.581,550.947,556.107,540.636,539.285,538.628,545.661,548.467,552.036,539.432,539.281,540.186,546.586,548.139,548.656,541.958],""Train_X_bais_max"":[[4.736,4.325,3.322,4.28,4.074,5.175,8.019,6.07,4.044,4.636,1.941,3.26,7.121,4.853,5.115,5.608,2.11,3.469,6.117,3.873]],""Train_X_bais_min"":[[0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.001,0.0,0.0]],""Train_X_bais_mean"":[[0.926,0.986,0.955,1.109,0.717,1.02,1.957,0.897,0.983,1.035,0.416,0.742,1.602,0.908,1.023,0.968,0.516,0.784,1.285,0.796]],""QCUL_95"":0.810776055,""QCUL_99"":1.45102394,""QCUL_95_line"":[3.215,3.345,3.198,3.74,2.509,3.517,6.629,3.117,3.329,3.548,1.435,2.544,5.417,3.132,3.526,3.343,1.784,2.681,4.386,2.755],""QCUL_99_line"":[3.939,4.091,3.908,4.572,3.076,4.307,8.107,3.82,4.071,4.343,1.757,3.115,6.623,3.835,4.318,4.095,2.186,3.281,5.367,3.375],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.301,0.289,0.29,0.294,0.298,0.303,0.307,0.285,0.286,0.289,0.293,0.296,0.3,0.282,0.284,0.285,0.293,0.294,0.293,0.281],""T2CUL_99_line"":[0.395,0.38,0.381,0.386,0.392,0.398,0.403,0.375,0.376,0.38,0.386,0.389,0.394,0.37,0.373,0.375,0.385,0.386,0.385,0.369],""Kesi_95"":1.559,""Kesi_99"":1.325,""Kesi_95_line"":[0.192,0.184,0.185,0.187,0.19,0.193,0.195,0.182,0.182,0.184,0.187,0.189,0.191,0.179,0.181,0.182,0.186,0.187,0.186,0.179],""Kesi_99_line"":[0.177,0.17,0.17,0.172,0.175,0.178,0.18,0.168,0.168,0.17,0.172,0.174,0.176,0.165,0.167,0.167,0.172,0.172,0.172,0.165],""COV"":[[1.0,0.984,0.984,0.98,0.999,0.999,0.992,0.983,0.981,0.979,0.996,0.998,0.994,0.982,0.979,0.98,0.995,0.997,0.996,0.985],[0.984,1.0,0.999,0.996,0.987,0.982,0.962,0.999,0.997,0.994,0.99,0.984,0.968,0.998,0.995,0.992,0.989,0.983,0.973,0.997],[0.984,0.999,1.0,0.999,0.987,0.982,0.96,0.998,0.999,0.997,0.991,0.985,0.968,0.997,0.998,0.995,0.99,0.984,0.973,0.996],[0.98,0.996,0.999,1.0,0.984,0.978,0.953,0.997,0.999,0.999,0.99,0.984,0.962,0.996,0.998,0.997,0.99,0.983,0.969,0.994],[0.999,0.987,0.987,0.984,1.0,0.999,0.991,0.987,0.985,0.983,0.998,0.999,0.994,0.985,0.982,0.984,0.997,0.998,0.995,0.988],[0.999,0.982,0.982,0.978,0.999,1.0,0.994,0.981,0.979,0.978,0.996,0.999,0.996,0.979,0.976,0.979,0.994,0.997,0.997,0.983],[0.992,0.962,0.96,0.953,0.991,0.994,1.0,0.961,0.956,0.954,0.984,0.989,0.999,0.959,0.953,0.957,0.98,0.988,0.995,0.965],[0.983,0.999,0.998,0.997,0.987,0.981,0.961,1.0,0.998,0.996,0.991,0.985,0.968,0.999,0.997,0.995,0.991,0.984,0.974,0.998],[0.981,0.997,0.999,0.999,0.985,0.979,0.956,0.998,1.0,0.999,0.991,0.985,0.965,0.998,0.999,0.997,0.99,0.984,0.972,0.996],[0.979,0.994,0.997,0.999,0.983,0.978,0.954,0.996,0.999,1.0,0.991,0.985,0.964,0.997,0.999,0.999,0.991,0.984,0.971,0.994],[0.996,0.99,0.991,0.99,0.998,0.996,0.984,0.991,0.991,0.991,1.0,0.999,0.99,0.991,0.99,0.992,0.999,0.998,0.993,0.992],[0.998,0.984,0.985,0.984,0.999,0.999,0.989,0.985,0.985,0.985,0.999,1.0,0.994,0.985,0.983,0.986,0.998,1.0,0.996,0.987],[0.994,0.968,0.968,0.962,0.994,0.996,0.999,0.968,0.965,0.964,0.99,0.994,1.0,0.967,0.963,0.967,0.987,0.993,0.998,0.973],[0.982,0.998,0.997,0.996,0.985,0.979,0.959,0.999,0.998,0.997,0.991,0.985,0.967,1.0,0.998,0.997,0.991,0.985,0.975,0.999],[0.979,0.995,0.998,0.998,0.982,0.976,0.953,0.997,0.999,0.999,0.99,0.983,0.963,0.998,1.0,0.999,0.991,0.984,0.972,0.996],[0.98,0.992,0.995,0.997,0.984,0.979,0.957,0.995,0.997,0.999,0.992,0.986,0.967,0.997,0.999,1.0,0.993,0.987,0.975,0.995],[0.995,0.989,0.99,0.99,0.997,0.994,0.98,0.991,0.99,0.991,0.999,0.998,0.987,0.991,0.991,0.993,1.0,0.998,0.992,0.993],[0.997,0.983,0.984,0.983,0.998,0.997,0.988,0.984,0.984,0.984,0.998,1.0,0.993,0.985,0.984,0.987,0.998,1.0,0.997,0.988],[0.996,0.973,0.973,0.969,0.995,0.997,0.995,0.974,0.972,0.971,0.993,0.996,0.998,0.975,0.972,0.975,0.992,0.997,1.0,0.979],[0.985,0.997,0.996,0.994,0.988,0.983,0.965,0.998,0.996,0.994,0.992,0.987,0.973,0.999,0.996,0.995,0.993,0.988,0.979,1.0]],""K"":1,""R"":0.988,""featValue"":[19.761,0.197,0.02,0.011,0.006,0.003,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.193,0.15,0.216,0.288,0.455,-0.035,-0.411,0.176,-0.356,-0.339,-0.286,0.093,-0.053,-0.022,-0.099,0.053,0.052,0.027,0.025],[-0.224,-0.181,0.471,0.011,0.073,0.037,0.166,0.006,0.239,0.449,0.27,-0.337,0.071,-0.135,-0.09,0.186,0.163,-0.307,0.171,0.014],[-0.224,-0.197,0.231,0.227,-0.178,0.37,-0.004,0.168,-0.357,0.157,0.05,-0.025,-0.091,0.261,0.496,-0.003,0.038,0.335,-0.13,0.046],[-0.223,-0.243,-0.031,0.374,0.032,0.036,0.081,-0.079,0.379,0.22,-0.196,0.593,-0.239,0.145,-0.243,-0.05,0.052,0.018,-0.086,-0.047],[-0.224,0.157,0.113,0.175,0.153,-0.167,0.323,-0.041,-0.419,-0.015,-0.001,0.196,-0.238,-0.486,0.096,-0.258,-0.197,-0.193,0.094,0.236],[-0.224,0.227,0.076,0.259,0.073,-0.088,0.166,0.273,0.143,-0.31,0.434,0.069,0.178,-0.127,-0.041,0.087,-0.1,0.241,-0.115,-0.512],[-0.221,0.429,0.29,-0.066,-0.372,-0.166,0.223,-0.058,-0.038,-0.097,-0.139,0.12,0.164,0.458,-0.144,0.242,-0.179,-0.079,0.077,0.236],[-0.224,-0.194,0.275,-0.119,0.17,-0.367,-0.426,-0.307,-0.074,-0.025,0.06,0.196,0.393,0.025,0.165,-0.142,-0.053,-0.078,-0.352,-0.004],[-0.224,-0.226,0.026,0.155,-0.279,0.039,-0.38,0.256,-0.302,-0.249,-0.24,0.066,0.117,-0.245,-0.268,0.245,0.22,-0.18,0.27,-0.105],[-0.224,-0.231,-0.24,0.162,-0.248,-0.272,-0.043,-0.081,0.259,0.095,-0.116,-0.285,0.132,-0.19,0.107,0.01,-0.467,0.358,0.243,0.165],[-0.225,0.064,-0.164,0.105,0.098,-0.355,0.024,0.009,-0.113,0.051,-0.251,-0.396,-0.386,0.059,-0.035,0.323,0.122,-0.055,-0.497,-0.116],[-0.224,0.154,-0.187,0.164,0.16,-0.09,-0.323,0.303,0.199,-0.101,0.133,-0.095,-0.169,0.352,0.287,-0.251,-0.053,-0.428,0.264,0.071],[-0.222,0.362,0.036,-0.149,-0.389,-0.088,-0.197,-0.043,0.11,0.181,0.055,-0.067,-0.148,-0.166,-0.108,-0.474,0.436,0.26,-0.024,-0.02],[-0.224,-0.205,0.1,-0.387,0.12,-0.054,-0.081,-0.243,0.009,-0.332,0.297,0.085,-0.512,0.081,-0.037,0.22,0.022,0.246,0.278,0.055],[-0.224,-0.244,-0.171,-0.112,-0.189,0.289,0.063,-0.02,-0.162,-0.077,0.262,-0.193,-0.019,0.144,-0.469,-0.328,-0.329,-0.202,-0.298,0.013],[-0.224,-0.2,-0.368,-0.135,-0.26,-0.008,0.439,-0.225,0.085,-0.206,0.03,0.065,0.199,-0.022,0.376,0.01,0.364,-0.261,-0.006,-0.091],[-0.225,0.042,-0.287,-0.028,0.387,-0.096,0.111,-0.103,-0.384,0.31,-0.029,-0.031,0.259,0.291,-0.213,-0.077,0.143,0.212,0.359,-0.197],[-0.224,0.154,-0.304,-0.041,0.203,0.185,-0.096,0.196,0.079,0.045,0.23,0.129,0.206,-0.157,-0.075,0.29,0.164,0.126,-0.216,0.62],[-0.223,0.291,-0.165,-0.308,-0.065,0.329,-0.213,-0.131,0.008,0.336,-0.076,0.183,-0.072,-0.195,0.185,0.258,-0.341,-0.167,-0.002,-0.358],[-0.224,-0.144,0.156,-0.507,0.209,0.01,0.204,0.53,0.165,-0.075,-0.434,0.015,0.061,-0.035,0.03,-0.19,-0.058,0.103,-0.056,-0.03]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.221],[-0.224],[-0.224],[-0.224],[-0.225],[-0.224],[-0.222],[-0.224],[-0.224],[-0.224],[-0.225],[-0.224],[-0.223],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8570,""AfterCleanSamNum"":5978,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":440,""version"":""v-2025-12-03 15:02:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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