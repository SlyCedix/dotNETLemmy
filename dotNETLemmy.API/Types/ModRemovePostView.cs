using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModRemovePostView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModRemovePost ModRemovePost { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
}