using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SEL2_3")]
	[FCDisplay("")]
	public partial class SEL2_3 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD A;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD B;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD C;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD D;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_5 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_7 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_12 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_10 = new AND();
	}
}
