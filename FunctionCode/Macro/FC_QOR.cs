using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("QOR")]
	[FCDisplay("")]
    public partial class QOR : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD DI1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD DI2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD DI3;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD DV;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_2 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_6 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_9 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_11 = new AND();
	}
}
