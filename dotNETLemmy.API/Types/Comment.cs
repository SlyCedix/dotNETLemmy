using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class Comment
{
    [JsonProperty] public string ApId { get; private set; } = string.Empty;
    [JsonProperty] public string Content { get; private set; } = string.Empty;
    [JsonProperty] public int CreatorId { get; private set; }
    [JsonProperty] public bool Deleted { get; private set; }
    [JsonProperty] public bool Distinguished { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int LanguageId { get; private set; }
    [JsonProperty] public bool Local { get; private set; }
    [JsonProperty] public string Path { get; private set; } = string.Empty;
    [JsonProperty] public int PostId { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public bool Removed { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}