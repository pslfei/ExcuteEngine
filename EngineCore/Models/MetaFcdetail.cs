using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class MetaFcdetail
{
    public int Id { get; set; }

    public string? FunctionName { get; set; }

    public string? PinName { get; set; }

    public byte? PinIndex { get; set; }

    public string? DataType { get; set; }

    public bool? Tune { get; set; }

    public string? PinType { get; set; }

    public bool? Visible { get; set; }

    public string? MaxValues { get; set; }

    public string? MinValue { get; set; }

    public string? ValidValue { get; set; }

    public string? DefaultValue { get; set; }

    public bool? Required { get; set; }

    public string? Description { get; set; }

    public bool? Fixed { get; set; }

    public string? PinSignalType { get; set; }

    public string? PointName { get; set; }

    public int? MetaFcmasterId { get; set; }

    public virtual MetaFcmaster? MetaFcmaster { get; set; }
}
