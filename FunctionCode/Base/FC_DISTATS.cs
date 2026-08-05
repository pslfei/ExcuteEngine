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
    [FCName("DISTATS")]
    [FCDisplay("数字量输入统计")]
    public partial class DISTATS : Function
    {
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LD IN1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LD IN2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LD IN3 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LD IN4 = new LD(QualityTypes.Good, false, false, false, 0, false);


        protected override void Run(ICommand cmd)
        { 
            int ov = 0;
            if (IN1)
            {
                ov += 1;
            }

            if (IN2)
            {
                ov += 1;
            }

            if (IN3)
            {
                ov += 1;
            }

            if (IN4)
            {
                ov += 1;
            }

            OUT[0] = ov;
        }
    }
}
