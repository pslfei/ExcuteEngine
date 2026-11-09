using System.Text.Json;

namespace TDServer.Service.AgentV2;

public sealed partial class AlarmEventsController
{
    private sealed class QueryCapacityException : Exception { }
    private static readonly SemaphoreSlim ComparisonBuildGate = new(1, 1);
    // 单次构建最多10万条。仅所选分类分页落本机临时文件，缓存不持有六份事件集合。
    private const long MaximumSnapshotBytes = 128L * 1024 * 1024;
    private static readonly Timer SnapshotCleanup = new(state =>
    {
        lock (SnapshotGate)
        {
            foreach (var pair in CompareSnapshots)
                if (pair.Value.ExpiresAt <= DateTimeOffset.UtcNow) RemoveCompareSnapshot(pair.Key);
            foreach (var pair in Snapshots)
                if (pair.Value.ExpiresAt <= DateTimeOffset.UtcNow) Snapshots.TryRemove(pair.Key, out _);
            foreach (var pair in CurrentSnapshots)
                if (pair.Value.ExpiresAt <= DateTimeOffset.UtcNow) CurrentSnapshots.TryRemove(pair.Key, out _);
        }
    }, null, TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(30));

    private static void DeleteSnapshotFile(string path)
    {
        try { System.IO.File.Delete(path); }
        catch (IOException) { /* 正在读取时下次过期清理重试。 */ }
        catch (UnauthorizedAccessException) { /* 不影响旧引擎计算。 */ }
    }
    private static void RemoveCompareSnapshot(string id)
    {
        if (CompareSnapshots.TryRemove(id, out var value)) DeleteSnapshotFile(value.FilePath);
    }

    private static async Task<CompareSnapshot> WriteCompareSnapshot(string id, string fingerprint,
        Dictionary<string, EventRow[]> buckets, string bucket, int size, int baselineCount,
        int comparisonCount, int unknownIdentity, bool durationComparable, CancellationToken ct)
    {
        string path = Path.Combine(Path.GetTempPath(), $"tdk-alarm-{Epoch}-{id}.pages");
        try
        {
            await using var file = new FileStream(path, FileMode.CreateNew, FileAccess.Write, FileShare.None, 65536, FileOptions.Asynchronous);
            var offsets = new List<long>();
            foreach (var page in buckets[bucket].Chunk(size))
            {
                ct.ThrowIfCancellationRequested();
                offsets.Add(file.Position);
                byte[] bytes = JsonSerializer.SerializeToUtf8Bytes(page);
                if (file.Position + bytes.Length > MaximumSnapshotBytes) throw new QueryCapacityException();
                await file.WriteAsync(bytes, ct);
            }
            offsets.Add(file.Position);
            return new CompareSnapshot(fingerprint, DateTimeOffset.UtcNow.AddMinutes(5), path, offsets.ToArray(),
                buckets.ToDictionary(x => x.Key, x => x.Value.Length), baselineCount, comparisonCount, unknownIdentity, durationComparable);
        }
        catch { DeleteSnapshotFile(path); throw; }
    }

    private static async Task<EventRow[]> ReadComparePage(CompareSnapshot snapshot, int offset, int size, CancellationToken ct)
    {
        int page = offset / size;
        if (page + 1 >= snapshot.Offsets.Length) return Array.Empty<EventRow>();
        await using var file = new FileStream(snapshot.FilePath, FileMode.Open, FileAccess.Read,
            FileShare.Read | FileShare.Delete, 65536, FileOptions.Asynchronous);
        file.Position = snapshot.Offsets[page];
        byte[] bytes = new byte[checked((int)(snapshot.Offsets[page + 1] - file.Position))];
        int read = 0;
        while (read < bytes.Length)
        {
            int count = await file.ReadAsync(bytes.AsMemory(read), ct);
            if (count == 0) throw new EndOfStreamException("Incomplete snapshot");
            read += count;
        }
        return JsonSerializer.Deserialize<EventRow[]>(bytes) ?? throw new InvalidDataException("Invalid snapshot");
    }
}
