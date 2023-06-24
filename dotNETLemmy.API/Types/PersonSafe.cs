using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PersonSafe : IJsonObject
{
    [JsonInclude] public string ActorId { get; private set; } = string.Empty;
    [JsonInclude] public bool Admin { get; private set; }
    [JsonInclude] public string? Avatar { get; private set; }
    [JsonInclude] public string? BanExpires { get; private set; }
    [JsonInclude] public bool Banned { get; private set; }
    [JsonInclude] public string? Banner { get; private set; }
    [JsonInclude] public string? Bio { get; private set; }
    [JsonInclude] public bool BotAccount { get; private set; }
    [JsonInclude] public bool Deleted { get; private set; }
    [JsonInclude] public string? DisplayName { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string InboxUrl { get; private set; } = string.Empty;
    [JsonInclude] public int InstanceId { get; private set; }
    [JsonInclude] public bool Local { get; private set; }
    [JsonInclude] public string? MatrixUserId { get; private set; }
    [JsonInclude] public string Name { get; private set; } = string.Empty;
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public string? SharedInboxUrl { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}