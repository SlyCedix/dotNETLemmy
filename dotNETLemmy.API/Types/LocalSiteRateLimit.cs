using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class LocalSiteRateLimit : IJsonObject
{
    [JsonInclude] public int Comment { get; private set; }
    [JsonInclude] public int CommentPerSecond { get; private set; }
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public int Image { get; private set; }
    [JsonInclude] public int ImagePerSecond { get; private set; }
    [JsonInclude] public int LocalSiteId { get; private set; }
    [JsonInclude] public int Message { get; private set; }
    [JsonInclude] public int MessagePerSecond { get; private set; }
    [JsonInclude] public int Post { get; private set; }
    [JsonInclude] public int PostPerSecond { get; private set; }
    [JsonInclude] public string Published { get; private set; } = string.Empty;
    [JsonInclude] public int Register { get; private set; }
    [JsonInclude] public int RegisterPerSecond { get; private set; }
    [JsonInclude] public int Search { get; private set; }
    [JsonInclude] public int SearchPerSecond { get; private set; }
    [JsonInclude] public string? Updated { get; private set; }
}