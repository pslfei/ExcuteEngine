using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA393")]
    [FCDisplay("PCA393")]
    public partial class PCA393 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁1号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁1号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁1号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁1号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁1号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁1号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁2号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁2号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁2号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁2号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁2号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁2号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁3号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁3号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁3号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁3号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁3号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁3号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁4号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁4号屏2号管壁温")]
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

		public PCA393()
		{
			ModelID = 433;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA393";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""433"",""name"":""PCA393"",""description"":""中温分隔屏过热器壁温1-20"",""founder"":""admin"",""creatTime"":""2025-12-03 11:28:45"",""Modifier"":""admin"",""modifiedTime"":""2025-12-03 14:28:57"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-03 13:46:00"",""et"":""2025-11-27 13:32:12"",""duration"":2072772,""number"":6910,""filter"":2039,""mode"":4871,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1949}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah17ct101k"",""Description"":""中温（分隔屏）过热器水冷壁1号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""531.22"",""TMin"":""437.78"",""TAvg"":""492.78"",""DMax"":""3.19"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.85"",""C99"":""2.28""},{""PointId"":""d1_10hah17ct102k"",""Description"":""中温（分隔屏）过热器水冷壁1号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""533.43"",""TMin"":""434.36"",""TAvg"":""494.18"",""DMax"":""2.09"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.50"",""C99"":""1.84""},{""PointId"":""d1_10hah17ct103k"",""Description"":""中温（分隔屏）过热器水冷壁1号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""531.58"",""TMin"":""430.95"",""TAvg"":""492.05"",""DMax"":""2.64"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.82"",""C99"":""2.23""},{""PointId"":""d1_10hah17ct104k"",""Description"":""中温（分隔屏）过热器水冷壁1号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""533.24"",""TMin"":""435.62"",""TAvg"":""493.89"",""DMax"":""1.33"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.60"",""C99"":""0.73""},{""PointId"":""d1_10hah17ct105k"",""Description"":""中温（分隔屏）过热器水冷壁1号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""532.24"",""TMin"":""435.37"",""TAvg"":""492.77"",""DMax"":""1.35"",""DMin"":""0.00"",""DAvg"":""0.23"",""C95"":""0.80"",""C99"":""0.98""},{""PointId"":""d1_10hah17ct106k"",""Description"":""中温（分隔屏）过热器水冷壁1号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""533.35"",""TMin"":""437.94"",""TAvg"":""493.39"",""DMax"":""3.25"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.84"",""C99"":""2.26""},{""PointId"":""d1_10hah17ct107k"",""Description"":""中温（分隔屏）过热器水冷壁2号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""540.34"",""TMin"":""444.93"",""TAvg"":""504.13"",""DMax"":""1.85"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.46"",""C99"":""1.79""},{""PointId"":""d1_10hah17ct108k"",""Description"":""中温（分隔屏）过热器水冷壁2号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""541.66"",""TMin"":""444.70"",""TAvg"":""506.24"",""DMax"":""2.27"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.49"",""C99"":""1.83""},{""PointId"":""d1_10hah17ct109k"",""Description"":""中温（分隔屏）过热器水冷壁2号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""539.07"",""TMin"":""441.28"",""TAvg"":""503.44"",""DMax"":""3.83"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.18"",""C99"":""2.67""},{""PointId"":""d1_10hah17ct110k"",""Description"":""中温（分隔屏）过热器水冷壁2号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""542.02"",""TMin"":""445.43"",""TAvg"":""506.29"",""DMax"":""1.95"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.40"",""C99"":""1.71""},{""PointId"":""d1_10hah17ct111k"",""Description"":""中温（分隔屏）过热器水冷壁2号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""543.50"",""TMin"":""447.06"",""TAvg"":""507.26"",""DMax"":""1.71"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.35"",""C99"":""1.65""},{""PointId"":""d1_10hah17ct112k"",""Description"":""中温（分隔屏）过热器水冷壁2号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""542.92"",""TMin"":""446.88"",""TAvg"":""506.03"",""DMax"":""2.82"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.74"",""C99"":""2.13""},{""PointId"":""d1_10hah17ct113k"",""Description"":""中温（分隔屏）过热器水冷壁3号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""543.72"",""TMin"":""449.52"",""TAvg"":""509.47"",""DMax"":""2.39"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.55"",""C99"":""1.91""},{""PointId"":""d1_10hah17ct114k"",""Description"":""中温（分隔屏）过热器水冷壁3号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""544.20"",""TMin"":""449.65"",""TAvg"":""510.45"",""DMax"":""1.74"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.02"",""C99"":""1.25""},{""PointId"":""d1_10hah17ct115k"",""Description"":""中温（分隔屏）过热器水冷壁3号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""543.74"",""TMin"":""446.73"",""TAvg"":""510.07"",""DMax"":""3.37"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.24"",""C99"":""2.74""},{""PointId"":""d1_10hah17ct116k"",""Description"":""中温（分隔屏）过热器水冷壁3号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""547.54"",""TMin"":""451.82"",""TAvg"":""513.71"",""DMax"":""1.69"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.13"",""C99"":""1.39""},{""PointId"":""d1_10hah17ct117k"",""Description"":""中温（分隔屏）过热器水冷壁3号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""548.38"",""TMin"":""453.17"",""TAvg"":""513.91"",""DMax"":""2.81"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.59"",""C99"":""1.95""},{""PointId"":""d1_10hah17ct118k"",""Description"":""中温（分隔屏）过热器水冷壁3号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""548.60"",""TMin"":""454.20"",""TAvg"":""513.49"",""DMax"":""4.57"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.66"",""C99"":""3.27""},{""PointId"":""d1_10hah17ct119k"",""Description"":""中温（分隔屏）过热器水冷壁4号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""550.26"",""TMin"":""455.67"",""TAvg"":""515.98"",""DMax"":""3.32"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.10"",""C99"":""2.57""},{""PointId"":""d1_10hah17ct120k"",""Description"":""中温（分隔屏）过热器水冷壁4号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""550.78"",""TMin"":""454.80"",""TAvg"":""515.57"",""DMax"":""2.54"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.40"",""C99"":""1.71""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-03 14:28:57"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[437.783,434.36,430.95,435.617,435.367,437.94,444.933,444.7,441.283,445.433,447.06,446.88,449.517,449.65,446.733,451.817,453.167,454.2,455.667,454.8],""Train_X_max"":[531.217,533.433,531.583,533.24,532.24,533.35,540.34,541.66,539.067,542.02,543.5,542.92,543.72,544.2,543.74,547.54,548.38,548.6,550.26,550.775],""Train_X_std"":[12.04,12.078,12.16,12.211,12.221,12.511,11.268,11.051,10.87,10.907,11.051,11.337,10.92,10.757,10.771,10.786,10.851,11.016,10.931,10.83],""Train_X_mean"":[492.784,494.18,492.049,493.889,492.768,493.394,504.131,506.238,503.438,506.294,507.257,506.03,509.474,510.445,510.066,513.705,513.911,513.485,515.979,515.573],""Train_X_bais_max"":[[3.19,2.09,2.638,1.332,1.347,3.25,1.845,2.271,3.827,1.952,1.708,2.824,2.392,1.74,3.366,1.687,2.814,4.568,3.316,2.541]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.523,0.434,0.524,0.161,0.228,0.519,0.427,0.418,0.618,0.409,0.387,0.497,0.446,0.289,0.648,0.323,0.458,0.745,0.6,0.401]],""QCUL_95"":0.163486317,""QCUL_99"":0.261299133,""QCUL_95_line"":[1.854,1.5,1.821,0.595,0.799,1.839,1.46,1.488,2.177,1.395,1.348,1.736,1.554,1.02,2.24,1.132,1.588,2.662,2.096,1.397],""QCUL_99_line"":[2.275,1.837,2.231,0.732,0.98,2.257,1.787,1.827,2.67,1.707,1.652,2.128,1.905,1.251,2.744,1.388,1.946,3.269,2.569,1.713],""T2CUL_95"":5.998,""T2CUL_99"":9.223,""T2CUL_95_line"":[0.422,0.424,0.427,0.428,0.429,0.439,0.395,0.388,0.381,0.383,0.388,0.398,0.383,0.377,0.378,0.378,0.381,0.387,0.384,0.38],""T2CUL_99_line"":[0.524,0.526,0.529,0.531,0.532,0.544,0.49,0.481,0.473,0.475,0.481,0.493,0.475,0.468,0.469,0.469,0.472,0.479,0.476,0.471],""Kesi_95"":1.578,""Kesi_99"":1.391,""Kesi_95_line"":[0.217,0.217,0.219,0.22,0.22,0.225,0.203,0.199,0.196,0.196,0.199,0.204,0.197,0.194,0.194,0.194,0.195,0.198,0.197,0.195],""Kesi_99_line"":[0.203,0.204,0.206,0.206,0.207,0.211,0.19,0.187,0.184,0.184,0.187,0.192,0.185,0.182,0.182,0.182,0.183,0.186,0.185,0.183],""COV"":[[1.0,0.997,0.996,0.998,0.997,0.996,0.966,0.943,0.935,0.938,0.952,0.969,0.92,0.89,0.868,0.884,0.9,0.924,0.882,0.851],[0.997,1.0,1.0,0.998,0.997,0.993,0.978,0.962,0.955,0.957,0.968,0.981,0.939,0.914,0.897,0.909,0.923,0.942,0.905,0.877],[0.996,1.0,1.0,0.999,0.997,0.993,0.973,0.957,0.952,0.953,0.965,0.978,0.933,0.907,0.891,0.903,0.917,0.936,0.896,0.869],[0.998,0.998,0.999,1.0,1.0,0.997,0.972,0.952,0.945,0.95,0.963,0.978,0.929,0.901,0.882,0.899,0.915,0.937,0.893,0.863],[0.997,0.997,0.997,1.0,1.0,0.999,0.968,0.946,0.939,0.945,0.959,0.976,0.923,0.894,0.874,0.892,0.909,0.933,0.885,0.855],[0.996,0.993,0.993,0.997,0.999,1.0,0.958,0.933,0.924,0.933,0.948,0.969,0.909,0.877,0.854,0.876,0.895,0.922,0.87,0.837],[0.966,0.978,0.973,0.972,0.968,0.958,1.0,0.996,0.991,0.994,0.996,0.996,0.99,0.976,0.963,0.973,0.98,0.988,0.973,0.956],[0.943,0.962,0.957,0.952,0.946,0.933,0.996,1.0,0.999,0.998,0.997,0.99,0.995,0.99,0.983,0.986,0.99,0.99,0.984,0.974],[0.935,0.955,0.952,0.945,0.939,0.924,0.991,0.999,1.0,0.998,0.995,0.986,0.993,0.991,0.987,0.988,0.991,0.988,0.982,0.975],[0.938,0.957,0.953,0.95,0.945,0.933,0.994,0.998,0.998,1.0,0.999,0.992,0.994,0.989,0.983,0.99,0.994,0.995,0.983,0.974],[0.952,0.968,0.965,0.963,0.959,0.948,0.996,0.997,0.995,0.999,1.0,0.997,0.99,0.982,0.973,0.983,0.989,0.994,0.976,0.964],[0.969,0.981,0.978,0.978,0.976,0.969,0.996,0.99,0.986,0.992,0.997,1.0,0.981,0.967,0.953,0.968,0.978,0.989,0.962,0.944],[0.92,0.939,0.933,0.929,0.923,0.909,0.99,0.995,0.993,0.994,0.99,0.981,1.0,0.996,0.989,0.994,0.995,0.994,0.996,0.988],[0.89,0.914,0.907,0.901,0.894,0.877,0.976,0.99,0.991,0.989,0.982,0.967,0.996,1.0,0.997,0.998,0.996,0.989,0.997,0.996],[0.868,0.897,0.891,0.882,0.874,0.854,0.963,0.983,0.987,0.983,0.973,0.953,0.989,0.997,1.0,0.996,0.991,0.979,0.992,0.994],[0.884,0.909,0.903,0.899,0.892,0.876,0.973,0.986,0.988,0.99,0.983,0.968,0.994,0.998,0.996,1.0,0.999,0.992,0.996,0.995],[0.9,0.923,0.917,0.915,0.909,0.895,0.98,0.99,0.991,0.994,0.989,0.978,0.995,0.996,0.991,0.999,1.0,0.997,0.994,0.99],[0.924,0.942,0.936,0.937,0.933,0.922,0.988,0.99,0.988,0.995,0.994,0.989,0.994,0.989,0.979,0.992,0.997,1.0,0.988,0.979],[0.882,0.905,0.896,0.893,0.885,0.87,0.973,0.984,0.982,0.983,0.976,0.962,0.996,0.997,0.992,0.996,0.994,0.988,1.0,0.997],[0.851,0.877,0.869,0.863,0.855,0.837,0.956,0.974,0.975,0.974,0.964,0.944,0.988,0.996,0.994,0.995,0.99,0.979,0.997,1.0]],""K"":2,""R"":0.997,""featValue"":[19.235,0.711,0.031,0.019,0.003,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.219,0.331,-0.104,-0.335,-0.207,-0.345,-0.477,0.515,-0.097,0.1,-0.041,-0.057,0.124,-0.071,0.095,-0.07,0.041,0.021,-0.066,-0.004],[-0.222,0.268,-0.235,-0.063,-0.162,0.152,0.161,-0.057,0.199,0.268,0.256,0.146,-0.023,0.4,0.231,0.313,0.207,-0.232,0.263,0.255],[-0.221,0.285,-0.285,0.09,-0.048,0.29,0.281,0.145,-0.097,-0.007,0.087,0.242,-0.082,-0.03,0.039,0.043,-0.377,0.171,-0.5,-0.294],[-0.22,0.302,0.019,0.023,0.062,0.338,0.103,0.089,0.01,-0.021,-0.353,0.134,0.1,-0.016,-0.46,-0.291,0.245,0.311,0.238,0.246],[-0.22,0.32,0.101,0.064,-0.012,0.155,-0.155,-0.274,0.118,-0.028,-0.058,-0.091,-0.356,-0.296,0.227,-0.416,-0.107,-0.415,0.181,-0.175],[-0.217,0.357,0.288,-0.003,-0.152,-0.078,-0.138,-0.463,0.057,-0.297,-0.078,-0.241,0.28,0.046,-0.088,0.43,-0.14,0.155,-0.083,-0.036],[-0.228,0.029,-0.024,-0.261,0.496,-0.223,0.092,-0.177,-0.052,-0.057,0.183,0.325,-0.078,-0.438,0.205,0.17,0.228,0.265,0.084,0.019],[-0.227,-0.058,-0.261,-0.012,0.133,-0.177,0.342,-0.112,-0.017,0.329,0.057,-0.386,0.548,-0.133,-0.049,-0.219,-0.159,-0.092,0.138,-0.126],[-0.227,-0.081,-0.342,0.266,-0.015,-0.355,0.058,0.037,-0.094,-0.56,-0.127,0.279,0.069,0.107,-0.178,0.008,0.063,-0.371,0.112,-0.073],[-0.227,-0.067,0.012,0.286,0.378,-0.11,-0.314,-0.186,0.013,0.135,-0.117,0.097,0.091,0.413,0.265,-0.283,-0.089,0.112,-0.313,0.293],[-0.228,-0.014,0.102,0.274,0.102,-0.217,0.071,0.177,-0.125,0.151,-0.118,-0.213,-0.402,0.267,0.029,0.158,-0.089,0.33,0.399,-0.368],[-0.227,0.066,0.282,0.151,0.031,-0.1,0.336,0.161,-0.277,0.033,0.008,-0.341,-0.203,-0.094,-0.041,0.077,0.374,-0.257,-0.41,0.258],[-0.226,-0.14,-0.017,-0.351,0.266,0.103,-0.209,-0.053,-0.172,0.045,0.291,-0.076,-0.243,0.15,-0.546,0.074,-0.332,-0.21,0.015,0.126],[-0.224,-0.223,-0.146,-0.063,-0.251,-0.248,0.007,-0.155,0.641,0.133,-0.017,-0.031,-0.259,-0.048,-0.271,-0.082,0.189,0.157,-0.279,-0.092],[-0.222,-0.267,-0.366,0.239,-0.18,0.328,-0.277,-0.001,-0.139,-0.239,0.285,-0.348,-0.03,-0.214,0.143,0.021,0.128,0.266,0.081,0.179],[-0.224,-0.231,0.13,0.174,0.097,0.315,-0.317,0.052,-0.017,0.304,-0.155,0.189,0.244,-0.119,-0.093,0.296,0.279,-0.249,-0.07,-0.412],[-0.225,-0.184,0.248,0.198,-0.042,-0.01,0.075,0.329,0.324,0.022,-0.106,0.127,0.053,-0.318,0.077,0.205,-0.478,-0.069,0.14,0.401],[-0.226,-0.106,0.492,0.048,-0.251,-0.032,0.076,0.064,-0.042,-0.105,0.571,0.245,0.196,0.139,-0.019,-0.346,0.061,0.101,0.071,-0.154],[-0.223,-0.241,0.092,-0.472,0.175,0.271,0.165,0.203,0.222,-0.387,-0.228,-0.213,0.062,0.261,0.3,-0.049,0.049,-0.038,-0.032,-0.154],[-0.22,-0.315,0.01,-0.273,-0.461,-0.033,0.1,-0.305,-0.451,0.175,-0.361,0.211,-0.088,-0.012,0.14,-0.034,-0.097,0.048,0.028,0.11]],""selectVec"":[[-0.219,0.331],[-0.222,0.268],[-0.221,0.285],[-0.22,0.302],[-0.22,0.32],[-0.217,0.357],[-0.228,0.029],[-0.227,-0.058],[-0.227,-0.081],[-0.227,-0.067],[-0.228,-0.014],[-0.227,0.066],[-0.226,-0.14],[-0.224,-0.223],[-0.222,-0.267],[-0.224,-0.231],[-0.225,-0.184],[-0.226,-0.106],[-0.223,-0.241],[-0.22,-0.315]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6910,""AfterCleanSamNum"":4871,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""2"",""precision"":""99.7%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":433,""version"":""v-2025-12-03 14:28:57"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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