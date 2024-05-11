namespace StructuralPatterns.Proxy;

public interface IImageApi
{
    void OpenImage(string url);
    
    Action<string> Opener { get; set; }
}