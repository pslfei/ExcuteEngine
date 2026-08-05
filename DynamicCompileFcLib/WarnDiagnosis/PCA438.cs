using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA438")]
    [FCDisplay("PCA438")]
    public partial class PCA438 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁116号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁116号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁116号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁117号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁117号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁117号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁117号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁117号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁117号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁118号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁118号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁118号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁118号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁118号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁118号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁119号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁119号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁119号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁119号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁119号屏5号管壁温")]
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

		public PCA438()
		{
			ModelID = 479;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA438";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""479"",""name"":""PCA438"",""description"":""中温分隔屏过热器水冷壁25-1-20"",""founder"":""admin"",""creatTime"":""2025-12-09 11:01:24"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 11:03:24"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 10:50:14"",""duration"":2402166,""number"":8008,""filter"":2599,""mode"":5409,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2509}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah25ct101k"",""Description"":""中温（分隔屏）过热器水冷壁116号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""580.13"",""TMin"":""488.57"",""TAvg"":""536.10"",""DMax"":""2.92"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.80"",""C99"":""2.21""},{""PointId"":""d1_10hah25ct102k"",""Description"":""中温（分隔屏）过热器水冷壁116号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""580.92"",""TMin"":""489.40"",""TAvg"":""536.74"",""DMax"":""4.36"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.38"",""C99"":""2.92""},{""PointId"":""d1_10hah25ct103k"",""Description"":""中温（分隔屏）过热器水冷壁116号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""580.39"",""TMin"":""489.35"",""TAvg"":""536.95"",""DMax"":""6.55"",""DMin"":""0.00"",""DAvg"":""1.01"",""C95"":""3.52"",""C99"":""4.31""},{""PointId"":""d1_10hah25ct104k"",""Description"":""中温（分隔屏）过热器水冷壁117号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""570.67"",""TMin"":""484.50"",""TAvg"":""529.32"",""DMax"":""6.17"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.86"",""C99"":""3.51""},{""PointId"":""d1_10hah25ct105k"",""Description"":""中温（分隔屏）过热器水冷壁117号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""573.19"",""TMin"":""485.44"",""TAvg"":""530.43"",""DMax"":""3.33"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.92"",""C99"":""2.35""},{""PointId"":""d1_10hah25ct106k"",""Description"":""中温（分隔屏）过热器水冷壁117号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""574.90"",""TMin"":""485.30"",""TAvg"":""530.92"",""DMax"":""3.57"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.32"",""C99"":""2.84""},{""PointId"":""d1_10hah25ct107k"",""Description"":""中温（分隔屏）过热器水冷壁117号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""579.38"",""TMin"":""488.64"",""TAvg"":""535.44"",""DMax"":""1.64"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.08"",""C99"":""1.33""},{""PointId"":""d1_10hah25ct108k"",""Description"":""中温（分隔屏）过热器水冷壁117号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""579.91"",""TMin"":""488.92"",""TAvg"":""535.95"",""DMax"":""3.08"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.91"",""C99"":""2.34""},{""PointId"":""d1_10hah25ct109k"",""Description"":""中温（分隔屏）过热器水冷壁117号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""579.82"",""TMin"":""489.41"",""TAvg"":""536.53"",""DMax"":""4.48"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.90"",""C99"":""3.55""},{""PointId"":""d1_10hah25ct110k"",""Description"":""中温（分隔屏）过热器水冷壁118号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""571.06"",""TMin"":""485.88"",""TAvg"":""530.08"",""DMax"":""5.38"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.76"",""C99"":""3.38""},{""PointId"":""d1_10hah25ct111k"",""Description"":""中温（分隔屏）过热器水冷壁118号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""573.70"",""TMin"":""486.59"",""TAvg"":""531.39"",""DMax"":""3.56"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.12"",""C99"":""2.59""},{""PointId"":""d1_10hah25ct112k"",""Description"":""中温（分隔屏）过热器水冷壁118号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""575.06"",""TMin"":""486.13"",""TAvg"":""531.58"",""DMax"":""3.30"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.32"",""C99"":""2.84""},{""PointId"":""d1_10hah25ct113k"",""Description"":""中温（分隔屏）过热器水冷壁118号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""577.89"",""TMin"":""488.53"",""TAvg"":""535.15"",""DMax"":""1.98"",""DMin"":""0.00"",""DAvg"":""0.33"",""C95"":""1.16"",""C99"":""1.43""},{""PointId"":""d1_10hah25ct114k"",""Description"":""中温（分隔屏）过热器水冷壁118号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""579.63"",""TMin"":""489.43"",""TAvg"":""536.29"",""DMax"":""3.52"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.96"",""C99"":""2.40""},{""PointId"":""d1_10hah25ct115k"",""Description"":""中温（分隔屏）过热器水冷壁118号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""579.81"",""TMin"":""490.14"",""TAvg"":""537.25"",""DMax"":""5.52"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.37"",""C99"":""4.12""},{""PointId"":""d1_10hah25ct116k"",""Description"":""中温（分隔屏）过热器水冷壁119号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""571.42"",""TMin"":""486.27"",""TAvg"":""530.64"",""DMax"":""6.07"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.79"",""C99"":""3.42""},{""PointId"":""d1_10hah25ct117k"",""Description"":""中温（分隔屏）过热器水冷壁119号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""572.92"",""TMin"":""486.65"",""TAvg"":""531.06"",""DMax"":""3.04"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""2.03"",""C99"":""2.49""},{""PointId"":""d1_10hah25ct118k"",""Description"":""中温（分隔屏）过热器水冷壁119号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.90"",""TMin"":""484.98"",""TAvg"":""529.72"",""DMax"":""3.54"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.59"",""C99"":""3.17""},{""PointId"":""d1_10hah25ct119k"",""Description"":""中温（分隔屏）过热器水冷壁119号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""578.85"",""TMin"":""489.71"",""TAvg"":""536.22"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.20"",""C99"":""1.47""},{""PointId"":""d1_10hah25ct120k"",""Description"":""中温（分隔屏）过热器水冷壁119号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""578.41"",""TMin"":""489.83"",""TAvg"":""535.76"",""DMax"":""2.92"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.68"",""C99"":""2.05""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 11:03:24"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[488.574,489.398,489.351,484.502,485.436,485.295,488.64,488.921,489.414,485.876,486.588,486.133,488.527,489.43,490.14,486.272,486.65,484.982,489.713,489.825],""Train_X_max"":[580.13,580.916,580.387,570.665,573.189,574.904,579.377,579.909,579.819,571.064,573.697,575.058,577.891,579.631,579.806,571.419,572.918,572.901,578.849,578.407],""Train_X_std"":[11.346,11.338,11.304,10.987,11.072,11.25,11.314,11.342,11.286,10.864,10.989,11.11,11.171,11.269,11.137,10.861,10.887,11.08,11.105,11.094],""Train_X_mean"":[536.104,536.737,536.952,529.318,530.426,530.915,535.443,535.946,536.526,530.079,531.387,531.584,535.151,536.293,537.251,530.635,531.057,529.722,536.224,535.757],""Train_X_bais_max"":[[2.918,4.361,6.548,6.17,3.329,3.571,1.641,3.077,4.48,5.383,3.557,3.297,1.98,3.516,5.52,6.067,3.044,3.538,1.996,2.92]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.517,0.676,1.008,0.814,0.549,0.674,0.308,0.554,0.844,0.79,0.613,0.671,0.334,0.56,0.977,0.795,0.584,0.758,0.344,0.484]],""QCUL_95"":0.385240465,""QCUL_99"":0.690760136,""QCUL_95_line"":[1.802,2.383,3.517,2.863,1.917,2.316,1.08,1.914,2.9,2.757,2.118,2.32,1.164,1.958,3.365,2.786,2.033,2.594,1.197,1.675],""QCUL_99_line"":[2.208,2.923,4.311,3.511,2.349,2.835,1.325,2.344,3.551,3.379,2.594,2.842,1.426,2.4,4.12,3.416,2.491,3.174,1.467,2.052],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.303,0.302,0.302,0.293,0.295,0.3,0.302,0.303,0.301,0.29,0.293,0.296,0.298,0.301,0.297,0.29,0.29,0.296,0.296,0.296],""T2CUL_99_line"":[0.398,0.398,0.396,0.385,0.388,0.394,0.397,0.398,0.396,0.381,0.385,0.39,0.392,0.395,0.39,0.381,0.382,0.388,0.389,0.389],""Kesi_95"":1.558,""Kesi_99"":1.32,""Kesi_95_line"":[0.193,0.193,0.192,0.187,0.188,0.191,0.192,0.193,0.192,0.184,0.187,0.189,0.19,0.191,0.189,0.184,0.185,0.188,0.189,0.188],""Kesi_99_line"":[0.177,0.177,0.177,0.172,0.173,0.176,0.177,0.177,0.176,0.17,0.172,0.174,0.175,0.176,0.174,0.17,0.17,0.173,0.174,0.173],""COV"":[[1.0,0.999,0.997,0.99,0.994,0.994,1.0,1.0,0.998,0.99,0.993,0.993,0.999,0.999,0.996,0.99,0.993,0.992,0.998,0.998],[0.999,1.0,0.999,0.987,0.991,0.99,0.998,1.0,0.999,0.987,0.99,0.99,0.998,0.999,0.998,0.987,0.99,0.988,0.997,0.998],[0.997,0.999,1.0,0.981,0.986,0.984,0.995,0.998,1.0,0.981,0.984,0.984,0.995,0.998,0.999,0.981,0.985,0.981,0.994,0.996],[0.99,0.987,0.981,1.0,0.998,0.998,0.994,0.989,0.984,1.0,0.998,0.997,0.993,0.988,0.981,1.0,0.998,0.997,0.993,0.99],[0.994,0.991,0.986,0.998,1.0,0.999,0.996,0.993,0.989,0.999,1.0,0.999,0.996,0.993,0.987,0.998,0.999,0.999,0.996,0.994],[0.994,0.99,0.984,0.998,0.999,1.0,0.996,0.992,0.987,0.997,0.999,1.0,0.995,0.991,0.984,0.997,0.998,1.0,0.995,0.993],[1.0,0.998,0.995,0.994,0.996,0.996,1.0,0.999,0.997,0.993,0.996,0.996,1.0,0.999,0.995,0.993,0.995,0.995,0.999,0.999],[1.0,1.0,0.998,0.989,0.993,0.992,0.999,1.0,0.999,0.989,0.992,0.992,0.999,1.0,0.997,0.989,0.992,0.991,0.998,0.999],[0.998,0.999,1.0,0.984,0.989,0.987,0.997,0.999,1.0,0.985,0.987,0.987,0.997,0.999,0.999,0.984,0.988,0.985,0.996,0.998],[0.99,0.987,0.981,1.0,0.999,0.997,0.993,0.989,0.985,1.0,0.999,0.997,0.993,0.989,0.982,1.0,0.998,0.997,0.993,0.991],[0.993,0.99,0.984,0.998,1.0,0.999,0.996,0.992,0.987,0.999,1.0,0.999,0.995,0.992,0.985,0.999,1.0,0.999,0.996,0.994],[0.993,0.99,0.984,0.997,0.999,1.0,0.996,0.992,0.987,0.997,0.999,1.0,0.995,0.991,0.985,0.997,0.999,1.0,0.995,0.993],[0.999,0.998,0.995,0.993,0.996,0.995,1.0,0.999,0.997,0.993,0.995,0.995,1.0,0.999,0.996,0.993,0.995,0.994,1.0,0.999],[0.999,0.999,0.998,0.988,0.993,0.991,0.999,1.0,0.999,0.989,0.992,0.991,0.999,1.0,0.998,0.989,0.992,0.99,0.999,1.0],[0.996,0.998,0.999,0.981,0.987,0.984,0.995,0.997,0.999,0.982,0.985,0.985,0.996,0.998,1.0,0.982,0.987,0.983,0.995,0.997],[0.99,0.987,0.981,1.0,0.998,0.997,0.993,0.989,0.984,1.0,0.999,0.997,0.993,0.989,0.982,1.0,0.999,0.997,0.994,0.991],[0.993,0.99,0.985,0.998,0.999,0.998,0.995,0.992,0.988,0.998,1.0,0.999,0.995,0.992,0.987,0.999,1.0,0.999,0.996,0.994],[0.992,0.988,0.981,0.997,0.999,1.0,0.995,0.991,0.985,0.997,0.999,1.0,0.994,0.99,0.983,0.997,0.999,1.0,0.995,0.993],[0.998,0.997,0.994,0.993,0.996,0.995,0.999,0.998,0.996,0.993,0.996,0.995,1.0,0.999,0.995,0.994,0.996,0.995,1.0,1.0],[0.998,0.998,0.996,0.99,0.994,0.993,0.999,0.999,0.998,0.991,0.994,0.993,0.999,1.0,0.997,0.991,0.994,0.993,1.0,1.0]],""K"":1,""R"":0.994,""featValue"":[19.888,0.093,0.009,0.006,0.005,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.149,0.149,0.366,-0.123,0.144,0.002,0.451,-0.426,0.037,0.099,0.182,-0.38,-0.171,-0.045,-0.145,0.068,-0.123,0.297,-0.03],[-0.224,0.231,0.055,0.26,0.055,-0.642,0.131,0.126,0.235,0.095,0.008,0.18,0.264,0.162,0.02,0.045,0.339,-0.26,-0.009,-0.026],[-0.223,0.355,-0.122,0.205,0.379,-0.104,0.186,-0.035,-0.217,0.04,-0.411,-0.067,0.069,-0.039,-0.124,0.078,-0.378,0.403,-0.063,0.136],[-0.223,-0.277,-0.358,0.33,-0.161,-0.015,-0.018,-0.21,0.01,0.169,0.083,0.319,0.009,-0.299,0.326,0.064,-0.322,-0.159,-0.308,-0.073],[-0.224,-0.186,-0.003,0.09,0.309,0.281,-0.378,0.173,0.248,-0.001,0.015,0.272,0.123,0.357,-0.132,0.382,-0.181,-0.038,0.277,-0.092],[-0.224,-0.21,0.349,0.196,0.054,0.187,-0.047,-0.317,0.038,0.142,0.125,0.119,0.285,-0.269,-0.189,-0.143,0.313,0.269,0.049,0.414],[-0.224,0.064,0.14,0.204,-0.267,0.181,0.041,0.095,0.079,0.144,0.189,-0.291,0.154,0.167,-0.23,-0.049,-0.002,0.274,-0.363,-0.556],[-0.224,0.188,0.087,0.143,-0.146,-0.093,-0.344,-0.106,-0.037,-0.373,0.301,-0.237,-0.123,0.329,0.101,-0.076,-0.219,-0.079,-0.222,0.444],[-0.223,0.296,-0.136,0.064,0.107,0.294,-0.161,-0.359,-0.104,0.138,-0.157,-0.379,-0.013,-0.042,0.314,0.209,0.371,-0.264,0.139,-0.136],[-0.223,-0.274,-0.404,0.071,-0.022,-0.082,0.203,-0.081,0.066,-0.231,0.052,0.011,-0.28,0.291,0.184,-0.124,0.312,0.475,0.233,-0.046],[-0.224,-0.221,0.054,-0.051,0.18,-0.094,-0.228,0.083,0.321,0.112,-0.38,-0.141,-0.53,-0.13,-0.243,-0.169,0.122,-0.127,-0.314,0.03],[-0.224,-0.204,0.383,-0.071,0.279,-0.114,0.394,0.001,0.084,-0.238,0.289,-0.259,-0.157,-0.265,0.167,0.363,-0.151,-0.056,0.059,-0.11],[-0.224,0.089,0.027,-0.068,-0.3,0.202,0.248,0.186,0.494,0.146,-0.19,-0.18,0.13,-0.013,0.224,-0.281,-0.282,-0.076,0.324,0.197],[-0.224,0.197,0.025,-0.152,-0.154,-0.032,-0.214,-0.138,0.105,-0.637,-0.191,0.232,0.146,-0.358,-0.103,-0.128,-0.003,0.029,0.106,-0.318],[-0.223,0.331,-0.205,-0.358,0.348,0.26,0.248,-0.053,0.083,0.07,0.406,0.286,-0.086,0.045,-0.119,-0.275,0.031,-0.145,-0.196,0.01],[-0.223,-0.276,-0.416,-0.064,-0.123,-0.022,0.167,0.068,-0.227,-0.119,0.017,-0.302,0.244,-0.05,-0.532,0.078,0.006,-0.334,0.094,0.146],[-0.224,-0.193,-0.043,-0.315,0.244,-0.168,-0.341,0.378,-0.259,0.114,0.074,-0.174,0.327,-0.12,0.358,-0.276,0.018,0.132,-0.041,-0.058],[-0.223,-0.247,0.363,-0.161,-0.043,-0.006,0.195,-0.305,-0.36,0.021,-0.309,0.18,0.024,0.439,0.066,-0.227,-0.12,-0.234,-0.009,-0.148],[-0.224,0.06,0.042,-0.317,-0.322,0.168,0.124,0.289,-0.087,-0.048,-0.207,0.213,0.013,0.026,0.136,0.478,0.244,0.13,-0.352,0.259],[-0.224,0.13,0.009,-0.371,-0.29,-0.346,-0.206,-0.249,-0.049,0.418,0.186,0.037,-0.221,-0.06,-0.18,0.196,-0.167,0.181,0.297,-0.04]],""selectVec"":[[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.223],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8008,""AfterCleanSamNum"":5402,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":479,""version"":""v-2025-12-09 11:03:24"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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