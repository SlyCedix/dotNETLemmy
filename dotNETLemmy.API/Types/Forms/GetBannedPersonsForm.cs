namespace dotNETLemmy.API.Types.Forms;

public class GetBannedPersonsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string EndPoint => "/api/v3/user/banned";
    public HttpMethod Method => HttpMethod.Get;
}