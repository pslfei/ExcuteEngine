using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("THR_SEL_21")]
	[FCDisplay("三选模块")]
    public partial class THR_SEL_21 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "三选模块";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，信号1")]
		public LA S1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，切除信号1")]
		public LD C1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，信号2")]
		public LA S2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，切除信号2")]
		public LD C2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，信号3")]
		public LA S3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，切除信号3")]
		public LD C3;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，选择信号输出")]
		public LA S_OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，选后信号品质输出")]
		public LD S_Q;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，三选模块")]
		public HSMEDSEL THR = new HSMEDSEL();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，三选二逻辑")]
		public HS3SEL2 SEL01 = new HS3SEL2();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，信号间最大允许偏差")]
		public float DB;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_34 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_39 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_47 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_51 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_52 = new AND();
	}
}
