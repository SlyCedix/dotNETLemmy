using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class SiteMetadata
{
    [JsonProperty] public string? Description { get; private set; }
    [JsonProperty] public string? Html { get; private set; }
    [JsonProperty] public string? Image { get; private set; }
    [JsonProperty] public string? Title { get; private set; }
}