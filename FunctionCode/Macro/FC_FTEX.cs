using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("FTEX")]
	[FCDisplay("风量补偿计算")]
    public partial class FTEX : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "风量补偿计算";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量差压信号kPa")]
		public LA dP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量温度信号")]
		public LA TE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量标定系数")]
		public LA K = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风管面积")]
		public LA Sg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，管道测点处静压")]
		public LA P0 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，质量流量标定系数")]
		public LA CM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，体积流量m3/h")]
		public LA V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，密度")]
		public LA Q = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，质量流量t/h")]
		public LA F = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，风速m/s")]
		public LA SPEED = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，当地大气压")]
		public float PD = 9100f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_44 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_47 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_48 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_49 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_51 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MAX MAX_65 = new MAX();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SQRT SQRT_52 = new SQRT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_53 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_24 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_55 = new MUL();
	}
}
