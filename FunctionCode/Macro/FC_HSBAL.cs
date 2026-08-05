using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSBAL")]
	[FCDisplay("双平衡模块")]
    public partial class HSBAL : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "双平衡模块";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，双自动时：手动设定偏差")]
		public LA IOF = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA Z1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LA Z2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，为1时手动")]
		public LD D1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，为1时手动")]
		public LD D2;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA O1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA O2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，偏差无效")]
		public HSBAL2 BAL = new HSBAL2();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，进入自动前偏差")]
		public float DVO;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，实际增减偏差")]
		public float DV;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_19 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_46 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_43 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_34 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_37 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_26 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_29 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_32 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_5 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_2 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_8 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_9 = new ADD();
	}
}
