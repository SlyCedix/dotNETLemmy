namespace dotNETLemmy.API.Types.Forms;

public class PasswordResetForm : IForm
{
    public string Email { get; set; } = string.Empty;

    public string EndPoint => "/user/password_reset";
    public HttpMethod Method => HttpMethod.Post;
}