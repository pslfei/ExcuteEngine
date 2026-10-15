using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;


namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("FaultOut")]
	[FCDisplay("故障输出")]
	public partial class FaultOut : Function, IFaultAlarm
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LD IN = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Constant)]
        [PinDisplay("故障码")]
        public int FaultCode = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("系统ID")]
        public int SysID = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool OldIN = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool NeedOut = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool UnAck = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public byte AlarmState = 1;

        /// <summary>
        /// 向统一报警接口暴露现有状态字段，保留原有管脚字段兼容性。
        /// </summary>
        byte IFaultAlarm.AlarmState => AlarmState;

        public FaultOut()
        {
            FcName = "FaultOut";
            FcType = enumType.FaultOut;
        }

        protected override void Run(ICommand cmd)
        {
            bool currentActive = IN.buffer;

            if (!OldIN && currentActive)
            {
                NeedOut = true;
                UnAck = true;
            }

            if (OldIN && !currentActive)
            {
                NeedOut = true;
            }

            OUT[0] = currentActive;
            UpdateWarnState(OUT.buffer);
            OldIN = currentActive;
        }

        /// <summary>
        /// 确认当前报警并立即更新状态，停用块也可调用；不改变实际输出。
        /// </summary>
        public void Ack()
        {
            UnAck = false;
            UpdateWarnState(OUT.buffer);
        }

        /// <summary>
        /// 根据实际输出与未确认标记计算四态报警状态。
        /// </summary>
        /// <param name="active">实际输出是否活动，已包含输出强制值的影响。</param>
        private void UpdateWarnState(bool active)
        {
            AlarmState = (active, UnAck) switch
            {
                (false, false) => 1,//灰色平光
                (false, true) => 2, //绿色闪烁
                (true, false) => 4, //红色平光
                (true, true) => 8   //红色闪烁
            };
        }
    }
}
