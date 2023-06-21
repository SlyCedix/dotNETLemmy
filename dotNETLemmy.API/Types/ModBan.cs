using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModBan : IJsonObject
{
    [JsonProperty] public bool? Banned { get; private set; }
    [JsonProperty] public string? Expires { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int ModPersonId { get; private set; }
    [JsonProperty] public int OtherPersonId { get; private set; }
    [JsonProperty] public string? Reason { get; private set; }
    [JsonProperty(PropertyName = "when_")] public string When { get; private set; } = string.Empty;
}