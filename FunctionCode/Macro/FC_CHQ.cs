using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("CHQ")]
	[FCDisplay("")]
	public partial class CHQ : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，吹灰器在原位")]
		public LD V2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控选择            0-运行  1-停止")]
		public LD SE;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控指令")]
		public LD CK;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，完成")]
		public LD SO;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSUP UP01 = new HSUP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，完成触发器")]
		public RS R1 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP01 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_12 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_3 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_13 = new OR();
	}
}
