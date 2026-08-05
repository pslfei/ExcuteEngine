using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSAlgMAN")]
	[FCDisplay("手操器")]
	public partial class HSAlgMAN : Function 
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
		[PinDisplay("(*输入端*)")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*强制手动开关, 1-开, 0-关 *)")]
		public LD FM;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*程控自动开关, 1-开, 0-关 *)")]
		public LD PA;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*跟踪开关,         1-开, 0-关 *)")]
		public LD TS;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*跟踪量点*)")]
		public LA TP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*增闭锁，1-开, 0-关*)")]
		public LD C0;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*减闭锁，1-开, 0-关*)")]
		public LD C1;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*程控增，1-开, 0-关*)")]
		public LD C2;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*程控减，1-开, 0-关*)")]
		public LD C3;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*运行方式*)")]
		public LA RM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*过程输入值*)")]
		public LA PV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*阀位输出端*)")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*设定值输出*)")]
		public LA SP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("(*状态输出端 , 0-AUTO mode , 1-not AUTO mode*)")]
		public LD AM;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*输出偏置*)")]
		public float BS = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*输出变化率*)")]
		public float OU = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*输出上限*)")]
		public float OT = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*输出下限*)")]
		public float OB = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*量程上限*)")]
		public float MU = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*量程下限*)")]
		public float MD = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*手动变化率, 百分数, 取值")]
		public float MR = 0.0f;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*手动允许,  1-允许, 0-禁止  *)")]
		public bool ME = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*自动允许,  1-允许, 0-禁止  *)")]
        public bool AE = true;

		[PinType(PinTypes.Constant)]
		[PinDisplay("(*跟踪允许,  1-允许, 0-禁止  *)")]
        public bool FE = true;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次运行模式")]
        private float OLD_RM;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次TS值")]
        private bool OLD_TS;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次TS值")]
        private bool OLD_FM;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次C0值")]
        private bool OLD_C0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次C1值")]
        private bool OLD_C1;

        [PinType(PinTypes.Internal)]
        [PinDisplay("C0由0到1时，AV的值")]
        private float C0_AV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("C1由0到1时，AV的值")]
        private float C1_AV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次的输出值")]
        private float OLD_AV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上次PA值")]
        private bool OLD_PA;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float StartTime;
	}
}
