using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("OptimizeLoad")]
	[FCDisplay("")]
	public partial class OptimizeLoad : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，当前应力系数")]
		public LA str = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，预测应力系数")]
		public LA fstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，应力值是/否有效")]
		public LD strinv;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，当前负荷")]
		public LA load = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期/ms")]
		public LA dtime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，实际升负荷率/min")]
		public LA loadrate = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，建议升负荷率/min")]
		public LA oloadrate = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，有效性")]
		public LD dinv;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short CNT;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetRation RT = new GetRation();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，升/降负荷率列表MW/min")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11)]
		public float[] LoadStage = new float[11] { 0f, 1.5f, 3.0f, 4.5f, 6.0f, 7.5f, 9.0f, 10.5f, 12.0f, 13.5f, 15.0f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，速率级")]
		public short iID;

	}
}
