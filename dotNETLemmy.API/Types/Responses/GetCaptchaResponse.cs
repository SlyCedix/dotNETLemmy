using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetCaptchaResponse : Response
{
    [JsonProperty] public CaptchaResponse? Ok { get; private set; }
}