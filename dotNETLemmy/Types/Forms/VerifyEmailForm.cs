namespace dotNetLemmy.Types;

public class VerifyEmailForm : IForm
{
    public string Token { get; set; } = string.Empty;

    public string EndPoint => "/user/verify_email";
    public HttpMethod Method => HttpMethod.Post;
}