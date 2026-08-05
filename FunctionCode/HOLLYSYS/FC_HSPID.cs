using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSPID")]
	[FCDisplay("单一功能PID调节")]
	public partial class HSPID : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Input)]
		[PinDisplay("内给定值。对单调节器PID、主调节器PID为本调节器的设定值，对副调节器为主调节器PID的输出值或计算输出值")]
		public LA SP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("过程值输入")]
		public LA PV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输入补偿")]
		public LA IC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输出补偿")]
		public LA OC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("跟踪量点")]
		public LA TP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("跟踪开关")]
		public LD TS;

		[PinType(PinTypes.Input)]
		[PinDisplay("计算周期, 单位:秒 sgl-cycle")]
		public LA CP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("PID调节器类型： 0 ---单PID,1---串级主PID,2 ---串级副PID")]
		public LA MC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("请赋值为  副调节器名.RM，为副调节器的运行方式，仅对串级调节回路的主调节器有效。  对单调节PID、串级副PID无效，无需赋值。SGL-CSRM")]
		public LA CM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("请赋值为  副调节器名.CI， 为副调节器的过程输入值-输入补偿，仅对串级调节回路的主调节器有效。 对单调节PID、串级副PID无效，无需赋值。SGL-CSOC")]
		public LA CC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("运行方式。0--MAN手动，1--AUTO自动，2--CAS串级,3--MANTRACK手动跟踪，4--AUTOTRACK自动跟踪,若填入其它非法值，一律保持前运行方式")]
		public LA RM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("比例带, >0, 百分数(%)")]
		public LA PT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 100.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("积分时间,>0 ")]
		public LA TI = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 30.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("微分增益  >0 ")]
		public LA KD = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("微分时间  >= 0 ")]
		public LA TD = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输出上限")]
		public LA OT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 100.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("输出下限")]
		public LA OB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出端")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("积分分离值/反向限, >= 0, 百分数(%) ")]
		public float SV = 100.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("输入死区/全开关限")]
		public float DI = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("调节器输出变化率")]
		public float OU = 100.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("偏差报警限 >0 百分数(%) ")]
		public float DL = 30.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("量程上限")]
		public float MU = 100.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("量程下限")]
		public float MD = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("PID 类型 -- 0:普通, 1: 智能")]
        public byte PK = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("输出模式 -- 0:位置式,1:增量式")]
		public int OM = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("作用方式 -- 0:正作用,1:反作用")]
		public int AD = 1;

		[PinType(PinTypes.Constant)]
		[PinDisplay("跟踪方式 --  0: SP 不跟踪 PV,  1:SP跟踪 PV")]
		public bool TM = false;

		[PinType(PinTypes.Constant)]
		[PinDisplay("内给定值sgl-scp")]
		public float CS = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("计算给定值 sgl-rsp")]
		public float RS = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("给定值变化率 ,缺省值0.1 sgl-AIFA")]
		public float FA = 0.1f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("手动输出变化率，快速变化率")]
		public float MI = 1.5f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("手动输出变化率，慢速变化率")]
		public float MS = 0.5f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("手动输出方式，1--快增，2--快减，3--慢增，4--慢减")]
        public byte MM = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("手动允许, 1-允许,0-禁止")]
		public bool ME = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("自动允许, 1-允许,0-禁止")]
		public bool AE = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("串级允许, 1-允许,0-禁止")]
		public bool CE = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("手动跟踪开关允许, 1-开,0-关 sgl-MTE")]
		public bool TE = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("自动跟踪开关允许, 1-开,0-关sgl-ATE")]
		public bool FE = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("过程输入值PV的量程上限SGL-PVMU")]
		public float PU = 100.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("过程输入值PV的量程下限 SGLPVMD-")]
		public float PD = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("报警级别： 普通,次急,紧急,特急")]
		public int AC = 0;


        [PinType(PinTypes.Internal)]
        [PinDisplay("上一周期的偏差值")]
        public float OLD_EK;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上两个周期的偏差值")]
        public float OLD_detalEK;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的输出值")]
        public float OLD_AV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的工作模式")]
        public float OLD_RM;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool OLD_TS;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的设定值")]
        public float OLD_SP;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的设定值")]
        public float Current_SP;

        [PinType(PinTypes.Internal)]
        [PinDisplay("偏差报警位,1-超差,0-正常 SGL-DevAlarm")]
        public bool DA;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public float OLD_OC;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public float OC1;
	}
}
