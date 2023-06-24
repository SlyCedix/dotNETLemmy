using System.Text.Json.Serialization;
using dotNETLemmy.API.Types.Enums;

namespace dotNETLemmy.API.Types;

public class CommentView : IJsonObject
{
    [JsonInclude] public Comment Comment { get; private set; } = null!;
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public CommentAggregates Counts { get; private set; } = null!;
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonInclude] public bool CreatorBlocked { get; private set; }
    [JsonInclude] public int MyVote { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
    [JsonInclude] public bool Saved { get; private set; }
    [JsonInclude] public SubscribedType Subscribed { get; private set; }
}