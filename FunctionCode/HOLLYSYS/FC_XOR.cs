using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("XOR")]
	[FCDisplay("逻辑异或")]
	public partial class XOR : Function 
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入1")]
		public LD IN1;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入2")]
		public LD IN2;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入3")]
		public LD IN3;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入4")]
		public LD IN4;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入5")]
		public LD IN5;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入6")]
		public LD IN6;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入7")]
		public LD IN7;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入8")]
		public LD IN8;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入9")]
		public LD IN9;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入10")]
		public LD IN10;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入11")]
		public LD IN11;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入12")]
		public LD IN12;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入13")]
		public LD IN13;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入14")]
		public LD IN14;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入15")]
		public LD IN15;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入16")]
		public LD IN16;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入17")]
		public LD IN17;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入18")]
		public LD IN18;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入19")]
		public LD IN19;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入20")]
		public LD IN20;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入21")]
		public LD IN21;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入22")]
		public LD IN22;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入23")]
		public LD IN23;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入24")]
		public LD IN24;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入25")]
		public LD IN25;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入26")]
		public LD IN26;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入27")]
		public LD IN27;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入28")]
		public LD IN28;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入29")]
		public LD IN29;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入30")]
		public LD IN30;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入31")]
		public LD IN31;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入32")]
		public LD IN32;

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD OUT;

	}
}
