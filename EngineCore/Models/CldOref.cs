using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldOref
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? RefName { get; set; }

    public string? SrcBlockId { get; set; }

    public string? SrcPinName { get; set; }

    public bool? Negate { get; set; }

    public string? SrcAddress { get; set; }

    public string? FunctionName { get; set; }

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
