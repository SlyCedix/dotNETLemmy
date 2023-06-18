using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class RegistrationApplicationView
{
    [JsonProperty] public PersonSafe? Admin { get; private set; }
    [JsonProperty] public PersonSafe Creator { get; private set; } = null!;
    [JsonProperty] public LocalUserSettings CreatorLocalUser { get; private set; } = null!;
    [JsonProperty] public RegistrationApplication RegistrationApplication { get; private set; } = null!;
}