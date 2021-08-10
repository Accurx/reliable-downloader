using System;
using System.Threading.Tasks;

namespace ReliableDownloader
{
    public interface IFileDownloader
    {
        /// <summary>Downloads a file, trying to use reliable downloading if possible</summary>
        /// <param name="contentFileUrl">The url which the file is hosted at</param>
        /// <param name="localFilePath">The local file path to save the file to</param>
        /// <param name="onProgressChanged">An action to call which prints progress</param>
        /// <returns>True or false, depending on if download completes and writes to file system okay</returns>
        Task<bool> DownloadFile(string contentFileUrl, string localFilePath, Action<FileProgress> onProgressChanged);
        
        /// <summary>
        /// Cancels any in progress downloads
        /// </summary>
        void CancelDownloads();
    }
}