using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types;

public class MyUserInfo : IJsonObject
{
    [JsonInclude] public CommunityBlockView[] CommunityBlocks { get; private set; } = null!;
    [JsonInclude] public int[] DiscussionLanguages { get; private set; } = null!;
    [JsonInclude] public CommunityFollowerView[] Follows { get; private set; } = null!;
    [JsonInclude] public LocalUserSettingsView LocalUserView { get; private set; } = null!;
    [JsonInclude] public CommunityModeratorView[] Moderates { get; private set; } = null!;
    [JsonInclude] public PersonBlockView[] PersonBlocks { get; private set; } = null!;
}