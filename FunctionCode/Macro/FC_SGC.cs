using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SGC")]
	[FCDisplay("程控启停操作块，与程控步骤作块配合使用")]
	public partial class SGC : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "程控启停操作块，与程控步骤作块配合使用";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控启动完成反馈输入")]
		public LD OT;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控启动允许输入")]
		public LD OP;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动启动按钮")]
		public LD MO;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动启动输入")]
		public LD AO;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动终止程控复位")]
		public LD MP;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动终止程控复位")]
		public LD SP;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控步启停失败输入：接本程控包含的每个SSB 程控步失败输出或即OR")]
		public LD FI;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控启动执行的步或在执行第几步输出")]
		public LA B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控启动脉冲输出，不上传")]
		public LD VOP;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控启动输出")]
		public LD VO;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控启停失败输出")]
		public LD FO;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP1 = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS1 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS2 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS3 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP VOPTP = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON OTTON = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_11 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_12 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_15 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_70 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_26 = new OR();
	}
}
