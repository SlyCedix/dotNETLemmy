using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommentReportView : IJsonObject
{
    [JsonInclude] public Comment Comment { get; private set; } = null!;
    [JsonInclude] public PersonSafe CommentCreator { get; private set; } = null!;
    [JsonInclude] public CommentReport CommentReport { get; private set; } = null!;
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public CommentAggregates Counts { get; private set; } = null!;
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public bool CreatorBannedFromCommunity { get; private set; }
    [JsonInclude] public int? MyVote { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
    [JsonInclude] public PersonSafe Resolver { get; private set; } = null!;
}