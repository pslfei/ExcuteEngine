using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DIV5_Q")]
	[FCDisplay("模入平均值，根据品质来去除坏值")]
	public partial class DIV5_Q : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "模入平均值，根据品质来去除坏值";

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
		[PinDisplay("输入，第四点信号")]
		public LA A4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第五点信号")]
		public LA A5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第一点信号品质坏")]
		public LD B1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二点信号品质坏")]
		public LD B2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三点信号品质坏")]
		public LD B3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第四点信号品质坏")]
		public LD B4;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第五点信号品质坏")]
		public LD B5;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，平均输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_46 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_49 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_52 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_55 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_82 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_56 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_47 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_50 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_53 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_57 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_84 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_58 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MAX MAX_79 = new MAX();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_59 = new DIV();
	}
}
