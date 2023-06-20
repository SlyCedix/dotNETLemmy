using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class SiteResponse : Response
{
    [JsonProperty] public SiteView SiteView { get; private set; } = null!;
}