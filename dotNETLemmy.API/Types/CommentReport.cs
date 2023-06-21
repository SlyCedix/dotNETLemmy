using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommentReport : IJsonObject
{
    [JsonProperty] public int CommentId { get; private set; }
    [JsonProperty] public int CreatorId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string OriginalCommentText { get; private set; } = string.Empty;
    [JsonProperty] public string Published { get; private set; } = string.Empty;
    [JsonProperty] public string Reason { get; private set; } = string.Empty;
    [JsonProperty] public bool Resolved { get; private set; }
    [JsonProperty] public int? ResolverId { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}