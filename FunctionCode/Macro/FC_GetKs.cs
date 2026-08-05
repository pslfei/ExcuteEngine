using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetKs")]
	[FCDisplay("求解塑性应变集中系数")]
	public partial class GetKs : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "求解塑性应变集中系数";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，屈服极限比")]
		public LA D = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，热应力集中系数")]
		public LA Kth = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，塑性应变集中系数")]
		public LA Ks = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short iCol;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short iRow;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float dPrev;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float dNext;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
		public float[] xCo = new float[8] { 0f, 0.2f, 0.4f, 0.6f, 0.8f, 1.0f, 1.2f, 1.4f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 5)]
		public float[] yCo = new float[5] { 0f, 1.5f, 2f, 3f, 4.5f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40)]
		public float[] Ko = new float[40] { 0f, 0f, 0f, 0f, 0f, 0f, 0f, 0f, 1.5f, 1.5f, 1.5f, 1.625f, 1.875f, 2.0f, 2.2f, 2.25f, 2.15f, 2.125f, 2.25f, 2.625f, 3.0f, 3.25f, 3.625f, 3.75f, 3.1f, 3.0f, 3.25f, 4.25f, 5.25f, 5.75f, 6.25f, 6.75f, 4.4f, 4.375f, 4.8f, 6f, 7f, 7.875f, 8.75f, 9.25f };

	}
}
