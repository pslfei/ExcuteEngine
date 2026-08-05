using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("MMA")]
    [FCDisplay("计算设定时间内输入点的最大值，最小值，平均值，标准差")]
    public partial class MMA : Function
    {

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出平均值")]
        public LA AVG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出最小值")]
        public LA MIN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出最大值")]
        public LA MAX = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("标准差")]
        public LA SDev = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("采样时间(单位秒)")]
        public int ST = 3600;

        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量2")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 36000)]
        private float[] SampleBuffer = new float[36000];

        protected override void Run(ICommand cmd)
        {
            int sampleCount = ST * 1000 / ExcuteEngine.cycle;
            long currentIndex = ExcuteEngine.cycleCount % sampleCount;
            SampleBuffer[currentIndex] = IN1;

            // 初始化统计变量
            double sum = 0;
            float minValue = float.MaxValue;
            float maxValue = float.MinValue;

            double devSum = 0;
            for (int i = 0; i < sampleCount; i++)
            {
                float currentValue = SampleBuffer[i];
                sum += currentValue;

                if (currentValue < minValue)
                {
                    minValue = currentValue;
                }

                if (currentValue > maxValue)
                {
                    maxValue = currentValue;
                }
            }

            AVG[0] = (float)(sum / sampleCount);
            MIN[0] = minValue;
            MAX[0] = maxValue;

            for (int i = 0; i < sampleCount; i++)
            {
                devSum += Math.Pow(SampleBuffer[i] - AVG, 2);
            }
            SDev[0] = Math.Sqrt(devSum / sampleCount);
        }
    }
}