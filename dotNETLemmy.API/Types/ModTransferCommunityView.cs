using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModTransferCommunityView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModTransferCommunity ModTransferCommunity { get; private set; } = null!;
    [JsonProperty] public PersonSafe ModdedPerson { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
}