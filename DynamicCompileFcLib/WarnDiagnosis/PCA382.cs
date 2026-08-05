using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA382")]
    [FCDisplay("PCA382")]
    public partial class PCA382 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机永磁调速装置导体温度反馈1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机永磁调速装置轴承温度反馈1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机永磁调速装置导体温度反馈2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机永磁调速装置轴承温度反馈2")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机永磁调速装置导体温度反馈3")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机永磁调速装置轴承温度反馈3")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机定子U相温度1")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机定子V相温度1")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机定子W相温度1")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机驱动端轴承温度")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机非驱动端轴承温度")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A驱动端轴承温度")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A非驱动端轴承温度")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机定子U相温度2")]
	    public LAExWarn IN14 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机定子V相温度2")]
	    public LAExWarn IN15 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("低加疏水泵A电机定子W相温度2")]
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

		public PCA382()
		{
			ModelID = 422;
			SysID = 4;
			FcType = enumType.Warn;
			FcName = "PCA382";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""422"",""name"":""PCA382"",""description"":""低加疏水泵A温度1"",""founder"":""admin"",""creatTime"":""2025-10-11 11:09:52"",""Modifier"":""admin"",""modifiedTime"":""2025-10-14 16:15:52"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-08-23 19:29:56"",""et"":""2025-09-16 20:57:20"",""duration"":2078844,""number"":6930,""filter"":599,""mode"":6331,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":509}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lcj71gf003xq01"",""Description"":""低加疏水泵A电机永磁调速装置导体温度反馈1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""86.75"",""TMin"":""35.01"",""TAvg"":""49.06"",""DMax"":""2.18"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.22"",""C99"":""1.49""},{""PointId"":""d1_10lcj71gf003xq04"",""Description"":""低加疏水泵A电机永磁调速装置轴承温度反馈1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""52.01"",""TMin"":""30.42"",""TAvg"":""37.63"",""DMax"":""1.59"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.63"",""C99"":""0.77""},{""PointId"":""d1_10lcj71gf003xq02"",""Description"":""低加疏水泵A电机永磁调速装置导体温度反馈2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""80.22"",""TMin"":""33.59"",""TAvg"":""46.82"",""DMax"":""0.98"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.63"",""C99"":""0.77""},{""PointId"":""d1_10lcj71gf003xq05"",""Description"":""低加疏水泵A电机永磁调速装置轴承温度反馈2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""51.00"",""TMin"":""29.67"",""TAvg"":""36.99"",""DMax"":""1.14"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.51"",""C99"":""0.63""},{""PointId"":""d1_10lcj71gf003xq03"",""Description"":""低加疏水泵A电机永磁调速装置导体温度反馈3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""69.25"",""TMin"":""29.49"",""TAvg"":""41.48"",""DMax"":""0.96"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.69"",""C99"":""0.84""},{""PointId"":""d1_10lcj71gf003xq06"",""Description"":""低加疏水泵A电机永磁调速装置轴承温度反馈3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""51.81"",""TMin"":""30.37"",""TAvg"":""37.54"",""DMax"":""1.62"",""DMin"":""0.00"",""DAvg"":""0.16"",""C95"":""0.57"",""C99"":""0.70""},{""PointId"":""d1_10lcj71ct101r"",""Description"":""低加疏水泵A电机定子U相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""86.32"",""TMin"":""52.68"",""TAvg"":""67.83"",""DMax"":""1.67"",""DMin"":""0.00"",""DAvg"":""0.22"",""C95"":""0.78"",""C99"":""0.95""},{""PointId"":""d1_10lcj71ct103r"",""Description"":""低加疏水泵A电机定子V相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""83.41"",""TMin"":""50.62"",""TAvg"":""65.50"",""DMax"":""2.05"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.72"",""C99"":""0.89""},{""PointId"":""d1_10lcj71ct105r"",""Description"":""低加疏水泵A电机定子W相温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""84.36"",""TMin"":""51.49"",""TAvg"":""66.37"",""DMax"":""1.69"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.69"",""C99"":""0.85""},{""PointId"":""d1_10lcj71ct107r"",""Description"":""低加疏水泵A电机驱动端轴承温度"",""Unit"":"""",""Upper"":""122"",""Lower"":""22"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""48.87"",""TMin"":""29.23"",""TAvg"":""38.87"",""DMax"":""2.64"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.21"",""C99"":""1.48""},{""PointId"":""d1_10lcj71ct108r"",""Description"":""低加疏水泵A电机非驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""42.59"",""TMin"":""23.91"",""TAvg"":""32.76"",""DMax"":""3.28"",""DMin"":""0.00"",""DAvg"":""0.41"",""C95"":""1.44"",""C99"":""1.77""},{""PointId"":""d1_10lcj71ct109r"",""Description"":""低加疏水泵A驱动端轴承温度"",""Unit"":"""",""Upper"":""122"",""Lower"":""22"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""37.89"",""TMin"":""25.58"",""TAvg"":""31.33"",""DMax"":""1.33"",""DMin"":""0.00"",""DAvg"":""0.18"",""C95"":""0.65"",""C99"":""0.79""},{""PointId"":""d1_10lcj71ct110r"",""Description"":""低加疏水泵A非驱动端轴承温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""45.60"",""TMin"":""31.40"",""TAvg"":""38.15"",""DMax"":""2.27"",""DMin"":""0.00"",""DAvg"":""0.26"",""C95"":""0.93"",""C99"":""1.15""},{""PointId"":""d1_10lcj71ct102r"",""Description"":""低加疏水泵A电机定子U相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":14,""type"":null,""TMax"":""85.86"",""TMin"":""52.35"",""TAvg"":""67.43"",""DMax"":""1.31"",""DMin"":""0.00"",""DAvg"":""0.22"",""C95"":""0.76"",""C99"":""0.94""},{""PointId"":""d1_10lcj71ct104r"",""Description"":""低加疏水泵A电机定子V相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":15,""type"":null,""TMax"":""84.88"",""TMin"":""51.81"",""TAvg"":""66.78"",""DMax"":""1.73"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.71"",""C99"":""0.87""},{""PointId"":""d1_10lcj71ct106r"",""Description"":""低加疏水泵A电机定子W相温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":16,""type"":null,""TMax"":""86.61"",""TMin"":""53.00"",""TAvg"":""68.18"",""DMax"":""2.79"",""DMin"":""0.00"",""DAvg"":""0.23"",""C95"":""0.82"",""C99"":""1.01""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-10-14 16:15:52"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[35.005,30.416,33.587,29.669,29.49,30.369,52.676,50.619,51.492,29.225,23.907,25.576,31.404,52.345,51.812,53.004],""Train_X_max"":[86.748,52.014,80.222,51.003,69.245,51.808,86.316,83.412,84.358,48.866,42.594,37.893,45.603,85.858,84.878,86.609],""Train_X_std"":[10.574,3.728,9.309,3.637,7.76,3.701,7.583,7.321,7.336,3.502,3.221,2.144,2.626,7.543,7.433,7.63],""Train_X_mean"":[49.058,37.634,46.815,36.989,41.477,37.54,67.827,65.5,66.371,38.868,32.762,31.327,38.148,67.431,66.775,68.178],""Train_X_bais_max"":[[2.178,1.588,0.983,1.136,0.956,1.616,1.674,2.046,1.687,2.636,3.281,1.33,2.274,1.305,1.731,2.787]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.347,0.176,0.179,0.144,0.195,0.157,0.223,0.201,0.194,0.343,0.409,0.18,0.258,0.219,0.201,0.227]],""QCUL_95"":0.290312052,""QCUL_99"":0.494376183,""QCUL_95_line"":[1.217,0.625,0.626,0.512,0.686,0.565,0.776,0.721,0.693,1.205,1.443,0.646,0.933,0.763,0.711,0.823],""QCUL_99_line"":[1.493,0.768,0.768,0.629,0.841,0.695,0.951,0.886,0.85,1.478,1.771,0.793,1.146,0.935,0.872,1.012],""T2CUL_95"":9.499,""T2CUL_99"":13.297,""T2CUL_95_line"":[0.41,0.144,0.361,0.141,0.301,0.143,0.294,0.284,0.284,0.136,0.125,0.083,0.102,0.292,0.288,0.296],""T2CUL_99_line"":[0.485,0.171,0.427,0.167,0.356,0.17,0.348,0.336,0.336,0.161,0.148,0.098,0.12,0.346,0.341,0.35],""Kesi_95"":1.596,""Kesi_99"":1.396,""Kesi_95_line"":[0.168,0.059,0.148,0.058,0.123,0.059,0.12,0.116,0.117,0.056,0.051,0.034,0.042,0.12,0.118,0.121],""Kesi_99_line"":[0.157,0.055,0.138,0.054,0.115,0.055,0.113,0.109,0.109,0.052,0.048,0.032,0.039,0.112,0.11,0.113],""COV"":[[1.0,0.698,0.996,0.678,0.991,0.695,-0.564,-0.559,-0.556,-0.118,-0.027,-0.208,-0.538,-0.563,-0.562,-0.568],[0.698,1.0,0.733,0.999,0.767,1.0,-0.097,-0.084,-0.083,0.435,0.531,0.323,-0.071,-0.094,-0.093,-0.105],[0.996,0.733,1.0,0.715,0.998,0.731,-0.515,-0.509,-0.507,-0.054,0.037,-0.149,-0.491,-0.514,-0.513,-0.52],[0.678,0.999,0.715,1.0,0.751,0.999,-0.06,-0.046,-0.046,0.469,0.563,0.358,-0.037,-0.057,-0.056,-0.069],[0.991,0.767,0.998,0.751,1.0,0.765,-0.48,-0.473,-0.471,-0.004,0.088,-0.099,-0.454,-0.478,-0.478,-0.485],[0.695,1.0,0.731,0.999,0.765,1.0,-0.088,-0.075,-0.074,0.444,0.54,0.332,-0.062,-0.085,-0.084,-0.096],[-0.564,-0.097,-0.515,-0.06,-0.48,-0.088,1.0,1.0,1.0,0.833,0.759,0.801,0.912,1.0,1.0,1.0],[-0.559,-0.084,-0.509,-0.046,-0.473,-0.075,1.0,1.0,1.0,0.841,0.768,0.809,0.911,1.0,1.0,0.999],[-0.556,-0.083,-0.507,-0.046,-0.471,-0.074,1.0,1.0,1.0,0.841,0.768,0.808,0.911,1.0,1.0,1.0],[-0.118,0.435,-0.054,0.469,-0.004,0.444,0.833,0.841,0.841,1.0,0.99,0.909,0.774,0.835,0.836,0.829],[-0.027,0.531,0.037,0.563,0.088,0.54,0.759,0.768,0.768,0.99,1.0,0.894,0.715,0.761,0.762,0.754],[-0.208,0.323,-0.149,0.358,-0.099,0.332,0.801,0.809,0.808,0.909,0.894,1.0,0.886,0.803,0.805,0.799],[-0.538,-0.071,-0.491,-0.037,-0.454,-0.062,0.912,0.911,0.911,0.774,0.715,0.886,1.0,0.911,0.912,0.913],[-0.563,-0.094,-0.514,-0.057,-0.478,-0.085,1.0,1.0,1.0,0.835,0.761,0.803,0.911,1.0,1.0,1.0],[-0.562,-0.093,-0.513,-0.056,-0.478,-0.084,1.0,1.0,1.0,0.836,0.762,0.805,0.912,1.0,1.0,1.0],[-0.568,-0.105,-0.52,-0.069,-0.485,-0.096,1.0,0.999,1.0,0.829,0.754,0.799,0.913,1.0,1.0,1.0]],""K"":4,""R"":0.994,""featValue"":[9.736,5.453,0.466,0.255,0.065,0.022,0.003,0.002,0.001,0.001,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.201,-0.306,-0.451,0.057,0.048,-0.005,0.63,0.449,-0.239,0.004,0.009,0.038,-0.011,-0.001,0.005,0.006],[-0.039,-0.413,0.321,-0.108,0.239,0.009,0.045,0.027,0.102,-0.17,-0.687,-0.04,0.337,-0.161,-0.012,0.008],[-0.185,-0.324,-0.445,0.059,0.024,-0.027,-0.176,-0.173,0.647,0.42,-0.031,0.01,0.006,0.014,-0.005,-0.003],[-0.027,-0.415,0.321,-0.106,0.192,0.061,-0.064,-0.1,-0.29,0.391,0.237,0.564,-0.035,0.214,-0.014,-0.008],[-0.173,-0.339,-0.41,0.066,0.004,0.015,-0.456,-0.314,-0.434,-0.429,0.024,-0.052,0.008,-0.016,0.002,-0.003],[-0.037,-0.414,0.316,-0.103,0.218,0.004,0.043,0.086,0.205,-0.206,0.469,-0.51,-0.306,-0.048,0.024,0.0],[0.318,-0.018,-0.139,-0.151,0.14,0.062,0.015,-0.014,0.093,-0.149,-0.163,0.244,-0.487,-0.128,-0.045,0.678],[0.318,-0.023,-0.125,-0.15,0.112,0.122,-0.009,-0.102,-0.261,0.404,0.144,-0.251,0.272,-0.606,0.237,0.102],[0.318,-0.023,-0.131,-0.153,0.124,0.083,0.016,-0.058,-0.134,0.168,-0.175,-0.389,0.068,0.721,0.259,0.11],[0.262,-0.239,0.007,-0.111,-0.457,-0.18,-0.448,0.644,-0.011,0.061,-0.021,0.014,0.024,-0.003,0.005,0.003],[0.239,-0.275,0.073,-0.083,-0.598,-0.361,0.382,-0.468,0.006,-0.049,0.001,-0.005,-0.012,-0.008,-0.002,-0.004],[0.264,-0.191,0.097,0.647,-0.226,0.639,0.051,-0.011,0.049,-0.024,-0.018,-0.004,-0.012,0.006,-0.003,0.0],[0.301,-0.024,0.005,0.619,0.367,-0.62,-0.041,0.03,-0.045,0.037,0.01,0.003,0.008,-0.006,0.004,-0.001],[0.318,-0.019,-0.136,-0.153,0.137,0.075,0.006,-0.029,-0.023,0.013,-0.238,0.076,-0.503,-0.117,0.047,-0.706],[0.318,-0.019,-0.136,-0.147,0.129,0.077,0.032,-0.019,0.016,-0.024,0.131,-0.065,0.248,0.072,-0.861,-0.062],[0.318,-0.014,-0.144,-0.144,0.142,0.057,0.068,0.039,0.315,-0.438,0.312,0.364,0.4,0.058,0.36,-0.12]],""selectVec"":[[-0.201,-0.306,-0.451,0.057],[-0.039,-0.413,0.321,-0.108],[-0.185,-0.324,-0.445,0.059],[-0.027,-0.415,0.321,-0.106],[-0.173,-0.339,-0.41,0.066],[-0.037,-0.414,0.316,-0.103],[0.318,-0.018,-0.139,-0.151],[0.318,-0.023,-0.125,-0.15],[0.318,-0.023,-0.131,-0.153],[0.262,-0.239,0.007,-0.111],[0.239,-0.275,0.073,-0.083],[0.264,-0.191,0.097,0.647],[0.301,-0.024,0.005,0.619],[0.318,-0.019,-0.136,-0.153],[0.318,-0.019,-0.136,-0.147],[0.318,-0.014,-0.144,-0.144]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6930,""AfterCleanSamNum"":6324,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""低加疏水泵A运行"",""alarmcondition"":""[d1_10lcj71gf003xq01]>35""},""copy"":false,""principal"":""4"",""precision"":""99.4%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":422,""version"":""v-2025-10-14 16:15:52"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "," + IN14 + "," + IN15 + "," + IN16 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>35))
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