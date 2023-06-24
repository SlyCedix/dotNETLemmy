using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PostReportView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public PostAggregates Counts { get; private set; } = null!;
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonInclude] public int? MyVote { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
    [JsonInclude] public PersonSafe PostCreator { get; private set; } = null!;
    [JsonInclude] public PostReport PostReport { get; private set; } = null!;
    [JsonInclude] public PersonSafe Resolver { get; private set; } = null!;
}