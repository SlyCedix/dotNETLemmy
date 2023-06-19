using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetModlogResponse : Response
{
    [JsonProperty] public ModAddView[] Added { get; private set; } = null!;
    [JsonProperty] public ModAddCommunityView[] AddedToCommunity { get; private set; } = null!;
    [JsonProperty] public AdminPurgeCommentView[] AdminPurgedComments { get; private set; } = null!;
    [JsonProperty] public AdminPurgeCommunityView[] AdminPurgedCommunities { get; private set; } = null!;
    [JsonProperty] public AdminPurgePersonView[] AdminPurgedPersons { get; private set; } = null!;
    [JsonProperty] public AdminPurgePostView[] AdminPurgedPosts { get; private set; } = null!;
    [JsonProperty] public ModBanView[] Banned { get; private set; } = null!;
    [JsonProperty] public ModBanFromCommunityView[] BannedFromCommunity { get; private set; } = null!;
    [JsonProperty] public ModFeaturePostView[] FeaturedPosts { get; private set; } = null!;
    [JsonProperty] public ModLockPostView[] LockedPosts { get; private set; } = null!;
    [JsonProperty] public ModRemoveCommentView[] RemovedComments { get; private set; } = null!;
    [JsonProperty] public ModRemoveCommunityView[] RemovedCommunities { get; private set; } = null!;
    [JsonProperty] public ModRemovePostView[] RemovedPosts { get; private set; } = null!;
    [JsonProperty] public ModTransferCommunityView[] TransferredToCommunity { get; private set; } = null!;
}