using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA418")]
    [FCDisplay("PCA418")]
    public partial class PCA418 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁50号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁50号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁50号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁51号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁51号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁51号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁51号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁51号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁51号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁52号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁52号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁52号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁52号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁52号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁52号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁53号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁53号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁53号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁53号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁53号屏5号管壁温")]
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

		public PCA418()
		{
			ModelID = 459;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA418";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""459"",""name"":""PCA418"",""description"":""中温分隔屏过热器水冷壁21-01-20"",""founder"":""admin"",""creatTime"":""2025-12-09 10:04:27"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:06:34"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 20:01:56"",""et"":""2025-12-07 13:48:46"",""duration"":2396810,""number"":7990,""filter"":2633,""mode"":5357,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2543}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah21ct101k"",""Description"":""中温（分隔屏）过热器水冷壁50号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""577.56"",""TMin"":""493.15"",""TAvg"":""541.51"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.96"",""C99"":""2.40""},{""PointId"":""d1_10hah21ct102k"",""Description"":""中温（分隔屏）过热器水冷壁50号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""578.61"",""TMin"":""493.87"",""TAvg"":""542.49"",""DMax"":""3.23"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.67"",""C99"":""3.26""},{""PointId"":""d1_10hah21ct103k"",""Description"":""中温（分隔屏）过热器水冷壁50号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""579.04"",""TMin"":""495.54"",""TAvg"":""543.40"",""DMax"":""4.65"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.53"",""C99"":""4.31""},{""PointId"":""d1_10hah21ct104k"",""Description"":""中温（分隔屏）过热器水冷壁51号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""571.16"",""TMin"":""486.95"",""TAvg"":""534.61"",""DMax"":""6.31"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.74"",""C99"":""4.57""},{""PointId"":""d1_10hah21ct105k"",""Description"":""中温（分隔屏）过热器水冷壁51号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""571.62"",""TMin"":""484.83"",""TAvg"":""536.26"",""DMax"":""3.37"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.93"",""C99"":""3.59""},{""PointId"":""d1_10hah21ct106k"",""Description"":""中温（分隔屏）过热器水冷壁51号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""570.43"",""TMin"":""483.47"",""TAvg"":""535.31"",""DMax"":""3.63"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.68"",""C99"":""3.29""},{""PointId"":""d1_10hah21ct107k"",""Description"":""中温（分隔屏）过热器水冷壁51号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""578.15"",""TMin"":""492.85"",""TAvg"":""542.00"",""DMax"":""2.19"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.33"",""C99"":""1.63""},{""PointId"":""d1_10hah21ct108k"",""Description"":""中温（分隔屏）过热器水冷壁51号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""578.56"",""TMin"":""492.72"",""TAvg"":""541.96"",""DMax"":""2.09"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.83"",""C99"":""2.24""},{""PointId"":""d1_10hah21ct109k"",""Description"":""中温（分隔屏）过热器水冷壁51号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""579.29"",""TMin"":""494.75"",""TAvg"":""543.30"",""DMax"":""3.94"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.81"",""C99"":""3.44""},{""PointId"":""d1_10hah21ct110k"",""Description"":""中温（分隔屏）过热器水冷壁52号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""573.00"",""TMin"":""488.59"",""TAvg"":""536.18"",""DMax"":""6.12"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.43"",""C99"":""4.21""},{""PointId"":""d1_10hah21ct111k"",""Description"":""中温（分隔屏）过热器水冷壁52号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""572.18"",""TMin"":""486.73"",""TAvg"":""536.56"",""DMax"":""2.82"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.71"",""C99"":""3.31""},{""PointId"":""d1_10hah21ct112k"",""Description"":""中温（分隔屏）过热器水冷壁52号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""571.52"",""TMin"":""484.63"",""TAvg"":""535.81"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""2.70"",""C99"":""3.30""},{""PointId"":""d1_10hah21ct113k"",""Description"":""中温（分隔屏）过热器水冷壁52号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""579.79"",""TMin"":""494.80"",""TAvg"":""543.31"",""DMax"":""2.04"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.54"",""C99"":""1.88""},{""PointId"":""d1_10hah21ct114k"",""Description"":""中温（分隔屏）过热器水冷壁52号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""578.74"",""TMin"":""494.06"",""TAvg"":""542.54"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.15"",""C99"":""2.63""},{""PointId"":""d1_10hah21ct115k"",""Description"":""中温（分隔屏）过热器水冷壁52号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""580.12"",""TMin"":""496.51"",""TAvg"":""544.49"",""DMax"":""5.27"",""DMin"":""0.00"",""DAvg"":""1.01"",""C95"":""3.47"",""C99"":""4.25""},{""PointId"":""d1_10hah21ct116k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""572.08"",""TMin"":""487.54"",""TAvg"":""535.76"",""DMax"":""3.49"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.73"",""C99"":""3.34""},{""PointId"":""d1_10hah21ct117k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""570.49"",""TMin"":""484.49"",""TAvg"":""535.12"",""DMax"":""3.20"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.64"",""C99"":""3.23""},{""PointId"":""d1_10hah21ct118k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""571.00"",""TMin"":""484.09"",""TAvg"":""535.60"",""DMax"":""3.05"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.37"",""C99"":""2.91""},{""PointId"":""d1_10hah21ct119k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""579.14"",""TMin"":""493.90"",""TAvg"":""542.98"",""DMax"":""2.19"",""DMin"":""0.00"",""DAvg"":""0.47"",""C95"":""1.60"",""C99"":""1.95""},{""PointId"":""d1_10hah21ct120k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""578.33"",""TMin"":""493.78"",""TAvg"":""542.53"",""DMax"":""3.53"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.78"",""C99"":""3.40""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:06:34"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[493.153,493.872,495.541,486.953,484.832,483.474,492.851,492.724,494.754,488.589,486.734,484.632,494.796,494.057,496.507,487.538,484.494,484.085,493.896,493.776],""Train_X_max"":[577.556,578.612,579.043,571.162,571.622,570.428,578.145,578.564,579.285,572.998,572.183,571.516,579.789,578.739,580.118,572.081,570.49,571.004,579.139,578.325],""Train_X_std"":[9.202,9.157,9.001,9.311,9.409,9.45,9.207,9.239,9.013,9.288,9.268,9.443,9.17,9.116,8.943,9.148,9.29,9.407,9.17,9.071],""Train_X_mean"":[541.506,542.488,543.404,534.611,536.256,535.31,542.0,541.963,543.302,536.18,536.56,535.812,543.308,542.538,544.485,535.762,535.124,535.597,542.981,542.526],""Train_X_bais_max"":[[3.009,3.229,4.645,6.305,3.368,3.629,2.192,2.088,3.941,6.119,2.823,3.359,2.039,3.357,5.265,3.489,3.199,3.046,2.185,3.527]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.001,0.0,0.0]],""Train_X_bais_mean"":[[0.576,0.79,1.041,1.09,0.858,0.773,0.381,0.539,0.822,0.993,0.803,0.79,0.45,0.628,1.014,0.81,0.78,0.689,0.466,0.815]],""QCUL_95"":0.735910833,""QCUL_99"":1.31956351,""QCUL_95_line"":[1.964,2.668,3.525,3.736,2.931,2.683,1.331,1.831,2.808,3.434,2.708,2.699,1.539,2.147,3.472,2.734,2.64,2.372,1.595,2.78],""QCUL_99_line"":[2.404,3.262,4.311,4.573,3.587,3.287,1.631,2.24,3.436,4.207,3.31,3.303,1.884,2.628,4.249,3.343,3.229,2.905,1.952,3.402],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.246,0.245,0.241,0.249,0.252,0.253,0.247,0.247,0.241,0.249,0.248,0.253,0.246,0.244,0.24,0.245,0.249,0.252,0.246,0.243],""T2CUL_99_line"":[0.324,0.322,0.317,0.328,0.331,0.333,0.324,0.325,0.317,0.327,0.326,0.332,0.323,0.321,0.315,0.322,0.327,0.331,0.323,0.319],""Kesi_95"":1.56,""Kesi_99"":1.327,""Kesi_95_line"":[0.157,0.156,0.154,0.159,0.161,0.161,0.157,0.158,0.154,0.158,0.158,0.161,0.156,0.156,0.153,0.156,0.159,0.161,0.156,0.155],""Kesi_99_line"":[0.145,0.144,0.142,0.147,0.148,0.149,0.145,0.145,0.142,0.146,0.146,0.149,0.144,0.143,0.141,0.144,0.146,0.148,0.144,0.143],""COV"":[[1.0,0.998,0.996,0.98,0.984,0.988,0.999,0.999,0.997,0.981,0.985,0.986,0.999,0.997,0.993,0.985,0.985,0.988,0.998,0.996],[0.998,1.0,0.999,0.972,0.978,0.981,0.997,0.999,0.999,0.974,0.979,0.98,0.998,0.999,0.997,0.979,0.979,0.982,0.997,0.999],[0.996,0.999,1.0,0.962,0.97,0.973,0.993,0.995,0.999,0.965,0.972,0.971,0.995,0.996,0.999,0.972,0.972,0.975,0.995,0.997],[0.98,0.972,0.962,1.0,0.996,0.994,0.985,0.98,0.969,0.999,0.995,0.996,0.981,0.976,0.962,0.997,0.995,0.994,0.98,0.97],[0.984,0.978,0.97,0.996,1.0,0.999,0.989,0.985,0.976,0.996,0.999,0.999,0.986,0.982,0.97,0.997,0.999,0.999,0.986,0.976],[0.988,0.981,0.973,0.994,0.999,1.0,0.992,0.988,0.979,0.994,0.997,0.999,0.988,0.984,0.972,0.995,0.998,0.999,0.988,0.979],[0.999,0.997,0.993,0.985,0.989,0.992,1.0,0.999,0.995,0.986,0.989,0.99,0.999,0.997,0.992,0.989,0.99,0.992,0.999,0.995],[0.999,0.999,0.995,0.98,0.985,0.988,0.999,1.0,0.998,0.982,0.986,0.987,0.998,0.999,0.994,0.985,0.986,0.989,0.998,0.998],[0.997,0.999,0.999,0.969,0.976,0.979,0.995,0.998,1.0,0.972,0.979,0.978,0.997,0.998,0.999,0.978,0.979,0.981,0.997,0.998],[0.981,0.974,0.965,0.999,0.996,0.994,0.986,0.982,0.972,1.0,0.996,0.996,0.984,0.979,0.966,0.998,0.996,0.994,0.983,0.974],[0.985,0.979,0.972,0.995,0.999,0.997,0.989,0.986,0.979,0.996,1.0,0.999,0.988,0.985,0.974,0.998,1.0,0.998,0.988,0.979],[0.986,0.98,0.971,0.996,0.999,0.999,0.99,0.987,0.978,0.996,0.999,1.0,0.988,0.984,0.972,0.997,0.999,1.0,0.988,0.979],[0.999,0.998,0.995,0.981,0.986,0.988,0.999,0.998,0.997,0.984,0.988,0.988,1.0,0.999,0.995,0.988,0.988,0.99,0.999,0.997],[0.997,0.999,0.996,0.976,0.982,0.984,0.997,0.999,0.998,0.979,0.985,0.984,0.999,1.0,0.997,0.983,0.984,0.986,0.998,0.999],[0.993,0.997,0.999,0.962,0.97,0.972,0.992,0.994,0.999,0.966,0.974,0.972,0.995,0.997,1.0,0.973,0.974,0.976,0.995,0.998],[0.985,0.979,0.972,0.997,0.997,0.995,0.989,0.985,0.978,0.998,0.998,0.997,0.988,0.983,0.973,1.0,0.998,0.997,0.988,0.979],[0.985,0.979,0.972,0.995,0.999,0.998,0.99,0.986,0.979,0.996,1.0,0.999,0.988,0.984,0.974,0.998,1.0,0.999,0.989,0.979],[0.988,0.982,0.975,0.994,0.999,0.999,0.992,0.989,0.981,0.994,0.998,1.0,0.99,0.986,0.976,0.997,0.999,1.0,0.991,0.982],[0.998,0.997,0.995,0.98,0.986,0.988,0.999,0.998,0.997,0.983,0.988,0.988,0.999,0.998,0.995,0.988,0.989,0.991,1.0,0.998],[0.996,0.999,0.997,0.97,0.976,0.979,0.995,0.998,0.998,0.974,0.979,0.979,0.997,0.999,0.998,0.979,0.979,0.982,0.998,1.0]],""K"":1,""R"":0.989,""featValue"":[19.786,0.18,0.013,0.011,0.005,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,-0.139,-0.084,0.414,-0.055,0.302,-0.14,0.192,-0.061,-0.165,-0.337,0.084,-0.063,-0.322,0.153,-0.154,-0.188,-0.011,0.507,0.051],[-0.224,-0.236,-0.028,0.2,-0.069,-0.226,0.089,0.073,-0.443,-0.179,-0.272,-0.187,-0.013,0.023,0.198,0.265,-0.167,-0.151,-0.514,0.146],[-0.223,-0.322,-0.014,-0.001,-0.445,0.154,0.179,0.017,-0.288,-0.188,0.172,0.277,0.22,0.348,-0.295,-0.159,0.195,0.193,0.062,-0.089],[-0.222,0.311,-0.475,0.102,-0.18,-0.175,0.162,0.069,0.243,-0.297,0.204,0.181,0.1,-0.356,-0.095,0.095,0.22,-0.294,-0.114,-0.004],[-0.223,0.252,0.211,0.027,-0.246,-0.07,0.03,0.373,-0.108,0.313,0.167,-0.15,-0.335,-0.033,-0.247,-0.443,-0.195,-0.218,-0.117,0.07],[-0.224,0.208,0.298,0.363,-0.045,0.088,0.151,-0.354,-0.017,-0.069,0.154,-0.253,-0.189,-0.245,-0.035,0.116,0.105,0.421,-0.1,-0.356],[-0.225,-0.074,-0.065,0.335,0.048,0.233,-0.21,0.169,0.242,0.151,0.39,-0.374,0.211,0.333,0.243,0.107,0.205,-0.065,-0.011,0.229],[-0.224,-0.138,-0.077,0.229,0.051,-0.446,0.12,0.027,0.276,0.323,-0.2,0.004,0.158,0.25,-0.201,0.157,-0.225,-0.077,0.207,-0.429],[-0.223,-0.256,0.01,-0.096,-0.31,-0.028,0.163,-0.207,0.393,0.337,-0.144,0.258,-0.33,-0.076,0.229,0.062,0.101,0.173,-0.098,0.364],[-0.223,0.278,-0.53,-0.093,0.091,-0.02,-0.116,-0.19,-0.334,0.251,0.199,0.129,-0.001,0.1,0.196,-0.046,-0.354,0.342,0.041,0.035],[-0.224,0.222,0.196,-0.287,-0.198,-0.188,-0.369,0.308,-0.016,-0.202,-0.044,0.127,-0.221,0.192,0.361,0.245,0.184,0.07,0.14,-0.286],[-0.224,0.228,0.252,0.08,0.087,-0.127,-0.148,-0.448,-0.094,-0.177,0.015,0.109,-0.103,0.234,-0.282,0.191,-0.056,-0.278,0.285,0.432],[-0.224,-0.119,-0.103,-0.007,0.161,0.16,-0.568,-0.169,-0.099,0.273,-0.214,0.135,-0.003,-0.144,-0.269,-0.088,0.358,-0.145,-0.291,-0.197],[-0.224,-0.18,0.008,-0.148,0.142,-0.455,-0.216,-0.058,0.202,-0.337,-0.014,-0.257,0.144,-0.088,-0.029,-0.486,0.006,0.32,-0.015,0.172],[-0.223,-0.309,0.069,-0.432,-0.181,0.167,-0.054,-0.263,0.027,-0.014,0.285,-0.242,0.109,-0.264,0.1,0.098,-0.329,-0.347,0.113,-0.218],[-0.224,0.222,-0.258,-0.298,0.033,0.327,0.29,-0.072,0.101,-0.114,-0.462,-0.417,-0.122,0.293,-0.075,-0.089,0.13,-0.049,0.033,-0.052],[-0.224,0.222,0.241,-0.228,-0.02,0.082,0.046,0.262,-0.036,0.212,-0.173,-0.025,0.54,-0.281,-0.199,0.302,-0.022,0.265,0.017,0.251],[-0.224,0.19,0.313,0.037,0.23,0.074,0.242,-0.144,0.02,0.022,-0.062,0.336,0.339,0.087,0.446,-0.382,0.015,-0.234,-0.15,-0.121],[-0.224,-0.119,0.049,-0.06,0.406,0.291,0.012,0.245,0.289,-0.275,0.14,0.284,-0.218,0.104,-0.225,0.142,-0.367,0.129,-0.281,-0.032],[-0.223,-0.241,-0.016,-0.143,0.495,-0.145,0.342,0.169,-0.3,0.131,0.202,-0.016,-0.222,-0.157,0.026,0.068,0.384,-0.045,0.286,0.033]],""selectVec"":[[-0.224],[-0.224],[-0.223],[-0.222],[-0.223],[-0.224],[-0.225],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7990,""AfterCleanSamNum"":5357,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":459,""version"":""v-2025-12-09 10:06:34"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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