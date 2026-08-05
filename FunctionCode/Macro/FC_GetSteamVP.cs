using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("GetSteamVP")]
	[FCDisplay("")]
	public partial class GetSteamVP : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，蒸汽温度")]
		public LA ts = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，饱和压力：单位ata")]
		public LA satmp = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，计算无效标志")]
		public LD DINV;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float zt;


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
		public float ddxx;

	}
}
