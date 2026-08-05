using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA451")]
    [FCDisplay("PCA451")]
    public partial class PCA451 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁159号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁159号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁159号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁160号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁160号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁160号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁160号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁160号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁160号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁161号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁161号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁161号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁161号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁161号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁161号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁162号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁162号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁162号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁162号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁162号屏5号管壁温")]
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

		public PCA451()
		{
			ModelID = 492;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA451";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""492"",""name"":""PCA451"",""description"":""中温分隔屏过热器水冷壁27-61-80"",""founder"":""admin"",""creatTime"":""2025-12-10 17:25:47"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:27:16"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 15:22:24"",""et"":""2025-12-07 15:18:02"",""duration"":2332538,""number"":7776,""filter"":2630,""mode"":5146,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2540}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah27ct161k"",""Description"":""中温（分隔屏）过热器水冷壁159号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""570.10"",""TMin"":""491.62"",""TAvg"":""543.32"",""DMax"":""2.63"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.55"",""C99"":""1.90""},{""PointId"":""d1_10hah27ct162k"",""Description"":""中温（分隔屏）过热器水冷壁159号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""570.43"",""TMin"":""491.50"",""TAvg"":""543.82"",""DMax"":""3.46"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.11"",""C99"":""2.59""},{""PointId"":""d1_10hah27ct163k"",""Description"":""中温（分隔屏）过热器水冷壁159号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""571.88"",""TMin"":""494.66"",""TAvg"":""546.53"",""DMax"":""6.09"",""DMin"":""0.00"",""DAvg"":""1.30"",""C95"":""4.36"",""C99"":""5.33""},{""PointId"":""d1_10hah27ct164k"",""Description"":""中温（分隔屏）过热器水冷壁160号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""564.08"",""TMin"":""490.24"",""TAvg"":""538.44"",""DMax"":""4.11"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.57"",""C99"":""3.15""},{""PointId"":""d1_10hah27ct165k"",""Description"":""中温（分隔屏）过热器水冷壁160号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""565.38"",""TMin"":""489.03"",""TAvg"":""539.41"",""DMax"":""3.63"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.18"",""C99"":""2.68""},{""PointId"":""d1_10hah27ct166k"",""Description"":""中温（分隔屏）过热器水冷壁160号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""565.28"",""TMin"":""487.22"",""TAvg"":""538.49"",""DMax"":""4.01"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.71"",""C99"":""3.33""},{""PointId"":""d1_10hah27ct167k"",""Description"":""中温（分隔屏）过热器水冷壁160号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""569.82"",""TMin"":""492.16"",""TAvg"":""543.68"",""DMax"":""2.12"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.40"",""C99"":""1.71""},{""PointId"":""d1_10hah27ct168k"",""Description"":""中温（分隔屏）过热器水冷壁160号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""571.23"",""TMin"":""493.82"",""TAvg"":""546.05"",""DMax"":""3.82"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.47"",""C99"":""4.24""},{""PointId"":""d1_10hah27ct169k"",""Description"":""中温（分隔屏）过热器水冷壁160号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""570.38"",""TMin"":""495.88"",""TAvg"":""546.02"",""DMax"":""6.03"",""DMin"":""0.00"",""DAvg"":""1.29"",""C95"":""4.37"",""C99"":""5.35""},{""PointId"":""d1_10hah27ct170k"",""Description"":""中温（分隔屏）过热器水冷壁161号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""564.88"",""TMin"":""489.38"",""TAvg"":""538.62"",""DMax"":""3.88"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.46"",""C99"":""3.01""},{""PointId"":""d1_10hah27ct171k"",""Description"":""中温（分隔屏）过热器水冷壁161号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""565.80"",""TMin"":""488.70"",""TAvg"":""539.35"",""DMax"":""3.75"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.66"",""C99"":""3.25""},{""PointId"":""d1_10hah27ct172k"",""Description"":""中温（分隔屏）过热器水冷壁161号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""564.55"",""TMin"":""486.88"",""TAvg"":""537.91"",""DMax"":""4.09"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.89"",""C99"":""3.54""},{""PointId"":""d1_10hah27ct173k"",""Description"":""中温（分隔屏）过热器水冷壁161号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""569.17"",""TMin"":""491.34"",""TAvg"":""542.93"",""DMax"":""1.53"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""0.87"",""C99"":""1.07""},{""PointId"":""d1_10hah27ct174k"",""Description"":""中温（分隔屏）过热器水冷壁161号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""569.72"",""TMin"":""492.34"",""TAvg"":""544.39"",""DMax"":""2.82"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.83"",""C99"":""2.24""},{""PointId"":""d1_10hah27ct175k"",""Description"":""中温（分隔屏）过热器水冷壁161号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""572.07"",""TMin"":""497.70"",""TAvg"":""548.56"",""DMax"":""6.07"",""DMin"":""0.00"",""DAvg"":""1.20"",""C95"":""4.14"",""C99"":""5.07""},{""PointId"":""d1_10hah27ct176k"",""Description"":""中温（分隔屏）过热器水冷壁162号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""566.10"",""TMin"":""488.74"",""TAvg"":""539.23"",""DMax"":""2.98"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.58"",""C99"":""3.16""},{""PointId"":""d1_10hah27ct177k"",""Description"":""中温（分隔屏）过热器水冷壁162号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""567.26"",""TMin"":""487.26"",""TAvg"":""539.54"",""DMax"":""4.04"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.19"",""C99"":""3.90""},{""PointId"":""d1_10hah27ct178k"",""Description"":""中温（分隔屏）过热器水冷壁162号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""566.00"",""TMin"":""484.76"",""TAvg"":""537.39"",""DMax"":""3.92"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.66"",""C99"":""4.48""},{""PointId"":""d1_10hah27ct179k"",""Description"":""中温（分隔屏）过热器水冷壁162号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""571.13"",""TMin"":""492.20"",""TAvg"":""544.48"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.73"",""C99"":""2.12""},{""PointId"":""d1_10hah27ct180k"",""Description"":""中温（分隔屏）过热器水冷壁162号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""572.22"",""TMin"":""493.54"",""TAvg"":""545.95"",""DMax"":""4.42"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.26"",""C99"":""2.77""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:27:16"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[491.62,491.5,494.66,490.24,489.025,487.22,492.16,493.82,495.88,489.38,488.7,486.88,491.34,492.34,497.7,488.74,487.26,484.76,492.2,493.54],""Train_X_max"":[570.1,570.433,571.883,564.08,565.38,565.275,569.817,571.233,570.383,564.88,565.8,564.55,569.167,569.717,572.067,566.1,567.26,566.0,571.133,572.217],""Train_X_std"":[9.435,9.434,9.331,9.319,9.428,9.546,9.465,9.393,9.269,9.342,9.363,9.46,9.423,9.347,9.213,9.265,9.46,9.587,9.353,9.368],""Train_X_mean"":[543.32,543.824,546.529,538.438,539.405,538.49,543.678,546.052,546.022,538.618,539.348,537.906,542.926,544.387,548.562,539.233,539.539,537.388,544.484,545.949],""Train_X_bais_max"":[[2.628,3.462,6.093,4.105,3.629,4.005,2.118,3.821,6.033,3.879,3.753,4.088,1.533,2.818,6.068,2.984,4.035,3.921,3.073,4.423]],""Train_X_bais_min"":[[0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.446,0.608,1.295,0.738,0.612,0.765,0.395,1.036,1.289,0.712,0.777,0.844,0.25,0.524,1.201,0.754,0.948,1.088,0.496,0.632]],""QCUL_95"":0.779363453,""QCUL_99"":1.39916766,""QCUL_95_line"":[1.551,2.114,4.364,2.57,2.184,2.71,1.397,3.467,4.373,2.455,2.655,2.889,0.874,1.825,4.142,2.582,3.193,3.662,1.728,2.256],""QCUL_99_line"":[1.901,2.59,5.334,3.15,2.681,3.326,1.714,4.237,5.349,3.006,3.249,3.535,1.071,2.237,5.072,3.16,3.903,4.476,2.117,2.769],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.258,0.258,0.255,0.255,0.258,0.261,0.259,0.257,0.253,0.255,0.256,0.259,0.258,0.255,0.252,0.253,0.259,0.262,0.256,0.256],""T2CUL_99_line"":[0.339,0.339,0.335,0.335,0.339,0.343,0.34,0.337,0.333,0.336,0.336,0.34,0.339,0.336,0.331,0.333,0.34,0.344,0.336,0.337],""Kesi_95"":1.557,""Kesi_99"":1.317,""Kesi_95_line"":[0.164,0.164,0.162,0.162,0.164,0.166,0.165,0.163,0.161,0.162,0.163,0.165,0.164,0.163,0.16,0.161,0.165,0.167,0.163,0.163],""Kesi_99_line"":[0.151,0.151,0.149,0.149,0.151,0.153,0.151,0.15,0.148,0.149,0.15,0.151,0.151,0.15,0.147,0.148,0.151,0.153,0.15,0.15],""COV"":[[1.0,0.999,0.99,0.991,0.993,0.991,0.999,0.993,0.989,0.991,0.989,0.989,0.998,0.996,0.987,0.99,0.987,0.986,0.997,0.996],[0.999,1.0,0.995,0.987,0.988,0.985,0.998,0.997,0.994,0.986,0.984,0.983,0.996,0.998,0.993,0.986,0.982,0.979,0.995,0.997],[0.99,0.995,1.0,0.97,0.972,0.967,0.99,0.997,0.999,0.969,0.966,0.963,0.984,0.991,0.998,0.968,0.96,0.955,0.983,0.989],[0.991,0.987,0.97,1.0,0.998,0.997,0.992,0.978,0.969,0.999,0.996,0.995,0.994,0.987,0.97,0.998,0.995,0.993,0.99,0.984],[0.993,0.988,0.972,0.998,1.0,0.999,0.993,0.98,0.971,0.998,0.999,0.998,0.996,0.99,0.973,0.996,0.996,0.995,0.992,0.986],[0.991,0.985,0.967,0.997,0.999,1.0,0.991,0.976,0.966,0.997,0.998,0.999,0.995,0.987,0.967,0.995,0.996,0.997,0.99,0.984],[0.999,0.998,0.99,0.992,0.993,0.991,1.0,0.995,0.99,0.992,0.989,0.989,0.998,0.998,0.989,0.99,0.986,0.984,0.996,0.995],[0.993,0.997,0.997,0.978,0.98,0.976,0.995,1.0,0.998,0.977,0.975,0.973,0.99,0.996,0.997,0.976,0.969,0.965,0.987,0.992],[0.989,0.994,0.999,0.969,0.971,0.966,0.99,0.998,1.0,0.969,0.966,0.963,0.983,0.991,0.999,0.967,0.959,0.954,0.983,0.989],[0.991,0.986,0.969,0.999,0.998,0.997,0.992,0.977,0.969,1.0,0.997,0.996,0.995,0.989,0.971,0.999,0.997,0.995,0.992,0.986],[0.989,0.984,0.966,0.996,0.999,0.998,0.989,0.975,0.966,0.997,1.0,0.999,0.995,0.988,0.969,0.997,0.998,0.997,0.992,0.986],[0.989,0.983,0.963,0.995,0.998,0.999,0.989,0.973,0.963,0.996,0.999,1.0,0.995,0.987,0.965,0.996,0.998,0.999,0.991,0.985],[0.998,0.996,0.984,0.994,0.996,0.995,0.998,0.99,0.983,0.995,0.995,0.995,1.0,0.998,0.985,0.994,0.993,0.992,0.998,0.997],[0.996,0.998,0.991,0.987,0.99,0.987,0.998,0.996,0.991,0.989,0.988,0.987,0.998,1.0,0.993,0.988,0.985,0.982,0.996,0.997],[0.987,0.993,0.998,0.97,0.973,0.967,0.989,0.997,0.999,0.971,0.969,0.965,0.985,0.993,1.0,0.969,0.962,0.957,0.984,0.991],[0.99,0.986,0.968,0.998,0.996,0.995,0.99,0.976,0.967,0.999,0.997,0.996,0.994,0.988,0.969,1.0,0.998,0.996,0.993,0.987],[0.987,0.982,0.96,0.995,0.996,0.996,0.986,0.969,0.959,0.997,0.998,0.998,0.993,0.985,0.962,0.998,1.0,0.999,0.992,0.985],[0.986,0.979,0.955,0.993,0.995,0.997,0.984,0.965,0.954,0.995,0.997,0.999,0.992,0.982,0.957,0.996,0.999,1.0,0.99,0.982],[0.997,0.995,0.983,0.99,0.992,0.99,0.996,0.987,0.983,0.992,0.992,0.991,0.998,0.996,0.984,0.993,0.992,0.99,1.0,0.998],[0.996,0.997,0.989,0.984,0.986,0.984,0.995,0.992,0.989,0.986,0.986,0.985,0.997,0.997,0.991,0.987,0.985,0.982,0.998,1.0]],""K"":1,""R"":0.988,""featValue"":[19.768,0.187,0.019,0.01,0.009,0.004,0.002,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.225,0.069,-0.009,0.098,0.494,0.119,-0.121,0.167,0.228,-0.248,-0.219,0.305,-0.435,0.153,-0.294,-0.184,0.039,0.026,-0.101,0.189],[-0.224,0.164,0.04,0.038,0.341,0.01,0.356,0.343,0.035,0.212,0.161,-0.118,-0.091,0.059,0.291,0.06,-0.142,0.351,-0.012,-0.48],[-0.222,0.379,-0.12,-0.078,0.144,0.316,0.346,-0.077,0.293,-0.203,0.069,-0.137,0.445,0.059,0.059,0.045,0.135,-0.254,0.192,0.251],[-0.224,-0.173,-0.398,-0.332,0.127,-0.051,-0.148,0.254,-0.03,0.235,0.162,-0.074,-0.228,-0.369,-0.056,0.297,0.238,-0.22,0.261,0.084],[-0.224,-0.162,-0.292,0.161,-0.079,0.175,0.145,0.07,-0.237,0.139,-0.204,0.378,0.27,-0.309,0.215,-0.304,0.213,0.261,-0.207,0.161],[-0.224,-0.206,-0.237,0.393,0.059,0.112,-0.1,-0.156,0.119,0.378,0.09,0.146,0.197,0.147,-0.242,0.003,-0.411,-0.348,0.033,-0.225],[-0.225,0.081,-0.132,0.101,0.227,-0.31,-0.192,-0.039,-0.421,-0.05,-0.204,-0.266,0.264,0.194,-0.163,0.128,-0.159,0.35,0.28,0.247],[-0.223,0.287,-0.176,0.152,-0.052,-0.432,0.218,-0.378,-0.266,-0.167,0.04,0.262,-0.264,0.08,0.167,0.083,0.202,-0.277,-0.009,-0.19],[-0.222,0.385,-0.146,-0.021,-0.088,0.272,-0.304,-0.217,-0.133,-0.041,0.283,-0.295,-0.169,-0.24,-0.038,-0.04,-0.21,0.107,-0.475,0.05],[-0.224,-0.183,-0.205,-0.407,-0.086,-0.125,-0.194,0.124,0.022,-0.019,0.03,-0.156,0.093,0.56,0.225,-0.385,0.092,-0.146,-0.223,-0.074],[-0.224,-0.213,-0.004,0.131,-0.368,0.223,0.117,0.348,-0.162,-0.359,0.083,0.111,-0.045,0.258,-0.022,0.532,-0.091,0.007,-0.16,0.08],[-0.224,-0.238,0.031,0.332,-0.13,0.005,-0.214,-0.092,0.253,-0.286,0.193,-0.134,-0.187,-0.124,0.45,-0.212,-0.092,0.11,0.43,0.088],[-0.225,-0.015,0.142,0.136,-0.046,-0.215,-0.224,0.165,0.15,-0.321,0.03,-0.085,0.349,-0.268,-0.337,-0.048,0.339,0.007,-0.102,-0.465],[-0.224,0.116,0.129,0.132,-0.259,-0.494,0.199,0.252,0.332,0.241,-0.16,-0.167,-0.054,-0.14,-0.019,-0.031,-0.174,-0.107,-0.244,0.374],[-0.222,0.356,0.019,-0.113,-0.495,0.233,-0.14,0.001,0.105,0.248,-0.38,0.083,-0.161,0.133,-0.128,-0.023,0.096,0.172,0.354,-0.207],[-0.224,-0.194,-0.007,-0.513,-0.02,-0.159,0.12,-0.365,0.28,-0.163,0.014,0.307,0.094,-0.139,-0.083,0.139,-0.351,0.309,-0.02,-0.053],[-0.223,-0.265,0.192,-0.111,-0.069,0.15,0.458,-0.066,-0.342,-0.099,-0.06,-0.313,-0.2,-0.132,-0.33,-0.369,-0.106,-0.162,0.134,-0.059],[-0.223,-0.302,0.231,0.121,0.11,0.107,0.044,-0.429,0.153,0.284,-0.058,-0.248,-0.085,0.172,0.006,0.275,0.473,0.171,-0.2,0.08],[-0.224,0.003,0.436,-0.138,0.198,0.111,-0.252,0.009,-0.183,-0.007,-0.428,0.043,0.101,-0.187,0.393,0.163,-0.181,-0.371,-0.064,-0.077],[-0.224,0.118,0.504,-0.084,-0.014,-0.038,-0.113,0.078,-0.194,0.227,0.562,0.356,0.102,0.095,-0.093,-0.128,0.092,0.013,0.136,0.226]],""selectVec"":[[-0.225],[-0.224],[-0.222],[-0.224],[-0.224],[-0.224],[-0.225],[-0.223],[-0.222],[-0.224],[-0.224],[-0.224],[-0.225],[-0.224],[-0.222],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7776,""AfterCleanSamNum"":5146,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":492,""version"":""v-2025-12-10 17:27:16"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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