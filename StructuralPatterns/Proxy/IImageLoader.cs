namespace StructuralPatterns.Proxy;

public interface IImageLoader
{
    ImageInfo? Load(string url);
}