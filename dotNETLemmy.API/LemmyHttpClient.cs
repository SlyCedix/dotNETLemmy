using dotNETLemmy.API.Types;
using dotNETLemmy.API.Types.Forms;
using dotNETLemmy.API.Types.Responses;

namespace dotNETLemmy.API;

/// <summary>
///     Helps build Lemmy HTTP Requests.
/// </summary>
/// <seealso cref="IDisposable" />
/// <inheritdoc/>
public sealed class LemmyHttpClient : ILemmyHttpClient
{
    private class LemmyHttpClientException : HttpRequestException {}
    
    public string BaseAddress { get; set; } = string.Empty;
    private HttpClient? Client { get; }
    private IHttpClientFactory? HttpClientFactory { get; }
    
    /// <summary>
    ///     Initializes a new instance of the <see cref="LemmyHttpClient" /> class
    ///     <para>
    ///         Intended to be used as an <see cref="IHttpClientFactory"/> typed client
    ///     </para>
    /// </summary>
    /// <param name="client"><see cref="HttpClient"/> to use for making requests</param>
    public LemmyHttpClient(HttpClient client)
    {
        Client = client;
    }

    public async Task<TResponse> SendAsync<TResponse>(IForm form, CancellationToken cancellationToken = default)
        where TResponse : Response, new()
    {
        if ((Client ?? HttpClientFactory?.CreateClient()) is not { } client)
        {
            throw new LemmyHttpClientException();
        }
        
        var req = form.ToRequest(BaseAddress);
        var res = await client.SendAsync(req, cancellationToken);
        return await Response.FromHttpResponseMessage<TResponse>(res);
    }
    
    public Task<AddAdminResponse> AddAdmin(AddAdminForm form, CancellationToken cancellationToken = default) =>
        SendAsync<AddAdminResponse>(form, cancellationToken);
    
