using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class LocalUserSettingsView : IJsonObject
{
    [JsonInclude] public PersonAggregates Counts { get; private set; } = null!;
    [JsonInclude] public LocalUserSettings LocalUser { get; private set; } = null!;
    [JsonInclude] public PersonSafe Person { get; private set; } = null!;
}