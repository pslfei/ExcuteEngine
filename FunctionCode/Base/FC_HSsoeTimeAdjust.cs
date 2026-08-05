using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSsoeTimeAdjust")]
	[FCDisplay("SOE的系统校时")]
	public partial class HSsoeTimeAdjust : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("秒s4byte")]
		private LA stime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("时间是否有效1-有效，0-无效")]
        private float bValid = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("存在GPS校时集线器对模件校时，1--存在，0-不存在")]
        private bool bGPS = false;
	}
}
