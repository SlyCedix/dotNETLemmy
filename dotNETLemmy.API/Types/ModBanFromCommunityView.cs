using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModBanFromCommunityView : IJsonObject
{
    [JsonProperty] public PersonSafe BannedPerson { get; private set; } = null!;
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModBanFromCommunity ModBanFromCommunity { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
}