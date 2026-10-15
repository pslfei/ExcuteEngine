namespace DCSCommon
{
    /// <summary>
    /// 故障报警块的统一状态和确认入口。
    /// </summary>
    public interface IFaultAlarm
    {
        /// <summary>
        /// 当前报警状态：1正常已确认，2恢复未确认，4活动已确认，8活动未确认。
        /// </summary>
        byte AlarmState { get; }

        /// <summary>
        /// 确认当前报警并立即更新报警状态，不改变真实活动状态或挂起状态。
        /// </summary>
        void Ack();
    }
}
