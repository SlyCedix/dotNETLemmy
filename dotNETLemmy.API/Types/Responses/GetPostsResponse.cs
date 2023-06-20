using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetPostsResponse : Response
{
    [JsonProperty] public PostView[] Posts { get; private set; } = null!;
}