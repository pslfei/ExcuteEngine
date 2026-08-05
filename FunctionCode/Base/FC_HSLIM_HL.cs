using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSLIM_HL")]
	[FCDisplay("幅值限制")]
	public partial class HSLIM_HL : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("(*输入信号*)")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*上限值*)")]
		public float HL = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*下限值*)")]
		public float LL = 0.0f;

		[PinType(PinTypes.Output)]
		[PinDisplay("输出信号")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	}
}
