using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("FTEX4")]
	[FCDisplay("磨入口一次风风量补偿计算_质量")]
	public partial class FTEX4 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "磨入口一次风风量补偿计算_质量";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量差压信号kPa")]
		public LA dP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量温度信号")]
		public LA TE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，风量标定系数调t/h")]
		public LA Km = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 65.8969f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，实测流体表压kPa")]
		public LA Pg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，质量流量t/h")]
		public LA F = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，当地大气压kPa")]
		public float Ph = 95.68f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，流量校准函数")]
		public float fdp;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSPOLY HSPOLY01 = new HSPOLY();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSPOLY HSPOLY02 = new HSPOLY();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_74 = new GE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_72 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_44 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_47 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_49 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_51 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MAX MAX_65 = new MAX();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SQRT SQRT_52 = new SQRT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_53 = new MUL();
	}
}
