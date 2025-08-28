namespace dotNETLemmy.API.Types.Forms;

public class GetSiteMetadataForm : IForm
{
    public string? Auth { get; set; }
    public string Url { get; set; } = string.Empty;

    public string EndPoint => "/api/v3/post/site_metadata";
    public HttpMethod Method => HttpMethod.Get;
}