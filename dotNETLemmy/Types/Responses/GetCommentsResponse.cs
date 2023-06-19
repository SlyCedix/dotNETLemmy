using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetCommentsResponse : Response
{
    [JsonProperty] public CommentView[] Comments { get; private set; } = null!;
}