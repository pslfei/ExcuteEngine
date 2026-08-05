using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA417")]
    [FCDisplay("PCA417")]
    public partial class PCA417 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("负荷大于350")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁47号屏3号管壁温")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁47号屏4号管壁温")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁47号屏5号管壁温")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁47号屏6号管壁温")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁48号屏1号管壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁48号屏2号管壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁48号屏3号管壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁48号屏4号管壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁48号屏5号管壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁48号屏6号管壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁49号屏1号管壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁49号屏2号管壁温")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁49号屏3号管壁温")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁49号屏4号管壁温")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁49号屏5号管壁温")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁49号屏6号管壁温")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁50号屏1号管壁温")]
	    public LAExWarn IN17 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁50号屏2号管壁温")]
	    public LAExWarn IN18 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("中温（分隔屏）过热器水冷壁50号屏3号管壁温")]
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

		public PCA417()
		{
			ModelID = 458;
			SysID = 46;
			FcType = enumType.Warn;
			FcName = "PCA417";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""458"",""name"":""PCA417"",""description"":""中温分隔屏过热器水冷壁19-81-99"",""founder"":""admin"",""creatTime"":""2025-12-09 09:55:49"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:00:35"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-09 14:49:30"",""et"":""2025-12-07 14:33:24"",""duration"":2418234,""number"":8061,""filter"":2637,""mode"":5424,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":2547}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hah19ct181k"",""Description"":""中温（分隔屏）过热器水冷壁47号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""570.35"",""TMin"":""483.65"",""TAvg"":""534.53"",""DMax"":""3.34"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.25"",""C99"":""2.75""},{""PointId"":""d1_10hah19ct182k"",""Description"":""中温（分隔屏）过热器水冷壁47号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""579.28"",""TMin"":""493.57"",""TAvg"":""542.53"",""DMax"":""2.18"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.82"",""C99"":""2.23""},{""PointId"":""d1_10hah19ct183k"",""Description"":""中温（分隔屏）过热器水冷壁47号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""578.32"",""TMin"":""492.57"",""TAvg"":""541.86"",""DMax"":""2.62"",""DMin"":""0.00"",""DAvg"":""0.67"",""C95"":""2.26"",""C99"":""2.77""},{""PointId"":""d1_10hah19ct184k"",""Description"":""中温（分隔屏）过热器水冷壁47号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""577.28"",""TMin"":""493.23"",""TAvg"":""541.46"",""DMax"":""3.89"",""DMin"":""0.00"",""DAvg"":""0.84"",""C95"":""2.89"",""C99"":""3.54""},{""PointId"":""d1_10hah19ct185k"",""Description"":""中温（分隔屏）过热器水冷壁48号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""573.07"",""TMin"":""489.36"",""TAvg"":""535.83"",""DMax"":""4.57"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.07"",""C99"":""3.76""},{""PointId"":""d1_10hah19ct186k"",""Description"":""中温（分隔屏）过热器水冷壁48号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""572.85"",""TMin"":""486.58"",""TAvg"":""536.25"",""DMax"":""3.48"",""DMin"":""0.00"",""DAvg"":""0.77"",""C95"":""2.59"",""C99"":""3.17""},{""PointId"":""d1_10hah19ct187k"",""Description"":""中温（分隔屏）过热器水冷壁48号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""571.00"",""TMin"":""483.88"",""TAvg"":""534.76"",""DMax"":""3.22"",""DMin"":""0.00"",""DAvg"":""0.80"",""C95"":""2.73"",""C99"":""3.35""},{""PointId"":""d1_10hah19ct188k"",""Description"":""中温（分隔屏）过热器水冷壁48号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""578.97"",""TMin"":""493.30"",""TAvg"":""541.57"",""DMax"":""2.37"",""DMin"":""0.00"",""DAvg"":""0.42"",""C95"":""1.46"",""C99"":""1.79""},{""PointId"":""d1_10hah19ct189k"",""Description"":""中温（分隔屏）过热器水冷壁48号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""579.97"",""TMin"":""494.62"",""TAvg"":""542.93"",""DMax"":""3.01"",""DMin"":""0.00"",""DAvg"":""0.63"",""C95"":""2.18"",""C99"":""2.67""},{""PointId"":""d1_10hah19ct190k"",""Description"":""中温（分隔屏）过热器水冷壁48号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""579.90"",""TMin"":""495.40"",""TAvg"":""542.97"",""DMax"":""4.10"",""DMin"":""0.00"",""DAvg"":""0.75"",""C95"":""2.59"",""C99"":""3.17""},{""PointId"":""d1_10hah19ct191k"",""Description"":""中温（分隔屏）过热器水冷壁49号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""571.43"",""TMin"":""487.23"",""TAvg"":""534.42"",""DMax"":""5.45"",""DMin"":""0.00"",""DAvg"":""0.89"",""C95"":""3.10"",""C99"":""3.80""},{""PointId"":""d1_10hah19ct192k"",""Description"":""中温（分隔屏）过热器水冷壁49号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""573.98"",""TMin"":""487.63"",""TAvg"":""537.31"",""DMax"":""2.26"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""2.17"",""C99"":""2.65""},{""PointId"":""d1_10hah19ct193k"",""Description"":""中温（分隔屏）过热器水冷壁49号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""573.33"",""TMin"":""486.68"",""TAvg"":""537.25"",""DMax"":""3.00"",""DMin"":""0.00"",""DAvg"":""0.53"",""C95"":""1.85"",""C99"":""2.27""},{""PointId"":""d1_10hah19ct194k"",""Description"":""中温（分隔屏）过热器水冷壁49号屏4号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""580.75"",""TMin"":""495.72"",""TAvg"":""543.51"",""DMax"":""2.63"",""DMin"":""0.00"",""DAvg"":""0.58"",""C95"":""2.01"",""C99"":""2.46""},{""PointId"":""d1_10hah19ct195k"",""Description"":""中温（分隔屏）过热器水冷壁49号屏5号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""581.18"",""TMin"":""496.72"",""TAvg"":""544.74"",""DMax"":""4.45"",""DMin"":""0.00"",""DAvg"":""0.97"",""C95"":""3.31"",""C99"":""4.05""},{""PointId"":""d1_10hah19ct196k"",""Description"":""中温（分隔屏）过热器水冷壁49号屏6号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""583.07"",""TMin"":""500.33"",""TAvg"":""547.26"",""DMax"":""7.19"",""DMin"":""0.00"",""DAvg"":""1.53"",""C95"":""5.21"",""C99"":""6.37""},{""PointId"":""d1_10hah19ct197k"",""Description"":""中温（分隔屏）过热器水冷壁50号屏1号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":17,""type"":null,""TMax"":""570.51"",""TMin"":""486.36"",""TAvg"":""534.27"",""DMax"":""6.06"",""DMin"":""0.00"",""DAvg"":""0.90"",""C95"":""3.10"",""C99"":""3.80""},{""PointId"":""d1_10hah19ct198k"",""Description"":""中温（分隔屏）过热器水冷壁50号屏2号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":18,""type"":null,""TMax"":""572.40"",""TMin"":""486.58"",""TAvg"":""536.83"",""DMax"":""3.72"",""DMin"":""0.00"",""DAvg"":""0.64"",""C95"":""2.23"",""C99"":""2.74""},{""PointId"":""d1_10hah19ct199k"",""Description"":""中温（分隔屏）过热器水冷壁50号屏3号管壁温"",""Unit"":"""",""Upper"":""650"",""Lower"":""350"",""dead"":true,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":19,""type"":null,""TMax"":""568.96"",""TMin"":""482.27"",""TAvg"":""533.61"",""DMax"":""3.91"",""DMin"":""0.00"",""DAvg"":""0.73"",""C95"":""2.54"",""C99"":""3.12""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:00:35"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[483.65,493.567,492.567,493.233,489.36,486.583,483.883,493.3,494.617,495.4,487.233,487.633,486.683,495.717,496.72,500.333,486.364,486.576,482.274],""Train_X_max"":[570.35,579.283,578.317,577.283,573.067,572.85,571.0,578.967,579.967,579.9,571.433,573.983,573.333,580.75,581.183,583.067,570.514,572.402,568.964],""Train_X_std"":[9.523,9.32,9.331,9.121,9.336,9.495,9.585,9.349,9.309,9.198,9.36,9.437,9.46,9.308,9.175,8.955,9.268,9.262,9.435],""Train_X_mean"":[534.525,542.533,541.86,541.456,535.831,536.252,534.758,541.565,542.931,542.965,534.417,537.314,537.25,543.506,544.739,547.258,534.27,536.83,533.611],""Train_X_bais_max"":[[3.341,2.18,2.624,3.888,4.568,3.483,3.218,2.365,3.014,4.096,5.446,2.258,3.004,2.632,4.451,7.187,6.064,3.715,3.906]],""Train_X_bais_min"":[[0.001,0.0,0.0,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.001,0.0,0.001,0.001,0.0,0.001]],""Train_X_bais_mean"":[[0.652,0.534,0.665,0.841,0.896,0.769,0.798,0.424,0.632,0.746,0.892,0.647,0.526,0.583,0.971,1.532,0.899,0.639,0.725]],""QCUL_95"":0.7103484,""QCUL_99"":1.27327538,""QCUL_95_line"":[2.248,1.824,2.261,2.889,3.074,2.593,2.733,1.463,2.181,2.589,3.104,2.171,1.848,2.005,3.307,5.209,3.104,2.232,2.541],""QCUL_99_line"":[2.754,2.232,2.766,3.537,3.763,3.17,3.346,1.791,2.672,3.171,3.803,2.653,2.266,2.455,4.047,6.372,3.802,2.736,3.115],""T2CUL_95"":3.844,""T2CUL_99"":6.641,""T2CUL_95_line"":[0.254,0.248,0.249,0.243,0.249,0.253,0.255,0.249,0.248,0.245,0.249,0.251,0.252,0.248,0.244,0.239,0.247,0.247,0.251],""T2CUL_99_line"":[0.333,0.326,0.327,0.319,0.327,0.332,0.336,0.327,0.326,0.322,0.328,0.33,0.331,0.326,0.321,0.314,0.324,0.324,0.33],""Kesi_95"":1.558,""Kesi_99"":1.321,""Kesi_95_line"":[0.161,0.158,0.158,0.155,0.158,0.161,0.163,0.159,0.158,0.156,0.159,0.16,0.16,0.158,0.156,0.152,0.157,0.157,0.16],""Kesi_99_line"":[0.149,0.146,0.146,0.142,0.146,0.148,0.15,0.146,0.145,0.144,0.146,0.147,0.148,0.145,0.143,0.14,0.145,0.145,0.147],""COV"":[[1.0,0.992,0.989,0.984,0.994,0.997,0.999,0.992,0.988,0.984,0.993,0.997,0.999,0.989,0.98,0.961,0.994,0.997,0.999],[0.992,1.0,0.999,0.997,0.984,0.987,0.987,0.999,0.998,0.997,0.984,0.989,0.992,0.999,0.996,0.985,0.984,0.99,0.989],[0.989,0.999,1.0,0.999,0.981,0.985,0.985,0.998,0.999,0.998,0.981,0.987,0.99,0.997,0.997,0.986,0.981,0.986,0.986],[0.984,0.997,0.999,1.0,0.975,0.979,0.978,0.996,0.998,0.999,0.975,0.982,0.985,0.997,0.998,0.992,0.974,0.982,0.98],[0.994,0.984,0.981,0.975,1.0,0.998,0.996,0.988,0.983,0.979,1.0,0.998,0.994,0.984,0.972,0.95,0.999,0.994,0.994],[0.997,0.987,0.985,0.979,0.998,1.0,0.999,0.99,0.985,0.982,0.998,1.0,0.997,0.986,0.975,0.955,0.998,0.997,0.997],[0.999,0.987,0.985,0.978,0.996,0.999,1.0,0.989,0.984,0.98,0.995,0.999,0.999,0.985,0.975,0.954,0.996,0.997,0.999],[0.992,0.999,0.998,0.996,0.988,0.99,0.989,1.0,0.999,0.998,0.988,0.992,0.993,0.999,0.996,0.984,0.986,0.991,0.989],[0.988,0.998,0.999,0.998,0.983,0.985,0.984,0.999,1.0,0.999,0.982,0.987,0.989,0.999,0.998,0.988,0.981,0.986,0.985],[0.984,0.997,0.998,0.999,0.979,0.982,0.98,0.998,0.999,1.0,0.979,0.984,0.986,0.998,0.998,0.992,0.978,0.984,0.981],[0.993,0.984,0.981,0.975,1.0,0.998,0.995,0.988,0.982,0.979,1.0,0.997,0.994,0.984,0.971,0.95,0.999,0.994,0.994],[0.997,0.989,0.987,0.982,0.998,1.0,0.999,0.992,0.987,0.984,0.997,1.0,0.999,0.989,0.979,0.961,0.997,0.999,0.997],[0.999,0.992,0.99,0.985,0.994,0.997,0.999,0.993,0.989,0.986,0.994,0.999,1.0,0.991,0.983,0.966,0.994,0.998,0.999],[0.989,0.999,0.997,0.997,0.984,0.986,0.985,0.999,0.999,0.998,0.984,0.989,0.991,1.0,0.997,0.988,0.983,0.988,0.987],[0.98,0.996,0.997,0.998,0.972,0.975,0.975,0.996,0.998,0.998,0.971,0.979,0.983,0.997,1.0,0.995,0.971,0.979,0.977],[0.961,0.985,0.986,0.992,0.95,0.955,0.954,0.984,0.988,0.992,0.95,0.961,0.966,0.988,0.995,1.0,0.95,0.964,0.958],[0.994,0.984,0.981,0.974,0.999,0.998,0.996,0.986,0.981,0.978,0.999,0.997,0.994,0.983,0.971,0.95,1.0,0.996,0.996],[0.997,0.99,0.986,0.982,0.994,0.997,0.997,0.991,0.986,0.984,0.994,0.999,0.998,0.988,0.979,0.964,0.996,1.0,0.998],[0.999,0.989,0.986,0.98,0.994,0.997,0.999,0.989,0.985,0.981,0.994,0.997,0.999,0.987,0.977,0.958,0.996,0.998,1.0]],""K"":1,""R"":0.989,""featValue"":[18.79,0.171,0.017,0.011,0.005,0.004,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.23,0.154,0.364,0.223,0.063,0.083,0.186,0.428,0.028,-0.084,0.105,-0.112,-0.39,-0.326,-0.312,-0.265,-0.031,0.203,-0.115],[-0.23,-0.133,0.112,0.237,0.265,0.277,0.46,-0.019,0.099,-0.196,-0.063,0.064,0.105,0.046,-0.055,0.265,0.136,-0.468,0.35],[-0.23,-0.175,0.064,0.4,0.191,-0.253,-0.01,-0.083,0.26,-0.098,-0.081,-0.461,0.311,0.048,0.241,0.06,-0.049,0.137,-0.409],[-0.229,-0.262,0.006,0.166,0.135,-0.469,0.164,0.097,0.01,0.334,-0.183,0.502,-0.126,0.246,0.075,-0.196,-0.164,0.114,0.136],[-0.229,0.25,-0.421,0.001,-0.094,-0.022,0.065,0.353,0.109,-0.465,0.221,0.343,0.214,-0.067,0.321,-0.049,0.041,0.131,-0.022],[-0.23,0.223,-0.074,-0.017,-0.355,-0.132,0.241,-0.247,0.168,0.353,0.085,0.163,0.051,-0.314,-0.083,-0.006,0.102,-0.398,-0.406],[-0.229,0.225,0.248,0.117,-0.334,-0.077,-0.137,0.142,-0.088,0.168,0.426,-0.196,0.07,0.298,0.123,0.183,-0.406,-0.157,0.277],[-0.23,-0.105,-0.147,0.145,-0.1,0.326,0.157,-0.286,-0.041,0.266,0.324,0.01,0.208,0.107,-0.208,-0.032,0.256,0.558,0.133],[-0.23,-0.183,-0.122,0.241,-0.189,-0.038,-0.328,-0.234,0.0,-0.283,0.107,0.082,-0.618,0.189,-0.012,0.213,0.249,-0.078,-0.11],[-0.23,-0.233,-0.155,0.021,-0.089,-0.28,0.013,-0.056,-0.725,-0.183,-0.002,-0.185,0.173,-0.282,-0.131,-0.168,0.015,-0.133,0.11],[-0.229,0.251,-0.443,0.004,0.143,0.07,-0.084,0.227,0.01,0.394,-0.25,-0.402,-0.219,0.027,0.198,-0.102,0.258,-0.103,0.223],[-0.23,0.183,0.0,-0.167,-0.309,-0.098,0.177,-0.183,0.096,-0.169,-0.531,-0.081,-0.079,-0.141,-0.079,0.364,-0.243,0.348,0.212],[-0.23,0.129,0.305,-0.077,-0.226,0.135,-0.178,0.218,-0.151,-0.06,-0.39,0.107,0.288,0.44,-0.161,-0.123,0.356,-0.058,-0.212],[-0.23,-0.163,-0.084,-0.025,0.01,0.6,0.003,-0.104,-0.198,0.042,-0.163,0.083,-0.111,0.018,0.278,-0.187,-0.509,-0.053,-0.284],[-0.229,-0.306,-0.012,-0.047,-0.102,0.083,-0.513,0.02,0.46,-0.01,-0.053,0.046,0.203,-0.297,-0.215,-0.247,-0.099,-0.127,0.302],[-0.226,-0.481,0.036,-0.606,-0.007,-0.027,0.137,0.34,0.06,0.104,0.186,-0.127,-0.071,0.009,0.052,0.317,0.102,0.039,-0.169],[-0.229,0.265,-0.261,-0.162,0.496,-0.076,-0.16,-0.063,-0.022,-0.034,0.094,0.048,0.054,0.194,-0.553,0.172,-0.274,-0.049,-0.188],[-0.23,0.159,0.219,-0.426,0.15,-0.128,0.145,-0.419,0.132,-0.234,0.146,-0.144,-0.12,0.176,0.189,-0.487,0.079,-0.026,0.133],[-0.23,0.194,0.362,-0.041,0.354,0.023,-0.339,-0.123,-0.205,0.156,0.025,0.258,0.056,-0.372,0.332,0.293,0.182,0.119,0.039]],""selectVec"":[[-0.23],[-0.23],[-0.23],[-0.229],[-0.229],[-0.23],[-0.229],[-0.23],[-0.23],[-0.23],[-0.229],[-0.23],[-0.23],[-0.23],[-0.229],[-0.226],[-0.229],[-0.23],[-0.23]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8061,""AfterCleanSamNum"":5417,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""负荷大于350"",""alarmcondition"":""[d1_mw]>350""},""copy"":false,""principal"":""1"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":458,""version"":""v-2025-12-09 10:00:35"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "," + IN17 + "," + IN18 + "," + IN19 + "]],\"Target_Data\":[[]]}";
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