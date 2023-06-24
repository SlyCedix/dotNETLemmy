using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModLockPostView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModLockPost ModLockPost { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
}