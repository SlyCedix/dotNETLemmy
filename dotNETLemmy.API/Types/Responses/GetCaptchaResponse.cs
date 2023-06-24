using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetCaptchaResponse : Response
{
    [JsonInclude] public CaptchaResponse? Ok { get; private set; }
}