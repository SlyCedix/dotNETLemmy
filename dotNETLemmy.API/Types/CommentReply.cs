using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommentReply : IJsonObject
{
    [JsonInclude] public int CommentId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string Published { get; private set; } = null!;
    [JsonInclude] public bool Read { get; private set; }
    [JsonInclude] public int RecipientId { get; private set; }
}