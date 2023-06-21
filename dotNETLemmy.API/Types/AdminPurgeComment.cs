using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class AdminPurgeComment : IJsonObject
{
    [JsonProperty] public int AdminPersonId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int PostId { get; private set; }
    [JsonProperty] public string? Reason { get; private set; }
    [JsonProperty(PropertyName = "when_")] public string When { get; private set; } = string.Empty;
}