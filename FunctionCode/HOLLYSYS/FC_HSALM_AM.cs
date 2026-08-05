using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSALM_AM")]
	[FCDisplay("幅值报警")]
	public partial class HSALM_AM : Function 
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
		[PinDisplay("(*输入端*)")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*报警上上限*)")]
		public LA HH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 10000000000.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*报警上限*)")]
		public LA AH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1000000000.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*报警下下限*)")]
		public LA LL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, -10000000000.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*报警下限*)")]
		public LA AL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, -1000000000.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*报警死区*)")]
		public LA DI = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*报警输出*)")]
		public LD DV;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*报警状态*)")]
		public LA AM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*上上限报警*)")]
		public LD AMHH;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*上限报警*)")]
		public LD AMH;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*下下限报警*)")]
		public LD AMLL;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*下限报警*)")]
		public LD AML;

	}
}
