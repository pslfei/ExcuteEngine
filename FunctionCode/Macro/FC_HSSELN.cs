using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSSELN")]
	[FCDisplay("")]
    public partial class HSSELN : Function
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


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号7")]
		public LD B7;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号8")]
		public LD B8;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，结果输出端")]
		public LD DV;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short NM = 2;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_8 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_9 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_10 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_11 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_13 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_14 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_20 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_INT BOOL_TO_INT_21 = new BOOL_TO_INT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_15 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_16 = new GE();
	}
}
