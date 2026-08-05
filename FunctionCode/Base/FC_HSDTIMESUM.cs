using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSDTIMESUM")]
	[FCDisplay("开关量状态时间累计器")]
	public partial class HSDTIMESUM : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("(*待监测开关值*)")]
		public LD I1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*复位端*)")]
		public LD RS = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*当前值,格式由SOF确定*)")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*当前值，单位ms*)")]
		public LA AV1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*AV的输出格式,0")]
        public byte SOF = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("输出选择")]
		public bool RB = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("累计值1")]
        private float L1;

        [PinType(PinTypes.Internal)]
        [PinDisplay("累计值0")]
        private float L0;

	}
}
