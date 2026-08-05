using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSSC3")]
	[FCDisplay("")]
	public partial class HSSC3 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入1")]
		public LD I1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入2")]
		public LD I2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入3")]
		public LD I3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入4")]
		public LD I4;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入5")]
		public LD I5;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入6")]
		public LD I6;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入7")]
		public LD I7;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入8")]
		public LD I8;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入9")]
		public LD I9;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入10")]
		public LD I10;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入11")]
		public LD I11;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入12")]
		public LD I12;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入13")]
		public LD I13;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入14")]
		public LD I14;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入15")]
		public LD I15;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，首出复位")]
		public LD I16;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出1")]
		public LD O1;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出2")]
		public LD O2;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出3")]
		public LD O3;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出4")]
		public LD O4;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出5")]
		public LD O5;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出6")]
		public LD O6;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出7")]
		public LD O7;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出8")]
		public LD O8;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出9")]
		public LD O9;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出10")]
		public LD O10;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出11")]
		public LD O11;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出12")]
		public LD O12;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出13")]
		public LD O13;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出14")]
		public LD O14;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出15")]
		public LD O15;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，首出指示")]
		public LD O16;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS1 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS2 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS3 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS4 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS5 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS6 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS7 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS8 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS9 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS10 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS11 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS12 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS13 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS14 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS15 = new RS();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，复位中间点")]
		public bool I17;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_5 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_85 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_7 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_9 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_11 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_13 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_15 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_17 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_19 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_21 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_23 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_25 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_27 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_29 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_31 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_33 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_124 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_140 = new AND();
	}
}
