using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PostResponse : Response
{
    [JsonProperty] public PostView PostView { get; private set; } = null!;
}