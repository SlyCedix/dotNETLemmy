using System.Runtime.Serialization;

namespace dotNetLemmy.Types;

public enum RegistrationMode
{
    [EnumMember(Value = "closed")] Closed,
    [EnumMember(Value = "open")] Open,

    [EnumMember(Value = "requireapplication")]
    RequireApplication
}