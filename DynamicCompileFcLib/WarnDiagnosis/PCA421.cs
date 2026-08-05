using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA421")]
    [FCDisplay("PCA421")]
    public partial class PCA421 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁60号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁60号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁60号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁61号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁61号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁61号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁61号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁61号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁61号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁62号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁62号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁62号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁62号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁62号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁62号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁63号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁63号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁63号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁63号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁63号屏5号管壁温")]
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

		public PCA421()
		{
			ModelID = 462;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA421";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""462"",""name"":""PCA421"",""description"":""中温分隔屏过热器水冷壁21-61-80"",""founder"":""admin"",""creatTime"":""2025-12-09 10:14:18"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:16:01"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 20:01:56"",""et"":""2025-12-06 22:56:06"",""duration"":2343250,""number"":7811,""filter"":2594,""mode"":5217,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2504}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah21ct161k"",""Description"":""中温（分隔屏）过热器水冷壁60号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""572.60"",""TMin"":""486.47"",""TAvg"":""538.95"",""DMax"":""3.43"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.15"",""C99"":""2.63""},{""PointId"":""d1_10hah21ct162k"",""Description"":""中温（分隔屏）过热器水冷壁60号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""574.20"",""TMin"":""487.93"",""TAvg"":""540.38"",""DMax"":""3.21"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.56"",""C99"":""3.13""},{""PointId"":""d1_10hah21ct163k"",""Description"":""中温（分隔屏）过热器水冷壁60号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""574.55"",""TMin"":""488.62"",""TAvg"":""540.69"",""DMax"":""4.04"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.37"",""C99"":""4.12""},{""PointId"":""d1_10hah21ct164k"",""Description"":""中温（分隔屏）过热器水冷壁61号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""567.13"",""TMin"":""480.81"",""TAvg"":""532.76"",""DMax"":""4.81"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.07"",""C99"":""3.76""},{""PointId"":""d1_10hah21ct165k"",""Description"":""中温（分隔屏）过热器水冷壁61号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""567.08"",""TMin"":""479.16"",""TAvg"":""533.89"",""DMax"":""4.49"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.50"",""C99"":""3.05""},{""PointId"":""d1_10hah21ct166k"",""Description"":""中温（分隔屏）过热器水冷壁61号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""564.67"",""TMin"":""476.33"",""TAvg"":""531.38"",""DMax"":""4.10"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.63"",""C99"":""3.22""},{""PointId"":""d1_10hah21ct167k"",""Description"":""中温（分隔屏）过热器水冷壁61号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.87"",""TMin"":""484.84"",""TAvg"":""537.90"",""DMax"":""2.44"",""DMin"":""0.00"",""DAvg"":""0.33"",""C95"":""1.18"",""C99"":""1.45""},{""PointId"":""d1_10hah21ct168k"",""Description"":""中温（分隔屏）过热器水冷壁61号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""573.53"",""TMin"":""486.91"",""TAvg"":""539.32"",""DMax"":""2.77"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.05"",""C99"":""2.50""},{""PointId"":""d1_10hah21ct169k"",""Description"":""中温（分隔屏）过热器水冷壁61号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""575.85"",""TMin"":""490.14"",""TAvg"":""542.03"",""DMax"":""4.24"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.02"",""C99"":""3.70""},{""PointId"":""d1_10hah21ct170k"",""Description"":""中温（分隔屏）过热器水冷壁62号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""567.75"",""TMin"":""482.40"",""TAvg"":""533.71"",""DMax"":""4.40"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.04"",""C99"":""3.72""},{""PointId"":""d1_10hah21ct171k"",""Description"":""中温（分隔屏）过热器水冷壁62号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""568.78"",""TMin"":""482.60"",""TAvg"":""535.40"",""DMax"":""2.41"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.38"",""C99"":""2.91""},{""PointId"":""d1_10hah21ct172k"",""Description"":""中温（分隔屏）过热器水冷壁62号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""567.34"",""TMin"":""479.19"",""TAvg"":""534.26"",""DMax"":""3.82"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.83"",""C99"":""3.46""},{""PointId"":""d1_10hah21ct173k"",""Description"":""中温（分隔屏）过热器水冷壁62号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""573.10"",""TMin"":""486.82"",""TAvg"":""539.39"",""DMax"":""1.72"",""DMin"":""0.00"",""DAvg"":""0.23"",""C95"":""0.78"",""C99"":""0.96""},{""PointId"":""d1_10hah21ct174k"",""Description"":""中温（分隔屏）过热器水冷壁62号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""575.45"",""TMin"":""490.37"",""TAvg"":""541.62"",""DMax"":""3.12"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.79"",""C99"":""2.19""},{""PointId"":""d1_10hah21ct175k"",""Description"":""中温（分隔屏）过热器水冷壁62号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""577.17"",""TMin"":""493.48"",""TAvg"":""543.85"",""DMax"":""4.47"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.79"",""C99"":""3.41""},{""PointId"":""d1_10hah21ct176k"",""Description"":""中温（分隔屏）过热器水冷壁63号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""569.62"",""TMin"":""485.80"",""TAvg"":""536.14"",""DMax"":""3.69"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.82"",""C99"":""3.46""},{""PointId"":""d1_10hah21ct177k"",""Description"":""中温（分隔屏）过热器水冷壁63号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""569.50"",""TMin"":""484.97"",""TAvg"":""537.11"",""DMax"":""2.74"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.07"",""C99"":""2.53""},{""PointId"":""d1_10hah21ct178k"",""Description"":""中温（分隔屏）过热器水冷壁63号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""568.42"",""TMin"":""482.67"",""TAvg"":""535.52"",""DMax"":""2.49"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.04"",""C99"":""2.49""},{""PointId"":""d1_10hah21ct179k"",""Description"":""中温（分隔屏）过热器水冷壁63号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""576.60"",""TMin"":""492.09"",""TAvg"":""543.32"",""DMax"":""2.92"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.17"",""C99"":""2.66""},{""PointId"":""d1_10hah21ct180k"",""Description"":""中温（分隔屏）过热器水冷壁63号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""577.93"",""TMin"":""495.00"",""TAvg"":""544.60"",""DMax"":""5.37"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.92"",""C99"":""3.58""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:16:01"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[486.471,487.929,488.617,480.814,479.157,476.329,484.843,486.914,490.143,482.4,482.6,479.186,486.817,490.371,493.483,485.8,484.971,482.667,492.086,495.0],""Train_X_max"":[572.6,574.2,574.55,567.133,567.083,564.667,571.867,573.533,575.85,567.75,568.783,567.34,573.1,575.45,577.167,569.617,569.5,568.42,576.6,577.933],""Train_X_std"":[9.077,9.013,8.927,9.113,9.284,9.359,9.142,9.085,8.915,9.088,9.182,9.372,9.089,9.016,8.893,9.008,9.089,9.217,8.99,8.926],""Train_X_mean"":[538.949,540.378,540.689,532.762,533.89,531.377,537.904,539.317,542.027,533.711,535.401,534.263,539.386,541.615,543.85,536.139,537.111,535.516,543.319,544.603],""Train_X_bais_max"":[[3.433,3.209,4.04,4.814,4.486,4.096,2.441,2.766,4.236,4.396,2.411,3.817,1.715,3.117,4.465,3.69,2.739,2.49,2.916,5.37]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.001]],""Train_X_bais_mean"":[[0.625,0.76,0.996,0.894,0.727,0.772,0.333,0.603,0.888,0.883,0.705,0.828,0.226,0.519,0.818,0.816,0.606,0.591,0.631,0.857]],""QCUL_95"":0.61701256,""QCUL_99"":1.09462488,""QCUL_95_line"":[2.145,2.557,3.369,3.07,2.495,2.631,1.178,2.045,3.02,3.037,2.378,2.825,0.781,1.786,2.786,2.823,2.068,2.036,2.171,2.923],""QCUL_99_line"":[2.626,3.126,4.119,3.759,3.054,3.218,1.445,2.502,3.695,3.719,2.907,3.457,0.957,2.186,3.408,3.458,2.53,2.493,2.658,3.577],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.246,0.245,0.242,0.247,0.252,0.254,0.248,0.247,0.242,0.247,0.249,0.254,0.247,0.245,0.241,0.245,0.247,0.25,0.244,0.242],""T2CUL_99_line"":[0.324,0.322,0.318,0.325,0.331,0.334,0.326,0.324,0.318,0.324,0.328,0.334,0.324,0.322,0.317,0.321,0.324,0.329,0.321,0.318],""Kesi_95"":1.554,""Kesi_99"":1.307,""Kesi_95_line"":[0.157,0.156,0.154,0.157,0.16,0.162,0.158,0.157,0.154,0.157,0.158,0.162,0.157,0.156,0.153,0.155,0.157,0.159,0.155,0.154],""Kesi_99_line"":[0.144,0.143,0.141,0.144,0.147,0.148,0.145,0.144,0.141,0.144,0.145,0.148,0.144,0.143,0.141,0.143,0.144,0.146,0.142,0.141],""COV"":[[1.0,0.998,0.996,0.984,0.988,0.989,0.998,0.998,0.995,0.983,0.986,0.985,0.996,0.996,0.994,0.983,0.988,0.988,0.995,0.993],[0.998,1.0,0.998,0.981,0.984,0.986,0.996,0.999,0.997,0.979,0.982,0.981,0.994,0.996,0.994,0.979,0.984,0.986,0.993,0.992],[0.996,0.998,1.0,0.972,0.977,0.977,0.991,0.997,0.999,0.971,0.975,0.973,0.99,0.995,0.996,0.972,0.978,0.979,0.992,0.993],[0.984,0.981,0.972,1.0,0.997,0.996,0.992,0.984,0.973,0.999,0.996,0.997,0.99,0.983,0.975,0.997,0.993,0.994,0.98,0.973],[0.988,0.984,0.977,0.997,1.0,0.999,0.995,0.987,0.979,0.997,0.998,0.999,0.994,0.987,0.979,0.995,0.996,0.997,0.985,0.979],[0.989,0.986,0.977,0.996,0.999,1.0,0.995,0.988,0.978,0.995,0.997,0.999,0.993,0.987,0.978,0.993,0.994,0.997,0.984,0.978],[0.998,0.996,0.991,0.992,0.995,0.995,1.0,0.997,0.992,0.991,0.993,0.993,0.998,0.996,0.991,0.991,0.993,0.995,0.994,0.991],[0.998,0.999,0.997,0.984,0.987,0.988,0.997,1.0,0.997,0.982,0.986,0.985,0.996,0.998,0.996,0.983,0.988,0.99,0.995,0.994],[0.995,0.997,0.999,0.973,0.979,0.978,0.992,0.997,1.0,0.973,0.979,0.975,0.993,0.997,0.998,0.975,0.983,0.983,0.995,0.996],[0.983,0.979,0.971,0.999,0.997,0.995,0.991,0.982,0.973,1.0,0.997,0.996,0.991,0.984,0.976,0.999,0.995,0.994,0.982,0.975],[0.986,0.982,0.975,0.996,0.998,0.997,0.993,0.986,0.979,0.997,1.0,0.999,0.995,0.989,0.982,0.997,0.999,0.999,0.988,0.982],[0.985,0.981,0.973,0.997,0.999,0.999,0.993,0.985,0.975,0.996,0.999,1.0,0.993,0.985,0.977,0.995,0.996,0.998,0.984,0.977],[0.996,0.994,0.99,0.99,0.994,0.993,0.998,0.996,0.993,0.991,0.995,0.993,1.0,0.998,0.995,0.993,0.997,0.996,0.998,0.995],[0.996,0.996,0.995,0.983,0.987,0.987,0.996,0.998,0.997,0.984,0.989,0.985,0.998,1.0,0.998,0.986,0.991,0.991,0.998,0.998],[0.994,0.994,0.996,0.975,0.979,0.978,0.991,0.996,0.998,0.976,0.982,0.977,0.995,0.998,1.0,0.98,0.987,0.985,0.998,0.999],[0.983,0.979,0.972,0.997,0.995,0.993,0.991,0.983,0.975,0.999,0.997,0.995,0.993,0.986,0.98,1.0,0.997,0.996,0.986,0.979],[0.988,0.984,0.978,0.993,0.996,0.994,0.993,0.988,0.983,0.995,0.999,0.996,0.997,0.991,0.987,0.997,1.0,0.999,0.992,0.988],[0.988,0.986,0.979,0.994,0.997,0.997,0.995,0.99,0.983,0.994,0.999,0.998,0.996,0.991,0.985,0.996,0.999,1.0,0.991,0.985],[0.995,0.993,0.992,0.98,0.985,0.984,0.994,0.995,0.995,0.982,0.988,0.984,0.998,0.998,0.998,0.986,0.992,0.991,1.0,0.998],[0.993,0.992,0.993,0.973,0.979,0.978,0.991,0.994,0.996,0.975,0.982,0.977,0.995,0.998,0.999,0.979,0.988,0.985,0.998,1.0]],""K"":1,""R"":0.99,""featValue"":[19.808,0.141,0.027,0.012,0.005,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,-0.156,-0.244,-0.019,0.549,0.37,0.016,-0.213,0.199,0.064,-0.119,0.222,-0.2,-0.277,-0.102,-0.277,-0.26,-0.052,0.009,0.022],[0.224,-0.217,-0.338,-0.053,-0.048,-0.221,-0.218,0.037,0.358,0.456,0.157,-0.042,0.057,0.121,0.091,-0.191,0.445,-0.045,-0.167,-0.183],[0.223,-0.334,-0.261,-0.082,-0.243,0.184,-0.239,-0.106,-0.278,0.21,0.226,0.124,-0.07,-0.043,0.043,0.548,-0.194,0.094,0.195,0.147],[0.223,0.284,-0.201,-0.41,-0.19,-0.059,0.088,0.02,-0.022,-0.14,0.269,-0.049,-0.249,0.167,-0.546,-0.24,0.024,0.047,0.139,0.226],[0.224,0.231,-0.149,0.164,-0.078,0.437,0.086,0.153,0.106,0.025,0.212,-0.303,0.486,0.192,-0.04,-0.017,-0.331,0.062,-0.14,-0.25],[0.224,0.214,-0.276,0.332,0.107,-0.064,0.033,-0.257,-0.342,-0.068,-0.278,0.355,0.148,0.491,0.023,-0.023,0.182,0.008,-0.03,0.11],[0.224,-0.012,-0.211,-0.004,0.373,-0.038,0.083,0.047,-0.223,-0.28,-0.066,-0.54,-0.088,-0.165,0.027,0.235,0.368,0.141,0.196,-0.215],[0.224,-0.178,-0.213,0.044,-0.09,-0.374,0.127,-0.052,0.241,-0.419,-0.007,-0.039,0.19,-0.108,0.022,0.162,-0.213,-0.561,-0.104,0.155],[0.223,-0.309,-0.037,0.015,-0.423,0.21,-0.149,0.141,0.059,-0.436,-0.305,-0.03,-0.18,0.041,0.24,-0.313,0.016,0.311,-0.112,0.023],[0.223,0.289,-0.001,-0.471,-0.019,-0.001,0.103,0.198,0.023,-0.114,-0.076,0.514,0.218,-0.274,0.176,0.187,0.127,0.099,-0.073,-0.302],[0.224,0.225,0.161,0.116,-0.162,0.173,0.271,-0.073,0.263,0.104,-0.033,-0.01,-0.57,0.235,0.232,0.22,0.012,-0.283,0.142,-0.248],[0.223,0.268,-0.067,0.317,-0.104,-0.108,0.02,0.318,-0.227,0.186,0.158,0.012,-0.019,-0.399,0.321,-0.33,-0.029,-0.108,0.299,0.254],[0.225,-0.023,0.111,0.035,0.195,-0.051,0.194,0.4,-0.099,0.166,-0.027,-0.048,-0.218,0.039,-0.044,0.21,-0.037,0.114,-0.652,0.35],[0.224,-0.161,0.122,-0.031,0.009,-0.373,0.434,-0.108,0.221,0.219,-0.187,-0.052,0.16,0.08,0.023,0.003,-0.258,0.482,0.314,0.062],[0.223,-0.269,0.245,-0.141,-0.198,0.141,0.19,0.016,-0.38,0.281,-0.367,-0.1,0.159,-0.088,-0.3,-0.158,0.099,-0.385,0.017,-0.166],[0.223,0.253,0.211,-0.411,0.118,-0.115,-0.402,-0.327,-0.113,0.092,-0.122,-0.311,0.029,0.108,0.365,-0.094,-0.228,-0.081,-0.116,0.131],[0.224,0.151,0.312,0.157,-0.068,0.266,-0.157,-0.183,0.373,-0.019,-0.094,-0.027,0.229,-0.2,-0.187,0.204,0.396,0.048,0.086,0.433],[0.224,0.16,0.129,0.359,-0.138,-0.317,-0.31,-0.198,-0.05,-0.01,-0.004,0.043,-0.168,-0.295,-0.361,0.036,-0.183,0.177,-0.215,-0.402],[0.224,-0.159,0.325,0.041,0.312,-0.085,-0.394,0.488,0.068,-0.119,0.041,0.158,0.03,0.34,-0.135,0.02,-0.094,-0.106,0.334,-0.086],[0.223,-0.259,0.382,0.036,0.093,0.028,0.222,-0.304,-0.18,-0.198,0.625,0.126,0.056,0.036,0.153,-0.184,0.16,0.038,-0.122,-0.06]],""selectVec"":[[0.224],[0.224],[0.223],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.223],[0.224],[0.223],[0.225],[0.224],[0.223],[0.223],[0.224],[0.224],[0.224],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7811,""AfterCleanSamNum"":5217,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":462,""version"":""v-2025-12-09 10:16:01"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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