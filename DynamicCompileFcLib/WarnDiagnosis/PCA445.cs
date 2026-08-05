using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA445")]
    [FCDisplay("PCA445")]
    public partial class PCA445 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁139号屏5号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁139号屏6号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁140号屏1号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁140号屏2号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁140号屏3号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁140号屏4号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁140号屏5号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁140号屏6号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁141号屏1号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁141号屏2号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁141号屏3号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁141号屏4号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁141号屏5号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁141号屏6号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁142号屏1号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁142号屏2号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁142号屏3号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁142号屏4号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁142号屏5号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁142号屏6号管壁温")]
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

		public PCA445()
		{
			ModelID = 486;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA445";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""486"",""name"":""PCA445"",""description"":""中温分隔屏过热器水冷壁26-41-60"",""founder"":""admin"",""creatTime"":""2025-12-10 17:10:39"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:12:04"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 15:22:24"",""et"":""2025-12-07 13:48:46"",""duration"":2327182,""number"":7758,""filter"":2627,""mode"":5131,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2535}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah26ct141k"",""Description"":""中温（分隔屏）过热器水冷壁139号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""571.61"",""TMin"":""492.62"",""TAvg"":""538.66"",""DMax"":""2.38"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.51"",""C99"":""1.85""},{""PointId"":""d1_10hah26ct142k"",""Description"":""中温（分隔屏）过热器水冷壁139号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""570.74"",""TMin"":""493.73"",""TAvg"":""539.22"",""DMax"":""4.37"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.05"",""C99"":""3.74""},{""PointId"":""d1_10hah26ct143k"",""Description"":""中温（分隔屏）过热器水冷壁140号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""565.79"",""TMin"":""487.97"",""TAvg"":""533.44"",""DMax"":""4.85"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.27"",""C99"":""4.00""},{""PointId"":""d1_10hah26ct144k"",""Description"":""中温（分隔屏）过热器水冷壁140号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""569.32"",""TMin"":""491.48"",""TAvg"":""537.28"",""DMax"":""3.67"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.22"",""C99"":""2.72""},{""PointId"":""d1_10hah26ct145k"",""Description"":""中温（分隔屏）过热器水冷壁140号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""567.75"",""TMin"":""487.75"",""TAvg"":""534.61"",""DMax"":""4.67"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.88"",""C99"":""3.53""},{""PointId"":""d1_10hah26ct146k"",""Description"":""中温（分隔屏）过热器水冷壁140号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""575.10"",""TMin"":""495.55"",""TAvg"":""541.64"",""DMax"":""2.66"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""1.29"",""C99"":""1.58""},{""PointId"":""d1_10hah26ct147k"",""Description"":""中温（分隔屏）过热器水冷壁140号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""575.19"",""TMin"":""497.12"",""TAvg"":""543.02"",""DMax"":""3.28"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.80"",""C99"":""3.43""},{""PointId"":""d1_10hah26ct148k"",""Description"":""中温（分隔屏）过热器水冷壁140号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""576.32"",""TMin"":""499.74"",""TAvg"":""544.26"",""DMax"":""4.57"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.71"",""C99"":""4.54""},{""PointId"":""d1_10hah26ct149k"",""Description"":""中温（分隔屏）过热器水冷壁141号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""569.32"",""TMin"":""490.88"",""TAvg"":""536.60"",""DMax"":""5.43"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.21"",""C99"":""3.93""},{""PointId"":""d1_10hah26ct150k"",""Description"":""中温（分隔屏）过热器水冷壁141号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""569.58"",""TMin"":""491.20"",""TAvg"":""537.09"",""DMax"":""2.76"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.15"",""C99"":""2.63""},{""PointId"":""d1_10hah26ct151k"",""Description"":""中温（分隔屏）过热器水冷壁141号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""569.16"",""TMin"":""490.52"",""TAvg"":""536.19"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.70"",""C99"":""3.31""},{""PointId"":""d1_10hah26ct152k"",""Description"":""中温（分隔屏）过热器水冷壁141号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""573.90"",""TMin"":""494.48"",""TAvg"":""540.36"",""DMax"":""1.66"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.20"",""C99"":""1.47""},{""PointId"":""d1_10hah26ct153k"",""Description"":""中温（分隔屏）过热器水冷壁141号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""576.22"",""TMin"":""498.22"",""TAvg"":""543.06"",""DMax"":""4.44"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.91"",""C99"":""3.57""},{""PointId"":""d1_10hah26ct154k"",""Description"":""中温（分隔屏）过热器水冷壁141号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""576.70"",""TMin"":""499.22"",""TAvg"":""543.88"",""DMax"":""4.09"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.11"",""C99"":""3.81""},{""PointId"":""d1_10hah26ct155k"",""Description"":""中温（分隔屏）过热器水冷壁142号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""567.63"",""TMin"":""490.45"",""TAvg"":""535.68"",""DMax"":""5.37"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.63"",""C99"":""4.44""},{""PointId"":""d1_10hah26ct156k"",""Description"":""中温（分隔屏）过热器水冷壁142号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""568.53"",""TMin"":""490.22"",""TAvg"":""536.48"",""DMax"":""3.40"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.79"",""C99"":""3.42""},{""PointId"":""d1_10hah26ct157k"",""Description"":""中温（分隔屏）过热器水冷壁142号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""569.00"",""TMin"":""489.38"",""TAvg"":""536.30"",""DMax"":""3.66"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.25"",""C99"":""3.98""},{""PointId"":""d1_10hah26ct158k"",""Description"":""中温（分隔屏）过热器水冷壁142号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""573.22"",""TMin"":""494.45"",""TAvg"":""541.00"",""DMax"":""2.42"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.46"",""C99"":""1.78""},{""PointId"":""d1_10hah26ct159k"",""Description"":""中温（分隔屏）过热器水冷壁142号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""576.30"",""TMin"":""497.42"",""TAvg"":""543.69"",""DMax"":""4.11"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.38"",""C99"":""2.91""},{""PointId"":""d1_10hah26ct160k"",""Description"":""中温（分隔屏）过热器水冷壁142号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""574.12"",""TMin"":""496.92"",""TAvg"":""542.75"",""DMax"":""4.16"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.22"",""C99"":""3.93""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:12:04"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[492.62,493.733,487.967,491.48,487.75,495.55,497.12,499.74,490.88,491.2,490.52,494.475,498.22,499.22,490.446,490.22,489.38,494.45,497.42,496.92],""Train_X_max"":[571.613,570.742,565.786,569.32,567.75,575.1,575.191,576.32,569.32,569.58,569.16,573.9,576.22,576.7,567.633,568.533,569.0,573.22,576.3,574.117],""Train_X_std"":[9.78,9.7,9.718,9.755,9.903,9.823,9.735,9.708,9.78,9.76,9.832,9.761,9.663,9.712,9.649,9.735,9.864,9.629,9.663,9.623],""Train_X_mean"":[538.658,539.219,533.439,537.283,534.612,541.64,543.021,544.257,536.596,537.086,536.192,540.364,543.062,543.877,535.684,536.476,536.296,540.997,543.688,542.747],""Train_X_bais_max"":[[2.382,4.367,4.854,3.672,4.671,2.663,3.279,4.572,5.433,2.763,3.547,1.66,4.435,4.09,5.37,3.403,3.659,2.417,4.105,4.156]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.444,0.897,0.946,0.64,0.818,0.362,0.814,1.078,0.923,0.621,0.793,0.345,0.833,0.897,1.041,0.81,0.945,0.429,0.688,0.95]],""QCUL_95"":0.7025583,""QCUL_99"":1.25995016,""QCUL_95_line"":[1.513,3.053,3.269,2.219,2.881,1.289,2.802,3.708,3.21,2.149,2.702,1.196,2.913,3.11,3.627,2.794,3.247,1.456,2.378,3.217],""QCUL_99_line"":[1.851,3.735,4.004,2.718,3.533,1.582,3.431,4.539,3.934,2.632,3.306,1.465,3.57,3.81,4.444,3.422,3.975,1.781,2.913,3.934],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.268,0.265,0.266,0.267,0.271,0.269,0.266,0.266,0.268,0.267,0.269,0.267,0.264,0.266,0.264,0.266,0.27,0.264,0.264,0.263],""T2CUL_99_line"":[0.352,0.349,0.35,0.351,0.356,0.353,0.35,0.349,0.352,0.351,0.354,0.351,0.348,0.349,0.347,0.35,0.355,0.346,0.348,0.346],""Kesi_95"":1.56,""Kesi_99"":1.326,""Kesi_95_line"":[0.171,0.169,0.169,0.17,0.173,0.171,0.17,0.169,0.171,0.17,0.171,0.17,0.168,0.169,0.168,0.17,0.172,0.168,0.168,0.168],""Kesi_99_line"":[0.157,0.156,0.156,0.157,0.159,0.158,0.157,0.156,0.157,0.157,0.158,0.157,0.155,0.156,0.155,0.157,0.159,0.155,0.155,0.155],""COV"":[[1.0,0.997,0.987,0.993,0.991,0.999,0.997,0.994,0.987,0.992,0.991,0.999,0.996,0.996,0.983,0.989,0.988,0.998,0.997,0.995],[0.997,1.0,0.975,0.984,0.98,0.995,0.999,0.999,0.975,0.983,0.981,0.995,0.998,0.999,0.97,0.978,0.975,0.995,0.996,0.998],[0.987,0.975,1.0,0.997,0.996,0.989,0.976,0.969,1.0,0.997,0.996,0.989,0.975,0.974,0.998,0.997,0.996,0.986,0.98,0.973],[0.993,0.984,0.997,1.0,0.998,0.994,0.985,0.978,0.996,1.0,0.999,0.993,0.983,0.982,0.994,0.998,0.997,0.992,0.986,0.981],[0.991,0.98,0.996,0.998,1.0,0.992,0.981,0.972,0.996,0.998,0.998,0.991,0.978,0.976,0.994,0.998,0.999,0.99,0.982,0.976],[0.999,0.995,0.989,0.994,0.992,1.0,0.996,0.992,0.989,0.994,0.992,0.999,0.995,0.994,0.986,0.99,0.989,0.998,0.996,0.993],[0.997,0.999,0.976,0.985,0.981,0.996,1.0,0.999,0.977,0.984,0.981,0.996,0.999,0.999,0.973,0.98,0.977,0.996,0.998,0.999],[0.994,0.999,0.969,0.978,0.972,0.992,0.999,1.0,0.969,0.978,0.974,0.993,0.999,1.0,0.965,0.972,0.968,0.993,0.996,0.999],[0.987,0.975,1.0,0.996,0.996,0.989,0.977,0.969,1.0,0.998,0.996,0.99,0.976,0.975,0.999,0.997,0.996,0.987,0.981,0.974],[0.992,0.983,0.997,1.0,0.998,0.994,0.984,0.978,0.998,1.0,0.999,0.994,0.983,0.982,0.996,0.999,0.998,0.993,0.987,0.981],[0.991,0.981,0.996,0.999,0.998,0.992,0.981,0.974,0.996,0.999,1.0,0.992,0.981,0.979,0.994,0.998,0.999,0.991,0.984,0.978],[0.999,0.995,0.989,0.993,0.991,0.999,0.996,0.993,0.99,0.994,0.992,1.0,0.996,0.995,0.987,0.991,0.989,0.999,0.998,0.994],[0.996,0.998,0.975,0.983,0.978,0.995,0.999,0.999,0.976,0.983,0.981,0.996,1.0,1.0,0.972,0.979,0.975,0.996,0.999,0.999],[0.996,0.999,0.974,0.982,0.976,0.994,0.999,1.0,0.975,0.982,0.979,0.995,1.0,1.0,0.971,0.977,0.974,0.995,0.998,0.999],[0.983,0.97,0.998,0.994,0.994,0.986,0.973,0.965,0.999,0.996,0.994,0.987,0.972,0.971,1.0,0.997,0.996,0.986,0.978,0.971],[0.989,0.978,0.997,0.998,0.998,0.99,0.98,0.972,0.997,0.999,0.998,0.991,0.979,0.977,0.997,1.0,0.999,0.991,0.984,0.978],[0.988,0.975,0.996,0.997,0.999,0.989,0.977,0.968,0.996,0.998,0.999,0.989,0.975,0.974,0.996,0.999,1.0,0.989,0.981,0.974],[0.998,0.995,0.986,0.992,0.99,0.998,0.996,0.993,0.987,0.993,0.991,0.999,0.996,0.995,0.986,0.991,0.989,1.0,0.999,0.996],[0.997,0.996,0.98,0.986,0.982,0.996,0.998,0.996,0.981,0.987,0.984,0.998,0.999,0.998,0.978,0.984,0.981,0.999,1.0,0.999],[0.995,0.998,0.973,0.981,0.976,0.993,0.999,0.999,0.974,0.981,0.978,0.994,0.999,0.999,0.971,0.978,0.974,0.996,0.999,1.0]],""K"":1,""R"":0.99,""featValue"":[19.796,0.172,0.013,0.009,0.005,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.09,0.212,0.133,0.3,0.018,-0.285,0.432,-0.083,-0.308,-0.472,-0.065,-0.063,0.09,-0.125,-0.025,-0.022,-0.321,0.204,-0.135],[-0.223,0.249,0.228,0.322,-0.122,0.108,-0.383,-0.27,-0.28,-0.048,-0.048,0.267,0.281,0.243,-0.026,0.001,-0.019,0.397,-0.141,0.123],[-0.223,-0.265,-0.292,0.395,0.051,-0.081,-0.077,-0.33,0.179,-0.372,-0.02,-0.193,-0.03,-0.148,0.267,-0.047,0.366,0.008,0.219,0.169],[-0.224,-0.168,0.199,0.224,-0.337,-0.055,0.36,-0.247,-0.002,-0.102,-0.282,0.234,-0.438,-0.149,-0.26,0.002,-0.152,-0.076,-0.207,-0.167],[-0.224,-0.222,0.378,0.049,0.196,0.359,-0.001,-0.033,0.474,-0.063,0.286,0.073,0.347,-0.254,-0.055,0.109,-0.233,-0.109,-0.064,-0.032],[-0.225,0.055,0.097,0.105,0.482,0.109,0.274,0.005,-0.242,0.308,-0.122,-0.237,-0.147,-0.28,0.249,-0.103,-0.102,0.429,0.024,-0.119],[-0.224,0.241,0.068,0.083,-0.01,0.305,0.288,0.285,-0.28,-0.14,0.445,0.14,-0.202,-0.011,0.007,0.046,0.396,-0.19,-0.076,0.255],[-0.223,0.326,-0.066,0.232,-0.197,-0.034,-0.048,-0.085,0.068,0.078,0.278,-0.613,-0.146,0.207,-0.096,0.201,-0.363,-0.135,0.059,-0.071],[-0.223,-0.262,-0.37,0.211,0.14,0.026,-0.063,0.145,0.01,0.206,0.116,0.152,0.005,0.34,0.142,-0.425,-0.164,-0.216,-0.41,-0.132],[-0.224,-0.179,0.057,0.06,-0.246,0.022,0.386,0.265,0.205,0.222,-0.168,0.032,0.193,0.409,-0.016,-0.05,0.009,0.201,0.45,0.243],[-0.224,-0.204,0.322,-0.071,-0.102,-0.519,-0.19,0.062,-0.205,0.207,0.162,0.13,-0.068,-0.132,0.428,0.157,-0.142,-0.226,0.087,0.209],[-0.225,0.064,-0.055,-0.075,0.356,-0.293,0.205,-0.203,0.079,0.17,-0.114,0.041,0.193,0.26,-0.151,0.515,0.336,-0.129,-0.235,-0.115],[-0.223,0.254,-0.106,-0.095,-0.001,-0.4,0.135,0.116,0.092,-0.334,0.312,0.257,0.115,-0.054,-0.001,-0.173,-0.064,0.236,0.212,-0.489],[-0.223,0.273,-0.115,0.059,-0.114,-0.241,-0.138,0.152,0.216,0.329,-0.103,-0.054,0.143,-0.464,-0.366,-0.289,0.181,-0.025,-0.134,0.27],[-0.223,-0.298,-0.488,-0.07,0.013,0.15,-0.196,0.123,-0.273,0.051,0.073,0.182,-0.044,-0.201,-0.333,0.404,-0.213,0.142,0.209,0.033],[-0.224,-0.233,0.018,-0.257,-0.372,0.058,0.091,0.146,-0.307,-0.197,-0.122,-0.409,0.414,-0.11,0.09,-0.008,0.128,0.032,-0.307,-0.199],[-0.223,-0.264,0.243,-0.356,0.026,0.019,-0.342,-0.045,0.146,0.076,0.191,-0.163,-0.416,0.219,-0.231,-0.16,0.319,0.269,-0.004,-0.106],[-0.224,0.08,-0.028,-0.394,0.14,0.092,0.118,-0.508,-0.264,-0.021,-0.018,0.005,0.137,0.053,-0.149,-0.365,-0.14,-0.339,0.287,0.154],[-0.224,0.189,-0.162,-0.381,0.066,-0.008,0.034,0.072,0.266,-0.344,-0.187,0.029,-0.182,0.069,0.217,0.09,-0.287,0.203,-0.312,0.44],[-0.223,0.273,-0.145,-0.172,-0.275,0.366,-0.173,-0.082,0.202,0.284,-0.203,0.191,-0.093,-0.088,0.411,0.12,0.166,-0.151,0.139,-0.333]],""selectVec"":[[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.225],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.225],[-0.223],[-0.223],[-0.223],[-0.224],[-0.223],[-0.224],[-0.224],[-0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7758,""AfterCleanSamNum"":5131,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":486,""version"":""v-2025-12-10 17:12:04"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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