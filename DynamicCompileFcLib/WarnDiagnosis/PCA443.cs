using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA443")]
    [FCDisplay("PCA443")]
    public partial class PCA443 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁133号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁133号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁133号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁133号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁133号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁133号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁134号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁134号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁134号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁134号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁134号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁134号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁135号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁135号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁135号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁135号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁135号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁135号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁136号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁136号屏2号管壁温")]
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

		public PCA443()
		{
			ModelID = 484;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA443";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""484"",""name"":""PCA443"",""description"":""中温分隔屏过热器水冷壁26-1-20"",""founder"":""admin"",""creatTime"":""2025-12-10 17:06:30"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:07:57"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 13:53:08"",""et"":""2025-12-07 16:02:40"",""duration"":2340572,""number"":7802,""filter"":2630,""mode"":5172,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2540}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah26ct101k"",""Description"":""中温（分隔屏）过热器水冷壁133号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""567.50"",""TMin"":""489.79"",""TAvg"":""533.32"",""DMax"":""2.85"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.26"",""C99"":""2.77""},{""PointId"":""d1_10hah26ct102k"",""Description"":""中温（分隔屏）过热器水冷壁133号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""571.27"",""TMin"":""493.37"",""TAvg"":""536.82"",""DMax"":""2.79"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.69"",""C99"":""2.07""},{""PointId"":""d1_10hah26ct103k"",""Description"":""中温（分隔屏）过热器水冷壁133号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""569.68"",""TMin"":""491.25"",""TAvg"":""534.56"",""DMax"":""2.88"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.90"",""C99"":""2.33""},{""PointId"":""d1_10hah26ct104k"",""Description"":""中温（分隔屏）过热器水冷壁133号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""576.56"",""TMin"":""497.98"",""TAvg"":""540.94"",""DMax"":""2.90"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.25"",""C99"":""2.75""},{""PointId"":""d1_10hah26ct105k"",""Description"":""中温（分隔屏）过热器水冷壁133号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""576.75"",""TMin"":""499.04"",""TAvg"":""541.14"",""DMax"":""4.03"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.07"",""C99"":""3.76""},{""PointId"":""d1_10hah26ct106k"",""Description"":""中温（分隔屏）过热器水冷壁133号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""577.26"",""TMin"":""500.68"",""TAvg"":""542.49"",""DMax"":""5.48"",""DMin"":""0.00"",""DAvg"":""1.26"",""C95"":""4.35"",""C99"":""5.32""},{""PointId"":""d1_10hah26ct107k"",""Description"":""中温（分隔屏）过热器水冷壁134号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""567.05"",""TMin"":""489.70"",""TAvg"":""533.04"",""DMax"":""4.30"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.52"",""C99"":""3.09""},{""PointId"":""d1_10hah26ct108k"",""Description"":""中温（分隔屏）过热器水冷壁134号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""567.91"",""TMin"":""490.68"",""TAvg"":""533.98"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.46"",""C99"":""3.01""},{""PointId"":""d1_10hah26ct109k"",""Description"":""中温（分隔屏）过热器水冷壁134号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""566.97"",""TMin"":""489.26"",""TAvg"":""532.33"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.34"",""C99"":""2.87""},{""PointId"":""d1_10hah26ct110k"",""Description"":""中温（分隔屏）过热器水冷壁134号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""573.59"",""TMin"":""497.03"",""TAvg"":""538.76"",""DMax"":""2.34"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.88"",""C99"":""2.31""},{""PointId"":""d1_10hah26ct111k"",""Description"":""中温（分隔屏）过热器水冷壁134号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""575.70"",""TMin"":""498.45"",""TAvg"":""540.20"",""DMax"":""3.78"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.51"",""C99"":""3.07""},{""PointId"":""d1_10hah26ct112k"",""Description"":""中温（分隔屏）过热器水冷壁134号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""577.63"",""TMin"":""501.61"",""TAvg"":""543.07"",""DMax"":""6.41"",""DMin"":""0.00"",""DAvg"":""1.25"",""C95"":""4.29"",""C99"":""5.25""},{""PointId"":""d1_10hah26ct113k"",""Description"":""中温（分隔屏）过热器水冷壁135号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""568.35"",""TMin"":""490.40"",""TAvg"":""534.37"",""DMax"":""5.24"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.87"",""C99"":""3.52""},{""PointId"":""d1_10hah26ct114k"",""Description"":""中温（分隔屏）过热器水冷壁135号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""566.55"",""TMin"":""489.16"",""TAvg"":""532.87"",""DMax"":""3.92"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.68"",""C99"":""3.29""},{""PointId"":""d1_10hah26ct115k"",""Description"":""中温（分隔屏）过热器水冷壁135号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""569.16"",""TMin"":""490.91"",""TAvg"":""534.46"",""DMax"":""3.60"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.76"",""C99"":""3.38""},{""PointId"":""d1_10hah26ct116k"",""Description"":""中温（分隔屏）过热器水冷壁135号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""572.25"",""TMin"":""494.71"",""TAvg"":""537.74"",""DMax"":""1.64"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.19"",""C99"":""1.46""},{""PointId"":""d1_10hah26ct117k"",""Description"":""中温（分隔屏）过热器水冷壁135号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""573.75"",""TMin"":""496.73"",""TAvg"":""539.19"",""DMax"":""3.32"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.04"",""C99"":""2.50""},{""PointId"":""d1_10hah26ct118k"",""Description"":""中温（分隔屏）过热器水冷壁135号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.74"",""TMin"":""497.35"",""TAvg"":""539.10"",""DMax"":""4.14"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.01"",""C99"":""3.68""},{""PointId"":""d1_10hah26ct119k"",""Description"":""中温（分隔屏）过热器水冷壁136号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""568.05"",""TMin"":""490.86"",""TAvg"":""534.91"",""DMax"":""3.62"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.91"",""C99"":""3.56""},{""PointId"":""d1_10hah26ct120k"",""Description"":""中温（分隔屏）过热器水冷壁136号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""566.96"",""TMin"":""489.03"",""TAvg"":""533.25"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.76"",""C99"":""3.37""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:07:57"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[489.786,493.366,491.247,497.983,499.04,500.678,489.704,490.683,489.261,497.029,498.447,501.605,490.404,489.16,490.91,494.71,496.73,497.353,490.862,489.03],""Train_X_max"":[567.5,571.268,569.682,576.555,576.746,577.259,567.047,567.91,566.969,573.591,575.703,577.626,568.347,566.553,569.16,572.25,573.753,572.738,568.054,566.96],""Train_X_std"":[9.902,9.991,10.059,10.063,10.083,10.065,9.908,10.036,10.057,9.967,10.052,10.043,9.926,9.936,10.071,9.949,9.954,9.917,9.8,9.914],""Train_X_mean"":[533.316,536.817,534.559,540.937,541.143,542.488,533.041,533.979,532.326,538.758,540.2,543.074,534.369,532.87,534.462,537.743,539.191,539.097,534.909,533.247],""Train_X_bais_max"":[[2.854,2.788,2.879,2.896,4.026,5.476,4.295,3.549,3.073,2.335,3.778,6.405,5.24,3.915,3.597,1.635,3.324,4.142,3.62,3.36]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.002,0.001,0.0,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.647,0.489,0.549,0.659,0.899,1.264,0.721,0.703,0.672,0.543,0.73,1.247,0.832,0.78,0.803,0.346,0.589,0.882,0.863,0.808]],""QCUL_95"":0.6268859,""QCUL_99"":1.11997783,""QCUL_95_line"":[2.258,1.687,1.901,2.251,3.074,4.348,2.517,2.456,2.343,1.884,2.507,4.29,2.873,2.684,2.758,1.191,2.042,3.006,2.913,2.757],""QCUL_99_line"":[2.768,2.066,2.328,2.754,3.762,5.323,3.085,3.01,2.872,2.308,3.069,5.253,3.519,3.286,3.377,1.459,2.502,3.679,3.561,3.373],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.27,0.272,0.274,0.274,0.275,0.274,0.27,0.274,0.274,0.272,0.274,0.274,0.271,0.271,0.275,0.271,0.271,0.27,0.267,0.27],""T2CUL_99_line"":[0.355,0.358,0.36,0.361,0.361,0.361,0.355,0.36,0.36,0.357,0.36,0.36,0.356,0.356,0.361,0.356,0.357,0.355,0.351,0.355],""Kesi_95"":1.557,""Kesi_99"":1.32,""Kesi_95_line"":[0.172,0.173,0.175,0.175,0.175,0.175,0.172,0.174,0.175,0.173,0.174,0.174,0.172,0.172,0.175,0.173,0.173,0.172,0.17,0.172],""Kesi_99_line"":[0.158,0.16,0.161,0.161,0.161,0.161,0.158,0.16,0.161,0.159,0.161,0.16,0.159,0.159,0.161,0.159,0.159,0.158,0.157,0.158],""COV"":[[1.0,0.998,0.997,0.99,0.985,0.976,0.999,0.997,0.996,0.99,0.987,0.976,0.998,0.997,0.995,0.994,0.989,0.983,0.996,0.995],[0.998,1.0,0.999,0.994,0.99,0.982,0.996,0.998,0.998,0.994,0.992,0.981,0.994,0.996,0.996,0.995,0.992,0.987,0.993,0.995],[0.997,0.999,1.0,0.994,0.989,0.98,0.996,0.998,0.999,0.993,0.991,0.979,0.994,0.996,0.997,0.996,0.991,0.986,0.992,0.995],[0.99,0.994,0.994,1.0,0.999,0.995,0.987,0.987,0.989,0.999,0.999,0.994,0.984,0.985,0.986,0.997,0.997,0.996,0.984,0.985],[0.985,0.99,0.989,0.999,1.0,0.998,0.982,0.982,0.984,0.998,1.0,0.997,0.979,0.979,0.98,0.994,0.997,0.997,0.979,0.979],[0.976,0.982,0.98,0.995,0.998,1.0,0.972,0.971,0.974,0.995,0.997,0.999,0.969,0.968,0.969,0.989,0.994,0.997,0.971,0.969],[0.999,0.996,0.996,0.987,0.982,0.972,1.0,0.998,0.996,0.988,0.985,0.972,1.0,0.999,0.997,0.993,0.988,0.982,0.997,0.997],[0.997,0.998,0.998,0.987,0.982,0.971,0.998,1.0,0.999,0.989,0.985,0.972,0.997,1.0,0.999,0.993,0.988,0.982,0.995,0.998],[0.996,0.998,0.999,0.989,0.984,0.974,0.996,0.999,1.0,0.991,0.987,0.974,0.995,0.998,0.999,0.995,0.989,0.983,0.993,0.997],[0.99,0.994,0.993,0.999,0.998,0.995,0.988,0.989,0.991,1.0,0.999,0.995,0.986,0.987,0.988,0.999,0.999,0.998,0.987,0.987],[0.987,0.992,0.991,0.999,1.0,0.997,0.985,0.985,0.987,0.999,1.0,0.997,0.982,0.983,0.984,0.997,0.999,0.998,0.983,0.983],[0.976,0.981,0.979,0.994,0.997,0.999,0.972,0.972,0.974,0.995,0.997,1.0,0.969,0.969,0.969,0.989,0.995,0.998,0.973,0.971],[0.998,0.994,0.994,0.984,0.979,0.969,1.0,0.997,0.995,0.986,0.982,0.969,1.0,0.999,0.997,0.992,0.987,0.981,0.999,0.998],[0.997,0.996,0.996,0.985,0.979,0.968,0.999,1.0,0.998,0.987,0.983,0.969,0.999,1.0,0.999,0.993,0.987,0.981,0.997,0.999],[0.995,0.996,0.997,0.986,0.98,0.969,0.997,0.999,0.999,0.988,0.984,0.969,0.997,0.999,1.0,0.994,0.988,0.981,0.995,0.998],[0.994,0.995,0.996,0.997,0.994,0.989,0.993,0.993,0.995,0.999,0.997,0.989,0.992,0.993,0.994,1.0,0.999,0.996,0.993,0.993],[0.989,0.992,0.991,0.997,0.997,0.994,0.988,0.988,0.989,0.999,0.999,0.995,0.987,0.987,0.988,0.999,1.0,0.999,0.988,0.988],[0.983,0.987,0.986,0.996,0.997,0.997,0.982,0.982,0.983,0.998,0.998,0.998,0.981,0.981,0.981,0.996,0.999,1.0,0.984,0.982],[0.996,0.993,0.992,0.984,0.979,0.971,0.997,0.995,0.993,0.987,0.983,0.973,0.999,0.997,0.995,0.993,0.988,0.984,1.0,0.998],[0.995,0.995,0.995,0.985,0.979,0.969,0.997,0.998,0.997,0.987,0.983,0.971,0.998,0.999,0.998,0.993,0.988,0.982,0.998,1.0]],""K"":1,""R"":0.99,""featValue"":[19.814,0.15,0.018,0.011,0.004,0.002,0.002,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,-0.154,-0.078,-0.516,-0.135,0.068,0.017,0.086,0.088,0.185,0.406,0.023,-0.027,0.152,0.243,-0.397,-0.33,-0.087,0.226,0.088],[-0.224,-0.077,-0.303,-0.171,0.39,-0.015,0.16,-0.264,0.057,0.292,0.071,0.245,-0.409,0.068,-0.306,0.058,0.146,-0.023,-0.2,-0.301],[-0.224,-0.099,-0.396,0.063,0.1,0.09,0.238,0.329,-0.029,0.162,0.087,-0.083,0.297,-0.341,-0.183,-0.009,0.371,0.031,0.191,0.376],[-0.224,0.179,-0.237,-0.113,-0.166,-0.128,0.41,-0.064,-0.15,0.208,-0.288,-0.083,0.295,0.263,0.338,0.373,-0.172,0.125,-0.101,-0.111],[-0.223,0.27,-0.151,-0.134,-0.082,-0.443,0.01,0.298,0.26,-0.289,-0.197,-0.051,-0.154,-0.336,0.08,-0.141,-0.012,-0.363,-0.139,-0.194],[-0.222,0.395,-0.002,-0.205,0.214,0.333,-0.042,-0.11,0.393,-0.292,-0.105,-0.381,-0.112,0.17,-0.088,0.046,0.026,0.3,0.097,0.187],[-0.224,-0.213,0.075,-0.334,-0.216,0.04,-0.292,-0.048,0.01,-0.224,0.127,0.063,0.372,0.008,0.018,0.05,0.472,0.21,-0.254,-0.328],[-0.224,-0.212,-0.159,0.051,0.223,-0.138,-0.475,-0.255,0.022,-0.04,-0.139,0.025,0.018,0.058,0.272,0.326,0.061,-0.315,0.444,0.107],[-0.224,-0.172,-0.276,0.292,-0.004,0.367,-0.067,0.198,0.037,-0.345,0.179,0.285,-0.117,-0.096,0.195,0.217,-0.357,0.098,-0.316,0.047],[-0.224,0.165,-0.057,0.069,-0.223,0.111,0.138,-0.476,-0.239,-0.229,-0.153,0.294,0.057,-0.339,-0.116,-0.286,-0.111,0.146,0.355,-0.118],[-0.224,0.223,-0.081,0.054,-0.131,-0.356,-0.225,0.159,-0.257,-0.119,0.022,0.296,-0.043,0.487,-0.336,-0.08,0.015,0.113,-0.049,0.358],[-0.222,0.39,0.153,-0.041,0.284,0.223,-0.211,0.1,-0.627,0.107,0.169,-0.222,0.018,-0.139,0.09,-0.022,-0.019,-0.211,-0.142,-0.114],[-0.223,-0.241,0.265,-0.242,-0.246,0.043,-0.112,0.141,-0.047,0.154,-0.203,-0.139,-0.098,-0.235,-0.493,0.385,-0.35,0.006,0.055,0.023],[-0.224,-0.247,0.056,0.098,0.131,-0.146,-0.182,-0.24,0.022,0.223,-0.333,-0.17,0.039,-0.161,0.155,-0.395,-0.106,0.206,-0.443,0.316],[-0.224,-0.228,-0.108,0.345,-0.223,0.244,-0.023,0.242,-0.072,0.051,-0.276,-0.297,-0.205,0.341,-0.037,-0.296,0.137,-0.064,0.167,-0.359],[-0.224,0.042,0.092,0.236,-0.372,0.046,0.175,-0.411,0.14,-0.001,0.34,-0.222,0.005,0.076,-0.113,0.089,0.113,-0.473,-0.23,0.209],[-0.224,0.158,0.197,0.252,-0.187,-0.251,-0.073,0.061,0.095,0.282,0.313,-0.029,-0.357,-0.2,0.268,0.16,0.163,0.452,0.17,-0.065],[-0.223,0.251,0.306,0.207,0.112,0.193,-0.096,0.139,0.415,0.349,-0.108,0.413,0.376,0.062,-0.056,-0.072,-0.068,-0.151,0.024,-0.123],[-0.223,-0.199,0.51,-0.138,0.136,0.079,0.414,0.119,-0.128,-0.211,-0.195,0.249,-0.241,0.072,0.235,0.034,0.273,-0.111,0.028,0.232],[-0.224,-0.225,0.201,0.226,0.404,-0.358,0.234,-0.001,0.009,-0.267,0.28,-0.222,0.286,0.092,-0.166,-0.042,-0.253,0.112,0.117,-0.229]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.222],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7802,""AfterCleanSamNum"":5172,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":484,""version"":""v-2025-12-10 17:07:57"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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