using dotNetLemmy.Types;

namespace dotNetLemmy;

public class LemmyHttpClient : IDisposable
{
    private bool _disposed; // = false

    public LemmyHttpClient(Uri baseUri)
    {
        Client = new HttpClient
        {
            BaseAddress = baseUri
        };
    }

    private HttpClient Client { get; }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public async Task<TResponse?> SendAsync<TResponse>(IForm form)
        where TResponse : Response, new()
    {
        var res = await Client.SendAsync(form.ToRequest(Client.BaseAddress!));
        return await Response.FromHttpResponseMessage<TResponse>(res);
    }

    public Task<AddAdminResponse?> AddAdmin(AddAdminForm form) =>
        SendAsync<AddAdminResponse>(form);

    public Task<AddModToCommunityResponse?> AddModToCommunity(AddModToCommunityForm form) =>
        SendAsync<AddModToCommunityResponse>(form);

    public Task<ApproveRegistrationApplicationResponse?> ApproveRegistrationApplication(ApproveRegistrationApplicationForm form) =>
        SendAsync<ApproveRegistrationApplicationResponse>(form);

    public Task<BanFromCommunityResponse?> BanFromCommunity(BanFromCommunityForm form) =>
        SendAsync<BanFromCommunityResponse>(form);

    public Task<BanPersonResponse?> BanPerson(BanPersonForm form) =>
        SendAsync<BanPersonResponse>(form);

    public Task<BlockCommunityResponse?> BlockCommunity(BlockCommunityForm form) =>
        SendAsync<BlockCommunityResponse>(form);

    public Task<BlockPersonResponse?> BlockPerson(BlockPersonForm form) =>
        SendAsync<BlockPersonResponse>(form);

    public Task<LoginResponse?> ChangePassword(ChangePasswordForm form) =>
        SendAsync<LoginResponse>(form);

