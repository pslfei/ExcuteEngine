using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("ZLRT")]
	[FCDisplay("速率及超限报警")]
	public partial class ZLRT : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "速率及超限报警";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入端")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，速率上限")]
		public LA RL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 100f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入正常高限，或量程上限")]
		public LA H = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 100f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入正常低限，或量程下限")]
		public LA L = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出端")]
		public LD DV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，超限报警，不处理")]
		public LD FI;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，间隔周期数")]
		public uint DP = 2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，超速周期数，滞后保持周期")]
		public uint AP = 40;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，运算周期数")]
		public uint SP = 10;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，持续周期数")]
		public uint LC = 0;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，存放前十周期的输入值区")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10)]
		public float[] IK = new float[10];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public uint num = 0;

	}
}
