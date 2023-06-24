using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ListRegistrationApplicationsResponse : Response
{
    [JsonInclude] public RegistrationApplicationView[] RegistrationApplications { get; private set; } = null!;
}