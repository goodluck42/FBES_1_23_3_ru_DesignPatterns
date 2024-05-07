namespace CreationalPatterns.FactoryMethod;

public sealed class JsonWriterFactory : IWriterFactory
{
    public JsonWriterFactory()
    {
        
    }
    
    public IWriter Create(object obj)
    {
        // 
        
        return new JsonWriter(obj);
    }
}