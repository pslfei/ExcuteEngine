using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaDatatypedetail
{
    public int Id { get; set; }

    public string? DataTypeName { get; set; }

    public string? MemberName { get; set; }

    public string? SystemType { get; set; }

    public int? Index { get; set; }

    public int MetaDataTypeId { get; set; }

    public virtual MetaDatatype MetaDataType { get; set; } = null!;
}
