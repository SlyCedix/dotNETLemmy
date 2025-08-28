namespace dotNETLemmy.API.Types.Forms;

public class VerifyEmailForm : IForm
{
    public string? Auth { get; set; }
    public string Token { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/user/verify_email";
    public HttpMethod Method => HttpMethod.Post;
}