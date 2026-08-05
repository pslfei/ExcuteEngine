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
    [FCName("BIASLIMITTIMEDELAY")]
    [FCDisplay("2、A一次风机出口压力预测模型")]
    public partial class FC_BIASLIMITTIMEDELAY : Function
    {     
        [PinType(PinTypes.Input)]
        [PinDisplay("输出管脚1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输出管脚1")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

  
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUTAVG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUTMIN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA OUTMAX = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, true);


        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private int IsAbs = 1;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float HLimit = 100;

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
            float diff = IN1 - IN2;
            if (IsAbs == 1)
            {
                if (diff < 0)
                {
                    diff = -diff;
                }
            }

            if (ValidSample < ContinueTime)
            {
                SampleBuffer[ValidSample] = diff;
                ValidSample++;
            }
            else
            {
                for (int i = 1; i < ValidSample; i++)
                {
                    SampleBuffer[i - 1] = SampleBuffer[i];
                }
                SampleBuffer[ValidSample - 1] = diff;

                double sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + SampleBuffer[i];
                }
                OUTAVG[0] = sum / ValidSample;

                float MinValue = 99999999999;
                float MaxValue = -99999999999;


                for (int i = 0; i < 10; i++)
                {
                    if (SampleBuffer[i] < MinValue)
                    {
                        MinValue = SampleBuffer[i];
                    }

                    if (SampleBuffer[i] > MaxValue)
                    {
                        MaxValue = SampleBuffer[i];
                    }
                }

                OUTMIN[0] = MinValue;
                OUTMAX[0] = MaxValue;

                if (OUTMAX < HLimit && OUTMIN > LLimit)
                {
                    OUT[0] = true;
                }
                else
                {
                    OUT[0] = false;
                }
            }
        }
    }
}
