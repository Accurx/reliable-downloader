using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableDownloader
{
    public interface IWebSystemCalls
    {
        /// <summary>Does an HTTP HEAD REST call to just get the headers for a URL</summary>
        Task<HttpResponseMessage> GetHeadersAsync(string url, CancellationToken token);
        /// <summary>
        /// Does a simple HTTP GET to download content from a URL
        /// </summary>
        Task<HttpResponseMessage> DownloadContent(string url, CancellationToken token);
        /// <summary>
        /// Does a HTTP GET but with a range specified to download partial content (if supported)
        /// </summary>
        /// <param name="from">From value, in bytes</param>
        /// <param name="to">From value, in bytes</param>
        /// <returns></returns>
        Task<HttpResponseMessage> DownloadPartialContent(string url, long from, long to, CancellationToken token);
    }
}