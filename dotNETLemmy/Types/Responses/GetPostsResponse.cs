using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetPostsResponse : Response
{
    [JsonProperty] public PostView[] Posts { get; private set; } = null!;
}