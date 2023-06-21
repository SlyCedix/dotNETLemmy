using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModRemovePostView : IJsonObject
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModRemovePost ModRemovePost { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
}