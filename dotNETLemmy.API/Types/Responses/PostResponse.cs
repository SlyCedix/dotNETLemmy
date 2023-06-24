using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class PostResponse : Response
{
    [JsonInclude] public PostView PostView { get; private set; } = null!;
}