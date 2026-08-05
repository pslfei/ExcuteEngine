using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCSType
{
    public interface IWarnModel
    {
        bool Runable { get; }
        string WarnConstraint { get; }
        string LimitAlarmCondition { get; }

        // 假设 HasConstraint 和 LimitAlarm 是 bool 或其他类型
        bool HasConstraint { get; set; }
        bool LimitAlarm { get; set; }


        int SysID { get; set; }
        int ModelID { get; set; }
        byte WarnState { get; set; }
        int AlarmType { get; set; }
        int? AlarmLevel { get; set; }

        DateTime WarnAlarmStartTime { get; set; }

        int LimitAlarmType { get; set; }

        bool IsAlarmSuspended { get; set; }
    }
}
