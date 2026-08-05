using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA436")]
    [FCDisplay("PCA436")]
    public partial class PCA436 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁110号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁110号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁110号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁110号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁110号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁110号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁111号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁111号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁111号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁111号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁111号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁111号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁112号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁112号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁112号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁112号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁112号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁112号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁113号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁113号屏2号管壁温")]
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

		public PCA436()
		{
			ModelID = 477;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA436";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""477"",""name"":""PCA436"",""description"":""中温分隔屏过热器水冷壁24-61-80"",""founder"":""admin"",""creatTime"":""2025-12-09 10:55:11"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:56:56"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 16:18:46"",""et"":""2025-12-07 10:50:14"",""duration"":2399488,""number"":7999,""filter"":2599,""mode"":5400,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2509}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah24ct161k"",""Description"":""中温（分隔屏）过热器水冷壁110号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""573.39"",""TMin"":""482.77"",""TAvg"":""528.94"",""DMax"":""6.74"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""3.06"",""C99"":""3.75""},{""PointId"":""d1_10hah24ct162k"",""Description"":""中温（分隔屏）过热器水冷壁110号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""578.05"",""TMin"":""485.07"",""TAvg"":""532.00"",""DMax"":""3.70"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.13"",""C99"":""2.61""},{""PointId"":""d1_10hah24ct163k"",""Description"":""中温（分隔屏）过热器水冷壁110号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""577.26"",""TMin"":""483.26"",""TAvg"":""530.32"",""DMax"":""4.10"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""2.98"",""C99"":""3.65""},{""PointId"":""d1_10hah24ct164k"",""Description"":""中温（分隔屏）过热器水冷壁110号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""579.95"",""TMin"":""484.74"",""TAvg"":""533.18"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.32"",""C99"":""1.62""},{""PointId"":""d1_10hah24ct165k"",""Description"":""中温（分隔屏）过热器水冷壁110号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""581.44"",""TMin"":""485.72"",""TAvg"":""534.48"",""DMax"":""2.79"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.60"",""C99"":""1.96""},{""PointId"":""d1_10hah24ct166k"",""Description"":""中温（分隔屏）过热器水冷壁110号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""582.33"",""TMin"":""486.98"",""TAvg"":""535.88"",""DMax"":""3.92"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.27"",""C99"":""2.79""},{""PointId"":""d1_10hah24ct167k"",""Description"":""中温（分隔屏）过热器水冷壁111号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""575.60"",""TMin"":""485.01"",""TAvg"":""530.95"",""DMax"":""4.55"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.15"",""C99"":""2.63""},{""PointId"":""d1_10hah24ct168k"",""Description"":""中温（分隔屏）过热器水冷壁111号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""579.01"",""TMin"":""486.11"",""TAvg"":""533.16"",""DMax"":""2.48"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.71"",""C99"":""2.10""},{""PointId"":""d1_10hah24ct169k"",""Description"":""中温（分隔屏）过热器水冷壁111号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""577.75"",""TMin"":""483.44"",""TAvg"":""530.92"",""DMax"":""3.39"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.45"",""C99"":""3.00""},{""PointId"":""d1_10hah24ct170k"",""Description"":""中温（分隔屏）过热器水冷壁111号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""582.28"",""TMin"":""486.55"",""TAvg"":""535.46"",""DMax"":""2.55"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.38"",""C99"":""1.69""},{""PointId"":""d1_10hah24ct171k"",""Description"":""中温（分隔屏）过热器水冷壁111号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""584.21"",""TMin"":""488.22"",""TAvg"":""537.20"",""DMax"":""4.01"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.31"",""C99"":""2.83""},{""PointId"":""d1_10hah24ct172k"",""Description"":""中温（分隔屏）过热器水冷壁111号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""581.92"",""TMin"":""486.61"",""TAvg"":""535.70"",""DMax"":""4.98"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.03"",""C99"":""3.72""},{""PointId"":""d1_10hah24ct173k"",""Description"":""中温（分隔屏）过热器水冷壁112号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""576.87"",""TMin"":""486.75"",""TAvg"":""532.65"",""DMax"":""3.16"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.75"",""C99"":""2.14""},{""PointId"":""d1_10hah24ct174k"",""Description"":""中温（分隔屏）过热器水冷壁112号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""577.43"",""TMin"":""484.74"",""TAvg"":""531.87"",""DMax"":""1.54"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""1.24"",""C99"":""1.51""},{""PointId"":""d1_10hah24ct175k"",""Description"":""中温（分隔屏）过热器水冷壁112号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""578.65"",""TMin"":""484.21"",""TAvg"":""531.42"",""DMax"":""2.47"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.95"",""C99"":""2.39""},{""PointId"":""d1_10hah24ct176k"",""Description"":""中温（分隔屏）过热器水冷壁112号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""584.03"",""TMin"":""488.39"",""TAvg"":""537.85"",""DMax"":""4.01"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.26"",""C99"":""2.76""},{""PointId"":""d1_10hah24ct177k"",""Description"":""中温（分隔屏）过热器水冷壁112号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""585.02"",""TMin"":""489.31"",""TAvg"":""538.72"",""DMax"":""5.65"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.23"",""C99"":""3.96""},{""PointId"":""d1_10hah24ct178k"",""Description"":""中温（分隔屏）过热器水冷壁112号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""583.98"",""TMin"":""488.94"",""TAvg"":""538.14"",""DMax"":""7.41"",""DMin"":""0.00"",""DAvg"":""1.21"",""C95"":""4.17"",""C99"":""5.11""},{""PointId"":""d1_10hah24ct179k"",""Description"":""中温（分隔屏）过热器水冷壁113号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""574.51"",""TMin"":""484.96"",""TAvg"":""530.92"",""DMax"":""5.07"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.12"",""C99"":""2.60""},{""PointId"":""d1_10hah24ct180k"",""Description"":""中温（分隔屏）过热器水冷壁113号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""575.51"",""TMin"":""484.86"",""TAvg"":""530.89"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.94"",""C99"":""2.38""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:56:56"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[482.773,485.069,483.261,484.736,485.721,486.982,485.006,486.112,483.44,486.55,488.224,486.61,486.745,484.744,484.207,488.39,489.31,488.939,484.959,484.863],""Train_X_max"":[573.39,578.053,577.261,579.951,581.439,582.329,575.6,579.011,577.749,582.279,584.208,581.924,576.867,577.432,578.649,584.03,585.022,583.981,574.513,575.505],""Train_X_std"":[11.337,11.425,11.553,11.464,11.511,11.508,11.363,11.5,11.632,11.592,11.648,11.595,11.302,11.442,11.592,11.675,11.632,11.583,11.248,11.366],""Train_X_mean"":[528.936,532.0,530.32,533.182,534.48,535.881,530.952,533.161,530.923,535.459,537.196,535.704,532.651,531.87,531.424,537.849,538.719,538.139,530.918,530.888],""Train_X_bais_max"":[[6.735,3.696,4.1,2.0,2.791,3.922,4.554,2.479,3.393,2.55,4.012,4.975,3.16,1.535,2.474,4.005,5.647,7.409,5.072,3.069]],""Train_X_bais_min"":[[0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.002,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.87,0.614,0.87,0.38,0.459,0.646,0.61,0.495,0.716,0.399,0.667,0.876,0.501,0.359,0.57,0.651,0.931,1.205,0.588,0.555]],""QCUL_95"":0.36362204,""QCUL_99"":0.6506653,""QCUL_95_line"":[3.059,2.134,2.984,1.32,1.596,2.272,2.147,1.713,2.453,1.38,2.306,3.033,1.745,1.235,1.951,2.256,3.229,4.174,2.115,1.942],""QCUL_99_line"":[3.751,2.614,3.653,1.617,1.956,2.786,2.633,2.099,3.003,1.69,2.825,3.716,2.138,1.512,2.388,2.764,3.956,5.113,2.598,2.381],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.302,0.305,0.308,0.306,0.307,0.307,0.303,0.307,0.31,0.309,0.311,0.309,0.302,0.305,0.309,0.312,0.31,0.309,0.3,0.303],""T2CUL_99_line"":[0.398,0.401,0.405,0.402,0.404,0.404,0.398,0.403,0.408,0.407,0.408,0.407,0.396,0.401,0.407,0.409,0.408,0.406,0.394,0.399],""Kesi_95"":1.556,""Kesi_99"":1.315,""Kesi_95_line"":[0.192,0.194,0.196,0.195,0.195,0.195,0.193,0.195,0.197,0.197,0.198,0.197,0.192,0.194,0.197,0.198,0.197,0.197,0.191,0.193],""Kesi_99_line"":[0.177,0.178,0.18,0.179,0.18,0.18,0.177,0.179,0.182,0.181,0.182,0.181,0.176,0.179,0.181,0.182,0.182,0.181,0.176,0.177],""COV"":[[1.0,0.999,0.998,0.994,0.991,0.988,0.999,0.998,0.997,0.991,0.987,0.983,0.998,0.996,0.994,0.987,0.981,0.975,0.998,0.997],[0.999,1.0,0.999,0.997,0.995,0.992,0.999,1.0,0.999,0.995,0.991,0.988,0.998,0.998,0.998,0.991,0.986,0.981,0.998,0.998],[0.998,0.999,1.0,0.995,0.992,0.988,0.997,0.998,1.0,0.993,0.988,0.983,0.995,0.997,0.998,0.988,0.982,0.976,0.996,0.997],[0.994,0.997,0.995,1.0,0.999,0.997,0.996,0.997,0.996,1.0,0.998,0.996,0.997,0.997,0.997,0.997,0.995,0.991,0.995,0.996],[0.991,0.995,0.992,0.999,1.0,0.999,0.994,0.996,0.994,0.999,0.999,0.998,0.995,0.997,0.996,0.998,0.997,0.995,0.994,0.994],[0.988,0.992,0.988,0.997,0.999,1.0,0.992,0.993,0.99,0.999,1.0,0.999,0.994,0.995,0.993,0.999,0.998,0.997,0.991,0.992],[0.999,0.999,0.997,0.996,0.994,0.992,1.0,0.999,0.998,0.995,0.991,0.988,0.999,0.998,0.996,0.991,0.987,0.982,0.999,0.998],[0.998,1.0,0.998,0.997,0.996,0.993,0.999,1.0,0.999,0.996,0.993,0.99,0.999,0.999,0.998,0.993,0.989,0.984,0.999,0.999],[0.997,0.999,1.0,0.996,0.994,0.99,0.998,0.999,1.0,0.995,0.99,0.986,0.996,0.998,0.999,0.991,0.986,0.98,0.997,0.998],[0.991,0.995,0.993,1.0,0.999,0.999,0.995,0.996,0.995,1.0,0.999,0.998,0.996,0.997,0.997,0.999,0.997,0.994,0.994,0.995],[0.987,0.991,0.988,0.998,0.999,1.0,0.991,0.993,0.99,0.999,1.0,1.0,0.993,0.995,0.994,0.999,0.999,0.997,0.991,0.992],[0.983,0.988,0.983,0.996,0.998,0.999,0.988,0.99,0.986,0.998,1.0,1.0,0.992,0.993,0.99,0.999,1.0,0.999,0.989,0.989],[0.998,0.998,0.995,0.997,0.995,0.994,0.999,0.999,0.996,0.996,0.993,0.992,1.0,0.999,0.996,0.994,0.991,0.987,0.999,0.998],[0.996,0.998,0.997,0.997,0.997,0.995,0.998,0.999,0.998,0.997,0.995,0.993,0.999,1.0,0.999,0.996,0.992,0.989,0.998,0.999],[0.994,0.998,0.998,0.997,0.996,0.993,0.996,0.998,0.999,0.997,0.994,0.99,0.996,0.999,1.0,0.994,0.99,0.986,0.997,0.999],[0.987,0.991,0.988,0.997,0.998,0.999,0.991,0.993,0.991,0.999,0.999,0.999,0.994,0.996,0.994,1.0,0.999,0.997,0.992,0.993],[0.981,0.986,0.982,0.995,0.997,0.998,0.987,0.989,0.986,0.997,0.999,1.0,0.991,0.992,0.99,0.999,1.0,0.999,0.988,0.989],[0.975,0.981,0.976,0.991,0.995,0.997,0.982,0.984,0.98,0.994,0.997,0.999,0.987,0.989,0.986,0.997,0.999,1.0,0.983,0.984],[0.998,0.998,0.996,0.995,0.994,0.991,0.999,0.999,0.997,0.994,0.991,0.989,0.999,0.998,0.997,0.992,0.988,0.983,1.0,0.999],[0.997,0.998,0.997,0.996,0.994,0.992,0.998,0.999,0.998,0.995,0.992,0.989,0.998,0.999,0.999,0.993,0.989,0.984,0.999,1.0]],""K"":1,""R"":0.994,""featValue"":[19.892,0.086,0.011,0.007,0.003,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.223,-0.302,-0.279,-0.334,-0.15,-0.092,0.176,0.244,-0.086,0.185,0.087,0.279,0.05,0.115,0.299,0.15,0.488,0.232,-0.019,-0.03],[-0.224,-0.211,0.081,-0.173,0.326,0.111,-0.267,-0.136,-0.145,0.347,-0.014,0.073,-0.069,0.487,-0.101,-0.24,-0.29,0.214,-0.223,0.152],[-0.223,-0.287,0.363,-0.067,-0.01,-0.189,0.253,-0.107,-0.19,0.268,0.244,0.143,0.124,-0.07,-0.175,0.101,-0.14,-0.498,0.257,-0.196],[-0.224,0.028,0.214,-0.314,-0.308,-0.046,-0.267,-0.26,-0.325,-0.107,-0.355,-0.298,0.304,-0.148,-0.034,-0.122,0.253,-0.034,-0.003,0.203],[-0.224,0.128,0.154,-0.264,0.19,-0.291,-0.178,-0.274,0.147,-0.337,0.131,0.382,-0.112,-0.278,0.148,0.315,-0.168,0.109,-0.244,0.054],[-0.224,0.22,-0.007,-0.266,0.354,-0.206,0.208,0.286,-0.078,0.086,-0.177,-0.167,-0.361,-0.342,0.001,-0.421,-0.002,0.059,0.141,-0.131],[-0.224,-0.197,-0.305,-0.174,-0.029,0.271,0.138,0.014,0.137,-0.258,-0.311,0.04,0.175,0.023,0.287,0.003,-0.505,-0.116,0.352,0.069],[-0.224,-0.164,-0.002,0.046,0.315,0.344,-0.241,0.341,0.062,-0.278,-0.131,0.148,0.211,-0.095,-0.356,0.03,0.238,-0.202,-0.208,-0.296],[-0.224,-0.228,0.313,0.079,-0.066,0.134,0.163,0.209,0.153,-0.266,0.526,-0.299,0.144,-0.103,0.137,-0.264,-0.048,0.212,-0.119,0.244],[-0.224,0.111,0.166,-0.106,-0.293,0.298,-0.099,-0.049,-0.084,-0.147,0.092,-0.23,-0.501,0.266,0.178,0.16,-0.006,-0.048,-0.014,-0.49],[-0.224,0.235,0.092,-0.125,-0.046,-0.039,-0.06,0.001,0.501,-0.065,0.054,0.093,-0.115,0.333,-0.328,-0.017,0.261,-0.057,0.454,0.295],[-0.223,0.316,-0.092,-0.129,0.036,-0.115,0.195,0.246,0.108,0.222,-0.027,-0.423,0.271,0.115,-0.147,0.497,-0.2,0.008,-0.274,0.027],[-0.224,-0.106,-0.419,0.028,-0.064,0.205,0.137,-0.499,0.069,0.109,0.188,-0.117,-0.051,-0.316,-0.419,-0.001,0.028,0.287,0.035,-0.14],[-0.224,-0.075,-0.038,0.289,0.284,0.158,-0.288,-0.115,0.166,0.354,0.004,-0.223,-0.13,-0.235,0.422,0.194,0.216,-0.256,0.085,0.219],[-0.224,-0.111,0.354,0.379,-0.04,0.002,0.458,-0.156,0.182,0.022,-0.531,0.128,-0.082,0.06,0.023,0.034,0.101,0.203,-0.194,-0.014],[-0.224,0.216,0.016,0.171,-0.405,0.254,-0.108,0.334,-0.243,0.206,0.006,0.366,-0.192,-0.27,-0.152,0.047,-0.211,0.028,-0.035,0.325],[-0.223,0.336,-0.013,0.166,-0.184,-0.113,-0.209,-0.039,0.261,0.237,0.071,0.179,0.422,0.003,0.234,-0.358,-0.07,0.077,0.0,-0.43],[-0.222,0.431,-0.163,0.206,0.272,0.134,0.3,-0.197,-0.457,-0.238,0.181,0.122,0.134,0.24,0.126,-0.066,0.169,-0.142,0.006,0.133],[-0.224,-0.174,-0.383,0.169,-0.243,-0.412,-0.035,-0.001,0.094,-0.153,-0.013,-0.072,-0.222,0.13,-0.063,-0.244,-0.031,-0.434,-0.382,0.107],[-0.224,-0.161,-0.053,0.421,0.063,-0.409,-0.272,0.158,-0.276,-0.188,-0.025,-0.121,0.006,0.088,-0.079,0.202,-0.082,0.356,0.385,-0.101]],""selectVec"":[[-0.223],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.222],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7999,""AfterCleanSamNum"":5400,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":477,""version"":""v-2025-12-09 10:56:56"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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