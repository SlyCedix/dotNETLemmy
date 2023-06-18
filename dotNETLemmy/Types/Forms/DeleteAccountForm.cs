namespace dotNetLemmy.Types;

public class DeleteAccountForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string EndPoint => "/user/delete_account";
    public HttpMethod Method => HttpMethod.Post;
}