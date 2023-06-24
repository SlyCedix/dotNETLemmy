using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetPersonDetailsResponse : Response
{
    [JsonInclude] public CommentView[] Comments { get; private set; } = null!;
    [JsonInclude] public CommunityModeratorView[] Moderates { get; private set; } = null!;
    [JsonInclude] public PersonViewSafe PersonView { get; private set; } = null!;
    [JsonInclude] public PostView[] Posts { get; private set; } = null!;
}