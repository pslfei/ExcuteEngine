using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("F_TRIG")]
	[FCDisplay("Falling Edge detection")]
	public partial class F_TRIG : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("Signal to detect")]
		public LD CLK = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("Edge detected")]
		public LD Q = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public bool M;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的CLK值")]
        private bool OLD_CLK;
	}
}
