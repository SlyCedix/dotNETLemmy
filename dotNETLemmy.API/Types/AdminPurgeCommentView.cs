using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class AdminPurgeCommentView
{
    [JsonProperty] public PersonSafe? Admin { get; private set; }
    [JsonProperty] public AdminPurgeComment AdminPurgeComment { get; private set; } = null!;
    [JsonProperty] public Post Post { get; private set; } = null!;
}