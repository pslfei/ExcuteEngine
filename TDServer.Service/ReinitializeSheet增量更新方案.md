# ReinitializeSheet 增量更新解决方案（方案三）

## 目录
1. [方案概述](#方案概述)
2. [核心思想](#核心思想)
3. [技术架构](#技术架构)
4. [详细设计](#详细设计)
5. [算法流程](#算法流程)
6. [数据结构设计](#数据结构设计)
7. [实现步骤](#实现步骤)
8. [边界情况处理](#边界情况处理)
9. [性能优化](#性能优化)
10. [测试方案](#测试方案)

---

## 方案概述

### 问题背景
当前 `ReinitializeSheet` 方法采用"全量重建"策略，会导致以下问题：
- 所有功能块实例被删除并重建
- 运行时状态数据（buffer值、累积状态等）全部丢失
- 关联字典数据需要重新构建
- 影响系统运行连续性

### 方案目标
实现增量更新机制，通过对比配置变化，只更新变化部分，保留未变化功能块的运行时状态。

### 预期收益
- **数据连续性**：未修改的功能块保持运行状态
- **性能提升**：减少不必要的重建开销
- **系统稳定性**：降低重建带来的风险
- **用户体验**：配置修改后无需担心数据丢失

---

## 核心思想

### 差分算法
通过对比新旧配置，将功能块分为三类：
1. **新增** - 需要创建实例并初始化
2. **删除** - 需要清理实例和相关数据
3. **修改** - 需要部分更新但保留状态
4. **不变** - 完全不处理，保留原状态

### 状态保持策略
```
┌─────────────────┐
│  读取新配置      │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│  配置差分对比    │
└────────┬────────┘
         │
    ┌────┼────┐
    │    │    │
    ▼    ▼    ▼
  新增  修改  删除
    │    │    │
    └────┼────┘
         ▼
┌─────────────────┐
│  增量应用更新    │
└────────┬────────┘
         │
         ▼
┌─────────────────┐
│  验证完整性      │
└─────────────────┘
```

---

## 技术架构

### 模块划分

```
┌──────────────────────────────────────────────────────┐
│                   增量更新引擎                         │
├──────────────────────────────────────────────────────┤
│                                                        │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  │
│  │ 配置对比器   │  │ 状态管理器   │  │ 依赖分析器   │  │
│  └─────────────┘  └─────────────┘  └─────────────┘  │
│                                                        │
│  ┌─────────────┐  ┌─────────────┐  ┌─────────────┐  │
│  │ 增量应用器   │  │ 回滚管理器   │  │ 验证器       │  │
│  └─────────────┘  └─────────────┘  └─────────────┘  │
│                                                        │
└──────────────────────────────────────────────────────┘
```

### 核心组件

#### 1. 配置对比器（ConfigurationComparator）
- 功能：对比新旧配置差异
- 输出：变更集合（ChangeSet）
- 算法：基于唯一标识的差分算法

#### 2. 状态管理器（StateManager）
- 功能：保存和恢复功能块状态
- 数据：运行时快照
- 策略：选择性保存

#### 3. 依赖分析器（DependencyAnalyzer）
- 功能：分析功能块间依赖关系
- 输出：依赖图（DependencyGraph）
- 用途：确定更新顺序

#### 4. 增量应用器（IncrementalApplier）
- 功能：应用配置变更
- 策略：最小化影响范围
- 保证：原子性操作

#### 5. 回滚管理器（RollbackManager）
- 功能：失败时恢复到之前状态
- 机制：快照 + 日志
- 触发：异常或验证失败

#### 6. 验证器（Validator）
- 功能：验证更新后的完整性
- 检查：连接完整性、数据一致性
- 输出：验证报告

---

## 详细设计

### 一、数据结构设计

#### 1.1 变更类型枚举
```csharp
/// <summary>
/// 功能块变更类型
/// </summary>
public enum ChangeType
{
    /// <summary>
    /// 新增
    /// </summary>
    Added,

    /// <summary>
    /// 删除
    /// </summary>
    Removed,

    /// <summary>
    /// 修改
    /// </summary>
    Modified,

    /// <summary>
    /// 不变
    /// </summary>
    Unchanged
}
```

#### 1.2 变更项
```csharp
/// <summary>
/// 功能块变更项
/// </summary>
public class FunctionBlockChange
{
    /// <summary>
    /// 变更类型
    /// </summary>
    public ChangeType ChangeType { get; set; }

    /// <summary>
    /// 功能块ID
    /// </summary>
    public int BlockId { get; set; }

    /// <summary>
    /// 算法名称（唯一标识）
    /// </summary>
    public string AlgName { get; set; }

    /// <summary>
    /// 旧配置（null表示新增）
    /// </summary>
    public CldFcblock OldConfig { get; set; }

    /// <summary>
    /// 新配置（null表示删除）
    /// </summary>
    public CldFcblock NewConfig { get; set; }

    /// <summary>
    /// 输入管脚变更详情
    /// </summary>
    public List<PinChange> InputChanges { get; set; }

    /// <summary>
    /// 输出管脚变更详情
    /// </summary>
    public List<PinChange> OutputChanges { get; set; }

    /// <summary>
    /// 参数变更详情
    /// </summary>
    public List<ParameterChange> ParameterChanges { get; set; }

    /// <summary>
    /// 依赖的其他功能块
    /// </summary>
    public List<string> Dependencies { get; set; }

    /// <summary>
    /// 被依赖的其他功能块
    /// </summary>
    public List<string> Dependents { get; set; }
}
```

#### 1.3 管脚变更
```csharp
/// <summary>
/// 管脚变更
/// </summary>
public class PinChange
{
    /// <summary>
    /// 变更类型
    /// </summary>
    public ChangeType ChangeType { get; set; }

    /// <summary>
    /// 管脚名称
    /// </summary>
    public string PinName { get; set; }

    /// <summary>
    /// 旧连接点名
    /// </summary>
    public string OldPointName { get; set; }

    /// <summary>
    /// 新连接点名
    /// </summary>
    public string NewPointName { get; set; }

    /// <summary>
    /// 旧初始值
    /// </summary>
    public string OldInitialValue { get; set; }

    /// <summary>
    /// 新初始值
    /// </summary>
    public string NewInitialValue { get; set; }
}
```

#### 1.4 参数变更
```csharp
/// <summary>
/// 参数变更
/// </summary>
public class ParameterChange
{
    /// <summary>
    /// 变更类型
    /// </summary>
    public ChangeType ChangeType { get; set; }

    /// <summary>
    /// 参数名称
    /// </summary>
    public string ParameterName { get; set; }

    /// <summary>
    /// 旧值
    /// </summary>
    public string OldValue { get; set; }

    /// <summary>
    /// 新值
    /// </summary>
    public string NewValue { get; set; }
}
```

#### 1.5 变更集
```csharp
/// <summary>
/// 工作表的所有变更
/// </summary>
public class SheetChangeSet
{
    /// <summary>
    /// 工作表ID
    /// </summary>
    public int SheetId { get; set; }

    /// <summary>
    /// 所有变更项
    /// </summary>
    public List<FunctionBlockChange> Changes { get; set; }

    /// <summary>
    /// 新增的功能块
    /// </summary>
    public List<FunctionBlockChange> AddedBlocks =>
        Changes.Where(c => c.ChangeType == ChangeType.Added).ToList();

    /// <summary>
    /// 删除的功能块
    /// </summary>
    public List<FunctionBlockChange> RemovedBlocks =>
        Changes.Where(c => c.ChangeType == ChangeType.Removed).ToList();

    /// <summary>
    /// 修改的功能块
    /// </summary>
    public List<FunctionBlockChange> ModifiedBlocks =>
        Changes.Where(c => c.ChangeType == ChangeType.Modified).ToList();

    /// <summary>
    /// 未变更的功能块
    /// </summary>
    public List<FunctionBlockChange> UnchangedBlocks =>
        Changes.Where(c => c.ChangeType == ChangeType.Unchanged).ToList();

    /// <summary>
    /// 是否有变更
    /// </summary>
    public bool HasChanges =>
        AddedBlocks.Count > 0 || RemovedBlocks.Count > 0 || ModifiedBlocks.Count > 0;
}
```

#### 1.6 运行时状态快照
```csharp
/// <summary>
/// 功能块运行时状态快照
/// </summary>
public class FunctionBlockSnapshot
{
    /// <summary>
    /// 算法名称
    /// </summary>
    public string AlgName { get; set; }

    /// <summary>
    /// 功能块类型
    /// </summary>
    public string FunctionName { get; set; }

    /// <summary>
    /// Runable状态
    /// </summary>
    public bool Runable { get; set; }

    /// <summary>
    /// 输出管脚值（管脚名 -> 值）
    /// </summary>
    public Dictionary<string, object> OutputValues { get; set; }

    /// <summary>
    /// 内部状态字段值
    /// </summary>
    public Dictionary<string, object> InternalStates { get; set; }

    /// <summary>
    /// 预警块特有状态
    /// </summary>
    public WarnBlockSnapshot WarnState { get; set; }

    /// <summary>
    /// 健康度块特有状态
    /// </summary>
    public HealthBlockSnapshot HealthState { get; set; }

    /// <summary>
    /// 故障诊断块特有状态
    /// </summary>
    public FaultBlockSnapshot FaultState { get; set; }

    /// <summary>
    /// 快照时间
    /// </summary>
    public DateTime SnapshotTime { get; set; }
}

/// <summary>
/// 预警块状态快照
/// </summary>
public class WarnBlockSnapshot
{
    public bool UnAck { get; set; }
    public Dictionary<string, LAExWarnSnapshot> WarnPoints { get; set; }
}

/// <summary>
/// 预警点状态快照
/// </summary>
public class LAExWarnSnapshot
{
    public bool UnAck { get; set; }
    public bool AlarmStatus { get; set; }
    public float CurrentValue { get; set; }
    public DateTime LastAlarmTime { get; set; }
}

/// <summary>
/// 健康度块状态快照
/// </summary>
public class HealthBlockSnapshot
{
    public float Score { get; set; }
    public int SystemID { get; set; }
    public int DeviceID { get; set; }
}

/// <summary>
/// 故障块状态快照
/// </summary>
public class FaultBlockSnapshot
{
    public int FaultCode { get; set; }
    public int Status { get; set; }
    public string Time { get; set; }
    public bool NeedOut { get; set; }
}
```

#### 1.7 依赖图
```csharp
/// <summary>
/// 功能块依赖图
/// </summary>
public class DependencyGraph
{
    /// <summary>
    /// 节点：算法名 -> 依赖信息
    /// </summary>
    public Dictionary<string, DependencyNode> Nodes { get; set; }

    /// <summary>
    /// 获取拓扑排序
    /// </summary>
    public List<string> GetTopologicalOrder()
    {
        // Kahn算法实现
    }

    /// <summary>
    /// 检测循环依赖
    /// </summary>
    public List<List<string>> DetectCycles()
    {
        // DFS检测环
    }

    /// <summary>
    /// 获取受影响的下游节点
    /// </summary>
    public List<string> GetAffectedDownstream(string algName)
    {
        // BFS/DFS遍历
    }
}

/// <summary>
/// 依赖节点
/// </summary>
public class DependencyNode
{
    /// <summary>
    /// 算法名
    /// </summary>
    public string AlgName { get; set; }

    /// <summary>
    /// 依赖的节点（输入来源）
    /// </summary>
    public List<string> Dependencies { get; set; }

    /// <summary>
    /// 被依赖的节点（输出目标）
    /// </summary>
    public List<string> Dependents { get; set; }

    /// <summary>
    /// 入度
    /// </summary>
    public int InDegree { get; set; }
}
```

---

## 算法流程

### 主流程

```
ReinitializeSheetIncremental(sheetId)
│
├─ 步骤1: 加载新旧配置
│   ├─ 从数据库加载新配置
│   └─ 从内存获取旧配置
│
├─ 步骤2: 配置差分对比
│   ├─ 对比功能块列表
│   ├─ 对比输入管脚配置
│   ├─ 对比输出管脚配置
│   ├─ 对比参数配置
│   └─ 生成变更集（ChangeSet）
│
├─ 步骤3: 创建状态快照
│   ├─ 遍历所有现有功能块
│   ├─ 保存输出管脚值
│   ├─ 保存内部状态
│   └─ 保存关联数据
│
├─ 步骤4: 构建依赖图
│   ├─ 分析功能块间连接关系
│   ├─ 构建依赖图
│   └─ 检测循环依赖
│
├─ 步骤5: 处理删除操作
│   ├─ 按逆拓扑序处理
│   ├─ 从 FunctionInstanceDict 移除
│   ├─ 清理 WriteBackDcsPointDict
│   ├─ 清理 secondCalcPinValueList
│   ├─ 清理 HealthScoreDict
│   ├─ 清理 FaultInfoList
│   ├─ 清理 AckDict
│   └─ 清理 calculatedLAList
│
├─ 步骤6: 处理新增操作
│   ├─ 按拓扑序处理
│   ├─ 创建功能块实例
│   ├─ 初始化输入管脚
│   ├─ 初始化输出管脚
│   ├─ 初始化参数
│   └─ 添加到相关字典
│
├─ 步骤7: 处理修改操作
│   ├─ 按拓扑序处理
│   ├─ 判断修改类型
│   │   ├─ 仅参数修改 -> 更新参数，保留状态
│   │   ├─ 输出管脚修改 -> 更新连接，部分保留状态
│   │   └─ 输入管脚修改 -> 重建连接，尽量保留输出状态
│   └─ 恢复快照数据
│
├─ 步骤8: 验证完整性
│   ├─ 验证所有连接有效性
│   ├─ 验证数据一致性
│   └─ 验证依赖完整性
│
└─ 步骤9: 提交或回滚
    ├─ 验证通过 -> 提交更改
    └─ 验证失败 -> 回滚到快照
```

### 配置对比算法

```
CompareConfigurations(oldBlocks, newBlocks)
│
├─ 1. 建立映射
│   ├─ oldMap: AlgName -> CldFcblock
│   └─ newMap: AlgName -> CldFcblock
│
├─ 2. 识别变更类型
│   ├─ 遍历 newMap
│   │   ├─ 如果 oldMap 不存在 -> Added
│   │   └─ 如果 oldMap 存在 -> 比较详情
│   │
│   └─ 遍历 oldMap
│       └─ 如果 newMap 不存在 -> Removed
│
├─ 3. 对比功能块详情
│   ├─ 对比 FunctionName（类型变更视为删除+新增）
│   ├─ 对比 Description
│   ├─ 对比 InstantStatus
│   ├─ 对比输入管脚
│   │   ├─ 建立 PinName 映射
│   │   ├─ 对比 PointName
│   │   └─ 对比 InitialValue
│   │
│   ├─ 对比输出管脚
│   │   ├─ 建立 PinName 映射
│   │   └─ 对比 PointName
│   │
│   └─ 对比参数
│       ├─ 建立 Name 映射
│       └─ 对比 Pvalue
│
└─ 4. 生成变更集
    └─ 返回 SheetChangeSet
```

### 依赖分析算法

```
BuildDependencyGraph(changeSet, functionInstanceDict)
│
├─ 1. 初始化图
│   └─ 为每个功能块创建节点
│
├─ 2. 分析输入依赖
│   ├─ 遍历所有功能块
│   │   └─ 遍历输入管脚
│   │       ├─ 如果是内部连接（包含'.'）
│   │       │   ├─ 解析源算法名
│   │       │   └─ 添加依赖边
│   │       │
│   │       └─ 如果是外部点
│   │           └─ 检查其他功能块是否输出到此点
│   │
│   └─ 计算入度和出度
│
├─ 3. 检测循环依赖
│   ├─ 使用 DFS
│   ├─ 记录访问状态（白、灰、黑）
│   └─ 发现环则记录路径
│
└─ 4. 生成拓扑序
    ├─ 使用 Kahn 算法
    │   ├─ 队列初始化：入度为0的节点
    │   ├─ 循环出队
    │   │   ├─ 将节点加入结果
    │   │   └─ 减少邻居入度
    │   │
    │   └─ 返回排序结果
    │
    └─ 如果有环，返回错误
```

### 状态保存算法

```
CreateStateSnapshot(algName, function)
│
├─ 1. 创建快照对象
│   └─ snapshot = new FunctionBlockSnapshot()
│
├─ 2. 保存基本信息
│   ├─ AlgName
│   ├─ FunctionName
│   └─ Runable
│
├─ 3. 保存输出管脚值
│   ├─ 通过反射获取所有字段
│   ├─ 过滤输出管脚（名称特征）
│   └─ 保存 buffer 值
│       ├─ LA -> float
│       ├─ LD -> bool
│       └─ 其他类型 -> 直接保存
│
├─ 4. 保存内部状态字段
│   ├─ 累加器、计数器等
│   ├─ 时间戳
│   └─ 中间计算结果
│
├─ 5. 保存特定类型状态
│   ├─ 预警块
│   │   ├─ UnAck
│   │   └─ 关联测点状态
│   │
│   ├─ 健康度块
│   │   ├─ Score
│   │   ├─ SystemID
│   │   └─ DeviceID
│   │
│   └─ 故障诊断块
│       ├─ FaultCode
│       ├─ Status
│       ├─ Time
│       └─ NeedOut
│
└─ 6. 保存关联数据
    ├─ secondCalcPinValueList
    ├─ HealthScoreDict
    ├─ FaultInfoList
    └─ AckDict
```

### 状态恢复算法

```
RestoreStateSnapshot(algName, function, snapshot)
│
├─ 1. 验证快照有效性
│   ├─ 检查 AlgName 匹配
│   ├─ 检查 FunctionName 匹配
│   └─ 检查快照时间不过期
│
├─ 2. 恢复输出管脚值
│   ├─ 遍历快照中的输出值
│   ├─ 通过反射获取功能块字段
│   └─ 设置 buffer 值
│       ├─ LA.buffer = float
│       ├─ LD.buffer = bool
│       └─ 其他类型直接赋值
│
├─ 3. 恢复内部状态
│   └─ 仅恢复兼容字段
│
├─ 4. 恢复特定类型状态
│   ├─ 预警块
│   │   ├─ 恢复 UnAck
│   │   └─ 恢复测点状态
│   │
│   ├─ 健康度块
│   │   └─ 恢复 Score（如果输入未变）
│   │
│   └─ 故障诊断块
│       ├─ 恢复 Status
│       └─ 恢复 Time
│
├─ 5. 恢复关联数据
│   ├─ 恢复 secondCalcPinValueList
│   ├─ 恢复 HealthScoreDict
│   ├─ 恢复 FaultInfoList（状态部分）
│   └─ 恢复 AckDict
│
└─ 6. 记录恢复日志
    └─ 记录哪些数据被恢复
```

### 增量应用算法

```
ApplyIncrementalChanges(changeSet, snapshotDict, dependencyGraph)
│
├─ 1. 处理删除
│   ├─ 获取逆拓扑序
│   └─ 遍历删除列表
│       ├─ 从 FunctionInstanceDict 移除
│       ├─ 断开输入连接
│       ├─ 清理输出连接引用
│       ├─ 从 WriteBackDcsPointDict 移除
│       ├─ 从 secondCalcPinValueList 移除
│       ├─ 从 HealthScoreDict 移除
│       ├─ 从 FaultInfoList 移除
│       ├─ 从 AckDict 移除
│       └─ 从 calculatedLAList 移除
│
├─ 2. 处理新增
│   ├─ 获取拓扑序
│   └─ 遍历新增列表
│       ├─ 创建功能块实例
│       ├─ 设置基本属性
│       ├─ 添加到 FunctionInstanceDict
│       ├─ 初始化块（调用InitializeSingleBlock）
│       └─ 添加到相关字典
│
├─ 3. 处理修改
│   ├─ 获取拓扑序
│   └─ 遍历修改列表
│       ├─ 分析修改影响范围
│       │   ├─ 仅参数修改 -> 轻量级更新
│       │   ├─ 输出管脚修改 -> 中度更新
│       │   └─ 输入管脚修改 -> 重度更新
│       │
│       ├─ 根据影响范围选择策略
│       │   ├─ 轻量级：仅更新参数值
│       │   │   ├─ 通过反射设置字段
│       │   │   └─ 保留所有状态
│       │   │
│       │   ├─ 中度：更新输出连接
│       │   │   ├─ 断开旧连接
│       │   │   ├─ 建立新连接
│       │   │   ├─ 更新 WriteBackDcsPointDict
│       │   │   └─ 保留内部状态
│       │   │
│       │   └─ 重度：重建输入连接
│       │       ├─ 断开所有输入
│       │       ├─ 重新建立连接
│       │       ├─ 尝试保留输出状态
│       │       └─ 恢复快照（选择性）
│       │
│       └─ 恢复快照数据
│           ├─ 检查快照存在
│           └─ 调用 RestoreStateSnapshot
│
└─ 4. 更新 CldFcblockList
    ├─ 移除删除的
    ├─ 添加新增的
    └─ 更新修改的
```

---

## 实现步骤

### 阶段一：基础框架（1-2天）

#### 步骤1：创建数据结构类
```csharp
// 文件位置: Controller.IncrementalUpdate.DataStructures.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        // 将上述所有数据结构定义添加到这里
        // ChangeType, FunctionBlockChange, PinChange,
        // ParameterChange, SheetChangeSet, FunctionBlockSnapshot,
        // DependencyGraph, DependencyNode 等
    }
}
```

#### 步骤2：创建配置对比器
```csharp
// 文件位置: Controller.IncrementalUpdate.Comparator.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        /// <summary>
        /// 配置对比器
        /// </summary>
        private class ConfigurationComparator
        {
            private readonly WarnContext _context;
            private readonly string _mysqlconn;

            public ConfigurationComparator(string mysqlconn)
            {
                _mysqlconn = mysqlconn;
            }

            /// <summary>
            /// 对比工作表配置
            /// </summary>
            public SheetChangeSet CompareSheet(int sheetId, List<CldFcblock> oldBlocks)
            {
                // 实现配置对比逻辑
            }

            /// <summary>
            /// 对比单个功能块
            /// </summary>
            private FunctionBlockChange CompareFunctionBlock(
                CldFcblock oldBlock,
                CldFcblock newBlock)
            {
                // 实现功能块对比逻辑
            }

            /// <summary>
            /// 对比输入管脚
            /// </summary>
            private List<PinChange> CompareInputPins(
                List<CldFcinput> oldInputs,
                List<CldFcinput> newInputs)
            {
                // 实现输入管脚对比逻辑
            }

            /// <summary>
            /// 对比输出管脚
            /// </summary>
            private List<PinChange> CompareOutputPins(
                List<CldFcoutput> oldOutputs,
                List<CldFcoutput> newOutputs)
            {
                // 实现输出管脚对比逻辑
            }

            /// <summary>
            /// 对比参数
            /// </summary>
            private List<ParameterChange> CompareParameters(
                List<CldFcparameter> oldParams,
                List<CldFcparameter> newParams)
            {
                // 实现参数对比逻辑
            }
        }
    }
}
```

### 阶段二：状态管理（2-3天）

#### 步骤3：创建状态管理器
```csharp
// 文件位置: Controller.IncrementalUpdate.StateManager.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        /// <summary>
        /// 状态管理器
        /// </summary>
        private class StateManager
        {
            private readonly Controller _controller;
            private Dictionary<string, FunctionBlockSnapshot> _snapshots;

            public StateManager(Controller controller)
            {
                _controller = controller;
                _snapshots = new Dictionary<string, FunctionBlockSnapshot>();
            }

            /// <summary>
            /// 创建工作表的所有功能块快照
            /// </summary>
            public Dictionary<string, FunctionBlockSnapshot> CreateSheetSnapshots(int sheetId)
            {
                // 实现快照创建逻辑
            }

            /// <summary>
            /// 创建单个功能块快照
            /// </summary>
            private FunctionBlockSnapshot CreateSnapshot(string algName, Function function)
            {
                // 实现单个快照创建逻辑
            }

            /// <summary>
            /// 保存输出管脚值
            /// </summary>
            private Dictionary<string, object> SaveOutputValues(Function function)
            {
                // 实现输出值保存逻辑
            }

            /// <summary>
            /// 保存预警块状态
            /// </summary>
            private WarnBlockSnapshot SaveWarnState(Function function)
            {
                // 实现预警块状态保存逻辑
            }

            /// <summary>
            /// 保存健康度块状态
            /// </summary>
            private HealthBlockSnapshot SaveHealthState(Function function)
            {
                // 实现健康度块状态保存逻辑
            }

            /// <summary>
            /// 保存故障诊断块状态
            /// </summary>
            private FaultBlockSnapshot SaveFaultState(Function function)
            {
                // 实现故障块状态保存逻辑
            }

            /// <summary>
            /// 恢复功能块状态
            /// </summary>
            public bool RestoreSnapshot(string algName, Function function)
            {
                // 实现状态恢复逻辑
            }

            /// <summary>
            /// 恢复输出管脚值
            /// </summary>
            private void RestoreOutputValues(Function function, Dictionary<string, object> values)
            {
                // 实现输出值恢复逻辑
            }

            /// <summary>
            /// 恢复预警块状态
            /// </summary>
            private void RestoreWarnState(Function function, WarnBlockSnapshot snapshot)
            {
                // 实现预警块状态恢复逻辑
            }

            /// <summary>
            /// 恢复健康度块状态
            /// </summary>
            private void RestoreHealthState(Function function, HealthBlockSnapshot snapshot)
            {
                // 实现健康度块状态恢复逻辑
            }

            /// <summary>
            /// 恢复故障诊断块状态
            /// </summary>
            private void RestoreFaultState(Function function, FaultBlockSnapshot snapshot)
            {
                // 实现故障块状态恢复逻辑
            }
        }
    }
}
```

### 阶段三：依赖分析（2-3天）

#### 步骤4：创建依赖分析器
```csharp
// 文件位置: Controller.IncrementalUpdate.DependencyAnalyzer.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        /// <summary>
        /// 依赖分析器
        /// </summary>
        private class DependencyAnalyzer
        {
            private readonly Controller _controller;
            private DependencyGraph _graph;

            public DependencyAnalyzer(Controller controller)
            {
                _controller = controller;
            }

            /// <summary>
            /// 构建依赖图
            /// </summary>
            public DependencyGraph BuildGraph(SheetChangeSet changeSet)
            {
                // 实现依赖图构建逻辑
            }

            /// <summary>
            /// 分析输入依赖
            /// </summary>
            private void AnalyzeInputDependencies(CldFcblock block, DependencyNode node)
            {
                // 实现输入依赖分析逻辑
            }

            /// <summary>
            /// 提取内部连接的源算法名
            /// </summary>
            private string ExtractSourceAlgName(string pointName)
            {
                // pointName 格式: "algName.pinName"
                // 返回 "algName"
            }

            /// <summary>
            /// 检测循环依赖
            /// </summary>
            public List<List<string>> DetectCycles()
            {
                // 使用 DFS 检测环
            }

            /// <summary>
            /// DFS 访问节点
            /// </summary>
            private bool DFSVisit(
                string algName,
                Dictionary<string, int> colors,
                List<string> path,
                List<List<string>> cycles)
            {
                // 0: 白色（未访问）
                // 1: 灰色（访问中）
                // 2: 黑色（已完成）
            }

            /// <summary>
            /// 获取拓扑排序
            /// </summary>
            public List<string> GetTopologicalOrder()
            {
                // 使用 Kahn 算法
            }

            /// <summary>
            /// 获取受影响的下游节点
            /// </summary>
            public List<string> GetAffectedDownstream(string algName)
            {
                // 使用 BFS 遍历
            }
        }

        /// <summary>
        /// 依赖图实现
        /// </summary>
        private class DependencyGraph
        {
            public Dictionary<string, DependencyNode> Nodes { get; set; }

            public DependencyGraph()
            {
                Nodes = new Dictionary<string, DependencyNode>();
            }

            /// <summary>
            /// 添加节点
            /// </summary>
            public void AddNode(string algName)
            {
                if (!Nodes.ContainsKey(algName))
                {
                    Nodes[algName] = new DependencyNode
                    {
                        AlgName = algName,
                        Dependencies = new List<string>(),
                        Dependents = new List<string>(),
                        InDegree = 0
                    };
                }
            }

            /// <summary>
            /// 添加依赖边
            /// </summary>
            public void AddEdge(string from, string to)
            {
                // from 依赖 to（from的输入来自to的输出）
                AddNode(from);
                AddNode(to);

                Nodes[from].Dependencies.Add(to);
                Nodes[to].Dependents.Add(from);
                Nodes[from].InDegree++;
            }
        }
    }
}
```

### 阶段四：增量应用（3-4天）

#### 步骤5：创建增量应用器
```csharp
// 文件位置: Controller.IncrementalUpdate.Applier.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        /// <summary>
        /// 增量应用器
        /// </summary>
        private class IncrementalApplier
        {
            private readonly Controller _controller;
            private readonly StateManager _stateManager;
            private readonly DependencyGraph _dependencyGraph;

            public IncrementalApplier(
                Controller controller,
                StateManager stateManager,
                DependencyGraph dependencyGraph)
            {
                _controller = controller;
                _stateManager = stateManager;
                _dependencyGraph = dependencyGraph;
            }

            /// <summary>
            /// 应用变更
            /// </summary>
            public void ApplyChanges(SheetChangeSet changeSet)
            {
                // 1. 处理删除
                ApplyDeletions(changeSet.RemovedBlocks);

                // 2. 处理新增
                ApplyAdditions(changeSet.AddedBlocks);

                // 3. 处理修改
                ApplyModifications(changeSet.ModifiedBlocks);
            }

            /// <summary>
            /// 应用删除操作
            /// </summary>
            private void ApplyDeletions(List<FunctionBlockChange> deletions)
            {
                // 获取逆拓扑序（从下游到上游）
                var reverseOrder = GetReversedTopologicalOrder(deletions);

                foreach (var algName in reverseOrder)
                {
                    DeleteFunctionBlock(algName);
                }
            }

            /// <summary>
            /// 删除功能块
            /// </summary>
            private void DeleteFunctionBlock(string algName)
            {
                // 1. 从 FunctionInstanceDict 移除
                if (_controller.FunctionInstanceDict.ContainsKey(algName))
                {
                    _controller.FunctionInstanceDict.Remove(algName);
                }

                // 2. 清理 WriteBackDcsPointDict
                if (_controller.WriteBackDcsPointDict.ContainsKey(algName))
                {
                    _controller.WriteBackDcsPointDict.Remove(algName);
                }

                // 3. 清理 secondCalcPinValueList
                if (_controller.secondCalcPinValueList.ContainsKey(algName))
                {
                    _controller.secondCalcPinValueList.Remove(algName);
                }

                // 4. 清理 HealthScoreDict
                if (_controller.HealthScoreDict.ContainsKey(algName))
                {
                    _controller.HealthScoreDict.Remove(algName);
                }

                // 5. 清理 FaultInfoList
                if (_controller.FaultInfoList.ContainsKey(algName))
                {
                    _controller.FaultInfoList.Remove(algName);
                }

                // 6. 清理 AckDict
                if (_controller.AckDict.ContainsKey(algName))
                {
                    _controller.AckDict.Remove(algName);
                }

                // 7. 清理 calculatedLAList
                if (_controller.calculatedLAList.ContainsKey(algName))
                {
                    _controller.calculatedLAList.Remove(algName);
                }

                // 8. 清理 CldFcblockList
                _controller.CldFcblockList.RemoveAll(x => x.AlgName == algName);
            }

            /// <summary>
            /// 应用新增操作
            /// </summary>
            private void ApplyAdditions(List<FunctionBlockChange> additions)
            {
                // 获取拓扑序（从上游到下游）
                var order = GetTopologicalOrder(additions);

                foreach (var algName in order)
                {
                    var change = additions.First(c => c.AlgName == algName);
                    AddFunctionBlock(change.NewConfig);
                }
            }

            /// <summary>
            /// 新增功能块
            /// </summary>
            private void AddFunctionBlock(CldFcblock newBlock)
            {
                // 使用现有的 ProcessSingleFunctionBlockForSheet 方法
                _controller.ProcessSingleFunctionBlockForSheet(newBlock, newBlock.PrjSheetId);

                // 初始化功能块
                _controller.InitializeSingleBlock(newBlock);

                // 添加到 CldFcblockList
                _controller.CldFcblockList.Add(newBlock);
            }

            /// <summary>
            /// 应用修改操作
            /// </summary>
            private void ApplyModifications(List<FunctionBlockChange> modifications)
            {
                // 获取拓扑序
                var order = GetTopologicalOrder(modifications);

                foreach (var algName in order)
                {
                    var change = modifications.First(c => c.AlgName == algName);
                    ModifyFunctionBlock(change);
                }
            }

            /// <summary>
            /// 修改功能块
            /// </summary>
            private void ModifyFunctionBlock(FunctionBlockChange change)
            {
                // 分析修改影响范围
                var impact = AnalyzeModificationImpact(change);

                switch (impact)
                {
                    case ModificationImpact.Light:
                        // 仅参数修改
                        ApplyLightModification(change);
                        break;

                    case ModificationImpact.Medium:
                        // 输出管脚修改
                        ApplyMediumModification(change);
                        break;

                    case ModificationImpact.Heavy:
                        // 输入管脚修改或类型变更
                        ApplyHeavyModification(change);
                        break;
                }
            }

            /// <summary>
            /// 分析修改影响
            /// </summary>
            private ModificationImpact AnalyzeModificationImpact(FunctionBlockChange change)
            {
                // 如果功能类型变化，视为重度修改
                if (change.OldConfig.FunctionName != change.NewConfig.FunctionName)
                {
                    return ModificationImpact.Heavy;
                }

                // 如果有输入管脚变化，视为重度修改
                if (change.InputChanges.Any(c => c.ChangeType != ChangeType.Unchanged))
                {
                    return ModificationImpact.Heavy;
                }

                // 如果有输出管脚变化，视为中度修改
                if (change.OutputChanges.Any(c => c.ChangeType != ChangeType.Unchanged))
                {
                    return ModificationImpact.Medium;
                }

                // 仅参数变化，视为轻度修改
                return ModificationImpact.Light;
            }

            /// <summary>
            /// 应用轻度修改（仅参数）
            /// </summary>
            private void ApplyLightModification(FunctionBlockChange change)
            {
                string algName = change.AlgName;
                var function = _controller.FunctionInstanceDict[algName];

                // 更新参数值
                foreach (var paramChange in change.ParameterChanges)
                {
                    if (paramChange.ChangeType == ChangeType.Unchanged)
                        continue;

                    var fieldInfo = function.GetType().GetField(paramChange.ParameterName);
                    if (fieldInfo == null)
                        continue;

                    // 根据字段类型设置值
                    switch (fieldInfo.FieldType.Name)
                    {
                        case "Int32":
                            fieldInfo.SetValue(function, Convert.ToInt32(paramChange.NewValue));
                            break;
                        case "Single":
                            fieldInfo.SetValue(function, Convert.ToSingle(paramChange.NewValue));
                            break;
                        case "Boolean":
                            fieldInfo.SetValue(function, Convert.ToBoolean(paramChange.NewValue));
                            break;
                    }
                }

                // 更新 CldFcblockList
                var index = _controller.CldFcblockList.FindIndex(x => x.AlgName == algName);
                if (index >= 0)
                {
                    _controller.CldFcblockList[index] = change.NewConfig;
                }

                // 恢复状态（保持所有运行时状态不变）
                _stateManager.RestoreSnapshot(algName, function);
            }

            /// <summary>
            /// 应用中度修改（输出管脚）
            /// </summary>
            private void ApplyMediumModification(FunctionBlockChange change)
            {
                string algName = change.AlgName;

                // 1. 清理旧的输出连接
                CleanupOutputConnections(algName);

                // 2. 重新处理输出管脚
                var function = _controller.FunctionInstanceDict[algName];
                _controller.ProcessOutputPins(change.NewConfig, algName, function);

                // 3. 更新 CldFcblockList
                var index = _controller.CldFcblockList.FindIndex(x => x.AlgName == algName);
                if (index >= 0)
                {
                    _controller.CldFcblockList[index] = change.NewConfig;
                }

                // 4. 恢复内部状态（输出值可能需要重新计算）
                _stateManager.RestoreSnapshot(algName, function);
            }

            /// <summary>
            /// 应用重度修改（输入管脚或类型变更）
            /// </summary>
            private void ApplyHeavyModification(FunctionBlockChange change)
            {
                string algName = change.AlgName;

                // 重度修改等同于删除后新增
                // 但尽量保留输出状态

                // 1. 保存快照
                var snapshot = _stateManager.CreateSnapshot(
                    algName,
                    _controller.FunctionInstanceDict[algName]
                );

                // 2. 删除旧实例
                DeleteFunctionBlock(algName);

                // 3. 创建新实例
                AddFunctionBlock(change.NewConfig);

                // 4. 尝试恢复输出状态（如果兼容）
                if (change.OldConfig.FunctionName == change.NewConfig.FunctionName)
                {
                    var function = _controller.FunctionInstanceDict[algName];
                    _stateManager.RestoreSnapshot(algName, function);
                }
            }

            /// <summary>
            /// 清理输出连接
            /// </summary>
            private void CleanupOutputConnections(string algName)
            {
                // 清理 WriteBackDcsPointDict
                if (_controller.WriteBackDcsPointDict.ContainsKey(algName))
                {
                    _controller.WriteBackDcsPointDict.Remove(algName);
                }

                // 清理 secondCalcPinValueList
                if (_controller.secondCalcPinValueList.ContainsKey(algName))
                {
                    _controller.secondCalcPinValueList.Remove(algName);
                }
            }

            /// <summary>
            /// 获取拓扑序
            /// </summary>
            private List<string> GetTopologicalOrder(List<FunctionBlockChange> changes)
            {
                var algNames = changes.Select(c => c.AlgName).ToList();
                var fullOrder = _dependencyGraph.GetTopologicalOrder();
                return fullOrder.Where(algNames.Contains).ToList();
            }

            /// <summary>
            /// 获取逆拓扑序
            /// </summary>
            private List<string> GetReversedTopologicalOrder(List<FunctionBlockChange> changes)
            {
                var order = GetTopologicalOrder(changes);
                order.Reverse();
                return order;
            }
        }

        /// <summary>
        /// 修改影响程度
        /// </summary>
        private enum ModificationImpact
        {
            /// <summary>
            /// 轻度：仅参数修改
            /// </summary>
            Light,

            /// <summary>
            /// 中度：输出管脚修改
            /// </summary>
            Medium,

            /// <summary>
            /// 重度：输入管脚修改或类型变更
            /// </summary>
            Heavy
        }
    }
}
```

### 阶段五：验证与回滚（1-2天）

#### 步骤6：创建验证器和回滚管理器
```csharp
// 文件位置: Controller.IncrementalUpdate.Validator.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        /// <summary>
        /// 验证器
        /// </summary>
        private class Validator
        {
            private readonly Controller _controller;
            private List<string> _errors;
            private List<string> _warnings;

            public Validator(Controller controller)
            {
                _controller = controller;
                _errors = new List<string>();
                _warnings = new List<string>();
            }

            /// <summary>
            /// 验证更新后的完整性
            /// </summary>
            public ValidationResult Validate(SheetChangeSet changeSet)
            {
                _errors.Clear();
                _warnings.Clear();

                // 1. 验证所有功能块实例存在
                ValidateFunctionInstances(changeSet);

                // 2. 验证输入连接完整性
                ValidateInputConnections(changeSet);

                // 3. 验证输出连接完整性
                ValidateOutputConnections(changeSet);

                // 4. 验证依赖关系
                ValidateDependencies(changeSet);

                // 5. 验证数据一致性
                ValidateDataConsistency(changeSet);

                return new ValidationResult
                {
                    IsValid = _errors.Count == 0,
                    Errors = _errors,
                    Warnings = _warnings
                };
            }

            /// <summary>
            /// 验证功能块实例
            /// </summary>
            private void ValidateFunctionInstances(SheetChangeSet changeSet)
            {
                // 验证新增和修改的功能块都已正确创建
                var expectedBlocks = changeSet.AddedBlocks
                    .Concat(changeSet.ModifiedBlocks)
                    .Concat(changeSet.UnchangedBlocks)
                    .Select(c => c.AlgName)
                    .ToList();

                foreach (var algName in expectedBlocks)
                {
                    if (!_controller.FunctionInstanceDict.ContainsKey(algName))
                    {
                        _errors.Add($"功能块实例缺失: {algName}");
                    }
                }

                // 验证删除的功能块已正确移除
                var removedBlocks = changeSet.RemovedBlocks.Select(c => c.AlgName).ToList();
                foreach (var algName in removedBlocks)
                {
                    if (_controller.FunctionInstanceDict.ContainsKey(algName))
                    {
                        _errors.Add($"功能块实例未正确删除: {algName}");
                    }
                }
            }

            /// <summary>
            /// 验证输入连接
            /// </summary>
            private void ValidateInputConnections(SheetChangeSet changeSet)
            {
                var activeBlocks = changeSet.AddedBlocks
                    .Concat(changeSet.ModifiedBlocks)
                    .Concat(changeSet.UnchangedBlocks);

                foreach (var change in activeBlocks)
                {
                    var algName = change.AlgName;
                    var block = change.NewConfig;

                    if (!_controller.FunctionInstanceDict.ContainsKey(algName))
                        continue;

                    var function = _controller.FunctionInstanceDict[algName];

                    // 验证每个输入管脚
                    foreach (var input in block.CldFcinputs)
                    {
                        ValidateSingleInputPin(algName, function, input);
                    }
                }
            }

            /// <summary>
            /// 验证单个输入管脚
            /// </summary>
            private void ValidateSingleInputPin(string algName, Function function, CldFcinput input)
            {
                if (string.IsNullOrEmpty(input.PointName))
                    return;

                var fieldInfo = function.GetType().GetField(input.PinName);
                if (fieldInfo == null)
                {
                    _errors.Add($"{algName}.{input.PinName} 字段不存在");
                    return;
                }

                var value = fieldInfo.GetValue(function);

                // 检查连接有效性
                if (input.PointName.Contains("."))
                {
                    // 内部连接
                    var parts = input.PointName.Split('.');
                    var sourceAlgName = parts[0];

                    if (!_controller.FunctionInstanceDict.ContainsKey(sourceAlgName))
                    {
                        _errors.Add($"{algName}.{input.PinName} 的源功能块 {sourceAlgName} 不存在");
                    }
                }
                else
                {
                    // 外部点连接
                    if (!_controller.RTDDict.ContainsKey(input.PointName))
                    {
                        _errors.Add($"{algName}.{input.PinName} 的外部点 {input.PointName} 不存在");
                    }
                }

                // 检查值的有效性
                if (value == null && string.IsNullOrEmpty(input.InitialValue))
                {
                    _warnings.Add($"{algName}.{input.PinName} 未连接且无初始值");
                }
            }

            /// <summary>
            /// 验证输出连接
            /// </summary>
            private void ValidateOutputConnections(SheetChangeSet changeSet)
            {
                var activeBlocks = changeSet.AddedBlocks
                    .Concat(changeSet.ModifiedBlocks)
                    .Concat(changeSet.UnchangedBlocks);

                foreach (var change in activeBlocks)
                {
                    var algName = change.AlgName;
                    var block = change.NewConfig;

                    if (!_controller.FunctionInstanceDict.ContainsKey(algName))
                        continue;

                    var function = _controller.FunctionInstanceDict[algName];

                    // 验证每个输出管脚
                    foreach (var output in block.CldFcoutputs)
                    {
                        ValidateSingleOutputPin(algName, function, output);
                    }
                }
            }

            /// <summary>
            /// 验证单个输出管脚
            /// </summary>
            private void ValidateSingleOutputPin(string algName, Function function, CldFcoutput output)
            {
                if (string.IsNullOrEmpty(output.PointName))
                    return;

                var fieldInfo = function.GetType().GetField(output.PinName);
                if (fieldInfo == null)
                {
                    _errors.Add($"{algName}.{output.PinName} 字段不存在");
                    return;
                }

                // 检查回写点
                if (!output.PointName.Contains("."))
                {
                    if (!_controller.RTDDict.ContainsKey(output.PointName))
                    {
                        _errors.Add($"{algName}.{output.PinName} 的输出点 {output.PointName} 不存在");
                    }
                }
            }

            /// <summary>
            /// 验证依赖关系
            /// </summary>
            private void ValidateDependencies(SheetChangeSet changeSet)
            {
                // 构建依赖图并检测循环依赖
                var analyzer = new DependencyAnalyzer(_controller);
                var graph = analyzer.BuildGraph(changeSet);
                var cycles = analyzer.DetectCycles();

                if (cycles.Count > 0)
                {
                    foreach (var cycle in cycles)
                    {
                        _errors.Add($"检测到循环依赖: {string.Join(" -> ", cycle)}");
                    }
                }
            }

            /// <summary>
            /// 验证数据一致性
            /// </summary>
            private void ValidateDataConsistency(SheetChangeSet changeSet)
            {
                // 验证关联字典的一致性
                foreach (var algName in _controller.FunctionInstanceDict.Keys)
                {
                    var function = _controller.FunctionInstanceDict[algName];

                    // 验证 secondCalcPinValueList
                    if (function.FcType == Function.enumType.SC ||
                        function.FcType == Function.enumType.ICO)
                    {
                        if (!_controller.secondCalcPinValueList.ContainsKey(algName))
                        {
                            _warnings.Add($"性能计算块 {algName} 未在 secondCalcPinValueList 中注册");
                        }
                    }

                    // 验证 FaultInfoList
                    if (function.FcType == Function.enumType.FaultOut)
                    {
                        if (!_controller.FaultInfoList.ContainsKey(algName))
                        {
                            _warnings.Add($"故障诊断块 {algName} 未在 FaultInfoList 中注册");
                        }
                    }

                    // 验证 AckDict
                    if (function.FcType == Function.enumType.Ack)
                    {
                        if (!_controller.AckDict.ContainsKey(algName))
                        {
                            _warnings.Add($"确认块 {algName} 未在 AckDict 中注册");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 验证结果
        /// </summary>
        private class ValidationResult
        {
            public bool IsValid { get; set; }
            public List<string> Errors { get; set; }
            public List<string> Warnings { get; set; }

            public override string ToString()
            {
                var sb = new StringBuilder();
                sb.AppendLine($"验证结果: {(IsValid ? "通过" : "失败")}");

                if (Errors.Count > 0)
                {
                    sb.AppendLine($"错误 ({Errors.Count}):");
                    foreach (var error in Errors)
                    {
                        sb.AppendLine($"  - {error}");
                    }
                }

                if (Warnings.Count > 0)
                {
                    sb.AppendLine($"警告 ({Warnings.Count}):");
                    foreach (var warning in Warnings)
                    {
                        sb.AppendLine($"  - {warning}");
                    }
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// 回滚管理器
        /// </summary>
        private class RollbackManager
        {
            private readonly Controller _controller;
            private SheetBackup _backup;

            public RollbackManager(Controller controller)
            {
                _controller = controller;
            }

            /// <summary>
            /// 创建备份
            /// </summary>
            public void CreateBackup(int sheetId)
            {
                _backup = new SheetBackup
                {
                    SheetId = sheetId,
                    CldFcblockList = new List<CldFcblock>(_controller.CldFcblockList.Where(x => x.PrjSheetId == sheetId)),
                    FunctionInstances = new Dictionary<string, Function>(),
                    WriteBackDcsPointDict = new Dictionary<string, Dictionary<string, object>>(),
                    SecondCalcPinValueList = new Dictionary<string, Dictionary<string, object>>(),
                    HealthScoreDict = new Dictionary<string, LA>(),
                    FaultInfoList = new Dictionary<string, FaultInfo>(),
                    AckDict = new Dictionary<string, List<string>>(),
                    CalculatedLAList = new Dictionary<string, List<CalculatedLA>>(),
                    BackupTime = DateTime.Now
                };

                // 备份功能块实例（深拷贝）
                foreach (var block in _backup.CldFcblockList)
                {
                    string algName = block.AlgName;
                    if (_controller.FunctionInstanceDict.ContainsKey(algName))
                    {
                        _backup.FunctionInstances[algName] = _controller.FunctionInstanceDict[algName];
                    }
                }

                // 备份其他字典
                foreach (var kvp in _controller.WriteBackDcsPointDict)
                {
                    if (_backup.CldFcblockList.Any(b => b.AlgName == kvp.Key))
                    {
                        _backup.WriteBackDcsPointDict[kvp.Key] = new Dictionary<string, object>(kvp.Value);
                    }
                }

                foreach (var kvp in _controller.secondCalcPinValueList)
                {
                    if (_backup.CldFcblockList.Any(b => b.AlgName == kvp.Key))
                    {
                        _backup.SecondCalcPinValueList[kvp.Key] = new Dictionary<string, object>(kvp.Value);
                    }
                }

                foreach (var kvp in _controller.HealthScoreDict)
                {
                    if (_backup.CldFcblockList.Any(b => b.AlgName == kvp.Key))
                    {
                        _backup.HealthScoreDict[kvp.Key] = kvp.Value;
                    }
                }

                foreach (var kvp in _controller.FaultInfoList)
                {
                    if (_backup.CldFcblockList.Any(b => b.AlgName == kvp.Key))
                    {
                        _backup.FaultInfoList[kvp.Key] = CloneFaultInfo(kvp.Value);
                    }
                }

                foreach (var kvp in _controller.AckDict)
                {
                    if (_backup.CldFcblockList.Any(b => b.AlgName == kvp.Key))
                    {
                        _backup.AckDict[kvp.Key] = new List<string>(kvp.Value);
                    }
                }

                foreach (var kvp in _controller.calculatedLAList)
                {
                    if (_backup.CldFcblockList.Any(b => b.AlgName == kvp.Key))
                    {
                        _backup.CalculatedLAList[kvp.Key] = new List<CalculatedLA>(kvp.Value);
                    }
                }
            }

            /// <summary>
            /// 回滚到备份
            /// </summary>
            public void Rollback()
            {
                if (_backup == null)
                {
                    throw new InvalidOperationException("没有可用的备份");
                }

                int sheetId = _backup.SheetId;

                // 1. 清理当前工作表的所有数据
                var currentBlocks = _controller.CldFcblockList.Where(x => x.PrjSheetId == sheetId).ToList();
                foreach (var block in currentBlocks)
                {
                    string algName = block.AlgName;
                    _controller.FunctionInstanceDict.Remove(algName);
                    _controller.WriteBackDcsPointDict.Remove(algName);
                    _controller.secondCalcPinValueList.Remove(algName);
                    _controller.HealthScoreDict.Remove(algName);
                    _controller.FaultInfoList.Remove(algName);
                    _controller.AckDict.Remove(algName);
                    _controller.calculatedLAList.Remove(algName);
                }
                _controller.CldFcblockList.RemoveAll(x => x.PrjSheetId == sheetId);

                // 2. 恢复备份数据
                _controller.CldFcblockList.AddRange(_backup.CldFcblockList);

                foreach (var kvp in _backup.FunctionInstances)
                {
                    _controller.FunctionInstanceDict[kvp.Key] = kvp.Value;
                }

                foreach (var kvp in _backup.WriteBackDcsPointDict)
                {
                    _controller.WriteBackDcsPointDict[kvp.Key] = kvp.Value;
                }

                foreach (var kvp in _backup.SecondCalcPinValueList)
                {
                    _controller.secondCalcPinValueList[kvp.Key] = kvp.Value;
                }

                foreach (var kvp in _backup.HealthScoreDict)
                {
                    _controller.HealthScoreDict[kvp.Key] = kvp.Value;
                }

                foreach (var kvp in _backup.FaultInfoList)
                {
                    _controller.FaultInfoList[kvp.Key] = kvp.Value;
                }

                foreach (var kvp in _backup.AckDict)
                {
                    _controller.AckDict[kvp.Key] = kvp.Value;
                }

                foreach (var kvp in _backup.CalculatedLAList)
                {
                    _controller.calculatedLAList[kvp.Key] = kvp.Value;
                }
            }

            /// <summary>
            /// 清除备份
            /// </summary>
            public void ClearBackup()
            {
                _backup = null;
            }

            /// <summary>
            /// 克隆故障信息
            /// </summary>
            private FaultInfo CloneFaultInfo(FaultInfo original)
            {
                return new FaultInfo
                {
                    Time = original.Time,
                    Status = original.Status,
                    Code = original.Code,
                    Desc = original.Desc,
                    Source = original.Source,
                    PointName = original.PointName
                };
            }
        }

        /// <summary>
        /// 工作表备份
        /// </summary>
        private class SheetBackup
        {
            public int SheetId { get; set; }
            public List<CldFcblock> CldFcblockList { get; set; }
            public Dictionary<string, Function> FunctionInstances { get; set; }
            public Dictionary<string, Dictionary<string, object>> WriteBackDcsPointDict { get; set; }
            public Dictionary<string, Dictionary<string, object>> SecondCalcPinValueList { get; set; }
            public Dictionary<string, LA> HealthScoreDict { get; set; }
            public Dictionary<string, FaultInfo> FaultInfoList { get; set; }
            public Dictionary<string, List<string>> AckDict { get; set; }
            public Dictionary<string, List<CalculatedLA>> CalculatedLAList { get; set; }
            public DateTime BackupTime { get; set; }
        }
    }
}
```

### 阶段六：主接口（1天）

#### 步骤7：实现主入口方法
```csharp
// 文件位置: Controller.IncrementalUpdate.Main.cs

namespace TDServer.Service
{
    public partial class Controller
    {
        /// <summary>
        /// 增量重新初始化工作表
        /// </summary>
        /// <param name="sheetId">工作表ID</param>
        /// <returns>是否成功</returns>
        public bool ReinitializeSheetIncremental(int sheetId)
        {
            try
            {
                logger.InfoLog($"开始增量重新初始化工作表 {sheetId}");

                // ===== 步骤1: 准备阶段 =====

                // 1.1 创建回滚管理器并备份当前状态
                var rollbackManager = new RollbackManager(this);
                rollbackManager.CreateBackup(sheetId);
                logger.InfoLog($"已创建工作表 {sheetId} 的备份");

                // 1.2 加载旧配置
                var oldBlocks = CldFcblockList.Where(x => x.PrjSheetId == sheetId).ToList();

                // 1.3 创建配置对比器
                var comparator = new ConfigurationComparator(mysqlconn);

                // ===== 步骤2: 配置对比阶段 =====

                logger.InfoLog($"开始对比工作表 {sheetId} 的配置变更");
                var changeSet = comparator.CompareSheet(sheetId, oldBlocks);

                // 输出变更统计
                logger.InfoLog($"配置对比完成:");
                logger.InfoLog($"  - 新增: {changeSet.AddedBlocks.Count} 个功能块");
                logger.InfoLog($"  - 删除: {changeSet.RemovedBlocks.Count} 个功能块");
                logger.InfoLog($"  - 修改: {changeSet.ModifiedBlocks.Count} 个功能块");
                logger.InfoLog($"  - 不变: {changeSet.UnchangedBlocks.Count} 个功能块");

                // 如果没有变更，直接返回
                if (!changeSet.HasChanges)
                {
                    logger.InfoLog($"工作表 {sheetId} 无配置变更，跳过更新");
                    rollbackManager.ClearBackup();
                    return true;
                }

                // ===== 步骤3: 状态快照阶段 =====

                logger.InfoLog($"开始创建工作表 {sheetId} 的状态快照");
                var stateManager = new StateManager(this);
                var snapshots = stateManager.CreateSheetSnapshots(sheetId);
                logger.InfoLog($"已创建 {snapshots.Count} 个功能块的状态快照");

                // ===== 步骤4: 依赖分析阶段 =====

                logger.InfoLog($"开始分析功能块依赖关系");
                var dependencyAnalyzer = new DependencyAnalyzer(this);
                var dependencyGraph = dependencyAnalyzer.BuildGraph(changeSet);

                // 检测循环依赖
                var cycles = dependencyAnalyzer.DetectCycles();
                if (cycles.Count > 0)
                {
                    logger.ErrorLog($"检测到 {cycles.Count} 个循环依赖:");
                    foreach (var cycle in cycles)
                    {
                        logger.ErrorLog($"  - {string.Join(" -> ", cycle)}");
                    }
                    logger.ErrorLog("由于存在循环依赖，取消更新");
                    rollbackManager.ClearBackup();
                    return false;
                }

                logger.InfoLog($"依赖分析完成，未发现循环依赖");

                // ===== 步骤5: 增量应用阶段 =====

                logger.InfoLog($"开始应用配置变更");
                var applier = new IncrementalApplier(this, stateManager, dependencyGraph);

                try
                {
                    applier.ApplyChanges(changeSet);
                    logger.InfoLog($"配置变更应用完成");
                }
                catch (Exception ex)
                {
                    logger.ErrorLog($"应用配置变更时出错: {ex.Message}");
                    logger.InfoLog("开始回滚到备份状态");
                    rollbackManager.Rollback();
                    logger.InfoLog("回滚完成");
                    return false;
                }

                // ===== 步骤6: 验证阶段 =====

                logger.InfoLog($"开始验证更新结果");
                var validator = new Validator(this);
                var validationResult = validator.Validate(changeSet);

                if (!validationResult.IsValid)
                {
                    logger.ErrorLog($"验证失败:");
                    logger.ErrorLog(validationResult.ToString());
                    logger.InfoLog("开始回滚到备份状态");
                    rollbackManager.Rollback();
                    logger.InfoLog("回滚完成");
                    return false;
                }

                if (validationResult.Warnings.Count > 0)
                {
                    logger.InfoLog($"验证通过，但有 {validationResult.Warnings.Count} 个警告:");
                    foreach (var warning in validationResult.Warnings)
                    {
                        logger.InfoLog($"  - {warning}");
                    }
                }
                else
                {
                    logger.InfoLog("验证完全通过，无警告");
                }

                // ===== 步骤7: 提交阶段 =====

                logger.InfoLog($"工作表 {sheetId} 增量重新初始化成功");
                rollbackManager.ClearBackup();

                // 输出最终统计
                logger.InfoLog($"最终状态:");
                logger.InfoLog($"  - 功能块实例总数: {FunctionInstanceDict.Count}");
                logger.InfoLog($"  - 工作表 {sheetId} 功能块数: {CldFcblockList.Count(x => x.PrjSheetId == sheetId)}");
                logger.InfoLog($"  - 性能计算块数: {secondCalcPinValueList.Count}");
                logger.InfoLog($"  - 健康度块数: {HealthScoreDict.Count}");
                logger.InfoLog($"  - 故障诊断块数: {FaultInfoList.Count}");

                return true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"增量重新初始化工作表 {sheetId} 时发生异常: {ex.Message}");
                logger.ErrorLog($"堆栈跟踪: {ex.StackTrace}");
                return false;
            }
        }

        /// <summary>
        /// 批量增量重新初始化工作表
        /// </summary>
        /// <param name="sheetIds">工作表ID列表</param>
        /// <returns>成功的工作表ID列表</returns>
        public List<int> ReinitializeSheetsIncremental(List<int> sheetIds)
        {
            var successList = new List<int>();

            foreach (var sheetId in sheetIds)
            {
                if (ReinitializeSheetIncremental(sheetId))
                {
                    successList.Add(sheetId);
                }
            }

            logger.InfoLog($"批量增量重新初始化完成: 成功 {successList.Count}/{sheetIds.Count}");

            return successList;
        }
    }
}
```

---

## 边界情况处理

### 情况1：功能块类型变更
```
处理策略:
- 将类型变更视为 "删除旧块 + 新增新块"
- 不尝试保留状态（因为类型不兼容）
- 清理旧块的所有关联数据
- 按标准流程创建新块
```

### 情况2：循环依赖
```
检测方法:
- 使用 DFS 算法检测依赖图中的环
- 在应用变更前检测

处理策略:
- 发现循环依赖时，拒绝更新
- 记录详细的循环路径
- 返回错误给用户
```

### 情况3：输入点名包含计算函数（sum/avg）
```
处理策略:
- 解析计算函数表达式
- 提取所有参与计算的点名
- 重新创建 CalculatedLA 对象
- 更新 calculatedLAList
- 不保留旧的计算状态（因为输入可能变化）
```

### 情况4：预警块的多实例问题
```
场景:
- 同一个点名可能有多个预警块实例（InstantInfo不为空）

处理策略:
- 使用 FcBlockID 区分不同实例
- 删除时精确匹配 FcBlockID
- 更新时保持实例隔离
```

### 情况5：输出点被多个功能块使用
```
检测:
- 检查 WriteBackDcsPointDict
- 发现同一点名被多个功能块输出

处理策略:
- 记录警告日志
- 保留最后一个赋值（符合当前行为）
- 建议用户修正配置
```

### 情况6：部分功能块初始化失败
```
处理策略:
- 使用 try-catch 包裹每个功能块的操作
- 记录失败的功能块
- 继续处理其他功能块
- 在验证阶段检测失败
- 根据严重程度决定是否回滚
```

### 情况7：数据库连接失败
```
处理策略:
- 在加载新配置时捕获异常
- 保持原有配置不变
- 返回失败状态
- 不创建备份（避免无效备份）
```

### 情况8：内存不足
```
处理策略:
- 使用 try-catch 捕获 OutOfMemoryException
- 立即触发回滚
- 清理快照和备份
- 强制 GC
- 记录错误日志
```

---

## 性能优化

### 优化1：延迟初始化
```
策略:
- 不立即初始化所有功能块
- 按拓扑序分批初始化
- 上游初始化完成后再初始化下游
- 减少无效初始化

收益:
- 减少重复工作
- 提高初始化成功率
```

### 优化2：增量快照
```
策略:
- 只为可能受影响的功能块创建快照
- 分析依赖关系，确定影响范围
- 排除完全不变的功能块

收益:
- 减少快照大小
- 加快快照创建速度
- 降低内存占用
```

### 优化3：并行处理
```
策略:
- 识别无依赖关系的功能块
- 使用 Parallel.ForEach 并行处理
- 注意线程安全

收益:
- 充分利用多核CPU
- 加快处理速度

注意:
- 小心字典访问的线程安全
- 考虑使用 ConcurrentDictionary
```

### 优化4：缓存优化
```
策略:
- 缓存反射结果（FieldInfo等）
- 缓存配置对比结果
- 缓存依赖分析结果

收益:
- 减少重复的反射操作
- 加快配置对比速度
```

### 优化5：批量操作
```
策略:
- 批量加载数据库数据（现有实现已有）
- 批量处理相同类型的变更
- 减少数据库访问次数

收益:
- 减少I/O开销
- 提高整体性能
```

---

## 测试方案

### 测试用例1：新增功能块
```
前置条件:
- 工作表已存在
- 添加新的功能块配置

预期结果:
- 新功能块成功创建
- 输入输出连接正确
- 参数正确设置
- 相关字典正确更新
- 旧功能块状态不受影响
```

### 测试用例2：删除功能块
```
前置条件:
- 工作表有多个功能块
- 删除其中一个

预期结果:
- 功能块实例被移除
- 从所有字典中清理
- 依赖它的功能块输入被断开
- 其他功能块状态保持
```

### 测试用例3：修改参数
```
前置条件:
- 修改功能块的参数值
- 不修改输入输出

预期结果:
- 参数值更新成功
- 所有运行时状态保持不变
- 输出值继续有效
```

### 测试用例4：修改输入连接
```
前置条件:
- 修改功能块的输入管脚连接
- 保持输出不变

预期结果:
- 输入连接更新成功
- 输出状态尽量保留
- 下次运行使用新输入
```

### 测试用例5：修改输出连接
```
前置条件:
- 修改功能块的输出管脚连接
- 保持输入不变

预期结果:
- 输出连接更新成功
- 内部状态保留
- 新输出点正确回写
```

### 测试用例6：复杂依赖链
```
前置条件:
- A -> B -> C -> D 的依赖链
- 修改 B 的配置

预期结果:
- B 正确更新
- A 状态不变
- C 和 D 根据需要更新
- 依赖关系保持正确
```

### 测试用例7：循环依赖检测
```
前置条件:
- 创建 A -> B -> C -> A 的循环依赖

预期结果:
- 检测到循环依赖
- 拒绝更新
- 返回详细错误信息
- 原配置保持不变
```

### 测试用例8：验证失败回滚
```
前置条件:
- 配置有错误（如引用不存在的点）
- 应用变更

预期结果:
- 验证阶段检测到错误
- 自动触发回滚
- 恢复到更新前状态
- 记录详细错误日志
```

### 测试用例9：预警块状态保持
```
前置条件:
- 预警块有未确认报警（UnAck=true）
- 修改预警块的非关键配置

预期结果:
- UnAck 状态保持
- 报警历史不丢失
- 测点状态正确恢复
```

### 测试用例10：性能计算块状态保持
```
前置条件:
- 性能计算块有输出值
- 修改非输入配置

预期结果:
- 输出值保持
- secondCalcPinValueList 正确
- 下次计算使用正确值
```

### 测试用例11：故障诊断块状态保持
```
前置条件:
- 故障块有活动故障（Status=1）
- 修改非关键配置

预期结果:
- 故障状态保持
- 故障时间保持
- FaultInfoList 正确
```

### 测试用例12：健康度块状态保持
```
前置条件:
- 健康度块有评分
- 修改非输入配置

预期结果:
- 评分保持
- HealthScoreDict 正确
- 系统健康度计算不受影响
```

### 压力测试：大规模更新
```
场景:
- 工作表有 100+ 功能块
- 修改 50+ 功能块
- 复杂依赖关系

测试指标:
- 完成时间 < 10秒
- 内存增长 < 100MB
- 无内存泄漏
- 无死锁
```

### 并发测试：多工作表同时更新
```
场景:
- 3个工作表同时更新
- 每个工作表独立更新

预期结果:
- 不互相干扰
- 都成功完成
- 无数据错乱
```

---

## 实施建议

### 第一周：基础框架
- 实现所有数据结构
- 实现配置对比器
- 完成单元测试

### 第二周：状态管理
- 实现状态管理器
- 实现快照创建和恢复
- 完成状态保持测试

### 第三周：依赖分析
- 实现依赖分析器
- 实现循环依赖检测
- 实现拓扑排序

### 第四周：增量应用
- 实现增量应用器
- 实现三种修改策略
- 完成集成测试

### 第五周：验证与回滚
- 实现验证器
- 实现回滚管理器
- 完成异常场景测试

### 第六周：优化与测试
- 性能优化
- 压力测试
- 文档完善

---

## 风险与对策

### 风险1：状态保持不完整
```
风险:
- 某些状态字段遗漏
- 导致功能异常

对策:
- 详细分析所有功能块类型
- 完整的单元测试覆盖
- 增加验证检查
```

### 风险2：依赖分析错误
```
风险:
- 依赖关系判断错误
- 导致更新顺序错误

对策:
- 多种场景测试
- 增加日志输出
- 可视化依赖图
```

### 风险3：回滚不彻底
```
风险:
- 回滚后仍有残留数据
- 系统状态不一致

对策:
- 完整的备份机制
- 验证回滚结果
- 增加清理逻辑
```

### 风险4：性能下降
```
风险:
- 增量更新比全量更新慢
- 得不偿失

对策:
- 性能基准测试
- 持续优化
- 考虑混合策略
```

---

## 后续扩展

### 扩展1：配置版本管理
```
功能:
- 记录每次配置变更
- 支持回退到历史版本
- 配置变更审计

实现:
- 新增配置历史表
- 记录变更详情和时间
- 提供回退接口
```

### 扩展2：可视化监控
```
功能:
- 实时显示更新进度
- 可视化依赖图
- 状态变化展示

实现:
- WebSocket 实时通信
- 前端可视化组件
- 进度条和状态展示
```

### 扩展3：配置校验
```
功能:
- 更新前校验配置合法性
- 提前发现潜在问题
- 给出修正建议

实现:
- 规则引擎
- 静态分析
- 智能建议
```

### 扩展4：增量更新优化器
```
功能:
- 自动分析最优更新策略
- 最小化影响范围
- 智能批处理

实现:
- 启发式算法
- 机器学习预测
- 自适应策略
```

---

## 总结

增量更新方案通过精细化的配置对比、状态保持和依赖分析，实现了最小化影响的配置更新机制。相比全量重建，具有以下优势：

1. **数据连续性**：保留未变化部分的运行时状态
2. **性能提升**：减少不必要的重建操作
3. **系统稳定性**：降低更新带来的风险
4. **可控性**：提供回滚机制保证安全

实施该方案需要约 4-6 周时间，但带来的价值是长期的。建议分阶段实施，逐步完善。
