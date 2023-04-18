using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReliableDownloader;

public class FileDownloader : IFileDownloader
{
    public Task<bool> TryDownloadFile(
        string contentFileUrl,
        string localFilePath,
        Action<FileProgress> onProgressChanged,
        CancellationToken cancellationToken) => throw new NotImplementedException();
}