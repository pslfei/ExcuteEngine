using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("P1FM_11")]
	[FCDisplay("回路自动调节强制手动判断")]
    public partial class P1FM_11 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "回路自动调节强制手动判断";

        [PinType(PinTypes.Input)]
		[PinDisplay("变量，PID主调")]
		public HSPID PID1 = new HSPID();


        [PinType(PinTypes.Input)]
		[PinDisplay("变量，手操器")]
		public HSAlgMAN MAN = new HSAlgMAN();


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，强制手动判定附加项")]
		public LD FM1;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，手操器强制手动开关")]
		public LD FM;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，手操器自动切手动报警")]
		public LD AM;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，偏差报警偏差限%")]
		public float DV = 10f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SR SR_01 = new SR();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_35 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")] 
		public LT LT_37 = new LT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_38 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_41 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ABS ABS_42 = new ABS();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_55 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_56 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_57 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_43 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_44 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_49 = new AND();
	}
}
