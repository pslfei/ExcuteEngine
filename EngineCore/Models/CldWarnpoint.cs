using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldWarnpoint
{
    public int Id { get; set; }

    public string? WarnId { get; set; }

    /// <summary>
    /// 点名
    /// </summary>
    public string? PointName { get; set; }

    /// <summary>
    /// 描述
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// 单位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 公式
    /// </summary>
    public string? Equation { get; set; }


    /// <summary>
    /// 报警高3限
    /// </summary>
    public string? Up3Limit { get; set; }


    /// <summary>
    /// 报警低3限
    /// </summary>
    public string? Low3Limit { get; set; }


    /// <summary>
    /// 报警下下限
    /// </summary>
    public string? LowLowLimit { get; set; }


    /// <summary>
    /// 报警上上限
    /// </summary>
    public string? UpUpLimit { get; set; }

    /// <summary>
    /// 报警上上限最大值
    /// </summary>
    public string? UpUpMaxLimit { get; set; }


    /// <summary>
    /// 残差上限
    /// </summary>
    public string? UpLimit { get; set; }

    /// <summary>
    /// 残差下限
    /// </summary>
    public string? LowLimit { get; set; }

    /// <summary>
    /// 告警延时
    /// </summary>
    public int? TimeDurationThreshold { get; set; }

    /// <summary>
    /// 实时状态
    /// </summary>
    public int? RealTimeStatus { get; set; }

    /// <summary>
    /// 测点或者模型
    /// </summary>
    public int? PointOrmodel { get; set; }

    /// <summary>
    /// 报警类型（模型或者规则）
    /// </summary>
    public int? ModelOrrule { get; set; }

    /// <summary>
    /// 输出点
    /// </summary>
    public string? OutputPoint { get; set; }

    /// <summary>
    /// 光子牌
    /// </summary>
    public string? Gzpname { get; set; }

    /// <summary>
    /// 光子牌状态（0：&quot;否&quot;，1：&quot;是&quot;）
    /// </summary>
    public int? Gzponoff { get; set; }

    /// <summary>
    /// 报警级别
    /// </summary>
    public int? AlarmLevel { get; set; }

    /// <summary>
    /// 报警类型编号
    /// </summary>
    public int? AlarmTypeId { get; set; }

    /// <summary>
    /// 短信告警（0：&quot;否&quot;，1：&quot;是&quot;）
    /// </summary>
    public int? ShortMessageOnoff { get; set; }

    /// <summary>
    /// 推送诊断（0：&quot;否&quot;，1：&quot;是&quot;）
    /// </summary>
    public int? CopyToDiagOnoff { get; set; }

    /// <summary>
    /// 已有实例（0：&quot;是&quot; ，1：&quot;否&quot;）
    /// </summary>
    public int? WarnStatus { get; set; }

    /// <summary>
    /// 是否运行（0：&quot;否&quot;，1：&quot;是&quot;）
    /// </summary>
    public int? WarnVisable { get; set; }

    /// <summary>
    /// 是否运行
    /// </summary>
    public int? Running { get; set; }

    /// <summary>
    /// 运行日志
    /// </summary>
    public string? RunningLog { get; set; }

    /// <summary>
    /// 限制名称
    /// </summary>
    public string? WarnConstraintName { get; set; }

    /// <summary>
    /// 限制条件
    /// </summary>
    public string? WarnConstraint { get; set; }

    /// <summary>
    /// 限值报警名称
    /// </summary>
    public string? LimitAlarmName { get; set; }

    /// <summary>
    /// 限值报警条件
    /// </summary>
    public string? LimitAlarmCondition { get; set; }

    /// <summary>
    /// 报警限值延时时间
    /// </summary>
    public int? DelayTimeLimitAlarm { get; set; }


    /// <summary>
    /// 是否挂起0：不挂起；1：挂起
    /// </summary>
    public int? IsAlarmSuspended { get; set; } = 0;


    /// <summary>
    /// 报警确认
    /// </summary>
    public int? IsConfirm { get; set; }

    /// <summary>
    /// 建议
    /// </summary>
    public string? Suggestion { get; set; }

    /// <summary>
    /// 写入时间
    /// </summary>
    public DateTime? InsertTime { get; set; }

    /// <summary>
    /// 块编号
    /// </summary>
    public int CldFcblockId { get; set; }

    /// <summary>
    /// 页面编号
    /// </summary>
    public int PrjSheetId { get; set; }

    public int PrjDocumentId { get; set; }

    public int PrjControllerId { get; set; }

    /// <summary>
    /// 是否回写（0：否，1：是）
    /// </summary>
    public int? IsWriteBack { get; set; }

    /// <summary>
    /// 回写点名称
    /// </summary>
    public string? WriteBackPointName { get; set; }

}
