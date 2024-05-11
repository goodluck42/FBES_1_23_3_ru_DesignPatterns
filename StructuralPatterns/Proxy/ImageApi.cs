using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace StructuralPatterns.Proxy;

public class ImageApi : IImageApi
{
    private readonly IImageLoader _loader;
    public Action<string> Opener { get; set; }
    
    public ImageApi(IImageLoader loader, Action<string> opener)
    {
        _loader = loader;
        Opener = opener;
    }

    public void OpenImage(string url)
    {
        var image = _loader.Load(url);

        if (image == null)
        {
            throw new ArgumentException("Provided url is not valid");
        }

        var hashedFilename = GetHashedFileName(image.Fullname, url);
        using (var fileStream = new FileStream(hashedFilename, FileMode.Create, FileAccess.Write))
        {
            fileStream.Write(image.Bytes);

            fileStream.Flush();
        }

        Opener(hashedFilename);
        //_ = Process.Start("mspaint", new[] { image.Fullname });
    }

    private static string GetHashedFileName(string fullname, string url)
    {
        var ext = Path.GetExtension(fullname);
        var name = Path.GetFileNameWithoutExtension(fullname);
        var hashBytes = SHA256.HashData(Encoding.UTF8.GetBytes(url));

        return $"{name}_{Convert.ToHexString(hashBytes).ToLower()}{ext}";
    }
}

public class ImageApiProxy : IImageApi
{
    private readonly IImageApi _imageApi;
    
    public ImageApiProxy(IImageApi imageApi)
    {
        _imageApi = imageApi;
    }

    public void OpenImage(string url)
    {
        var files = Directory.GetFiles(Directory.GetCurrentDirectory());
        string? fileFound = null;
        var urlHash = Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(url))).ToLower();
        
        foreach (var file in files)
        {
            var withoutExtension = Path.GetFileNameWithoutExtension(file);
            string fileUrlHash;
            
            try
            {
                fileUrlHash = withoutExtension.Split('_').Last();
            }
            catch (Exception ex) when(ex is ArgumentNullException or InvalidOperationException)
            {
                continue;
            }

            if (urlHash == fileUrlHash)
            {
                fileFound = file;
                break;
            }
        }

        if (fileFound != null)
        {

            Opener(fileFound);
            
            return;
        }
        
        _imageApi.OpenImage(url);
    }

    public Action<string> Opener
    {
        get => _imageApi.Opener;
        set => _imageApi.Opener = value;
    }
}