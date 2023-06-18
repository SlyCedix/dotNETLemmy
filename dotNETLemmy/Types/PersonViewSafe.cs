using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PersonViewSafe
{
    [JsonProperty] public PersonAggregates Counts { get; private set; } = null!;
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
}