namespace CreationalPatterns.FactoryMethod;

public class JsonWriter : IWriter
{
    private const string Path = "JSONData.json";

    public JsonWriter(object value)
    {
        
    }
    
    public void Write(string text)
    {
        File.WriteAllText(Path,text);
    }
}