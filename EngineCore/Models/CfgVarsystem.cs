using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CfgVarsystem
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Kkscode { get; set; }

    public string? IomapName { get; set; }

    public int? IomapDirection { get; set; }

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public string? DefaultValue { get; set; }

    public string? ForceValue { get; set; }

    public bool? IsHistory { get; set; }

    public string? MinimumScale { get; set; }

    public string? MaximunScale { get; set; }

    public int? LowAlarm1Priority { get; set; }

    public int? LowAlarm2Priority { get; set; }

    public int? LowAlarm3Priority { get; set; }

    public int? LowAlarm4Priority { get; set; }

    public int? LowAlarmUserPriority { get; set; }

    public int? HighAlarm1Priority { get; set; }

    public int? HighAlarm2Priority { get; set; }

    public int? HighAlarm3Priority { get; set; }

    public int? HighAlarm4Priority { get; set; }

    public int? HighAlarmUserPriority { get; set; }

    public double? LowAlarmLimit1Value { get; set; }

    public double? LowAlarmLimit2Value { get; set; }

    public double? LowAlarmLimit3Value { get; set; }

    public double? LowAlarmLimit4Value { get; set; }

    public int? LowAlarmLimitUserValue { get; set; }

    public double? HighAlarmLimit1Value { get; set; }

    public double? HighAlarmLimit2Value { get; set; }

    public double? HighAlarmLimit3Value { get; set; }

    public double? HighAlarmLimit4Value { get; set; }

    public int? HighAlarmLimitUserValue { get; set; }

    public int? AlarmPriority { get; set; }

    public int? StatusChecking { get; set; }

    public bool? IsSoe { get; set; }

    public int? Iotype { get; set; }

    public string? Unit { get; set; }

    public int? Prj_Controller_ID { get; set; }

    public string? Opcaddress { get; set; }

    public int? Prj_System_ID { get; set; }

    public int? Source { get; set; }

    public double? LowAlarmLimit1Value_Edit { get; set; }

    public double? LowAlarmLimit2Value_Edit { get; set; }

    public double? LowAlarmLimit3Value_Edit { get; set; }

    public double? LowAlarmLimit4Value_Edit { get; set; }

    public double? HighAlarmLimit1Value_Edit { get; set; }

    public double? HighAlarmLimit2Value_Edit { get; set; }

    public double? HighAlarmLimit3Value_Edit { get; set; }

    public double? HighAlarmLimit4Value_Edit { get; set; }

    public double? MinimumScale_Edit { get; set; }

    public double? MaximunScale_Edit { get; set; }
}
