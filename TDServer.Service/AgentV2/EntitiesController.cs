using EngineCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MySqlConnector;
using Microsoft.Extensions.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Logging;

namespace TDServer.Service.AgentV2;

/// <summary>七号机测点及模型身份解析。</summary>
[ApiController]
[Route("api/v2/entities")]
[ApiExplorerSettings(GroupName = "agent-v2")]
public sealed class EntitiesController : ControllerBase
{
    // 游标仅在本进程内有效，不依赖客户端令牌。
    private static readonly byte[] CursorKey = RandomNumberGenerator.GetBytes(32);
    private readonly IConfiguration _configuration;
    private readonly ILogger<EntitiesController> _logger;
    /// <summary>使用宿主的智能体数据源配置。</summary>
    public EntitiesController(IConfiguration configuration, ILogger<EntitiesController> logger) { _configuration = configuration; _logger = logger; }

    private void LogFailure(Exception exception)
    {
        string detail = string.Equals(_configuration["AgentApi:DiagnosticErrors"], "true", StringComparison.OrdinalIgnoreCase)
            ? Regex.Replace(exception.Message, @"(?i)(password|pwd)\s*=\s*[^;,\s]+", "$1=***") : "details disabled";
        _logger.LogWarning("Agent entity query failed: {ExceptionType}: {Detail}", exception.GetType().Name, detail);
    }

