using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PersonMention : IJsonObject
{
    [JsonInclude] public int CommentId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public bool Read { get; private set; }
    [JsonInclude] public int RecipientId { get; private set; }
}