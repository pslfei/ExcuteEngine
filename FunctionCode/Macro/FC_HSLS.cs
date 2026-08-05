using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSLS")]
	[FCDisplay("两设备中一设备跳闸联启另一设备用，联锁条件为设备跳闸外的其他条件")]
	public partial class HSLS : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "两设备中一设备跳闸联启另一设备用，联锁条件为设备跳闸外的其他条件";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，联锁投入按钮")]
		public LD IN1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，A设备运行状态")]
		public LD INA;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，B设备运行状态")]
		public LD INB;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，联锁条件")]
		public LD IN2;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，联锁投入指示")]
		public LD OUT;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，A设备联锁启动")]
		public LD OUTA;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，B设备联锁启动")]
		public LD OUTB;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP01 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP02 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP03 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP04 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LS LS01 = new LS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON05 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON TON06 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_16 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public NOT NOT_19 = new NOT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_21 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_23 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_24 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_26 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public NOT NOT_28 = new NOT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_30 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_31 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_33 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_34 = new AND();
	}
}
