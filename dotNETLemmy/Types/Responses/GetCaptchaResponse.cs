using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetCaptchaResponse : Response
{
    [JsonProperty] public CaptchaResponse? Ok { get; private set; }
}