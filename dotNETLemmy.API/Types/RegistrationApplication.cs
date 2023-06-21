using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class RegistrationApplication : IJsonObject
{
    [JsonProperty] public int AdminId { get; private set; }
    [JsonProperty] public string Answer { get; private set; } = string.Empty;
    [JsonProperty] public string? DenyReason { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int LocalUserId { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
}