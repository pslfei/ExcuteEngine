using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("TON")]
	[FCDisplay("Timer on delay")]
	public partial class TON : Function 
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
		[PinDisplay("")]
		public LD IN;

		[PinType(PinTypes.Input)]
		[PinDisplay("")]
		public LA PT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("")]
		public LD Q;

		[PinType(PinTypes.Output)]
		[PinDisplay("")]
		public LA ET = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Internal)]
        [PinDisplay("脉冲开始时间")]
        private float StartTime;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private bool StartTON;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的IN值")]
        private bool OLD_IN;
	}
}
