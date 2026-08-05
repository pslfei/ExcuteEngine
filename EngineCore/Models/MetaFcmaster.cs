using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaFcmaster
{
    public int Id { get; set; }

    public string? FunctionName { get; set; }

    public int? FunctionCode { get; set; }

    public string? Description { get; set; }

    public string? Function { get; set; }

    public byte? Diag { get; set; }

    public byte? InputCount { get; set; }

    public byte? SpecCount { get; set; }

    public byte? OutPutCount { get; set; }

    public int? InternalCount { get; set; }

    public short? Fclength { get; set; }

    public string? Type { get; set; }

    public int? Visable { get; set; }

    public int? PrjSystemId { get; set; }

    public string? Algorithm { get; set; }

    public string? State { get; set; }

    public string? ModelState { get; set; }

    public string? Version { get; set; }

    public DateTime? CreateTime { get; set; }

    public string? CreateUser { get; set; }

    public string? ModelInfo { get; set; }

    public string? ModelType { get; set; }

    public virtual ICollection<MetaFcdetail> MetaFcdetails { get; set; } = new List<MetaFcdetail>();
}
