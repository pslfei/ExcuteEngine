using System.Globalization;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Concurrent;
using System.Reflection;
using DCSType;
using EngineCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace TDServer.Service.AgentV2;

/// <summary>只读报警事件查询，沿用原引擎Config.json数据库连接；历史记录归属单独标记。</summary>
[ApiController]
[Route("api/v2/alarm-events")]
[ApiExplorerSettings(GroupName = "agent-v2")]
public sealed partial class AlarmEventsController : ControllerBase
{
    // 限制历史数据的并发读取，避免智能体查询挤占原计算服务的数据库资源。
    private static readonly SemaphoreSlim HistoryReadGate = new(2, 2);
    private sealed class HistoryBusyException : Exception { }
    // 保留分页防篡改，签名密钥在服务重启后自动更新。
    private static readonly byte[] CursorKey = RandomNumberGenerator.GetBytes(32);
    private readonly IConfiguration _config;
    private static readonly TimeSpan PlantOffset = TimeSpan.FromHours(8);
    private static readonly string Epoch = Guid.NewGuid().ToString("N");
    /// <summary>初始化查询控制器。</summary>
    public AlarmEventsController(IConfiguration config) => _config = config;

    /// <summary>可选的精确测点目标。</summary>
    public sealed class Target
    {
        /// <summary>完整测点名，与EntityId二选一。</summary>
        public string? PointName { get; set; }
        /// <summary>解析接口返回的测点、模型定义或模型实例ID。</summary>
        public string? EntityId { get; set; }
        [JsonIgnore] public int? ResolvedModelId { get; set; }
        [JsonIgnore] public int? ResolvedInstanceId { get; set; }
        [JsonIgnore] public string[]? ResolvedInstancePoints { get; set; }
        [JsonIgnore] public string? ResolvedDeviceName { get; set; }
        [JsonIgnore] public DeviceAssociation[]? ResolvedDeviceAssociations { get; set; }
        [JsonExtensionData] public Dictionary<string, JsonElement>? Extra { get; set; }
    }
    /// <summary>按名称匹配出的候选设备关联，不等同于设备台账确认关系。</summary>
    public sealed record DeviceAssociation(string PointName, int ModelOrRule, int? ModelId, int BlockId);
    /// <summary>事件查询条件，时间必须带时区偏移。</summary>
    public class QueryRequest
    {
        /// <summary>开始时间，带偏移的ISO 8601格式，包含该时间。</summary>
        public string? StartTime { get; set; }
        /// <summary>结束时间，带偏移的ISO 8601格式，不包含该时间。</summary>
        public string? EndTime { get; set; }
        /// <summary>occurred发生、overlapping期间存在、recovered恢复；默认overlapping。</summary>
        public string TimeRelation { get; set; } = "overlapping";
        /// <summary>事件类别：model_warning、rule_warning、fault_diagnosis、unclassified_warning。</summary>
        public string[]? EventKinds { get; set; }
        /// <summary>测点或模型目标；省略时查询参照库范围。</summary>
        public Target? Target { get; set; }
        /// <summary>每页1至200条，默认50条。</summary>
        public int PageSize { get; set; } = 50;
        /// <summary>上一页返回的游标，须保持查询条件不变。</summary>
        public string? Cursor { get; set; }
        /// <summary>省略时查询原引擎连接的库；显式来源值须与实际来源标记一致。</summary>
        public string? OriginScope { get; set; }
        /// <summary>持续时间过滤尚未实现，当前只能省略或传null。</summary>
        public double? MinDurationSeconds { get; set; }
        [JsonExtensionData] public Dictionary<string, JsonElement>? Extra { get; set; }
    }
    /// <summary>统计条件及分组维度。</summary>
    public sealed class SummaryRequest : QueryRequest
    {
        /// <summary>分组维度，可选eventKind、severity、point，最多两个。</summary>
        public string[]? GroupBy { get; set; }
    }
    /// <summary>当前状态查询条件。</summary>
    public sealed class CurrentRequest
    {
        /// <summary>测点或模型目标；省略表示全部已加载对象。</summary>
        public Target? Target { get; set; }
        /// <summary>是否包含挂起的活动报警，默认包含。</summary>
        public bool IncludeSuspended { get; set; } = true;
        /// <summary>是否返回监测配置状态摘要。</summary>
        public bool IncludeMonitoringStatus { get; set; } = true;
        /// <summary>可选模型、规则及故障事件类别。</summary>
        public string[]? EventKinds { get; set; }
        /// <summary>当前仅支持单页1至200条。</summary>
        public int PageSize { get; set; } = 50;
        /// <summary>实时分页尚未实现，请省略。</summary>
        public string? Cursor { get; set; }
        [JsonExtensionData] public Dictionary<string, JsonElement>? Extra { get; set; }
    }
    /// <summary>对比时间窗口。</summary>
    public sealed class Window
    {
        /// <summary>窗口开始时间，包含，须带时区偏移。</summary>
        public string? StartTime { get; set; }
        /// <summary>窗口结束时间，不包含，须带时区偏移。</summary>
        public string? EndTime { get; set; }
        [JsonExtensionData] public Dictionary<string, JsonElement>? Extra { get; set; }
    }
    /// <summary>两个时间窗口及可选事件类型。</summary>
    public sealed class CompareRequest
    {
        /// <summary>基准时间窗口。</summary>
        public Window? Baseline { get; set; }
        /// <summary>对比时间窗口，须不早于基准窗口结束。</summary>
        public Window? Comparison { get; set; }
        /// <summary>参与对比的事件类别。</summary>
        public string[]? EventKinds { get; set; }
        /// <summary>可选测点或模型定义目标。</summary>
        public Target? Target { get; set; }
        /// <summary>省略时查询原引擎连接的库；显式来源值须与实际来源标记一致。</summary>
        public string? OriginScope { get; set; }
        /// <summary>明细类别：new_events、ongoing、recovered、new_active_since_baseline、repeated_keys或priority。</summary>
        public string DetailBucket { get; set; } = "new_events";
        /// <summary>每页1至200条，默认50条。</summary>
        public int PageSize { get; set; } = 50;
        /// <summary>上一页返回的对比游标。</summary>
        public string? Cursor { get; set; }
        [JsonExtensionData] public Dictionary<string, JsonElement>? Extra { get; set; }
    }
    private sealed record EventRow(string EventId, string EventKind, string? PointName, string? Source, int? ModelId, int? SysId, int? FaultCode, int? Level, int? LimitType, DateTime Begin, DateTime? End, double? Duration, string IntervalState, int? FaultDefinitionId = null, string? FaultName = null, string? PointDescription = null);
    private sealed record QueryRange(DateTime Start, DateTime End, string Relation, string? PointName, HashSet<string> Kinds, bool PointFaultExcluded = false, int? ModelId = null, int? InstanceId = null, string[]? InstancePoints = null, string? DeviceName = null, DeviceAssociation[]? DeviceAssociations = null);
    private sealed record PageSnapshot(string Fingerprint, DateTimeOffset ExpiresAt, EventRow[] Events);
    private sealed record CompareSnapshot(string Fingerprint, DateTimeOffset ExpiresAt, string FilePath, long[] Offsets, Dictionary<string, int> Counts, int BaselineCount, int ComparisonCount, int UnknownIdentityCount, bool DurationComparable);
    private static readonly ConcurrentDictionary<string, PageSnapshot> Snapshots = new();
    private static readonly ConcurrentDictionary<string, CompareSnapshot> CompareSnapshots = new();
    private static readonly object SnapshotGate = new();

