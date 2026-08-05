using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA401")]
    [FCDisplay("PCA401")]
    public partial class PCA401 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁27号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁27号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁27号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁28号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁28号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁28号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁28号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁28号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁28号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁29号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁29号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁29号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁29号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁29号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁29号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁30号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁30号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁30号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁30号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁30号屏5号管壁温")]
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

		public PCA401()
		{
			ModelID = 442;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA401";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""442"",""name"":""PCA401"",""description"":""中温分隔屏过热器水冷壁18-61-80"",""founder"":""admin"",""creatTime"":""2025-12-04 09:12:23"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 09:14:20"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 16:32:48"",""et"":""2025-12-04 04:43:44"",""duration"":2549456,""number"":8499,""filter"":2648,""mode"":5851,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2558}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah18ct161k"",""Description"":""中温（分隔屏）过热器水冷壁27号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""587.38"",""TMin"":""495.77"",""TAvg"":""544.75"",""DMax"":""3.98"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.68"",""C99"":""2.06""},{""PointId"":""d1_10hah18ct162k"",""Description"":""中温（分隔屏）过热器水冷壁27号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""589.92"",""TMin"":""498.27"",""TAvg"":""548.29"",""DMax"":""4.47"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.92"",""C99"":""3.58""},{""PointId"":""d1_10hah18ct163k"",""Description"":""中温（分隔屏）过热器水冷壁27号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""591.45"",""TMin"":""500.62"",""TAvg"":""550.26"",""DMax"":""6.01"",""DMin"":""0.00"",""DAvg"":""1.27"",""C95"":""4.34"",""C99"":""5.31""},{""PointId"":""d1_10hah18ct164k"",""Description"":""中温（分隔屏）过热器水冷壁28号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""580.75"",""TMin"":""494.45"",""TAvg"":""540.57"",""DMax"":""5.15"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.70"",""C99"":""3.31""},{""PointId"":""d1_10hah18ct165k"",""Description"":""中温（分隔屏）过热器水冷壁28号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""578.38"",""TMin"":""491.28"",""TAvg"":""538.25"",""DMax"":""3.54"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.53"",""C99"":""3.10""},{""PointId"":""d1_10hah18ct166k"",""Description"":""中温（分隔屏）过热器水冷壁28号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""578.52"",""TMin"":""489.27"",""TAvg"":""538.13"",""DMax"":""4.50"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.23"",""C99"":""3.95""},{""PointId"":""d1_10hah18ct167k"",""Description"":""中温（分隔屏）过热器水冷壁28号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""586.07"",""TMin"":""495.92"",""TAvg"":""544.89"",""DMax"":""2.66"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.58"",""C99"":""1.93""},{""PointId"":""d1_10hah18ct168k"",""Description"":""中温（分隔屏）过热器水冷壁28号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""589.23"",""TMin"":""498.58"",""TAvg"":""548.18"",""DMax"":""3.92"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.70"",""C99"":""3.31""},{""PointId"":""d1_10hah18ct169k"",""Description"":""中温（分隔屏）过热器水冷壁28号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""591.03"",""TMin"":""501.38"",""TAvg"":""550.54"",""DMax"":""6.22"",""DMin"":""0.00"",""DAvg"":""1.33"",""C95"":""4.54"",""C99"":""5.55""},{""PointId"":""d1_10hah18ct170k"",""Description"":""中温（分隔屏）过热器水冷壁29号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""577.27"",""TMin"":""492.68"",""TAvg"":""538.19"",""DMax"":""4.34"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.77"",""C99"":""3.38""},{""PointId"":""d1_10hah18ct171k"",""Description"":""中温（分隔屏）过热器水冷壁29号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""577.97"",""TMin"":""491.18"",""TAvg"":""538.58"",""DMax"":""4.49"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.33"",""C99"":""4.07""},{""PointId"":""d1_10hah18ct172k"",""Description"":""中温（分隔屏）过热器水冷壁29号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""581.37"",""TMin"":""495.28"",""TAvg"":""541.66"",""DMax"":""3.46"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.47"",""C99"":""1.80""},{""PointId"":""d1_10hah18ct173k"",""Description"":""中温（分隔屏）过热器水冷壁29号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""586.00"",""TMin"":""497.45"",""TAvg"":""545.47"",""DMax"":""1.71"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.12"",""C99"":""1.38""},{""PointId"":""d1_10hah18ct174k"",""Description"":""中温（分隔屏）过热器水冷壁29号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""588.95"",""TMin"":""499.85"",""TAvg"":""548.71"",""DMax"":""3.53"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.51"",""C99"":""3.07""},{""PointId"":""d1_10hah18ct175k"",""Description"":""中温（分隔屏）过热器水冷壁29号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""590.12"",""TMin"":""501.92"",""TAvg"":""550.60"",""DMax"":""5.77"",""DMin"":""0.00"",""DAvg"":""1.26"",""C95"":""4.27"",""C99"":""5.22""},{""PointId"":""d1_10hah18ct176k"",""Description"":""中温（分隔屏）过热器水冷壁30号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""574.40"",""TMin"":""491.20"",""TAvg"":""536.85"",""DMax"":""4.45"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.11"",""C99"":""3.81""},{""PointId"":""d1_10hah18ct177k"",""Description"":""中温（分隔屏）过热器水冷壁30号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""575.48"",""TMin"":""489.63"",""TAvg"":""537.24"",""DMax"":""5.48"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.54"",""C99"":""4.34""},{""PointId"":""d1_10hah18ct178k"",""Description"":""中温（分隔屏）过热器水冷壁30号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""574.62"",""TMin"":""486.90"",""TAvg"":""535.86"",""DMax"":""6.01"",""DMin"":""0.00"",""DAvg"":""1.23"",""C95"":""4.21"",""C99"":""5.16""},{""PointId"":""d1_10hah18ct179k"",""Description"":""中温（分隔屏）过热器水冷壁30号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""581.65"",""TMin"":""495.08"",""TAvg"":""542.71"",""DMax"":""2.47"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.41"",""C99"":""1.73""},{""PointId"":""d1_10hah18ct180k"",""Description"":""中温（分隔屏）过热器水冷壁30号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""582.02"",""TMin"":""495.22"",""TAvg"":""543.37"",""DMax"":""3.00"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""1.99"",""C99"":""2.44""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 09:14:20"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[495.767,498.267,500.62,494.45,491.283,489.267,495.917,498.583,501.38,492.683,491.183,495.283,497.45,499.85,501.917,491.2,489.633,486.9,495.08,495.217],""Train_X_max"":[587.38,589.92,591.45,580.75,578.38,578.517,586.067,589.233,591.033,577.267,577.967,581.367,586.0,588.95,590.117,574.4,575.483,574.617,581.65,582.017],""Train_X_std"":[11.123,11.114,11.121,10.709,10.768,10.847,10.968,11.043,11.051,10.562,10.719,10.65,10.928,10.99,10.964,10.365,10.604,10.665,10.748,10.769],""Train_X_mean"":[544.754,548.286,550.255,540.566,538.246,538.133,544.893,548.179,550.543,538.188,538.575,541.664,545.471,548.713,550.599,536.848,537.236,535.861,542.708,543.366],""Train_X_bais_max"":[[3.984,4.467,6.008,5.154,3.542,4.496,2.659,3.92,6.223,4.341,4.485,3.463,1.708,3.527,5.77,4.454,5.478,6.011,2.47,2.997]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.002,0.0,0.0,0.001,0.0,0.0]],""Train_X_bais_mean"":[[0.47,0.845,1.269,0.789,0.743,0.951,0.452,0.776,1.333,0.81,0.977,0.404,0.321,0.731,1.261,0.9,1.015,1.233,0.401,0.585]],""QCUL_95"":0.666217566,""QCUL_99"":1.1922909,""QCUL_95_line"":[1.676,2.924,4.34,2.701,2.532,3.231,1.576,2.701,4.538,2.765,3.326,1.465,1.123,2.511,4.271,3.107,3.539,4.212,1.409,1.993],""QCUL_99_line"":[2.057,3.582,5.312,3.306,3.097,3.952,1.931,3.309,5.552,3.383,4.069,1.801,1.376,3.074,5.222,3.806,4.338,5.155,1.728,2.439],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.285,0.285,0.285,0.274,0.276,0.278,0.281,0.283,0.283,0.271,0.275,0.273,0.28,0.282,0.281,0.266,0.272,0.273,0.275,0.276],""T2CUL_99_line"":[0.375,0.374,0.375,0.361,0.363,0.365,0.37,0.372,0.372,0.356,0.361,0.359,0.368,0.37,0.369,0.349,0.357,0.359,0.362,0.363],""Kesi_95"":1.56,""Kesi_99"":1.329,""Kesi_95_line"":[0.182,0.181,0.182,0.175,0.176,0.177,0.179,0.18,0.18,0.172,0.175,0.174,0.178,0.179,0.179,0.169,0.173,0.174,0.176,0.176],""Kesi_99_line"":[0.168,0.168,0.168,0.161,0.162,0.163,0.165,0.166,0.167,0.159,0.162,0.161,0.165,0.166,0.165,0.156,0.16,0.161,0.162,0.162],""COV"":[[1.0,0.997,0.993,0.993,0.993,0.991,0.999,0.997,0.991,0.992,0.989,0.997,0.999,0.997,0.991,0.989,0.987,0.984,0.997,0.997],[0.997,1.0,0.998,0.986,0.986,0.982,0.999,1.0,0.997,0.984,0.98,0.992,0.997,0.999,0.997,0.981,0.977,0.974,0.993,0.996],[0.993,0.998,1.0,0.979,0.977,0.971,0.995,0.998,1.0,0.975,0.969,0.986,0.992,0.997,0.999,0.972,0.967,0.961,0.986,0.993],[0.993,0.986,0.979,1.0,0.998,0.995,0.992,0.986,0.977,1.0,0.996,0.995,0.993,0.987,0.978,0.998,0.995,0.991,0.994,0.988],[0.993,0.986,0.977,0.998,1.0,0.999,0.992,0.986,0.975,0.999,0.999,0.997,0.994,0.987,0.976,0.997,0.998,0.995,0.996,0.99],[0.991,0.982,0.971,0.995,0.999,1.0,0.989,0.983,0.969,0.997,0.999,0.996,0.991,0.983,0.97,0.996,0.998,0.999,0.995,0.988],[0.999,0.999,0.995,0.992,0.992,0.989,1.0,0.999,0.994,0.991,0.987,0.996,0.999,0.999,0.995,0.988,0.986,0.982,0.997,0.998],[0.997,1.0,0.998,0.986,0.986,0.983,0.999,1.0,0.997,0.985,0.981,0.993,0.998,1.0,0.997,0.981,0.978,0.975,0.994,0.998],[0.991,0.997,1.0,0.977,0.975,0.969,0.994,0.997,1.0,0.974,0.967,0.984,0.991,0.997,1.0,0.971,0.965,0.959,0.985,0.993],[0.992,0.984,0.975,1.0,0.999,0.997,0.991,0.985,0.974,1.0,0.998,0.996,0.993,0.985,0.975,0.999,0.997,0.994,0.994,0.988],[0.989,0.98,0.969,0.996,0.999,0.999,0.987,0.981,0.967,0.998,1.0,0.995,0.991,0.982,0.969,0.997,0.999,0.998,0.994,0.987],[0.997,0.992,0.986,0.995,0.997,0.996,0.996,0.993,0.984,0.996,0.995,1.0,0.997,0.994,0.986,0.995,0.994,0.992,0.998,0.996],[0.999,0.997,0.992,0.993,0.994,0.991,0.999,0.998,0.991,0.993,0.991,0.997,1.0,0.998,0.992,0.991,0.989,0.987,0.999,0.999],[0.997,0.999,0.997,0.987,0.987,0.983,0.999,1.0,0.997,0.985,0.982,0.994,0.998,1.0,0.998,0.983,0.98,0.977,0.995,0.999],[0.991,0.997,0.999,0.978,0.976,0.97,0.995,0.997,1.0,0.975,0.969,0.986,0.992,0.998,1.0,0.974,0.968,0.962,0.987,0.994],[0.989,0.981,0.972,0.998,0.997,0.996,0.988,0.981,0.971,0.999,0.997,0.995,0.991,0.983,0.974,1.0,0.998,0.995,0.994,0.988],[0.987,0.977,0.967,0.995,0.998,0.998,0.986,0.978,0.965,0.997,0.999,0.994,0.989,0.98,0.968,0.998,1.0,0.998,0.994,0.986],[0.984,0.974,0.961,0.991,0.995,0.999,0.982,0.975,0.959,0.994,0.998,0.992,0.987,0.977,0.962,0.995,0.998,1.0,0.993,0.984],[0.997,0.993,0.986,0.994,0.996,0.995,0.997,0.994,0.985,0.994,0.994,0.998,0.999,0.995,0.987,0.994,0.994,0.993,1.0,0.998],[0.997,0.996,0.993,0.988,0.99,0.988,0.998,0.998,0.993,0.988,0.987,0.996,0.999,0.999,0.994,0.988,0.986,0.984,0.998,1.0]],""K"":1,""R"":0.99,""featValue"":[19.806,0.163,0.015,0.008,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.07,-0.016,0.397,0.248,-0.501,-0.218,-0.206,-0.178,-0.218,-0.228,-0.004,-0.266,-0.142,0.23,-0.01,0.328,-0.013,0.033,0.003],[-0.224,0.221,0.005,0.285,0.051,0.139,-0.248,0.336,0.031,0.349,0.539,0.25,-0.243,-0.047,0.102,0.087,0.021,0.253,0.033,0.049],[-0.222,0.34,0.163,0.074,-0.25,0.066,-0.407,-0.154,-0.362,-0.121,-0.109,0.187,0.069,0.114,-0.3,-0.051,-0.418,-0.202,-0.076,-0.151],[-0.224,-0.153,0.519,0.077,0.232,0.169,0.107,-0.033,0.005,0.337,-0.26,0.044,-0.03,0.094,0.195,0.141,-0.153,-0.323,0.09,0.411],[-0.224,-0.188,0.154,0.212,-0.341,0.005,0.038,-0.361,0.188,0.277,0.186,-0.022,0.134,-0.003,-0.304,-0.383,0.422,-0.118,-0.001,-0.034],[-0.223,-0.245,-0.176,0.323,-0.152,0.234,0.007,0.242,0.009,0.074,-0.336,-0.215,0.06,-0.325,0.237,-0.357,-0.302,0.167,-0.123,-0.161],[-0.224,0.114,0.011,0.131,0.152,-0.129,-0.078,0.028,0.67,-0.238,0.076,-0.244,-0.011,0.425,0.004,-0.093,-0.274,-0.067,0.139,-0.119],[-0.224,0.212,-0.083,0.167,0.022,0.093,0.223,0.2,-0.174,-0.189,0.128,-0.52,0.017,-0.007,-0.306,0.145,0.117,-0.095,-0.37,0.379],[-0.222,0.36,0.142,-0.131,-0.125,0.241,-0.152,0.071,0.093,-0.051,-0.267,-0.108,0.465,-0.018,0.195,0.229,0.399,0.255,0.227,-0.073],[-0.224,-0.199,0.366,-0.031,0.211,0.095,0.305,0.179,-0.205,-0.134,-0.048,0.097,-0.163,0.296,-0.154,0.007,0.152,0.253,-0.178,-0.518],[-0.223,-0.27,-0.01,0.1,-0.199,0.148,0.177,-0.304,-0.144,-0.48,0.378,0.17,0.174,0.071,0.369,0.115,-0.135,0.128,0.065,0.187],[-0.224,-0.057,-0.07,-0.036,-0.512,-0.582,0.26,0.342,-0.025,0.174,-0.114,0.127,0.068,0.162,0.022,0.226,-0.082,-0.004,0.063,0.045],[-0.225,0.058,-0.096,0.042,0.34,-0.138,0.243,-0.228,0.152,0.065,-0.086,0.256,0.245,-0.346,-0.428,0.124,-0.243,0.369,0.072,0.1],[-0.224,0.195,-0.148,-0.065,0.093,0.064,0.344,-0.033,-0.103,0.068,0.211,-0.113,-0.033,-0.312,0.101,0.099,-0.032,-0.507,0.347,-0.429],[-0.223,0.332,0.058,-0.385,-0.195,0.099,0.211,-0.049,0.254,-0.18,-0.135,0.255,-0.458,-0.195,0.117,-0.275,0.057,0.017,-0.207,0.176],[-0.223,-0.227,0.275,-0.463,0.153,-0.275,-0.294,0.27,-0.112,-0.133,0.26,-0.172,0.167,-0.271,-0.04,-0.304,-0.041,0.001,0.119,0.108],[-0.223,-0.291,-0.042,-0.253,-0.156,0.043,-0.291,-0.299,0.137,0.148,-0.002,-0.301,-0.321,-0.141,-0.04,0.523,-0.071,0.108,-0.173,-0.155],[-0.222,-0.328,-0.396,-0.031,0.039,0.276,-0.18,0.254,0.022,-0.211,-0.196,0.269,-0.147,0.101,-0.316,0.057,0.213,-0.205,0.329,0.156],[-0.224,-0.044,-0.307,-0.159,0.256,-0.047,-0.113,-0.004,0.08,0.141,0.033,0.268,0.366,0.123,0.22,0.004,0.1,-0.274,-0.597,-0.096],[-0.224,0.105,-0.348,-0.258,0.128,0.009,0.064,-0.248,-0.338,0.318,-0.033,-0.222,-0.096,0.42,0.095,-0.282,-0.056,0.258,0.209,0.122]],""selectVec"":[[-0.224],[-0.224],[-0.222],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.222],[-0.224],[-0.223],[-0.224],[-0.225],[-0.224],[-0.223],[-0.223],[-0.223],[-0.222],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8499,""AfterCleanSamNum"":5851,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":442,""version"":""v-2025-12-04 09:14:20"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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