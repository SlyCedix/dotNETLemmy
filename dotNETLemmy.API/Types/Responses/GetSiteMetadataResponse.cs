using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetSiteMetadataResponse : Response
{
    [JsonProperty] public SiteMetadata Metadata { get; private set; } = null!;
}