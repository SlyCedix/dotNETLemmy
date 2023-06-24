using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModRemoveComment : IJsonObject
{
    [JsonInclude] public int CommentId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int ModPersonId { get; private set; }
    [JsonInclude] public string? Reason { get; private set; }
    [JsonInclude] public bool? Removed { get; private set; }
    [JsonPropertyName("when_")] public string When { get; private set; } = string.Empty;
}