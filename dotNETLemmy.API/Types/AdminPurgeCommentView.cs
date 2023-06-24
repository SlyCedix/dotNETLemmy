using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class AdminPurgeCommentView : IJsonObject
{
    [JsonInclude] public PersonSafe? Admin { get; private set; }
    [JsonInclude] public AdminPurgeComment AdminPurgeComment { get; private set; } = null!;
    [JsonInclude] public Post Post { get; private set; } = null!;
}