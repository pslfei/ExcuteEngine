using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Agccontrol
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string? UnitName { get; set; }

    public string Load { get; set; } = null!;

    public string Agc { get; set; } = null!;

    public string AgcControl { get; set; } = null!;

    public int? Count { get; set; }

    public string? Newpoint { get; set; }
}
