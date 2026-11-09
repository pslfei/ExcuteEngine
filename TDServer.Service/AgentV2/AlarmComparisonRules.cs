namespace TDServer.Service.AgentV2;

/// <summary>历史区间口径。只判断记录，不替代运行引擎当前状态。</summary>
internal static class AlarmComparisonRules
{
    // 时间窗采用[start,end)，末端状态取end之前的左极限。
    internal static bool ActiveBefore(DateTime begin, DateTime? end, DateTime at)
        => begin < at && (!end.HasValue || end.Value >= at);
    internal static bool Overlaps(DateTime begin, DateTime? end, DateTime start, DateTime stop)
        => begin < stop && (!end.HasValue || end.Value > start);
    internal static double RecordedDurationSeconds(DateTime begin, DateTime? end, DateTime stop)
        => Math.Max(0, ((end.HasValue && end.Value < stop ? end.Value : stop) - begin).TotalSeconds);
    internal static bool RecoveredInComparison(DateTime begin, DateTime? end, DateTime baselineEnd, DateTime comparisonStart, DateTime comparisonEnd)
        => ActiveBefore(begin, end, baselineEnd) && end >= comparisonStart && end < comparisonEnd;
    internal static string? RepeatedIdentity(string kind, string? point, string? source, int? faultCode, int? limitType)
        => kind switch
        {
            "fault_diagnosis" when !string.IsNullOrWhiteSpace(source) && faultCode > 0 => $"fault:{source}:{faultCode}",
            "rule_warning" when !string.IsNullOrWhiteSpace(point) && limitType.HasValue => $"rule:{point}:{limitType}",
            _ => null // 历史模型记录缺少实例身份，不把同模型的不同实例合并成重复报警。
        };
}
