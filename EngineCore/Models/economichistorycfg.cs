using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public class economichistorycfg
{
    public int Id { get; set; } = 0;

    public string pointName { get; set; }

    public DateTime startTime { get; set; }

    public DateTime? endTime { get; set; }

    public string? duration { get; set; }

    public string level { get; set; }
}
