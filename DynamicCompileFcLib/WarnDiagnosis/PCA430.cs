using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA430")]
    [FCDisplay("PCA430")]
    public partial class PCA430 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁90号屏2号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁90号屏3号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁90号屏4号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁90号屏5号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁90号屏6号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁91号屏1号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁91号屏2号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁91号屏3号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁91号屏4号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁91号屏5号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁91号屏6号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁92号屏1号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁92号屏2号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁92号屏3号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁92号屏4号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁92号屏5号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁92号屏6号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁93号屏1号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁93号屏2号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁93号屏3号管壁温")]
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

		public PCA430()
		{
			ModelID = 471;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA430";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""471"",""name"":""PCA430"",""description"":""中温分隔屏过热器水冷壁23-41-60"",""founder"":""admin"",""creatTime"":""2025-12-09 10:37:53"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:39:32"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 17:03:24"",""et"":""2025-12-07 04:53:10"",""duration"":2375386,""number"":7918,""filter"":2594,""mode"":5324,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2504}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah23ct141k"",""Description"":""中温（分隔屏）过热器水冷壁90号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""562.27"",""TMin"":""483.75"",""TAvg"":""527.46"",""DMax"":""2.45"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.06"",""C99"":""2.52""},{""PointId"":""d1_10hah23ct142k"",""Description"":""中温（分隔屏）过热器水冷壁90号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""563.52"",""TMin"":""483.90"",""TAvg"":""527.79"",""DMax"":""3.51"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.08"",""C99"":""2.55""},{""PointId"":""d1_10hah23ct143k"",""Description"":""中温（分隔屏）过热器水冷壁90号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""568.53"",""TMin"":""486.58"",""TAvg"":""531.86"",""DMax"":""2.16"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.66"",""C99"":""2.03""},{""PointId"":""d1_10hah23ct144k"",""Description"":""中温（分隔屏）过热器水冷壁90号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""569.91"",""TMin"":""488.56"",""TAvg"":""533.46"",""DMax"":""5.09"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.02"",""C99"":""3.70""},{""PointId"":""d1_10hah23ct145k"",""Description"":""中温（分隔屏）过热器水冷壁90号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""570.73"",""TMin"":""489.42"",""TAvg"":""534.01"",""DMax"":""6.28"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.18"",""C99"":""3.89""},{""PointId"":""d1_10hah23ct146k"",""Description"":""中温（分隔屏）过热器水冷壁91号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""561.25"",""TMin"":""481.75"",""TAvg"":""525.70"",""DMax"":""5.58"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.83"",""C99"":""3.47""},{""PointId"":""d1_10hah23ct147k"",""Description"":""中温（分隔屏）过热器水冷壁91号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""561.19"",""TMin"":""481.42"",""TAvg"":""525.59"",""DMax"":""2.96"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.11"",""C99"":""2.58""},{""PointId"":""d1_10hah23ct148k"",""Description"":""中温（分隔屏）过热器水冷壁91号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""562.26"",""TMin"":""481.84"",""TAvg"":""525.93"",""DMax"":""3.15"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.80"",""C99"":""2.21""},{""PointId"":""d1_10hah23ct149k"",""Description"":""中温（分隔屏）过热器水冷壁91号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""568.71"",""TMin"":""486.19"",""TAvg"":""531.66"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.36"",""C99"":""1.67""},{""PointId"":""d1_10hah23ct150k"",""Description"":""中温（分隔屏）过热器水冷壁91号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""568.84"",""TMin"":""486.82"",""TAvg"":""531.54"",""DMax"":""4.22"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.40"",""C99"":""2.94""},{""PointId"":""d1_10hah23ct151k"",""Description"":""中温（分隔屏）过热器水冷壁91号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""570.28"",""TMin"":""488.49"",""TAvg"":""532.95"",""DMax"":""4.35"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.63"",""C99"":""3.22""},{""PointId"":""d1_10hah23ct152k"",""Description"":""中温（分隔屏）过热器水冷壁92号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""559.58"",""TMin"":""479.45"",""TAvg"":""523.86"",""DMax"":""6.07"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.84"",""C99"":""3.48""},{""PointId"":""d1_10hah23ct153k"",""Description"":""中温（分隔屏）过热器水冷壁92号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""560.95"",""TMin"":""480.80"",""TAvg"":""525.03"",""DMax"":""2.81"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.71"",""C99"":""2.09""},{""PointId"":""d1_10hah23ct154k"",""Description"":""中温（分隔屏）过热器水冷壁92号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""561.56"",""TMin"":""480.51"",""TAvg"":""524.74"",""DMax"":""2.82"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.84"",""C99"":""2.26""},{""PointId"":""d1_10hah23ct155k"",""Description"":""中温（分隔屏）过热器水冷壁92号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""568.11"",""TMin"":""485.16"",""TAvg"":""531.01"",""DMax"":""2.02"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.48"",""C99"":""1.81""},{""PointId"":""d1_10hah23ct156k"",""Description"":""中温（分隔屏）过热器水冷壁92号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""568.21"",""TMin"":""485.26"",""TAvg"":""530.79"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""2.02"",""C99"":""2.47""},{""PointId"":""d1_10hah23ct157k"",""Description"":""中温（分隔屏）过热器水冷壁92号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""569.78"",""TMin"":""486.71"",""TAvg"":""531.97"",""DMax"":""4.57"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.68"",""C99"":""3.29""},{""PointId"":""d1_10hah23ct158k"",""Description"":""中温（分隔屏）过热器水冷壁93号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""560.73"",""TMin"":""480.61"",""TAvg"":""525.02"",""DMax"":""5.88"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.70"",""C99"":""3.32""},{""PointId"":""d1_10hah23ct159k"",""Description"":""中温（分隔屏）过热器水冷壁93号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""562.24"",""TMin"":""481.23"",""TAvg"":""525.99"",""DMax"":""3.32"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.96"",""C99"":""2.40""},{""PointId"":""d1_10hah23ct160k"",""Description"":""中温（分隔屏）过热器水冷壁93号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""563.81"",""TMin"":""481.72"",""TAvg"":""526.85"",""DMax"":""3.14"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.91"",""C99"":""2.34""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:39:32"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[483.746,483.902,486.584,488.563,489.415,481.748,481.424,481.841,486.189,486.82,488.486,479.453,480.798,480.513,485.159,485.256,486.711,480.608,481.225,481.718],""Train_X_max"":[562.274,563.522,568.532,569.914,570.728,561.25,561.19,562.255,568.708,568.842,570.275,559.576,560.95,561.558,568.105,568.213,569.777,560.733,562.235,563.808],""Train_X_std"":[10.519,10.538,10.508,10.304,10.292,10.588,10.662,10.642,10.553,10.4,10.375,10.637,10.614,10.692,10.594,10.538,10.501,10.628,10.743,10.814],""Train_X_mean"":[527.462,527.788,531.858,533.456,534.013,525.695,525.593,525.93,531.659,531.544,532.95,523.862,525.032,524.744,531.005,530.786,531.965,525.022,525.989,526.847],""Train_X_bais_max"":[[2.447,3.509,2.157,5.092,6.28,5.581,2.961,3.151,2.003,4.215,4.354,6.068,2.811,2.823,2.023,3.169,4.57,5.876,3.319,3.142]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.002,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.602,0.59,0.478,0.875,0.917,0.809,0.614,0.507,0.393,0.693,0.759,0.797,0.492,0.531,0.43,0.584,0.775,0.749,0.562,0.547]],""QCUL_95"":0.3908998,""QCUL_99"":0.6948818,""QCUL_95_line"":[2.059,2.081,1.655,3.019,3.178,2.832,2.106,1.8,1.361,2.401,2.628,2.835,1.707,1.844,1.48,2.018,2.683,2.699,1.958,1.909],""QCUL_99_line"":[2.52,2.553,2.027,3.698,3.893,3.472,2.578,2.209,1.668,2.941,3.219,3.479,2.092,2.259,1.812,2.472,3.287,3.316,2.399,2.34],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.283,0.283,0.282,0.277,0.277,0.285,0.286,0.286,0.284,0.279,0.279,0.286,0.285,0.287,0.285,0.283,0.282,0.286,0.289,0.291],""T2CUL_99_line"":[0.372,0.372,0.371,0.364,0.364,0.374,0.377,0.376,0.373,0.367,0.366,0.376,0.375,0.378,0.374,0.372,0.371,0.375,0.379,0.382],""Kesi_95"":1.554,""Kesi_99"":1.307,""Kesi_95_line"":[0.18,0.18,0.18,0.176,0.176,0.181,0.182,0.182,0.18,0.178,0.177,0.182,0.181,0.183,0.181,0.18,0.179,0.182,0.184,0.185],""Kesi_99_line"":[0.165,0.165,0.165,0.161,0.161,0.166,0.167,0.167,0.165,0.163,0.163,0.167,0.166,0.168,0.166,0.165,0.165,0.167,0.168,0.169],""COV"":[[1.0,0.999,0.995,0.988,0.987,0.997,1.0,0.999,0.995,0.99,0.989,0.996,0.999,0.998,0.994,0.991,0.988,0.995,0.997,0.996],[0.999,1.0,0.995,0.988,0.987,0.995,0.999,1.0,0.995,0.99,0.989,0.995,0.998,0.999,0.994,0.992,0.988,0.993,0.996,0.997],[0.995,0.995,1.0,0.998,0.997,0.991,0.994,0.995,1.0,0.998,0.997,0.991,0.994,0.994,0.999,0.998,0.996,0.99,0.993,0.994],[0.988,0.988,0.998,1.0,1.0,0.982,0.986,0.988,0.997,0.999,0.999,0.981,0.987,0.987,0.996,0.997,0.998,0.983,0.986,0.987],[0.987,0.987,0.997,1.0,1.0,0.981,0.985,0.987,0.996,0.999,0.999,0.98,0.986,0.986,0.995,0.997,0.998,0.982,0.986,0.987],[0.997,0.995,0.991,0.982,0.981,1.0,0.998,0.996,0.992,0.985,0.985,1.0,0.998,0.996,0.991,0.987,0.984,0.998,0.997,0.994],[1.0,0.999,0.994,0.986,0.985,0.998,1.0,0.999,0.994,0.989,0.988,0.998,1.0,0.999,0.994,0.991,0.987,0.996,0.998,0.997],[0.999,1.0,0.995,0.988,0.987,0.996,0.999,1.0,0.996,0.991,0.99,0.996,0.999,1.0,0.995,0.993,0.99,0.994,0.998,0.998],[0.995,0.995,1.0,0.997,0.996,0.992,0.994,0.996,1.0,0.998,0.998,0.991,0.995,0.995,1.0,0.999,0.997,0.992,0.994,0.995],[0.99,0.99,0.998,0.999,0.999,0.985,0.989,0.991,0.998,1.0,1.0,0.985,0.99,0.991,0.998,0.999,1.0,0.987,0.991,0.992],[0.989,0.989,0.997,0.999,0.999,0.985,0.988,0.99,0.998,1.0,1.0,0.984,0.989,0.989,0.997,0.999,0.999,0.987,0.989,0.99],[0.996,0.995,0.991,0.981,0.98,1.0,0.998,0.996,0.991,0.985,0.984,1.0,0.998,0.996,0.992,0.988,0.984,0.999,0.997,0.995],[0.999,0.998,0.994,0.987,0.986,0.998,1.0,0.999,0.995,0.99,0.989,0.998,1.0,0.999,0.995,0.993,0.99,0.998,0.999,0.999],[0.998,0.999,0.994,0.987,0.986,0.996,0.999,1.0,0.995,0.991,0.989,0.996,0.999,1.0,0.995,0.994,0.99,0.995,0.999,0.999],[0.994,0.994,0.999,0.996,0.995,0.991,0.994,0.995,1.0,0.998,0.997,0.992,0.995,0.995,1.0,0.999,0.998,0.993,0.995,0.996],[0.991,0.992,0.998,0.997,0.997,0.987,0.991,0.993,0.999,0.999,0.999,0.988,0.993,0.994,0.999,1.0,1.0,0.99,0.993,0.995],[0.988,0.988,0.996,0.998,0.998,0.984,0.987,0.99,0.997,1.0,0.999,0.984,0.99,0.99,0.998,1.0,1.0,0.987,0.99,0.992],[0.995,0.993,0.99,0.983,0.982,0.998,0.996,0.994,0.992,0.987,0.987,0.999,0.998,0.995,0.993,0.99,0.987,1.0,0.998,0.996],[0.997,0.996,0.993,0.986,0.986,0.997,0.998,0.998,0.994,0.991,0.989,0.997,0.999,0.999,0.995,0.993,0.99,0.998,1.0,0.999],[0.996,0.997,0.994,0.987,0.987,0.994,0.997,0.998,0.995,0.992,0.99,0.995,0.999,0.999,0.996,0.995,0.992,0.996,0.999,1.0]],""K"":1,""R"":0.994,""featValue"":[19.88,0.09,0.014,0.011,0.004,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.171,0.274,0.228,-0.356,-0.312,0.131,-0.045,0.163,-0.236,-0.235,0.035,0.137,-0.185,-0.305,-0.057,-0.508,-0.022,0.056,-0.028],[-0.224,0.147,0.462,0.006,-0.089,0.08,-0.371,0.015,-0.057,0.11,-0.216,-0.365,0.299,-0.229,0.234,-0.056,0.333,0.064,-0.199,-0.117],[-0.224,-0.134,0.135,0.248,0.376,-0.083,-0.096,0.346,0.074,-0.435,-0.273,0.106,0.022,0.404,0.114,-0.124,0.16,-0.054,0.26,0.078],[-0.223,-0.339,0.059,0.258,-0.035,-0.131,-0.12,0.252,-0.016,0.569,-0.167,0.371,-0.294,-0.201,0.184,0.044,-0.113,0.028,-0.041,0.043],[-0.223,-0.356,0.103,0.184,-0.348,-0.038,-0.348,-0.332,-0.256,-0.117,0.297,-0.117,-0.258,0.34,-0.215,0.057,0.085,-0.055,0.003,-0.049],[-0.223,0.274,-0.215,0.407,0.005,0.331,-0.001,0.07,0.265,-0.161,0.154,-0.078,-0.305,-0.15,-0.006,-0.132,0.067,-0.218,-0.431,0.228],[-0.224,0.219,0.166,0.103,-0.11,-0.038,0.455,-0.162,0.184,0.116,0.154,-0.014,-0.238,-0.019,0.208,0.113,0.349,-0.145,0.439,-0.312],[-0.224,0.15,0.317,-0.093,0.138,0.28,0.11,0.023,-0.154,0.116,0.149,-0.173,-0.028,0.178,0.137,0.411,-0.365,0.075,0.128,0.494],[-0.224,-0.124,0.017,0.109,0.364,-0.181,0.264,0.078,-0.129,-0.154,0.217,-0.125,-0.042,-0.097,-0.063,0.225,-0.05,0.479,-0.368,-0.38],[-0.224,-0.273,-0.032,-0.073,-0.095,0.128,0.022,0.331,0.298,0.112,0.459,0.027,0.531,0.079,-0.034,0.027,-0.096,-0.304,-0.022,-0.17],[-0.223,-0.292,-0.135,0.061,-0.173,0.264,0.47,0.052,-0.363,0.027,-0.162,-0.111,0.191,-0.152,-0.207,-0.306,0.226,0.146,0.107,0.262],[-0.223,0.285,-0.303,0.237,0.199,0.188,-0.133,-0.225,-0.216,0.207,-0.258,0.222,0.3,0.117,-0.296,0.334,0.038,-0.136,0.05,-0.217],[-0.224,0.186,0.023,-0.087,-0.038,-0.187,-0.097,-0.239,0.052,-0.109,0.312,0.576,0.236,-0.07,0.106,-0.101,0.235,0.334,-0.033,0.333],[-0.224,0.16,0.173,-0.277,0.157,0.323,-0.027,-0.084,-0.048,0.152,0.023,0.157,-0.175,0.22,-0.069,-0.6,-0.279,0.092,-0.026,-0.317],[-0.224,-0.112,-0.079,-0.089,0.484,-0.391,-0.035,-0.33,-0.093,0.083,0.107,-0.235,0.028,-0.274,0.005,-0.221,-0.088,-0.419,0.08,0.175],[-0.224,-0.201,-0.098,-0.277,0.073,0.044,-0.07,-0.176,0.644,0.138,-0.248,-0.178,-0.106,0.066,-0.33,0.127,0.136,0.273,0.039,0.133],[-0.223,-0.282,-0.206,-0.223,-0.123,0.252,0.018,-0.29,0.013,-0.375,-0.25,0.135,0.003,-0.162,0.512,0.168,-0.203,-0.095,-0.061,-0.152],[-0.223,0.225,-0.527,0.032,-0.165,-0.132,-0.275,0.222,-0.051,0.034,0.114,-0.318,-0.013,-0.029,0.207,-0.114,-0.171,0.325,0.374,-0.048],[-0.224,0.172,-0.165,-0.268,-0.224,-0.391,0.243,0.094,-0.096,0.144,-0.199,-0.065,-0.007,0.478,0.148,0.005,0.08,-0.171,-0.43,0.08],[-0.224,0.123,0.028,-0.482,-0.044,-0.002,-0.144,0.398,-0.217,-0.22,0.023,0.15,-0.282,-0.314,-0.33,0.201,0.164,-0.199,0.075,-0.037]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7918,""AfterCleanSamNum"":5324,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":471,""version"":""v-2025-12-09 10:39:32"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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