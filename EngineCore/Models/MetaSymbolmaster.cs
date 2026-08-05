using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaSymbolmaster
{
    public string Id { get; set; } = null!;

    public string? SymbolName { get; set; }

    public string? SymbolType { get; set; }

    public string? OringinPoint { get; set; }

    public bool? ReadOnly { get; set; }

    public string? FunctionName { get; set; }

    public short? Code { get; set; }

    public virtual ICollection<MetaSymboldetail> MetaSymboldetails { get; set; } = new List<MetaSymboldetail>();
}
