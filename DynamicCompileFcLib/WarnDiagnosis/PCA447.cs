using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA447")]
    [FCDisplay("PCA447")]
    public partial class PCA447 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁146号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁146号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁146号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁146号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁147号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁147号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁147号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁147号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁147号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁147号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁148号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁148号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁148号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁148号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁148号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁148号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁149号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁149号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁149号屏3号管壁温")]
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

		public PCA447()
		{
			ModelID = 488;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA447";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""488"",""name"":""PCA447"",""description"":""中温分隔屏过热器水冷壁26-81-99"",""founder"":""admin"",""creatTime"":""2025-12-10 17:15:28"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:17:09"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 16:07:02"",""et"":""2025-12-07 18:16:34"",""duration"":2340572,""number"":7802,""filter"":2630,""mode"":5172,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2540}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah26ct181k"",""Description"":""中温（分隔屏）过热器水冷壁146号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""565.50"",""TMin"":""485.38"",""TAvg"":""534.17"",""DMax"":""4.04"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""3.07"",""C99"":""3.77""},{""PointId"":""d1_10hah26ct182k"",""Description"":""中温（分隔屏）过热器水冷壁146号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""571.98"",""TMin"":""492.22"",""TAvg"":""540.86"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.54"",""C99"":""3.11""},{""PointId"":""d1_10hah26ct183k"",""Description"":""中温（分隔屏）过热器水冷壁146号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""571.72"",""TMin"":""492.36"",""TAvg"":""540.44"",""DMax"":""3.62"",""DMin"":""0.00"",""DAvg"":""0.94"",""C95"":""3.21"",""C99"":""3.92""},{""PointId"":""d1_10hah26ct184k"",""Description"":""中温（分隔屏）过热器水冷壁146号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""571.68"",""TMin"":""493.95"",""TAvg"":""541.19"",""DMax"":""4.52"",""DMin"":""0.00"",""DAvg"":""1.16"",""C95"":""3.96"",""C99"":""4.85""},{""PointId"":""d1_10hah26ct185k"",""Description"":""中温（分隔屏）过热器水冷壁147号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""564.58"",""TMin"":""487.38"",""TAvg"":""534.80"",""DMax"":""4.38"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.62"",""C99"":""3.21""},{""PointId"":""d1_10hah26ct186k"",""Description"":""中温（分隔屏）过热器水冷壁147号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""565.10"",""TMin"":""486.23"",""TAvg"":""535.41"",""DMax"":""3.58"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.36"",""C99"":""2.89""},{""PointId"":""d1_10hah26ct187k"",""Description"":""中温（分隔屏）过热器水冷壁147号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""565.62"",""TMin"":""485.35"",""TAvg"":""535.39"",""DMax"":""4.32"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.95"",""C99"":""3.61""},{""PointId"":""d1_10hah26ct188k"",""Description"":""中温（分隔屏）过热器水冷壁147号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""571.08"",""TMin"":""492.20"",""TAvg"":""541.53"",""DMax"":""1.78"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.62"",""C99"":""1.98""},{""PointId"":""d1_10hah26ct189k"",""Description"":""中温（分隔屏）过热器水冷壁147号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""571.65"",""TMin"":""492.70"",""TAvg"":""541.93"",""DMax"":""2.59"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.21"",""C99"":""2.71""},{""PointId"":""d1_10hah26ct190k"",""Description"":""中温（分隔屏）过热器水冷壁147号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""570.93"",""TMin"":""493.38"",""TAvg"":""541.70"",""DMax"":""3.54"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.92"",""C99"":""3.57""},{""PointId"":""d1_10hah26ct191k"",""Description"":""中温（分隔屏）过热器水冷壁148号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""566.92"",""TMin"":""491.94"",""TAvg"":""537.92"",""DMax"":""3.59"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.80"",""C99"":""3.44""},{""PointId"":""d1_10hah26ct192k"",""Description"":""中温（分隔屏）过热器水冷壁148号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""567.82"",""TMin"":""489.43"",""TAvg"":""538.20"",""DMax"":""2.26"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.23"",""C99"":""2.72""},{""PointId"":""d1_10hah26ct193k"",""Description"":""中温（分隔屏）过热器水冷壁148号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""567.60"",""TMin"":""488.32"",""TAvg"":""537.34"",""DMax"":""2.94"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.36"",""C99"":""2.89""},{""PointId"":""d1_10hah26ct194k"",""Description"":""中温（分隔屏）过热器水冷壁148号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""572.78"",""TMin"":""494.78"",""TAvg"":""543.33"",""DMax"":""3.71"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.37"",""C99"":""2.90""},{""PointId"":""d1_10hah26ct195k"",""Description"":""中温（分隔屏）过热器水冷壁148号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""575.40"",""TMin"":""497.23"",""TAvg"":""545.67"",""DMax"":""4.32"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.78"",""C99"":""3.41""},{""PointId"":""d1_10hah26ct196k"",""Description"":""中温（分隔屏）过热器水冷壁148号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""575.88"",""TMin"":""499.82"",""TAvg"":""547.88"",""DMax"":""6.24"",""DMin"":""0.00"",""DAvg"":""1.44"",""C95"":""4.93"",""C99"":""6.03""},{""PointId"":""d1_10hah26ct197k"",""Description"":""中温（分隔屏）过热器水冷壁149号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""568.50"",""TMin"":""492.02"",""TAvg"":""538.64"",""DMax"":""3.85"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.97"",""C99"":""3.64""},{""PointId"":""d1_10hah26ct198k"",""Description"":""中温（分隔屏）过热器水冷壁149号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""569.10"",""TMin"":""491.46"",""TAvg"":""539.47"",""DMax"":""2.23"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.24"",""C99"":""2.74""},{""PointId"":""d1_10hah26ct199k"",""Description"":""中温（分隔屏）过热器水冷壁149号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""569.07"",""TMin"":""489.66"",""TAvg"":""538.61"",""DMax"":""2.73"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.63"",""C99"":""3.21""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:17:09"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[485.38,492.22,492.36,493.95,487.38,486.225,485.35,492.2,492.7,493.38,491.94,489.425,488.32,494.775,497.225,499.82,492.02,491.46,489.66],""Train_X_max"":[565.5,571.98,571.72,571.68,564.583,565.1,565.617,571.08,571.65,570.933,566.92,567.82,567.6,572.78,575.4,575.883,568.5,569.1,569.067],""Train_X_std"":[9.698,9.53,9.57,9.522,9.529,9.541,9.654,9.479,9.52,9.475,9.374,9.579,9.619,9.394,9.503,9.421,9.485,9.457,9.631],""Train_X_mean"":[534.172,540.862,540.437,541.186,534.797,535.405,535.385,541.53,541.929,541.702,537.916,538.204,537.337,543.327,545.673,547.878,538.637,539.469,538.608],""Train_X_bais_max"":[[4.037,3.167,3.623,4.523,4.382,3.584,4.316,1.781,2.594,3.541,3.587,2.262,2.936,3.708,4.322,6.237,3.849,2.226,2.725]],""Train_X_bais_min"":[[0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.868,0.741,0.943,1.159,0.756,0.669,0.841,0.471,0.644,0.848,0.805,0.653,0.694,0.685,0.795,1.444,0.86,0.659,0.783]],""QCUL_95"":0.7167999,""QCUL_99"":1.26635611,""QCUL_95_line"":[3.073,2.543,3.205,3.963,2.621,2.359,2.947,1.619,2.211,2.915,2.804,2.226,2.359,2.367,2.784,4.929,2.968,2.242,2.626],""QCUL_99_line"":[3.77,3.113,3.92,4.85,3.211,2.893,3.614,1.982,2.707,3.569,3.437,2.724,2.886,2.9,3.414,6.031,3.635,2.743,3.209],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.264,0.26,0.261,0.26,0.26,0.26,0.263,0.258,0.26,0.258,0.256,0.261,0.262,0.256,0.259,0.257,0.259,0.258,0.263],""T2CUL_99_line"":[0.348,0.341,0.343,0.341,0.341,0.342,0.346,0.34,0.341,0.34,0.336,0.343,0.345,0.337,0.341,0.338,0.34,0.339,0.345],""Kesi_95"":1.555,""Kesi_99"":1.314,""Kesi_95_line"":[0.168,0.165,0.166,0.165,0.165,0.165,0.167,0.164,0.165,0.164,0.163,0.166,0.167,0.163,0.165,0.163,0.164,0.164,0.167],""Kesi_99_line"":[0.155,0.152,0.153,0.152,0.152,0.152,0.154,0.151,0.152,0.151,0.149,0.153,0.153,0.15,0.151,0.15,0.151,0.151,0.154],""COV"":[[1.0,0.989,0.984,0.975,0.994,0.996,0.998,0.989,0.983,0.977,0.991,0.995,0.997,0.98,0.976,0.956,0.991,0.993,0.997],[0.989,1.0,0.999,0.996,0.985,0.987,0.986,0.997,0.995,0.994,0.982,0.986,0.987,0.994,0.992,0.983,0.981,0.985,0.986],[0.984,0.999,1.0,0.999,0.979,0.981,0.979,0.994,0.995,0.995,0.976,0.982,0.982,0.993,0.993,0.987,0.975,0.981,0.98],[0.975,0.996,0.999,1.0,0.973,0.974,0.971,0.991,0.994,0.996,0.97,0.975,0.974,0.992,0.992,0.991,0.968,0.975,0.972],[0.994,0.985,0.979,0.973,1.0,0.998,0.996,0.99,0.985,0.98,0.999,0.998,0.996,0.985,0.982,0.964,0.999,0.997,0.997],[0.996,0.987,0.981,0.974,0.998,1.0,0.999,0.991,0.987,0.982,0.997,0.999,0.999,0.985,0.982,0.964,0.996,0.998,0.998],[0.998,0.986,0.979,0.971,0.996,0.999,1.0,0.99,0.984,0.978,0.994,0.997,0.999,0.981,0.978,0.957,0.994,0.995,0.998],[0.989,0.997,0.994,0.991,0.99,0.991,0.99,1.0,0.999,0.996,0.988,0.991,0.991,0.998,0.996,0.986,0.987,0.991,0.99],[0.983,0.995,0.995,0.994,0.985,0.987,0.984,0.999,1.0,0.999,0.984,0.987,0.987,0.999,0.999,0.992,0.983,0.988,0.985],[0.977,0.994,0.995,0.996,0.98,0.982,0.978,0.996,0.999,1.0,0.979,0.983,0.982,0.998,0.999,0.996,0.978,0.983,0.98],[0.991,0.982,0.976,0.97,0.999,0.997,0.994,0.988,0.984,0.979,1.0,0.998,0.996,0.984,0.982,0.964,1.0,0.998,0.997],[0.995,0.986,0.982,0.975,0.998,0.999,0.997,0.991,0.987,0.983,0.998,1.0,0.999,0.987,0.985,0.967,0.998,0.999,0.999],[0.997,0.987,0.982,0.974,0.996,0.999,0.999,0.991,0.987,0.982,0.996,0.999,1.0,0.986,0.983,0.964,0.996,0.998,1.0],[0.98,0.994,0.993,0.992,0.985,0.985,0.981,0.998,0.999,0.998,0.984,0.987,0.986,1.0,0.999,0.993,0.984,0.988,0.985],[0.976,0.992,0.993,0.992,0.982,0.982,0.978,0.996,0.999,0.999,0.982,0.985,0.983,0.999,1.0,0.995,0.982,0.986,0.982],[0.956,0.983,0.987,0.991,0.964,0.964,0.957,0.986,0.992,0.996,0.964,0.967,0.964,0.993,0.995,1.0,0.962,0.969,0.961],[0.991,0.981,0.975,0.968,0.999,0.996,0.994,0.987,0.983,0.978,1.0,0.998,0.996,0.984,0.982,0.962,1.0,0.998,0.997],[0.993,0.985,0.981,0.975,0.997,0.998,0.995,0.991,0.988,0.983,0.998,0.999,0.998,0.988,0.986,0.969,0.998,1.0,0.999],[0.997,0.986,0.98,0.972,0.997,0.998,0.998,0.99,0.985,0.98,0.997,0.999,1.0,0.985,0.982,0.961,0.997,0.999,1.0]],""K"":1,""R"":0.988,""featValue"":[18.778,0.165,0.035,0.009,0.006,0.005,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.229,0.207,0.419,0.002,0.01,0.038,-0.067,0.272,0.271,-0.193,0.234,-0.088,0.295,0.202,0.294,-0.114,-0.47,0.15,0.073],[0.23,-0.142,0.376,-0.123,0.199,-0.312,0.274,0.039,0.091,0.132,0.005,0.055,0.335,-0.348,0.113,0.115,0.37,-0.045,-0.361],[0.229,-0.232,0.369,-0.207,-0.177,-0.166,-0.086,-0.316,0.009,-0.211,-0.127,-0.156,-0.577,-0.117,0.258,0.112,-0.052,-0.035,0.184],[0.228,-0.327,0.29,-0.404,-0.195,0.181,-0.013,0.107,-0.13,0.189,-0.067,0.217,0.088,0.354,-0.499,-0.137,0.02,0.025,0.077],[0.23,0.208,-0.101,-0.344,0.445,0.123,-0.054,-0.016,-0.039,-0.195,0.24,-0.392,-0.095,-0.192,-0.315,-0.238,-0.007,-0.325,-0.008],[0.23,0.2,0.023,0.075,0.084,0.458,0.309,-0.433,0.117,0.152,0.076,-0.075,-0.084,0.346,0.22,-0.129,0.339,0.2,-0.082],[0.229,0.237,0.206,0.323,0.203,0.243,-0.053,0.178,0.041,-0.236,-0.434,0.088,-0.042,0.061,-0.235,0.491,0.118,-0.173,0.098],[0.23,-0.096,0.047,0.333,0.388,-0.126,0.119,-0.134,-0.261,0.341,-0.276,0.157,-0.109,-0.019,0.031,-0.333,-0.453,-0.097,-0.034],[0.23,-0.186,-0.055,0.26,0.117,0.038,-0.34,-0.259,0.304,-0.129,0.259,0.35,0.062,-0.328,-0.24,-0.117,0.093,0.324,0.221],[0.229,-0.259,-0.082,0.069,0.021,0.292,-0.482,0.074,-0.204,0.4,0.266,-0.183,0.054,-0.019,0.253,0.364,-0.026,-0.144,-0.136],[0.229,0.22,-0.267,-0.363,0.085,-0.026,-0.03,0.1,-0.145,-0.088,0.033,0.637,-0.019,0.029,0.394,0.012,0.087,-0.207,0.188],[0.23,0.186,-0.073,-0.061,-0.328,0.138,0.135,-0.262,-0.499,-0.133,-0.136,-0.137,0.399,-0.352,-0.032,0.089,-0.164,0.224,0.126],[0.23,0.197,0.049,0.23,-0.314,0.012,-0.027,0.306,-0.249,-0.157,0.212,0.146,-0.389,-0.091,-0.099,-0.199,0.077,0.12,-0.528],[0.23,-0.188,-0.181,0.177,0.101,-0.308,0.447,0.121,-0.185,-0.081,0.444,-0.085,-0.091,0.245,-0.121,0.33,-0.015,0.106,0.282],[0.229,-0.228,-0.237,0.139,-0.1,-0.254,-0.209,-0.259,0.005,-0.427,-0.142,-0.083,0.298,0.405,0.041,-0.124,0.067,-0.262,-0.288],[0.227,-0.43,-0.351,-0.028,-0.043,0.308,0.257,0.415,0.248,-0.128,-0.297,-0.15,-0.043,-0.204,0.18,-0.167,-0.011,0.106,0.031],[0.229,0.23,-0.271,-0.289,0.15,-0.322,-0.222,0.036,0.139,0.192,-0.27,-0.131,-0.103,0.139,-0.091,0.189,-0.07,0.548,-0.186],[0.23,0.172,-0.18,-0.004,-0.401,-0.036,0.209,-0.176,0.483,0.274,0.072,0.081,-0.033,-0.114,-0.19,0.178,-0.298,-0.382,-0.105],[0.23,0.223,0.017,0.208,-0.247,-0.275,-0.167,0.213,0.008,0.297,-0.097,-0.253,0.052,0.005,0.041,-0.322,0.395,-0.132,0.449]],""selectVec"":[[0.229],[0.23],[0.229],[0.228],[0.23],[0.23],[0.229],[0.23],[0.23],[0.229],[0.229],[0.23],[0.23],[0.23],[0.229],[0.227],[0.229],[0.23],[0.23]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7802,""AfterCleanSamNum"":5172,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.8%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":488,""version"":""v-2025-12-10 17:17:09"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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