using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaCrossreference
{
    public int Id { get; set; }

    public string? FunctionName { get; set; }

    public string? DataType { get; set; }

    public string? Type { get; set; }

    public string? Description { get; set; }
}
