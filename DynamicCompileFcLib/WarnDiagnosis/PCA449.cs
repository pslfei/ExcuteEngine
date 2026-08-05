using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA449")]
    [FCDisplay("PCA449")]
    public partial class PCA449 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁152号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁153号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁153号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁153号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁153号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁153号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁153号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁154号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁154号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁154号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁154号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁154号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁154号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁155号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁155号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁155号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁155号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁155号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁155号屏6号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁156号屏1号管壁温")]
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

		public PCA449()
		{
			ModelID = 490;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA449";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""490"",""name"":""PCA449"",""description"":""中温分隔屏过热器水冷壁27-21-40"",""founder"":""admin"",""creatTime"":""2025-12-10 17:22:00"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:23:27"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 13:08:30"",""et"":""2025-12-07 12:19:30"",""duration"":2329860,""number"":7767,""filter"":2609,""mode"":5158,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2519}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah27ct121k"",""Description"":""中温（分隔屏）过热器水冷壁152号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""574.37"",""TMin"":""496.28"",""TAvg"":""546.38"",""DMax"":""6.73"",""DMin"":""0.00"",""DAvg"":""1.34"",""C95"":""4.64"",""C99"":""5.69""},{""PointId"":""d1_10hah27ct122k"",""Description"":""中温（分隔屏）过热器水冷壁153号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""566.00"",""TMin"":""488.45"",""TAvg"":""536.68"",""DMax"":""4.27"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.17"",""C99"":""3.87""},{""PointId"":""d1_10hah27ct123k"",""Description"":""中温（分隔屏）过热器水冷壁153号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""566.64"",""TMin"":""488.30"",""TAvg"":""537.76"",""DMax"":""2.84"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.49"",""C99"":""3.05""},{""PointId"":""d1_10hah27ct124k"",""Description"":""中温（分隔屏）过热器水冷壁153号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""566.38"",""TMin"":""485.72"",""TAvg"":""536.63"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.02"",""C99"":""3.70""},{""PointId"":""d1_10hah27ct125k"",""Description"":""中温（分隔屏）过热器水冷壁153号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""569.52"",""TMin"":""489.36"",""TAvg"":""540.11"",""DMax"":""2.52"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.50"",""C99"":""1.84""},{""PointId"":""d1_10hah27ct126k"",""Description"":""中温（分隔屏）过热器水冷壁153号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""570.83"",""TMin"":""490.60"",""TAvg"":""541.54"",""DMax"":""3.58"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.39"",""C99"":""2.93""},{""PointId"":""d1_10hah27ct127k"",""Description"":""中温（分隔屏）过热器水冷壁153号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.18"",""TMin"":""492.26"",""TAvg"":""542.60"",""DMax"":""4.89"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.49"",""C99"":""4.28""},{""PointId"":""d1_10hah27ct128k"",""Description"":""中温（分隔屏）过热器水冷壁154号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""560.48"",""TMin"":""483.50"",""TAvg"":""532.83"",""DMax"":""4.73"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.71"",""C99"":""3.31""},{""PointId"":""d1_10hah27ct129k"",""Description"":""中温（分隔屏）过热器水冷壁154号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""563.08"",""TMin"":""483.54"",""TAvg"":""535.25"",""DMax"":""2.60"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.87"",""C99"":""2.29""},{""PointId"":""d1_10hah27ct130k"",""Description"":""中温（分隔屏）过热器水冷壁154号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""563.27"",""TMin"":""481.96"",""TAvg"":""534.50"",""DMax"":""3.50"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.59"",""C99"":""3.18""},{""PointId"":""d1_10hah27ct131k"",""Description"":""中温（分隔屏）过热器水冷壁154号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""566.96"",""TMin"":""486.56"",""TAvg"":""538.83"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.54"",""C99"":""1.89""},{""PointId"":""d1_10hah27ct132k"",""Description"":""中温（分隔屏）过热器水冷壁154号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""569.52"",""TMin"":""489.30"",""TAvg"":""541.86"",""DMax"":""4.07"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.90"",""C99"":""3.55""},{""PointId"":""d1_10hah27ct133k"",""Description"":""中温（分隔屏）过热器水冷壁154号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""569.14"",""TMin"":""490.26"",""TAvg"":""541.88"",""DMax"":""4.58"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.35"",""C99"":""4.10""},{""PointId"":""d1_10hah27ct134k"",""Description"":""中温（分隔屏）过热器水冷壁155号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""561.20"",""TMin"":""483.90"",""TAvg"":""534.11"",""DMax"":""6.34"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.14"",""C99"":""3.85""},{""PointId"":""d1_10hah27ct135k"",""Description"":""中温（分隔屏）过热器水冷壁155号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""560.92"",""TMin"":""481.68"",""TAvg"":""533.88"",""DMax"":""3.46"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.45"",""C99"":""3.00""},{""PointId"":""d1_10hah27ct136k"",""Description"":""中温（分隔屏）过热器水冷壁155号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""561.53"",""TMin"":""480.23"",""TAvg"":""533.86"",""DMax"":""4.09"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.72"",""C99"":""3.34""},{""PointId"":""d1_10hah27ct137k"",""Description"":""中温（分隔屏）过热器水冷壁155号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""567.20"",""TMin"":""486.34"",""TAvg"":""539.31"",""DMax"":""3.06"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""2.00"",""C99"":""2.45""},{""PointId"":""d1_10hah27ct138k"",""Description"":""中温（分隔屏）过热器水冷壁155号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""568.35"",""TMin"":""487.44"",""TAvg"":""540.42"",""DMax"":""2.78"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.21"",""C99"":""2.71""},{""PointId"":""d1_10hah27ct139k"",""Description"":""中温（分隔屏）过热器水冷壁155号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""568.17"",""TMin"":""488.26"",""TAvg"":""541.20"",""DMax"":""4.04"",""DMin"":""0.00"",""DAvg"":""1.03"",""C95"":""3.57"",""C99"":""4.38""},{""PointId"":""d1_10hah27ct140k"",""Description"":""中温（分隔屏）过热器水冷壁156号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""563.15"",""TMin"":""486.10"",""TAvg"":""536.36"",""DMax"":""4.72"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.20"",""C99"":""3.92""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:23:27"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[496.28,488.45,488.3,485.72,489.36,490.6,492.26,483.5,483.54,481.96,486.56,489.3,490.26,483.9,481.675,480.225,486.34,487.44,488.26,486.1],""Train_X_max"":[574.367,566.0,566.64,566.38,569.52,570.833,571.183,560.48,563.08,563.267,566.96,569.517,569.14,561.2,560.917,561.533,567.2,568.35,568.167,563.15],""Train_X_std"":[9.435,9.593,9.49,9.698,9.522,9.504,9.433,9.42,9.527,9.653,9.443,9.407,9.328,9.542,9.47,9.579,9.494,9.502,9.433,9.548],""Train_X_mean"":[546.379,536.683,537.755,536.625,540.112,541.537,542.599,532.83,535.249,534.499,538.83,541.863,541.882,534.11,533.884,533.861,539.308,540.419,541.2,536.36],""Train_X_bais_max"":[[6.728,4.269,2.835,3.363,2.524,3.577,4.887,4.731,2.598,3.497,2.0,4.071,4.579,6.339,3.459,4.094,3.064,2.781,4.043,4.717]],""Train_X_bais_min"":[[0.0,0.0,0.002,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.34,0.924,0.729,0.881,0.419,0.686,1.001,0.784,0.537,0.736,0.447,0.856,0.99,0.904,0.694,0.77,0.561,0.623,1.027,0.921]],""QCUL_95"":0.7441048,""QCUL_99"":1.30978429,""QCUL_95_line"":[4.644,3.165,2.494,3.021,1.498,2.392,3.493,2.706,1.871,2.594,1.539,2.904,3.352,3.144,2.449,2.722,1.997,2.205,3.574,3.199],""QCUL_99_line"":[5.689,3.874,3.052,3.697,1.84,2.931,4.281,3.314,2.293,3.181,1.885,3.552,4.1,3.853,3.004,3.339,2.452,2.706,4.38,3.92],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.258,0.262,0.259,0.265,0.26,0.259,0.258,0.257,0.26,0.264,0.258,0.257,0.255,0.26,0.259,0.261,0.259,0.259,0.258,0.261],""T2CUL_99_line"":[0.339,0.344,0.341,0.348,0.342,0.341,0.338,0.338,0.342,0.346,0.339,0.338,0.335,0.342,0.34,0.344,0.341,0.341,0.338,0.343],""Kesi_95"":1.555,""Kesi_99"":1.312,""Kesi_95_line"":[0.164,0.167,0.165,0.168,0.165,0.165,0.164,0.164,0.165,0.168,0.164,0.163,0.162,0.166,0.164,0.166,0.165,0.165,0.164,0.166],""Kesi_99_line"":[0.15,0.153,0.151,0.155,0.152,0.152,0.15,0.15,0.152,0.154,0.151,0.15,0.149,0.152,0.151,0.153,0.151,0.152,0.15,0.152],""COV"":[[1.0,0.964,0.973,0.964,0.987,0.994,0.998,0.964,0.971,0.964,0.988,0.995,0.997,0.958,0.965,0.964,0.98,0.987,0.992,0.96],[0.964,1.0,0.997,0.997,0.991,0.984,0.975,0.999,0.996,0.995,0.987,0.975,0.972,0.996,0.993,0.99,0.985,0.982,0.97,0.995],[0.973,0.997,1.0,0.998,0.995,0.99,0.982,0.995,0.998,0.996,0.991,0.983,0.98,0.992,0.994,0.992,0.987,0.985,0.976,0.99],[0.964,0.997,0.998,1.0,0.993,0.985,0.975,0.996,0.998,0.998,0.989,0.978,0.975,0.993,0.995,0.994,0.986,0.982,0.97,0.991],[0.987,0.991,0.995,0.993,1.0,0.998,0.994,0.991,0.995,0.992,0.999,0.994,0.993,0.987,0.99,0.989,0.994,0.994,0.988,0.987],[0.994,0.984,0.99,0.985,0.998,1.0,0.998,0.984,0.989,0.985,0.997,0.998,0.997,0.979,0.984,0.982,0.992,0.995,0.992,0.98],[0.998,0.975,0.982,0.975,0.994,0.998,1.0,0.975,0.981,0.975,0.993,0.998,0.999,0.97,0.975,0.973,0.987,0.992,0.994,0.971],[0.964,0.999,0.995,0.996,0.991,0.984,0.975,1.0,0.998,0.997,0.989,0.978,0.975,0.999,0.997,0.995,0.989,0.985,0.974,0.997],[0.971,0.996,0.998,0.998,0.995,0.989,0.981,0.998,1.0,0.999,0.994,0.985,0.982,0.996,0.999,0.997,0.993,0.989,0.98,0.994],[0.964,0.995,0.996,0.998,0.992,0.985,0.975,0.997,0.999,1.0,0.992,0.981,0.977,0.996,0.998,0.998,0.991,0.986,0.975,0.993],[0.988,0.987,0.991,0.989,0.999,0.997,0.993,0.989,0.994,0.992,1.0,0.997,0.995,0.986,0.991,0.991,0.997,0.997,0.992,0.986],[0.995,0.975,0.983,0.978,0.994,0.998,0.998,0.978,0.985,0.981,0.997,1.0,0.999,0.975,0.982,0.982,0.993,0.996,0.997,0.976],[0.997,0.972,0.98,0.975,0.993,0.997,0.999,0.975,0.982,0.977,0.995,0.999,1.0,0.971,0.978,0.977,0.99,0.994,0.996,0.972],[0.958,0.996,0.992,0.993,0.987,0.979,0.97,0.999,0.996,0.996,0.986,0.975,0.971,1.0,0.998,0.996,0.99,0.985,0.974,0.999],[0.965,0.993,0.994,0.995,0.99,0.984,0.975,0.997,0.999,0.998,0.991,0.982,0.978,0.998,1.0,0.999,0.994,0.989,0.979,0.997],[0.964,0.99,0.992,0.994,0.989,0.982,0.973,0.995,0.997,0.998,0.991,0.982,0.977,0.996,0.999,1.0,0.994,0.989,0.979,0.994],[0.98,0.985,0.987,0.986,0.994,0.992,0.987,0.989,0.993,0.991,0.997,0.993,0.99,0.99,0.994,0.994,1.0,0.998,0.993,0.991],[0.987,0.982,0.985,0.982,0.994,0.995,0.992,0.985,0.989,0.986,0.997,0.996,0.994,0.985,0.989,0.989,0.998,1.0,0.998,0.987],[0.992,0.97,0.976,0.97,0.988,0.992,0.994,0.974,0.98,0.975,0.992,0.997,0.996,0.974,0.979,0.979,0.993,0.998,1.0,0.977],[0.96,0.995,0.99,0.991,0.987,0.98,0.971,0.997,0.994,0.993,0.986,0.976,0.972,0.999,0.997,0.994,0.991,0.987,0.977,1.0]],""K"":1,""R"":0.988,""featValue"":[19.767,0.169,0.037,0.016,0.006,0.003,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.221,0.412,-0.195,0.157,-0.343,-0.208,0.574,0.188,0.122,-0.178,0.035,-0.09,0.18,0.133,-0.004,0.136,-0.091,0.213,-0.053,0.109],[0.223,-0.23,-0.272,0.364,0.192,0.0,-0.139,0.199,0.128,-0.003,0.009,-0.441,-0.064,0.027,-0.342,0.395,0.141,-0.211,-0.175,-0.105],[0.224,-0.133,-0.356,-0.01,-0.394,0.295,0.005,-0.066,-0.164,0.26,0.304,0.208,0.341,-0.056,-0.127,-0.08,-0.02,-0.329,0.248,-0.13],[0.224,-0.217,-0.302,-0.23,-0.018,0.277,-0.156,0.281,0.203,-0.135,0.292,-0.09,-0.102,-0.049,0.346,-0.229,0.158,0.376,-0.213,0.17],[0.225,0.054,-0.211,-0.065,0.375,0.161,0.275,0.052,-0.216,0.1,-0.059,-0.129,-0.397,0.313,0.139,-0.178,-0.372,-0.058,0.26,-0.247],[0.224,0.19,-0.206,0.048,0.168,0.267,0.017,-0.431,0.186,-0.111,-0.233,0.102,-0.147,-0.134,-0.062,0.081,0.148,-0.098,0.232,0.58],[0.223,0.308,-0.201,0.154,0.007,-0.009,-0.198,0.065,-0.174,-0.323,-0.296,0.395,-0.101,-0.12,-0.022,-0.195,0.267,-0.046,-0.239,-0.418],[0.224,-0.228,-0.051,0.237,0.12,-0.479,0.087,0.018,0.205,0.387,0.097,0.332,-0.202,-0.23,-0.171,-0.19,0.046,0.289,0.176,0.007],[0.224,-0.155,-0.08,-0.16,-0.19,-0.046,-0.032,-0.025,-0.15,0.319,-0.375,0.149,-0.091,-0.181,0.287,0.411,-0.342,-0.01,-0.387,0.088],[0.224,-0.208,-0.034,-0.341,0.101,-0.151,-0.132,0.081,0.308,-0.213,-0.418,-0.025,0.446,0.067,0.002,0.06,-0.085,0.1,0.392,-0.199],[0.225,0.091,0.008,-0.262,0.334,-0.203,0.131,-0.002,-0.264,0.207,-0.055,-0.215,0.377,-0.059,-0.15,-0.387,0.132,-0.167,-0.348,0.236],[0.224,0.259,0.048,-0.159,0.046,-0.186,-0.048,-0.468,0.052,0.032,0.331,-0.318,-0.024,-0.327,0.288,0.195,0.123,0.033,0.065,-0.366],[0.223,0.305,-0.001,-0.082,-0.052,-0.27,-0.607,0.072,-0.196,-0.061,0.26,0.046,-0.055,0.279,-0.181,0.087,-0.3,0.084,0.097,0.25],[0.223,-0.264,0.153,0.284,0.077,-0.223,0.032,-0.185,0.076,-0.169,0.149,0.207,0.121,0.456,0.473,-0.008,0.104,-0.331,-0.11,0.09],[0.224,-0.196,0.177,-0.129,-0.374,0.019,0.037,-0.225,-0.282,0.099,-0.207,-0.187,-0.212,0.378,-0.178,-0.007,0.446,0.284,0.062,-0.033],[0.224,-0.188,0.252,-0.352,-0.21,-0.111,0.186,0.078,0.141,-0.382,0.134,0.033,-0.371,-0.206,-0.272,-0.092,-0.14,-0.397,-0.068,0.026],[0.224,0.03,0.35,-0.104,0.332,0.229,0.183,0.311,-0.266,-0.025,0.214,0.316,0.103,-0.08,-0.03,0.451,0.229,0.122,0.129,0.023],[0.224,0.131,0.306,0.041,0.062,0.381,-0.023,-0.229,0.442,0.177,0.058,0.122,0.11,0.222,-0.274,-0.079,-0.239,0.163,-0.351,-0.203],[0.223,0.275,0.37,0.173,-0.195,0.108,-0.162,0.405,0.19,0.318,-0.192,-0.21,-0.077,-0.106,0.26,-0.177,0.127,-0.258,0.216,0.059],[0.223,-0.232,0.244,0.445,-0.046,0.144,-0.028,-0.115,-0.335,-0.306,-0.045,-0.206,0.167,-0.328,0.018,-0.194,-0.332,0.244,0.068,0.063]],""selectVec"":[[0.221],[0.223],[0.224],[0.224],[0.225],[0.224],[0.223],[0.224],[0.224],[0.224],[0.225],[0.224],[0.223],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7767,""AfterCleanSamNum"":5158,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":490,""version"":""v-2025-12-10 17:23:27"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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