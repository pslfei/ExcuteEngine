using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class TempFunctionnamechanged
{
    public int Id { get; set; }

    public string? OldName { get; set; }

    public string? NewName { get; set; }

    public bool? IsLibrary { get; set; }

    public string? Address { get; set; }
}
