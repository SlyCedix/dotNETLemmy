using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class RegistrationApplication
{
    [JsonProperty] public int AdminId { get; private set; }
    [JsonProperty] public string Answer { get; private set; } = string.Empty;
    [JsonProperty] public string? DenyReason { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int LocalUserId { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
}