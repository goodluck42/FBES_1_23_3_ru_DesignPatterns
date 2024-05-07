namespace CreationalPatterns.FactoryMethod;

public class TextWriter : IWriter
{
    private const string Path = "TextData.txt";

    public TextWriter(object value)
    {
        
    }
    
    public void Write(string text)
    {
        File.WriteAllText(Path,text);
    }
}