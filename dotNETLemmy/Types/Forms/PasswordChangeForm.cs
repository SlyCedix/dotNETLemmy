namespace dotNetLemmy.Types;

public class PasswordChangeForm : IForm
{
    public string Password { get; set; } = string.Empty;
    public string PasswordVerify { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;

    public string EndPoint => "/user/password_change";
    public HttpMethod Method => HttpMethod.Post;
}