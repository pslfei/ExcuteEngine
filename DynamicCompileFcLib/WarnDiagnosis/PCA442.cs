using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA442")]
    [FCDisplay("PCA442")]
    public partial class PCA442 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁129号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁130号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁130号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁130号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁130号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁130号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁130号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁131号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁131号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁131号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁131号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁131号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁131号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁132号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁132号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁132号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁132号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁132号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁132号屏6号管壁温")]
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

		public PCA442()
		{
			ModelID = 483;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA442";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""483"",""name"":""PCA442"",""description"":""中温分隔屏过热器水冷壁25-81-99"",""founder"":""admin"",""creatTime"":""2025-12-10 17:02:37"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:05:09"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 15:22:24"",""et"":""2025-12-07 10:50:14"",""duration"":2316470,""number"":7722,""filter"":2591,""mode"":5131,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2501}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah25ct181k"",""Description"":""中温（分隔屏）过热器水冷壁129号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""581.01"",""TMin"":""502.22"",""TAvg"":""544.29"",""DMax"":""7.23"",""DMin"":""0.00"",""DAvg"":""1.57"",""C95"":""5.35"",""C99"":""6.55""},{""PointId"":""d1_10hah25ct182k"",""Description"":""中温（分隔屏）过热器水冷壁130号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""571.31"",""TMin"":""492.68"",""TAvg"":""535.81"",""DMax"":""3.82"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.35"",""C99"":""2.88""},{""PointId"":""d1_10hah25ct183k"",""Description"":""中温（分隔屏）过热器水冷壁130号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""572.63"",""TMin"":""492.49"",""TAvg"":""535.79"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.37"",""C99"":""2.90""},{""PointId"":""d1_10hah25ct184k"",""Description"":""中温（分隔屏）过热器水冷壁130号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""573.05"",""TMin"":""492.01"",""TAvg"":""535.25"",""DMax"":""3.65"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.80"",""C99"":""3.42""},{""PointId"":""d1_10hah25ct185k"",""Description"":""中温（分隔屏）过热器水冷壁130号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""578.65"",""TMin"":""497.93"",""TAvg"":""541.03"",""DMax"":""2.88"",""DMin"":""0.00"",""DAvg"":""0.52"",""C95"":""1.79"",""C99"":""2.19""},{""PointId"":""d1_10hah25ct186k"",""Description"":""中温（分隔屏）过热器水冷壁130号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""578.25"",""TMin"":""498.39"",""TAvg"":""540.88"",""DMax"":""4.17"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.63"",""C99"":""3.21""},{""PointId"":""d1_10hah25ct187k"",""Description"":""中温（分隔屏）过热器水冷壁130号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""578.73"",""TMin"":""499.63"",""TAvg"":""542.13"",""DMax"":""6.58"",""DMin"":""0.00"",""DAvg"":""1.27"",""C95"":""4.35"",""C99"":""5.32""},{""PointId"":""d1_10hah25ct188k"",""Description"":""中温（分隔屏）过热器水冷壁131号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""570.12"",""TMin"":""491.36"",""TAvg"":""534.89"",""DMax"":""4.31"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.79"",""C99"":""3.41""},{""PointId"":""d1_10hah25ct189k"",""Description"":""中温（分隔屏）过热器水冷壁131号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""570.58"",""TMin"":""491.34"",""TAvg"":""534.98"",""DMax"":""4.00"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.63"",""C99"":""3.22""},{""PointId"":""d1_10hah25ct190k"",""Description"":""中温（分隔屏）过热器水冷壁131号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""570.32"",""TMin"":""490.26"",""TAvg"":""533.67"",""DMax"":""4.00"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.05"",""C99"":""3.73""},{""PointId"":""d1_10hah25ct191k"",""Description"":""中温（分隔屏）过热器水冷壁131号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""575.27"",""TMin"":""495.66"",""TAvg"":""538.58"",""DMax"":""1.50"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""0.94"",""C99"":""1.15""},{""PointId"":""d1_10hah25ct192k"",""Description"":""中温（分隔屏）过热器水冷壁131号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""576.04"",""TMin"":""497.72"",""TAvg"":""539.94"",""DMax"":""2.21"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.70"",""C99"":""2.08""},{""PointId"":""d1_10hah25ct193k"",""Description"":""中温（分隔屏）过热器水冷壁131号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""577.83"",""TMin"":""499.98"",""TAvg"":""542.17"",""DMax"":""3.98"",""DMin"":""0.00"",""DAvg"":""0.91"",""C95"":""3.11"",""C99"":""3.80""},{""PointId"":""d1_10hah25ct194k"",""Description"":""中温（分隔屏）过热器水冷壁132号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""569.77"",""TMin"":""490.70"",""TAvg"":""534.76"",""DMax"":""6.78"",""DMin"":""0.00"",""DAvg"":""1.03"",""C95"":""3.59"",""C99"":""4.39""},{""PointId"":""d1_10hah25ct195k"",""Description"":""中温（分隔屏）过热器水冷壁132号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""570.17"",""TMin"":""490.90"",""TAvg"":""534.89"",""DMax"":""4.68"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.06"",""C99"":""3.75""},{""PointId"":""d1_10hah25ct196k"",""Description"":""中温（分隔屏）过热器水冷壁132号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""569.23"",""TMin"":""489.68"",""TAvg"":""533.28"",""DMax"":""4.15"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.24"",""C99"":""3.96""},{""PointId"":""d1_10hah25ct197k"",""Description"":""中温（分隔屏）过热器水冷壁132号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""578.02"",""TMin"":""498.00"",""TAvg"":""541.12"",""DMax"":""2.13"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.35"",""C99"":""1.65""},{""PointId"":""d1_10hah25ct198k"",""Description"":""中温（分隔屏）过热器水冷壁132号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""577.01"",""TMin"":""498.55"",""TAvg"":""540.63"",""DMax"":""3.40"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.23"",""C99"":""2.73""},{""PointId"":""d1_10hah25ct199k"",""Description"":""中温（分隔屏）过热器水冷壁132号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""578.47"",""TMin"":""500.84"",""TAvg"":""542.86"",""DMax"":""5.12"",""DMin"":""0.00"",""DAvg"":""1.11"",""C95"":""3.76"",""C99"":""4.60""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:05:09"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[502.216,492.683,492.488,492.012,497.925,498.389,499.633,491.362,491.34,490.261,495.656,497.718,499.976,490.698,490.9,489.682,498.003,498.553,500.839],""Train_X_max"":[581.01,571.311,572.627,573.048,578.645,578.251,578.73,570.124,570.579,570.322,575.271,576.04,577.833,569.768,570.17,569.233,578.018,577.005,578.466],""Train_X_std"":[10.49,10.162,10.321,10.342,10.373,10.363,10.357,10.076,10.125,10.24,10.225,10.217,10.227,10.062,10.142,10.181,10.231,10.137,10.171],""Train_X_mean"":[544.294,535.811,535.786,535.254,541.033,540.883,542.133,534.887,534.984,533.665,538.58,539.941,542.17,534.758,534.889,533.284,541.119,540.631,542.86],""Train_X_bais_max"":[[7.229,3.815,3.011,3.654,2.877,4.167,6.582,4.314,3.997,3.998,1.5,2.213,3.98,6.78,4.684,4.153,2.125,3.399,5.123]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[1.565,0.676,0.698,0.819,0.515,0.762,1.265,0.808,0.767,0.885,0.27,0.49,0.905,1.033,0.895,0.948,0.385,0.645,1.106]],""QCUL_95"":0.6915552,""QCUL_99"":1.2360934,""QCUL_95_line"":[5.35,2.349,2.369,2.798,1.785,2.625,4.345,2.786,2.628,3.046,0.936,1.697,3.105,3.585,3.064,3.235,1.348,2.226,3.759],""QCUL_99_line"":[6.548,2.878,2.898,3.424,2.187,3.214,5.32,3.412,3.217,3.73,1.147,2.079,3.8,4.392,3.751,3.959,1.652,2.726,4.598],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.287,0.278,0.282,0.283,0.284,0.284,0.283,0.276,0.277,0.28,0.28,0.28,0.28,0.275,0.278,0.279,0.28,0.277,0.278],""T2CUL_99_line"":[0.377,0.366,0.371,0.372,0.373,0.373,0.373,0.362,0.364,0.368,0.368,0.368,0.368,0.362,0.365,0.366,0.368,0.365,0.366],""Kesi_95"":1.558,""Kesi_99"":1.323,""Kesi_95_line"":[0.183,0.177,0.18,0.18,0.181,0.181,0.18,0.176,0.176,0.178,0.178,0.178,0.178,0.175,0.177,0.177,0.178,0.177,0.177],""Kesi_99_line"":[0.168,0.163,0.166,0.166,0.167,0.166,0.166,0.162,0.163,0.164,0.164,0.164,0.164,0.162,0.163,0.163,0.164,0.163,0.163],""COV"":[[1.0,0.972,0.971,0.967,0.989,0.993,0.999,0.963,0.963,0.96,0.982,0.987,0.995,0.955,0.959,0.957,0.982,0.988,0.993],[0.972,1.0,0.998,0.996,0.993,0.988,0.977,0.999,0.997,0.995,0.995,0.991,0.984,0.996,0.996,0.994,0.994,0.988,0.98],[0.971,0.998,1.0,0.999,0.993,0.988,0.977,0.997,0.998,0.998,0.996,0.991,0.983,0.994,0.996,0.996,0.993,0.988,0.978],[0.967,0.996,0.999,1.0,0.992,0.986,0.974,0.995,0.997,0.999,0.995,0.99,0.981,0.992,0.996,0.998,0.992,0.986,0.975],[0.989,0.993,0.993,0.992,1.0,0.999,0.994,0.989,0.989,0.989,0.999,0.998,0.996,0.983,0.987,0.987,0.998,0.997,0.993],[0.993,0.988,0.988,0.986,0.999,1.0,0.997,0.983,0.984,0.982,0.996,0.998,0.998,0.977,0.981,0.98,0.996,0.997,0.996],[0.999,0.977,0.977,0.974,0.994,0.997,1.0,0.97,0.971,0.969,0.988,0.993,0.998,0.962,0.967,0.966,0.988,0.993,0.997],[0.963,0.999,0.997,0.995,0.989,0.983,0.97,1.0,0.999,0.997,0.994,0.989,0.98,0.999,0.998,0.997,0.993,0.986,0.977],[0.963,0.997,0.998,0.997,0.989,0.984,0.971,0.999,1.0,0.999,0.995,0.99,0.98,0.998,1.0,0.999,0.993,0.987,0.977],[0.96,0.995,0.998,0.999,0.989,0.982,0.969,0.997,0.999,1.0,0.994,0.988,0.978,0.995,0.998,1.0,0.991,0.985,0.973],[0.982,0.995,0.996,0.995,0.999,0.996,0.988,0.994,0.995,0.994,1.0,0.999,0.994,0.99,0.993,0.993,1.0,0.997,0.991],[0.987,0.991,0.991,0.99,0.998,0.998,0.993,0.989,0.99,0.988,0.999,1.0,0.998,0.985,0.988,0.987,0.999,0.999,0.996],[0.995,0.984,0.983,0.981,0.996,0.998,0.998,0.98,0.98,0.978,0.994,0.998,1.0,0.974,0.978,0.977,0.995,0.998,0.999],[0.955,0.996,0.994,0.992,0.983,0.977,0.962,0.999,0.998,0.995,0.99,0.985,0.974,1.0,0.998,0.997,0.99,0.983,0.971],[0.959,0.996,0.996,0.996,0.987,0.981,0.967,0.998,1.0,0.998,0.993,0.988,0.978,0.998,1.0,0.999,0.992,0.985,0.974],[0.957,0.994,0.996,0.998,0.987,0.98,0.966,0.997,0.999,1.0,0.993,0.987,0.977,0.997,0.999,1.0,0.991,0.984,0.973],[0.982,0.994,0.993,0.992,0.998,0.996,0.988,0.993,0.993,0.991,1.0,0.999,0.995,0.99,0.992,0.991,1.0,0.999,0.993],[0.988,0.988,0.988,0.986,0.997,0.997,0.993,0.986,0.987,0.985,0.997,0.999,0.998,0.983,0.985,0.984,0.999,1.0,0.998],[0.993,0.98,0.978,0.975,0.993,0.996,0.997,0.977,0.977,0.973,0.991,0.996,0.999,0.971,0.974,0.973,0.993,0.998,1.0]],""K"":1,""R"":0.989,""featValue"":[18.796,0.166,0.019,0.012,0.005,0.001,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.227,0.423,-0.324,-0.335,-0.341,0.151,0.306,0.065,-0.076,-0.41,-0.327,-0.067,0.058,0.051,0.079,0.046,-0.121,-0.041,0.008],[-0.23,-0.139,-0.147,-0.495,0.235,0.019,-0.226,0.197,0.177,0.196,-0.067,-0.489,-0.265,-0.129,0.206,-0.17,0.125,0.102,-0.133],[-0.23,-0.153,-0.368,-0.048,0.042,-0.274,0.277,0.205,0.227,0.349,0.089,0.221,0.186,0.399,0.013,0.111,0.105,-0.367,-0.091],[-0.23,-0.18,-0.401,0.269,-0.083,0.164,-0.132,0.426,-0.13,0.121,0.011,0.189,0.199,-0.308,0.006,-0.165,-0.194,0.337,0.262],[-0.23,0.108,-0.198,0.087,0.371,0.346,0.0,-0.458,-0.021,0.063,0.165,-0.284,0.498,0.085,-0.113,0.104,-0.056,0.115,-0.117],[-0.23,0.207,-0.15,0.108,0.275,-0.295,0.159,-0.207,-0.324,-0.1,0.325,0.084,-0.332,-0.025,0.149,-0.479,-0.192,-0.113,0.023],[-0.228,0.366,-0.159,-0.052,-0.133,0.02,-0.193,-0.102,-0.095,0.187,0.245,0.205,-0.326,-0.083,-0.269,0.338,0.485,0.183,0.078],[-0.23,-0.217,0.104,-0.377,0.115,0.048,-0.347,-0.094,-0.289,-0.003,-0.09,0.188,-0.018,-0.018,-0.252,0.217,-0.368,-0.393,0.273],[-0.23,-0.223,0.046,-0.022,-0.145,-0.226,0.082,-0.393,-0.124,0.162,-0.53,0.149,0.142,-0.213,-0.178,-0.322,0.289,0.085,-0.158],[-0.229,-0.243,-0.14,0.283,-0.158,0.026,-0.398,-0.18,0.035,-0.233,-0.158,0.053,-0.269,0.52,0.228,0.092,-0.095,0.191,-0.2],[-0.231,0.01,0.045,0.194,0.275,0.155,0.004,-0.079,0.342,-0.215,-0.13,0.283,-0.051,-0.443,0.43,0.216,0.157,-0.293,0.004],[-0.23,0.113,0.137,0.198,0.171,-0.569,-0.083,0.137,0.003,-0.229,-0.154,-0.352,0.197,0.071,-0.033,0.195,0.139,0.094,0.433],[-0.229,0.259,0.14,0.014,-0.192,-0.248,-0.271,0.055,0.476,-0.065,0.166,0.054,0.124,-0.186,-0.307,-0.124,-0.353,-0.005,-0.374],[-0.229,-0.284,0.293,-0.362,0.047,-0.004,0.137,0.116,-0.064,-0.399,0.377,0.282,0.23,0.092,0.073,-0.039,0.218,0.325,-0.094],[-0.229,-0.252,0.134,0.002,-0.342,-0.091,0.405,-0.271,0.094,0.236,0.188,-0.205,-0.181,-0.186,0.165,0.329,-0.323,0.186,0.143],[-0.229,-0.264,0.033,0.27,-0.302,0.239,0.04,0.116,-0.082,-0.231,0.226,-0.377,-0.067,-0.071,-0.263,-0.156,0.278,-0.455,-0.029],[-0.23,0.034,0.243,0.1,0.304,0.309,0.324,0.13,0.293,0.029,-0.23,0.089,-0.326,0.24,-0.402,-0.145,-0.085,0.168,0.191],[-0.23,0.15,0.315,0.178,0.117,0.025,0.099,0.358,-0.479,0.201,-0.148,-0.053,-0.005,-0.024,0.087,0.259,-0.082,-0.005,-0.514],[-0.229,0.293,0.393,-0.019,-0.269,0.207,-0.183,-0.021,0.031,0.339,0.044,0.033,0.204,0.232,0.382,-0.306,0.075,-0.11,0.295]],""selectVec"":[[-0.227],[-0.23],[-0.23],[-0.23],[-0.23],[-0.23],[-0.228],[-0.23],[-0.23],[-0.229],[-0.231],[-0.23],[-0.229],[-0.229],[-0.229],[-0.229],[-0.23],[-0.23],[-0.229]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7722,""AfterCleanSamNum"":5131,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":483,""version"":""v-2025-12-10 17:05:09"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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