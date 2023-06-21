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
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>The deserialized response format</returns>
    [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
    public async Task<TResponse> SendAsync<TResponse>(IForm form, CancellationToken cancellationToken = default)
        where TResponse : Response, new()
    {
        var req = form.ToRequest(Client.BaseAddress!);
        var res = await Client.SendAsync(req, cancellationToken);
        Console.WriteLine(res);
        return await Response.FromHttpResponseMessage<TResponse>(res);
    }

    /// <summary>
    ///     Adds an administrator.
    /// </summary>
    /// <param name="form">The form to send for adding an administrator.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after adding an
    ///     administrator.
    /// </returns>
    public Task<AddAdminResponse> AddAdmin(AddAdminForm form, CancellationToken cancellationToken = default) =>
        SendAsync<AddAdminResponse>(form, cancellationToken);

    /// <summary>
    ///     Adds a moderator to a community.
    /// </summary>
    /// <param name="form">The form to send for adding a moderator to a community. </param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after adding a
    ///     moderator to a community.
    /// </returns>
    public Task<AddModToCommunityResponse> AddModToCommunity(AddModToCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<AddModToCommunityResponse>(form, cancellationToken);

    /// <summary>
    ///     Approves a registration application.
    /// </summary>
    /// <param name="form">The form to send for approving a registration application.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after approving
    ///     a registration application.
    /// </returns>
    public Task<ApproveRegistrationApplicationResponse> ApproveRegistrationApplication(ApproveRegistrationApplicationForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ApproveRegistrationApplicationResponse>(form, cancellationToken);

    /// <summary>
    ///     Bans a person from a community.
    /// </summary>
    /// <param name="form">The form to send for banning a person from a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after banning a
    ///     person from a community.
    /// </returns>
    public Task<BanFromCommunityResponse> BanFromCommunity(BanFromCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BanFromCommunityResponse>(form, cancellationToken);

    /// <summary>
    ///     Bans a person.
    /// </summary>
    /// <param name="form">The form to send for banning a person.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after banning a
    ///     person.
    /// </returns>
    public Task<BanPersonResponse> BanPerson(BanPersonForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BanPersonResponse>(form, cancellationToken);

    /// <summary>
    ///     Blocks a community.
    /// </summary>
    /// <param name="form">The form to send for blocking a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after blocking
    ///     a community.
    /// </returns>
    public Task<BlockCommunityResponse> BlockCommunity(BlockCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BlockCommunityResponse>(form, cancellationToken);

    /// <summary>
    ///     Blocks a person.
    /// </summary>
    /// <param name="form">The form to send for blocking a person.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after blocking
    ///     a person.
    /// </returns>
    public Task<BlockPersonResponse> BlockPerson(BlockPersonForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BlockPersonResponse>(form, cancellationToken);

    /// <summary>
    ///     Changes the password for the current user.
    /// </summary>
    /// <param name="form">The form to send for changing the password.></param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after changing
    ///     the password. <see cref="LoginResponse" />
    /// </returns>
    public Task<LoginResponse> ChangePassword(ChangePasswordForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new comment.
    /// </summary>
    /// <param name="form">The form to send for creating a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a comment. <see cref="CommentResponse" />
    /// </returns>
    public Task<CommentResponse> CreateComment(CreateCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new community.
    /// </summary>
    /// <param name="form">The form to send for creating a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a community.
    /// </returns>
    public Task<CommunityResponse> CreateCommunity(CreateCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new post.
    /// </summary>
    /// <param name="form">The form to send for creating a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a post.
    /// </returns>
    public Task<PostResponse> CreatePost(CreatePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new report for a post.
    /// </summary>
    /// <param name="form">The form to send for creating a post report.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a post report.
    /// </returns>
    public Task<PostReportResponse> CreatePostReport(CreatePostReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostReportResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new private message.
    /// </summary>
    /// <param name="form">The form to send for creating a private message.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a private message.
    /// </returns>
    public Task<PrivateMessageResponse> CreatePrivateMessage(CreatePrivateMessageForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new report for a private message.
    /// </summary>
    /// <param name="form">The form to send for creating a private message report. </param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a private message report.
    /// </returns>
    public Task<PrivateMessageReportResponse> CreatePrivateMessageReport(CreatePrivateMessageReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageReportResponse>(form, cancellationToken);

    /// <summary>
    ///     Creates a new report for a private message.
    /// </summary>
    /// <param name="form">The form to send for creating a private message report. </param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after creating
    ///     a private message report.
    /// </returns>
    public Task<SiteResponse> CreateSite(CreateSiteForm form, CancellationToken cancellationToken = default) =>
        SendAsync<SiteResponse>(form, cancellationToken);

    /// <summary>
    ///     Deletes a user account.
    /// </summary>
    /// <param name="form">The form to send for deleting a user account.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    ///     The task object representing the asynchronous operation. The task result contains the response after deleting
    ///     a user account.
    /// </returns>
    public Task<DeleteAccountResponse> DeleteAccount(DeleteAccountForm form, CancellationToken cancellationToken = default) =>
        SendAsync<DeleteAccountResponse>(form, cancellationToken);

    /// <summary>
    /// Deletes a comment.
    /// </summary>
    /// <param name="form">The form to send for deleting a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the comment.
    /// </returns>
    public Task<CommentResponse> DeleteComment(DeleteCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    /// Deletes a community.
    /// </summary>
    /// <param name="form">The form to send for deleting a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the community.
    /// </returns>
    public Task<CommunityResponse> DeleteCommunity(DeleteCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    /// <summary>
    /// Deletes a post.
    /// </summary>
    /// <param name="form">The form to send for deleting a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the post.
    /// </returns>
    public Task<PostResponse> DeletePost(DeletePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Deletes a private message.
    /// </summary>
    /// <param name="form">The form to send for deleting a private message.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after deleting the private message.
    /// </returns>
    public Task<PrivateMessageResponse> DeletePrivateMessage(DeletePrivateMessageForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);

    /// <summary>
    /// Edits a comment.
    /// </summary>
    /// <param name="form">The form to send for editing a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the comment.
    /// </returns>
    public Task<CommentResponse> EditComment(EditCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    /// Edits a community.
    /// </summary>
    /// <param name="form">The form to send for editing a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the community.
    /// </returns>
    public Task<CommunityResponse> EditCommunity(EditCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    /// <summary>
    /// Edits a post.
    /// </summary>
    /// <param name="form">The form to send for editing a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the post.
    /// </returns>
    public Task<PostResponse> EditPost(EditPostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Edits a private message.
    /// </summary>
    /// <param name="form">The form to send for editing a private message.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the private message.
    /// </returns>
    public Task<PrivateMessageResponse> EditPrivateMessage(EditPrivateMessageForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);

    /// <summary>
    /// Edits a site.
    /// </summary>
    /// <param name="form">The form to send for editing a site.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after editing the site.
    /// </returns>
    public Task<SiteResponse> EditSite(EditSiteForm form, CancellationToken cancellationToken = default) =>
        SendAsync<SiteResponse>(form, cancellationToken);

    /// <summary>
    /// Features a post.
    /// </summary>
    /// <param name="form">The form to send for featuring a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after featuring the post.
    /// </returns>
    public Task<PostResponse> FeaturePost(FeaturePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Follows a community.
    /// </summary>
    /// <param name="form">The form to send for following a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after following the community.
    /// </returns>
    public Task<CommunityResponse> FollowCommunity(FollowCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    /// <summary>
    /// Gets the list of banned persons.
    /// </summary>
    /// <param name="form">The form to send for retrieving the list of banned persons.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the list of banned persons.
    /// </returns>
    public Task<BannedPersonsResponse> GetBannedPersons(GetBannedPersonsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<BannedPersonsResponse>(form, cancellationToken);

    /// <summary>
    /// Gets a captcha.
    /// </summary>
    /// <param name="form">The form to send for retrieving a captcha.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved captcha.
    /// </returns>
    public Task<GetCaptchaResponse> GetCaptcha(GetCaptchaForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCaptchaResponse>(form, cancellationToken);

    /// <summary>
    /// Gets comments.
    /// </summary>
    /// <param name="form">The form to send for retrieving comments.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved comments.
    /// </returns>
    public Task<GetCommentsResponse> GetComments(GetCommentsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCommentsResponse>(form, cancellationToken);

    /// <summary>
    /// Gets a community.
    /// </summary>
    /// <param name="form">The form to send for retrieving a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved community.
    /// </returns>
    public Task<GetCommunityResponse> GetCommunity(GetCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCommunityResponse>(form, cancellationToken);

    /// <summary>
    /// Gets the modlog.
    /// </summary>
    /// <param name="form">The form to send for retrieving the modlog.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved modlog.
    /// </returns>
    public Task<GetModlogResponse> GetModlog(GetModlogForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetModlogResponse>(form, cancellationToken);

    /// <summary>
    /// Gets the details of a person.
    /// </summary>
    /// <param name="form">The form to send for retrieving the person details.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved person details.
    /// </returns>
    public Task<GetPersonDetailsResponse> GetPersonDetails(GetPersonDetailsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPersonDetailsResponse>(form, cancellationToken);

    /// <summary>
    /// Gets mentions of a person.
    /// </summary>
    /// <param name="form">The form to send for retrieving the person mentions.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved person mentions.
    /// </returns>
    public Task<GetPersonMentionsResponse> GetPersonMentions(GetPersonMentionsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPersonMentionsResponse>(form, cancellationToken);

    /// <summary>
    /// Gets a post.
    /// </summary>
    /// <param name="form">The form to send for retrieving a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved post.
    /// </returns>
    public Task<GetPostResponse> GetPost(GetPostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPostResponse>(form, cancellationToken);

    /// <summary>
    /// Gets posts.
    /// </summary>
    /// <param name="form">The form to send for retrieving posts.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved posts.
    /// </returns>
    public Task<GetPostsResponse> GetPosts(GetPostsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetPostsResponse>(form, cancellationToken);

    /// <summary>
    /// Gets private messages.
    /// </summary>
    /// <param name="form">The form to send for retrieving private messages.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved private messages.
    /// </returns>
    public Task<PrivateMessagesResponse> GetPrivateMessages(GetPrivateMessagesForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessagesResponse>(form, cancellationToken);

    /// <summary>
    /// Gets replies.
    /// </summary>
    /// <param name="form">The form to send for retrieving replies.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved replies.
    /// </returns>
    public Task<GetRepliesResponse> GetReplies(GetRepliesForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetRepliesResponse>(form, cancellationToken);

    /// <summary>
    /// Gets the count of reports.
    /// </summary>
    /// <param name="form">The form to send for retrieving the report count.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved report count.
    /// </returns>
    public Task<GetReportCountResponse> GetReportCount(GetReportCountForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetReportCountResponse>(form, cancellationToken);

    /// <summary>
    /// Gets a site.
    /// </summary>
    /// <param name="form">The form to send for retrieving a site.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved site.
    /// </returns>
    public Task<GetSiteResponse> GetSite(GetSiteForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetSiteResponse>(form, cancellationToken);

    /// <summary>
    /// Gets site metadata.
    /// </summary>
    /// <param name="form">The form to send for retrieving site metadata.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved site metadata.
    /// </returns>
    public Task<GetSiteMetadataResponse> GetSiteMetadata(GetSiteMetadataForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetSiteMetadataResponse>(form, cancellationToken);

    /// <summary>
    /// Gets the count of unread messages.
    /// </summary>
    /// <param name="form">The form to send for retrieving the unread count.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved unread count.
    /// </returns>
    public Task<GetUnreadCountResponse> GetUnreadCount(GetUnreadCountForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetUnreadCountResponse>(form, cancellationToken);

    /// <summary>
    /// Gets the count of unread registration applications.
    /// </summary>
    /// <param name="form">The form to send for retrieving the unread registration application count.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the retrieved unread registration application count.
    /// </returns>
    public Task<GetUnreadRegistrationApplicationCountResponse> GetUnreadRegistrationApplicationCount(
        GetUnreadRegistrationApplicationCountForm form,
        CancellationToken cancellationToken = default
    ) =>
        SendAsync<GetUnreadRegistrationApplicationCountResponse>(form, cancellationToken);

    /// <summary>
    /// Leaves admin role.
    /// </summary>
    /// <param name="form">The form to send for leaving the admin role.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after leaving the admin role.
    /// </returns>
    public Task<GetSiteResponse> LeaveAdmin(LeaveAdminForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetSiteResponse>(form, cancellationToken);

    /// <summary>
    /// Likes a comment.
    /// </summary>
    /// <param name="form">The form to send for liking a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after liking the comment.
    /// </returns>
    public Task<CommentResponse> LikeComment(LikeCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    /// Likes a post.
    /// </summary>
    /// <param name="form">The form to send for liking a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after liking the post.
    /// </returns>
    public Task<PostResponse> LikePost(LikePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Lists comment reports.
    /// </summary>
    /// <param name="form">The form to send for listing comment reports.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed comment reports.
    /// </returns>
    public Task<ListCommentReportsResponse> ListCommentReports(ListCommentReportsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListCommentReportsResponse>(form, cancellationToken);

    /// <summary>
    /// Lists communities.
    /// </summary>
    /// <param name="form">The form to send for listing communities.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed communities.
    /// </returns>
    public Task<ListCommunitiesResponse> ListCommunities(ListCommunitiesForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListCommunitiesResponse>(form, cancellationToken);

    /// <summary>
    /// Lists post reports.
    /// </summary>
    /// <param name="form">The form to send for listing post reports.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed post reports.
    /// </returns>
    public Task<ListPostReportsResponse> ListPostReports(ListPostReportsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListPostReportsResponse>(form, cancellationToken);

    /// <summary>
    /// Lists private message reports.
    /// </summary>
    /// <param name="form">The form to send for listing private message reports.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed private message reports.
    /// </returns>
    public Task<ListPrivateMessageReportsResponse> ListPrivateMessageReports(ListPrivateMessageReportsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListPrivateMessageReportsResponse>(form, cancellationToken);

    /// <summary>
    /// Lists registration applications.
    /// </summary>
    /// <param name="form">The form to send for listing registration applications.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response with the listed registration applications.
    /// </returns>
    public Task<ListRegistrationApplicationsResponse> ListRegistrationApplications(ListRegistrationApplicationsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ListRegistrationApplicationsResponse>(form, cancellationToken);

    /// <summary>
    /// Locks a post.
    /// </summary>
    /// <param name="form">The form to send for locking a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after locking the post.
    /// </returns>
    public Task<PostResponse> LockPost(LockPostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Performs login.
    /// </summary>
    /// <param name="form">The form to send for performing login.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing login.
    /// </returns>
    public Task<LoginResponse> Login(LoginForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);

    /// <summary>
    /// Marks everything as read.
    /// </summary>
    /// <param name="form">The form to send for marking all replies as read.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking all replies as read.
    /// </returns>
    public Task<GetRepliesResponse> MarkAllAsRead(MarkAllAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetRepliesResponse>(form, cancellationToken);

    /// <summary>
    /// Marks a comment reply as read.
    /// </summary>
    /// <param name="form">The form to send for marking a comment reply as read.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the comment reply as read.
    /// </returns>
    public Task<CommentResponse> MarkCommentReplyAsRead(MarkCommentReplyAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    /// Marks a person mention as read.
    /// </summary>
    /// <param name="form">The form to send for marking a person mention as read.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the person mention as read.
    /// </returns>
    public Task<PersonMentionResponse> MarkPersonMentionAsRead(MarkPersonMentionAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PersonMentionResponse>(form, cancellationToken);

    /// <summary>
    /// Marks a post as read.
    /// </summary>
    /// <param name="form">The form to send for marking a post as read.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the post as read.
    /// </returns>
    public Task<PostResponse> MarkPostAsRead(MarkPostAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Marks a private message as read.
    /// </summary>
    /// <param name="form">The form to send for marking a private message as read.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after marking the private message as read.
    /// </returns>
    public Task<PrivateMessageResponse> MarkPrivateMessageAsRead(MarkPrivateMessageAsReadForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageResponse>(form, cancellationToken);

    /// <summary>
    /// Performs a password change.
    /// </summary>
    /// <param name="form">The form to send for performing a password change.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing the password change.
    /// </returns>
    public Task<LoginResponse> PasswordChange(PasswordChangeForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);

    /// <summary>
    /// Performs a password reset.
    /// </summary>
    /// <param name="form">The form to send for performing a password reset.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing the password reset.
    /// </returns>
    public Task<PasswordResetResponse> PasswordReset(PasswordResetForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PasswordResetResponse>(form, cancellationToken);

    /// <summary>
    /// Purges a comment.
    /// </summary>
    /// <param name="form">The form to send for purging a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the comment.
    /// </returns>
    public Task<PurgeItemResponse> PurgeComment(PurgeCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);

    /// <summary>
    /// Purges a community.
    /// </summary>
    /// <param name="form">The form to send for purging a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the community.
    /// </returns>
    public Task<PurgeItemResponse> PurgeCommunity(PurgeCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);

    /// <summary>
    /// Purges a person.
    /// </summary>
    /// <param name="form">The form to send for purging a person.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the person.
    /// </returns>
    public Task<PurgeItemResponse> PurgePerson(PurgePersonForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);

    /// <summary>
    /// Purges a post.
    /// </summary>
    /// <param name="form">The form to send for purging a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after purging the post.
    /// </returns>
    public Task<PurgeItemResponse> PurgePost(PurgePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PurgeItemResponse>(form, cancellationToken);

    /// <summary>
    /// Registers a new account.
    /// </summary>
    /// <param name="form">The form to send for registering a new account.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after registering the account.
    /// </returns>
    public Task<LoginResponse> Register(RegisterForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);

    /// <summary>
    /// Removes a comment.
    /// </summary>
    /// <param name="form">The form to send for removing a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after removing the comment.
    /// </returns>
    public Task<CommentResponse> RemoveComment(RemoveCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    /// Removes a community.
    /// </summary>
    /// <param name="form">The form to send for removing a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after removing the community.
    /// </returns>
    public Task<CommunityResponse> RemoveCommunity(RemoveCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommunityResponse>(form, cancellationToken);

    /// <summary>
    /// Resolves a comment report.
    /// </summary>
    /// <param name="form">The form to send for resolving a comment report.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the comment report.
    /// </returns>
    public Task<CommentReportResponse> ResolveCommentReport(ResolveCommentReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentReportResponse>(form, cancellationToken);

    /// <summary>
    /// Resolves an object.
    /// </summary>
    /// <param name="form">The form to send for resolving an object.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the object.
    /// </returns>
    public Task<ResolveObjectResponse> ResolveObject(ResolveObjectForm form, CancellationToken cancellationToken = default) =>
        SendAsync<ResolveObjectResponse>(form, cancellationToken);

    /// <summary>
    /// Resolves a post report.
    /// </summary>
    /// <param name="form">The form to send for resolving a post report.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the post report.
    /// </returns>
    public Task<PostReportResponse> ResolvePostReport(ResolvePostReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostReportResponse>(form, cancellationToken);

    /// <summary>
    /// Resolves a private message report.
    /// </summary>
    /// <param name="form">The form to send for resolving a private message report.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after resolving the private message report.
    /// </returns>
    public Task<PrivateMessageReportResponse> ResolvePrivateMessageReport(ResolvePrivateMessageReportForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PrivateMessageReportResponse>(form, cancellationToken);

    /// <summary>
    /// Saves a comment.
    /// </summary>
    /// <param name="form">The form to send for saving a comment.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after saving the comment.
    /// </returns>
    public Task<CommentResponse> SaveComment(SaveCommentForm form, CancellationToken cancellationToken = default) =>
        SendAsync<CommentResponse>(form, cancellationToken);

    /// <summary>
    /// Saves a post.
    /// </summary>
    /// <param name="form">The form to send for saving a post.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after saving the post.
    /// </returns>
    public Task<PostResponse> SavePost(SavePostForm form, CancellationToken cancellationToken = default) =>
        SendAsync<PostResponse>(form, cancellationToken);

    /// <summary>
    /// Saves user settings.
    /// </summary>
    /// <param name="form">The form to send for saving user settings.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after saving the user settings.
    /// </returns>
    public Task<LoginResponse> SaveUserSettings(SaveUserSettingsForm form, CancellationToken cancellationToken = default) =>
        SendAsync<LoginResponse>(form, cancellationToken);

    /// <summary>
    /// Performs a search.
    /// </summary>
    /// <param name="form">The form to send for performing a search.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after performing the search.
    /// </returns>
    public Task<SearchResponse> Search(SearchForm form, CancellationToken cancellationToken = default) =>
        SendAsync<SearchResponse>(form, cancellationToken);

    /// <summary>
    /// Transfers a community to another moderator.
    /// </summary>
    /// <param name="form">The form to send for transferring a community.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after transferring the community.
    /// </returns>
    public Task<GetCommunityResponse> TransferCommunity(TransferCommunityForm form, CancellationToken cancellationToken = default) =>
        SendAsync<GetCommunityResponse>(form, cancellationToken);

    /// <summary>
    /// Verifies an email for log in.
    /// </summary>
    /// <param name="form">The form to send for verifying an email.</param>
    /// <param name="cancellationToken">Optional cancellation token to pass through to HttpClient</param>
    /// <returns>
    /// The task object representing the asynchronous operation. The task result contains the response after verifying the email.
    /// </returns>
    public Task<VerifyEmailResponse> VerifyEmail(VerifyEmailForm form, CancellationToken cancellationToken = default) =>
        SendAsync<VerifyEmailResponse>(form, cancellationToken);
    
    private void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
            Client.Dispose();
        _disposed = true;
    }

    ~LemmyHttpClient() { Dispose(false); }
}