using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace TDServer.Service.AgentV2;

/// <summary>仅在明确启用时加载独立的智能体控制器，不影响原有控制器。</summary>
public sealed class AgentControllerFeatureProvider : IApplicationFeatureProvider<ControllerFeature>
{
    private readonly bool _enabled;
    public AgentControllerFeatureProvider(bool enabled) => _enabled = enabled;

    public void PopulateFeature(IEnumerable<ApplicationPart> parts, ControllerFeature feature)
    {
        if (_enabled) return;
        for (int i = feature.Controllers.Count - 1; i >= 0; i--)
            if (feature.Controllers[i].Namespace?.StartsWith("TDServer.Service.AgentV2", StringComparison.Ordinal) == true)
                feature.Controllers.RemoveAt(i);
    }
}
