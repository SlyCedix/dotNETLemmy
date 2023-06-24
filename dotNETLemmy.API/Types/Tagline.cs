using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class Tagline : IJsonObject
{
    [JsonInclude] public string Content { get; private set; } = string.Empty;
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int LocalSiteId { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public string? Updated { get; private set; }
}