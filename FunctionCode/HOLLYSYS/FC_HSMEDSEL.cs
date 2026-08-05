using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSMEDSEL")]
	[FCDisplay("三取中")]
	public partial class HSMEDSEL : Function 
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
		[PinDisplay("(*模拟量1输入端*)")]
		public LA X1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*模拟量1报警*)")]
        public LD A1;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*模拟量2输入端*)")]
        public LA X2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*模拟量2 报警*)")]
        public LD A2;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*模拟量3输入端*)")]
        public LA X3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*模拟量3 报警*)")]
        public LD A3;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*工作模式")]
        public LA MD = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("偏差限")]
        public LA DB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*当前值输出端*)")]
        public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*第一个模入点的品质输出*)")]
        public LD Q1;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*第 二个模入点的品质输出*)")]
        public LD Q2;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*第三个模入点的品质输出*)")]
        public LD Q3;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*品质输出*)")]
        public LD QQ;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*品质输出*)")]
        public LD Q0;

	}
}
