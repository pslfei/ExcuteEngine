using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class PrjProject
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public DateTime? CreateTime { get; set; }

    public DateTime? ModifyTime { get; set; }

    public string? Type { get; set; }

    public string? BlockMaxNumber { get; set; }

    public string? PinMaxNumber { get; set; }

    public string? ProjectPath { get; set; }

    public string? VarSystemVersion { get; set; }

    public string? AlarmVersion { get; set; }

    public virtual ICollection<PrjNetwork> PrjNetworks { get; set; } = new List<PrjNetwork>();
}
