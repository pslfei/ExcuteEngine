using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HLL")]
	[FCDisplay("")]
	public partial class HLL : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA HL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA LL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_1 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_2 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_3 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_4 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_5 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_6 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_7 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_8 = new GT();
	}
}
