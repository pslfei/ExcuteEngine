using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SLC1")]
	[FCDisplay("联锁投切")]
	public partial class SLC1 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "联锁投切";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动投入输入")]
		public LD AON;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动投入输入")]
		public LD MON;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动切除输入")]
		public LD AOFF;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动切除输入")]
		public LD MOFF;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，外部锁闭输入")]
		public LD BL;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动闭锁输入")]
		public LD MBL;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，投入输出")]
		public LD ON;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，切除输出")]
		public LD OFF;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS1 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS2 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS3 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON1 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON2 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TOF TOF1 = new TOF();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP1 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_7 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_25 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_23 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_18 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_9 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_26 = new AND();
	}
}
