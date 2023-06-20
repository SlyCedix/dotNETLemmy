using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class PersonMentionResponse : Response
{
    [JsonProperty] public PersonMentionView PersonMentionView { get; private set; } = null!;
}