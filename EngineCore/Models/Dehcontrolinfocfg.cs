using System;
using System.Collections.Generic;

namespace EngineCore.Models;


public partial class Dehcontrolinfocfg
{
    public int Id { get; set; }

    public string? Unit { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? Time { get; set; }

    public double? LoadValue { get; set; }

    public double? Loadchange { get; set; }

    public double? ResponseValue { get; set; }

    public double? ResponseDeviation { get; set; }

    public double? ResponseQualified { get; set; }

    public double? EleQualified { get; set; }

    public double? DehQualified { get; set; }

    public double? Ele { get; set; }

    public double? Elesum { get; set; }
}
