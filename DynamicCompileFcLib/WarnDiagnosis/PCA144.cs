using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA144")]
    [FCDisplay("PCA144")]
    public partial class PCA144 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口风粉混合物温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E分离器风粉混合物温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E分离器风粉混合物温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E分离器风粉混合物温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E11侧燃烧器壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E12侧燃烧器壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E21侧燃烧器壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E22侧燃烧器壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E31侧燃烧器壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E32侧燃烧器壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E41侧燃烧器壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机E出口E42侧燃烧器壁温")]
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

		public PCA144()
		{
			ModelID = 154;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA144";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""154"",""name"":""PCA144"",""description"":""PCA144"",""founder"":""admin"",""creatTime"":""2023-10-30 16:05:50"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 11:20:05"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:12:50"",""et"":""2025-11-26 05:32:58"",""duration"":1167608,""number"":3893,""filter"":90,""mode"":3803,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-11-29 13:53:22"",""et"":""2025-12-05 20:53:56"",""duration"":543634,""number"":1813,""filter"":90,""mode"":1723,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_emillot"",""Description"":""磨煤机E出口风粉混合物温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.26"",""lowerBound"":""-0.26"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""83.10"",""TMin"":""59.35"",""TAvg"":""75.21"",""DMax"":""0.33"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.26""},{""PointId"":""d1_10hfc50ct111r"",""Description"":""磨煤机E分离器风粉混合物温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.40"",""lowerBound"":""-0.40"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""82.77"",""TMin"":""59.21"",""TAvg"":""74.99"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.33"",""C99"":""0.40""},{""PointId"":""d1_10hfc50ct112r"",""Description"":""磨煤机E分离器风粉混合物温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.71"",""lowerBound"":""-0.71"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""84.27"",""TMin"":""59.36"",""TAvg"":""75.76"",""DMax"":""0.93"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.58"",""C99"":""0.71""},{""PointId"":""d1_10hfc50ct113r"",""Description"":""磨煤机E分离器风粉混合物温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.25"",""lowerBound"":""-0.25"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""83.09"",""TMin"":""59.44"",""TAvg"":""75.21"",""DMax"":""0.30"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.21"",""C99"":""0.25""},{""PointId"":""d1_10hhe50ct101k"",""Description"":""磨煤机E出口E11侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.84"",""lowerBound"":""-0.84"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""73.26"",""TMin"":""58.18"",""TAvg"":""67.56"",""DMax"":""1.10"",""DMin"":""0.00"",""DAvg"":""0.20"",""C95"":""0.68"",""C99"":""0.84""},{""PointId"":""d1_10hhe50ct102k"",""Description"":""磨煤机E出口E12侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.79"",""lowerBound"":""-0.79"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""73.62"",""TMin"":""59.01"",""TAvg"":""68.19"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.19"",""C95"":""0.64"",""C99"":""0.79""},{""PointId"":""d1_10hhe50ct103k"",""Description"":""磨煤机E出口E21侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.99"",""lowerBound"":""-0.99"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""73.61"",""TMin"":""58.42"",""TAvg"":""68.35"",""DMax"":""1.31"",""DMin"":""0.00"",""DAvg"":""0.23"",""C95"":""0.80"",""C99"":""0.99""},{""PointId"":""d1_10hhe50ct104k"",""Description"":""磨煤机E出口E22侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.73"",""lowerBound"":""-0.73"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""72.31"",""TMin"":""58.83"",""TAvg"":""67.33"",""DMax"":""1.07"",""DMin"":""0.00"",""DAvg"":""0.17"",""C95"":""0.60"",""C99"":""0.73""},{""PointId"":""d1_10hhe50ct105k"",""Description"":""磨煤机E出口E31侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.96"",""lowerBound"":""-0.96"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""72.87"",""TMin"":""58.50"",""TAvg"":""67.91"",""DMax"":""0.97"",""DMin"":""0.00"",""DAvg"":""0.23"",""C95"":""0.78"",""C99"":""0.96""},{""PointId"":""d1_10hhe50ct106k"",""Description"":""磨煤机E出口E32侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.03"",""lowerBound"":""-1.03"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""72.94"",""TMin"":""58.01"",""TAvg"":""67.82"",""DMax"":""1.36"",""DMin"":""0.00"",""DAvg"":""0.24"",""C95"":""0.84"",""C99"":""1.03""},{""PointId"":""d1_10hhe50ct107k"",""Description"":""磨煤机E出口E41侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.49"",""lowerBound"":""-0.49"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""73.17"",""TMin"":""59.05"",""TAvg"":""68.01"",""DMax"":""0.57"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.40"",""C99"":""0.49""},{""PointId"":""d1_10hhe50ct108k"",""Description"":""磨煤机E出口E42侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.42"",""lowerBound"":""-1.42"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""72.01"",""TMin"":""58.47"",""TAvg"":""66.76"",""DMax"":""1.96"",""DMin"":""0.00"",""DAvg"":""0.33"",""C95"":""1.16"",""C99"":""1.42""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 11:20:05"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[59.35,59.211,59.363,59.442,58.184,59.006,58.417,58.827,58.497,58.01,59.051,58.473],""Train_X_max"":[83.103,82.774,84.271,83.085,73.26,73.622,73.606,72.312,72.874,72.941,73.173,72.012],""Train_X_std"":[3.568,3.592,3.792,3.563,2.747,2.718,2.656,2.436,2.586,2.64,2.658,2.542],""Train_X_mean"":[75.207,74.985,75.757,75.207,67.559,68.189,68.35,67.325,67.911,67.822,68.007,66.758],""Train_X_bais_max"":[[0.33,0.57,0.926,0.299,1.102,0.669,1.306,1.073,0.968,1.364,0.573,1.964]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.059,0.091,0.168,0.059,0.2,0.185,0.228,0.173,0.225,0.242,0.116,0.329]],""QCUL_95"":0.27702108,""QCUL_99"":0.4624805,""QCUL_95_line"":[0.21,0.325,0.582,0.207,0.684,0.642,0.803,0.596,0.782,0.84,0.403,1.161],""QCUL_99_line"":[0.257,0.4,0.713,0.254,0.837,0.787,0.985,0.73,0.958,1.029,0.493,1.424],""T2CUL_95"":5.997,""T2CUL_99"":9.221,""T2CUL_95_line"":[0.117,0.117,0.124,0.116,0.09,0.089,0.087,0.08,0.085,0.086,0.087,0.083],""T2CUL_99_line"":[0.145,0.146,0.154,0.144,0.111,0.11,0.108,0.099,0.105,0.107,0.108,0.103],""Kesi_95"":1.568,""Kesi_99"":1.356,""Kesi_95_line"":[0.06,0.06,0.063,0.06,0.046,0.045,0.044,0.041,0.043,0.044,0.044,0.042],""Kesi_99_line"":[0.055,0.056,0.059,0.055,0.043,0.042,0.041,0.038,0.04,0.041,0.041,0.04],""COV"":[[1.0,1.0,0.998,1.0,0.771,0.751,0.813,0.712,0.774,0.797,0.713,0.642],[1.0,1.0,0.998,1.0,0.774,0.754,0.815,0.715,0.776,0.8,0.716,0.645],[0.998,0.998,1.0,0.998,0.771,0.751,0.808,0.71,0.771,0.794,0.712,0.644],[1.0,1.0,0.998,1.0,0.772,0.752,0.813,0.712,0.774,0.798,0.713,0.643],[0.771,0.774,0.771,0.772,1.0,0.996,0.99,0.985,0.987,0.988,0.989,0.961],[0.751,0.754,0.751,0.752,0.996,1.0,0.985,0.992,0.984,0.982,0.992,0.97],[0.813,0.815,0.808,0.813,0.99,0.985,1.0,0.975,0.991,0.995,0.975,0.931],[0.712,0.715,0.71,0.712,0.985,0.992,0.975,1.0,0.982,0.974,0.995,0.982],[0.774,0.776,0.771,0.774,0.987,0.984,0.991,0.982,1.0,0.997,0.986,0.954],[0.797,0.8,0.794,0.798,0.988,0.982,0.995,0.974,0.997,1.0,0.98,0.941],[0.713,0.716,0.712,0.713,0.989,0.992,0.975,0.995,0.986,0.98,1.0,0.987],[0.642,0.645,0.644,0.643,0.961,0.97,0.931,0.982,0.954,0.941,0.987,1.0]],""K"":2,""R"":0.992,""featValue"":[10.579,1.326,0.056,0.022,0.011,0.003,0.001,0.001,0.001,0.001,0.001,0.0],""featVec"":[[-0.27,0.414,-0.057,-0.032,0.079,-0.086,-0.009,0.027,0.059,-0.271,0.396,0.709],[-0.271,0.41,-0.047,-0.011,0.062,-0.368,-0.053,-0.106,0.467,0.351,-0.511,-0.014],[-0.27,0.413,-0.158,0.025,-0.185,0.529,0.05,0.01,-0.543,0.216,-0.269,0.008],[-0.27,0.413,-0.056,-0.032,0.077,-0.078,-0.006,0.036,0.04,-0.279,0.403,-0.705],[-0.301,-0.161,0.096,0.449,-0.495,-0.162,0.445,-0.426,0.007,0.036,0.142,-0.002],[-0.299,-0.189,-0.047,0.535,-0.017,0.42,-0.31,0.366,0.416,-0.08,-0.023,-0.001],[-0.304,-0.099,0.424,0.188,0.213,-0.344,-0.057,0.203,-0.418,-0.397,-0.378,0.006],[-0.294,-0.239,-0.154,0.109,0.751,0.067,0.268,-0.158,-0.1,0.343,0.168,-0.001],[-0.301,-0.155,0.325,-0.489,0.042,0.427,0.061,-0.395,0.276,-0.304,-0.169,-0.003],[-0.302,-0.121,0.416,-0.343,-0.218,-0.063,0.105,0.505,0.008,0.465,0.263,0.003],[-0.295,-0.24,-0.157,-0.117,-0.137,-0.186,-0.741,-0.34,-0.219,0.163,0.158,-0.002],[-0.283,-0.308,-0.67,-0.302,-0.165,-0.16,0.25,0.279,0.007,-0.245,-0.18,0.002]],""selectVec"":[[-0.27,0.414],[-0.271,0.41],[-0.27,0.413],[-0.27,0.413],[-0.301,-0.161],[-0.299,-0.189],[-0.304,-0.099],[-0.294,-0.239],[-0.301,-0.155],[-0.302,-0.121],[-0.295,-0.24],[-0.283,-0.308]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":5705,""AfterCleanSamNum"":5615,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机E运行"",""alarmcondition"":""[d1_10hfe50aj001xq01]>10""},""copy"":false,""principal"":""2"",""precision"":""99.2%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":154,""version"":""v-2025-12-09 11:20:05"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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
			
	        if (!(Condition1>10))
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