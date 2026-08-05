using System;
using System.Collections.Generic;

namespace EngineCore.Models;

public partial class Xunyou
{

    public CldIndexconditioncompare steadydata { get; set; }
    public CldIndexcondition standarddata { get; set; }

}
public partial class Xunyoudevice
{

    public string device { get; set; }

}
public partial class Xunyouhis
{

    public int Id { get; set; }

    public DateTime? steadytime { get; set; }

    public DateTime? standardtime { get; set; }
    public string? unit { get; set; }
    public string? json { get; set; }


}