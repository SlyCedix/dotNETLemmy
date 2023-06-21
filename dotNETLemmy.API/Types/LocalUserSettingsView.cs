using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class LocalUserSettingsView : IJsonObject
{
    [JsonProperty] public PersonAggregates Counts { get; private set; } = null!;
    [JsonProperty] public LocalUserSettings LocalUser { get; private set; } = null!;
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
}