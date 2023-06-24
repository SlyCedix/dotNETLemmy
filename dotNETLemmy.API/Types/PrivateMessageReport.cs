using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PrivateMessageReport : IJsonObject
{
    [JsonInclude] public int CreatorId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string OriginalPmText { get; private set; } = null!;
    [JsonInclude] public int PrivateMessageId { get; private set; }
    [JsonInclude] public string Published { get; private set; } = null!;
    [JsonInclude] public string Reason { get; private set; } = null!;
    [JsonInclude] public bool Resolved { get; private set; }
    [JsonInclude] public int? ResolverId { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}