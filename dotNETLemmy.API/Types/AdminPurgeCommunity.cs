using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class AdminPurgeCommunity : IJsonObject
{
    [JsonInclude] public int AdminPersonId { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string? Reason { get; private set; }
    [JsonPropertyName("when_")] public string When { get; private set; } = string.Empty;
}