using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using TDServer.Service;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PCA294")]
    [FCDisplay("PCA294")]
    public partial class PCA294 : WarnFunction
    {
	    [PinType(PinTypes.Input)]
	    [PinDisplay("给水流量大于600")]
	    public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("锅炉主给水流量1")]
	    public LAExWarn IN1 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("锅炉主给水流量2")]
	    public LAExWarn IN2 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("锅炉主给水流量3")]
	    public LAExWarn IN3 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后锅炉主给水流量")]
	    public LAExWarn IN4 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("省煤器入口给水流量1")]
	    public LAExWarn IN5 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("省煤器入口给水流量2")]
	    public LAExWarn IN6 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("省煤器入口给水流量3")]
	    public LAExWarn IN7 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Input)]
	    [PinDisplay("选择后锅炉主给水流量")]
	    public LAExWarn IN8 = new LAExWarn(QualityTypes.Good,false,"",float.MaxValue, float.MinValue,0,0,0,0,0, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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
	    [PinDisplay("")]
	    public LA OUT_ste = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] TempOUT_W = new bool[8] {false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public bool[] OldTempOUT_W = new bool[8] {false,false,false,false,false,false,false,false};

	    [PinType(PinTypes.Constant)]
	    [PinDisplay("")]
	    public long[] StartTime = new long[8] {-1,-1,-1,-1,-1,-1,-1,-1};

		public PCA294()
		{
			ModelID = 320;
			SysID = 7;
			FcType = enumType.Warn;
			FcName = "PCA294";
			FcCode = "PCA";
		}

	    protected override void Run(ICommand cmd)
	    {
	        string ModelInfo = @"{""id"":""320"",""name"":""PCA294"",""description"":""给水流量"",""founder"":""admin"",""creatTime"":""2024-03-07 16:04:43"",""Modifier"":""admin"",""modifiedTime"":""2025-12-04 15:10:27"",""algorithm"":""PCA"",""sampling"":""300"",""monitor"":null,""trainTime"":[{""st"":""2025-11-07 21:10:02"",""et"":""2025-11-23 17:17:40"",""duration"":1368458,""number"":4562,""filter"":90,""mode"":4472,""id"":null,""load"":null,""temp"":null,""LAY_TABLE_INDEX"":1,""limitnumber"":0,""conditionnumber"":0}],""model_state"":"""",""pointInfo"":[{""PointId"":""d1_fwflow1"",""Description"":""锅炉主给水流量1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""128.73"",""lowerBound"":""-128.73"",""LAY_TABLE_INDEX"":1,""type"":null,""TMax"":""2907.61"",""TMin"":""601.30"",""TAvg"":""1518.44"",""DMax"":""36.97"",""DMin"":""0.00"",""DAvg"":""2.06"",""C95"":""9.27"",""C99"":""11.55""},{""PointId"":""d1_fwflow2"",""Description"":""锅炉主给水流量2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""126.82"",""lowerBound"":""-126.82"",""LAY_TABLE_INDEX"":2,""type"":null,""TMax"":""2912.22"",""TMin"":""610.04"",""TAvg"":""1523.39"",""DMax"":""40.09"",""DMin"":""0.00"",""DAvg"":""2.10"",""C95"":""9.41"",""C99"":""11.73""},{""PointId"":""d1_fwflow3"",""Description"":""锅炉主给水流量3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""130.92"",""lowerBound"":""-130.92"",""LAY_TABLE_INDEX"":3,""type"":null,""TMax"":""2905.30"",""TMin"":""584.24"",""TAvg"":""1509.75"",""DMax"":""36.98"",""DMin"":""0.00"",""DAvg"":""2.33"",""C95"":""9.96"",""C99"":""12.37""},{""PointId"":""d1_fwflow"",""Description"":""选择后锅炉主给水流量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""128.73"",""lowerBound"":""-128.73"",""LAY_TABLE_INDEX"":4,""type"":null,""TMax"":""2907.62"",""TMin"":""601.21"",""TAvg"":""1518.44"",""DMax"":""36.33"",""DMin"":""0.00"",""DAvg"":""2.06"",""C95"":""9.27"",""C99"":""11.55""},{""PointId"":""d1_10lab70cf101_c"",""Description"":""省煤器入口给水流量1"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""129.12"",""lowerBound"":""-129.12"",""LAY_TABLE_INDEX"":5,""type"":null,""TMax"":""2909.19"",""TMin"":""598.23"",""TAvg"":""1518.30"",""DMax"":""62.66"",""DMin"":""0.00"",""DAvg"":""2.86"",""C95"":""13.38"",""C99"":""16.71""},{""PointId"":""d1_10lab70cf102_c"",""Description"":""省煤器入口给水流量2"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""127.17"",""lowerBound"":""-127.17"",""LAY_TABLE_INDEX"":6,""type"":null,""TMax"":""2913.90"",""TMin"":""607.24"",""TAvg"":""1523.25"",""DMax"":""62.37"",""DMin"":""0.00"",""DAvg"":""2.95"",""C95"":""13.52"",""C99"":""16.86""},{""PointId"":""d1_10lab70cf103_c"",""Description"":""省煤器入口给水流量3"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""131.21"",""lowerBound"":""-131.21"",""LAY_TABLE_INDEX"":7,""type"":null,""TMax"":""2907.04"",""TMin"":""579.33"",""TAvg"":""1509.59"",""DMax"":""64.11"",""DMin"":""0.00"",""DAvg"":""3.01"",""C95"":""13.68"",""C99"":""17.05""},{""PointId"":""d1_d24p003"",""Description"":""选择后锅炉主给水流量"",""Unit"":"""",""Upper"":"""",""Lower"":"""",""dead"":false,""limit"":false,""Lock"":false,""upperBound"":""129.59"",""lowerBound"":""-129.59"",""LAY_TABLE_INDEX"":8,""type"":null,""TMax"":""2907.79"",""TMin"":""572.97"",""TAvg"":""1518.44"",""DMax"":""121.05"",""DMin"":""0.00"",""DAvg"":""3.61"",""C95"":""15.44"",""C99"":""19.19""}],""outPointInfo"":null,""biasPointInfo"":null,""faultVariablePointInfo"":null,""btmState"":""已下装"",""version"":""v-2025-12-04 15:10:27"",""smote"":null,""online"":1,""unit"":null,""versionNumber"":0,""Envelopes"":null,""samrangenew"":null,""para"":{""Model_info"":{""Train_X_min"":[601.299,610.041,584.242,601.205,598.234,607.241,579.33,572.974],""Train_X_max"":[2907.608,2912.218,2905.302,2907.616,2909.192,2913.898,2907.042,2907.794],""Train_X_std"":[637.053,635.766,640.161,637.055,637.333,636.036,640.444,637.025],""Train_X_mean"":[1518.439,1523.394,1509.751,1518.436,1518.301,1523.253,1509.591,1518.44],""Train_X_bais_max"":[[36.966,40.093,36.98,36.332,62.658,62.372,64.107,121.053]],""Train_X_bais_min"":[[0.001,0.0,0.0,0.0,0.0,0.002,0.0,0.001]],""Train_X_bais_mean"":[[2.064,2.101,2.329,2.064,2.864,2.951,3.007,3.607]],""QCUL_95"":0.0014504639,""QCUL_99"":0.0024998493,""QCUL_95_line"":[9.272,9.413,9.959,9.273,13.382,13.516,13.678,15.442],""QCUL_99_line"":[11.552,11.726,12.373,11.553,16.71,16.857,17.054,19.186],""T2CUL_95"":3.844,""T2CUL_99"":6.642,""T2CUL_95_line"":[18.678,18.641,18.77,18.678,18.687,18.649,18.778,18.678],""T2CUL_99_line"":[24.551,24.502,24.671,24.551,24.562,24.512,24.682,24.55],""Kesi_95"":1.563,""Kesi_99"":1.346,""Kesi_95_line"":[11.909,11.885,11.968,11.909,11.915,11.89,11.973,11.909],""Kesi_99_line"":[11.054,11.031,11.108,11.054,11.059,11.036,11.113,11.053],""COV"":[[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0],[1.0,1.0,1.0,1.0,1.0,1.0,1.0,1.0]],""K"":1,""R"":1.0,""featValue"":[8.001,0.0,0.0,0.0,0.0,0.0,0.0,0.0],""featVec"":[[0.354,0.295,-0.192,-0.109,0.36,-0.098,0.404,0.661],[0.354,0.296,-0.184,-0.368,-0.605,-0.262,-0.414,0.109],[0.354,0.301,-0.204,0.58,-0.021,0.583,-0.256,-0.033],[0.354,0.295,-0.19,-0.121,0.268,-0.228,0.265,-0.737],[0.354,-0.453,-0.044,-0.184,0.536,-0.048,-0.585,0.029],[0.354,-0.455,-0.047,-0.381,-0.279,0.538,0.386,-0.067],[0.354,-0.453,-0.059,0.568,-0.258,-0.488,0.196,0.037],[0.354,0.175,0.919,0.015,-0.001,0.003,0.004,0.0]],""selectVec"":[[0.354],[0.354],[0.354],[0.354],[0.354],[0.354],[0.354],[0.354]]},""Model_type"":""PCA"",""BeforeCleanSamNum"":4562,""AfterCleanSamNum"":4472,""CleanOrNot"":true},""alarmmodelset"":{""alarmname"":""给水流量大于600"",""alarmcondition"":""[d1_fwflow]>600""},""copy"":false,""principal"":""1"",""precision"":""100%"",""rate"":""0.98"",""iter"":""800"",""layer"":""5"",""component"":null,""count"":null,""version1"":""1""}";
	        string InputInfo = @"{""Model_id"":320,""version"":""v-2025-12-04 15:10:27"",""Test_Data"":[[" + IN1 + "," + IN2 + "," + IN3 + "," + IN4 + "," + IN5 + "," + IN6 + "," + IN7 + "," + IN8 + "]],\"Target_Data\":[[]]}";
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
	        OUT_ste[0] = index[0];

			LAExWarn[] arrIN = new LAExWarn[8] {IN1,IN2,IN3,IN4,IN5,IN6,IN7,IN8};
			float[] arrOUT_B = new float[8] {OUT_B1,OUT_B2,OUT_B3,OUT_B4,OUT_B5,OUT_B6,OUT_B7,OUT_B8};
			LD[] arrOUT_W = new LD[8] { OUT_W1,OUT_W2,OUT_W3,OUT_W4,OUT_W5,OUT_W6,OUT_W7,OUT_W8 };
			
	        if (!(Condition1>600))
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