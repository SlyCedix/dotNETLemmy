using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetCommentsResponse : Response
{
    [JsonProperty] public CommentView[] Comments { get; private set; } = null!;
}