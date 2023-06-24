using System.Text.Json.Serialization;

namespace dotNETLemmy.API.Types.Responses;

public class GetPersonMentionsResponse : Response
{
    [JsonInclude] public PersonMentionView[] Mentions { get; private set; } = null!;
}