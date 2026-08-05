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
		[PinType(PinTypes.Input)]
		[PinDisplay("输入端")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出端")]
		public LD DV = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Constant)]
		[PinDisplay("速率上限")]
		public float HL =1E9f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("间隔周期")]
		public int DP = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("超速周期")]
		public int AP = 10;

        [PinType(PinTypes.Output)]
        [PinDisplay("持续周期")]
        public LA LC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("当前IN和DP个周期前的IN偏差值")]
        public LA Dev = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("DP个周期前的IN")]
        public LA LastDPIN= new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的DV值")]
        private bool OLD_DV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("存放前十周期的输入值")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 28800)]
        private float[] IK = new float[28800];
	}
}
