namespace dotNETLemmy.API.Types.Forms;

public class GetUnreadRegistrationApplicationCountForm : IForm
{
    public string Auth { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/admin/registration_application/count";
    public HttpMethod Method => HttpMethod.Get;
}