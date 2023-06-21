using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommentReply : IJsonObject
{
    [JsonProperty] public int CommentId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string Published { get; private set; } = null!;
    [JsonProperty] public bool Read { get; private set; }
    [JsonProperty] public int RecipientId { get; private set; }
}