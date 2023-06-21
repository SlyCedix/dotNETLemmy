using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class PersonBlockView : IJsonObject
{
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
    [JsonProperty] public PersonSafe Target { get; private set; } = null!;
}