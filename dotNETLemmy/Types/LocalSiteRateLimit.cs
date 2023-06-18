using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class LocalSiteRateLimit
{
    [JsonProperty] public int Comment { get; private set; }
    [JsonProperty] public int CommentPerSecond { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int Image { get; private set; }
    [JsonProperty] public int ImagePerSecond { get; private set; }
    [JsonProperty] public int LocalSiteId { get; private set; }
    [JsonProperty] public int Message { get; private set; }
    [JsonProperty] public int MessagePerSecond { get; private set; }
    [JsonProperty] public int Post { get; private set; }
    [JsonProperty] public int PostPerSecond { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public int Register { get; private set; }
    [JsonProperty] public int RegisterPerSecond { get; private set; }
    [JsonProperty] public int Search { get; private set; }
    [JsonProperty] public int SearchPerSecond { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}