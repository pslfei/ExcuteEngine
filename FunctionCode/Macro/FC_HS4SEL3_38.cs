using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HS4SEL3_38")]
	[FCDisplay("")]
    public partial class HS4SEL3_38 : Function
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
		public BOOL_TO_INT BOOL_TO_INT_41 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_42 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_43 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_44 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_45 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_46 = new GE();
	}
}
