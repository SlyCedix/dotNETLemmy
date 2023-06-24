using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class BlockPersonResponse : Response
{
    [JsonInclude] public bool Blocked { get; private set; }

    [JsonInclude] public PersonViewSafe PersonView { get; private set; } = null!;
}