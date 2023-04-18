using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableDownloader;

public interface IFileDownloader
{
    /// <summary>Attempts to download a file and write it to the file system.</summary>
    /// <param name="contentFileUrl">The URL of the file to download.</param>
    /// <param name="localFilePath">The file path to persist the downloaded file to.</param>
    /// <param name="onProgressChanged">An action that is invoked with the latest download progress.</param>
    /// <param name="cancellationToken">A cancellation token to cancel the download.</param>
    /// <returns>True if the download completes and writes to the file system successfully, otherwise false.</returns>
    Task<bool> TryDownloadFile(
        string contentFileUrl,
        string localFilePath,
        Action<FileProgress> onProgressChanged,
        CancellationToken cancellationToken);
}