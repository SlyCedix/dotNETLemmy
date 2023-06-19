using Newtonsoft.Json;

namespace dotNetLemmy.Types;

public class GetSiteMetadataResponse : Response
{
    [JsonProperty] public SiteMetadata Metadata { get; private set; } = null!;
}