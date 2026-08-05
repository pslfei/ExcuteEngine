using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("ECFV")]
	[FCDisplay("二次风管风速补偿计算")]
    public partial class ECFV : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "二次风管风速补偿计算";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量差压信号kPa")]
		public LA FT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量温度信号")]
		public LA TE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，面积系数")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，体积风量标定系数")]
		public LA CV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，体积信号m/s")]
		public LA V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_49 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_50 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_51 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SQRT SQRT_52 = new SQRT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_53 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_54 = new DIV();
	}
}
