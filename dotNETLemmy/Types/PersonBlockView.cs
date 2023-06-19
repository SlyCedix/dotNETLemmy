using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PersonBlockView
{
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
    [JsonProperty] public PersonSafe Target { get; private set; } = null!;
}