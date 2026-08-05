using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CfgVarconstant
{
    public int Id { get; set; }

    public string? VarName { get; set; }

    public string? DataType { get; set; }

    public string? Value { get; set; }

    public string? SymbolName { get; set; }
}
