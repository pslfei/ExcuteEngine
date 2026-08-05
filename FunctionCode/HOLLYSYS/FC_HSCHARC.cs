using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSCHARC")]
	[FCDisplay("折线函数")]
	public partial class HSCHARC : Function 
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
		public LA I1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出端")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("错误信息 1：折点个数超范围；2：X值非递增；3：输入值非法")]
		public LA eRR = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("折点个数1<=PS<=11")]
		public int PS = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("对应第1折点至第11折点X值")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11)]
		public float[] XX = new float[11];

		[PinType(PinTypes.Constant)]
		[PinDisplay("对应第1折点至第11折点Y值")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11)]
		public float[] YY = new float[11];

	}
}
