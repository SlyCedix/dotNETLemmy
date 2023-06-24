using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModFeaturePost : IJsonObject
{
    [JsonInclude] public bool Featured { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public bool IsFeaturedCommunity { get; private set; }
    [JsonInclude] public int ModPersonId { get; private set; }
    [JsonInclude] public int PostId { get; private set; }
    [JsonPropertyName("when_")] public string When { get; private set; } = string.Empty;
}