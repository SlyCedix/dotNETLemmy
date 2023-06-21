using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CaptchaResponse : IJsonObject
{
    [JsonProperty] public string Png { get; private set; } = string.Empty;
    [JsonProperty] public string Uuid { get; private set; } = string.Empty;
    [JsonProperty] public string? Wav { get; private set; }
}