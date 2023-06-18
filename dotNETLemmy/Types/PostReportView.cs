using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PostReportView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PostAggregates Counts { get; private set; } = null!;
    [JsonProperty] public PersonSafe Creator { get; private set; } = null!;
    [JsonProperty] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonProperty] public int? MyVote { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
    [JsonProperty] public PersonSafe PostCreator { get; private set; } = null!;
    [JsonProperty] public PostReport PostReport { get; private set; } = null!;
    [JsonProperty] public PersonSafe Resolver { get; private set; } = null!;
}