using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class PostResponse : Response
{
    [JsonProperty] public PostView PostView { get; private set; } = null!;
}