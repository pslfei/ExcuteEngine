using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("TETRIP_42")]
	[FCDisplay("龙岩温度信号跳闸处理")]
	public partial class TETRIP_42 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "龙岩温度信号跳闸处理";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，温度信号")]
		public LA TE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，跳闸定值")]
		public LA SP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，温度信号跳闸输出")]
		public LD TRIP;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，速率限制")]
		public HSRATELIM A = new HSRATELIM();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，滞后")]
		public TON B = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，定宽")]
		public TP TP = new TP();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，脉宽设顶")]
		public float DW = 0.25f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP01 = new TP();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，调试命令，为真时，解除速率闭锁条件，调试完后，一定要使其为：FALSE，慎用，")]
		public bool SY;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS01 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS02 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，速率报警")]
		public HSALM_RT CTE_RT = new HSALM_RT();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_64 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_66 = new GE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_68 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_71 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_72 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_73 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_74 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_77 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_78 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_81 = new AND();
	}
}
