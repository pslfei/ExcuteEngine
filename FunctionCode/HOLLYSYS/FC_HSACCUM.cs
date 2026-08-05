using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSACCUM")]
	[FCDisplay("积算算法")]
	public partial class HSACCUM : Function 
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
		[PinDisplay("(*模拟量输入端*)")]
		public LA I1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*复位信号*)")]
		public LD RS;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*计算结果*)")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*选择结果,0:小于量程, 1:到达量程*)")]
		public LD SS;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*计算初值，初值为0*)")]
		public float IV = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*计算总量，初值为64为浮点数，1.79769313486232E308*)")]
		public double MS = 1.79E308;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*仪表因子，初值为1*)")]
		public float MC = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次复位信号值")]
        private bool OLD_RS;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次计算结果")]
        private float OLD_AV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("是否为正数累积方式。TRUE, 则不累积负的输入值")]
        private bool bPositiveAccum;
	}
}
