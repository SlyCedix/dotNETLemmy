namespace dotNetLemmy.Types;

public class FeaturePostForm : IForm
{
    public string Auth { get; set; } = string.Empty;
    public PostFeatureType FeatureType { get; set; }
    public bool Featured { get; set; }
    public int PostId { get; set; }
    public string EndPoint => "/post/feature";
    public HttpMethod Method => HttpMethod.Post;
}