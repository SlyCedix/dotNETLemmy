using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetCommentsResponse : Response
{
    [JsonInclude] public CommentView[] Comments { get; private set; } = null!;
}