# ExcuteEngine

基于 .NET 6 的计算与执行引擎解决方案。

## 本地配置

仓库不会提交包含真实连接信息的 `DataCommSisKaT/Config.json`。首次运行前，请复制示例配置：

```powershell
Copy-Item DataCommSisKaT/Config.example.json DataCommSisKaT/Config.json
Copy-Item DataCommSisKaT/cfg.example.ini DataCommSisKaT/cfg.ini
```

然后在本地 `Config.json` 和 `cfg.ini` 中填写数据库、Redis、InfluxDB 和各服务接口信息。这两个文件均已被 `.gitignore` 排除。

调用 TPRI 写入接口前，还需要设置以下环境变量：

- `TPRI_ACCESS_KEY`：接口 AccessKey
- `TPRI_SECRET_KEY`：接口 SecretKey
- `TPRI_BASE_URL`：接口根地址，例如 `https://example.internal`
- `TPRI_FIXED_ASSET_CODE`：固定资产编码；未设置时默认为 `opc_jianpan`

如需启用旧版 TDengine 辅助代码，请额外设置 `TDENGINE_USERNAME` 和 `TDENGINE_PASSWORD`。

## 时序数据访问方式

`Config.json` 根节点的 `TsqServerBaseUrl` 控制 InfluxDB 读写方式，修改后重启程序生效：

- 配置 TSQSERVER 的 HTTP/HTTPS 根地址：查询和写入统一通过 `POST /api/ExcuteEngine/Query`、`POST /api/ExcuteEngine/Write`，正文分别为裸 SQL 和 Line Protocol，使用 `text/plain; charset=utf-8`。
- 未配置、null、空字符串或全空白：继续使用原 InfluxDB 客户端、GET 查询及 `InfluxDBQueryApiurl` 查询代理。示例配置默认此方式。
- 非空地址格式错误会报配置错误；HTTP 失败不会切回原访问方式，也不会自动重试写入。请求默认超时 30 秒，超时不代表远端一定未落库。

HTTP 模式保留测点名、`pvalue` 字段及秒级时间戳，写入按最多 10000 行、UTF-8 正文 1 MiB 拆批；后批失败时前批不会回滚。目标数据库及权限由 TSQSERVER 配置，客户端原 `dbName`、组织和 Token 不传给它。部署时核对服务端按秒解释时间戳、批次限制和目标数据库，并使用约定测试点写入回读核对实际时间。

查询返回继续使用原 `List<DataItem>`。调节品质曲线、经济报警曲线及专家库历史查询均经过同一访问分流。方案和离线验证见 [TSQSERVER 接入方案](.ccg/plan/tsq-server-influxdb-routing.md) 与 [协议回归](tests/InfluxDBRoutingRegression/README.md)。

## 构建

```powershell
dotnet restore DataCommSisKaT.sln
dotnet build DataCommSisKaT.sln --configuration Release --no-restore
```

> 项目当前目标框架为 .NET 6。请确保本机已安装兼容的 .NET SDK 和项目所需的本机依赖。
