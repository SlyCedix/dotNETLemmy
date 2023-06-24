using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetModlogResponse : Response
{
    [JsonInclude] public ModAddView[] Added { get; private set; } = null!;
    [JsonInclude] public ModAddCommunityView[] AddedToCommunity { get; private set; } = null!;
    [JsonInclude] public AdminPurgeCommentView[] AdminPurgedComments { get; private set; } = null!;
    [JsonInclude] public AdminPurgeCommunityView[] AdminPurgedCommunities { get; private set; } = null!;
    [JsonInclude] public AdminPurgePersonView[] AdminPurgedPersons { get; private set; } = null!;
    [JsonInclude] public AdminPurgePostView[] AdminPurgedPosts { get; private set; } = null!;
    [JsonInclude] public ModBanView[] Banned { get; private set; } = null!;
    [JsonInclude] public ModBanFromCommunityView[] BannedFromCommunity { get; private set; } = null!;
    [JsonInclude] public ModFeaturePostView[] FeaturedPosts { get; private set; } = null!;
    [JsonInclude] public ModLockPostView[] LockedPosts { get; private set; } = null!;
    [JsonInclude] public ModRemoveCommentView[] RemovedComments { get; private set; } = null!;
    [JsonInclude] public ModRemoveCommunityView[] RemovedCommunities { get; private set; } = null!;
    [JsonInclude] public ModRemovePostView[] RemovedPosts { get; private set; } = null!;
    [JsonInclude] public ModTransferCommunityView[] TransferredToCommunity { get; private set; } = null!;
}