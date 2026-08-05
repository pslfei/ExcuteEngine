using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("UINT_TO_BOOL")]
    [FCDisplay("UINT_TO_BOOL")]
    public partial class UINT_TO_BOOL : Function 
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		private LD _ENO;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
        private LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD OUT;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
        public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	}
}
