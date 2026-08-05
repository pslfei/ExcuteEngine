using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("RAMP_REAL")]
    [FCDisplay("限制给定函数升降")]
    public partial class RAMP_REAL : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("maximum positive slope")]
        public LA ASCEND = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("maximum negative slope (non-negative!!)")]
        public LA DESCEND = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA TIMEBASE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LD RESET = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float DIFF;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float OLD_IN;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float TB;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float CET;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private TON CLOCK = new TON();
    }
}
