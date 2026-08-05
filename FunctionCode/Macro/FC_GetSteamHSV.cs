using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetSteamHSV")]
	[FCDisplay("")]
	public partial class GetSteamHSV : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽压力：单位ata")]
		public LA ps = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽温度：单位C")]
		public LA ts = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，蒸汽焓值")]
		public LA enth = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，蒸汽熵值")]
		public LA sg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，蒸汽比容")]
		public LA vg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，计算无效标志")]
		public LD DINV;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float zp;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float zt;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float zv;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float zh;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az0;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float azz;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az4;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az5;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az6;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az7;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az8;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float az9;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float azs;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short j;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short k;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
		public float[] z3 = new float[8] { 523.5718623f, -2693.088365f, 5745.984054f, -6508.211677f, 4126.607219f, -1388.522425f, 193.6587558f, 0f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 8)]
		public float[] z4 = new float[8] { 0.08565182058f, -0.6547711697f, 0.4330662834f, -54.38923329f, 28.5606796f, 0.0f, 0.0f, 0.0f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 6)]
		public float[] z7 = new float[6] { 15.74373327f, -34.17061978f, 19.31380707f, 0.763333333f, 16.83599274f, 4.260321148f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24)]
		public float[] z8 = new float[24] { 0.06670375918f, 1.388983801f, 0.0f, 0.08390104328f, 0.02614670893f, -0.03373439453f, 0.4520918904f, 0.1069036614f, 0.0f, -0.5975336707f, -0.08847535804f, 0.0f, 0.5958051609f, -0.5159303373f, 0.2075021122f, 0.1190610271f, -0.09867174132f, 0.0f, 0.1683998803f, -0.05809438001f, 0.0f, 0.006552390126f, 0.0005710218649f, 0.0f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 24)]
		public float[] z9 = new float[24] { 13f, 3f, 0f, 18f, 2f, 1f, 18f, 10f, 0f, 25f, 14f, 0f, 32f, 28f, 24f, 12f, 11f, 0f, 24f, 18f, 0f, 24f, 14f, 0f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
		public float[] zz = new float[9] { 0.4006073948f, 0.0f, 0.0f, 0.08636081627f, 0.0f, 0.0f, -0.8532322921f, 03460208816f, 0.0f };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
		public float[] zs = new float[9] { 14f, 0f, 0f, 19f, 0f, 0f, 54f, 27f, 0f };

	}
}
