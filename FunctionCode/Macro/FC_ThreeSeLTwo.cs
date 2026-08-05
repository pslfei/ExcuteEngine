using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("ThreeSeLTwo")]
	[FCDisplay("三选二功能块")]
	public partial class ThreeSeLTwo : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "三选二功能块";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD IN1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD IN2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD IN3;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD OUT;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_1 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_5 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_8 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_12 = new OR();
	}
}
