using DCSCommon;
using DCSType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("SIMUSUMIDFCURR")]
    [FCDisplay("数字量输入统计")]
    public partial class SIMUSUMIDFCURR : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        protected override void Run(ICommand cmd)
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            OUT[0] = IN1 * IN1 * 0.00009 - 0.1318 * IN1 + 413.78 + 0;
        }
    }
}
