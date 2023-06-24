using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommentAggregates : IJsonObject
{
    [JsonInclude] public int ChildCount { get; private set; }
    [JsonInclude] public int CommentId { get; private set; }
    [JsonInclude] public int Downvotes { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int Score { get; private set; }
    [JsonInclude] public int Upvotes { get; private set; }
}