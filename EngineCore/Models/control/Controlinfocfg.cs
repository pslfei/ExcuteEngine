using System;
using System.Collections.Generic;
namespace EngineCore.Models;

public partial class Controlinfocfg
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string StartTime { get; set; } = null!;

    public string? EndTime { get; set; }

    public double? MaxDeviation { get; set; }

    public double? Time { get; set; }

    public double? DecayRate { get; set; }

    public double? RiseRate { get; set; }

    public double? Residual { get; set; }

    public string? SteadyBeginPoint { get; set; }

    public string? SteadyEndPoint { get; set; }

    public int? UpperCount { get; set; }

    public string? LowerCount { get; set; }

    public string? UnitName { get; set; }

    public double? Upper { get; set; }

    public double? Lower { get; set; }

    public string? Qos { get; set; }

    public string? Performance { get; set; }

    public string? Score { get; set; }

    public string? decayratescore { get; set; }

    public string? resscore { get; set; }
    public string? kpiscore { get; set; }
    public string? timescore { get; set; }
}
