using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EngineCore.Models;

public class economiccfg
{
    public int Id { get; set; } = 0;

    /// <summary>
    /// 点描述
    /// </summary>
    public string? subName { get; set; }

    /// <summary>
    /// 实时值
    /// </summary>
    [NotMapped]
    public string? realTimeValue { get; set; }

    /// <summary>
    /// 一般报警限值
    /// </summary>
    [NotMapped]
    public string? NormalLimit { get; set; }

    /// <summary>
    /// 严重报警限值
    /// </summary>
    [NotMapped]
    public string? BadLimit { get; set; }

    /// <summary>
    /// 非常严重报警限值
    /// </summary>
    [NotMapped]
    public string? MoreBadLimit { get; set; }

    /// <summary>
    /// 报警等级
    /// </summary>
    [NotMapped]
    public string? alarmLevel { get; set; }

    public string? name { get; set; }


    /// <summary>
    /// 机组名称
    /// </summary>
    public string? unitName { get; set; }

    /// <summary>
    /// 机组描述
    /// </summary>
    public string? unitDescription { get; set; }

    /// <summary>
    /// 点名
    /// </summary>
    public string? pointName { get; set; }

    /// <summary>
    /// 设计负荷
    /// </summary>
    public string designXValue { get; set; }

    /// <summary>
    /// 设计值
    /// </summary>
    public string designYValue { get; set; }


    /// <summary>
    /// 报警限值（一般）配置
    /// </summary>
    public string alarmLConfig { get; set; }

    /// <summary>
    /// 报警限值（严重）配置
    /// </summary>
    public string alarmMConfig { get; set; }

    /// <summary>
    /// 报警限值（非常严重）配置
    /// </summary>
    public string alarmHConfig { get; set; }

    /// <summary>
    /// 目标值
    /// </summary>
    [NotMapped]
    public string? targetValue { get; set; }

    /// <summary>
    /// 偏差值
    /// </summary>
    [NotMapped]
    public string? biasValue { get; set; }


    /// <summary>
    /// 负荷点名
    /// </summary>
    public string? loadPoint { get; set; }

    public bool computeRule { get; set; }

    [NotMapped]
    public DateTime? startTime { get; set; }
}
