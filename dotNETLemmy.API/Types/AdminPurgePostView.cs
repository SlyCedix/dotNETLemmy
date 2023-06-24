using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class AdminPurgePostView : IJsonObject
{
    [JsonInclude] public PersonSafe Admin { get; private set; } = null!;
    [JsonInclude] public AdminPurgePost AdminPurgePost { get; private set; } = null!;
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
}