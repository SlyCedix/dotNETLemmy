using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModBanFromCommunity : IJsonObject
{
    [JsonInclude] public bool? Banned { get; private set; }
    [JsonInclude] public int CommunityId { get; private set; }
    [JsonInclude] public string? Expires { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int ModPersonId { get; private set; }
    [JsonInclude] public int OtherPersonId { get; private set; }
    [JsonInclude] public string? Reason { get; private set; }
    [JsonPropertyName("when_")] public string When { get; private set; } = string.Empty;
}