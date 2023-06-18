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
        where TResponse : Response
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

    public Task<ChangePasswordResponse?> ChangePassword(ChangePasswordForm form) =>
        SendAsync<ChangePasswordResponse>(form);

    public Task<CreateCommentResponse?> CreateComment(CreateCommentForm form) =>
        SendAsync<CreateCommentResponse>(form);

    public Task<CreateCommunityResponse?> CreateCommunity(CreateCommunityForm form) =>
        SendAsync<CreateCommunityResponse>(form);

    public Task<CreatePostResponse?> CreatePost(CreatePostForm form) =>
        SendAsync<CreatePostResponse>(form);

    public Task<CreatePostReportResponse?> CreatePostReport(CreatePostReportForm form) =>
        SendAsync<CreatePostReportResponse>(form);

    public Task<CreatePrivateMessageResponse?> CreatePrivateMessage(CreatePrivateMessageForm form) =>
        SendAsync<CreatePrivateMessageResponse>(form);

    public Task<CreatePrivateMessageReportResponse?> CreatePrivateMessageReport(CreatePrivateMessageReportForm form) =>
        SendAsync<CreatePrivateMessageReportResponse>(form);
    
    public Task<CreateSiteResponse?> CreateSite(CreateSiteForm form) =>
        SendAsync<CreateSiteResponse>(form);


    public Task<LoginResponse?> Login(LoginForm form) =>
        SendAsync<LoginResponse>(form);

    private void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
            Client.Dispose();
        _disposed = true;
    }

    ~LemmyHttpClient() { Dispose(false); }
}