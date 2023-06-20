using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModAddCommunityView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModAddCommunity ModAddCommunity { get; private set; } = null!;
    [JsonProperty] public PersonSafe ModdedPerson { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
}