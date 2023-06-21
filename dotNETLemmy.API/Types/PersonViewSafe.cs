using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PersonViewSafe : IJsonObject
{
    [JsonProperty] public PersonAggregates Counts { get; private set; } = null!;
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
}