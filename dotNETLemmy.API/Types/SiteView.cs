using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class SiteView : IJsonObject
{
    [JsonInclude] public SiteAggregates Counts { get; private set; } = null!;
    [JsonInclude] public LocalSite LocalSite { get; private set; } = null!;
    [JsonInclude] public LocalSiteRateLimit LocalSiteRateLimit { get; private set; } = null!;
    [JsonInclude] public Site Site { get; private set; } = null!;
    [JsonInclude] public Tagline[]? Taglines { get; private set; }
}