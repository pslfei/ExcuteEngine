using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class PrjSystem
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? ParentId { get; set; }

    public string? Description { get; set; }

    public int? SystemId { get; set; }

    public string? ModelType { get; set; }
}
