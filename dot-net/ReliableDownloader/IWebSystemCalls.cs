using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableDownloader;

public interface IWebSystemCalls
{
    /// <summary>
    /// Makes an HTTP HEAD request to get the response headers for a URL.
    /// </summary>
    /// <param name="url">The URL to make the request to.</param>
    /// <param name="token">A cancellation token to allow request cancellation.</param>
    Task<HttpResponseMessage> GetHeadersAsync(string url, CancellationToken token);

    /// <summary>
    /// Makes an HTTP GET request to download content from a URL.
    /// </summary>
    /// <param name="url">The URL to download content from.</param>
    /// <param name="token">A cancellation token to allow request cancellation.</param>
    Task<HttpResponseMessage> DownloadContentAsync(string url, CancellationToken token);

    /// <summary>
    /// Makes an HTTP GET request with a byte range specified to allow downloading partial content, if supported.
    /// </summary>
    /// <param name="url">The URL to download content from.</param>
    /// <param name="from">The position (in bytes) of the file to start sending data.</param>
    /// <param name="to">The position (in bytes) of the file to stop sending data.</param>
    /// <param name="token">A cancellation token to allow request cancellation.</param>
    Task<HttpResponseMessage> DownloadPartialContentAsync(string url, long from, long to, CancellationToken token);
}