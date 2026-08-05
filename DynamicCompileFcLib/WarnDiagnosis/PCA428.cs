using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA428")]
    [FCDisplay("PCA428")]
    public partial class PCA428 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁83号屏4号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁83号屏5号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁83号屏6号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁84号屏1号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁84号屏2号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁84号屏3号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁84号屏4号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁84号屏5号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁84号屏6号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁85号屏1号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁85号屏2号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁85号屏3号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁85号屏4号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁85号屏5号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁85号屏6号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁86号屏1号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁86号屏2号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁86号屏3号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁86号屏4号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁86号屏5号管壁温")]
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

		public PCA428()
		{
			ModelID = 469;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA428";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""469"",""name"":""PCA428"",""description"":""中温分隔屏过热器水冷壁23-1-20"",""founder"":""admin"",""creatTime"":""2025-12-09 10:33:10"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:34:58"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 17:48:02"",""et"":""2025-12-07 07:51:42"",""duration"":2383420,""number"":7945,""filter"":2594,""mode"":5351,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2504}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah23ct101k"",""Description"":""中温（分隔屏）过热器水冷壁83号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""569.90"",""TMin"":""487.36"",""TAvg"":""534.93"",""DMax"":""2.09"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.41"",""C99"":""1.73""},{""PointId"":""d1_10hah23ct102k"",""Description"":""中温（分隔屏）过热器水冷壁83号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""570.79"",""TMin"":""488.86"",""TAvg"":""535.64"",""DMax"":""2.99"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.16"",""C99"":""2.65""},{""PointId"":""d1_10hah23ct103k"",""Description"":""中温（分隔屏）过热器水冷壁83号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""569.80"",""TMin"":""488.56"",""TAvg"":""534.80"",""DMax"":""3.65"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.57"",""C99"":""3.15""},{""PointId"":""d1_10hah23ct104k"",""Description"":""中温（分隔屏）过热器水冷壁84号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""561.30"",""TMin"":""481.17"",""TAvg"":""527.57"",""DMax"":""4.54"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.08"",""C99"":""3.77""},{""PointId"":""d1_10hah23ct105k"",""Description"":""中温（分隔屏）过热器水冷壁84号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""562.21"",""TMin"":""480.85"",""TAvg"":""527.89"",""DMax"":""3.02"",""DMin"":""0.00"",""DAvg"":""0.70"",""C95"":""2.40"",""C99"":""2.94""},{""PointId"":""d1_10hah23ct106k"",""Description"":""中温（分隔屏）过热器水冷壁84号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""564.69"",""TMin"":""481.01"",""TAvg"":""529.65"",""DMax"":""3.93"",""DMin"":""0.00"",""DAvg"":""0.66"",""C95"":""2.27"",""C99"":""2.78""},{""PointId"":""d1_10hah23ct107k"",""Description"":""中温（分隔屏）过热器水冷壁84号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.14"",""TMin"":""489.64"",""TAvg"":""535.59"",""DMax"":""1.52"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.00"",""C99"":""1.22""},{""PointId"":""d1_10hah23ct108k"",""Description"":""中温（分隔屏）过热器水冷壁84号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""570.14"",""TMin"":""489.86"",""TAvg"":""534.53"",""DMax"":""3.09"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""1.66"",""C99"":""2.03""},{""PointId"":""d1_10hah23ct109k"",""Description"":""中温（分隔屏）过热器水冷壁84号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""571.27"",""TMin"":""491.11"",""TAvg"":""535.76"",""DMax"":""3.37"",""DMin"":""0.00"",""DAvg"":""0.57"",""C95"":""1.98"",""C99"":""2.42""},{""PointId"":""d1_10hah23ct110k"",""Description"":""中温（分隔屏）过热器水冷壁85号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""560.05"",""TMin"":""479.77"",""TAvg"":""525.74"",""DMax"":""5.79"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.10"",""C99"":""3.80""},{""PointId"":""d1_10hah23ct111k"",""Description"":""中温（分隔屏）过热器水冷壁85号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""562.85"",""TMin"":""481.59"",""TAvg"":""528.59"",""DMax"":""3.09"",""DMin"":""0.00"",""DAvg"":""0.56"",""C95"":""1.92"",""C99"":""2.35""},{""PointId"":""d1_10hah23ct112k"",""Description"":""中温（分隔屏）过热器水冷壁85号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""565.61"",""TMin"":""482.79"",""TAvg"":""529.84"",""DMax"":""2.67"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.54"",""C99"":""1.88""},{""PointId"":""d1_10hah23ct113k"",""Description"":""中温（分隔屏）过热器水冷壁85号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""572.33"",""TMin"":""491.90"",""TAvg"":""536.26"",""DMax"":""2.69"",""DMin"":""0.00"",""DAvg"":""0.51"",""C95"":""1.76"",""C99"":""2.16""},{""PointId"":""d1_10hah23ct114k"",""Description"":""中温（分隔屏）过热器水冷壁85号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""573.29"",""TMin"":""492.55"",""TAvg"":""537.00"",""DMax"":""3.14"",""DMin"":""0.00"",""DAvg"":""0.59"",""C95"":""2.02"",""C99"":""2.48""},{""PointId"":""d1_10hah23ct115k"",""Description"":""中温（分隔屏）过热器水冷壁85号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""573.08"",""TMin"":""493.76"",""TAvg"":""537.55"",""DMax"":""4.77"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.93"",""C99"":""3.59""},{""PointId"":""d1_10hah23ct116k"",""Description"":""中温（分隔屏）过热器水冷壁86号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""559.80"",""TMin"":""480.70"",""TAvg"":""526.24"",""DMax"":""4.93"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.91"",""C99"":""3.56""},{""PointId"":""d1_10hah23ct117k"",""Description"":""中温（分隔屏）过热器水冷壁86号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""562.65"",""TMin"":""481.70"",""TAvg"":""528.52"",""DMax"":""2.72"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.82"",""C99"":""2.22""},{""PointId"":""d1_10hah23ct118k"",""Description"":""中温（分隔屏）过热器水冷壁86号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""561.74"",""TMin"":""478.69"",""TAvg"":""526.72"",""DMax"":""2.93"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.28"",""C99"":""2.79""},{""PointId"":""d1_10hah23ct119k"",""Description"":""中温（分隔屏）过热器水冷壁86号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""569.15"",""TMin"":""488.17"",""TAvg"":""533.79"",""DMax"":""2.02"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""1.47"",""C99"":""1.81""},{""PointId"":""d1_10hah23ct120k"",""Description"":""中温（分隔屏）过热器水冷壁86号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""568.77"",""TMin"":""488.77"",""TAvg"":""533.23"",""DMax"":""3.00"",""DMin"":""0.00"",""DAvg"":""0.68"",""C95"":""2.34"",""C99"":""2.86""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:34:58"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[487.361,488.862,488.562,481.165,480.852,481.006,489.637,489.861,491.109,479.768,481.592,482.787,491.896,492.551,493.759,480.696,481.703,478.689,488.17,488.773],""Train_X_max"":[569.904,570.788,569.804,561.296,562.214,564.687,571.144,570.139,571.274,560.05,562.854,565.612,572.33,573.288,573.083,559.798,562.645,561.736,569.15,568.767],""Train_X_std"":[9.994,9.904,9.804,10.009,10.13,10.24,10.047,9.92,9.896,10.102,10.209,10.204,10.044,10.07,9.88,10.099,10.165,10.233,10.097,9.976],""Train_X_mean"":[534.929,535.64,534.796,527.57,527.889,529.645,535.588,534.533,535.756,525.744,528.593,529.844,536.255,536.998,537.546,526.243,528.517,526.72,533.79,533.233],""Train_X_bais_max"":[[2.091,2.985,3.646,4.542,3.02,3.933,1.518,3.093,3.371,5.794,3.092,2.673,2.693,3.142,4.77,4.93,2.716,2.932,2.02,3.002]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.405,0.63,0.749,0.895,0.704,0.658,0.289,0.482,0.572,0.888,0.562,0.442,0.51,0.588,0.862,0.837,0.525,0.665,0.426,0.684]],""QCUL_95"":0.409308881,""QCUL_99"":0.735105932,""QCUL_95_line"":[1.408,2.161,2.573,3.076,2.401,2.266,0.999,1.66,1.977,3.102,1.92,1.536,1.761,2.023,2.931,2.905,1.816,2.279,1.474,2.338],""QCUL_99_line"":[1.726,2.646,3.151,3.766,2.938,2.775,1.223,2.033,2.421,3.802,2.35,1.882,2.156,2.477,3.585,3.56,2.224,2.789,1.806,2.861],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.268,0.265,0.263,0.268,0.272,0.274,0.269,0.266,0.265,0.271,0.274,0.273,0.269,0.27,0.265,0.271,0.272,0.274,0.271,0.267],""T2CUL_99_line"":[0.352,0.349,0.345,0.353,0.357,0.361,0.354,0.349,0.349,0.356,0.36,0.359,0.354,0.355,0.348,0.356,0.358,0.36,0.356,0.351],""Kesi_95"":1.554,""Kesi_99"":1.308,""Kesi_95_line"":[0.17,0.169,0.167,0.171,0.173,0.175,0.171,0.169,0.169,0.172,0.174,0.174,0.171,0.172,0.168,0.172,0.173,0.174,0.172,0.17],""Kesi_99_line"":[0.156,0.155,0.153,0.156,0.158,0.16,0.157,0.155,0.155,0.158,0.16,0.16,0.157,0.157,0.154,0.158,0.159,0.16,0.158,0.156],""COV"":[[1.0,0.999,0.997,0.989,0.993,0.995,0.999,0.998,0.997,0.989,0.994,0.997,0.998,0.997,0.995,0.991,0.995,0.995,0.999,0.997],[0.999,1.0,0.999,0.984,0.988,0.99,0.998,0.999,0.998,0.983,0.99,0.993,0.998,0.998,0.998,0.985,0.991,0.99,0.998,0.998],[0.997,0.999,1.0,0.982,0.986,0.987,0.997,0.998,0.999,0.981,0.989,0.991,0.997,0.997,0.998,0.982,0.988,0.987,0.996,0.997],[0.989,0.984,0.982,1.0,0.999,0.997,0.991,0.987,0.986,0.999,0.998,0.995,0.986,0.985,0.978,0.999,0.997,0.995,0.988,0.982],[0.993,0.988,0.986,0.999,1.0,0.999,0.994,0.991,0.99,0.997,1.0,0.998,0.99,0.989,0.983,0.997,0.999,0.998,0.991,0.986],[0.995,0.99,0.987,0.997,0.999,1.0,0.995,0.992,0.99,0.996,0.999,0.999,0.991,0.989,0.984,0.996,0.999,0.999,0.993,0.988],[0.999,0.998,0.997,0.991,0.994,0.995,1.0,0.999,0.999,0.991,0.996,0.997,0.999,0.999,0.996,0.991,0.996,0.994,0.999,0.997],[0.998,0.999,0.998,0.987,0.991,0.992,0.999,1.0,1.0,0.987,0.993,0.995,0.999,0.999,0.998,0.987,0.993,0.991,0.998,0.998],[0.997,0.998,0.999,0.986,0.99,0.99,0.999,1.0,1.0,0.986,0.992,0.993,0.999,0.999,0.999,0.987,0.991,0.989,0.997,0.998],[0.989,0.983,0.981,0.999,0.997,0.996,0.991,0.987,0.986,1.0,0.998,0.994,0.986,0.985,0.979,0.999,0.997,0.995,0.989,0.983],[0.994,0.99,0.989,0.998,1.0,0.999,0.996,0.993,0.992,0.998,1.0,0.998,0.992,0.991,0.986,0.998,0.999,0.997,0.994,0.989],[0.997,0.993,0.991,0.995,0.998,0.999,0.997,0.995,0.993,0.994,0.998,1.0,0.995,0.994,0.989,0.995,0.999,0.999,0.996,0.993],[0.998,0.998,0.997,0.986,0.99,0.991,0.999,0.999,0.999,0.986,0.992,0.995,1.0,1.0,0.998,0.988,0.993,0.992,0.999,0.999],[0.997,0.998,0.997,0.985,0.989,0.989,0.999,0.999,0.999,0.985,0.991,0.994,1.0,1.0,0.998,0.987,0.992,0.991,0.998,0.999],[0.995,0.998,0.998,0.978,0.983,0.984,0.996,0.998,0.999,0.979,0.986,0.989,0.998,0.998,1.0,0.98,0.987,0.984,0.996,0.999],[0.991,0.985,0.982,0.999,0.997,0.996,0.991,0.987,0.987,0.999,0.998,0.995,0.988,0.987,0.98,1.0,0.998,0.996,0.991,0.985],[0.995,0.991,0.988,0.997,0.999,0.999,0.996,0.993,0.991,0.997,0.999,0.999,0.993,0.992,0.987,0.998,1.0,0.999,0.995,0.99],[0.995,0.99,0.987,0.995,0.998,0.999,0.994,0.991,0.989,0.995,0.997,0.999,0.992,0.991,0.984,0.996,0.999,1.0,0.995,0.99],[0.999,0.998,0.996,0.988,0.991,0.993,0.999,0.998,0.997,0.989,0.994,0.996,0.999,0.998,0.996,0.991,0.995,0.995,1.0,0.999],[0.997,0.998,0.997,0.982,0.986,0.988,0.997,0.998,0.998,0.983,0.989,0.993,0.999,0.999,0.999,0.985,0.99,0.99,0.999,1.0]],""K"":1,""R"":0.994,""featValue"":[19.877,0.096,0.011,0.008,0.005,0.002,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.089,-0.197,0.075,-0.454,-0.211,-0.314,-0.055,0.297,0.17,-0.363,0.124,-0.148,0.064,0.264,-0.111,0.2,-0.278,0.046,0.231],[-0.224,0.224,-0.126,0.225,-0.362,0.129,-0.019,-0.234,0.026,-0.465,0.058,-0.164,0.086,-0.229,0.251,0.108,0.001,0.386,-0.07,-0.308],[-0.223,0.267,0.065,0.381,-0.365,0.101,0.333,0.174,-0.128,0.047,-0.012,-0.098,-0.101,0.258,-0.533,-0.105,-0.148,-0.056,0.079,0.114],[-0.223,-0.335,0.318,0.178,-0.039,0.115,-0.03,0.182,0.415,-0.212,0.128,0.108,0.413,0.221,0.076,0.325,-0.137,-0.247,0.038,0.009],[-0.223,-0.25,-0.039,0.3,0.265,-0.019,0.1,-0.327,0.225,0.039,0.055,0.466,-0.227,0.228,-0.078,-0.253,0.108,0.371,-0.108,-0.035],[-0.224,-0.214,-0.325,0.276,0.071,0.06,-0.189,0.288,-0.31,0.036,0.159,0.157,-0.162,-0.24,-0.135,0.213,0.267,-0.313,-0.194,-0.307],[-0.224,0.082,0.069,0.096,0.075,-0.248,-0.392,-0.136,-0.168,0.033,0.122,0.252,0.13,-0.402,-0.188,0.025,-0.47,0.078,0.283,0.247],[-0.224,0.174,0.056,0.137,0.256,0.082,-0.161,-0.102,0.222,0.13,0.506,-0.505,-0.25,-0.001,0.153,-0.147,-0.044,-0.177,-0.179,0.197],[-0.224,0.2,0.274,0.15,0.138,0.246,-0.063,-0.153,-0.157,0.566,-0.193,-0.068,0.418,-0.026,0.09,0.029,0.286,0.091,0.093,-0.188],[-0.223,-0.326,0.4,-0.139,-0.165,0.073,-0.229,0.233,-0.379,-0.166,0.051,-0.11,-0.202,0.102,0.112,-0.124,0.288,0.298,0.122,0.271],[-0.224,-0.197,0.055,0.145,0.17,-0.359,0.203,-0.216,-0.405,-0.167,-0.298,-0.21,0.084,0.158,0.26,-0.19,-0.254,-0.291,-0.144,-0.105],[-0.224,-0.107,-0.355,-0.02,0.261,0.079,0.073,0.233,0.165,-0.159,-0.307,-0.236,0.352,-0.236,-0.206,-0.182,0.135,0.177,-0.157,0.383],[-0.224,0.179,0.015,-0.208,0.182,-0.357,-0.176,0.257,0.216,-0.146,0.015,-0.121,0.013,0.162,-0.191,-0.255,0.119,0.03,0.359,-0.512],[-0.224,0.205,0.078,-0.225,0.274,0.306,-0.225,-0.166,0.004,-0.197,-0.425,-0.009,-0.343,0.183,-0.188,0.415,-0.123,-0.05,-0.096,0.003],[-0.223,0.327,0.206,-0.015,0.163,-0.114,0.389,0.476,0.065,0.052,-0.066,0.28,-0.208,-0.244,0.392,0.084,-0.091,0.091,-0.102,0.053],[-0.223,-0.3,0.257,-0.357,-0.271,0.132,0.126,-0.115,0.199,0.18,-0.076,-0.046,-0.121,-0.418,-0.217,-0.24,-0.177,-0.099,-0.251,-0.262],[-0.224,-0.188,-0.1,-0.121,-0.01,-0.307,0.406,-0.263,0.063,0.118,0.093,-0.208,-0.13,-0.126,-0.078,0.493,0.249,0.034,0.366,0.119],[-0.224,-0.19,-0.463,-0.19,-0.035,0.382,0.058,0.138,-0.076,0.236,0.06,-0.018,-0.036,0.21,0.281,-0.064,-0.407,0.101,0.343,-0.085],[-0.224,0.112,-0.135,-0.348,-0.168,-0.314,-0.082,0.032,-0.116,0.194,0.231,0.066,0.24,0.333,-0.076,0.205,-0.061,0.226,-0.531,0.03],[-0.224,0.247,-0.05,-0.341,0.013,0.227,0.196,-0.243,-0.158,-0.289,0.262,0.341,0.191,0.003,0.012,-0.229,0.259,-0.374,0.102,0.146]],""selectVec"":[[-0.224],[-0.224],[-0.223],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.224],[-0.224]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7945,""AfterCleanSamNum"":5351,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":469,""version"":""v-2025-12-09 10:34:58"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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