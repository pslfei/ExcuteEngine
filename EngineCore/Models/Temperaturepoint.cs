using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Temperaturepoint
{
    public string Name { get; set; } = null!;

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public int? ControllerId { get; set; }
}
