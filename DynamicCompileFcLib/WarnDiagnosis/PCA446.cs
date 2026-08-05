using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA446")]
    [FCDisplay("PCA446")]
    public partial class PCA446 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁143号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁143号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁143号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁143号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁143号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁143号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁144号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁144号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁144号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁144号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁144号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁144号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁145号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁145号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁145号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁145号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁145号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁145号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁146号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁146号屏2号管壁温")]
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

		public PCA446()
		{
			ModelID = 487;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA446";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""487"",""name"":""PCA446"",""description"":""中温分隔屏过热器水冷壁26-61-80"",""founder"":""admin"",""creatTime"":""2025-12-10 17:12:34"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:14:20"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 13:53:08"",""et"":""2025-12-07 15:18:02"",""duration"":2337894,""number"":7793,""filter"":2629,""mode"":5164,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2539}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah26ct161k"",""Description"":""中温（分隔屏）过热器水冷壁143号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""567.05"",""TMin"":""490.30"",""TAvg"":""536.10"",""DMax"":""4.25"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.95"",""C99"":""3.61""},{""PointId"":""d1_10hah26ct162k"",""Description"":""中温（分隔屏）过热器水冷壁143号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""569.58"",""TMin"":""491.90"",""TAvg"":""538.40"",""DMax"":""2.56"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""2.00"",""C99"":""2.45""},{""PointId"":""d1_10hah26ct163k"",""Description"":""中温（分隔屏）过热器水冷壁143号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""567.98"",""TMin"":""489.08"",""TAvg"":""536.20"",""DMax"":""3.66"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.99"",""C99"":""3.67""},{""PointId"":""d1_10hah26ct164k"",""Description"":""中温（分隔屏）过热器水冷壁143号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""573.72"",""TMin"":""495.18"",""TAvg"":""542.20"",""DMax"":""1.98"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.52"",""C99"":""1.86""},{""PointId"":""d1_10hah26ct165k"",""Description"":""中温（分隔屏）过热器水冷壁143号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""574.16"",""TMin"":""496.03"",""TAvg"":""542.50"",""DMax"":""2.42"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.95"",""C99"":""2.38""},{""PointId"":""d1_10hah26ct166k"",""Description"":""中温（分隔屏）过热器水冷壁143号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""575.00"",""TMin"":""497.88"",""TAvg"":""544.07"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.82"",""C99"":""3.45""},{""PointId"":""d1_10hah26ct167k"",""Description"":""中温（分隔屏）过热器水冷壁144号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""568.25"",""TMin"":""491.62"",""TAvg"":""537.35"",""DMax"":""3.70"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.50"",""C99"":""3.07""},{""PointId"":""d1_10hah26ct168k"",""Description"":""中温（分隔屏）过热器水冷壁144号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""571.22"",""TMin"":""493.64"",""TAvg"":""540.05"",""DMax"":""2.02"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.92"",""C99"":""2.34""},{""PointId"":""d1_10hah26ct169k"",""Description"":""中温（分隔屏）过热器水冷壁144号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""570.58"",""TMin"":""491.95"",""TAvg"":""538.95"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.82"",""C99"":""2.23""},{""PointId"":""d1_10hah26ct170k"",""Description"":""中温（分隔屏）过热器水冷壁144号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""575.72"",""TMin"":""497.64"",""TAvg"":""544.12"",""DMax"":""2.88"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.86"",""C99"":""2.29""},{""PointId"":""d1_10hah26ct171k"",""Description"":""中温（分隔屏）过热器水冷壁144号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""576.08"",""TMin"":""498.44"",""TAvg"":""544.97"",""DMax"":""4.45"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.10"",""C99"":""3.80""},{""PointId"":""d1_10hah26ct172k"",""Description"":""中温（分隔屏）过热器水冷壁144号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""575.44"",""TMin"":""500.08"",""TAvg"":""545.68"",""DMax"":""5.48"",""DMin"":""0.00"",""DAvg"":""1.29"",""C95"":""4.42"",""C99"":""5.41""},{""PointId"":""d1_10hah26ct173k"",""Description"":""中温（分隔屏）过热器水冷壁145号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""569.50"",""TMin"":""493.02"",""TAvg"":""538.44"",""DMax"":""4.54"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.69"",""C99"":""3.30""},{""PointId"":""d1_10hah26ct174k"",""Description"":""中温（分隔屏）过热器水冷壁145号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""570.26"",""TMin"":""492.80"",""TAvg"":""539.26"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.81"",""C99"":""2.22""},{""PointId"":""d1_10hah26ct175k"",""Description"":""中温（分隔屏）过热器水冷壁145号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""570.12"",""TMin"":""491.53"",""TAvg"":""538.67"",""DMax"":""2.66"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.89"",""C99"":""2.32""},{""PointId"":""d1_10hah26ct176k"",""Description"":""中温（分隔屏）过热器水冷壁145号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""575.96"",""TMin"":""496.78"",""TAvg"":""544.12"",""DMax"":""2.74"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.77"",""C99"":""2.18""},{""PointId"":""d1_10hah26ct177k"",""Description"":""中温（分隔屏）过热器水冷壁145号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""576.82"",""TMin"":""498.45"",""TAvg"":""544.91"",""DMax"":""4.60"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.89"",""C99"":""3.55""},{""PointId"":""d1_10hah26ct178k"",""Description"":""中温（分隔屏）过热器水冷壁145号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""576.18"",""TMin"":""499.00"",""TAvg"":""545.58"",""DMax"":""6.21"",""DMin"":""0.00"",""DAvg"":""1.39"",""C95"":""4.71"",""C99"":""5.77""},{""PointId"":""d1_10hah26ct179k"",""Description"":""中温（分隔屏）过热器水冷壁146号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""566.00"",""TMin"":""489.18"",""TAvg"":""535.74"",""DMax"":""4.65"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.91"",""C99"":""3.56""},{""PointId"":""d1_10hah26ct180k"",""Description"":""中温（分隔屏）过热器水冷壁146号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""567.42"",""TMin"":""488.24"",""TAvg"":""536.81"",""DMax"":""3.85"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.81"",""C99"":""3.44""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:14:20"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[490.302,491.9,489.08,495.18,496.025,497.88,491.617,493.64,491.95,497.64,498.44,500.08,493.02,492.8,491.525,496.78,498.45,499.0,489.18,488.24],""Train_X_max"":[567.05,569.58,567.98,573.72,574.16,575.0,568.25,571.217,570.58,575.72,576.08,575.44,569.5,570.26,570.12,575.96,576.82,576.18,566.0,567.42],""Train_X_std"":[9.582,9.601,9.739,9.609,9.636,9.607,9.57,9.621,9.701,9.606,9.588,9.543,9.548,9.576,9.656,9.631,9.602,9.591,9.496,9.615],""Train_X_mean"":[536.102,538.4,536.2,542.204,542.5,544.071,537.347,540.046,538.947,544.118,544.968,545.68,538.442,539.257,538.668,544.123,544.914,545.584,535.735,536.813],""Train_X_bais_max"":[[4.254,2.559,3.663,1.976,2.423,3.167,3.698,2.015,2.108,2.882,4.445,5.475,4.535,2.112,2.66,2.744,4.598,6.205,4.647,3.851]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0]],""Train_X_bais_mean"":[[0.85,0.575,0.847,0.434,0.569,0.822,0.72,0.562,0.533,0.527,0.889,1.292,0.773,0.528,0.549,0.506,0.832,1.386,0.846,0.807]],""QCUL_95"":0.7026018,""QCUL_99"":1.25973618,""QCUL_95_line"":[2.949,2.001,2.992,1.515,1.947,2.821,2.503,1.916,1.818,1.863,3.098,4.419,2.689,1.81,1.891,1.774,2.894,4.713,2.907,2.81],""QCUL_99_line"":[3.613,2.452,3.67,1.857,2.384,3.453,3.067,2.344,2.225,2.286,3.797,5.409,3.295,2.216,2.316,2.175,3.547,5.766,3.56,3.444],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.261,0.262,0.266,0.262,0.263,0.262,0.261,0.262,0.265,0.262,0.262,0.26,0.261,0.261,0.263,0.263,0.262,0.262,0.259,0.262],""T2CUL_99_line"":[0.344,0.344,0.349,0.345,0.346,0.345,0.343,0.345,0.348,0.344,0.344,0.342,0.342,0.343,0.346,0.345,0.344,0.344,0.341,0.345],""Kesi_95"":1.56,""Kesi_99"":1.327,""Kesi_95_line"":[0.167,0.167,0.169,0.167,0.167,0.167,0.166,0.167,0.169,0.167,0.167,0.166,0.166,0.166,0.168,0.167,0.167,0.167,0.165,0.167],""Kesi_99_line"":[0.154,0.154,0.156,0.154,0.154,0.154,0.153,0.154,0.156,0.154,0.154,0.153,0.153,0.154,0.155,0.154,0.154,0.154,0.152,0.154],""COV"":[[1.0,0.998,0.997,0.989,0.985,0.978,0.999,0.997,0.997,0.985,0.975,0.964,0.999,0.997,0.996,0.985,0.977,0.961,0.999,0.997],[0.998,1.0,0.998,0.994,0.99,0.985,0.998,0.999,0.999,0.99,0.982,0.972,0.998,0.999,0.999,0.991,0.984,0.97,0.997,0.998],[0.997,0.998,1.0,0.991,0.987,0.98,0.994,0.996,0.998,0.985,0.975,0.963,0.995,0.996,0.999,0.986,0.978,0.961,0.995,0.998],[0.989,0.994,0.991,1.0,0.999,0.997,0.99,0.993,0.994,0.999,0.995,0.989,0.989,0.993,0.995,0.999,0.996,0.987,0.989,0.99],[0.985,0.99,0.987,0.999,1.0,0.999,0.987,0.991,0.992,0.999,0.998,0.992,0.986,0.991,0.992,0.999,0.998,0.991,0.985,0.986],[0.978,0.985,0.98,0.997,0.999,1.0,0.981,0.985,0.986,0.997,0.998,0.996,0.98,0.986,0.986,0.998,0.998,0.996,0.979,0.98],[0.999,0.998,0.994,0.99,0.987,0.981,1.0,0.998,0.997,0.989,0.981,0.97,1.0,0.997,0.996,0.988,0.981,0.967,0.998,0.996],[0.997,0.999,0.996,0.993,0.991,0.985,0.998,1.0,0.999,0.991,0.984,0.974,0.998,1.0,0.999,0.991,0.986,0.972,0.996,0.997],[0.997,0.999,0.998,0.994,0.992,0.986,0.997,0.999,1.0,0.992,0.984,0.974,0.997,0.999,1.0,0.992,0.986,0.972,0.997,0.998],[0.985,0.99,0.985,0.999,0.999,0.997,0.989,0.991,0.992,1.0,0.998,0.993,0.987,0.992,0.992,1.0,0.998,0.991,0.985,0.986],[0.975,0.982,0.975,0.995,0.998,0.998,0.981,0.984,0.984,0.998,1.0,0.998,0.979,0.985,0.984,0.998,0.999,0.996,0.976,0.976],[0.964,0.972,0.963,0.989,0.992,0.996,0.97,0.974,0.974,0.993,0.998,1.0,0.968,0.975,0.973,0.993,0.996,0.999,0.966,0.965],[0.999,0.998,0.995,0.989,0.986,0.98,1.0,0.998,0.997,0.987,0.979,0.968,1.0,0.997,0.996,0.987,0.98,0.964,0.998,0.996],[0.997,0.999,0.996,0.993,0.991,0.986,0.997,1.0,0.999,0.992,0.985,0.975,0.997,1.0,0.999,0.992,0.987,0.973,0.996,0.997],[0.996,0.999,0.999,0.995,0.992,0.986,0.996,0.999,1.0,0.992,0.984,0.973,0.996,0.999,1.0,0.992,0.986,0.972,0.996,0.998],[0.985,0.991,0.986,0.999,0.999,0.998,0.988,0.991,0.992,1.0,0.998,0.993,0.987,0.992,0.992,1.0,0.999,0.992,0.986,0.987],[0.977,0.984,0.978,0.996,0.998,0.998,0.981,0.986,0.986,0.998,0.999,0.996,0.98,0.987,0.986,0.999,1.0,0.996,0.978,0.979],[0.961,0.97,0.961,0.987,0.991,0.996,0.967,0.972,0.972,0.991,0.996,0.999,0.964,0.973,0.972,0.992,0.996,1.0,0.963,0.963],[0.999,0.997,0.995,0.989,0.985,0.979,0.998,0.996,0.997,0.985,0.976,0.966,0.998,0.996,0.996,0.986,0.978,0.963,1.0,0.998],[0.997,0.998,0.998,0.99,0.986,0.98,0.996,0.997,0.998,0.986,0.976,0.965,0.996,0.997,0.998,0.987,0.979,0.963,0.998,1.0]],""K"":1,""R"":0.99,""featValue"":[19.796,0.172,0.014,0.006,0.006,0.003,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.223,-0.253,-0.216,0.258,-0.069,0.272,-0.168,-0.024,-0.127,-0.19,0.121,-0.098,0.263,-0.47,-0.058,-0.391,0.15,-0.11,0.261,0.2],[0.224,-0.171,0.074,-0.083,-0.064,0.265,0.121,-0.053,-0.399,-0.001,0.485,-0.381,-0.098,0.069,0.153,0.227,-0.092,0.124,-0.387,0.117],[0.223,-0.23,0.455,0.054,-0.09,0.307,0.023,0.011,0.306,0.104,0.126,0.289,-0.32,-0.034,-0.313,0.074,-0.073,-0.407,-0.008,0.048],[0.224,0.08,0.262,0.37,0.006,0.052,0.129,-0.412,-0.251,-0.073,-0.142,-0.153,-0.047,0.297,-0.15,0.064,-0.031,0.204,0.479,-0.218],[0.224,0.15,0.206,0.261,0.089,0.022,-0.134,0.428,-0.191,-0.089,0.02,0.14,0.133,0.169,0.114,-0.394,-0.095,-0.069,-0.302,-0.473],[0.224,0.239,0.149,0.115,-0.257,0.319,-0.159,0.31,0.03,0.059,-0.507,-0.029,-0.012,-0.07,0.137,0.228,0.092,0.304,-0.08,0.351],[0.224,-0.189,-0.412,0.1,0.134,0.232,0.083,-0.044,0.065,0.269,0.109,0.511,-0.078,-0.043,0.222,0.21,0.112,0.322,0.058,-0.291],[0.224,-0.145,-0.081,-0.398,0.202,0.078,0.039,0.11,-0.308,-0.275,-0.339,0.004,-0.002,0.073,0.171,0.267,0.216,-0.468,0.165,-0.137],[0.224,-0.146,0.129,-0.186,0.13,0.029,0.228,-0.121,0.294,-0.399,-0.002,0.232,0.46,0.238,0.137,-0.084,-0.3,0.193,-0.042,0.265],[0.224,0.146,0.008,0.161,0.347,-0.186,0.32,-0.26,-0.079,0.025,-0.213,0.061,0.076,-0.295,-0.327,0.035,0.272,-0.018,-0.489,0.081],[0.223,0.273,-0.113,0.066,0.217,-0.111,0.321,0.326,0.092,0.071,0.278,-0.045,-0.241,0.29,0.076,-0.205,0.31,-0.06,0.256,0.376],[0.222,0.39,-0.26,-0.145,-0.205,0.147,0.41,0.117,0.197,0.007,0.006,-0.233,0.057,-0.274,-0.135,0.059,-0.404,-0.111,0.109,-0.29],[0.224,-0.211,-0.376,0.179,0.201,-0.016,-0.321,0.059,0.228,0.246,-0.13,-0.329,0.163,0.397,-0.28,0.128,-0.176,-0.151,-0.11,0.054],[0.224,-0.131,-0.019,-0.485,0.124,-0.054,-0.111,0.019,-0.229,0.17,-0.188,0.038,-0.336,-0.051,-0.276,-0.425,-0.244,0.33,0.056,0.062],[0.224,-0.142,0.262,-0.212,0.052,-0.073,-0.073,-0.09,0.484,0.086,0.0,-0.422,0.007,-0.126,0.242,-0.121,0.393,0.17,0.0,-0.32],[0.224,0.144,0.103,0.123,0.186,-0.245,-0.167,-0.261,-0.036,0.301,-0.039,0.021,-0.081,-0.224,0.551,-0.013,-0.387,-0.27,0.062,0.181],[0.223,0.251,0.061,-0.058,0.2,-0.258,-0.461,0.129,0.042,-0.345,0.342,0.087,-0.034,-0.211,-0.225,0.387,-0.031,0.179,0.138,-0.028],[0.221,0.412,-0.148,-0.266,-0.386,0.094,-0.28,-0.426,-0.019,0.069,0.125,0.189,0.121,0.26,-0.039,-0.157,0.247,-0.163,-0.134,0.014],[0.223,-0.232,-0.251,0.212,-0.438,-0.401,0.053,-0.042,0.103,-0.411,-0.124,0.013,-0.436,0.042,0.108,-0.036,-0.034,-0.002,-0.173,-0.013],[0.224,-0.229,0.159,-0.069,-0.388,-0.471,0.146,0.224,-0.197,0.378,0.074,0.107,0.404,-0.035,-0.113,0.147,0.077,-0.003,0.142,0.02]],""selectVec"":[[0.223],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.222],[0.224],[0.224],[0.224],[0.224],[0.223],[0.221],[0.223],[0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7793,""AfterCleanSamNum"":5164,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":487,""version"":""v-2025-12-10 17:14:20"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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