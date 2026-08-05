using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Whereusedoref
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? RefName { get; set; }

    public string? SheetName { get; set; }
}
