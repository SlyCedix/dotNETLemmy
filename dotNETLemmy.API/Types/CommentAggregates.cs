using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommentAggregates
{
    [JsonProperty] public int ChildCount { get; private set; }
    [JsonProperty] public int CommentId { get; private set; }
    [JsonProperty] public int Downvotes { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int Score { get; private set; }
    [JsonProperty] public int Upvotes { get; private set; }
}