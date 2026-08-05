# AlarmController 需求整理

## 1. 目标概述

本需求是在现有执行引擎中新增一套基于 Excel 配置驱动的报警控制器。

该控制器不依赖数据库中的 `CldFcblock` 下装配置，而是在系统启动时直接读取 `alarm.xlsx`，实例化两类报警功能块：

- `DevAlarm`
- `AnalogFluctuationAlarm`

并按不同业务要求分别写入：

- `faultdiagnosis`
- `warnalarm`

新增报警控制器编号：

- `AlarmControllerID = 20000`


## 2. 数据来源

Excel 文件路径：

- `DataCommSisKaT/bin/Debug/net6.0/alarm.xlsx`

当前确认的 Sheet 结构如下。

### 2.1 偏差报警 Sheet

Sheet 名：

- `偏差报警`

表头：

- `故障码`
- `调门指令点名`
- `反馈偏差点名`
- `报警阈值`
- `延时（秒）`
- `报警条件`

示例数据：

- `1001 | d2_amillcapide | d2_amillcanmw | 30 | 20 | [d2_afdrflow] > 12`
- `1002 | d2_amillnmtime | d2_amillnmftaset | 30 | 30 | [d2_afdrflow] > 12`

### 2.2 波动报警 Sheet

Sheet 名：

- `波动报警`

表头：

- `模拟量波动点名`
- `采样时间`
- `报警阈值`
- `延时（秒）`
- `报警条件`

示例数据：

- `d2_20hfc10cp101 | 60 | 30 | 10 | [d2_afdrflow] > 12`
- `d2_afdrdmd | 60 | 30 | 10 | [d2_afdrflow] > 12`


## 3. 报警条件规则

报警条件表达式统一采用：

- `[点名] > 12`
- `[点名1] > 12 && [点名2] == 1`

说明：

- 该格式与现有 `AnalyticalExpression.Analytical(...)` 的解析方式兼容。
- 不再使用裸点名格式，例如 `d2_afdrflow > 12`。


## 4. 功能块实例化要求

### 4.1 总体要求

新增一个 Excel 驱动的报警控制器，初始化行为参考健康控制器。

目标行为：

1. 系统启动时读取 `alarm.xlsx`
2. 创建 `Controller(AlarmControllerID, configInfo.mysqlConn)`
3. 在该控制器内部完成报警功能块实例化
4. 将实例加入 `FunctionInstanceDict`
5. 运行期走现有控制器周期执行链路

说明：

- 创建实例时应使用 `CreateFcInstance("DevAlarm")`
- 创建实例时应使用 `CreateFcInstance("AnalogFluctuationAlarm")`
- 不能使用文件名 `FC_DevAlarm` 或 `FC_AnalogFluctuationAlarm`


## 5. 字段映射

### 5.1 偏差报警 -> DevAlarm

目标功能块：

- `FunctionCode.DevAlarm`

Excel 与字段映射：

- `故障码 -> FaultCode`
- `调门指令点名 -> IN1`
- `反馈偏差点名 -> IN2`
- `报警阈值 -> AlarmThreshold`
- `延时（秒） -> DelayTime`
- `报警条件 -> Condition`

业务含义：

- 当 `IN1 - IN2 > AlarmThreshold`
- 且 `Condition` 为真
- 且持续达到 `DelayTime`
- 判定为偏差报警

### 5.2 波动报警 -> AnalogFluctuationAlarm

目标功能块：

- `FunctionCode.AnalogFluctuationAlarm`

Excel 与字段映射：

- `模拟量波动点名 -> IN`
- `采样时间 -> SampleTime`
- `报警阈值 -> AlarmThreshold`
- `延时（秒） -> DelayTime`
- `报警条件 -> Condition`

业务含义：

- 在 `SampleTime` 时间窗内
- 计算 `max(IN) - min(IN)`
- 当该波动值大于 `AlarmThreshold`
- 且 `Condition` 为真
- 且持续达到 `DelayTime`
- 判定为波动报警


## 6. 入库要求

### 6.1 DevAlarm -> faultdiagnosis

`DevAlarm` 的报警记录写入：

- `FaultDiagnosis`

目标表模型：

- `EngineCore.Models.FaultDiagnosis`

入库字段要求：

- `FaultCode = Excel.故障码`
- `BeginTime = 报警开始时间`
- `EndTime = 报警恢复时间`
- `Source = DevAlarm 实例名`

记录规则：

- 报警触发时新增一条记录
- 报警恢复时回填同一条记录的 `EndTime`

