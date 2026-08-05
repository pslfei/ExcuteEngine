using System;
using System.Collections.Generic;

namespace EngineCore.Models;


public partial class Dehcontrol
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public string? UnitName { get; set; }

    public string Load { get; set; } = null!;

    public string DehOn { get; set; } = null!;

    public string DehValue { get; set; } = null!;

    public int? Count { get; set; }

    public string? Newpoint { get; set; }
}
