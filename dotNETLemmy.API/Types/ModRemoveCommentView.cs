using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class ModRemoveCommentView : IJsonObject
{
    [JsonInclude] public Comment Comment { get; private set; } = null!;
    [JsonInclude] public PersonSafe Commenter { get; private set; } = null!;
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public ModRemoveComment ModRemoveComment { get; private set; } = null!;
    [JsonInclude] public PersonSafe? Moderator { get; private set; }
    [JsonInclude] public Post Post { get; private set; } = null!;
}