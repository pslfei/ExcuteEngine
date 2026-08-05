using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Controlcfg
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string PointName { get; set; } = null!;

    public string UnitName { get; set; } = null!;

    public double? Upper { get; set; }

    public double? Lower { get; set; }

    public string? LimitPoint { get; set; }

    public double? SetPoint { get; set; }

    public double? UpperMore { get; set; }

    public double? LowerMore { get; set; }

    public string NewPoint { get; set; } = null!;

    public int? Firsttime { get; set; }

    public int? Secondtime { get; set; }

    public int? Endtime { get; set; }

    public double? Datachange { get; set; }

    public string Pointevaluate { get; set; } = null!;

    public double? Mintimecount { get; set; }
    public double? Maxtimecount { get; set; }
    public double? Minabs { get; set; }
    public double? Maxabs { get; set; }
    public double? Minresidual { get; set; }
    public double? Maxresidual { get; set; }

    public string? Faultcode { get; set; } = null!;
    public string? Faultcodedes { get; set; } = null!;
    public string? Device { get; set; } = null!;

    public string? Deviceevaluate { get; set; } = null!;
    public string? auto { get; set; } = null!;
    public int? Level { get; set; }
    public string? kpi { get; set; } = null!;
}
