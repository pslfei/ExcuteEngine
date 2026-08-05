using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA434")]
    [FCDisplay("PCA434")]
    public partial class PCA434 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁103号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁103号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁103号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁103号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁104号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁104号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁104号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁104号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁104号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁104号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁105号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁105号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁105号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁105号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁105号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁105号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁106号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁106号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁106号屏3号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁106号屏4号管壁温")]
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

		public PCA434()
		{
			ModelID = 475;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA434";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""475"",""name"":""PCA434"",""description"":""中温分隔屏过热器水冷壁24-21-40"",""founder"":""admin"",""creatTime"":""2025-12-09 10:49:55"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:51:42"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 12:19:30"",""duration"":2407522,""number"":8026,""filter"":2617,""mode"":5409,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2527}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah24ct121k"",""Description"":""中温（分隔屏）过热器水冷壁103号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""576.17"",""TMin"":""482.42"",""TAvg"":""530.30"",""DMax"":""2.40"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.66"",""C99"":""2.04""},{""PointId"":""d1_10hah24ct122k"",""Description"":""中温（分隔屏）过热器水冷壁103号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""579.13"",""TMin"":""484.45"",""TAvg"":""533.93"",""DMax"":""1.87"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.67"",""C99"":""2.05""},{""PointId"":""d1_10hah24ct123k"",""Description"":""中温（分隔屏）过热器水冷壁103号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""581.03"",""TMin"":""485.85"",""TAvg"":""535.24"",""DMax"":""2.73"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.12"",""C99"":""2.59""},{""PointId"":""d1_10hah24ct124k"",""Description"":""中温（分隔屏）过热器水冷壁103号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""581.17"",""TMin"":""486.76"",""TAvg"":""536.26"",""DMax"":""4.41"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.00"",""C99"":""3.68""},{""PointId"":""d1_10hah24ct125k"",""Description"":""中温（分隔屏）过热器水冷壁104号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""571.64"",""TMin"":""482.43"",""TAvg"":""528.41"",""DMax"":""5.18"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.32"",""C99"":""2.85""},{""PointId"":""d1_10hah24ct126k"",""Description"":""中温（分隔屏）过热器水冷壁104号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""572.89"",""TMin"":""481.22"",""TAvg"":""528.24"",""DMax"":""2.89"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.75"",""C99"":""2.14""},{""PointId"":""d1_10hah24ct127k"",""Description"":""中温（分隔屏）过热器水冷壁104号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""573.56"",""TMin"":""480.80"",""TAvg"":""527.98"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.93"",""C99"":""2.36""},{""PointId"":""d1_10hah24ct128k"",""Description"":""中温（分隔屏）过热器水冷壁104号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""577.80"",""TMin"":""483.21"",""TAvg"":""532.53"",""DMax"":""1.91"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.48"",""C99"":""1.81""},{""PointId"":""d1_10hah24ct129k"",""Description"":""中温（分隔屏）过热器水冷壁104号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""577.80"",""TMin"":""483.40"",""TAvg"":""532.18"",""DMax"":""3.35"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.87"",""C99"":""2.29""},{""PointId"":""d1_10hah24ct130k"",""Description"":""中温（分隔屏）过热器水冷壁104号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""577.88"",""TMin"":""484.73"",""TAvg"":""533.24"",""DMax"":""3.80"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.32"",""C99"":""2.85""},{""PointId"":""d1_10hah24ct131k"",""Description"":""中温（分隔屏）过热器水冷壁105号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""570.87"",""TMin"":""481.28"",""TAvg"":""527.54"",""DMax"":""5.73"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.39"",""C99"":""2.94""},{""PointId"":""d1_10hah24ct132k"",""Description"":""中温（分隔屏）过热器水冷壁105号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""572.78"",""TMin"":""481.52"",""TAvg"":""528.33"",""DMax"":""2.43"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.72"",""C99"":""2.10""},{""PointId"":""d1_10hah24ct133k"",""Description"":""中温（分隔屏）过热器水冷壁105号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""571.80"",""TMin"":""479.62"",""TAvg"":""526.70"",""DMax"":""3.07"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.87"",""C99"":""2.29""},{""PointId"":""d1_10hah24ct134k"",""Description"":""中温（分隔屏）过热器水冷壁105号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""576.39"",""TMin"":""482.39"",""TAvg"":""531.08"",""DMax"":""1.52"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.06"",""C99"":""1.30""},{""PointId"":""d1_10hah24ct135k"",""Description"":""中温（分隔屏）过热器水冷壁105号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""576.93"",""TMin"":""483.30"",""TAvg"":""531.39"",""DMax"":""1.93"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.45"",""C99"":""1.77""},{""PointId"":""d1_10hah24ct136k"",""Description"":""中温（分隔屏）过热器水冷壁105号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""578.28"",""TMin"":""484.34"",""TAvg"":""532.71"",""DMax"":""3.90"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.24"",""C99"":""2.75""},{""PointId"":""d1_10hah24ct137k"",""Description"":""中温（分隔屏）过热器水冷壁106号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""570.08"",""TMin"":""480.34"",""TAvg"":""526.88"",""DMax"":""4.83"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.56"",""C99"":""3.14""},{""PointId"":""d1_10hah24ct138k"",""Description"":""中温（分隔屏）过热器水冷壁106号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.84"",""TMin"":""480.88"",""TAvg"":""527.50"",""DMax"":""2.24"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.02"",""C99"":""2.47""},{""PointId"":""d1_10hah24ct139k"",""Description"":""中温（分隔屏）过热器水冷壁106号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""574.62"",""TMin"":""481.14"",""TAvg"":""528.45"",""DMax"":""2.39"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.81"",""C99"":""2.21""},{""PointId"":""d1_10hah24ct140k"",""Description"":""中温（分隔屏）过热器水冷壁106号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""577.22"",""TMin"":""482.64"",""TAvg"":""531.73"",""DMax"":""2.90"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.94"",""C99"":""2.37""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:51:42"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[482.423,484.445,485.851,486.755,482.432,481.224,480.803,483.21,483.397,484.726,481.281,481.52,479.623,482.394,483.297,484.343,480.339,480.879,481.142,482.642],""Train_X_max"":[576.17,579.133,581.032,581.169,571.638,572.885,573.564,577.795,577.8,577.876,570.871,572.784,571.799,576.394,576.926,578.28,570.082,572.838,574.617,577.217],""Train_X_std"":[10.997,10.929,10.915,10.839,10.897,10.98,10.957,10.877,10.835,10.795,11.022,10.962,10.963,10.943,10.965,10.882,11.102,11.207,11.248,11.136],""Train_X_mean"":[530.296,533.934,535.239,536.26,528.408,528.238,527.976,532.533,532.176,533.244,527.543,528.332,526.704,531.079,531.385,532.711,526.88,527.498,528.445,531.733],""Train_X_bais_max"":[[2.403,1.865,2.734,4.414,5.18,2.885,3.009,1.913,3.349,3.798,5.734,2.431,3.07,1.519,1.932,3.901,4.827,2.235,2.388,2.896]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.48,0.495,0.62,0.883,0.664,0.507,0.55,0.437,0.54,0.669,0.674,0.503,0.534,0.307,0.417,0.641,0.735,0.599,0.534,0.561]],""QCUL_95"":0.2630202,""QCUL_99"":0.460066378,""QCUL_95_line"":[1.663,1.673,2.116,3.004,2.323,1.748,1.927,1.48,1.866,2.324,2.392,1.719,1.87,1.059,1.447,2.239,2.56,2.018,1.808,1.938],""QCUL_99_line"":[2.037,2.045,2.589,3.675,2.848,2.141,2.363,1.809,2.286,2.848,2.936,2.104,2.293,1.297,1.773,2.745,3.137,2.467,2.212,2.373],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.293,0.291,0.291,0.289,0.29,0.293,0.292,0.29,0.289,0.288,0.294,0.292,0.292,0.292,0.292,0.29,0.296,0.299,0.3,0.297],""T2CUL_99_line"":[0.385,0.383,0.382,0.38,0.382,0.385,0.384,0.381,0.38,0.378,0.386,0.384,0.384,0.383,0.384,0.381,0.389,0.393,0.394,0.39],""Kesi_95"":1.552,""Kesi_99"":1.298,""Kesi_95_line"":[0.186,0.185,0.185,0.184,0.185,0.186,0.186,0.184,0.184,0.183,0.187,0.186,0.186,0.185,0.186,0.184,0.188,0.19,0.191,0.189],""Kesi_99_line"":[0.17,0.169,0.169,0.168,0.169,0.17,0.17,0.169,0.168,0.167,0.171,0.17,0.17,0.17,0.17,0.169,0.172,0.174,0.174,0.173],""COV"":[[1.0,0.997,0.995,0.991,0.998,0.999,1.0,0.997,0.995,0.993,0.996,0.999,0.999,0.997,0.996,0.993,0.995,0.997,0.998,0.994],[0.997,1.0,0.999,0.997,0.994,0.996,0.995,1.0,0.999,0.998,0.993,0.995,0.995,0.999,0.998,0.997,0.993,0.994,0.995,0.997],[0.995,0.999,1.0,0.999,0.991,0.993,0.993,0.999,1.0,0.999,0.991,0.993,0.992,0.998,0.998,0.999,0.99,0.992,0.993,0.998],[0.991,0.997,0.999,1.0,0.988,0.989,0.989,0.997,0.998,0.999,0.987,0.989,0.988,0.995,0.996,0.998,0.987,0.988,0.989,0.996],[0.998,0.994,0.991,0.988,1.0,0.999,0.997,0.994,0.991,0.99,1.0,0.998,0.997,0.995,0.993,0.99,0.998,0.997,0.996,0.992],[0.999,0.996,0.993,0.989,0.999,1.0,0.999,0.996,0.994,0.992,0.998,1.0,0.999,0.997,0.995,0.992,0.997,0.998,0.998,0.994],[1.0,0.995,0.993,0.989,0.997,0.999,1.0,0.996,0.994,0.992,0.996,0.999,1.0,0.997,0.995,0.992,0.995,0.997,0.998,0.993],[0.997,1.0,0.999,0.997,0.994,0.996,0.996,1.0,0.999,0.998,0.993,0.996,0.996,0.999,0.998,0.997,0.992,0.994,0.996,0.998],[0.995,0.999,1.0,0.998,0.991,0.994,0.994,0.999,1.0,0.999,0.991,0.994,0.994,0.999,0.999,0.999,0.99,0.993,0.994,0.998],[0.993,0.998,0.999,0.999,0.99,0.992,0.992,0.998,0.999,1.0,0.99,0.992,0.992,0.997,0.998,0.999,0.989,0.991,0.992,0.997],[0.996,0.993,0.991,0.987,1.0,0.998,0.996,0.993,0.991,0.99,1.0,0.998,0.997,0.995,0.994,0.99,1.0,0.998,0.997,0.993],[0.999,0.995,0.993,0.989,0.998,1.0,0.999,0.996,0.994,0.992,0.998,1.0,1.0,0.997,0.996,0.992,0.998,0.999,0.999,0.995],[0.999,0.995,0.992,0.988,0.997,0.999,1.0,0.996,0.994,0.992,0.997,1.0,1.0,0.997,0.996,0.992,0.996,0.998,0.999,0.994],[0.997,0.999,0.998,0.995,0.995,0.997,0.997,0.999,0.999,0.997,0.995,0.997,0.997,1.0,0.999,0.998,0.994,0.997,0.998,0.999],[0.996,0.998,0.998,0.996,0.993,0.995,0.995,0.998,0.999,0.998,0.994,0.996,0.996,0.999,1.0,0.999,0.994,0.996,0.997,0.999],[0.993,0.997,0.999,0.998,0.99,0.992,0.992,0.997,0.999,0.999,0.99,0.992,0.992,0.998,0.999,1.0,0.991,0.993,0.994,0.999],[0.995,0.993,0.99,0.987,0.998,0.997,0.995,0.992,0.99,0.989,1.0,0.998,0.996,0.994,0.994,0.991,1.0,0.999,0.997,0.994],[0.997,0.994,0.992,0.988,0.997,0.998,0.997,0.994,0.993,0.991,0.998,0.999,0.998,0.997,0.996,0.993,0.999,1.0,1.0,0.996],[0.998,0.995,0.993,0.989,0.996,0.998,0.998,0.996,0.994,0.992,0.997,0.999,0.999,0.998,0.997,0.994,0.997,1.0,1.0,0.997],[0.994,0.997,0.998,0.996,0.992,0.994,0.993,0.998,0.998,0.997,0.993,0.995,0.994,0.999,0.999,0.999,0.994,0.996,0.997,1.0]],""K"":1,""R"":0.996,""featValue"":[19.916,0.057,0.012,0.01,0.003,0.002,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,-0.137,-0.355,-0.032,0.017,-0.319,0.14,0.269,0.112,-0.332,-0.145,0.07,0.216,0.261,-0.157,0.216,-0.471,0.142,0.11,0.148],[-0.224,0.146,-0.174,-0.252,-0.466,-0.07,0.157,-0.096,-0.148,-0.413,-0.351,-0.038,-0.157,-0.034,0.051,0.066,0.438,-0.171,0.01,-0.087],[-0.224,0.27,-0.055,-0.175,-0.05,-0.216,0.395,0.052,0.369,0.356,0.07,-0.215,-0.125,-0.048,-0.098,-0.248,-0.197,-0.363,-0.24,-0.071],[-0.223,0.384,0.032,-0.302,0.184,-0.417,-0.279,-0.029,-0.023,0.305,-0.164,0.017,0.131,-0.02,0.278,0.03,0.143,0.416,0.116,0.026],[-0.223,-0.257,0.029,-0.447,0.075,0.189,-0.23,0.227,0.222,-0.119,0.102,0.033,0.209,-0.401,-0.253,-0.286,0.084,-0.054,0.302,-0.105],[-0.224,-0.216,-0.175,-0.109,0.06,-0.038,0.038,-0.426,-0.244,0.158,0.011,0.305,0.171,-0.373,-0.21,0.193,-0.053,0.003,-0.469,0.151],[-0.224,-0.187,-0.376,0.121,0.143,0.095,0.112,0.174,-0.216,0.379,-0.033,0.048,-0.483,-0.163,0.086,0.215,0.016,-0.06,0.41,-0.091],[-0.224,0.134,-0.239,-0.049,-0.351,0.248,-0.216,-0.082,-0.107,-0.087,0.323,0.098,-0.264,0.09,0.152,-0.366,-0.34,0.348,-0.142,-0.099],[-0.224,0.244,-0.121,0.064,0.071,0.161,0.227,0.102,0.078,-0.118,0.641,-0.176,0.189,-0.006,-0.005,0.351,0.347,0.146,-0.012,0.127],[-0.223,0.308,0.05,-0.06,0.399,0.091,-0.051,0.029,-0.512,-0.143,0.077,0.178,0.125,0.27,-0.016,-0.202,-0.081,-0.465,0.073,0.007],[-0.223,-0.273,0.257,-0.311,0.071,0.276,0.141,0.119,0.092,0.196,-0.111,0.187,-0.17,0.573,-0.127,0.062,0.212,0.188,-0.211,0.034],[-0.224,-0.221,-0.05,0.074,0.111,-0.152,-0.222,-0.584,0.145,-0.038,0.125,-0.319,0.005,0.3,-0.125,0.086,0.018,-0.09,0.173,-0.42],[-0.224,-0.199,-0.254,0.253,0.103,0.085,-0.234,0.092,-0.022,0.045,-0.209,-0.482,0.073,0.06,0.075,-0.317,0.206,-0.03,-0.213,0.467],[-0.224,0.078,-0.038,0.168,-0.245,0.31,-0.275,0.022,0.351,0.175,-0.138,0.271,0.311,0.06,0.37,0.273,-0.077,-0.342,0.006,-0.027],[-0.224,0.126,0.132,0.225,0.137,0.361,0.492,-0.264,0.034,-0.043,-0.339,-0.049,0.234,-0.137,0.049,-0.199,-0.112,0.317,0.218,-0.091],[-0.223,0.274,0.203,0.183,0.321,0.076,-0.265,0.046,0.274,-0.327,-0.169,0.031,-0.472,-0.213,-0.204,0.214,-0.08,0.036,-0.21,0.017],[-0.223,-0.259,0.468,-0.199,-0.068,-0.016,0.059,0.085,-0.249,-0.101,0.073,-0.394,-0.038,-0.161,0.423,0.239,-0.319,-0.063,-0.075,0.024],[-0.224,-0.212,0.245,0.213,-0.035,-0.351,0.132,-0.184,0.192,-0.136,0.229,0.391,-0.175,-0.012,0.223,-0.259,0.138,-0.073,0.224,0.375],[-0.224,-0.156,0.086,0.4,-0.015,-0.256,0.023,0.392,-0.126,-0.011,0.014,0.127,0.158,-0.068,0.033,-0.145,0.192,0.091,-0.302,-0.563],[-0.224,0.152,0.336,0.231,-0.461,-0.056,-0.146,0.058,-0.223,0.255,-0.004,-0.085,0.06,0.022,-0.546,0.077,-0.063,0.025,0.232,0.181]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8026,""AfterCleanSamNum"":5409,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.6%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":475,""version"":""v-2025-12-09 10:51:42"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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