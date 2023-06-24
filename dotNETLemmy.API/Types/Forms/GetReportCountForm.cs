namespace dotNETLemmy.API.Types.Forms;

public class GetReportCountForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public int? CommunityId { get; set; }

    public string EndPoint => "/api/v3/user/report_count";
    public HttpMethod Method => HttpMethod.Get;
}