    private object Error(string code, string message) => new { error = new { code, message, requestId = HttpContext.TraceIdentifier } };
    private object Meta(object? paging = null, bool pointFaultExcluded = false, bool instanceAssociation = false, bool deviceCandidate = false, IEnumerable<string>? includedKinds = null)
    {
        var issues = new List<object> { new { code = DataOrigin == "reference_test_data" ? "REFERENCE_DATABASE" : "HISTORICAL_ORIGIN_UNVERIFIED", message = "使用原计算引擎配置的数据库；库内历史记录是否全部属于当前机组尚未逐条核实。" }, new { code = "TIMEZONE_ASSUMED", message = "参照库时间按配置的东八区假设处理，原始存储时区尚未核实。" } };
        if (pointFaultExcluded) issues.Add(new { code = "FAULT_MAPPING_UNVERIFIED", message = "目标与故障实例或其他类型事件的关联未核实，本次仅包含明确匹配的预警。" });
        if (instanceAssociation) issues.Add(new { code = "HISTORICAL_INSTANCE_UNVERIFIED", message = "历史预警没有实例ID，本次按当前实例测点推断关联，不能证明覆盖全部历史。" });
        if (deviceCandidate) issues.Add(new { code = "DEVICE_CANDIDATE_UNVERIFIED", message = "设备与测点、模型按名称匹配，属于待核实候选，不能证明覆盖整台设备。" });
        return new { requestId = HttpContext.TraceIdentifier, sourceId = SourceId, unitId = SourceUnitId, generatedAt = DateTimeOffset.UtcNow, timeZone = "Asia/Shanghai", coverage = new { status = "partial", scopeCompleteness = "unknown", includedEventKinds = includedKinds?.OrderBy(x => x, StringComparer.Ordinal).ToArray() ?? Array.Empty<string>(), issues }, paging };
    }
    private string Fingerprint(QueryRange range, int size)
    {
        string input = JsonSerializer.Serialize(new { SourceId, SourceDatabase, range.Start, range.End, range.Relation, range.PointName, range.ModelId, range.InstanceId, range.DeviceName, deviceAssociations = range.DeviceAssociations?.OrderBy(x => x.PointName, StringComparer.Ordinal).ThenBy(x => x.ModelId).ThenBy(x => x.BlockId).ToArray(), points = range.InstancePoints?.OrderBy(x => x, StringComparer.Ordinal).ToArray(), kinds = range.Kinds.OrderBy(x => x, StringComparer.Ordinal).ToArray(), size });
        return Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(input)));
    }
    private string CursorSignature(string payload)
    {
        using var hmac = new HMACSHA256(CursorKey);
        return Convert.ToHexString(hmac.ComputeHash(Encoding.UTF8.GetBytes(payload)));
    }
    private string CreateCursor(string id, int offset)
    {
        string payload = $"{id}:{offset}";
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(payload + ":" + CursorSignature(payload)));
    }
    private (string Id, int Offset) ReadCursor(string cursor)
    {
        try
        {
            if (cursor.Length > 256) throw new FormatException();
            string decoded = Encoding.UTF8.GetString(Convert.FromBase64String(cursor));
            string[] pieces = decoded.Split(':');
            if (pieces.Length != 3 || !Guid.TryParseExact(pieces[0], "N", out _) || !int.TryParse(pieces[1], out int offset) || offset < 0) throw new FormatException();
            string expected = CursorSignature(pieces[0] + ":" + pieces[1]);
            if (!CryptographicOperations.FixedTimeEquals(Encoding.ASCII.GetBytes(expected), Encoding.ASCII.GetBytes(pieces[2]))) throw new FormatException();
            return (pieces[0], offset);
        }
        catch (FormatException) { throw new ArgumentException("分页游标无效或已被修改。"); }
    }
    private string SourceDatabase => AgentDataSource.Database(_config);
    private string DataOrigin => AgentDataSource.IsReference(SourceDatabase) ? "reference_test_data" : "unverified";
    private int? SourceUnitId => AgentApiConfiguration.UnitId(_config);
    private string SourceId => AgentApiConfiguration.SourceId(_config);
    private string? Connection()
    {
        string? connection = ExcuteEngine.configInfo?.mysqlConn;
        if (string.IsNullOrEmpty(connection)) return null;
        // 始终使用原计算引擎的Config.json连接；可选AllowedDatabase只核对库名，不切库。
        if (_config["AgentApi:StorageOffsetMinutes"] != "480" || !string.Equals(new MySqlConnectionStringBuilder(connection).Database, SourceDatabase, StringComparison.OrdinalIgnoreCase)) return null;
        return connection;
    }
    private static DateTime ParseTime(string? text)
    {
        if (string.IsNullOrWhiteSpace(text) || !Regex.IsMatch(text, @"(?:Z|[+-]\d\d:\d\d)$", RegexOptions.IgnoreCase) ||
            !DateTimeOffset.TryParse(text, CultureInfo.InvariantCulture, DateTimeStyles.None, out var result)) throw new ArgumentException("时间须为带时区偏移的ISO 8601格式。");
        return DateTime.SpecifyKind(result.ToOffset(PlantOffset).DateTime, DateTimeKind.Unspecified);
    }
    private QueryRange Validate(QueryRequest request, bool allowTarget = true)
    {
        var start = ParseTime(request.StartTime); var end = ParseTime(request.EndTime);
        if ((request.Extra?.Count ?? 0) > 0 || (request.Target?.Extra?.Count ?? 0) > 0 || request.MinDurationSeconds.HasValue) throw new ArgumentException("请求包含尚不支持的筛选字段。");
        if (request.OriginScope != null && request.OriginScope != DataOrigin) throw new ArgumentException("数据来源筛选须与实际来源标记一致；当前不支持声明已核实的历史归属。");
        if (end <= start || end - start > TimeSpan.FromDays(31)) throw new ArgumentException("时间范围须大于零且不超过31天。");
        if (request.TimeRelation != "occurred" && request.TimeRelation != "overlapping" && request.TimeRelation != "recovered") throw new ArgumentException("时间匹配方式无效。");
        if (request.Target?.EntityId != null || (!allowTarget && request.Target != null)) throw new ArgumentException("当前仅支持精确测点名称筛选。");
        if (request.Target != null && string.IsNullOrWhiteSpace(request.Target.PointName) && request.Target.ResolvedModelId == null && request.Target.ResolvedDeviceName == null) throw new ArgumentException("请输入完整测点名称或模型标识。");
        var kinds = (request.EventKinds ?? new[] { "model_warning", "rule_warning", "fault_diagnosis", "unclassified_warning" }).ToHashSet(StringComparer.Ordinal);
        if (kinds.Count == 0 || kinds.Any(x => x != "model_warning" && x != "rule_warning" && x != "fault_diagnosis" && x != "unclassified_warning")) throw new ArgumentException("包含尚不支持的事件类型。");
        // 当前尚无可信测点至故障映射，不得将整个故障表作为该测点的结果。
        bool excluded = false;
        if (request.Target?.ResolvedDeviceName != null)
        {
            excluded = kinds.RemoveWhere(x => x != "model_warning" && x != "rule_warning") > 0;
            if (kinds.Count == 0) throw new ArgumentException("设备候选当前仅支持关联的模型和规则预警，故障关联未核实。");
        }
        else if (request.Target?.ResolvedModelId != null)
        {
            excluded = kinds.RemoveWhere(x => x != "model_warning") > 0;
            if (kinds.Count == 0) throw new ArgumentException("指定模型当前仅支持模型预警查询，故障关联未核实。");
        }
        else
        {
            excluded = request.Target != null && request.EventKinds == null && kinds.Remove("fault_diagnosis");
            if (request.Target != null && kinds.Contains("fault_diagnosis")) throw new ArgumentException("测点到故障实例的完整关联尚未确定；请单独查询模型或规则预警。");
        }
        return new(start, end, request.TimeRelation, request.Target?.PointName?.Trim(), kinds, excluded, request.Target?.ResolvedModelId, request.Target?.ResolvedInstanceId, request.Target?.ResolvedInstancePoints, request.Target?.ResolvedDeviceName, request.Target?.ResolvedDeviceAssociations);
    }
    private async Task ResolvePointTarget(Target? target, CancellationToken ct)
    {
        if (target == null) return;
        if ((target.Extra?.Count ?? 0) > 0 || (target.EntityId != null && target.PointName != null)) throw new ArgumentException("目标对象不明确。");
        string? connection = Connection();
        if (connection == null) throw new InvalidOperationException("当前数据库与允许的本地参照数据源或时区配置不匹配。");
        using var db = new WarnContext(connection); db.Database.SetCommandTimeout(10);
        // 同一读取事务覆盖两张事件表，分页后续使用固定快照，不长期占用数据库事务。
        await using var readTransaction = await db.Database.BeginTransactionAsync(System.Data.IsolationLevel.RepeatableRead, ct);
        var query = db.CfgVarsystems.AsNoTracking();
        if (target.EntityId != null)
        {
            string? deviceName = EntitiesController.DecodeDeviceCandidate(target.EntityId);
            if (deviceName != null)
            {
                var candidates = await (from warning in db.CldWarnpoints.AsNoTracking()
                                        join block in db.CldFcblocks.AsNoTracking() on warning.CldFcblockId equals block.Id into blockGroup
                                        from block in blockGroup.DefaultIfEmpty()
                                        join master in db.MetaFcmasters.AsNoTracking() on block.FunctionName equals master.FunctionName into masterGroup
                                        from master in masterGroup.DefaultIfEmpty()
                                        where warning.PointName != null && (warning.ModelOrrule == 0 || warning.ModelOrrule == 1) &&
                                              ((warning.Description != null && warning.Description.Contains(deviceName)) || (block != null && block.Description != null && block.Description.Contains(deviceName)) || (master != null && master.Description != null && master.Description.Contains(deviceName)))
                                        select new { warning.PointName, warning.ModelOrrule, warning.CldFcblockId, ModelId = (int?)master.Id }).Distinct().Take(2001).ToArrayAsync(ct);
                if (candidates.Length == 0) throw new KeyNotFoundException("没有找到该设备名称对应的预警配置候选。");
                if (candidates.Length > 2000) throw new ArgumentException("设备候选关联过多，请缩小设备名称范围。");
                target.ResolvedDeviceName = deviceName;
                target.ResolvedDeviceAssociations = candidates.Select(x => new DeviceAssociation(x.PointName!, x.ModelOrrule!.Value, x.ModelId, x.CldFcblockId)).ToArray();
                target.EntityId = null; return;
            }
            if (target.EntityId.StartsWith("ent_instance_", StringComparison.Ordinal) && int.TryParse(target.EntityId[13..], out int instanceId) && instanceId > 0)
            {
                var block = await db.CldFcblocks.AsNoTracking().Where(x => x.Id == instanceId).Select(x => new { x.FunctionName }).SingleOrDefaultAsync(ct);
                if (block?.FunctionName == null) throw new KeyNotFoundException("没有找到该模型实例。");
                var definitions = await db.MetaFcmasters.AsNoTracking().Where(x => x.FunctionName == block.FunctionName).Select(x => x.Id).Take(2).ToListAsync(ct);
                if (definitions.Count == 0) throw new KeyNotFoundException("模型实例缺少模型定义。");
                if (definitions.Count != 1) throw new AmbiguousMatchException("模型实例对应多个模型定义，无法唯一关联。");
                var instancePoints = await db.CldWarnpoints.AsNoTracking().Where(x => x.CldFcblockId == instanceId && x.ModelOrrule == 0 && x.PointName != null).Select(x => x.PointName!).Distinct().Take(201).ToArrayAsync(ct);
                if (instancePoints.Length == 0 || instancePoints.Length > 200) throw new ArgumentException("实例没有可用预警测点，或关联测点超过当前上限。");
                bool overlaps = await (from warning in db.CldWarnpoints.AsNoTracking()
                                      join other in db.CldFcblocks.AsNoTracking() on warning.CldFcblockId equals other.Id
                                      where warning.ModelOrrule == 0 && warning.CldFcblockId != instanceId && other.FunctionName == block.FunctionName && warning.PointName != null && instancePoints.Contains(warning.PointName)
                                      select warning.Id).AnyAsync(ct);
                if (overlaps) throw new AmbiguousMatchException("同一模型定义和测点存在多个实例，历史记录无法唯一归属到该实例。");
                target.ResolvedModelId = definitions[0]; target.ResolvedInstanceId = instanceId; target.ResolvedInstancePoints = instancePoints; target.EntityId = null; return;
            }
            if (target.EntityId.StartsWith("ent_model_", StringComparison.Ordinal) && int.TryParse(target.EntityId[10..], out int modelId) && modelId > 0)
            {
                if (!await db.MetaFcmasters.AsNoTracking().AnyAsync(x => x.Id == modelId, ct)) throw new KeyNotFoundException("没有找到该模型。");
                target.ResolvedModelId = modelId; target.EntityId = null; return;
            }
            if (!target.EntityId.StartsWith("ent_point_", StringComparison.Ordinal) || !int.TryParse(target.EntityId[10..], out int id) || id <= 0) throw new ArgumentException("当前事件查询仅支持测点或模型定义ID。");
            string? name = await query.Where(x => x.Id == id).Select(x => x.Name).SingleOrDefaultAsync(ct);
            if (name == null) throw new KeyNotFoundException("没有找到该测点。");
            target.PointName = name; target.EntityId = null;
        }
        if (string.IsNullOrWhiteSpace(target.PointName)) throw new ArgumentException("请输入完整测点名称。");
        string pointName = target.PointName.Trim();
        int matching = await query.Where(x => x.Name == pointName).Select(x => x.Id).Take(2).CountAsync(ct);
        if (matching == 0) throw new KeyNotFoundException("没有找到该测点。");
        if (matching > 1) throw new AmbiguousMatchException("存在同名测点，当前无法唯一识别控制器。");
        target.PointName = pointName;
    }
    private async Task<List<EventRow>> Load(QueryRange range, CancellationToken ct, bool enrich = true, int maxRows = 10000)
    {
        if (!await HistoryReadGate.WaitAsync(0, ct)) throw new HistoryBusyException();
        try
        {
        string? connection = Connection();
        if (connection == null) throw new InvalidOperationException("当前数据库与允许的本地参照数据源或时区配置不匹配，生产来源归属仍需核实。");
        using var db = new WarnContext(connection); db.Database.SetCommandTimeout(5);
        var rows = new List<EventRow>();
        if (range.Kinds.Any(x => x != "fault_diagnosis"))
        {
            var q = db.WarnAlarms.AsNoTracking().Where(x => (x.AlarmType == 0 && range.Kinds.Contains("model_warning")) || (x.AlarmType == 1 && range.Kinds.Contains("rule_warning")) || ((x.AlarmType == null || (x.AlarmType != 0 && x.AlarmType != 1)) && range.Kinds.Contains("unclassified_warning")));
            if (range.PointName != null) q = q.Where(x => x.PointName == range.PointName);
            if (range.ModelId.HasValue) q = q.Where(x => x.ModelID == range.ModelId.Value && x.AlarmType == 0);
            if (range.InstancePoints != null) q = q.Where(x => x.PointName != null && range.InstancePoints.Contains(x.PointName));
            if (range.DeviceAssociations != null)
            {
                var candidatePoints = range.DeviceAssociations.Select(x => x.PointName).Distinct(StringComparer.OrdinalIgnoreCase).ToArray();
                q = q.Where(x => x.PointName != null && candidatePoints.Contains(x.PointName));
            }
            q = range.Relation switch {
                "occurred" => q.Where(x => x.BeginTime >= range.Start && x.BeginTime < range.End),
                "recovered" => q.Where(x => x.EndTime >= range.Start && x.EndTime < range.End && x.EndTime > DateTime.MinValue),
                _ => q.Where(x => x.BeginTime < range.End && (x.EndTime == DateTime.MinValue || x.EndTime > range.Start)) };
            var values = await q.OrderByDescending(x => x.BeginTime).ThenByDescending(x => x.Id).Take(maxRows + 1).ToListAsync(ct);
            if (values.Count > maxRows) throw new QueryCapacityException();
            if (range.DeviceAssociations != null)
            {
                var modelKeys = range.DeviceAssociations.Where(x => x.ModelOrRule == 0 && x.ModelId.HasValue).Select(x => $"{x.ModelId}:{x.PointName}").ToHashSet(StringComparer.OrdinalIgnoreCase);
                var ruleKeys = range.DeviceAssociations.Where(x => x.ModelOrRule == 1).Select(x => x.PointName).ToHashSet(StringComparer.OrdinalIgnoreCase);
                values = values.Where(x => x.PointName != null && ((x.AlarmType == 0 && modelKeys.Contains($"{x.ModelID}:{x.PointName}")) || (x.AlarmType == 1 && ruleKeys.Contains(x.PointName)))).ToList();
            }
            rows.AddRange(values.Select(x => new EventRow($"{SourceDatabase}:warnalarm:{x.Id}", x.AlarmType == 0 ? "model_warning" : x.AlarmType == 1 ? "rule_warning" : "unclassified_warning", x.PointName, null, x.ModelID, x.SysID, null, x.Level, x.LimitAlarmType, x.BeginTime, x.EndTime == DateTime.MinValue ? null : x.EndTime, x.Duration, x.EndTime == DateTime.MinValue ? "open_record" : "closed_record")));
        }
        if (range.Kinds.Contains("fault_diagnosis"))
        {
            var q = db.FaultDiagnosis.AsNoTracking();
            q = range.Relation switch {
                "occurred" => q.Where(x => x.BeginTime >= range.Start && x.BeginTime < range.End),
                "recovered" => q.Where(x => x.EndTime >= range.Start && x.EndTime < range.End && x.EndTime > DateTime.MinValue),
                _ => q.Where(x => x.BeginTime < range.End && (x.EndTime == DateTime.MinValue || x.EndTime > range.Start)) };
            var values = await q.OrderByDescending(x => x.BeginTime).ThenByDescending(x => x.Id).Take(maxRows + 1).ToListAsync(ct);
            rows.AddRange(values.Select(x => new EventRow($"{SourceDatabase}:faultdiagnosis:{x.Id}", "fault_diagnosis", null, x.Source, null, null, x.FaultCode, null, null, x.BeginTime, x.EndTime == DateTime.MinValue ? null : x.EndTime, null, x.EndTime == DateTime.MinValue ? "open_record" : "closed_record")));
        }
        if (rows.Count > maxRows) throw new QueryCapacityException();
        // 故障编码可匹配多条字典，只在唯一命中时补充字典ID；补充失败不丢失原事件。
        var faultCodes = enrich ? rows.Where(x => x.FaultCode.HasValue).Select(x => x.FaultCode!.Value).Distinct().ToArray() : Array.Empty<int>();
        if (faultCodes.Length > 0)
        {
            try
            {
                var dictionary = new List<(int Id, int Code, string? Name)>();
                foreach (var batch in faultCodes.Chunk(500))
                {
                    var matches = await db.Troubleshooting.AsNoTracking().Where(x => x.Code.HasValue && batch.Contains(x.Code.Value)).Select(x => new { x.Id, x.Code, x.TroubleName }).ToListAsync(ct);
                    dictionary.AddRange(matches.Select(x => (x.Id, x.Code!.Value, x.TroubleName)));
                }
                var unique = dictionary.GroupBy(x => x.Code).Where(x => x.Count() == 1).ToDictionary(x => x.Key, x => x.Single());
                for (int i = 0; i < rows.Count; i++)
                    if (rows[i].FaultCode is int code && unique.TryGetValue(code, out var item)) rows[i] = rows[i] with { FaultDefinitionId = item.Id, FaultName = item.Name };
            }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch (Exception) { /* 字典不可用时返回原始编码；关联状态仍为未解析。 */ }
        }
        var pointNames = enrich ? rows.Where(x => x.PointName != null).Select(x => x.PointName!).Distinct(StringComparer.OrdinalIgnoreCase).ToArray() : Array.Empty<string>();
        if (pointNames.Length > 0 && pointNames.Length <= 2000)
        {
            try
            {
                var descriptions = new List<(string Point, string Description)>();
                foreach (var batch in pointNames.Chunk(500))
                {
                    var matches = await db.ParaWarns.AsNoTracking().Where(x => x.PointName != null && batch.Contains(x.PointName)).Select(x => new { x.PointName, x.Description }).ToListAsync(ct);
                    descriptions.AddRange(matches.Where(x => !string.IsNullOrWhiteSpace(x.Description)).Select(x => (x.PointName!, x.Description!)));
                }
                var unique = descriptions.GroupBy(x => x.Point, StringComparer.OrdinalIgnoreCase).Select(x => new { Point = x.Key, Names = x.Select(v => v.Description).Distinct(StringComparer.Ordinal).ToArray() }).Where(x => x.Names.Length == 1).ToDictionary(x => x.Point, x => x.Names[0], StringComparer.OrdinalIgnoreCase);
                for (int i = 0; i < rows.Count; i++) if (rows[i].PointName is string name && unique.TryGetValue(name, out var description)) rows[i] = rows[i] with { PointDescription = description };
            }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch (Exception) { /* 描述无法唯一匹配时保留原始点名。 */ }
        }
        return rows.OrderByDescending(x => x.Begin).ThenBy(x => x.EventId, StringComparer.Ordinal).ToList();
            }
        finally { HistoryReadGate.Release(); }
    }

    private object Present(EventRow e)
    {
        var issues = new List<object> { new { code = DataOrigin == "reference_test_data" ? "REFERENCE_DATABASE" : "HISTORICAL_ORIGIN_UNVERIFIED", message = "使用当前引擎数据源，历史归属及关联仍需核实。" } };
        if (e.End < e.Begin) issues.Add(new { code = "INVALID_RECORDED_INTERVAL", message = "恢复时间早于开始时间，记录时长不能作为有效持续时间。" });
        if (e.PointName != null && e.PointDescription == null) issues.Add(new { code = "DESCRIPTION_UNAVAILABLE", message = "未找到唯一的当前点描述，保留原始点名。" });
        if (e.FaultCode.HasValue && e.FaultDefinitionId == null) issues.Add(new { code = "FAULT_DICTIONARY_UNAVAILABLE", message = "故障编码未唯一匹配字典，保留原始编码。" });
        return new { eventId = e.EventId, runtimeId = (string?)null, eventKind = e.EventKind, title = e.FaultName ?? e.PointDescription ?? e.PointName ?? e.Source ?? "未知事件", point = e.PointName == null ? null : new { pointName = e.PointName, description = e.PointDescription, descriptionSource = e.PointDescription == null ? null : "current_parawarns" }, fault = e.FaultCode == null ? null : new { faultDefinitionId = e.FaultDefinitionId, faultCode = e.FaultCode, name = e.FaultName, source = e.Source }, model = e.ModelId > 0 ? new { modelDefinitionId = e.ModelId } : null, beginTime = new DateTimeOffset(e.Begin, PlantOffset), endTime = e.End.HasValue ? new DateTimeOffset(e.End.Value, PlantOffset) : (DateTimeOffset?)null, intervalState = e.IntervalState, activityState = "unknown", severity = new { rawLevel = e.Level }, limitAlarmType = e.LimitType, recordedDurationSeconds = e.Duration, originStatus = DataOrigin, associationStatus = "unresolved", qualityIssues = issues };
    }

    /// <summary>查询已配置本地参照库中的历史预警和故障。</summary>
    /// <param name="request">目标、半开时间窗口、事件类别及分页。</param>
    /// <param name="ct">请求取消标记。</param>
    /// <returns>历史事件及绑定查询条件的分页游标。</returns>
    /// <remarks>当前仅用于已允许的本地参照库；最多缓存10000条事件，结果不能作为七号机生产事实。</remarks>
    [HttpPost("query")]
    public async Task<IActionResult> Query([FromBody] QueryRequest request, CancellationToken ct)
    {
        try
        {
            if (request.PageSize is < 1 or > 200) throw new ArgumentException("每页数量必须在1到200之间。");
            await ResolvePointTarget(request.Target, ct);
            var range = Validate(request);
            string fingerprint = Fingerprint(range, request.PageSize);
            string snapshotId;
            int offset;
            PageSnapshot snapshot;
            if (request.Cursor == null)
            {
                var events = await Load(range, ct);
                snapshotId = Guid.NewGuid().ToString("N"); offset = 0;
                snapshot = new PageSnapshot(fingerprint, DateTimeOffset.UtcNow.AddMinutes(5), events.ToArray());
                lock (SnapshotGate)
                {
                    foreach (var expired in Snapshots.Where(x => x.Value.ExpiresAt <= DateTimeOffset.UtcNow).Select(x => x.Key)) Snapshots.TryRemove(expired, out _);
                    foreach (var expired in CompareSnapshots.Where(x => x.Value.ExpiresAt <= DateTimeOffset.UtcNow).Select(x => x.Key)) RemoveCompareSnapshot(expired);
                    if (Snapshots.Count + CompareSnapshots.Count + CurrentSnapshots.Count >= 4) return StatusCode(429, Error("QUERY_LIMIT_EXCEEDED", "查询快照已满，请稍后重试。"));
                    Snapshots[snapshotId] = snapshot;
                }
            }
            else
            {
                (snapshotId, offset) = ReadCursor(request.Cursor);
                if (!Snapshots.TryGetValue(snapshotId, out snapshot!) || snapshot.ExpiresAt <= DateTimeOffset.UtcNow)
                    return Conflict(Error("SNAPSHOT_EXPIRED", "查询快照已过期，请重新查询。"));
                if (!string.Equals(snapshot.Fingerprint, fingerprint, StringComparison.Ordinal)) return Conflict(Error("CURSOR_MISMATCH", "分页游标与查询条件不一致。"));
                if (offset > snapshot.Events.Length) throw new ArgumentException("分页游标位置无效。");
            }
            var page = snapshot.Events.Skip(offset).Take(request.PageSize).ToArray();
            int next = offset + page.Length;
            bool hasMore = next < snapshot.Events.Length;
            string? nextCursor = hasMore ? CreateCursor(snapshotId, next) : null;
            if (!hasMore) Snapshots.TryRemove(snapshotId, out _);
            return Ok(new { data = new { items = page.Select(Present), effectiveFilter = new { startTime = new DateTimeOffset(range.Start, PlantOffset), endTime = new DateTimeOffset(range.End, PlantOffset), timeRelation = range.Relation, pointName = range.PointName, modelDefinitionId = range.ModelId, instanceId = range.InstanceId, deviceCandidate = range.DeviceName, eventKinds = range.Kinds.OrderBy(x => x, StringComparer.Ordinal) }, consistency = "bounded_read" }, meta = Meta(new { pageSize = request.PageSize, hasMore, nextCursor, total = snapshot.Events.Length }, range.PointFaultExcluded, range.InstanceId.HasValue, range.DeviceName != null, range.Kinds) });
        }
        catch (QueryCapacityException) { return UnprocessableEntity(Error("QUERY_LIMIT_EXCEEDED", "结果超过本接口的有界查询容量，请缩小时间或对象范围；未返回截断统计。")); }
        catch (HistoryBusyException) { return StatusCode(429, Error("QUERY_BUSY", "历史查询繁忙，请稍后重试。")); }
        catch (KeyNotFoundException ex) { return NotFound(Error("ENTITY_NOT_FOUND", ex.Message)); }
        catch (AmbiguousMatchException ex) { return Conflict(Error("ENTITY_AMBIGUOUS", ex.Message)); }
        catch (ArgumentException ex) { return BadRequest(Error("INVALID_REQUEST", ex.Message)); }
        catch (InvalidOperationException ex) { return StatusCode(503, Error("SOURCE_UNAVAILABLE", ex.Message)); }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch (Exception) { return StatusCode(503, Error("SOURCE_UNAVAILABLE", "历史数据查询失败。")); }
    }
    /// <summary>按参照库原始事件标识查询单条预警或故障记录。</summary>
    /// <param name="eventId">数据库名:warnalarm:ID 或 数据库名:faultdiagnosis:ID。</param>
    /// <param name="cancellationToken">请求取消标记。</param>
    /// <returns>事件原始信息；历史关联缺失时保留原始事件。</returns>
    [HttpGet("{eventId}")]
    public async Task<IActionResult> Detail(string eventId, [FromQuery] bool includeCurrentState = false, CancellationToken cancellationToken = default)
    {
        if (includeCurrentState) return UnprocessableEntity(Error("CURRENT_LINK_UNAVAILABLE", "历史事件与当前运行状态的可靠关联尚未实现。"));
        var parts = eventId.Split(':');
        if (parts.Length != 3 || parts[0] != SourceDatabase || (parts[1] != "warnalarm" && parts[1] != "faultdiagnosis") || !int.TryParse(parts[2], out int id) || id <= 0)
            return BadRequest(Error("INVALID_EVENT_ID", "事件标识无效。"));
        string? connection = Connection();
        if (connection == null) return StatusCode(503, Error("SOURCE_UNAVAILABLE", "当前数据库与允许的本地参照数据源或时区配置不匹配。"));
        try
        {
            using var db = new WarnContext(connection);
            db.Database.SetCommandTimeout(5);
            EventRow? row;
            if (parts[1] == "warnalarm")
            {
                var e = await db.WarnAlarms.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
                row = e == null ? null : new EventRow(eventId, e.AlarmType == 0 ? "model_warning" : e.AlarmType == 1 ? "rule_warning" : "unclassified_warning", e.PointName, null, e.ModelID, e.SysID, null, e.Level, e.LimitAlarmType, e.BeginTime, e.EndTime == DateTime.MinValue ? null : e.EndTime, e.Duration, e.EndTime == DateTime.MinValue ? "open_record" : "closed_record");
            }
            else
            {
                var e = await db.FaultDiagnosis.AsNoTracking().SingleOrDefaultAsync(x => x.Id == id, cancellationToken);
                row = e == null ? null : new EventRow(eventId, "fault_diagnosis", null, e.Source, null, null, e.FaultCode, null, null, e.BeginTime, e.EndTime == DateTime.MinValue ? null : e.EndTime, null, e.EndTime == DateTime.MinValue ? "open_record" : "closed_record");
            }
            if (row == null) return NotFound(Error("EVENT_NOT_FOUND", "没有找到该事件。"));
            if (row.PointName is string pointName)
            {
                try
                {
                    var descriptions = await db.ParaWarns.AsNoTracking().Where(x => x.PointName == pointName && x.Description != null).Select(x => x.Description!).Distinct().Take(2).ToListAsync(cancellationToken);
                    if (descriptions.Count == 1 && !string.IsNullOrWhiteSpace(descriptions[0])) row = row with { PointDescription = descriptions[0] };
                }
                catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
                catch (Exception) { /* 保留原始点名。 */ }
            }
            if (row.FaultCode is int faultCode)
            {
                try
                {
                    var matches = await db.Troubleshooting.AsNoTracking().Where(x => x.Code == faultCode).Select(x => new { x.Id, x.TroubleName }).Take(2).ToListAsync(cancellationToken);
                    if (matches.Count == 1) row = row with { FaultDefinitionId = matches[0].Id, FaultName = matches[0].TroubleName };
                }
                catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
                catch (Exception) { /* 保留原始事件和故障编码。 */ }
            }
            return Ok(new { data = Present(row), meta = Meta(includedKinds: new[] { row.EventKind }) });
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
        catch (Exception) { return StatusCode(503, Error("SOURCE_UNAVAILABLE", "事件详情查询失败。")); }
    }

    // 全库统计在数据库内聚合，避免将所有旧未闭合事件加载到引擎内存。
    // 指定对象仍使用已核实的现有关系过滤流程，不在这里猜测设备或实例关系。
    private async Task<IActionResult> SummaryUnscoped(QueryRange range, string[] groupBy, CancellationToken ct)
    {
        if (!await HistoryReadGate.WaitAsync(0, ct)) throw new HistoryBusyException();
        try
        {
            using var connection = new MySqlConnection(Connection() ?? throw new InvalidOperationException("数据源不可用。"));
            await connection.OpenAsync(ct);
            using var transaction = await connection.BeginTransactionAsync(System.Data.IsolationLevel.RepeatableRead, ct);
            const string sourceSql = "(SELECT CASE WHEN AlarmType=0 THEN 'model_warning' WHEN AlarmType=1 THEN 'rule_warning' ELSE 'unclassified_warning' END AS eventKind, Level AS rawLevel, PointName AS pointName, ModelID AS modelId, BeginTime AS beginTime, EndTime AS endTime FROM warnalarm UNION ALL SELECT 'fault_diagnosis', NULL, NULL, NULL, BeginTime, EndTime FROM faultdiagnosis) events";
            const string occurred = "(beginTime>=@start AND beginTime<@end)";
            const string recovered = "(endTime>=@start AND endTime<@end AND endTime>@minimum)";
            const string overlapping = "(beginTime<@end AND (endTime=@minimum OR endTime>@start))";
            const string openAtEnd = "(beginTime<@end AND (endTime=@minimum OR endTime>=@end))";
            string selected = range.Relation == "occurred" ? occurred : range.Relation == "recovered" ? recovered : overlapping;
            var kinds = range.Kinds.OrderBy(x => x, StringComparer.Ordinal).ToArray();
            string filter = "eventKind IN (" + string.Join(",", kinds.Select((_, i) => "@kind" + i)) + ")";
            MySqlCommand Command(string sql)
            {
                var cmd = new MySqlCommand(sql, connection, transaction) { CommandTimeout = 5 };
                cmd.Parameters.AddWithValue("@start", range.Start);
                cmd.Parameters.AddWithValue("@end", range.End);
                cmd.Parameters.AddWithValue("@minimum", DateTime.MinValue);
                for (int i = 0; i < kinds.Length; i++) cmd.Parameters.AddWithValue("@kind" + i, kinds[i]);
                return cmd;
            }
            string Sum(string condition) => "COALESCE(SUM(CASE WHEN " + condition + " THEN 1 ELSE 0 END),0)";
            long eventCount, newCount, recoveredCount, overlapCount, openCount, pointCount, modelCount;
            using (var cmd = Command("SELECT " + string.Join(",", new[] { Sum(selected), Sum(occurred), Sum(recovered), Sum(overlapping), Sum(openAtEnd) }) +
                ",COUNT(DISTINCT CASE WHEN " + selected + " THEN pointName END),COUNT(DISTINCT CASE WHEN " + selected + " AND modelId>0 AND EXISTS (SELECT 1 FROM meta_fcmaster m WHERE m.ID=events.modelId) THEN modelId END) FROM " + sourceSql + " WHERE " + filter + " AND (" + occurred + " OR " + recovered + " OR " + overlapping + ")"))
            {
                using var reader = await cmd.ExecuteReaderAsync(ct);
                await reader.ReadAsync(ct);
                eventCount = reader.GetInt64(0); newCount = reader.GetInt64(1); recoveredCount = reader.GetInt64(2);
                overlapCount = reader.GetInt64(3); openCount = reader.GetInt64(4); pointCount = reader.GetInt64(5); modelCount = reader.GetInt64(6);
            }
            var groups = new List<object>();
            if (groupBy.Length > 0)
            {
                string Dimension(string key) => key switch { "eventKind" => "eventKind", "severity" => "COALESCE(CAST(rawLevel AS CHAR),'unknown')", "point" => "COALESCE(pointName,'unknown')", _ => throw new ArgumentException("不支持的分组。") };
                string dimensions = string.Join(",", groupBy.Select(Dimension));
                using var cmd = Command("SELECT " + dimensions + ",COUNT(*) FROM " + sourceSql + " WHERE " + filter + " AND " + selected + " GROUP BY " + dimensions + " LIMIT 10001");
                using var reader = await cmd.ExecuteReaderAsync(ct);
                while (await reader.ReadAsync(ct))
                {
                    if (groups.Count >= 10000) throw new InvalidOperationException("分组数量过多，请缩小统计范围。");
                    var values = new Dictionary<string, string>();
                    for (int i = 0; i < groupBy.Length; i++) values[groupBy[i]] = reader.GetString(i);
                    groups.Add(new { values, eventCount = reader.GetInt64(groupBy.Length) });
                }
            }
            await transaction.CommitAsync(ct);
            return Ok(new { data = new { eventCount, newEventCount = newCount, recoveredEventCount = recoveredCount, overlappingEventCount = overlapCount, openRecordCountAtEnd = openCount,
                affectedPointCount = (int?)null, rawPointNameCount = pointCount, affectedModelCount = modelCount, affectedDeviceCount = (int?)null,
                groupBy, groups, groupsAreAdditive = true, countDefinitions = new { eventCount = range.Relation, newEventCount = "occurred", recoveredEventCount = "recovered", overlappingEventCount = "overlapping", openRecordCountAtEnd = "left_limit_recorded_interval", rawPointNameCount = "按历史原始点名去重，未核实物理测点身份" } }, meta = Meta(includedKinds: range.Kinds) });
        }
        finally { HistoryReadGate.Release(); }
    }

    /// <summary>统计参照库时间范围内的事件，不按点名去重。</summary>
    /// <param name="request">统计时间窗口、事件类别及分组条件。</param>
    /// <param name="ct">请求取消标记。</param>
    /// <returns>事件数量、新发、恢复、重叠和窗口结束时的未闭合记录。</returns>
    [HttpPost("summary")]
    public async Task<IActionResult> Summary([FromBody] SummaryRequest request, CancellationToken ct)
    {
        try
        {
            if (request.Cursor != null) throw new ArgumentException("统计接口不接受分页游标。");
            string[] groupBy = request.GroupBy ?? Array.Empty<string>();
            string[] supported = { "eventKind", "severity", "point" };
            if (groupBy.Length > 2 || groupBy.Distinct(StringComparer.Ordinal).Count() != groupBy.Length || groupBy.Any(x => !supported.Contains(x))) throw new ArgumentException("分组维度尚不支持或超过两个。");
            await ResolvePointTarget(request.Target, ct);
            var range = Validate(request);
            if (range.PointName == null && !range.ModelId.HasValue && !range.InstanceId.HasValue && range.DeviceAssociations == null)
                return await SummaryUnscoped(range, groupBy, ct);
            var events = await Load(range, ct, enrich: false);
            var occurred = range.Relation == "occurred" ? events : await Load(range with { Relation = "occurred" }, ct, enrich: false);
            var recovered = range.Relation == "recovered" ? events : await Load(range with { Relation = "recovered" }, ct, enrich: false);
            var overlapping = range.Relation == "overlapping" ? events : await Load(range with { Relation = "overlapping" }, ct, enrich: false);
            string GroupValue(EventRow e, string field) => field switch { "eventKind" => e.EventKind, "severity" => e.Level?.ToString(CultureInfo.InvariantCulture) ?? "unknown", "point" => e.PointName ?? "unknown", "model" => e.ModelId > 0 ? e.ModelId.Value.ToString(CultureInfo.InvariantCulture) : "unknown", "system" => e.SysId > 0 ? e.SysId.Value.ToString(CultureInfo.InvariantCulture) : "unknown", _ => "unknown" };
            // 序列化键保持各维度边界，避免点名中包含分隔符时错误合并。
            var groups = groupBy.Length == 0 ? Array.Empty<object>() : events.GroupBy(e => JsonSerializer.Serialize(groupBy.Select(g => GroupValue(e, g)).ToArray())).Select(g => (object)new { values = groupBy.Zip(JsonSerializer.Deserialize<string[]>(g.Key)!).ToDictionary(x => x.First, x => x.Second), eventCount = g.Count() }).ToArray();
            int openAtEnd = overlapping.Count(x => x.Begin < range.End && (!x.End.HasValue || x.End.Value >= range.End));
            int? affectedModelCount = null;
            try
            {
                int[] modelIds = events.Where(x => x.ModelId > 0).Select(x => x.ModelId!.Value).Distinct().ToArray();
                affectedModelCount = 0;
                if (modelIds.Length > 0)
                {
                    using var modelDb = new WarnContext(Connection()!); modelDb.Database.SetCommandTimeout(5);
                    foreach (var batch in modelIds.Chunk(500)) affectedModelCount += await modelDb.MetaFcmasters.AsNoTracking().CountAsync(x => batch.Contains(x.Id), ct);
                }
            }
            catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
            catch (Exception) { affectedModelCount = null; }
            return Ok(new { data = new { eventCount = events.Count, newEventCount = occurred.Count, recoveredEventCount = recovered.Count, overlappingEventCount = overlapping.Count, openRecordCountAtEnd = openAtEnd, affectedPointCount = (int?)null, rawPointNameCount = events.Where(x => x.PointName != null).Select(x => x.PointName).Distinct(StringComparer.OrdinalIgnoreCase).Count(), affectedModelCount, affectedDeviceCount = (int?)null, groupBy, groups, groupsAreAdditive = true, countDefinitions = new { eventCount = range.Relation, newEventCount = "occurred", recoveredEventCount = "recovered", overlappingEventCount = "overlapping", openRecordCountAtEnd = "left_limit_recorded_interval", rawPointNameCount = "按历史事件中的原始点名去重，未核实是否为当前物理测点" } }, meta = Meta(pointFaultExcluded: range.PointFaultExcluded, instanceAssociation: range.InstanceId.HasValue, deviceCandidate: range.DeviceName != null, includedKinds: range.Kinds) });
        }
        catch (QueryCapacityException) { return UnprocessableEntity(Error("QUERY_LIMIT_EXCEEDED", "结果超过本接口的有界查询容量，请缩小时间或对象范围；未返回截断统计。")); }
        catch (HistoryBusyException) { return StatusCode(429, Error("QUERY_BUSY", "历史查询繁忙，请稍后重试。")); }
        catch (KeyNotFoundException ex) { return NotFound(Error("ENTITY_NOT_FOUND", ex.Message)); }
        catch (AmbiguousMatchException ex) { return Conflict(Error("ENTITY_AMBIGUOUS", ex.Message)); }
        catch (ArgumentException ex) { return BadRequest(Error("INVALID_REQUEST", ex.Message)); }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch (Exception) { return StatusCode(503, Error("SOURCE_UNAVAILABLE", "统计来源不可用或结果过多。")); }
    }
    /// <summary>比较两个时间窗口中的新增、持续和恢复事件。</summary>
    /// <param name="request">基准窗口、对比窗口及明细分页条件。</param>
    /// <param name="ct">请求取消标记。</param>
    /// <returns>分类计数和指定类别的事件明细。</returns>
    /// <remarks>各分类可重叠。最多读取10万条，超限返回明确错误；只允许一个对比构建。固定快照分页5分钟，每页1至200条，全部查询共享4个快照。未配置等级语义时按历史记录未恢复和持续时间排序，不代表实时风险。</remarks>
    [HttpPost("compare")]
    public async Task<IActionResult> Compare([FromBody] CompareRequest request, CancellationToken ct)
    {
        try
        {
            if (request.Baseline == null || request.Comparison == null) throw new ArgumentException("两个时间窗口均为必填。");
            if ((request.Extra?.Count ?? 0) > 0 || (request.Baseline.Extra?.Count ?? 0) > 0 || (request.Comparison.Extra?.Count ?? 0) > 0) throw new ArgumentException("请求包含尚不支持的对比字段。");
            string[] supportedBuckets = { "new_events", "ongoing", "recovered", "new_active_since_baseline", "repeated_keys", "priority" };
            if (request.PageSize is < 1 or > 200 || !supportedBuckets.Contains(request.DetailBucket)) throw new ArgumentException("对比明细类型或每页数量无效。");
            await ResolvePointTarget(request.Target, ct);
            var before = Validate(new QueryRequest { StartTime = request.Baseline.StartTime, EndTime = request.Baseline.EndTime, TimeRelation = "overlapping", EventKinds = request.EventKinds, Target = request.Target, OriginScope = request.OriginScope });
            var after = Validate(new QueryRequest { StartTime = request.Comparison.StartTime, EndTime = request.Comparison.EndTime, TimeRelation = "overlapping", EventKinds = request.EventKinds, Target = request.Target, OriginScope = request.OriginScope });
            if (before.End > after.Start || after.End - before.Start > TimeSpan.FromDays(31)) throw new ArgumentException("对比窗口顺序或总跨度无效。");
            bool ActiveBefore(EventRow x, DateTime t) => AlarmComparisonRules.ActiveBefore(x.Begin, x.End, t);
            string fingerprint = Fingerprint(before, request.PageSize) + Fingerprint(after, request.PageSize) + ":" + request.DetailBucket;
            string snapshotId; int offset; CompareSnapshot snapshot;
            if (request.Cursor == null)
            {
                // 仅允许一个大范围对比构建；查询边界是10万条，超限明确失败，不截断统计。
                if (!await ComparisonBuildGate.WaitAsync(0, ct)) throw new HistoryBusyException();
                try
                {
                var events = await Load(new QueryRange(before.Start, after.End, "overlapping", before.PointName, before.Kinds, before.PointFaultExcluded, before.ModelId, before.InstanceId, before.InstancePoints, before.DeviceName, before.DeviceAssociations), ct, maxRows: 100000);
                var added = events.Where(x => x.Begin >= after.Start && x.Begin < after.End).ToArray();
                var ongoing = events.Where(x => ActiveBefore(x, before.End) && ActiveBefore(x, after.End)).ToArray();
                var recovered = events.Where(x => AlarmComparisonRules.RecoveredInComparison(x.Begin, x.End, before.End, after.Start, after.End)).ToArray();
                var newActive = events.Where(x => ActiveBefore(x, after.End) && !ActiveBefore(x, before.End)).ToArray();
                string? AnomalyKey(EventRow e) => AlarmComparisonRules.RepeatedIdentity(e.EventKind, e.PointName, e.Source, e.FaultCode, e.LimitType);
                var baselineKeys = events.Where(x => AlarmComparisonRules.Overlaps(x.Begin, x.End, before.Start, before.End)).Select(AnomalyKey).Where(x => x != null).ToHashSet(StringComparer.OrdinalIgnoreCase);
                var repeated = added.Select(x => (Event: x, Key: AnomalyKey(x))).Where(x => x.Key != null).GroupBy(x => x.Key!, StringComparer.OrdinalIgnoreCase).Where(x => x.Count() > 1 || baselineKeys.Contains(x.Key)).Select(x => x.First().Event).ToArray();
                int unknownIdentity = added.Count(x => AnomalyKey(x) == null);
                // 未配置等级次序时，不假定级别1/2/3的严重程度；仅按活动和持续时间排序。
                var priority = events.Where(x => (x.Begin < after.End && (!x.End.HasValue || x.End > after.Start)) || ActiveBefore(x, after.End)).OrderByDescending(x => ActiveBefore(x, after.End)).ThenByDescending(x => AlarmComparisonRules.RecordedDurationSeconds(x.Begin, x.End, after.End)).ThenBy(x => x.EventId, StringComparer.Ordinal).ToArray();
                var buckets = new Dictionary<string, EventRow[]> { ["new_events"] = added, ["ongoing"] = ongoing, ["recovered"] = recovered, ["new_active_since_baseline"] = newActive, ["repeated_keys"] = repeated, ["priority"] = priority };
                int baselineCount = events.Count(x => x.Begin < before.End && (!x.End.HasValue || x.End > before.Start));
                int comparisonCount = events.Count(x => x.Begin < after.End && (!x.End.HasValue || x.End > after.Start));
                snapshotId = Guid.NewGuid().ToString("N"); offset = 0;
                snapshot = await WriteCompareSnapshot(snapshotId, fingerprint, buckets, request.DetailBucket, request.PageSize, baselineCount, comparisonCount, unknownIdentity, before.End - before.Start == after.End - after.Start, ct);
                lock (SnapshotGate)
                {
                    foreach (var expired in Snapshots.Where(x => x.Value.ExpiresAt <= DateTimeOffset.UtcNow).Select(x => x.Key)) Snapshots.TryRemove(expired, out _);
                    foreach (var expired in CompareSnapshots.Where(x => x.Value.ExpiresAt <= DateTimeOffset.UtcNow).Select(x => x.Key)) RemoveCompareSnapshot(expired);
                    if (Snapshots.Count + CompareSnapshots.Count + CurrentSnapshots.Count >= 4) { DeleteSnapshotFile(snapshot.FilePath); return StatusCode(429, Error("QUERY_LIMIT_EXCEEDED", "查询快照已满，请稍后重试。")); }
                    CompareSnapshots[snapshotId] = snapshot;
                }
                } finally { ComparisonBuildGate.Release(); }
            }
            else
            {
                (snapshotId, offset) = ReadCursor(request.Cursor);
                if (!CompareSnapshots.TryGetValue(snapshotId, out snapshot!) || snapshot.ExpiresAt <= DateTimeOffset.UtcNow) return Conflict(Error("COMPARISON_EXPIRED", "对比快照已过期，请重新查询。"));
                if (snapshot.Fingerprint != fingerprint) return Conflict(Error("CURSOR_MISMATCH", "分页游标与对比条件不一致。"));
            }
            int total = snapshot.Counts[request.DetailBucket];
            if (offset > total || offset % request.PageSize != 0) throw new ArgumentException("分页游标位置无效。");
            var page = await ReadComparePage(snapshot, offset, request.PageSize, ct);
            int next = offset + page.Length; bool hasMore = next < total;
            string? nextCursor = hasMore ? CreateCursor(snapshotId, next) : null;
            if (!hasMore) RemoveCompareSnapshot(snapshotId);
            var metrics = snapshot.Counts.ToDictionary(x => x.Key, x => new { count = x.Value, unit = x.Key == "repeated_keys" ? "abnormality_key" : "event" });
            return Ok(new { data = new { comparisonId = snapshotId, baselineSummary = new { eventCount = snapshot.BaselineCount }, comparisonSummary = new { eventCount = snapshot.ComparisonCount }, newEvents = snapshot.Counts["new_events"], ongoing = snapshot.Counts["ongoing"], recovered = snapshot.Counts["recovered"], metrics, detailBucket = request.DetailBucket, items = page.Select(Present), priorityEvidence = request.DetailBucket == "priority" ? page.Select(x => new { x.EventId, recordedActiveAtComparisonEnd = ActiveBefore(x, after.End), recordedDurationSeconds = AlarmComparisonRules.RecordedDurationSeconds(x.Begin, x.End, after.End), liveActivityVerified = false, severityUsed = false }) : null, countDefinitions = new { ongoing = "同一历史事件在两个窗口末端左极限均未恢复", recovered = "基准末端未恢复且在对比窗口内恢复，窗口间隔中的恢复不计入", repeated = "同一可识别异常在基准窗口存在且对比窗口新发，或对比窗口多次新发；模型实例身份缺失不推断", priority = "对比窗口存在的事件，按记录未恢复优先、记录持续秒数降序、事件ID稳定排序" }, durationComparable = snapshot.DurationComparable, repeatedCoverage = "partial", unknownIdentityEventCount = snapshot.UnknownIdentityCount, priorityRule = new { ruleVersion = "recorded-active-duration-v2", severityOrderConfigured = false, reasons = new[] { "按记录活动状态和持续时间排序", "未配置等级次序，未按等级排序" } } }, meta = Meta(new { pageSize = request.PageSize, hasMore, nextCursor, total }, before.PointFaultExcluded, before.InstanceId.HasValue, before.DeviceName != null, before.Kinds) });
        }
        catch (QueryCapacityException) { return UnprocessableEntity(Error("QUERY_LIMIT_EXCEEDED", "结果超过本接口的有界查询容量，请缩小时间或对象范围；未返回截断统计。")); }
        catch (HistoryBusyException) { return StatusCode(429, Error("QUERY_BUSY", "历史查询繁忙，请稍后重试。")); }
        catch (KeyNotFoundException ex) { return NotFound(Error("ENTITY_NOT_FOUND", ex.Message)); }
        catch (AmbiguousMatchException ex) { return Conflict(Error("ENTITY_AMBIGUOUS", ex.Message)); }
        catch (ArgumentException ex) { return BadRequest(Error("INVALID_REQUEST", ex.Message)); }
        catch (OperationCanceledException) when (ct.IsCancellationRequested) { throw; }
        catch (Exception) { return StatusCode(503, Error("SOURCE_UNAVAILABLE", "对比来源不可用或结果过多。")); }
    }
    /// <summary>从实际运行引擎读取模型、规则当前活动状态。</summary>
    /// <param name="request">可选目标、事件类型和挂起过滤。</param>
    /// <param name="cancellationToken">请求取消标记。</param>
    /// <returns>活动对象及引擎缓存状态覆盖说明。</returns>
    /// <remarks>读取原模型、规则及故障计算状态，固定快照分页2分钟。快照年龄不代表计算状态年龄。未启动引擎时返回不可用；缺少输入质量与成功计算时间时不能证明现场实时有效。</remarks>
    [HttpPost("current")]
    public async Task<IActionResult> Current([FromBody] CurrentRequest request, CancellationToken cancellationToken = default)
    {
        if (Connection() == null) return StatusCode(503, Error("SOURCE_UNAVAILABLE", "当前数据库与允许的本地参照数据源或时区配置不匹配。"));
        if ((request.Extra?.Count ?? 0) > 0 || (request.Target?.Extra?.Count ?? 0) > 0) return BadRequest(Error("INVALID_REQUEST", "请求包含尚不支持的筛选字段。"));
        if (request.PageSize is < 1 or > 200) return BadRequest(Error("INVALID_REQUEST", "每页数量须为1至200。"));
        string currentFingerprint = CurrentFingerprint(request);
        if (request.Cursor != null)
        {
            try
            {
                var (id, offset) = ReadCursor(request.Cursor);
                if (!CurrentSnapshots.TryGetValue(id, out var cached) || cached.ExpiresAt <= DateTimeOffset.UtcNow)
                    return Conflict(Error("SNAPSHOT_EXPIRED", "当前状态快照已过期，请重新查询。"));
                if (cached.Fingerprint != currentFingerprint) return Conflict(Error("CURSOR_MISMATCH", "游标与当前查询条件不一致。"));
                return CurrentPage(id, offset, cached, request.PageSize);
            }
            catch (ArgumentException ex) { return BadRequest(Error("INVALID_REQUEST", ex.Message)); }
        }
        if (ExcuteEngine.RTDDict == null || ExcuteEngine.RTDDict_Rule == null)
            return StatusCode(503, Error("RUNTIME_UNAVAILABLE", "本地测试宿主未启动计算引擎，无法判断当前报警。"));
        try { await ResolvePointTarget(request.Target, cancellationToken); }
        catch (KeyNotFoundException ex) { return NotFound(Error("ENTITY_NOT_FOUND", ex.Message)); }
        catch (AmbiguousMatchException ex) { return Conflict(Error("ENTITY_AMBIGUOUS", ex.Message)); }
        catch (ArgumentException ex) { return BadRequest(Error("INVALID_REQUEST", ex.Message)); }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
        catch (Exception) { return StatusCode(503, Error("SOURCE_UNAVAILABLE", "目标对象查询失败。")); }
        var selectedKinds = (request.EventKinds ?? new[] { "model_warning", "rule_warning", "fault_diagnosis" }).ToHashSet(StringComparer.Ordinal);
        if (selectedKinds.Count == 0 || selectedKinds.Any(x => x != "model_warning" && x != "rule_warning" && x != "fault_diagnosis")) return BadRequest(Error("INVALID_REQUEST", "包含尚不支持的实时事件类型。"));
        if (request.Target?.ResolvedModelId != null && !selectedKinds.Contains("model_warning")) return UnprocessableEntity(Error("MODEL_EVENT_KIND_UNSUPPORTED", "模型目标仅支持模型预警；故障关联尚未核实。"));
        var items = new List<object>(); string? point = request.Target?.PointName?.Trim();
        void Add(string name, IWarnModel obj, int? ruleLimit = null, bool? ruleActive = null, bool? ruleUnacknowledged = null)
        {
            if (point != null && !name.Equals(point, StringComparison.OrdinalIgnoreCase)) return;
            if (request.Target?.ResolvedModelId is int modelId && (obj.AlarmType != 0 || obj.ModelID != modelId)) return;
            if (!selectedKinds.Contains(obj.AlarmType == 0 ? "model_warning" : "rule_warning")) return;
            if (!(ruleActive ?? (obj.WarnState > 2)) || (!request.IncludeSuspended && obj.IsAlarmSuspended)) return;
            int blockId = obj switch { LAExWarn analog => analog.FcBlockID, LDExWarn digital => digital.FcBlockID, _ => -1 };
            if (request.Target?.ResolvedInstanceId is int instanceId && blockId != instanceId) return;
            if (request.Target?.ResolvedDeviceAssociations is { } associations && !associations.Any(x => string.Equals(x.PointName, name, StringComparison.OrdinalIgnoreCase) && x.ModelOrRule == obj.AlarmType && (x.ModelOrRule == 1 || (x.ModelId == obj.ModelID && x.BlockId == blockId)))) return;
            int level = ruleLimit ?? obj.LimitAlarmType;
            string acknowledgement = ruleUnacknowledged.HasValue ? (ruleUnacknowledged.Value ? "unacknowledged" : "acknowledged") : obj.WarnState == 4 ? "acknowledged" : obj.WarnState == 8 ? "unacknowledged" : "unknown";
            items.Add(new { runtimeId = $"{Epoch}:{obj.AlarmType}:{obj.ModelID}:{blockId}:{name}:{level}", eventId = (string?)null, pointName = name, modelId = obj.ModelID, blockId, sysId = obj.SysID, limitAlarmType = level, eventKind = obj.AlarmType == 0 ? "model_warning" : "rule_warning", activityState = "active", acknowledgement, suspension = obj.IsAlarmSuspended ? "suspended" : "not_suspended", historyLinkStatus = "unavailable", stateSource = "engine_computed_state", stateValidity = new { runnable = obj.Runable, constraintActive = obj.HasConstraint, rawState = obj.WarnState, inputFreshness = "unknown", lastSuccessfulEvaluationAt = (DateTimeOffset?)null, liveActivityVerified = false } });
        }
        foreach (var pair in ExcuteEngine.RTDDict.ToArray()) { object[] snapshot; lock (pair.Value) snapshot = pair.Value.ToArray(); foreach (var obj in snapshot) if (obj is IWarnModel warn) Add(pair.Key, warn); }
        bool ruleCoverage = true;
        try
        {
            foreach (var pair in ExcuteEngine.RTDDict_Rule.ToArray())
            {
                if (pair.Value is LAExWarn analog && analog.AlarmLevels.Count > 0)
                    foreach (var level in analog.AlarmLevels.Values.ToArray()) Add(pair.Key, analog, level.LimitAlarmType, level.Active, level.UnAck);
                else if (pair.Value is LDExWarn digital && digital.AlarmLevels.Count > 0)
                    foreach (var level in digital.AlarmLevels.Values.ToArray()) Add(pair.Key, digital, level.LimitAlarmType, level.Active, level.UnAck);
                else if (pair.Value is IWarnModel warn) Add(pair.Key, warn);
            }
        }
        catch (InvalidOperationException) { ruleCoverage = false; }
        catch (ArgumentException) { ruleCoverage = false; }
        // FaultInfoList由引擎维护且未统一加锁。尽量复制，不持锁干扰计算；并发变化时明确标记而非报告无故障。
        bool faultCoverage = selectedKinds.Contains("fault_diagnosis") && request.Target == null && ExcuteEngine.controllerList?.Count > 0;
        if (faultCoverage)
        {
            try
            {
                foreach (var controller in ExcuteEngine.controllerList.ToArray())
                {
                    if (controller?.FaultInfoList == null) { faultCoverage = false; continue; }
                    foreach (var pair in controller.FaultInfoList.ToArray())
                    {
                        var info = pair.Value;
                        if (info == null || info.Status != 1) continue;
                        string source = string.IsNullOrWhiteSpace(info.Source) ? pair.Key : info.Source;
                        items.Add(new { runtimeId = $"{Epoch}:fault:{controller.ID}:{pair.Key}:{info.Code}", eventId = (string?)null, eventKind = "fault_diagnosis", source, faultCode = info.Code, activityState = "active", controllerId = controller.ID, historyLinkStatus = "unavailable", stateSource = "engine_cached_status", timeQuality = "unverified" });
                    }
                }
            }
            catch (InvalidOperationException) { faultCoverage = false; }
            catch (ArgumentException) { faultCoverage = false; }
        }
        if (items.Count > 10000) return UnprocessableEntity(Error("QUERY_LIMIT_EXCEEDED", "运行状态超过快照容量，请缩小对象范围。"));
        object? targetMonitoring = null;
        if (request.IncludeMonitoringStatus && request.Target?.ResolvedModelId == null && request.Target?.ResolvedDeviceName == null)
        {
            try
            {
                var configs = ExcuteEngine.cldWarnpointList?.ToArray();
                if (configs != null)
                {
                    var matches = configs.Where(x => point == null || string.Equals(x.PointName, point, StringComparison.OrdinalIgnoreCase)).ToArray();
                    targetMonitoring = new { configuredCount = matches.Length, disabledCount = matches.Count(x => !(x.WarnStatus > 0)), enabledCount = matches.Count(x => x.WarnStatus > 0), instanceState = "unknown", notice = "尚未核实每项配置的实例状态。" };
                }
            }
            catch (InvalidOperationException) { targetMonitoring = null; }
            catch (ArgumentException) { targetMonitoring = null; }
        }
        var includedKinds = selectedKinds.Where(x => (x != "fault_diagnosis" || faultCoverage) && (x != "rule_warning" || ruleCoverage)).ToArray();
        string currentId = Guid.NewGuid().ToString("N");
        var observedAt = DateTimeOffset.UtcNow;
        var currentSnapshot = new CurrentSnapshot(currentFingerprint, observedAt, observedAt.AddMinutes(2),
            items.Select(x => JsonSerializer.SerializeToElement(x, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase })).ToArray(),
            targetMonitoring, ruleCoverage, faultCoverage, request.Target != null,
            request.Target?.ResolvedInstanceId != null, request.Target?.ResolvedDeviceName != null, includedKinds);
        if (items.Count > request.PageSize)
        {
            lock (SnapshotGate)
            {
                foreach (var expired in CurrentSnapshots.Where(x => x.Value.ExpiresAt <= observedAt).Select(x => x.Key)) CurrentSnapshots.TryRemove(expired, out _);
                if (Snapshots.Count + CompareSnapshots.Count + CurrentSnapshots.Count >= 4)
                    return StatusCode(429, Error("QUERY_LIMIT_EXCEEDED", "查询快照已满，请稍后重试。"));
                CurrentSnapshots[currentId] = currentSnapshot;
            }
        }
        return CurrentPage(currentId, 0, currentSnapshot, request.PageSize);
    }
}
