using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types;

public class PostView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public PostAggregates Counts { get; private set; } = null!;
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonInclude] public bool CreatorBlocked { get; private set; }
    [JsonInclude] public int? MyVote { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
    [JsonInclude] public bool Read { get; private set; }
    [JsonInclude] public bool Saved { get; private set; }
    [JsonInclude] public SubscribedType Subscribed { get; private set; }
    [JsonInclude] public int UnreadComments { get; private set; }
}