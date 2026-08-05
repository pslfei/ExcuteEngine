using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DQFOP_38")]
	[FCDisplay("信号品质检查：实现用模拟量输入信号超过高、低限时报警，用于自动调节中信号处理")]
    public partial class DQFOP_38 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "信号品质检查：实现用模拟量输入信号超过高、低限时报警，用于自动调节中信号处理";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，信号")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出信号")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，品质信号：当输入信号超过定义的上下限，将产生DQ坏信号")]
		public LD DQ;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号上限")]
		public float H;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号下限")]
		public float L;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSFOP INFOP = new HSFOP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_2 = new GE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_3 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_5 = new OR();
	}
}
