using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("FALARMSPARK")]
	[FCDisplay("")]
    public partial class FALARMSPARK : Function
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
        [PinDisplay("报警触发源")]
		public LD I1;

        [PinType(PinTypes.Input)]
        [PinDisplay("确认输入")]
        public LD I2;

        [PinType(PinTypes.Output)]
        [PinDisplay("表示报警正发生已确认")]
        public LD O1;

        [PinType(PinTypes.Output)]
        [PinDisplay("表示报警正发生未确认")]
        public LD O2;

        [PinType(PinTypes.Output)]
        [PinDisplay("表示报警曾发生未确认")]
        public LD O3;

        [PinType(PinTypes.Internal)]
        public bool OLD_I1;

        [PinType(PinTypes.Internal)]
        public bool unack;
	}
}
