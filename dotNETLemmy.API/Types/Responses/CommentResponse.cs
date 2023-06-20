using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class CommentResponse : Response
{
    [JsonProperty] public CommentView CommentView { get; private set; } = null!;
    [JsonProperty] public string? FormId { get; private set; }
    [JsonProperty] public int[] RecipientIds { get; private set; } = null!;
}