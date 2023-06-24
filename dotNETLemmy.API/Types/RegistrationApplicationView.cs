using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class RegistrationApplicationView : IJsonObject
{
    [JsonInclude] public PersonSafe? Admin { get; private set; }
    [JsonInclude] public PersonSafe Creator { get; private set; } = null!;
    [JsonInclude] public LocalUserSettings CreatorLocalUser { get; private set; } = null!;
    [JsonInclude] public RegistrationApplication RegistrationApplication { get; private set; } = null!;
}