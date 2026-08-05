using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetSteamVT")]
	[FCDisplay("")]
	public partial class GetSteamVT : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽压力：单位ata")]
		public LA ps = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，饱和温度")]
		public LA satmt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，计算无效标志")]
		public LD DINV;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float pb;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float ta;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetSteamVP vpst = new GetSteamVP();

	}
}
