using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class LoginResponse : Response
{
    [JsonProperty] public string? Jwt { get; init; }
    [JsonProperty] public bool RegistrationCreated { get; init; }
    [JsonProperty] public bool VerifyEmailSent { get; init; }
}