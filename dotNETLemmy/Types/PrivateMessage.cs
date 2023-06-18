using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PrivateMessage
{
    [JsonProperty] public string ApId { get; private set; } = string.Empty;
    [JsonProperty] public string Content { get; private set; } = string.Empty;
    [JsonProperty] public int CreatorId { get; private set; }
    [JsonProperty] public bool Deleted { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public bool Local { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public bool Read { get; private set; }
    [JsonProperty] public int RecipientId { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}