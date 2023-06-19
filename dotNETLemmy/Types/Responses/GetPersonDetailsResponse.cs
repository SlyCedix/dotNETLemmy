using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetPersonDetailsResponse : Response
{
    [JsonProperty] public CommentView[] Comments { get; private set; } = null!;
    [JsonProperty] public CommunityModeratorView[] Moderates { get; private set; } = null!;
    [JsonProperty] public PersonViewSafe PersonView { get; private set; } = null!;
    [JsonProperty] public PostView[] posts { get; private set; } = null!;
}