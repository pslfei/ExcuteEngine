using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Devicehealthy
{
    public int Id { get; set; }

    public string? System { get; set; }

    public string? Systemdescription { get; set; }

    public string? Point { get; set; }

    public string? Pointdescription { get; set; }

    public double? Weight { get; set; }

    public string? Unit { get; set; }
}
