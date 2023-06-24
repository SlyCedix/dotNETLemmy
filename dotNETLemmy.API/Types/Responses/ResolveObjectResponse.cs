using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ResolveObjectResponse : Response
{
    [JsonInclude] public CommentView? Comment { get; private set; }
    [JsonInclude] public CommunityView? Community { get; private set; }
    [JsonInclude] public PersonViewSafe? Person { get; private set; }
    [JsonInclude] public PostView? Post { get; private set; }
}