using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreateCommentResponse : Response
{
    [JsonProperty] public CommentView CommentView { get; private set; } = null!;
    [JsonProperty] public string? FormId { get; private set; }
    [JsonProperty] public int[] RecipientIds { get; private set; } = null!;
}