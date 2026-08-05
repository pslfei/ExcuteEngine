using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("FLOR")]
	[FCDisplay("")]
    public partial class FLOR : Function 
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
		[PinDisplay("输入")]
		public LD I1;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I2;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I3;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I4;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I5;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I6;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I7;

        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LD I8;

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD DV;
	}
}
