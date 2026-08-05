using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldIref
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? RefName { get; set; }

    public string? SrcRefId { get; set; }

    public string? FunctionCode { get; set; }

    public string? FunctionName { get; set; }

    public string? PinName { get; set; }

    public bool? Negate { get; set; }

    public string? Address { get; set; }

    public string? Description { get; set; }

    public string? XY { get; set; }

    public string? NetworkId { get; set; }

    public int? PrjSheetId { get; set; }

    public int? PrjDocumentId { get; set; }

    public int? PrjControllerId { get; set; }

    public virtual PrjController? PrjController { get; set; }

    public virtual PrjDocument? PrjDocument { get; set; }

    public virtual PrjSheet? PrjSheet { get; set; }
}
