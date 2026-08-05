using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetRation")]
	[FCDisplay("求解变化率")]
	public partial class GetRation : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "求解变化率";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，参数当前值")]
		public LA AMV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，变化周期ms")]
		public LA AMDT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，参数变化率s")]
		public LA AMRATION = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，历史采样值")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
		public float[] Value = new float[4];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，采样计数")]
		public short iCNT;

	}
}
