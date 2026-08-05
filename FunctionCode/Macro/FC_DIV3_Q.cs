using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DIV3_Q")]
	[FCDisplay("")]
	public partial class DIV3_Q : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第一点信号")]
		public LA A1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二点信号")]
		public LA A2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三点信号")]
		public LA A3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第一点信号品质坏")]
		public LD B1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二点信号品质坏")]
		public LD B2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三点信号品质坏")]
		public LD B3;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，平均输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_1 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_3 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_5 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_7 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_10 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_11 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_12 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_19 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MAX MAX_20 = new MAX();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_22 = new DIV();
	}
}
