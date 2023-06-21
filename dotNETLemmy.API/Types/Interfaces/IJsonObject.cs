namespace dotNETLemmy.API.Types;

public interface IJsonObject
{
    public static bool EqualsByJson(IJsonObject a, IJsonObject b)
    {
        return a.Json == b.Json;
    }
    
    public string Json => SerializationUtils.Serialize(this);
}