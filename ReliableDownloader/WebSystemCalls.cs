using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableDownloader
{
    public class WebSystemCalls : IWebSystemCalls
    {
        private static readonly HttpClient _client = new HttpClient();

        public async Task<HttpResponseMessage> GetHeadersAsync(string url, CancellationToken token)
        {
            return await _client.SendAsync(new HttpRequestMessage(HttpMethod.Head, url), token).ConfigureAwait(continueOnCapturedContext: false);
        }

        public async Task<HttpResponseMessage> DownloadContent(string url, CancellationToken token)
        {
            using (var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                return await _client.SendAsync(httpRequestMessage, token).ConfigureAwait(continueOnCapturedContext: false);
            }
        }

        public async Task<HttpResponseMessage> DownloadPartialContent(string url, long from, long to, CancellationToken token)
        {
            using (var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, url))
            {
                httpRequestMessage.Headers.Range = new RangeHeaderValue(from, to);
                return await _client.SendAsync(httpRequestMessage, token).ConfigureAwait(continueOnCapturedContext: false);
            }
        }
    }
}