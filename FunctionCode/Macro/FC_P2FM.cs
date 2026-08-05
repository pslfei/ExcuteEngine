using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("P2FM")]
	[FCDisplay("回路自动调节强制手动判断")]
	public partial class P2FM : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "回路自动调节强制手动判断";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，PID主调")]
		public HSPID PID1 = new HSPID();


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，PID副调")]
		public HSPID PID2 = new HSPID();


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手操器")]
		public HSAlgMAN MAN = new HSAlgMAN();


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，强制手动判定附加项")]
		public LD FM1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，强制手动判定附加项")]
		public LD FM2;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，手操器强制手动开关")]
		public LD FM;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，偏差报警偏差限")]
		public float DV = 10f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_4 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_11 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_6 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_8 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public LT LT_16 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_13 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_20 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ABS ABS_21 = new ABS();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_22 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_30 = new OR();
	}
}
