using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("CFEM_Modal")]
	[FCDisplay("")]
	public partial class CFEM_Modal : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，节点坐标")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 250)]
		public float[] YX = new float[250];


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，单元编号")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 640)]
		public short[] EP = new short[640];


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，边界编号")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 210)]
		public short[] TBI = new short[210];


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，截面编号")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 60)]
		public short[] XII = new short[60];


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，节点总数")]
		public LA Nmax = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，单元总数")]
		public LA Emax = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，边界总数")]
		public LA NBorder = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，截面总数")]
		public LA Nset = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，危险截面、节点号")]
		public LA Calcset  = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，危险截面、节点号")]
		public LA Mark = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，应力集中系数")]
		public LA Kth = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetStressPro SP = new GetStressPro();


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
		public float Ec;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ec1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ec2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ec3;


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
		public float COFE;


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
		public short Mt;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ai;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Bi;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ci;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Aj;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Bj;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Cj;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Am;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Bm;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Cm;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float eArea;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Si;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Ro;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float Zo;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float s1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float s2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 125)]
		public short[] Ka = new short[125];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short KLT;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short DISR;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1440)]
		public float[] V_KE = new float[1440];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1440)]
		public float[] V_NKE = new float[1440];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 1440)]
		public float[] V_KE1 = new float[1440];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 320)]
		public float[] V_PE = new float[320];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11)]
		public float[] V_Rs = new float[11];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，模型初始化标志")]
		public bool bInitioned;

	}
}
