using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class SiteResponse : Response
{
    [JsonProperty] public SiteView SiteView { get; private set; } = null!;
}