using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSPOLY")]
	[FCDisplay("多项式")]
	public partial class HSPOLY : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("(*模拟量输入端*)")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*计算结果*)")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*各阶系数*)")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 7)]
        public float[] CF = new float[7];

	}
}
