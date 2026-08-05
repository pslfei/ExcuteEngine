using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaDatatype
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Index { get; set; }

    public string? Class { get; set; }

    public string? SystemType { get; set; }

    public short? Length { get; set; }

    public string? Function { get; set; }

    public virtual ICollection<MetaDatatypedetail> MetaDatatypedetails { get; set; } = new List<MetaDatatypedetail>();
}
