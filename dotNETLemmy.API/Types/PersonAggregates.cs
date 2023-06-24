using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PersonAggregates : IJsonObject
{
    [JsonInclude] public int CommentCount { get; private set; }
    [JsonInclude] public int CommentScore { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int PersonId { get; private set; }
    [JsonInclude] public int PostCount { get; private set; }
    [JsonInclude] public int PostScore { get; private set; }
}