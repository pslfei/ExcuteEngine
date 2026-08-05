using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("test111")]
	[FCDisplay("右侧屏过泄漏故障1")]
	public partial class test111 : Function
	{
		//[PinType(PinTypes.Constant)]
		//[PinDisplay("算法块的描述")]
		//[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		//public string Description = "右侧屏过泄漏故障";

		[PinType(PinTypes.Input)]
		[PinDisplay("算法块是否可用")]
		public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入1")]
		public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入2")]
		public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入3")]
		public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入4")]
		public LA IN4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入5")]
		public LA IN5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入6")]
		public LA IN6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入7")]
		public LA IN7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入8")]
		public LA IN8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入9")]
		public LA IN9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入10")]
		public LA IN10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入11")]
		public LA IN11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入12")]
		public LA IN12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入13")]
		public LA IN13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入14")]
		public LA IN14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入15")]
		public LA IN15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float H1 = 80f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float H2 = 2f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float H3 = 30f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float H4 = 0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float L1 = 10f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float L2 = -10f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public int TIME1 = 20;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public int TIME2 = 40;

		[PinType(PinTypes.Constant)]
		[PinDisplay("采样间隔")]
		public int SampleInterval = 60;
		
		[PinType(PinTypes.Output)]
		[PinDisplay("OUT")]
		public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Output)]
		[PinDisplay("_ENO")]
		public LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Internal)]
        [PinDisplay("1")]
        public SUB SUB_1 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("2")]
        public ABS ABS_2 = new ABS();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public LT LT_3 = new LT();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public GT GT_7 = new GT();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public GT GT_9 = new GT();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SIMUSUMIDFCURR SIMUSUMIDFCURR_4 = new SIMUSUMIDFCURR();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public DISTATS DISTATS_6 = new DISTATS();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public HSAISW HSAISW_10 = new HSAISW();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SUB SUB_8 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public ADD4 ADD4_12 = new ADD4();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SUB SUB_11 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public GT GT_13 = new GT();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SUB SUB_14 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SUB SUB_15 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SUB SUB_16 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public SUB SUB_17 = new SUB();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public MAX MAX_18 = new MAX();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public MAX MAX_19 = new MAX();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public MAX MAX_20 = new MAX();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public LT LT_21 = new LT();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public GT GT_25 = new GT();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public MOVAVG MOVAVG_22 = new MOVAVG();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public MOVAVG MOVAVG_23 = new MOVAVG();

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public MIN MIN_5 = new MIN();

    }
}
