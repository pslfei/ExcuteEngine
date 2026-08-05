using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class PrjController
{
    public int Id { get; set; }

    public string? ControllerAddress { get; set; }

    public string? ControllerName { get; set; }

    public DateTime? CreateTime { get; set; }

    public DateTime? ModifyTime { get; set; }

    public string? Description { get; set; }

    public string? Version { get; set; }

    public string? TranslatorResult { get; set; }

    public int? Sequence { get; set; }

    public int PrjUnitId { get; set; }

    public virtual ICollection<CldConstant> CldConstants { get; set; } = new List<CldConstant>();

    public virtual ICollection<CldFcblock> CldFcblocks { get; set; } = new List<CldFcblock>();

    public virtual ICollection<CldFcinput> CldFcinputs { get; set; } = new List<CldFcinput>();

    public virtual ICollection<CldFcoutput> CldFcoutputs { get; set; } = new List<CldFcoutput>();

    public virtual ICollection<CldFcparameter> CldFcparameters { get; set; } = new List<CldFcparameter>();

    public virtual ICollection<CldGraphic> CldGraphics { get; set; } = new List<CldGraphic>();

    public virtual ICollection<CldIref> CldIrefs { get; set; } = new List<CldIref>();

    public virtual ICollection<CldOref> CldOrefs { get; set; } = new List<CldOref>();

    public virtual ICollection<CldSignal> CldSignals { get; set; } = new List<CldSignal>();

    public virtual ICollection<PrjDocument> PrjDocuments { get; set; } = new List<PrjDocument>();

    public virtual ICollection<PrjSheet> PrjSheets { get; set; } = new List<PrjSheet>();

    public virtual PrjUnit PrjUnit { get; set; } = null!;
}
