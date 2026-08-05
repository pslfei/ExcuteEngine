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

## 构建

```powershell
dotnet restore DataCommSisKaT.sln
dotnet build DataCommSisKaT.sln --configuration Release --no-restore
```

> 项目当前目标框架为 .NET 6。请确保本机已安装兼容的 .NET SDK 和项目所需的本机依赖。
