using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSALM_RT")]
	[FCDisplay("速率报警")]
	public partial class HSALM_RT : Function 
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
		[PinDisplay("输入端")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出端")]
		public LD DV;

		[PinType(PinTypes.Constant)]
		[PinDisplay("速率上限")]
		public float HL =1E9f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("间隔周期")]
		public int DP = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("超速周期")]
		public int AP = 10;

        [PinType(PinTypes.Constant)]
        [PinDisplay("持续周期")]
        private int LC;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的DV值")]
        private bool OLD_DV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("存放前十周期的输入值")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 10)]
        private float[] IK = new float[10];
	}
}
