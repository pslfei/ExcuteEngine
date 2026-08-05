using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA437")]
    [FCDisplay("PCA437")]
    public partial class PCA437 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁113号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁113号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁113号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁113号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁114号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁114号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁114号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁114号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁114号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁114号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁115号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁115号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁115号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁115号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁115号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁115号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁116号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁116号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁116号屏3号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[19] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[19] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[19] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA437()
		{
			ModelID = 478;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA437";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""478"",""name"":""PCA437"",""description"":""中温分隔屏过热器水冷壁24-81-99"",""founder"":""admin"",""creatTime"":""2025-12-09 10:58:05"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:59:42"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 15:34:08"",""et"":""2025-12-07 10:50:14"",""duration"":2402166,""number"":8008,""filter"":2599,""mode"":5409,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2509}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah24ct181k"",""Description"":""中温（分隔屏）过热器水冷壁113号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""575.23"",""TMin"":""482.86"",""TAvg"":""529.55"",""DMax"":""2.67"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.20"",""C99"":""2.69""},{""PointId"":""d1_10hah24ct182k"",""Description"":""中温（分隔屏）过热器水冷壁113号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""580.32"",""TMin"":""486.58"",""TAvg"":""534.87"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.79"",""C99"":""2.19""},{""PointId"":""d1_10hah24ct183k"",""Description"":""中温（分隔屏）过热器水冷壁113号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""581.53"",""TMin"":""487.80"",""TAvg"":""535.75"",""DMax"":""4.26"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.32"",""C99"":""2.84""},{""PointId"":""d1_10hah24ct184k"",""Description"":""中温（分隔屏）过热器水冷壁113号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""582.53"",""TMin"":""488.91"",""TAvg"":""537.44"",""DMax"":""6.26"",""DMin"":""0.00"",""DAvg"":""1.00"",""C95"":""3.48"",""C99"":""4.27""},{""PointId"":""d1_10hah24ct185k"",""Description"":""中温（分隔屏）过热器水冷壁114号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""573.24"",""TMin"":""484.74"",""TAvg"":""530.63"",""DMax"":""5.96"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.64"",""C99"":""3.24""},{""PointId"":""d1_10hah24ct186k"",""Description"":""中温（分隔屏）过热器水冷壁114号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""572.97"",""TMin"":""483.41"",""TAvg"":""529.04"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.17"",""C99"":""2.66""},{""PointId"":""d1_10hah24ct187k"",""Description"":""中温（分隔屏）过热器水冷壁114号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""576.26"",""TMin"":""484.45"",""TAvg"":""531.25"",""DMax"":""2.92"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.07"",""C99"":""2.54""},{""PointId"":""d1_10hah24ct188k"",""Description"":""中温（分隔屏）过热器水冷壁114号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""579.45"",""TMin"":""486.80"",""TAvg"":""534.81"",""DMax"":""2.43"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.56"",""C99"":""1.91""},{""PointId"":""d1_10hah24ct189k"",""Description"":""中温（分隔屏）过热器水冷壁114号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""580.94"",""TMin"":""487.99"",""TAvg"":""536.08"",""DMax"":""4.14"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.31"",""C99"":""2.83""},{""PointId"":""d1_10hah24ct190k"",""Description"":""中温（分隔屏）过热器水冷壁114号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""580.34"",""TMin"":""488.30"",""TAvg"":""536.23"",""DMax"":""7.73"",""DMin"":""0.00"",""DAvg"":""1.07"",""C95"":""3.74"",""C99"":""4.58""},{""PointId"":""d1_10hah24ct191k"",""Description"":""中温（分隔屏）过热器水冷壁115号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""572.09"",""TMin"":""485.17"",""TAvg"":""529.84"",""DMax"":""4.85"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.45"",""C99"":""3.01""},{""PointId"":""d1_10hah24ct192k"",""Description"":""中温（分隔屏）过热器水冷壁115号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""574.07"",""TMin"":""485.26"",""TAvg"":""530.71"",""DMax"":""3.38"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.96"",""C99"":""2.40""},{""PointId"":""d1_10hah24ct193k"",""Description"":""中温（分隔屏）过热器水冷壁115号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""572.50"",""TMin"":""483.00"",""TAvg"":""528.47"",""DMax"":""4.15"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.71"",""C99"":""3.32""},{""PointId"":""d1_10hah24ct194k"",""Description"":""中温（分隔屏）过热器水冷壁115号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""579.59"",""TMin"":""487.90"",""TAvg"":""535.65"",""DMax"":""1.62"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.19"",""C99"":""1.46""},{""PointId"":""d1_10hah24ct195k"",""Description"":""中温（分隔屏）过热器水冷壁115号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""580.32"",""TMin"":""488.40"",""TAvg"":""536.10"",""DMax"":""3.77"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.18"",""C99"":""2.67""},{""PointId"":""d1_10hah24ct196k"",""Description"":""中温（分隔屏）过热器水冷壁115号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""578.91"",""TMin"":""487.90"",""TAvg"":""535.14"",""DMax"":""4.16"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.60"",""C99"":""3.18""},{""PointId"":""d1_10hah24ct197k"",""Description"":""中温（分隔屏）过热器水冷壁116号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""573.93"",""TMin"":""486.90"",""TAvg"":""531.66"",""DMax"":""6.26"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.54"",""C99"":""3.12""},{""PointId"":""d1_10hah24ct198k"",""Description"":""中温（分隔屏）过热器水冷壁116号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""574.99"",""TMin"":""486.64"",""TAvg"":""531.75"",""DMax"":""3.45"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.93"",""C99"":""2.36""},{""PointId"":""d1_10hah24ct199k"",""Description"":""中温（分隔屏）过热器水冷壁116号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""574.64"",""TMin"":""484.48"",""TAvg"":""530.43"",""DMax"":""3.56"",""DMin"":""0.00"",""DAvg"":""0.62"",""C95"":""2.17"",""C99"":""2.66""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:59:42"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[482.859,486.576,487.8,488.906,484.738,483.413,484.447,486.8,487.993,488.3,485.168,485.261,483.0,487.903,488.396,487.897,486.897,486.637,484.478],""Train_X_max"":[575.231,580.322,581.528,582.527,573.242,572.965,576.258,579.452,580.943,580.342,572.085,574.072,572.504,579.594,580.324,578.909,573.929,574.986,574.635],""Train_X_std"":[11.412,11.507,11.573,11.526,11.182,11.261,11.354,11.47,11.422,11.238,11.028,11.161,11.269,11.369,11.356,11.341,11.061,11.117,11.282],""Train_X_mean"":[529.549,534.87,535.75,537.44,530.628,529.041,531.249,534.806,536.078,536.231,529.842,530.705,528.47,535.653,536.099,535.138,531.659,531.752,530.433],""Train_X_bais_max"":[[2.665,3.362,4.262,6.256,5.962,3.545,2.919,2.434,4.142,7.729,4.852,3.378,4.151,1.619,3.768,4.157,6.256,3.448,3.563]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.643,0.506,0.657,0.995,0.748,0.629,0.602,0.443,0.663,1.07,0.699,0.561,0.78,0.34,0.624,0.751,0.723,0.553,0.62]],""QCUL_95"":0.364744246,""QCUL_99"":0.651065946,""QCUL_95_line"":[2.201,1.787,2.317,3.481,2.643,2.173,2.071,1.555,2.306,3.739,2.454,1.956,2.706,1.192,2.181,2.599,2.541,1.928,2.166],""QCUL_99_line"":[2.694,2.192,2.842,4.267,3.242,2.662,2.535,1.907,2.826,4.584,3.009,2.398,3.315,1.462,2.673,3.183,3.116,2.363,2.655],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.304,0.307,0.309,0.307,0.298,0.3,0.303,0.306,0.304,0.3,0.294,0.298,0.3,0.303,0.303,0.302,0.295,0.296,0.301],""T2CUL_99_line"":[0.4,0.403,0.406,0.404,0.392,0.395,0.398,0.402,0.4,0.394,0.386,0.391,0.395,0.398,0.398,0.397,0.388,0.39,0.395],""Kesi_95"":1.556,""Kesi_99"":1.314,""Kesi_95_line"":[0.194,0.195,0.196,0.195,0.19,0.191,0.193,0.195,0.194,0.191,0.187,0.189,0.191,0.193,0.193,0.192,0.188,0.189,0.191],""Kesi_99_line"":[0.178,0.179,0.18,0.18,0.174,0.176,0.177,0.179,0.178,0.175,0.172,0.174,0.176,0.177,0.177,0.177,0.172,0.173,0.176],""COV"":[[1.0,0.995,0.992,0.986,0.997,0.999,1.0,0.995,0.992,0.985,0.996,0.999,0.999,0.995,0.991,0.989,0.995,0.997,0.999],[0.995,1.0,1.0,0.997,0.992,0.993,0.995,1.0,0.999,0.996,0.992,0.993,0.991,0.999,0.999,0.998,0.991,0.994,0.993],[0.992,1.0,1.0,0.999,0.989,0.991,0.992,0.999,1.0,0.997,0.989,0.991,0.989,0.998,0.999,0.999,0.989,0.992,0.991],[0.986,0.997,0.999,1.0,0.984,0.984,0.986,0.996,0.999,0.999,0.984,0.986,0.981,0.996,0.998,0.999,0.985,0.987,0.985],[0.997,0.992,0.989,0.984,1.0,0.998,0.997,0.993,0.989,0.981,0.999,0.998,0.997,0.994,0.989,0.988,0.999,0.997,0.997],[0.999,0.993,0.991,0.984,0.998,1.0,0.999,0.994,0.99,0.983,0.999,1.0,1.0,0.995,0.991,0.989,0.998,0.998,0.999],[1.0,0.995,0.992,0.986,0.997,0.999,1.0,0.996,0.992,0.985,0.996,0.999,0.999,0.996,0.992,0.99,0.995,0.997,0.999],[0.995,1.0,0.999,0.996,0.993,0.994,0.996,1.0,0.999,0.995,0.993,0.995,0.993,1.0,0.999,0.998,0.992,0.994,0.994],[0.992,0.999,1.0,0.999,0.989,0.99,0.992,0.999,1.0,0.998,0.989,0.991,0.988,0.999,1.0,0.999,0.989,0.992,0.991],[0.985,0.996,0.997,0.999,0.981,0.983,0.985,0.995,0.998,1.0,0.982,0.984,0.98,0.995,0.998,0.998,0.982,0.986,0.984],[0.996,0.992,0.989,0.984,0.999,0.999,0.996,0.993,0.989,0.982,1.0,0.999,0.997,0.994,0.99,0.989,1.0,0.999,0.997],[0.999,0.993,0.991,0.986,0.998,1.0,0.999,0.995,0.991,0.984,0.999,1.0,0.999,0.996,0.992,0.99,0.998,0.999,0.999],[0.999,0.991,0.989,0.981,0.997,1.0,0.999,0.993,0.988,0.98,0.997,0.999,1.0,0.994,0.989,0.987,0.996,0.997,1.0],[0.995,0.999,0.998,0.996,0.994,0.995,0.996,1.0,0.999,0.995,0.994,0.996,0.994,1.0,0.999,0.998,0.994,0.996,0.996],[0.991,0.999,0.999,0.998,0.989,0.991,0.992,0.999,1.0,0.998,0.99,0.992,0.989,0.999,1.0,1.0,0.991,0.994,0.992],[0.989,0.998,0.999,0.999,0.988,0.989,0.99,0.998,0.999,0.998,0.989,0.99,0.987,0.998,1.0,1.0,0.99,0.992,0.99],[0.995,0.991,0.989,0.985,0.999,0.998,0.995,0.992,0.989,0.982,1.0,0.998,0.996,0.994,0.991,0.99,1.0,0.999,0.997],[0.997,0.994,0.992,0.987,0.997,0.998,0.997,0.994,0.992,0.986,0.999,0.999,0.997,0.996,0.994,0.992,0.999,1.0,0.999],[0.999,0.993,0.991,0.985,0.997,0.999,0.999,0.994,0.991,0.984,0.997,0.999,1.0,0.996,0.992,0.99,0.997,0.999,1.0]],""K"":1,""R"":0.994,""featValue"":[18.891,0.086,0.013,0.006,0.003,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.23,-0.177,0.374,-0.084,-0.254,-0.215,-0.04,0.013,-0.196,0.093,-0.134,0.237,-0.061,0.2,-0.015,-0.081,-0.266,-0.373,0.524],[0.23,0.158,0.18,-0.242,-0.034,-0.251,0.338,0.151,-0.237,0.282,-0.426,-0.211,-0.025,0.055,-0.067,0.077,0.175,-0.102,-0.463],[0.229,0.227,0.111,-0.214,0.069,-0.467,-0.128,0.047,0.053,0.16,0.366,-0.035,-0.321,-0.194,-0.046,-0.069,-0.185,0.494,0.077],[0.229,0.366,-0.089,-0.133,-0.191,-0.15,-0.333,0.114,-0.235,-0.588,0.05,0.081,0.094,0.069,0.306,0.12,0.241,-0.106,-0.065],[0.229,-0.232,-0.241,-0.564,-0.006,0.265,-0.3,0.105,0.088,0.288,0.141,0.245,0.155,0.212,0.011,-0.244,0.024,-0.022,-0.214],[0.23,-0.23,0.096,-0.041,-0.137,-0.093,-0.047,0.055,0.441,-0.104,-0.276,-0.065,0.226,0.113,-0.217,0.225,0.427,0.38,0.279],[0.23,-0.169,0.36,-0.006,-0.127,0.183,0.164,-0.214,-0.003,-0.093,0.147,0.403,0.194,-0.336,0.083,0.403,-0.203,0.122,-0.314],[0.23,0.12,0.132,-0.269,0.367,0.25,0.118,0.189,-0.021,-0.3,0.07,-0.27,0.23,-0.337,-0.391,-0.131,-0.118,-0.195,0.198],[0.229,0.24,0.047,0.014,0.119,-0.154,0.273,-0.409,0.449,0.031,0.197,-0.16,0.302,0.285,0.314,-0.152,-0.078,-0.201,-0.01],[0.228,0.39,-0.018,0.192,-0.615,0.457,0.088,0.01,-0.044,0.183,0.163,-0.165,-0.046,0.068,-0.208,-0.092,0.001,0.108,0.064],[0.229,-0.226,-0.368,-0.142,-0.173,-0.02,0.286,-0.401,-0.06,-0.155,-0.161,0.03,-0.296,-0.408,0.118,-0.305,0.195,-0.017,0.118],[0.23,-0.206,-0.019,0.14,-0.112,0.057,-0.17,0.401,0.407,0.068,-0.003,-0.315,-0.283,-0.262,0.335,0.167,-0.127,-0.311,-0.09],[0.229,-0.271,0.261,0.169,0.101,0.103,-0.256,-0.285,-0.059,-0.326,-0.038,-0.251,-0.326,0.342,-0.209,-0.201,-0.107,0.085,-0.332],[0.23,0.091,0.009,0.014,0.361,0.388,0.249,0.196,-0.126,-0.021,-0.218,0.108,-0.211,0.248,0.439,0.051,-0.088,0.347,0.23],[0.23,0.223,-0.073,0.209,0.285,0.012,0.032,0.001,0.196,0.076,0.114,0.472,-0.373,0.06,-0.331,0.145,0.332,-0.319,-0.03],[0.229,0.259,-0.199,0.217,0.15,0.0,-0.463,-0.266,-0.003,0.222,-0.508,0.049,0.206,-0.227,-0.044,0.021,-0.28,0.042,0.015],[0.229,-0.205,-0.503,-0.004,0.048,-0.11,0.113,-0.099,-0.264,0.032,0.214,-0.238,0.039,0.227,-0.167,0.555,-0.204,-0.046,0.097],[0.23,-0.149,-0.239,0.42,-0.053,-0.256,0.227,0.421,-0.004,-0.161,0.01,0.241,0.265,0.04,-0.105,-0.374,-0.203,0.122,-0.178],[0.23,-0.205,0.178,0.325,0.197,0.003,-0.153,-0.03,-0.381,0.311,0.291,-0.156,0.23,-0.155,0.194,-0.115,0.466,-0.008,0.093]],""selectVec"":[[0.23],[0.23],[0.229],[0.229],[0.229],[0.23],[0.23],[0.23],[0.229],[0.228],[0.229],[0.23],[0.229],[0.23],[0.23],[0.229],[0.229],[0.23],[0.23]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8008,""AfterCleanSamNum"":5409,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":478,""version"":""v-2025-12-09 10:59:42"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[19] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16,IN17,IN18,IN19};
			float[] arrOUT_B = new float[19] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16,OUT_B17,OUT_B18,OUT_B19};
			LD[] arrOUT_W = new LD[19] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16,OUT_W17,OUT_W18,OUT_W19 };
			
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