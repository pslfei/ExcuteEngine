using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Iomap
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Kkscode { get; set; }

    public string? IomapName { get; set; }

    public int? IomapDirection { get; set; }

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public bool? IsSoe { get; set; }

    public int? Iotype { get; set; }

    public int? PrjControllerId { get; set; }
}
