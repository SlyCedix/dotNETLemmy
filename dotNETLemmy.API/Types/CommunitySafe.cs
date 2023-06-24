using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommunitySafe : IJsonObject
{
    [JsonInclude] public string ActorId { get; private set; } = string.Empty;
    [JsonInclude] public string? Banner { get; private set; }
    [JsonInclude] public bool Deleted { get; private set; }
    [JsonInclude] public string? Description { get; private set; }
    [JsonInclude] public bool Hidden { get; private set; }
    [JsonInclude] public string? Icon { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int InstanceId { get; private set; }
    [JsonInclude] public bool Local { get; private set; }
    [JsonInclude] public string Name { get; private set; } = string.Empty;
    [JsonInclude] public bool Nsfw { get; private set; }
    [JsonInclude] public bool PostingRestrictedToMods { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public bool Removed { get; private set; }
    [JsonInclude] public string Title { get; private set; } = string.Empty;
    [JsonInclude] public string? Updated { get; private set; }
}