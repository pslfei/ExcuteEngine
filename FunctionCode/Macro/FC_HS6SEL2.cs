using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HS6SEL2")]
	[FCDisplay("")]
	public partial class HS6SEL2 : Function
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


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号5")]
		public LD B5;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号6")]
		public LD B6;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，结果输出端")]
		public LD DV;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_50 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_54 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_55 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_53 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_52 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_51 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_68 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_97 = new GE();
	}
}
