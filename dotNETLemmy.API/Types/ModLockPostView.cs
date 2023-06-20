using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModLockPostView
{
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModLockPost ModLockPost { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
}