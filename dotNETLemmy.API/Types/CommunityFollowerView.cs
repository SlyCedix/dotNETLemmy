using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommunityFollowerView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PersonSafe Follower { get; private set; } = null!;
}