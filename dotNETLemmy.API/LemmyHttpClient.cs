using System.Diagnostics.CodeAnalysis;
using dotNETLemmy.API.Types;
using dotNETLemmy.API.Types.Forms;
using dotNETLemmy.API.Types.Responses;

namespace dotNETLemmy.API;

/// <summary>
///     Helps build Lemmy HTTP Requests.
/// </summary>
/// <seealso cref="IDisposable" />
public class LemmyHttpClient : IDisposable
{
    private bool _disposed; // = false

    /// <summary>
    ///     Initializes a new instance of the <see cref="LemmyHttpClient" /> class
    /// </summary>
    /// <param name="baseUri">Base uri to the lemmy instance</param>
    public LemmyHttpClient(Uri baseUri)
    {
        Client = new HttpClient
        {
            BaseAddress = baseUri
        };
    }

    private HttpClient Client { get; }

    /// <summary>
    ///     Disposes this instance
    /// </summary>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    ///     Sends an asynchronous HTTP request and returns the deserialized response.
    ///     <para>
    ///         Avoid calling directly unless the Lemmy instance requires non-standard API calls.
    ///     </para>
    /// </summary>
    /// <typeparam name="TResponse">Deserialized response format, inherits <see cref="Response" /></typeparam>
    /// <param name="form">The form data to be sent, inherits <see cref="IForm" /></param>
    /// <returns>The deserialized response format</returns>
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public async Task<TResponse> SendAsync<TResponse>(IForm form)
        where TResponse : Response, new()
    {
        var res = await Client.SendAsync(form.ToRequest(Client.BaseAddress!));
        return await Response.FromHttpResponseMessage<TResponse>(res);
    }

    /// <summary>
    ///     Adds an administrator.
    /// </summary>
    /// <param name="form">The form to send for adding an administrator.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after adding an
    ///     administrator.
    /// </returns>
    public Task<AddAdminResponse> AddAdmin(AddAdminForm form) =>
        SendAsync<AddAdminResponse>(form);

    /// <summary>
    ///     Adds a moderator to a community.
    /// </summary>
    /// <param name="form">
    ///     The form to send for adding a moderator to a community.
    /// </param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after adding a
    ///     moderator to a community.
    /// </returns>
    public Task<AddModToCommunityResponse> AddModToCommunity(AddModToCommunityForm form) =>
        SendAsync<AddModToCommunityResponse>(form);

    /// <summary>
    ///     Approves a registration application.
    /// </summary>
    /// <param name="form">
    ///     The form to send for approving a registration application.
    /// </param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after approving
    ///     a registration application.
    /// </returns>
    public Task<ApproveRegistrationApplicationResponse> ApproveRegistrationApplication(ApproveRegistrationApplicationForm form) =>
        SendAsync<ApproveRegistrationApplicationResponse>(form);

    /// <summary>
    ///     Bans a person from a community.
    /// </summary>
    /// <param name="form">The form to send for banning a person from a community.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after banning a
    ///     person from a community.
    /// </returns>
    public Task<BanFromCommunityResponse> BanFromCommunity(BanFromCommunityForm form) =>
        SendAsync<BanFromCommunityResponse>(form);

    /// <summary>
    ///     Bans a person.
    /// </summary>
    /// <param name="form">The form to send for banning a person.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after banning a
    ///     person.
    /// </returns>
    public Task<BanPersonResponse> BanPerson(BanPersonForm form) =>
        SendAsync<BanPersonResponse>(form);

    /// <summary>
    ///     Blocks a community.
    /// </summary>
    /// <param name="form">The form to send for blocking a community.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after blocking
    ///     a community.
    /// </returns>
    public Task<BlockCommunityResponse> BlockCommunity(BlockCommunityForm form) =>
        SendAsync<BlockCommunityResponse>(form);

    /// <summary>
    ///     Blocks a person.
    /// </summary>
    /// <param name="form">The form to send for blocking a person.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after blocking
    ///     a person.
    /// </returns>
    public Task<BlockPersonResponse> BlockPerson(BlockPersonForm form) =>
        SendAsync<BlockPersonResponse>(form);

