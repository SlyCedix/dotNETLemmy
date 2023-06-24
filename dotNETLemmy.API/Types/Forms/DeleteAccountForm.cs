namespace dotNETLemmy.API.Types.Forms;

public class DeleteAccountForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string EndPoint => "/api/v3/user/delete_account";
    public HttpMethod Method => HttpMethod.Post;
}