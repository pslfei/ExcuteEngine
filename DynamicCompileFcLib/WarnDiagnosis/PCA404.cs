using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA404")]
    [FCDisplay("PCA404")]
    public partial class PCA404 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("汽机转速大于500")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承回油温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承左前上部温度#1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承右前上部温度#1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承左前下部温度#1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承右前下部温度#1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承左前上部温度#2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承右前上部温度#2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承左前下部温度#2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承右前下部温度#2")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承左前上部温度#3")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承右前上部温度#3")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承左前下部温度#3")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("#2轴承右前下部温度#3")]
	    public LAExWarn IN13 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[13] {false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[13] {false,false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[13] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA404()
		{
			ModelID = 445;
			SysID = 13;
			FcType = enumType.Warn;
			FcName = "PCA404";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""445"",""name"":""PCA404"",""description"":""#2轴承温度"",""founder"":""admin"",""creatTime"":""2025-12-04 16:20:51"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 16:23:08"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 19:26:44"",""et"":""2025-11-26 04:48:20"",""duration"":1156896,""number"":3857,""filter"":90,""mode"":3767,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10mav71ct103a"",""Description"":""#2轴承回油温度"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""64.81"",""TMin"":""60.56"",""TAvg"":""63.22"",""DMax"":""0.11"",""DMin"":""0.00"",""DAvg"":""0.02"",""C95"":""0.07"",""C99"":""0.09""},{""PointId"":""d1_10mad12ct111a"",""Description"":""#2轴承左前上部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""64.17"",""TMin"":""59.58"",""TAvg"":""61.04"",""DMax"":""1.11"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.62"",""C99"":""0.76""},{""PointId"":""d1_10mad12ct112a"",""Description"":""#2轴承右前上部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""65.75"",""TMin"":""63.02"",""TAvg"":""64.32"",""DMax"":""0.54"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.22"",""C99"":""0.27""},{""PointId"":""d1_10mad12ct113a"",""Description"":""#2轴承左前下部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""94.15"",""TMin"":""87.16"",""TAvg"":""91.51"",""DMax"":""0.63"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.33"",""C99"":""0.41""},{""PointId"":""d1_10mad12ct114a"",""Description"":""#2轴承右前下部温度#1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""60.86"",""TMin"":""56.08"",""TAvg"":""59.28"",""DMax"":""0.74"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.37"",""C99"":""0.45""},{""PointId"":""d1_10mad12ct111b"",""Description"":""#2轴承左前上部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""64.16"",""TMin"":""59.67"",""TAvg"":""61.14"",""DMax"":""0.77"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.51"",""C99"":""0.63""},{""PointId"":""d1_10mad12ct112b"",""Description"":""#2轴承右前上部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""65.83"",""TMin"":""63.38"",""TAvg"":""64.52"",""DMax"":""0.37"",""DMin"":""0.00"",""DAvg"":""0.05"",""C95"":""0.18"",""C99"":""0.23""},{""PointId"":""d1_10mad12ct113b"",""Description"":""#2轴承左前下部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""93.53"",""TMin"":""86.85"",""TAvg"":""91.24"",""DMax"":""0.50"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10mad12ct114b"",""Description"":""#2轴承右前下部温度#2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""60.60"",""TMin"":""56.25"",""TAvg"":""59.53"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.29"",""C99"":""0.36""},{""PointId"":""d1_10mad12ct111c"",""Description"":""#2轴承左前上部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""64.34"",""TMin"":""59.77"",""TAvg"":""61.20"",""DMax"":""0.73"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10mad12ct112c"",""Description"":""#2轴承右前上部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""66.15"",""TMin"":""63.71"",""TAvg"":""64.75"",""DMax"":""0.53"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.16"",""C99"":""0.20""},{""PointId"":""d1_10mad12ct113c"",""Description"":""#2轴承左前下部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""94.14"",""TMin"":""87.44"",""TAvg"":""91.77"",""DMax"":""0.60"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.32"",""C99"":""0.39""},{""PointId"":""d1_10mad12ct114c"",""Description"":""#2轴承右前下部温度#3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":13,""type"":null,""TMax"":""60.84"",""TMin"":""56.53"",""TAvg"":""59.71"",""DMax"":""0.63"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.27"",""C99"":""0.33""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 16:23:08"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[60.562,59.576,63.022,87.157,56.08,59.667,63.383,86.846,56.251,59.773,63.705,87.439,56.527],""Train_X_max"":[64.806,64.17,65.751,94.149,60.864,64.155,65.833,93.532,60.604,64.338,66.148,94.144,60.839],""Train_X_std"":[0.173,1.009,0.336,1.54,0.504,0.968,0.257,1.525,0.488,0.986,0.276,1.531,0.476],""Train_X_mean"":[63.219,61.04,64.322,91.509,59.283,61.144,64.523,91.236,59.53,61.202,64.745,91.767,59.713],""Train_X_bais_max"":[[0.105,1.109,0.54,0.63,0.737,0.774,0.372,0.497,0.574,0.726,0.529,0.597,0.625]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.022,0.173,0.057,0.092,0.099,0.149,0.05,0.089,0.085,0.144,0.039,0.091,0.075]],""QCUL_95"":1.42790091,""QCUL_99"":2.285865,""QCUL_95_line"":[0.074,0.62,0.217,0.331,0.367,0.511,0.184,0.312,0.293,0.49,0.161,0.318,0.267],""QCUL_99_line"":[0.091,0.761,0.268,0.406,0.452,0.625,0.226,0.382,0.358,0.599,0.2,0.39,0.328],""T2CUL_95"":7.828,""T2CUL_99"":11.37,""T2CUL_95_line"":[0.008,0.046,0.015,0.07,0.023,0.044,0.012,0.07,0.022,0.045,0.013,0.07,0.022],""T2CUL_99_line"":[0.01,0.055,0.018,0.085,0.028,0.053,0.014,0.084,0.027,0.054,0.015,0.084,0.026],""Kesi_95"":1.591,""Kesi_99"":1.411,""Kesi_95_line"":[0.004,0.021,0.007,0.032,0.01,0.02,0.005,0.031,0.01,0.02,0.006,0.031,0.01],""Kesi_99_line"":[0.003,0.02,0.006,0.03,0.01,0.019,0.005,0.03,0.009,0.019,0.005,0.03,0.009],""COV"":[[1.0,0.096,0.326,0.085,0.271,0.09,0.358,0.078,0.257,0.096,0.36,0.083,0.278],[0.096,1.0,0.619,-0.902,-0.682,0.989,0.601,-0.927,-0.789,0.991,0.633,-0.926,-0.772],[0.326,0.619,1.0,-0.296,-0.035,0.539,0.886,-0.359,-0.233,0.553,0.917,-0.349,-0.189],[0.085,-0.902,-0.296,1.0,0.919,-0.936,-0.362,0.996,0.94,-0.934,-0.397,0.996,0.938],[0.271,-0.682,-0.035,0.919,1.0,-0.742,-0.153,0.894,0.956,-0.74,-0.188,0.895,0.965],[0.09,0.989,0.539,-0.936,-0.742,1.0,0.585,-0.947,-0.808,0.997,0.6,-0.949,-0.803],[0.358,0.601,0.886,-0.362,-0.153,0.585,1.0,-0.384,-0.229,0.579,0.948,-0.388,-0.228],[0.078,-0.927,-0.359,0.996,0.894,-0.947,-0.384,1.0,0.943,-0.949,-0.431,0.999,0.933],[0.257,-0.789,-0.233,0.94,0.956,-0.808,-0.229,0.943,1.0,-0.816,-0.303,0.938,0.985],[0.096,0.991,0.553,-0.934,-0.74,0.997,0.579,-0.949,-0.816,1.0,0.62,-0.946,-0.796],[0.36,0.633,0.917,-0.397,-0.188,0.6,0.948,-0.431,-0.303,0.62,1.0,-0.417,-0.247],[0.083,-0.926,-0.349,0.996,0.895,-0.949,-0.388,0.999,0.938,-0.946,-0.417,1.0,0.938],[0.278,-0.772,-0.189,0.938,0.965,-0.803,-0.228,0.933,0.985,-0.796,-0.247,0.938,1.0]],""K"":3,""R"":0.961,""featValue"":[8.934,2.832,0.733,0.28,0.145,0.063,0.014,0.001,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.004,0.39,-0.862,-0.263,-0.173,0.064,-0.024,-0.017,0.002,-0.003,0.0,0.0,0.0],[-0.321,0.091,-0.058,0.42,-0.057,0.048,-0.26,-0.273,0.064,-0.72,-0.041,0.061,-0.182],[-0.172,0.465,0.299,0.109,-0.612,0.16,0.089,0.485,0.094,0.031,0.018,0.015,-0.015],[0.325,0.125,0.11,-0.007,-0.15,0.067,-0.434,-0.164,-0.001,-0.105,-0.1,-0.132,0.766],[0.282,0.275,0.02,0.49,-0.168,0.101,0.246,-0.57,-0.179,0.358,0.019,-0.008,-0.137],[-0.325,0.057,-0.107,0.308,0.234,0.074,-0.313,0.145,-0.107,0.286,0.663,-0.238,0.124],[-0.184,0.455,0.234,-0.278,0.481,0.493,0.038,-0.205,0.309,0.052,-0.1,-0.016,-0.012],[0.328,0.101,0.081,-0.082,0.042,0.088,-0.456,0.073,-0.1,0.055,0.215,0.724,-0.251],[0.304,0.209,-0.068,0.264,0.412,0.171,0.183,0.445,-0.5,-0.257,-0.186,-0.085,0.039],[-0.326,0.063,-0.104,0.296,0.145,-0.22,-0.307,0.12,0.035,0.415,-0.637,0.176,0.049],[-0.196,0.448,0.227,-0.291,0.087,-0.637,0.024,-0.178,-0.405,-0.081,0.094,0.004,0.024],[0.328,0.105,0.083,-0.086,-0.021,-0.106,-0.453,0.059,0.101,0.043,-0.12,-0.592,-0.519],[0.3,0.23,-0.064,0.272,0.234,-0.45,0.184,0.149,0.643,-0.082,0.167,0.091,0.095]],""selectVec"":[[0.004,0.39,-0.862],[-0.321,0.091,-0.058],[-0.172,0.465,0.299],[0.325,0.125,0.11],[0.282,0.275,0.02],[-0.325,0.057,-0.107],[-0.184,0.455,0.234],[0.328,0.101,0.081],[0.304,0.209,-0.068],[-0.326,0.063,-0.104],[-0.196,0.448,0.227],[0.328,0.105,0.083],[0.3,0.23,-0.064]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":3857,""AfterCleanSamNum"":3767,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""汽机转速大于500"",""alarmcondition"":""[d1_10cjj01yq03ai]>500""},""copy"":false,""principal"":""3"",""precision"":""96.1%"",""rate"":""0.95"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":445,""version"":""v-2025-12-04 16:23:08"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "," + IN13 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[13] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12,IN13};
			float[] arrOUT_B = new float[13] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12,OUT_B13};
			LD[] arrOUT_W = new LD[13] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12,OUT_W13 };
			
	        if (!(Condition1>500))
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