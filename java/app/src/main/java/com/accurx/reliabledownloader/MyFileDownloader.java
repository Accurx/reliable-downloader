package com.accurx.reliabledownloader;

import javax.naming.OperationNotSupportedException;
import java.util.concurrent.CompletableFuture;
import java.util.function.Consumer;
import java.util.function.Function;

public class MyFileDownloader implements FileDownloader
{
    public CompletableFuture<Boolean> DownloadFile(String contentFileUrl, String localFilePath, Consumer<FileProgress> onProgressChanged) {
        throw new RuntimeException("Not yet implemented");
    }

    public void CancelDownloads() {
        throw new RuntimeException("Not yet implemented");
    }
}
