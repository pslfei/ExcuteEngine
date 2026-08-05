using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("JONSI1")]
	[FCDisplay("")]
	public partial class JONSI1 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，模拟量输入")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，常数高限")]
		public LA HH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，常数低限")]
		public LA LL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，常数低限")]
		public LD BD;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，高限输出")]
		public LD OH;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，低限输出")]
		public LD OL;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，模拟量输出")]
		public LA AO = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD DQ;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，坏点切除")]
		public DQ1 DQ_1 = new DQ1();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，坏点切除高限")]
		public float H;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，坏点切除低限")]
		public float L;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，速率判断")]
		public float RL;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_12 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_16 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_25 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_27 = new AND();
	}
}
