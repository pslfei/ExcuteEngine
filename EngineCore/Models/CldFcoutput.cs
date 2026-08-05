using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldFcoutput
{
    public int Id { get; set; }

    public string? PinName { get; set; }

    public string? PointName { get; set; }

    public string? InitialValue { get; set; }

    public string? Point { get; set; }

    public bool? Visible { get; set; }

    public bool? Negate { get; set; }

    public string? Description { get; set; }

    public int CldFcblockId { get; set; }

    public int PrjSheetId { get; set; }

    public int PrjDocumentId { get; set; }

    public int PrjControllerId { get; set; }

    public virtual CldFcblock CldFcblock { get; set; } = null!;

    public virtual PrjController PrjController { get; set; } = null!;

    public virtual PrjDocument PrjDocument { get; set; } = null!;

    public virtual PrjSheet PrjSheet { get; set; } = null!;
}
