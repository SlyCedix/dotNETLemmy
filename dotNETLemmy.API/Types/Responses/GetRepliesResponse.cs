using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetRepliesResponse : Response
{
    [JsonProperty] public CommentReplyView[] Replies { get; private set; } = null!;
}