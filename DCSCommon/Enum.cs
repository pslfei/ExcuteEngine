using System;
using System.Collections.Generic;
using System.Text;

namespace DCSCommon
{
    /// <summary>
    /// DCS工作状态
    /// </summary>
    public enum DcsState
    {
        /// <summary>
        /// 初始化工程中
        /// </summary>
        Initializing = 0,
        /// <summary>
        /// 初始化工程完毕
        /// </summary>
        Initialized,
        /// <summary>
        /// 加载工况中
        /// </summary>
        Loading,
        /// <summary>
        /// 加载工况完毕
        /// </summary>
        Loaded,
        /// <summary>
        /// 运行中
        /// </summary>
        Running,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 单步
        /// </summary>
        Step,
        /// <summary>
        /// 关闭
        /// </summary>
        Stop,
        /// <summary>
        /// 保存工况中
        /// </summary>
        Saving,
        /// <summary>
        /// 保存工况完毕
        /// </summary>
        Saved,
        /// <summary>
        /// 工程上装中
        /// </summary>
        Uploading,
        /// <summary>
        /// 上装完毕
        /// </summary>
        Uploaded,
        /// <summary>
        /// 工程下装中
        /// </summary>
        Downloading,
        /// <summary>
        /// 下载完毕
        /// </summary>
        Downloaded,
    }

    /// <summary>
    /// Dpu工作状态
    /// </summary>
    public enum DpuState
    {
        /// <summary>
        /// 运行错误
        /// </summary>
        Error = 0,
        /// <summary>
        /// 正常运行
        /// </summary>
        Running,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 空白Dpu
        /// </summary>
        Empty,
    }

    /// <summary>
    /// 初始化操作类型
    /// </summary>
    public enum InitOpType
    {
        /// <summary>
        /// 初始化点
        /// </summary>
        InitPoint = 0,
        /// <summary>
        /// 初始化命令
        /// </summary>
        InitCommand,
        /// <summary>
        /// 初始化别名系统
        /// </summary>
        InitAlias,
    }

    /// <summary>
    /// 下装操作类型
    /// </summary>
    public enum DownLoadOpType
    {
        /// <summary>
        /// 全部下装
        /// </summary>
        All = 0,
        /// <summary>
        /// 选择下装
        /// </summary>
        Select,
        /// <summary>
        /// 使用当前工况进行DPU级别下装
        /// </summary>
        DpuLevel,
        /// <summary>
        /// 使用当前工况进行DCS级别下装
        /// </summary>
        DcsLevel,
    }

    /// <summary>
    /// 版本检查结果
    /// </summary>
    public enum CheckVersionResult
    {
        /// <summary>
        /// 检查过程出现错误
        /// </summary>
        Error = 0,
        /// <summary>
        /// 表示工程与工况版本匹配
        /// </summary>
        Matching,
        /// <summary>
        /// 版本不匹配
        /// </summary>
        Unmatching,
    }

    /// <summary>
    /// 状态与版本检查结果
    /// </summary>
    public enum StateAndVersionResult
    {
        /// <summary>
        /// 错误
        /// </summary>
        Error=0,
        /// <summary>
        /// 正常运行且版本一致
        /// </summary>
        RunningAndConsistent,
        /// <summary>
        /// 正常运行且版本不一致
        /// </summary>
        RuningAndInconsistent,
        /// <summary>
        /// 暂停且版本一致
        /// </summary>
        PauseAndConsistent,
        /// <summary>
        /// 暂停且版本不一致
        /// </summary>
        PauseAndInconsistent,
        /// <summary>
        /// Dpu/DCS空白
        /// </summary>
        Empty,
        /// <summary>
        /// DCS的版本一
        /// </summary>
        DcsConsistent,
        /// <summary>
        /// DCS的版本不一致
        /// </summary>
        DcsInconsistent,
    }

    /// <summary>
    /// //工程的状态
    /// </summary>
    public enum ProjState
    {
        /// <summary>
        /// 出现问题
        /// </summary>
        Error = 0,
        /// <summary>
        /// 正常
        /// </summary>
        Normal,
    }

    /// <summary>
    /// 序列化操作类型
    /// </summary>
    public enum SerializeOperationType
    {
        /// <summary>
        /// 序列化操作
        /// </summary>
        Serialize = 0,
        /// <summary>
        /// 反序列化操作
        /// </summary>
        Deserialize,
    }

