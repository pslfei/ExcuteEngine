using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SEL_OUT")]
	[FCDisplay("输出选择")]
    public partial class SEL_OUT : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "输出选择";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入")]
		public LD IN;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，选择条件")]
		public LD SE;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，当选择条件为TRUE，在该脚输出")]
		public LD V1;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，当选择条件为FALSE，在该脚输出")]
		public LD V2;

	}
}