    public Task<AddModToCommunityResponse> AddModToCommunity(AddModToCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<AddModToCommunityResponse>(form, cancellationToken);
    
    public Task<ApproveRegistrationApplicationResponse> ApproveRegistrationApplication(ApproveRegistrationApplicationForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ApproveRegistrationApplicationResponse>(form, cancellationToken);
    
    public Task<BanFromCommunityResponse> BanFromCommunity(BanFromCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BanFromCommunityResponse>(form, cancellationToken);
    
    public Task<BanPersonResponse> BanPerson(BanPersonForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BanPersonResponse>(form, cancellationToken);
    
    public Task<BlockCommunityResponse> BlockCommunity(BlockCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BlockCommunityResponse>(form, cancellationToken);
    
    public Task<BlockPersonResponse> BlockPerson(BlockPersonForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BlockPersonResponse>(form, cancellationToken);
    
    public Task<LoginResponse> ChangePassword(ChangePasswordForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);
    
    public Task<CommentResponse> CreateComment(CreateCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);
    
    public Task<CommunityResponse> CreateCommunity(CreateCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);
    
    public Task<PostResponse> CreatePost(CreatePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);
    
    public Task<PostReportResponse> CreatePostReport(CreatePostReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostReportResponse>(form, cancellationToken);
    
    public Task<PrivateMessageResponse> CreatePrivateMessage(CreatePrivateMessageForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);
    
    public Task<PrivateMessageReportResponse> CreatePrivateMessageReport(CreatePrivateMessageReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageReportResponse>(form, cancellationToken);
    
    public Task<SiteResponse> CreateSite(CreateSiteForm form, CancellationToken cancellationToken = default) =>
        SendAsync<SiteResponse>(form, cancellationToken);
    
    public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountForm form, CancellationToken cancellationToken = default) =>
        SendAsync<DeleteAccountResponse>(form, cancellationToken);
    
    public Task<CommentResponse> DeleteComment(DeleteCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);
    
    public Task<CommunityResponse> DeleteCommunity(DeleteCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);
    
    public Task<PostResponse> DeletePost(DeletePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);
    
    public Task<PrivateMessageResponse> DeletePrivateMessage(DeletePrivateMessageForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);
    
    public Task<CommentResponse> EditComment(EditCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);
    
    public Task<CommunityResponse> EditCommunity(EditCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);
    
    public Task<PostResponse> EditPost(EditPostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    public Task<PrivateMessageResponse> EditPrivateMessage(EditPrivateMessageForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);

    public Task<SiteResponse> EditSite(EditSiteForm form, CancellationToken cancellationToken = default) =>
        SendAsync<SiteResponse>(form, cancellationToken);

    public Task<PostResponse> FeaturePost(FeaturePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    public Task<CommunityResponse> FollowCommunity(FollowCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    public Task<BannedPersonsResponse> GetBannedPersons(GetBannedPersonsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BannedPersonsResponse>(form, cancellationToken);

    public Task<GetCaptchaResponse> GetCaptcha(GetCaptchaForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCaptchaResponse>(form, cancellationToken);

    public Task<GetCommentsResponse> GetComments(GetCommentsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCommentsResponse>(form, cancellationToken);

    public Task<GetCommunityResponse> GetCommunity(GetCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCommunityResponse>(form, cancellationToken);

    public Task<GetModlogResponse> GetModlog(GetModlogForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetModlogResponse>(form, cancellationToken);

    public Task<GetPersonDetailsResponse> GetPersonDetails(GetPersonDetailsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPersonDetailsResponse>(form, cancellationToken);

    public Task<GetPersonMentionsResponse> GetPersonMentions(GetPersonMentionsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPersonMentionsResponse>(form, cancellationToken);

    public Task<GetPostResponse> GetPost(GetPostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPostResponse>(form, cancellationToken);

    public Task<GetPostsResponse> GetPosts(GetPostsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPostsResponse>(form, cancellationToken);

    public Task<PrivateMessagesResponse> GetPrivateMessages(GetPrivateMessagesForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessagesResponse>(form, cancellationToken);

    public Task<GetRepliesResponse> GetReplies(GetRepliesForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetRepliesResponse>(form, cancellationToken);

    public Task<GetReportCountResponse> GetReportCount(GetReportCountForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetReportCountResponse>(form, cancellationToken);

    public Task<GetSiteResponse> GetSite(GetSiteForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetSiteResponse>(form, cancellationToken);

    public Task<GetSiteMetadataResponse> GetSiteMetadata(GetSiteMetadataForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetSiteMetadataResponse>(form, cancellationToken);

    public Task<GetUnreadCountResponse> GetUnreadCount(GetUnreadCountForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetUnreadCountResponse>(form, cancellationToken);

    public Task<GetUnreadRegistrationApplicationCountResponse> GetUnreadRegistrationApplicationCount(
        GetUnreadRegistrationApplicationCountForm form,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<GetUnreadRegistrationApplicationCountResponse>(form, cancellationToken);

    public Task<GetSiteResponse> LeaveAdmin(LeaveAdminForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetSiteResponse>(form, cancellationToken);

    public Task<CommentResponse> LikeComment(LikeCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    public Task<PostResponse> LikePost(LikePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    public Task<ListCommentReportsResponse> ListCommentReports(ListCommentReportsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListCommentReportsResponse>(form, cancellationToken);
    
    public Task<ListCommunitiesResponse> ListCommunities(ListCommunitiesForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListCommunitiesResponse>(form, cancellationToken);

    public Task<ListPostReportsResponse> ListPostReports(ListPostReportsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListPostReportsResponse>(form, cancellationToken);

    public Task<ListPrivateMessageReportsResponse> ListPrivateMessageReports(ListPrivateMessageReportsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListPrivateMessageReportsResponse>(form, cancellationToken);
    
    public Task<ListRegistrationApplicationsResponse> ListRegistrationApplications(ListRegistrationApplicationsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListRegistrationApplicationsResponse>(form, cancellationToken);
    
    public Task<PostResponse> LockPost(LockPostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);
    
    public Task<LoginResponse> Login(LoginForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);
    
    public Task<GetRepliesResponse> MarkAllAsRead(MarkAllAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetRepliesResponse>(form, cancellationToken);
    
    public Task<CommentResponse> MarkCommentReplyAsRead(MarkCommentReplyAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);
    
    public Task<PersonMentionResponse> MarkPersonMentionAsRead(MarkPersonMentionAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PersonMentionResponse>(form, cancellationToken);
    
    public Task<PostResponse> MarkPostAsRead(MarkPostAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);
    
    public Task<PrivateMessageResponse> MarkPrivateMessageAsRead(MarkPrivateMessageAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);
    
    public Task<LoginResponse> PasswordChange(PasswordChangeForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);
    
    public Task<PasswordResetResponse> PasswordReset(PasswordResetForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PasswordResetResponse>(form, cancellationToken);

    public Task<PurgeItemResponse> PurgeComment(PurgeCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);
    
    public Task<PurgeItemResponse> PurgeCommunity(PurgeCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);
    
    public Task<PurgeItemResponse> PurgePerson(PurgePersonForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);

    public Task<PurgeItemResponse> PurgePost(PurgePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);

    public Task<LoginResponse> Register(RegisterForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);
    
    public Task<CommentResponse> RemoveComment(RemoveCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);
    
    public Task<CommunityResponse> RemoveCommunity(RemoveCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    public Task<CommentReportResponse> ResolveCommentReport(ResolveCommentReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentReportResponse>(form, cancellationToken);
    
    public Task<ResolveObjectResponse> ResolveObject(ResolveObjectForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ResolveObjectResponse>(form, cancellationToken);
    
    public Task<PostReportResponse> ResolvePostReport(ResolvePostReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostReportResponse>(form, cancellationToken);
    
    public Task<PrivateMessageReportResponse> ResolvePrivateMessageReport(ResolvePrivateMessageReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageReportResponse>(form, cancellationToken);
    
    public Task<CommentResponse> SaveComment(SaveCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);
    
    public Task<PostResponse> SavePost(SavePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);
    
    public Task<LoginResponse> SaveUserSettings(SaveUserSettingsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);
    
    public Task<SearchResponse> Search(SearchForm form, CancellationToken cancellationToken = default) =>
        SendAsync<SearchResponse>(form, cancellationToken);
    
    public Task<GetCommunityResponse> TransferCommunity(TransferCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCommunityResponse>(form, cancellationToken);

    public Task<VerifyEmailResponse> VerifyEmail(VerifyEmailForm form, CancellationToken cancellationToken = default) =>
        SendAsync<VerifyEmailResponse>(form, cancellationToken);
}