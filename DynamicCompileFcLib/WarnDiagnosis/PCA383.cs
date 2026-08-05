using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA383")]
    [FCDisplay("PCA383")]
    public partial class PCA383 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机永磁调速装置导体温度反馈1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机永磁调速装置轴承温度反馈1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机永磁调速装置导体温度反馈2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机永磁调速装置轴承温度反馈2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机永磁调速装置导体温度反馈3")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机永磁调速装置轴承温度反馈3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机定子U相温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机定子V相温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机定子W相温度1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机定子U相温度2")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机定子V相温度2")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机定子W相温度2")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机驱动端轴承温度")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B电机非驱动端轴承温度")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B驱动端轴承温度")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵B非驱动端轴承温度")]
	    public LAExWarn IN16 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[16] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[16] {false,false,false,false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[16] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA383()
		{
			ModelID = 423;
			SysID = 4;
			FcType = enumType.Warn;
			FcName = "PCA383";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""423"",""name"":""PCA383"",""description"":""低加疏水泵B温度"",""founder"":""admin"",""creatTime"":""2025-10-14 16:56:19"",""Modifier"":""admin"",""modifiedTime"":""2025-10-14 17:05:03"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-08-08 11:17:09"",""et"":""2025-08-10 09:44:33"",""duration"":167244,""number"":558,""filter"":234,""mode"":324,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":144},{""st"":""2025-08-22 09:59:06"",""et"":""2025-08-23 17:39:36"",""duration"":114030,""number"":381,""filter"":314,""mode"":67,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":224}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lcj72gf003xq01"",""Description"":""低加疏水泵B电机永磁调速装置导体温度反馈1"",""Unit"":"""",""Upper"":""65"",""Lower"":""22"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""61.42"",""TMin"":""38.80"",""TAvg"":""46.79"",""DMax"":""0.95"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.41"",""C99"":""0.50""},{""PointId"":""d1_10lcj72gf003xq04"",""Description"":""低加疏水泵B电机永磁调速装置轴承温度反馈1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""51.00"",""TMin"":""37.40"",""TAvg"":""45.76"",""DMax"":""0.26"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.19""},{""PointId"":""d1_10lcj72gf003xq02"",""Description"":""低加疏水泵B电机永磁调速装置导体温度反馈2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""65.77"",""TMin"":""40.20"",""TAvg"":""48.55"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.44""},{""PointId"":""d1_10lcj72gf003xq05"",""Description"":""低加疏水泵B电机永磁调速装置轴承温度反馈2"",""Unit"":"""",""Upper"":""65"",""Lower"":""22"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""54.08"",""TMin"":""40.02"",""TAvg"":""48.70"",""DMax"":""0.34"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.26"",""C99"":""0.32""},{""PointId"":""d1_10lcj72gf003xq03"",""Description"":""低加疏水泵B电机永磁调速装置导体温度反馈3"",""Unit"":"""",""Upper"":""65"",""Lower"":""25"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""64.77"",""TMin"":""38.08"",""TAvg"":""46.68"",""DMax"":""0.92"",""DMin"":""0.00"",""DAvg"":""0.13"",""C95"":""0.46"",""C99"":""0.57""},{""PointId"":""d1_10lcj72gf003xq06"",""Description"":""低加疏水泵B电机永磁调速装置轴承温度反馈3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""51.60"",""TMin"":""37.60"",""TAvg"":""46.19"",""DMax"":""0.37"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.24"",""C99"":""0.30""},{""PointId"":""d1_10lcj72ct101r"",""Description"":""低加疏水泵B电机定子U相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""89.71"",""TMin"":""36.04"",""TAvg"":""82.78"",""DMax"":""1.02"",""DMin"":""0.01"",""DAvg"":""0.32"",""C95"":""1.09"",""C99"":""1.33""},{""PointId"":""d1_10lcj72ct103r"",""Description"":""低加疏水泵B电机定子V相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""87.08"",""TMin"":""36.22"",""TAvg"":""80.33"",""DMax"":""0.89"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.03"",""C99"":""1.27""},{""PointId"":""d1_10lcj72ct105r"",""Description"":""低加疏水泵B电机定子W相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""89.35"",""TMin"":""35.98"",""TAvg"":""82.39"",""DMax"":""0.99"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.09"",""C99"":""1.34""},{""PointId"":""d1_10lcj72ct102r"",""Description"":""低加疏水泵B电机定子U相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""88.79"",""TMin"":""36.55"",""TAvg"":""81.94"",""DMax"":""0.95"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.06"",""C99"":""1.30""},{""PointId"":""d1_10lcj72ct104r"",""Description"":""低加疏水泵B电机定子V相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""88.05"",""TMin"":""36.26"",""TAvg"":""81.27"",""DMax"":""0.94"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""1.08"",""C99"":""1.32""},{""PointId"":""d1_10lcj72ct106r"",""Description"":""低加疏水泵B电机定子W相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""89.00"",""TMin"":""36.04"",""TAvg"":""82.09"",""DMax"":""1.02"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.10"",""C99"":""1.34""},{""PointId"":""d1_10lcj72ct107r"",""Description"":""低加疏水泵B电机驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""51.38"",""TMin"":""30.29"",""TAvg"":""47.38"",""DMax"":""1.86"",""DMin"":""0.00"",""DAvg"":""0.45"",""C95"":""1.61"",""C99"":""1.98""},{""PointId"":""d1_10lcj72ct108r"",""Description"":""低加疏水泵B电机非驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""43.27"",""TMin"":""30.24"",""TAvg"":""39.96"",""DMax"":""1.90"",""DMin"":""0.00"",""DAvg"":""0.39"",""C95"":""1.33"",""C99"":""1.62""},{""PointId"":""d1_10lcj72ct109r"",""Description"":""低加疏水泵B驱动端轴承温度"",""Unit"":"""",""Upper"":""86"",""Lower"":""25"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""79.51"",""TMin"":""31.49"",""TAvg"":""61.52"",""DMax"":""7.78"",""DMin"":""0.01"",""DAvg"":""1.25"",""C95"":""4.32"",""C99"":""5.29""},{""PointId"":""d1_10lcj72ct110r"",""Description"":""低加疏水泵B非驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""50.41"",""TMin"":""32.41"",""TAvg"":""48.34"",""DMax"":""2.81"",""DMin"":""0.00"",""DAvg"":""0.44"",""C95"":""1.56"",""C99"":""1.91""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-10-14 17:05:03"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[38.796,37.399,40.201,40.017,38.083,37.597,36.042,36.215,35.984,36.548,36.264,36.038,30.285,30.236,31.491,32.412],""Train_X_max"":[61.42,50.997,65.769,54.079,64.771,51.604,89.712,87.077,89.345,88.794,88.05,89.002,51.377,43.27,79.505,50.414],""Train_X_std"":[3.807,2.877,4.053,2.973,4.119,2.925,6.795,6.439,6.741,6.611,6.532,6.691,3.154,2.172,17.047,1.881],""Train_X_mean"":[46.79,45.762,48.545,48.704,46.679,46.189,82.784,80.331,82.389,81.943,81.273,82.086,47.376,39.959,61.522,48.342],""Train_X_bais_max"":[[0.945,0.255,0.665,0.344,0.917,0.371,1.016,0.893,0.99,0.948,0.94,1.016,1.859,1.901,7.78,2.806]],""Train_X_bais_min"":[[0.0,0.0,0.001,0.0,0.001,0.0,0.005,0.001,0.001,0.0,0.003,0.001,0.001,0.002,0.008,0.001]],""Train_X_bais_mean"":[[0.1,0.044,0.1,0.077,0.13,0.07,0.322,0.3,0.318,0.312,0.314,0.319,0.447,0.393,1.254,0.436]],""QCUL_95"":0.615913033,""QCUL_99"":0.972744942,""QCUL_95_line"":[0.405,0.157,0.357,0.261,0.463,0.241,1.09,1.034,1.091,1.061,1.076,1.098,1.613,1.327,4.318,1.555],""QCUL_99_line"":[0.501,0.193,0.438,0.319,0.569,0.295,1.333,1.267,1.335,1.297,1.318,1.344,1.982,1.622,5.287,1.909],""T2CUL_95"":9.728,""T2CUL_99"":13.696,""T2CUL_95_line"":[0.671,0.507,0.714,0.524,0.726,0.516,1.198,1.135,1.188,1.165,1.152,1.18,0.556,0.383,3.005,0.332],""T2CUL_99_line"":[0.796,0.602,0.848,0.622,0.862,0.612,1.421,1.347,1.41,1.383,1.366,1.4,0.66,0.454,3.566,0.393],""Kesi_95"":1.59,""Kesi_99"":1.423,""Kesi_95_line"":[0.271,0.205,0.289,0.212,0.294,0.208,0.484,0.459,0.48,0.471,0.466,0.477,0.225,0.155,1.215,0.134],""Kesi_99_line"":[0.257,0.194,0.273,0.2,0.278,0.197,0.458,0.434,0.455,0.446,0.44,0.451,0.213,0.146,1.149,0.127],""COV"":[[1.003,0.655,1.0,0.65,1.0,0.661,0.422,0.433,0.425,0.429,0.429,0.427,0.543,0.544,0.118,0.452],[0.655,1.003,0.661,1.003,0.647,1.003,0.384,0.401,0.391,0.391,0.397,0.393,0.499,0.642,-0.287,0.5],[1.0,0.661,1.003,0.655,1.003,0.667,0.406,0.417,0.409,0.413,0.413,0.411,0.533,0.544,0.062,0.437],[0.65,1.003,0.655,1.003,0.641,1.003,0.378,0.394,0.384,0.384,0.39,0.386,0.489,0.631,-0.28,0.492],[1.0,0.647,1.003,0.641,1.003,0.653,0.404,0.415,0.406,0.411,0.411,0.408,0.527,0.53,0.082,0.432],[0.661,1.003,0.667,1.003,0.653,1.003,0.39,0.406,0.397,0.397,0.402,0.399,0.503,0.641,-0.274,0.503],[0.422,0.384,0.406,0.378,0.404,0.39,1.003,1.003,1.003,1.003,1.003,1.003,0.96,0.874,0.157,0.928],[0.433,0.401,0.417,0.394,0.415,0.406,1.003,1.003,1.003,1.003,1.003,1.003,0.962,0.883,0.143,0.93],[0.425,0.391,0.409,0.384,0.406,0.397,1.003,1.003,1.003,1.003,1.003,1.003,0.96,0.878,0.149,0.929],[0.429,0.391,0.413,0.384,0.411,0.397,1.003,1.003,1.003,1.003,1.003,1.003,0.961,0.878,0.152,0.929],[0.429,0.397,0.413,0.39,0.411,0.402,1.003,1.003,1.003,1.003,1.003,1.003,0.96,0.88,0.146,0.93],[0.427,0.393,0.411,0.386,0.408,0.399,1.003,1.003,1.003,1.003,1.003,1.003,0.96,0.879,0.149,0.929],[0.543,0.499,0.533,0.489,0.527,0.503,0.96,0.962,0.96,0.961,0.96,0.96,1.003,0.951,0.07,0.897],[0.544,0.642,0.544,0.631,0.53,0.641,0.874,0.883,0.878,0.878,0.88,0.879,0.951,1.003,-0.185,0.841],[0.118,-0.287,0.062,-0.28,0.082,-0.274,0.157,0.143,0.149,0.152,0.146,0.149,0.07,-0.185,1.003,0.128],[0.452,0.5,0.437,0.492,0.432,0.503,0.928,0.93,0.929,0.929,0.93,0.929,0.897,0.841,0.128,1.003]],""K"":4,""R"":0.987,""featValue"":[10.551,3.23,1.476,0.582,0.118,0.079,0.013,0.002,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.209,0.311,0.372,0.195,-0.036,0.007,-0.191,0.79,-0.071,0.024,0.015,0.107,0.051,-0.024,0.01,0.0],[0.206,0.362,-0.232,-0.307,0.039,-0.046,0.009,0.02,0.229,0.401,-0.661,0.023,-0.147,0.039,0.029,-0.005],[0.206,0.324,0.347,0.253,-0.076,-0.023,0.057,-0.323,0.672,-0.31,0.045,-0.006,-0.052,0.006,-0.035,-0.007],[0.203,0.363,-0.231,-0.327,0.048,-0.09,0.024,-0.013,-0.324,-0.731,-0.075,0.008,0.105,-0.019,0.02,-0.004],[0.204,0.319,0.365,0.247,-0.087,-0.062,0.085,-0.444,-0.599,0.274,-0.061,-0.087,0.001,0.016,0.025,0.006],[0.207,0.36,-0.222,-0.316,0.049,-0.082,0.053,-0.012,0.102,0.347,0.728,-0.032,0.039,-0.019,-0.049,0.01],[0.286,-0.205,-0.008,0.007,0.0,-0.204,0.028,-0.092,0.001,0.039,0.006,0.749,0.264,0.437,0.021,0.045],[0.288,-0.195,-0.015,0.013,-0.007,-0.203,-0.084,0.071,0.017,-0.015,-0.049,-0.522,0.128,0.457,-0.49,0.291],[0.287,-0.201,-0.014,0.01,-0.004,-0.207,-0.035,-0.015,-0.052,-0.036,0.023,0.215,-0.473,-0.506,-0.178,0.52],[0.287,-0.2,-0.009,0.012,-0.005,-0.205,0.005,-0.027,0.096,0.087,-0.106,-0.152,0.685,-0.539,0.123,-0.094],[0.288,-0.198,-0.015,0.01,-0.011,-0.209,-0.077,0.041,0.023,-0.038,0.075,-0.272,-0.255,0.216,0.795,0.035],[0.287,-0.2,-0.013,0.01,-0.005,-0.21,-0.05,0.017,-0.046,-0.028,0.027,-0.003,-0.339,-0.065,-0.275,-0.795],[0.295,-0.11,-0.015,0.111,0.377,0.382,0.757,0.15,-0.017,-0.014,-0.011,-0.045,-0.037,0.015,0.005,0.002],[0.289,-0.012,-0.188,0.198,0.431,0.526,-0.591,-0.167,-0.021,0.005,0.023,0.024,0.028,-0.013,0.002,-0.005],[0.015,-0.189,0.643,-0.677,0.238,0.143,-0.098,-0.077,0.012,0.001,-0.004,-0.009,-0.004,0.0,-0.001,0.0],[0.282,-0.129,-0.046,-0.162,-0.771,0.529,0.012,-0.001,-0.014,-0.009,0.015,0.002,0.003,-0.002,-0.003,-0.001]],""selectVec"":[[0.209,0.311,0.372,0.195],[0.206,0.362,-0.232,-0.307],[0.206,0.324,0.347,0.253],[0.203,0.363,-0.231,-0.327],[0.204,0.319,0.365,0.247],[0.207,0.36,-0.222,-0.316],[0.286,-0.205,-0.008,0.007],[0.288,-0.195,-0.015,0.013],[0.287,-0.201,-0.014,0.01],[0.287,-0.2,-0.009,0.012],[0.288,-0.198,-0.015,0.01],[0.287,-0.2,-0.013,0.01],[0.295,-0.11,-0.015,0.111],[0.289,-0.012,-0.188,0.198],[0.015,-0.189,0.643,-0.677],[0.282,-0.129,-0.046,-0.162]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":938,""AfterCleanSamNum"":313,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""低加疏水泵B运行"",""alarmcondition"":""[d1_10lcj72ap001xq01]>5""},""copy"":false,""principal"":""4"",""precision"":""98.7%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":423,""version"":""v-2025-10-14 17:05:03"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[16] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13,IN14,IN15,IN16};
			float[] arrOUT_B = new float[16] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13,OUT_B14,OUT_B15,OUT_B16};
			LD[] arrOUT_W = new LD[16] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13,OUT_W14,OUT_W15,OUT_W16 };
			
	        if (!(Condition1>5))
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