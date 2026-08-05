using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSVALVE5")]
	[FCDisplay("远程调节门")]
	public partial class HSVALVE5 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "远程调节门";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，反馈信号，需上传")]
		public LA ZT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动开命令")]
		public LD AO;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动关命令")]
		public LD AC;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，阀门开指令")]
		public LD DV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，阀门关指令")]
		public LD RV;


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
		[PinDisplay("规格数，阀位指令信号设定")]
		public float MS = 0f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，检修挂牌命令")]
		public bool JC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，开关脉冲宽度，短脉冲时间MS")]
		public float T1 = 250f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，脉冲周期，间隔MS")]
		public float T2 = 1600f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，长脉冲时间MS")]
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
		public LT LT_39 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_40 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_41 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_43 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_95 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_373 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_374 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_375 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_376 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_378 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_379 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_380 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_381 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_383 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_384 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_385 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_386 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_387 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_388 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_389 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_391 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_392 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_393 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_394 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_395 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_397 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_398 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_400 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_405 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_406 = new REAL_TO_TIME();
	}
}
