using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreatePostResponse : Response
{
    [JsonProperty] public PostView PostView { get; private set; } = null!;
}