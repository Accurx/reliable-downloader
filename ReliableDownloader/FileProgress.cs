using System;

namespace ReliableDownloader
{
    public class FileProgress
    {
        public FileProgress(long? totalFileSize, long totalBytesDownloaded, double? progressPercent, TimeSpan? estimatedRemaining)
        {
            TotalFileSize = totalFileSize;
            TotalBytesDownloaded = totalBytesDownloaded;
            ProgressPercent = progressPercent;
            EstimatedRemaining = estimatedRemaining;
        }

        public long? TotalFileSize { get; }
        public long TotalBytesDownloaded { get; }
        public double? ProgressPercent { get; }
        public TimeSpan? EstimatedRemaining { get; }
    }
}