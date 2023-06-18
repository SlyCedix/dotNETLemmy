namespace dotNetLemmy.Types;

public class GetUnreadRegistrationApplicationCountForm : IForm
{
    public string Auth { get; set; } = string.Empty;

    public string EndPoint => "/admin/registration_application/count";
    public HttpMethod Method => HttpMethod.Get;
}