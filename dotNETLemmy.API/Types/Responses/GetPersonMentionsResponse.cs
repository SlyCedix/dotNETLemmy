using Newtonsoft.Json;

namespace dotNETLemmy.API.Types.Responses;

public class GetPersonMentionsResponse : Response
{
    [JsonProperty] public PersonMentionView[] Mentions { get; private set; } = null!;
}