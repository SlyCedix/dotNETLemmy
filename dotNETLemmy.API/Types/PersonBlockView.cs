using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class PersonBlockView : IJsonObject
{
    [JsonInclude] public PersonSafe Person { get; private set; } = null!;
    [JsonInclude] public PersonSafe Target { get; private set; } = null!;
}