using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("HSAMEMORY")]
    [FCDisplay("模拟存储")]
    public partial class HSAMEMORY : Function
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
        [PinDisplay("*输入端*")]
		public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("*增指令*")]
        public LD IC;

        [PinType(PinTypes.Input)]
        [PinDisplay("*减指令*")]
        public LD DC;

        [PinType(PinTypes.Input)]
        [PinDisplay("*方式开关,0设定方式，1跟踪方式*")]
        public LD SW;

        [PinType(PinTypes.Input)]
        [PinDisplay("*设定变化率*")]
        public LA SR = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.1f);

        [PinType(PinTypes.Output)]
        [PinDisplay("*输出端*")]
        public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Constant)]
        [PinDisplay("*初始值*")]
        public int IV = 20;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*输出上限*")]
        public int OT = 100;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*输出下限*")]
        public int OB = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("计数器")]
        private int V1;
	}
}
