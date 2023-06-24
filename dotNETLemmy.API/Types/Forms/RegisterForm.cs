namespace dotNETLemmy.API.Types.Forms;

public class RegisterForm : IForm
{
    public string? Answer { get; set; }
    public string? CaptchaAnswer { get; set; }
    public string? CaptchaUuid { get; set; }
    public string? Email { get; set; }
    public string? Honeypot { get; set; }
    public string Password { get; set; } = string.Empty;
    public string PasswordVerify { get; set; } = string.Empty;
    public bool ShowNsfw { get; set; }
    public string Username { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/user/register";
    public HttpMethod Method => HttpMethod.Post;
}