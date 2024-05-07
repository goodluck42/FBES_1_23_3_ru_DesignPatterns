namespace CreationalPatterns.FactoryMethod;

public sealed class TextWriterFactory : IWriterFactory
{
    public TextWriterFactory()
    {
        
    }
    
    public IWriter Create(object obj)
    {
        // 
        
        return new TextWriter(obj);
    }
}