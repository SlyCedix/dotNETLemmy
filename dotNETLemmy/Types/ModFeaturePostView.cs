using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class ModFeaturePostView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModFeaturePost ModFeaturePost { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
}