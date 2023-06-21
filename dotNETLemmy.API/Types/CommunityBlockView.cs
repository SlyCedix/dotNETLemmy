using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class CommunityBlockView : IJsonObject
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public PersonSafe Person { get; private set; } = null!;
}