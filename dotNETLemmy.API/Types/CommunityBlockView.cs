using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class CommunityBlockView : IJsonObject
{
    [JsonInclude] public CommunitySafe Community { get; private set; } = null!;
    [JsonInclude] public PersonSafe Person { get; private set; } = null!;
}