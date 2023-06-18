using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommentReportView
{
    [JsonProperty] public Comment Comment { get; private set; } = null!;
    [JsonProperty] public PersonSafe CommentCreator { get; private set; } = null!;
    [JsonProperty] public CommentReport CommentReport { get; private set; } = null!;
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public CommentAggregates Counts { get; private set; } = null!;
    [JsonProperty] public PersonSafe Creator { get; private set; } = null!;
    [JsonProperty] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonProperty] public int? MyVote { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
    [JsonProperty] public PersonSafe Resolver { get; private set; } = null!;
}