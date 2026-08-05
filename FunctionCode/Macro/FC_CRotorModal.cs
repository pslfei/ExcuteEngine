using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("CRotorModal")]
	[FCDisplay("")]
	public partial class CRotorModal : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Constant)]
		[PinDisplay("输入，蒸汽温度")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
		public float[] tcc = new float[12];


        [PinType(PinTypes.Constant)]
		[PinDisplay("输入，蒸汽压力")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
		public float[] pcc = new float[12];


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，抽汽级")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
		public short[] RN = new short[4];


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，转数")]
		public LA RpM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期ms")]
		public LA dTime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，有限元数学模型")]
		public CFEM_Modal uMM = new CFEM_Modal();


        [PinType(PinTypes.Constant)]
		[PinDisplay("输入，初始温度场")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125)]
		public float[] TT = new float[125];


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


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，蒸汽温度")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31)]
		public float[] VTcc = new float[31];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，蒸汽压力")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 31)]
		public float[] VPcc = new float[31];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float delt;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float delp;


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
		public short j;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short m;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short e;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Ni;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Nj;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Nk;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Mt;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Mc;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Tev;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Tecf;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Pecf;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short N;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short l;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short p;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short q;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short II;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short JJ;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short It;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Jt;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Ik;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Jk;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Rj;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Rk;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Dk;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float T1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float T11;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float P1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float P11;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Io;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Jo;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short LL1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short M1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short M2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short M3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short Rt;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 800)]
		public float[] K = new float[800];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125)]
		public float[] U = new float[125];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125)]
		public float[] PE = new float[125];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
		public float[] KE1 = new float[9];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
		public float[] KE = new float[9];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
		public float[] NKE = new float[9];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
		public float[] TU = new float[9];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
		public float[] TE = new float[3];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float dti;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float dpi;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float d_time;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float temp;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float ss;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float strL;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float strR;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，计算标志码")]
		public short ICOUNT;

	}
}
