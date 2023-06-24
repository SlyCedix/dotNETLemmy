using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class SiteResponse : Response
{
    [JsonInclude] public SiteView SiteView { get; private set; } = null!;
}