using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommunityFollowerView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PersonSafe Follower { get; private set; } = null!;
}