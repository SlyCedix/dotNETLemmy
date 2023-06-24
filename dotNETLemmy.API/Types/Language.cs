using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class Language : IJsonObject
{
    [JsonInclude] public string Code { get; private set; } = string.Empty;
    [JsonInclude] public int Id { get; private set; }
    [JsonInclude] public string Name { get; private set; } = string.Empty;
}