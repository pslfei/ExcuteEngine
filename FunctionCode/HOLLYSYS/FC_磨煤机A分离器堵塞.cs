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
    [FCName("磨煤机A分离器堵塞")]
    [FCDisplay("2、A一次风机出口压力预测模型")]
    public partial class FC_磨煤机A分离器堵塞 : Function
    {      

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨分离器与密封风差压")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨分离器风粉混合物温度1")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨分离器风粉混合物温度2")]
        public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨分离器风粉混合物温度3")]
        public LA IN4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨入口混合一次风温度1")]
        public LA IN5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨入口混合一次风温度2")]
        public LA IN6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A磨入口混合一次风温度2")]
        public LA IN7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float Limit0 = 100;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float Limit1 = 100;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float Limit2 = 100;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float Limit3 = 100;




        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float LLimit = 10;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float ContinueTime = 120;

        //内部变量
        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量1")]
        private int ValidSample;

        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量2")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 120)]
        private float[] SampleBuffer = new float[120];

        protected override void Run(ICommand cmd)
        {
            bool c0_check = false;
            bool c1_check = false;
            bool c2_check = false;
            bool c3_check = false;

            if (IN1 >= Limit0) { c0_check = true; }

            c1_check = IN2 < Limit1 || (IN3 < Limit1) || (IN4 < Limit1);
            c2_check = IN5 > Limit1 || (IN6 > Limit2);

            c3_check = IN7 < Limit3;

            bool final_check = c0_check & c1_check & c2_check & c3_check;
            if (final_check)
            {
                OUT[0] = 1;
            }
            else
            {
                OUT[0] = 0;
            }
        }
    }
}
