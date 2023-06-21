using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class Site : IJsonObject
{
    [JsonProperty] public string ActorId { get; private set; } = string.Empty;
    [JsonProperty] public string? Banner { get; private set; }
    [JsonProperty] public string? Description { get; private set; }
    [JsonProperty] public string? Icon { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string InboxUrl { get; private set; } = string.Empty;
    [JsonProperty] public int InstanceId { get; private set; }
    [JsonProperty] public string LastRefreshedAt { get; private set; } = string.Empty;
    [JsonProperty] public string Name { get; private set; } = string.Empty;
    [JsonProperty] public string? PrivateKey { get; private set; }
    [JsonProperty] public string PublicKey { get; private set; } = string.Empty;
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public string? Sidebar { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}