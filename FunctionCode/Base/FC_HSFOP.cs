using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSFOP")]
	[FCDisplay("一阶惯性")]
	public partial class HSFOP : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("(*输入*)")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*时间*)")]
		public float TC = 1.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*增益*)")]
		public float KG = 1.0f;

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的输出值")]
        private float OLD_AV;
	}
}
