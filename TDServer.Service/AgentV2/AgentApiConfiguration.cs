using Microsoft.Extensions.Configuration;

namespace TDServer.Service.AgentV2;

/// <summary>启动时冻结主程序 AgentApi 配置。修改后重启生效，不随文件热更新切换机组。</summary>
public static class AgentApiConfiguration
{
    /// <summary>沿用主程序配置优先级（Config.json 优先，环境变量兼容旧部署）。错误仅关闭新增接口。</summary>
    public static IConfiguration CreateSnapshot(IConfiguration host, out string? error)
    {
        var values = host.GetSection("AgentApi").AsEnumerable()
            .ToDictionary(pair => pair.Key, pair => pair.Value, StringComparer.OrdinalIgnoreCase);
        error = null;
        var enabledText = host["AgentApi:Enabled"];
        bool enabled = bool.TryParse(enabledText, out var parsed) && parsed;
        if (enabledText != null && !bool.TryParse(enabledText, out _))
            error = "AgentApi.Enabled 必须为 true 或 false。";
        if (enabled)
        {
            if (string.IsNullOrWhiteSpace(host["AgentApi:SourceId"]))
                error = "启用新版接口必须配置 AgentApi.SourceId。";
            else if (!int.TryParse(host["AgentApi:UnitId"], out var unit) || unit <= 0)
                error = "AgentApi.UnitId 必须为正整数。";
            else if (host["AgentApi:StorageOffsetMinutes"] != "480")
                error = "当前报警记录按北京时间存储，AgentApi.StorageOffsetMinutes 必须为 480。";
        }
        values["AgentApi:Enabled"] = (enabled && error == null).ToString();
        return new ConfigurationBuilder().AddInMemoryCollection(values).Build();
    }

    /// <summary>来源标识只读取显式配置，禁止根据库名猜测机组。</summary>
    public static string SourceId(IConfiguration config) => config["AgentApi:SourceId"] ?? "";
    /// <summary>机组编号只读取显式配置。</summary>
    public static int? UnitId(IConfiguration config)
        => int.TryParse(config["AgentApi:UnitId"], out var unit) ? unit : null;
}
