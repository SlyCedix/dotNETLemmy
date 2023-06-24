using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetRepliesResponse : Response
{
    [JsonInclude] public CommentReplyView[] Replies { get; private set; } = null!;
}