using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SLC_14")]
	[FCDisplay("联锁投切功能块")]
	public partial class SLC_14 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "联锁投切功能块";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动投入输入，不上传")]
		public LD AO;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动切除输入，不上传")]
		public LD AF;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，外部闭锁输入，不上传")]
		public LD BL;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动闭锁输入，不上传")]
		public LD MB;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，投入输出")]
		public LD ON;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS1 = new RS();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public bool DM001;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_7 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_25 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_9 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_26 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_23 = new OR();
	}
}
