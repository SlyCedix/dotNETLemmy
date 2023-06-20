using System.Runtime.Serialization;

namespace dotNETLemmy.API.Types.Enums;

public enum RegistrationMode
{
    [EnumMember(Value = "closed")] Closed,
    [EnumMember(Value = "open")] Open,

    [EnumMember(Value = "requireapplication")]
    RequireApplication
}