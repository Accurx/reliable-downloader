package com.accurx.reliabledownloader;

import java.net.http.HttpResponse;
import java.util.concurrent.CompletableFuture;

public interface WebSystemCalls {
    CompletableFuture<HttpResponse<Void>> GetHeaders(String url);

    CompletableFuture<HttpResponse<byte[]>> DownloadContent(String url);

    CompletableFuture<HttpResponse<byte[]>> DownloadPartialContent(String url, long from, long to);
}
