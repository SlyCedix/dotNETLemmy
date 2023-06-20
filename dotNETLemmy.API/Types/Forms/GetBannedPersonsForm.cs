namespace dotNETLemmy.API.Types.Forms;

public class GetBannedPersonsForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public string EndPoint => "/user/banned";
    public HttpMethod Method => HttpMethod.Get;
}