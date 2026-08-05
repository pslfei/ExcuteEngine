using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EngineCore.Models;

public partial class Healthy
{
    public int Id { get; set; }

    public string? System { get; set; }

    public string? Device { get; set; }

    public string? Point { get; set; }

    public double? Weight { get; set; }

    public string? Unit { get; set; }
}
