using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class PrjNetwork
{
    public int Id { get; set; }

    public string? NetworkAddress { get; set; }

    public string? NetworkName { get; set; }

    public string? Description { get; set; }

    public int PrjProjectId { get; set; }

    public virtual PrjProject PrjProject { get; set; } = null!;

    public virtual ICollection<PrjUnit> PrjUnits { get; set; } = new List<PrjUnit>();
}
