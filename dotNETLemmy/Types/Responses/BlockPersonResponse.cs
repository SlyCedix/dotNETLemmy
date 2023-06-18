using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class BlockPersonResponse : Response
{
    [JsonProperty]
    public bool Blocked { get; private set; }

    [JsonProperty]
    public PersonViewSafe PersonView { get; private set; } = null!;
}