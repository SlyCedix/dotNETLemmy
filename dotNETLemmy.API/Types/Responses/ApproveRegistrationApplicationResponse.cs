using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class ApproveRegistrationApplicationResponse : Response
{
    [JsonInclude] public RegistrationApplicationView RegistrationApplication { get; private set; } = null!;
}