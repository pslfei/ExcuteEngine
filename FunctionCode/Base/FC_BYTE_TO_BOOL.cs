using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("BYTE_TO_BOOL")]
	[FCDisplay("BYTE_TO_BOOL")]
	public partial class BYTE_TO_BOOL : Function 
	{
		[PinType(PinTypes.Output)]
		[PinDisplay(" ‰≥ˆ")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay(" ‰»Î")]
        public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	}
}