    /// <summary>
    /// 读写能力
    /// </summary>
    public enum WriteReadAbility
    {
        /// <summary>
        /// 可读可写
        /// </summary>
        WR = 0,

        /// <summary>
        /// 只读
        /// </summary>
        R,

        /// <summary>
        /// 只写
        /// </summary>
        W,

        /// <summary>
        /// 不可读不可写
        /// </summary>
        NWR,
    }

    /// <summary>
    /// 引脚类型
    /// </summary>
    public enum PinTypes
    {
        /// <summary>
        /// 输入管脚
        /// </summary>
        Input = 0,
        /// <summary>
        /// 输出管脚
        /// </summary>
        Output,
        /// <summary>
        /// 输入输出管脚
        /// </summary>
        IO,
        /// <summary>
        /// 规格数
        /// </summary>
        Constant,
        /// <summary>
        /// 内部变量
        /// </summary>
        Internal,
        /// <summary>
        /// 级联功能码
        /// </summary>
        Cascaded,
        /// <summary>
        /// 不是管脚
        /// </summary>
        None,
    }

    /// <summary>
    /// 信号线型号（对接型或引用型）（对接型或引用型）
    /// </summary>
    public enum WireAttributes
    {
        /// <summary>
        /// 引用型
        /// </summary>
        Reference = 0,

        /// <summary>
        /// 对接型
        /// </summary>
        Joint,

		/// <summary>
		/// 块引用类型，区别于引用型
		/// </summary>
		BlockReference,
    }

    /// <summary>
    /// 信号线IO类型
    /// </summary>
    public enum WireTypes
    {
        /// <summary>
        /// 无效的信号线
        /// </summary>
        Invalid = 0,
        /// <summary>
        /// 输入信号线
        /// </summary>
        IN,
        /// <summary>
        /// 输出信号线
        /// </summary>
        OUT,
        /// <summary>
        /// 输入出信号线
        /// </summary>
        IO,
    }

    /// <summary>
    /// 变量类别（基本类型，如int、double等，与Tag、Piont、Block、Macro统称变量）
    /// </summary>
    public enum VariableClass
    {
        /// <summary>
        /// Point类型变量
        /// </summary>
        Point = 0,
        /// <summary>
        /// Tag类型变量
        /// </summary>
        Tag,
        /// <summary>
        /// Block类型变量
        /// </summary>
        Block,
        /// <summary>
        /// 宏类型变量
        /// </summary>
        Macro,
        /// <summary>
        /// 基本类型
        /// </summary>
        Basic,
    }

    /// <summary>
    /// RTD的工作模式
    /// </summary>
    public enum RTDWorkMode
    {
        /// <summary>
        /// 无模式
        /// </summary>
        None = 0,
        /// <summary>
        /// 主模式
        /// </summary>
        Master,
        /// <summary>
        /// 从模式
        /// </summary>
        Slave,
        /// <summary>
        /// 克隆模式，是Master或Slave的深拷贝
        /// </summary>
        Clone,
    }

    /// <summary>
    /// 通信方向
    /// </summary>
    public enum CommunicatingDirections
    {
        /// <summary>
        /// 无方向
        /// </summary>
        None = 0,

        /// <summary>
        /// 双向的
        /// </summary>
        Bidirectional,

        /// <summary>
        /// 向内的（输入、写）
        /// </summary>
        Inner,

        /// <summary>
        /// 向外的（输出、读）
        /// </summary>
        Outer,

        /// <summary>
        /// 直通向内（直通输入、直写）
        /// </summary>
        DirectInner,
    }

    /// <summary>
    /// 运行状态
    /// </summary>
    public enum RunState
    {
        /// <summary>
        /// 停止
        /// </summary>
        Stop = 0,
        /// <summary>
        /// 运行
        /// </summary>
        Run,
        /// <summary>
        /// 暂停
        /// </summary>
        Pause,
        /// <summary>
        /// 单步
        /// </summary>
        Step,
    }

    /// <summary>
    /// 信号质量类型
    /// </summary>
    public enum QualityTypes
    {
        Good = 0,
        Bad,
        Fair,
        NotGood,
    }

    public enum ForceTypes
    {
    }
}