    public Task<CommentResponse?> CreateComment(CreateCommentForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<CommunityResponse?> CreateCommunity(CreateCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    public Task<PostResponse?> CreatePost(CreatePostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<PostReportResponse?> CreatePostReport(CreatePostReportForm form) =>
        SendAsync<PostReportResponse>(form);

    public Task<PrivateMessageResponse?> CreatePrivateMessage(CreatePrivateMessageForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    public Task<PrivateMessageReportResponse?> CreatePrivateMessageReport(CreatePrivateMessageReportForm form) =>
        SendAsync<PrivateMessageReportResponse>(form);
    
    public Task<SiteResponse?> CreateSite(CreateSiteForm form) =>
        SendAsync<SiteResponse>(form);

    public Task<DeleteAccountResponse?> DeleteAccount(DeleteAccountForm form) =>
        SendAsync<DeleteAccountResponse>(form);

    public Task<CommentResponse?> DeleteComment(DeleteCommentForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<CommunityResponse?> DeleteCommunity(DeleteCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    public Task<PostResponse?> DeletePost(DeletePostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<PrivateMessageResponse?> DeletePrivateMessage(DeletePrivateMessageForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    public Task<CommentResponse?> EditComment(EditCommentForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<CommunityResponse?> EditCommunity(EditCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    public Task<PostResponse?> EditPost(EditPostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<PrivateMessageResponse?> EditPrivateMessage(EditPrivateMessageForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    public Task<SiteResponse?> EditSite(EditSiteForm form) =>
        SendAsync<SiteResponse>(form);

    public Task<PostResponse?> FeaturePost(FeaturePostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<CommunityResponse?> FollowCommunity(FollowCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    public Task<BannedPersonsResponse?> GetBannedPersons(GetBannedPersonsForm form) =>
        SendAsync<BannedPersonsResponse>(form);

    public Task<GetCaptchaResponse?> GetCaptcha(GetCaptchaForm form) =>
        SendAsync<GetCaptchaResponse>(form);

    public Task<GetCommentsResponse?> GetComments(GetCommentsForm form) =>
        SendAsync<GetCommentsResponse>(form);

    public Task<GetCommunityResponse?> GetCommunity(GetCommunityForm form) =>
        SendAsync<GetCommunityResponse>(form);

    public Task<GetModlogResponse?> GetModlog(GetModlogForm form) =>
        SendAsync<GetModlogResponse>(form);

    public Task<GetPersonDetailsResponse?> GetPersonDetails(GetPersonDetailsForm form) =>
        SendAsync<GetPersonDetailsResponse>(form);

    public Task<GetPersonMentionsResponse?> GetPersonMentions(GetPersonMentionsForm form) =>
        SendAsync<GetPersonMentionsResponse>(form);

    public Task<GetPostResponse?> GetPost(GetPostForm form) =>
        SendAsync<GetPostResponse>(form);

    public Task<GetPostsResponse?> GetPosts(GetPostsForm form) =>
        SendAsync<GetPostsResponse>(form);

    public Task<PrivateMessagesResponse?> GetPrivateMessages(GetPrivateMessagesForm form) =>
        SendAsync<PrivateMessagesResponse>(form);

    public Task<GetRepliesResponse?> GetReplies(GetRepliesForm form) =>
        SendAsync<GetRepliesResponse>(form);

    public Task<GetReportCountResponse?> GetReportCount(GetReportCountForm form) =>
        SendAsync<GetReportCountResponse>(form);

    public Task<GetSiteResponse?> GetSite(GetSiteForm form) =>
        SendAsync<GetSiteResponse>(form);

    public Task<GetSiteMetadataResponse?> GetSiteMetadata(GetSiteMetadataForm form) =>
        SendAsync<GetSiteMetadataResponse>(form);

    public Task<GetUnreadCountResponse?> GetUnreadCount(GetUnreadCountForm form) =>
        SendAsync<GetUnreadCountResponse>(form);

    public Task<GetUnreadRegistrationApplicationCountResponse?> GetUnreadRegistrationApplicationCount(GetUnreadRegistrationApplicationCountForm form) =>
        SendAsync<GetUnreadRegistrationApplicationCountResponse>(form);

    public Task<GetSiteResponse?> LeaveAdmin(LeaveAdminForm form) =>
        SendAsync<GetSiteResponse>(form);

    public Task<CommentResponse?> LikeComment(LikeCommentForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<PostResponse?> LikePost(LikePostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<ListCommentReportsResponse?> ListCommentReports(ListCommentReportsForm form) =>
        SendAsync<ListCommentReportsResponse>(form);

    public Task<ListCommunitiesResponse?> ListCommunities(ListCommunitiesForm form) =>
        SendAsync<ListCommunitiesResponse>(form);

    public Task<ListPostReportsResponse?> ListPostReports(ListPostReportsForm form) =>
        SendAsync<ListPostReportsResponse>(form);

    public Task<ListPrivateMessageReportsResponse?> ListPrivateMessageReports(ListPrivateMessageReportsForm form) =>
        SendAsync<ListPrivateMessageReportsResponse>(form);

    public Task<ListRegistrationApplicationsResponse?> ListRegistrationApplications(ListRegistrationApplicationsForm form) =>
        SendAsync<ListRegistrationApplicationsResponse>(form);

    public Task<PostResponse?> LockPost(LockPostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<LoginResponse?> Login(LoginForm form) =>
        SendAsync<LoginResponse>(form);

    public Task<GetRepliesResponse?> MarkAllAsRead(MarkAllAsReadForm form) =>
        SendAsync<GetRepliesResponse>(form);

    public Task<CommentResponse?> MarkCommentReplyAsRead(MarkCommentReplyAsReadForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<PersonMentionResponse?> MarkPersonMentionAsRead(MarkPersonMentionAsReadForm form) =>
        SendAsync<PersonMentionResponse>(form);

    public Task<PostResponse?> MarkPostAsRead(MarkPostAsReadForm form) =>
        SendAsync<PostResponse>(form);

    public Task<PrivateMessageResponse?> MarkPrivateMessageAsRead(MarkPrivateMessageAsReadForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    public Task<LoginResponse?> PasswordChange(PasswordChangeForm form) =>
        SendAsync<LoginResponse>(form);

    public Task<PasswordResetResponse?> PasswordReset(PasswordResetForm form) =>
        SendAsync<PasswordResetResponse>(form);

    public Task<PurgeItemResponse?> PurgeComment(PurgeCommentForm form) =>
        SendAsync<PurgeItemResponse>(form);

    public Task<PurgeItemResponse?> PurgeCommunity(PurgeCommunityForm form) =>
        SendAsync<PurgeItemResponse>(form);

    public Task<PurgeItemResponse?> PurgePerson(PurgePersonForm form) =>
        SendAsync<PurgeItemResponse>(form);
    
    public Task<PurgeItemResponse?> PurgePost(PurgePostForm form) =>
        SendAsync<PurgeItemResponse>(form);
    
    public Task<LoginResponse?> Register(RegisterForm form) =>
        SendAsync<LoginResponse>(form);

    public Task<CommentResponse?> RemoveComment(RemoveCommentForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<CommunityResponse?> RemoveCommunity(RemoveCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    public Task<CommentReportResponse?> ResolveCommentReport(ResolveCommentReportForm form) =>
        SendAsync<CommentReportResponse>(form);

    public Task<ResolveObjectResponse?> ResolveObject(ResolveObjectForm form) =>
        SendAsync<ResolveObjectResponse>(form);

    public Task<PostReportResponse?> ResolvePostReport(ResolvePostReportForm form) =>
        SendAsync<PostReportResponse>(form);

    public Task<PrivateMessageReportResponse?> ResolvePrivateMessageReport(ResolvePrivateMessageReportForm form) =>
        SendAsync<PrivateMessageReportResponse>(form);

    public Task<CommentResponse?> SaveComment(SaveCommentForm form) =>
        SendAsync<CommentResponse>(form);

    public Task<PostResponse?> SavePost(SavePostForm form) =>
        SendAsync<PostResponse>(form);

    public Task<LoginResponse?> SaveUserSettings(SaveUserSettingsForm form) =>
        SendAsync<LoginResponse>(form);

    public Task<SearchResponse?> Search(SearchForm form) =>
        SendAsync<SearchResponse>(form);

    public Task<GetCommunityResponse?> TransferCommunity(TransferCommunityForm form) =>
        SendAsync<GetCommunityResponse>(form);

    public Task<VerifyEmailResponse?> VerifyEmail(VerifyEmailForm form) =>
        SendAsync<VerifyEmailResponse>(form);
    
    private void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
            Client.Dispose();
        _disposed = true;
    }

    ~LemmyHttpClient() { Dispose(false); }
}