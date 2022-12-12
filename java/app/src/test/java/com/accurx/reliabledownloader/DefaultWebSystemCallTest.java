package com.accurx.reliabledownloader;

import org.junit.jupiter.api.Test;

import java.io.*;
import java.util.concurrent.ExecutionException;

public class DefaultWebSystemCallTest {

    @Test
    public void When_HeadRequested_HeadersReceived() throws ExecutionException, InterruptedException {
        DefaultWebSystemCall webSystemCall = new DefaultWebSystemCall();
        var future = webSystemCall.GetHeaders("https://installer.demo.accurx.com/chain/3.182.57641.0/accuRx.Installer.Local.msi");
        future.thenApply(it -> {
            System.out.println(it);
            return it;
        }).get();
    }

    @Test
    public void When_GetRequested_ContentReceived() throws ExecutionException, InterruptedException, IOException {
        DefaultWebSystemCall webSystemCall = new DefaultWebSystemCall();

        var stream = new FileOutputStream("full.msi");

        var future = webSystemCall.DownloadContent("https://installer.demo.accurx.com/chain/3.182.57641.0/accuRx.Installer.Local.msi");
        future.thenApply(it -> {
            try {
                stream.write(it.body());
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
            return it;
        }).get();

        stream.close();
    }

    @Test
    public void When_PartialContentRequested_ContentReceived() throws ExecutionException, InterruptedException, IOException {

        //14565376 / 2 = 7282688

        DefaultWebSystemCall webSystemCall = new DefaultWebSystemCall();

        var stream = new FileOutputStream("partial.msi");

        // 0 => 7282688
        var future = webSystemCall.DownloadPartialContent("https://installer.demo.accurx.com/chain/3.182.57641.0/accuRx.Installer.Local.msi", 0, 7282688);
        future.thenApply(it -> {
            try {
                stream.write(it.body());
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
            return it;
        }).get();

        // 7282688 => 14565376
        var future2 = webSystemCall.DownloadPartialContent("https://installer.demo.accurx.com/chain/3.182.57641.0/accuRx.Installer.Local.msi", 7282689, 14565376);
        future2.thenApply(it -> {
            try {
                stream.write(it.body());
            } catch (IOException e) {
                throw new RuntimeException(e);
            }
            return it;
        }).get();

        stream.close();

    }

}
