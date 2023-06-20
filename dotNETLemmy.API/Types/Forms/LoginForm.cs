namespace dotNETLemmy.API.Types.Forms;

public class LoginForm : IForm
{
    public string UsernameOrEmail { get; init; } = null!;
    public string Password { get; init; } = null!;
    public string EndPoint => "/user/login";
    public HttpMethod Method => HttpMethod.Post;
}