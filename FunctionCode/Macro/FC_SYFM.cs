using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SYFM")]
	[FCDisplay("送/引风机进出口门逻辑：单侧风机停运时，关闭自身的进出口门；两侧风机均停时，打开双风机的进出口门")]
	public partial class SYFM : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "送/引风机进出口门逻辑：单侧风机停运时，关闭自身的进出口门；两侧风机均停时，打开双风机的进出口门";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，A风机运行")]
		public LD DI1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，B风机运行")]
		public LD DI2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，A风机停运")]
		public LD DI3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，B风机停运")]
		public LD DI4;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，关A风机进出口门")]
		public LD DO1;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，关B风机进出口门")]
		public LD DO2;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，开A/B风机进出口门")]
		public LD DO3;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，RS01")]
		public RS RS01 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，RS01")]
		public RS RS02 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，TON01两侧风机均停时打开进出口门的时间")]
		public TON TON01 = new TON();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float TI = 15f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_49 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_56 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_51 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_53 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_69 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_66 = new AND();
	}
}
