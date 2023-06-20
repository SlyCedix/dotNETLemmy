using dotNETLemmy.API.Types.Enums;
using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PostView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PostAggregates Counts { get; private set; } = null!;
    [JsonProperty] public PersonSafe Creator { get; private set; } = null!;
    [JsonProperty] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonProperty] public bool CreatorBlocked { get; private set; }
    [JsonProperty] public int? MyVote { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
    [JsonProperty] public bool Read { get; private set; }
    [JsonProperty] public bool Saved { get; private set; }
    [JsonProperty] public SubscribedType Subscribed { get; private set; }
    [JsonProperty] public int UnreadComments { get; private set; }
}