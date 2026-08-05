using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DQTZ")]
	[FCDisplay("信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警，同时屏蔽保护，用于保护")]
	public partial class DQTZ : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警，同时屏蔽保护，用于保护";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，信号")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，保护动作信号")]
		public LD TZ;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，变化率设定")]
		public float RL = 100f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号正常范围上限，不是量程上限")]
		public float H;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号正常范围下限，不是量程下限")]
		public float L;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，保护动作值，信号高动作")]
		public float HH;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ZLRT RT_1 = new ZLRT();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_12 = new GE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_18 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_13 = new AND();
	}
}
