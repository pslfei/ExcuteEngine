using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("AnalogFluctuationAlarm")]
    [FCDisplay("模拟量波动报警")]
    public partial class AnalogFluctuationAlarm : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("模拟量输入")]
        public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Constant)]
        [PinDisplay("报警条件")]
        public string Condition = "";

        [PinType(PinTypes.Constant)]
        [PinDisplay("延时时间")]
        public int DelayTime = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("报警阈值")]
        public float AlarmThreshold = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("采样时间单位秒")]
        public int SampleTime = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool NeedOut = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool OldIN = false;

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, true);

        private readonly Queue<float> sampleQueue = new Queue<float>();
        private long starttime = -1;
        private bool oldAlarm = false;


        protected override void Run(ICommand cmd)
        {
            NeedOut = false;
            bool alarmCondition = AnalyticalExpression.Analytical(Condition);
            long currentTime = (long)ExcuteEngine.cycle * ExcuteEngine.cycleCount;
            bool alarmOutput = OUT;

            if (!alarmCondition)
            {
                sampleQueue.Clear();
                starttime = -1;
                oldAlarm = false;
                alarmOutput = false;
            }
            else
            {
                sampleQueue.Enqueue(IN.buffer);

                int sampleCount = GetSampleCount();
                while (sampleQueue.Count > sampleCount)
                {
                    sampleQueue.Dequeue();
                }

                if (sampleQueue.Count < sampleCount)
                {
                    starttime = -1;
                    oldAlarm = false;
                    alarmOutput = false;
                }
                else
                {
                    float fluctuation = Math.Abs(sampleQueue.Max() - sampleQueue.Min());
                    bool isAlarm = fluctuation > AlarmThreshold;

                    if (isAlarm)
                    {
                        if (!oldAlarm)
                        {
                            starttime = currentTime;
                        }

                        if (starttime >= 0 && currentTime >= starttime + DelayTime * 1000L)
                        {
                            starttime = -1;
                            alarmOutput = true;
                        }
                    }
                    else
                    {
                        alarmOutput = false;
                        starttime = -1;
                    }

                    oldAlarm = isAlarm;
                }
            }

            if (!OldIN && alarmOutput)
            {
                NeedOut = true;
            }

            if (OldIN && !alarmOutput)
            {
                NeedOut = true;
            }

            OldIN = alarmOutput;
            OUT[0] = alarmOutput;
        }

        private int GetSampleCount()
        {
            if (ExcuteEngine.cycle <= 0 || SampleTime <= 0)
            {
                return 1;
            }

            return Math.Max(1, (int)Math.Ceiling(SampleTime * 1000.0 / ExcuteEngine.cycle));
        }
    }
}
