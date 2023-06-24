namespace dotNETLemmy.API.Types.Forms;

public class ApproveRegistrationApplicationForm : IForm
{
    public bool Approve { get; set; }
    public string Auth { get; set; } = string.Empty;
    public string? DenyReason { get; set; }
    public int Id { get; set; }
    public string EndPoint => "/api/v3/admin/registration_application/approve";
    public HttpMethod Method => HttpMethod.Put;
}