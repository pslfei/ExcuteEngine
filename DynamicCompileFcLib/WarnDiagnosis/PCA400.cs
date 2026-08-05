using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA400")]
    [FCDisplay("PCA400")]
    public partial class PCA400 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁24号屏2号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁24号屏3号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁24号屏4号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁24号屏5号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁24号屏6号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁25号屏1号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁25号屏2号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁25号屏3号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁25号屏4号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁25号屏5号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁25号屏6号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁26号屏1号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁26号屏2号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁26号屏3号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁26号屏4号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁26号屏5号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁26号屏6号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁27号屏1号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁27号屏2号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁27号屏3号管壁温")]
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

		public PCA400()
		{
			ModelID = 441;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA400";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""441"",""name"":""PCA400"",""description"":""中温分隔屏过热器水冷壁18-41-60"",""founder"":""admin"",""creatTime"":""2025-12-04 09:10:01"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 09:11:43"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 15:03:32"",""et"":""2025-12-04 01:45:12"",""duration"":2544100,""number"":8481,""filter"":2648,""mode"":5833,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2558}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah18ct141k"",""Description"":""中温（分隔屏）过热器水冷壁24号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""584.50"",""TMin"":""492.24"",""TAvg"":""541.14"",""DMax"":""2.71"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.08"",""C99"":""2.55""},{""PointId"":""d1_10hah18ct142k"",""Description"":""中温（分隔屏）过热器水冷壁24号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""581.80"",""TMin"":""487.90"",""TAvg"":""538.32"",""DMax"":""3.00"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.14"",""C99"":""2.63""},{""PointId"":""d1_10hah18ct143k"",""Description"":""中温（分隔屏）过热器水冷壁24号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""590.58"",""TMin"":""494.87"",""TAvg"":""546.45"",""DMax"":""4.08"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.09"",""C99"":""2.57""},{""PointId"":""d1_10hah18ct144k"",""Description"":""中温（分隔屏）过热器水冷壁24号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""592.87"",""TMin"":""496.84"",""TAvg"":""548.83"",""DMax"":""5.08"",""DMin"":""0.00"",""DAvg"":""1.15"",""C95"":""3.97"",""C99"":""4.86""},{""PointId"":""d1_10hah18ct145k"",""Description"":""中温（分隔屏）过热器水冷壁24号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""593.73"",""TMin"":""498.08"",""TAvg"":""550.27"",""DMax"":""5.53"",""DMin"":""0.00"",""DAvg"":""1.34"",""C95"":""4.58"",""C99"":""5.60""},{""PointId"":""d1_10hah18ct146k"",""Description"":""中温（分隔屏）过热器水冷壁25号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""579.44"",""TMin"":""489.82"",""TAvg"":""537.36"",""DMax"":""4.89"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.83"",""C99"":""3.46""},{""PointId"":""d1_10hah18ct147k"",""Description"":""中温（分隔屏）过热器水冷壁25号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""580.82"",""TMin"":""489.05"",""TAvg"":""537.93"",""DMax"":""3.82"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.09"",""C99"":""3.78""},{""PointId"":""d1_10hah18ct148k"",""Description"":""中温（分隔屏）过热器水冷壁25号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""580.72"",""TMin"":""487.15"",""TAvg"":""537.47"",""DMax"":""3.39"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.47"",""C99"":""3.02""},{""PointId"":""d1_10hah18ct149k"",""Description"":""中温（分隔屏）过热器水冷壁25号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""589.00"",""TMin"":""494.45"",""TAvg"":""545.34"",""DMax"":""4.13"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.43"",""C99"":""2.98""},{""PointId"":""d1_10hah18ct150k"",""Description"":""中温（分隔屏）过热器水冷壁25号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""591.33"",""TMin"":""496.58"",""TAvg"":""548.07"",""DMax"":""5.02"",""DMin"":""0.00"",""DAvg"":""1.10"",""C95"":""3.75"",""C99"":""4.59""},{""PointId"":""d1_10hah18ct151k"",""Description"":""中温（分隔屏）过热器水冷壁25号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""592.05"",""TMin"":""498.23"",""TAvg"":""549.37"",""DMax"":""7.37"",""DMin"":""0.00"",""DAvg"":""1.62"",""C95"":""5.48"",""C99"":""6.71""},{""PointId"":""d1_10hah18ct152k"",""Description"":""中温（分隔屏）过热器水冷壁26号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""577.98"",""TMin"":""489.93"",""TAvg"":""536.94"",""DMax"":""6.54"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.34"",""C99"":""4.09""},{""PointId"":""d1_10hah18ct153k"",""Description"":""中温（分隔屏）过热器水冷壁26号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""578.87"",""TMin"":""489.17"",""TAvg"":""536.97"",""DMax"":""3.57"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.09"",""C99"":""3.78""},{""PointId"":""d1_10hah18ct154k"",""Description"":""中温（分隔屏）过热器水冷壁26号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""580.26"",""TMin"":""488.57"",""TAvg"":""538.32"",""DMax"":""3.79"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.11"",""C99"":""3.81""},{""PointId"":""d1_10hah18ct155k"",""Description"":""中温（分隔屏）过热器水冷壁26号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""589.38"",""TMin"":""496.00"",""TAvg"":""545.99"",""DMax"":""2.87"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.63"",""C99"":""2.00""},{""PointId"":""d1_10hah18ct156k"",""Description"":""中温（分隔屏）过热器水冷壁26号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""589.52"",""TMin"":""495.70"",""TAvg"":""546.98"",""DMax"":""4.01"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.79"",""C99"":""3.42""},{""PointId"":""d1_10hah18ct157k"",""Description"":""中温（分隔屏）过热器水冷壁26号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""592.13"",""TMin"":""499.17"",""TAvg"":""549.85"",""DMax"":""5.61"",""DMin"":""0.00"",""DAvg"":""1.05"",""C95"":""3.63"",""C99"":""4.45""},{""PointId"":""d1_10hah18ct158k"",""Description"":""中温（分隔屏）过热器水冷壁27号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""579.10"",""TMin"":""491.90"",""TAvg"":""538.04"",""DMax"":""3.94"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.81"",""C99"":""3.45""},{""PointId"":""d1_10hah18ct159k"",""Description"":""中温（分隔屏）过热器水冷壁27号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""580.04"",""TMin"":""491.22"",""TAvg"":""538.80"",""DMax"":""4.41"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""3.02"",""C99"":""3.71""},{""PointId"":""d1_10hah18ct160k"",""Description"":""中温（分隔屏）过热器水冷壁27号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""581.00"",""TMin"":""490.08"",""TAvg"":""539.28"",""DMax"":""5.51"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""3.05"",""C99"":""3.73""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 09:11:43"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[492.24,487.9,494.867,496.84,498.08,489.817,489.05,487.15,494.45,496.58,498.233,489.933,489.167,488.567,496.0,495.7,499.167,491.9,491.217,490.08],""Train_X_max"":[584.5,581.8,590.58,592.867,593.733,579.44,580.817,580.717,589.0,591.333,592.05,577.975,578.867,580.26,589.38,589.517,592.133,579.1,580.04,581.0],""Train_X_std"":[11.135,11.159,11.438,11.464,11.497,10.955,11.092,11.144,11.387,11.402,11.369,10.864,10.901,11.012,11.264,11.295,11.28,10.751,10.85,10.976],""Train_X_mean"":[541.137,538.316,546.45,548.833,550.269,537.36,537.932,537.47,545.341,548.07,549.365,536.943,536.974,538.32,545.988,546.977,549.848,538.037,538.802,539.281],""Train_X_bais_max"":[[2.711,3.001,4.077,5.082,5.525,4.89,3.82,3.385,4.126,5.016,7.373,6.542,3.566,3.794,2.868,4.013,5.606,3.935,4.413,5.505]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.608,0.614,0.598,1.152,1.338,0.833,0.907,0.719,0.702,1.095,1.619,0.961,0.903,0.911,0.467,0.806,1.049,0.807,0.866,0.871]],""QCUL_95"":0.722470045,""QCUL_99"":1.29544675,""QCUL_95_line"":[2.082,2.143,2.092,3.968,4.576,2.825,3.089,2.469,2.431,3.753,5.484,3.336,3.088,3.113,1.632,2.79,3.634,2.811,3.023,3.045],""QCUL_99_line"":[2.549,2.627,2.565,4.858,5.6,3.455,3.778,3.022,2.978,4.594,6.707,4.087,3.779,3.809,2.0,3.418,4.452,3.445,3.706,3.732],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.286,0.286,0.294,0.294,0.295,0.281,0.285,0.286,0.292,0.293,0.292,0.279,0.28,0.283,0.289,0.29,0.29,0.276,0.279,0.282],""T2CUL_99_line"":[0.376,0.377,0.386,0.387,0.388,0.37,0.374,0.376,0.384,0.385,0.384,0.367,0.368,0.372,0.38,0.381,0.381,0.363,0.366,0.37],""Kesi_95"":1.56,""Kesi_99"":1.329,""Kesi_95_line"":[0.182,0.183,0.187,0.187,0.188,0.179,0.181,0.182,0.186,0.186,0.186,0.178,0.178,0.18,0.184,0.185,0.184,0.176,0.177,0.18],""Kesi_99_line"":[0.168,0.168,0.173,0.173,0.174,0.165,0.167,0.168,0.172,0.172,0.172,0.164,0.165,0.166,0.17,0.171,0.17,0.162,0.164,0.166],""COV"":[[1.0,0.998,0.993,0.985,0.982,0.998,0.998,0.998,0.992,0.986,0.977,0.995,0.997,0.995,0.994,0.99,0.986,0.997,0.996,0.995],[0.998,1.0,0.993,0.983,0.979,0.997,0.999,1.0,0.991,0.984,0.972,0.996,0.998,0.998,0.994,0.989,0.984,0.996,0.997,0.998],[0.993,0.993,1.0,0.997,0.995,0.99,0.988,0.991,0.999,0.997,0.99,0.987,0.987,0.988,0.999,0.998,0.996,0.988,0.987,0.987],[0.985,0.983,0.997,1.0,0.999,0.979,0.976,0.981,0.998,1.0,0.998,0.974,0.975,0.976,0.994,0.996,0.998,0.978,0.976,0.976],[0.982,0.979,0.995,0.999,1.0,0.976,0.971,0.976,0.996,0.999,0.999,0.971,0.971,0.971,0.992,0.995,0.998,0.974,0.971,0.972],[0.998,0.997,0.99,0.979,0.976,1.0,0.998,0.997,0.989,0.98,0.969,0.998,0.997,0.995,0.991,0.987,0.981,0.998,0.996,0.994],[0.998,0.999,0.988,0.976,0.971,0.998,1.0,0.999,0.986,0.977,0.964,0.998,0.999,0.998,0.99,0.984,0.977,0.998,0.998,0.998],[0.998,1.0,0.991,0.981,0.976,0.997,0.999,1.0,0.989,0.982,0.969,0.996,0.999,0.999,0.993,0.988,0.982,0.996,0.998,0.999],[0.992,0.991,0.999,0.998,0.996,0.989,0.986,0.989,1.0,0.998,0.993,0.984,0.985,0.985,0.999,0.998,0.998,0.987,0.985,0.985],[0.986,0.984,0.997,1.0,0.999,0.98,0.977,0.982,0.998,1.0,0.998,0.975,0.976,0.977,0.995,0.998,0.999,0.979,0.977,0.978],[0.977,0.972,0.99,0.998,0.999,0.969,0.964,0.969,0.993,0.998,1.0,0.963,0.963,0.964,0.988,0.992,0.997,0.968,0.965,0.965],[0.995,0.996,0.987,0.974,0.971,0.998,0.998,0.996,0.984,0.975,0.963,1.0,0.998,0.997,0.99,0.982,0.976,0.999,0.997,0.996],[0.997,0.998,0.987,0.975,0.971,0.997,0.999,0.999,0.985,0.976,0.963,0.998,1.0,0.999,0.99,0.984,0.978,0.998,1.0,0.999],[0.995,0.998,0.988,0.976,0.971,0.995,0.998,0.999,0.985,0.977,0.964,0.997,0.999,1.0,0.992,0.984,0.978,0.997,0.999,0.999],[0.994,0.994,0.999,0.994,0.992,0.991,0.99,0.993,0.999,0.995,0.988,0.99,0.99,0.992,1.0,0.997,0.995,0.992,0.991,0.992],[0.99,0.989,0.998,0.996,0.995,0.987,0.984,0.988,0.998,0.998,0.992,0.982,0.984,0.984,0.997,1.0,0.998,0.985,0.984,0.986],[0.986,0.984,0.996,0.998,0.998,0.981,0.977,0.982,0.998,0.999,0.997,0.976,0.978,0.978,0.995,0.998,1.0,0.981,0.979,0.979],[0.997,0.996,0.988,0.978,0.974,0.998,0.998,0.996,0.987,0.979,0.968,0.999,0.998,0.997,0.992,0.985,0.981,1.0,0.998,0.997],[0.996,0.997,0.987,0.976,0.971,0.996,0.998,0.998,0.985,0.977,0.965,0.997,1.0,0.999,0.991,0.984,0.979,0.998,1.0,0.999],[0.995,0.998,0.987,0.976,0.972,0.994,0.998,0.999,0.985,0.978,0.965,0.996,0.999,0.999,0.992,0.986,0.979,0.997,0.999,1.0]],""K"":1,""R"":0.989,""featValue"":[19.79,0.177,0.012,0.008,0.006,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,-0.1,-0.28,-0.097,-0.498,-0.048,0.239,-0.211,0.01,0.092,-0.399,0.025,-0.37,0.156,0.371,-0.095,0.132,-0.032,-0.054,0.051],[-0.224,-0.136,0.117,-0.347,-0.162,0.164,-0.019,0.3,-0.245,-0.02,0.389,-0.064,-0.29,-0.01,0.073,0.445,-0.116,-0.056,-0.353,-0.094],[-0.224,0.124,-0.028,-0.376,0.263,0.087,0.047,-0.028,-0.312,-0.067,-0.207,0.122,0.059,0.313,0.02,0.237,-0.132,0.022,0.613,-0.03],[-0.223,0.291,0.004,-0.117,-0.089,0.254,0.041,0.093,-0.16,-0.475,-0.211,-0.052,0.34,-0.304,0.13,-0.2,0.195,0.102,-0.186,-0.352],[-0.222,0.335,-0.103,0.031,-0.102,0.212,-0.286,-0.078,-0.441,0.262,0.016,-0.126,-0.15,-0.083,-0.366,-0.317,-0.014,-0.06,-0.059,0.365],[-0.224,-0.166,-0.509,-0.135,0.026,-0.3,-0.014,0.313,0.076,0.046,0.05,-0.06,0.178,-0.412,0.075,-0.033,-0.269,0.303,0.112,0.239],[-0.224,-0.228,-0.1,-0.186,-0.168,-0.111,-0.17,-0.269,0.132,0.071,-0.158,-0.122,0.485,0.18,-0.315,0.099,-0.239,-0.378,-0.231,-0.137],[-0.224,-0.169,0.193,-0.253,-0.188,0.0,-0.073,0.191,0.164,0.203,0.205,0.482,0.215,0.03,-0.094,-0.195,0.524,0.002,0.14,0.111],[-0.224,0.167,-0.07,-0.197,0.185,-0.034,0.425,-0.179,0.274,0.143,0.156,-0.011,-0.247,0.039,-0.428,-0.178,-0.057,0.307,-0.099,-0.353],[-0.223,0.279,0.069,-0.002,-0.01,0.051,-0.108,-0.008,0.401,-0.437,0.098,0.066,0.009,0.4,0.073,-0.007,-0.175,0.171,-0.18,0.48],[-0.221,0.4,-0.114,0.315,-0.3,0.168,0.009,0.101,0.346,0.175,0.209,-0.166,0.049,-0.112,0.046,0.298,0.021,-0.237,0.374,-0.165],[-0.223,-0.228,-0.345,0.116,0.437,0.217,-0.393,-0.053,0.138,0.029,-0.046,-0.229,-0.12,0.142,0.068,0.133,0.458,0.104,-0.093,-0.102],[-0.224,-0.234,0.114,0.113,-0.089,-0.086,-0.048,-0.51,-0.199,-0.148,0.542,-0.174,0.086,-0.002,0.269,-0.227,-0.059,0.125,0.222,-0.077],[-0.224,-0.219,0.321,-0.016,0.112,0.284,-0.298,-0.035,0.288,0.02,-0.234,0.194,-0.297,-0.344,0.085,-0.194,-0.39,-0.105,0.122,-0.102],[-0.224,0.072,0.145,-0.039,0.426,0.089,0.452,-0.16,0.02,0.239,0.006,-0.064,0.182,-0.221,0.292,0.063,0.08,-0.323,-0.194,0.349],[-0.224,0.172,0.204,-0.062,0.118,-0.703,-0.158,0.072,0.002,-0.234,-0.065,-0.164,-0.285,-0.121,-0.068,-0.015,0.215,-0.312,0.059,-0.042],[-0.223,0.263,0.102,0.286,0.078,-0.283,-0.214,-0.035,-0.168,0.368,-0.08,0.376,0.13,0.116,0.261,0.138,-0.145,0.279,-0.268,-0.237],[-0.224,-0.187,-0.278,0.434,0.137,0.033,0.238,0.285,-0.183,-0.235,0.125,0.334,-0.071,0.202,-0.101,-0.226,-0.126,-0.375,-0.028,-0.107],[-0.224,-0.222,0.16,0.347,-0.123,0.006,0.168,-0.212,-0.111,-0.211,-0.197,0.136,-0.018,-0.253,-0.386,0.459,0.136,0.257,0.037,0.205],[-0.224,-0.208,0.397,0.194,-0.056,0.004,0.157,0.423,-0.032,0.179,-0.198,-0.506,0.118,0.283,-0.008,-0.186,-0.038,0.206,0.066,-0.002]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.223],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.221],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8481,""AfterCleanSamNum"":5833,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":441,""version"":""v-2025-12-04 09:11:43"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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