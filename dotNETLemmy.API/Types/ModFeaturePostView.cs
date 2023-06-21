using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModFeaturePostView : IJsonObject
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModFeaturePost ModFeaturePost { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
}