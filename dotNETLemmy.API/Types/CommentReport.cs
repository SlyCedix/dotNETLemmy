using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommentReport : IJsonObject
{
    [JsonInclude] public int CommentId { get; private set; }
    [JsonInclude] public int CreatorId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string OriginalCommentText { get; private set; } = string.Empty;
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public string Reason { get; private set; } = string.Empty;
    [JsonInclude] public bool Resolved { get; private set; }
    [JsonInclude] public int? ResolverId { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}