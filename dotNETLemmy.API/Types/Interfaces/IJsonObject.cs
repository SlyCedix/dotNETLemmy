namespace dotNETLemmy.API.Types;

public interface IJsonObject
{
    public string Json => SerializationUtils.Serialize(this);

    public static bool EqualsByJson(IJsonObject a, IJsonObject b) =>
        a.Json == b.Json;
}