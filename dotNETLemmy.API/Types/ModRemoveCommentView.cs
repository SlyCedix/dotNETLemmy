using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class ModRemoveCommentView
{
    [JsonProperty] public Comment Comment { get; private set; } = null!;
    [JsonProperty] public PersonSafe Commenter { get; private set; } = null!;
    [JsonProperty] public CommunitySafe Community { get; private set; } = null!;
    [JsonProperty] public ModRemoveComment ModRemoveComment { get; private set; } = null!;
    [JsonProperty] public PersonSafe? Moderator { get; private set; }
    [JsonProperty] public Post Post { get; private set; } = null!;
}