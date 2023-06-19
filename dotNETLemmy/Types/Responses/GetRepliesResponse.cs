using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetRepliesResponse : Response
{
    [JsonProperty] public CommentReplyView[] Replies { get; private set; } = null!;
}