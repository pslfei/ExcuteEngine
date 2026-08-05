using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("FCSSysPer")]
	[FCDisplay("")]
    public partial class FCSSysPer : Function 
	{
		[PinType(PinTypes.Output)]
        [PinDisplay("负荷率, 百分数")]
        public LA load = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float bb;
	}
}
