namespace dotNETLemmy.API.Types.Forms;

public class LeaveAdminForm : IForm
{
    public string Auth { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/user/leave_admin";
    public HttpMethod Method => HttpMethod.Post;
}