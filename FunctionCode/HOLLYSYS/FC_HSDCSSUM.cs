using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSDCSSUM")]
	[FCDisplay("开关量变态次数累积")]
	public partial class HSDCSSUM : Function 
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*待监测开关值*)")]
		public LD I1;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*复位端*)")]
		public LD RS;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*当前值*)")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*统计类型,0上升沿、1下降沿、2全统计*)")]
		public byte SL = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次的I1值")]
        private bool OLD_I1;

	}
}
