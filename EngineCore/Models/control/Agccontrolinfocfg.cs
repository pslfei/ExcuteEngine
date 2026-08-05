using System;
using System.Collections.Generic;

namespace EngineCore.Models;
public partial class Agccontrolinfocfg
{
    public int Id { get; set; }

    public string? Unit { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Qualified { get; set; }

    public double? LoadValue { get; set; }

    public double? AgcValue { get; set; }

    public double? LoadValueSteady { get; set; }

    public string? Time { get; set; }

    public double? ControlRate { get; set; }

    public double? ControlRateSp { get; set; }

    public double? ResponseTime { get; set; }

    public double? ResponseTimeStandard { get; set; }
}
