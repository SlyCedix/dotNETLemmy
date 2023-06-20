using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommunityView
{
    [JsonProperty] public bool Blocked { get; private set; }
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public CommunityAggregates Counts { get; private set; } = null!;
    [JsonProperty] public SubscribedType Subscribed { get; private set; }
}