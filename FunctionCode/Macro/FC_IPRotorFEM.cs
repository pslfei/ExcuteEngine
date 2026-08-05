using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("IPRotorFEM")]
	[FCDisplay("")]
	public partial class IPRotorFEM : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，再热蒸汽温度、压力")]
		public LA tzr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，再热蒸汽温度、压力")]
		public LA pzr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸前轴封蒸汽温度、压力")]
		public LA tqzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸前轴封蒸汽温度、压力")]
		public LA pqzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压第一级蒸汽温度、压力")]
		public LA tyl1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压第一级蒸汽温度、压力")]
		public LA pyl1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第3#抽汽温度、压力")]
		public LA tcq3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第3#抽汽温度、压力")]
		public LA pcq3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第4#抽汽温度、压力")]
		public LA tcq4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第4#抽汽温度、压力")]
		public LA pcq4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第5#抽汽温度、压力")]
		public LA tcq5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第5#抽汽温度、压力")]
		public LA pcq5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第5#抽汽温度、压力")]
		public LA tcq6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸第5#抽汽温度、压力")]
		public LA pcq6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸排汽温度、压力")]
		public LA tpq = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸排汽温度、压力")]
		public LA ppq = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸后轴封蒸汽温度、压力")]
		public LA thzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸后轴封蒸汽温度、压力")]
		public LA phzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸前、后轴端温度")]
		public LA tqzd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸前、后轴端温度")]
		public LA thzd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，中压缸内壁温度")]
		public LA tqg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，转速")]
		public LA rpM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期ms")]
		public LA dtime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大热应力")]
		public LA ipvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大热应力比率")]
		public LA ipstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，预测最大热应力")]
		public LA ipfvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，预测最大热应力比率")]
		public LA ipfstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，中压缸转子表面温度")]
		public LA ipsurt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，中压缸转子中心孔温度")]
		public LA ipbort = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，中压缸转子体积平均温度")]
		public LA ipvolt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("输出，中压缸转子温度场")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 109)]
		public float[] iptRotor = new float[109];


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，中压缸转子应力计算无效")]
		public LD ipstrinv;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short j;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，蒸汽温度")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
		public float[] tcc = new float[12];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，蒸汽压力")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
		public float[] pcc = new float[12];


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，节点总数")]
		public short Nmax = 109;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，单元总数")]
		public short Emax = 160;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，边界总数")]
		public short Nborder = 21;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，截面总数")]
		public short Nset = 17;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，危险截面序号")]
		public short Calcset = 7;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，危险节点序号")]
		public short Mark = 39;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，热应力集中系数")]
		public float Kth = 2.2f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 218)]
		public float[] YX = new float[218] { 75f, 0f, 180f, 0f, 285f, 0f, 390f, 0f, 495f, 0f, 75f, 60f, 180f, 60f, 285f, 60f, 390f, 60f, 495f, 60f, 75f, 120f, 180f, 120f, 285f, 120f, 390f, 120f, 495f, 120f, 75f, 220f, 180f, 220f, 285f, 220f, 390f, 220f, 495f, 220f, 75f, 320f, 180f, 320f, 285f, 320f, 390f, 320f, 495f, 320f, 575f, 320f, 655f, 320f, 75f, 365f, 180f, 365f, 285f, 365f, 390f, 365f, 495f, 365f, 575f, 365f, 655f, 365f, 75f, 410f, 180f, 410f, 285f, 410f, 390f, 410f, 495f, 410f, 575f, 410f, 655f, 410f, 75f, 530f, 180f, 530f, 285f, 530f, 390f, 530f, 495f, 530f, 575f, 530f, 655f, 530f, 75f, 575f, 180f, 575f, 285f, 575f, 390f, 575f, 495f, 575f, 575f, 575f, 655f, 575f, 75f, 620f, 180f, 620f, 285f, 620f, 390f, 620f, 495f, 620f, 575f, 620f, 655f, 620f, 75f, 740f, 180f, 740f, 285f, 740f, 390f, 740f, 495f, 740f, 575f, 740f, 655f, 740f, 75f, 785f, 180f, 785f, 285f, 785f, 390f, 785f, 495f, 785f, 575f, 785f, 655f, 785f, 75f, 830f, 180f, 830f, 285f, 830f, 390f, 830f, 495f, 830f, 575f, 830f, 655f, 830f, 75f, 950f, 180f, 950f, 285f, 950f, 390f, 950f, 495f, 950f, 575f, 950f, 655f, 950f, 75f, 995f, 180f, 995f, 285f, 995f, 390f, 995f, 495f, 995f, 575f, 995f, 655f, 995f, 75f, 1040f, 180f, 1040f, 285f, 1040f, 390f, 1040f, 495f, 1040f, 575f, 1040f, 655f, 1040f, 75f, 1160f, 180f, 1160f, 285f, 1160f, 390f, 1160f, 495f, 1160f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 640)]
		public short[] EP = new short[640] { 7, 1, 2, 1, 7, 2, 3, 1, 8, 3, 4, 1, 9, 4, 5, 1, 9, 5, 10, 2, 9, 10, 15, 2, 14, 15, 20, 3, 19, 20, 25, 3, 32, 25, 26, 4, 33, 26, 27, 4, 33, 27, 34, 5, 33, 34, 41, 5, 33, 41, 40, 6, 32, 40, 39, 6, 38, 39, 46, 7, 53, 46, 47, 8, 54, 47, 48, 8, 54, 48, 55, 9, 54, 55, 62, 9, 54, 62, 61, 10, 53, 61, 60, 10, 59, 60, 67, 11, 74, 67, 68, 12, 75, 68, 69, 12, 75, 69, 76, 13, 75, 76, 83, 13, 75, 83, 82, 14, 74, 82, 81, 14, 80, 81, 88, 15, 95, 88, 89, 16, 96, 89, 90, 16, 96, 90, 97, 17, 96, 97, 104, 17, 96, 104, 103, 18, 95, 103, 102, 18, 101, 102, 109, 19, 101, 109, 108, 20, 100, 108, 107, 20, 99, 107, 106, 20, 99, 106, 105, 20, 99, 105, 98, 21, 92, 98, 91, 21, 85, 91, 84, 21, 78, 84, 77, 21, 71, 77, 70, 21, 64, 70, 63, 21, 57, 63, 56, 21, 50, 56, 49, 21, 43, 49, 42, 21, 36, 42, 35, 21, 29, 35, 28, 21, 22, 28, 21, 21, 17, 21, 16, 21, 12, 16, 11, 21, 7, 11, 6, 21, 7, 6, 1, 21, 33, 40, 32, 0, 33, 32, 26, 0, 54, 61, 53, 0, 54, 53, 47, 0, 75, 82, 74, 0, 75, 74, 68, 0, 96, 103, 95, 0, 96, 95, 89, 0, 12, 11, 7, 0, 8, 7, 3, 0, 12, 7, 8, 0, 9, 8, 4, 0, 13, 8, 9, 0, 14, 9, 15, 0, 13, 9, 14, 0, 19, 14, 20, 0, 13, 14, 19, 0, 24, 19, 25, 0, 24, 25, 32, 0, 31, 32, 39, 0, 31, 39, 38, 0, 45, 38, 46, 0, 45, 46, 53, 0, 52, 53, 60, 0, 52, 60, 59, 0, 66, 59, 67, 0, 66, 67, 74, 0, 73, 74, 81, 0, 73, 81, 80, 0, 87, 80, 88, 0, 87, 88, 95, 0, 94, 95, 102, 0, 94, 102, 101, 0, 100, 101, 108, 0, 93, 101, 100, 0, 99, 100, 107, 0, 92, 100, 99, 0, 92, 99, 98, 0, 93, 100, 92, 0, 85, 92, 91, 0, 86, 92, 85, 0, 78, 85, 84, 0, 79, 85, 78, 0, 71, 78, 77, 0, 72, 78, 71, 0, 64, 71, 70, 0, 65, 71, 64, 0, 57, 64, 63, 0, 58, 64, 57, 0, 50, 57, 56, 0, 51, 57, 50, 0, 43, 50, 49, 0, 44, 50, 43, 0, 36, 43, 42, 0, 37, 43, 36, 0, 29, 36, 35, 0, 30, 36, 29, 0, 22, 29, 28, 0, 23, 29, 22, 0, 17, 22, 21, 0, 18, 22, 17, 0, 12, 17, 16, 0, 13, 17, 12, 0, 13, 12, 8, 0, 18, 17, 13, 0, 18, 13, 19, 0, 18, 19, 24, 0, 31, 24, 32, 0, 23, 24, 31, 0, 30, 31, 38, 0, 37, 38, 45, 0, 52, 45, 53, 0, 44, 45, 52, 0, 51, 52, 59, 0, 58, 59, 66, 0, 73, 66, 74, 0, 65, 66, 73, 0, 72, 73, 80, 0, 79, 80, 87, 0, 94, 87, 95, 0, 86, 87, 94, 0, 93, 94, 101, 0, 86, 94, 93, 0, 86, 93, 92, 0, 18, 24, 23, 0, 18, 23, 22, 0, 23, 31, 30, 0, 23, 30, 29, 0, 30, 38, 37, 0, 30, 37, 36, 0, 37, 45, 44, 0, 37, 44, 43, 0, 44, 52, 51, 0, 44, 51, 50, 0, 51, 59, 58, 0, 51, 58, 57, 0, 58, 66, 65, 0, 58, 65, 64, 0, 65, 73, 72, 0, 65, 72, 71, 0, 72, 80, 79, 0, 72, 79, 78, 0, 79, 87, 86, 0, 79, 86, 85, 0 };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 126)]
		public short[] TBI = new short[126] { 1, 4, 1, 0, 0, 0, 5, 6, 2, 0, 1, 40, 7, 8, 2, 1, 3, 60, 9, 10, 5, 3, 3, 0, 11, 12, 6, 3, 4, 0, 13, 14, 5, 4, 4, 0, 15, 15, 2, 4, 5, 30, 16, 17, 5, 5, 5, 0, 18, 19, 6, 5, 6, 0, 20, 21, 5, 5, 6, 0, 22, 22, 2, 6, 7, 30, 23, 24, 5, 7, 7, 0, 25, 26, 6, 7, 8, 0, 27, 28, 5, 8, 8, 0, 29, 29, 2, 8, 9, 30, 30, 31, 5, 9, 9, 0, 32, 33, 6, 9, 10, 0, 34, 35, 5, 10, 10, 0, 36, 36, 2, 10, 11, 30, 37, 40, 0, 0, 0, 0, 41, 56, 0, 0, 0, 0 };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 34)]
		public short[] XII = new short[34] { 1, 5, 6, 10, 11, 15, 16, 20, 21, 27, 28, 34, 35, 41, 42, 48, 49, 55, 56, 62, 63, 69, 70, 76, 77, 83, 84, 90, 91, 97, 98, 104, 105, 109 };


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，有限元数学模型")]
		public CRotorModal IPRotor = new CRotorModal();

	}
}
