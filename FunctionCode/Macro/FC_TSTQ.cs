using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("TSTQ")]
	[FCDisplay("模拟量信号超限判断")]
	public partial class TSTQ : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "模拟量信号超限判断";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，模拟量信号输入")]
		public LA I1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，超限报警输出")]
		public LD DV;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，量程上限")]
		public float MU;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，量程下限")]
		public float MD;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，故障允许偏差")]
		public float P5 = 0.05f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，故障允许值")]
		public float A5;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，故障滤波时间")]
		public TON TON1 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_12 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ABS ABS_13 = new ABS();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_14 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_18 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_1 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_20 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_7 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_4 = new OR();
	}
}
