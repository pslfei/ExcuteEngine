using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSTIMER")]
	[FCDisplay("定时器")]
	public partial class HSTIMER : Function 
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
		[PinDisplay("启动信号")]
		public LD SS;

		[PinType(PinTypes.Input)]
		[PinDisplay("复位信号")]
		public LD RS;

		[PinType(PinTypes.Input)]
		[PinDisplay("时间常数")]
		public LA TC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出值")]
		public LD DV;

		[PinType(PinTypes.Constant)]
		[PinDisplay("定时器类型")]
		public int TT = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("前一状态的SS值")]
        private bool OLD_SS;

        [PinType(PinTypes.Internal)]
        [PinDisplay("前一状态的RS值")]
        private bool OLD_RS;

        [PinType(PinTypes.Internal)]
        [PinDisplay("开始时间")]
        private float StartTime;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private bool Start;
	}
}
