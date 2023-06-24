using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PostAggregates : IJsonObject
{
    [JsonInclude] public int Comments { get; private set; }
    [JsonInclude] public int Downvotes { get; private set; }
    [JsonInclude] public bool FeaturedCommunity { get; private set; }
    [JsonInclude] public bool FeaturedLocal { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string NewestCommentTime { get; private set; } = string.Empty;
    [JsonInclude] public string NewestCommentTimeNecro { get; private set; } = string.Empty;
    [JsonInclude] public int PostId { get; private set; }
    [JsonInclude] public int Score { get; private set; }
    [JsonInclude] public int Upvotes { get; private set; }
}