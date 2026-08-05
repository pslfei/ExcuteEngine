using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA433")]
    [FCDisplay("PCA433")]
    public partial class PCA433 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁100号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁100号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁100号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁100号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁100号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁100号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁101号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁101号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁101号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁101号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁101号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁101号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁102号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁102号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁102号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁102号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁102号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁102号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁103号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁103号屏2号管壁温")]
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

		public PCA433()
		{
			ModelID = 474;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA433";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""474"",""name"":""PCA433"",""description"":""中温分隔屏过热器水冷壁24-1-20"",""founder"":""admin"",""creatTime"":""2025-12-09 10:46:59"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:49:09"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 13:48:46"",""duration"":2412878,""number"":8043,""filter"":2632,""mode"":5411,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2542}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah24ct101k"",""Description"":""中温（分隔屏）过热器水冷壁100号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""574.86"",""TMin"":""486.18"",""TAvg"":""532.73"",""DMax"":""3.53"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.07"",""C99"":""2.54""},{""PointId"":""d1_10hah24ct102k"",""Description"":""中温（分隔屏）过热器水冷壁100号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""576.14"",""TMin"":""485.17"",""TAvg"":""532.80"",""DMax"":""2.48"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.36"",""C99"":""1.66""},{""PointId"":""d1_10hah24ct103k"",""Description"":""中温（分隔屏）过热器水冷壁100号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""576.94"",""TMin"":""484.46"",""TAvg"":""532.32"",""DMax"":""2.59"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.62"",""C99"":""1.99""},{""PointId"":""d1_10hah24ct104k"",""Description"":""中温（分隔屏）过热器水冷壁100号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""580.07"",""TMin"":""486.93"",""TAvg"":""536.31"",""DMax"":""2.20"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.76"",""C99"":""2.15""},{""PointId"":""d1_10hah24ct105k"",""Description"":""中温（分隔屏）过热器水冷壁100号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""581.91"",""TMin"":""488.67"",""TAvg"":""538.18"",""DMax"":""3.81"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.62"",""C99"":""3.20""},{""PointId"":""d1_10hah24ct106k"",""Description"":""中温（分隔屏）过热器水冷壁100号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""583.78"",""TMin"":""490.93"",""TAvg"":""540.09"",""DMax"":""5.34"",""DMin"":""0.00"",""DAvg"":""1.06"",""C95"":""3.60"",""C99"":""4.40""},{""PointId"":""d1_10hah24ct107k"",""Description"":""中温（分隔屏）过热器水冷壁101号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.75"",""TMin"":""483.24"",""TAvg"":""529.17"",""DMax"":""5.11"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.30"",""C99"":""2.82""},{""PointId"":""d1_10hah24ct108k"",""Description"":""中温（分隔屏）过热器水冷壁101号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""574.86"",""TMin"":""483.91"",""TAvg"":""531.28"",""DMax"":""2.72"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.72"",""C99"":""2.11""},{""PointId"":""d1_10hah24ct109k"",""Description"":""中温（分隔屏）过热器水冷壁101号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""574.53"",""TMin"":""482.17"",""TAvg"":""529.84"",""DMax"":""3.04"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.14"",""C99"":""2.62""},{""PointId"":""d1_10hah24ct110k"",""Description"":""中温（分隔屏）过热器水冷壁101号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""581.15"",""TMin"":""486.80"",""TAvg"":""536.56"",""DMax"":""1.70"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.19"",""C99"":""1.45""},{""PointId"":""d1_10hah24ct111k"",""Description"":""中温（分隔屏）过热器水冷壁101号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""580.96"",""TMin"":""487.05"",""TAvg"":""536.14"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.71"",""C99"":""2.09""},{""PointId"":""d1_10hah24ct112k"",""Description"":""中温（分隔屏）过热器水冷壁101号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""582.69"",""TMin"":""488.85"",""TAvg"":""538.33"",""DMax"":""5.13"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.88"",""C99"":""3.53""},{""PointId"":""d1_10hah24ct113k"",""Description"":""中温（分隔屏）过热器水冷壁102号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""573.68"",""TMin"":""484.15"",""TAvg"":""530.36"",""DMax"":""5.49"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.53"",""C99"":""3.10""},{""PointId"":""d1_10hah24ct114k"",""Description"":""中温（分隔屏）过热器水冷壁102号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""576.15"",""TMin"":""483.93"",""TAvg"":""531.84"",""DMax"":""2.71"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.82"",""C99"":""2.23""},{""PointId"":""d1_10hah24ct115k"",""Description"":""中温（分隔屏）过热器水冷壁102号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""576.16"",""TMin"":""482.39"",""TAvg"":""530.51"",""DMax"":""2.82"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.14"",""C99"":""2.62""},{""PointId"":""d1_10hah24ct116k"",""Description"":""中温（分隔屏）过热器水冷壁102号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""581.40"",""TMin"":""486.00"",""TAvg"":""535.77"",""DMax"":""3.44"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.55"",""C99"":""1.90""},{""PointId"":""d1_10hah24ct117k"",""Description"":""中温（分隔屏）过热器水冷壁102号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""582.49"",""TMin"":""487.34"",""TAvg"":""537.02"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.11"",""C99"":""2.58""},{""PointId"":""d1_10hah24ct118k"",""Description"":""中温（分隔屏）过热器水冷壁102号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""582.47"",""TMin"":""487.95"",""TAvg"":""537.49"",""DMax"":""3.91"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.49"",""C99"":""3.05""},{""PointId"":""d1_10hah24ct119k"",""Description"":""中温（分隔屏）过热器水冷壁103号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""573.10"",""TMin"":""483.21"",""TAvg"":""529.38"",""DMax"":""6.07"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.75"",""C99"":""3.37""},{""PointId"":""d1_10hah24ct120k"",""Description"":""中温（分隔屏）过热器水冷壁103号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""574.78"",""TMin"":""482.61"",""TAvg"":""529.56"",""DMax"":""4.15"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.65"",""C99"":""3.24""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:49:09"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[486.178,485.168,484.456,486.931,488.671,490.927,483.237,483.914,482.173,486.797,487.05,488.852,484.151,483.934,482.39,485.998,487.337,487.954,483.207,482.605],""Train_X_max"":[574.864,576.135,576.941,580.068,581.905,583.783,571.752,574.855,574.527,581.145,580.957,582.685,573.683,576.147,576.158,581.402,582.491,582.467,573.096,574.784],""Train_X_std"":[10.684,10.68,10.745,10.627,10.546,10.512,10.716,10.807,10.874,10.775,10.697,10.635,10.857,10.91,10.965,10.808,10.823,10.811,10.94,11.021],""Train_X_mean"":[532.734,532.799,532.316,536.306,538.178,540.093,529.168,531.284,529.838,536.559,536.135,538.327,530.355,531.841,530.508,535.771,537.024,537.491,529.383,529.563],""Train_X_bais_max"":[[3.533,2.484,2.59,2.201,3.809,5.344,5.105,2.717,3.04,1.695,3.308,5.132,5.485,2.713,2.822,3.444,3.309,3.905,6.07,4.146]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.601,0.388,0.459,0.513,0.768,1.056,0.659,0.502,0.62,0.342,0.492,0.841,0.723,0.534,0.627,0.444,0.613,0.726,0.779,0.774]],""QCUL_95"":0.3603109,""QCUL_99"":0.6427016,""QCUL_95_line"":[2.074,1.356,1.623,1.76,2.617,3.597,2.301,1.723,2.141,1.186,1.707,2.884,2.525,1.822,2.14,1.552,2.111,2.494,2.747,2.648],""QCUL_99_line"":[2.54,1.662,1.991,2.154,3.202,4.401,2.82,2.109,2.622,1.453,2.091,3.531,3.095,2.23,2.619,1.902,2.584,3.053,3.37,3.241],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.285,0.285,0.287,0.283,0.281,0.28,0.286,0.288,0.29,0.287,0.285,0.284,0.29,0.291,0.292,0.288,0.289,0.288,0.292,0.294],""T2CUL_99_line"":[0.375,0.374,0.377,0.373,0.37,0.369,0.376,0.379,0.381,0.378,0.375,0.373,0.381,0.382,0.384,0.379,0.379,0.379,0.384,0.386],""Kesi_95"":1.554,""Kesi_99"":1.309,""Kesi_95_line"":[0.181,0.181,0.182,0.18,0.179,0.178,0.182,0.183,0.184,0.183,0.181,0.18,0.184,0.185,0.186,0.183,0.184,0.183,0.186,0.187],""Kesi_99_line"":[0.166,0.166,0.167,0.165,0.164,0.164,0.167,0.168,0.169,0.168,0.167,0.166,0.169,0.17,0.171,0.168,0.168,0.168,0.17,0.172],""COV"":[[1.0,0.999,0.996,0.995,0.992,0.987,0.999,0.998,0.995,0.996,0.993,0.99,0.998,0.997,0.995,0.994,0.992,0.991,0.997,0.995],[0.999,1.0,0.999,0.996,0.994,0.989,0.998,0.999,0.998,0.997,0.996,0.992,0.997,0.999,0.998,0.996,0.994,0.993,0.996,0.996],[0.996,0.999,1.0,0.996,0.993,0.988,0.996,0.999,0.999,0.997,0.996,0.991,0.996,0.998,0.999,0.997,0.994,0.992,0.994,0.996],[0.995,0.996,0.996,1.0,0.999,0.997,0.992,0.994,0.993,1.0,0.999,0.998,0.991,0.993,0.993,0.999,0.998,0.998,0.99,0.99],[0.992,0.994,0.993,0.999,1.0,0.998,0.988,0.99,0.989,0.998,0.998,0.999,0.986,0.99,0.989,0.998,0.998,0.998,0.985,0.985],[0.987,0.989,0.988,0.997,0.998,1.0,0.982,0.985,0.983,0.995,0.996,1.0,0.98,0.984,0.983,0.995,0.996,0.998,0.979,0.979],[0.999,0.998,0.996,0.992,0.988,0.982,1.0,0.999,0.997,0.994,0.992,0.986,1.0,0.999,0.997,0.992,0.99,0.989,0.999,0.998],[0.998,0.999,0.999,0.994,0.99,0.985,0.999,1.0,0.999,0.996,0.994,0.989,0.999,1.0,0.999,0.995,0.992,0.991,0.998,0.999],[0.995,0.998,0.999,0.993,0.989,0.983,0.997,0.999,1.0,0.995,0.994,0.987,0.997,0.999,1.0,0.995,0.992,0.99,0.996,0.998],[0.996,0.997,0.997,1.0,0.998,0.995,0.994,0.996,0.995,1.0,0.999,0.997,0.993,0.996,0.995,1.0,0.999,0.998,0.992,0.993],[0.993,0.996,0.996,0.999,0.998,0.996,0.992,0.994,0.994,0.999,1.0,0.998,0.991,0.994,0.994,0.999,0.999,0.999,0.99,0.991],[0.99,0.992,0.991,0.998,0.999,1.0,0.986,0.989,0.987,0.997,0.998,1.0,0.985,0.988,0.988,0.997,0.998,0.999,0.984,0.984],[0.998,0.997,0.996,0.991,0.986,0.98,1.0,0.999,0.997,0.993,0.991,0.985,1.0,0.999,0.997,0.992,0.99,0.988,1.0,0.999],[0.997,0.999,0.998,0.993,0.99,0.984,0.999,1.0,0.999,0.996,0.994,0.988,0.999,1.0,0.999,0.995,0.993,0.991,0.998,0.999],[0.995,0.998,0.999,0.993,0.989,0.983,0.997,0.999,1.0,0.995,0.994,0.988,0.997,0.999,1.0,0.995,0.992,0.99,0.997,0.999],[0.994,0.996,0.997,0.999,0.998,0.995,0.992,0.995,0.995,1.0,0.999,0.997,0.992,0.995,0.995,1.0,0.999,0.998,0.991,0.992],[0.992,0.994,0.994,0.998,0.998,0.996,0.99,0.992,0.992,0.999,0.999,0.998,0.99,0.993,0.992,0.999,1.0,1.0,0.99,0.991],[0.991,0.993,0.992,0.998,0.998,0.998,0.989,0.991,0.99,0.998,0.999,0.999,0.988,0.991,0.99,0.998,1.0,1.0,0.988,0.988],[0.997,0.996,0.994,0.99,0.985,0.979,0.999,0.998,0.996,0.992,0.99,0.984,1.0,0.998,0.997,0.991,0.99,0.988,1.0,0.999],[0.995,0.996,0.996,0.99,0.985,0.979,0.998,0.999,0.998,0.993,0.991,0.984,0.999,0.999,0.999,0.992,0.991,0.988,0.999,1.0]],""K"":1,""R"":0.994,""featValue"":[19.891,0.084,0.012,0.009,0.003,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.113,0.489,0.297,-0.089,0.239,0.042,-0.163,0.086,0.196,0.2,0.379,-0.019,-0.002,-0.246,0.262,0.265,-0.288,-0.007,-0.067],[-0.224,0.091,0.028,0.36,0.122,-0.237,0.111,-0.109,0.22,-0.04,-0.073,0.226,0.086,0.54,0.131,0.069,-0.227,0.476,0.095,0.045],[-0.224,0.091,-0.294,0.343,0.062,0.279,0.064,0.118,0.002,-0.21,-0.366,0.017,-0.058,-0.333,-0.397,0.142,-0.186,0.085,-0.194,0.298],[-0.224,-0.182,0.044,0.194,-0.332,-0.012,0.114,-0.254,-0.146,-0.318,-0.088,-0.187,0.073,-0.211,0.279,0.235,-0.246,-0.07,0.042,-0.524],[-0.223,-0.287,0.071,0.17,-0.326,-0.487,-0.044,0.471,-0.182,-0.06,0.071,0.291,-0.068,-0.216,0.005,-0.185,0.131,0.036,0.112,0.155],[-0.223,-0.407,0.155,0.121,0.54,0.093,-0.035,0.077,-0.028,-0.429,0.125,-0.173,0.21,0.155,0.096,-0.118,0.182,-0.24,-0.11,0.118],[-0.224,0.233,0.329,0.058,-0.118,0.119,-0.127,0.313,-0.176,0.14,-0.24,-0.307,-0.253,0.333,0.043,-0.263,-0.339,-0.275,-0.055,-0.004],[-0.224,0.185,-0.039,0.113,0.144,-0.262,-0.091,-0.301,0.169,0.193,-0.468,-0.162,0.062,-0.223,0.198,-0.152,0.331,-0.209,0.344,0.12],[-0.224,0.188,-0.368,0.164,0.1,0.255,-0.121,0.038,-0.343,0.185,0.096,0.216,0.183,0.016,0.1,-0.412,0.208,0.126,-0.137,-0.402],[-0.224,-0.11,-0.062,0.039,-0.324,0.121,0.093,-0.455,-0.287,0.081,0.301,-0.293,-0.122,0.094,0.033,-0.136,0.109,0.174,-0.053,0.493],[-0.224,-0.172,-0.122,-0.136,-0.102,-0.079,-0.804,-0.185,0.204,0.075,0.063,0.098,0.134,0.026,-0.094,0.085,-0.243,-0.081,-0.168,0.036],[-0.223,-0.33,0.066,-0.053,0.33,0.049,-0.006,-0.024,0.038,0.269,0.126,-0.17,-0.4,-0.168,-0.319,-0.065,-0.13,0.285,0.368,-0.274],[-0.223,0.267,0.256,-0.166,0.013,0.048,-0.223,0.262,0.03,-0.076,0.012,-0.28,-0.026,-0.145,0.193,0.331,0.369,0.487,-0.192,-0.034],[-0.224,0.188,-0.077,-0.008,0.179,-0.498,0.297,-0.009,0.065,0.262,0.281,-0.229,0.136,-0.133,-0.15,0.053,-0.155,-0.165,-0.465,-0.08],[-0.224,0.186,-0.4,-0.032,0.06,0.096,0.004,0.274,-0.073,0.045,0.334,-0.042,0.015,0.097,0.19,0.432,-0.084,-0.264,0.468,0.135],[-0.224,-0.135,-0.207,-0.079,-0.307,0.233,0.217,0.167,0.722,-0.017,0.068,-0.07,-0.109,0.066,0.101,-0.239,0.149,-0.064,-0.099,-0.09],[-0.224,-0.204,-0.065,-0.365,-0.181,-0.023,0.176,0.063,-0.175,0.096,-0.342,-0.073,0.394,0.345,-0.422,0.171,0.206,0.011,0.085,-0.1],[-0.223,-0.259,0.04,-0.335,0.174,0.141,0.207,-0.028,-0.113,0.294,-0.247,0.378,-0.143,-0.104,0.455,0.152,-0.155,-0.017,-0.246,0.158],[-0.223,0.273,0.281,-0.347,-0.002,0.127,0.113,-0.041,0.07,-0.202,0.153,0.139,0.415,-0.283,-0.049,-0.319,-0.322,0.113,0.261,0.126],[-0.223,0.268,-0.122,-0.341,0.062,-0.203,0.013,-0.213,-0.085,-0.488,-0.007,0.242,-0.511,0.147,-0.147,-0.043,0.136,-0.12,-0.048,-0.108]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8043,""AfterCleanSamNum"":5404,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":474,""version"":""v-2025-12-09 10:49:09"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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