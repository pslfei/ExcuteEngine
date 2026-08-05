using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("LS1")]
	[FCDisplay("")]
	public partial class LS1 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，联锁投入")]
		public LD IN;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，联锁投入允许")]
		public LD YX;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，联锁复位")]
		public LD RS;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，联锁状态")]
		public LD OUT;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS01 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON01 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON02 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON03 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_19 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_9 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_13 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_11 = new OR();
	}
}
