using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("MANPH")]
	[FCDisplay("手操 自平衡功能块：自动实现平衡和计算偏值，无需人工调平和设定偏值，比双平衡灵活，适用于多输出平衡")]
	public partial class MANPH : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "手操 自平衡功能块：自动实现平衡和计算偏值，无需人工调平和设定偏值，比双平衡灵活，适用于多输出平衡";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，指令信号输入")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手操输出信号")]
		public LA PV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手操状态信号")]
		public LD AM;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出给手操的指令")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，(*偏值计算 输出")]
		public LA BS = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_8 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_9 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_10 = new ADD();
	}
}
