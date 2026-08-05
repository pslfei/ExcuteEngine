using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSBAL2")]
	[FCDisplay("双平衡模块")]
	public partial class HSBAL2 : Function 
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
		[PinDisplay("(*控制指令*)")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*偏置*)")]
		public LA IOF = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*ZT1值，A阀反馈*)")]
		public LA Z1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*ZT2值，B阀反馈*)")]
		public LA Z2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*DM1值，A阀AM状态（报警状态）*)")]
		public LD D1;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*DM2值，B阀AM状态*)")]
		public LD D2;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*A阀指令*)")]
		public LA O1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*B阀指令*)")]
		public LA O2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*正向限制值*)")]
		public float HL = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*反向限制值*)")]
		public float LL = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*变化率限制*)")]
		public float OUTR = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次的O1值")]
        private float OLD_O1;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次的O2值")]
        private float OLD_O2;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次的IOF值")]
        private float OLD_IOF;

	}
}
