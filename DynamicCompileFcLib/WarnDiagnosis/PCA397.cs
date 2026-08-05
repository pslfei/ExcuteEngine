using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA397")]
    [FCDisplay("PCA397")]
    public partial class PCA397 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁14号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁14号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁14号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁14号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁15号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁15号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁15号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁15号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁15号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁15号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁16号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁16号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁16号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁16号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁16号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁16号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁17号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁17号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁17号屏3号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[19] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[19] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[19] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA397()
		{
			ModelID = 438;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA397";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""438"",""name"":""PCA397"",""description"":""中温分隔屏过热器水冷壁81-99"",""founder"":""admin"",""creatTime"":""2025-12-03 14:51:53"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:53:30"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 16:44:32"",""et"":""2025-12-03 05:40:06"",""duration"":2552134,""number"":8508,""filter"":2588,""mode"":5920,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2498}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah17ct181k"",""Description"":""中温（分隔屏）过热器水冷壁14号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""582.44"",""TMin"":""482.27"",""TAvg"":""536.75"",""DMax"":""5.14"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.59"",""C99"":""3.18""},{""PointId"":""d1_10hah17ct182k"",""Description"":""中温（分隔屏）过热器水冷壁14号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""588.52"",""TMin"":""487.37"",""TAvg"":""542.33"",""DMax"":""4.39"",""DMin"":""0.00"",""DAvg"":""1.12"",""C95"":""3.85"",""C99"":""4.71""},{""PointId"":""d1_10hah17ct183k"",""Description"":""中温（分隔屏）过热器水冷壁14号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""588.84"",""TMin"":""486.77"",""TAvg"":""542.40"",""DMax"":""4.81"",""DMin"":""0.00"",""DAvg"":""1.31"",""C95"":""4.49"",""C99"":""5.50""},{""PointId"":""d1_10hah17ct184k"",""Description"":""中温（分隔屏）过热器水冷壁14号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""592.50"",""TMin"":""489.55"",""TAvg"":""545.90"",""DMax"":""6.02"",""DMin"":""0.00"",""DAvg"":""1.80"",""C95"":""6.08"",""C99"":""7.44""},{""PointId"":""d1_10hah17ct185k"",""Description"":""中温（分隔屏）过热器水冷壁15号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""580.66"",""TMin"":""485.88"",""TAvg"":""536.15"",""DMax"":""5.18"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.83"",""C99"":""3.47""},{""PointId"":""d1_10hah17ct186k"",""Description"":""中温（分隔屏）过热器水冷壁15号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""580.25"",""TMin"":""482.92"",""TAvg"":""535.10"",""DMax"":""4.67"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.90"",""C99"":""3.55""},{""PointId"":""d1_10hah17ct187k"",""Description"":""中温（分隔屏）过热器水冷壁15号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""580.64"",""TMin"":""481.50"",""TAvg"":""535.04"",""DMax"":""5.54"",""DMin"":""0.00"",""DAvg"":""0.94"",""C95"":""3.22"",""C99"":""3.94""},{""PointId"":""d1_10hah17ct188k"",""Description"":""中温（分隔屏）过热器水冷壁15号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""590.55"",""TMin"":""489.65"",""TAvg"":""543.78"",""DMax"":""2.77"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.97"",""C99"":""2.42""},{""PointId"":""d1_10hah17ct189k"",""Description"":""中温（分隔屏）过热器水冷壁15号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""590.42"",""TMin"":""489.08"",""TAvg"":""543.70"",""DMax"":""3.65"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.95"",""C99"":""3.61""},{""PointId"":""d1_10hah17ct190k"",""Description"":""中温（分隔屏）过热器水冷壁15号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""592.95"",""TMin"":""491.57"",""TAvg"":""546.66"",""DMax"":""5.28"",""DMin"":""0.00"",""DAvg"":""1.20"",""C95"":""4.11"",""C99"":""5.03""},{""PointId"":""d1_10hah17ct191k"",""Description"":""中温（分隔屏）过热器水冷壁16号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""584.78"",""TMin"":""488.77"",""TAvg"":""538.30"",""DMax"":""6.07"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.61"",""C99"":""4.42""},{""PointId"":""d1_10hah17ct192k"",""Description"":""中温（分隔屏）过热器水冷壁16号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""586.82"",""TMin"":""488.68"",""TAvg"":""539.61"",""DMax"":""3.95"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.65"",""C99"":""4.46""},{""PointId"":""d1_10hah17ct193k"",""Description"":""中温（分隔屏）过热器水冷壁16号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""586.86"",""TMin"":""487.85"",""TAvg"":""539.69"",""DMax"":""3.84"",""DMin"":""0.00"",""DAvg"":""1.21"",""C95"":""4.01"",""C99"":""4.90""},{""PointId"":""d1_10hah17ct194k"",""Description"":""中温（分隔屏）过热器水冷壁16号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""594.98"",""TMin"":""494.67"",""TAvg"":""546.88"",""DMax"":""4.02"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.29"",""C99"":""2.80""},{""PointId"":""d1_10hah17ct195k"",""Description"":""中温（分隔屏）过热器水冷壁16号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""597.42"",""TMin"":""495.45"",""TAvg"":""548.82"",""DMax"":""5.03"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""3.03"",""C99"":""3.72""},{""PointId"":""d1_10hah17ct196k"",""Description"":""中温（分隔屏）过热器水冷壁16号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""599.08"",""TMin"":""497.78"",""TAvg"":""551.47"",""DMax"":""6.91"",""DMin"":""0.00"",""DAvg"":""1.17"",""C95"":""4.03"",""C99"":""4.93""},{""PointId"":""d1_10hah17ct197k"",""Description"":""中温（分隔屏）过热器水冷壁17号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""585.60"",""TMin"":""489.20"",""TAvg"":""538.95"",""DMax"":""5.20"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.10"",""C99"":""3.79""},{""PointId"":""d1_10hah17ct198k"",""Description"":""中温（分隔屏）过热器水冷壁17号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""587.64"",""TMin"":""488.93"",""TAvg"":""539.88"",""DMax"":""3.99"",""DMin"":""0.00"",""DAvg"":""0.97"",""C95"":""3.28"",""C99"":""4.02""},{""PointId"":""d1_10hah17ct199k"",""Description"":""中温（分隔屏）过热器水冷壁17号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""588.60"",""TMin"":""488.35"",""TAvg"":""540.48"",""DMax"":""3.85"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.30"",""C99"":""4.03""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:53:30"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[482.267,487.367,486.767,489.55,485.883,482.917,481.5,489.65,489.083,491.567,488.767,488.683,487.85,494.667,495.45,497.783,489.2,488.933,488.35],""Train_X_max"":[582.44,588.52,588.84,592.5,580.66,580.25,580.64,590.55,590.417,592.95,584.783,586.817,586.86,594.983,597.417,599.083,585.6,587.64,588.6],""Train_X_std"":[11.414,11.728,11.863,11.979,11.182,11.299,11.321,11.612,11.717,11.705,11.481,11.573,11.63,11.81,11.949,11.951,11.538,11.688,11.75],""Train_X_mean"":[536.748,542.331,542.395,545.898,536.145,535.104,535.035,543.777,543.696,546.661,538.299,539.611,539.688,546.881,548.817,551.465,538.951,539.878,540.475],""Train_X_bais_max"":[[5.135,4.394,4.811,6.023,5.181,4.666,5.541,2.767,3.653,5.278,6.072,3.95,3.836,4.016,5.034,6.906,5.203,3.988,3.854]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.734,1.122,1.308,1.797,0.82,0.85,0.94,0.573,0.863,1.199,1.043,1.086,1.205,0.654,0.864,1.169,0.891,0.97,0.988]],""QCUL_95"":0.725837,""QCUL_99"":1.28807461,""QCUL_95_line"":[2.591,3.846,4.492,6.083,2.83,2.903,3.216,1.973,2.951,4.11,3.611,3.651,4.008,2.285,3.031,4.025,3.096,3.283,3.297],""QCUL_99_line"":[3.178,4.707,5.499,7.438,3.465,3.553,3.935,2.416,3.612,5.03,4.424,4.462,4.895,2.802,3.717,4.928,3.793,4.015,4.027],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.291,0.299,0.302,0.305,0.285,0.288,0.288,0.296,0.299,0.298,0.293,0.295,0.296,0.301,0.304,0.305,0.294,0.298,0.299],""T2CUL_99_line"":[0.382,0.393,0.397,0.401,0.375,0.378,0.379,0.389,0.392,0.392,0.385,0.388,0.389,0.396,0.4,0.4,0.386,0.391,0.394],""Kesi_95"":1.555,""Kesi_99"":1.311,""Kesi_95_line"":[0.185,0.19,0.192,0.194,0.181,0.183,0.183,0.188,0.19,0.19,0.186,0.188,0.188,0.191,0.194,0.194,0.187,0.189,0.19],""Kesi_99_line"":[0.17,0.175,0.177,0.178,0.166,0.168,0.168,0.173,0.174,0.174,0.171,0.172,0.173,0.176,0.178,0.178,0.172,0.174,0.175],""COV"":[[1.0,0.99,0.987,0.978,0.995,0.997,0.998,0.994,0.991,0.985,0.99,0.991,0.991,0.99,0.986,0.981,0.992,0.993,0.994],[0.99,1.0,0.999,0.997,0.983,0.981,0.981,0.996,0.998,0.997,0.976,0.975,0.972,0.989,0.992,0.992,0.98,0.979,0.979],[0.987,0.999,1.0,0.998,0.979,0.977,0.977,0.995,0.997,0.997,0.972,0.97,0.968,0.987,0.991,0.992,0.977,0.974,0.974],[0.978,0.997,0.998,1.0,0.97,0.965,0.965,0.989,0.993,0.996,0.961,0.959,0.955,0.979,0.986,0.99,0.967,0.963,0.962],[0.995,0.983,0.979,0.97,1.0,0.998,0.996,0.99,0.985,0.98,0.998,0.996,0.994,0.99,0.985,0.98,0.998,0.997,0.995],[0.997,0.981,0.977,0.965,0.998,1.0,0.999,0.99,0.985,0.978,0.996,0.998,0.997,0.991,0.985,0.978,0.996,0.998,0.998],[0.998,0.981,0.977,0.965,0.996,0.999,1.0,0.991,0.985,0.978,0.993,0.995,0.997,0.989,0.984,0.977,0.993,0.995,0.997],[0.994,0.996,0.995,0.989,0.99,0.99,0.991,1.0,0.999,0.997,0.986,0.986,0.986,0.997,0.997,0.995,0.989,0.988,0.989],[0.991,0.998,0.997,0.993,0.985,0.985,0.985,0.999,1.0,0.999,0.98,0.98,0.979,0.995,0.997,0.997,0.984,0.983,0.984],[0.985,0.997,0.997,0.996,0.98,0.978,0.978,0.997,0.999,1.0,0.974,0.973,0.971,0.991,0.995,0.997,0.978,0.975,0.976],[0.99,0.976,0.972,0.961,0.998,0.996,0.993,0.986,0.98,0.974,1.0,0.997,0.995,0.991,0.985,0.979,0.999,0.997,0.995],[0.991,0.975,0.97,0.959,0.996,0.998,0.995,0.986,0.98,0.973,0.997,1.0,0.999,0.991,0.985,0.978,0.996,0.999,0.998],[0.991,0.972,0.968,0.955,0.994,0.997,0.997,0.986,0.979,0.971,0.995,0.999,1.0,0.991,0.984,0.975,0.994,0.998,0.999],[0.99,0.989,0.987,0.979,0.99,0.991,0.989,0.997,0.995,0.991,0.991,0.991,0.991,1.0,0.998,0.995,0.992,0.992,0.993],[0.986,0.992,0.991,0.986,0.985,0.985,0.984,0.997,0.997,0.995,0.985,0.985,0.984,0.998,1.0,0.999,0.987,0.986,0.986],[0.981,0.992,0.992,0.99,0.98,0.978,0.977,0.995,0.997,0.997,0.979,0.978,0.975,0.995,0.999,1.0,0.982,0.979,0.979],[0.992,0.98,0.977,0.967,0.998,0.996,0.993,0.989,0.984,0.978,0.999,0.996,0.994,0.992,0.987,0.982,1.0,0.998,0.996],[0.993,0.979,0.974,0.963,0.997,0.998,0.995,0.988,0.983,0.975,0.997,0.999,0.998,0.992,0.986,0.979,0.998,1.0,0.999],[0.994,0.979,0.974,0.962,0.995,0.998,0.997,0.989,0.984,0.976,0.995,0.998,0.999,0.993,0.986,0.979,0.996,0.999,1.0]],""K"":1,""R"":0.988,""featValue"":[18.775,0.168,0.03,0.015,0.006,0.003,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.23,0.059,0.439,-0.132,-0.027,0.004,-0.174,0.071,-0.072,0.217,0.234,0.367,0.097,-0.291,-0.333,-0.086,-0.478,-0.119,0.007],[0.229,-0.26,0.251,0.046,-0.278,0.016,0.215,-0.223,-0.438,0.137,-0.048,0.216,0.007,-0.049,0.493,0.104,0.067,0.277,-0.21],[0.229,-0.313,0.212,0.054,-0.313,0.177,-0.127,-0.231,0.202,-0.18,-0.328,0.134,0.091,0.3,-0.337,-0.037,0.179,0.071,0.393],[0.227,-0.426,0.186,0.262,-0.104,-0.361,-0.338,0.118,0.012,-0.055,0.222,-0.517,-0.117,-0.013,0.001,0.021,0.006,-0.178,-0.169],[0.23,0.162,0.17,0.369,0.357,0.092,0.206,0.058,-0.221,0.234,-0.378,-0.138,-0.477,0.148,-0.22,-0.067,-0.081,0.026,-0.016],[0.23,0.2,0.173,-0.089,0.196,-0.089,0.186,-0.506,0.395,0.265,0.301,-0.142,0.085,0.332,0.121,0.238,-0.028,-0.079,0.002],[0.23,0.186,0.282,-0.324,0.286,0.019,-0.204,0.24,-0.21,-0.16,0.177,0.137,-0.051,0.162,0.048,-0.069,0.619,-0.091,-0.005],[0.23,-0.119,-0.006,-0.19,0.234,0.209,0.319,0.042,-0.28,-0.328,0.181,-0.431,0.277,-0.083,-0.062,-0.028,-0.225,0.226,0.317],[0.23,-0.208,-0.004,-0.186,0.106,0.237,0.247,0.006,0.319,-0.306,-0.191,0.057,0.013,-0.036,-0.013,-0.229,-0.076,-0.223,-0.629],[0.229,-0.298,-0.054,-0.077,0.343,-0.163,0.038,0.208,0.381,0.149,-0.214,0.164,-0.09,-0.41,0.298,0.152,0.063,0.044,0.355],[0.229,0.233,-0.119,0.438,0.205,0.105,-0.293,-0.216,-0.003,-0.148,-0.075,0.038,0.389,-0.346,-0.13,0.257,0.18,0.194,-0.222],[0.229,0.255,-0.103,-0.025,-0.078,-0.653,0.174,-0.085,-0.198,-0.252,-0.316,0.093,0.215,0.041,0.034,-0.078,-0.097,-0.338,0.104],[0.229,0.28,-0.095,-0.286,-0.091,-0.1,-0.413,-0.126,0.135,-0.108,-0.132,-0.135,-0.271,0.016,0.183,-0.296,-0.232,0.508,-0.045],[0.23,-0.016,-0.362,-0.148,-0.129,0.27,-0.108,-0.371,-0.199,0.277,0.029,-0.155,-0.145,-0.313,-0.002,-0.239,0.177,-0.43,0.144],[0.23,-0.135,-0.415,-0.097,0.018,0.018,-0.086,-0.005,-0.152,-0.241,0.195,0.284,-0.38,0.198,-0.142,0.545,-0.192,-0.041,-0.034],[0.229,-0.232,-0.424,0.037,0.121,-0.161,0.01,0.187,-0.049,0.423,0.118,0.149,0.324,0.326,-0.176,-0.321,0.056,0.239,-0.119],[0.23,0.182,-0.064,0.465,-0.1,0.295,-0.05,0.24,0.122,-0.166,0.226,0.162,0.035,0.199,0.449,-0.232,-0.181,-0.209,0.212],[0.23,0.224,-0.05,0.108,-0.416,-0.132,0.446,0.16,0.223,-0.047,0.298,-0.005,-0.229,-0.273,-0.26,-0.044,0.288,0.22,0.0],[0.23,0.22,-0.016,-0.222,-0.334,0.209,-0.053,0.436,0.034,0.289,-0.302,-0.28,0.229,0.093,0.05,0.407,-0.043,-0.096,-0.086]],""selectVec"":[[0.23],[0.229],[0.229],[0.227],[0.23],[0.23],[0.23],[0.23],[0.23],[0.229],[0.229],[0.229],[0.229],[0.23],[0.23],[0.229],[0.23],[0.23],[0.23]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8508,""AfterCleanSamNum"":5920,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":438,""version"":""v-2025-12-03 14:53:30"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[19] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18,IN19};
			float[] arrOUT_B = new float[19] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18,OUT_B19};
			LD[] arrOUT_W = new LD[19] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18,OUT_W19 };
			
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