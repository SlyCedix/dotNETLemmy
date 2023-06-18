using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PersonSafe
{
    [JsonProperty] public string ActorId { get; private set; } = string.Empty;
    [JsonProperty] public bool Admin { get; private set; }
    [JsonProperty] public string? Avatar { get; private set; }
    [JsonProperty] public string? BanExpires { get; private set; }
    [JsonProperty] public bool Banned { get; private set; }
    [JsonProperty] public string? Banner { get; private set; }
    [JsonProperty] public string? Bio { get; private set; }
    [JsonProperty] public bool BotAccount { get; private set; }
    [JsonProperty] public bool Deleted { get; private set; }
    [JsonProperty] public string? DisplayName { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string InboxUrl { get; private set; } = string.Empty;
    [JsonProperty] public int InstanceId { get; private set; }
    [JsonProperty] public bool Local { get; private set; }
    [JsonProperty] public string? MatrixUserId { get; private set; }
    [JsonProperty] public string Name { get; private set; } = string.Empty;
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public string? SharedInboxUrl { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}