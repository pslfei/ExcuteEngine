using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("AI_Red_Sel")]
    [FCDisplay("模入信号二选一")]
    public partial class AI_Red_Sel : Function
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
        [PinDisplay("*输入1*")]
        public LA X1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("*输入2*")]
        public LA X2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("*手动选择，0-自动选择，1-手动选择*")]
        public LD M1;

        [PinType(PinTypes.Input)]
        [PinDisplay("*手动选择开关，0---选AI1,1---选AI2*")]
        public LD M2;

        [PinType(PinTypes.Output)]
        [PinDisplay("*输出端*")]
        public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Output)]
        [PinDisplay("*故障提示，0---正常，1---故障，2---手动选择*")]
        public LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Constant)]
        [PinDisplay("*自动选择工作模式*")]
        public byte MD;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*点1所在板号*")]
        public uint D1 = 2;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*点2所在板号*")]
        public uint D2 = 2;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*点1和2 的相对误差限％,量程的%*")]
        public float DB = 0.1f;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*量程上限*")]
        public float UP = 100;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*量程下限*")]
        public float LO = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*报警上限*")]
        public float AU = 100;

        [PinType(PinTypes.Constant)]
        [PinDisplay("*报警下限*")]
        public float AL = 0;

    }
}
