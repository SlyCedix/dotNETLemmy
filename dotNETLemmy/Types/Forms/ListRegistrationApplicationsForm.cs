namespace dotNetLemmy.Types;

public class ListRegistrationApplicationsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? Limit { get; set; }
    public int? Page { get; set; }
    public bool? UnreadOnly { get; set; }

    public string EndPoint => "/admin/registration_application/list";
    public HttpMethod Method => HttpMethod.Get;
}