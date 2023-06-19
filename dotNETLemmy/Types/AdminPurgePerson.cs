using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class AdminPurgePerson
{
    [JsonProperty] public int AdminPersonId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string? Reason { get; private set; }
    [JsonProperty(PropertyName = "when_")] public string When { get; private set; } = string.Empty;
}