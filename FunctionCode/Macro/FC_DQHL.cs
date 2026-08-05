using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DQHL")]
	[FCDisplay("信号品质检查：实现用模拟量输入信号超过高、低限报警")]
	public partial class DQHL : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "信号品质检查：实现用模拟量输入信号超过高、低限报警";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，信号")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，信号无超速时发生高限报警")]
		public LD OH;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，信号无超速时发生低限报警")]
		public LD OL;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，高限报警")]
		public float HH;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，低限报警")]
		public float LL;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSALM_RT RT_1 = new HSALM_RT();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，速率限值")]
		public float HL = 50f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_39 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_30 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public NOT NOT_41 = new NOT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_33 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_38 = new GE();
	}
}
