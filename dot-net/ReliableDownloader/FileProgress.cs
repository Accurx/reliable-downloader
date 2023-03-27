using System;

namespace ReliableDownloader;

public record FileProgress(
    long? TotalFileSize,
    long TotalBytesDownloaded,
    double? ProgressPercent,
    TimeSpan? EstimatedRemaining);
