using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("OptimizeRpM")]
	[FCDisplay("")]
	public partial class OptimizeRpM : Function
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
		[PinDisplay("输入")]
		public LD strinv;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，当前转数")]
		public LA rpm = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期/ms")]
		public LA dtime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，实际升转率/min")]
		public LA rpmrate = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，建议升转率/min")]
		public LA orpmrate = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，计算有效性")]
		public LD dinv;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short j;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short CNT;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetRation RT = new GetRation();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，升/降速率列表RPM/min")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 11)]
		public short[] RpMStage = new short[11] { 0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500 };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，临界转数")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 12)]
		public short[] VibrateRpM = new short[12] { 950, 1010, 1200, 1260, 1410, 1610, 1750, 1970, 2110, 2570, 2650, 2850 };


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，速率级")]
		public short iID;

	}
}
