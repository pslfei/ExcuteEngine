using System.Reflection;
using POWERSISAI;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;
using System;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("MOVAVG")]
    [FCDisplay("移动平均值")]
    public partial class MOVAVG : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输出
        [PinType(PinTypes.Output)]
		[PinDisplay("输出管脚1")]
        public LA AVG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA MIN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA MAX = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        ////规格数
        //[PinType(PinTypes.Constant)]
        //[PinDisplay("采样个数")]
        //private int SampleCount = 10;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("采样间隔(单位秒)")]
        public int SampleInterval = 5;

        [PinType(PinTypes.Constant)]
        [PinDisplay("开始采样时间(单位秒)")]
        public int StartTime = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("结束采样周期(单位秒)")]
        public int EndTime = 1200;


        ////规格数
        //[PinType(PinTypes.Constant)]
        //[PinDisplay("采样时间(单位秒)")]
        //private int SampleTime = 1200;
        
        //内部变量
        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量1")]
        private int ValidSample;

        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量2")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 600)]
        private float[] SampleBuffer = new float[600];

        protected override void Run(ICommand cmd)
        {
            return;
            _ENO[0] = _EN;
            if (!_EN)
                return;

            int SampleCount = EndTime * 60 / SampleInterval;//采样个数
            int SampleCycle = (int)(SampleInterval / cmd.Dpu.Cycle);//采样周期

            if (cmd.Dpu.CycleCount % SampleCycle == 0)
            {
                if (ValidSample < SampleCount)
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
                }

                int startIndex = StartTime * 60 / SampleInterval;
                double sum = 0;
                for (int i = startIndex; i < SampleCount; i++)
                {
                    sum = sum + SampleBuffer[i];
                }


                float MinValue = 99999999999;
                float MaxValue = -99999999999;

                for (int i = 0; i < SampleCount; i++)
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

                AVG[0] = sum / ValidSample;
                MIN[0] = MinValue;
                MAX[0] = MaxValue;
            }
        }
    }
}