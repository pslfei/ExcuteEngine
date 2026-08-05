using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSDLCTRL5")]
	[FCDisplay("断路器5")]
	public partial class HSDLCTRL5 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "断路器5";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，合闸位置反馈")]
		public LD I1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，分闸位置反馈")]
		public LD I2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，电气故障")]
		public LD I3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，0: 远方、1:就地")]
		public LD RL;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，合闸脉冲定时器定时")]
		public LA T1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 2000f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，分闸脉冲定时器定时")]
		public LA T2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 2000f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，合闸许可条件")]
		public LD HX = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，分闸许可条件")]
		public LD FX = new LD(QualityTypes.Good, false, false, false,0, true);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动合闸命令")]
		public LD ZH;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动分闸命令")]
		public LD ZF;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，初始化脉冲")]
		public LD IP = new LD(QualityTypes.Good, false, false, false,0, true);

        #region 为实现IP的脉冲功能另加的管脚 李飞 20120619

        [PinType(PinTypes.Internal)]
        public bool OLD_IP;

        [PinType(PinTypes.Internal)]
        public bool IP0To1;

        [PinType(PinTypes.Internal)]
        public float SampleTime;    
    
        #endregion

		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出O1合闸指令输出")]
		public LD DV;

		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出O2分闸指令输出")]
		public LD RV;

		[PinType(PinTypes.Output)]
		[PinDisplay("输出，合闸超时")]
		public LD C1;

		[PinType(PinTypes.Output)]
		[PinDisplay("输出，分闸超时")]
		public LD C2;


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
		[PinDisplay("规格数，检修挂牌命令")]
		public bool JC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，手动复位脉冲")]
		public bool MR;


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
		[PinDisplay("规格数，故障信息：0：正常；1：状态反馈冲突；2：就地操作；3：检修挂牌；4：合闸超时；5：分闸超时；6：偏差关到开；7：偏差开到关；8：电气故障；9：调试/危险状态")]
		public byte FN;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1：有合闸指令，2：有分闸指令，3：指令冲突")]
		public byte CE;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1：有合闸状态，2：有分闸状态，3：状态冲突")]
		public byte SE;


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


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，状态偏差开到关")]
		public bool OC;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，状态偏差关到开")]
		public bool CO;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，调试命令，为真时，解除所有禁止条件，调试完后，一定要使其为：FALSE，慎用")]
		public bool SY;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，复位脉冲")]
		public bool RP;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSYH = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSHH = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，合闸脉冲定时器")]
		public TP TIMEWH = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public F_TRIG TRIGH = new F_TRIG();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSC1 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSYF = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSFH = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，分闸脉冲定时器")]
		public TP TIMEWF = new TP();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public F_TRIG TRIGF = new F_TRIG();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSC2 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public R_TRIG RTRIG1 = new R_TRIG();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public R_TRIG RTRIG2 = new R_TRIG();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSC3 = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSC4 = new RS();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，主控启动自动复位脉冲")]
		public bool IP1 = true;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，主控启动自动复位脉冲")]
		public bool IP2 = true;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，主控启动自动复位脉冲")]
		public bool IP3;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_19 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_307 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_309 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_7 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_9 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_136 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_137 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_24 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_32 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_25 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_38 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_40 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_46 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_52 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_258 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_56 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_57 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_305 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_306 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_320 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_222 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_161 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_270 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_310 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_311 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_71 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_79 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_142 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_146 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_82 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_90 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_83 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_103 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_95 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_98 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_106 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_266 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_109 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_313 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_314 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_110 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public REAL_TO_TIME REAL_TO_TIME_321 = new REAL_TO_TIME();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_229 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_158 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_273 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_183 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_185 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public XOR XOR_216 = new XOR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_189 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_193 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_200 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_205 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_209 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_212 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_265 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_197 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_324 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_237 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_219 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_225 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_231 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_243 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_245 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_250 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_244 = new SEL();
	}
}
