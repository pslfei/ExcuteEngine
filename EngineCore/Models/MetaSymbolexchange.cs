using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaSymbolexchange
{
    public string ObjectId { get; set; } = null!;

    public string? ObjectName { get; set; }

    public string? ObjectType { get; set; }

    public string? ParentObjectId { get; set; }
}
