package com.accurx.reliabledownloader;

import org.springframework.web.reactive.function.client.WebClient;

public interface WebSystemCalls {
    WebClient.ResponseSpec GetHeaders(String url);

    WebClient.ResponseSpec DownloadContent(String url);

    WebClient.ResponseSpec DownloadPartialContent(String url, long from, long to);
}
