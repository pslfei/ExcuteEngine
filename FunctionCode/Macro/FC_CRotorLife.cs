using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("CRotorLife")]
	[FCDisplay("转子疲劳寿命损耗率")]
	public partial class CRotorLife : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "转子疲劳寿命损耗率";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，循环热应力")]
		public LA cvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，热应力集中系数")]
		public LA kth = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，疲劳损耗")]
		public LA df = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetKs uKS = new GetKs();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GetNf uNf = new GetNf();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，屈服极限比")]
		public float D;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，全应变")]
		public float Ke;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float EE;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float relayLife;

	}
}
