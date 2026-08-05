using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HS4SEL2")]
	[FCDisplay("")]
	public partial class HS4SEL2 : Function
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


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号4")]
		public LD B4;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，结果输出端")]
		public LD DV;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_50 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_54 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_55 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_53 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_52 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_51 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_68 = new OR();
	}
}
