using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class CommentResponse : Response
{
    [JsonInclude] public CommentView CommentView { get; private set; } = null!;
    [JsonInclude] public string? FormId { get; private set; }
    [JsonInclude] public int[] RecipientIds { get; private set; } = null!;
}