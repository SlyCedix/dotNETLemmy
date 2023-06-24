using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class AddAdminResponse : Response
{
    [JsonInclude] public PersonViewSafe[] Admins { get; private set; } = null!;
}