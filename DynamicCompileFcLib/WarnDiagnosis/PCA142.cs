using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA142")]
    [FCDisplay("PCA142")]
    public partial class PCA142 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C分离器风粉混合物温度1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C分离器风粉混合物温度2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C分离器风粉混合物温度3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口风粉混合物温度")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C11侧燃烧器壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C12侧燃烧器壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C21侧燃烧器壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C22侧燃烧器壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C31侧燃烧器壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C32侧燃烧器壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C41侧燃烧器壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机C出口C42侧燃烧器壁温")]
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

		public PCA142()
		{
			ModelID = 152;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA142";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""152"",""name"":""PCA142"",""description"":""PCA142"",""founder"":""admin"",""creatTime"":""2023-10-30 15:54:49"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 11:13:03"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-08-24 06:20:30"",""et"":""2025-09-14 03:38:33"",""duration"":1804683,""number"":6016,""filter"":1371,""mode"":4645,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":1281}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_10hfc30ct111r"",""Description"":""磨煤机C分离器风粉混合物温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.33"",""lowerBound"":""-0.33"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""85.37"",""TMin"":""57.42"",""TAvg"":""71.85"",""DMax"":""1.39"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.26"",""C99"":""0.33""},{""PointId"":""d1_10hfc30ct112r"",""Description"":""磨煤机C分离器风粉混合物温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.37"",""lowerBound"":""-0.37"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""85.88"",""TMin"":""57.37"",""TAvg"":""71.86"",""DMax"":""0.64"",""DMin"":""0.00"",""DAvg"":""0.08"",""C95"":""0.30"",""C99"":""0.37""},{""PointId"":""d1_10hfc30ct113r"",""Description"":""磨煤机C分离器风粉混合物温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.45"",""lowerBound"":""-0.45"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""86.47"",""TMin"":""57.21"",""TAvg"":""71.72"",""DMax"":""1.81"",""DMin"":""0.00"",""DAvg"":""0.10"",""C95"":""0.36"",""C99"":""0.45""},{""PointId"":""d1_cmillot"",""Description"":""磨煤机C出口风粉混合物温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.18"",""lowerBound"":""-0.18"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""85.95"",""TMin"":""57.36"",""TAvg"":""71.82"",""DMax"":""0.60"",""DMin"":""0.00"",""DAvg"":""0.04"",""C95"":""0.14"",""C99"":""0.18""},{""PointId"":""d1_10hhe30ct101k"",""Description"":""磨煤机C出口C11侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.32"",""lowerBound"":""-2.32"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""264.11"",""TMin"":""37.08"",""TAvg"":""65.04"",""DMax"":""14.47"",""DMin"":""0.00"",""DAvg"":""0.29"",""C95"":""1.83"",""C99"":""2.32""},{""PointId"":""d1_10hhe30ct102k"",""Description"":""磨煤机C出口C12侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.28"",""lowerBound"":""-2.28"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""149.78"",""TMin"":""37.95"",""TAvg"":""64.87"",""DMax"":""8.60"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""1.83"",""C99"":""2.28""},{""PointId"":""d1_10hhe30ct103k"",""Description"":""磨煤机C出口C21侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""4.38"",""lowerBound"":""-4.38"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""261.24"",""TMin"":""37.56"",""TAvg"":""64.99"",""DMax"":""28.78"",""DMin"":""0.00"",""DAvg"":""0.40"",""C95"":""3.43"",""C99"":""4.38""},{""PointId"":""d1_10hhe30ct104k"",""Description"":""磨煤机C出口C22侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""4.05"",""lowerBound"":""-4.05"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""206.08"",""TMin"":""37.51"",""TAvg"":""64.11"",""DMax"":""18.66"",""DMin"":""0.00"",""DAvg"":""0.69"",""C95"":""3.24"",""C99"":""4.05""},{""PointId"":""d1_10hhe30ct105k"",""Description"":""磨煤机C出口C31侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.68"",""lowerBound"":""-2.68"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""200.86"",""TMin"":""37.63"",""TAvg"":""64.31"",""DMax"":""10.99"",""DMin"":""0.00"",""DAvg"":""0.43"",""C95"":""2.14"",""C99"":""2.68""},{""PointId"":""d1_10hhe30ct106k"",""Description"":""磨煤机C出口C32侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.89"",""lowerBound"":""-1.89"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""139.85"",""TMin"":""38.33"",""TAvg"":""63.74"",""DMax"":""7.83"",""DMin"":""0.00"",""DAvg"":""0.34"",""C95"":""1.52"",""C99"":""1.89""},{""PointId"":""d1_10hhe30ct107k"",""Description"":""磨煤机C出口C41侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""7.14"",""lowerBound"":""-7.14"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""261.60"",""TMin"":""37.35"",""TAvg"":""64.19"",""DMax"":""43.93"",""DMin"":""0.00"",""DAvg"":""0.79"",""C95"":""5.61"",""C99"":""7.14""},{""PointId"":""d1_10hhe30ct108k"",""Description"":""磨煤机C出口C42侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.93"",""lowerBound"":""-2.93"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""176.97"",""TMin"":""38.06"",""TAvg"":""63.88"",""DMax"":""15.93"",""DMin"":""0.00"",""DAvg"":""0.38"",""C95"":""2.32"",""C99"":""2.93""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 11:13:03"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[57.423,57.372,57.207,57.357,37.082,37.954,37.555,37.511,37.634,38.329,37.346,38.061],""Train_X_max"":[85.374,85.88,86.471,85.945,264.11,149.779,261.243,206.076,200.863,139.848,261.6,176.971],""Train_X_std"":[4.068,4.109,4.046,4.073,8.675,5.037,8.167,7.923,6.459,4.899,9.321,6.282],""Train_X_mean"":[71.854,71.855,71.715,71.817,65.043,64.874,64.994,64.107,64.307,63.74,64.187,63.88],""Train_X_bais_max"":[[1.394,0.639,1.812,0.603,14.472,8.599,28.781,18.658,10.993,7.833,43.927,15.925]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.001,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.06,0.08,0.096,0.036,0.294,0.383,0.396,0.688,0.425,0.339,0.787,0.375]],""QCUL_95"":0.64177,""QCUL_99"":1.06715214,""QCUL_95_line"":[0.264,0.298,0.361,0.143,1.834,1.826,3.425,3.243,2.14,1.519,5.61,2.318],""QCUL_99_line"":[0.328,0.367,0.445,0.177,2.321,2.283,4.383,4.051,2.682,1.892,7.135,2.933],""T2CUL_95"":7.826,""T2CUL_99"":11.365,""T2CUL_95_line"":[0.167,0.169,0.166,0.167,0.356,0.207,0.335,0.325,0.265,0.201,0.383,0.258],""T2CUL_99_line"":[0.201,0.203,0.2,0.201,0.429,0.249,0.404,0.392,0.32,0.242,0.461,0.311],""Kesi_95"":1.582,""Kesi_99"":1.381,""Kesi_95_line"":[0.075,0.076,0.075,0.075,0.16,0.093,0.151,0.146,0.119,0.09,0.172,0.116],""Kesi_99_line"":[0.07,0.071,0.07,0.07,0.15,0.087,0.141,0.137,0.111,0.084,0.161,0.108],""COV"":[[1.0,0.999,0.999,1.0,0.236,0.388,0.25,0.204,0.315,0.36,0.215,0.248],[0.999,1.0,0.999,1.0,0.236,0.388,0.249,0.206,0.315,0.36,0.218,0.249],[0.999,0.999,1.0,1.0,0.232,0.381,0.244,0.203,0.31,0.353,0.215,0.244],[1.0,1.0,1.0,1.0,0.235,0.386,0.248,0.204,0.314,0.358,0.216,0.247],[0.236,0.236,0.232,0.235,1.0,0.291,0.993,0.15,0.976,0.295,0.938,0.247],[0.388,0.388,0.381,0.386,0.291,1.0,0.329,0.943,0.357,0.988,0.345,0.949],[0.25,0.249,0.244,0.248,0.993,0.329,1.0,0.176,0.96,0.336,0.902,0.284],[0.204,0.206,0.203,0.204,0.15,0.943,0.176,1.0,0.207,0.943,0.269,0.965],[0.315,0.315,0.31,0.314,0.976,0.357,0.96,0.207,1.0,0.365,0.949,0.306],[0.36,0.36,0.353,0.358,0.295,0.988,0.336,0.943,0.365,1.0,0.34,0.97],[0.215,0.218,0.215,0.216,0.938,0.345,0.902,0.269,0.949,0.34,1.0,0.297],[0.248,0.249,0.244,0.247,0.247,0.949,0.284,0.965,0.306,0.97,0.297,1.0]],""K"":3,""R"":0.981,""featValue"":[6.169,2.922,2.688,0.132,0.043,0.036,0.007,0.002,0.001,0.001,0.001,0.0],""featVec"":[[-0.295,-0.361,-0.176,-0.002,0.004,-0.008,-0.051,-0.078,-0.387,-0.503,0.494,-0.311],[-0.295,-0.36,-0.175,0.022,0.031,-0.005,0.013,-0.053,0.437,0.616,0.244,-0.344],[-0.293,-0.363,-0.177,0.039,0.073,-0.036,0.046,0.14,-0.061,-0.149,-0.808,-0.207],[-0.295,-0.361,-0.176,0.019,0.031,-0.01,0.003,-0.006,0.013,0.034,0.083,0.861],[-0.268,0.355,-0.26,-0.194,0.107,-0.233,-0.079,-0.294,0.596,-0.429,-0.018,0.01],[-0.318,0.018,0.363,-0.099,-0.628,-0.169,-0.512,-0.211,-0.088,0.093,-0.104,0.004],[-0.275,0.344,-0.238,-0.463,0.118,-0.426,0.116,0.249,-0.412,0.306,0.03,-0.005],[-0.258,0.047,0.455,0.385,0.228,-0.352,-0.071,0.571,0.185,-0.128,0.133,-0.002],[-0.294,0.316,-0.241,0.001,-0.126,0.686,-0.253,0.448,0.042,-0.017,0.04,-0.005],[-0.314,0.034,0.373,-0.21,-0.289,0.209,0.756,-0.018,0.092,-0.094,0.023,-0.003],[-0.271,0.354,-0.202,0.722,-0.059,-0.046,0.201,-0.34,-0.232,0.144,-0.041,-0.001],[-0.283,0.065,0.418,-0.149,0.647,0.305,-0.179,-0.368,-0.159,0.108,-0.063,0.002]],""selectVec"":[[-0.295,-0.361,-0.176],[-0.295,-0.36,-0.175],[-0.293,-0.363,-0.177],[-0.295,-0.361,-0.176],[-0.268,0.355,-0.26],[-0.318,0.018,0.363],[-0.275,0.344,-0.238],[-0.258,0.047,0.455],[-0.294,0.316,-0.241],[-0.314,0.034,0.373],[-0.271,0.354,-0.202],[-0.283,0.065,0.418]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":6016,""AfterCleanSamNum"":4645,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机C运行"",""alarmcondition"":""[d1_10hfe30aj001xq01]>10""},""copy"":false,""principal"":""3"",""precision"":""98.1%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":152,""version"":""v-2025-12-09 11:13:03"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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