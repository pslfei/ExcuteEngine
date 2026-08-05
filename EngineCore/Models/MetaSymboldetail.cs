using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaSymboldetail
{
    public int Id { get; set; }

    public string? SymbolId { get; set; }

    public string? ElementType { get; set; }

    public string? ElementData { get; set; }

    public int? DynamicType { get; set; }

    public virtual MetaSymbolmaster? Symbol { get; set; }
}
