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
    [FCName("HSDIGSW")]
    [FCDisplay("数字开关")]
    public partial class HSDIGSW : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);


        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LD DV = new LD(QualityTypes.Good, false, false, false, 0, false);

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LD I1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LD I2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LD SW = new LD(QualityTypes.Good, false, false, false, 0, false);

        protected override void Run(ICommand cmd)
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (SW)
            {
                DV[0] = I1;
            }
            else
            {
                DV[0] = I2;
            }
        }
    }
}
