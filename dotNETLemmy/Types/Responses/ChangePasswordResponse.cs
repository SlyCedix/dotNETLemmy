using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ChangePasswordResponse : Response
{
    [JsonProperty]
    private string? Jwt { get; init; }

    [JsonProperty]
    public bool RegistrationCreated { get; init; }

    [JsonProperty]
    public bool VerifyEmailSent { get; init; }
}