    /// <summary>
    ///     Changes the password for the current user.
    /// </summary>
    /// <param name="form">The form to send for changing the password.></param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after changing
    ///     the password. <see cref="LoginResponse" />
    /// </returns>
    public Task<LoginResponse> ChangePassword(ChangePasswordForm form) =>
        SendAsync<LoginResponse>(form);

    /// <summary>
    ///     Creates a new comment.
    /// </summary>
    /// <param name="form">The form to send for creating a comment.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a comment. <see cref="CommentResponse" />
    /// </returns>
    public Task<CommentResponse> CreateComment(CreateCommentForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    ///     Creates a new community.
    /// </summary>
    /// <param name="form">The form to send for creating a community.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a community.
    /// </returns>
    public Task<CommunityResponse> CreateCommunity(CreateCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    /// <summary>
    ///     Creates a new post.
    /// </summary>
    /// <param name="form">The form to send for creating a post.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a post.
    /// </returns>
    public Task<PostResponse> CreatePost(CreatePostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    ///     Creates a new report for a post.
    /// </summary>
    /// <param name="form">The form to send for creating a post report.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a post report.
    /// </returns>
    public Task<PostReportResponse> CreatePostReport(CreatePostReportForm form) =>
        SendAsync<PostReportResponse>(form);

    /// <summary>
    ///     Creates a new private message.
    /// </summary>
    /// <param name="form">The form to send for creating a private message.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a private message.
    /// </returns>
    public Task<PrivateMessageResponse> CreatePrivateMessage(CreatePrivateMessageForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    /// <summary>
    ///     Creates a new report for a private message.
    /// </summary>
    /// <param name="form">
    ///     The form to send for creating a private message report.
    /// </param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a private message report.
    /// </returns>
    public Task<PrivateMessageReportResponse> CreatePrivateMessageReport(CreatePrivateMessageReportForm form) =>
        SendAsync<PrivateMessageReportResponse>(form);

    /// <summary>
    ///     Creates a new report for a private message.
    /// </summary>
    /// <param name="form">
    ///     The form to send for creating a private message report.
    /// </param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a private message report.
    /// </returns>
    public Task<SiteResponse> CreateSite(CreateSiteForm form) =>
        SendAsync<SiteResponse>(form);

    /// <summary>
    ///     Deletes a user account.
    /// </summary>
    /// <param name="form">The form to send for deleting a user account.</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after deleting
    ///     a user account.
    /// </returns>
    public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountForm form) =>
        SendAsync<DeleteAccountResponse>(form);

    /// <summary>
    /// Deletes a comment.
    /// </summary>
    /// <param name="form">The form to send for deleting a comment.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the comment.
    /// </returns>
    public Task<CommentResponse> DeleteComment(DeleteCommentForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    /// Deletes a community.
    /// </summary>
    /// <param name="form">The form to send for deleting a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the community.
    /// </returns>
    public Task<CommunityResponse> DeleteCommunity(DeleteCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    /// <summary>
    /// Deletes a post.
    /// </summary>
    /// <param name="form">The form to send for deleting a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the post.
    /// </returns>
    public Task<PostResponse> DeletePost(DeletePostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Deletes a private message.
    /// </summary>
    /// <param name="form">The form to send for deleting a private message.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the private message.
    /// </returns>
    public Task<PrivateMessageResponse> DeletePrivateMessage(DeletePrivateMessageForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    /// <summary>
    /// Edits a comment.
    /// </summary>
    /// <param name="form">The form to send for editing a comment.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the comment.
    /// </returns>
    public Task<CommentResponse> EditComment(EditCommentForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    /// Edits a community.
    /// </summary>
    /// <param name="form">The form to send for editing a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the community.
    /// </returns>
    public Task<CommunityResponse> EditCommunity(EditCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    /// <summary>
    /// Edits a post.
    /// </summary>
    /// <param name="form">The form to send for editing a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the post.
    /// </returns>
    public Task<PostResponse> EditPost(EditPostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Edits a private message.
    /// </summary>
    /// <param name="form">The form to send for editing a private message.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the private message.
    /// </returns>
    public Task<PrivateMessageResponse> EditPrivateMessage(EditPrivateMessageForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    /// <summary>
    /// Edits a site.
    /// </summary>
    /// <param name="form">The form to send for editing a site.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the site.
    /// </returns>
    public Task<SiteResponse> EditSite(EditSiteForm form) =>
        SendAsync<SiteResponse>(form);

    /// <summary>
    /// Features a post.
    /// </summary>
    /// <param name="form">The form to send for featuring a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after featuring the post.
    /// </returns>
    public Task<PostResponse> FeaturePost(FeaturePostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Follows a community.
    /// </summary>
    /// <param name="form">The form to send for following a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after following the community.
    /// </returns>
    public Task<CommunityResponse> FollowCommunity(FollowCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    /// <summary>
    /// Gets the list of banned persons.
    /// </summary>
    /// <param name="form">The form to send for retrieving the list of banned persons.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the list of banned persons.
    /// </returns>
    public Task<BannedPersonsResponse> GetBannedPersons(GetBannedPersonsForm form) =>
        SendAsync<BannedPersonsResponse>(form);

    /// <summary>
    /// Gets a captcha.
    /// </summary>
    /// <param name="form">The form to send for retrieving a captcha.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved captcha.
    /// </returns>
    public Task<GetCaptchaResponse> GetCaptcha(GetCaptchaForm form) =>
        SendAsync<GetCaptchaResponse>(form);

    /// <summary>
    /// Gets comments.
    /// </summary>
    /// <param name="form">The form to send for retrieving comments.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved comments.
    /// </returns>
    public Task<GetCommentsResponse> GetComments(GetCommentsForm form) =>
        SendAsync<GetCommentsResponse>(form);

    /// <summary>
    /// Gets a community.
    /// </summary>
    /// <param name="form">The form to send for retrieving a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved community.
    /// </returns>
    public Task<GetCommunityResponse> GetCommunity(GetCommunityForm form) =>
        SendAsync<GetCommunityResponse>(form);

    /// <summary>
    /// Gets the modlog.
    /// </summary>
    /// <param name="form">The form to send for retrieving the modlog.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved modlog.
    /// </returns>
    public Task<GetModlogResponse> GetModlog(GetModlogForm form) =>
        SendAsync<GetModlogResponse>(form);

    /// <summary>
    /// Gets the details of a person.
    /// </summary>
    /// <param name="form">The form to send for retrieving the person details.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved person details.
    /// </returns>
    public Task<GetPersonDetailsResponse> GetPersonDetails(GetPersonDetailsForm form) =>
        SendAsync<GetPersonDetailsResponse>(form);

    /// <summary>
    /// Gets mentions of a person.
    /// </summary>
    /// <param name="form">The form to send for retrieving the person mentions.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved person mentions.
    /// </returns>
    public Task<GetPersonMentionsResponse> GetPersonMentions(GetPersonMentionsForm form) =>
        SendAsync<GetPersonMentionsResponse>(form);

    /// <summary>
    /// Gets a post.
    /// </summary>
    /// <param name="form">The form to send for retrieving a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved post.
    /// </returns>
    public Task<GetPostResponse> GetPost(GetPostForm form) =>
        SendAsync<GetPostResponse>(form);

    /// <summary>
    /// Gets posts.
    /// </summary>
    /// <param name="form">The form to send for retrieving posts.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved posts.
    /// </returns>
    public Task<GetPostsResponse> GetPosts(GetPostsForm form) =>
        SendAsync<GetPostsResponse>(form);

    /// <summary>
    /// Gets private messages.
    /// </summary>
    /// <param name="form">The form to send for retrieving private messages.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved private messages.
    /// </returns>
    public Task<PrivateMessagesResponse> GetPrivateMessages(GetPrivateMessagesForm form) =>
        SendAsync<PrivateMessagesResponse>(form);

    /// <summary>
    /// Gets replies.
    /// </summary>
    /// <param name="form">The form to send for retrieving replies.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved replies.
    /// </returns>
    public Task<GetRepliesResponse> GetReplies(GetRepliesForm form) =>
        SendAsync<GetRepliesResponse>(form);

    /// <summary>
    /// Gets the count of reports.
    /// </summary>
    /// <param name="form">The form to send for retrieving the report count.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved report count.
    /// </returns>
    public Task<GetReportCountResponse> GetReportCount(GetReportCountForm form) =>
        SendAsync<GetReportCountResponse>(form);

    /// <summary>
    /// Gets a site.
    /// </summary>
    /// <param name="form">The form to send for retrieving a site.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved site.
    /// </returns>
    public Task<GetSiteResponse> GetSite(GetSiteForm form) =>
        SendAsync<GetSiteResponse>(form);

    /// <summary>
    /// Gets site metadata.
    /// </summary>
    /// <param name="form">The form to send for retrieving site metadata.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved site metadata.
    /// </returns>
    public Task<GetSiteMetadataResponse> GetSiteMetadata(GetSiteMetadataForm form) =>
        SendAsync<GetSiteMetadataResponse>(form);

    /// <summary>
    /// Gets the count of unread messages.
    /// </summary>
    /// <param name="form">The form to send for retrieving the unread count.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved unread count.
    /// </returns>
    public Task<GetUnreadCountResponse> GetUnreadCount(GetUnreadCountForm form) =>
        SendAsync<GetUnreadCountResponse>(form);

    /// <summary>
    /// Gets the count of unread registration applications.
    /// </summary>
    /// <param name="form">The form to send for retrieving the unread registration application count.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved unread registration application count.
    /// </returns>
    public Task<GetUnreadRegistrationApplicationCountResponse> GetUnreadRegistrationApplicationCount(
        GetUnreadRegistrationApplicationCountForm form
    ) =>
        SendAsync<GetUnreadRegistrationApplicationCountResponse>(form);

    /// <summary>
    /// Leaves admin role.
    /// </summary>
    /// <param name="form">The form to send for leaving the admin role.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after leaving the admin role.
    /// </returns>
    public Task<GetSiteResponse> LeaveAdmin(LeaveAdminForm form) =>
        SendAsync<GetSiteResponse>(form);

    /// <summary>
    /// Likes a comment.
    /// </summary>
    /// <param name="form">The form to send for liking a comment.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after liking the comment.
    /// </returns>
    public Task<CommentResponse> LikeComment(LikeCommentForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    /// Likes a post.
    /// </summary>
    /// <param name="form">The form to send for liking a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after liking the post.
    /// </returns>
    public Task<PostResponse> LikePost(LikePostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Lists comment reports.
    /// </summary>
    /// <param name="form">The form to send for listing comment reports.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed comment reports.
    /// </returns>
    public Task<ListCommentReportsResponse> ListCommentReports(ListCommentReportsForm form) =>
        SendAsync<ListCommentReportsResponse>(form);

    /// <summary>
    /// Lists communities.
    /// </summary>
    /// <param name="form">The form to send for listing communities.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed communities.
    /// </returns>
    public Task<ListCommunitiesResponse> ListCommunities(ListCommunitiesForm form) =>
        SendAsync<ListCommunitiesResponse>(form);

    /// <summary>
    /// Lists post reports.
    /// </summary>
    /// <param name="form">The form to send for listing post reports.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed post reports.
    /// </returns>
    public Task<ListPostReportsResponse> ListPostReports(ListPostReportsForm form) =>
        SendAsync<ListPostReportsResponse>(form);

    /// <summary>
    /// Lists private message reports.
    /// </summary>
    /// <param name="form">The form to send for listing private message reports.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed private message reports.
    /// </returns>
    public Task<ListPrivateMessageReportsResponse> ListPrivateMessageReports(ListPrivateMessageReportsForm form) =>
        SendAsync<ListPrivateMessageReportsResponse>(form);

    /// <summary>
    /// Lists registration applications.
    /// </summary>
    /// <param name="form">The form to send for listing registration applications.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed registration applications.
    /// </returns>
    public Task<ListRegistrationApplicationsResponse> ListRegistrationApplications(ListRegistrationApplicationsForm form) =>
        SendAsync<ListRegistrationApplicationsResponse>(form);

    /// <summary>
    /// Locks a post.
    /// </summary>
    /// <param name="form">The form to send for locking a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after locking the post.
    /// </returns>
    public Task<PostResponse> LockPost(LockPostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Performs login.
    /// </summary>
    /// <param name="form">The form to send for performing login.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing login.
    /// </returns>
    public Task<LoginResponse> Login(LoginForm form) =>
        SendAsync<LoginResponse>(form);

    /// <summary>
    /// Marks everything as read.
    /// </summary>
    /// <param name="form">The form to send for marking all replies as read.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking all replies as read.
    /// </returns>
    public Task<GetRepliesResponse> MarkAllAsRead(MarkAllAsReadForm form) =>
        SendAsync<GetRepliesResponse>(form);

    /// <summary>
    /// Marks a comment reply as read.
    /// </summary>
    /// <param name="form">The form to send for marking a comment reply as read.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the comment reply as read.
    /// </returns>
    public Task<CommentResponse> MarkCommentReplyAsRead(MarkCommentReplyAsReadForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    /// Marks a person mention as read.
    /// </summary>
    /// <param name="form">The form to send for marking a person mention as read.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the person mention as read.
    /// </returns>
    public Task<PersonMentionResponse> MarkPersonMentionAsRead(MarkPersonMentionAsReadForm form) =>
        SendAsync<PersonMentionResponse>(form);

    /// <summary>
    /// Marks a post as read.
    /// </summary>
    /// <param name="form">The form to send for marking a post as read.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the post as read.
    /// </returns>
    public Task<PostResponse> MarkPostAsRead(MarkPostAsReadForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Marks a private message as read.
    /// </summary>
    /// <param name="form">The form to send for marking a private message as read.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the private message as read.
    /// </returns>
    public Task<PrivateMessageResponse> MarkPrivateMessageAsRead(MarkPrivateMessageAsReadForm form) =>
        SendAsync<PrivateMessageResponse>(form);

    /// <summary>
    /// Performs a password change.
    /// </summary>
    /// <param name="form">The form to send for performing a password change.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing the password change.
    /// </returns>
    public Task<LoginResponse> PasswordChange(PasswordChangeForm form) =>
        SendAsync<LoginResponse>(form);

    /// <summary>
    /// Performs a password reset.
    /// </summary>
    /// <param name="form">The form to send for performing a password reset.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing the password reset.
    /// </returns>
    public Task<PasswordResetResponse> PasswordReset(PasswordResetForm form) =>
        SendAsync<PasswordResetResponse>(form);

    /// <summary>
    /// Purges a comment.
    /// </summary>
    /// <param name="form">The form to send for purging a comment.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the comment.
    /// </returns>
    public Task<PurgeItemResponse> PurgeComment(PurgeCommentForm form) =>
        SendAsync<PurgeItemResponse>(form);

    /// <summary>
    /// Purges a community.
    /// </summary>
    /// <param name="form">The form to send for purging a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the community.
    /// </returns>
    public Task<PurgeItemResponse> PurgeCommunity(PurgeCommunityForm form) =>
        SendAsync<PurgeItemResponse>(form);

    /// <summary>
    /// Purges a person.
    /// </summary>
    /// <param name="form">The form to send for purging a person.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the person.
    /// </returns>
    public Task<PurgeItemResponse> PurgePerson(PurgePersonForm form) =>
        SendAsync<PurgeItemResponse>(form);

    /// <summary>
    /// Purges a post.
    /// </summary>
    /// <param name="form">The form to send for purging a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the post.
    /// </returns>
    public Task<PurgeItemResponse> PurgePost(PurgePostForm form) =>
        SendAsync<PurgeItemResponse>(form);

    /// <summary>
    /// Registers a new account.
    /// </summary>
    /// <param name="form">The form to send for registering a new account.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after registering the account.
    /// </returns>
    public Task<LoginResponse> Register(RegisterForm form) =>
        SendAsync<LoginResponse>(form);

    /// <summary>
    /// Removes a comment.
    /// </summary>
    /// <param name="form">The form to send for removing a comment.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after removing the comment.
    /// </returns>
    public Task<CommentResponse> RemoveComment(RemoveCommentForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    /// Removes a community.
    /// </summary>
    /// <param name="form">The form to send for removing a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after removing the community.
    /// </returns>
    public Task<CommunityResponse> RemoveCommunity(RemoveCommunityForm form) =>
        SendAsync<CommunityResponse>(form);

    /// <summary>
    /// Resolves a comment report.
    /// </summary>
    /// <param name="form">The form to send for resolving a comment report.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the comment report.
    /// </returns>
    public Task<CommentReportResponse> ResolveCommentReport(ResolveCommentReportForm form) =>
        SendAsync<CommentReportResponse>(form);

    /// <summary>
    /// Resolves an object.
    /// </summary>
    /// <param name="form">The form to send for resolving an object.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the object.
    /// </returns>
    public Task<ResolveObjectResponse> ResolveObject(ResolveObjectForm form) =>
        SendAsync<ResolveObjectResponse>(form);

    /// <summary>
    /// Resolves a post report.
    /// </summary>
    /// <param name="form">The form to send for resolving a post report.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the post report.
    /// </returns>
    public Task<PostReportResponse> ResolvePostReport(ResolvePostReportForm form) =>
        SendAsync<PostReportResponse>(form);

    /// <summary>
    /// Resolves a private message report.
    /// </summary>
    /// <param name="form">The form to send for resolving a private message report.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the private message report.
    /// </returns>
    public Task<PrivateMessageReportResponse> ResolvePrivateMessageReport(ResolvePrivateMessageReportForm form) =>
        SendAsync<PrivateMessageReportResponse>(form);

    /// <summary>
    /// Saves a comment.
    /// </summary>
    /// <param name="form">The form to send for saving a comment.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after saving the comment.
    /// </returns>
    public Task<CommentResponse> SaveComment(SaveCommentForm form) =>
        SendAsync<CommentResponse>(form);

    /// <summary>
    /// Saves a post.
    /// </summary>
    /// <param name="form">The form to send for saving a post.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after saving the post.
    /// </returns>
    public Task<PostResponse> SavePost(SavePostForm form) =>
        SendAsync<PostResponse>(form);

    /// <summary>
    /// Saves user settings.
    /// </summary>
    /// <param name="form">The form to send for saving user settings.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after saving the user settings.
    /// </returns>
    public Task<LoginResponse> SaveUserSettings(SaveUserSettingsForm form) =>
        SendAsync<LoginResponse>(form);

    /// <summary>
    /// Performs a search.
    /// </summary>
    /// <param name="form">The form to send for performing a search.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing the search.
    /// </returns>
    public Task<SearchResponse> Search(SearchForm form) =>
        SendAsync<SearchResponse>(form);

    /// <summary>
    /// Transfers a community to another moderator.
    /// </summary>
    /// <param name="form">The form to send for transferring a community.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after transferring the community.
    /// </returns>
    public Task<GetCommunityResponse> TransferCommunity(TransferCommunityForm form) =>
        SendAsync<GetCommunityResponse>(form);

    /// <summary>
    /// Verifies an email for log in.
    /// </summary>
    /// <param name="form">The form to send for verifying an email.</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after verifying the email.
    /// </returns>
    public Task<VerifyEmailResponse> VerifyEmail(VerifyEmailForm form) =>
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