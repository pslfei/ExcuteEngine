using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA396")]
    [FCDisplay("PCA396")]
    public partial class PCA396 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁11号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁11号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁11号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁11号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁11号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁11号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁12号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁12号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁12号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁12号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁12号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁12号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁13号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁13号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁13号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁13号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁13号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁13号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁14号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁14号屏2号管壁温")]
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

		public PCA396()
		{
			ModelID = 437;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA396";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""437"",""name"":""PCA396"",""description"":""中温分隔屏过热器水冷壁61-80"",""founder"":""admin"",""creatTime"":""2025-12-03 14:48:38"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:50:30"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 17:29:10"",""et"":""2025-12-03 09:23:16"",""duration"":2562846,""number"":8543,""filter"":2591,""mode"":5952,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2501}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah17ct161k"",""Description"":""中温（分隔屏）过热器水冷壁11号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""574.82"",""TMin"":""478.23"",""TAvg"":""531.49"",""DMax"":""7.81"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.51"",""C99"":""4.30""},{""PointId"":""d1_10hah17ct162k"",""Description"":""中温（分隔屏）过热器水冷壁11号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""576.78"",""TMin"":""478.62"",""TAvg"":""532.88"",""DMax"":""5.68"",""DMin"":""0.00"",""DAvg"":""1.05"",""C95"":""3.61"",""C99"":""4.42""},{""PointId"":""d1_10hah17ct163k"",""Description"":""中温（分隔屏）过热器水冷壁11号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""577.18"",""TMin"":""478.00"",""TAvg"":""533.29"",""DMax"":""6.90"",""DMin"":""0.00"",""DAvg"":""1.16"",""C95"":""3.95"",""C99"":""4.83""},{""PointId"":""d1_10hah17ct164k"",""Description"":""中温（分隔屏）过热器水冷壁11号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""583.90"",""TMin"":""485.13"",""TAvg"":""539.34"",""DMax"":""3.42"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.58"",""C99"":""1.94""},{""PointId"":""d1_10hah17ct165k"",""Description"":""中温（分隔屏）过热器水冷壁11号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""583.62"",""TMin"":""483.48"",""TAvg"":""538.83"",""DMax"":""3.27"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.93"",""C99"":""2.36""},{""PointId"":""d1_10hah17ct166k"",""Description"":""中温（分隔屏）过热器水冷壁11号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""587.58"",""TMin"":""487.46"",""TAvg"":""543.18"",""DMax"":""4.32"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.37"",""C99"":""4.12""},{""PointId"":""d1_10hah17ct167k"",""Description"":""中温（分隔屏）过热器水冷壁12号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""582.15"",""TMin"":""486.63"",""TAvg"":""537.68"",""DMax"":""3.46"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.93"",""C99"":""3.59""},{""PointId"":""d1_10hah17ct168k"",""Description"":""中温（分隔屏）过热器水冷壁12号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""581.55"",""TMin"":""484.58"",""TAvg"":""536.48"",""DMax"":""2.63"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.43"",""C99"":""2.97""},{""PointId"":""d1_10hah17ct169k"",""Description"":""中温（分隔屏）过热器水冷壁12号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""583.28"",""TMin"":""484.67"",""TAvg"":""537.86"",""DMax"":""2.57"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.36"",""C99"":""2.89""},{""PointId"":""d1_10hah17ct170k"",""Description"":""中温（分隔屏）过热器水冷壁12号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""589.43"",""TMin"":""489.32"",""TAvg"":""543.40"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.70"",""C99"":""2.08""},{""PointId"":""d1_10hah17ct171k"",""Description"":""中温（分隔屏）过热器水冷壁12号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""590.00"",""TMin"":""488.93"",""TAvg"":""543.87"",""DMax"":""3.68"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.56"",""C99"":""3.14""},{""PointId"":""d1_10hah17ct172k"",""Description"":""中温（分隔屏）过热器水冷壁12号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""591.20"",""TMin"":""490.82"",""TAvg"":""546.07"",""DMax"":""4.99"",""DMin"":""0.00"",""DAvg"":""1.12"",""C95"":""3.84"",""C99"":""4.70""},{""PointId"":""d1_10hah17ct173k"",""Description"":""中温（分隔屏）过热器水冷壁13号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""581.98"",""TMin"":""486.47"",""TAvg"":""537.44"",""DMax"":""3.22"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.39"",""C99"":""2.93""},{""PointId"":""d1_10hah17ct174k"",""Description"":""中温（分隔屏）过热器水冷壁13号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""583.20"",""TMin"":""485.32"",""TAvg"":""537.56"",""DMax"":""2.77"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.08"",""C99"":""2.54""},{""PointId"":""d1_10hah17ct175k"",""Description"":""中温（分隔屏）过热器水冷壁13号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""583.88"",""TMin"":""484.18"",""TAvg"":""537.67"",""DMax"":""2.88"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.02"",""C99"":""2.47""},{""PointId"":""d1_10hah17ct176k"",""Description"":""中温（分隔屏）过热器水冷壁13号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""591.43"",""TMin"":""489.55"",""TAvg"":""544.21"",""DMax"":""5.23"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""3.00"",""C99"":""3.68""},{""PointId"":""d1_10hah17ct177k"",""Description"":""中温（分隔屏）过热器水冷壁13号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""595.00"",""TMin"":""492.18"",""TAvg"":""547.64"",""DMax"":""5.93"",""DMin"":""0.00"",""DAvg"":""1.11"",""C95"":""3.84"",""C99"":""4.70""},{""PointId"":""d1_10hah17ct178k"",""Description"":""中温（分隔屏）过热器水冷壁13号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""596.38"",""TMin"":""493.82"",""TAvg"":""549.72"",""DMax"":""7.31"",""DMin"":""0.00"",""DAvg"":""1.70"",""C95"":""5.76"",""C99"":""7.04""},{""PointId"":""d1_10hah17ct179k"",""Description"":""中温（分隔屏）过热器水冷壁14号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""579.72"",""TMin"":""484.08"",""TAvg"":""535.16"",""DMax"":""4.08"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.60"",""C99"":""3.19""},{""PointId"":""d1_10hah17ct180k"",""Description"":""中温（分隔屏）过热器水冷壁14号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""580.23"",""TMin"":""482.45"",""TAvg"":""535.08"",""DMax"":""3.93"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.57"",""C99"":""3.14""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:50:30"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[478.233,478.617,478.0,485.133,483.483,487.46,486.633,484.583,484.667,489.317,488.933,490.817,486.467,485.32,484.18,489.55,492.18,493.817,484.08,482.45],""Train_X_max"":[574.817,576.783,577.18,583.9,583.617,587.583,582.15,581.55,583.283,589.433,590.0,591.2,581.975,583.2,583.88,591.433,595.0,596.383,579.72,580.233],""Train_X_std"":[11.066,11.095,11.181,11.39,11.469,11.556,11.232,11.255,11.317,11.579,11.677,11.725,11.304,11.341,11.451,11.84,11.953,12.074,11.301,11.318],""Train_X_mean"":[531.49,532.884,533.289,539.338,538.825,543.175,537.676,536.481,537.857,543.398,543.871,546.069,537.443,537.555,537.67,544.212,547.635,549.72,535.161,535.081],""Train_X_bais_max"":[[7.806,5.675,6.898,3.418,3.268,4.322,3.463,2.629,2.574,3.012,3.678,4.988,3.215,2.77,2.877,5.231,5.93,7.305,4.081,3.925]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.997,1.054,1.16,0.442,0.557,0.979,0.842,0.717,0.703,0.486,0.735,1.115,0.699,0.603,0.594,0.868,1.112,1.698,0.753,0.737]],""QCUL_95"":0.577279031,""QCUL_99"":1.01898539,""QCUL_95_line"":[3.507,3.611,3.945,1.582,1.925,3.365,2.926,2.425,2.362,1.696,2.562,3.839,2.39,2.077,2.018,3.003,3.835,5.757,2.603,2.565],""QCUL_99_line"":[4.301,4.419,4.827,1.942,2.358,4.119,3.585,2.965,2.887,2.079,3.14,4.701,2.925,2.543,2.468,3.679,4.696,7.041,3.188,3.143],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.281,0.282,0.284,0.289,0.291,0.294,0.285,0.286,0.288,0.294,0.297,0.298,0.287,0.288,0.291,0.301,0.304,0.307,0.287,0.288],""T2CUL_99_line"":[0.37,0.371,0.373,0.38,0.383,0.386,0.375,0.376,0.378,0.387,0.39,0.392,0.378,0.379,0.382,0.395,0.399,0.403,0.377,0.378],""Kesi_95"":1.554,""Kesi_99"":1.309,""Kesi_95_line"":[0.179,0.179,0.181,0.184,0.185,0.187,0.182,0.182,0.183,0.187,0.189,0.189,0.183,0.183,0.185,0.191,0.193,0.195,0.183,0.183],""Kesi_99_line"":[0.164,0.165,0.166,0.169,0.17,0.171,0.167,0.167,0.168,0.172,0.173,0.174,0.168,0.168,0.17,0.176,0.177,0.179,0.168,0.168],""COV"":[[1.0,0.996,0.993,0.992,0.988,0.982,0.997,0.995,0.993,0.988,0.982,0.977,0.997,0.994,0.992,0.981,0.976,0.966,0.997,0.992],[0.996,1.0,0.999,0.993,0.989,0.979,0.991,0.998,0.998,0.987,0.982,0.973,0.994,0.996,0.996,0.979,0.973,0.96,0.994,0.997],[0.993,0.999,1.0,0.993,0.989,0.978,0.986,0.996,0.997,0.987,0.982,0.972,0.991,0.993,0.996,0.978,0.973,0.957,0.992,0.996],[0.992,0.993,0.993,1.0,0.999,0.994,0.992,0.995,0.996,0.999,0.996,0.991,0.994,0.995,0.997,0.995,0.992,0.983,0.994,0.995],[0.988,0.989,0.989,0.999,1.0,0.997,0.99,0.993,0.994,0.999,0.998,0.995,0.991,0.993,0.995,0.997,0.995,0.987,0.991,0.993],[0.982,0.979,0.978,0.994,0.997,1.0,0.988,0.984,0.986,0.996,0.997,0.999,0.987,0.987,0.988,0.997,0.997,0.995,0.985,0.985],[0.997,0.991,0.986,0.992,0.99,0.988,1.0,0.994,0.991,0.991,0.989,0.987,0.999,0.995,0.992,0.989,0.985,0.98,0.996,0.991],[0.995,0.998,0.996,0.995,0.993,0.984,0.994,1.0,0.999,0.994,0.99,0.982,0.997,0.999,0.999,0.987,0.983,0.97,0.997,0.998],[0.993,0.998,0.997,0.996,0.994,0.986,0.991,0.999,1.0,0.995,0.991,0.983,0.995,0.998,1.0,0.988,0.984,0.971,0.995,0.999],[0.988,0.987,0.987,0.999,0.999,0.996,0.991,0.994,0.995,1.0,0.999,0.995,0.993,0.994,0.996,0.998,0.997,0.989,0.993,0.993],[0.982,0.982,0.982,0.996,0.998,0.997,0.989,0.99,0.991,0.999,1.0,0.998,0.99,0.992,0.993,0.999,0.999,0.993,0.989,0.99],[0.977,0.973,0.972,0.991,0.995,0.999,0.987,0.982,0.983,0.995,0.998,1.0,0.985,0.986,0.986,0.998,0.999,0.998,0.984,0.982],[0.997,0.994,0.991,0.994,0.991,0.987,0.999,0.997,0.995,0.993,0.99,0.985,1.0,0.998,0.996,0.989,0.985,0.977,0.999,0.995],[0.994,0.996,0.993,0.995,0.993,0.987,0.995,0.999,0.998,0.994,0.992,0.986,0.998,1.0,0.999,0.99,0.986,0.976,0.997,0.998],[0.992,0.996,0.996,0.997,0.995,0.988,0.992,0.999,1.0,0.996,0.993,0.986,0.996,0.999,1.0,0.991,0.987,0.975,0.996,0.999],[0.981,0.979,0.978,0.995,0.997,0.997,0.989,0.987,0.988,0.998,0.999,0.998,0.989,0.99,0.991,1.0,1.0,0.995,0.988,0.988],[0.976,0.973,0.973,0.992,0.995,0.997,0.985,0.983,0.984,0.997,0.999,0.999,0.985,0.986,0.987,1.0,1.0,0.997,0.984,0.984],[0.966,0.96,0.957,0.983,0.987,0.995,0.98,0.97,0.971,0.989,0.993,0.998,0.977,0.976,0.975,0.995,0.997,1.0,0.975,0.972],[0.997,0.994,0.992,0.994,0.991,0.985,0.996,0.997,0.995,0.993,0.989,0.984,0.999,0.997,0.996,0.988,0.984,0.975,1.0,0.997],[0.992,0.997,0.996,0.995,0.993,0.985,0.991,0.998,0.999,0.993,0.99,0.982,0.995,0.998,0.999,0.988,0.984,0.972,0.997,1.0]],""K"":1,""R"":0.991,""featValue"":[19.819,0.131,0.027,0.013,0.005,0.004,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.223,0.235,0.381,0.389,0.155,0.012,0.115,0.017,0.164,-0.453,0.091,0.091,-0.123,-0.079,-0.423,0.034,-0.026,-0.33,0.035,0.027],[0.223,0.314,-0.064,0.161,-0.26,0.075,0.008,0.138,0.131,-0.257,0.114,-0.517,0.126,0.185,0.206,-0.288,0.289,0.281,-0.103,0.133],[0.223,0.308,-0.291,0.307,-0.034,-0.106,0.234,-0.251,-0.092,0.132,-0.125,0.107,0.212,-0.033,0.191,-0.243,-0.517,-0.123,-0.154,-0.214],[0.224,-0.002,-0.18,0.314,0.259,0.017,0.053,0.224,-0.166,0.184,0.244,-0.055,-0.123,0.253,0.373,0.36,0.076,-0.229,0.396,0.11],[0.224,-0.088,-0.227,0.281,0.114,-0.014,-0.21,0.158,0.392,0.174,0.103,0.071,-0.141,-0.287,-0.213,0.09,-0.112,0.557,0.098,-0.201],[0.223,-0.251,0.004,0.387,-0.379,-0.139,-0.102,-0.011,-0.049,0.375,-0.398,0.012,0.0,0.053,-0.213,0.035,0.342,-0.203,-0.193,0.135],[0.224,0.063,0.539,0.042,-0.072,0.279,0.003,0.128,-0.426,0.251,0.183,0.096,0.243,-0.38,0.138,-0.027,0.043,0.183,-0.012,-0.089],[0.224,0.189,-0.062,-0.202,-0.019,0.295,-0.368,0.266,0.065,-0.221,-0.568,-0.037,0.126,-0.092,0.142,0.324,-0.15,-0.134,0.024,-0.09],[0.224,0.17,-0.216,-0.112,-0.114,0.198,0.028,-0.191,-0.28,-0.155,-0.148,0.417,-0.471,0.008,-0.003,-0.274,0.283,0.148,0.275,-0.021],[0.224,-0.102,-0.144,-0.032,0.366,0.206,-0.137,0.045,-0.169,-0.047,0.127,0.158,-0.088,0.148,-0.043,-0.005,-0.092,0.092,-0.652,0.417],[0.224,-0.2,-0.162,-0.094,0.084,0.145,-0.225,-0.34,-0.029,-0.075,0.289,-0.23,0.0,-0.079,-0.005,0.037,0.263,-0.295,-0.19,-0.581],[0.223,-0.32,0.046,0.024,-0.203,-0.022,-0.4,-0.37,-0.084,-0.214,0.147,0.01,0.284,0.146,-0.066,-0.051,-0.307,0.071,0.366,0.299],[0.224,0.122,0.336,-0.169,0.117,0.14,0.069,-0.302,0.534,0.279,-0.047,0.261,0.11,0.405,0.175,0.041,0.129,0.066,-0.004,-0.036],[0.224,0.128,0.048,-0.34,-0.317,0.107,-0.035,0.188,0.079,0.348,0.232,-0.236,-0.401,0.072,-0.227,-0.119,-0.366,-0.243,0.025,0.062],[0.224,0.12,-0.19,-0.227,-0.159,-0.015,0.471,-0.278,-0.072,-0.032,0.043,-0.122,0.133,-0.159,-0.237,0.58,0.068,0.17,-0.017,0.175],[0.224,-0.239,-0.04,-0.149,0.291,0.06,0.289,0.283,-0.188,0.02,-0.199,-0.123,0.286,0.354,-0.4,-0.245,-0.008,0.101,0.185,-0.235],[0.223,-0.31,-0.096,-0.143,0.19,0.062,0.25,0.009,0.305,0.004,-0.091,-0.084,0.052,-0.517,0.219,-0.323,0.087,-0.246,0.133,0.324],[0.221,-0.458,0.205,-0.014,-0.279,-0.187,0.286,0.166,0.031,-0.329,-0.029,0.097,-0.274,0.115,0.339,0.124,-0.194,0.13,-0.185,-0.222],[0.224,0.144,0.259,-0.143,0.363,-0.581,-0.175,-0.21,-0.187,0.07,-0.238,-0.325,-0.251,-0.073,0.07,-0.014,-0.004,0.143,0.015,0.026],[0.224,0.171,-0.143,-0.277,-0.111,-0.533,-0.149,0.33,0.042,-0.061,0.268,0.407,0.302,-0.04,-0.019,-0.041,0.192,-0.139,-0.044,-0.019]],""selectVec"":[[0.223],[0.223],[0.223],[0.224],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.221],[0.224],[0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8543,""AfterCleanSamNum"":5952,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.1%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":437,""version"":""v-2025-12-03 14:50:30"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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