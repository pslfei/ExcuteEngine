using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("RS")]
	[FCDisplay("Bistable function, reset dominant")]
	public partial class RS : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LD SET = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LD RESET1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("")]
		public LD Q1 = new LD(QualityTypes.Good, false, false, false, 0, false);

    }
}
