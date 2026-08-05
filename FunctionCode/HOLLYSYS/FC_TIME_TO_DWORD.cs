using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("TIME_TO_DWORD")]
	[FCDisplay("")]
	public partial class TIME_TO_DWORD : Function 
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("Ëã·¨¿éµÄÃèÊö")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Output)]
		[PinDisplay("0")]
        public LD _ENO;

		[PinType(PinTypes.Input)]
		[PinDisplay("0")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

		[PinType(PinTypes.Output)]
		[PinDisplay("0")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("0")]
        public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	}
}
