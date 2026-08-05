using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Agcmonthinfocfg
{
    public int Id { get; set; }

    public string? Unit { get; set; }

    public string? Time { get; set; }

    public double? Availability { get; set; }

    public double? AvailabilityStandard { get; set; }

    public double? MonthlyControlrate { get; set; }

    public double? MonthlyControlrateStandard { get; set; }

    public string? Qualified { get; set; }

    public double? MonthlyQualified { get; set; }

    public double? MonthlyQualifiedStandard { get; set; }
}
