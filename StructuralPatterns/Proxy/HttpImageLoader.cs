using System.Net;

namespace StructuralPatterns.Proxy;

public class HttpImageLoader : IImageLoader
{
    public ImageInfo? Load(string url)
    {
        var httpClient = new HttpClient();

        var response = httpClient.Send(new HttpRequestMessage()
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url, UriKind.Absolute)
        });

        if (response.StatusCode == HttpStatusCode.OK)
        {
            string extension = string.Empty;
            string name;

            try
            {
                if (response.Content.Headers.ContentType != null)
                {
                    extension = response.Content.Headers.ContentType.ToString().Split('/').Last();
                }
            }
            catch (Exception ex) when (ex is ArgumentException or InvalidOperationException)
            {
            }

            try
            {
                name = Path.GetFileNameWithoutExtension(url);
            }
            catch (Exception ex) when (ex is ArgumentException)
            {
                name = Guid.NewGuid().ToString();
            }

            var fullName = $"{name}.{extension}";

            byte[] bytes = Array.Empty<byte>();

            using var binaryReader = new BinaryReader(response.Content.ReadAsStream());

            if (response.Content.Headers.ContentLength != null)
            {
                bytes = binaryReader.ReadBytes((int)response.Content.Headers.ContentLength);
            }

            return new ImageInfo
            {
                Fullname = fullName,
                Bytes = bytes
            };
        }

        return null;
    }
}