using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class SiteView : IJsonObject
{
    [JsonProperty] public SiteAggregates Counts { get; private set; } = null!;
    [JsonProperty] public LocalSite LocalSite { get; private set; } = null!;
    [JsonProperty] public LocalSiteRateLimit LocalSiteRateLimit { get; private set; } = null!;
    [JsonProperty] public Site Site { get; private set; } = null!;
    [JsonProperty] public Tagline[]? Taglines { get; private set; }
}