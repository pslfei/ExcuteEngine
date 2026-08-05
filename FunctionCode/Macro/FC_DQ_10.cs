using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DQ_10")]
	[FCDisplay("信号品质检查：实现用模拟量输入信号超过高、低限和变化太快时报警，信号保持，品质信号用来闭锁保护")]
	public partial class DQ_10 : Function
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


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动复位选项MR为TRUE时，需要手动复位，为FALSE时，自动复位")]
		public LD RS;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，信号品质坏")]
		public LD DQ;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，变化率设定")]
		public float RL = 100f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，输入正常高限，或量程上限")]
		public float H = 100f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，输入正常低限，或量程下限")]
		public float L = 0f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动复位选项，为TRUE时，需要手动复位，为FALSE时，自动复位")]
		public bool MR;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，变化率报警")]
		public bool ZR;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号超限")]
		public bool ZL;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号超限")]
		public bool ZL_1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号超限")]
		public bool ZL_2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，变化率处理功能块")]
		public ZLRT RT1 = new ZLRT();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，置位优先")]
		public SR SR1 = new SR();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public TON TON_1 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_10 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_67 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_31 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_68 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_6 = new SEL();
	}
}
