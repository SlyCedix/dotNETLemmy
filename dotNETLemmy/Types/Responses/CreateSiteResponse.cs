using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class CreateSiteResponse : Response
{
    [JsonProperty] public SiteView SiteView { get; private set; } = null!;
}