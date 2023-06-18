using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class Tagline
{
    [JsonProperty] public string Content { get; private set; } = string.Empty;
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int LocalSiteId { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public string? Updated { get; private set; }
}