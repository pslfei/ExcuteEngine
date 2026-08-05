using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA140")]
    [FCDisplay("PCA140")]
    public partial class PCA140 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B分离器风粉混合物温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B分离器风粉混合物温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B分离器风粉混合物温度3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口风粉混合物温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B11侧燃烧器壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B12侧燃烧器壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B21侧燃烧器壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B22侧燃烧器壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B31侧燃烧器壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B32侧燃烧器壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B41侧燃烧器壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机B出口B42侧燃烧器壁温")]
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

		public PCA140()
		{
			ModelID = 151;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA140";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""151"",""name"":""PCA140"",""description"":""PCA140"",""founder"":""admin"",""creatTime"":""2023-10-30 15:26:02"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 11:04:15"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 23:54:32"",""et"":""2025-12-07 11:34:52"",""duration"":2115620,""number"":7053,""filter"":3598,""mode"":3455,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":3508}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc20ct111r"",""Description"":""磨煤机B分离器风粉混合物温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.46"",""lowerBound"":""-0.46"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""89.45"",""TMin"":""49.79"",""TAvg"":""74.66"",""DMax"":""0.82"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.38"",""C99"":""0.46""},{""PointId"":""d1_10hfc20ct112r"",""Description"":""磨煤机B分离器风粉混合物温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.31"",""lowerBound"":""-0.31"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""89.91"",""TMin"":""49.62"",""TAvg"":""74.47"",""DMax"":""0.95"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.25"",""C99"":""0.31""},{""PointId"":""d1_10hfc20ct113r"",""Description"":""磨煤机B分离器风粉混合物温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.57"",""lowerBound"":""-0.57"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""88.69"",""TMin"":""50.29"",""TAvg"":""73.21"",""DMax"":""1.15"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.46"",""C99"":""0.57""},{""PointId"":""d1_bmillot"",""Description"":""磨煤机B出口风粉混合物温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""88.38"",""TMin"":""49.76"",""TAvg"":""74.45"",""DMax"":""1.74"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hhe20ct101k"",""Description"":""磨煤机B出口B11侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.49"",""lowerBound"":""-1.49"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""66.25"",""TMin"":""30.52"",""TAvg"":""60.07"",""DMax"":""5.53"",""DMin"":""0.00"",""DAvg"":""0.25"",""C95"":""1.07"",""C99"":""1.33""},{""PointId"":""d1_10hhe20ct102k"",""Description"":""磨煤机B出口B12侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""4.00"",""lowerBound"":""-4.00"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""115.72"",""TMin"":""37.82"",""TAvg"":""63.97"",""DMax"":""11.94"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.93"",""C99"":""2.43""},{""PointId"":""d1_10hhe20ct103k"",""Description"":""磨煤机B出口B21侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.66"",""lowerBound"":""-2.66"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""130.23"",""TMin"":""29.25"",""TAvg"":""61.80"",""DMax"":""8.88"",""DMin"":""0.00"",""DAvg"":""0.37"",""C95"":""1.63"",""C99"":""2.03""},{""PointId"":""d1_10hhe20ct104k"",""Description"":""磨煤机B出口B22侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.60"",""lowerBound"":""-1.60"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""71.15"",""TMin"":""34.45"",""TAvg"":""62.69"",""DMax"":""6.27"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.26"",""C99"":""1.56""},{""PointId"":""d1_10hhe20ct105k"",""Description"":""磨煤机B出口B31侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.10"",""lowerBound"":""-2.10"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""66.90"",""TMin"":""31.07"",""TAvg"":""60.99"",""DMax"":""10.82"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.60"",""C99"":""2.01""},{""PointId"":""d1_10hhe20ct106k"",""Description"":""磨煤机B出口B32侧燃烧器壁温"",""Unit"":"""",""Upper"":""222"",""Lower"":""5"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""4.74"",""lowerBound"":""-4.74"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""126.68"",""TMin"":""37.07"",""TAvg"":""62.05"",""DMax"":""11.58"",""DMin"":""0.00"",""DAvg"":""0.31"",""C95"":""2.03"",""C99"":""2.57""},{""PointId"":""d1_10hhe20ct107k"",""Description"":""磨煤机B出口B41侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.52"",""lowerBound"":""-1.52"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""89.37"",""TMin"":""31.39"",""TAvg"":""60.89"",""DMax"":""2.86"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.07"",""C99"":""1.31""},{""PointId"":""d1_10hhe20ct108k"",""Description"":""磨煤机B出口B42侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.52"",""lowerBound"":""-2.52"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""167.35"",""TMin"":""37.31"",""TAvg"":""61.62"",""DMax"":""13.41"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.88"",""C99"":""2.38""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 11:04:15"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[49.793,49.617,50.285,49.764,30.519,37.818,29.248,34.445,31.072,37.065,31.391,37.311],""Train_X_max"":[89.448,89.913,88.686,88.377,66.252,115.721,130.229,71.15,66.898,126.677,89.365,167.348],""Train_X_std"":[3.999,4.006,3.849,4.015,5.941,5.968,6.486,5.674,5.918,6.346,5.658,7.804],""Train_X_mean"":[74.659,74.47,73.207,74.445,60.065,63.973,61.795,62.687,60.987,62.05,60.891,61.615],""Train_X_bais_max"":[[0.822,0.947,1.153,1.735,5.528,11.939,8.883,6.268,10.818,11.576,2.856,13.41]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.104,0.061,0.119,0.067,0.249,0.322,0.367,0.3,0.323,0.312,0.298,0.315]],""QCUL_95"":0.232708842,""QCUL_99"":0.3517925,""QCUL_95_line"":[0.376,0.253,0.46,0.3,1.068,1.925,1.631,1.26,1.604,2.03,1.065,1.884],""QCUL_99_line"":[0.462,0.314,0.567,0.373,1.327,2.432,2.031,1.564,2.01,2.574,1.308,2.381],""T2CUL_95"":9.509,""T2CUL_99"":13.314,""T2CUL_95_line"":[0.21,0.21,0.202,0.211,0.312,0.313,0.341,0.298,0.311,0.333,0.297,0.41],""T2CUL_99_line"":[0.249,0.249,0.239,0.25,0.369,0.371,0.403,0.353,0.368,0.394,0.352,0.485],""Kesi_95"":1.612,""Kesi_99"":1.447,""Kesi_95_line"":[0.086,0.087,0.083,0.087,0.128,0.129,0.14,0.123,0.128,0.137,0.122,0.169],""Kesi_99_line"":[0.082,0.082,0.079,0.082,0.122,0.122,0.133,0.116,0.121,0.13,0.116,0.16],""COV"":[[1.0,0.999,0.998,0.999,0.605,0.337,0.537,0.641,0.607,0.257,0.58,0.102],[0.999,1.0,0.999,1.0,0.622,0.346,0.55,0.658,0.625,0.263,0.596,0.103],[0.998,0.999,1.0,0.998,0.617,0.342,0.546,0.653,0.62,0.261,0.591,0.103],[0.999,1.0,0.998,1.0,0.618,0.345,0.548,0.654,0.621,0.262,0.593,0.103],[0.605,0.622,0.617,0.618,1.0,0.57,0.883,0.992,0.992,0.448,0.959,0.196],[0.337,0.346,0.342,0.345,0.57,1.0,0.569,0.554,0.543,0.957,0.573,0.813],[0.537,0.55,0.546,0.548,0.883,0.569,1.0,0.894,0.875,0.477,0.971,0.417],[0.641,0.658,0.653,0.654,0.992,0.554,0.894,1.0,0.985,0.44,0.963,0.191],[0.607,0.625,0.62,0.621,0.992,0.543,0.875,0.985,1.0,0.429,0.955,0.179],[0.257,0.263,0.261,0.262,0.448,0.957,0.477,0.44,0.429,1.0,0.474,0.858],[0.58,0.596,0.591,0.593,0.959,0.573,0.971,0.963,0.955,0.474,1.0,0.326],[0.102,0.103,0.103,0.103,0.196,0.813,0.417,0.191,0.179,0.858,0.326,1.0]],""K"":4,""R"":0.992,""featValue"":[7.805,2.406,1.41,0.29,0.035,0.032,0.011,0.006,0.004,0.003,0.001,0.001],""featVec"":[[-0.295,-0.289,-0.29,-0.03,-0.001,0.016,0.014,-0.072,0.093,-0.415,-0.736,0.129],[-0.299,-0.285,-0.275,-0.018,-0.003,-0.005,0.002,-0.013,-0.017,-0.04,0.489,0.716],[-0.298,-0.286,-0.278,-0.022,0.02,-0.022,-0.012,0.109,-0.034,0.822,-0.169,-0.183],[-0.298,-0.286,-0.278,-0.02,-0.011,0.012,0.039,-0.043,-0.021,-0.356,0.43,-0.661],[-0.328,0.027,0.315,0.229,-0.152,-0.195,-0.123,-0.194,0.786,0.065,0.058,-0.022],[-0.239,0.425,-0.211,0.359,-0.663,0.307,0.123,-0.066,-0.183,0.024,-0.023,0.008],[-0.313,0.116,0.263,-0.577,-0.023,0.515,0.194,0.388,0.178,-0.022,0.012,0.007],[-0.333,0.005,0.293,0.167,0.062,0.044,-0.767,0.255,-0.33,-0.081,-0.027,-0.007],[-0.326,0.013,0.322,0.22,0.045,-0.501,0.53,0.364,-0.263,-0.068,-0.038,0.017],[-0.205,0.464,-0.275,0.319,0.707,0.209,0.08,0.024,0.122,-0.002,0.014,0.0],[-0.328,0.077,0.3,-0.24,0.145,0.028,0.098,-0.767,-0.334,0.086,-0.021,0.001],[-0.135,0.504,-0.342,-0.498,-0.099,-0.551,-0.212,0.047,0.033,-0.023,0.006,-0.007]],""selectVec"":[[-0.295,-0.289,-0.29,-0.03],[-0.299,-0.285,-0.275,-0.018],[-0.298,-0.286,-0.278,-0.022],[-0.298,-0.286,-0.278,-0.02],[-0.328,0.027,0.315,0.229],[-0.239,0.425,-0.211,0.359],[-0.313,0.116,0.263,-0.577],[-0.333,0.005,0.293,0.167],[-0.326,0.013,0.322,0.22],[-0.205,0.464,-0.275,0.319],[-0.328,0.077,0.3,-0.24],[-0.135,0.504,-0.342,-0.498]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7053,""AfterCleanSamNum"":3448,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机B运行"",""alarmcondition"":""[d1_10hfe20aj001xq01]>10""},""copy"":false,""principal"":""4"",""precision"":""99.2%"",""rate"":""0.97"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":151,""version"":""v-2025-12-09 11:04:15"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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