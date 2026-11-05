# 时序读写分流回归

独立 .NET 8 控制台回归项目，引用实际 TDServer.Service，使用 Kestrel 监听操作系统分配的本机端口。不会构造生产执行引擎、读取现场 Config.json、连接 MySQL 或访问现场 TSQSERVER/InfluxDB。

```powershell
dotnet run --project tests/InfluxDBRoutingRegression/InfluxDBRoutingRegression.csproj -c Release -p:Platform=x64
```

覆盖配置空值与地址校验、启动模式固定、两个裸文本 POST、用户查询响应样例、原 DTO 数值/null/无 series、多语句错误、HTTP/业务错误、超时及不回退、四个写入入口、SDK 转义、固定小数格式、非法值及完整预校验、10000 行和 UTF-8 1 MiB 精确边界、部分批次失败、并发查询。

当前通过 103 项断言。

旧访问方式也通过实际本地网络请求验证，包括 JSON 查询代理、GET /query 的数据库和 Token，以及四个原写入入口的 SDK 路由、组织、库和秒级精度。专家库查询覆盖不访问数据库的 HTTP 失败与无 series 返回分支。

这些测试验证客户端协议和兼容行为，不证明现场服务端已经正确持久化数据。两类历史曲线的完整数据库业务流程及真实服务端时间戳精度需在对应联调环境核对。
