using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class CldFcblock
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? AlgName { get; set; }

    public int? Sequence { get; set; }

    public string? FunctionName { get; set; }

    public string? XY { get; set; }

    public string? SymbolName { get; set; }

    public string? Description { get; set; }

    public string? Period { get; set; }

    public string? Phase { get; set; }

    public string? LoopId { get; set; }

    public int? MacroId { get; set; }

    public string? InstantInfo { get; set; }

    public int? InstantStatus { get; set; }

    public int PrjSheetId { get; set; }

    public int PrjDocumentId { get; set; }

    public int PrjControllerId { get; set; }

    public virtual List<CldFcinput> CldFcinputs { get; set; } = new List<CldFcinput>();

    public virtual List<CldFcoutput> CldFcoutputs { get; set; } = new List<CldFcoutput>();

    public virtual List<CldFcparameter> CldFcparameters { get; set; } = new List<CldFcparameter>();

    public virtual PrjController PrjController { get; set; } = null!;

    public virtual PrjDocument PrjDocument { get; set; } = null!;

    public virtual PrjSheet PrjSheet { get; set; } = null!;
}
