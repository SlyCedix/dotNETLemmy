namespace dotNETLemmy.API.Types.Forms;

public class GetSiteMetadataForm : IForm
{
    public string Url { get; set; } = string.Empty;

    public string EndPoint => "/post/site_metadata";
    public HttpMethod Method => HttpMethod.Get;
}