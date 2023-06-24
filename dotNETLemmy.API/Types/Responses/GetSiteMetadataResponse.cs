using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetSiteMetadataResponse : Response
{
    [JsonInclude] public SiteMetadata Metadata { get; private set; } = null!;
}