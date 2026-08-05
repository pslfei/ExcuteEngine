using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA143")]
    [FCDisplay("PCA143")]
    public partial class PCA143 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口风粉混合物温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D分离器风粉混合物温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D分离器风粉混合物温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D分离器风粉混合物温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D11侧燃烧器壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D12侧燃烧器壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D21侧燃烧器壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D22侧燃烧器壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D31侧燃烧器壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D32侧燃烧器壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D41侧燃烧器壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机D出口D42侧燃烧器壁温")]
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

		public PCA143()
		{
			ModelID = 153;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA143";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""153"",""name"":""PCA143"",""description"":""PCA143"",""founder"":""admin"",""creatTime"":""2023-10-30 16:00:28"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 11:17:04"",""algorithm"":""PCA"",""sampling"":""100"",""monitor"":null,""trainTime"":[{""st"":""2025-11-12 17:12:50"",""et"":""2025-11-17 21:26:36"",""duration"":447226,""number"":4473,""filter"":282,""mode"":4191,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0},{""st"":""2025-12-05 00:48:50"",""et"":""2025-12-07 17:31:56"",""duration"":232986,""number"":2330,""filter"":282,""mode"":2048,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":2,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_dmillot"",""Description"":""磨煤机D出口风粉混合物温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.27"",""lowerBound"":""-0.27"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""81.84"",""TMin"":""57.90"",""TAvg"":""75.31"",""DMax"":""0.85"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.22"",""C99"":""0.27""},{""PointId"":""d1_10hfc40ct111r"",""Description"":""磨煤机D分离器风粉混合物温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.43"",""lowerBound"":""-0.43"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""81.56"",""TMin"":""57.80"",""TAvg"":""74.93"",""DMax"":""0.67"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.35"",""C99"":""0.43""},{""PointId"":""d1_10hfc40ct112r"",""Description"":""磨煤机D分离器风粉混合物温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""82.04"",""TMin"":""57.91"",""TAvg"":""75.38"",""DMax"":""0.71"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hfc40ct113r"",""Description"":""磨煤机D分离器风粉混合物温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.35"",""lowerBound"":""-0.35"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""82.21"",""TMin"":""58.04"",""TAvg"":""75.43"",""DMax"":""0.42"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.29"",""C99"":""0.35""},{""PointId"":""d1_10hhe40ct101k"",""Description"":""磨煤机D出口D11侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.28"",""lowerBound"":""-0.28"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""75.32"",""TMin"":""57.58"",""TAvg"":""70.14"",""DMax"":""0.27"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.23"",""C99"":""0.28""},{""PointId"":""d1_10hhe40ct102k"",""Description"":""磨煤机D出口D12侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""75.22"",""TMin"":""57.33"",""TAvg"":""70.09"",""DMax"":""0.35"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hhe40ct103k"",""Description"":""磨煤机D出口D21侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.38"",""lowerBound"":""-0.38"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""74.27"",""TMin"":""57.32"",""TAvg"":""69.43"",""DMax"":""0.38"",""DMin"":""0.00"",""DAvg"":""0.09"",""C95"":""0.31"",""C99"":""0.38""},{""PointId"":""d1_10hhe40ct104k"",""Description"":""磨煤机D出口D22侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.33"",""lowerBound"":""-0.33"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""74.79"",""TMin"":""57.44"",""TAvg"":""69.78"",""DMax"":""0.29"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.27"",""C99"":""0.33""},{""PointId"":""d1_10hhe40ct105k"",""Description"":""磨煤机D出口D31侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.46"",""lowerBound"":""-0.46"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""75.00"",""TMin"":""57.01"",""TAvg"":""70.04"",""DMax"":""0.47"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.38"",""C99"":""0.46""},{""PointId"":""d1_10hhe40ct106k"",""Description"":""磨煤机D出口D32侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.60"",""lowerBound"":""-0.60"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""74.63"",""TMin"":""56.78"",""TAvg"":""69.65"",""DMax"":""0.61"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10hhe40ct107k"",""Description"":""磨煤机D出口D41侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.60"",""lowerBound"":""-0.60"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""74.67"",""TMin"":""57.34"",""TAvg"":""69.38"",""DMax"":""0.56"",""DMin"":""0.00"",""DAvg"":""0.14"",""C95"":""0.49"",""C99"":""0.60""},{""PointId"":""d1_10hhe40ct108k"",""Description"":""磨煤机D出口D42侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.66"",""lowerBound"":""-0.66"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""74.54"",""TMin"":""57.35"",""TAvg"":""69.29"",""DMax"":""0.55"",""DMin"":""0.00"",""DAvg"":""0.15"",""C95"":""0.54"",""C99"":""0.66""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 11:17:04"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[57.898,57.797,57.912,58.035,57.582,57.333,57.316,57.437,57.01,56.782,57.338,57.351],""Train_X_max"":[81.844,81.564,82.042,82.213,75.324,75.222,74.269,74.787,75.004,74.627,74.666,74.539],""Train_X_std"":[3.571,3.559,3.59,3.546,2.87,2.875,2.764,2.86,2.897,2.86,2.838,2.832],""Train_X_mean"":[75.312,74.934,75.379,75.434,70.137,70.091,69.427,69.782,70.035,69.654,69.383,69.29],""Train_X_bais_max"":[[0.851,0.668,0.709,0.419,0.266,0.354,0.381,0.29,0.465,0.613,0.56,0.554]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.057,0.1,0.086,0.085,0.069,0.091,0.087,0.079,0.11,0.144,0.142,0.154]],""QCUL_95"":0.06698915,""QCUL_99"":0.116638817,""QCUL_95_line"":[0.216,0.35,0.309,0.289,0.231,0.311,0.307,0.272,0.378,0.489,0.487,0.539],""QCUL_99_line"":[0.266,0.429,0.38,0.354,0.283,0.381,0.376,0.332,0.463,0.598,0.596,0.66],""T2CUL_95"":6.005,""T2CUL_99"":9.238,""T2CUL_95_line"":[0.188,0.187,0.189,0.186,0.151,0.151,0.145,0.15,0.152,0.15,0.149,0.149],""T2CUL_99_line"":[0.233,0.232,0.234,0.231,0.187,0.187,0.18,0.186,0.189,0.186,0.185,0.185],""Kesi_95"":1.558,""Kesi_99"":1.321,""Kesi_95_line"":[0.096,0.095,0.096,0.095,0.077,0.077,0.074,0.076,0.077,0.076,0.076,0.076],""Kesi_99_line"":[0.088,0.088,0.088,0.087,0.071,0.071,0.068,0.07,0.071,0.07,0.07,0.07],""COV"":[[1.0,0.999,1.0,0.999,0.83,0.848,0.805,0.823,0.841,0.842,0.783,0.805],[0.999,1.0,0.999,0.999,0.828,0.845,0.803,0.821,0.838,0.84,0.782,0.804],[1.0,0.999,1.0,0.998,0.837,0.854,0.812,0.83,0.848,0.849,0.79,0.812],[0.999,0.999,0.998,1.0,0.82,0.837,0.795,0.813,0.831,0.832,0.773,0.795],[0.83,0.828,0.837,0.82,1.0,1.0,0.999,1.0,0.998,0.998,0.994,0.996],[0.848,0.845,0.854,0.837,1.0,1.0,0.996,0.998,0.999,0.999,0.99,0.993],[0.805,0.803,0.812,0.795,0.999,0.996,1.0,0.999,0.997,0.996,0.996,0.996],[0.823,0.821,0.83,0.813,1.0,0.998,0.999,1.0,0.998,0.996,0.996,0.997],[0.841,0.838,0.848,0.831,0.998,0.999,0.997,0.998,1.0,1.0,0.991,0.993],[0.842,0.84,0.849,0.832,0.998,0.999,0.996,0.996,1.0,1.0,0.989,0.991],[0.783,0.782,0.79,0.773,0.994,0.99,0.996,0.996,0.991,0.989,1.0,0.999],[0.805,0.804,0.812,0.795,0.996,0.993,0.996,0.997,0.993,0.991,0.999,1.0]],""K"":2,""R"":0.998,""featValue"":[11.037,0.945,0.014,0.003,0.002,0.001,0.001,0.001,0.0,0.0,0.0,0.0],""featVec"":[[0.276,0.413,-0.036,0.015,-0.116,-0.409,0.186,-0.381,-0.198,0.584,0.093,-0.051],[0.275,0.416,0.166,-0.038,0.314,0.719,-0.217,-0.072,-0.062,0.126,0.186,0.016],[0.277,0.401,-0.093,0.065,-0.498,0.121,0.272,-0.188,0.281,-0.528,-0.141,-0.007],[0.273,0.43,0.106,-0.039,0.328,-0.438,-0.168,0.57,-0.012,-0.215,-0.167,0.033],[0.296,-0.182,-0.072,0.401,-0.119,0.135,0.165,0.331,-0.233,0.06,0.055,-0.695],[0.298,-0.149,-0.241,0.332,-0.274,0.142,-0.011,0.346,-0.06,0.259,-0.041,0.658],[0.294,-0.225,-0.136,0.216,0.613,-0.071,0.485,-0.199,0.316,-0.109,0.129,0.12],[0.295,-0.194,0.045,0.386,0.01,-0.184,-0.695,-0.404,0.114,-0.128,-0.106,-0.057],[0.297,-0.161,-0.327,-0.394,-0.043,-0.099,-0.104,-0.059,-0.441,-0.347,0.527,0.071],[0.297,-0.157,-0.443,-0.528,0.029,0.108,-0.115,0.037,0.294,0.252,-0.443,-0.198],[0.291,-0.26,0.505,-0.172,0.02,0.059,0.217,-0.155,-0.462,-0.109,-0.495,0.132],[0.293,-0.223,0.556,-0.248,-0.253,-0.087,-0.004,0.168,0.461,0.152,0.396,-0.022]],""selectVec"":[[0.276,0.413],[0.275,0.416],[0.277,0.401],[0.273,0.43],[0.296,-0.182],[0.298,-0.149],[0.294,-0.225],[0.295,-0.194],[0.297,-0.161],[0.297,-0.157],[0.291,-0.26],[0.293,-0.223]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":2267,""AfterCleanSamNum"":2177,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机D运行"",""alarmcondition"":""[d1_10hfe40aj001xq01]>10""},""copy"":false,""principal"":""2"",""precision"":""99.8%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":153,""version"":""v-2025-12-09 11:17:04"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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