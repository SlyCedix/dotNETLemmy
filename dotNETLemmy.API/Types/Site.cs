using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class Site : IJsonObject
{
    [JsonInclude] public string ActorId { get; private set; } = string.Empty;
    [JsonInclude] public string? Banner { get; private set; }
    [JsonInclude] public string? Description { get; private set; }
    [JsonInclude] public string? Icon { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string InboxUrl { get; private set; } = string.Empty;
    [JsonInclude] public int InstanceId { get; private set; }
    [JsonInclude] public string LastRefreshedAt { get; private set; } = string.Empty;
    [JsonInclude] public string Name { get; private set; } = string.Empty;
    [JsonInclude] public string? PrivateKey { get; private set; }
    [JsonInclude] public string PublicKey { get; private set; } = string.Empty;
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public string? Sidebar { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}