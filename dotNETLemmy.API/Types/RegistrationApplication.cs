using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class RegistrationApplication : IJsonObject
{
    [JsonInclude] public int AdminId { get; private set; }
    [JsonInclude] public string Answer { get; private set; } = string.Empty;
    [JsonInclude] public string? DenyReason { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int LocalUserId { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
}