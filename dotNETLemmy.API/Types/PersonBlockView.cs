using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PersonBlockView
{
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
    [JsonProperty] public PersonSafe Target { get; private set; } = null!;
}