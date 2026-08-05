using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA402")]
    [FCDisplay("PCA402")]
    public partial class PCA402 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁30号屏6号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁31号屏1号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁31号屏2号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁31号屏3号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁31号屏4号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁31号屏5号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁31号屏6号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁32号屏1号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁32号屏2号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁32号屏3号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁32号屏4号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁32号屏5号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁32号屏6号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁33号屏1号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁33号屏2号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁33号屏3号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁33号屏4号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁33号屏5号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁33号屏6号管壁温")]
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

		public PCA402()
		{
			ModelID = 443;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA402";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""443"",""name"":""PCA402"",""description"":""中温分隔屏过热器水冷壁18-81-99"",""founder"":""admin"",""creatTime"":""2025-12-04 09:15:49"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 09:17:21"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 15:03:32"",""et"":""2025-12-04 03:59:06"",""duration"":2552134,""number"":8508,""filter"":2648,""mode"":5860,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2558}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah18ct181k"",""Description"":""中温（分隔屏）过热器水冷壁30号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""587.23"",""TMin"":""501.73"",""TAvg"":""549.04"",""DMax"":""6.22"",""DMin"":""0.00"",""DAvg"":""1.18"",""C95"":""4.08"",""C99"":""5.00""},{""PointId"":""d1_10hah18ct182k"",""Description"":""中温（分隔屏）过热器水冷壁31号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""573.28"",""TMin"":""490.50"",""TAvg"":""535.64"",""DMax"":""7.51"",""DMin"":""0.00"",""DAvg"":""1.13"",""C95"":""3.94"",""C99"":""4.82""},{""PointId"":""d1_10hah18ct183k"",""Description"":""中温（分隔屏）过热器水冷壁31号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""573.95"",""TMin"":""489.80"",""TAvg"":""536.68"",""DMax"":""6.17"",""DMin"":""0.00"",""DAvg"":""1.04"",""C95"":""3.55"",""C99"":""4.34""},{""PointId"":""d1_10hah18ct184k"",""Description"":""中温（分隔屏）过热器水冷壁31号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""572.73"",""TMin"":""486.38"",""TAvg"":""535.14"",""DMax"":""6.54"",""DMin"":""0.00"",""DAvg"":""1.07"",""C95"":""3.64"",""C99"":""4.46""},{""PointId"":""d1_10hah18ct185k"",""Description"":""中温（分隔屏）过热器水冷壁31号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""580.65"",""TMin"":""496.05"",""TAvg"":""542.98"",""DMax"":""4.28"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.63"",""C99"":""2.01""},{""PointId"":""d1_10hah18ct186k"",""Description"":""中温（分隔屏）过热器水冷壁31号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""584.18"",""TMin"":""499.57"",""TAvg"":""546.33"",""DMax"":""4.19"",""DMin"":""0.00"",""DAvg"":""0.78"",""C95"":""2.72"",""C99"":""3.34""},{""PointId"":""d1_10hah18ct187k"",""Description"":""中温（分隔屏）过热器水冷壁31号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""584.85"",""TMin"":""501.42"",""TAvg"":""547.77"",""DMax"":""4.84"",""DMin"":""0.00"",""DAvg"":""1.10"",""C95"":""3.75"",""C99"":""4.59""},{""PointId"":""d1_10hah18ct188k"",""Description"":""中温（分隔屏）过热器水冷壁32号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""577.62"",""TMin"":""497.10"",""TAvg"":""541.13"",""DMax"":""3.44"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.30"",""C99"":""2.82""},{""PointId"":""d1_10hah18ct189k"",""Description"":""中温（分隔屏）过热器水冷壁32号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""576.03"",""TMin"":""494.88"",""TAvg"":""538.86"",""DMax"":""3.14"",""DMin"":""0.00"",""DAvg"":""0.72"",""C95"":""2.49"",""C99"":""3.05""},{""PointId"":""d1_10hah18ct190k"",""Description"":""中温（分隔屏）过热器水冷壁32号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""576.73"",""TMin"":""494.18"",""TAvg"":""539.60"",""DMax"":""3.55"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.36"",""C99"":""2.89""},{""PointId"":""d1_10hah18ct191k"",""Description"":""中温（分隔屏）过热器水冷壁32号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""583.10"",""TMin"":""501.35"",""TAvg"":""546.53"",""DMax"":""2.44"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""1.39"",""C99"":""1.70""},{""PointId"":""d1_10hah18ct192k"",""Description"":""中温（分隔屏）过热器水冷壁32号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""582.32"",""TMin"":""500.52"",""TAvg"":""545.58"",""DMax"":""2.97"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.76"",""C99"":""3.37""},{""PointId"":""d1_10hah18ct193k"",""Description"":""中温（分隔屏）过热器水冷壁32号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""586.72"",""TMin"":""505.22"",""TAvg"":""550.59"",""DMax"":""6.91"",""DMin"":""0.00"",""DAvg"":""1.72"",""C95"":""5.75"",""C99"":""7.02""},{""PointId"":""d1_10hah18ct194k"",""Description"":""中温（分隔屏）过热器水冷壁33号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""578.70"",""TMin"":""497.72"",""TAvg"":""541.33"",""DMax"":""4.62"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""3.01"",""C99"":""3.70""},{""PointId"":""d1_10hah18ct195k"",""Description"":""中温（分隔屏）过热器水冷壁33号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""575.23"",""TMin"":""493.10"",""TAvg"":""537.41"",""DMax"":""4.85"",""DMin"":""0.00"",""DAvg"":""1.10"",""C95"":""3.73"",""C99"":""4.56""},{""PointId"":""d1_10hah18ct196k"",""Description"":""中温（分隔屏）过热器水冷壁33号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""574.83"",""TMin"":""491.88"",""TAvg"":""537.04"",""DMax"":""4.27"",""DMin"":""0.00"",""DAvg"":""1.09"",""C95"":""3.66"",""C99"":""4.47""},{""PointId"":""d1_10hah18ct197k"",""Description"":""中温（分隔屏）过热器水冷壁33号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""580.23"",""TMin"":""499.60"",""TAvg"":""543.74"",""DMax"":""2.20"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.04"",""C99"":""1.28""},{""PointId"":""d1_10hah18ct198k"",""Description"":""中温（分隔屏）过热器水冷壁33号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""583.62"",""TMin"":""503.04"",""TAvg"":""547.84"",""DMax"":""4.21"",""DMin"":""0.00"",""DAvg"":""0.81"",""C95"":""2.81"",""C99"":""3.44""},{""PointId"":""d1_10hah18ct199k"",""Description"":""中温（分隔屏）过热器水冷壁33号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""583.83"",""TMin"":""502.90"",""TAvg"":""547.61"",""DMax"":""6.85"",""DMin"":""0.00"",""DAvg"":""1.17"",""C95"":""4.01"",""C99"":""4.91""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 09:17:21"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[501.733,490.5,489.8,486.383,496.05,499.567,501.417,497.1,494.88,494.18,501.35,500.517,505.22,497.72,493.1,491.883,499.6,503.04,502.9],""Train_X_max"":[587.233,573.28,573.95,572.733,580.65,584.183,584.85,577.62,576.033,576.733,583.1,582.32,586.72,578.7,575.233,574.833,580.233,583.617,583.833],""Train_X_std"":[10.714,10.394,10.449,10.51,10.596,10.69,10.637,10.245,10.261,10.315,10.47,10.487,10.536,10.107,10.263,10.322,10.344,10.426,10.335],""Train_X_mean"":[549.043,535.639,536.677,535.139,542.979,546.329,547.772,541.129,538.858,539.599,546.528,545.583,550.592,541.33,537.412,537.035,543.738,547.835,547.611],""Train_X_bais_max"":[[6.221,7.509,6.173,6.535,4.281,4.192,4.844,3.441,3.137,3.549,2.437,2.969,6.911,4.62,4.849,4.267,2.198,4.207,6.851]],""Train_X_bais_min"":[[0.0,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.002,0.0,0.0,0.0,0.0,0.001,0.0]],""Train_X_bais_mean"":[[1.177,1.133,1.04,1.066,0.449,0.781,1.096,0.67,0.724,0.69,0.402,0.809,1.716,0.857,1.102,1.087,0.287,0.812,1.165]],""QCUL_95"":0.8075484,""QCUL_99"":1.44853842,""QCUL_95_line"":[4.084,3.937,3.55,3.64,1.633,2.722,3.751,2.302,2.491,2.361,1.386,2.757,5.748,3.013,3.728,3.659,1.042,2.812,4.009],""QCUL_99_line"":[5.003,4.823,4.344,4.455,2.008,3.336,4.591,2.818,3.049,2.89,1.698,3.373,7.024,3.695,4.559,4.473,1.281,3.444,4.908],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.274,0.266,0.268,0.269,0.271,0.274,0.272,0.262,0.263,0.264,0.268,0.269,0.27,0.259,0.263,0.264,0.265,0.267,0.265],""T2CUL_99_line"":[0.361,0.35,0.352,0.354,0.357,0.36,0.358,0.345,0.345,0.347,0.352,0.353,0.355,0.34,0.345,0.347,0.348,0.351,0.348],""Kesi_95"":1.558,""Kesi_99"":1.32,""Kesi_95_line"":[0.175,0.169,0.17,0.171,0.173,0.174,0.173,0.167,0.167,0.168,0.171,0.171,0.172,0.165,0.167,0.168,0.169,0.17,0.168],""Kesi_99_line"":[0.161,0.156,0.157,0.158,0.159,0.16,0.16,0.154,0.154,0.155,0.157,0.157,0.158,0.152,0.154,0.155,0.155,0.156,0.155],""COV"":[[1.0,0.967,0.969,0.969,0.991,0.998,0.999,0.981,0.977,0.978,0.993,0.996,0.995,0.972,0.965,0.967,0.989,0.995,0.996],[0.967,1.0,0.998,0.996,0.99,0.978,0.97,0.995,0.995,0.994,0.985,0.976,0.949,0.995,0.995,0.992,0.988,0.974,0.964],[0.969,0.998,1.0,0.999,0.991,0.98,0.971,0.994,0.998,0.998,0.987,0.978,0.951,0.995,0.998,0.997,0.99,0.977,0.967],[0.969,0.996,0.999,1.0,0.992,0.981,0.971,0.992,0.996,0.998,0.988,0.979,0.951,0.993,0.997,0.997,0.991,0.977,0.966],[0.991,0.99,0.991,0.992,1.0,0.997,0.993,0.994,0.993,0.994,0.998,0.994,0.979,0.99,0.987,0.988,0.997,0.993,0.988],[0.998,0.978,0.98,0.981,0.997,1.0,0.999,0.988,0.985,0.987,0.997,0.997,0.99,0.982,0.977,0.978,0.995,0.996,0.995],[0.999,0.97,0.971,0.971,0.993,0.999,1.0,0.983,0.978,0.979,0.995,0.997,0.995,0.975,0.968,0.969,0.991,0.996,0.997],[0.981,0.995,0.994,0.992,0.994,0.988,0.983,1.0,0.997,0.995,0.995,0.989,0.971,0.997,0.993,0.991,0.995,0.988,0.982],[0.977,0.995,0.998,0.996,0.993,0.985,0.978,0.997,1.0,0.999,0.992,0.985,0.964,0.997,0.998,0.997,0.995,0.985,0.977],[0.978,0.994,0.998,0.998,0.994,0.987,0.979,0.995,0.999,1.0,0.993,0.986,0.964,0.996,0.998,0.998,0.996,0.986,0.978],[0.993,0.985,0.987,0.988,0.998,0.997,0.995,0.995,0.992,0.993,1.0,0.998,0.986,0.99,0.986,0.987,0.999,0.998,0.993],[0.996,0.976,0.978,0.979,0.994,0.997,0.997,0.989,0.985,0.986,0.998,1.0,0.992,0.982,0.977,0.979,0.996,0.999,0.996],[0.995,0.949,0.951,0.951,0.979,0.99,0.995,0.971,0.964,0.964,0.986,0.992,1.0,0.96,0.95,0.951,0.981,0.992,0.997],[0.972,0.995,0.995,0.993,0.99,0.982,0.975,0.997,0.997,0.996,0.99,0.982,0.96,1.0,0.997,0.996,0.994,0.983,0.975],[0.965,0.995,0.998,0.997,0.987,0.977,0.968,0.993,0.998,0.998,0.986,0.977,0.95,0.997,1.0,0.999,0.991,0.977,0.967],[0.967,0.992,0.997,0.997,0.988,0.978,0.969,0.991,0.997,0.998,0.987,0.979,0.951,0.996,0.999,1.0,0.992,0.979,0.969],[0.989,0.988,0.99,0.991,0.997,0.995,0.991,0.995,0.995,0.996,0.999,0.996,0.981,0.994,0.991,0.992,1.0,0.997,0.991],[0.995,0.974,0.977,0.977,0.993,0.996,0.996,0.988,0.985,0.986,0.998,0.999,0.992,0.983,0.977,0.979,0.997,1.0,0.998],[0.996,0.964,0.967,0.966,0.988,0.995,0.997,0.982,0.977,0.978,0.993,0.996,0.997,0.975,0.967,0.969,0.991,0.998,1.0]],""K"":1,""R"":0.987,""featValue"":[18.76,0.194,0.019,0.013,0.005,0.005,0.002,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.229,0.293,-0.24,-0.063,0.329,0.077,0.118,-0.596,-0.181,0.322,0.198,0.188,0.139,0.267,0.003,-0.01,-0.105,0.056,0.037],[-0.229,-0.266,-0.368,0.413,-0.056,0.108,0.322,0.133,-0.205,-0.296,-0.069,0.405,-0.162,0.211,-0.01,-0.03,0.217,0.066,-0.12],[-0.229,-0.264,-0.187,-0.078,0.128,-0.222,0.425,0.021,0.134,0.262,0.024,-0.192,-0.121,-0.345,0.007,-0.412,-0.11,-0.383,-0.059],[-0.229,-0.258,-0.238,-0.293,-0.061,-0.151,-0.041,0.227,-0.432,0.22,0.092,-0.275,0.033,-0.06,0.08,0.396,-0.075,0.342,-0.221],[-0.231,0.02,-0.367,-0.087,-0.172,0.113,-0.242,0.251,0.201,0.058,0.305,-0.06,0.275,0.109,-0.47,0.001,0.223,-0.204,0.316],[-0.23,0.175,-0.293,-0.162,0.055,0.284,-0.179,-0.013,0.284,0.007,-0.36,0.323,-0.096,-0.544,0.103,0.223,-0.055,0.069,-0.029],[-0.229,0.273,-0.255,0.011,0.115,0.201,-0.061,0.02,0.051,-0.352,-0.207,-0.629,-0.112,0.235,0.27,-0.201,-0.009,0.049,0.023],[-0.23,-0.094,0.022,0.567,-0.168,-0.249,-0.158,-0.077,-0.011,0.233,-0.389,-0.095,0.389,-0.03,0.09,0.04,-0.214,0.047,0.265],[-0.23,-0.174,0.118,0.039,0.345,-0.332,-0.116,-0.089,0.523,-0.011,-0.083,-0.047,-0.066,0.282,-0.111,0.316,0.217,-0.023,-0.354],[-0.23,-0.165,0.1,-0.213,0.156,-0.237,-0.374,0.046,-0.119,-0.063,-0.127,0.212,-0.395,0.125,-0.204,-0.383,-0.205,0.257,0.307],[-0.231,0.078,-0.007,-0.007,-0.373,-0.157,-0.244,0.047,0.111,-0.002,0.372,0.21,-0.181,0.165,0.558,0.044,-0.208,-0.314,-0.068],[-0.23,0.188,0.073,-0.096,-0.434,-0.275,0.216,-0.395,-0.072,-0.413,-0.025,-0.101,-0.115,-0.149,-0.382,0.205,-0.13,-0.052,-0.012],[-0.226,0.431,0.152,0.165,0.272,-0.351,-0.098,0.202,-0.257,-0.145,0.209,0.068,0.145,-0.356,0.078,-0.133,0.39,0.035,-0.071],[-0.23,-0.195,0.268,0.374,0.0,0.45,-0.263,-0.225,-0.116,0.147,0.273,-0.228,-0.342,-0.232,-0.147,0.029,0.085,-0.033,-0.109],[-0.229,-0.281,0.23,-0.063,0.196,0.14,0.266,-0.005,0.24,-0.335,0.35,0.014,0.272,-0.127,0.21,0.102,-0.166,0.293,0.365],[-0.229,-0.257,0.268,-0.348,0.032,0.165,-0.079,-0.136,-0.324,-0.11,-0.323,0.064,0.233,0.083,0.152,0.046,0.311,-0.467,0.094],[-0.231,0.012,0.182,-0.111,-0.228,0.2,-0.051,0.052,0.096,-0.016,-0.026,0.104,0.405,0.06,-0.123,-0.441,-0.165,0.215,-0.577],[-0.23,0.192,0.257,-0.114,-0.337,0.052,0.331,0.072,0.172,0.399,-0.118,-0.012,-0.212,0.128,0.112,-0.041,0.429,0.304,0.21],[-0.229,0.298,0.285,0.068,0.212,0.18,0.233,0.468,-0.106,0.091,-0.093,0.052,-0.089,0.172,-0.215,0.25,-0.424,-0.255,0.004]],""selectVec"":[[-0.229],[-0.229],[-0.229],[-0.229],[-0.231],[-0.23],[-0.229],[-0.23],[-0.23],[-0.23],[-0.231],[-0.23],[-0.226],[-0.23],[-0.229],[-0.229],[-0.231],[-0.23],[-0.229]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8508,""AfterCleanSamNum"":5860,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.7%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":443,""version"":""v-2025-12-04 09:17:21"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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