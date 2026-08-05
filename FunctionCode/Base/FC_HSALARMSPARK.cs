using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("HSALARMSPARK")]
	[FCDisplay("")]
    public partial class HSALARMSPARK : Function
	{
		[PinType(PinTypes.Input)]
        [PinDisplay("报警触发源")]
		public LD I1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("确认输入")]
        public LD I2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("表示报警正发生已确认")]
        public LD O1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("表示报警正发生未确认")]
        public LD O2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("表示报警曾发生未确认")]
        public LD O3 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Internal)]
        public bool OLD_I1;

        [PinType(PinTypes.Internal)]
        public bool unack;
	}
}
