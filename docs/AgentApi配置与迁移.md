# 智能体接口配置

新版接口随主程序启动，使用程序目录下原 Config.json。不是独立服务，不新增数据库连接。原 rtserverport、mysqlConn 等配置不变。

在原 JSON 根对象增加 AgentApi（不要覆盖整个文件）：

```json
"AgentApi": {
  "Enabled": true,
  "SourceId": "pw-unit8",
  "UnitId": 8,
  "StorageOffsetMinutes": 480
}
```

七号用 pw-unit7 / 7，八号用 pw-unit8 / 8。同一个程序包适用两台机组，端口仍使用原 rtserverport。SourceId 是显式来源标识，不自动检查历史记录归属，也不按库名推断机组。

Enabled 缺省或 false 时不注册 /api/v2 控制器，原 Swagger 和旧接口保留。启用但缺少来源标识、机组号非法、时区配置非法时，记录明确错误并只关闭新版接口，原引擎和旧接口继续启动。当前数据库时间约定为北京时间，StorageOffsetMinutes 必须是 480。

启动时冻结 AgentApi，所有修改重启后生效。主程序现有 Config.json 优先于环境变量；旧 agent.env 可暂时兼容，但正式迁移后删除重复配置避免歧义。不要携带示例 Config.json 覆盖现场原文件。

迁移步骤：备份原 Config.json 和 service/agent.env；在原 Config.json 增加完整 AgentApi 段；更新程序；删除 service 中专用于 agent.env 的 EnvironmentFile 行（其他环境配置保留）；systemctl daemon-reload；重启对应服务；核对 capabilities 的 sourceId/unitId/database，以及新旧 Swagger 和接口。验证完成后 agent.env 可保留为备份但不再加载。Windows 或手动运行同样读取程序目录 Config.json，无需 systemd。

仓库默认 Enabled=false，部署时显式填写并开启。配置错误时查看启动日志，不能把 v2 缺失当作无报警。
