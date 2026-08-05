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
    [FCName("JUDGECONDITION")]
    [FCDisplay("A磨煤机分离器频率运行状态")]
    public partial class FC_JUDGECONDITION : Function
    {       //输出
        [PinType(PinTypes.Input)]
        [PinDisplay("A磨煤机分离器电流")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);



        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private int TIMEDELAY = 300;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float LIMIT = 50;



        //内部变量
        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量1")]
        private int ValidSample;

        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量2")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 300)]
        private float[] SampleBuffer = new float[300];

        protected override void Run(ICommand cmd)
        {
            if (ValidSample < TIMEDELAY)
            {
                SampleBuffer[ValidSample] = IN1;
                ValidSample++;
            }
            else
            {
                for (int i = 1; i < ValidSample; i++)
                {
                    SampleBuffer[i - 1] = SampleBuffer[i];
                }
                SampleBuffer[ValidSample - 1] = IN1;


                if (SampleBuffer[SampleBuffer.Length - 1] > LIMIT && SampleBuffer[0] > LIMIT)
                {
                    OUT[0] = 1;
                }
                else if (SampleBuffer[SampleBuffer.Length - 1] > LIMIT && SampleBuffer[0] < LIMIT)
                {
                    OUT[0] = 2;
                }
                else
                {
                    OUT[0] = 0;
                }
            }
        }
    }
}
