using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetNf")]
	[FCDisplay("计算疲劳循环周次")]
	public partial class GetNf : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "计算疲劳循环周次";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA Ke = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA Nf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short iID;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float temp;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18)]
		public float[] aN = new float[18] { 0.16f, 0.18f, 0.21f, 0.24f, 0.3f, 0.4f, 0.58f, 1.0f, 4.3f, 6.0f, 8.8f, 12f, 20f, 40f, 90f, 300f, 2000f, 5000f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 18)]
		public float[] aStrain = new float[18] { 0.09f, 0.08f, 0.07f, 0.06f, 0.05f, 0.04f, 0.03f, 0.02f, 0.01f, 0.009f, 0.008f, 0.007f, 0.006f, 0.005f, 0.004f, 0.003f, 0.002f, 0.001f };

	}
}
