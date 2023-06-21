using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PersonAggregates : IJsonObject
{
    [JsonProperty] public int CommentCount { get; private set; }
    [JsonProperty] public int CommentScore { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public int PersonId { get; private set; }
    [JsonProperty] public int PostCount { get; private set; }
    [JsonProperty] public int PostScore { get; private set; }
}