using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class SiteMetadata : IJsonObject
{
    [JsonInclude] public string? Description { get; private set; }
    [JsonInclude] public string? Html { get; private set; }
    [JsonInclude] public string? Image { get; private set; }
    [JsonInclude] public string? Title { get; private set; }
}