using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CommunityBlockView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
}