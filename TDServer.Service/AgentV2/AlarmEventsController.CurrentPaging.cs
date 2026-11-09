using System.Collections.Concurrent;
using System.Security.Cryptography;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace TDServer.Service.AgentV2;

public sealed partial class AlarmEventsController
{
    private sealed record CurrentSnapshot(string Fingerprint, DateTimeOffset CreatedAt, DateTimeOffset ExpiresAt,
        JsonElement[] Items, object? Monitoring, bool RulesCovered, bool FaultsCovered,
        bool HasTarget, bool HasInstance, bool HasDevice, string[] Kinds);
    private static readonly ConcurrentDictionary<string, CurrentSnapshot> CurrentSnapshots = new();

    private string CurrentFingerprint(CurrentRequest request) => Convert.ToHexString(SHA256.HashData(
        JsonSerializer.SerializeToUtf8Bytes(new { SourceId, SourceDatabase, request.Target, request.PageSize,
            request.IncludeSuspended, request.IncludeMonitoringStatus,
            kinds = request.EventKinds?.OrderBy(x => x, StringComparer.Ordinal).ToArray() })));

    private IActionResult CurrentPage(string id, int offset, CurrentSnapshot snapshot, int size)
    {
        if (offset < 0 || offset > snapshot.Items.Length || offset % size != 0)
            return BadRequest(Error("INVALID_REQUEST", "分页游标位置无效。"));
        var items = snapshot.Items.Skip(offset).Take(size).ToArray();
        int next = offset + items.Length;
        bool hasMore = next < snapshot.Items.Length;
        if (!hasMore) CurrentSnapshots.TryRemove(id, out _);
        return Ok(new { data = new { snapshotId = id, asOf = snapshot.CreatedAt, engineEpoch = Epoch,
            snapshotAgeSeconds = (DateTimeOffset.UtcNow - snapshot.CreatedAt).TotalSeconds,
            stateAgeSeconds = (double?)null, freshnessVerified = false, isStale = (bool?)null,
            items, targetMonitoring = snapshot.Monitoring,
            ruleCoverage = snapshot.RulesCovered ? "partial" : "unavailable",
            faultCoverage = snapshot.FaultsCovered ? "partial" : "unavailable",
            consistency = "fixed_paged_runtime_observation",
            notice = "当前结果来自原引擎计算状态；采集质量及各实例最后成功计算时间未提供，不能确认其时效。分页保持同次读取内容，跨对象不是原子采样。" },
            meta = Meta(new { pageSize = size, hasMore, nextCursor = hasMore ? CreateCursor(id, next) : null,
                total = snapshot.Items.Length }, snapshot.HasTarget, snapshot.HasInstance, snapshot.HasDevice, snapshot.Kinds) });
    }
}
