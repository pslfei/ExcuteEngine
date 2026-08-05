using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSDLCTRL3")]
	[FCDisplay("断路器")]
    public partial class HSDLCTRL3 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "断路器";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，合闸位置反馈")]
		public LD I1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，分闸位置反馈")]
		public LD I2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，电源监视")]
		public LD I3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，远方、就地切换")]
		public LD I4;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，定时器1周期数")]
		public LA T1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，定时器2周期数")]
		public LA T2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，定时器3周期数")]
		public LA T3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，合闸许可条件")]
		public LD HX = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，分闸许可条件")]
		public LD FX = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，保护合闸命令")]
		public LD BH;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，保护分闸命令")]
		public LD BF;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动合闸命令")]
		public LD ZH;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动分闸命令")]
		public LD ZF;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，禁止手、自动互相闭锁 0：闭锁 1：普通")]
		public LD FM;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，初始化脉冲")]
		public LD IP;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出O1合闸指令输出")]
		public LD DV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出O2分闸指令输出")]
		public LD RV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，事故跳闸输出OC1")]
		public LD C1;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，事故跳闸输出OC2")]
		public LD C2;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，自动合闸输出OC3")]
		public LD C3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动预合命令")]
		public bool Z1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动合闸命令")]
		public bool Z2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动预分命令")]
		public bool Z3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动分闸命令")]
		public bool Z4;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，禁操状态")]
		public bool JC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，红灯平光状态")]
		public bool HP;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，红灯闪光状态")]
		public bool HS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，绿灯平光状态")]
		public bool LP;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，绿灯闪光状态")]
		public bool LS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，预合状态")]
		public bool YH;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，合闸后状态")]
		public bool HH;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，预分状态")]
		public bool YF;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，分闸后状态")]
		public bool FH;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS1 = new RS();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public bool VAR01;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS2 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，保持滞后置位定时器")]
		public TON T4 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，保持滞后置位定时器")]
		public TON T5 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，合闸脉冲定时器")]
		public HSTIMER T1_1 = new HSTIMER();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，分闸脉冲定时器")]
		public HSTIMER T2_1 = new HSTIMER();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，跳闸事故报警滞后置位定时器")]
		public TON T6 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，跳闸事故报警定宽脉冲定时器")]
		public HSTIMER T3_1 = new HSTIMER();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，自动合闸报警滞后置位定时器")]
		public TON T8 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS4 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS5 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS6 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RS8 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TON T9 = new TON();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP T10 = new TP();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public bool IP_RS;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_4 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_126 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_155 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_130 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_131 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_15 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_135 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_156 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_142 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_136 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_23 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_31 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_38 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_42 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_32 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_49 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_50 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_51 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_148 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_152 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_159 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_55 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_61 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_62 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_56 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_70 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_71 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_68 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_168 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_78 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_79 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_81 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_87 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_107 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_108 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_109 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_113 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_205 = new OR();
	}
}
