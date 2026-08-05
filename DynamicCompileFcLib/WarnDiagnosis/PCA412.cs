using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA412")]
    [FCDisplay("PCA412")]
    public partial class PCA412 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁40号屏5号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁40号屏6号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁41号屏1号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁41号屏2号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁41号屏3号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁41号屏4号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁41号屏5号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁41号屏6号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁42号屏1号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁42号屏2号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁42号屏3号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁42号屏4号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁42号屏5号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁42号屏6号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁43号屏1号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁43号屏2号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁43号屏3号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁43号屏4号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁43号屏5号管壁温")]
	    public LAExWarn IN19 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁43号屏6号管壁温")]
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

		public PCA412()
		{
			ModelID = 453;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA412";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""453"",""name"":""PCA412"",""description"":""中温分隔屏过热器水冷壁19-41-60"",""founder"":""admin"",""creatTime"":""2025-12-04 17:26:03"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 17:28:13"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-04 18:02:04"",""et"":""2025-12-04 09:11:32"",""duration"":2560168,""number"":8534,""filter"":2648,""mode"":5886,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2558}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah19ct141k"",""Description"":""中温（分隔屏）过热器水冷壁40号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""584.05"",""TMin"":""501.62"",""TAvg"":""544.31"",""DMax"":""3.11"",""DMin"":""0.00"",""DAvg"":""0.55"",""C95"":""1.92"",""C99"":""2.35""},{""PointId"":""d1_10hah19ct142k"",""Description"":""中温（分隔屏）过热器水冷壁40号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""583.80"",""TMin"":""502.10"",""TAvg"":""544.50"",""DMax"":""3.36"",""DMin"":""0.00"",""DAvg"":""0.74"",""C95"":""2.56"",""C99"":""3.13""},{""PointId"":""d1_10hah19ct143k"",""Description"":""中温（分隔屏）过热器水冷壁41号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""578.32"",""TMin"":""496.36"",""TAvg"":""539.17"",""DMax"":""2.97"",""DMin"":""0.00"",""DAvg"":""0.76"",""C95"":""2.57"",""C99"":""3.15""},{""PointId"":""d1_10hah19ct144k"",""Description"":""中温（分隔屏）过热器水冷壁41号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""575.62"",""TMin"":""491.34"",""TAvg"":""536.57"",""DMax"":""3.17"",""DMin"":""0.00"",""DAvg"":""0.82"",""C95"":""2.80"",""C99"":""3.43""},{""PointId"":""d1_10hah19ct145k"",""Description"":""中温（分隔屏）过热器水冷壁41号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""578.05"",""TMin"":""491.86"",""TAvg"":""538.73"",""DMax"":""4.24"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.86"",""C99"":""3.50""},{""PointId"":""d1_10hah19ct146k"",""Description"":""中温（分隔屏）过热器水冷壁41号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""584.12"",""TMin"":""501.30"",""TAvg"":""544.23"",""DMax"":""2.47"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.56"",""C99"":""1.91""},{""PointId"":""d1_10hah19ct147k"",""Description"":""中温（分隔屏）过热器水冷壁41号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""584.55"",""TMin"":""501.56"",""TAvg"":""544.67"",""DMax"":""3.33"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.62"",""C99"":""3.21""},{""PointId"":""d1_10hah19ct148k"",""Description"":""中温（分隔屏）过热器水冷壁41号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""587.68"",""TMin"":""504.92"",""TAvg"":""548.15"",""DMax"":""4.54"",""DMin"":""0.00"",""DAvg"":""1.02"",""C95"":""3.48"",""C99"":""4.26""},{""PointId"":""d1_10hah19ct149k"",""Description"":""中温（分隔屏）过热器水冷壁42号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""576.77"",""TMin"":""494.64"",""TAvg"":""538.00"",""DMax"":""3.89"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.87"",""C99"":""3.51""},{""PointId"":""d1_10hah19ct150k"",""Description"":""中温（分隔屏）过热器水冷壁42号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""575.58"",""TMin"":""490.96"",""TAvg"":""536.95"",""DMax"":""3.64"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.07"",""C99"":""3.76""},{""PointId"":""d1_10hah19ct151k"",""Description"":""中温（分隔屏）过热器水冷壁42号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""576.12"",""TMin"":""490.46"",""TAvg"":""537.54"",""DMax"":""4.07"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.93"",""C99"":""3.59""},{""PointId"":""d1_10hah19ct152k"",""Description"":""中温（分隔屏）过热器水冷壁42号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""580.80"",""TMin"":""497.82"",""TAvg"":""541.22"",""DMax"":""2.34"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""1.28"",""C99"":""1.57""},{""PointId"":""d1_10hah19ct153k"",""Description"":""中温（分隔屏）过热器水冷壁42号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""584.62"",""TMin"":""502.20"",""TAvg"":""545.77"",""DMax"":""4.08"",""DMin"":""0.00"",""DAvg"":""0.86"",""C95"":""2.92"",""C99"":""3.58""},{""PointId"":""d1_10hah19ct154k"",""Description"":""中温（分隔屏）过热器水冷壁42号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""584.20"",""TMin"":""502.06"",""TAvg"":""545.44"",""DMax"":""4.97"",""DMin"":""0.00"",""DAvg"":""0.98"",""C95"":""3.36"",""C99"":""4.11""},{""PointId"":""d1_10hah19ct155k"",""Description"":""中温（分隔屏）过热器水冷壁43号屏1号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""576.15"",""TMin"":""493.00"",""TAvg"":""537.03"",""DMax"":""4.64"",""DMin"":""0.00"",""DAvg"":""0.87"",""C95"":""2.95"",""C99"":""3.61""},{""PointId"":""d1_10hah19ct156k"",""Description"":""中温（分隔屏）过热器水冷壁43号屏2号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""574.95"",""TMin"":""490.45"",""TAvg"":""536.12"",""DMax"":""3.46"",""DMin"":""0.00"",""DAvg"":""0.88"",""C95"":""3.03"",""C99"":""3.70""},{""PointId"":""d1_10hah19ct157k"",""Description"":""中温（分隔屏）过热器水冷壁43号屏3号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""573.70"",""TMin"":""488.12"",""TAvg"":""535.08"",""DMax"":""4.71"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.30"",""C99"":""4.05""},{""PointId"":""d1_10hah19ct158k"",""Description"":""中温（分隔屏）过热器水冷壁43号屏4号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""583.22"",""TMin"":""500.88"",""TAvg"":""543.65"",""DMax"":""2.17"",""DMin"":""0.00"",""DAvg"":""0.46"",""C95"":""1.58"",""C99"":""1.94""},{""PointId"":""d1_10hah19ct159k"",""Description"":""中温（分隔屏）过热器水冷壁43号屏5号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""584.93"",""TMin"":""503.16"",""TAvg"":""546.14"",""DMax"":""4.53"",""DMin"":""0.00"",""DAvg"":""0.92"",""C95"":""3.15"",""C99"":""3.85""},{""PointId"":""d1_10hah19ct160k"",""Description"":""中温（分隔屏）过热器水冷壁43号屏6号管壁温"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":20,""type"":null,""TMax"":""585.98"",""TMin"":""504.14"",""TAvg"":""546.78"",""DMax"":""4.92"",""DMin"":""0.00"",""DAvg"":""0.95"",""C95"":""3.28"",""C99"":""4.02""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 17:28:13"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[501.62,502.1,496.36,491.34,491.86,501.3,501.56,504.92,494.64,490.96,490.46,497.82,502.2,502.06,493.0,490.45,488.117,500.883,503.16,504.14],""Train_X_max"":[584.05,583.8,578.317,575.617,578.05,584.117,584.55,587.683,576.767,575.583,576.117,580.8,584.617,584.2,576.15,574.95,573.7,583.217,584.933,585.983],""Train_X_std"":[10.551,10.429,10.293,10.444,10.561,10.51,10.514,10.509,10.222,10.365,10.443,10.482,10.408,10.348,10.245,10.343,10.437,10.408,10.333,10.333],""Train_X_mean"":[544.312,544.495,539.17,536.573,538.727,544.226,544.672,548.15,537.997,536.954,537.542,541.215,545.769,545.444,537.026,536.118,535.075,543.645,546.136,546.775],""Train_X_bais_max"":[[3.114,3.363,2.97,3.166,4.241,2.474,3.327,4.539,3.885,3.636,4.067,2.341,4.08,4.974,4.638,3.461,4.712,2.169,4.534,4.924]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.554,0.735,0.759,0.815,0.837,0.45,0.766,1.024,0.84,0.896,0.841,0.361,0.86,0.979,0.87,0.882,0.953,0.458,0.918,0.946]],""QCUL_95"":0.6341231,""QCUL_99"":1.13473439,""QCUL_95_line"":[1.918,2.557,2.574,2.8,2.863,1.559,2.62,3.481,2.868,3.069,2.929,1.275,2.924,3.357,2.952,3.026,3.304,1.582,3.147,3.282],""QCUL_99_line"":[2.349,3.133,3.149,3.428,3.504,1.91,3.206,4.258,3.51,3.756,3.589,1.565,3.577,4.109,3.61,3.704,4.047,1.937,3.852,4.021],""T2CUL_95"":3.844,""T2CUL_99"":6.64,""T2CUL_95_line"":[0.27,0.267,0.263,0.267,0.27,0.269,0.269,0.269,0.261,0.265,0.267,0.268,0.266,0.264,0.262,0.264,0.267,0.266,0.264,0.264],""T2CUL_99_line"":[0.354,0.35,0.346,0.351,0.355,0.353,0.353,0.353,0.343,0.348,0.351,0.352,0.35,0.348,0.344,0.347,0.351,0.35,0.347,0.347],""Kesi_95"":1.561,""Kesi_99"":1.332,""Kesi_95_line"":[0.172,0.17,0.168,0.17,0.172,0.171,0.171,0.171,0.166,0.169,0.17,0.171,0.17,0.169,0.167,0.168,0.17,0.17,0.168,0.168],""Kesi_99_line"":[0.159,0.157,0.155,0.157,0.159,0.158,0.158,0.158,0.154,0.156,0.157,0.158,0.157,0.156,0.154,0.156,0.157,0.157,0.155,0.155],""COV"":[[1.0,0.999,0.99,0.99,0.991,0.999,0.999,0.996,0.988,0.987,0.989,0.999,0.996,0.995,0.988,0.987,0.987,0.998,0.995,0.995],[0.999,1.0,0.987,0.984,0.985,0.998,0.999,0.999,0.984,0.982,0.983,0.997,0.998,0.998,0.983,0.982,0.98,0.997,0.998,0.998],[0.99,0.987,1.0,0.999,0.997,0.992,0.986,0.981,1.0,0.998,0.996,0.993,0.984,0.981,0.999,0.997,0.995,0.991,0.982,0.982],[0.99,0.984,0.999,1.0,0.999,0.991,0.984,0.978,0.998,1.0,0.999,0.992,0.981,0.978,0.998,0.999,0.998,0.989,0.979,0.978],[0.991,0.985,0.997,0.999,1.0,0.991,0.985,0.978,0.997,0.999,0.999,0.993,0.982,0.978,0.997,0.998,0.999,0.99,0.98,0.978],[0.999,0.998,0.992,0.991,0.991,1.0,0.999,0.996,0.99,0.989,0.99,1.0,0.997,0.995,0.989,0.989,0.988,0.999,0.995,0.995],[0.999,0.999,0.986,0.984,0.985,0.999,1.0,0.998,0.983,0.982,0.983,0.997,0.998,0.997,0.982,0.982,0.981,0.998,0.997,0.997],[0.996,0.999,0.981,0.978,0.978,0.996,0.998,1.0,0.978,0.975,0.976,0.994,0.999,0.999,0.977,0.976,0.973,0.996,0.999,0.999],[0.988,0.984,1.0,0.998,0.997,0.99,0.983,0.978,1.0,0.998,0.997,0.992,0.981,0.978,1.0,0.998,0.997,0.989,0.98,0.979],[0.987,0.982,0.998,1.0,0.999,0.989,0.982,0.975,0.998,1.0,0.999,0.991,0.979,0.976,0.998,1.0,0.999,0.988,0.978,0.977],[0.989,0.983,0.996,0.999,0.999,0.99,0.983,0.976,0.997,0.999,1.0,0.993,0.981,0.977,0.997,0.999,1.0,0.99,0.979,0.978],[0.999,0.997,0.993,0.992,0.993,1.0,0.997,0.994,0.992,0.991,0.993,1.0,0.996,0.993,0.992,0.991,0.991,0.999,0.994,0.994],[0.996,0.998,0.984,0.981,0.982,0.997,0.998,0.999,0.981,0.979,0.981,0.996,1.0,1.0,0.98,0.98,0.978,0.998,1.0,0.999],[0.995,0.998,0.981,0.978,0.978,0.995,0.997,0.999,0.978,0.976,0.977,0.993,1.0,1.0,0.978,0.977,0.975,0.997,1.0,1.0],[0.988,0.983,0.999,0.998,0.997,0.989,0.982,0.977,1.0,0.998,0.997,0.992,0.98,0.978,1.0,0.998,0.997,0.989,0.979,0.979],[0.987,0.982,0.997,0.999,0.998,0.989,0.982,0.976,0.998,1.0,0.999,0.991,0.98,0.977,0.998,1.0,0.999,0.989,0.979,0.978],[0.987,0.98,0.995,0.998,0.999,0.988,0.981,0.973,0.997,0.999,1.0,0.991,0.978,0.975,0.997,0.999,1.0,0.988,0.977,0.976],[0.998,0.997,0.991,0.989,0.99,0.999,0.998,0.996,0.989,0.988,0.99,0.999,0.998,0.997,0.989,0.989,0.988,1.0,0.998,0.997],[0.995,0.998,0.982,0.979,0.98,0.995,0.997,0.999,0.98,0.978,0.979,0.994,1.0,1.0,0.979,0.979,0.977,0.998,1.0,1.0],[0.995,0.998,0.982,0.978,0.978,0.995,0.997,0.999,0.979,0.977,0.978,0.994,0.999,1.0,0.979,0.978,0.976,0.997,1.0,1.0]],""K"":1,""R"":0.991,""featValue"":[19.817,0.156,0.011,0.009,0.004,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.224,0.11,-0.347,-0.278,0.057,-0.378,0.059,-0.127,0.383,-0.081,-0.318,-0.048,-0.154,0.186,0.099,-0.231,0.007,0.054,-0.218,0.381],[-0.224,0.205,-0.091,-0.266,0.291,-0.39,0.004,-0.193,-0.14,0.23,0.127,-0.226,-0.052,0.142,-0.279,0.31,-0.104,0.009,0.243,-0.385],[-0.224,-0.186,0.312,-0.383,0.055,0.234,-0.202,0.173,0.186,0.282,0.155,-0.059,-0.109,0.203,0.406,0.068,0.058,0.417,-0.021,-0.044],[-0.224,-0.236,-0.034,-0.097,0.333,0.184,0.018,-0.18,0.256,-0.147,0.088,0.422,-0.198,-0.178,0.096,0.334,0.035,-0.439,0.195,0.099],[-0.224,-0.225,-0.336,0.041,0.098,-0.084,-0.376,0.127,0.136,-0.001,0.402,0.23,0.202,-0.206,-0.287,-0.379,0.019,0.158,-0.114,-0.173],[-0.224,0.091,-0.262,-0.195,-0.196,0.346,0.147,0.041,-0.129,-0.146,0.357,-0.132,0.336,0.437,0.005,0.091,-0.162,-0.292,-0.181,0.121],[-0.224,0.202,-0.286,-0.138,0.173,0.107,0.266,0.653,-0.234,0.111,-0.218,0.023,0.032,-0.33,0.118,0.0,0.122,-0.009,0.122,-0.003],[-0.223,0.294,0.086,-0.163,0.007,0.208,-0.185,-0.238,-0.524,-0.302,0.0,0.208,-0.426,-0.002,-0.035,-0.293,-0.006,0.13,-0.006,0.026],[-0.224,-0.226,0.319,-0.283,-0.273,-0.086,-0.091,0.065,-0.134,0.115,-0.34,0.173,0.191,0.079,-0.418,0.045,0.396,-0.221,-0.14,0.023],[-0.223,-0.261,0.045,0.132,0.325,0.131,0.234,-0.221,-0.159,-0.018,-0.382,0.121,0.307,-0.004,0.03,0.028,-0.39,0.25,-0.33,-0.175],[-0.223,-0.24,-0.164,0.284,-0.104,0.023,-0.393,0.015,-0.179,0.289,-0.277,-0.117,-0.028,0.213,0.148,-0.158,-0.255,-0.227,0.431,0.13],[-0.224,0.048,-0.225,-0.049,-0.475,0.089,0.107,-0.426,0.048,0.006,-0.034,0.003,0.262,-0.344,0.137,0.158,0.177,0.321,0.315,0.006],[-0.224,0.248,0.052,0.164,0.012,0.189,-0.278,0.05,0.333,-0.38,-0.272,-0.297,0.051,0.019,0.096,-0.007,0.177,-0.163,-0.06,-0.502],[-0.223,0.285,0.231,0.139,0.168,0.013,-0.3,-0.102,-0.038,0.21,0.115,-0.301,0.149,-0.408,-0.026,0.16,-0.053,-0.105,-0.298,0.448],[-0.223,-0.236,0.328,-0.187,-0.262,-0.279,0.159,0.186,0.041,-0.361,0.114,-0.223,-0.067,-0.294,0.016,-0.123,-0.466,-0.099,0.13,-0.016],[-0.223,-0.253,0.122,0.217,0.287,0.103,0.393,-0.133,-0.026,-0.042,0.162,-0.4,-0.046,0.085,-0.119,-0.33,0.428,0.029,0.189,0.135],[-0.223,-0.269,-0.19,0.355,-0.169,-0.274,-0.042,0.14,-0.243,-0.182,0.108,-0.052,-0.314,0.079,0.138,0.448,0.203,0.139,-0.313,-0.004],[-0.224,0.113,-0.011,0.187,-0.309,0.213,0.295,-0.041,0.239,0.472,0.043,0.058,-0.437,-0.073,-0.196,-0.11,-0.165,-0.122,-0.235,-0.208],[-0.223,0.262,0.189,0.3,0.002,0.042,0.034,0.246,0.239,-0.17,-0.017,0.242,0.05,0.265,-0.375,0.195,-0.139,0.35,0.288,0.265],[-0.223,0.273,0.266,0.224,-0.018,-0.394,0.149,-0.032,-0.058,0.111,0.185,0.374,0.249,0.131,0.449,-0.207,0.12,-0.18,0.001,-0.125]],""selectVec"":[[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.224],[-0.223],[-0.224],[-0.223],[-0.223],[-0.224],[-0.224],[-0.223],[-0.223],[-0.223],[-0.223],[-0.224],[-0.223],[-0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8534,""AfterCleanSamNum"":5886,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""99.1%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":453,""version"":""v-2025-12-04 17:28:13"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "," + IN20 + "]],\"Target_Data\":[[]]}";
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