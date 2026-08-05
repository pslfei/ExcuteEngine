using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA419")]
    [FCDisplay("PCA419")]
    public partial class PCA419 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁53号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁54号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁54号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁54号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁54号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁54号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁54号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁55号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁55号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁55号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁55号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁55号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁55号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁56号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁56号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁56号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁56号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁56号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁56号屏6号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁57号屏1号管壁温")]
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

		public PCA419()
		{
			ModelID = 460;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA419";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""460"",""name"":""PCA419"",""description"":""中温分隔屏过热器水冷壁21-21-40"",""founder"":""admin"",""creatTime"":""2025-12-09 10:07:42"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:10:06"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 20:01:56"",""et"":""2025-12-07 04:53:10"",""duration"":2364674,""number"":7883,""filter"":2594,""mode"":5289,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2504}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah21ct121k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""578.56"",""TMin"":""495.27"",""TAvg"":""543.21"",""DMax"":""5.46"",""DMin"":""0.00"",""DAvg"":""1.33"",""C95"":""4.56"",""C99"":""5.59""},{""PointId"":""d1_10hah21ct122k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""567.43"",""TMin"":""483.63"",""TAvg"":""533.20"",""DMax"":""4.06"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.42"",""C99"":""2.96""},{""PointId"":""d1_10hah21ct123k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""567.90"",""TMin"":""481.27"",""TAvg"":""533.70"",""DMax"":""4.14"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.55"",""C99"":""3.11""},{""PointId"":""d1_10hah21ct124k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""567.77"",""TMin"":""480.80"",""TAvg"":""533.71"",""DMax"":""3.30"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.28"",""C99"":""2.79""},{""PointId"":""d1_10hah21ct125k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""572.55"",""TMin"":""487.52"",""TAvg"":""537.80"",""DMax"":""2.42"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.68"",""C99"":""2.06""},{""PointId"":""d1_10hah21ct126k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""574.78"",""TMin"":""489.13"",""TAvg"":""539.91"",""DMax"":""3.43"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.72"",""C99"":""3.32""},{""PointId"":""d1_10hah21ct127k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""575.62"",""TMin"":""491.28"",""TAvg"":""541.34"",""DMax"":""5.29"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.76"",""C99"":""4.60""},{""PointId"":""d1_10hah21ct128k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""567.90"",""TMin"":""481.47"",""TAvg"":""532.50"",""DMax"":""5.85"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.43"",""C99"":""4.20""},{""PointId"":""d1_10hah21ct129k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""566.90"",""TMin"":""479.60"",""TAvg"":""532.98"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.59"",""C99"":""3.17""},{""PointId"":""d1_10hah21ct130k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""567.24"",""TMin"":""481.02"",""TAvg"":""534.37"",""DMax"":""4.53"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.24"",""C99"":""2.76""},{""PointId"":""d1_10hah21ct131k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""572.28"",""TMin"":""485.52"",""TAvg"":""537.57"",""DMax"":""1.85"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.03"",""C99"":""1.26""},{""PointId"":""d1_10hah21ct132k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""573.28"",""TMin"":""487.05"",""TAvg"":""539.18"",""DMax"":""3.10"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.45"",""C99"":""3.00""},{""PointId"":""d1_10hah21ct133k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""573.20"",""TMin"":""488.05"",""TAvg"":""539.48"",""DMax"":""4.24"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.38"",""C99"":""4.14""},{""PointId"":""d1_10hah21ct134k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""567.40"",""TMin"":""480.32"",""TAvg"":""532.62"",""DMax"":""5.65"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.16"",""C99"":""3.87""},{""PointId"":""d1_10hah21ct135k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""566.10"",""TMin"":""477.72"",""TAvg"":""532.36"",""DMax"":""4.14"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.04"",""C99"":""3.72""},{""PointId"":""d1_10hah21ct136k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""563.22"",""TMin"":""475.03"",""TAvg"":""530.10"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.67"",""C99"":""3.27""},{""PointId"":""d1_10hah21ct137k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""571.05"",""TMin"":""483.60"",""TAvg"":""536.82"",""DMax"":""2.83"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.37"",""C99"":""1.69""},{""PointId"":""d1_10hah21ct138k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.25"",""TMin"":""484.88"",""TAvg"":""538.16"",""DMax"":""3.15"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.42"",""C99"":""2.96""},{""PointId"":""d1_10hah21ct139k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""572.57"",""TMin"":""486.88"",""TAvg"":""538.87"",""DMax"":""5.28"",""DMin"":""0.00"",""DAvg"":""1.05"",""C95"":""3.56"",""C99"":""4.35""},{""PointId"":""d1_10hah21ct140k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""562.97"",""TMin"":""475.87"",""TAvg"":""528.60"",""DMax"":""5.39"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.71"",""C99"":""4.54""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:10:06"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[495.269,483.63,481.269,480.804,487.52,489.133,491.283,481.467,479.6,481.02,485.517,487.05,488.05,480.317,477.717,475.033,483.6,484.883,486.883,475.867],""Train_X_max"":[578.558,567.434,567.9,567.77,572.55,574.783,575.617,567.9,566.9,567.24,572.283,573.283,573.2,567.4,566.1,563.217,571.05,572.25,572.567,562.967],""Train_X_std"":[8.905,9.034,9.301,9.374,9.148,9.141,8.946,9.315,9.361,9.252,9.221,9.081,8.941,9.269,9.38,9.37,9.206,9.089,8.917,9.219],""Train_X_mean"":[543.209,533.198,533.696,533.711,537.804,539.907,541.34,532.502,532.978,534.374,537.566,539.18,539.476,532.62,532.356,530.103,536.821,538.156,538.869,528.601],""Train_X_bais_max"":[[5.458,4.057,4.137,3.304,2.418,3.429,5.287,5.848,3.314,4.534,1.845,3.104,4.241,5.653,4.142,3.552,2.832,3.148,5.28,5.391]],""Train_X_bais_min"":[[0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001]],""Train_X_bais_mean"":[[1.327,0.696,0.754,0.661,0.495,0.798,1.093,0.989,0.76,0.619,0.294,0.72,0.997,0.908,0.885,0.77,0.388,0.717,1.047,1.077]],""QCUL_95"":0.8644715,""QCUL_99"":1.54824519,""QCUL_95_line"":[4.564,2.416,2.547,2.278,1.68,2.717,3.758,3.425,2.591,2.244,1.026,2.449,3.383,3.161,3.039,2.671,1.373,2.418,3.557,3.706],""QCUL_99_line"":[5.589,2.961,3.113,2.79,2.055,3.324,4.601,4.195,3.169,2.758,1.257,2.995,4.137,3.873,3.721,3.272,1.685,2.956,4.352,4.537],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.24,0.244,0.251,0.253,0.247,0.246,0.241,0.251,0.252,0.249,0.249,0.245,0.241,0.25,0.253,0.253,0.248,0.245,0.24,0.249],""T2CUL_99_line"":[0.316,0.32,0.33,0.332,0.324,0.324,0.317,0.33,0.332,0.328,0.327,0.322,0.317,0.328,0.332,0.332,0.326,0.322,0.316,0.327],""Kesi_95"":1.558,""Kesi_99"":1.322,""Kesi_95_line"":[0.153,0.155,0.16,0.161,0.157,0.157,0.154,0.16,0.161,0.159,0.158,0.156,0.153,0.159,0.161,0.161,0.158,0.156,0.153,0.158],""Kesi_99_line"":[0.141,0.143,0.147,0.148,0.145,0.145,0.141,0.147,0.148,0.146,0.146,0.144,0.141,0.147,0.148,0.148,0.146,0.144,0.141,0.146],""COV"":[[1.0,0.968,0.964,0.967,0.989,0.994,0.998,0.956,0.961,0.971,0.986,0.993,0.996,0.956,0.955,0.96,0.982,0.991,0.993,0.949],[0.968,1.0,0.998,0.997,0.99,0.983,0.973,0.998,0.997,0.992,0.992,0.983,0.976,0.998,0.996,0.994,0.991,0.983,0.974,0.996],[0.964,0.998,1.0,0.999,0.989,0.982,0.971,0.997,0.999,0.995,0.992,0.982,0.974,0.997,0.998,0.997,0.991,0.982,0.972,0.996],[0.967,0.997,0.999,1.0,0.992,0.985,0.974,0.994,0.998,0.996,0.994,0.985,0.977,0.995,0.997,0.998,0.994,0.986,0.976,0.994],[0.989,0.99,0.989,0.992,1.0,0.998,0.994,0.984,0.988,0.991,0.999,0.998,0.994,0.985,0.985,0.988,0.998,0.997,0.992,0.98],[0.994,0.983,0.982,0.985,0.998,1.0,0.997,0.976,0.98,0.985,0.996,0.999,0.996,0.977,0.976,0.98,0.993,0.997,0.993,0.972],[0.998,0.973,0.971,0.974,0.994,0.997,1.0,0.963,0.969,0.978,0.991,0.998,0.999,0.965,0.965,0.969,0.989,0.996,0.997,0.958],[0.956,0.998,0.997,0.994,0.984,0.976,0.963,1.0,0.997,0.987,0.987,0.976,0.967,0.999,0.997,0.993,0.986,0.975,0.964,0.999],[0.961,0.997,0.999,0.998,0.988,0.98,0.969,0.997,1.0,0.996,0.992,0.982,0.974,0.998,0.999,0.999,0.992,0.983,0.973,0.997],[0.971,0.992,0.995,0.996,0.991,0.985,0.978,0.987,0.996,1.0,0.995,0.988,0.982,0.989,0.994,0.997,0.995,0.99,0.984,0.988],[0.986,0.992,0.992,0.994,0.999,0.996,0.991,0.987,0.992,0.995,1.0,0.997,0.993,0.988,0.99,0.992,0.999,0.997,0.992,0.985],[0.993,0.983,0.982,0.985,0.998,0.999,0.998,0.976,0.982,0.988,0.997,1.0,0.999,0.977,0.978,0.982,0.995,0.999,0.996,0.973],[0.996,0.976,0.974,0.977,0.994,0.996,0.999,0.967,0.974,0.982,0.993,0.999,1.0,0.969,0.97,0.974,0.991,0.998,0.998,0.963],[0.956,0.998,0.997,0.995,0.985,0.977,0.965,0.999,0.998,0.989,0.988,0.977,0.969,1.0,0.998,0.995,0.989,0.978,0.967,0.999],[0.955,0.996,0.998,0.997,0.985,0.976,0.965,0.997,0.999,0.994,0.99,0.978,0.97,0.998,1.0,0.999,0.991,0.98,0.97,0.998],[0.96,0.994,0.997,0.998,0.988,0.98,0.969,0.993,0.999,0.997,0.992,0.982,0.974,0.995,0.999,1.0,0.994,0.984,0.975,0.995],[0.982,0.991,0.991,0.994,0.998,0.993,0.989,0.986,0.992,0.995,0.999,0.995,0.991,0.989,0.991,0.994,1.0,0.997,0.992,0.985],[0.991,0.983,0.982,0.986,0.997,0.997,0.996,0.975,0.983,0.99,0.997,0.999,0.998,0.978,0.98,0.984,0.997,1.0,0.998,0.973],[0.993,0.974,0.972,0.976,0.992,0.993,0.997,0.964,0.973,0.984,0.992,0.996,0.998,0.967,0.97,0.975,0.992,0.998,1.0,0.962],[0.949,0.996,0.996,0.994,0.98,0.972,0.958,0.999,0.997,0.988,0.985,0.973,0.963,0.999,0.998,0.995,0.985,0.973,0.962,1.0]],""K"":1,""R"":0.987,""featValue"":[19.744,0.209,0.023,0.01,0.008,0.003,0.001,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.221,0.38,-0.334,0.208,-0.354,-0.174,-0.032,-0.16,-0.229,-0.429,-0.147,0.103,0.392,0.11,0.005,-0.111,-0.097,-0.012,-0.049,0.103],[0.224,-0.17,-0.265,0.029,-0.354,-0.354,-0.042,0.334,0.321,0.415,0.089,-0.05,-0.006,0.275,0.246,-0.138,-0.009,0.155,-0.133,0.06],[0.224,-0.193,-0.076,0.321,-0.182,0.036,-0.257,-0.234,0.445,-0.173,0.175,0.24,-0.125,-0.194,-0.013,0.305,0.138,-0.309,0.075,-0.256],[0.224,-0.154,0.073,0.451,0.119,-0.173,-0.302,0.137,-0.124,-0.11,-0.26,-0.546,-0.203,-0.152,-0.179,-0.026,-0.034,0.205,0.16,0.068],[0.225,0.105,-0.112,0.137,0.361,-0.299,0.278,-0.084,-0.163,0.06,-0.125,0.093,-0.4,-0.009,0.296,0.077,-0.015,-0.436,-0.23,0.227],[0.224,0.2,-0.226,0.229,0.338,0.313,-0.2,0.129,-0.096,0.3,0.101,0.223,0.109,-0.241,0.05,-0.475,0.032,0.033,-0.039,-0.277],[0.222,0.326,-0.139,-0.026,-0.091,0.104,-0.076,-0.244,-0.295,0.355,0.23,0.024,-0.282,0.191,-0.102,0.44,-0.028,0.296,0.253,-0.009],[0.223,-0.26,-0.367,-0.171,0.056,0.06,0.333,-0.024,-0.152,-0.018,0.252,-0.369,0.295,-0.26,0.019,0.117,0.442,-0.057,0.094,0.041],[0.224,-0.211,0.075,0.046,-0.064,0.18,0.298,-0.313,0.092,-0.04,0.227,-0.13,-0.001,-0.205,0.173,-0.126,-0.683,0.186,-0.068,0.052],[0.224,-0.077,0.439,0.274,-0.377,0.196,0.399,0.299,-0.266,0.131,-0.196,0.194,0.049,-0.048,0.094,0.057,0.119,-0.09,0.175,-0.115],[0.225,0.054,0.048,0.086,0.223,-0.167,0.331,0.262,0.163,-0.194,0.206,0.248,-0.017,0.031,-0.571,0.107,0.017,0.301,-0.289,-0.015],[0.224,0.202,-0.007,-0.008,0.165,0.371,0.033,0.158,0.432,0.007,-0.104,-0.049,0.13,0.185,-0.072,0.02,-0.055,-0.182,0.366,0.541],[0.223,0.288,0.018,-0.205,-0.151,0.297,0.153,-0.081,0.219,-0.164,-0.198,-0.383,-0.327,0.196,0.006,-0.17,0.183,-0.016,-0.275,-0.374],[0.223,-0.25,-0.207,-0.327,0.027,-0.059,-0.021,-0.057,-0.052,0.247,-0.51,0.081,0.135,-0.001,-0.398,0.099,-0.309,-0.236,0.05,-0.243],[0.224,-0.246,0.153,-0.123,-0.043,-0.023,-0.054,-0.479,0.021,0.05,-0.227,0.289,-0.106,-0.023,-0.054,-0.33,0.386,0.311,-0.015,0.329],[0.224,-0.191,0.336,0.094,0.121,0.112,-0.26,-0.138,-0.203,0.089,0.257,-0.153,0.311,0.488,-0.077,0.034,0.021,-0.255,-0.361,0.031],[0.225,0.037,0.223,-0.163,0.292,-0.39,0.076,-0.067,0.068,-0.182,0.119,0.028,0.104,0.256,0.202,-0.164,-0.003,0.04,0.538,-0.37],[0.224,0.186,0.217,-0.18,0.171,-0.031,-0.186,0.068,0.139,0.018,-0.257,0.013,0.316,-0.281,0.39,0.44,0.026,0.291,-0.266,-0.024],[0.223,0.28,0.299,-0.363,-0.262,-0.24,-0.212,0.108,-0.055,0.066,0.289,-0.081,-0.087,-0.422,-0.203,-0.187,-0.042,-0.286,0.004,0.161],[0.223,-0.301,-0.154,-0.316,-0.006,0.245,-0.261,0.382,-0.272,-0.434,0.079,0.223,-0.283,0.102,0.187,0.031,-0.09,0.062,0.009,0.072]],""selectVec"":[[0.221],[0.224],[0.224],[0.224],[0.225],[0.224],[0.222],[0.223],[0.224],[0.224],[0.225],[0.224],[0.223],[0.223],[0.224],[0.224],[0.225],[0.224],[0.223],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7883,""AfterCleanSamNum"":5289,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.7%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":460,""version"":""v-2025-12-09 10:10:06"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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