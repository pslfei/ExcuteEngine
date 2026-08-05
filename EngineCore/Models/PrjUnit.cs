using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class PrjUnit
{
    public int Id { get; set; }

    public string? UnitAddress { get; set; }

    public string? UnitName { get; set; }

    public string? Description { get; set; }

    public string? LoadPoint { get; set; }

    public string? TempPoint { get; set; }

    public int PrjNetworkId { get; set; }

    public virtual ICollection<PrjController> PrjControllers { get; set; } = new List<PrjController>();

    public virtual PrjNetwork PrjNetwork { get; set; } = null!;
}
