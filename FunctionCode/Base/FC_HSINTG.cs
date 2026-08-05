using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("HSINTG")]
	[FCDisplay("单一功能PID调节")]
    public partial class HSINTG : Function 
	{
		[PinType(PinTypes.Input)]
        [PinDisplay("设定值")]
		public LA SP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("过程值")]
		public LA PV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("跟踪开关")]
		public LD TS = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("跟踪量点")]
		public LA TP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("计算周期, 单位:秒 sgl-cycle")]
		public LA TB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.2f);

        [PinType(PinTypes.Input)]
        [PinDisplay("增益")]
        public LA KI = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("时间常数")]
        public LA TI = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入死区")]
        public LA DI = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输出上限")]
        public LA OT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 100.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输出下限")]
        public LA OB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输出变化率")]
        public LA OTR = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 100.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("作用方式 -- 0:正作用,1:反作用")]
        public LD AD = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("输出端")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public float SV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public float YK;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public float EK;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public float UK;

        [PinType(PinTypes.Internal)]
        [PinDisplay("偏差报警位,1-超差,0-正常 SGL-DevAlarm")]
        public float AV_1;
    }
}
