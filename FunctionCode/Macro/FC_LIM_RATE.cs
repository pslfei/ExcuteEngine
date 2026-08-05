using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("LIM_RATE")]
	[FCDisplay("速率限制")]
	public partial class LIM_RATE : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "速率限制";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入端")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，限制开关；为TRUE时，不限制")]
		public LD SW;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，计算结果")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，正向限制值，HL>=0")]
		public float HL;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，反向限制值，LL>=0")]
		public float LL;

	}
}
