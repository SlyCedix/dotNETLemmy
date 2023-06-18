using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class BanFromCommunityResponse : Response
{
    [JsonProperty] public bool Banned { get; private set; }
    [JsonProperty] public PersonViewSafe PersonView { get; private set; } = null!;
}