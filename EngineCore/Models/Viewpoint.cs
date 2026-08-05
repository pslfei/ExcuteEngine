using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Viewpoint
{
    public string? Name { get; set; }

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public int? SystemId { get; set; }

    public string? ModelType { get; set; }

    public string? MinimumScale { get; set; }

    public string? MaximunScale { get; set; }

    public string? Unit { get; set; }
}
