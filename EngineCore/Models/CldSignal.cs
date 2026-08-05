using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldSignal
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? SignalType { get; set; }

    public string? EntityBelongTo { get; set; }

    public string? FromBlockName { get; set; }

    public string? FromPinName { get; set; }

    public string? Data { get; set; }

    public string? ToBlockName { get; set; }

    public string? ToPinName { get; set; }

    public int PrjSheetId { get; set; }

    public int PrjDocumentId { get; set; }

    public int PrjControllerId { get; set; }

    public virtual PrjController PrjController { get; set; } = null!;

    public virtual PrjDocument PrjDocument { get; set; } = null!;

    public virtual PrjSheet PrjSheet { get; set; } = null!;
}
