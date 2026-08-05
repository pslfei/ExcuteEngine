using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HS3SEL2")]
	[FCDisplay("")]
	public partial class HS3SEL2 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号1")]
		public LD B1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号2")]
		public LD B2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号3")]
		public LD B3;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，结果输出端")]
		public LD DV;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_20 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_21 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_22 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_23 = new OR();
	}
}
