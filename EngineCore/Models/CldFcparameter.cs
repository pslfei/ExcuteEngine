using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldFcparameter
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Pvalue { get; set; }

    public int CldFcblockId { get; set; }

    public int PrjSheetId { get; set; }

    public int PrjDocumentId { get; set; }

    public int PrjControllerId { get; set; }

    public virtual CldFcblock CldFcblock { get; set; } = null!;

    public virtual PrjController PrjController { get; set; } = null!;

    public virtual PrjDocument PrjDocument { get; set; } = null!;

    public virtual PrjSheet PrjSheet { get; set; } = null!;
}
