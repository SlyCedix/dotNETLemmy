using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class LoginResponse : Response
{
    [JsonInclude] public string? Jwt { get; init; }
    [JsonInclude] public bool RegistrationCreated { get; init; }
    [JsonInclude] public bool VerifyEmailSent { get; init; }
}