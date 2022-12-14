package com.accurx.reliabledownloader;

import java.time.Duration;

public class FileProgress
{
    private final long totalFileSize;
    private final long totalBytesDownloaded;
    private final double progressPercent;
    private final Duration estimatedRemaining;

    public FileProgress(long totalFileSize, long totalBytesDownloaded, double progressPercent, Duration estimatedRemaining) {
        this.totalFileSize = totalFileSize;
        this.totalBytesDownloaded = totalBytesDownloaded;
        this.progressPercent = progressPercent;
        this.estimatedRemaining = estimatedRemaining;
    }

    public long getTotalFileSize() {
        return totalFileSize;
    }

    public long getTotalBytesDownloaded() {
        return totalBytesDownloaded;
    }

    public double getProgressPercent() {
        return progressPercent;
    }

    public Duration getEstimatedRemaining() {
        return estimatedRemaining;
    }

    @Override
    public String toString() {
        return "FileProgress{" +
                "totalFileSize=" + totalFileSize +
                ", totalBytesDownloaded=" + totalBytesDownloaded +
                ", progressPercent=" + progressPercent +
                ", estimatedRemaining=" + estimatedRemaining +
                '}';
    }
}