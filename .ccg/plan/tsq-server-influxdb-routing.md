# InfluxDB 读写增加 TSQSERVER HTTP 模式实施方案

## 状态与目标

本方案已获用户通过 ccg-execute 明确授权实施。实现和验证记录见文末；未连接现场数据库或调用现场写入接口。

在现有读写封装中增加按配置分流：TsqServerBaseUrl 非空时统一调用 TSQSERVER；缺失、null、空字符串或全空白时保持旧访问路径。非空但格式错误时报配置错误，不能静默回退。HTTP 请求失败也不能自动切换旧路径或自动重试写入。

## 已核实的上下文

- DataCommSisKaT/Program.cs 加载 Config.json 并绑定 ConfigInfo 单例；虽然配置源 reloadOnChange=true，现有 ConfigInfo 是启动时一次绑定，本次按重启生效实施，不新增热切换。
- TDServer.Service/ClassDto.cs 的 ConfigInfo 目前没有 TsqServerBaseUrl。
- ExcuteEngine 构造函数先设置 configInfo，再调用 InfluxDBHelp.InitInfluxDB，然后初始化和启动引擎。
- TDServer.Service/TDService.cs 也有同名初始化调用，但已在 csproj 中排除编译，不扩大修改范围。
- InfluxDBHelp 现有四个有效写入入口：Dictionary<string,double>、二次计算嵌套字典、List<WarnRValue> 和 BatchInsertPointValue(List<items>)。
- 现有查询既有直接 GET InfluxDB /query，也有 POST InfluxDBQueryApiurl，不能将旧模式概括成全都直连数据库。
- ControlQualityService.GetControlAlarmCurve、EconomicAlarmMonitoringService.GetEconomicAlarmCurve、ICCompareService.CreateExpertICByDt 绕过封装，直接 POST 旧 InfluxDBQueryApiurl，需要一并接入查询分流。
- 桌面参考文件为仅支持 TSQSERVER 的版本，不能直接整文件覆盖项目版本；提取 HTTP 协议和批次实现，保留旧分支。
- Config.json 已被 gitignore 排除，Config.example.json 被跟踪。实施时仅在本地配置添加用户指定地址，在示例配置添加空字符串，不复制其他现场配置。

## 方案选择

| 方案 | 优缺点 | 结论 |
| --- | --- | --- |
| 直接用桌面文件替换 | 改动直接，但不支持空配置沿用旧模式，且遗漏三个业务查询入口 | 不采用 |
| 每个业务方法自行判断并发送 HTTP | 能工作，但会复制协议、校验和错误处理 | 不采用 |
| 现有 InfluxDBHelp 内分流，HTTP 传输和解析独立封装 | 保留业务接口、复用传输逻辑，并覆盖旁路查询 | 采用 |

代码使用普通属性、if、foreach、List 和常规方法，不引入策略框架、额外 NuGet 包或数据库结构变更。新增方法添加中文注释。

## 实施步骤

### 1. 配置与初始化

1. 在本地 DataCommSisKaT/Config.json 根节点首项添加 `"TsqServerBaseUrl": "http://192.168.1.154:5336"`。
2. Config.example.json 首项添加同名空字符串，保持示例默认运行旧模式。
3. ConfigInfo 添加带中文说明的 string 属性，默认 string.Empty，实际判断使用 IsNullOrWhiteSpace 以兼容 null。
4. InfluxDBHelp.InitInfluxDB 保留公开签名。读取已经绑定的 configInfo，冻结本次运行的模式和规范化地址。
5. HTTP 模式校验 HTTP/HTTPS 根地址及路径拼接，拒绝 query、fragment 和错误配置；不创建 InfluxDBClient、不发网络探活请求。旧模式仍按原参数创建客户端。
6. 启动日志只说明模式和必要的服务地址，不输出 Token 或连接串。修改配置后重启程序生效。

### 2. HTTP 传输封装

建议新增 TDServer.Service/InfluxDBHelp.TsqServer.cs，原类改成 partial；HTTP 请求、响应检查和批次辅助方法集中在此，原业务入口继续位于 InfluxDBHelp.cs。

按桌面参考文件实现：

| 项目 | 约定 |
| --- | --- |
| 写地址 | POST {TsqServerBaseUrl}/api/ExcuteEngine/Write |
| 查询地址 | POST {TsqServerBaseUrl}/api/ExcuteEngine/Query |
| Content-Type | text/plain; charset=utf-8 |
| 查询请求体 | 原始 SQL，不包裹 {sql:...} JSON |
| 写请求体 | 多行 InfluxDB Line Protocol |
| 成功条件 | HTTP 2xx，响应为 JSON 对象，code 为整数 0 |
| 默认单次请求超时 | 参考文件中的 30 秒，覆盖发送和响应读取 |

复用一个 HttpClient，及时释放每次请求、响应及取消令牌。异步内部使用 ConfigureAwait(false)，原同步入口使用 GetAwaiter().GetResult()，避免扩大为全调用链异步改造。

