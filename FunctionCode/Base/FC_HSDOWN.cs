using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSDOWN")]
	[FCDisplay("下降沿触发")]
	public partial class HSDOWN : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD IN = new LD(QualityTypes.Good, false, false, false,0,false);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD OUT = new LD(QualityTypes.Good, false, false, false,0,false);

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的输入值")]
        private bool OLD_IN;
	}
}
