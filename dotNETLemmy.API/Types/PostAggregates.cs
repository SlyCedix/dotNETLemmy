using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PostAggregates : IJsonObject
{
    [JsonProperty] public int Comments { get; private set; }
    [JsonProperty] public int Downvotes { get; private set; }
    [JsonProperty] public bool FeaturedCommunity { get; private set; }
    [JsonProperty] public bool FeaturedLocal { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string NewestCommentTime { get; private set; } = string.Empty;
    [JsonProperty] public string NewestCommentTimeNecro { get; private set; } = string.Empty;
    [JsonProperty] public int PostId { get; private set; }
    [JsonProperty] public int Score { get; private set; }
    [JsonProperty] public int Upvotes { get; private set; }
}