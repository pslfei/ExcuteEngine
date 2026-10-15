using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("DevAlarm")]
    [FCDisplay("偏差报警")]
    public partial class DevAlarm : Function, IFaultAlarm
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("输入")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入2")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

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
        [PinDisplay("故障码")]
        public int FaultCode = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool NeedOut = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool OldIN = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("故障块")]
        public FaultOut faultOut = new FaultOut();

        /// <summary>
        /// 直接读取内部故障输出块的报警状态，供控制器统一展示和确认。
        /// </summary>
        public byte AlarmState => faultOut.AlarmState;

        /// <summary>
        /// 将确认操作传递给内部故障输出块，立即清除未确认状态。
        /// </summary>
        public void Ack()
        {
            faultOut.Ack();
        }

        public long starttime = -1;
        public bool oldAlarm = false;


        protected override void Run(ICommand cmd)
        {
            float dev = IN1 - IN2;
            bool alarmCondition = AnalyticalExpression.Analytical(Condition);
            long currentTime = (long)ExcuteEngine.cycle * ExcuteEngine.cycleCount;
            bool alarmOutput = OUT;

            if (alarmCondition)
            {
                bool isAlarm = dev > AlarmThreshold;

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
            else
            {
                alarmOutput = false;
                starttime = -1;
                oldAlarm = false;
            }

            UpdateFaultOutput(alarmOutput, cmd);
        }

        private void UpdateFaultOutput(bool alarmOutput, ICommand cmd)
        {
            faultOut.FaultCode = FaultCode;
            faultOut.IN[0] = alarmOutput;
            faultOut.NeedOut = false;
            faultOut.Implement(cmd);

            OUT[0] = faultOut.OUT;
            NeedOut = faultOut.NeedOut;
            OldIN = faultOut.OldIN;
        }
    }
}
