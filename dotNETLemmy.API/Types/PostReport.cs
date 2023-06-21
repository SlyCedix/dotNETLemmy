using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PostReport : IJsonObject
{
    [JsonProperty] public int CreatorId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string? OriginalPostBody { get; private set; }
    [JsonProperty] public string OriginalPostName { get; private set; } = string.Empty;
    [JsonProperty] public string? OriginalPostUrl { get; private set; }
    [JsonProperty] public int PostId { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public string Reason { get; private set; } = string.Empty;
    [JsonProperty] public bool Resolved { get; private set; }
    [JsonProperty] public int? ResolverId { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}