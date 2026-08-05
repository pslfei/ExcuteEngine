using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA410")]
    [FCDisplay("PCA410")]
    public partial class PCA410 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁37号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁37号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁37号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁37号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁38号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁38号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁38号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁38号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁38号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁38号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁39号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁39号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁39号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁39号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁39号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁39号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁40号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁40号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁40号屏3号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁40号屏4号管壁温")]
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

		public PCA410()
		{
			ModelID = 451;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA410";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""451"",""name"":""PCA410"",""description"":""中温分隔屏过热器水冷壁19-21-40"",""founder"":""admin"",""creatTime"":""2025-12-04 17:17:44"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:24:37"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 19:31:20"",""et"":""2025-12-03 22:02:02"",""duration"":2514642,""number"":8383,""filter"":2648,""mode"":5735,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2558}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah19ct121k"",""Description"":""中温（分隔屏）过热器水冷壁37号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""575.52"",""TMin"":""490.30"",""TAvg"":""536.52"",""DMax"":""4.29"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.75"",""C99"":""3.37""},{""PointId"":""d1_10hah19ct122k"",""Description"":""中温（分隔屏）过热器水冷壁37号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""580.93"",""TMin"":""499.12"",""TAvg"":""542.73"",""DMax"":""2.84"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.65"",""C99"":""2.02""},{""PointId"":""d1_10hah19ct123k"",""Description"":""中温（分隔屏）过热器水冷壁37号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""582.85"",""TMin"":""502.05"",""TAvg"":""544.66"",""DMax"":""3.86"",""DMin"":""0.00"",""DAvg"":""0.83"",""C95"":""2.85"",""C99"":""3.49""},{""PointId"":""d1_10hah19ct124k"",""Description"":""中温（分隔屏）过热器水冷壁37号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""583.75"",""TMin"":""502.66"",""TAvg"":""545.43"",""DMax"":""4.63"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.57"",""C99"":""4.38""},{""PointId"":""d1_10hah19ct125k"",""Description"":""中温（分隔屏）过热器水冷壁38号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""573.82"",""TMin"":""492.22"",""TAvg"":""535.45"",""DMax"":""4.19"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.58"",""C99"":""3.16""},{""PointId"":""d1_10hah19ct126k"",""Description"":""中温（分隔屏）过热器水冷壁38号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""574.24"",""TMin"":""491.58"",""TAvg"":""536.44"",""DMax"":""3.52"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.30"",""C99"":""2.82""},{""PointId"":""d1_10hah19ct127k"",""Description"":""中温（分隔屏）过热器水冷壁38号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""572.93"",""TMin"":""487.92"",""TAvg"":""534.10"",""DMax"":""3.76"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.82"",""C99"":""3.45""},{""PointId"":""d1_10hah19ct128k"",""Description"":""中温（分隔屏）过热器水冷壁38号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""577.80"",""TMin"":""495.38"",""TAvg"":""539.79"",""DMax"":""2.22"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.52"",""C99"":""1.86""},{""PointId"":""d1_10hah19ct129k"",""Description"":""中温（分隔屏）过热器水冷壁38号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""580.80"",""TMin"":""499.82"",""TAvg"":""543.01"",""DMax"":""3.22"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.66"",""C99"":""3.26""},{""PointId"":""d1_10hah19ct130k"",""Description"":""中温（分隔屏）过热器水冷壁38号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""581.68"",""TMin"":""500.90"",""TAvg"":""543.73"",""DMax"":""4.03"",""DMin"":""0.00"",""DAvg"":""0.96"",""C95"":""3.30"",""C99"":""4.04""},{""PointId"":""d1_10hah19ct131k"",""Description"":""中温（分隔屏）过热器水冷壁39号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""572.20"",""TMin"":""490.76"",""TAvg"":""533.83"",""DMax"":""5.24"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.03"",""C99"":""3.71""},{""PointId"":""d1_10hah19ct132k"",""Description"":""中温（分隔屏）过热器水冷壁39号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""574.02"",""TMin"":""490.66"",""TAvg"":""536.20"",""DMax"":""3.48"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.29"",""C99"":""2.80""},{""PointId"":""d1_10hah19ct133k"",""Description"":""中温（分隔屏）过热器水冷壁39号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""574.78"",""TMin"":""494.46"",""TAvg"":""537.56"",""DMax"":""3.37"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.54"",""C99"":""1.89""},{""PointId"":""d1_10hah19ct134k"",""Description"":""中温（分隔屏）过热器水冷壁39号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""581.33"",""TMin"":""498.98"",""TAvg"":""542.63"",""DMax"":""2.10"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.53"",""C99"":""1.87""},{""PointId"":""d1_10hah19ct135k"",""Description"":""中温（分隔屏）过热器水冷壁39号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""581.93"",""TMin"":""501.12"",""TAvg"":""543.48"",""DMax"":""3.96"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.40"",""C99"":""2.94""},{""PointId"":""d1_10hah19ct136k"",""Description"":""中温（分隔屏）过热器水冷壁39号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""583.12"",""TMin"":""502.54"",""TAvg"":""545.02"",""DMax"":""5.18"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.44"",""C99"":""4.21""},{""PointId"":""d1_10hah19ct137k"",""Description"":""中温（分隔屏）过热器水冷壁40号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""576.73"",""TMin"":""493.53"",""TAvg"":""536.82"",""DMax"":""4.86"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.04"",""C99"":""3.72""},{""PointId"":""d1_10hah19ct138k"",""Description"":""中温（分隔屏）过热器水冷壁40号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""575.97"",""TMin"":""492.50"",""TAvg"":""536.89"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.01"",""C99"":""3.68""},{""PointId"":""d1_10hah19ct139k"",""Description"":""中温（分隔屏）过热器水冷壁40号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""574.35"",""TMin"":""488.96"",""TAvg"":""535.25"",""DMax"":""4.07"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.48"",""C99"":""4.26""},{""PointId"":""d1_10hah19ct140k"",""Description"":""中温（分隔屏）过热器水冷壁40号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""584.12"",""TMin"":""501.03"",""TAvg"":""544.13"",""DMax"":""2.81"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.84"",""C99"":""2.25""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:24:37"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[490.3,499.12,502.05,502.66,492.217,491.58,487.92,495.383,499.817,500.9,490.76,490.66,494.46,498.983,501.12,502.54,493.533,492.5,488.96,501.033],""Train_X_max"":[575.517,580.933,582.85,583.75,573.817,574.24,572.933,577.8,580.8,581.683,572.2,574.017,574.783,581.333,581.933,583.117,576.733,575.967,574.35,584.117],""Train_X_std"":[10.509,10.493,10.518,10.454,10.311,10.372,10.458,10.461,10.444,10.438,10.269,10.351,10.237,10.481,10.466,10.396,10.47,10.482,10.564,10.527],""Train_X_mean"":[536.517,542.727,544.661,545.434,535.446,536.438,534.104,539.792,543.007,543.734,533.825,536.202,537.56,542.629,543.476,545.022,536.823,536.89,535.25,544.133],""Train_X_bais_max"":[[4.293,2.841,3.861,4.629,4.188,3.519,3.759,2.221,3.22,4.03,5.235,3.48,3.373,2.104,3.955,5.181,4.862,3.065,4.069,2.807]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.797,0.479,0.832,1.037,0.756,0.665,0.818,0.442,0.778,0.956,0.887,0.657,0.41,0.439,0.697,0.988,0.881,0.883,1.019,0.526]],""QCUL_95"":0.5620154,""QCUL_99"":1.00997841,""QCUL_95_line"":[2.75,1.652,2.852,3.573,2.583,2.301,2.821,1.518,2.66,3.295,3.033,2.285,1.535,1.527,2.402,3.437,3.041,3.009,3.483,1.835],""QCUL_99_line"":[3.368,2.023,3.49,4.375,3.161,2.818,3.454,1.858,3.255,4.036,3.712,2.8,1.891,1.872,2.942,4.212,3.724,3.681,4.262,2.249],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.27,0.27,0.27,0.269,0.265,0.266,0.269,0.269,0.268,0.268,0.264,0.266,0.263,0.269,0.269,0.267,0.269,0.269,0.271,0.27],""T2CUL_99_line"":[0.355,0.354,0.355,0.353,0.348,0.35,0.353,0.353,0.353,0.352,0.347,0.349,0.346,0.354,0.353,0.351,0.354,0.354,0.357,0.355],""Kesi_95"":1.556,""Kesi_99"":1.314,""Kesi_95_line"":[0.172,0.172,0.172,0.171,0.169,0.17,0.171,0.171,0.171,0.171,0.168,0.169,0.167,0.171,0.171,0.17,0.171,0.171,0.173,0.172],""Kesi_99_line"":[0.158,0.158,0.158,0.157,0.155,0.156,0.157,0.157,0.157,0.157,0.154,0.155,0.154,0.157,0.157,0.156,0.157,0.157,0.159,0.158],""COV"":[[1.0,0.992,0.985,0.979,0.996,0.999,1.0,0.992,0.985,0.981,0.995,0.997,0.995,0.991,0.986,0.979,0.994,0.996,0.998,0.989],[0.992,1.0,0.998,0.996,0.991,0.992,0.991,1.0,0.998,0.996,0.988,0.992,0.997,0.999,0.998,0.995,0.989,0.989,0.987,0.998],[0.985,0.998,1.0,0.999,0.984,0.985,0.983,0.997,1.0,0.999,0.98,0.985,0.994,0.997,0.999,0.998,0.982,0.981,0.979,0.997],[0.979,0.996,0.999,1.0,0.98,0.981,0.977,0.995,0.999,0.999,0.976,0.981,0.992,0.995,0.998,0.999,0.977,0.976,0.972,0.995],[0.996,0.991,0.984,0.98,1.0,0.999,0.997,0.992,0.985,0.982,1.0,0.997,0.994,0.992,0.986,0.981,0.999,0.997,0.995,0.991],[0.999,0.992,0.985,0.981,0.999,1.0,0.999,0.993,0.986,0.983,0.998,0.999,0.996,0.992,0.987,0.981,0.997,0.998,0.997,0.991],[1.0,0.991,0.983,0.977,0.997,0.999,1.0,0.991,0.984,0.979,0.997,0.998,0.994,0.99,0.985,0.977,0.995,0.997,0.999,0.989],[0.992,1.0,0.997,0.995,0.992,0.993,0.991,1.0,0.998,0.996,0.99,0.993,0.997,0.999,0.998,0.995,0.99,0.989,0.987,0.998],[0.985,0.998,1.0,0.999,0.985,0.986,0.984,0.998,1.0,0.999,0.982,0.986,0.995,0.998,0.999,0.999,0.982,0.982,0.979,0.997],[0.981,0.996,0.999,0.999,0.982,0.983,0.979,0.996,0.999,1.0,0.978,0.983,0.992,0.996,0.998,0.999,0.979,0.977,0.974,0.996],[0.995,0.988,0.98,0.976,1.0,0.998,0.997,0.99,0.982,0.978,1.0,0.997,0.991,0.99,0.983,0.977,0.999,0.998,0.996,0.988],[0.997,0.992,0.985,0.981,0.997,0.999,0.998,0.993,0.986,0.983,0.997,1.0,0.996,0.993,0.988,0.983,0.996,0.999,0.997,0.992],[0.995,0.997,0.994,0.992,0.994,0.996,0.994,0.997,0.995,0.992,0.991,0.996,1.0,0.997,0.995,0.992,0.99,0.993,0.991,0.996],[0.991,0.999,0.997,0.995,0.992,0.992,0.99,0.999,0.998,0.996,0.99,0.993,0.997,1.0,0.998,0.995,0.991,0.99,0.988,1.0],[0.986,0.998,0.999,0.998,0.986,0.987,0.985,0.998,0.999,0.998,0.983,0.988,0.995,0.998,1.0,0.999,0.985,0.985,0.982,0.998],[0.979,0.995,0.998,0.999,0.981,0.981,0.977,0.995,0.999,0.999,0.977,0.983,0.992,0.995,0.999,1.0,0.978,0.977,0.973,0.996],[0.994,0.989,0.982,0.977,0.999,0.997,0.995,0.99,0.982,0.979,0.999,0.996,0.99,0.991,0.985,0.978,1.0,0.998,0.996,0.99],[0.996,0.989,0.981,0.976,0.997,0.998,0.997,0.989,0.982,0.977,0.998,0.999,0.993,0.99,0.985,0.977,0.998,1.0,0.998,0.99],[0.998,0.987,0.979,0.972,0.995,0.997,0.999,0.987,0.979,0.974,0.996,0.997,0.991,0.988,0.982,0.973,0.996,0.998,1.0,0.987],[0.989,0.998,0.997,0.995,0.991,0.991,0.989,0.998,0.997,0.996,0.988,0.992,0.996,1.0,0.998,0.996,0.99,0.99,0.987,1.0]],""K"":1,""R"":0.991,""featValue"":[19.833,0.134,0.014,0.007,0.006,0.003,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.202,-0.475,-0.184,-0.069,-0.1,-0.043,-0.112,0.104,0.279,0.117,0.069,0.325,-0.312,-0.064,-0.257,-0.362,-0.301,-0.064,0.124],[-0.224,-0.111,-0.096,-0.088,-0.354,0.148,0.431,0.037,-0.069,-0.131,-0.243,0.255,0.297,0.02,-0.196,0.103,0.361,-0.255,0.072,-0.32],[-0.223,-0.252,-0.114,-0.085,-0.227,-0.282,0.222,0.117,0.409,-0.205,0.065,-0.157,-0.128,-0.249,0.005,0.236,0.132,0.223,-0.256,0.41],[-0.223,-0.327,-0.012,-0.134,0.042,-0.284,0.391,0.046,-0.512,0.251,0.207,-0.249,-0.128,-0.016,0.043,-0.104,-0.172,0.194,0.182,-0.17],[-0.224,0.206,0.284,-0.384,0.017,0.006,0.027,-0.406,-0.026,-0.033,-0.25,-0.356,0.126,0.298,-0.221,0.309,-0.227,-0.037,-0.052,0.137],[-0.224,0.202,-0.076,-0.247,0.171,0.12,-0.022,0.224,0.236,0.24,-0.396,-0.241,-0.053,-0.138,0.519,0.005,0.183,0.131,0.134,-0.245],[-0.223,0.236,-0.328,-0.046,-0.185,-0.068,-0.3,0.019,-0.214,0.034,0.336,-0.115,0.077,0.451,0.071,-0.003,0.422,0.172,-0.245,-0.019],[-0.224,-0.102,-0.014,-0.148,-0.267,0.426,-0.124,0.166,-0.008,0.05,-0.086,0.233,-0.069,0.166,-0.115,-0.213,-0.154,0.367,0.401,0.385],[-0.224,-0.245,-0.069,-0.083,-0.038,0.002,-0.229,0.015,0.386,-0.175,0.095,0.036,-0.212,0.181,-0.19,-0.078,-0.341,0.089,-0.13,-0.611],[-0.223,-0.303,0.086,-0.185,0.105,-0.106,-0.269,0.21,-0.164,0.117,-0.202,0.141,-0.37,0.125,0.017,-0.048,0.108,-0.577,-0.173,0.217],[-0.223,0.261,0.351,-0.229,0.03,-0.061,-0.124,-0.016,-0.166,-0.453,0.103,-0.031,-0.05,-0.415,-0.118,-0.457,0.197,0.053,-0.015,-0.058],[-0.224,0.187,-0.063,0.11,0.413,0.217,0.066,0.429,0.073,-0.021,0.323,-0.189,-0.022,-0.052,-0.403,0.303,0.052,-0.167,0.241,0.027],[-0.224,-0.009,-0.281,-0.033,0.465,0.193,0.249,-0.478,-0.015,-0.256,0.102,0.342,-0.242,0.066,0.237,0.038,0.051,0.034,0.006,0.089],[-0.224,-0.1,0.096,0.207,-0.152,0.47,-0.092,0.111,-0.319,-0.158,0.076,-0.094,0.141,-0.226,0.332,0.25,-0.306,-0.038,-0.377,-0.024],[-0.224,-0.21,0.016,0.284,0.013,-0.262,-0.181,-0.046,0.098,-0.365,0.016,-0.184,0.352,0.182,0.314,-0.067,-0.046,-0.218,0.477,0.084],[-0.223,-0.31,0.132,0.093,0.377,-0.116,-0.294,-0.091,-0.039,0.248,-0.146,0.243,0.434,-0.171,-0.202,0.111,0.176,0.34,-0.13,-0.016],[-0.223,0.234,0.491,-0.024,-0.172,-0.176,0.071,-0.003,0.187,0.276,0.395,0.435,-0.02,0.039,0.255,0.219,-0.045,-0.064,0.097,-0.048],[-0.223,0.257,0.103,0.365,0.164,-0.146,0.352,0.289,0.043,-0.035,-0.264,0.087,0.077,0.33,-0.026,-0.346,-0.192,0.093,-0.337,0.098],[-0.223,0.297,-0.19,0.395,-0.207,-0.271,-0.192,-0.121,-0.22,-0.014,-0.326,0.103,-0.365,-0.216,-0.149,0.28,-0.082,0.09,0.191,-0.077],[-0.224,-0.114,0.16,0.416,-0.127,0.282,0.059,-0.389,0.213,0.354,0.078,-0.328,-0.171,-0.063,-0.109,-0.284,0.246,-0.128,-0.023,0.016]],""selectVec"":[[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.223],[-0.223],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8383,""AfterCleanSamNum"":5825,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.1%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":451,""version"":""v-2025-12-04 17:24:37"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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