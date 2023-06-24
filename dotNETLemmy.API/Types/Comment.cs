using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class Comment : IJsonObject
{
    [JsonInclude] public string ApId { get; private set; } = string.Empty;
    [JsonInclude] public string Content { get; private set; } = string.Empty;
    [JsonInclude] public int CreatorId { get; private set; }
    [JsonInclude] public bool Deleted { get; private set; }
    [JsonInclude] public bool Distinguished { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int LanguageId { get; private set; }
    [JsonInclude] public bool Local { get; private set; }
    [JsonInclude] public string Path { get; private set; } = string.Empty;
    [JsonInclude] public int PostId { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public bool Removed { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}