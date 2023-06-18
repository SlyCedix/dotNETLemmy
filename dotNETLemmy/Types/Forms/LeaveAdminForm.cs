namespace dotNetLemmy.Types;

public class LeaveAdminForm : IForm
{
    public string Auth { get; set; } = string.Empty;

    public string EndPoint => "/user/leave_admin";
    public HttpMethod Method => HttpMethod.Post;
}