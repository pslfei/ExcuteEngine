using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("FL")]
	[FCDisplay("")]
	public partial class FL : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量差压信号Pa")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风温度信号")]
		public LA TE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量压力信号KPa")]
		public LA PT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，风量信号t/h")]
		public LA FT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，修正系统")]
		public float KT;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，当地大气压")]
		public float DDDQY;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_26 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SQRT SQRT_27 = new SQRT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_28 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_29 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_31 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_32 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_33 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_35 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_36 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_48 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_49 = new SEL();
	}
}
