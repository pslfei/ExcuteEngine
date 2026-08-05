using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("TETRIP")]
	[FCDisplay("温度信号跳闸处理")]
	public partial class TETRIP : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "温度信号跳闸处理";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，温度信号")]
		public LA TE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，跳闸定值")]
		public LA SP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，温度信号跳闸输出")]
		public LD TRIP;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，速率限制")]
		public HSRATELIM A = new HSRATELIM();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，滞后")]
		public TON B = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，定宽")]
		public TP TP = new TP();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，脉宽设顶")]
		public float DW = 0.25f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS01 = new RS();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float SP1 = 2f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_22 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_6 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_11 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_12 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_14 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_8 = new AND();
	}
}
