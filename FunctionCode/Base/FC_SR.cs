using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SR")]
	[FCDisplay("Bistable function, set dominant")]
	public partial class SR : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LD SET1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LD RESET = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("")]
		public LD Q1 = new LD(QualityTypes.Good, false, false, false, 0, false);

    }
}