实现约束补充：

- `Source` 必须写 `DevAlarm.InstanceName`
- 不应再依赖 `FunctionInstanceDict` 的 key 与实例名“恰好相等”这一隐式约定
- 入库时应优先读取功能块顶层的 `InstanceName`，仅在实例名为空时回退到字典 key

### 6.2 AnalogFluctuationAlarm -> warnalarm

`AnalogFluctuationAlarm` 的报警记录写入：

- `WarnAlarm`

目标表模型：

- `EngineCore.Models.WarnAlarm`

固定要求：

- `AlarmType = 1`
- `LimitAlarmType = 20`

建议字段定义：

- `PointName = Excel.模拟量波动点名`
- `SysID = -1`
- `ModelID = -1`
- `BeginTime = 报警开始时间`
- `EndTime = 报警恢复时间`
- `Duration = 持续秒数`
- `UnAck = 1`
- `Level = 1`
- `AlarmType = 1`
- `LimitAlarmType = 20`

记录规则：

- 报警触发时新增一条 `WarnAlarm`
- 报警恢复时更新该条记录的 `EndTime` 和 `Duration`

实现约束补充：

- 由于 `warnalarm` 表中没有单独的实例名字段，恢复记录通常只能依赖 `PointName + AlarmType + LimitAlarmType + EndTime == MinValue` 去匹配未恢复报警
- 因此“波动报警”配置中应保证 `模拟量波动点名` 唯一，避免同一点名出现多条同类型未恢复报警而导致恢复匹配歧义


## 7. FaultOut 复用结论

### 7.1 结论

`FaultOut` 的处理机制可以复用一部分思想，但当前 `DevAlarm` 内部定义的 `faultOut` 不能零改动直接复用现有程序处理链。

结论分两层：

- `FaultOut` 这个算法块本身已有现成处理逻辑，程序层面已经支持
- 但 `DevAlarm` 当前把 `FaultOut` 作为内部字段嵌进去，并不会自动进入现有 `FaultOut` 处理主链

### 7.2 为什么不能直接复用

当前 `DevAlarm` 的实现方式是：

- 定义内部字段 `public FaultOut faultOut = new FaultOut();`
- 在 `Run()` 中只给 `faultOut.FaultCode` 和 `faultOut.IN[0]` 赋值

但存在以下问题：

1. `faultOut.Run()` 没有被调用

- `FaultOut` 的 `NeedOut` 边沿判断在 `FaultOut.Run()` 中完成
- 当前 `DevAlarm.Run()` 只赋值，没有执行 `faultOut.Run()`
- 因此 `NeedOut` 和 `OUT` 不会自动更新到可入库状态

2. `faultOut` 不在 `FunctionInstanceDict` 顶层

- 现有 `Controller.InsertFaultData()` 遍历的是控制器的 `FunctionInstanceDict`
- 它只会把顶层功能块当作故障源处理
- `DevAlarm` 内部的 `faultOut` 不会被单独扫描

3. 现有 `InsertFaultData()` 读取的是顶层字段

当前故障处理逻辑默认从功能块顶层读取：

- `NeedOut`
- `OUT`
- `FaultCode`

而不是去读取嵌套对象：

- `faultOut.NeedOut`
- `faultOut.OUT`
- `faultOut.FaultCode`

### 7.3 可复用的正确理解

可以复用的不是“当前这段嵌套写法直接生效”，而是：

- 复用 `FaultOut` 的边沿触发语义
- 复用 `FaultDiagnosis` 的入库模型
- 复用 `Controller.InsertFaultData()` 的整体入库流程

前提是要增加一层适配，让 `DevAlarm` 的故障状态能以程序现有识别的形式暴露出来。

### 7.4 推荐处理方向

推荐方向是：

- 保留 `DevAlarm -> FaultDiagnosis` 这一业务目标
- 但不要假设“内部 `faultOut` 赋值”就等于已经接入现有 `FaultOut` 程序处理链

实现层面最终应采用：

1. 让 `DevAlarm` 顶层暴露 `NeedOut`、`OUT(LD)`、`FaultCode`
2. `DevAlarm.Run()` 在完成偏差报警延时判定后，显式调用内部 `faultOut` 的执行逻辑
3. 将 `faultOut.OUT / faultOut.NeedOut / faultOut.OldIN` 同步回 `DevAlarm` 顶层

这样可以同时满足：

- 复用 `FaultOut` 的边沿语义
- 不修改 `Controller.InsertFaultData()` 的主扫描对象
- 让 `DevAlarm` 直接被现有 `FaultDiagnosis` 入库流程识别


