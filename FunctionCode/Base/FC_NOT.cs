using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("NOT")]
	[FCDisplay("Âß¼­·Ç")]
	public partial class NOT : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("ÊäÈë")]
		public LD IN = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("Êä³ö")]
		public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

    }
}
