using System;
using System.Threading.Tasks;

namespace ReliableDownloader
{
    public class FileDownloader : IFileDownloader
    {
        public Task<bool> DownloadFile(string contentFileUrl, string localFilePath, Action<FileProgress> onProgressChanged)
        {
            throw new NotImplementedException();
        }

        public void CancelDownloads()
        {
            throw new NotImplementedException();
        }
    }
}