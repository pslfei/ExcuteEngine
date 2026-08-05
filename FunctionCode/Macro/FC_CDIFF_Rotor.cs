using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("CDIFF_Rotor")]
	[FCDisplay("")]
	public partial class CDIFF_Rotor : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽温度、压力")]
		public LA Tcc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽温度、压力")]
		public LA Pcc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，汽缸内壁温度")]
		public LA Tqg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，转数")]
		public LA RpM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期ms")]
		public LA dTime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，有限元数学模型")]
		public CDIFF_Modal uMM = new CDIFF_Modal();


		[PinType(PinTypes.Constant)]
		[PinDisplay("输入，初始温度场")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] TT = new float[16];


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大应力")]
		public LA AVSTR = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，安全系数")]
		public LA ASTR = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子表面金属温度")]
		public LA ASURT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子中心孔金属温度")]
		public LA ABORT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子平均温度")]
		public LA AVOLT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，计算无效标志")]
		public LD DSTRINV;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetThermalPro TP = new GetThermalPro();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetStressPro SP = new GetStressPro();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetAlfa ALFA = new GetAlfa();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float af_;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float LAMD;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float AA;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float EE;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float BATA;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Mu;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] Co = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] Ri_1 = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] Ri_2 = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] A = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] B = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] C = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] D = new float[16];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float strL;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float strR;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float d_time;

	}
}
