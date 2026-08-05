using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("MLLJ")]
	[FCDisplay("开关量累计")]
    public partial class MLLJ : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "开关量累计";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，待监测开关值")]
		public LD IN1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，单位脉冲对应的给煤量")]
		public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，给煤量复位值")]
		public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 999999999999999999999f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，复位端")]
		public LD RS;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出端")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSUP HSUP01 = new HSUP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GT GT_8 = new GT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_9 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_11 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_12 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_13 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_14 = new SEL();
	}
}
