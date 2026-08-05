using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Hdl
{
    public int Id { get; set; }

    public string? Point { get; set; }

    public DateTime? Time { get; set; }

    public double? Value { get; set; }

    public string? Unit { get; set; }
}
