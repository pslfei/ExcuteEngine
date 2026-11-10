using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using System.Reflection;
using TDServer.Service.AgentV2;

class Program
{
    static int checks;
    static void Check(bool ok, string name) { if (!ok) throw new Exception(name); checks++; }
    static IConfigurationRoot Config(params (string, string?)[] values) => new ConfigurationBuilder().AddInMemoryCollection(values.Select(v => new KeyValuePair<string,string?>("AgentApi:"+v.Item1,v.Item2))).Build();
    static void Main()
    {
        foreach (var unit in new[]{7,8})
        {
            var host=Config(("Enabled","true"),("SourceId",$"pw-unit{unit}"),("UnitId",unit.ToString()),("StorageOffsetMinutes","480"));
            var snapshot=AgentApiConfiguration.CreateSnapshot(host,out var error);
            Check(error==null && snapshot["AgentApi:Enabled"]=="True", "enable");
            Check(AgentApiConfiguration.UnitId(snapshot)==unit && AgentApiConfiguration.SourceId(snapshot)==$"pw-unit{unit}", "identity");
            host["AgentApi:UnitId"]="99";
            Check(AgentApiConfiguration.UnitId(snapshot)==unit,"frozen identity");
        }
        foreach (var c in new[]{Config(),Config(("Enabled","false"))})
            Check(AgentApiConfiguration.CreateSnapshot(c,out var e)["AgentApi:Enabled"]=="False" && e==null,"default off");
        foreach(var key in new[]{"SourceId","UnitId","StorageOffsetMinutes","Enabled"})
        {
            var c=Config(("Enabled","true"),("SourceId","pw-unit8"),("UnitId","8"),("StorageOffsetMinutes","480"));
            c["AgentApi:"+key]="";
            Check(AgentApiConfiguration.CreateSnapshot(c,out var error)["AgentApi:Enabled"]=="False" && error!=null,"invalid "+key);
        }
        // Match the main host's provider order: original JSON overrides legacy environment settings.
        var legacy=Config(("UnitId","7"),("SourceId","pw-unit7"),("Enabled","true"),("StorageOffsetMinutes","480"));
        using var json=new MemoryStream(System.Text.Encoding.UTF8.GetBytes("""{"AgentApi":{"Enabled":true,"UnitId":8,"SourceId":"pw-unit8","StorageOffsetMinutes":480}}"""));
        var merged=new ConfigurationBuilder().AddConfiguration(legacy).AddJsonStream(json).Build();
        var effective=AgentApiConfiguration.CreateSnapshot(merged,out _);
        Check(AgentApiConfiguration.UnitId(effective)==8,"JSON precedence");
        foreach(var enabled in new[]{false,true})
        {
            var f=new ControllerFeature(); f.Controllers.Add(typeof(LegacyController).GetTypeInfo()); f.Controllers.Add(typeof(ProbeController).GetTypeInfo());
            new AgentControllerFeatureProvider(enabled).PopulateFeature(Array.Empty<ApplicationPart>(),f);
            Check(f.Controllers.Contains(typeof(LegacyController).GetTypeInfo()),"legacy preserved");
            Check(f.Controllers.Contains(typeof(ProbeController).GetTypeInfo())==enabled,"v2 switch");
        }
        Console.WriteLine($"PASS: {checks} configuration and controller checks (no database access)");
    }
}
class LegacyController {}
namespace TDServer.Service.AgentV2 { class ProbeController {} }
