using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA423")]
    [FCDisplay("PCA423")]
    public partial class PCA423 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁67号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁67号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁67号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁67号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁67号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁67号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁68号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁68号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁68号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁68号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁68号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁68号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁69号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁69号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁69号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁69号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁69号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁69号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁70号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁70号屏2号管壁温")]
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

		public PCA423()
		{
			ModelID = 464;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA423";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""464"",""name"":""PCA423"",""description"":""中温分隔屏过热器水冷壁22-1-20"",""founder"":""admin"",""creatTime"":""2025-12-09 10:19:47"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:21:23"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 20:01:56"",""et"":""2025-12-07 13:04:08"",""duration"":2394132,""number"":7981,""filter"":2626,""mode"":5355,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2536}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah22ct101k"",""Description"":""中温（分隔屏）过热器水冷壁67号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""565.94"",""TMin"":""480.84"",""TAvg"":""532.26"",""DMax"":""4.17"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.52"",""C99"":""3.09""},{""PointId"":""d1_10hah22ct102k"",""Description"":""中温（分隔屏）过热器水冷壁67号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""565.03"",""TMin"":""479.49"",""TAvg"":""532.48"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.93"",""C99"":""2.36""},{""PointId"":""d1_10hah22ct103k"",""Description"":""中温（分隔屏）过热器水冷壁67号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""565.48"",""TMin"":""478.91"",""TAvg"":""532.97"",""DMax"":""3.66"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.33"",""C99"":""2.86""},{""PointId"":""d1_10hah22ct104k"",""Description"":""中温（分隔屏）过热器水冷壁67号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""569.27"",""TMin"":""485.00"",""TAvg"":""536.82"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.29"",""C99"":""1.58""},{""PointId"":""d1_10hah22ct105k"",""Description"":""中温（分隔屏）过热器水冷壁67号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""573.20"",""TMin"":""490.25"",""TAvg"":""540.73"",""DMax"":""4.63"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.27"",""C99"":""2.78""},{""PointId"":""d1_10hah22ct106k"",""Description"":""中温（分隔屏）过热器水冷壁67号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""573.26"",""TMin"":""492.07"",""TAvg"":""541.45"",""DMax"":""6.73"",""DMin"":""0.00"",""DAvg"":""1.01"",""C95"":""3.47"",""C99"":""4.25""},{""PointId"":""d1_10hah22ct107k"",""Description"":""中温（分隔屏）过热器水冷壁68号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""567.94"",""TMin"":""482.03"",""TAvg"":""533.46"",""DMax"":""4.51"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.56"",""C99"":""3.14""},{""PointId"":""d1_10hah22ct108k"",""Description"":""中温（分隔屏）过热器水冷壁68号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""567.26"",""TMin"":""480.99"",""TAvg"":""533.84"",""DMax"":""2.03"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.52"",""C99"":""1.85""},{""PointId"":""d1_10hah22ct109k"",""Description"":""中温（分隔屏）过热器水冷壁68号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""564.51"",""TMin"":""477.45"",""TAvg"":""531.87"",""DMax"":""4.18"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.99"",""C99"":""2.44""},{""PointId"":""d1_10hah22ct110k"",""Description"":""中温（分隔屏）过热器水冷壁68号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""572.63"",""TMin"":""486.89"",""TAvg"":""539.48"",""DMax"":""2.15"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.82"",""C99"":""2.22""},{""PointId"":""d1_10hah22ct111k"",""Description"":""中温（分隔屏）过热器水冷壁68号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""571.86"",""TMin"":""487.64"",""TAvg"":""539.10"",""DMax"":""3.77"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.12"",""C99"":""2.59""},{""PointId"":""d1_10hah22ct112k"",""Description"":""中温（分隔屏）过热器水冷壁68号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""573.39"",""TMin"":""488.90"",""TAvg"":""540.44"",""DMax"":""4.45"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.08"",""C99"":""3.77""},{""PointId"":""d1_10hah22ct113k"",""Description"":""中温（分隔屏）过热器水冷壁69号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""565.03"",""TMin"":""479.33"",""TAvg"":""531.60"",""DMax"":""4.29"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.59"",""C99"":""3.17""},{""PointId"":""d1_10hah22ct114k"",""Description"":""中温（分隔屏）过热器水冷壁69号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""564.94"",""TMin"":""477.77"",""TAvg"":""531.98"",""DMax"":""4.05"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.29"",""C99"":""2.80""},{""PointId"":""d1_10hah22ct115k"",""Description"":""中温（分隔屏）过热器水冷壁69号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""564.11"",""TMin"":""475.95"",""TAvg"":""531.31"",""DMax"":""3.50"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.57"",""C99"":""3.15""},{""PointId"":""d1_10hah22ct116k"",""Description"":""中温（分隔屏）过热器水冷壁69号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""572.17"",""TMin"":""486.17"",""TAvg"":""539.18"",""DMax"":""2.43"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.92"",""C99"":""2.35""},{""PointId"":""d1_10hah22ct117k"",""Description"":""中温（分隔屏）过热器水冷壁69号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""572.49"",""TMin"":""488.24"",""TAvg"":""540.05"",""DMax"":""4.18"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.09"",""C99"":""3.77""},{""PointId"":""d1_10hah22ct118k"",""Description"":""中温（分隔屏）过热器水冷壁69号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""573.11"",""TMin"":""490.45"",""TAvg"":""541.17"",""DMax"":""5.71"",""DMin"":""0.00"",""DAvg"":""1.26"",""C95"":""4.22"",""C99"":""5.16""},{""PointId"":""d1_10hah22ct119k"",""Description"":""中温（分隔屏）过热器水冷壁70号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""562.53"",""TMin"":""477.17"",""TAvg"":""529.61"",""DMax"":""4.85"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.12"",""C99"":""3.82""},{""PointId"":""d1_10hah22ct120k"",""Description"":""中温（分隔屏）过热器水冷壁70号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""563.32"",""TMin"":""477.79"",""TAvg"":""531.47"",""DMax"":""3.39"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.41"",""C99"":""2.95""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:21:23"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[480.84,479.494,478.906,485.0,490.25,492.067,482.033,480.989,477.453,486.892,487.644,488.9,479.333,477.765,475.947,486.171,488.238,490.453,477.171,477.787],""Train_X_max"":[565.943,565.033,565.48,569.271,573.2,573.257,567.943,567.257,564.514,572.629,571.863,573.386,565.029,564.943,564.11,572.171,572.486,573.113,562.529,563.317],""Train_X_std"":[9.105,9.207,9.36,9.012,8.929,8.732,9.178,9.213,9.351,9.071,8.96,8.898,9.167,9.367,9.461,9.108,8.961,8.828,9.261,9.309],""Train_X_mean"":[532.259,532.482,532.971,536.819,540.725,541.449,533.461,533.843,531.867,539.483,539.1,540.437,531.604,531.975,531.308,539.181,540.051,541.171,529.611,531.47],""Train_X_bais_max"":[[4.169,3.36,3.662,1.997,4.625,6.728,4.508,2.03,4.179,2.149,3.772,4.45,4.291,4.045,3.498,2.431,4.182,5.706,4.854,3.386]],""Train_X_bais_min"":[[0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.72,0.563,0.686,0.371,0.655,1.013,0.728,0.446,0.577,0.526,0.619,0.912,0.755,0.67,0.747,0.56,0.914,1.257,0.905,0.705]],""QCUL_95"":0.686819851,""QCUL_99"":1.23149955,""QCUL_95_line"":[2.522,1.93,2.333,1.288,2.266,3.47,2.557,1.515,1.989,1.816,2.119,3.082,2.589,2.291,2.569,1.916,3.086,4.222,3.119,2.413],""QCUL_99_line"":[3.091,2.362,2.855,1.578,2.775,4.248,3.135,1.853,2.436,2.224,2.594,3.769,3.17,2.804,3.146,2.345,3.772,5.16,3.819,2.953],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.244,0.247,0.251,0.241,0.239,0.234,0.246,0.247,0.251,0.243,0.24,0.238,0.246,0.251,0.253,0.244,0.24,0.237,0.248,0.249],""T2CUL_99_line"":[0.321,0.324,0.33,0.317,0.314,0.308,0.323,0.324,0.329,0.319,0.316,0.313,0.323,0.33,0.333,0.321,0.316,0.311,0.326,0.328],""Kesi_95"":1.558,""Kesi_99"":1.322,""Kesi_95_line"":[0.155,0.157,0.16,0.154,0.152,0.149,0.157,0.157,0.16,0.155,0.153,0.152,0.156,0.16,0.161,0.155,0.153,0.151,0.158,0.159],""Kesi_99_line"":[0.143,0.145,0.147,0.142,0.14,0.137,0.144,0.145,0.147,0.143,0.141,0.14,0.144,0.147,0.149,0.143,0.141,0.139,0.146,0.146],""COV"":[[1.0,0.997,0.995,0.991,0.984,0.975,1.0,0.997,0.996,0.987,0.985,0.979,0.999,0.997,0.994,0.986,0.977,0.966,0.998,0.995],[0.997,1.0,0.999,0.994,0.988,0.979,0.997,0.999,0.999,0.99,0.989,0.982,0.997,0.999,0.998,0.989,0.981,0.971,0.996,0.997],[0.995,0.999,1.0,0.993,0.987,0.976,0.995,0.998,0.999,0.99,0.988,0.979,0.995,0.998,0.999,0.988,0.98,0.968,0.994,0.997],[0.991,0.994,0.993,1.0,0.999,0.993,0.991,0.995,0.994,0.999,0.998,0.995,0.989,0.992,0.991,0.998,0.995,0.989,0.987,0.991],[0.984,0.988,0.987,0.999,1.0,0.997,0.984,0.99,0.988,0.998,1.0,0.998,0.983,0.985,0.984,0.998,0.997,0.993,0.979,0.984],[0.975,0.979,0.976,0.993,0.997,1.0,0.974,0.981,0.977,0.994,0.997,0.999,0.973,0.975,0.973,0.994,0.998,0.998,0.967,0.975],[1.0,0.997,0.995,0.991,0.984,0.974,1.0,0.998,0.996,0.987,0.985,0.978,0.999,0.997,0.994,0.987,0.977,0.966,0.998,0.995],[0.997,0.999,0.998,0.995,0.99,0.981,0.998,1.0,0.999,0.992,0.991,0.984,0.998,0.999,0.998,0.992,0.984,0.975,0.996,0.998],[0.996,0.999,0.999,0.994,0.988,0.977,0.996,0.999,1.0,0.991,0.989,0.981,0.997,0.999,0.999,0.99,0.982,0.971,0.995,0.998],[0.987,0.99,0.99,0.999,0.998,0.994,0.987,0.992,0.991,1.0,0.999,0.997,0.986,0.988,0.988,0.999,0.997,0.992,0.983,0.988],[0.985,0.989,0.988,0.998,1.0,0.997,0.985,0.991,0.989,0.999,1.0,0.998,0.984,0.986,0.986,0.998,0.998,0.994,0.98,0.986],[0.979,0.982,0.979,0.995,0.998,0.999,0.978,0.984,0.981,0.997,0.998,1.0,0.977,0.978,0.977,0.996,0.999,0.998,0.972,0.978],[0.999,0.997,0.995,0.989,0.983,0.973,0.999,0.998,0.997,0.986,0.984,0.977,1.0,0.999,0.996,0.986,0.976,0.966,0.999,0.997],[0.997,0.999,0.998,0.992,0.985,0.975,0.997,0.999,0.999,0.988,0.986,0.978,0.999,1.0,0.999,0.988,0.979,0.968,0.998,0.999],[0.994,0.998,0.999,0.991,0.984,0.973,0.994,0.998,0.999,0.988,0.986,0.977,0.996,0.999,1.0,0.988,0.979,0.967,0.995,0.998],[0.986,0.989,0.988,0.998,0.998,0.994,0.987,0.992,0.99,0.999,0.998,0.996,0.986,0.988,0.988,1.0,0.998,0.993,0.984,0.989],[0.977,0.981,0.98,0.995,0.997,0.998,0.977,0.984,0.982,0.997,0.998,0.999,0.976,0.979,0.979,0.998,1.0,0.998,0.972,0.98],[0.966,0.971,0.968,0.989,0.993,0.998,0.966,0.975,0.971,0.992,0.994,0.998,0.966,0.968,0.967,0.993,0.998,1.0,0.961,0.97],[0.998,0.996,0.994,0.987,0.979,0.967,0.998,0.996,0.995,0.983,0.98,0.972,0.999,0.998,0.995,0.984,0.972,0.961,1.0,0.998],[0.995,0.997,0.997,0.991,0.984,0.975,0.995,0.998,0.998,0.988,0.986,0.978,0.997,0.999,0.998,0.989,0.98,0.97,0.998,1.0]],""K"":1,""R"":0.99,""featValue"":[19.798,0.166,0.016,0.01,0.005,0.002,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.202,0.388,-0.273,0.011,-0.027,0.119,-0.425,-0.111,-0.224,0.083,-0.17,0.325,0.096,-0.172,0.105,0.196,0.192,0.175,-0.36],[-0.224,0.158,-0.103,-0.19,-0.308,0.196,-0.288,-0.305,0.369,-0.187,0.339,0.398,-0.127,-0.069,0.128,-0.127,-0.212,0.019,0.115,0.114],[-0.224,0.172,-0.377,-0.242,-0.055,-0.05,0.285,-0.265,-0.264,-0.046,-0.074,0.09,0.003,0.146,0.001,0.036,0.245,-0.126,-0.514,0.339],[-0.224,-0.087,-0.102,-0.24,0.197,-0.232,-0.293,-0.175,0.002,0.102,-0.167,-0.348,-0.636,0.172,0.021,-0.151,0.083,0.119,0.159,-0.038],[-0.224,-0.203,-0.054,-0.314,-0.027,-0.436,-0.15,0.225,0.014,0.177,-0.089,0.418,0.156,0.148,-0.33,0.287,-0.107,-0.231,0.122,-0.111],[-0.222,-0.333,0.104,-0.131,-0.535,-0.055,-0.115,0.034,-0.204,0.387,0.194,-0.348,0.213,-0.219,0.162,-0.093,-0.005,0.075,-0.062,0.141],[-0.224,0.206,0.402,-0.173,0.198,0.185,0.012,0.252,-0.244,-0.008,-0.172,0.097,0.022,0.0,-0.073,-0.186,-0.143,0.064,0.252,0.593],[-0.224,0.127,-0.034,-0.04,-0.156,0.247,-0.313,0.378,-0.29,-0.273,-0.211,-0.006,0.035,0.271,0.255,-0.066,-0.165,0.019,-0.263,-0.401],[-0.224,0.16,-0.287,-0.057,0.149,0.21,0.069,0.016,-0.038,0.136,-0.04,-0.135,0.057,-0.48,-0.422,-0.375,-0.173,-0.262,0.008,-0.277],[-0.224,-0.15,-0.07,-0.073,0.459,0.199,-0.151,-0.073,0.015,0.015,0.062,-0.088,0.063,-0.329,0.167,0.591,-0.24,0.201,-0.192,0.058],[-0.224,-0.195,-0.079,-0.162,0.08,-0.231,0.289,0.387,0.152,-0.382,0.079,0.12,-0.033,-0.351,0.231,-0.186,0.345,0.24,0.054,-0.069],[-0.223,-0.294,0.162,-0.064,-0.089,0.174,0.418,-0.13,0.448,0.007,-0.468,-0.102,0.023,0.147,0.187,-0.023,-0.246,-0.232,-0.022,-0.034],[-0.224,0.227,0.316,0.079,-0.053,0.089,0.094,0.209,0.047,0.067,0.324,-0.101,-0.36,-0.058,0.076,0.302,0.258,-0.552,-0.033,-0.07],[-0.224,0.204,-0.065,0.163,-0.088,0.147,-0.201,0.231,0.517,0.162,-0.13,-0.154,0.158,0.142,-0.328,0.08,0.356,0.303,-0.161,0.128],[-0.224,0.196,-0.414,0.138,-0.034,0.122,0.36,0.094,-0.124,0.308,0.127,0.019,0.021,0.246,0.218,0.158,-0.067,0.199,0.504,-0.095],[-0.224,-0.154,-0.018,0.231,0.432,-0.029,-0.266,-0.146,0.039,0.121,0.131,0.078,0.39,0.192,0.316,-0.318,0.258,-0.305,0.048,0.024],[-0.223,-0.293,-0.048,0.249,0.059,-0.065,0.142,0.085,-0.017,-0.358,0.453,-0.238,-0.033,0.336,-0.357,-0.071,-0.317,0.02,-0.09,0.138],[-0.221,-0.406,0.11,0.36,-0.105,0.324,0.002,-0.191,-0.28,0.034,-0.152,0.4,-0.253,-0.079,-0.23,0.032,0.274,0.143,0.034,-0.094],[-0.223,0.271,0.293,0.289,0.076,-0.405,0.15,-0.066,0.037,0.308,0.043,0.221,-0.115,-0.057,0.098,-0.175,-0.282,0.272,-0.362,-0.153],[-0.224,0.186,-0.119,0.455,-0.217,-0.362,-0.158,-0.139,-0.073,-0.344,-0.33,-0.149,0.09,-0.255,0.051,0.181,-0.06,-0.156,0.228,0.171]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.221],[-0.223],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7981,""AfterCleanSamNum"":5355,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":464,""version"":""v-2025-12-09 10:21:23"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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