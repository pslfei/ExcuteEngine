using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SSB_22")]
	[FCDisplay("程控步骤作块，与程控启停操作块配合使用")]
	public partial class SSB_22 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "程控步骤作块，与程控启停操作块配合使用";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控步启动输入，不上传")]
		public LD IN;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控步完成反馈输入")]
		public LD SC;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，跳步信号，本设备不响应程控")]
		public LD JT;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控启停失败输入：接SGC的程控启停失败输出，不上传")]
		public LD FI;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，程控程序正在进行，不上传")]
		public LD RU;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，下一步进行来复位信号，不上传")]
		public LD DR;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，为真时暂停等待，程控步暂停输出，调试时用，不上传")]
		public LD WT;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，复位上一步来的启动信号，不上传")]
		public LD UR;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控步启动输出，进行中")]
		public LD OT;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控步失败输出")]
		public LD SF;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控执行的步输出，不上传")]
		public LA B1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，程控步完成输出，不上传")]
		public LD SO;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，跳过信号和启动下一步信号，不上传")]
		public LD JP;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，程控设备本步执行时间，不上传")]
		public uint ET;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，程控启动本步设备动作时间或等待时间，预置时间到而完成信号没有，发故障，不上传")]
		public float T1 = 20f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，程控设备本步的顺序预置数，不上传")]
		public byte BB;


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
		public TON TON1 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_77 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_9 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_12 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_17 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_79 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TIME_TO_DWORD TIME_TO_DWORD_81 = new TIME_TO_DWORD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_86 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_89 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_33 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_29 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_101 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_69 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_50 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_96 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_105 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_100 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_91 = new SEL();
	}
}
