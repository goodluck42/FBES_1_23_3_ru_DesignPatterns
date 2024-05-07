using System.Text.Json;
using System.Text.Json.Serialization;
using CreationalPatterns.Builder.Models;

namespace CreationalPatterns.Prototype;

public interface ICloneable<T>
    where T : class
{
    T CloneObject();
}

public record CloneablePc : Pc, ICloneable<CloneablePc>
{
    public CloneablePc CloneObject()
    {
        var data = JsonSerializer.Serialize(this, new JsonSerializerOptions()
        {
            WriteIndented = false
        });
        
        return JsonSerializer.Deserialize<CloneablePc>(data)!;
    }
}