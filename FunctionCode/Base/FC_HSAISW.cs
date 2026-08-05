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
    [FCName("HSAISW")]
    [FCDisplay("模拟量开关")]

    public partial class HSAISW : Function
    {
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA I1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA I2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LD SW = new LD(QualityTypes.Good, false, false, false, 0, true);
        protected override void Run(ICommand cmd)
        {
            if (SW)
            {
                AV[0] = I1;
            }
            else
            {
                AV[0] = I2;
            }
        }
    }


}
