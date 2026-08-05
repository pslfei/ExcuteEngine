using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA427")]
    [FCDisplay("PCA427")]
    public partial class PCA427 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁63号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁64号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁64号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁64号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁64号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁64号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁64号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁65号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁65号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁65号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁65号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁65号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁65号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁66号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁66号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁66号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁66号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁66号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁66号屏6号管壁温")]
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

		public PCA427()
		{
			ModelID = 468;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA427";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""468"",""name"":""PCA427"",""description"":""中温分隔屏过热器水冷壁22-81-99"",""founder"":""admin"",""creatTime"":""2025-12-09 10:29:52"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:31:44"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 17:48:02"",""et"":""2025-12-07 00:25:22"",""duration"":2356640,""number"":7856,""filter"":2594,""mode"":5262,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2504}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah21ct181k"",""Description"":""中温（分隔屏）过热器水冷壁63号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""579.05"",""TMin"":""498.29"",""TAvg"":""547.23"",""DMax"":""4.50"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.65"",""C99"":""4.47""},{""PointId"":""d1_10hah21ct182k"",""Description"":""中温（分隔屏）过热器水冷壁64号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""573.02"",""TMin"":""490.57"",""TAvg"":""539.83"",""DMax"":""4.65"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.29"",""C99"":""2.81""},{""PointId"":""d1_10hah21ct183k"",""Description"":""中温（分隔屏）过热器水冷壁64号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""573.92"",""TMin"":""491.17"",""TAvg"":""541.49"",""DMax"":""3.20"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.64"",""C99"":""2.00""},{""PointId"":""d1_10hah21ct184k"",""Description"":""中温（分隔屏）过热器水冷壁64号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""572.20"",""TMin"":""489.59"",""TAvg"":""540.47"",""DMax"":""2.71"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.56"",""C99"":""1.91""},{""PointId"":""d1_10hah21ct185k"",""Description"":""中温（分隔屏）过热器水冷壁64号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""580.73"",""TMin"":""498.57"",""TAvg"":""548.59"",""DMax"":""3.28"",""DMin"":""0.00"",""DAvg"":""0.97"",""C95"":""3.25"",""C99"":""3.98""},{""PointId"":""d1_10hah21ct186k"",""Description"":""中温（分隔屏）过热器水冷壁64号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""582.38"",""TMin"":""501.33"",""TAvg"":""549.90"",""DMax"":""4.19"",""DMin"":""0.00"",""DAvg"":""1.16"",""C95"":""3.91"",""C99"":""4.78""},{""PointId"":""d1_10hah21ct187k"",""Description"":""中温（分隔屏）过热器水冷壁64号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""582.53"",""TMin"":""502.67"",""TAvg"":""551.10"",""DMax"":""5.15"",""DMin"":""0.00"",""DAvg"":""1.59"",""C95"":""5.35"",""C99"":""6.54""},{""PointId"":""d1_10hah21ct188k"",""Description"":""中温（分隔屏）过热器水冷壁65号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""571.40"",""TMin"":""491.30"",""TAvg"":""538.59"",""DMax"":""4.13"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.17"",""C99"":""3.88""},{""PointId"":""d1_10hah21ct189k"",""Description"":""中温（分隔屏）过热器水冷壁65号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""571.98"",""TMin"":""491.89"",""TAvg"":""539.95"",""DMax"":""3.47"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.28"",""C99"":""4.01""},{""PointId"":""d1_10hah21ct190k"",""Description"":""中温（分隔屏）过热器水冷壁65号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""574.16"",""TMin"":""493.11"",""TAvg"":""541.96"",""DMax"":""3.67"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.58"",""C99"":""4.37""},{""PointId"":""d1_10hah21ct191k"",""Description"":""中温（分隔屏）过热器水冷壁65号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""579.17"",""TMin"":""499.89"",""TAvg"":""546.76"",""DMax"":""2.71"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.36"",""C99"":""1.67""},{""PointId"":""d1_10hah21ct192k"",""Description"":""中温（分隔屏）过热器水冷壁65号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""582.25"",""TMin"":""505.89"",""TAvg"":""551.12"",""DMax"":""4.60"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.92"",""C99"":""3.58""},{""PointId"":""d1_10hah21ct193k"",""Description"":""中温（分隔屏）过热器水冷壁65号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""582.60"",""TMin"":""508.35"",""TAvg"":""552.73"",""DMax"":""8.19"",""DMin"":""0.00"",""DAvg"":""1.39"",""C95"":""4.68"",""C99"":""5.73""},{""PointId"":""d1_10hah21ct194k"",""Description"":""中温（分隔屏）过热器水冷壁66号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""568.22"",""TMin"":""486.47"",""TAvg"":""535.93"",""DMax"":""4.30"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.69"",""C99"":""4.51""},{""PointId"":""d1_10hah21ct195k"",""Description"":""中温（分隔屏）过热器水冷壁66号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""569.70"",""TMin"":""486.03"",""TAvg"":""537.32"",""DMax"":""3.81"",""DMin"":""0.00"",""DAvg"":""1.05"",""C95"":""3.56"",""C99"":""4.35""},{""PointId"":""d1_10hah21ct196k"",""Description"":""中温（分隔屏）过热器水冷壁66号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""566.08"",""TMin"":""481.68"",""TAvg"":""534.05"",""DMax"":""4.90"",""DMin"":""0.00"",""DAvg"":""1.47"",""C95"":""4.98"",""C99"":""6.08""},{""PointId"":""d1_10hah21ct197k"",""Description"":""中温（分隔屏）过热器水冷壁66号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""572.98"",""TMin"":""490.32"",""TAvg"":""540.49"",""DMax"":""4.25"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.19"",""C99"":""2.69""},{""PointId"":""d1_10hah21ct198k"",""Description"":""中温（分隔屏）过热器水冷壁66号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""574.78"",""TMin"":""494.45"",""TAvg"":""543.07"",""DMax"":""3.13"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.69"",""C99"":""2.07""},{""PointId"":""d1_10hah21ct199k"",""Description"":""中温（分隔屏）过热器水冷壁66号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""574.90"",""TMin"":""497.28"",""TAvg"":""544.36"",""DMax"":""4.77"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.85"",""C99"":""3.49""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:31:44"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[498.286,490.571,491.171,489.586,498.571,501.329,502.671,491.3,491.886,493.114,499.886,505.886,508.35,486.471,486.029,481.683,490.318,494.45,497.281],""Train_X_max"":[579.05,573.017,573.917,572.2,580.733,582.383,582.533,571.4,571.983,574.16,579.167,582.25,582.6,568.217,569.7,566.08,572.975,574.775,574.9],""Train_X_std"":[8.756,8.782,8.884,8.927,8.882,8.899,8.773,8.797,8.933,9.061,8.805,8.692,8.559,8.889,9.072,9.301,9.0,8.82,8.637],""Train_X_mean"":[547.234,539.825,541.486,540.47,548.588,549.9,551.096,538.589,539.947,541.956,546.759,551.123,552.732,535.928,537.318,534.05,540.492,543.074,544.359],""Train_X_bais_max"":[[4.503,4.645,3.199,2.705,3.283,4.194,5.15,4.131,3.471,3.672,2.707,4.599,8.192,4.304,3.806,4.9,4.245,3.134,4.772]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.001,0.0,0.001,0.0,0.0,0.0,0.001,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.077,0.642,0.472,0.437,0.973,1.163,1.593,0.927,0.983,1.075,0.381,0.857,1.385,1.087,1.047,1.473,0.641,0.476,0.833]],""QCUL_95"":1.158511,""QCUL_99"":2.08119965,""QCUL_95_line"":[3.653,2.291,1.635,1.556,3.254,3.909,5.354,3.173,3.279,3.576,1.357,2.922,4.684,3.689,3.556,4.975,2.194,1.69,2.854],""QCUL_99_line"":[4.468,2.812,2.002,1.91,3.976,4.777,6.543,3.883,4.006,4.367,1.666,3.575,5.727,4.512,4.349,6.083,2.685,2.074,3.493],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.237,0.237,0.24,0.241,0.24,0.241,0.237,0.238,0.241,0.245,0.238,0.235,0.231,0.24,0.245,0.251,0.243,0.238,0.233],""T2CUL_99_line"":[0.311,0.312,0.316,0.317,0.316,0.316,0.312,0.313,0.317,0.322,0.313,0.309,0.304,0.316,0.322,0.33,0.32,0.313,0.307],""Kesi_95"":1.558,""Kesi_99"":1.321,""Kesi_95_line"":[0.151,0.151,0.153,0.154,0.153,0.153,0.151,0.151,0.154,0.156,0.152,0.15,0.147,0.153,0.156,0.16,0.155,0.152,0.149],""Kesi_99_line"":[0.139,0.139,0.141,0.141,0.141,0.141,0.139,0.139,0.142,0.144,0.14,0.138,0.136,0.141,0.144,0.147,0.143,0.14,0.137],""COV"":[[1.0,0.978,0.981,0.982,0.997,0.997,0.996,0.963,0.962,0.96,0.986,0.995,0.993,0.958,0.96,0.945,0.977,0.988,0.997],[0.978,1.0,0.998,0.995,0.983,0.978,0.963,0.995,0.992,0.99,0.991,0.98,0.965,0.994,0.992,0.984,0.993,0.99,0.981],[0.981,0.998,1.0,0.999,0.986,0.981,0.967,0.995,0.995,0.992,0.995,0.985,0.971,0.992,0.993,0.985,0.995,0.993,0.985],[0.982,0.995,0.999,1.0,0.987,0.982,0.968,0.992,0.993,0.993,0.996,0.986,0.971,0.991,0.993,0.986,0.996,0.994,0.986],[0.997,0.983,0.986,0.987,1.0,0.998,0.994,0.969,0.968,0.965,0.989,0.995,0.991,0.964,0.966,0.951,0.98,0.989,0.995],[0.997,0.978,0.981,0.982,0.998,1.0,0.994,0.962,0.961,0.958,0.985,0.995,0.99,0.957,0.96,0.943,0.976,0.985,0.993],[0.996,0.963,0.967,0.968,0.994,0.994,1.0,0.944,0.942,0.937,0.973,0.989,0.995,0.936,0.937,0.918,0.958,0.975,0.991],[0.963,0.995,0.995,0.992,0.969,0.962,0.944,1.0,0.998,0.997,0.99,0.972,0.953,0.998,0.996,0.992,0.993,0.987,0.972],[0.962,0.992,0.995,0.993,0.968,0.961,0.942,0.998,1.0,0.999,0.991,0.974,0.954,0.996,0.997,0.994,0.993,0.986,0.972],[0.96,0.99,0.992,0.993,0.965,0.958,0.937,0.997,0.999,1.0,0.991,0.971,0.949,0.996,0.997,0.997,0.994,0.987,0.969],[0.986,0.991,0.995,0.996,0.989,0.985,0.973,0.99,0.991,0.991,1.0,0.993,0.981,0.986,0.988,0.98,0.995,0.997,0.992],[0.995,0.98,0.985,0.986,0.995,0.995,0.989,0.972,0.974,0.971,0.993,1.0,0.995,0.967,0.969,0.955,0.982,0.991,0.997],[0.993,0.965,0.971,0.971,0.991,0.99,0.995,0.953,0.954,0.949,0.981,0.995,1.0,0.944,0.946,0.928,0.963,0.979,0.994],[0.958,0.994,0.992,0.991,0.964,0.957,0.936,0.998,0.996,0.996,0.986,0.967,0.944,1.0,0.998,0.995,0.993,0.984,0.968],[0.96,0.992,0.993,0.993,0.966,0.96,0.937,0.996,0.997,0.997,0.988,0.969,0.946,0.998,1.0,0.997,0.995,0.987,0.97],[0.945,0.984,0.985,0.986,0.951,0.943,0.918,0.992,0.994,0.997,0.98,0.955,0.928,0.995,0.997,1.0,0.991,0.98,0.956],[0.977,0.993,0.995,0.996,0.98,0.976,0.958,0.993,0.993,0.994,0.995,0.982,0.963,0.993,0.995,0.991,1.0,0.997,0.985],[0.988,0.99,0.993,0.994,0.989,0.985,0.975,0.987,0.986,0.987,0.997,0.991,0.979,0.984,0.987,0.98,0.997,1.0,0.994],[0.997,0.981,0.985,0.986,0.995,0.993,0.991,0.972,0.972,0.969,0.992,0.997,0.994,0.968,0.97,0.956,0.985,0.994,1.0]],""K"":1,""R"":0.982,""featValue"":[18.657,0.281,0.021,0.017,0.01,0.005,0.004,0.002,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.229,-0.268,-0.069,0.174,-0.074,-0.097,0.205,0.504,0.674,0.114,-0.087,-0.16,-0.026,0.022,-0.09,-0.126,-0.013,0.029,-0.055],[-0.23,0.093,-0.49,-0.143,-0.281,0.052,-0.235,0.092,-0.1,0.082,0.245,-0.178,0.496,0.096,0.071,-0.103,-0.33,0.195,0.092],[-0.231,0.074,-0.249,-0.141,0.134,-0.242,0.183,0.257,-0.334,0.378,-0.169,-0.153,-0.055,0.126,0.097,0.477,0.325,-0.038,-0.121],[-0.231,0.063,-0.133,0.054,0.368,-0.379,0.087,-0.276,0.045,0.308,0.423,0.004,-0.301,-0.086,-0.044,-0.206,-0.301,-0.206,0.095],[-0.23,-0.226,-0.237,0.081,0.261,-0.018,-0.18,-0.417,-0.02,-0.001,-0.535,-0.136,-0.024,0.067,-0.153,-0.267,0.086,0.354,-0.144],[-0.229,-0.268,-0.273,0.186,0.303,0.475,-0.048,0.211,-0.153,-0.345,0.108,0.14,-0.309,0.175,0.127,0.189,-0.181,-0.084,0.104],[-0.226,-0.405,-0.195,-0.036,-0.123,-0.323,-0.021,-0.101,-0.017,-0.294,0.139,0.41,0.247,-0.309,0.014,0.021,0.38,-0.193,0.047],[-0.23,0.219,-0.081,-0.34,-0.269,0.021,-0.306,0.032,0.105,-0.208,0.074,-0.071,-0.468,-0.274,-0.197,0.095,-0.014,0.013,-0.45],[-0.23,0.224,0.127,-0.331,0.119,-0.043,0.142,0.39,-0.249,-0.127,-0.19,0.16,-0.096,-0.165,-0.12,-0.429,0.029,0.171,0.423],[-0.229,0.249,0.224,-0.09,0.256,-0.091,-0.214,0.075,0.139,-0.131,0.153,0.245,0.201,0.601,0.075,-0.174,0.2,-0.073,-0.314],[-0.231,0.002,0.282,-0.072,0.152,0.05,-0.446,-0.037,0.249,0.253,-0.125,0.238,0.132,-0.128,-0.176,0.475,-0.153,0.086,0.343],[-0.23,-0.195,0.28,-0.155,0.206,0.485,0.068,-0.051,-0.047,0.241,0.336,-0.275,0.178,-0.311,0.086,-0.138,0.3,0.064,-0.156],[-0.227,-0.342,0.331,-0.419,-0.109,-0.145,0.143,-0.145,-0.054,-0.194,-0.206,-0.286,0.043,0.172,0.233,0.069,-0.371,-0.281,0.011],[-0.229,0.263,-0.178,-0.105,-0.307,0.296,0.177,-0.366,0.305,0.102,-0.093,0.061,-0.184,0.18,0.245,-0.033,0.297,-0.165,0.36],[-0.229,0.255,-0.029,0.093,0.025,0.214,0.494,-0.105,-0.006,0.018,-0.21,0.359,0.286,-0.189,-0.159,0.088,-0.325,-0.103,-0.361],[-0.227,0.348,0.118,0.31,0.145,-0.205,0.132,-0.098,0.101,-0.483,0.097,-0.368,0.107,-0.177,0.196,0.247,0.063,0.276,0.126],[-0.231,0.117,0.104,0.409,-0.155,0.061,-0.221,0.062,-0.236,-0.007,-0.123,-0.294,0.089,0.007,-0.381,-0.127,0.097,-0.574,0.095],[-0.231,-0.016,0.226,0.378,-0.28,-0.08,-0.202,0.096,-0.189,0.234,-0.12,0.214,-0.158,-0.142,0.589,-0.164,-0.106,0.122,-0.147],[-0.23,-0.196,0.242,0.14,-0.373,-0.035,0.246,-0.125,-0.208,0.039,0.284,0.089,-0.154,0.333,-0.409,0.107,0.023,0.405,0.054]],""selectVec"":[[-0.229],[-0.23],[-0.231],[-0.231],[-0.23],[-0.229],[-0.226],[-0.23],[-0.23],[-0.229],[-0.231],[-0.23],[-0.227],[-0.229],[-0.229],[-0.227],[-0.231],[-0.231],[-0.23]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7856,""AfterCleanSamNum"":5262,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.2%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":468,""version"":""v-2025-12-09 10:31:44"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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