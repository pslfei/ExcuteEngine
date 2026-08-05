using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA432")]
    [FCDisplay("PCA432")]
    public partial class PCA432 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁96号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁97号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁97号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁97号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁97号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁97号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁97号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁98号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁98号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁98号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁98号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁98号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁98号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁99号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁99号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁99号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁99号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁99号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁99号屏6号管壁温")]
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

		public PCA432()
		{
			ModelID = 473;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA432";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""473"",""name"":""PCA432"",""description"":""中温分隔屏过热器水冷壁23-81-99"",""founder"":""admin"",""creatTime"":""2025-12-09 10:43:51"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:46:06"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 12:19:30"",""duration"":2407522,""number"":8026,""filter"":2617,""mode"":5409,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2527}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah23ct181k"",""Description"":""中温（分隔屏）过热器水冷壁96号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""578.01"",""TMin"":""491.97"",""TAvg"":""539.72"",""DMax"":""19.97"",""DMin"":""0.00"",""DAvg"":""2.35"",""C95"":""8.58"",""C99"":""10.56""},{""PointId"":""d1_10hah23ct182k"",""Description"":""中温（分隔屏）过热器水冷壁97号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""575.01"",""TMin"":""488.28"",""TAvg"":""535.83"",""DMax"":""4.45"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.39"",""C99"":""2.94""},{""PointId"":""d1_10hah23ct183k"",""Description"":""中温（分隔屏）过热器水冷壁97号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""575.80"",""TMin"":""487.58"",""TAvg"":""535.85"",""DMax"":""4.43"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""2.01"",""C99"":""2.46""},{""PointId"":""d1_10hah23ct184k"",""Description"":""中温（分隔屏）过热器水冷壁97号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""575.02"",""TMin"":""485.65"",""TAvg"":""534.02"",""DMax"":""4.77"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.36"",""C99"":""2.90""},{""PointId"":""d1_10hah23ct185k"",""Description"":""中温（分隔屏）过热器水冷壁97号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""578.81"",""TMin"":""489.14"",""TAvg"":""538.63"",""DMax"":""5.42"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.95"",""C99"":""2.40""},{""PointId"":""d1_10hah23ct186k"",""Description"":""中温（分隔屏）过热器水冷壁97号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""582.73"",""TMin"":""492.69"",""TAvg"":""542.43"",""DMax"":""5.35"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.82"",""C99"":""3.45""},{""PointId"":""d1_10hah23ct187k"",""Description"":""中温（分隔屏）过热器水冷壁97号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""582.48"",""TMin"":""493.41"",""TAvg"":""543.19"",""DMax"":""7.85"",""DMin"":""0.00"",""DAvg"":""1.31"",""C95"":""4.47"",""C99"":""5.47""},{""PointId"":""d1_10hah23ct188k"",""Description"":""中温（分隔屏）过热器水冷壁98号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""576.13"",""TMin"":""488.63"",""TAvg"":""535.43"",""DMax"":""5.31"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.63"",""C99"":""3.23""},{""PointId"":""d1_10hah23ct189k"",""Description"":""中温（分隔屏）过热器水冷壁98号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""576.84"",""TMin"":""487.09"",""TAvg"":""534.43"",""DMax"":""2.92"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.98"",""C99"":""2.42""},{""PointId"":""d1_10hah23ct190k"",""Description"":""中温（分隔屏）过热器水冷壁98号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""580.96"",""TMin"":""489.77"",""TAvg"":""537.29"",""DMax"":""2.98"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.06"",""C99"":""2.53""},{""PointId"":""d1_10hah23ct191k"",""Description"":""中温（分隔屏）过热器水冷壁98号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""584.44"",""TMin"":""492.27"",""TAvg"":""541.57"",""DMax"":""2.45"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.74"",""C99"":""2.13""},{""PointId"":""d1_10hah23ct192k"",""Description"":""中温（分隔屏）过热器水冷壁98号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""584.26"",""TMin"":""492.52"",""TAvg"":""541.62"",""DMax"":""3.10"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.35"",""C99"":""2.87""},{""PointId"":""d1_10hah23ct193k"",""Description"":""中温（分隔屏）过热器水冷壁98号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""585.85"",""TMin"":""494.98"",""TAvg"":""544.48"",""DMax"":""5.46"",""DMin"":""0.00"",""DAvg"":""1.17"",""C95"":""3.96"",""C99"":""4.84""},{""PointId"":""d1_10hah23ct194k"",""Description"":""中温（分隔屏）过热器水冷壁99号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""575.95"",""TMin"":""487.69"",""TAvg"":""534.03"",""DMax"":""6.84"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.23"",""C99"":""3.96""},{""PointId"":""d1_10hah23ct195k"",""Description"":""中温（分隔屏）过热器水冷壁99号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""578.61"",""TMin"":""487.98"",""TAvg"":""535.01"",""DMax"":""5.75"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.28"",""C99"":""4.02""},{""PointId"":""d1_10hah23ct196k"",""Description"":""中温（分隔屏）过热器水冷壁99号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""577.84"",""TMin"":""486.49"",""TAvg"":""533.21"",""DMax"":""6.87"",""DMin"":""0.00"",""DAvg"":""1.18"",""C95"":""4.07"",""C99"":""4.99""},{""PointId"":""d1_10hah23ct197k"",""Description"":""中温（分隔屏）过热器水冷壁99号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""580.99"",""TMin"":""489.25"",""TAvg"":""537.20"",""DMax"":""6.10"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.54"",""C99"":""3.13""},{""PointId"":""d1_10hah23ct198k"",""Description"":""中温（分隔屏）过热器水冷壁99号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""582.03"",""TMin"":""490.46"",""TAvg"":""538.32"",""DMax"":""5.56"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.19"",""C99"":""2.69""},{""PointId"":""d1_10hah23ct199k"",""Description"":""中温（分隔屏）过热器水冷壁99号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""584.97"",""TMin"":""492.87"",""TAvg"":""541.14"",""DMax"":""7.30"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.99"",""C99"":""3.67""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:46:06"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[491.972,488.276,487.579,485.646,489.138,492.689,493.408,488.628,487.086,489.768,492.273,492.517,494.98,487.693,487.979,486.49,489.25,490.463,492.871],""Train_X_max"":[578.008,575.014,575.801,575.024,578.809,582.734,582.477,576.131,576.839,580.961,584.438,584.263,585.85,575.948,578.613,577.835,580.986,582.03,584.974],""Train_X_std"":[10.274,10.35,10.344,10.374,10.261,10.234,10.114,10.505,10.454,10.469,10.46,10.329,10.232,10.525,10.572,10.602,10.526,10.356,10.386],""Train_X_mean"":[539.722,535.825,535.85,534.017,538.626,542.427,543.194,535.429,534.429,537.289,541.565,541.62,544.478,534.029,535.006,533.212,537.203,538.319,541.144],""Train_X_bais_max"":[[19.966,4.446,4.426,4.766,5.416,5.346,7.847,5.311,2.919,2.984,2.451,3.102,5.457,6.835,5.749,6.871,6.097,5.555,7.3]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[2.352,0.678,0.569,0.669,0.53,0.802,1.312,0.757,0.582,0.595,0.498,0.692,1.173,0.918,0.945,1.177,0.685,0.586,0.838]],""QCUL_95"":0.8172705,""QCUL_99"":1.37696576,""QCUL_95_line"":[8.584,2.393,2.006,2.363,1.95,2.815,4.471,2.634,1.979,2.062,1.735,2.349,3.956,3.23,3.282,4.07,2.544,2.187,2.986],""QCUL_99_line"":[10.556,2.935,2.461,2.899,2.399,3.452,5.471,3.227,2.421,2.526,2.127,2.874,4.837,3.962,4.021,4.986,3.132,2.694,3.666],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.274,0.276,0.276,0.277,0.274,0.273,0.27,0.28,0.279,0.279,0.279,0.276,0.273,0.281,0.282,0.283,0.281,0.276,0.277],""T2CUL_99_line"":[0.36,0.363,0.363,0.364,0.36,0.359,0.355,0.368,0.367,0.367,0.367,0.362,0.359,0.369,0.371,0.372,0.369,0.363,0.364],""Kesi_95"":1.559,""Kesi_99"":1.329,""Kesi_95_line"":[0.175,0.176,0.176,0.176,0.174,0.174,0.172,0.178,0.178,0.178,0.178,0.175,0.174,0.179,0.18,0.18,0.179,0.176,0.176],""Kesi_99_line"":[0.161,0.162,0.162,0.163,0.161,0.161,0.159,0.165,0.164,0.164,0.164,0.162,0.161,0.165,0.166,0.166,0.165,0.162,0.163],""COV"":[[1.0,0.955,0.958,0.956,0.966,0.97,0.97,0.936,0.937,0.935,0.94,0.943,0.947,0.919,0.919,0.91,0.924,0.93,0.93],[0.955,1.0,0.999,0.997,0.996,0.992,0.982,0.998,0.995,0.993,0.992,0.989,0.982,0.993,0.989,0.985,0.989,0.989,0.984],[0.958,0.999,1.0,0.999,0.997,0.993,0.983,0.996,0.997,0.995,0.993,0.99,0.982,0.992,0.991,0.987,0.99,0.99,0.985],[0.956,0.997,0.999,1.0,0.996,0.991,0.979,0.994,0.997,0.996,0.992,0.988,0.979,0.991,0.992,0.989,0.991,0.99,0.984],[0.966,0.996,0.997,0.996,1.0,0.999,0.992,0.991,0.992,0.992,0.995,0.994,0.99,0.986,0.985,0.981,0.989,0.991,0.989],[0.97,0.992,0.993,0.991,0.999,1.0,0.997,0.985,0.987,0.986,0.993,0.994,0.994,0.979,0.978,0.973,0.984,0.988,0.989],[0.97,0.982,0.983,0.979,0.992,0.997,1.0,0.974,0.975,0.975,0.986,0.99,0.996,0.966,0.965,0.957,0.973,0.98,0.985],[0.936,0.998,0.996,0.994,0.991,0.985,0.974,1.0,0.998,0.995,0.993,0.989,0.979,0.998,0.995,0.992,0.994,0.992,0.987],[0.937,0.995,0.997,0.997,0.992,0.987,0.975,0.998,1.0,0.999,0.995,0.992,0.981,0.997,0.998,0.996,0.997,0.996,0.991],[0.935,0.993,0.995,0.996,0.992,0.986,0.975,0.995,0.999,1.0,0.996,0.993,0.982,0.996,0.998,0.997,0.998,0.997,0.992],[0.94,0.992,0.993,0.992,0.995,0.993,0.986,0.993,0.995,0.996,1.0,0.999,0.992,0.992,0.992,0.989,0.996,0.998,0.995],[0.943,0.989,0.99,0.988,0.994,0.994,0.99,0.989,0.992,0.993,0.999,1.0,0.995,0.987,0.988,0.984,0.993,0.997,0.996],[0.947,0.982,0.982,0.979,0.99,0.994,0.996,0.979,0.981,0.982,0.992,0.995,1.0,0.975,0.974,0.969,0.983,0.989,0.994],[0.919,0.993,0.992,0.991,0.986,0.979,0.966,0.998,0.997,0.996,0.992,0.987,0.975,1.0,0.998,0.997,0.997,0.994,0.988],[0.919,0.989,0.991,0.992,0.985,0.978,0.965,0.995,0.998,0.998,0.992,0.988,0.974,0.998,1.0,0.999,0.998,0.995,0.989],[0.91,0.985,0.987,0.989,0.981,0.973,0.957,0.992,0.996,0.997,0.989,0.984,0.969,0.997,0.999,1.0,0.997,0.994,0.987],[0.924,0.989,0.99,0.991,0.989,0.984,0.973,0.994,0.997,0.998,0.996,0.993,0.983,0.997,0.998,0.997,1.0,0.999,0.996],[0.93,0.989,0.99,0.99,0.991,0.988,0.98,0.992,0.996,0.997,0.998,0.997,0.989,0.994,0.995,0.994,0.999,1.0,0.998],[0.93,0.984,0.985,0.984,0.989,0.989,0.985,0.987,0.991,0.992,0.995,0.996,0.994,0.988,0.989,0.987,0.996,0.998,1.0]],""K"":1,""R"":0.986,""featValue"":[18.73,0.174,0.067,0.015,0.006,0.004,0.003,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.22,-0.697,0.348,0.363,-0.3,0.258,-0.19,0.117,0.004,-0.044,-0.036,0.025,0.008,-0.017,-0.032,0.015,0.01,0.006,-0.018],[0.23,-0.035,0.226,-0.459,-0.105,0.032,0.073,0.081,0.218,0.488,0.137,-0.331,0.407,-0.032,-0.083,-0.041,0.029,0.129,-0.228],[0.231,-0.041,0.243,-0.132,0.137,-0.22,0.006,-0.31,-0.13,-0.063,-0.386,0.087,0.27,0.036,0.105,0.502,-0.178,-0.399,0.024],[0.23,-0.017,0.28,0.073,0.358,-0.366,0.175,0.282,-0.076,0.019,-0.202,-0.1,-0.298,0.11,-0.485,0.033,0.045,0.292,0.092],[0.231,-0.145,0.042,-0.036,0.253,-0.001,0.464,0.036,0.109,-0.444,0.112,-0.107,0.22,-0.118,0.265,-0.236,0.434,-0.121,0.13],[0.23,-0.222,-0.104,-0.04,0.154,0.048,0.319,-0.456,0.006,0.158,0.169,0.21,-0.221,-0.34,-0.147,-0.266,-0.439,-0.013,-0.046],[0.228,-0.322,-0.309,-0.174,0.011,-0.261,-0.01,0.062,-0.406,0.238,0.247,-0.036,-0.219,0.363,0.405,0.087,0.067,0.058,0.059],[0.23,0.115,0.182,-0.456,-0.214,0.217,-0.071,0.023,0.265,-0.104,-0.138,0.192,-0.364,0.351,0.001,-0.238,-0.033,-0.205,0.319],[0.231,0.124,0.134,0.032,-0.038,-0.235,-0.294,-0.416,0.101,-0.227,0.174,0.218,-0.06,0.18,-0.035,-0.089,0.298,0.199,-0.532],[0.23,0.136,0.077,0.21,0.132,-0.209,-0.276,0.043,0.514,0.125,0.156,-0.064,-0.159,-0.294,0.41,0.188,-0.105,0.143,0.29],[0.231,0.043,-0.155,-0.049,0.367,0.367,-0.222,0.202,0.012,-0.176,0.42,-0.158,-0.106,0.032,-0.263,0.299,-0.075,-0.341,-0.184],[0.23,-0.01,-0.274,-0.024,0.345,0.377,-0.261,-0.091,-0.077,0.235,-0.315,0.314,0.224,-0.055,-0.056,-0.031,0.309,0.282,0.205],[0.229,-0.141,-0.466,-0.136,-0.14,-0.348,-0.23,0.341,0.139,-0.282,-0.239,0.059,0.219,-0.148,-0.107,-0.228,-0.263,-0.045,-0.136],[0.23,0.233,0.133,-0.257,-0.291,0.153,0.037,0.168,-0.426,-0.205,-0.021,0.059,-0.196,-0.524,0.13,0.204,0.04,0.252,-0.084],[0.23,0.248,0.12,0.176,-0.114,-0.104,-0.28,-0.189,-0.391,-0.053,0.244,-0.261,0.276,0.018,-0.171,-0.332,-0.101,-0.078,0.433],[0.229,0.305,0.133,0.335,0.029,-0.011,0.118,0.356,-0.122,0.358,-0.049,0.324,0.012,0.001,0.179,-0.263,0.026,-0.391,-0.277],[0.23,0.192,-0.07,0.205,-0.13,0.184,0.345,0.08,0.085,-0.176,0.136,0.195,0.291,0.403,0.049,0.214,-0.374,0.395,0.033],[0.23,0.13,-0.18,0.208,-0.016,0.235,0.051,-0.192,0.006,-0.012,-0.447,-0.62,-0.224,0.111,0.187,-0.117,-0.078,0.034,-0.238],[0.23,0.072,-0.35,0.179,-0.458,-0.109,0.238,-0.128,0.163,0.169,0.037,-0.002,-0.082,-0.078,-0.348,0.297,0.387,-0.201,0.156]],""selectVec"":[[0.22],[0.23],[0.231],[0.23],[0.231],[0.23],[0.228],[0.23],[0.231],[0.23],[0.231],[0.23],[0.229],[0.23],[0.23],[0.229],[0.23],[0.23],[0.23]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8026,""AfterCleanSamNum"":5402,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.6%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":473,""version"":""v-2025-12-09 10:46:06"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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