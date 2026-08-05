using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA424")]
    [FCDisplay("PCA424")]
    public partial class PCA424 : WarnFunction
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

		public PCA424()
		{
			ModelID = 465;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA424";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""465"",""name"":""PCA424"",""description"":""中温分隔屏过热器水冷壁22-21-40"",""founder"":""admin"",""creatTime"":""2025-12-09 10:22:06"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:24:38"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 20:46:34"",""et"":""2025-12-07 11:34:52"",""duration"":2386098,""number"":7954,""filter"":2608,""mode"":5346,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2518}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah21ct121k"",""Description"":""中温（分隔屏）过热器水冷壁53号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""578.56"",""TMin"":""495.27"",""TAvg"":""543.21"",""DMax"":""5.43"",""DMin"":""0.00"",""DAvg"":""1.34"",""C95"":""4.59"",""C99"":""5.62""},{""PointId"":""d1_10hah21ct122k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""567.43"",""TMin"":""483.63"",""TAvg"":""533.18"",""DMax"":""4.06"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.42"",""C99"":""2.97""},{""PointId"":""d1_10hah21ct123k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""567.90"",""TMin"":""481.27"",""TAvg"":""533.67"",""DMax"":""4.13"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.55"",""C99"":""3.12""},{""PointId"":""d1_10hah21ct124k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""567.77"",""TMin"":""480.80"",""TAvg"":""533.69"",""DMax"":""3.30"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.27"",""C99"":""2.78""},{""PointId"":""d1_10hah21ct125k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""572.55"",""TMin"":""487.52"",""TAvg"":""537.79"",""DMax"":""2.41"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.68"",""C99"":""2.06""},{""PointId"":""d1_10hah21ct126k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""574.78"",""TMin"":""489.13"",""TAvg"":""539.89"",""DMax"":""3.42"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.72"",""C99"":""3.32""},{""PointId"":""d1_10hah21ct127k"",""Description"":""中温（分隔屏）过热器水冷壁54号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""575.62"",""TMin"":""491.28"",""TAvg"":""541.33"",""DMax"":""5.28"",""DMin"":""0.00"",""DAvg"":""1.10"",""C95"":""3.77"",""C99"":""4.61""},{""PointId"":""d1_10hah21ct128k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""567.90"",""TMin"":""481.47"",""TAvg"":""532.48"",""DMax"":""5.84"",""DMin"":""0.00"",""DAvg"":""0.99"",""C95"":""3.43"",""C99"":""4.20""},{""PointId"":""d1_10hah21ct129k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""566.90"",""TMin"":""479.60"",""TAvg"":""532.95"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.59"",""C99"":""3.17""},{""PointId"":""d1_10hah21ct130k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""567.24"",""TMin"":""481.02"",""TAvg"":""534.36"",""DMax"":""4.54"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.23"",""C99"":""2.74""},{""PointId"":""d1_10hah21ct131k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""572.28"",""TMin"":""485.52"",""TAvg"":""537.55"",""DMax"":""1.84"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.03"",""C99"":""1.26""},{""PointId"":""d1_10hah21ct132k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""573.28"",""TMin"":""487.05"",""TAvg"":""539.16"",""DMax"":""3.10"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.45"",""C99"":""3.00""},{""PointId"":""d1_10hah21ct133k"",""Description"":""中温（分隔屏）过热器水冷壁55号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""573.20"",""TMin"":""488.05"",""TAvg"":""539.47"",""DMax"":""4.23"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.39"",""C99"":""4.15""},{""PointId"":""d1_10hah21ct134k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""567.40"",""TMin"":""480.32"",""TAvg"":""532.59"",""DMax"":""5.64"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.17"",""C99"":""3.89""},{""PointId"":""d1_10hah21ct135k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""566.10"",""TMin"":""477.72"",""TAvg"":""532.33"",""DMax"":""4.13"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.05"",""C99"":""3.73""},{""PointId"":""d1_10hah21ct136k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""563.22"",""TMin"":""475.03"",""TAvg"":""530.07"",""DMax"":""3.54"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.68"",""C99"":""3.28""},{""PointId"":""d1_10hah21ct137k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""571.05"",""TMin"":""483.60"",""TAvg"":""536.80"",""DMax"":""2.83"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.37"",""C99"":""1.68""},{""PointId"":""d1_10hah21ct138k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.25"",""TMin"":""484.88"",""TAvg"":""538.14"",""DMax"":""3.15"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.42"",""C99"":""2.96""},{""PointId"":""d1_10hah21ct139k"",""Description"":""中温（分隔屏）过热器水冷壁56号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""572.57"",""TMin"":""486.88"",""TAvg"":""538.86"",""DMax"":""5.27"",""DMin"":""0.00"",""DAvg"":""1.05"",""C95"":""3.56"",""C99"":""4.35""},{""PointId"":""d1_10hah21ct140k"",""Description"":""中温（分隔屏）过热器水冷壁57号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""562.97"",""TMin"":""475.87"",""TAvg"":""528.57"",""DMax"":""5.38"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.73"",""C99"":""4.56""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:24:38"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[495.269,483.63,481.269,480.804,487.52,489.133,491.283,481.467,479.6,481.02,485.517,487.05,488.05,480.317,477.717,475.033,483.6,484.883,486.883,475.867],""Train_X_max"":[578.558,567.434,567.9,567.77,572.55,574.783,575.617,567.9,566.9,567.24,572.283,573.283,573.2,567.4,566.1,563.217,571.05,572.25,572.567,562.967],""Train_X_std"":[8.869,8.997,9.264,9.335,9.11,9.103,8.91,9.278,9.323,9.213,9.183,9.044,8.905,9.233,9.343,9.332,9.168,9.052,8.88,9.184],""Train_X_mean"":[543.213,533.177,533.669,533.689,537.791,539.893,541.333,532.478,532.95,534.356,537.55,539.164,539.466,532.591,532.327,530.073,536.801,538.138,538.856,528.567],""Train_X_bais_max"":[[5.431,4.055,4.129,3.301,2.412,3.424,5.276,5.844,3.306,4.536,1.841,3.101,4.232,5.644,4.133,3.542,2.831,3.147,5.274,5.376]],""Train_X_bais_min"":[[0.0,0.001,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.338,0.699,0.757,0.66,0.496,0.799,1.097,0.991,0.762,0.615,0.295,0.721,1.0,0.914,0.888,0.772,0.387,0.717,1.047,1.085]],""QCUL_95"":0.8748039,""QCUL_99"":1.56676877,""QCUL_95_line"":[4.592,2.422,2.553,2.272,1.683,2.716,3.765,3.429,2.594,2.232,1.027,2.45,3.39,3.173,3.045,2.675,1.369,2.418,3.557,3.728],""QCUL_99_line"":[5.621,2.967,3.121,2.782,2.059,3.322,4.609,4.201,3.173,2.744,1.258,2.997,4.146,3.888,3.727,3.277,1.679,2.955,4.351,4.564],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.238,0.241,0.248,0.25,0.244,0.244,0.239,0.249,0.25,0.247,0.246,0.243,0.239,0.248,0.251,0.25,0.246,0.243,0.238,0.246],""T2CUL_99_line"":[0.313,0.317,0.327,0.329,0.321,0.321,0.314,0.327,0.329,0.325,0.324,0.319,0.314,0.325,0.329,0.329,0.323,0.319,0.313,0.324],""Kesi_95"":1.558,""Kesi_99"":1.323,""Kesi_95_line"":[0.151,0.154,0.158,0.159,0.156,0.155,0.152,0.158,0.159,0.157,0.157,0.154,0.152,0.158,0.16,0.159,0.157,0.155,0.152,0.157],""Kesi_99_line"":[0.14,0.142,0.146,0.147,0.143,0.143,0.14,0.146,0.147,0.145,0.144,0.142,0.14,0.145,0.147,0.147,0.144,0.142,0.14,0.144],""COV"":[[1.0,0.967,0.964,0.967,0.989,0.994,0.998,0.955,0.96,0.971,0.985,0.993,0.996,0.956,0.955,0.959,0.981,0.99,0.992,0.948],[0.967,1.0,0.998,0.997,0.989,0.983,0.973,0.998,0.997,0.992,0.992,0.983,0.975,0.998,0.996,0.994,0.991,0.982,0.974,0.996],[0.964,0.998,1.0,0.999,0.989,0.982,0.971,0.997,0.999,0.995,0.992,0.982,0.974,0.997,0.998,0.997,0.991,0.982,0.972,0.996],[0.967,0.997,0.999,1.0,0.992,0.985,0.974,0.994,0.998,0.996,0.994,0.985,0.976,0.995,0.997,0.998,0.994,0.985,0.976,0.994],[0.989,0.989,0.989,0.992,1.0,0.998,0.994,0.984,0.988,0.99,0.999,0.998,0.994,0.985,0.985,0.988,0.998,0.997,0.992,0.98],[0.994,0.983,0.982,0.985,0.998,1.0,0.997,0.976,0.98,0.985,0.996,0.999,0.996,0.976,0.976,0.98,0.993,0.997,0.993,0.971],[0.998,0.973,0.971,0.974,0.994,0.997,1.0,0.963,0.969,0.978,0.991,0.997,0.999,0.964,0.964,0.969,0.988,0.996,0.997,0.958],[0.955,0.998,0.997,0.994,0.984,0.976,0.963,1.0,0.997,0.987,0.987,0.976,0.966,0.999,0.997,0.993,0.986,0.975,0.963,0.999],[0.96,0.997,0.999,0.998,0.988,0.98,0.969,0.997,1.0,0.996,0.992,0.982,0.973,0.998,0.999,0.999,0.992,0.982,0.973,0.997],[0.971,0.992,0.995,0.996,0.99,0.985,0.978,0.987,0.996,1.0,0.995,0.988,0.982,0.989,0.994,0.997,0.995,0.99,0.984,0.988],[0.985,0.992,0.992,0.994,0.999,0.996,0.991,0.987,0.992,0.995,1.0,0.997,0.993,0.988,0.989,0.992,0.999,0.997,0.992,0.985],[0.993,0.983,0.982,0.985,0.998,0.999,0.997,0.976,0.982,0.988,0.997,1.0,0.999,0.977,0.978,0.982,0.995,0.999,0.996,0.972],[0.996,0.975,0.974,0.976,0.994,0.996,0.999,0.966,0.973,0.982,0.993,0.999,1.0,0.968,0.969,0.974,0.991,0.998,0.998,0.962],[0.956,0.998,0.997,0.995,0.985,0.976,0.964,0.999,0.998,0.989,0.988,0.977,0.968,1.0,0.998,0.995,0.989,0.978,0.967,0.999],[0.955,0.996,0.998,0.997,0.985,0.976,0.964,0.997,0.999,0.994,0.989,0.978,0.969,0.998,1.0,0.999,0.991,0.98,0.97,0.998],[0.959,0.994,0.997,0.998,0.988,0.98,0.969,0.993,0.999,0.997,0.992,0.982,0.974,0.995,0.999,1.0,0.993,0.984,0.975,0.995],[0.981,0.991,0.991,0.994,0.998,0.993,0.988,0.986,0.992,0.995,0.999,0.995,0.991,0.989,0.991,0.993,1.0,0.997,0.992,0.985],[0.99,0.982,0.982,0.985,0.997,0.997,0.996,0.975,0.982,0.99,0.997,0.999,0.998,0.978,0.98,0.984,0.997,1.0,0.998,0.973],[0.992,0.974,0.972,0.976,0.992,0.993,0.997,0.963,0.973,0.984,0.992,0.996,0.998,0.967,0.97,0.975,0.992,0.998,1.0,0.961],[0.948,0.996,0.996,0.994,0.98,0.971,0.958,0.999,0.997,0.988,0.985,0.972,0.962,0.999,0.998,0.995,0.985,0.973,0.961,1.0]],""K"":1,""R"":0.987,""featValue"":[19.741,0.211,0.023,0.01,0.008,0.004,0.001,0.001,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.221,0.381,-0.337,0.213,-0.354,-0.173,-0.02,-0.164,-0.25,-0.428,-0.122,0.111,0.383,0.104,0.011,-0.082,-0.121,-0.014,-0.049,-0.099],[0.224,-0.171,-0.267,0.033,-0.354,-0.347,-0.066,0.336,0.333,0.407,0.054,-0.068,0.007,0.276,0.238,-0.15,-0.02,0.154,-0.137,-0.057],[0.224,-0.193,-0.077,0.319,-0.174,0.049,-0.281,-0.234,0.454,-0.172,0.178,0.228,-0.11,-0.191,-0.01,0.282,0.179,-0.303,0.083,0.247],[0.224,-0.153,0.071,0.451,0.123,-0.17,-0.291,0.13,-0.156,-0.126,-0.278,-0.525,-0.226,-0.153,-0.177,-0.024,-0.034,0.204,0.157,-0.065],[0.225,0.105,-0.113,0.135,0.36,-0.304,0.274,-0.08,-0.141,0.069,-0.096,0.12,-0.41,-0.007,0.3,0.092,-0.015,-0.428,-0.228,-0.234],[0.224,0.199,-0.225,0.221,0.345,0.315,-0.198,0.127,-0.091,0.306,0.096,0.208,0.119,-0.238,0.036,-0.475,-0.065,0.012,-0.041,0.281],[0.222,0.326,-0.139,-0.027,-0.089,0.107,-0.074,-0.244,-0.269,0.375,0.235,0.018,-0.277,0.194,-0.099,0.42,0.08,0.318,0.252,0.005],[0.223,-0.26,-0.366,-0.17,0.053,0.053,0.342,-0.022,-0.145,-0.009,0.237,-0.385,0.283,-0.268,0.02,0.031,0.445,-0.085,0.103,-0.037],[0.224,-0.211,0.075,0.047,-0.063,0.178,0.297,-0.307,0.111,-0.035,0.23,-0.132,-0.01,-0.203,0.176,-0.001,-0.677,0.234,-0.084,-0.057],[0.224,-0.076,0.437,0.282,-0.376,0.193,0.402,0.303,-0.254,0.137,-0.172,0.212,0.04,-0.053,0.1,0.039,0.117,-0.097,0.179,0.115],[0.225,0.054,0.048,0.086,0.221,-0.171,0.318,0.268,0.177,-0.188,0.218,0.235,0.0,0.039,-0.578,0.098,0.061,0.29,-0.288,0.022],[0.224,0.201,-0.006,-0.013,0.169,0.371,0.028,0.16,0.418,-0.012,-0.132,-0.059,0.139,0.184,-0.068,0.034,-0.064,-0.166,0.363,-0.546],[0.223,0.288,0.019,-0.205,-0.152,0.295,0.158,-0.079,0.206,-0.18,-0.213,-0.366,-0.335,0.199,0.003,-0.195,0.143,-0.046,-0.27,0.38],[0.223,-0.25,-0.205,-0.327,0.022,-0.063,-0.01,-0.058,-0.067,0.23,-0.513,0.103,0.124,-0.006,-0.381,0.189,-0.309,-0.217,0.053,0.239],[0.224,-0.246,0.153,-0.12,-0.046,-0.025,-0.044,-0.481,0.015,0.045,-0.219,0.296,-0.094,-0.016,-0.076,-0.422,0.333,0.271,-0.017,-0.318],[0.224,-0.191,0.336,0.093,0.122,0.111,-0.249,-0.142,-0.21,0.1,0.239,-0.179,0.32,0.483,-0.07,0.05,0.014,-0.262,-0.356,-0.03],[0.225,0.037,0.223,-0.163,0.286,-0.394,0.071,-0.066,0.071,-0.178,0.125,0.022,0.107,0.253,0.205,-0.161,-0.044,0.037,0.539,0.368],[0.224,0.186,0.218,-0.182,0.169,-0.032,-0.184,0.065,0.118,0.001,-0.268,0.018,0.307,-0.288,0.394,0.4,0.141,0.309,-0.269,0.024],[0.223,0.279,0.299,-0.359,-0.267,-0.237,-0.22,0.107,-0.046,0.076,0.283,-0.094,-0.086,-0.418,-0.208,-0.162,-0.097,-0.287,0.004,-0.164],[0.223,-0.302,-0.152,-0.318,-0.006,0.246,-0.258,0.377,-0.282,-0.42,0.119,0.234,-0.279,0.109,0.183,0.036,-0.068,0.074,0.006,-0.075]],""selectVec"":[[0.221],[0.224],[0.224],[0.224],[0.225],[0.224],[0.222],[0.223],[0.224],[0.224],[0.225],[0.224],[0.223],[0.223],[0.224],[0.224],[0.225],[0.224],[0.223],[0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7954,""AfterCleanSamNum"":5346,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.7%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":465,""version"":""v-2025-12-09 10:24:38"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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