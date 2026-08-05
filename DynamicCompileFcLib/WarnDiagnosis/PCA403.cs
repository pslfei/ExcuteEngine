using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA403")]
    [FCDisplay("PCA403")]
    public partial class PCA403 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁34号屏1号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁34号屏2号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁34号屏3号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁34号屏4号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁34号屏5号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁34号屏6号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁35号屏1号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁35号屏2号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁35号屏3号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁35号屏4号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁35号屏5号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁35号屏6号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁36号屏1号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁36号屏2号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁36号屏3号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁36号屏4号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁36号屏5号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁36号屏6号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁37号屏1号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁37号屏2号管壁温")]
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

		public PCA403()
		{
			ModelID = 444;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA403";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""444"",""name"":""PCA403"",""description"":""中温分隔屏过热器水冷壁19-01-20"",""founder"":""admin"",""creatTime"":""2025-12-04 09:19:50"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 09:23:56"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 15:03:32"",""et"":""2025-12-04 01:00:34"",""duration"":2541422,""number"":8472,""filter"":2648,""mode"":5824,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2558}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah19ct101k"",""Description"":""中温（分隔屏）过热器水冷壁34号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""577.36"",""TMin"":""495.78"",""TAvg"":""540.10"",""DMax"":""4.62"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.27"",""C99"":""2.78""},{""PointId"":""d1_10hah19ct102k"",""Description"":""中温（分隔屏）过热器水冷壁34号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""575.95"",""TMin"":""493.73"",""TAvg"":""538.39"",""DMax"":""2.46"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.63"",""C99"":""2.00""},{""PointId"":""d1_10hah19ct103k"",""Description"":""中温（分隔屏）过热器水冷壁34号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""575.42"",""TMin"":""491.42"",""TAvg"":""537.62"",""DMax"":""4.77"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.22"",""C99"":""2.72""},{""PointId"":""d1_10hah19ct104k"",""Description"":""中温（分隔屏）过热器水冷壁34号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""578.28"",""TMin"":""496.28"",""TAvg"":""542.00"",""DMax"":""3.43"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.40"",""C99"":""2.93""},{""PointId"":""d1_10hah19ct105k"",""Description"":""中温（分隔屏）过热器水冷壁34号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""579.85"",""TMin"":""499.03"",""TAvg"":""543.90"",""DMax"":""3.82"",""DMin"":""0.00"",""DAvg"":""1.05"",""C95"":""3.58"",""C99"":""4.37""},{""PointId"":""d1_10hah19ct106k"",""Description"":""中温（分隔屏）过热器水冷壁34号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""583.00"",""TMin"":""502.78"",""TAvg"":""546.93"",""DMax"":""5.73"",""DMin"":""0.00"",""DAvg"":""1.58"",""C95"":""5.35"",""C99"":""6.53""},{""PointId"":""d1_10hah19ct107k"",""Description"":""中温（分隔屏）过热器水冷壁35号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""573.02"",""TMin"":""491.72"",""TAvg"":""535.44"",""DMax"":""3.18"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.36"",""C99"":""2.89""},{""PointId"":""d1_10hah19ct108k"",""Description"":""中温（分隔屏）过热器水冷壁35号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""574.35"",""TMin"":""491.20"",""TAvg"":""536.45"",""DMax"":""3.79"",""DMin"":""0.00"",""DAvg"":""0.85"",""C95"":""2.89"",""C99"":""3.53""},{""PointId"":""d1_10hah19ct109k"",""Description"":""中温（分隔屏）过热器水冷壁35号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""572.42"",""TMin"":""487.03"",""TAvg"":""534.04"",""DMax"":""4.52"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.25"",""C99"":""3.97""},{""PointId"":""d1_10hah19ct110k"",""Description"":""中温（分隔屏）过热器水冷壁35号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""580.12"",""TMin"":""498.42"",""TAvg"":""543.25"",""DMax"":""2.06"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.54"",""C99"":""1.88""},{""PointId"":""d1_10hah19ct111k"",""Description"":""中温（分隔屏）过热器水冷壁35号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""579.97"",""TMin"":""499.67"",""TAvg"":""543.45"",""DMax"":""3.58"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.29"",""C99"":""2.81""},{""PointId"":""d1_10hah19ct112k"",""Description"":""中温（分隔屏）过热器水冷壁35号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""581.82"",""TMin"":""502.18"",""TAvg"":""545.38"",""DMax"":""5.69"",""DMin"":""0.00"",""DAvg"":""1.03"",""C95"":""3.55"",""C99"":""4.35""},{""PointId"":""d1_10hah19ct113k"",""Description"":""中温（分隔屏）过热器水冷壁36号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""575.16"",""TMin"":""494.98"",""TAvg"":""537.63"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.47"",""C99"":""3.02""},{""PointId"":""d1_10hah19ct114k"",""Description"":""中温（分隔屏）过热器水冷壁36号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""574.52"",""TMin"":""493.00"",""TAvg"":""536.47"",""DMax"":""3.24"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.74"",""C99"":""3.35""},{""PointId"":""d1_10hah19ct115k"",""Description"":""中温（分隔屏）过热器水冷壁36号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""573.96"",""TMin"":""489.28"",""TAvg"":""535.17"",""DMax"":""3.46"",""DMin"":""0.00"",""DAvg"":""0.94"",""C95"":""3.19"",""C99"":""3.90""},{""PointId"":""d1_10hah19ct116k"",""Description"":""中温（分隔屏）过热器水冷壁36号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""581.60"",""TMin"":""498.68"",""TAvg"":""543.32"",""DMax"":""2.98"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.60"",""C99"":""1.96""},{""PointId"":""d1_10hah19ct117k"",""Description"":""中温（分隔屏）过热器水冷壁36号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""581.10"",""TMin"":""500.58"",""TAvg"":""543.47"",""DMax"":""3.80"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.47"",""C99"":""3.02""},{""PointId"":""d1_10hah19ct118k"",""Description"":""中温（分隔屏）过热器水冷壁36号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""584.58"",""TMin"":""504.76"",""TAvg"":""547.30"",""DMax"":""6.03"",""DMin"":""0.00"",""DAvg"":""1.11"",""C95"":""3.82"",""C99"":""4.67""},{""PointId"":""d1_10hah19ct119k"",""Description"":""中温（分隔屏）过热器水冷壁37号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""575.90"",""TMin"":""493.42"",""TAvg"":""537.33"",""DMax"":""5.41"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.33"",""C99"":""4.08""},{""PointId"":""d1_10hah19ct120k"",""Description"":""中温（分隔屏）过热器水冷壁37号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""576.30"",""TMin"":""493.50"",""TAvg"":""538.02"",""DMax"":""5.28"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.93"",""C99"":""3.59""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 09:23:56"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[495.783,493.733,491.42,496.283,499.033,502.78,491.72,491.2,487.033,498.42,499.667,502.183,494.983,493.0,489.283,498.683,500.58,504.76,493.417,493.5],""Train_X_max"":[577.36,575.95,575.417,578.283,579.85,583.0,573.017,574.35,572.417,580.117,579.967,581.817,575.16,574.52,573.96,581.6,581.1,584.583,575.9,576.3],""Train_X_std"":[10.322,10.325,10.359,10.443,10.522,10.448,10.25,10.405,10.456,10.426,10.47,10.396,10.251,10.387,10.498,10.54,10.513,10.502,10.418,10.46],""Train_X_mean"":[540.103,538.392,537.619,542.0,543.903,546.925,535.435,536.446,534.035,543.246,543.449,545.378,537.63,536.467,535.168,543.324,543.465,547.304,537.325,538.018],""Train_X_bais_max"":[[4.624,2.461,4.774,3.432,3.817,5.732,3.18,3.785,4.52,2.06,3.576,5.691,3.01,3.236,3.46,2.98,3.798,6.03,5.407,5.283]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.651,0.466,0.625,0.706,1.053,1.584,0.686,0.845,0.951,0.451,0.668,1.029,0.723,0.808,0.939,0.45,0.71,1.106,0.959,0.856]],""QCUL_95"":0.661087453,""QCUL_99"":1.18100691,""QCUL_95_line"":[2.272,1.632,2.217,2.396,3.575,5.345,2.361,2.885,3.246,1.538,2.292,3.548,2.469,2.738,3.188,1.6,2.465,3.815,3.331,2.93],""QCUL_99_line"":[2.784,2.001,2.721,2.931,4.373,6.534,2.891,3.53,3.972,1.882,2.805,4.345,3.021,3.348,3.899,1.964,3.021,4.671,4.082,3.585],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.265,0.265,0.266,0.268,0.27,0.269,0.263,0.267,0.269,0.268,0.269,0.267,0.264,0.267,0.27,0.271,0.27,0.27,0.268,0.269],""T2CUL_99_line"":[0.349,0.349,0.35,0.353,0.356,0.353,0.346,0.352,0.353,0.352,0.354,0.351,0.346,0.351,0.355,0.356,0.355,0.355,0.352,0.353],""Kesi_95"":1.555,""Kesi_99"":1.31,""Kesi_95_line"":[0.169,0.169,0.169,0.171,0.172,0.171,0.168,0.17,0.171,0.17,0.171,0.17,0.168,0.17,0.172,0.172,0.172,0.172,0.17,0.171],""Kesi_99_line"":[0.155,0.155,0.155,0.157,0.158,0.157,0.154,0.156,0.157,0.156,0.157,0.156,0.154,0.156,0.158,0.158,0.158,0.158,0.156,0.157],""COV"":[[1.0,0.998,0.994,0.993,0.988,0.979,0.997,0.993,0.991,0.994,0.991,0.986,0.996,0.993,0.99,0.994,0.99,0.984,0.994,0.992],[0.998,1.0,0.998,0.995,0.989,0.978,0.998,0.997,0.995,0.996,0.992,0.987,0.996,0.996,0.994,0.995,0.991,0.985,0.993,0.995],[0.994,0.998,1.0,0.993,0.986,0.974,0.996,0.997,0.998,0.995,0.991,0.984,0.994,0.995,0.996,0.993,0.989,0.981,0.99,0.995],[0.993,0.995,0.993,1.0,0.998,0.992,0.988,0.986,0.985,0.999,0.998,0.996,0.987,0.985,0.984,0.996,0.996,0.994,0.982,0.984],[0.988,0.989,0.986,0.998,1.0,0.997,0.981,0.977,0.977,0.996,0.998,0.998,0.98,0.977,0.975,0.993,0.996,0.996,0.974,0.976],[0.979,0.978,0.974,0.992,0.997,1.0,0.967,0.962,0.959,0.989,0.991,0.996,0.968,0.963,0.958,0.984,0.989,0.994,0.959,0.962],[0.997,0.998,0.996,0.988,0.981,0.967,1.0,0.998,0.996,0.992,0.988,0.98,0.999,0.998,0.997,0.993,0.987,0.979,0.998,0.997],[0.993,0.997,0.997,0.986,0.977,0.962,0.998,1.0,0.999,0.99,0.986,0.977,0.997,0.999,0.999,0.991,0.985,0.974,0.996,0.998],[0.991,0.995,0.998,0.985,0.977,0.959,0.996,0.999,1.0,0.989,0.985,0.975,0.994,0.997,0.999,0.99,0.984,0.972,0.993,0.996],[0.994,0.996,0.995,0.999,0.996,0.989,0.992,0.99,0.989,1.0,0.999,0.996,0.991,0.99,0.989,0.999,0.998,0.995,0.987,0.99],[0.991,0.992,0.991,0.998,0.998,0.991,0.988,0.986,0.985,0.999,1.0,0.998,0.988,0.986,0.985,0.997,0.999,0.997,0.983,0.986],[0.986,0.987,0.984,0.996,0.998,0.996,0.98,0.977,0.975,0.996,0.998,1.0,0.981,0.978,0.975,0.993,0.997,0.998,0.975,0.978],[0.996,0.996,0.994,0.987,0.98,0.968,0.999,0.997,0.994,0.991,0.988,0.981,1.0,0.999,0.996,0.993,0.988,0.981,0.999,0.998],[0.993,0.996,0.995,0.985,0.977,0.963,0.998,0.999,0.997,0.99,0.986,0.978,0.999,1.0,0.999,0.993,0.987,0.978,0.998,1.0],[0.99,0.994,0.996,0.984,0.975,0.958,0.997,0.999,0.999,0.989,0.985,0.975,0.996,0.999,1.0,0.991,0.985,0.974,0.995,0.998],[0.994,0.995,0.993,0.996,0.993,0.984,0.993,0.991,0.99,0.999,0.997,0.993,0.993,0.993,0.991,1.0,0.999,0.994,0.991,0.992],[0.99,0.991,0.989,0.996,0.996,0.989,0.987,0.985,0.984,0.998,0.999,0.997,0.988,0.987,0.985,0.999,1.0,0.998,0.985,0.986],[0.984,0.985,0.981,0.994,0.996,0.994,0.979,0.974,0.972,0.995,0.997,0.998,0.981,0.978,0.974,0.994,0.998,1.0,0.976,0.978],[0.994,0.993,0.99,0.982,0.974,0.959,0.998,0.996,0.993,0.987,0.983,0.975,0.999,0.998,0.995,0.991,0.985,0.976,1.0,0.997],[0.992,0.995,0.995,0.984,0.976,0.962,0.997,0.998,0.996,0.99,0.986,0.978,0.998,1.0,0.998,0.992,0.986,0.978,0.997,1.0]],""K"":1,""R"":0.99,""featValue"":[19.798,0.155,0.021,0.016,0.006,0.003,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.049,0.079,-0.581,-0.269,-0.016,-0.111,0.095,0.094,-0.134,0.022,0.472,0.118,0.361,-0.287,-0.09,0.145,-0.059,0.016,0.02],[-0.224,0.07,0.227,-0.207,0.196,-0.255,-0.024,-0.269,-0.494,0.025,-0.245,0.238,0.226,-0.342,0.162,-0.143,-0.262,0.105,-0.007,-0.131],[-0.224,0.105,0.434,0.094,0.121,-0.125,-0.27,0.247,0.063,-0.238,-0.125,-0.064,-0.322,-0.198,-0.352,0.423,-0.139,-0.027,-0.057,0.168],[-0.224,-0.173,0.281,-0.022,-0.178,-0.228,0.291,0.067,-0.01,0.003,0.064,-0.454,-0.01,-0.089,-0.268,-0.463,0.091,-0.146,0.363,-0.041],[-0.223,-0.296,0.191,-0.017,-0.205,0.186,0.211,-0.395,-0.054,-0.231,-0.026,-0.268,0.032,0.229,0.005,0.146,-0.072,0.022,-0.575,-0.095],[-0.221,-0.452,0.132,-0.258,0.276,-0.098,-0.268,-0.128,0.341,0.192,-0.02,-0.137,0.0,0.144,0.422,0.177,0.049,0.038,0.27,0.102],[-0.224,0.187,-0.016,-0.262,-0.051,0.268,-0.049,0.274,-0.243,-0.041,0.152,-0.131,-0.326,-0.155,0.453,-0.044,0.153,-0.453,-0.12,-0.112],[-0.224,0.241,0.153,0.056,0.103,0.131,0.202,-0.365,0.187,0.184,0.481,0.25,-0.457,-0.021,-0.021,-0.108,-0.111,0.244,0.081,-0.044],[-0.223,0.243,0.284,0.276,-0.141,0.269,-0.306,-0.004,0.063,-0.004,0.03,-0.05,0.372,-0.124,0.143,-0.166,0.468,0.306,-0.049,0.154],[-0.224,-0.111,0.07,0.109,-0.076,-0.194,0.366,0.46,0.097,0.179,0.262,0.165,0.292,-0.105,0.117,0.347,0.015,0.134,-0.095,-0.37],[-0.224,-0.179,-0.014,0.205,-0.04,0.345,0.322,0.173,-0.222,-0.211,-0.069,0.216,0.058,0.141,0.16,0.042,-0.256,0.019,0.323,0.504],[-0.223,-0.297,-0.106,0.074,0.327,0.455,0.003,0.093,0.185,0.272,-0.287,0.185,0.008,-0.23,-0.328,-0.227,0.028,-0.175,-0.165,-0.167],[-0.224,0.177,-0.257,-0.25,0.13,0.05,0.021,0.283,-0.207,0.268,-0.145,-0.369,-0.124,0.238,-0.106,-0.043,-0.088,0.554,-0.112,0.074],[-0.224,0.227,-0.133,0.067,0.201,-0.119,0.214,-0.291,-0.217,0.296,-0.031,-0.047,0.129,0.141,-0.202,0.38,0.408,-0.343,0.077,0.204],[-0.223,0.254,0.049,0.328,-0.05,0.019,-0.31,0.013,0.026,0.172,-0.004,-0.08,0.178,0.46,0.025,-0.084,-0.464,-0.29,0.096,-0.283],[-0.224,-0.055,-0.193,0.163,-0.389,-0.402,-0.049,0.016,0.171,0.308,-0.142,0.144,-0.17,-0.133,0.14,-0.181,-0.084,-0.1,-0.343,0.41],[-0.224,-0.166,-0.256,0.241,-0.309,-0.043,-0.135,-0.123,-0.171,-0.137,-0.301,0.129,-0.353,0.028,0.02,0.136,0.264,0.188,0.305,-0.413],[-0.223,-0.297,-0.374,0.096,0.162,-0.126,-0.359,-0.005,-0.259,-0.222,0.588,-0.021,0.112,-0.087,-0.199,-0.077,-0.016,0.004,-0.079,0.081],[-0.223,0.243,-0.372,-0.233,-0.235,0.161,0.032,-0.198,0.351,-0.157,-0.033,-0.213,0.242,-0.411,-0.053,0.211,-0.264,-0.013,0.195,-0.006],[-0.224,0.224,-0.181,0.119,0.434,-0.274,0.214,0.052,0.307,-0.521,-0.168,0.031,-0.004,0.155,0.171,-0.236,0.134,-0.009,-0.123,-0.056]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.221],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8472,""AfterCleanSamNum"":5817,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":444,""version"":""v-2025-12-04 09:23:56"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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