using System.Security.Cryptography;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;

namespace TDServer.Service.AgentV2;

/// <summary>提供当前配置机组的智能体接口能力信息。</summary>
[ApiController]
[Route("api/v2/capabilities")]
[ApiExplorerSettings(GroupName = "agent-v2")]
public sealed class CapabilitiesController : ControllerBase
{
    private readonly IConfiguration _configuration;
    /// <summary>读取当前宿主的数据源配置。</summary>
    public CapabilitiesController(IConfiguration configuration) => _configuration = configuration;
    /// <summary>获取当前已实现的接口能力及覆盖状态。</summary>
    /// <returns>当前能力和覆盖状态。</returns>
    [HttpGet]
    public IActionResult Get()
    {
        string database = AgentDataSource.Database(_configuration);
        bool available = !string.IsNullOrWhiteSpace(database) && database.Equals(AgentDataSource.ActualDatabase(), StringComparison.OrdinalIgnoreCase);
        string sourceId = AgentApiConfiguration.SourceId(_configuration);
        int? unitId = AgentApiConfiguration.UnitId(_configuration);
        return Ok(new {
        data = new
        {
            apiVersion = "2.0", sourceId, unitId, database, connectionSource = "original_engine_config", historicalOrigin = AgentDataSource.IsReference(database) ? "reference_test_data" : "unverified",
            queryLimits = new { pageSizeMax = 200, historyRowsMax = 10000, comparisonRowsMax = 100000, currentRowsMax = 10000, concurrentSnapshotsMax = 4, comparisonSnapshotTtlSeconds = 300, currentSnapshotTtlSeconds = 120 },
            currentStateSemantics = "original_engine_state_freshness_unverified",
            comparisonSemantics = "recorded_intervals_not_live_activity",
            eventKinds = available ? new[] { new { eventKind = "model_warning", historySupported = true }, new { eventKind = "rule_warning", historySupported = true }, new { eventKind = "fault_diagnosis", historySupported = true } } : Array.Empty<object>(),
            notice = available ? "沿用原引擎配置的数据源；历史归属和实时有效性仍需结合返回证据核实。" : "原引擎数据源尚未初始化或与可选库名校验不一致。"
        },
        meta = new
        {
            requestId = HttpContext.TraceIdentifier, sourceId, unitId,
            generatedAt = DateTimeOffset.Now, timeZone = "Asia/Shanghai",
            coverage = new { status = available ? "partial" : "unavailable", scopeCompleteness = "unknown", issues = new[] { new { code = "LIMITED_IMPLEMENTATION", message = "历史归属和实时计算有效性未核实；查询容量详见queryLimits，超限明确失败。" } } }
        }
        });
    }
}
