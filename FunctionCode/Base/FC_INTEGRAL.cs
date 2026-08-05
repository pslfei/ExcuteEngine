using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("INTEGRAL")]
	[FCDisplay("")]
	public partial class INTEGRAL : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay(" ‰»Î")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay(" ‰»Î")]
		public LA TM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
		private LD RESET = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay(" ‰≥ˆ")]
		public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float OLD_IN;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float A;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float B;
	}
}