错误包含操作类型、HTTP 状态、服务端 msg 和存在时的 X-Request-Id，不输出整批写值或 Token。分别识别连接失败、超时、HTTP 非成功、业务 code 非 0、非 JSON/缺少 code 等问题。SendWriteBatch 不重试、不重新生成时间戳。超时只说明请求结果不确定，不声称一定未写入。

### 3. 写入接入

四个写入入口均增加模式分支，旧模式继续执行原实现，HTTP 模式复用共同的写入批次封装：

| 原入口 | HTTP 数据映射 |
| --- | --- |
| BatchInsert(Dictionary<string,double>) | 字典键为 measurement，值为 pvalue |
| BatchInsert(嵌套字典) | 内层键为 measurement，LA.buffer 为 pvalue |
| BatchInsert(List<WarnRValue>) | WarnRTableName 为 measurement，RValue.buffer 为 pvalue |
| BatchInsertPointValue(List<items>) | item 为 measurement，value 为 pvalue |

保持原有测点名称、字段 pvalue、秒级采样精度和现有 SQL/时区语义。每批先冻结值和时间戳，拆批发送沿用已生成内容，不在发送或失败处理时重新采样。

优先核实并复用当前 InfluxDB.Client 4.14.0 可用的 PointData 行协议序列化接口；若需要参考文件的手动格式化，应覆盖 measurement 转义、InvariantCulture 浮点格式、NaN/Infinity、空值、换行和控制字符。HTTP 分支不把空 RValue 自动当成 0，不接受非法行；不顺带改变旧模式的空值处理。

参考文件每请求最多 10000 行且 UTF-8 正文不超过 1 MiB，按这两个限制拆批；先校验整个批次，单行超限则发送前失败。后批失败不重发已成功前批，不能承诺整个方法具备数据库事务性。

嵌套字典只迁移当前有效的逐点 pvalue 分支，不启用原文件 return 后不可达的多字段业务逻辑。

保留各入口的调用契约：原来抛异常的入口继续由原调用方处理；重构值入口继续记录并抛出；BatchInsertPointValue 失败记录原因并返回 false、成功返回 true。HTTP 模式的成功表示远端接口按协议响应成功，不扩大为其他持久化保证。

### 4. 查询统一与兼容

增加 `public static List<DataItem> ExecuteQuery(string sql)` 作为列表查询入口：

- HTTP 模式：裸 SQL POST Query；先校验 HTTP/code，再要求 data 为数组；逐项检查 error，任一语句失败则报告语句序号；转换为原有 List<DataItem>。
- 旧模式：保持现有 InfluxDBQueryApiurl 的 POST JSON {sql:...} 协议，抽取原列表查询公共流程。保留旧接口已有的成功/失败处理边界，不向旧接口误发裸 SQL。
- data=[] 为合法空列表；有 statement_id 但无 series 为合法无数据语句，保留 series=null，不能丢项、重排或补成虚构数据。
- 保留 DataItem、SeriesItem、InfluxQuery、Response2<T> 等现有类型和 List<List<string>> values 契约，覆盖返回数值和 null 的反序列化测试，不改为新的 DTO 类型。

各查询入口按原签名适配：

| 入口 | HTTP 模式与兼容约束 |
| --- | --- |
| QueryAsync(dbName,command,out msg) | HTTP 时调用 ExecuteQuery；失败返回 -1 并填写 msg；旧模式保留原 GET /query、db 参数和 Token |
| GetValueByTime | 复用 QueryAsync，保留现有 SQL 和时间转换 |
| GetQjrhValue | HTTP 时统一查询，失败/无数据仍返回 null；保留 ts 字段与十分钟窗口 |
| GetEletodaysum | HTTP 时统一查询，保留 sum/7200 和 5 秒采样；无数据返回 0；原来已有的 HTTP 非成功回零边界保留，其他异常仍交原调用方 |
| 三个业务旁路查询 | 仅替换查询获取环节，复用 ExecuteQuery；保留 SQL、多语句顺序、曲线填充、业务计算和对外失败返回约定 |

列表查询入口的严格异常在原调用边界映射，不能把所有异常都当成空列表或 0，也不能让共用封装无意改变原曲线/专家库的失败返回。

TSQSERVER 请求没有 db/org/token 参数，目标数据库由该服务配置决定。QueryAsync 的 dbName 仅在 HTTP 模式保留签名兼容，不能声称 HTTP 也使用了该参数。

### 5. 需要核对的服务端契约

这些是联调检查项，不要求本轮访问现场写接口：

1. 根地址下实际存在两个 api/ExcuteEngine 路由，写响应同样使用 code/msg 成功信封。
2. Write 将参考文件中的秒级 Unix 时间戳按秒处理。Line Protocol 本身不能替客户端与接收端约定时间单位；不能仅看 HTTP 200 就判定写入时间正确。
3. 服务端使用预期 InfluxDB 数据库/组织，以及正确 token，支持现有 SQL，包括多语句、原有字段和函数。
4. 10000 行、1 MiB 是参考客户端采用的限制，尚未通过服务端代码核实；联调确认或按服务端更严格值调整。
5. 服务端 Query 返回顺序和 statement_id 对应关系、无数据 series 的表示与当前业务一致。

