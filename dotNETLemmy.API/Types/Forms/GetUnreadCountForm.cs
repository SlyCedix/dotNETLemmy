namespace dotNETLemmy.API.Types.Forms;

public class GetUnreadCountForm : IForm
{
    public string Auth { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/user/unread_count";
    public HttpMethod Method => HttpMethod.Get;
}