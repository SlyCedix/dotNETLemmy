using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PrivateMessageReport
{
    [JsonProperty] public int CreatorId { get; private set; }
    [JsonProperty] public int Id { get; private set; }
    [JsonProperty] public string OriginalPmText { get; private set; } = null!;
    [JsonProperty] public int PrivateMessageId { get; private set; }
    [JsonProperty] public string Published { get; private set; } = null!;
    [JsonProperty] public string Reason { get; private set; } = null!;
    [JsonProperty] public bool Resolved { get; private set; }
    [JsonProperty] public int? ResolverId { get; private set; }
    [JsonProperty] public string? Updated { get; private set; }
}