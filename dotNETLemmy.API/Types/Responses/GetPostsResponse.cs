using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetPostsResponse : Response
{
    [JsonInclude] public PostView[] Posts { get; private set; } = null!;
}