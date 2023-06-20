using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class AddAdminResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Admins { get; private set; } = null!;
}