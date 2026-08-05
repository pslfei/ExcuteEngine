using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA452")]
    [FCDisplay("PCA452")]
    public partial class PCA452 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁162号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁163号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁163号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁163号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁163号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁163号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁163号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁164号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁164号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁164号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁164号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁164号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁164号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁165号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁165号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁165号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁165号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁165号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁165号屏6号管壁温")]
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

		public PCA452()
		{
			ModelID = 493;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA452";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""493"",""name"":""PCA452"",""description"":""中温分隔屏过热器水冷壁27-81-99"",""founder"":""admin"",""creatTime"":""2025-12-10 17:28:09"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:30:11"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 19:50:12"",""et"":""2025-12-07 10:50:14"",""duration"":2300402,""number"":7669,""filter"":2582,""mode"":5087,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2492}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah27ct181k"",""Description"":""中温（分隔屏）过热器水冷壁162号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""570.62"",""TMin"":""494.50"",""TAvg"":""546.14"",""DMax"":""6.21"",""DMin"":""0.00"",""DAvg"":""1.44"",""C95"":""4.95"",""C99"":""6.06""},{""PointId"":""d1_10hah27ct182k"",""Description"":""中温（分隔屏）过热器水冷壁163号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""567.46"",""TMin"":""487.58"",""TAvg"":""538.47"",""DMax"":""4.24"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.53"",""C99"":""3.10""},{""PointId"":""d1_10hah27ct183k"",""Description"":""中温（分隔屏）过热器水冷壁163号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""565.78"",""TMin"":""483.52"",""TAvg"":""536.35"",""DMax"":""3.28"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.13"",""C99"":""2.61""},{""PointId"":""d1_10hah27ct184k"",""Description"":""中温（分隔屏）过热器水冷壁163号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""564.95"",""TMin"":""481.70"",""TAvg"":""535.19"",""DMax"":""4.00"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.67"",""C99"":""3.28""},{""PointId"":""d1_10hah27ct185k"",""Description"":""中温（分隔屏）过热器水冷壁163号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""570.06"",""TMin"":""488.52"",""TAvg"":""541.71"",""DMax"":""3.61"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.24"",""C99"":""1.52""},{""PointId"":""d1_10hah27ct186k"",""Description"":""中温（分隔屏）过热器水冷壁163号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""571.36"",""TMin"":""489.78"",""TAvg"":""543.15"",""DMax"":""2.96"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.09"",""C99"":""2.57""},{""PointId"":""d1_10hah27ct187k"",""Description"":""中温（分隔屏）过热器水冷壁163号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.12"",""TMin"":""491.18"",""TAvg"":""544.11"",""DMax"":""4.03"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.11"",""C99"":""3.80""},{""PointId"":""d1_10hah27ct188k"",""Description"":""中温（分隔屏）过热器水冷壁164号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""567.04"",""TMin"":""483.90"",""TAvg"":""536.68"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.34"",""C99"":""2.87""},{""PointId"":""d1_10hah27ct189k"",""Description"":""中温（分隔屏）过热器水冷壁164号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""564.76"",""TMin"":""479.90"",""TAvg"":""533.67"",""DMax"":""3.20"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.42"",""C99"":""2.97""},{""PointId"":""d1_10hah27ct190k"",""Description"":""中温（分隔屏）过热器水冷壁164号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""565.40"",""TMin"":""479.12"",""TAvg"":""534.10"",""DMax"":""4.32"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.99"",""C99"":""3.67""},{""PointId"":""d1_10hah27ct191k"",""Description"":""中温（分隔屏）过热器水冷壁164号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""570.44"",""TMin"":""486.20"",""TAvg"":""540.79"",""DMax"":""3.91"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.09"",""C99"":""1.33""},{""PointId"":""d1_10hah27ct192k"",""Description"":""中温（分隔屏）过热器水冷壁164号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""573.04"",""TMin"":""489.14"",""TAvg"":""543.43"",""DMax"":""3.41"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.17"",""C99"":""2.66""},{""PointId"":""d1_10hah27ct193k"",""Description"":""中温（分隔屏）过热器水冷壁164号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""572.42"",""TMin"":""490.44"",""TAvg"":""544.18"",""DMax"":""5.53"",""DMin"":""0.00"",""DAvg"":""1.01"",""C95"":""3.53"",""C99"":""4.32""},{""PointId"":""d1_10hah27ct194k"",""Description"":""中温（分隔屏）过热器水冷壁165号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""566.38"",""TMin"":""481.27"",""TAvg"":""534.28"",""DMax"":""5.17"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.32"",""C99"":""4.07""},{""PointId"":""d1_10hah27ct195k"",""Description"":""中温（分隔屏）过热器水冷壁165号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""566.44"",""TMin"":""479.82"",""TAvg"":""534.39"",""DMax"":""3.19"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.45"",""C99"":""3.01""},{""PointId"":""d1_10hah27ct196k"",""Description"":""中温（分隔屏）过热器水冷壁165号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""566.86"",""TMin"":""478.58"",""TAvg"":""534.34"",""DMax"":""4.37"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.11"",""C99"":""3.81""},{""PointId"":""d1_10hah27ct197k"",""Description"":""中温（分隔屏）过热器水冷壁165号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""572.00"",""TMin"":""486.04"",""TAvg"":""540.90"",""DMax"":""2.54"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.45"",""C99"":""1.78""},{""PointId"":""d1_10hah27ct198k"",""Description"":""中温（分隔屏）过热器水冷壁165号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.68"",""TMin"":""487.26"",""TAvg"":""542.32"",""DMax"":""4.61"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.75"",""C99"":""3.37""},{""PointId"":""d1_10hah27ct199k"",""Description"":""中温（分隔屏）过热器水冷壁165号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""572.84"",""TMin"":""488.30"",""TAvg"":""542.79"",""DMax"":""4.35"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.73"",""C99"":""3.34""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:30:11"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[494.5,487.58,483.52,481.7,488.52,489.78,491.18,483.9,479.9,479.12,486.2,489.14,490.44,481.267,479.82,478.58,486.04,487.26,488.3],""Train_X_max"":[570.617,567.46,565.78,564.95,570.06,571.36,571.12,567.04,564.76,565.4,570.44,573.04,572.42,566.38,566.44,566.86,572.0,572.68,572.84],""Train_X_std"":[9.218,9.463,9.521,9.664,9.495,9.463,9.335,9.576,9.646,9.788,9.588,9.558,9.396,9.717,9.685,9.857,9.688,9.554,9.549],""Train_X_mean"":[546.137,538.473,536.35,535.19,541.71,543.152,544.105,536.683,533.669,534.104,540.789,543.43,544.181,534.277,534.386,534.335,540.902,542.324,542.789],""Train_X_bais_max"":[[6.206,4.238,3.281,3.996,3.614,2.957,4.026,3.172,3.198,4.319,3.914,3.409,5.53,5.167,3.186,4.371,2.54,4.611,4.346]],""Train_X_bais_min"":[[0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.443,0.726,0.608,0.763,0.353,0.605,0.902,0.672,0.704,0.855,0.31,0.622,1.014,0.956,0.698,0.88,0.41,0.791,0.778]],""QCUL_95"":0.678879142,""QCUL_99"":1.2110666,""QCUL_95_line"":[4.949,2.526,2.128,2.673,1.236,2.094,3.105,2.339,2.424,2.992,1.086,2.172,3.525,3.318,2.452,3.109,1.451,2.752,2.727],""QCUL_99_line"":[6.058,3.095,2.609,3.277,1.515,2.565,3.802,2.866,2.968,3.667,1.331,2.663,4.32,4.065,3.007,3.814,1.78,3.373,3.344],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.253,0.26,0.262,0.266,0.261,0.26,0.257,0.263,0.265,0.269,0.264,0.263,0.258,0.267,0.266,0.271,0.266,0.263,0.263],""T2CUL_99_line"":[0.333,0.342,0.344,0.349,0.343,0.342,0.337,0.346,0.349,0.354,0.346,0.345,0.339,0.351,0.35,0.356,0.35,0.345,0.345],""Kesi_95"":1.558,""Kesi_99"":1.323,""Kesi_95_line"":[0.161,0.166,0.167,0.169,0.166,0.166,0.163,0.168,0.169,0.171,0.168,0.167,0.164,0.17,0.169,0.173,0.17,0.167,0.167],""Kesi_99_line"":[0.149,0.153,0.154,0.156,0.153,0.153,0.151,0.154,0.156,0.158,0.155,0.154,0.152,0.157,0.156,0.159,0.156,0.154,0.154],""COV"":[[1.0,0.966,0.968,0.964,0.984,0.992,0.996,0.965,0.962,0.957,0.982,0.989,0.995,0.952,0.961,0.954,0.977,0.987,0.989],[0.966,1.0,0.998,0.997,0.994,0.987,0.981,0.999,0.997,0.996,0.992,0.985,0.976,0.996,0.996,0.995,0.992,0.981,0.982],[0.968,0.998,1.0,0.999,0.995,0.989,0.982,0.998,0.999,0.998,0.994,0.987,0.978,0.995,0.998,0.997,0.993,0.984,0.983],[0.964,0.997,0.999,1.0,0.994,0.987,0.979,0.996,0.998,0.999,0.992,0.984,0.974,0.994,0.997,0.998,0.992,0.98,0.98],[0.984,0.994,0.995,0.994,1.0,0.998,0.994,0.993,0.993,0.992,0.999,0.997,0.991,0.988,0.992,0.99,0.998,0.994,0.994],[0.992,0.987,0.989,0.987,0.998,1.0,0.999,0.987,0.986,0.984,0.998,0.999,0.997,0.98,0.986,0.982,0.995,0.997,0.997],[0.996,0.981,0.982,0.979,0.994,0.999,1.0,0.981,0.979,0.975,0.994,0.998,0.999,0.972,0.979,0.973,0.99,0.996,0.997],[0.965,0.999,0.998,0.996,0.993,0.987,0.981,1.0,0.998,0.996,0.993,0.987,0.978,0.998,0.998,0.996,0.994,0.984,0.984],[0.962,0.997,0.999,0.998,0.993,0.986,0.979,0.998,1.0,0.999,0.993,0.986,0.975,0.997,0.999,0.999,0.994,0.983,0.982],[0.957,0.996,0.998,0.999,0.992,0.984,0.975,0.996,0.999,1.0,0.992,0.983,0.97,0.996,0.998,0.999,0.992,0.979,0.978],[0.982,0.992,0.994,0.992,0.999,0.998,0.994,0.993,0.993,0.992,1.0,0.998,0.992,0.989,0.993,0.991,0.999,0.996,0.996],[0.989,0.985,0.987,0.984,0.997,0.999,0.998,0.987,0.986,0.983,0.998,1.0,0.998,0.981,0.987,0.982,0.997,0.999,0.999],[0.995,0.976,0.978,0.974,0.991,0.997,0.999,0.978,0.975,0.97,0.992,0.998,1.0,0.969,0.976,0.97,0.99,0.998,0.998],[0.952,0.996,0.995,0.994,0.988,0.98,0.972,0.998,0.997,0.996,0.989,0.981,0.969,1.0,0.998,0.997,0.991,0.979,0.979],[0.961,0.996,0.998,0.997,0.992,0.986,0.979,0.998,0.999,0.998,0.993,0.987,0.976,0.998,1.0,0.999,0.995,0.985,0.984],[0.954,0.995,0.997,0.998,0.99,0.982,0.973,0.996,0.999,0.999,0.991,0.982,0.97,0.997,0.999,1.0,0.992,0.979,0.979],[0.977,0.992,0.993,0.992,0.998,0.995,0.99,0.994,0.994,0.992,0.999,0.997,0.99,0.991,0.995,0.992,1.0,0.996,0.996],[0.987,0.981,0.984,0.98,0.994,0.997,0.996,0.984,0.983,0.979,0.996,0.999,0.998,0.979,0.985,0.979,0.996,1.0,1.0],[0.989,0.982,0.983,0.98,0.994,0.997,0.997,0.984,0.982,0.978,0.996,0.999,0.998,0.979,0.984,0.979,0.996,1.0,1.0]],""K"":1,""R"":0.989,""featValue"":[18.799,0.163,0.022,0.01,0.005,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.226,-0.44,0.498,0.126,0.239,-0.319,-0.116,0.392,0.107,0.148,-0.209,0.242,0.142,0.049,-0.009,-0.012,0.064,-0.047,0.007],[0.23,0.184,0.286,0.37,-0.338,0.255,-0.062,0.071,-0.316,-0.168,-0.064,0.252,-0.132,-0.238,-0.303,0.208,-0.313,-0.045,-0.033],[0.23,0.172,0.25,-0.05,0.227,0.12,0.23,0.165,-0.203,0.011,0.174,-0.321,0.059,-0.319,0.05,-0.61,-0.086,0.189,0.098],[0.229,0.211,0.272,-0.321,-0.004,0.061,-0.301,-0.105,-0.422,0.266,0.12,-0.107,-0.041,0.045,0.192,0.214,0.416,-0.252,-0.153],[0.23,-0.047,0.133,-0.209,-0.43,-0.235,0.222,0.041,-0.023,0.131,0.132,-0.316,-0.003,0.525,-0.344,0.035,-0.151,0.173,0.099],[0.23,-0.184,0.11,-0.138,-0.116,0.099,0.289,-0.361,0.286,0.365,-0.123,-0.026,0.038,-0.427,0.119,0.276,-0.063,0.305,-0.208],[0.229,-0.288,0.169,0.058,0.03,-0.129,0.147,-0.457,-0.006,-0.394,-0.038,-0.073,-0.497,0.056,0.221,-0.096,0.02,-0.257,0.219],[0.23,0.181,0.028,0.468,-0.112,0.216,-0.2,0.031,0.384,0.026,-0.192,-0.328,-0.074,0.273,0.172,-0.177,0.146,0.017,-0.374],[0.23,0.214,0.036,-0.047,0.302,0.204,0.409,0.159,0.035,-0.304,-0.064,-0.054,0.334,0.241,0.278,0.435,-0.133,-0.107,0.081],[0.229,0.259,0.07,-0.32,-0.006,0.159,-0.263,-0.23,0.239,-0.176,-0.379,0.269,0.17,0.07,-0.213,-0.188,0.177,0.209,0.365],[0.23,-0.049,-0.098,-0.178,-0.327,-0.038,-0.125,0.28,0.434,-0.216,0.345,-0.115,0.125,-0.37,-0.029,0.041,0.097,-0.398,0.103],[0.23,-0.187,-0.182,-0.095,-0.09,0.313,0.274,-0.062,-0.043,0.138,0.179,0.521,0.102,0.245,-0.005,-0.373,0.011,-0.264,-0.285],[0.229,-0.33,-0.096,0.139,0.163,0.195,-0.372,-0.112,-0.064,-0.18,0.536,0.021,0.117,0.108,0.039,0.142,0.002,0.469,0.057],[0.229,0.272,-0.205,0.451,-0.133,-0.385,0.094,-0.156,-0.063,0.305,0.132,0.188,0.21,-0.032,0.238,-0.024,0.121,-0.01,0.403],[0.23,0.204,-0.159,0.09,0.464,-0.099,0.192,0.031,0.158,0.075,0.161,0.047,-0.359,-0.048,-0.551,0.16,0.283,-0.015,-0.097],[0.229,0.272,-0.097,-0.224,0.19,-0.371,-0.306,-0.077,0.101,0.016,0.061,0.125,-0.11,0.025,0.145,-0.057,-0.628,-0.038,-0.278],[0.23,-0.009,-0.321,-0.149,-0.22,-0.193,0.106,0.392,-0.213,-0.257,-0.218,0.148,-0.269,-0.08,0.258,0.011,0.254,0.388,-0.172],[0.229,-0.216,-0.368,-0.045,0.101,0.335,-0.161,0.227,-0.079,0.394,-0.252,-0.177,-0.256,0.014,0.032,0.06,-0.237,-0.146,0.399],[0.229,-0.226,-0.318,0.08,0.07,-0.191,-0.062,-0.229,-0.311,-0.177,-0.306,-0.29,0.446,-0.138,-0.289,-0.046,0.021,-0.171,-0.228]],""selectVec"":[[0.226],[0.23],[0.23],[0.229],[0.23],[0.23],[0.229],[0.23],[0.23],[0.229],[0.23],[0.23],[0.229],[0.229],[0.23],[0.229],[0.23],[0.229],[0.229]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7669,""AfterCleanSamNum"":5087,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":493,""version"":""v-2025-12-10 17:30:11"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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