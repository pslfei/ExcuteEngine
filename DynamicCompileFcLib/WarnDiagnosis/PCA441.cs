using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA441")]
    [FCDisplay("PCA441")]
    public partial class PCA441 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁126号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁126号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁126号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁127号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁127号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁127号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁127号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁127号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁127号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁128号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁128号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁128号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁128号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁128号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁128号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁129号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁129号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁129号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁129号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁129号屏5号管壁温")]
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

		public PCA441()
		{
			ModelID = 482;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA441";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""482"",""name"":""PCA441"",""description"":""中温分隔屏过热器水冷壁25-61-80"",""founder"":""admin"",""creatTime"":""2025-12-10 16:58:46"",""Modifier"":""admin"",""modifiedTime"":""2025-12-10 17:00:38"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-10 15:22:24"",""et"":""2025-12-07 19:45:50"",""duration"":2348606,""number"":7829,""filter"":2630,""mode"":5199,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2540}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah25ct161k"",""Description"":""中温（分隔屏）过热器水冷壁126号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""577.30"",""TMin"":""493.87"",""TAvg"":""538.97"",""DMax"":""2.00"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.62"",""C99"":""1.98""},{""PointId"":""d1_10hah25ct162k"",""Description"":""中温（分隔屏）过热器水冷壁126号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""579.34"",""TMin"":""496.17"",""TAvg"":""540.87"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""1.98"",""C99"":""2.42""},{""PointId"":""d1_10hah25ct163k"",""Description"":""中温（分隔屏）过热器水冷壁126号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""578.96"",""TMin"":""496.26"",""TAvg"":""541.29"",""DMax"":""4.73"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.78"",""C99"":""3.40""},{""PointId"":""d1_10hah25ct164k"",""Description"":""中温（分隔屏）过热器水冷壁127号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""571.31"",""TMin"":""492.30"",""TAvg"":""534.54"",""DMax"":""4.85"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.07"",""C99"":""3.76""},{""PointId"":""d1_10hah25ct165k"",""Description"":""中温（分隔屏）过热器水冷壁127号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""573.88"",""TMin"":""493.49"",""TAvg"":""536.26"",""DMax"":""3.75"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.61"",""C99"":""3.20""},{""PointId"":""d1_10hah25ct166k"",""Description"":""中温（分隔屏）过热器水冷壁127号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""573.77"",""TMin"":""491.55"",""TAvg"":""535.10"",""DMax"":""3.86"",""DMin"":""0.00"",""DAvg"":""0.93"",""C95"":""3.18"",""C99"":""3.89""},{""PointId"":""d1_10hah25ct167k"",""Description"":""中温（分隔屏）过热器水冷壁127号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""578.81"",""TMin"":""495.68"",""TAvg"":""540.56"",""DMax"":""2.20"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.43"",""C99"":""1.75""},{""PointId"":""d1_10hah25ct168k"",""Description"":""中温（分隔屏）过热器水冷壁127号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""580.46"",""TMin"":""497.95"",""TAvg"":""542.55"",""DMax"":""3.57"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.88"",""C99"":""2.30""},{""PointId"":""d1_10hah25ct169k"",""Description"":""中温（分隔屏）过热器水冷壁127号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""580.91"",""TMin"":""499.13"",""TAvg"":""543.59"",""DMax"":""4.88"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.09"",""C99"":""3.78""},{""PointId"":""d1_10hah25ct170k"",""Description"":""中温（分隔屏）过热器水冷壁128号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""573.36"",""TMin"":""494.79"",""TAvg"":""537.11"",""DMax"":""4.78"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.59"",""C99"":""3.18""},{""PointId"":""d1_10hah25ct171k"",""Description"":""中温（分隔屏）过热器水冷壁128号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""576.19"",""TMin"":""496.27"",""TAvg"":""538.63"",""DMax"":""4.29"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.41"",""C99"":""2.95""},{""PointId"":""d1_10hah25ct172k"",""Description"":""中温（分隔屏）过热器水冷壁128号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""576.84"",""TMin"":""496.61"",""TAvg"":""538.57"",""DMax"":""3.29"",""DMin"":""0.00"",""DAvg"":""0.60"",""C95"":""2.09"",""C99"":""2.56""},{""PointId"":""d1_10hah25ct173k"",""Description"":""中温（分隔屏）过热器水冷壁128号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""582.89"",""TMin"":""501.54"",""TAvg"":""544.97"",""DMax"":""2.22"",""DMin"":""0.00"",""DAvg"":""0.49"",""C95"":""1.71"",""C99"":""2.09""},{""PointId"":""d1_10hah25ct174k"",""Description"":""中温（分隔屏）过热器水冷壁128号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""582.00"",""TMin"":""501.33"",""TAvg"":""544.58"",""DMax"":""3.61"",""DMin"":""0.00"",""DAvg"":""0.94"",""C95"":""3.19"",""C99"":""3.91""},{""PointId"":""d1_10hah25ct175k"",""Description"":""中温（分隔屏）过热器水冷壁128号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""584.67"",""TMin"":""504.70"",""TAvg"":""548.16"",""DMax"":""7.48"",""DMin"":""0.00"",""DAvg"":""1.58"",""C95"":""5.38"",""C99"":""6.58""},{""PointId"":""d1_10hah25ct176k"",""Description"":""中温（分隔屏）过热器水冷壁129号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""576.02"",""TMin"":""496.70"",""TAvg"":""539.77"",""DMax"":""5.08"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.68"",""C99"":""3.28""},{""PointId"":""d1_10hah25ct177k"",""Description"":""中温（分隔屏）过热器水冷壁129号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""576.35"",""TMin"":""496.29"",""TAvg"":""539.15"",""DMax"":""4.44"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""2.37"",""C99"":""2.91""},{""PointId"":""d1_10hah25ct178k"",""Description"":""中温（分隔屏）过热器水冷壁129号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""577.50"",""TMin"":""497.27"",""TAvg"":""539.64"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.54"",""C95"":""1.88"",""C99"":""2.31""},{""PointId"":""d1_10hah25ct179k"",""Description"":""中温（分隔屏）过热器水冷壁129号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""580.67"",""TMin"":""500.86"",""TAvg"":""543.28"",""DMax"":""1.62"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.50"",""C99"":""1.84""},{""PointId"":""d1_10hah25ct180k"",""Description"":""中温（分隔屏）过热器水冷壁129号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""581.03"",""TMin"":""501.37"",""TAvg"":""543.64"",""DMax"":""2.63"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.59"",""C99"":""3.17""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-10 17:00:38"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[493.865,496.165,496.259,492.298,493.491,491.549,495.678,497.954,499.125,494.792,496.269,496.606,501.542,501.33,504.703,496.7,496.288,497.268,500.864,501.367],""Train_X_max"":[577.3,579.336,578.962,571.312,573.882,573.772,578.814,580.455,580.909,573.361,576.19,576.838,582.893,582.0,584.665,576.017,576.35,577.5,580.665,581.03],""Train_X_std"":[10.618,10.65,10.646,10.312,10.385,10.547,10.579,10.589,10.671,10.268,10.413,10.426,10.56,10.502,10.609,10.226,10.275,10.329,10.405,10.381],""Train_X_mean"":[538.974,540.87,541.29,534.536,536.264,535.099,540.564,542.548,543.589,537.108,538.633,538.569,544.97,544.58,548.162,539.769,539.145,539.64,543.284,543.644],""Train_X_bais_max"":[[2.0,3.165,4.733,4.846,3.753,3.863,2.201,3.573,4.878,4.784,4.293,3.294,2.223,3.607,7.482,5.083,4.435,3.009,1.616,2.628]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.001,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.475,0.578,0.802,0.88,0.763,0.933,0.413,0.539,0.901,0.742,0.695,0.598,0.493,0.94,1.58,0.769,0.688,0.544,0.441,0.767]],""QCUL_95"":0.531304955,""QCUL_99"":0.9499206,""QCUL_95_line"":[1.617,1.975,2.779,3.065,2.614,3.182,1.428,1.877,3.089,2.592,2.406,2.089,1.706,3.194,5.378,2.675,2.373,1.883,1.504,2.591],""QCUL_99_line"":[1.978,2.417,3.404,3.756,3.2,3.893,1.749,2.3,3.781,3.177,2.947,2.56,2.089,3.907,6.579,3.278,2.906,2.306,1.841,3.168],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.289,0.29,0.289,0.28,0.282,0.287,0.288,0.288,0.29,0.279,0.283,0.283,0.287,0.286,0.288,0.278,0.279,0.281,0.283,0.282],""T2CUL_99_line"":[0.379,0.381,0.38,0.369,0.371,0.377,0.378,0.378,0.381,0.367,0.372,0.373,0.377,0.375,0.379,0.365,0.367,0.369,0.372,0.371],""Kesi_95"":1.553,""Kesi_99"":1.306,""Kesi_95_line"":[0.184,0.184,0.184,0.178,0.18,0.182,0.183,0.183,0.184,0.177,0.18,0.18,0.183,0.182,0.183,0.177,0.178,0.179,0.18,0.179],""Kesi_99_line"":[0.168,0.169,0.169,0.163,0.165,0.167,0.168,0.168,0.169,0.163,0.165,0.165,0.167,0.166,0.168,0.162,0.163,0.164,0.165,0.165],""COV"":[[1.0,0.999,0.995,0.994,0.996,0.995,0.999,0.998,0.993,0.994,0.995,0.996,0.996,0.991,0.978,0.993,0.994,0.996,0.996,0.992],[0.999,1.0,0.998,0.989,0.992,0.99,0.998,0.999,0.996,0.99,0.991,0.993,0.997,0.994,0.984,0.99,0.991,0.993,0.996,0.995],[0.995,0.998,1.0,0.982,0.985,0.983,0.996,0.999,1.0,0.985,0.986,0.988,0.997,0.996,0.992,0.985,0.986,0.989,0.995,0.995],[0.994,0.989,0.982,1.0,0.999,0.997,0.993,0.987,0.979,0.999,0.997,0.996,0.988,0.978,0.96,0.999,0.997,0.996,0.99,0.983],[0.996,0.992,0.985,0.999,1.0,0.999,0.994,0.99,0.982,0.998,0.999,0.998,0.99,0.981,0.964,0.997,0.999,0.998,0.992,0.985],[0.995,0.99,0.983,0.997,0.999,1.0,0.993,0.988,0.979,0.996,0.998,0.998,0.987,0.978,0.959,0.994,0.997,0.997,0.989,0.982],[0.999,0.998,0.996,0.993,0.994,0.993,1.0,0.999,0.994,0.994,0.994,0.995,0.998,0.993,0.982,0.993,0.993,0.996,0.998,0.994],[0.998,0.999,0.999,0.987,0.99,0.988,0.999,1.0,0.998,0.989,0.99,0.992,0.999,0.997,0.989,0.989,0.99,0.993,0.998,0.997],[0.993,0.996,1.0,0.979,0.982,0.979,0.994,0.998,1.0,0.983,0.984,0.986,0.997,0.998,0.995,0.983,0.984,0.987,0.995,0.996],[0.994,0.99,0.985,0.999,0.998,0.996,0.994,0.989,0.983,1.0,0.998,0.997,0.991,0.983,0.968,0.999,0.998,0.997,0.993,0.987],[0.995,0.991,0.986,0.997,0.999,0.998,0.994,0.99,0.984,0.998,1.0,0.999,0.991,0.983,0.968,0.997,0.999,0.999,0.993,0.987],[0.996,0.993,0.988,0.996,0.998,0.998,0.995,0.992,0.986,0.997,0.999,1.0,0.994,0.986,0.972,0.995,0.999,0.999,0.994,0.99],[0.996,0.997,0.997,0.988,0.99,0.987,0.998,0.999,0.997,0.991,0.991,0.994,1.0,0.998,0.991,0.991,0.991,0.994,0.999,0.998],[0.991,0.994,0.996,0.978,0.981,0.978,0.993,0.997,0.998,0.983,0.983,0.986,0.998,1.0,0.996,0.983,0.984,0.987,0.997,0.999],[0.978,0.984,0.992,0.96,0.964,0.959,0.982,0.989,0.995,0.968,0.968,0.972,0.991,0.996,1.0,0.968,0.968,0.973,0.987,0.992],[0.993,0.99,0.985,0.999,0.997,0.994,0.993,0.989,0.983,0.999,0.997,0.995,0.991,0.983,0.968,1.0,0.998,0.996,0.993,0.988],[0.994,0.991,0.986,0.997,0.999,0.997,0.993,0.99,0.984,0.998,0.999,0.999,0.991,0.984,0.968,0.998,1.0,0.999,0.994,0.989],[0.996,0.993,0.989,0.996,0.998,0.997,0.996,0.993,0.987,0.997,0.999,0.999,0.994,0.987,0.973,0.996,0.999,1.0,0.996,0.991],[0.996,0.996,0.995,0.99,0.992,0.989,0.998,0.998,0.995,0.993,0.993,0.994,0.999,0.997,0.987,0.993,0.994,0.996,1.0,0.999],[0.992,0.995,0.995,0.983,0.985,0.982,0.994,0.997,0.996,0.987,0.987,0.99,0.998,0.999,0.992,0.988,0.989,0.991,0.999,1.0]],""K"":1,""R"":0.992,""featValue"":[19.837,0.123,0.019,0.01,0.006,0.004,0.002,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.224,0.024,0.367,0.066,-0.126,-0.091,0.162,0.137,0.241,-0.005,0.611,-0.206,0.014,-0.036,0.243,0.081,-0.344,-0.253,0.024,-0.127],[0.224,-0.087,0.407,0.057,-0.05,0.233,-0.131,0.286,-0.027,0.368,-0.075,-0.001,-0.075,0.018,-0.367,-0.009,-0.067,0.036,-0.211,0.533],[0.224,-0.225,0.309,0.1,0.293,0.238,-0.005,-0.116,-0.01,0.173,-0.098,-0.403,0.06,0.166,-0.037,0.122,0.364,0.153,0.238,-0.419],[0.223,0.282,-0.025,0.4,0.016,-0.144,-0.222,-0.304,0.121,0.283,-0.196,0.049,0.363,-0.206,0.287,0.267,-0.146,0.193,-0.15,0.054],[0.224,0.25,0.089,-0.053,0.074,0.006,-0.319,-0.101,0.459,-0.341,-0.185,0.085,-0.211,0.106,-0.076,0.202,0.245,-0.452,0.102,0.118],[0.223,0.282,0.232,-0.275,0.012,-0.152,0.01,-0.442,-0.066,-0.056,-0.11,-0.159,0.003,-0.071,-0.269,-0.55,-0.198,0.017,-0.183,-0.159],[0.224,-0.021,0.227,0.124,-0.27,-0.347,0.348,0.077,0.166,-0.278,-0.04,0.137,-0.016,-0.087,0.038,-0.114,0.376,0.458,0.166,0.189],[0.224,-0.149,0.236,0.056,-0.166,0.046,-0.09,0.128,-0.22,-0.091,-0.169,0.581,-0.192,-0.031,0.002,0.137,-0.129,-0.01,-0.212,-0.524],[0.223,-0.279,0.129,0.095,0.327,0.154,0.03,-0.252,-0.411,-0.316,0.016,0.166,0.107,-0.08,0.306,-0.132,-0.105,-0.186,0.214,0.368],[0.224,0.218,-0.229,0.335,0.182,-0.236,0.0,0.059,-0.242,-0.036,0.276,0.127,0.072,0.196,-0.568,0.104,-0.112,0.005,0.318,-0.052],[0.224,0.212,-0.085,-0.236,0.301,-0.002,-0.19,0.323,-0.175,-0.372,0.147,-0.192,0.062,0.158,0.155,0.143,0.051,0.34,-0.438,0.03],[0.224,0.162,-0.07,-0.406,0.084,-0.228,-0.057,0.124,-0.266,0.337,0.034,-0.022,-0.285,-0.511,0.117,0.16,0.164,-0.065,0.279,0.01],[0.224,-0.14,-0.107,-0.034,-0.168,-0.324,0.054,0.329,-0.146,0.081,-0.27,-0.131,0.489,0.153,0.061,-0.161,0.18,-0.465,-0.104,-0.055],[0.223,-0.291,-0.194,-0.089,-0.169,-0.189,-0.496,-0.012,0.114,0.152,0.035,-0.007,-0.214,0.391,0.222,-0.257,-0.2,0.23,0.253,0.038],[0.221,-0.497,-0.277,-0.056,0.424,-0.22,0.238,-0.078,0.39,0.067,-0.004,0.07,-0.094,-0.182,-0.173,0.053,-0.101,-0.004,-0.296,-0.003],[0.224,0.199,-0.292,0.481,0.002,0.214,0.164,0.087,-0.059,0.106,0.019,-0.111,-0.456,-0.015,0.206,-0.365,0.195,-0.135,-0.211,-0.041],[0.224,0.203,-0.164,-0.181,0.119,0.463,0.142,0.323,0.317,0.016,-0.132,0.216,0.299,-0.11,0.036,-0.245,-0.202,0.125,0.32,-0.1],[0.224,0.142,-0.106,-0.323,-0.119,0.132,0.418,-0.324,-0.061,0.271,0.105,0.232,0.0,0.506,0.112,0.238,0.108,-0.026,-0.097,0.119],[0.224,-0.085,-0.198,0.001,-0.356,0.132,0.204,-0.032,-0.11,-0.259,-0.365,-0.434,-0.166,-0.066,-0.1,0.336,-0.384,0.038,0.102,0.045],[0.224,-0.205,-0.254,-0.061,-0.401,0.315,-0.258,-0.218,-0.01,-0.1,0.401,0.005,0.24,-0.301,-0.198,-0.013,0.304,0.004,-0.119,-0.024]],""selectVec"":[[0.224],[0.224],[0.224],[0.223],[0.224],[0.223],[0.224],[0.224],[0.223],[0.224],[0.224],[0.224],[0.224],[0.223],[0.221],[0.224],[0.224],[0.224],[0.224],[0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7829,""AfterCleanSamNum"":5199,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.2%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":482,""version"":""v-2025-12-10 17:00:38"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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