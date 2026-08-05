using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA387")]
    [FCDisplay("PCA387")]
    public partial class PCA387 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B推力轴承温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机上轴承温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机下轴承温度1")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机定子绕组线圈温度1")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机定子绕组线圈温度2")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B推力轴承温度2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机上轴承温度2")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机下轴承温度2")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机定子绕组线圈温度5")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机定子绕组线圈温度6")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机定子绕组线圈温度3")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("凝结水泵B电机定子绕组线圈温度4")]
	    public LAExWarn IN12 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[12] {false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[12] {false,false,false,false,false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[12] {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA387()
		{
			ModelID = 427;
			SysID = 8;
			FcType = enumType.Warn;
			FcName = "PCA387";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""427"",""name"":""PCA387"",""description"":""凝泵B轴承温度"",""founder"":""admin"",""creatTime"":""2025-10-27 15:18:10"",""Modifier"":""admin"",""modifiedTime"":""2025-10-27 15:20:28"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-08-06 15:57:42"",""et"":""2025-08-14 15:27:57"",""duration"":689415,""number"":2299,""filter"":90,""mode"":2209,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-08-27 13:54:15"",""et"":""2025-09-17 09:49:51"",""duration"":1799736,""number"":6000,""filter"":3011,""mode"":2989,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":2893}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10lcb12ct101r"",""Description"":""凝结水泵B推力轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""60.26"",""TMin"":""31.94"",""TAvg"":""54.20"",""DMax"":""4.06"",""DMin"":""0.00"",""DAvg"":""0.50"",""C95"":""1.75"",""C99"":""2.14""},{""PointId"":""d1_10lcb12ct103r"",""Description"":""凝结水泵B电机上轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""47.98"",""TMin"":""27.83"",""TAvg"":""39.21"",""DMax"":""1.01"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.84"",""C99"":""1.03""},{""PointId"":""d1_10lcb12ct105r"",""Description"":""凝结水泵B电机下轴承温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""45.72"",""TMin"":""26.09"",""TAvg"":""36.60"",""DMax"":""1.39"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.51"",""C99"":""0.63""},{""PointId"":""d1_10lcb12ct107r"",""Description"":""凝结水泵B电机定子绕组线圈温度1"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""75.23"",""TMin"":""32.11"",""TAvg"":""57.51"",""DMax"":""0.75"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10lcb12ct108r"",""Description"":""凝结水泵B电机定子绕组线圈温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""74.30"",""TMin"":""32.27"",""TAvg"":""56.62"",""DMax"":""0.78"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10lcb12ct102r"",""Description"":""凝结水泵B推力轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""45.91"",""TMin"":""28.97"",""TAvg"":""41.07"",""DMax"":""2.84"",""DMin"":""0.00"",""DAvg"":""0.35"",""C95"":""1.24"",""C99"":""1.52""},{""PointId"":""d1_10lcb12ct104r"",""Description"":""凝结水泵B电机上轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""47.74"",""TMin"":""27.60"",""TAvg"":""38.90"",""DMax"":""1.14"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""0.85"",""C99"":""1.04""},{""PointId"":""d1_10lcb12ct106r"",""Description"":""凝结水泵B电机下轴承温度2"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""45.46"",""TMin"":""25.72"",""TAvg"":""36.34"",""DMax"":""1.41"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.53"",""C99"":""0.65""},{""PointId"":""d1_10lcb12ct111r"",""Description"":""凝结水泵B电机定子绕组线圈温度5"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""74.03"",""TMin"":""32.20"",""TAvg"":""56.48"",""DMax"":""0.58"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.27"",""C99"":""0.33""},{""PointId"":""d1_10lcb12ct112r"",""Description"":""凝结水泵B电机定子绕组线圈温度6"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""74.68"",""TMin"":""32.18"",""TAvg"":""57.17"",""DMax"":""0.61"",""DMin"":""0.00"",""DAvg"":""0.03"",""C95"":""0.14"",""C99"":""0.17""},{""PointId"":""d1_10lcb12ct109r"",""Description"":""凝结水泵B电机定子绕组线圈温度3"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""74.59"",""TMin"":""32.27"",""TAvg"":""57.27"",""DMax"":""1.07"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.36"",""C99"":""0.45""},{""PointId"":""d1_10lcb12ct110r"",""Description"":""凝结水泵B电机定子绕组线圈温度4"",""Unit"":"""",""Upper"":""0"",""Lower"":""0"",""dead"":false,""limit"":null,""Lock"":false,""upperBound"":""0"",""lowerBound"":""0"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""74.19"",""TMin"":""31.92"",""TAvg"":""56.46"",""DMax"":""0.75"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.22"",""C99"":""0.27""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-10-27 15:20:28"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[31.937,27.827,26.09,32.11,32.271,28.97,27.6,25.721,32.198,32.18,32.271,31.918],""Train_X_max"":[60.258,47.98,45.723,75.23,74.304,45.913,47.735,45.457,74.031,74.682,74.585,74.189],""Train_X_std"":[2.968,3.786,3.881,5.889,5.731,1.73,3.775,3.893,5.721,5.802,5.812,5.76],""Train_X_mean"":[54.199,39.211,36.599,57.505,56.624,41.074,38.895,36.337,56.482,57.174,57.271,56.457],""Train_X_bais_max"":[[4.059,1.008,1.389,0.751,0.781,2.838,1.139,1.41,0.577,0.607,1.07,0.745]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.495,0.244,0.143,0.063,0.079,0.352,0.247,0.146,0.069,0.034,0.094,0.055]],""QCUL_95"":0.480950028,""QCUL_99"":0.8512025,""QCUL_95_line"":[1.748,0.843,0.51,0.248,0.297,1.239,0.853,0.526,0.265,0.136,0.364,0.222],""QCUL_99_line"":[2.144,1.032,0.626,0.306,0.366,1.519,1.044,0.647,0.327,0.168,0.45,0.274],""T2CUL_95"":7.824,""T2CUL_99"":11.362,""T2CUL_95_line"":[0.114,0.146,0.15,0.227,0.221,0.067,0.145,0.15,0.22,0.224,0.224,0.222],""T2CUL_99_line"":[0.138,0.176,0.18,0.273,0.266,0.08,0.175,0.181,0.266,0.269,0.27,0.267],""Kesi_95"":1.597,""Kesi_99"":1.399,""Kesi_95_line"":[0.052,0.066,0.068,0.103,0.1,0.03,0.066,0.068,0.1,0.101,0.101,0.1],""Kesi_99_line"":[0.048,0.062,0.063,0.096,0.093,0.028,0.061,0.063,0.093,0.095,0.095,0.094],""COV"":[[1.0,0.225,0.158,0.332,0.331,0.814,0.231,0.161,0.338,0.336,0.334,0.334],[0.225,1.0,0.99,0.893,0.894,0.539,1.0,0.99,0.894,0.896,0.897,0.892],[0.158,0.99,1.0,0.867,0.87,0.514,0.99,1.0,0.869,0.87,0.871,0.867],[0.332,0.893,0.867,1.0,1.0,0.614,0.895,0.867,1.0,1.0,1.0,1.0],[0.331,0.894,0.87,1.0,1.0,0.62,0.896,0.871,1.0,1.0,0.999,1.0],[0.814,0.539,0.514,0.614,0.62,1.0,0.542,0.517,0.624,0.618,0.614,0.62],[0.231,1.0,0.99,0.895,0.896,0.542,1.0,0.99,0.896,0.897,0.899,0.894],[0.161,0.99,1.0,0.867,0.871,0.517,0.99,1.0,0.87,0.87,0.871,0.868],[0.338,0.894,0.869,1.0,1.0,0.624,0.896,0.87,1.0,1.0,0.999,1.0],[0.336,0.896,0.87,1.0,1.0,0.618,0.897,0.87,1.0,1.0,1.0,1.0],[0.334,0.897,0.871,1.0,0.999,0.614,0.899,0.871,0.999,1.0,1.0,0.999],[0.334,0.892,0.867,1.0,1.0,0.62,0.894,0.868,1.0,1.0,0.999,1.0]],""K"":3,""R"":0.989,""featValue"":[9.934,1.436,0.498,0.123,0.01,0.001,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[-0.115,0.753,0.13,-0.611,-0.173,0.005,-0.005,0.006,0.002,0.007,-0.001,-0.001],[-0.303,-0.144,0.331,-0.182,0.49,0.092,-0.551,0.156,-0.4,-0.025,0.083,-0.01],[-0.296,-0.189,0.385,0.036,-0.468,-0.085,0.405,0.106,-0.526,0.216,0.02,0.046],[-0.311,-0.007,-0.271,-0.012,0.034,-0.423,-0.119,0.064,0.105,0.536,-0.135,-0.561],[-0.312,-0.006,-0.262,0.029,-0.078,0.402,-0.082,0.408,0.168,0.314,-0.373,0.477],[-0.211,0.568,0.232,0.743,0.161,-0.018,0.004,-0.001,-0.004,-0.003,0.002,0.0],[-0.303,-0.14,0.328,-0.187,0.489,0.053,0.554,-0.133,0.413,0.032,-0.085,0.002],[-0.297,-0.186,0.385,0.044,-0.476,-0.04,-0.405,-0.123,0.521,-0.213,-0.013,-0.05],[-0.312,-0.001,-0.259,0.015,-0.062,0.424,0.033,-0.496,-0.26,-0.284,-0.395,-0.315],[-0.312,-0.005,-0.26,-0.011,0.016,-0.15,-0.082,-0.574,-0.031,0.229,0.448,0.471],[-0.312,-0.008,-0.258,-0.031,0.054,-0.58,0.091,0.226,-0.077,-0.58,-0.205,0.226],[-0.312,-0.004,-0.268,0.017,-0.063,0.316,0.155,0.366,0.089,-0.223,0.655,-0.286]],""selectVec"":[[-0.115,0.753,0.13],[-0.303,-0.144,0.331],[-0.296,-0.189,0.385],[-0.311,-0.007,-0.271],[-0.312,-0.006,-0.262],[-0.211,0.568,0.232],[-0.303,-0.14,0.328],[-0.297,-0.186,0.385],[-0.312,-0.001,-0.259],[-0.312,-0.005,-0.26],[-0.312,-0.008,-0.258],[-0.312,-0.004,-0.268]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":8298,""AfterCleanSamNum"":5270,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""凝结水泵B运行"",""alarmcondition"":""[d1_10lcb12ap001xq01]>5""},""copy"":false,""principal"":""3"",""precision"":""98.9%"",""rate"":""0.98"",""iter"":null,""layer"":null,""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":427,""version"":""v-2025-10-27 15:20:28"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[12] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8,IN9,IN10,IN11,IN12};
			float[] arrOUT_B = new float[12] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8,OUT_B9,OUT_B10,OUT_B11,OUT_B12};
			LD[] arrOUT_W = new LD[12] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8,OUT_W9,OUT_W10,OUT_W11,OUT_W12 };
			
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