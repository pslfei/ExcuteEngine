using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSCSLAVE5_11")]
	[FCDisplay("组合伺放")]
    public partial class HSCSLAVE5_11 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "组合伺放";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，指令信号设定或连调节器输出端，需上传")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，反馈信号，需上传")]
		public LA ZT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，PID过程值输入")]
		public LA PV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，切手动附加判断开关, 1-开, 0-关")]
		public LD FM;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动开命令")]
		public LD AO;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动关命令")]
		public LD AC;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，指令信号设定，中间点")]
		public LA MS = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，状态输出及手/自动设定端")]
		public LD AM;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，阀门开指令")]
		public LD DV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，阀门关指令")]
		public LD RV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，PID设定值输出")]
		public LA SP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，执行器故障及自动切手动中间点")]
		public LD GZ;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，运行方式。")]
		public byte RM;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动慢开脉冲指令MAN_OPEN：画面面板操作")]
		public bool MO;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动慢关脉冲指令MAN_CLOSE：画面面板操作")]
		public bool MC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动快开脉冲指令MAN_OPEN：画面面板操作")]
		public bool M1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动快关脉冲指令MAN_CLOSE：画面面板操作")]
		public bool M2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，检修挂牌命令")]
		public bool JC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，开关脉冲宽度，短脉冲时间ms")]
		public float T1 = 250f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，脉冲周期，间隔ms")]
		public float T2 = 1600f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，长脉冲时间ms")]
		public float T3 = 3000f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，伺放死区设置，可做在画面，由运行人员在1.5--10间修改")]
		public float DB = 2.5f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，连续宽脉冲死区设置，大于这个死区输出长脉冲，由运行人员在6--10间修改")]
		public float DL = 8f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP11 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP12 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP22 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TPMS = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP31 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP32 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TOF TOFZH = new TOF();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，可根据不同的需要，修改和定义内部参数")]
		public HSALM_RT ZLRT = new HSALM_RT();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，全开位置")]
		public float OT = 98f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，全关位置")]
		public float OB = 1f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，增加： 强制开关时跟踪滞后2秒复位，")]
		public bool AMZH;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，增加： 强制开关，当阀位反馈波动和不好时，使此项为TRUE，模拟量设定无效")]
		public bool QC;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_295 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_296 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_297 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_299 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_300 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_301 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_303 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_304 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_309 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_310 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_311 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_306 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_307 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_313 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_316 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_454 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_456 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_445 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_328 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_324 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_319 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_421 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_325 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_323 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_334 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_329 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_448 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_451 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_447 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_317 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_331 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_332 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_423 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_318 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_330 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_321 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_326 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_335 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_336 = new REAL_TO_TIME();
	}
}
