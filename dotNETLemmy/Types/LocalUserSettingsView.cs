using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class LocalUserSettingsView
{
    [JsonProperty] public PersonAggregates Counts { get; private set; } = null!;
    [JsonProperty] public LocalUserSettings LocalUser { get; private set; } = null!;
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
}