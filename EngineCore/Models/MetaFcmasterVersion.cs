using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaFcmasterVersion
{
    public int Id { get; set; }

    public string? Version { get; set; }

    public string? State { get; set; }

    public string? ModelState { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ModelInfo { get; set; }

    public string? ConditionName { get; set; }

    public int? Status { get; set; }

    public int? Visable { get; set; }

    public int? MetaFcmasterId { get; set; }
}
