using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSALM_DV")]
	[FCDisplay("偏差报警")]
	public partial class HSALM_DV : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("(*输入端1*)")]
		public LA I1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*输入端2*)")]
		public LA I2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*正偏差限*)")]
		public LA HL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1000000000.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*负偏差限*)")]
		public LA LL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1000000000.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*报警输出*)")]
		public LD DV = new LD(QualityTypes.Good, false, false, false, 0, false);

    }
}
