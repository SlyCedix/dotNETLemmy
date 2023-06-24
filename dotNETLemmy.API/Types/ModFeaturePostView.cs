using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModFeaturePostView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModFeaturePost ModFeaturePost { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
}