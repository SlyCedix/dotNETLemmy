using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class AddModToCommunityResponse : Response
{
    [JsonInclude] public CommunityModeratorView[] Moderators { get; private set; } = null!;
}