using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA435")]
    [FCDisplay("PCA435")]
    public partial class PCA435 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁106号屏5号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁106号屏6号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁107号屏1号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁107号屏2号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁107号屏3号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁107号屏4号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁107号屏5号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁107号屏6号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁108号屏1号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁108号屏2号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁108号屏3号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁108号屏4号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁108号屏5号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁108号屏6号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁109号屏1号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁109号屏2号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁109号屏3号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁109号屏4号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁109号屏5号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁109号屏6号管壁温")]
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

		public PCA435()
		{
			ModelID = 476;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA435";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""476"",""name"":""PCA435"",""description"":""中温分隔屏过热器水冷壁24-41-60"",""founder"":""admin"",""creatTime"":""2025-12-09 10:52:20"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:54:27"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 17:03:24"",""et"":""2025-12-07 10:50:14"",""duration"":2396810,""number"":7990,""filter"":2599,""mode"":5391,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2509}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah24ct141k"",""Description"":""中温（分隔屏）过热器水冷壁106号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""579.81"",""TMin"":""484.46"",""TAvg"":""533.50"",""DMax"":""2.38"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.93"",""C99"":""2.35""},{""PointId"":""d1_10hah24ct142k"",""Description"":""中温（分隔屏）过热器水冷壁106号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""579.74"",""TMin"":""484.84"",""TAvg"":""534.08"",""DMax"":""3.29"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.31"",""C99"":""2.83""},{""PointId"":""d1_10hah24ct143k"",""Description"":""中温（分隔屏）过热器水冷壁107号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""571.40"",""TMin"":""480.82"",""TAvg"":""527.40"",""DMax"":""8.36"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.26"",""C99"":""4.00""},{""PointId"":""d1_10hah24ct144k"",""Description"":""中温（分隔屏）过热器水冷壁107号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""574.48"",""TMin"":""482.52"",""TAvg"":""529.10"",""DMax"":""3.60"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.41"",""C99"":""2.95""},{""PointId"":""d1_10hah24ct145k"",""Description"":""中温（分隔屏）过热器水冷壁107号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""574.58"",""TMin"":""481.07"",""TAvg"":""528.58"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.50"",""C99"":""3.06""},{""PointId"":""d1_10hah24ct146k"",""Description"":""中温（分隔屏）过热器水冷壁107号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""578.48"",""TMin"":""483.47"",""TAvg"":""532.34"",""DMax"":""1.51"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.04"",""C99"":""1.28""},{""PointId"":""d1_10hah24ct147k"",""Description"":""中温（分隔屏）过热器水冷壁107号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""580.07"",""TMin"":""484.45"",""TAvg"":""533.65"",""DMax"":""2.09"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.40"",""C99"":""1.72""},{""PointId"":""d1_10hah24ct148k"",""Description"":""中温（分隔屏）过热器水冷壁107号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""581.36"",""TMin"":""485.65"",""TAvg"":""535.23"",""DMax"":""3.40"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.22"",""C99"":""2.71""},{""PointId"":""d1_10hah24ct149k"",""Description"":""中温（分隔屏）过热器水冷壁108号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""572.88"",""TMin"":""481.97"",""TAvg"":""528.62"",""DMax"":""5.79"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.38"",""C99"":""2.92""},{""PointId"":""d1_10hah24ct150k"",""Description"":""中温（分隔屏）过热器水冷壁108号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""573.63"",""TMin"":""480.31"",""TAvg"":""527.50"",""DMax"":""2.28"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.56"",""C99"":""1.91""},{""PointId"":""d1_10hah24ct151k"",""Description"":""中温（分隔屏）过热器水冷壁108号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""574.41"",""TMin"":""480.26"",""TAvg"":""527.48"",""DMax"":""3.32"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.90"",""C99"":""2.32""},{""PointId"":""d1_10hah24ct152k"",""Description"":""中温（分隔屏）过热器水冷壁108号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""578.46"",""TMin"":""483.54"",""TAvg"":""532.54"",""DMax"":""1.64"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.18"",""C99"":""1.44""},{""PointId"":""d1_10hah24ct153k"",""Description"":""中温（分隔屏）过热器水冷壁108号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""577.77"",""TMin"":""482.65"",""TAvg"":""531.34"",""DMax"":""2.51"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.71"",""C99"":""2.09""},{""PointId"":""d1_10hah24ct154k"",""Description"":""中温（分隔屏）过热器水冷壁108号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""579.46"",""TMin"":""484.77"",""TAvg"":""533.53"",""DMax"":""6.44"",""DMin"":""0.00"",""DAvg"":""0.94"",""C95"":""3.28"",""C99"":""4.02""},{""PointId"":""d1_10hah24ct155k"",""Description"":""中温（分隔屏）过热器水冷壁109号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""573.09"",""TMin"":""482.77"",""TAvg"":""528.92"",""DMax"":""3.72"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.96"",""C99"":""2.40""},{""PointId"":""d1_10hah24ct156k"",""Description"":""中温（分隔屏）过热器水冷壁109号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""572.87"",""TMin"":""481.28"",""TAvg"":""527.87"",""DMax"":""2.48"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.83"",""C99"":""2.24""},{""PointId"":""d1_10hah24ct157k"",""Description"":""中温（分隔屏）过热器水冷壁109号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""573.88"",""TMin"":""480.65"",""TAvg"":""527.54"",""DMax"":""3.44"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.08"",""C99"":""2.54""},{""PointId"":""d1_10hah24ct158k"",""Description"":""中温（分隔屏）过热器水冷壁109号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""578.16"",""TMin"":""483.27"",""TAvg"":""531.90"",""DMax"":""1.95"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.52"",""C99"":""1.86""},{""PointId"":""d1_10hah24ct159k"",""Description"":""中温（分隔屏）过热器水冷壁109号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""579.66"",""TMin"":""484.19"",""TAvg"":""532.83"",""DMax"":""2.98"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.25"",""C99"":""2.75""},{""PointId"":""d1_10hah24ct160k"",""Description"":""中温（分隔屏）过热器水冷壁109号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""578.10"",""TMin"":""483.18"",""TAvg"":""532.04"",""DMax"":""4.48"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.98"",""C99"":""3.65""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:54:27"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[484.456,484.839,480.821,482.516,481.071,483.474,484.453,485.651,481.974,480.311,480.257,483.542,482.648,484.773,482.766,481.284,480.654,483.27,484.191,483.182],""Train_X_max"":[579.807,579.742,571.401,574.476,574.576,578.482,580.072,581.361,572.883,573.626,574.414,578.461,577.772,579.455,573.094,572.872,573.881,578.161,579.66,578.103],""Train_X_std"":[11.127,11.104,11.259,11.245,11.325,11.293,11.312,11.289,11.223,11.266,11.342,11.361,11.316,11.149,11.164,11.156,11.29,11.356,11.39,11.295],""Train_X_mean"":[533.5,534.081,527.399,529.1,528.584,532.336,533.654,535.232,528.622,527.496,527.484,532.541,531.339,533.529,528.916,527.872,527.539,531.897,532.829,532.035],""Train_X_bais_max"":[[2.382,3.285,8.362,3.596,3.305,1.505,2.085,3.4,5.79,2.278,3.323,1.64,2.512,6.438,3.723,2.475,3.442,1.949,2.977,4.481]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.569,0.682,0.915,0.699,0.721,0.305,0.405,0.646,0.667,0.447,0.547,0.343,0.494,0.941,0.549,0.533,0.596,0.441,0.656,0.861]],""QCUL_95"":0.300968,""QCUL_99"":0.529148638,""QCUL_95_line"":[1.925,2.312,3.255,2.412,2.498,1.043,1.402,2.217,2.38,1.56,1.896,1.179,1.705,3.281,1.958,1.827,2.076,1.516,2.248,2.976],""QCUL_99_line"":[2.354,2.827,3.995,2.954,3.06,1.277,1.717,2.714,2.922,1.912,2.323,1.443,2.088,4.021,2.403,2.236,2.544,1.856,2.752,3.645],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.297,0.297,0.301,0.3,0.302,0.302,0.302,0.301,0.3,0.301,0.303,0.303,0.302,0.298,0.298,0.298,0.301,0.303,0.304,0.302],""T2CUL_99_line"":[0.391,0.39,0.395,0.395,0.397,0.396,0.397,0.396,0.394,0.395,0.398,0.399,0.397,0.391,0.392,0.392,0.396,0.399,0.4,0.396],""Kesi_95"":1.553,""Kesi_99"":1.303,""Kesi_95_line"":[0.189,0.188,0.191,0.191,0.192,0.192,0.192,0.192,0.19,0.191,0.192,0.193,0.192,0.189,0.189,0.189,0.192,0.193,0.193,0.192],""Kesi_99_line"":[0.173,0.173,0.175,0.175,0.176,0.176,0.176,0.176,0.175,0.175,0.176,0.177,0.176,0.173,0.174,0.173,0.176,0.177,0.177,0.176],""COV"":[[1.0,0.999,0.991,0.994,0.994,0.999,0.999,0.999,0.993,0.996,0.995,0.998,0.998,0.995,0.994,0.994,0.993,0.996,0.995,0.994],[0.999,1.0,0.988,0.991,0.991,0.998,0.999,1.0,0.991,0.994,0.993,0.998,0.998,0.997,0.992,0.992,0.991,0.996,0.996,0.996],[0.991,0.988,1.0,0.998,0.997,0.994,0.991,0.988,0.999,0.997,0.995,0.992,0.989,0.979,0.998,0.996,0.994,0.99,0.987,0.982],[0.994,0.991,0.998,1.0,1.0,0.996,0.994,0.99,0.999,0.999,0.998,0.994,0.992,0.984,0.998,0.999,0.998,0.994,0.99,0.986],[0.994,0.991,0.997,1.0,1.0,0.997,0.994,0.99,0.997,0.999,0.999,0.995,0.992,0.984,0.997,0.998,0.999,0.994,0.99,0.985],[0.999,0.998,0.994,0.996,0.997,1.0,0.999,0.998,0.996,0.998,0.997,0.999,0.998,0.994,0.997,0.997,0.996,0.998,0.996,0.994],[0.999,0.999,0.991,0.994,0.994,0.999,1.0,0.999,0.994,0.996,0.996,0.999,1.0,0.997,0.995,0.995,0.995,0.998,0.998,0.997],[0.999,1.0,0.988,0.99,0.99,0.998,0.999,1.0,0.991,0.993,0.992,0.998,0.999,0.998,0.993,0.992,0.991,0.997,0.997,0.998],[0.993,0.991,0.999,0.999,0.997,0.996,0.994,0.991,1.0,0.998,0.997,0.995,0.992,0.985,1.0,0.998,0.996,0.994,0.991,0.987],[0.996,0.994,0.997,0.999,0.999,0.998,0.996,0.993,0.998,1.0,0.999,0.997,0.995,0.989,0.999,1.0,0.999,0.997,0.994,0.991],[0.995,0.993,0.995,0.998,0.999,0.997,0.996,0.992,0.997,0.999,1.0,0.997,0.995,0.988,0.997,0.999,1.0,0.997,0.994,0.99],[0.998,0.998,0.992,0.994,0.995,0.999,0.999,0.998,0.995,0.997,0.997,1.0,0.999,0.996,0.996,0.996,0.996,0.999,0.998,0.997],[0.998,0.998,0.989,0.992,0.992,0.998,1.0,0.999,0.992,0.995,0.995,0.999,1.0,0.998,0.994,0.995,0.994,0.999,0.999,0.999],[0.995,0.997,0.979,0.984,0.984,0.994,0.997,0.998,0.985,0.989,0.988,0.996,0.998,1.0,0.988,0.988,0.988,0.996,0.997,0.999],[0.994,0.992,0.998,0.998,0.997,0.997,0.995,0.993,1.0,0.999,0.997,0.996,0.994,0.988,1.0,0.999,0.997,0.996,0.994,0.991],[0.994,0.992,0.996,0.999,0.998,0.997,0.995,0.992,0.998,1.0,0.999,0.996,0.995,0.988,0.999,1.0,0.999,0.997,0.994,0.991],[0.993,0.991,0.994,0.998,0.999,0.996,0.995,0.991,0.996,0.999,1.0,0.996,0.994,0.988,0.997,0.999,1.0,0.997,0.994,0.99],[0.996,0.996,0.99,0.994,0.994,0.998,0.998,0.997,0.994,0.997,0.997,0.999,0.999,0.996,0.996,0.997,0.997,1.0,0.999,0.998],[0.995,0.996,0.987,0.99,0.99,0.996,0.998,0.997,0.991,0.994,0.994,0.998,0.999,0.997,0.994,0.994,0.994,0.999,1.0,0.999],[0.994,0.996,0.982,0.986,0.985,0.994,0.997,0.998,0.987,0.991,0.99,0.997,0.999,0.999,0.991,0.991,0.99,0.998,0.999,1.0]],""K"":1,""R"":0.995,""featValue"":[19.906,0.067,0.014,0.009,0.003,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,-0.108,0.391,0.222,-0.115,0.041,0.578,-0.264,-0.038,0.015,0.245,0.011,-0.306,-0.131,-0.04,0.032,-0.237,0.083,-0.258,-0.115],[0.224,-0.211,0.379,0.154,0.191,-0.04,0.084,0.263,-0.499,0.2,-0.149,-0.283,0.109,-0.056,0.09,-0.048,0.21,-0.238,0.295,0.141],[0.223,0.352,0.286,-0.413,-0.158,0.188,-0.076,0.191,0.0,-0.064,0.116,-0.098,-0.268,0.337,0.084,-0.187,0.354,-0.07,-0.172,-0.236],[0.223,0.286,0.079,0.098,0.171,0.309,-0.392,-0.255,-0.075,0.084,-0.079,-0.185,-0.125,-0.093,0.229,0.023,-0.217,0.163,-0.239,0.497],[0.223,0.273,0.025,0.361,0.018,0.058,-0.317,0.172,-0.062,0.067,0.406,0.098,0.189,0.081,-0.047,0.149,-0.368,-0.214,0.151,-0.397],[0.224,-0.015,0.186,0.1,-0.248,-0.356,-0.106,-0.395,0.18,-0.076,0.246,0.125,0.135,0.275,0.129,-0.169,0.178,0.139,0.415,0.27],[0.224,-0.143,0.155,0.089,-0.128,0.269,-0.052,-0.051,0.191,0.199,-0.265,-0.041,0.486,-0.043,0.018,0.162,0.221,0.472,-0.111,-0.326],[0.224,-0.241,0.251,-0.077,0.075,-0.007,-0.136,-0.011,-0.045,-0.586,-0.319,0.204,0.162,0.271,-0.274,0.079,-0.233,-0.177,-0.194,0.075],[0.223,0.254,0.122,-0.387,0.006,-0.161,0.083,0.268,0.055,-0.044,0.0,0.005,-0.084,-0.287,-0.292,0.369,-0.174,0.347,0.355,0.151],[0.224,0.171,-0.063,0.094,0.281,-0.04,0.003,-0.329,0.314,-0.269,-0.103,-0.187,-0.076,-0.386,-0.025,0.172,0.359,-0.373,0.102,-0.198],[0.224,0.165,-0.187,0.356,-0.002,-0.002,0.128,0.334,0.184,-0.183,-0.065,-0.168,0.04,-0.091,-0.308,-0.617,0.006,0.182,-0.039,0.113],[0.224,-0.095,-0.011,0.013,-0.377,-0.457,-0.322,0.106,-0.094,0.086,-0.269,0.2,-0.226,-0.39,0.229,-0.121,-0.054,-0.042,-0.207,-0.169],[0.224,-0.193,-0.049,-0.01,-0.211,0.409,0.013,0.156,0.286,0.297,0.062,0.435,-0.065,-0.115,-0.166,0.045,0.138,-0.363,0.049,0.333],[0.223,-0.395,-0.044,-0.011,0.53,-0.165,-0.1,0.201,0.393,0.176,0.057,-0.024,-0.326,0.259,0.173,0.017,-0.085,0.157,-0.003,-0.095],[0.224,0.189,-0.066,-0.387,0.19,-0.161,0.326,-0.045,0.113,0.186,-0.02,0.081,0.491,-0.05,0.295,-0.234,-0.269,-0.233,-0.148,0.037],[0.224,0.181,-0.253,-0.013,0.215,-0.041,0.05,-0.351,-0.351,0.327,-0.275,0.313,-0.171,0.22,-0.375,-0.107,0.068,0.082,0.09,-0.165],[0.224,0.17,-0.345,0.256,-0.013,-0.04,0.298,0.241,-0.178,-0.254,-0.024,0.243,-0.003,0.184,0.399,0.373,0.235,0.114,-0.109,0.142],[0.224,-0.098,-0.292,-0.036,-0.298,-0.25,0.002,-0.043,0.026,0.211,0.073,-0.541,0.061,0.248,-0.293,0.289,-0.007,-0.177,-0.27,0.133],[0.224,-0.21,-0.321,-0.154,-0.27,0.367,0.089,-0.111,-0.058,-0.177,-0.176,-0.236,-0.154,0.049,0.257,-0.106,-0.316,-0.021,0.442,-0.177],[0.223,-0.333,-0.243,-0.257,0.147,0.081,-0.154,-0.076,-0.343,-0.196,0.541,0.048,0.131,-0.28,-0.084,-0.12,0.192,0.17,-0.149,-0.014]],""selectVec"":[[0.224],[0.224],[0.223],[0.223],[0.223],[0.224],[0.224],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7990,""AfterCleanSamNum"":5391,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.5%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":476,""version"":""v-2025-12-09 10:54:27"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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