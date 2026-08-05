using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA448")]
    [FCDisplay("PCA448")]
    public partial class PCA448 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁149号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁149号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁149号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁150号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁150号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁150号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁150号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁150号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁150号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁151号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁151号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁151号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁151号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁151号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁151号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁152号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁152号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁152号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁152号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁152号屏5号管壁温")]
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

		public PCA448()
		{
			ModelID = 489;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA448";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""489"",""name"":""PCA448"",""description"":""中温分隔屏过热器水冷壁27-1-20"",""founder"":""admin"",""creatTime"":""2025-12-10 17:19:57"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:21:26"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 15:22:24"",""et"":""2025-12-07 10:50:14"",""duration"":2316470,""number"":7722,""filter"":2591,""mode"":5131,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2501}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah27ct101k"",""Description"":""中温（分隔屏）过热器水冷壁149号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""574.00"",""TMin"":""494.90"",""TAvg"":""543.65"",""DMax"":""3.11"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.18"",""C99"":""2.67""},{""PointId"":""d1_10hah27ct102k"",""Description"":""中温（分隔屏）过热器水冷壁149号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""576.30"",""TMin"":""497.98"",""TAvg"":""546.16"",""DMax"":""3.88"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""3.01"",""C99"":""3.69""},{""PointId"":""d1_10hah27ct103k"",""Description"":""中温（分隔屏）过热器水冷壁149号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""574.74"",""TMin"":""497.70"",""TAvg"":""545.53"",""DMax"":""4.78"",""DMin"":""0.00"",""DAvg"":""1.15"",""C95"":""3.94"",""C99"":""4.82""},{""PointId"":""d1_10hah27ct104k"",""Description"":""中温（分隔屏）过热器水冷壁150号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""567.64"",""TMin"":""490.22"",""TAvg"":""537.61"",""DMax"":""5.09"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.08"",""C99"":""3.77""},{""PointId"":""d1_10hah27ct105k"",""Description"":""中温（分隔屏）过热器水冷壁150号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""567.40"",""TMin"":""488.20"",""TAvg"":""537.41"",""DMax"":""3.60"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.59"",""C99"":""3.16""},{""PointId"":""d1_10hah27ct106k"",""Description"":""中温（分隔屏）过热器水冷壁150号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""567.80"",""TMin"":""487.95"",""TAvg"":""537.37"",""DMax"":""3.20"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.40"",""C99"":""2.95""},{""PointId"":""d1_10hah27ct107k"",""Description"":""中温（分隔屏）过热器水冷壁150号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""574.43"",""TMin"":""495.12"",""TAvg"":""544.28"",""DMax"":""2.32"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.62"",""C99"":""1.99""},{""PointId"":""d1_10hah27ct108k"",""Description"":""中温（分隔屏）过热器水冷壁150号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""575.36"",""TMin"":""496.40"",""TAvg"":""545.19"",""DMax"":""3.48"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.27"",""C99"":""2.78""},{""PointId"":""d1_10hah27ct109k"",""Description"":""中温（分隔屏）过热器水冷壁150号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""574.78"",""TMin"":""497.24"",""TAvg"":""545.84"",""DMax"":""4.18"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.54"",""C99"":""4.33""},{""PointId"":""d1_10hah27ct110k"",""Description"":""中温（分隔屏）过热器水冷壁151号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""566.92"",""TMin"":""490.94"",""TAvg"":""538.20"",""DMax"":""3.66"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.58"",""C99"":""3.16""},{""PointId"":""d1_10hah27ct111k"",""Description"":""中温（分隔屏）过热器水冷壁151号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""567.12"",""TMin"":""488.74"",""TAvg"":""538.15"",""DMax"":""2.91"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.12"",""C99"":""2.59""},{""PointId"":""d1_10hah27ct112k"",""Description"":""中温（分隔屏）过热器水冷壁151号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""566.08"",""TMin"":""485.68"",""TAvg"":""536.14"",""DMax"":""4.11"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.14"",""C99"":""3.85""},{""PointId"":""d1_10hah27ct113k"",""Description"":""中温（分隔屏）过热器水冷壁151号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""571.14"",""TMin"":""491.93"",""TAvg"":""541.48"",""DMax"":""1.38"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.06"",""C99"":""1.30""},{""PointId"":""d1_10hah27ct114k"",""Description"":""中温（分隔屏）过热器水冷壁151号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""573.10"",""TMin"":""493.32"",""TAvg"":""543.10"",""DMax"":""3.61"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.96"",""C99"":""2.41""},{""PointId"":""d1_10hah27ct115k"",""Description"":""中温（分隔屏）过热器水冷壁151号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""571.97"",""TMin"":""493.98"",""TAvg"":""543.17"",""DMax"":""3.83"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.69"",""C99"":""3.29""},{""PointId"":""d1_10hah27ct116k"",""Description"":""中温（分隔屏）过热器水冷壁152号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""566.70"",""TMin"":""489.20"",""TAvg"":""537.56"",""DMax"":""5.19"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.13"",""C99"":""3.84""},{""PointId"":""d1_10hah27ct117k"",""Description"":""中温（分隔屏）过热器水冷壁152号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""566.88"",""TMin"":""487.98"",""TAvg"":""537.53"",""DMax"":""3.14"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.76"",""C99"":""3.38""},{""PointId"":""d1_10hah27ct118k"",""Description"":""中温（分隔屏）过热器水冷壁152号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""566.00"",""TMin"":""485.30"",""TAvg"":""536.16"",""DMax"":""3.98"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.94"",""C99"":""3.60""},{""PointId"":""d1_10hah27ct119k"",""Description"":""中温（分隔屏）过热器水冷壁152号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""573.33"",""TMin"":""492.90"",""TAvg"":""543.77"",""DMax"":""2.22"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.49"",""C99"":""1.83""},{""PointId"":""d1_10hah27ct120k"",""Description"":""中温（分隔屏）过热器水冷壁152号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""572.43"",""TMin"":""492.56"",""TAvg"":""543.03"",""DMax"":""4.33"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.70"",""C99"":""3.31""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:21:26"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[494.9,497.98,497.7,490.22,488.2,487.95,495.12,496.4,497.24,490.94,488.74,485.68,491.925,493.32,493.975,489.2,487.98,485.3,492.9,492.56],""Train_X_max"":[574.0,576.3,574.74,567.64,567.4,567.8,574.433,575.36,574.78,566.917,567.12,566.08,571.14,573.1,571.967,566.7,566.88,566.0,573.333,572.433],""Train_X_std"":[9.452,9.442,9.411,9.589,9.618,9.641,9.472,9.491,9.427,9.414,9.504,9.688,9.481,9.503,9.44,9.57,9.572,9.662,9.58,9.501],""Train_X_mean"":[543.65,546.155,545.527,537.614,537.406,537.373,544.284,545.189,545.844,538.2,538.145,536.141,541.48,543.097,543.172,537.559,537.528,536.161,543.767,543.029],""Train_X_bais_max"":[[3.106,3.876,4.779,5.091,3.603,3.199,2.324,3.482,4.178,3.664,2.913,4.114,1.379,3.614,3.832,5.186,3.143,3.979,2.216,4.327]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0]],""Train_X_bais_mean"":[[0.634,0.874,1.149,0.889,0.753,0.68,0.462,0.658,1.037,0.747,0.607,0.904,0.31,0.554,0.784,0.909,0.801,0.85,0.428,0.783]],""QCUL_95"":0.659282148,""QCUL_99"":1.17204142,""QCUL_95_line"":[2.178,3.01,3.939,3.076,2.585,2.4,1.619,2.269,3.536,2.577,2.116,3.143,1.064,1.964,2.685,3.132,2.76,2.941,1.489,2.702],""QCUL_99_line"":[2.667,3.685,4.822,3.767,3.164,2.945,1.986,2.779,4.327,3.156,2.593,3.851,1.303,2.41,3.286,3.835,3.379,3.602,1.825,3.309],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.259,0.258,0.258,0.262,0.263,0.264,0.259,0.26,0.258,0.258,0.26,0.265,0.26,0.26,0.258,0.262,0.262,0.264,0.262,0.26],""T2CUL_99_line"":[0.34,0.34,0.339,0.345,0.346,0.347,0.341,0.341,0.339,0.339,0.342,0.349,0.341,0.342,0.34,0.344,0.344,0.348,0.345,0.342],""Kesi_95"":1.556,""Kesi_99"":1.317,""Kesi_95_line"":[0.165,0.164,0.164,0.167,0.167,0.168,0.165,0.165,0.164,0.164,0.166,0.169,0.165,0.165,0.164,0.167,0.167,0.168,0.167,0.165],""Kesi_99_line"":[0.151,0.151,0.151,0.154,0.154,0.154,0.152,0.152,0.151,0.151,0.152,0.155,0.152,0.152,0.151,0.153,0.153,0.155,0.153,0.152],""COV"":[[1.0,0.999,0.996,0.985,0.989,0.991,0.999,0.998,0.995,0.985,0.988,0.984,0.996,0.996,0.995,0.982,0.984,0.984,0.994,0.991],[0.999,1.0,0.999,0.978,0.982,0.983,0.998,0.999,0.998,0.979,0.982,0.976,0.993,0.996,0.996,0.975,0.977,0.976,0.99,0.992],[0.996,0.999,1.0,0.97,0.974,0.976,0.994,0.997,0.999,0.972,0.975,0.967,0.989,0.993,0.996,0.967,0.968,0.967,0.985,0.989],[0.985,0.978,0.97,1.0,0.998,0.996,0.986,0.981,0.972,0.998,0.997,0.996,0.99,0.983,0.978,0.997,0.996,0.995,0.99,0.98],[0.989,0.982,0.974,0.998,1.0,0.999,0.989,0.985,0.975,0.997,0.999,0.999,0.992,0.986,0.981,0.994,0.998,0.998,0.991,0.981],[0.991,0.983,0.976,0.996,0.999,1.0,0.991,0.987,0.978,0.995,0.998,0.999,0.994,0.987,0.983,0.992,0.996,0.998,0.993,0.983],[0.999,0.998,0.994,0.986,0.989,0.991,1.0,0.999,0.996,0.988,0.991,0.986,0.999,0.998,0.997,0.985,0.987,0.987,0.997,0.996],[0.998,0.999,0.997,0.981,0.985,0.987,0.999,1.0,0.998,0.984,0.987,0.981,0.997,0.999,0.998,0.981,0.983,0.982,0.995,0.996],[0.995,0.998,0.999,0.972,0.975,0.978,0.996,0.998,1.0,0.975,0.978,0.97,0.991,0.996,0.999,0.972,0.972,0.971,0.989,0.994],[0.985,0.979,0.972,0.998,0.997,0.995,0.988,0.984,0.975,1.0,0.999,0.996,0.993,0.987,0.983,0.999,0.999,0.997,0.993,0.986],[0.988,0.982,0.975,0.997,0.999,0.998,0.991,0.987,0.978,0.999,1.0,0.998,0.995,0.989,0.985,0.997,0.999,0.999,0.995,0.987],[0.984,0.976,0.967,0.996,0.999,0.999,0.986,0.981,0.97,0.996,0.998,1.0,0.991,0.983,0.977,0.993,0.998,1.0,0.991,0.979],[0.996,0.993,0.989,0.99,0.992,0.994,0.999,0.997,0.991,0.993,0.995,0.991,1.0,0.998,0.995,0.991,0.993,0.992,1.0,0.996],[0.996,0.996,0.993,0.983,0.986,0.987,0.998,0.999,0.996,0.987,0.989,0.983,0.998,1.0,0.999,0.985,0.987,0.985,0.998,0.999],[0.995,0.996,0.996,0.978,0.981,0.983,0.997,0.998,0.999,0.983,0.985,0.977,0.995,0.999,1.0,0.981,0.981,0.979,0.995,0.998],[0.982,0.975,0.967,0.997,0.994,0.992,0.985,0.981,0.972,0.999,0.997,0.993,0.991,0.985,0.981,1.0,0.998,0.995,0.992,0.985],[0.984,0.977,0.968,0.996,0.998,0.996,0.987,0.983,0.972,0.999,0.999,0.998,0.993,0.987,0.981,0.998,1.0,0.999,0.993,0.985],[0.984,0.976,0.967,0.995,0.998,0.998,0.987,0.982,0.971,0.997,0.999,1.0,0.992,0.985,0.979,0.995,0.999,1.0,0.993,0.982],[0.994,0.99,0.985,0.99,0.991,0.993,0.997,0.995,0.989,0.993,0.995,0.991,1.0,0.998,0.995,0.992,0.993,0.993,1.0,0.997],[0.991,0.992,0.989,0.98,0.981,0.983,0.996,0.996,0.994,0.986,0.987,0.979,0.996,0.999,0.998,0.985,0.985,0.982,0.997,1.0]],""K"":1,""R"":0.99,""featValue"":[19.801,0.155,0.026,0.012,0.005,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,-0.156,-0.311,0.032,-0.291,-0.074,0.349,-0.118,0.0,0.023,-0.521,0.099,0.325,0.116,0.195,-0.117,0.109,0.329,0.157,-0.066],[0.223,-0.268,-0.244,0.091,-0.018,-0.451,0.055,0.123,-0.178,-0.244,0.143,0.031,0.073,-0.085,-0.03,-0.211,-0.437,-0.245,-0.091,0.399],[0.222,-0.362,-0.238,0.252,0.19,0.119,0.193,0.315,-0.165,-0.092,0.129,-0.072,0.006,0.148,-0.133,0.383,0.25,-0.255,0.038,-0.374],[0.223,0.249,-0.11,0.486,-0.333,0.069,-0.44,0.257,0.192,-0.118,0.012,-0.003,0.038,-0.291,0.211,-0.009,0.214,-0.069,0.155,0.088],[0.224,0.213,-0.278,0.038,0.206,-0.194,-0.082,0.059,0.381,0.249,-0.195,0.115,-0.035,-0.091,-0.348,0.337,-0.159,0.209,-0.406,0.005],[0.224,0.179,-0.317,-0.202,0.028,0.221,-0.091,-0.252,-0.157,-0.126,-0.27,-0.167,-0.438,-0.112,-0.191,0.058,-0.221,-0.169,0.438,-0.023],[0.224,-0.137,-0.067,-0.099,-0.343,0.057,0.15,-0.378,0.221,0.066,0.084,-0.162,-0.304,0.012,0.149,-0.053,0.283,-0.345,-0.473,0.061],[0.224,-0.208,-0.064,-0.097,0.061,-0.349,-0.333,-0.253,-0.227,0.157,0.287,0.16,-0.131,-0.055,-0.209,-0.121,0.439,0.332,0.167,-0.016],[0.223,-0.335,-0.013,0.142,0.199,0.43,-0.046,0.045,0.145,0.093,0.154,0.262,-0.334,0.051,0.337,-0.166,-0.311,0.337,-0.04,0.011],[0.224,0.22,0.147,0.35,0.089,0.094,0.041,-0.588,-0.252,0.074,0.174,0.193,0.323,0.048,0.103,0.307,-0.18,-0.107,0.002,0.034],[0.224,0.19,0.014,-0.032,0.358,-0.012,0.327,-0.13,0.457,-0.358,0.269,-0.102,0.175,-0.193,-0.079,-0.319,0.117,0.037,0.166,-0.148],[0.223,0.274,-0.201,-0.285,0.039,0.225,-0.289,0.127,-0.049,-0.159,0.079,0.156,0.227,0.636,-0.036,-0.198,0.085,-0.097,-0.15,0.084],[0.225,-0.037,0.09,-0.191,-0.378,0.076,0.069,0.1,0.104,0.076,0.386,-0.483,0.133,0.127,-0.091,0.308,-0.204,0.336,0.168,0.147],[0.224,-0.159,0.212,-0.14,0.039,-0.226,-0.412,-0.066,0.054,0.022,-0.162,-0.267,0.173,-0.008,0.218,-0.096,-0.279,-0.111,-0.085,-0.591],[0.224,-0.238,0.204,0.007,0.265,0.314,-0.087,0.051,-0.02,0.381,-0.256,-0.257,0.298,-0.167,-0.218,-0.2,0.14,-0.175,0.026,0.376],[0.223,0.242,0.335,0.405,-0.124,-0.049,0.191,0.107,-0.268,-0.02,-0.117,-0.171,-0.283,0.212,-0.327,-0.343,-0.047,0.175,-0.18,-0.141],[0.224,0.249,0.139,-0.058,0.228,-0.369,0.191,0.201,0.075,0.388,-0.019,-0.019,-0.228,0.246,0.422,0.082,0.086,-0.185,0.291,0.141],[0.223,0.262,-0.041,-0.326,0.086,0.115,0.143,0.225,-0.483,-0.047,0.049,-0.031,0.046,-0.465,0.285,0.047,0.093,0.167,-0.32,-0.044],[0.224,-0.011,0.258,-0.245,-0.364,0.072,0.145,0.18,0.088,0.185,0.081,0.573,0.049,-0.18,-0.272,-0.044,-0.12,-0.258,0.159,-0.194],[0.224,-0.166,0.481,-0.123,0.067,-0.066,-0.074,0.0,0.079,-0.552,-0.307,0.145,-0.115,0.054,0.015,0.354,0.142,0.095,-0.026,0.251]],""selectVec"":[[0.224],[0.223],[0.222],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.224],[0.224],[0.223],[0.225],[0.224],[0.224],[0.223],[0.224],[0.223],[0.224],[0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7722,""AfterCleanSamNum"":5131,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":489,""version"":""v-2025-12-10 17:21:26"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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