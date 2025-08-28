namespace dotNETLemmy.API.Types.Forms;

public class PasswordResetForm : IForm
{
    public string? Auth { get; set; }
    public string Email { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/user/password_reset";
    public HttpMethod Method => HttpMethod.Post;
}