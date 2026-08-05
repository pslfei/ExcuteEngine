using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("BOOL_TO_INT")]
	[FCDisplay("BOOL_TO_INT")]
	public partial class BOOL_TO_INT : Function
	{ 
		[PinType(PinTypes.Output)]
		[PinDisplay(" ‰≥ˆ")]
		public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay(" ‰»Î")]
        public LD IN = new LD(QualityTypes.Good, false, false, false, 0, false);

    }
}
