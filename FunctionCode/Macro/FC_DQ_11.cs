using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DQ_11")]
	[FCDisplay("信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警，信号保持，品质信号用来闭锁保护")]
    public partial class DQ_11 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警，信号保持，品质信号用来闭锁保护";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入信号所在模块状态，TRUE好，FALSE坏")]
		public LD BD = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，信号品质坏")]
		public LD DQ;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public bool RS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，输入正常高限，或量程上限")]
		public float H = 100f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，输入正常低限，或量程下限")]
		public float L = 0f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS1 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSFOP INFOP = new HSFOP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSHLLIM HSHLLIM01 = new HSHLLIM();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_110 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_111 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_10 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_67 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_6 = new SEL();
	}
}
