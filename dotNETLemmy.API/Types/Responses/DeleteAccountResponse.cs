using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class DeleteAccountResponse : Response
{
    [JsonProperty] public PersonViewSafe[] Banned { get; private set; } = null!;
}