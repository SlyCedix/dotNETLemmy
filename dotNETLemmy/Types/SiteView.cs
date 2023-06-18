using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class SiteView
{
    [JsonProperty] public SiteAggregates Counts { get; private set; } = null!;
    [JsonProperty] public LocalSite LocalSite { get; private set; } = null!;
    [JsonProperty] public LocalSiteRateLimit LocalSiteRateLimit { get; private set; } = null!;
    [JsonProperty] public Site Site { get; private set; } = null!;
    [JsonProperty] public Tagline[]? Taglines { get; private set; }
}