using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA394")]
    [FCDisplay("PCA394")]
    public partial class PCA394 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁4号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁4号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁4号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁4号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁5号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁5号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁5号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁5号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁5号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁5号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁6号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁6号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁6号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁6号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁6号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁6号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁7号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁7号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁7号屏3号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁7号屏4号管壁温")]
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

		public PCA394()
		{
			ModelID = 434;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA394";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""434"",""name"":""PCA394"",""description"":""中温分隔屏过热器水冷壁21-40"",""founder"":""admin"",""creatTime"":""2025-12-03 14:31:03"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:35:19"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 15:15:16"",""et"":""2025-12-03 06:24:44"",""duration"":2560168,""number"":8534,""filter"":2590,""mode"":5944,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2498}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah17ct121k"",""Description"":""中温（分隔屏）过热器水冷壁4号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""550.04"",""TMin"":""453.62"",""TAvg"":""515.35"",""DMax"":""5.21"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.15"",""C99"":""3.87""},{""PointId"":""d1_10hah17ct122k"",""Description"":""中温（分隔屏）过热器水冷壁4号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""555.23"",""TMin"":""458.13"",""TAvg"":""519.84"",""DMax"":""4.31"",""DMin"":""0.00"",""DAvg"":""1.01"",""C95"":""3.48"",""C99"":""4.26""},{""PointId"":""d1_10hah17ct123k"",""Description"":""中温（分隔屏）过热器水冷壁4号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""554.78"",""TMin"":""459.40"",""TAvg"":""519.92"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.22"",""C99"":""3.94""},{""PointId"":""d1_10hah17ct124k"",""Description"":""中温（分隔屏）过热器水冷壁4号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""552.48"",""TMin"":""459.03"",""TAvg"":""518.59"",""DMax"":""5.22"",""DMin"":""0.00"",""DAvg"":""1.53"",""C95"":""5.07"",""C99"":""6.19""},{""PointId"":""d1_10hah17ct125k"",""Description"":""中温（分隔屏）过热器水冷壁5号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""555.08"",""TMin"":""459.86"",""TAvg"":""519.76"",""DMax"":""4.72"",""DMin"":""0.00"",""DAvg"":""1.33"",""C95"":""4.48"",""C99"":""5.47""},{""PointId"":""d1_10hah17ct126k"",""Description"":""中温（分隔屏）过热器水冷壁5号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""555.60"",""TMin"":""458.77"",""TAvg"":""519.40"",""DMax"":""3.75"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.50"",""C99"":""3.06""},{""PointId"":""d1_10hah17ct127k"",""Description"":""中温（分隔屏）过热器水冷壁5号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""553.65"",""TMin"":""454.90"",""TAvg"":""517.06"",""DMax"":""3.10"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.10"",""C99"":""2.57""},{""PointId"":""d1_10hah17ct128k"",""Description"":""中温（分隔屏）过热器水冷壁5号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""558.18"",""TMin"":""458.80"",""TAvg"":""520.58"",""DMax"":""2.78"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.16"",""C99"":""1.42""},{""PointId"":""d1_10hah17ct129k"",""Description"":""中温（分隔屏）过热器水冷壁5号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""558.75"",""TMin"":""461.57"",""TAvg"":""521.88"",""DMax"":""2.16"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.37"",""C99"":""1.68""},{""PointId"":""d1_10hah17ct130k"",""Description"":""中温（分隔屏）过热器水冷壁5号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""558.80"",""TMin"":""464.02"",""TAvg"":""523.28"",""DMax"":""3.94"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.32"",""C99"":""4.07""},{""PointId"":""d1_10hah17ct131k"",""Description"":""中温（分隔屏）过热器水冷壁6号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""555.40"",""TMin"":""460.08"",""TAvg"":""518.43"",""DMax"":""3.52"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.37"",""C99"":""2.90""},{""PointId"":""d1_10hah17ct132k"",""Description"":""中温（分隔屏）过热器水冷壁6号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""558.46"",""TMin"":""460.08"",""TAvg"":""519.99"",""DMax"":""2.58"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.24"",""C99"":""2.74""},{""PointId"":""d1_10hah17ct133k"",""Description"":""中温（分隔屏）过热器水冷壁6号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""557.00"",""TMin"":""457.25"",""TAvg"":""518.89"",""DMax"":""3.74"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.13"",""C99"":""3.82""},{""PointId"":""d1_10hah17ct134k"",""Description"":""中温（分隔屏）过热器水冷壁6号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""563.05"",""TMin"":""462.87"",""TAvg"":""523.82"",""DMax"":""2.97"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.83"",""C99"":""3.46""},{""PointId"":""d1_10hah17ct135k"",""Description"":""中温（分隔屏）过热器水冷壁6号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""562.54"",""TMin"":""463.62"",""TAvg"":""523.77"",""DMax"":""2.85"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.60"",""C99"":""3.18""},{""PointId"":""d1_10hah17ct136k"",""Description"":""中温（分隔屏）过热器水冷壁6号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""563.14"",""TMin"":""466.28"",""TAvg"":""525.36"",""DMax"":""5.75"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.18"",""C99"":""3.90""},{""PointId"":""d1_10hah17ct137k"",""Description"":""中温（分隔屏）过热器水冷壁7号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""558.28"",""TMin"":""461.40"",""TAvg"":""519.78"",""DMax"":""3.76"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.49"",""C99"":""3.05""},{""PointId"":""d1_10hah17ct138k"",""Description"":""中温（分隔屏）过热器水冷壁7号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""560.08"",""TMin"":""462.62"",""TAvg"":""521.58"",""DMax"":""4.25"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.40"",""C99"":""4.15""},{""PointId"":""d1_10hah17ct139k"",""Description"":""中温（分隔屏）过热器水冷壁7号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""560.78"",""TMin"":""461.03"",""TAvg"":""521.68"",""DMax"":""3.98"",""DMin"":""0.00"",""DAvg"":""1.17"",""C95"":""3.90"",""C99"":""4.76""},{""PointId"":""d1_10hah17ct140k"",""Description"":""中温（分隔屏）过热器水冷壁7号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""566.26"",""TMin"":""466.02"",""TAvg"":""526.04"",""DMax"":""4.20"",""DMin"":""0.00"",""DAvg"":""1.21"",""C95"":""4.09"",""C99"":""5.00""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:35:19"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[453.617,458.133,459.4,459.033,459.86,458.767,454.9,458.8,461.567,464.017,460.083,460.083,457.25,462.867,463.617,466.28,461.4,462.617,461.033,466.017],""Train_X_max"":[550.04,555.225,554.78,552.48,555.08,555.6,553.65,558.18,558.75,558.8,555.4,558.46,557.0,563.05,562.54,563.14,558.28,560.08,560.78,566.26],""Train_X_std"":[10.672,10.777,10.776,10.818,10.928,10.724,10.718,10.756,10.741,10.811,10.681,10.787,10.779,10.887,10.852,10.88,10.702,10.685,10.796,10.896],""Train_X_mean"":[515.354,519.841,519.916,518.591,519.76,519.398,517.056,520.584,521.879,523.283,518.425,519.986,518.894,523.82,523.77,525.357,519.778,521.581,521.682,526.04],""Train_X_bais_max"":[[5.213,4.305,3.549,5.224,4.718,3.751,3.104,2.776,2.16,3.939,3.517,2.584,3.735,2.967,2.854,5.754,3.76,4.249,3.978,4.197]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.892,1.011,0.949,1.53,1.332,0.73,0.611,0.32,0.402,0.977,0.682,0.666,0.931,0.834,0.763,0.909,0.717,1.018,1.173,1.205]],""QCUL_95"":0.65321964,""QCUL_99"":1.11636066,""QCUL_95_line"":[3.152,3.479,3.221,5.068,4.477,2.497,2.097,1.155,1.371,3.323,2.367,2.241,3.128,2.829,2.599,3.182,2.486,3.398,3.899,4.089],""QCUL_99_line"":[3.866,4.26,3.94,6.187,5.471,3.056,2.567,1.419,1.678,4.066,2.9,2.739,3.823,3.46,3.179,3.902,3.045,4.151,4.762,5.002],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.271,0.274,0.274,0.275,0.278,0.273,0.273,0.274,0.273,0.275,0.272,0.274,0.274,0.277,0.276,0.277,0.272,0.272,0.275,0.277],""T2CUL_99_line"":[0.357,0.36,0.36,0.362,0.365,0.358,0.358,0.36,0.359,0.361,0.357,0.361,0.36,0.364,0.363,0.364,0.358,0.357,0.361,0.364],""Kesi_95"":1.556,""Kesi_99"":1.315,""Kesi_95_line"":[0.173,0.174,0.174,0.175,0.177,0.174,0.173,0.174,0.174,0.175,0.173,0.175,0.174,0.176,0.176,0.176,0.173,0.173,0.175,0.176],""Kesi_99_line"":[0.159,0.16,0.16,0.161,0.163,0.16,0.159,0.16,0.16,0.161,0.159,0.16,0.16,0.162,0.161,0.162,0.159,0.159,0.161,0.162],""COV"":[[1.0,0.995,0.994,0.987,0.991,0.996,0.997,0.994,0.993,0.988,0.991,0.99,0.988,0.983,0.983,0.981,0.987,0.983,0.981,0.974],[0.995,1.0,0.999,0.997,0.996,0.993,0.991,0.994,0.995,0.996,0.99,0.984,0.978,0.98,0.983,0.986,0.984,0.975,0.971,0.971],[0.994,0.999,1.0,0.997,0.994,0.992,0.991,0.994,0.996,0.998,0.99,0.985,0.979,0.982,0.985,0.99,0.984,0.977,0.973,0.974],[0.987,0.997,0.997,1.0,0.992,0.982,0.981,0.985,0.99,0.996,0.984,0.974,0.965,0.97,0.974,0.984,0.974,0.962,0.958,0.961],[0.991,0.996,0.994,0.992,1.0,0.992,0.986,0.988,0.988,0.991,0.993,0.983,0.973,0.973,0.975,0.979,0.984,0.972,0.965,0.962],[0.996,0.993,0.992,0.982,0.992,1.0,0.997,0.996,0.994,0.989,0.994,0.994,0.992,0.988,0.989,0.984,0.992,0.991,0.987,0.981],[0.997,0.991,0.991,0.981,0.986,0.997,1.0,0.997,0.995,0.987,0.994,0.997,0.997,0.992,0.992,0.986,0.993,0.992,0.992,0.986],[0.994,0.994,0.994,0.985,0.988,0.996,0.997,1.0,0.999,0.993,0.994,0.995,0.994,0.996,0.997,0.993,0.995,0.992,0.991,0.991],[0.993,0.995,0.996,0.99,0.988,0.994,0.995,0.999,1.0,0.997,0.994,0.993,0.991,0.994,0.996,0.996,0.993,0.99,0.988,0.989],[0.988,0.996,0.998,0.996,0.991,0.989,0.987,0.993,0.997,1.0,0.99,0.985,0.978,0.984,0.988,0.995,0.985,0.978,0.974,0.978],[0.991,0.99,0.99,0.984,0.993,0.994,0.994,0.994,0.994,0.99,1.0,0.996,0.99,0.99,0.99,0.99,0.998,0.989,0.986,0.984],[0.99,0.984,0.985,0.974,0.983,0.994,0.997,0.995,0.993,0.985,0.996,1.0,0.998,0.996,0.995,0.99,0.998,0.997,0.996,0.992],[0.988,0.978,0.979,0.965,0.973,0.992,0.997,0.994,0.991,0.978,0.99,0.998,1.0,0.996,0.995,0.985,0.995,0.998,0.999,0.994],[0.983,0.98,0.982,0.97,0.973,0.988,0.992,0.996,0.994,0.984,0.99,0.996,0.996,1.0,0.999,0.993,0.995,0.996,0.997,0.999],[0.983,0.983,0.985,0.974,0.975,0.989,0.992,0.997,0.996,0.988,0.99,0.995,0.995,0.999,1.0,0.996,0.995,0.995,0.995,0.998],[0.981,0.986,0.99,0.984,0.979,0.984,0.986,0.993,0.996,0.995,0.99,0.99,0.985,0.993,0.996,1.0,0.99,0.987,0.985,0.992],[0.987,0.984,0.984,0.974,0.984,0.992,0.993,0.995,0.993,0.985,0.998,0.998,0.995,0.995,0.995,0.99,1.0,0.995,0.993,0.992],[0.983,0.975,0.977,0.962,0.972,0.991,0.992,0.992,0.99,0.978,0.989,0.997,0.998,0.996,0.995,0.987,0.995,1.0,0.999,0.995],[0.981,0.971,0.973,0.958,0.965,0.987,0.992,0.991,0.988,0.974,0.986,0.996,0.999,0.997,0.995,0.985,0.993,0.999,1.0,0.997],[0.974,0.971,0.974,0.961,0.962,0.981,0.986,0.991,0.989,0.978,0.984,0.992,0.994,0.999,0.998,0.992,0.992,0.995,0.997,1.0]],""K"":1,""R"":0.989,""featValue"":[19.784,0.14,0.045,0.019,0.006,0.005,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,0.156,-0.341,0.323,0.327,0.073,-0.333,0.301,0.449,0.186,-0.313,-0.057,-0.008,0.165,0.028,-0.086,0.122,0.009,-0.06,0.022],[0.223,0.298,-0.024,0.14,-0.128,-0.22,0.139,-0.653,0.196,-0.048,0.039,-0.287,0.071,0.178,0.23,-0.246,0.131,-0.078,-0.007,-0.181],[0.224,0.271,0.095,0.182,-0.052,0.052,-0.12,0.157,-0.277,0.233,0.29,-0.576,0.136,0.031,-0.163,0.381,-0.201,-0.076,-0.069,0.029],[0.222,0.424,0.205,0.049,0.315,0.069,-0.194,-0.056,-0.367,0.05,0.074,0.313,-0.151,-0.104,0.248,-0.289,-0.261,0.258,0.148,0.078],[0.222,0.334,-0.228,-0.395,-0.249,-0.086,0.083,0.312,0.266,-0.175,0.371,0.169,-0.095,0.168,-0.219,-0.137,-0.197,0.033,-0.042,-0.208],[0.224,0.055,-0.323,0.074,-0.505,0.16,0.118,0.154,-0.201,0.09,-0.087,0.134,-0.209,-0.05,0.533,0.221,0.187,-0.095,0.1,0.114],[0.224,-0.025,-0.26,0.241,0.308,-0.064,0.154,-0.073,-0.213,-0.18,0.207,0.112,-0.287,-0.374,-0.288,0.113,0.359,-0.119,-0.097,-0.302],[0.225,0.004,0.019,0.144,-0.213,-0.399,0.058,-0.034,0.075,0.045,0.01,0.139,0.098,-0.226,-0.195,-0.031,0.073,0.321,-0.374,0.587],[0.225,0.056,0.14,0.159,-0.115,-0.107,0.038,-0.231,0.127,0.045,-0.318,0.347,-0.082,0.147,-0.341,0.462,-0.252,-0.039,0.393,-0.074],[0.223,0.231,0.302,-0.012,-0.12,0.308,-0.004,0.119,-0.073,-0.223,-0.211,0.199,0.546,-0.109,-0.118,-0.111,0.268,-0.339,-0.13,-0.046],[0.224,0.041,-0.121,-0.513,0.283,-0.052,0.074,-0.04,0.13,-0.003,-0.013,-0.205,0.226,-0.284,0.067,0.179,0.223,0.118,0.484,0.234],[0.224,-0.142,-0.157,-0.206,0.175,0.153,0.47,-0.063,-0.253,0.509,-0.152,0.089,0.151,0.321,-0.12,-0.098,-0.005,0.141,-0.221,-0.101],[0.224,-0.24,-0.202,0.163,0.159,0.065,0.238,0.034,0.029,-0.502,-0.092,-0.081,0.267,-0.085,0.253,0.103,-0.533,0.117,-0.133,-0.052],[0.224,-0.221,0.16,0.029,0.01,-0.334,0.165,0.226,0.05,0.259,-0.052,-0.077,-0.113,-0.25,0.05,-0.357,-0.255,-0.556,0.162,0.028],[0.224,-0.171,0.246,0.058,-0.182,-0.185,0.003,0.304,-0.208,-0.225,-0.277,-0.292,-0.122,0.154,-0.09,-0.209,0.23,0.433,0.215,-0.253],[0.224,-0.014,0.476,-0.115,0.164,0.326,0.247,0.011,0.306,-0.124,0.023,-0.116,-0.489,0.103,0.102,0.155,0.08,-0.04,-0.244,0.203],[0.224,-0.125,-0.082,-0.455,0.025,-0.217,-0.51,-0.179,-0.235,-0.115,-0.285,-0.037,-0.154,0.08,0.038,0.129,-0.062,-0.208,-0.363,-0.051],[0.223,-0.271,-0.099,-0.017,-0.294,0.531,-0.258,-0.268,0.132,0.141,0.041,-0.115,-0.086,-0.34,-0.243,-0.264,-0.156,0.156,0.07,-0.045],[0.223,-0.335,-0.088,0.127,0.078,0.07,-0.153,-0.062,-0.152,-0.21,0.378,0.097,0.062,0.513,-0.088,-0.135,0.124,-0.196,0.249,0.383],[0.223,-0.32,0.283,0.026,0.014,-0.139,-0.217,0.042,0.219,0.246,0.373,0.248,0.24,-0.035,0.321,0.213,0.122,0.163,-0.08,-0.367]],""selectVec"":[[0.224],[0.223],[0.224],[0.222],[0.222],[0.224],[0.224],[0.225],[0.225],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.223],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8534,""AfterCleanSamNum"":5944,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":434,""version"":""v-2025-12-03 14:35:19"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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