## 8. 对 warnalarm 现有查询链路的影响

`AnalogFluctuationAlarm` 写入 `warnalarm` 时，虽然 `AlarmType = 1` 已与现有“规则报警”分类保持一致，但仍需注意下面的展示链路约束。

现有 `GetWarnAlarmList(...)` 的查询逻辑会使用：

- `WarnAlarm.PointName`
- `WarnAlarm.AlarmType`

去匹配：

- `CldWarnpoints.PointName`
- `CldWarnpoints.ModelOrrule`

因此需要提前明确：

1. 如果页面仍复用现有 `warnalarm` 列表接口

则需要保证对应 `PointName` 在 `CldWarnpoints` 中存在，并且：

- `ModelOrrule = 1`

否则可能出现：

- 数据库里有 `WarnAlarm`
- 但页面列表查不到

2. `LimitAlarmType = 20` 属于新增业务编码

当前系统对 `LimitAlarmType` 的若干日志或展示命名可能只覆盖既有编号，后续如需文本化展示，需要补充对应名称映射。


## 9. 实例命名建议

建议为两类报警块生成稳定且唯一的实例名。

### 9.1 DevAlarm

建议格式：

- `alarm_dev_{行号}_{faultCode}`

示例：

- `alarm_dev_2_1001`
- `alarm_dev_3_1002`

### 9.2 AnalogFluctuationAlarm

建议格式：

- `alarm_fluc_{行号}_{pointName规范化}`

示例：

- `alarm_fluc_2_d2_20hfc10cp101`
- `alarm_fluc_3_d2_afdrdmd`

这样做的好处：

- 便于排查
- 便于日志定位
- 便于后续通过 `算法名.管脚名` 访问
- 实例名不会因描述文字变化而漂移


## 10. 推荐实现边界

本次需求建议拆成四部分实现。

### 10.1 Excel 解析层

新增 `AlarmHelp` 或等价模块，负责：

- 读取 `alarm.xlsx`
- 解析两个 Sheet
- 转成两个配置 DTO 列表

### 10.2 报警控制器初始化层

在 `ExcuteEngine.InitController()` 中：

- 新增 `AlarmControllerID = 20000`
- 启动时创建报警控制器

在 `Controller.InitializeController()` 中：

- 对 `AlarmControllerID` 走专用初始化分支

### 10.3 功能块实例化层

在 `Controller` 中新增：

- `InstanceAlarmFunctionBlock()`
- `CreateDevAlarmFunction(...)`
- `CreateAnalogFluctuationAlarmFunction(...)`

职责：

- 校验点名是否存在
- 校验点类型是否为 `LA`
- 设置输入管脚
- 设置常量字段
- 设置稳定实例名并写入 `InstanceName`
- 将功能块加入 `FunctionInstanceDict`
- 对 `DevAlarm` 同步补充 `FaultInfoList`
- 对 `AnalogFluctuationAlarm` 同步补充专用的 `warnalarm` 元数据索引

### 10.4 报警记录桥接层

需要分别处理两条不同的记录链路：

- `DevAlarm -> FaultDiagnosis`
- `AnalogFluctuationAlarm -> WarnAlarm`

这里不要试图强行把两类报警都塞进同一套旧逻辑，而应按各自目标表做专门桥接。

当前建议的程序落点：

- `DevAlarm -> FaultDiagnosis`：
  继续复用 `Controller.InsertFaultData()`，但要求 `Source` 最终取 `function.InstanceName`
- `AnalogFluctuationAlarm -> WarnAlarm`：
  在 `Controller` 中新增专用插入/恢复处理，不走现有 `cldWarnpointList` 扫描链路


## 11. 最终需求一句话定义

系统需新增一个 `AlarmControllerID = 20000` 的 Excel 驱动报警控制器，在启动时读取 `alarm.xlsx`，将“偏差报警”逐行实例化为 `DevAlarm`，并将报警过程写入 `faultdiagnosis`，其中 `Source` 写 `DevAlarm` 实例名；将“波动报警”逐行实例化为 `AnalogFluctuationAlarm`，并以 `AlarmType = 1`、`LimitAlarmType = 20` 写入 `warnalarm`。其中 `DevAlarm` 虽内部定义了 `FaultOut`，但必须通过顶层 `OUT(LD) + NeedOut + FaultCode` 适配后，才能真正接入现有故障入库流程；`AnalogFluctuationAlarm` 则需走独立的 `warnalarm` 桥接逻辑。
