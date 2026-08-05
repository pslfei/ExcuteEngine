using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA139")]
    [FCDisplay("PCA139")]
    public partial class PCA139 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机运行")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口风粉混合物温度")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A分离器风粉混合物温度1")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A分离器风粉混合物温度2")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A分离器风粉混合物温度3")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A11侧燃烧器壁温")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A12侧燃烧器壁温")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A21侧燃烧器壁温")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A22侧燃烧器壁温")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A31侧燃烧器壁温")]
	    public LAExWarn IN9 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A32侧燃烧器壁温")]
	    public LAExWarn IN10 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A41侧燃烧器壁温")]
	    public LAExWarn IN11 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("磨煤机A出口A42侧燃烧器壁温")]
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

		public PCA139()
		{
			ModelID = 149;
			SysID = 32;
			FcType = enumType.Warn;
			FcName = "PCA139";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""149"",""name"":""PCA139"",""description"":""PCA139"",""founder"":""admin"",""creatTime"":""2023-10-30 14:44:00"",""Modifier"":""admin"",""modifiedTime"":""2025-12-09 10:57:32"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-13 09:34:46"",""et"":""2025-12-09 10:29:24"",""duration"":2249678,""number"":7499,""filter"":4865,""mode"":2634,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":4775}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_amillot"",""Description"":""磨煤机A出口风粉混合物温度"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.29"",""lowerBound"":""-0.29"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""88.22"",""TMin"":""52.78"",""TAvg"":""74.11"",""DMax"":""0.68"",""DMin"":""0.00"",""DAvg"":""0.06"",""C95"":""0.24"",""C99"":""0.29""},{""PointId"":""d1_10hfc10ct111r"",""Description"":""磨煤机A分离器风粉混合物温度1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.60"",""lowerBound"":""-0.60"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""89.01"",""TMin"":""52.04"",""TAvg"":""74.00"",""DMax"":""2.04"",""DMin"":""0.00"",""DAvg"":""0.11"",""C95"":""0.48"",""C99"":""0.59""},{""PointId"":""d1_10hfc10ct112r"",""Description"":""磨煤机A分离器风粉混合物温度2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.55"",""lowerBound"":""-0.55"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""87.72"",""TMin"":""52.41"",""TAvg"":""74.78"",""DMax"":""1.46"",""DMin"":""0.00"",""DAvg"":""0.12"",""C95"":""0.45"",""C99"":""0.55""},{""PointId"":""d1_10hfc10ct113r"",""Description"":""磨煤机A分离器风粉混合物温度3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""0.39"",""lowerBound"":""-0.39"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""88.47"",""TMin"":""52.50"",""TAvg"":""74.08"",""DMax"":""1.88"",""DMin"":""0.00"",""DAvg"":""0.07"",""C95"":""0.31"",""C99"":""0.39""},{""PointId"":""d1_10hhe10ct101k"",""Description"":""磨煤机A出口A11侧燃烧器壁温"",""Unit"":"""",""Upper"":""111"",""Lower"":""5"",""dead"":false,""limit"":true,""Lock"":false,""upperBound"":""2.16"",""lowerBound"":""-2.16"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""73.80"",""TMin"":""23.42"",""TAvg"":""66.76"",""DMax"":""5.77"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""1.23"",""C99"":""1.53""},{""PointId"":""d1_10hhe10ct102k"",""Description"":""磨煤机A出口A12侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""5.09"",""lowerBound"":""-5.09"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""168.19"",""TMin"":""23.64"",""TAvg"":""68.41"",""DMax"":""19.29"",""DMin"":""0.00"",""DAvg"":""0.65"",""C95"":""3.83"",""C99"":""4.83""},{""PointId"":""d1_10hhe10ct103k"",""Description"":""磨煤机A出口A21侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.92"",""lowerBound"":""-1.92"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""140.27"",""TMin"":""24.44"",""TAvg"":""66.78"",""DMax"":""21.48"",""DMin"":""0.00"",""DAvg"":""0.48"",""C95"":""2.94"",""C99"":""3.72""},{""PointId"":""d1_10hhe10ct104k"",""Description"":""磨煤机A出口A22侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.63"",""lowerBound"":""-1.63"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""74.15"",""TMin"":""24.61"",""TAvg"":""66.39"",""DMax"":""14.39"",""DMin"":""0.00"",""DAvg"":""0.36"",""C95"":""2.34"",""C99"":""2.97""},{""PointId"":""d1_10hhe10ct105k"",""Description"":""磨煤机A出口A31侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""2.10"",""lowerBound"":""-2.10"",""LAY_TABLE_INDEX"":9,""type"":null,""TMax"":""90.15"",""TMin"":""23.16"",""TAvg"":""66.21"",""DMax"":""8.86"",""DMin"":""0.00"",""DAvg"":""0.32"",""C95"":""1.59"",""C99"":""1.98""},{""PointId"":""d1_10hhe10ct106k"",""Description"":""磨煤机A出口A32侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""4.51"",""lowerBound"":""-4.51"",""LAY_TABLE_INDEX"":10,""type"":null,""TMax"":""145.24"",""TMin"":""24.43"",""TAvg"":""67.37"",""DMax"":""21.67"",""DMin"":""0.00"",""DAvg"":""0.71"",""C95"":""4.36"",""C99"":""5.51""},{""PointId"":""d1_10hhe10ct107k"",""Description"":""磨煤机A出口A41侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""3.74"",""lowerBound"":""-3.74"",""LAY_TABLE_INDEX"":11,""type"":null,""TMax"":""73.59"",""TMin"":""24.21"",""TAvg"":""66.60"",""DMax"":""10.13"",""DMin"":""0.00"",""DAvg"":""0.30"",""C95"":""1.49"",""C99"":""1.87""},{""PointId"":""d1_10hhe10ct108k"",""Description"":""磨煤机A出口A42侧燃烧器壁温"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""1.61"",""lowerBound"":""-1.61"",""LAY_TABLE_INDEX"":12,""type"":null,""TMax"":""110.29"",""TMin"":""24.68"",""TAvg"":""67.95"",""DMax"":""15.55"",""DMin"":""0.00"",""DAvg"":""0.27"",""C95"":""1.78"",""C99"":""2.25""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-09 10:57:32"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[52.776,52.041,52.413,52.503,23.418,23.644,24.435,24.613,23.156,24.431,24.206,24.683],""Train_X_max"":[88.218,89.014,87.716,88.465,73.801,168.188,140.265,74.153,90.154,145.235,73.585,110.293],""Train_X_std"":[3.951,4.036,4.015,3.943,6.846,8.417,6.889,6.321,6.792,7.409,6.984,6.532],""Train_X_mean"":[74.106,74.003,74.78,74.084,66.755,68.412,66.783,66.386,66.214,67.372,66.596,67.947],""Train_X_bais_max"":[[0.679,2.038,1.461,1.882,5.772,19.289,21.48,14.394,8.861,21.669,10.126,15.547]],""Train_X_bais_min"":[[0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0,0.0]],""Train_X_bais_mean"":[[0.059,0.107,0.12,0.069,0.272,0.649,0.48,0.362,0.324,0.708,0.295,0.271]],""QCUL_95"":0.603972852,""QCUL_99"":1.04125524,""QCUL_95_line"":[0.235,0.477,0.448,0.313,1.225,3.827,2.941,2.342,1.585,4.359,1.488,1.775],""QCUL_99_line"":[0.29,0.594,0.551,0.39,1.527,4.833,3.72,2.969,1.984,5.514,1.866,2.251],""T2CUL_95"":9.516,""T2CUL_99"":13.326,""T2CUL_95_line"":[0.238,0.243,0.242,0.237,0.412,0.507,0.415,0.38,0.409,0.446,0.42,0.393],""T2CUL_99_line"":[0.281,0.287,0.286,0.281,0.488,0.599,0.491,0.45,0.484,0.528,0.497,0.465],""Kesi_95"":1.588,""Kesi_99"":1.376,""Kesi_95_line"":[0.097,0.099,0.099,0.097,0.168,0.207,0.169,0.155,0.167,0.182,0.172,0.161],""Kesi_99_line"":[0.09,0.092,0.092,0.09,0.157,0.193,0.158,0.145,0.155,0.17,0.16,0.149],""COV"":[[1.0,0.999,0.999,1.0,0.622,0.101,0.481,0.647,0.595,0.17,0.617,0.436],[0.999,1.0,0.998,0.998,0.617,0.098,0.475,0.64,0.587,0.163,0.611,0.43],[0.999,0.998,1.0,0.998,0.631,0.104,0.488,0.655,0.602,0.173,0.625,0.442],[1.0,0.998,0.998,1.0,0.62,0.102,0.48,0.646,0.595,0.172,0.617,0.435],[0.622,0.617,0.631,0.62,1.0,0.316,0.823,0.978,0.969,0.288,0.996,0.744],[0.101,0.098,0.104,0.102,0.316,1.0,0.634,0.273,0.42,0.894,0.297,0.668],[0.481,0.475,0.488,0.48,0.823,0.634,1.0,0.75,0.905,0.613,0.796,0.657],[0.647,0.64,0.655,0.646,0.978,0.273,0.75,1.0,0.942,0.292,0.983,0.755],[0.595,0.587,0.602,0.595,0.969,0.42,0.905,0.942,1.0,0.432,0.966,0.723],[0.17,0.163,0.173,0.172,0.288,0.894,0.613,0.292,0.432,1.0,0.283,0.572],[0.617,0.611,0.625,0.617,0.996,0.297,0.796,0.983,0.966,0.283,1.0,0.744],[0.436,0.43,0.442,0.435,0.744,0.668,0.657,0.755,0.723,0.572,0.744,1.0]],""K"":4,""R"":0.983,""featValue"":[7.813,2.4,1.208,0.383,0.131,0.039,0.013,0.009,0.003,0.003,0.001,0.0],""featVec"":[[-0.295,-0.321,-0.244,-0.002,-0.024,0.0,-0.032,0.033,0.182,-0.11,0.307,-0.78],[-0.293,-0.325,-0.246,-0.003,-0.047,0.032,-0.015,-0.06,-0.06,0.826,-0.206,0.11],[-0.297,-0.318,-0.236,-0.002,-0.018,0.0,0.07,-0.064,-0.469,-0.481,-0.54,0.058],[-0.295,-0.321,-0.245,-0.001,-0.015,-0.005,-0.059,0.093,0.343,-0.249,0.429,0.611],[-0.331,0.055,0.334,0.012,-0.047,0.195,0.045,-0.49,-0.507,0.036,0.483,0.044],[-0.157,0.491,-0.396,-0.072,-0.41,0.616,0.006,0.153,0.003,-0.021,-0.017,-0.003],[-0.298,0.25,0.046,0.563,-0.425,-0.449,0.328,-0.08,0.164,-0.005,-0.078,-0.002],[-0.329,0.025,0.314,-0.132,0.355,0.211,0.655,0.405,0.088,0.033,-0.052,-0.008],[-0.331,0.123,0.25,0.247,0.08,-0.076,-0.589,0.581,-0.231,0.035,0.02,-0.009],[-0.163,0.439,-0.462,0.149,0.686,-0.161,-0.03,-0.21,-0.03,0.016,0.043,0.004],[-0.328,0.049,0.345,-0.03,0.099,0.25,-0.317,-0.407,0.529,-0.087,-0.379,-0.025],[-0.277,0.263,0.002,-0.759,-0.182,-0.491,-0.055,0.012,-0.003,0.009,-0.009,0.0]],""selectVec"":[[-0.295,-0.321,-0.244,-0.002],[-0.293,-0.325,-0.246,-0.003],[-0.297,-0.318,-0.236,-0.002],[-0.295,-0.321,-0.245,-0.001],[-0.331,0.055,0.334,0.012],[-0.157,0.491,-0.396,-0.072],[-0.298,0.25,0.046,0.563],[-0.329,0.025,0.314,-0.132],[-0.331,0.123,0.25,0.247],[-0.163,0.439,-0.462,0.149],[-0.328,0.049,0.345,-0.03],[-0.277,0.263,0.002,-0.759]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":7499,""AfterCleanSamNum"":2627,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""磨煤机运行"",""alarmcondition"":""[d1_10hfe10aj001xq01]>10""},""copy"":false,""principal"":""4"",""precision"":""98.3%"",""rate"":""0.97"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":149,""version"":""v-2025-12-09 10:57:32"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "," + IN9 + "," + IN10 + "," + IN11 + "," + IN12 + "]],\"Target_Data\":[[]]}";
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