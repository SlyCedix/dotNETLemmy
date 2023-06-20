using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetPersonDetailsResponse : Response
{
    [JsonProperty] public CommentView[] Comments { get; private set; } = null!;
    [JsonProperty] public CommunityModeratorView[] Moderates { get; private set; } = null!;
    [JsonProperty] public PersonViewSafe PersonView { get; private set; } = null!;
    [JsonProperty] public PostView[] Posts { get; private set; } = null!;
}