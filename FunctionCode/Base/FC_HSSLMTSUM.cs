using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSSLMTSUM")]
	[FCDisplay("定义模拟量越限时间累计器")]
	public partial class HSSLMTSUM : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LA I1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LD I1DQ;

		[PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LD RS;

		[PinType(PinTypes.Output)]
		[PinDisplay("")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("")]
		public LA AV1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float AH = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float AL = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
		public float SOF = 0.0f;

	}
}
