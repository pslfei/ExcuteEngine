using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DXDQ")]
	[FCDisplay("信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警,同时信号保持,用于保护和自动调节")]
	public partial class DXDQ : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警,同时信号保持,用于保护和自动调节";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，信号选择值")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，品质信号：当输入信号超过信号品质上限值或变化率超过40,将产生DQ信号 ，用于报警")]
		public LD DQ;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，用于设备报警信号： 当输入信号正常且超过信号保护值上限,将产生此报警信号*")]
		public LD BJH;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，用于设备报警信号： 当输入信号正常且超过信号保护值下限,将产生此报警信号*")]
		public LD BJL;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，用于设备保护信号： 当输入信号正常且超过信号保护值上上限,将产生此保护信号*")]
		public LD BHHH;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，用于设备保护信号： 当输入信号正常且超过信号保护值下下限,将产生此保护信号*")]
		public LD BHLL;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号故障后选择的预设值，可以更改")]
		public float A = 5f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号品质上限值")]
		public float MU = 2000f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号品质下限值")]
		public float MD = -2000f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号保护值上限")]
		public float H = 70f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号保护值下限")]
		public float L = -15f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号保护值上上限")]
		public float HH = 80f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号保护值下下限")]
		public float LL = -10f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，可根据不同的需要,修改和定义内部参数")]
		public HSALM_RT ZLRT = new HSALM_RT();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，信号越限、超速故障RS01")]
		public RS DXDQRS01 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，信号越限、超速故障RS02")]
		public RS DXDQRS02 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，信号越限、超速故障恢复TON01")]
		public TON DXDQTON01 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，模拟量信号惯性处理")]
		public HSFOP DXDQFOP01 = new HSFOP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_21 = new GE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LE LE_22 = new LE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_23 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_26 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_74 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_75 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_37 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_38 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_58 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_90 = new SEL();
	}
}