依据：https://docs.influxdata.com/influxdb/v1/write_protocols/line_protocol_reference/ 。该文档说明 Line Protocol 结构及通过写 API 指定其他时间精度；不用于证明现场 TSQSERVER 的具体实现。

## 关键文件与修改边界

| 文件 | 计划操作 |
| --- | --- |
| DataCommSisKaT/Config.json | 本地添加指定地址，不触及其他配置值，不强制纳入 Git |
| DataCommSisKaT/Config.example.json | 添加空字符串示例 |
| TDServer.Service/ClassDto.cs | ConfigInfo 新增属性和注释 |
| TDServer.Service/InfluxDBHelp.cs | 初始化分流、四写入入口和查询入口适配，保留原 DTO |
| TDServer.Service/InfluxDBHelp.TsqServer.cs | 新增 HTTP 传输、协议校验和批次辅助方法 |
| TDServer.Service/ControlQualityService.cs | 替换历史曲线的旁路查询获取环节 |
| TDServer.Service/EconomicAlarmMonitoringService.cs | 替换经济报警曲线的旁路查询获取环节 |
| TDServer.Service/ICCompareService.cs | 替换专家库历史查询获取环节 |
| tests/InfluxDBRoutingRegression/* | 按现有独立回归项目形式，增加本地假 HTTP 服务测试，不依赖现场 |
| README.md | 说明两种模式、重启生效、HTTP 失败不回退、TSQSERVER 数据库归属 |

ExcuteEngine 构造函数现有调用顺序可复用，原则上不修改它。HomeController、算法调用处继续使用原公开方法；不改前端 API，不删除 InfluxDB.Client 依赖，不改此前模型加载和系统点同步功能。

## 验证与验收

先建立有意义的本地协议回归，再实现和验证：

1. 缺失/null/空/空白配置走旧模式；有效 HTTP/HTTPS、尾斜杠正确；非空无效地址明确报错。
2. 本地假 TSQSERVER 验证两个 POST 路径、text/plain、裸 SQL、行协议正文；HTTP 模式不创建或访问旧客户端，Token 不发送给 TSQSERVER。
3. 采用用户提供的 Query 样例验证 values 数值 16 可按现有业务读取；测试空列表、无 series、null、多个 statement_id、单条 error、code 非 0、缺少 data、非 JSON 和非 2xx。
4. 四写入入口映射完整；测试 measurement 特殊字符、非中文小数区域设置、秒级时间戳、非法浮点数/空值。
5. 覆盖 10000 行与 UTF-8 1 MiB 边界、单行超限、后批失败；验证无额外重试、无旧路径回退、已生成时间戳不变。
6. 验证 QueryAsync 的 -1/msg、GetQjrhValue 的 null、GetEletodaysum 的既有返回边界、BatchInsertPointValue 的 bool，以及三个业务入口的失败映射和无数据处理。
7. 旧模式分别使用本地假的原查询代理、InfluxDB GET/写入端点验证协议、db/org、原精度，不能只测试分流条件。
8. 通过源码检索确认有效的 InfluxDBQueryApiurl 调用均集中到受分流控制的位置，没有遗漏旁路查询。
9. 构建 DataCommSisKaT Release/x64，运行现有故障报警与模型系统点回归，检查变更差异和空白问题。
10. 后续联调使用约定的测试测点写入并回读，核对值和实际时间；不在自动测试中写现场业务表。

## 交付顺序

配置与初始化 → HTTP 公共封装 → 四写入入口 → 查询统一与三个旁路入口 → 本地协议和兼容回归 → 构建与原功能回归 → 文档及服务端联调说明。

## 实施记录

- 已新增配置属性，本地 Config.json 开头写入用户指定地址，示例配置默认空值，其他现场配置保留。
- 已在 InfluxDBHelp 中实现启动模式固定与两种访问路径，HTTP 逻辑集中于 InfluxDBHelp.TsqServer.cs；未修改引擎初始化调用链。
- 四个写入入口已接入，使用已核实的 InfluxDB.Client 4.14.0 PointData.ToLineProtocol() 序列化，发送前冻结数据和秒级时间戳，按行数/字节拆批，不重试、不回退、不跟随重定向。
- 已接入列表查询入口、标量方法及三个原旁路查询；DTO 保留，无 series 不补造数据。TryExecuteQuery 仅适配 HTTP 非成功状态，协议/业务/连接/超时错误仍按原调用边界处理。
- LA 重载了 ==，新增路径使用 ReferenceEquals 判空，避免触发其数值比较操作符。
- 已增加独立本地协议回归和部署说明。现场服务端契约及两类曲线的完整数据库流程仍需后续联调，自动测试不连接现场。
- 验证通过：InfluxDBRoutingRegression 103 项断言、ModelAlarmPointRegression 300 项断言、FaultAlarmRegression 72 项断言；DataCommSisKaT Release/x64 构建无错误，保留项目既有警告。
- 配置原文比对确认两份配置仅添加首项；三个业务查询的计算主体在统一结果变量替换和缩进调整后与原实现一致。
