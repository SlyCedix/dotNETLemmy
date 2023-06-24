using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CaptchaResponse : IJsonObject
{
    [JsonInclude] public string Png { get; private set; } = string.Empty;
    [JsonInclude] public string Uuid { get; private set; } = string.Empty;
    [JsonInclude] public string? Wav { get; private set; }
}