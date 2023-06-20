using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommunitySafe
{
    [JsonProperty] public string ActorId { get; private set; } = string.Empty;
    [JsonProperty] public string? Banner { get; private set; }
    [JsonProperty] public bool Deleted { get; private set; }
    [JsonProperty] public string? Description { get; private set; }
    [JsonProperty] public bool Hidden { get; private set; }
    [JsonProperty] public string? Icon { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int InstanceId { get; private set; }
    [JsonProperty] public bool Local { get; private set; }
    [JsonProperty] public string Name { get; private set; } = string.Empty;
    [JsonProperty] public bool Nsfw { get; private set; }
    [JsonProperty] public bool PostingRestrictedToMods { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public bool Removed { get; private set; }
    [JsonProperty] public string Title { get; private set; } = string.Empty;
    [JsonProperty] public string? Updated { get; private set; }
}