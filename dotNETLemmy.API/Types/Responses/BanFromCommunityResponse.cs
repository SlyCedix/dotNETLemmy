using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class BanFromCommunityResponse : Response
{
    [JsonInclude] public bool Banned { get; private set; }
    [JsonInclude] public PersonViewSafe PersonView { get; private set; } = null!;
}