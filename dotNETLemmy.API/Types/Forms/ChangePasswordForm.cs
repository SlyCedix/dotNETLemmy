namespace dotNETLemmy.API.Types.Forms;

public class ChangePasswordForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;
    public string NewPasswordVerify { get; set; } = string.Empty;
    public string OldPassword { get; set; } = string.Empty;
    public string EndPoint => "/api/v3/user/change_password";
    public HttpMethod Method => HttpMethod.Put;
}