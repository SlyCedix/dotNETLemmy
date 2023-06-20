using Newtonsoft.Json;

namespace dotNETLemmy.API.Types;

public class MyUserInfo
{
    [JsonProperty] public CommunityBlockView[] CommunityBlocks { get; private set; } = null!;
    [JsonProperty] public int[] DiscussionLanguages { get; private set; } = null!;
    [JsonProperty] public CommunityFollowerView[] Follows { get; private set; } = null!;
    [JsonProperty] public LocalUserSettingsView LocalUserView { get; private set; } = null!;
    [JsonProperty] public CommunityModeratorView[] Moderates { get; private set; } = null!;
    [JsonProperty] public PersonBlockView[] PersonBlocks { get; private set; } = null!;
}