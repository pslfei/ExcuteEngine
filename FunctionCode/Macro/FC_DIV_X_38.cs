using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DIV_X_38")]
	[FCDisplay("模入平均值，自动去除坏值")]
    public partial class DIV_X_38 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "模入平均值，自动去除坏值";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA A1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA A2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA A3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA A4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_45 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_46 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_47 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_48 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_49 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_50 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_51 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_52 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_53 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_54 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_55 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_56 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_57 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_58 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_59 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MAX MAX_79 = new MAX();
	}
}
