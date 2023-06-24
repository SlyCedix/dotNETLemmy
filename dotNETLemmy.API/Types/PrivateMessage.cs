using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PrivateMessage : IJsonObject
{
    [JsonInclude] public string ApId { get; private set; } = string.Empty;
    [JsonInclude] public string Content { get; private set; } = string.Empty;
    [JsonInclude] public int CreatorId { get; private set; }
    [JsonInclude] public bool Deleted { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public bool Local { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public bool Read { get; private set; }
    [JsonInclude] public int RecipientId { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}