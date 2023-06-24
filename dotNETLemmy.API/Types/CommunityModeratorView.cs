using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommunityModeratorView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public PersonSafe Moderator { get; private set; } = null!;
}