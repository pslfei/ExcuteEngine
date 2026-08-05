using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetAlfa")]
	[FCDisplay("")]
	public partial class GetAlfa : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽温度")]
		public LA T = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽压力")]
		public LA P = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，轴封齿数")]
		public LA N = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，转子半径")]
		public LA Dk = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，轴封进口压力")]
		public LA PN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，轴封出口压力")]
		public LA PM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，边界类型")]
		public LA Mc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA alfa = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float V;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float U;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Cp;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Q;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float V1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float V2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float V3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float A1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Q1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float U1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float X;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float LAMD1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float T1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float C1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float C2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float w;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float H;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float WS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ro;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ao;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float P1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float P2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Pt;

	}
}
