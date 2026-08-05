using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA439")]
    [FCDisplay("PCA439")]
    public partial class PCA439 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁119号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁120号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁120号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁120号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁120号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁120号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁120号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁121号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁121号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁121号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁121号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁121号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁121号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁122号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁122号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁122号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁122号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁122号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁122号屏6号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁123号屏1号管壁温")]
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

		public PCA439()
		{
			ModelID = 480;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA439";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""480"",""name"":""PCA439"",""description"":""中温分隔屏过热器水冷壁25-21-40"",""founder"":""admin"",""creatTime"":""2025-12-09 11:04:08"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 11:07:04"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 14:49:30"",""et"":""2025-12-07 11:34:52"",""duration"":2407522,""number"":8026,""filter"":2608,""mode"":5418,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2518}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah25ct121k"",""Description"":""中温（分隔屏）过热器水冷壁119号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""578.06"",""TMin"":""489.75"",""TAvg"":""536.14"",""DMax"":""5.05"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.04"",""C99"":""3.72""},{""PointId"":""d1_10hah25ct122k"",""Description"":""中温（分隔屏）过热器水冷壁120号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""571.62"",""TMin"":""486.65"",""TAvg"":""531.03"",""DMax"":""5.77"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.64"",""C99"":""3.23""},{""PointId"":""d1_10hah25ct123k"",""Description"":""中温（分隔屏）过热器水冷壁120号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""571.66"",""TMin"":""486.00"",""TAvg"":""530.10"",""DMax"":""3.42"",""DMin"":""0.00"",""DAvg"":""0.61"",""C95"":""2.11"",""C99"":""2.59""},{""PointId"":""d1_10hah25ct124k"",""Description"":""中温（分隔屏）过热器水冷壁120号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""571.83"",""TMin"":""484.80"",""TAvg"":""529.20"",""DMax"":""3.35"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.68"",""C99"":""3.28""},{""PointId"":""d1_10hah25ct125k"",""Description"":""中温（分隔屏）过热器水冷壁120号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""578.36"",""TMin"":""489.70"",""TAvg"":""535.94"",""DMax"":""2.12"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""1.25"",""C99"":""1.53""},{""PointId"":""d1_10hah25ct126k"",""Description"":""中温（分隔屏）过热器水冷壁120号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""579.94"",""TMin"":""491.33"",""TAvg"":""537.33"",""DMax"":""3.31"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.99"",""C99"":""2.44""},{""PointId"":""d1_10hah25ct127k"",""Description"":""中温（分隔屏）过热器水冷壁120号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""580.62"",""TMin"":""492.40"",""TAvg"":""538.83"",""DMax"":""6.02"",""DMin"":""0.00"",""DAvg"":""1.08"",""C95"":""3.73"",""C99"":""4.57""},{""PointId"":""d1_10hah25ct128k"",""Description"":""中温（分隔屏）过热器水冷壁121号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""571.50"",""TMin"":""487.59"",""TAvg"":""531.56"",""DMax"":""5.95"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.72"",""C99"":""3.33""},{""PointId"":""d1_10hah25ct129k"",""Description"":""中温（分隔屏）过热器水冷壁121号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""571.07"",""TMin"":""486.03"",""TAvg"":""530.08"",""DMax"":""3.54"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.18"",""C99"":""2.67""},{""PointId"":""d1_10hah25ct130k"",""Description"":""中温（分隔屏）过热器水冷壁121号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""573.29"",""TMin"":""486.91"",""TAvg"":""531.44"",""DMax"":""3.90"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.76"",""C99"":""3.37""},{""PointId"":""d1_10hah25ct131k"",""Description"":""中温（分隔屏）过热器水冷壁121号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""578.94"",""TMin"":""490.96"",""TAvg"":""536.98"",""DMax"":""1.91"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.20"",""C99"":""1.47""},{""PointId"":""d1_10hah25ct132k"",""Description"":""中温（分隔屏）过热器水冷壁121号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""579.98"",""TMin"":""491.85"",""TAvg"":""537.91"",""DMax"":""3.52"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.04"",""C99"":""2.51""},{""PointId"":""d1_10hah25ct133k"",""Description"":""中温（分隔屏）过热器水冷壁121号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""578.03"",""TMin"":""490.56"",""TAvg"":""536.42"",""DMax"":""3.67"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.48"",""C99"":""3.04""},{""PointId"":""d1_10hah25ct134k"",""Description"":""中温（分隔屏）过热器水冷壁122号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""573.03"",""TMin"":""486.82"",""TAvg"":""531.39"",""DMax"":""3.27"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.31"",""C99"":""2.84""},{""PointId"":""d1_10hah25ct135k"",""Description"":""中温（分隔屏）过热器水冷壁122号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""572.69"",""TMin"":""488.27"",""TAvg"":""532.00"",""DMax"":""3.04"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.77"",""C99"":""2.17""},{""PointId"":""d1_10hah25ct136k"",""Description"":""中温（分隔屏）过热器水冷壁122号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""571.93"",""TMin"":""488.73"",""TAvg"":""532.43"",""DMax"":""4.38"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.26"",""C99"":""2.77""},{""PointId"":""d1_10hah25ct137k"",""Description"":""中温（分隔屏）过热器水冷壁122号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""578.14"",""TMin"":""491.30"",""TAvg"":""537.32"",""DMax"":""2.11"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.53"",""C99"":""1.87""},{""PointId"":""d1_10hah25ct138k"",""Description"":""中温（分隔屏）过热器水冷壁122号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""576.29"",""TMin"":""489.68"",""TAvg"":""535.09"",""DMax"":""3.97"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.28"",""C99"":""2.79""},{""PointId"":""d1_10hah25ct139k"",""Description"":""中温（分隔屏）过热器水冷壁122号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""578.01"",""TMin"":""491.92"",""TAvg"":""537.82"",""DMax"":""5.58"",""DMin"":""0.00"",""DAvg"":""1.10"",""C95"":""3.76"",""C99"":""4.61""},{""PointId"":""d1_10hah25ct140k"",""Description"":""中温（分隔屏）过热器水冷壁123号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""570.52"",""TMin"":""488.77"",""TAvg"":""531.80"",""DMax"":""4.66"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.26"",""C99"":""2.77""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 11:07:04"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[489.754,486.65,486.004,484.795,489.696,491.332,492.404,487.587,486.031,486.913,490.955,491.853,490.559,486.818,488.274,488.733,491.297,489.675,491.917,488.773],""Train_X_max"":[578.061,571.624,571.657,571.827,578.361,579.942,580.624,571.503,571.068,573.286,578.942,579.984,578.034,573.03,572.689,571.928,578.137,576.285,578.008,570.517],""Train_X_std"":[11.08,10.878,10.915,11.054,11.106,11.113,11.081,10.848,10.901,11.04,11.079,11.047,11.086,10.96,10.838,10.759,10.997,10.928,10.935,10.673],""Train_X_mean"":[536.136,531.027,530.104,529.202,535.939,537.328,538.829,531.563,530.081,531.442,536.975,537.905,536.418,531.385,532.002,532.43,537.318,535.088,537.819,531.797],""Train_X_bais_max"":[[5.052,5.772,3.419,3.347,2.119,3.309,6.021,5.948,3.537,3.898,1.911,3.515,3.666,3.266,3.043,4.383,2.105,3.965,5.579,4.657]],""Train_X_bais_min"":[[0.0,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.001,0.0]],""Train_X_bais_mean"":[[0.879,0.752,0.611,0.782,0.363,0.571,1.084,0.773,0.626,0.806,0.345,0.585,0.725,0.667,0.51,0.647,0.437,0.658,1.096,0.638]],""QCUL_95"":0.4392853,""QCUL_99"":0.7852212,""QCUL_95_line"":[3.039,2.636,2.113,2.676,1.249,1.991,3.731,2.715,2.177,2.757,1.199,2.043,2.481,2.314,1.77,2.263,1.525,2.279,3.764,2.256],""QCUL_99_line"":[3.722,3.232,2.588,3.275,1.529,2.44,4.568,3.33,2.667,3.374,1.47,2.505,3.036,2.835,2.169,2.774,1.87,2.792,4.609,2.768],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.295,0.29,0.291,0.294,0.296,0.296,0.295,0.289,0.29,0.294,0.295,0.294,0.295,0.292,0.289,0.287,0.293,0.291,0.291,0.284],""T2CUL_99_line"":[0.388,0.381,0.382,0.387,0.389,0.389,0.388,0.38,0.382,0.387,0.388,0.387,0.388,0.384,0.379,0.377,0.385,0.383,0.383,0.374],""Kesi_95"":1.56,""Kesi_99"":1.328,""Kesi_95_line"":[0.188,0.185,0.185,0.188,0.188,0.189,0.188,0.184,0.185,0.187,0.188,0.187,0.188,0.186,0.184,0.183,0.187,0.185,0.186,0.181],""Kesi_99_line"":[0.173,0.17,0.171,0.173,0.174,0.174,0.174,0.17,0.171,0.173,0.173,0.173,0.174,0.172,0.17,0.168,0.172,0.171,0.171,0.167],""COV"":[[1.0,0.984,0.987,0.985,0.997,0.999,0.999,0.984,0.986,0.983,0.996,0.999,1.0,0.986,0.989,0.986,0.997,0.999,0.999,0.986],[0.984,1.0,0.998,0.997,0.993,0.99,0.98,1.0,0.999,0.998,0.994,0.989,0.987,0.996,0.998,1.0,0.991,0.987,0.979,0.999],[0.987,0.998,1.0,0.999,0.995,0.992,0.983,0.998,1.0,0.999,0.995,0.991,0.99,0.999,1.0,0.998,0.993,0.99,0.982,0.998],[0.985,0.997,0.999,1.0,0.994,0.99,0.98,0.997,0.999,1.0,0.994,0.989,0.987,1.0,0.999,0.996,0.992,0.988,0.979,0.996],[0.997,0.993,0.995,0.994,1.0,0.999,0.994,0.993,0.995,0.994,1.0,0.999,0.998,0.995,0.996,0.994,0.999,0.998,0.994,0.994],[0.999,0.99,0.992,0.99,0.999,1.0,0.997,0.989,0.991,0.989,0.999,1.0,0.999,0.991,0.993,0.991,0.999,1.0,0.996,0.991],[0.999,0.98,0.983,0.98,0.994,0.997,1.0,0.979,0.982,0.978,0.994,0.998,0.999,0.982,0.985,0.983,0.996,0.998,0.999,0.983],[0.984,1.0,0.998,0.997,0.993,0.989,0.979,1.0,0.999,0.998,0.994,0.988,0.987,0.996,0.998,1.0,0.991,0.987,0.979,0.999],[0.986,0.999,1.0,0.999,0.995,0.991,0.982,0.999,1.0,0.999,0.995,0.991,0.989,0.999,1.0,0.999,0.993,0.99,0.981,0.999],[0.983,0.998,0.999,1.0,0.994,0.989,0.978,0.998,0.999,1.0,0.994,0.989,0.986,1.0,0.999,0.997,0.992,0.988,0.978,0.997],[0.996,0.994,0.995,0.994,1.0,0.999,0.994,0.994,0.995,0.994,1.0,0.999,0.997,0.995,0.996,0.995,0.999,0.998,0.993,0.995],[0.999,0.989,0.991,0.989,0.999,1.0,0.998,0.988,0.991,0.989,0.999,1.0,1.0,0.991,0.993,0.991,0.999,1.0,0.997,0.991],[1.0,0.987,0.99,0.987,0.998,0.999,0.999,0.987,0.989,0.986,0.997,1.0,1.0,0.989,0.991,0.989,0.998,1.0,0.999,0.989],[0.986,0.996,0.999,1.0,0.995,0.991,0.982,0.996,0.999,1.0,0.995,0.991,0.989,1.0,0.999,0.997,0.994,0.991,0.982,0.997],[0.989,0.998,1.0,0.999,0.996,0.993,0.985,0.998,1.0,0.999,0.996,0.993,0.991,0.999,1.0,0.999,0.995,0.992,0.985,0.999],[0.986,1.0,0.998,0.996,0.994,0.991,0.983,1.0,0.999,0.997,0.995,0.991,0.989,0.997,0.999,1.0,0.993,0.99,0.983,1.0],[0.997,0.991,0.993,0.992,0.999,0.999,0.996,0.991,0.993,0.992,0.999,0.999,0.998,0.994,0.995,0.993,1.0,0.999,0.996,0.994],[0.999,0.987,0.99,0.988,0.998,1.0,0.998,0.987,0.99,0.988,0.998,1.0,1.0,0.991,0.992,0.99,0.999,1.0,0.998,0.99],[0.999,0.979,0.982,0.979,0.994,0.996,0.999,0.979,0.981,0.978,0.993,0.997,0.999,0.982,0.985,0.983,0.996,0.998,1.0,0.983],[0.986,0.999,0.998,0.996,0.994,0.991,0.983,0.999,0.999,0.997,0.995,0.991,0.989,0.997,0.999,1.0,0.994,0.99,0.983,1.0]],""K"":1,""R"":0.993,""featValue"":[19.873,0.107,0.011,0.004,0.004,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.223,0.287,-0.017,0.036,0.427,-0.459,-0.158,-0.238,0.4,0.03,0.448,-0.035,0.007,-0.117,-0.075,0.008,0.018,0.077,-0.007,0.045],[0.223,-0.238,-0.336,-0.237,0.178,-0.141,0.03,0.018,0.071,-0.072,-0.25,-0.522,0.207,-0.127,0.356,-0.078,-0.04,-0.325,0.12,-0.118],[0.224,-0.195,0.091,0.138,0.349,0.292,0.251,0.183,0.209,0.201,0.001,-0.017,-0.065,0.198,0.178,0.154,0.172,-0.057,-0.519,0.308],[0.223,-0.23,0.39,0.01,0.186,-0.202,-0.064,-0.061,-0.068,0.197,-0.292,0.103,0.368,0.341,-0.052,-0.013,0.281,0.279,0.255,-0.217],[0.224,0.077,0.115,-0.406,-0.078,0.005,0.243,-0.204,0.186,0.031,-0.211,0.242,0.045,0.071,0.107,0.104,-0.608,0.147,0.104,0.3],[0.224,0.179,0.094,-0.342,0.101,0.254,-0.251,-0.099,0.064,0.196,-0.085,0.206,-0.339,0.136,-0.12,-0.107,0.034,-0.453,-0.066,-0.427],[0.223,0.362,-0.112,0.168,0.246,0.028,0.414,-0.288,-0.455,0.106,-0.29,-0.093,-0.199,-0.252,-0.14,-0.013,0.129,0.092,0.051,0.027],[0.223,-0.249,-0.352,-0.215,0.072,0.005,-0.114,0.174,0.049,-0.234,-0.155,-0.005,-0.026,-0.007,-0.676,-0.13,-0.007,0.26,-0.198,0.079],[0.224,-0.214,0.042,0.103,0.182,0.237,0.157,0.323,-0.027,-0.018,0.324,-0.025,-0.168,-0.075,-0.161,0.356,-0.15,-0.063,0.589,-0.088],[0.223,-0.254,0.298,-0.033,-0.045,-0.265,-0.066,0.261,-0.213,0.086,0.077,-0.009,-0.404,-0.328,0.253,-0.303,-0.189,0.267,-0.193,-0.146],[0.224,0.057,0.095,-0.369,-0.321,-0.067,0.266,0.074,-0.078,0.005,0.322,-0.045,-0.004,0.1,-0.03,-0.326,0.448,-0.148,0.179,0.364],[0.224,0.197,0.064,-0.172,-0.088,0.227,-0.055,0.038,-0.363,0.102,0.371,-0.2,0.524,-0.052,-0.052,0.151,-0.188,0.099,-0.316,-0.216],[0.224,0.24,-0.038,-0.005,0.174,-0.078,-0.247,0.319,-0.242,-0.494,-0.124,0.451,0.136,-0.073,0.267,0.135,0.125,-0.126,-0.001,0.163],[0.224,-0.187,0.36,0.273,-0.217,-0.224,-0.19,-0.235,-0.148,-0.124,-0.087,-0.187,-0.026,-0.015,-0.281,0.211,-0.14,-0.462,-0.12,0.266],[0.224,-0.158,0.071,0.341,0.009,0.374,0.12,-0.318,0.158,-0.386,0.126,0.149,0.181,-0.079,0.063,-0.515,-0.088,-0.018,0.039,-0.136],[0.224,-0.194,-0.37,0.028,-0.172,-0.071,-0.075,-0.366,-0.22,-0.149,0.213,0.03,-0.299,0.463,0.254,0.245,0.055,0.202,-0.046,-0.102],[0.224,0.123,0.07,0.037,-0.423,-0.115,0.321,0.084,0.404,-0.198,-0.14,0.017,-0.009,-0.212,-0.01,0.347,0.239,0.071,-0.149,-0.393],[0.224,0.219,0.083,0.054,-0.17,0.392,-0.505,-0.03,0.183,0.051,-0.168,-0.343,-0.122,-0.118,0.13,0.04,0.144,0.328,0.184,0.248],[0.223,0.366,-0.158,0.39,-0.164,-0.162,0.058,0.401,0.062,0.119,-0.083,-0.129,-0.005,0.465,-0.037,-0.271,-0.285,-0.061,0.042,-0.055],[0.224,-0.186,-0.393,0.204,-0.243,-0.034,-0.135,-0.035,0.026,0.552,0.004,0.409,0.196,-0.318,0.026,0.004,0.049,-0.108,0.053,0.098]],""selectVec"":[[0.223],[0.223],[0.224],[0.223],[0.224],[0.224],[0.223],[0.223],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.224],[0.223],[0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8026,""AfterCleanSamNum"":5418,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.3%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":480,""version"":""v-2025-12-09 11:07:04"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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