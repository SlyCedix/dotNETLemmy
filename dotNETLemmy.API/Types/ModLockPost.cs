using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModLockPost : IJsonObject
{
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public bool? Locked { get; private set; }
    [JsonInclude] public int ModPersonId { get; private set; }
    [JsonInclude] public int PostId { get; private set; }
    [JsonPropertyName("when_")] public string When { get; private set; } = string.Empty;
}