using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PostReport : IJsonObject
{
    [JsonInclude] public int CreatorId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string? OriginalPostBody { get; private set; }
    [JsonInclude] public string OriginalPostName { get; private set; } = string.Empty;
    [JsonInclude] public string? OriginalPostUrl { get; private set; }
    [JsonInclude] public int PostId { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public string Reason { get; private set; } = string.Empty;
    [JsonInclude] public bool Resolved { get; private set; }
    [JsonInclude] public int? ResolverId { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}