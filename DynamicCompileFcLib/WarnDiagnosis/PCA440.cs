using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA440")]
    [FCDisplay("PCA440")]
    public partial class PCA440 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁123号屏2号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁123号屏3号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁123号屏4号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁123号屏5号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁123号屏6号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁124号屏1号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁124号屏2号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁124号屏3号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁124号屏4号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁124号屏5号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁124号屏6号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁125号屏1号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁125号屏2号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁125号屏3号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁125号屏4号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁125号屏5号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁125号屏6号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁126号屏1号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁126号屏2号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁126号屏3号管壁温")]
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

		public PCA440()
		{
			ModelID = 481;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA440";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""481"",""name"":""PCA440"",""description"":""中温分隔屏过热器水冷壁25-41-60"",""founder"":""admin"",""creatTime"":""2025-12-09 14:28:01"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 14:30:12"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 17:31:56"",""duration"":2426268,""number"":8088,""filter"":2638,""mode"":5450,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2548}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah25ct141k"",""Description"":""中温（分隔屏）过热器水冷壁123号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""573.55"",""TMin"":""489.72"",""TAvg"":""533.85"",""DMax"":""3.28"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.82"",""C99"":""2.23""},{""PointId"":""d1_10hah25ct142k"",""Description"":""中温（分隔屏）过热器水冷壁123号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""572.77"",""TMin"":""487.73"",""TAvg"":""531.92"",""DMax"":""3.29"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.72"",""C99"":""3.32""},{""PointId"":""d1_10hah25ct143k"",""Description"":""中温（分隔屏）过热器水冷壁123号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""575.12"",""TMin"":""490.08"",""TAvg"":""534.99"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.31"",""C99"":""1.61""},{""PointId"":""d1_10hah25ct144k"",""Description"":""中温（分隔屏）过热器水冷壁123号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""578.27"",""TMin"":""492.46"",""TAvg"":""537.79"",""DMax"":""3.58"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.95"",""C99"":""2.39""},{""PointId"":""d1_10hah25ct145k"",""Description"":""中温（分隔屏）过热器水冷壁123号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""577.37"",""TMin"":""492.22"",""TAvg"":""537.74"",""DMax"":""5.22"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.10"",""C99"":""3.79""},{""PointId"":""d1_10hah25ct146k"",""Description"":""中温（分隔屏）过热器水冷壁124号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""569.76"",""TMin"":""489.28"",""TAvg"":""531.77"",""DMax"":""4.28"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.24"",""C99"":""2.75""},{""PointId"":""d1_10hah25ct147k"",""Description"":""中温（分隔屏）过热器水冷壁124号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.98"",""TMin"":""489.12"",""TAvg"":""532.56"",""DMax"":""2.75"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.84"",""C99"":""2.25""},{""PointId"":""d1_10hah25ct148k"",""Description"":""中温（分隔屏）过热器水冷壁124号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""570.99"",""TMin"":""486.66"",""TAvg"":""530.60"",""DMax"":""2.60"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.07"",""C99"":""2.53""},{""PointId"":""d1_10hah25ct149k"",""Description"":""中温（分隔屏）过热器水冷壁124号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""577.17"",""TMin"":""492.03"",""TAvg"":""537.48"",""DMax"":""2.59"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.46"",""C99"":""1.79""},{""PointId"":""d1_10hah25ct150k"",""Description"":""中温（分隔屏）过热器水冷壁124号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""578.20"",""TMin"":""493.46"",""TAvg"":""538.75"",""DMax"":""4.39"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.54"",""C99"":""3.11""},{""PointId"":""d1_10hah25ct151k"",""Description"":""中温（分隔屏）过热器水冷壁124号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""577.70"",""TMin"":""493.91"",""TAvg"":""539.24"",""DMax"":""6.14"",""DMin"":""0.00"",""DAvg"":""1.21"",""C95"":""4.13"",""C99"":""5.06""},{""PointId"":""d1_10hah25ct152k"",""Description"":""中温（分隔屏）过热器水冷壁125号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""571.11"",""TMin"":""491.30"",""TAvg"":""533.61"",""DMax"":""4.31"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.22"",""C99"":""2.72""},{""PointId"":""d1_10hah25ct153k"",""Description"":""中温（分隔屏）过热器水冷壁125号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""570.23"",""TMin"":""489.27"",""TAvg"":""532.21"",""DMax"":""3.50"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""2.01"",""C99"":""2.46""},{""PointId"":""d1_10hah25ct154k"",""Description"":""中温（分隔屏）过热器水冷壁125号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""571.40"",""TMin"":""488.41"",""TAvg"":""532.05"",""DMax"":""3.13"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""2.42"",""C99"":""2.97""},{""PointId"":""d1_10hah25ct155k"",""Description"":""中温（分隔屏）过热器水冷壁125号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""574.28"",""TMin"":""491.21"",""TAvg"":""535.57"",""DMax"":""1.59"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.21"",""C99"":""1.49""},{""PointId"":""d1_10hah25ct156k"",""Description"":""中温（分隔屏）过热器水冷壁125号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""576.88"",""TMin"":""493.01"",""TAvg"":""537.74"",""DMax"":""4.58"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.77"",""C99"":""3.39""},{""PointId"":""d1_10hah25ct157k"",""Description"":""中温（分隔屏）过热器水冷壁125号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""578.31"",""TMin"":""494.88"",""TAvg"":""539.69"",""DMax"":""5.81"",""DMin"":""0.00"",""DAvg"":""1.12"",""C95"":""3.84"",""C99"":""4.70""},{""PointId"":""d1_10hah25ct158k"",""Description"":""中温（分隔屏）过热器水冷壁126号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.13"",""TMin"":""492.61"",""TAvg"":""534.71"",""DMax"":""4.17"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.18"",""C99"":""2.68""},{""PointId"":""d1_10hah25ct159k"",""Description"":""中温（分隔屏）过热器水冷壁126号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""573.09"",""TMin"":""491.80"",""TAvg"":""534.69"",""DMax"":""2.87"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.78"",""C99"":""2.18""},{""PointId"":""d1_10hah25ct160k"",""Description"":""中温（分隔屏）过热器水冷壁126号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""572.62"",""TMin"":""490.01"",""TAvg"":""533.21"",""DMax"":""3.02"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.19"",""C99"":""2.68""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 14:30:12"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[489.715,487.728,490.077,492.457,492.224,489.277,489.122,486.655,492.033,493.456,493.909,491.297,489.274,488.413,491.21,493.014,494.883,492.607,491.803,490.012],""Train_X_max"":[573.55,572.774,575.115,578.265,577.367,569.755,571.979,570.991,577.173,578.202,577.702,571.106,570.231,571.403,574.279,576.879,578.314,572.126,573.086,572.616],""Train_X_std"":[10.729,10.831,10.811,10.894,10.86,10.51,10.686,10.734,10.829,10.787,10.771,10.454,10.552,10.676,10.682,10.67,10.765,10.418,10.582,10.664],""Train_X_mean"":[533.853,531.922,534.986,537.787,537.74,531.772,532.563,530.6,537.483,538.747,539.238,533.612,532.213,532.05,535.568,537.739,539.692,534.706,534.685,533.208],""Train_X_bais_max"":[[3.284,3.293,1.997,3.582,5.224,4.282,2.753,2.604,2.59,4.386,6.142,4.314,3.504,3.129,1.587,4.579,5.81,4.168,2.869,3.022]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.527,0.797,0.373,0.562,0.895,0.646,0.529,0.609,0.42,0.734,1.207,0.64,0.577,0.707,0.351,0.797,1.119,0.621,0.513,0.642]],""QCUL_95"":0.43751657,""QCUL_99"":0.7812091,""QCUL_95_line"":[1.817,2.715,1.313,1.954,3.097,2.242,1.835,2.071,1.463,2.539,4.133,2.22,2.006,2.423,1.214,2.765,3.837,2.184,1.779,2.191],""QCUL_99_line"":[2.225,3.321,1.611,2.394,3.794,2.746,2.248,2.534,1.792,3.11,5.059,2.721,2.457,2.966,1.487,3.388,4.696,2.678,2.179,2.681],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.285,0.288,0.287,0.289,0.288,0.279,0.284,0.285,0.288,0.286,0.286,0.278,0.28,0.284,0.284,0.283,0.286,0.277,0.281,0.283],""T2CUL_99_line"":[0.375,0.378,0.377,0.38,0.379,0.367,0.373,0.375,0.378,0.377,0.376,0.365,0.368,0.373,0.373,0.372,0.376,0.364,0.369,0.372],""Kesi_95"":1.558,""Kesi_99"":1.322,""Kesi_95_line"":[0.181,0.183,0.183,0.184,0.184,0.178,0.181,0.181,0.183,0.182,0.182,0.177,0.178,0.18,0.181,0.18,0.182,0.176,0.179,0.18],""Kesi_99_line"":[0.167,0.169,0.168,0.17,0.169,0.164,0.166,0.167,0.169,0.168,0.168,0.163,0.164,0.166,0.166,0.166,0.168,0.162,0.165,0.166],""COV"":[[1.0,0.999,0.997,0.994,0.988,0.999,1.0,0.999,0.995,0.99,0.982,0.998,0.999,0.998,0.996,0.989,0.983,0.998,0.999,0.998],[0.999,1.0,0.995,0.991,0.984,0.996,0.999,1.0,0.993,0.986,0.975,0.996,0.998,0.999,0.993,0.984,0.977,0.994,0.998,0.999],[0.997,0.995,1.0,0.999,0.996,0.995,0.996,0.996,1.0,0.997,0.991,0.995,0.995,0.994,0.999,0.996,0.992,0.995,0.996,0.995],[0.994,0.991,0.999,1.0,0.999,0.991,0.993,0.993,0.999,0.999,0.995,0.991,0.992,0.991,0.998,0.998,0.995,0.991,0.993,0.992],[0.988,0.984,0.996,0.999,1.0,0.986,0.987,0.987,0.997,0.999,0.999,0.986,0.986,0.984,0.996,0.999,0.999,0.987,0.987,0.985],[0.999,0.996,0.995,0.991,0.986,1.0,0.998,0.996,0.993,0.989,0.981,1.0,0.998,0.996,0.995,0.987,0.982,1.0,0.998,0.996],[1.0,0.999,0.996,0.993,0.987,0.998,1.0,0.999,0.995,0.99,0.981,0.998,1.0,0.999,0.996,0.989,0.983,0.998,1.0,0.999],[0.999,1.0,0.996,0.993,0.987,0.996,0.999,1.0,0.995,0.99,0.98,0.996,0.999,1.0,0.996,0.988,0.982,0.996,0.999,1.0],[0.995,0.993,1.0,0.999,0.997,0.993,0.995,0.995,1.0,0.999,0.994,0.993,0.994,0.993,0.999,0.998,0.995,0.993,0.995,0.994],[0.99,0.986,0.997,0.999,0.999,0.989,0.99,0.99,0.999,1.0,0.998,0.988,0.989,0.987,0.998,1.0,0.998,0.989,0.99,0.988],[0.982,0.975,0.991,0.995,0.999,0.981,0.981,0.98,0.994,0.998,1.0,0.98,0.98,0.977,0.992,0.998,1.0,0.982,0.982,0.979],[0.998,0.996,0.995,0.991,0.986,1.0,0.998,0.996,0.993,0.988,0.98,1.0,0.999,0.997,0.995,0.988,0.982,1.0,0.999,0.997],[0.999,0.998,0.995,0.992,0.986,0.998,1.0,0.999,0.994,0.989,0.98,0.999,1.0,0.999,0.996,0.988,0.982,0.998,1.0,0.999],[0.998,0.999,0.994,0.991,0.984,0.996,0.999,1.0,0.993,0.987,0.977,0.997,0.999,1.0,0.995,0.986,0.979,0.996,0.999,1.0],[0.996,0.993,0.999,0.998,0.996,0.995,0.996,0.996,0.999,0.998,0.992,0.995,0.996,0.995,1.0,0.997,0.994,0.995,0.996,0.995],[0.989,0.984,0.996,0.998,0.999,0.987,0.989,0.988,0.998,1.0,0.998,0.988,0.988,0.986,0.997,1.0,0.999,0.989,0.989,0.988],[0.983,0.977,0.992,0.995,0.999,0.982,0.983,0.982,0.995,0.998,1.0,0.982,0.982,0.979,0.994,0.999,1.0,0.984,0.984,0.981],[0.998,0.994,0.995,0.991,0.987,1.0,0.998,0.996,0.993,0.989,0.982,1.0,0.998,0.996,0.995,0.989,0.984,1.0,0.999,0.997],[0.999,0.998,0.996,0.993,0.987,0.998,1.0,0.999,0.995,0.99,0.982,0.999,1.0,0.999,0.996,0.989,0.984,0.999,1.0,0.999],[0.998,0.999,0.995,0.992,0.985,0.996,0.999,1.0,0.994,0.988,0.979,0.997,0.999,1.0,0.995,0.988,0.981,0.997,0.999,1.0]],""K"":1,""R"":0.993,""featValue"":[19.871,0.105,0.014,0.006,0.003,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.164,-0.013,0.267,0.28,-0.011,-0.293,0.466,-0.318,0.045,-0.305,0.067,0.088,-0.205,-0.227,-0.063,-0.105,0.037,0.127,-0.368],[-0.223,0.24,-0.358,0.157,0.166,0.066,0.155,0.051,0.111,-0.065,-0.477,-0.067,-0.359,-0.061,0.312,-0.083,0.086,-0.072,-0.135,0.405],[-0.224,-0.05,-0.158,0.39,-0.355,-0.046,-0.126,0.233,0.023,0.232,0.127,-0.111,0.243,0.135,0.061,0.484,0.239,0.256,-0.015,0.226],[-0.224,-0.162,-0.21,0.29,-0.069,-0.4,0.066,-0.444,0.126,0.102,-0.036,-0.168,-0.03,-0.158,-0.364,-0.321,-0.092,0.28,-0.124,-0.099],[-0.223,-0.307,-0.053,0.247,0.322,-0.147,0.117,-0.081,0.25,0.111,0.005,0.296,0.162,0.287,0.01,0.106,0.077,-0.582,0.078,-0.117],[-0.224,0.172,0.395,0.321,-0.03,0.225,0.103,-0.114,0.005,-0.226,0.033,-0.347,0.459,0.018,0.21,-0.23,-0.275,-0.125,-0.033,0.119],[-0.224,0.18,-0.046,-0.019,0.294,-0.068,-0.161,-0.224,-0.224,-0.456,0.28,-0.135,-0.201,0.1,-0.233,0.464,-0.091,-0.064,-0.242,0.051],[-0.224,0.177,-0.297,-0.065,0.09,0.206,0.335,-0.248,-0.134,-0.183,0.088,0.211,0.179,0.114,0.18,0.008,0.174,0.355,0.433,-0.278],[-0.224,-0.121,-0.149,0.136,-0.291,0.112,-0.06,0.346,0.047,-0.225,0.385,0.101,-0.377,0.318,0.094,-0.378,-0.164,-0.012,-0.101,-0.172],[-0.224,-0.258,-0.061,0.005,-0.152,0.118,-0.092,-0.193,-0.37,0.164,0.211,-0.164,-0.191,-0.531,0.286,0.023,0.134,-0.338,0.148,-0.08],[-0.222,-0.419,0.123,-0.066,0.369,0.316,-0.069,0.065,0.088,0.009,0.153,0.339,0.086,-0.258,-0.013,-0.07,-0.053,0.364,-0.193,0.335],[-0.224,0.178,0.409,0.103,-0.096,0.218,0.159,-0.151,0.043,0.394,-0.045,0.133,-0.447,0.115,-0.216,0.186,-0.274,0.056,0.286,0.065],[-0.224,0.194,0.097,-0.211,0.057,-0.035,-0.568,-0.299,0.048,0.304,-0.075,0.072,0.033,0.27,0.372,-0.11,0.07,0.111,-0.242,-0.19],[-0.224,0.229,-0.192,-0.274,-0.028,0.402,-0.069,0.051,0.211,0.16,0.126,-0.21,0.143,0.0,-0.502,-0.201,0.332,-0.236,-0.009,0.083],[-0.224,-0.073,-0.02,-0.167,-0.502,0.031,-0.245,-0.125,0.191,-0.404,-0.366,0.352,0.122,-0.178,-0.111,0.143,-0.156,-0.124,0.099,0.028],[-0.223,-0.276,0.005,-0.3,-0.13,-0.056,0.239,0.029,-0.612,0.103,-0.276,-0.036,0.123,0.377,-0.124,-0.091,-0.05,-0.035,-0.169,0.172],[-0.222,-0.387,0.147,-0.267,0.132,-0.008,0.005,0.161,0.322,-0.135,-0.212,-0.552,-0.139,0.088,0.086,0.163,0.042,0.164,0.215,-0.237],[-0.224,0.149,0.486,0.003,-0.106,-0.225,0.291,0.112,0.02,-0.148,-0.004,0.173,-0.097,-0.16,-0.003,-0.038,0.575,0.031,-0.293,-0.164],[-0.224,0.165,0.083,-0.234,0.088,-0.549,-0.13,0.16,0.001,-0.024,0.24,0.028,0.043,-0.026,0.047,-0.196,-0.025,-0.019,0.474,0.426],[-0.224,0.2,-0.184,-0.319,-0.036,-0.147,0.345,0.204,0.173,0.244,0.148,0.018,0.162,-0.247,0.136,0.204,-0.445,-0.045,-0.303,-0.202]],""selectVec"":[[-0.224],[-0.223],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.222],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.222],[-0.224],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8088,""AfterCleanSamNum"":5450,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.3%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":481,""version"":""v-2025-12-09 14:30:12"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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