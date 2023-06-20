using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class BanPersonResponse : Response
{
    [JsonProperty]
    public bool Banned { get; private set; }

    [JsonProperty]
    public PersonViewSafe PersonView { get; private set; } = null!;
}