    private string AllowedDatabase => AgentDataSource.Database(_configuration);
    private string SourceId => _configuration["AgentApi:SourceId"] ?? (AllowedDatabase.Equals("warnnew", StringComparison.OrdinalIgnoreCase) ? "pw-unit7" : "test-" + AllowedDatabase);
    private int? UnitId => int.TryParse(_configuration["AgentApi:UnitId"], out int id) ? id : AllowedDatabase == "warnnew" ? 7 : null;
    internal static string DeviceCandidateId(string name) => "ent_device_" + Convert.ToBase64String(Encoding.UTF8.GetBytes(name)).TrimEnd('=').Replace('+', '-').Replace('/', '_');
    internal static string? DecodeDeviceCandidate(string id)
    {
        if (!id.StartsWith("ent_device_", StringComparison.Ordinal) || id.Length > 820) return null;
        try
        {
            string value = id[11..].Replace('-', '+').Replace('_', '/');
            value += new string('=', (4 - value.Length % 4) % 4);
            string name = new UTF8Encoding(false, true).GetString(Convert.FromBase64String(value));
            return name.Length is >= 3 and <= 150 && name == name.Trim() && !name.Any(char.IsControl) ? name : null;
        }
        catch (Exception ex) when (ex is FormatException or DecoderFallbackException) { return null; }
    }
    private string SignScopeCursor(string value)
    {
        using var hmac = new HMACSHA256(CursorKey);
        return Convert.ToHexString(hmac.ComputeHash(Encoding.UTF8.GetBytes(AllowedDatabase + "\n" + SourceId + "\n" + value)));
    }
    /// <summary>查询测点或模型的预警配置及所属实例，当前仅支持不超过200条的范围。</summary>
    /// <param name="entityId">解析接口返回的测点或模型ID。</param>
    /// <param name="relationType">支持 monitoring 与 model_membership；故障关联暂不可用。</param>
    /// <param name="pageSize">每页数量，1至200。</param>
    /// <param name="cursor">前一页返回的游标。</param>
    /// <param name="cancellationToken">请求取消标记。</param>
    /// <returns>明确关联的预警配置和实例，按配置ID和模型ID分页。</returns>
    [HttpGet("{entityId}/scope")]
    public async Task<IActionResult> Scope(string entityId, [FromQuery] string? relationType = null, [FromQuery] int pageSize = 50, [FromQuery] string? cursor = null, CancellationToken cancellationToken = default)
    {
        relationType ??= "monitoring";
        bool isPoint = entityId.StartsWith("ent_point_", StringComparison.Ordinal);
        bool isModel = entityId.StartsWith("ent_model_", StringComparison.Ordinal);
        bool isInstance = entityId.StartsWith("ent_instance_", StringComparison.Ordinal);
        string? deviceCandidate = DecodeDeviceCandidate(entityId);
        bool isDevice = deviceCandidate != null;
        int id = 0;
        if ((!isPoint && !isModel && !isInstance && !isDevice) || (!isDevice && (!int.TryParse(entityId[(isInstance ? 13 : 10)..], out id) || id <= 0)))
            return BadRequest(new { error = new { code = "INVALID_ENTITY_ID", message = "对象标识无效。", requestId = HttpContext.TraceIdentifier } });
        if (pageSize is < 1 or > 200) return BadRequest(new { error = new { code = "INVALID_REQUEST", message = "每页数量须在1至200之间。", requestId = HttpContext.TraceIdentifier } });
        if (relationType != "monitoring" && relationType != "model_membership") return UnprocessableEntity(new { error = new { code = "UNSUPPORTED_RELATION_TYPE", message = "该关联类型尚不可用。", requestId = HttpContext.TraceIdentifier } });
        int lastWarning = 0, lastModel = 0;
        long expires = DateTimeOffset.UtcNow.AddMinutes(5).ToUnixTimeSeconds();
        if (cursor != null)
        {
            try
            {
                if (cursor.Length > 1700) throw new FormatException();
                string[] parts = Encoding.UTF8.GetString(Convert.FromBase64String(cursor)).Split(':');
                if (parts.Length != 6 || parts[0] != entityId || !int.TryParse(parts[1], out var oldSize) || oldSize != pageSize || !int.TryParse(parts[2], out lastWarning) || !int.TryParse(parts[3], out lastModel) || !long.TryParse(parts[4], out expires) || lastWarning < 0 || lastModel < 0) throw new FormatException();
                string payload = string.Join(':', parts.Take(5));
                if (!CryptographicOperations.FixedTimeEquals(Encoding.ASCII.GetBytes(SignScopeCursor(relationType + ":" + payload)), Encoding.ASCII.GetBytes(parts[5]))) throw new FormatException();
                if (expires <= DateTimeOffset.UtcNow.ToUnixTimeSeconds()) return Conflict(new { error = new { code = "SNAPSHOT_EXPIRED", message = "分页游标已过期。", requestId = HttpContext.TraceIdentifier } });
            }
            catch (FormatException) { return BadRequest(new { error = new { code = "INVALID_CURSOR", message = "分页游标无效或与对象不匹配。", requestId = HttpContext.TraceIdentifier } }); }
        }
        string? connection = ExcuteEngine.configInfo?.mysqlConn;
        if (string.IsNullOrWhiteSpace(connection))
            return StatusCode(503, new { error = new { code = "SOURCE_UNAVAILABLE", message = "数据源尚未初始化。", requestId = HttpContext.TraceIdentifier } });
        try
        {
            if (!string.Equals(new MySqlConnectionStringBuilder(connection).Database, AllowedDatabase, StringComparison.OrdinalIgnoreCase))
                return StatusCode(503, new { error = new { code = "SOURCE_MISMATCH", message = "当前数据库与智能体允许的数据源不一致。", requestId = HttpContext.TraceIdentifier } });
            using var db = new WarnContext(connection);
            db.Database.SetCommandTimeout(5);
            string? key = isDevice ? deviceCandidate : isPoint
                ? await db.CfgVarsystems.AsNoTracking().Where(p => p.Id == id).Select(p => p.Name).SingleOrDefaultAsync(cancellationToken)
                : isModel ? await db.MetaFcmasters.AsNoTracking().Where(m => m.Id == id).Select(m => m.FunctionName).SingleOrDefaultAsync(cancellationToken)
                : await db.CldFcblocks.AsNoTracking().Where(b => b.Id == id).Select(b => b.FunctionName).SingleOrDefaultAsync(cancellationToken);
            if (key == null) return NotFound(new { error = new { code = "ENTITY_NOT_FOUND", message = "没有找到该对象。", requestId = HttpContext.TraceIdentifier } });

            var query = from warning in db.CldWarnpoints.AsNoTracking()
                        join block in db.CldFcblocks.AsNoTracking() on warning.CldFcblockId equals block.Id into blockGroup
                        from block in blockGroup.DefaultIfEmpty()
                        join master in db.MetaFcmasters.AsNoTracking() on block.FunctionName equals master.FunctionName into masterGroup
                        from master in masterGroup.DefaultIfEmpty()
                        where (isPoint ? warning.PointName == key : isModel ? master.Id == id : isInstance ? warning.CldFcblockId == id :
                              ((warning.Description != null && warning.Description.Contains(key)) || (block != null && block.Description != null && block.Description.Contains(key)) || (master != null && master.Description != null && master.Description.Contains(key)))) &&
                              (warning.Id > lastWarning || (warning.Id == lastWarning && (master == null ? 0 : master.Id) > lastModel))
                        orderby warning.Id, master.Id
                        select new { warning.Id, warning.PointName, warning.ModelOrrule, warning.CldFcblockId, warning.PrjSheetId, warning.PrjDocumentId, warning.PrjControllerId, BlockName = block.AlgName, FunctionName = block.FunctionName, ModelId = (int?)master.Id, ModelDescription = master.Description };
            var rows = await query.Take(pageSize + 1).ToListAsync(cancellationToken);
            bool hasMore = rows.Count > pageSize;
            if (hasMore) rows.RemoveAt(rows.Count - 1);
            string? nextCursor = null;
            if (hasMore && rows.Count > 0)
            {
                var last = rows[^1];
                string payload = $"{entityId}:{pageSize}:{last.Id}:{last.ModelId ?? 0}:{expires}";
                nextCursor = Convert.ToBase64String(Encoding.UTF8.GetBytes(payload + ":" + SignScopeCursor(relationType + ":" + payload)));
            }
            var items = rows.Select(x => new { warningConfigId = x.Id, pointName = x.PointName, point = new { pointName = x.PointName }, modelOrRule = x.ModelOrrule, instance = x.CldFcblockId > 0 ? new { blockId = x.CldFcblockId, algName = x.BlockName } : null, model = x.ModelId.HasValue ? new { modelDefinitionId = x.ModelId, functionName = x.FunctionName, description = x.ModelDescription } : null, location = new { controllerId = x.PrjControllerId, documentId = x.PrjDocumentId, sheetId = x.PrjSheetId }, relationStatus = isDevice ? "candidate" : "configured" }).ToArray();
            return Ok(new { data = new { entityId, relationStatus = isDevice ? "candidate" : "configured", scopeCompleteness = "unknown", relationCount = (int?)null, items, consistency = "bounded_read" }, meta = new { requestId = HttpContext.TraceIdentifier, sourceId = SourceId, unitId = UnitId, generatedAt = DateTimeOffset.UtcNow, timeZone = "Asia/Shanghai", coverage = new { status = "partial", scopeCompleteness = "unknown", includedEventKinds = Array.Empty<string>(), issues = new[] { new { code = isDevice ? "DEVICE_CANDIDATE_UNVERIFIED" : "SCOPE_UNVERIFIED", message = isDevice ? "设备范围按名称匹配，仅为候选，不代表完整设备归属；分页期间配置可能变化。" : "仅返回现有配置，无法证明整台设备监测范围完整；分页期间配置可能变化。" } } }, paging = new { pageSize, hasMore, nextCursor, total = (int?)null } } });
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
        catch (Exception ex) { LogFailure(ex); return StatusCode(503, new { error = new { code = "SOURCE_UNAVAILABLE", message = "数据源查询失败。", requestId = HttpContext.TraceIdentifier } }); }
    }

    /// <summary>解析请求所支持的对象类型。</summary>
    public sealed class ResolveRequest
    {
        /// <summary>点名、模型功能名或描述。</summary>
        public string? Text { get; set; }
        /// <summary>支持 point、model_definition、model_instance 和设备名称候选。</summary>
        public string[]? EntityTypes { get; set; }
        /// <summary>exact 精确匹配；search 模糊查找。</summary>
        public string MatchMode { get; set; } = "search";
        /// <summary>最大候选数，1 至 50。</summary>
        public int Limit { get; set; } = 20;
    }

    /// <summary>解析点表、模型定义、模型实例及待核实的设备名称候选。</summary>
    /// <param name="request">对象名称和筛选条件。</param>
    /// <param name="cancellationToken">调用方取消标记。</param>
    /// <returns>候选对象及监测范围说明。</returns>
    [HttpPost("resolve")]
    public async Task<IActionResult> Resolve([FromBody] ResolveRequest request, CancellationToken cancellationToken)
    {
        string query = request.Text?.Trim() ?? "";
        if (query.Length == 0 || query.Length > 150 || request.Limit is < 1 or > 50 ||
            (request.MatchMode != "exact" && request.MatchMode != "search") ||
            (request.MatchMode == "search" && query.Length < 3))
            return BadRequest(new { error = new { code = "INVALID_REQUEST", message = "请输入有效名称和查询参数。", requestId = HttpContext.TraceIdentifier } });

        var types = request.EntityTypes ?? new[] { "point", "model_definition", "model_instance", "device" };
        if (types.Length == 0 || types.Any(t => t != "point" && t != "model_definition" && t != "model_instance" && t != "device"))
            return UnprocessableEntity(new { error = new { code = "UNSUPPORTED_ENTITY_TYPE", message = "不支持该对象类型。", requestId = HttpContext.TraceIdentifier } });

        string? connection = ExcuteEngine.configInfo?.mysqlConn;
        if (string.IsNullOrWhiteSpace(connection))
            return StatusCode(503, new { error = new { code = "SOURCE_UNAVAILABLE", message = "数据源尚未初始化。", requestId = HttpContext.TraceIdentifier } });
        try
        {
            // 数据库名称须与明确配置一致；测试库不可默认冒充七号机。
            if (!string.Equals(new MySqlConnectionStringBuilder(connection).Database, AllowedDatabase, StringComparison.OrdinalIgnoreCase))
                return StatusCode(503, new { error = new { code = "SOURCE_MISMATCH", message = "当前数据库与智能体允许的数据源不一致。", requestId = HttpContext.TraceIdentifier } });
            using var db = new WarnContext(connection);
            db.Database.SetCommandTimeout(5);
            var candidates = new List<object>();
            bool truncated = false;
            bool hasUnverifiedDevice = false;
            if (types.Contains("device") && query.Length >= 3)
            {
                bool found = await db.CldWarnpoints.AsNoTracking().AnyAsync(x => x.Description != null && x.Description.Contains(query), cancellationToken) ||
                    await db.MetaFcmasters.AsNoTracking().AnyAsync(x => x.Type == "AIModel" && x.Description != null && x.Description.Contains(query), cancellationToken);
                if (found)
                {
                    hasUnverifiedDevice = true;
                    candidates.Add(new { entityId = DeviceCandidateId(query), entityType = "device", name = query, description = "按现有配置名称匹配的设备候选，归属和覆盖未核实。", matchBasis = "description_contains", relationStatus = "candidate", scopeCompleteness = "unknown", scopeUrl = $"/api/v2/entities/{DeviceCandidateId(query)}/scope" });
                }
            }
            if (types.Contains("point"))
            {
                int remaining = request.Limit - candidates.Count;
                var points = db.CfgVarsystems.AsNoTracking().Where(x => x.Name != null);
                points = request.MatchMode == "exact" ? points.Where(x => x.Name == query) :
                    points.Where(x => x.Name!.Contains(query) || (x.Description != null && x.Description.Contains(query)));
                var rows = await points.OrderBy(x => x.Id).Select(x => new { x.Id, x.Name, x.Description, x.Prj_Controller_ID }).Take(remaining + 1).ToListAsync(cancellationToken);
                truncated |= rows.Count > remaining;
                candidates.AddRange(rows.Take(remaining).Select(x => (object)new { entityId = $"ent_point_{x.Id}", entityType = "point", name = x.Name, description = x.Description, matchBasis = request.MatchMode, references = new { pointId = x.Id, controllerId = x.Prj_Controller_ID }, scopeCompleteness = "unknown", scopeUrl = $"/api/v2/entities/ent_point_{x.Id}/scope" }));
            }
            if (types.Contains("model_definition"))
            {
                int remaining = request.Limit - candidates.Count;
                var models = db.MetaFcmasters.AsNoTracking().Where(x => x.FunctionName != null);
                models = request.MatchMode == "exact" ? models.Where(x => x.FunctionName == query) :
                    models.Where(x => x.FunctionName!.Contains(query) || (x.Description != null && x.Description.Contains(query)));
                var rows = await models.OrderBy(x => x.Id).Select(x => new { x.Id, x.FunctionName, x.Description, x.Type }).Take(remaining + 1).ToListAsync(cancellationToken);
                truncated |= rows.Count > remaining;
                candidates.AddRange(rows.Take(remaining).Select(x => (object)new { entityId = $"ent_model_{x.Id}", entityType = "model_definition", name = x.FunctionName, description = x.Description, matchBasis = request.MatchMode, references = new { modelDefinitionId = x.Id, type = x.Type }, scopeCompleteness = "unknown", scopeUrl = $"/api/v2/entities/ent_model_{x.Id}/scope" }));
            }
            if (types.Contains("model_instance"))
            {
                int remaining = request.Limit - candidates.Count;
                var blocks = from block in db.CldFcblocks.AsNoTracking()
                             join master in db.MetaFcmasters.AsNoTracking() on block.FunctionName equals master.FunctionName
                             where master.Type == "AIModel" && block.AlgName != null
                             select new { block.Id, block.AlgName, block.Description, block.FunctionName, block.PrjControllerId, ModelId = master.Id };
                blocks = request.MatchMode == "exact" ? blocks.Where(x => x.AlgName == query) : blocks.Where(x => x.AlgName!.Contains(query) || (x.Description != null && x.Description.Contains(query)));
                var rows = await blocks.OrderBy(x => x.Id).ThenBy(x => x.ModelId).Take(remaining + 1).ToListAsync(cancellationToken);
                truncated |= rows.Count > remaining;
                candidates.AddRange(rows.Take(remaining).Select(x => (object)new { entityId = $"ent_instance_{x.Id}", entityType = "model_instance", name = x.AlgName, description = x.Description, matchBasis = request.MatchMode, references = new { blockId = x.Id, modelDefinitionId = x.ModelId, controllerId = x.PrjControllerId, functionName = x.FunctionName }, scopeCompleteness = "unknown", scopeUrl = $"/api/v2/entities/ent_instance_{x.Id}/scope" }));
            }
            return Ok(new
            {
                data = new { resolution = candidates.Count == 0 ? "not_found" : candidates.Count == 1 && !truncated && !hasUnverifiedDevice ? "exact" : "ambiguous", candidates },
                meta = new { requestId = HttpContext.TraceIdentifier, sourceId = SourceId, unitId = UnitId, generatedAt = DateTimeOffset.UtcNow, timeZone = "Asia/Shanghai", coverage = new { status = "partial", scopeCompleteness = "unknown", includedEventKinds = Array.Empty<string>(), issues = new[] { new { code = truncated ? "RESULT_LIMIT" : "SCOPE_UNVERIFIED", message = "仅解析当前配置，尚未核实设备范围及历史来源。" } } } }
            });
        }
        catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested) { throw; }
        catch (Exception ex)
        {
            LogFailure(ex);
            return StatusCode(503, new { error = new { code = "SOURCE_UNAVAILABLE", message = "数据源查询失败。", requestId = HttpContext.TraceIdentifier } });
        }
    }
}
