using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PersonMention
{
    [JsonProperty] public int CommentId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public bool Read { get; private set; }
    [JsonProperty] public int RecipientId { get; private set; }
}