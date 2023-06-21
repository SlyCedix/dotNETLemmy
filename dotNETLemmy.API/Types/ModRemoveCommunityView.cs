using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModRemoveCommunityView : IJsonObject
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModRemoveCommunity ModRemoveCommunity { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
}