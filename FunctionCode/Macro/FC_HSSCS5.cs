using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSSCS5")]
	[FCDisplay("顺控设备5,未封装版")]
	public partial class HSSCS5 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "顺控设备5,未封装版";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，开位置状态反馈输入点")]
		public LD V1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，关位置状态反馈输入点")]
		public LD V2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，电气故障")]
		public LD L0;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，设备保护关")]
		public LD L1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，厂区保护开")]
		public LD L2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，厂区保护关")]
		public LD L3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，开许可条件")]
		public LD L4 = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，关许可条件")]
		public LD L5 = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动开命令")]
		public LD L6;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动关命令")]
		public LD L7;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，初始化脉冲")]
		public LD L8 = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动开命令")]
		public LD TP;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动关命令")]
		public LD TC;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动停止命令")]
		public LD TS;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，远方操作,0：远方/DCS，1：就地/手动")]
		public LD SD;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，开指令")]
		public LD DV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，关指令")]
		public LD RV;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，偏差开到关")]
		public LD OC;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，中停命令")]
		public LD SP;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，偏差关到开")]
		public LD CO;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，开运行超时")]
		public LD OT;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，关运行超时")]
		public LD CT;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSSCS AAAA = new HSSCS();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，检修挂牌命令")]
		public bool JC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，故障信息：0：正常；1：开超时；2：关超时；3：偏差开到关；4：偏差关到开；5：状态反馈错；6：电源故障；7：就地操作；8：试验-危险状态")]
		public byte FN;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，运行状态 ：0：中停（灰）；1：已开（红）；2：开过程（红闪）；3：已关（绿）；4：关过程（绿闪）；5：故障（黄闪）；6：试验-危险状态")]
		public byte ZT;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1：有开指令，2：有关指令，3：指令冲突")]
		public byte CE;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1：开状态，2：关状态，3：状态冲突")]
		public byte SE;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，上层复位脉冲")]
		public bool RP;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，设备类型 0－－电动机，1－－电动门，2－－电磁阀")]
		public byte DE;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，停止控制 0－－否，1－－是")]
		public bool SC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，开关指令二次确认操作")]
		public bool QR;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，调试命令，为真时，解除所有禁止条件，调试完后，一定要使其为：FALSE，慎用，")]
		public bool SY;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，输出脉冲限制，为TRUE时，输出至设备动作其状态变位为短脉冲，用于现场自保持回路，当为FALSE时，根据定义的时间输出")]
		public bool CD;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，开关指令二次确认等待时间")]
		public float T1 = 2f;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP_TP = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP_TC = new TP();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，主控启动自动复位脉冲")]
		public bool IP1 = true;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，主控启动自动复位脉冲")]
		public bool IP2 = true;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，主控启动自动复位脉冲")]
		public bool IP3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，命令记忆 0－－否，1－－是")]
		public bool CM;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，开命令终止连接 0－－否，1－－是")]
		public bool OS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，关命令终止连接 0－－否，1－－是")]
		public bool CS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，开命令输出反作用0－－否，1－－是")]
		public bool OU;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，运行时间")]
		public uint RT;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_436 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_437 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_440 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_441 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_174 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_667 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_651 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_654 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_663 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_671 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public EQ EQ_688 = new EQ();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_690 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_444 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_628 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_445 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_629 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_446 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_635 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_702 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_705 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_447 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_622 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_624 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_626 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_449 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_618 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_615 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_617 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_633 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_454 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_455 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_456 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_457 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_458 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_459 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_460 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_461 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_462 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_638 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public GE GE_464 = new GE();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_465 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_466 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_467 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_468 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_469 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_470 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_471 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_642 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_473 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_474 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_477 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_475 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_476 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_478 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_479 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_480 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_482 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_483 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_484 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_485 = new SEL();
	}
}
