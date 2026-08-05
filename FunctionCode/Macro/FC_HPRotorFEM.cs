using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HPRotorFEM")]
	[FCDisplay("")]
	public partial class HPRotorFEM : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸主进汽蒸汽温度、压力")]
		public LA tzq = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸主进汽蒸汽温度、压力")]
		public LA pzq = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸前轴封蒸汽温度、压力")]
		public LA tqzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸前轴封蒸汽温度、压力")]
		public LA pqzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸调节汽室蒸汽温度、压力")]
		public LA ttj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸调节汽室蒸汽温度、压力")]
		public LA ptj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸第1#抽汽温度、压力")]
		public LA tcq1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸第1#抽汽温度、压力")]
		public LA pcq1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸第2#抽汽温度、压力")]
		public LA tcq2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸第2#抽汽温度、压力")]
		public LA pcq2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸排汽温度、压力")]
		public LA tpq = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸排汽温度、压力")]
		public LA ppq = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸后轴封蒸汽温度、压力")]
		public LA thzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸后轴封蒸汽温度、压力")]
		public LA phzf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸前、后轴端温度")]
		public LA tqzd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸前、后轴端温度")]
		public LA thzd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，高压缸内壁温度")]
		public LA tqg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，转速")]
		public LA rpM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期ms")]
		public LA dtime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大热应力")]
		public LA hpvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大热应力比率")]
		public LA hpstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，预测最大热应力")]
		public LA hpfvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，预测最大热应力比率")]
		public LA hpfstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，高压缸转子表面温度")]
		public LA hpsurt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，高压缸转子中心孔温度")]
		public LA hpbort = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，高压缸转子体积平均温度")]
		public LA hpvolt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("输出，高压缸转子温度场")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 123)]
		public float[] hptRotor = new float[123];


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，高压缸转子应力计算无效")]
		public LD hpstrinv;


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
		public short Nmax = 123;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，单元总数")]
		public short Emax = 160;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，边界总数")]
		public short Nborder = 33;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，截面总数")]
		public short Nset = 26;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，危险截面序号")]
		public short Calcset = 20;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，危险节点序号")]
		public short Mark = 96;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，热应力集中系数")]
		public float Kth = 2.8f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 246)]
		public float[] YX = new float[246] { 75f, 0f, 205f, 0f, 335f, 0f, 75f, 70f, 205f, 70f, 335f, 70f, 380f, 70f, 425f, 70f, 75f, 95f, 205f, 95f, 335f, 95f, 380f, 95f, 425f, 95f, 75f, 120f, 205f, 120f, 335f, 120f, 380f, 120f, 425f, 120f, 75f, 190f, 205f, 190f, 335f, 190f, 380f, 190f, 425f, 190f, 75f, 215f, 205f, 215f, 335f, 215f, 380f, 215f, 425f, 215f, 75f, 240f, 205f, 240f, 335f, 240f, 380f, 240f, 425f, 240f, 75f, 310f, 205f, 310f, 335f, 310f, 380f, 310f, 425f, 310f, 75f, 335f, 205f, 335f, 335f, 335f, 380f, 335f, 425f, 335f, 75f, 360f, 205f, 360f, 335f, 360f, 380f, 360f, 425f, 360f, 75f, 430f, 205f, 430f, 335f, 430f, 380f, 430f, 425f, 430f, 75f, 455f, 205f, 455f, 335f, 455f, 380f, 455f, 425f, 455f, 75f, 480f, 205f, 480f, 335f, 480f, 380f, 480f, 425f, 480f, 75f, 550f, 205f, 550f, 335f, 550f, 380f, 550f, 425f, 550f, 75f, 575f, 205f, 575f, 335f, 575f, 380f, 575f, 425f, 575f, 75f, 600f, 205f, 600f, 335f, 600f, 380f, 600f, 425f, 600f, 75f, 670f, 205f, 670f, 335f, 670f, 380f, 670f, 425f, 670f, 75f, 695f, 205f, 695f, 335f, 695f, 380f, 695f, 425f, 695f, 75f, 720f, 205f, 720f, 335f, 720f, 380f, 720f, 425f, 720f, 75f, 790f, 205f, 790f, 335f, 790f, 380f, 790f, 425f, 790f, 475f, 790f, 75f, 830f, 205f, 830f, 335f, 830f, 380f, 830f, 425f, 830f, 475f, 830f, 75f, 870f, 205f, 870f, 335f, 870f, 380f, 870f, 425f, 870f, 475f, 870f, 75f, 970f, 205f, 970f, 335f, 970f, 75f, 1070f, 205f, 1070f, 335f, 1070f, 75f, 1130f, 205f, 1130f, 335f, 1130f, 75f, 1190f, 205f, 1190f, 335f, 1190f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 640)]
		public short[] EP = new short[640] { 5, 1, 2, 1, 5, 2, 3, 1, 5, 3, 6, 2, 11, 6, 7, 3, 12, 7, 8, 3, 12, 8, 13, 4, 12, 13, 18, 4, 12, 18, 17, 5, 11, 17, 16, 5, 15, 16, 21, 6, 26, 21, 22, 7, 27, 22, 23, 7, 27, 23, 28, 8, 27, 28, 33, 8, 27, 33, 32, 9, 26, 32, 31, 9, 30, 31, 36, 10, 41, 36, 37, 11, 42, 37, 38, 11, 42, 38, 43, 12, 42, 43, 48, 12, 42, 48, 47, 13, 41, 47, 46, 13, 45, 46, 51, 14, 56, 51, 52, 15, 57, 52, 53, 15, 57, 53, 58, 16, 57, 58, 63, 16, 57, 63, 62, 17, 56, 62, 61, 17, 60, 61, 66, 18, 71, 66, 67, 19, 72, 67, 68, 19, 72, 68, 73, 20, 72, 73, 78, 20, 72, 78, 77, 21, 71, 77, 76, 21, 75, 76, 81, 22, 86, 81, 82, 23, 87, 82, 83, 23, 87, 83, 88, 24, 87, 88, 93, 24, 87, 93, 92, 25, 86, 92, 91, 25, 90, 91, 96, 26, 102, 96, 97, 27, 103, 97, 98, 27, 104, 98, 99, 27, 104, 99, 105, 28, 104, 105, 111, 28, 104, 111, 110, 29, 103, 110, 109, 29, 102, 109, 108, 29, 107, 108, 114, 30, 113, 114, 117, 30, 116, 117, 120, 31, 119, 120, 123, 31, 119, 123, 122, 32, 119, 122, 121, 32, 119, 121, 118, 33, 116, 118, 115, 33, 113, 115, 112, 33, 107, 112, 106, 33, 101, 106, 100, 33, 95, 100, 94, 33, 90, 94, 89, 33, 85, 89, 84, 33, 80, 84, 79, 33, 75, 79, 74, 33, 70, 74, 69, 33, 65, 69, 64, 33, 60, 64, 59, 33, 55, 59, 54, 33, 50, 54, 49, 33, 45, 49, 44, 33, 40, 44, 39, 33, 35, 39, 34, 33, 30, 34, 29, 33, 25, 29, 24, 33, 20, 24, 19, 33, 15, 19, 14, 33, 10, 14, 9, 33, 5, 9, 4, 33, 5, 4, 1, 33, 12, 17, 11, 0, 12, 11, 7, 0, 27, 32, 26, 0, 27, 26, 22, 0, 42, 47, 41, 0, 42, 41, 37, 0, 57, 62, 56, 0, 57, 56, 52, 0, 72, 77, 71, 0, 72, 71, 67, 0, 87, 92, 86, 0, 87, 86, 82, 0, 104, 110, 103, 0, 104, 103, 98, 0, 103, 109, 102, 0, 103, 102, 97, 0, 119, 118, 116, 0, 119, 116, 120, 0, 116, 115, 113, 0, 116, 113, 117, 0, 113, 112, 107, 0, 113, 107, 114, 0, 95, 94, 90, 0, 95, 90, 96, 0, 95, 96, 102, 0, 101, 102, 108, 0, 101, 108, 107, 0, 101, 107, 106, 0, 80, 79, 75, 0, 80, 75, 81, 0, 80, 81, 86, 0, 85, 86, 91, 0, 85, 91, 90, 0, 85, 90, 89, 0, 65, 64, 60, 0, 65, 60, 66, 0, 65, 66, 71, 0, 70, 71, 76, 0, 70, 76, 75, 0, 70, 75, 74, 0, 50, 49, 45, 0, 50, 45, 51, 0, 50, 51, 56, 0, 55, 56, 61, 0, 55, 61, 60, 0, 55, 60, 59, 0, 35, 34, 30, 0, 35, 30, 36, 0, 35, 36, 41, 0, 40, 41, 46, 0, 40, 46, 45, 0, 40, 45, 44, 0, 20, 19, 15, 0, 20, 15, 21, 0, 20, 21, 26, 0, 25, 26, 31, 0, 25, 31, 30, 0, 25, 30, 29, 0, 10, 9, 5, 0, 10, 5, 6, 0, 10, 6, 11, 0, 10, 11, 16, 0, 10, 16, 15, 0, 10, 15, 14, 0, 95, 102, 101, 0, 95, 101, 100, 0, 80, 86, 85, 0, 80, 85, 84, 0, 65, 71, 70, 0, 65, 70, 69, 0, 50, 56, 55, 0, 50, 55, 54, 0, 35, 41, 40, 0, 35, 40, 39, 0, 20, 26, 25, 0, 20, 25, 24, 0 };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 198)]
		public short[] TBI = new short[198] { 7, 2, 0, 0, 0, 0, 3, 3, 2, 17, 16, 30, 4, 5, 5, 16, 16, 0, 6, 7, 6, 16, 15, 0, 8, 9, 5, 15, 15, 0, 10, 10, 2, 15, 14, 30, 11, 12, 5, 14, 14, 0, 13, 14, 6, 14, 13, 0, 15, 16, 5, 13, 13, 0, 17, 17, 2, 13, 12, 30, 18, 19, 5, 12, 12, 0, 20, 21, 6, 12, 11, 0, 22, 23, 5, 11, 11, 0, 24, 24, 2, 11, 10, 30, 25, 26, 5, 10, 10, 0, 27, 28, 6, 10, 9, 0, 29, 30, 5, 9, 9, 0, 31, 31, 2, 9, 8, 30, 32, 33, 5, 8, 8, 0, 34, 35, 6, 8, 7, 0, 36, 37, 5, 7, 7, 0, 38, 38, 2, 7, 6, 30, 39, 40, 5, 6, 6, 0, 41, 42, 6, 6, 5, 0, 43, 44, 5, 5, 5, 0, 45, 45, 2, 5, 4, 40, 46, 48, 4, 4, 4, 0, 49, 50, 6, 4, 3, 0, 51, 53, 4, 3, 3, 0, 54, 55, 2, 3, 1, 60, 56, 57, 2, 1, 0, 60, 58, 59, 1, 0, 0, 0, 60, 84, 0, 0, 0, 0 };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 52)]
		public short[] XII = new short[52] { 1, 3, 4, 8, 9, 13, 14, 18, 19, 23, 24, 28, 29, 33, 34, 38, 39, 43, 44, 48, 49, 53, 54, 58, 59, 63, 64, 68, 69, 73, 74, 78, 79, 83, 84, 88, 89, 93, 94, 99, 100, 105, 106, 111, 112, 114, 115, 117, 118, 120, 121, 123 };


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，有限元数学模型")]
		public CRotorModal HPRotor = new CRotorModal();

	}
}
