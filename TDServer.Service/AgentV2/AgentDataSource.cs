using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace TDServer.Service.AgentV2;

/// <summary>智能体查询复用原计算引擎连接。绝不创建第二套数据库配置或切换数据库。</summary>
internal static class AgentDataSource
{
    internal static string ActualDatabase()
    {
        string? connection = ExcuteEngine.configInfo?.mysqlConn;
        if (string.IsNullOrWhiteSpace(connection)) return "";
        try { return new MySqlConnectionStringBuilder(connection).Database; }
        catch (ArgumentException) { return ""; }
    }
    // 兼容本地测试的显式库名核对；现场不设该值，自动跟随原Config.json。
    internal static string Database(IConfiguration config)
        => string.IsNullOrWhiteSpace(config["AgentApi:AllowedDatabase"]) ? ActualDatabase() : config["AgentApi:AllowedDatabase"]!;
    internal static bool IsReference(string database)
        => database.Equals("test001", StringComparison.OrdinalIgnoreCase) || database.Equals("warnnew-pz", StringComparison.OrdinalIgnoreCase);
}
