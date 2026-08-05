using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldGraphic
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Layer { get; set; }

    public string? Data { get; set; }

    public int PrjSheetId { get; set; }

    public int PrjDocumentId { get; set; }

    public int PrjControllerId { get; set; }

    public virtual PrjController PrjController { get; set; } = null!;

    public virtual PrjDocument PrjDocument { get; set; } = null!;

    public virtual PrjSheet PrjSheet { get; set; } = null!;
}
