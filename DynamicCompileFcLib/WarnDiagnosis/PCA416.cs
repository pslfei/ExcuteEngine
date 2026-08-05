using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA416")]
    [FCDisplay("PCA416")]
    public partial class PCA416 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁44号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁44号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁44号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁44号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁44号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁44号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁45号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁45号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁45号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁45号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁45号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁45号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁46号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁46号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁46号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁46号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁46号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁46号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁47号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁47号屏2号管壁温")]
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

		public PCA416()
		{
			ModelID = 457;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA416";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""457"",""name"":""PCA416"",""description"":""中温分隔屏过热器水冷壁19-61-80"",""founder"":""admin"",""creatTime"":""2025-12-09 09:49:36"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 09:55:06"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 14:49:30"",""et"":""2025-12-07 19:01:12"",""duration"":2434302,""number"":8115,""filter"":2640,""mode"":5475,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2548}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah19ct161k"",""Description"":""中温（分隔屏）过热器水冷壁44号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""573.83"",""TMin"":""492.58"",""TAvg"":""536.62"",""DMax"":""4.45"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.74"",""C99"":""3.35""},{""PointId"":""d1_10hah19ct162k"",""Description"":""中温（分隔屏）过热器水冷壁44号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""574.25"",""TMin"":""490.92"",""TAvg"":""537.76"",""DMax"":""2.70"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.22"",""C99"":""2.71""},{""PointId"":""d1_10hah19ct163k"",""Description"":""中温（分隔屏）过热器水冷壁44号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""571.83"",""TMin"":""487.15"",""TAvg"":""535.28"",""DMax"":""2.64"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.29"",""C99"":""2.80""},{""PointId"":""d1_10hah19ct164k"",""Description"":""中温（分隔屏）过热器水冷壁44号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""583.12"",""TMin"":""500.92"",""TAvg"":""545.86"",""DMax"":""3.15"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.60"",""C99"":""3.19""},{""PointId"":""d1_10hah19ct165k"",""Description"":""中温（分隔屏）过热器水冷壁44号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""582.93"",""TMin"":""501.22"",""TAvg"":""545.94"",""DMax"":""4.43"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.17"",""C99"":""3.89""},{""PointId"":""d1_10hah19ct166k"",""Description"":""中温（分隔屏）过热器水冷壁44号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""584.93"",""TMin"":""502.70"",""TAvg"":""547.74"",""DMax"":""5.52"",""DMin"":""0.00"",""DAvg"":""1.11"",""C95"":""3.81"",""C99"":""4.67""},{""PointId"":""d1_10hah19ct167k"",""Description"":""中温（分隔屏）过热器水冷壁45号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""572.52"",""TMin"":""489.70"",""TAvg"":""535.36"",""DMax"":""4.15"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.62"",""C99"":""3.20""},{""PointId"":""d1_10hah19ct168k"",""Description"":""中温（分隔屏）过热器水冷壁45号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""572.90"",""TMin"":""488.28"",""TAvg"":""536.44"",""DMax"":""2.69"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.45"",""C99"":""3.00""},{""PointId"":""d1_10hah19ct169k"",""Description"":""中温（分隔屏）过热器水冷壁45号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""572.68"",""TMin"":""487.53"",""TAvg"":""536.16"",""DMax"":""2.61"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.97"",""C99"":""2.41""},{""PointId"":""d1_10hah19ct170k"",""Description"":""中温（分隔屏）过热器水冷壁45号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""580.23"",""TMin"":""496.92"",""TAvg"":""542.63"",""DMax"":""2.54"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.94"",""C99"":""2.37""},{""PointId"":""d1_10hah19ct171k"",""Description"":""中温（分隔屏）过热器水冷壁45号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""581.67"",""TMin"":""498.70"",""TAvg"":""544.23"",""DMax"":""3.70"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.73"",""C99"":""3.33""},{""PointId"":""d1_10hah19ct172k"",""Description"":""中温（分隔屏）过热器水冷壁45号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""582.88"",""TMin"":""501.22"",""TAvg"":""546.38"",""DMax"":""5.76"",""DMin"":""0.00"",""DAvg"":""1.27"",""C95"":""4.35"",""C99"":""5.32""},{""PointId"":""d1_10hah19ct173k"",""Description"":""中温（分隔屏）过热器水冷壁46号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""570.95"",""TMin"":""486.97"",""TAvg"":""534.24"",""DMax"":""6.47"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.91"",""C99"":""3.57""},{""PointId"":""d1_10hah19ct174k"",""Description"":""中温（分隔屏）过热器水冷壁46号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""569.52"",""TMin"":""483.60"",""TAvg"":""533.24"",""DMax"":""3.34"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.54"",""C99"":""3.12""},{""PointId"":""d1_10hah19ct175k"",""Description"":""中温（分隔屏）过热器水冷壁46号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""568.88"",""TMin"":""482.60"",""TAvg"":""533.09"",""DMax"":""3.64"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.52"",""C99"":""3.08""},{""PointId"":""d1_10hah19ct176k"",""Description"":""中温（分隔屏）过热器水冷壁46号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""579.00"",""TMin"":""494.32"",""TAvg"":""542.00"",""DMax"":""2.17"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.05"",""C99"":""2.50""},{""PointId"":""d1_10hah19ct177k"",""Description"":""中温（分隔屏）过热器水冷壁46号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""578.95"",""TMin"":""493.93"",""TAvg"":""542.28"",""DMax"":""3.57"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.69"",""C99"":""3.29""},{""PointId"":""d1_10hah19ct178k"",""Description"":""中温（分隔屏）过热器水冷壁46号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""579.38"",""TMin"":""495.48"",""TAvg"":""542.75"",""DMax"":""3.98"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.02"",""C99"":""3.69""},{""PointId"":""d1_10hah19ct179k"",""Description"":""中温（分隔屏）过热器水冷壁47号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""571.17"",""TMin"":""486.47"",""TAvg"":""534.29"",""DMax"":""5.29"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.14"",""C99"":""3.84""},{""PointId"":""d1_10hah19ct180k"",""Description"":""中温（分隔屏）过热器水冷壁47号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""570.93"",""TMin"":""483.62"",""TAvg"":""534.78"",""DMax"":""4.10"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.30"",""C99"":""4.04""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 09:55:06"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[492.58,490.92,487.15,500.917,501.22,502.7,489.7,488.28,487.533,496.917,498.7,501.22,486.967,483.6,482.6,494.317,493.933,495.48,486.467,483.617],""Train_X_max"":[573.833,574.25,571.833,583.117,582.933,584.933,572.517,572.9,572.683,580.233,581.667,582.883,570.95,569.517,568.883,579.0,578.95,579.383,571.167,570.933],""Train_X_std"":[9.423,9.454,9.63,9.362,9.328,9.243,9.376,9.519,9.618,9.409,9.393,9.143,9.431,9.526,9.603,9.422,9.354,9.259,9.42,9.633],""Train_X_mean"":[536.618,537.755,535.279,545.86,545.939,547.742,535.355,536.441,536.163,542.626,544.227,546.38,534.235,533.239,533.085,541.999,542.284,542.751,534.286,534.783],""Train_X_bais_max"":[[4.453,2.702,2.639,3.148,4.433,5.517,4.153,2.692,2.613,2.535,3.696,5.758,6.473,3.335,3.636,2.173,3.572,3.978,5.291,4.104]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0]],""Train_X_bais_mean"":[[0.794,0.654,0.673,0.759,0.924,1.106,0.767,0.723,0.571,0.572,0.799,1.273,0.84,0.737,0.722,0.61,0.791,0.881,0.921,0.961]],""QCUL_95"":0.7928463,""QCUL_99"":1.41929793,""QCUL_95_line"":[2.739,2.219,2.286,2.602,3.174,3.81,2.617,2.452,1.965,1.941,2.725,4.347,2.914,2.543,2.516,2.048,2.689,3.016,3.139,3.296],""QCUL_99_line"":[3.354,2.714,2.797,3.185,3.886,4.665,3.202,2.998,2.406,2.374,3.334,5.32,3.571,3.115,3.084,2.502,3.289,3.691,3.84,4.035],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.25,0.251,0.255,0.248,0.247,0.245,0.249,0.252,0.255,0.249,0.249,0.242,0.25,0.253,0.255,0.25,0.248,0.245,0.25,0.255],""T2CUL_99_line"":[0.328,0.329,0.336,0.326,0.325,0.322,0.327,0.332,0.335,0.328,0.327,0.319,0.329,0.332,0.335,0.328,0.326,0.323,0.328,0.336],""Kesi_95"":1.56,""Kesi_99"":1.329,""Kesi_95_line"":[0.159,0.16,0.163,0.158,0.158,0.156,0.158,0.161,0.162,0.159,0.159,0.154,0.159,0.161,0.162,0.159,0.158,0.156,0.159,0.163],""Kesi_99_line"":[0.147,0.147,0.15,0.146,0.145,0.144,0.146,0.148,0.15,0.147,0.146,0.142,0.147,0.148,0.15,0.147,0.146,0.144,0.147,0.15],""COV"":[[1.0,0.997,0.996,0.983,0.978,0.973,0.999,0.997,0.996,0.987,0.981,0.966,0.998,0.996,0.994,0.986,0.979,0.977,0.998,0.994],[0.997,1.0,0.999,0.986,0.982,0.977,0.998,1.0,0.999,0.989,0.984,0.971,0.995,0.998,0.996,0.988,0.984,0.981,0.995,0.996],[0.996,0.999,1.0,0.985,0.981,0.975,0.997,0.999,1.0,0.99,0.985,0.969,0.995,0.998,0.998,0.989,0.984,0.981,0.995,0.997],[0.983,0.986,0.985,1.0,0.999,0.997,0.982,0.983,0.987,0.999,0.999,0.995,0.98,0.982,0.983,0.998,0.998,0.997,0.977,0.976],[0.978,0.982,0.981,0.999,1.0,0.999,0.977,0.979,0.983,0.998,1.0,0.997,0.974,0.976,0.978,0.996,0.998,0.998,0.972,0.97],[0.973,0.977,0.975,0.997,0.999,1.0,0.972,0.974,0.977,0.995,0.998,0.999,0.969,0.971,0.972,0.993,0.997,0.997,0.966,0.964],[0.999,0.998,0.997,0.982,0.977,0.972,1.0,0.998,0.996,0.986,0.981,0.966,0.999,0.998,0.995,0.986,0.98,0.978,0.999,0.996],[0.997,1.0,0.999,0.983,0.979,0.974,0.998,1.0,0.999,0.987,0.982,0.968,0.996,0.999,0.997,0.986,0.982,0.979,0.997,0.998],[0.996,0.999,1.0,0.987,0.983,0.977,0.996,0.999,1.0,0.991,0.986,0.972,0.995,0.999,0.999,0.991,0.986,0.984,0.995,0.997],[0.987,0.989,0.99,0.999,0.998,0.995,0.986,0.987,0.991,1.0,0.999,0.992,0.985,0.986,0.988,0.999,0.998,0.997,0.983,0.982],[0.981,0.984,0.985,0.999,1.0,0.998,0.981,0.982,0.986,0.999,1.0,0.996,0.978,0.98,0.982,0.997,0.999,0.998,0.976,0.975],[0.966,0.971,0.969,0.995,0.997,0.999,0.966,0.968,0.972,0.992,0.996,1.0,0.963,0.966,0.967,0.991,0.996,0.997,0.961,0.959],[0.998,0.995,0.995,0.98,0.974,0.969,0.999,0.996,0.995,0.985,0.978,0.963,1.0,0.998,0.996,0.986,0.979,0.977,1.0,0.997],[0.996,0.998,0.998,0.982,0.976,0.971,0.998,0.999,0.999,0.986,0.98,0.966,0.998,1.0,0.999,0.987,0.982,0.979,0.998,0.999],[0.994,0.996,0.998,0.983,0.978,0.972,0.995,0.997,0.999,0.988,0.982,0.967,0.996,0.999,1.0,0.99,0.985,0.981,0.996,0.998],[0.986,0.988,0.989,0.998,0.996,0.993,0.986,0.986,0.991,0.999,0.997,0.991,0.986,0.987,0.99,1.0,0.998,0.998,0.984,0.984],[0.979,0.984,0.984,0.998,0.998,0.997,0.98,0.982,0.986,0.998,0.999,0.996,0.979,0.982,0.985,0.998,1.0,1.0,0.977,0.977],[0.977,0.981,0.981,0.997,0.998,0.997,0.978,0.979,0.984,0.997,0.998,0.997,0.977,0.979,0.981,0.998,1.0,1.0,0.975,0.974],[0.998,0.995,0.995,0.977,0.972,0.966,0.999,0.997,0.995,0.983,0.976,0.961,1.0,0.998,0.996,0.984,0.977,0.975,1.0,0.998],[0.994,0.996,0.997,0.976,0.97,0.964,0.996,0.998,0.997,0.982,0.975,0.959,0.997,0.999,0.998,0.984,0.977,0.974,0.998,1.0]],""K"":1,""R"":0.988,""featValue"":[19.769,0.194,0.015,0.012,0.007,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.19,0.485,-0.059,-0.186,0.0,0.316,0.014,-0.184,-0.192,0.142,-0.292,-0.256,0.261,0.384,0.117,0.064,0.212,-0.122,-0.072],[-0.224,0.153,0.133,0.395,0.19,0.151,-0.071,-0.208,-0.149,-0.218,0.333,0.033,-0.284,-0.056,-0.274,0.138,-0.036,-0.424,0.209,0.246],[-0.224,0.162,-0.087,0.341,-0.195,-0.329,0.273,0.133,-0.094,-0.132,-0.2,-0.362,0.252,-0.122,-0.424,-0.244,-0.014,-0.013,-0.212,-0.034],[-0.224,-0.204,0.098,0.083,-0.331,0.637,-0.109,-0.191,0.025,0.245,-0.266,-0.149,0.073,0.124,-0.037,-0.202,-0.011,-0.022,-0.152,0.298],[-0.223,-0.271,0.132,0.178,-0.065,-0.088,-0.14,-0.145,-0.478,0.325,-0.189,0.071,-0.037,-0.121,-0.033,0.197,-0.096,0.042,0.208,-0.539],[-0.222,-0.328,0.225,0.088,0.197,-0.187,0.177,-0.278,0.359,-0.169,-0.306,0.059,-0.048,-0.477,0.247,0.011,0.192,0.013,0.009,0.142],[-0.224,0.202,0.342,-0.13,0.014,-0.106,-0.182,0.012,0.111,0.404,0.38,-0.011,0.429,-0.219,-0.16,0.187,0.171,0.229,0.01,0.191],[-0.224,0.184,0.021,0.318,0.295,0.115,-0.255,0.028,0.12,-0.068,0.156,0.103,0.262,0.01,0.408,-0.384,-0.278,-0.009,-0.218,-0.296],[-0.224,0.137,-0.177,0.294,-0.112,-0.072,0.169,0.135,0.396,0.272,-0.034,0.095,-0.247,0.187,0.027,-0.046,-0.184,0.335,0.508,0.072],[-0.224,-0.148,-0.02,0.027,-0.379,0.053,-0.284,0.254,0.373,-0.261,0.133,0.068,-0.035,0.09,-0.091,0.095,0.449,-0.181,0.013,-0.379],[-0.224,-0.228,0.024,0.078,-0.154,-0.417,-0.221,0.268,-0.198,-0.045,-0.102,0.329,0.087,0.289,0.196,0.118,-0.144,-0.135,-0.146,0.457],[-0.222,-0.375,0.098,-0.098,0.447,0.287,0.331,0.545,0.024,0.008,0.049,0.014,0.038,0.062,-0.229,0.119,-0.13,0.021,-0.078,-0.058],[-0.224,0.224,0.173,-0.427,-0.064,0.024,0.244,-0.027,-0.096,-0.081,-0.167,0.306,0.254,0.071,-0.016,-0.348,0.017,-0.339,0.419,-0.064],[-0.224,0.209,-0.179,-0.006,0.139,0.106,0.087,-0.345,-0.033,-0.214,-0.168,0.456,0.071,0.254,-0.246,0.239,0.148,0.381,-0.275,-0.066],[-0.224,0.174,-0.435,-0.028,-0.12,0.063,0.368,0.022,-0.022,0.371,0.125,0.094,-0.061,-0.213,0.292,0.233,0.103,-0.369,-0.278,-0.031],[-0.224,-0.133,-0.237,-0.273,-0.328,0.104,-0.036,-0.066,-0.042,-0.38,0.252,-0.022,0.057,-0.37,0.001,0.1,-0.51,0.22,0.081,0.032],[-0.224,-0.219,-0.255,-0.119,0.118,-0.089,-0.048,-0.014,-0.314,0.058,0.305,0.02,-0.27,-0.051,-0.005,-0.543,0.398,0.252,0.005,0.109],[-0.223,-0.249,-0.193,-0.219,0.196,-0.244,-0.005,-0.42,0.207,0.071,0.14,-0.413,0.146,0.455,-0.025,0.075,-0.114,-0.19,0.044,-0.076],[-0.223,0.252,0.13,-0.361,0.086,-0.141,-0.304,0.067,0.171,0.161,-0.232,-0.028,-0.527,-0.107,-0.225,-0.095,-0.241,-0.087,-0.295,-0.063],[-0.223,0.262,-0.276,-0.085,0.258,0.136,-0.306,0.217,-0.179,-0.153,-0.355,-0.37,0.097,-0.069,0.211,0.236,0.214,0.064,0.27,0.129]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8115,""AfterCleanSamNum"":5470,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":457,""version"":""v-2025-12-09 09:55:06"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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