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
    [FCName("送风机A喘振")]
    [FCDisplay("2、A一次风机出口压力预测模型")]
    public partial class FC_送风机A喘振 : Function
    {      

        [PinType(PinTypes.Input)]
        [PinDisplay("A电动机电流故障报警")]
        public LD IN1  = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("A电动机电流")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);


        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float LLimit = 10;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float ContinueTime = 300;

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
            if (ValidSample < ContinueTime)
            {
                SampleBuffer[ValidSample] = IN2;
                ValidSample++;
            }
            else
            {
                for (int i = 1; i < ValidSample; i++)
                {
                    SampleBuffer[i - 1] = SampleBuffer[i];
                }
                SampleBuffer[ValidSample - 1] = IN2;

                double sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + SampleBuffer[i];
                }

                double avgAmFds = sum / ValidSample;
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
                int bias = 6;
                bool biasAlarm = false;
                if ((SampleBuffer[SampleBuffer.Length - 1] - avgAmFds) / avgAmFds > (bias / 100) || ((SampleBuffer[0] - avgAmFds) / avgAmFds < (-bias / 100))) 
                {
                    biasAlarm = true; 
                }

                OUT[0] = IN1 & biasAlarm;
            }
        }
    }
}
